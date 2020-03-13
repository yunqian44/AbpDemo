using System.Threading.Tasks;

namespace Czar.AbpDemo.Data
{
    public interface IAbpDemoDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
