using HospitalSystem.UserControls.Admin;

namespace HospitalSystem.Forms.Admin;

public partial class FrmAdminDashboard : Form
{
    public FrmAdminDashboard()
    {
        InitializeComponent();
        CargarUserControl(new UcInicio());
        lblBreadcrumb.Text = "Inicio";
    }

    /// <summary>
    /// Reemplaza el contenido del panel central por el UserControl recibido.
    /// </summary>
    protected void CargarUserControl(UserControl uc)
    {
        pnlContent.Controls.Clear();
        uc.Dock = DockStyle.Fill;
        pnlContent.Controls.Add(uc);
    }

    private void btnNavInicio_Click(object sender, EventArgs e)        { CargarUserControl(new UcInicio()); lblBreadcrumb.Text = "Inicio / Inicio"; }
    private void btnNavPacientes_Click(object sender, EventArgs e)     { CargarUserControl(new UcPacientes()); lblBreadcrumb.Text = "Inicio / Pacientes"; }
    private void btnNavMedicos_Click(object sender, EventArgs e)       { CargarUserControl(new UcMedicos()); lblBreadcrumb.Text = "Inicio / Médicos"; }
    private void btnNavCitas_Click(object sender, EventArgs e)         { CargarUserControl(new UcCitas()); lblBreadcrumb.Text = "Inicio / Citas"; }
    private void btnNavEspecialidades_Click(object sender, EventArgs e){ CargarUserControl(new UcEspecialidades()); lblBreadcrumb.Text = "Inicio / Especialidades"; }
    private void btnNavRecetas_Click(object sender, EventArgs e)       { CargarUserControl(new UcRecetas()); lblBreadcrumb.Text = "Inicio / Recetas"; }

    private void btnLogout_Click(object sender, EventArgs e) { Close(); }
}
