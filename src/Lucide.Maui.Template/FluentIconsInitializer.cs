namespace Lucide.Maui;

public sealed class FluentIconsInitializer : IMauiInitializeService
{
    public void Initialize(IServiceProvider services)
    {
        var registrar = services.GetService<IFontRegistrar>();
        if (registrar is null) return;
        foreach (var cfg in IconFontConfigs.All)
        {
            registrar.Register(cfg.FontFile, cfg.FontAlias);
        }
    }
}
