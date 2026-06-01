using System.Drawing;

namespace HospitalSystem.Common;

/// <summary>
/// Paleta de colores centralizada (ver §0 del documento de diseño).
/// </summary>
public static class AppColors
{
    // Base
    public static readonly Color Background = ColorTranslator.FromHtml("#F7F9FC");
    public static readonly Color Primary    = ColorTranslator.FromHtml("#1F6FEB");
    public static readonly Color Sidebar    = ColorTranslator.FromHtml("#0F172A");
    public static readonly Color TextMain   = ColorTranslator.FromHtml("#1E293B");
    public static readonly Color TextMuted  = ColorTranslator.FromHtml("#64748B");
    public static readonly Color Surface    = Color.White;
    public static readonly Color Border     = ColorTranslator.FromHtml("#E2E8F0");

    // Prioridades de paciente
    public static readonly Color PrioridadUrgente = ColorTranslator.FromHtml("#E5484D");
    public static readonly Color PrioridadAlta    = ColorTranslator.FromHtml("#F5A524");
    public static readonly Color PrioridadMedia   = ColorTranslator.FromHtml("#F4D35E");
    public static readonly Color PrioridadBaja    = ColorTranslator.FromHtml("#22C55E");

    // Estados de cita
    public static readonly Color EstadoPendiente = ColorTranslator.FromHtml("#3B82F6");
    public static readonly Color EstadoAtendida  = ColorTranslator.FromHtml("#22C55E");
    public static readonly Color EstadoCancelada = ColorTranslator.FromHtml("#94A3B8");

    // Zona peligrosa (mantenimiento)
    public static readonly Color Danger     = ColorTranslator.FromHtml("#DC2626");
    public static readonly Color DangerSoft = ColorTranslator.FromHtml("#FEE2E2");
}
