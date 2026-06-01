using HospitalSystem.Common;

namespace HospitalSystem.UserControls.SuperAdmin;

/// <summary>
/// §6.4 Acciones destructivas. Zona roja.
/// TODO FlowLayoutPanel vertical con 5 tarjetas (Panel) — cada una con botón rojo:
///   - btnVaciarLogs           (vaciar log_auditoria)
///   - btnLimpiarSesiones      (eliminar sesiones cerradas)
///   - btnCancelarVencidas     (citas pendientes > 30 días)
///   - btnPurgarCitasCanceladas
///   - btnResetEsquema         (DROP + recrear)
/// Cada botón abre FrmConfirmacionPeligrosa.
/// </summary>
public class UcMantenimientoBD : UserControl
{
    public UcMantenimientoBD()
    {
        BackColor = AppColors.DangerSoft;
        Controls.Add(new Label
        {
            Text = "Mantenimiento BD — ⚠ Zona roja · añadir 5 tarjetas de acciones destructivas",
            Font = AppFonts.Title, ForeColor = AppColors.Danger,
            Dock = DockStyle.Top, Height = 60,
            TextAlign = ContentAlignment.MiddleLeft, Padding = new Padding(20, 0, 0, 0)
        });
    }
}
