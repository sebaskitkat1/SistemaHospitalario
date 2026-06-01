using HospitalSystem.Common;

namespace HospitalSystem.UserControls.Admin;

/// <summary>
/// §5.2 CRUD Médicos.
/// TODO toolbar: txtBuscarMed, cboEspecialidadFiltro, chkSoloActivosMed, btnNuevo/Editar/Eliminar/Refrescar.
/// TODO grid: dgvMedicos (ID, Nombre, Cédula, Especialidad, Email, Teléfono, Activo).
/// TODO modal: FrmEditMedico.
/// </summary>
public class UcMedicos : UserControl
{
    public UcMedicos()
    {
        BackColor = AppColors.Background;
        Controls.Add(new Label
        {
            Text = "Gestión de Médicos — añadir toolbar + dgvMedicos",
            Font = AppFonts.Title, ForeColor = AppColors.TextMuted,
            Dock = DockStyle.Top, Height = 60,
            TextAlign = ContentAlignment.MiddleLeft, Padding = new Padding(20, 0, 0, 0)
        });
    }
}
