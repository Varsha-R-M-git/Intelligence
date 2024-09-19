using Qsecure_Intelligence.api.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Qsecure_Intelligence.api.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class apiController : AbpControllerBase
{
    protected apiController()
    {
        LocalizationResource = typeof(apiResource);
    }
}
