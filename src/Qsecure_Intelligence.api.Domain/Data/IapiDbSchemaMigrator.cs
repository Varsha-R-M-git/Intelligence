using System.Threading.Tasks;

namespace Qsecure_Intelligence.api.Data;

public interface IapiDbSchemaMigrator
{
    Task MigrateAsync();
}
