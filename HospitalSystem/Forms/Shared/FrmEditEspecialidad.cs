using HospitalSystem.Common;

namespace HospitalSystem.Forms.Shared;

/// <summary>§5.4 Modal Especialidad: txtNombreEsp (UNIQUE) + txtDescEsp (Multiline) + Guardar/Cancelar.</summary>
public class FrmEditEspecialidad : Form
{
    public FrmEditEspecialidad()
    {
        Text = "Especialidad"; ClientSize = new Size(480, 320);
        StartPosition = FormStartPosition.CenterParent;
        FormBorderStyle = FormBorderStyle.FixedDialog;
        BackColor = AppColors.Surface;
        Controls.Add(new Label { Text = "Modal Especialidad — §5.4", Font = AppFonts.Subtitle,
            ForeColor = AppColors.TextMuted, Dock = DockStyle.Fill,
            TextAlign = ContentAlignment.MiddleCenter });
    }
}
