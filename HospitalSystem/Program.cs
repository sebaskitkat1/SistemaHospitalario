using HospitalSystem.Data;
using HospitalSystem.Forms.Auth;

namespace HospitalSystem;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        OracleDb.InicializarWallet();
        Application.Run(new FrmPortal());
    }
}
