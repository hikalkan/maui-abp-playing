using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MauiDemo.Data;
using Volo.Abp.DependencyInjection;

namespace MauiDemo.EntityFrameworkCore;

public class EntityFrameworkCoreMauiDemoDbSchemaMigrator
    : IMauiDemoDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreMauiDemoDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the MauiDemoDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<MauiDemoDbContext>()
            .Database
            .MigrateAsync();
    }
}
