using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace TeduEcomerce.Data;

/* This is used if database provider does't define
 * ITeduEcomerceDbSchemaMigrator implementation.
 */
public class NullTeduEcomerceDbSchemaMigrator : ITeduEcomerceDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
