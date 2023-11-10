using System.Threading.Tasks;

namespace ABPExample.Data;

public interface IABPExampleDbSchemaMigrator
{
    Task MigrateAsync();
}
