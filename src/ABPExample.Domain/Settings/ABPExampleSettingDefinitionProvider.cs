using Volo.Abp.Settings;

namespace ABPExample.Settings;

public class ABPExampleSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(ABPExampleSettings.MySetting1));
    }
}
