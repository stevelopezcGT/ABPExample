using ABPExample.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace ABPExample.Permissions;

public class ABPExamplePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(ABPExamplePermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(ABPExamplePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<ABPExampleResource>(name);
    }
}
