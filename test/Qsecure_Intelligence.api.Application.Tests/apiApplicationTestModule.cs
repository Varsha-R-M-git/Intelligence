using Volo.Abp.Modularity;

namespace Qsecure_Intelligence.api;

[DependsOn(
    typeof(apiApplicationModule),
    typeof(apiDomainTestModule)
)]
public class apiApplicationTestModule : AbpModule
{

}
