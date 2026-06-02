using Oracle.ManagedDataAccess.Client;

namespace HospitalSystem.Data;


// MODELO: datos del usuario que inició sesión
// Se llena al hacer login y se usa en toda la aplicación

public class UsuarioSesion
{
    public int    UsrId      { get; set; }
    public string UsrNombre  { get; set; } = "";
    public int    SesId      { get; set; }
    public string RolNombre  { get; set; } = "";
}


// SERVICIO DE USUARIOS Y LOGIN
// Verifica credenciales y crea la sesión en la base de datos

public static class UsuarioService
{
    // Guarda el usuario activo mientras la app está corriendo
    public static UsuarioSesion? UsuarioActivo { get; private set; }

    
    // LOGIN: verifica usuario y contraseña contra la BD
    // La contraseña llega como texto plano y se convierte a MD5
    // porque así se guardó en la tabla usuarios
    // Regresa true si el login fue exitoso
    
    public static bool Login(string usuario, string password)
    {
        try
        {
            // Convertir contraseña a MD5 igual que como está en la BD
            string passwordMd5 = ConvertirMd5(password).ToUpper();

            using var conn = OracleDb.Conectar();

            // Verificar que el usuario y contraseña existan
            string sqlVerificar = @"
                SELECT u.usr_id, u.usr_nombre, r.rol_nombre
                FROM   usuarios u
                INNER JOIN usuarios_roles ur ON (ur.usr_id = u.usr_id)
                INNER JOIN roles          r  ON (r.rol_id  = ur.rol_id)
                WHERE  u.usr_nombre = :usuario
                  AND  u.usr_pwd    = :password";

            using var cmd = new OracleCommand(sqlVerificar, conn);
            cmd.Parameters.Add("usuario",  OracleDbType.Varchar2).Value = usuario;
            cmd.Parameters.Add("password", OracleDbType.Char).Value     = passwordMd5;

            using var reader = cmd.ExecuteReader();

            if (!reader.Read())
                return false; // Usuario o contraseña incorrectos

            int    usrId     = reader.GetInt32(0);
            string usrNombre = reader.GetString(1);
            string rolNombre = reader.GetString(2);
            reader.Close();

            // Crear sesión en la tabla sesiones
            string token = Guid.NewGuid().ToString("N").ToUpper()[..32];

            string sqlSesion = @"
                INSERT INTO sesiones (ses_token, ses_inicio, ses_ultima_actividad, ses_ip, usr_id)
                VALUES (:token, SYSDATE, SYSDATE, :ip, :usr_id)
                RETURNING ses_id INTO :ses_id";

            using var cmdSesion = new OracleCommand(sqlSesion, conn);
            cmdSesion.Parameters.Add("token",  OracleDbType.Char).Value     = token;
            cmdSesion.Parameters.Add("ip",     OracleDbType.Varchar2).Value = "127.0.0.1";
            cmdSesion.Parameters.Add("usr_id", OracleDbType.Int32).Value    = usrId;

            var paramSesId = new OracleParameter("ses_id", OracleDbType.Int32)
            {
                Direction = System.Data.ParameterDirection.Output
            };
            cmdSesion.Parameters.Add(paramSesId);
            cmdSesion.ExecuteNonQuery();

            int sesId = Convert.ToInt32(paramSesId.Value.ToString());

            // Actualizar la última sesión del usuario
            string sqlUpdate = "UPDATE usuarios SET ses_id = :ses_id WHERE usr_id = :usr_id";
            using var cmdUpdate = new OracleCommand(sqlUpdate, conn);
            cmdUpdate.Parameters.Add("ses_id", OracleDbType.Int32).Value = sesId;
            cmdUpdate.Parameters.Add("usr_id", OracleDbType.Int32).Value = usrId;
            cmdUpdate.ExecuteNonQuery();

            

            // Guardar en memoria el usuario activo
            UsuarioActivo = new UsuarioSesion
            {
                UsrId     = usrId,
                UsrNombre = usrNombre,
                SesId     = sesId,
                RolNombre = rolNombre
            };

            return true;
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al iniciar sesión: " + ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }

    
    // LOGOUT: cierra la sesión activa en la BD
    
    public static void Logout()
    {
        if (UsuarioActivo == null) return;

        try
        {
            using var conn = OracleDb.Conectar();
            string sql = "UPDATE sesiones SET ses_fin = SYSDATE WHERE ses_id = :ses_id";
            using var cmd = new OracleCommand(sql, conn);
            cmd.Parameters.Add("ses_id", OracleDbType.Int32).Value = UsuarioActivo.SesId;
            cmd.ExecuteNonQuery();
            
        }
        catch { /* Si falla el logout no importa */ }
        finally
        {
            UsuarioActivo = null;
        }
    }

    
    // Convierte texto a hash MD5 igual que como está en la BD
    
    private static string ConvertirMd5(string texto)
    {
        using var md5  = System.Security.Cryptography.MD5.Create();
        byte[] bytes   = System.Text.Encoding.UTF8.GetBytes(texto);
        byte[] hash    = md5.ComputeHash(bytes);
        return BitConverter.ToString(hash).Replace("-", "");
    }
}
