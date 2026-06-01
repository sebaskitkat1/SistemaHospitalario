using HospitalSystem.Common;

namespace HospitalSystem.UserControls.Admin;

/// <summary>
/// §5.1 CRUD Pacientes.
/// TODO toolbar: txtBuscarPac, cboPrioridadFiltro, chkSoloActivosPac, btnNuevoPac, btnEditarPac, btnEliminarPac, btnRefrescar.
/// TODO grid: dgvPacientes (ID, Nombre completo, CURP, Edad, Teléfono, Email, Prioridad-badge, Activo, Registro).
/// TODO modal: FrmEditPaciente.
/// </summary>
public class UcPacientes : UserControl
{
    public UcPacientes()
    {
        BackColor = AppColors.Background;
        var lbl = new Label
        {
            Text = "Gestión de Pacientes — añadir toolbar + dgvPacientes",
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
