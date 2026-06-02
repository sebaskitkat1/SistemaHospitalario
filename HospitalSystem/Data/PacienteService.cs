using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace HospitalSystem.Data;


// MODELO: representa un paciente de la BD

public class Paciente
{
    public int     PacId       { get; set; }
    public string  PacNombre   { get; set; } = "";
    public string  PacApellido { get; set; } = "";
    public string? PacCurp     { get; set; }
    public DateTime? PacFechaNac { get; set; }
    public string? PacTelefono { get; set; }
    public string? PacEmail    { get; set; }
    public int     PacPrioridad { get; set; } = 3;
    public int     PacActivo   { get; set; } = 1;
    public string  NombreCompleto => $"{PacNombre} {PacApellido}";
    public string  PrioridadTexto => PacPrioridad switch
    {
        1 => "URGENTE",
        2 => "ALTA",
        3 => "MEDIA",
        4 => "BAJA",
        _ => "DESCONOCIDA"
    };
}


// SERVICIO DE PACIENTES
// Contiene todos los queries de la tabla pacientes

public static class PacienteService
{
    
    // LISTAR: trae todos los pacientes activos ordenados por prioridad
    // Usa fn_etiqueta_prioridad de la BD para el texto
    
    public static List<Paciente> ObtenerTodos(string? filtroNombre = null, int? filtroPrioridad = null)
    {
        var lista = new List<Paciente>();

        try
        {
            using var conn = OracleDb.Conectar();

            string sql = @"
                SELECT pac_id, pac_nombre, pac_apellido, pac_curp,
                       pac_fecha_nac, pac_telefono, pac_email,
                       pac_prioridad, pac_activo
                FROM   pacientes
                WHERE  pac_activo = 1";

            if (!string.IsNullOrEmpty(filtroNombre))
                sql += " AND (UPPER(pac_nombre) LIKE UPPER(:nombre) OR UPPER(pac_apellido) LIKE UPPER(:nombre))";

            if (filtroPrioridad.HasValue && filtroPrioridad > 0)
                sql += " AND pac_prioridad = :prioridad";

            sql += " ORDER BY pac_prioridad ASC, pac_nombre ASC";

            using var cmd = new OracleCommand(sql, conn);

            if (!string.IsNullOrEmpty(filtroNombre))
                cmd.Parameters.Add("nombre", OracleDbType.Varchar2).Value = $"%{filtroNombre}%";

            if (filtroPrioridad.HasValue && filtroPrioridad > 0)
                cmd.Parameters.Add("prioridad", OracleDbType.Int32).Value = filtroPrioridad.Value;

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                lista.Add(new Paciente
                {
                    PacId        = reader.GetInt32(0),
                    PacNombre    = reader.GetString(1),
                    PacApellido  = reader.GetString(2),
                    PacCurp      = reader.IsDBNull(3)  ? null : reader.GetString(3),
                    PacFechaNac  = reader.IsDBNull(4)  ? null : reader.GetDateTime(4),
                    PacTelefono  = reader.IsDBNull(5)  ? null : reader.GetString(5),
                    PacEmail     = reader.IsDBNull(6)  ? null : reader.GetString(6),
                    PacPrioridad = reader.GetInt32(7),
                    PacActivo    = reader.GetInt32(8),
                });
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al cargar pacientes: " + ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        return lista;
    }

    
    // INSERTAR: registra un paciente nuevo
    // El trigger tr_log_nuevo_paciente se dispara automáticamente
    
    public static bool Insertar(Paciente p)
    {
        try
        {
            using var conn = OracleDb.Conectar();

            string sql = @"
                INSERT INTO pacientes
                    (pac_nombre, pac_apellido, pac_curp, pac_fecha_nac,
                     pac_telefono, pac_email, pac_prioridad, ses_id)
                VALUES
                    (:nombre, :apellido, :curp, :fecha_nac,
                     :telefono, :email, :prioridad, :ses_id)";

            using var cmd = new OracleCommand(sql, conn);
            cmd.Parameters.Add("nombre",    OracleDbType.Varchar2).Value = p.PacNombre;
            cmd.Parameters.Add("apellido",  OracleDbType.Varchar2).Value = p.PacApellido;
            cmd.Parameters.Add("curp",      OracleDbType.Varchar2).Value = (object?)p.PacCurp    ?? DBNull.Value;
            cmd.Parameters.Add("fecha_nac", OracleDbType.Date).Value     = (object?)p.PacFechaNac ?? DBNull.Value;
            cmd.Parameters.Add("telefono",  OracleDbType.Varchar2).Value = (object?)p.PacTelefono ?? DBNull.Value;
            cmd.Parameters.Add("email",     OracleDbType.Varchar2).Value = (object?)p.PacEmail    ?? DBNull.Value;
            cmd.Parameters.Add("prioridad", OracleDbType.Int32).Value    = p.PacPrioridad;
            cmd.Parameters.Add("ses_id",    OracleDbType.Int32).Value    = UsuarioService.UsuarioActivo?.SesId ?? 1;

            cmd.ExecuteNonQuery();
            
            return true;
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al registrar paciente: " + ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }

    
    // ACTUALIZAR: modifica los datos de un paciente existente
    // Si cambia la prioridad, tr_log_cambio_prioridad se dispara solo
    
    public static bool Actualizar(Paciente p)
    {
        try
        {
            using var conn = OracleDb.Conectar();

            string sql = @"
                UPDATE pacientes SET
                    pac_nombre    = :nombre,
                    pac_apellido  = :apellido,
                    pac_curp      = :curp,
                    pac_fecha_nac = :fecha_nac,
                    pac_telefono  = :telefono,
                    pac_email     = :email,
                    pac_prioridad = :prioridad,
                    ses_id        = :ses_id
                WHERE pac_id = :pac_id";

            using var cmd = new OracleCommand(sql, conn);
            cmd.Parameters.Add("nombre",    OracleDbType.Varchar2).Value = p.PacNombre;
            cmd.Parameters.Add("apellido",  OracleDbType.Varchar2).Value = p.PacApellido;
            cmd.Parameters.Add("curp",      OracleDbType.Varchar2).Value = (object?)p.PacCurp     ?? DBNull.Value;
            cmd.Parameters.Add("fecha_nac", OracleDbType.Date).Value     = (object?)p.PacFechaNac ?? DBNull.Value;
            cmd.Parameters.Add("telefono",  OracleDbType.Varchar2).Value = (object?)p.PacTelefono ?? DBNull.Value;
            cmd.Parameters.Add("email",     OracleDbType.Varchar2).Value = (object?)p.PacEmail    ?? DBNull.Value;
            cmd.Parameters.Add("prioridad", OracleDbType.Int32).Value    = p.PacPrioridad;
            cmd.Parameters.Add("ses_id",    OracleDbType.Int32).Value    = UsuarioService.UsuarioActivo?.SesId ?? 1;
            cmd.Parameters.Add("pac_id",    OracleDbType.Int32).Value    = p.PacId;

            cmd.ExecuteNonQuery();
            
            return true;
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al actualizar paciente: " + ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }

    
    // ELIMINAR (baja lógica): no borra el registro, solo lo desactiva
    // conserva el historial
    
    public static bool Eliminar(int pacId)
    {
        try
        {
            using var conn = OracleDb.Conectar();

            string sql = "UPDATE pacientes SET pac_activo = 0 WHERE pac_id = :pac_id";
            using var cmd = new OracleCommand(sql, conn);
            cmd.Parameters.Add("pac_id", OracleDbType.Int32).Value = pacId;
            cmd.ExecuteNonQuery();
            
            return true;
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al eliminar paciente: " + ex.Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }
}
