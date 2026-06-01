using HospitalSystem.Common;

namespace HospitalSystem.UserControls.Admin;

/// <summary>
/// §4 Pantalla "Inicio" del FrmAdminDashboard.
/// TODO controles:
///   - 4 paneles-tarjeta KPI (Pacientes activos, Citas hoy, Citas pendientes, Médicos activos)
///   - DataGridView dgvCitasHoy (vista rápida de v_citas_resumen filtrada por hoy)
/// </summary>
public class UcInicio : UserControl
{
    public UcInicio()
    {
        BackColor = AppColors.Background;
        var lbl = new Label
        {
            Text = "Dashboard de Inicio — añadir 4 tarjetas KPI + dgvCitasHoy",
            Font = AppFonts.Title,
            ForeColor = AppColors.TextMuted,
            Dock = DockStyle.Top,
            Height = 60,
            TextAlign = ContentAlignment.MiddleLeft,
            Padding = new Padding(20, 0, 0, 0)
        };
        Controls.Add(lbl);
    }
}
