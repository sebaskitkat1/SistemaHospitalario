using HospitalSystem.Common;

namespace HospitalSystem.Forms.Paciente;

partial class FrmPacienteDashboard
{
    private System.ComponentModel.IContainer components = null;
    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null) components.Dispose();
        base.Dispose(disposing);
    }

    private Panel pnlTopBarPac;
    private Label lblSaludoPac;
    private Label lblPrioridadVisible;
    private Button btnLogoutPac;
    private TabControl tcPaciente;
    private TabPage tpPerfil;
    private TabPage tpAgendar;
    private TabPage tpMisCitas;

    private void InitializeComponent()
    {
        pnlTopBarPac = new Panel();
        lblSaludoPac = new Label();
        lblPrioridadVisible = new Label();
        btnLogoutPac = new Button();
        tcPaciente = new TabControl();
        tpPerfil = new TabPage();
        tpAgendar = new TabPage();
        tpMisCitas = new TabPage();

        pnlTopBarPac.Dock = DockStyle.Top;
        pnlTopBarPac.Height = 72;
        pnlTopBarPac.BackColor = AppColors.Surface;
        pnlTopBarPac.Controls.Add(btnLogoutPac);
        pnlTopBarPac.Controls.Add(lblPrioridadVisible);
        pnlTopBarPac.Controls.Add(lblSaludoPac);

        lblSaludoPac.Text = "Hola, {Nombre} {Apellido}";
        lblSaludoPac.Font = AppFonts.Title;
        lblSaludoPac.ForeColor = AppColors.TextMain;
        lblSaludoPac.AutoSize = true;
        lblSaludoPac.Location = new Point(32, 24);

        lblPrioridadVisible.Text = "  Prioridad: MEDIA  ";
        lblPrioridadVisible.Font = AppFonts.BodyBold;
        lblPrioridadVisible.ForeColor = Color.White;
        lblPrioridadVisible.BackColor = AppColors.PrioridadMedia;
        lblPrioridadVisible.AutoSize = true;
        lblPrioridadVisible.Padding = new Padding(8, 4, 8, 4);
        lblPrioridadVisible.Location = new Point(500, 28);

        btnLogoutPac.Text = "Cerrar sesión";
        btnLogoutPac.Font = AppFonts.Body;
        btnLogoutPac.FlatStyle = FlatStyle.Flat;
        btnLogoutPac.FlatAppearance.BorderSize = 1;
        btnLogoutPac.ForeColor = AppColors.Danger;
        btnLogoutPac.Location = new Point(1140, 21);
        btnLogoutPac.Size = new Size(120, 30);
        btnLogoutPac.Click += btnLogoutPac_Click;

        tcPaciente.Dock = DockStyle.Fill;
        tcPaciente.Font = AppFonts.Subtitle;
        tcPaciente.SizeMode = TabSizeMode.Fixed;
        tcPaciente.ItemSize = new Size(200, 40);
        tcPaciente.Controls.Add(tpPerfil);
        tcPaciente.Controls.Add(tpAgendar);
        tcPaciente.Controls.Add(tpMisCitas);

        tpPerfil.Text = "Mi Perfil";
        tpPerfil.BackColor = AppColors.Background;
        tpPerfil.Padding = new Padding(40);
        // TODO: añadir controles de §7.1 (txtPerfilNombre, txtPerfilApellido, mtxtPerfilCurp,
        //       dtpPerfilFechaNac, lblPerfilEdad, mtxtPerfilTel, txtPerfilEmail,
        //       lblPerfilPrioridad, btnGuardarPerfil, btnCancelarPerfil)

        tpAgendar.Text = "Agendar cita";
        tpAgendar.BackColor = AppColors.Background;
        tpAgendar.Padding = new Padding(40);
        // TODO: wizard 3 pasos (§7.2): pnlStepper + pnlPaso1/2/3 + pnlNavegacionWizard

        tpMisCitas.Text = "Mis citas";
        tpMisCitas.BackColor = AppColors.Background;
        tpMisCitas.Padding = new Padding(40);
        // TODO: filtros (rbFiltroTodas/Pend/Aten/Canc) + dgvMisCitas + pnlAccionesCita
        //       (btnReprogramar, btnCancelarCita, btnEliminarCita, btnVerReceta)

        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1280, 800);
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Portal del Paciente - Sistema Hospitalario";
        MinimumSize = new Size(1100, 700);
        Controls.Add(tcPaciente);
        Controls.Add(pnlTopBarPac);
    }
}
