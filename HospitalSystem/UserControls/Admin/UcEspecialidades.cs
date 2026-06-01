using HospitalSystem.Common;

namespace HospitalSystem.UserControls.Admin;

/// <summary>
/// §5.4 Catálogo Especialidades.
/// TODO grid: dgvEspecialidades (ID, Nombre, Descripción, #Médicos).
/// TODO modal: FrmEditEspecialidad.
/// </summary>
public class UcEspecialidades : UserControl
{
    public UcEspecialidades()
    {
        BackColor = AppColors.Background;
        Controls.Add(new Label
        {
            Text = "Catálogo de Especialidades — añadir dgvEspecialidades",
            Font = AppFonts.Title, ForeColor = AppColors.TextMuted,
            Dock = DockStyle.Top, Height = 60,
            TextAlign = ContentAlignment.MiddleLeft, Padding = new Padding(20, 0, 0, 0)
        });
    }
}
