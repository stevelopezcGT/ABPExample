using ABPExample.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace ABPExample;

[DependsOn(
    typeof(ABPExampleEntityFrameworkCoreTestModule)
    )]
public class ABPExampleDomainTestModule : AbpModule
{

}
