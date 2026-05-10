namespace Lucide.Maui;

public static partial class IconFontBuilderExtensions
{
    // Called by generated per-font helpers (UseFluentIconsRegular, etc.)
    internal static MauiAppBuilder UseIconFont(this MauiAppBuilder builder, string fontClass)
    {
        var cfg = System.Array.Find(IconFontConfigs.All, x => x.ClassName == fontClass);
        if (cfg is not null)
        {
            builder.ConfigureFonts(fonts => fonts.AddFont(cfg.FontFile, cfg.FontAlias));
        }
        return builder;
    }
}
