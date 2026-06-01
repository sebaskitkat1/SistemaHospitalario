using HospitalSystem.Common;

namespace HospitalSystem.UserControls.SuperAdmin;

/// <summary>
/// §6.1 Visualización de log_auditoria.
/// TODO toolbar: dtpAudDesde, dtpAudHasta, cboAudTabla, cboAudAccion (INSERT/UPDATE/DELETE),
///               txtAudMensaje, btnFiltrar, btnLimpiarFiltros, btnExportar (SaveFileDialog).
/// TODO grid: dgvAuditoria ReadOnly (log_id, log_fecha, log_tabla, log_accion-badge, log_mensaje, ses_id).
/// </summary>
public class UcAuditoria : UserControl
{
    public UcAuditoria()
    {
        BackColor = AppColors.Background;
        Controls.Add(new Label
        {
            Text = "Auditoría (log_auditoria) — solo lectura · añadir filtros + dgvAuditoria",
            Font = AppFonts.Title, ForeColor = AppColors.TextMuted,
            Dock = DockStyle.Top, Height = 60,
            TextAlign = ContentAlignment.MiddleLeft, Padding = new Padding(20, 0, 0, 0)
        });
    }
}
