using System.Drawing;

namespace HospitalSystem.Common;

/// <summary>
/// Fuentes reutilizables (ver §0 del documento de diseño).
/// </summary>
public static class AppFonts
{
    private const string Family = "Segoe UI";

    public static readonly Font Body          = new(Family, 9F, FontStyle.Regular);
    public static readonly Font BodyBold      = new(Family, 9F, FontStyle.Bold);
    public static readonly Font Subtitle      = new(Family, 11F, FontStyle.Regular);
    public static readonly Font Title         = new(Family, 14F, FontStyle.Bold);
    public static readonly Font TitleLarge    = new(Family, 18F, FontStyle.Bold);
    public static readonly Font Display       = new(Family, 24F, FontStyle.Bold);
    public static readonly Font ButtonPrimary = new(Family, 10F, FontStyle.Bold);
}
