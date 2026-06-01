using HospitalSystem.Common;

namespace HospitalSystem.Forms.Shared;

/// <summary>
/// §5.1 Modal de alta/edición de paciente.
/// TODO controles:
///   - txtNombrePac (MaxLength=80), txtApellidoPac (MaxLength=80)
///   - mtxtCurpPac (Mask CURP, validar UNIQUE)
///   - dtpFechaNacPac, lblEdadCalc
///   - mtxtTelPac, txtEmailPac
///   - cboPrioridadPac (DropDownList: 1-URGENTE / 2-ALTA / 3-MEDIA / 4-BAJA)
///   - pnlIndicadorPrioridad (cuadro de color que reacciona al combo)
///   - chkActivoPac
///   - btnGuardarPac, btnCancelarPac
///   - ErrorProvider errPac
/// </summary>
public class FrmEditPaciente : Form
{
    public FrmEditPaciente()
    {
        Text = "Paciente"; ClientSize = new Size(560, 620);
        StartPosition = FormStartPosition.CenterParent;
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false; MinimizeBox = false;
        BackColor = AppColors.Surface;
        Controls.Add(new Label
        {
            Text = "Modal Paciente — añadir TableLayoutPanel con campos del §5.1",
            Font = AppFonts.Subtitle, ForeColor = AppColors.TextMuted,
            Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleCenter
        });
    }
}
