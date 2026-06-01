using HospitalSystem.Common;

namespace HospitalSystem.Forms.Shared;

/// <summary>
/// §5.3 Modal alta/edición Cita.
/// TODO: cboPaciente (autocomplete), lblPrioridadPaciente (badge), cboEspecialidad, cboMedico,
///       dtpFecha, mtxtHora, lblConflictoHorario, txtMotivo (Multiline), cboEstado (DropDownList),
///       txtNotas (Multiline), btnGuardar/Cancelar, btnCapturarReceta (si estado=ATENDIDA).
/// </summary>
public class FrmEditCita : Form
{
    public FrmEditCita()
    {
        Text = "Cita"; ClientSize = new Size(620, 680);
        StartPosition = FormStartPosition.CenterParent;
        FormBorderStyle = FormBorderStyle.FixedDialog;
        BackColor = AppColors.Surface;
        Controls.Add(new Label { Text = "Modal Cita — §5.3", Font = AppFonts.Subtitle,
            ForeColor = AppColors.TextMuted, Dock = DockStyle.Fill,
            TextAlign = ContentAlignment.MiddleCenter });
    }
}
