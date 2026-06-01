namespace HospitalSystem.Forms.Auth;

public partial class FrmLoginPaciente : Form
{
    public FrmLoginPaciente()
    {
        InitializeComponent();
    }

    private void btnAccederPac_Click(object sender, EventArgs e)
    {
        // TODO: validar CURP + fecha_nac contra pacientes y abrir FrmPacienteDashboard
    }

    private void lnkVolverPortal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        Close();
    }

    private void lnkRegistrarme_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
        // TODO: abrir FrmRegistroPaciente (modal)
    }
}
