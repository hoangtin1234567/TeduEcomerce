using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace TeduEcomerce;

[Dependency(ReplaceServices = true)]
public class TeduEcomerceBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "TeduEcomerce";
}
