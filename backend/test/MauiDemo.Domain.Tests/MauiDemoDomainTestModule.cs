using MauiDemo.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace MauiDemo;

[DependsOn(
    typeof(MauiDemoEntityFrameworkCoreTestModule)
    )]
public class MauiDemoDomainTestModule : AbpModule
{

}
