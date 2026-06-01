using HospitalSystem.Common;

namespace HospitalSystem.UserControls.SuperAdmin;

/// <summary>
/// §6.3 Gestión de Usuarios y asignación de roles.
/// TODO toolbar: txtBuscarUsr, btnNuevoUsr, btnEditarUsr, btnAsignarRol, btnEliminarUsr, btnResetPwd.
/// TODO grid: dgvUsuarios (usr_id, usr_nombre, usr_creado, Roles, Sesión activa).
/// TODO modales: FrmEditUsuario, FrmAsignarRol (CheckedListBox).
/// </summary>
public class UcUsuarios : UserControl
{
    public UcUsuarios()
    {
        BackColor = AppColors.Background;
        Controls.Add(new Label
        {
            Text = "Usuarios — añadir toolbar + dgvUsuarios + modal asignar rol",
            Font = AppFonts.Title, ForeColor = AppColors.TextMuted,
            Dock = DockStyle.Top, Height = 60,
            TextAlign = ContentAlignment.MiddleLeft, Padding = new Padding(20, 0, 0, 0)
        });
    }
}
