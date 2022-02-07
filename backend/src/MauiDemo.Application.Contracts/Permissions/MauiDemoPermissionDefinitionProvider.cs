using MauiDemo.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace MauiDemo.Permissions;

public class MauiDemoPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(MauiDemoPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(MauiDemoPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<MauiDemoResource>(name);
    }
}
