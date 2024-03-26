using Volo.Abp.Modularity;

namespace TeduEcomerce;

/* Inherit from this class for your domain layer tests. */
public abstract class TeduEcomerceDomainTestBase<TStartupModule> : TeduEcomerceTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
