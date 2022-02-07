using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace MauiDemo.Data;

/* This is used if database provider does't define
 * IMauiDemoDbSchemaMigrator implementation.
 */
public class NullMauiDemoDbSchemaMigrator : IMauiDemoDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
