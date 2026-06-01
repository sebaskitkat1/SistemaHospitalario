using HospitalSystem.Common;

namespace HospitalSystem.Forms.Shared;

/// <summary>§6.2 Modal Rol: txtNombreRol (UNIQUE) + Guardar/Cancelar.</summary>
public class FrmEditRol : Form
{
    public FrmEditRol()
    {
        Text = "Rol"; ClientSize = new Size(440, 220);
        StartPosition = FormStartPosition.CenterParent;
        FormBorderStyle = FormBorderStyle.FixedDialog;
        BackColor = AppColors.Surface;
        Controls.Add(new Label { Text = "Modal Rol — §6.2", Font = AppFonts.Subtitle,
            ForeColor = AppColors.TextMuted, Dock = DockStyle.Fill,
            TextAlign = ContentAlignment.MiddleCenter });
    }
}

/// <summary>
/// §6.2 Modal Permiso con máscara hex visual.
/// TODO: lblRolAsignado, mtxtPermisoHex (CHAR(8) upper), 32 CheckBoxes sincronizados (TableLayout 8x4),
///       lblPreviewHex, btnGuardar/Cancelar.
/// </summary>
public class FrmEditPermiso : Form
{
    public FrmEditPermiso()
    {
        Text = "Permiso (máscara hex)"; ClientSize = new Size(640, 520);
        StartPosition = FormStartPosition.CenterParent;
        FormBorderStyle = FormBorderStyle.FixedDialog;
        BackColor = AppColors.Surface;
        Controls.Add(new Label { Text = "Modal Permiso — §6.2 (32 CheckBoxes ↔ MaskedTextBox hex)",
            Font = AppFonts.Subtitle, ForeColor = AppColors.TextMuted,
            Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter });
    }
}
