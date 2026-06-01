using HospitalSystem.Common;

namespace HospitalSystem.Forms.Admin;

partial class FrmAdminDashboard
{
    private System.ComponentModel.IContainer components = null;
    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null) components.Dispose();
        base.Dispose(disposing);
    }

    // Marcados como protected para que FrmSuperAdminDashboard pueda extender el sidebar.
    protected Panel pnlTopBar;
    protected Label lblBreadcrumb;
    protected Label lblUsuarioActivo;
    protected Button btnLogout;
    protected Panel pnlSide;
    protected FlowLayoutPanel flpMenu;
    protected Button btnNavInicio;
    protected Button btnNavPacientes;
    protected Button btnNavMedicos;
    protected Button btnNavCitas;
    protected Button btnNavEspecialidades;
    protected Button btnNavRecetas;
    protected Panel pnlContent;

    private Button MakeNavButton(string text)
    {
        var b = new Button
        {
            Text = "   " + text,
            TextAlign = ContentAlignment.MiddleLeft,
            Font = AppFonts.Subtitle,
            ForeColor = Color.White,
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

    private void InitializeComponent()
    {
        pnlTopBar = new Panel();
        lblBreadcrumb = new Label();
        lblUsuarioActivo = new Label();
        btnLogout = new Button();
        pnlSide = new Panel();
        flpMenu = new FlowLayoutPanel();
        btnNavInicio = MakeNavButton("Inicio");
        btnNavPacientes = MakeNavButton("Pacientes");
        btnNavMedicos = MakeNavButton("Médicos");
        btnNavCitas = MakeNavButton("Citas");
        btnNavEspecialidades = MakeNavButton("Especialidades");
        btnNavRecetas = MakeNavButton("Recetas");
        pnlContent = new Panel();

        pnlTopBar.Dock = DockStyle.Top;
        pnlTopBar.Height = 56;
        pnlTopBar.BackColor = AppColors.Surface;
        pnlTopBar.Controls.Add(btnLogout);
        pnlTopBar.Controls.Add(lblUsuarioActivo);
        pnlTopBar.Controls.Add(lblBreadcrumb);

        lblBreadcrumb.Text = "Inicio";
        lblBreadcrumb.Font = AppFonts.Subtitle;
        lblBreadcrumb.ForeColor = AppColors.TextMain;
        lblBreadcrumb.AutoSize = true;
        lblBreadcrumb.Location = new Point(260, 18);

        lblUsuarioActivo.Text = "Hola, admin";
        lblUsuarioActivo.Font = AppFonts.Body;
        lblUsuarioActivo.ForeColor = AppColors.TextMuted;
        lblUsuarioActivo.AutoSize = true;
        lblUsuarioActivo.Location = new Point(1050, 20);

        btnLogout.Text = "Cerrar sesión";
        btnLogout.Font = AppFonts.Body;
        btnLogout.FlatStyle = FlatStyle.Flat;
        btnLogout.FlatAppearance.BorderSize = 1;
        btnLogout.ForeColor = AppColors.Danger;
        btnLogout.Location = new Point(1140, 13);
        btnLogout.Size = new Size(120, 30);
        btnLogout.Click += btnLogout_Click;

        pnlSide.Dock = DockStyle.Left;
        pnlSide.Width = 240;
        pnlSide.BackColor = AppColors.Sidebar;
        pnlSide.Controls.Add(flpMenu);

        flpMenu.Dock = DockStyle.Fill;
        flpMenu.FlowDirection = FlowDirection.TopDown;
        flpMenu.WrapContents = false;
        flpMenu.Padding = new Padding(0, 20, 0, 0);
        flpMenu.Controls.Add(btnNavInicio);
        flpMenu.Controls.Add(btnNavPacientes);
        flpMenu.Controls.Add(btnNavMedicos);
        flpMenu.Controls.Add(btnNavCitas);
        flpMenu.Controls.Add(btnNavEspecialidades);
        flpMenu.Controls.Add(btnNavRecetas);

        btnNavInicio.Click += btnNavInicio_Click;
        btnNavPacientes.Click += btnNavPacientes_Click;
        btnNavMedicos.Click += btnNavMedicos_Click;
        btnNavCitas.Click += btnNavCitas_Click;
        btnNavEspecialidades.Click += btnNavEspecialidades_Click;
        btnNavRecetas.Click += btnNavRecetas_Click;

        pnlContent.Dock = DockStyle.Fill;
        pnlContent.BackColor = AppColors.Background;
        pnlContent.Padding = new Padding(24);

        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1280, 800);
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Panel de Administración - Sistema Hospitalario";
        MinimumSize = new Size(1100, 700);
        Controls.Add(pnlContent);
        Controls.Add(pnlSide);
        Controls.Add(pnlTopBar);
    }
}
