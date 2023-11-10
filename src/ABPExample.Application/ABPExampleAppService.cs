using System;
using System.Collections.Generic;
using System.Text;
using ABPExample.Localization;
using Volo.Abp.Application.Services;

namespace ABPExample;

/* Inherit your application services from this class.
 */
public abstract class ABPExampleAppService : ApplicationService
{
    protected ABPExampleAppService()
    {
        LocalizationResource = typeof(ABPExampleResource);
    }
}
