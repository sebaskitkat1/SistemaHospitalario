using HospitalSystem.Common;

namespace HospitalSystem.UserControls.SuperAdmin;

/// <summary>
/// §6.5 Respaldos / Triggers / Procedimientos.
/// TODO TabControl tcMantenimiento con 3 pestañas:
///   1. Respaldos:     btnNuevoRespaldo, lblUltimoRespaldo, dgvHistorialRespaldos, btnRestaurar, btnDescargar
///   2. Triggers:      dgvTriggers, btnHabilitar/Deshabilitar, btnEjecutarManual, txtTriggerSource (Consolas)
///   3. Procedimientos:lstProcedimientos, pnlParametrosDinamicos, btnEjecutarSP, txtResultadoSP
/// </summary>
public class UcRespaldosTriggers : UserControl
{
    public UcRespaldosTriggers()
    {
        BackColor = AppColors.Background;
        Controls.Add(new Label
        {
            Text = "Respaldos / Triggers / Procedimientos — añadir TabControl 3 pestañas",
            Font = AppFonts.Title, ForeColor = AppColors.TextMuted,
            Dock = DockStyle.Top, Height = 60,
            TextAlign = ContentAlignment.MiddleLeft, Padding = new Padding(20, 0, 0, 0)
        });
    }
}
