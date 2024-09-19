using Qsecure_Intelligence.api.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Qsecure_Intelligence.api.Permissions;

public class apiPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(apiPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(apiPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<apiResource>(name);
    }
}
