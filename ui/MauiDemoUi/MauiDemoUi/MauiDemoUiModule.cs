using Volo.Abp.Modularity;

namespace MauiDemoUi
{
    public class MauiDemoUiModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddBlazorWebView();
        }
    }
}
