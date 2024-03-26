using Volo.Abp.Modularity;

namespace TeduEcomerce;

[DependsOn(
    typeof(TeduEcomerceDomainModule),
    typeof(TeduEcomerceTestBaseModule)
)]
public class TeduEcomerceDomainTestModule : AbpModule
{

}
