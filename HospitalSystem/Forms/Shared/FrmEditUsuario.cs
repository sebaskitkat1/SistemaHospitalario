using HospitalSystem.Common;

namespace HospitalSystem.Forms.Shared;

/// <summary>§6.3 Modal Usuario: txtNombreUsr (UNIQUE), txtPwdUsr + txtPwdConfirm, lblHashInfo, btnGuardar/Cancelar.</summary>
public class FrmEditUsuario : Form
{
    public FrmEditUsuario()
    {
        Text = "Usuario"; ClientSize = new Size(480, 360);
        StartPosition = FormStartPosition.CenterParent;
        FormBorderStyle = FormBorderStyle.FixedDialog;
        BackColor = AppColors.Surface;
        Controls.Add(new Label { Text = "Modal Usuario — §6.3", Font = AppFonts.Subtitle,
            ForeColor = AppColors.TextMuted, Dock = DockStyle.Fill,
            TextAlign = ContentAlignment.MiddleCenter });
    }
}

/// <summary>§6.3 Modal asignar rol: lblUsuarioObjetivo + CheckedListBox clbRolesDisponibles + dtpInicioVigencia + Guardar/Cancelar.</summary>
public class FrmAsignarRol : Form
{
    public FrmAsignarRol()
    {
        Text = "Asignar rol"; ClientSize = new Size(480, 440);
        StartPosition = FormStartPosition.CenterParent;
        FormBorderStyle = FormBorderStyle.FixedDialog;
        BackColor = AppColors.Surface;
        Controls.Add(new Label { Text = "Modal Asignar Rol — §6.3 (CheckedListBox)",
            Font = AppFonts.Subtitle, ForeColor = AppColors.TextMuted,
            Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter });
    }
}
