using System;
using System.Collections.Generic;
using System.Text;
using TeduEcomerce.Localization;
using Volo.Abp.Application.Services;

namespace TeduEcomerce;

/* Inherit your application services from this class.
 */
public abstract class TeduEcomerceAppService : ApplicationService
{
    protected TeduEcomerceAppService()
    {
        LocalizationResource = typeof(TeduEcomerceResource);
    }
}
