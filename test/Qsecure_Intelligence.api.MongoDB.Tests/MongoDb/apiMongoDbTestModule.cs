using System;
using Volo.Abp.Data;
using Volo.Abp.Modularity;

namespace Qsecure_Intelligence.api.MongoDB;

[DependsOn(
    typeof(apiApplicationTestModule),
    typeof(apiMongoDbModule)
)]
public class apiMongoDbTestModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpDbConnectionOptions>(options =>
        {
            options.ConnectionStrings.Default = apiMongoDbFixture.GetRandomConnectionString();
        });
    }
}
