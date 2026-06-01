using HospitalSystem.Common;

namespace HospitalSystem.UserControls.SuperAdmin;

/// <summary>
/// §6.2 Gestión de Roles y Permisos.
/// TODO SplitContainer horizontal:
///   - Panel1: dgvRoles + toolbar (btnNuevoRol, btnEditarRol, btnEliminarRol)
///   - Panel2: dgvPermisos (filtrados por rol seleccionado) + toolbar
/// TODO modales: FrmEditRol, FrmEditPermiso (con 32 CheckBoxes sincronizados al hex).
/// </summary>
public class UcRolesPermisos : UserControl
{
    public UcRolesPermisos()
    {
        BackColor = AppColors.Background;
        Controls.Add(new Label
        {
            Text = "Roles y Permisos — añadir SplitContainer (dgvRoles | dgvPermisos)",
            Font = AppFonts.Title, ForeColor = AppColors.TextMuted,
            Dock = DockStyle.Top, Height = 60,
            TextAlign = ContentAlignment.MiddleLeft, Padding = new Padding(20, 0, 0, 0)
        });
    }
}
