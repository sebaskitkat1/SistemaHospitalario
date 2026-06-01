using HospitalSystem.Common;

namespace HospitalSystem.Forms.Auth;

partial class FrmLoginPaciente
{
    private System.ComponentModel.IContainer components = null;
    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null) components.Dispose();
        base.Dispose(disposing);
    }

    private SplitContainer splLogin;
    private Panel pnlBranding;
    private Label lblBrandTagline;
    private Panel pnlFormulario;
    private Label lblTituloLoginPac;
    private Label lblCurp;
    private MaskedTextBox mtxtCurp;
    private Label lblFechaNac;
    private DateTimePicker dtpFechaNac;
    private Label lblErrorPac;
    private Button btnAccederPac;
    private LinkLabel lnkRegistrarme;
    private LinkLabel lnkVolverPortal;
    private ErrorProvider errPac;

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        splLogin = new SplitContainer();
        pnlBranding = new Panel();
        lblBrandTagline = new Label();
        pnlFormulario = new Panel();
        lblTituloLoginPac = new Label();
        lblCurp = new Label();
        mtxtCurp = new MaskedTextBox();
        lblFechaNac = new Label();
        dtpFechaNac = new DateTimePicker();
        lblErrorPac = new Label();
        btnAccederPac = new Button();
        lnkRegistrarme = new LinkLabel();
        lnkVolverPortal = new LinkLabel();
        errPac = new ErrorProvider(components);

        splLogin.Dock = DockStyle.Fill;
        splLogin.Orientation = Orientation.Vertical;
        splLogin.IsSplitterFixed = true;
        splLogin.SplitterDistance = 480;
        splLogin.Panel1.Controls.Add(pnlBranding);
        splLogin.Panel2.Controls.Add(pnlFormulario);

        pnlBranding.Dock = DockStyle.Fill;
        pnlBranding.BackColor = AppColors.PrioridadBaja;
        pnlBranding.Controls.Add(lblBrandTagline);

        lblBrandTagline.Text = "Tu salud,\nen tus manos";
        lblBrandTagline.Font = AppFonts.TitleLarge;
        lblBrandTagline.ForeColor = Color.White;
        lblBrandTagline.AutoSize = true;
        lblBrandTagline.Location = new Point(40, 320);

        pnlFormulario.Dock = DockStyle.Fill;
        pnlFormulario.BackColor = AppColors.Surface;
        pnlFormulario.Padding = new Padding(60);
        pnlFormulario.Controls.Add(lnkVolverPortal);
        pnlFormulario.Controls.Add(lnkRegistrarme);
        pnlFormulario.Controls.Add(btnAccederPac);
        pnlFormulario.Controls.Add(lblErrorPac);
        pnlFormulario.Controls.Add(dtpFechaNac);
        pnlFormulario.Controls.Add(lblFechaNac);
        pnlFormulario.Controls.Add(mtxtCurp);
        pnlFormulario.Controls.Add(lblCurp);
        pnlFormulario.Controls.Add(lblTituloLoginPac);

        lblTituloLoginPac.Text = "Acceso de Paciente";
        lblTituloLoginPac.Font = AppFonts.TitleLarge;
        lblTituloLoginPac.ForeColor = AppColors.TextMain;
        lblTituloLoginPac.AutoSize = true;
        lblTituloLoginPac.Location = new Point(60, 100);

        lblCurp.Text = "CURP";
        lblCurp.Font = AppFonts.BodyBold;
        lblCurp.AutoSize = true;
        lblCurp.Location = new Point(60, 180);

        mtxtCurp.Mask = "AAAA000000AAAAAA00";
        mtxtCurp.Font = AppFonts.Subtitle;
        mtxtCurp.Location = new Point(60, 205);
        mtxtCurp.Size = new Size(360, 30);
        mtxtCurp.BorderStyle = BorderStyle.FixedSingle;

        lblFechaNac.Text = "Fecha de nacimiento";
        lblFechaNac.Font = AppFonts.BodyBold;
        lblFechaNac.AutoSize = true;
        lblFechaNac.Location = new Point(60, 260);

        dtpFechaNac.Format = DateTimePickerFormat.Short;
        dtpFechaNac.MaxDate = DateTime.Today;
        dtpFechaNac.Font = AppFonts.Subtitle;
        dtpFechaNac.Location = new Point(60, 285);
        dtpFechaNac.Size = new Size(360, 30);

        lblErrorPac.Text = "";
        lblErrorPac.ForeColor = AppColors.Danger;
        lblErrorPac.AutoSize = true;
        lblErrorPac.Location = new Point(60, 330);
        lblErrorPac.Visible = false;

        btnAccederPac.Text = "Acceder a mi portal";
        btnAccederPac.Font = AppFonts.ButtonPrimary;
        btnAccederPac.FlatStyle = FlatStyle.Flat;
        btnAccederPac.FlatAppearance.BorderSize = 0;
        btnAccederPac.BackColor = AppColors.PrioridadBaja;
        btnAccederPac.ForeColor = Color.White;
        btnAccederPac.Size = new Size(360, 48);
        btnAccederPac.Location = new Point(60, 370);
        btnAccederPac.Cursor = Cursors.Hand;
        btnAccederPac.Click += btnAccederPac_Click;

        lnkRegistrarme.Text = "¿Primera vez? Regístrate";
        lnkRegistrarme.AutoSize = true;
        lnkRegistrarme.Location = new Point(60, 440);
        lnkRegistrarme.LinkClicked += lnkRegistrarme_LinkClicked;

        lnkVolverPortal.Text = "← Volver al portal";
        lnkVolverPortal.AutoSize = true;
        lnkVolverPortal.Location = new Point(60, 470);
        lnkVolverPortal.LinkClicked += lnkVolverPortal_LinkClicked;

        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(960, 600);
        StartPosition = FormStartPosition.CenterScreen;
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Text = "Acceso - Paciente";
        AcceptButton = btnAccederPac;
        Controls.Add(splLogin);
    }
}
