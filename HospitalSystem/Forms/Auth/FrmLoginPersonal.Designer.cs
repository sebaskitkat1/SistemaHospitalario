using HospitalSystem.Common;

namespace HospitalSystem.Forms.Auth;

partial class FrmLoginPersonal
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
    private Label lblTituloLogin;
    private Label lblUsuario;
    private TextBox txtUsuario;
    private Label lblPassword;
    private TextBox txtPassword;
    private CheckBox chkMostrarPwd;
    private Label lblErrorLogin;
    private Button btnIniciarSesion;
    private LinkLabel lnkVolverPortal;
    private ErrorProvider errLogin;

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();
        splLogin = new SplitContainer();
        pnlBranding = new Panel();
        lblBrandTagline = new Label();
        pnlFormulario = new Panel();
        lnkVolverPortal = new LinkLabel();
        btnIniciarSesion = new Button();
        lblErrorLogin = new Label();
        chkMostrarPwd = new CheckBox();
        txtPassword = new TextBox();
        lblPassword = new Label();
        txtUsuario = new TextBox();
        lblUsuario = new Label();
        lblTituloLogin = new Label();
        errLogin = new ErrorProvider(components);
        ((System.ComponentModel.ISupportInitialize)splLogin).BeginInit();
        splLogin.Panel1.SuspendLayout();
        splLogin.Panel2.SuspendLayout();
        splLogin.SuspendLayout();
        pnlBranding.SuspendLayout();
        pnlFormulario.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)errLogin).BeginInit();
        SuspendLayout();
        // 
        // splLogin
        // 
        splLogin.Dock = DockStyle.Fill;
        splLogin.IsSplitterFixed = true;
        splLogin.Location = new Point(0, 0);
        splLogin.Name = "splLogin";
        // 
        // splLogin.Panel1
        // 
        splLogin.Panel1.Controls.Add(pnlBranding);
        // 
        // splLogin.Panel2
        // 
        splLogin.Panel2.Controls.Add(pnlFormulario);
        splLogin.Size = new Size(1110, 600);
        splLogin.SplitterDistance = 895;
        splLogin.TabIndex = 0;
        // 
        // pnlBranding
        // 
        pnlBranding.BackColor = Color.FromArgb(31, 111, 235);
        pnlBranding.Controls.Add(lblBrandTagline);
        pnlBranding.Dock = DockStyle.Fill;
        pnlBranding.Location = new Point(0, 0);
        pnlBranding.Name = "pnlBranding";
        pnlBranding.Size = new Size(895, 600);
        pnlBranding.TabIndex = 0;
        // 
        // lblBrandTagline
        // 
        lblBrandTagline.AutoSize = true;
        lblBrandTagline.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
        lblBrandTagline.ForeColor = Color.White;
        lblBrandTagline.Location = new Point(40, 320);
        lblBrandTagline.Name = "lblBrandTagline";
        lblBrandTagline.Size = new Size(278, 64);
        lblBrandTagline.TabIndex = 0;
        lblBrandTagline.Text = "Cuidamos vidas,\ngestionamos confianza";
        // 
        // pnlFormulario
        // 
        pnlFormulario.BackColor = Color.White;
        pnlFormulario.Controls.Add(lnkVolverPortal);
        pnlFormulario.Controls.Add(btnIniciarSesion);
        pnlFormulario.Controls.Add(lblErrorLogin);
        pnlFormulario.Controls.Add(chkMostrarPwd);
        pnlFormulario.Controls.Add(txtPassword);
        pnlFormulario.Controls.Add(lblPassword);
        pnlFormulario.Controls.Add(txtUsuario);
        pnlFormulario.Controls.Add(lblUsuario);
        pnlFormulario.Controls.Add(lblTituloLogin);
        pnlFormulario.Dock = DockStyle.Fill;
        pnlFormulario.Location = new Point(0, 0);
        pnlFormulario.Name = "pnlFormulario";
        pnlFormulario.Padding = new Padding(60);
        pnlFormulario.Size = new Size(211, 600);
        pnlFormulario.TabIndex = 0;
        // 
        // lnkVolverPortal
        // 
        lnkVolverPortal.AutoSize = true;
        lnkVolverPortal.Font = new Font("Segoe UI", 9F);
        lnkVolverPortal.Location = new Point(60, 470);
        lnkVolverPortal.Name = "lnkVolverPortal";
        lnkVolverPortal.Size = new Size(98, 15);
        lnkVolverPortal.TabIndex = 0;
        lnkVolverPortal.TabStop = true;
        lnkVolverPortal.Text = "← Volver al portal";
        lnkVolverPortal.LinkClicked += lnkVolverPortal_LinkClicked;
        // 
        // btnIniciarSesion
        // 
        btnIniciarSesion.BackColor = Color.FromArgb(31, 111, 235);
        btnIniciarSesion.Cursor = Cursors.Hand;
        btnIniciarSesion.FlatAppearance.BorderSize = 0;
        btnIniciarSesion.FlatStyle = FlatStyle.Flat;
        btnIniciarSesion.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        btnIniciarSesion.ForeColor = Color.White;
        btnIniciarSesion.Location = new Point(60, 400);
        btnIniciarSesion.Name = "btnIniciarSesion";
        btnIniciarSesion.Size = new Size(360, 48);
        btnIniciarSesion.TabIndex = 1;
        btnIniciarSesion.Text = "Iniciar sesión";
        btnIniciarSesion.UseVisualStyleBackColor = false;
        btnIniciarSesion.Click += btnIniciarSesion_Click;
        // 
        // lblErrorLogin
        // 
        lblErrorLogin.AutoSize = true;
        lblErrorLogin.Font = new Font("Segoe UI", 9F);
        lblErrorLogin.ForeColor = Color.FromArgb(220, 38, 38);
        lblErrorLogin.Location = new Point(60, 360);
        lblErrorLogin.Name = "lblErrorLogin";
        lblErrorLogin.Size = new Size(0, 15);
        lblErrorLogin.TabIndex = 2;
        lblErrorLogin.Visible = false;
        // 
        // chkMostrarPwd
        // 
        chkMostrarPwd.AutoSize = true;
        chkMostrarPwd.Font = new Font("Segoe UI", 9F);
        chkMostrarPwd.ForeColor = Color.FromArgb(100, 116, 139);
        chkMostrarPwd.Location = new Point(60, 325);
        chkMostrarPwd.Name = "chkMostrarPwd";
        chkMostrarPwd.Size = new Size(128, 19);
        chkMostrarPwd.TabIndex = 3;
        chkMostrarPwd.Text = "Mostrar contraseña";
        chkMostrarPwd.CheckedChanged += chkMostrarPwd_CheckedChanged;
        // 
        // txtPassword
        // 
        txtPassword.BorderStyle = BorderStyle.FixedSingle;
        txtPassword.Font = new Font("Segoe UI", 11F);
        txtPassword.Location = new Point(60, 285);
        txtPassword.Name = "txtPassword";
        txtPassword.Size = new Size(360, 27);
        txtPassword.TabIndex = 4;
        txtPassword.UseSystemPasswordChar = true;
        // 
        // lblPassword
        // 
        lblPassword.AutoSize = true;
        lblPassword.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblPassword.ForeColor = Color.FromArgb(30, 41, 59);
        lblPassword.Location = new Point(60, 260);
        lblPassword.Name = "lblPassword";
        lblPassword.Size = new Size(69, 15);
        lblPassword.TabIndex = 5;
        lblPassword.Text = "Contraseña";
        // 
        // txtUsuario
        // 
        txtUsuario.BorderStyle = BorderStyle.FixedSingle;
        txtUsuario.Font = new Font("Segoe UI", 11F);
        txtUsuario.Location = new Point(60, 205);
        txtUsuario.MaxLength = 50;
        txtUsuario.Name = "txtUsuario";
        txtUsuario.Size = new Size(360, 27);
        txtUsuario.TabIndex = 6;
        // 
        // lblUsuario
        // 
        lblUsuario.AutoSize = true;
        lblUsuario.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        lblUsuario.ForeColor = Color.FromArgb(30, 41, 59);
        lblUsuario.Location = new Point(60, 180);
        lblUsuario.Name = "lblUsuario";
        lblUsuario.Size = new Size(49, 15);
        lblUsuario.TabIndex = 7;
        lblUsuario.Text = "Usuario";
        // 
        // lblTituloLogin
        // 
        lblTituloLogin.AutoSize = true;
        lblTituloLogin.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
        lblTituloLogin.ForeColor = Color.FromArgb(30, 41, 59);
        lblTituloLogin.Location = new Point(60, 100);
        lblTituloLogin.Name = "lblTituloLogin";
        lblTituloLogin.Size = new Size(165, 32);
        lblTituloLogin.TabIndex = 8;
        lblTituloLogin.Text = "Iniciar sesión";
        // 
        // errLogin
        // 
        errLogin.ContainerControl = this;
        // 
        // FrmLoginPersonal
        // 
        AcceptButton = btnIniciarSesion;
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1110, 600);
        Controls.Add(splLogin);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = "FrmLoginPersonal";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Iniciar sesión - Personal";
        splLogin.Panel1.ResumeLayout(false);
        splLogin.Panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)splLogin).EndInit();
        splLogin.ResumeLayout(false);
        pnlBranding.ResumeLayout(false);
        pnlBranding.PerformLayout();
        pnlFormulario.ResumeLayout(false);
        pnlFormulario.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)errLogin).EndInit();
        ResumeLayout(false);
    }
}
