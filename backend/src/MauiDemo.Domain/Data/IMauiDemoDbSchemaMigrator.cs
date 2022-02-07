using System.Threading.Tasks;

namespace MauiDemo.Data;

public interface IMauiDemoDbSchemaMigrator
{
    Task MigrateAsync();
}
