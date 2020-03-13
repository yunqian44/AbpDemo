using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Czar.AbpDemo.Data;
using Volo.Abp.DependencyInjection;

namespace Czar.AbpDemo.EntityFrameworkCore
{
    public class EntityFrameworkCoreAbpDemoDbSchemaMigrator
        : IAbpDemoDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreAbpDemoDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the AbpDemoMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<AbpDemoMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}