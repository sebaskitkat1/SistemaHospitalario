using HospitalSystem.Common;

namespace HospitalSystem.Forms.Shared;

/// <summary>§3 Registro de paciente (autoservicio). Mismos campos que FrmEditPaciente sin asignar prioridad (default 3).</summary>
public class FrmRegistroPaciente : Form
{
    public FrmRegistroPaciente()
    {
        Text = "Registro de paciente"; ClientSize = new Size(560, 560);
        StartPosition = FormStartPosition.CenterParent;
        FormBorderStyle = FormBorderStyle.FixedDialog;
        BackColor = AppColors.Surface;
        Controls.Add(new Label { Text = "Registro de Paciente — §3", Font = AppFonts.Subtitle,
            ForeColor = AppColors.TextMuted, Dock = DockStyle.Fill,
            TextAlign = ContentAlignment.MiddleCenter });
    }
}

/// <summary>§7.3 Reprogramar cita (sólo si está PENDIENTE).</summary>
public class FrmReprogramarCita : Form
{
    public FrmReprogramarCita()
    {
        Text = "Reprogramar cita"; ClientSize = new Size(440, 320);
        StartPosition = FormStartPosition.CenterParent;
        FormBorderStyle = FormBorderStyle.FixedDialog;
        BackColor = AppColors.Surface;
        Controls.Add(new Label { Text = "Reprogramar — §7.3", Font = AppFonts.Subtitle,
            ForeColor = AppColors.TextMuted, Dock = DockStyle.Fill,
            TextAlign = ContentAlignment.MiddleCenter });
    }
}

/// <summary>§7.2 Confirmación visual de cita agendada (animación + número de cita).</summary>
public class FrmCitaAgendadaExito : Form
{
    public FrmCitaAgendadaExito()
    {
        Text = "¡Cita agendada!"; ClientSize = new Size(440, 320);
        StartPosition = FormStartPosition.CenterParent;
        FormBorderStyle = FormBorderStyle.FixedDialog;
        BackColor = AppColors.Surface;
        Controls.Add(new Label { Text = "✓ Cita agendada — §7.2", Font = AppFonts.Title,
            ForeColor = AppColors.PrioridadBaja, Dock = DockStyle.Fill,
            TextAlign = ContentAlignment.MiddleCenter });
    }
}

/// <summary>§7.3 Receta read-only para el paciente.</summary>
public class FrmVerReceta : Form
{
    public FrmVerReceta()
    {
        Text = "Mi receta"; ClientSize = new Size(560, 520);
        StartPosition = FormStartPosition.CenterParent;
        FormBorderStyle = FormBorderStyle.FixedDialog;
        BackColor = AppColors.Surface;
        Controls.Add(new Label { Text = "Ver Receta — §7.3 (sólo lectura + Imprimir/PDF)",
            Font = AppFonts.Subtitle, ForeColor = AppColors.TextMuted,
            Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter });
    }
}
