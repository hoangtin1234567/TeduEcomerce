using TeduEcomerce.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace TeduEcomerce.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class TeduEcomerceController : AbpControllerBase
{
    protected TeduEcomerceController()
    {
        LocalizationResource = typeof(TeduEcomerceResource);
    }
}
