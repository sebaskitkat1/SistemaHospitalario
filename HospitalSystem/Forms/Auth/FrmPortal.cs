namespace HospitalSystem.Forms.Auth;

public partial class FrmPortal : Form
{
    public FrmPortal()
    {
        InitializeComponent();
    }

    private void btnEntrarStaff_Click(object sender, EventArgs e)
    {
        // TODO: abrir FrmLoginPersonal
        new FrmLoginPersonal().ShowDialog();
    }

    private void btnEntrarPac_Click(object sender, EventArgs e)
    {
        // TODO: abrir FrmLoginPaciente
        new FrmLoginPaciente().ShowDialog();
    }
}
