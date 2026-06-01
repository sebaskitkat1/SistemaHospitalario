using HospitalSystem.Common;

namespace HospitalSystem.Forms.Auth;

partial class FrmPortal
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null) components.Dispose();
        base.Dispose(disposing);
    }

    private Panel pnlHeader;
    private Label lblTituloHospital;
    private TableLayoutPanel tlpBifurcacion;
    private Panel pnlCardPersonal;
    private Panel pnlCardPaciente;
    private Label lblTituloPersonal;
    private Label lblDescPersonal;
    private Button btnEntrarStaff;
    private Label lblTituloPaciente;
    private Label lblDescPaciente;
    private Button btnEntrarPac;
    private Panel pnlFooter;
    private Label lblVersion;

    private void InitializeComponent()
    {
        pnlHeader = new Panel();
        lblTituloHospital = new Label();
        tlpBifurcacion = new TableLayoutPanel();
        pnlCardPersonal = new Panel();
        pnlCardPaciente = new Panel();
        lblTituloPersonal = new Label();
        lblDescPersonal = new Label();
        btnEntrarStaff = new Button();
        lblTituloPaciente = new Label();
        lblDescPaciente = new Label();
        btnEntrarPac = new Button();
        pnlFooter = new Panel();
        lblVersion = new Label();

        // pnlHeader
        pnlHeader.Dock = DockStyle.Top;
        pnlHeader.Height = 80;
        pnlHeader.BackColor = AppColors.Primary;
        pnlHeader.Controls.Add(lblTituloHospital);

        // lblTituloHospital
        lblTituloHospital.Text = "Sistema Hospitalario";
        lblTituloHospital.Font = AppFonts.TitleLarge;
        lblTituloHospital.ForeColor = Color.White;
        lblTituloHospital.AutoSize = true;
        lblTituloHospital.Location = new Point(32, 26);

        // tlpBifurcacion
        tlpBifurcacion.Dock = DockStyle.Fill;
        tlpBifurcacion.ColumnCount = 2;
        tlpBifurcacion.RowCount = 1;
        tlpBifurcacion.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tlpBifurcacion.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
        tlpBifurcacion.Padding = new Padding(40);
        tlpBifurcacion.BackColor = AppColors.Background;
        tlpBifurcacion.Controls.Add(pnlCardPersonal, 0, 0);
        tlpBifurcacion.Controls.Add(pnlCardPaciente, 1, 0);

        // pnlCardPersonal
        pnlCardPersonal.Dock = DockStyle.Fill;
        pnlCardPersonal.BackColor = AppColors.Surface;
        pnlCardPersonal.Margin = new Padding(20);
        pnlCardPersonal.Padding = new Padding(40);
        pnlCardPersonal.Controls.Add(btnEntrarStaff);
        pnlCardPersonal.Controls.Add(lblDescPersonal);
        pnlCardPersonal.Controls.Add(lblTituloPersonal);

        // lblTituloPersonal
        lblTituloPersonal.Text = "Ingreso como Personal";
        lblTituloPersonal.Font = AppFonts.Title;
        lblTituloPersonal.ForeColor = AppColors.TextMain;
        lblTituloPersonal.AutoSize = true;
        lblTituloPersonal.Location = new Point(40, 60);

        // lblDescPersonal
        lblDescPersonal.Text = "Acceso para administradores y personal médico.";
        lblDescPersonal.Font = AppFonts.Subtitle;
        lblDescPersonal.ForeColor = AppColors.TextMuted;
        lblDescPersonal.AutoSize = true;
        lblDescPersonal.Location = new Point(40, 110);

        // btnEntrarStaff
        btnEntrarStaff.Text = "Continuar →";
        btnEntrarStaff.Font = AppFonts.ButtonPrimary;
        btnEntrarStaff.FlatStyle = FlatStyle.Flat;
        btnEntrarStaff.FlatAppearance.BorderSize = 0;
        btnEntrarStaff.BackColor = AppColors.Primary;
        btnEntrarStaff.ForeColor = Color.White;
        btnEntrarStaff.Size = new Size(200, 48);
        btnEntrarStaff.Location = new Point(40, 170);
        btnEntrarStaff.Cursor = Cursors.Hand;
        btnEntrarStaff.Click += btnEntrarStaff_Click;

        // pnlCardPaciente
        pnlCardPaciente.Dock = DockStyle.Fill;
        pnlCardPaciente.BackColor = AppColors.Surface;
        pnlCardPaciente.Margin = new Padding(20);
        pnlCardPaciente.Padding = new Padding(40);
        pnlCardPaciente.Controls.Add(btnEntrarPac);
        pnlCardPaciente.Controls.Add(lblDescPaciente);
        pnlCardPaciente.Controls.Add(lblTituloPaciente);

        // lblTituloPaciente
        lblTituloPaciente.Text = "Ingreso como Paciente";
        lblTituloPaciente.Font = AppFonts.Title;
        lblTituloPaciente.ForeColor = AppColors.TextMain;
        lblTituloPaciente.AutoSize = true;
        lblTituloPaciente.Location = new Point(40, 60);

        // lblDescPaciente
        lblDescPaciente.Text = "Portal de autoservicio para pacientes registrados.";
        lblDescPaciente.Font = AppFonts.Subtitle;
        lblDescPaciente.ForeColor = AppColors.TextMuted;
        lblDescPaciente.AutoSize = true;
        lblDescPaciente.Location = new Point(40, 110);

        // btnEntrarPac
        btnEntrarPac.Text = "Continuar →";
        btnEntrarPac.Font = AppFonts.ButtonPrimary;
        btnEntrarPac.FlatStyle = FlatStyle.Flat;
        btnEntrarPac.FlatAppearance.BorderSize = 0;
        btnEntrarPac.BackColor = AppColors.PrioridadBaja;
        btnEntrarPac.ForeColor = Color.White;
        btnEntrarPac.Size = new Size(200, 48);
        btnEntrarPac.Location = new Point(40, 170);
        btnEntrarPac.Cursor = Cursors.Hand;
        btnEntrarPac.Click += btnEntrarPac_Click;

        // pnlFooter
        pnlFooter.Dock = DockStyle.Bottom;
        pnlFooter.Height = 40;
        pnlFooter.BackColor = AppColors.Sidebar;
        pnlFooter.Controls.Add(lblVersion);

        // lblVersion
        lblVersion.Text = "v1.0 · 2026 · Sistema Hospitalario";
        lblVersion.Font = AppFonts.Body;
        lblVersion.ForeColor = Color.White;
        lblVersion.AutoSize = true;
        lblVersion.Location = new Point(32, 12);

        // FrmPortal
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1280, 800);
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Sistema Hospitalario - Portal";
        Controls.Add(tlpBifurcacion);
        Controls.Add(pnlFooter);
        Controls.Add(pnlHeader);
        MinimumSize = new Size(1024, 700);
    }
}
