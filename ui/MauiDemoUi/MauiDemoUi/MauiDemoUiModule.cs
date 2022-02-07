using MauiDemo;
using Volo.Abp.AspNetCore.Components.Web.BasicTheme;
using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace MauiDemoUi
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(AbpHttpClientIdentityModelModule),
        typeof(MauiDemoHttpApiClientModule),
        typeof(AbpAspNetCoreComponentsWebBasicThemeModule)
        )]
    public class MauiDemoUiModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddBlazorWebView();
        }
    }
}
