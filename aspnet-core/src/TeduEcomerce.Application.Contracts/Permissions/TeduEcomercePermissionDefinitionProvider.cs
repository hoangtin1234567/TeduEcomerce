using TeduEcomerce.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace TeduEcomerce.Permissions;

public class TeduEcomercePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(TeduEcomercePermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(TeduEcomercePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<TeduEcomerceResource>(name);
    }
}
