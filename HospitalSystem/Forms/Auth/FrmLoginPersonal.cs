namespace HospitalSystem.Forms.Auth;

public partial class FrmLoginPersonal : Form
{
    public FrmLoginPersonal()
    {
        InitializeComponent();
    }

    private void btnIniciarSesion_Click(object sender, EventArgs e)
    {
        // TODO: validar credenciales contra tabla usuarios.
        // Según rol/permisos abrir FrmAdminDashboard o FrmSuperAdminDashboard.
    }

    private void chkMostrarPwd_CheckedChanged(object sender, EventArgs e)
    {
        txtPassword.UseSystemPasswordChar = !chkMostrarPwd.Checked;
    }

    private void lnkVolverPortal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        Close();
    }
}
