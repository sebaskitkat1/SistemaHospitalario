using HospitalSystem.Common;

namespace HospitalSystem.Forms.Shared;

/// <summary>
/// §6.4 Confirmación de acción destructiva.
/// TODO: lblAdvertencia (rojo), lblDetalle, txtConfirmacion (debe escribir "CONFIRMAR"),
///       btnEjecutar (Enabled=false hasta que coincida), btnAbortar, pbEjecucion.
/// </summary>
public class FrmConfirmacionPeligrosa : Form
{
    public FrmConfirmacionPeligrosa()
    {
        Text = "⚠ Confirmación requerida"; ClientSize = new Size(520, 380);
        StartPosition = FormStartPosition.CenterParent;
        FormBorderStyle = FormBorderStyle.FixedDialog;
        BackColor = AppColors.DangerSoft;
        Controls.Add(new Label { Text = "Modal Confirmación Peligrosa — §6.4 (escribir CONFIRMAR)",
            Font = AppFonts.Subtitle, ForeColor = AppColors.Danger,
            Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter });
    }
}
