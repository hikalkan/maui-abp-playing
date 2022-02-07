using MauiDemo.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace MauiDemo.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(MauiDemoEntityFrameworkCoreModule),
    typeof(MauiDemoApplicationContractsModule)
    )]
public class MauiDemoDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
