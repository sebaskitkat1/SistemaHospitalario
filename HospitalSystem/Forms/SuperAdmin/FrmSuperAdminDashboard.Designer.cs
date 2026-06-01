using HospitalSystem.Common;

namespace HospitalSystem.Forms.SuperAdmin;

partial class FrmSuperAdminDashboard
{
    private Label lblSepAvanzado;
    private Button btnNavAuditoria;
    private Button btnNavRoles;
    private Button btnNavUsuarios;
    private Button btnNavMantenimiento;
    private Button btnNavRespaldos;

    private Button MakeAdvNavButton(string text, Color? fore = null)
    {
        var b = new Button
        {
            Text = "   " + text,
            TextAlign = ContentAlignment.MiddleLeft,
            Font = AppFonts.Subtitle,
            ForeColor = fore ?? Color.White,
            BackColor = AppColors.Sidebar,
            FlatStyle = FlatStyle.Flat,
            Width = 240,
            Height = 48,
            Cursor = Cursors.Hand,
            Margin = new Padding(0)
        };
        b.FlatAppearance.BorderSize = 0;
        b.FlatAppearance.MouseOverBackColor = AppColors.Primary;
        return b;
    }

    /// <summary>
    /// Añade el separador y los 5 botones avanzados al flpMenu heredado.
    /// </summary>
    private void InitializeAdvancedComponent()
    {
        lblSepAvanzado = new Label
        {
            Text = "  OPCIONES AVANZADAS",
            Font = AppFonts.Body,
            ForeColor = AppColors.TextMuted,
            BackColor = AppColors.Sidebar,
            AutoSize = false,
            Width = 240,
            Height = 36,
            TextAlign = ContentAlignment.MiddleLeft,
            Margin = new Padding(0, 20, 0, 4)
        };
        btnNavAuditoria     = MakeAdvNavButton("Auditoría");
        btnNavRoles         = MakeAdvNavButton("Roles y Permisos");
        btnNavUsuarios      = MakeAdvNavButton("Usuarios");
        btnNavMantenimiento = MakeAdvNavButton("Mantenimiento BD", AppColors.Danger);
        btnNavRespaldos     = MakeAdvNavButton("Respaldos / Triggers");

        flpMenu.Controls.Add(lblSepAvanzado);
        flpMenu.Controls.Add(btnNavAuditoria);
        flpMenu.Controls.Add(btnNavRoles);
        flpMenu.Controls.Add(btnNavUsuarios);
        flpMenu.Controls.Add(btnNavMantenimiento);
        flpMenu.Controls.Add(btnNavRespaldos);

        btnNavAuditoria.Click     += btnNavAuditoria_Click;
        btnNavRoles.Click         += btnNavRoles_Click;
        btnNavUsuarios.Click      += btnNavUsuarios_Click;
        btnNavMantenimiento.Click += btnNavMantenimiento_Click;
        btnNavRespaldos.Click     += btnNavRespaldos_Click;
    }
}
