using Volo.Abp.Modularity;

namespace Qsecure_Intelligence.api;

[DependsOn(
    typeof(apiDomainModule),
    typeof(apiTestBaseModule)
)]
public class apiDomainTestModule : AbpModule
{

}
