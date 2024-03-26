using Volo.Abp.Modularity;

namespace TeduEcomerce;

[DependsOn(
    typeof(TeduEcomerceApplicationModule),
    typeof(TeduEcomerceDomainTestModule)
)]
public class TeduEcomerceApplicationTestModule : AbpModule
{

}
