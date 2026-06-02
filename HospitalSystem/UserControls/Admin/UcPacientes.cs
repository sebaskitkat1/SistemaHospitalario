using HospitalSystem.Common;
using HospitalSystem.Data;

namespace HospitalSystem.UserControls.Admin;

public class UcPacientes : UserControl
{
    private DataGridView dgv = new();
    private TextBox txtBuscar = new();
    private ComboBox cboPrioridad = new();
    private Button btnNuevo = new();
    private Button btnRefrescar = new();

    public UcPacientes()
    {
        BackColor = AppColors.Background;
        InicializarComponentes();
        CargarPacientes();
    }

    private void InicializarComponentes()
    {
        // Toolbar
        var toolbar = new Panel { Dock = DockStyle.Top, Height = 50, Padding = new Padding(10, 8, 10, 8) };

        txtBuscar.PlaceholderText = "Buscar paciente...";
        txtBuscar.Width = 200;
        txtBuscar.TextChanged += (s, e) => CargarPacientes();

        cboPrioridad.Items.AddRange(new object[] { "Todas", "URGENTE", "ALTA", "MEDIA", "BAJA" });
        cboPrioridad.SelectedIndex = 0;
        cboPrioridad.Width = 120;
        cboPrioridad.SelectedIndexChanged += (s, e) => CargarPacientes();

        btnNuevo.Text = "+ Nuevo Paciente";
        btnNuevo.BackColor = AppColors.Primary;
        btnNuevo.ForeColor = Color.White;
        btnNuevo.FlatStyle = FlatStyle.Flat;
        btnNuevo.Click += BtnNuevo_Click;

        btnRefrescar.Text = "↻ Refrescar";
        btnRefrescar.Click += (s, e) => CargarPacientes();

        toolbar.Controls.AddRange(new Control[] { txtBuscar, cboPrioridad, btnNuevo, btnRefrescar });
        var fl = new FlowLayoutPanel { Dock = DockStyle.Fill };
        fl.Controls.AddRange(new Control[] { txtBuscar, cboPrioridad, btnNuevo, btnRefrescar });
        toolbar.Controls.Add(fl);

        // Grid
        dgv.Dock = DockStyle.Fill;
        dgv.ReadOnly = true;
        dgv.AllowUserToAddRows = false;
        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        dgv.BackgroundColor = Color.White;

        Controls.Add(dgv);
        Controls.Add(toolbar);
    }

    private void CargarPacientes()
    {
        int? prioridad = cboPrioridad.SelectedIndex switch
        {
            1 => 1,
            2 => 2,
            3 => 3,
            4 => 4,
            _ => null
        };

        var pacientes = PacienteService.ObtenerTodos(
            txtBuscar.Text.Trim(),
            prioridad
        );

        dgv.DataSource = pacientes.Select(p => new
        {
            ID = p.PacId,
            Nombre = p.NombreCompleto,
            CURP = p.PacCurp,
            Telefono = p.PacTelefono,
            Email = p.PacEmail,
            Prioridad = p.PrioridadTexto,
        }).ToList();
    }

    private void BtnNuevo_Click(object? sender, EventArgs e)
    {
        // Aqui va el modal de nuevo paciente cuando este listo
        MessageBox.Show("Modal de nuevo paciente próximamente.", "Info",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        CargarPacientes();
    }
}