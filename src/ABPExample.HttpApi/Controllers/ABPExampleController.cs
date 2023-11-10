using ABPExample.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ABPExample.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class ABPExampleController : AbpControllerBase
{
    protected ABPExampleController()
    {
        LocalizationResource = typeof(ABPExampleResource);
    }
}
