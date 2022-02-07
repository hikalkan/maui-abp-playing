using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace MauiDemo;

[Dependency(ReplaceServices = true)]
public class MauiDemoBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "MauiDemo";
}
