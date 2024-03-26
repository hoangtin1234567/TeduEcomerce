using TeduEcomerce.Samples;
using Xunit;

namespace TeduEcomerce.EntityFrameworkCore.Applications;

[Collection(TeduEcomerceTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<TeduEcomerceEntityFrameworkCoreTestModule>
{

}
