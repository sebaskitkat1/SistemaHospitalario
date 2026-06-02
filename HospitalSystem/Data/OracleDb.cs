using Oracle.ManagedDataAccess.Client;

namespace HospitalSystem.Data;


// CLASE PRINCIPAL DE CONEXIÓN A ORACLE
// Todos los demás servicios usan esta clase para conectarse.
// La wallet es el archivo zip que descargamos de Oracle Cloud.


public static class OracleDb
{
    // Ruta al zip de la wallet dentro del proyecto
    private const string WalletPath = @"Wallet\Wallet_TallerBaseDeDatos (2).zip";

    // Cadena de conexión usando la wallet
    // DATA SOURCE = el perfil _low de la wallet
    // USER ID     = usuario ADMIN de Oracle Cloud
    // PASSWORD    = contraseña que pusimos al descargar la wallet
    private static string ConnectionString => new OracleConnectionStringBuilder
    {
        DataSource          = "tallerbasededatos_low",
        UserID              = "ADMIN",
        Password            = "Hospital123",
        // Le dice a Oracle dónde está la wallet
        ConnectionTimeout   = 30,
    }.ToString();

    
    // Configura la wallet antes de conectarse.
    // Se llama una sola vez al arrancar la aplicación en Program.cs
 
    public static void InicializarWallet()
    {
        // Ruta completa a la carpeta Wallet dentro del proyecto
        string walletDir = Path.Combine(
            AppDomain.CurrentDomain.BaseDirectory,
            "Wallet"
        );

        // Le dice al driver de Oracle dónde está la wallet
        OracleConfiguration.WalletLocation = $"(SOURCE=(METHOD=FILE)(METHOD_DATA=(DIRECTORY={walletDir})))";
        OracleConfiguration.TnsAdmin       = walletDir;
    }

    
    // Abre y regresa una conexión a Oracle.
    // Uso: using var conn = OracleDb.Conectar();
    // El using cierra la conexión automáticamente al terminar.
    
    public static OracleConnection Conectar()
    {
        var conn = new OracleConnection(ConnectionString);
        conn.Open();
        return conn;
    }

    
    // Prueba si la conexión funciona.
    // Regresa true si conectó bien, false si hubo error.
    // Se puede llamar al arrancar para verificar que Oracle jala.
    
    public static bool ProbarConexion()
    {
        try
        {
            using var conn = Conectar();
            return conn.State == System.Data.ConnectionState.Open;
        }
        catch
        {
            return false;
        }
    }
}
