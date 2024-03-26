using System.Threading.Tasks;

namespace TeduEcomerce.Data;

public interface ITeduEcomerceDbSchemaMigrator
{
    Task MigrateAsync();
}
