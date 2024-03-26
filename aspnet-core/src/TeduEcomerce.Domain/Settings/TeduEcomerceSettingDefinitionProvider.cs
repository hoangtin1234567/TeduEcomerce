using Volo.Abp.Settings;

namespace TeduEcomerce.Settings;

public class TeduEcomerceSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(TeduEcomerceSettings.MySetting1));
    }
}
