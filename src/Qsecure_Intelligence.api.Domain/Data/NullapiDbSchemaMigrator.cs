using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Qsecure_Intelligence.api.Data;

/* This is used if database provider does't define
 * IapiDbSchemaMigrator implementation.
 */
public class NullapiDbSchemaMigrator : IapiDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
