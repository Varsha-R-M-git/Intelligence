using Volo.Abp.Modularity;

namespace Qsecure_Intelligence.api;

public abstract class apiApplicationTestBase<TStartupModule> : apiTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
