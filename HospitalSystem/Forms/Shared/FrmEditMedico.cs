using HospitalSystem.Common;

namespace HospitalSystem.Forms.Shared;

/// <summary>
/// §5.2 Modal alta/edición Médico.
/// TODO: txtNombre/Apellido/Cedula (UNIQUE)/Email, mtxtTel, cboEspecialidad (DropDownList FK), chkActivo, btnGuardar/Cancelar.
/// </summary>
public class FrmEditMedico : Form
{
    public FrmEditMedico()
    {
        Text = "Médico"; ClientSize = new Size(560, 520);
        StartPosition = FormStartPosition.CenterParent;
        FormBorderStyle = FormBorderStyle.FixedDialog;
        BackColor = AppColors.Surface;
        Controls.Add(new Label { Text = "Modal Médico — §5.2", Font = AppFonts.Subtitle,
            ForeColor = AppColors.TextMuted, Dock = DockStyle.Fill,
            TextAlign = ContentAlignment.MiddleCenter });
    }
}
