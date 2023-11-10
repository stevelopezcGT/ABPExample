using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace ABPExample.Data;

/* This is used if database provider does't define
 * IABPExampleDbSchemaMigrator implementation.
 */
public class NullABPExampleDbSchemaMigrator : IABPExampleDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
