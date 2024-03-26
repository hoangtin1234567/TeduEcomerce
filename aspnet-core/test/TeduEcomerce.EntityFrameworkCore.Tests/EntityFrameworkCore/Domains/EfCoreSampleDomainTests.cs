using TeduEcomerce.Samples;
using Xunit;

namespace TeduEcomerce.EntityFrameworkCore.Domains;

[Collection(TeduEcomerceTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<TeduEcomerceEntityFrameworkCoreTestModule>
{

}
