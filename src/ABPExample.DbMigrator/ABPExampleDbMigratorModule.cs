using ABPExample.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace ABPExample.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(ABPExampleEntityFrameworkCoreModule),
    typeof(ABPExampleApplicationContractsModule)
    )]
public class ABPExampleDbMigratorModule : AbpModule
{
}
