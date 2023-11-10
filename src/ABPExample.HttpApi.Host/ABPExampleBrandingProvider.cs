using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace ABPExample;

[Dependency(ReplaceServices = true)]
public class ABPExampleBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "ABPExample";
}
