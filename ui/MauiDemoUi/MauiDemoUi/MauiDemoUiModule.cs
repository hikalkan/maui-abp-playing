using Blazorise.Bootstrap5;
using Blazorise.Icons.FontAwesome;
using MauiDemo;
using MyCompanyName.MyProjectName.Blazor.Menus;
using Volo.Abp.AspNetCore.Components.Web.BasicTheme;
using Volo.Abp.AspNetCore.Components.Web.Theming.Routing;
using Volo.Abp.Autofac;
using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;
using Volo.Abp.UI.Navigation;

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

            ConfigureMenu(context);
            ConfigureRouter(context);
            ConfigureBlazorise(context);
        }

        private void ConfigureMenu(ServiceConfigurationContext context)
        {
            Configure<AbpNavigationOptions>(options =>
            {
                options.MenuContributors.Add(new MyProjectNameMenuContributor(context.Services.GetConfiguration()));
            });
        }

        private void ConfigureRouter(ServiceConfigurationContext context)
        {
            Configure<AbpRouterOptions>(options =>
            {
                options.AppAssembly = typeof(MauiDemoUiModule).Assembly;
            });
        }

        private void ConfigureBlazorise(ServiceConfigurationContext context)
        {
            context.Services
                .AddBootstrap5Providers()
                .AddFontAwesomeIcons();
        }
    }
}
