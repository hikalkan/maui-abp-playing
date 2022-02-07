using Volo.Abp.Modularity;

namespace MauiDemo;

[DependsOn(
    typeof(MauiDemoApplicationModule),
    typeof(MauiDemoDomainTestModule)
    )]
public class MauiDemoApplicationTestModule : AbpModule
{

}
