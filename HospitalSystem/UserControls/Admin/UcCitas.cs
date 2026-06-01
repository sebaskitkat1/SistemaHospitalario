using HospitalSystem.Common;

namespace HospitalSystem.UserControls.Admin;

/// <summary>
/// §5.3 CRUD Citas.
/// TODO toolbar: dtpDesde, dtpHasta, cboEstadoFiltro (PENDIENTE/ATENDIDA/CANCELADA), cboMedicoFiltro,
///               btnNueva, btnEditar, btnCancelarCita, btnAtender, btnEliminar, btnRefrescar.
/// TODO grid: dgvCitas (ID, Fecha, Hora, Paciente, Prioridad-badge, Médico, Especialidad, Estado-badge, Tiene receta).
/// TODO modal: FrmEditCita.
/// </summary>
public class UcCitas : UserControl
{
    public UcCitas()
    {
        BackColor = AppColors.Background;
        Controls.Add(new Label
        {
            Text = "Gestión de Citas — añadir filtros + dgvCitas",
            Font = AppFonts.Title, ForeColor = AppColors.TextMuted,
            Dock = DockStyle.Top, Height = 60,
            TextAlign = ContentAlignment.MiddleLeft, Padding = new Padding(20, 0, 0, 0)
        });
    }
}
