using Volo.Abp.Modularity;

namespace ABPExample;

[DependsOn(
    typeof(ABPExampleApplicationModule),
    typeof(ABPExampleDomainTestModule)
    )]
public class ABPExampleApplicationTestModule : AbpModule
{

}
