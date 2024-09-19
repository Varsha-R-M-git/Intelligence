using Microsoft.Extensions.Localization;
using Qsecure_Intelligence.api.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace Qsecure_Intelligence.api;

[Dependency(ReplaceServices = true)]
public class apiBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<apiResource> _localizer;

    public apiBrandingProvider(IStringLocalizer<apiResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
