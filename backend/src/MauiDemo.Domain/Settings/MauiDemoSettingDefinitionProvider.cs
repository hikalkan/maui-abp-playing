using Volo.Abp.Settings;

namespace MauiDemo.Settings;

public class MauiDemoSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(MauiDemoSettings.MySetting1));
    }
}
