using HospitalSystem.Forms.Admin;
using HospitalSystem.UserControls.SuperAdmin;

namespace HospitalSystem.Forms.SuperAdmin;

/// <summary>
/// Hereda visualmente del Admin y añade el grupo "Opciones Avanzadas" al sidebar.
/// </summary>
public partial class FrmSuperAdminDashboard : FrmAdminDashboard
{
    public FrmSuperAdminDashboard()
    {
        InitializeAdvancedComponent();
        Text = "Panel de Super Administrador - Sistema Hospitalario";
    }

    private void btnNavAuditoria_Click(object sender, EventArgs e)     { CargarUserControl(new UcAuditoria()); lblBreadcrumb.Text = "SuperAdmin / Auditoría"; }
    private void btnNavRoles_Click(object sender, EventArgs e)         { CargarUserControl(new UcRolesPermisos()); lblBreadcrumb.Text = "SuperAdmin / Roles y Permisos"; }
    private void btnNavUsuarios_Click(object sender, EventArgs e)      { CargarUserControl(new UcUsuarios()); lblBreadcrumb.Text = "SuperAdmin / Usuarios"; }
    private void btnNavMantenimiento_Click(object sender, EventArgs e) { CargarUserControl(new UcMantenimientoBD()); lblBreadcrumb.Text = "SuperAdmin / Mantenimiento BD"; }
    private void btnNavRespaldos_Click(object sender, EventArgs e)     { CargarUserControl(new UcRespaldosTriggers()); lblBreadcrumb.Text = "SuperAdmin / Respaldos y Triggers"; }
}
