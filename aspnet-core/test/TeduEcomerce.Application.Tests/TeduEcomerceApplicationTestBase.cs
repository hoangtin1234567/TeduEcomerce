using Volo.Abp.Modularity;

namespace TeduEcomerce;

public abstract class TeduEcomerceApplicationTestBase<TStartupModule> : TeduEcomerceTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
