using Volo.Abp.Settings;

namespace Qsecure_Intelligence.api.Settings;

public class apiSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(apiSettings.MySetting1));
    }
}
