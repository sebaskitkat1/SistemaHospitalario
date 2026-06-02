using HospitalSystem.Data;

namespace HospitalSystem.Forms.Auth;

public partial class FrmLoginPersonal : Form
{
    public FrmLoginPersonal()
    {
        InitializeComponent();
    }

    private void btnIniciarSesion_Click(object sender, EventArgs e)
    {
        if (string.IsNullOrEmpty(txtUsuario.Text) || string.IsNullOrEmpty(txtPassword.Text))
        {
            MessageBox.Show("Ingresa usuario y contraseña.", "Aviso",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        bool ok = UsuarioService.Login(txtUsuario.Text.Trim(), txtPassword.Text);

        if (!ok)
        {
            MessageBox.Show("Usuario o contraseña incorrectos.", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        string rol = UsuarioService.UsuarioActivo!.RolNombre;

        if (rol == "ADMINISTRADOR" || rol == "RECEPCIONISTA" || rol == "MEDICO")
        {
            new Forms.Admin.FrmAdminDashboard().Show();
            Hide();
        }
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
