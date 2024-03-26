using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TeduEcomerce.Data;
using Volo.Abp.DependencyInjection;

namespace TeduEcomerce.EntityFrameworkCore;

public class EntityFrameworkCoreTeduEcomerceDbSchemaMigrator
    : ITeduEcomerceDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreTeduEcomerceDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the TeduEcomerceDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<TeduEcomerceDbContext>()
            .Database
            .MigrateAsync();
    }
}
