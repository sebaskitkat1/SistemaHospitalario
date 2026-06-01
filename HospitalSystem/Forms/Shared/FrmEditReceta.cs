using HospitalSystem.Common;

namespace HospitalSystem.Forms.Shared;

/// <summary>
/// §5.5 Modal Receta (sólo desde cita ATENDIDA).
/// TODO: lblCitaRef (read-only), txtDiagnostico, txtMedicamento, txtDosis, txtIndicaciones, dtpFechaReceta, btnGuardar/Cancelar.
/// </summary>
public class FrmEditReceta : Form
{
    public FrmEditReceta()
    {
        Text = "Receta"; ClientSize = new Size(560, 560);
        StartPosition = FormStartPosition.CenterParent;
        FormBorderStyle = FormBorderStyle.FixedDialog;
        BackColor = AppColors.Surface;
        Controls.Add(new Label { Text = "Modal Receta — §5.5", Font = AppFonts.Subtitle,
            ForeColor = AppColors.TextMuted, Dock = DockStyle.Fill,
            TextAlign = ContentAlignment.MiddleCenter });
    }
}
