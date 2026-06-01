using HospitalSystem.Common;

namespace HospitalSystem.UserControls.Admin;

/// <summary>
/// §5.5 Visualización de Recetas.
/// TODO grid: dgvRecetas (ID, Fecha, Paciente, Médico, Diagnóstico, Medicamento, CitaID).
/// TODO modal: FrmEditReceta (sólo abrible desde cita ATENDIDA).
/// </summary>
public class UcRecetas : UserControl
{
    public UcRecetas()
    {
        BackColor = AppColors.Background;
        Controls.Add(new Label
        {
            Text = "Recetas — añadir filtros + dgvRecetas",
            Font = AppFonts.Title, ForeColor = AppColors.TextMuted,
            Dock = DockStyle.Top, Height = 60,
            TextAlign = ContentAlignment.MiddleLeft, Padding = new Padding(20, 0, 0, 0)
        });
    }
}
