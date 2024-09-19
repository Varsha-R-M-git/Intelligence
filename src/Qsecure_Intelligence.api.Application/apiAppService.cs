using System;
using System.Collections.Generic;
using System.Text;
using Qsecure_Intelligence.api.Localization;
using Volo.Abp.Application.Services;

namespace Qsecure_Intelligence.api;

/* Inherit your application services from this class.
 */
public abstract class apiAppService : ApplicationService
{
    protected apiAppService()
    {
        LocalizationResource = typeof(apiResource);
    }
}
