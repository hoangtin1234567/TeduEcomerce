using TeduEcomerce.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Caching;
using Volo.Abp.Caching.StackExchangeRedis;
using Volo.Abp.Modularity;

namespace TeduEcomerce.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AbpCachingStackExchangeRedisModule),
    typeof(TeduEcomerceEntityFrameworkCoreModule),
    typeof(TeduEcomerceApplicationContractsModule)
    )]
public class TeduEcomerceDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpDistributedCacheOptions>(options => { options.KeyPrefix = "TeduEcomerce:"; });
    }
}
