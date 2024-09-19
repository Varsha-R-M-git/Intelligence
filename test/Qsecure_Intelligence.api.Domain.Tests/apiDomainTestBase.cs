using Volo.Abp.Modularity;

namespace Qsecure_Intelligence.api;

/* Inherit from this class for your domain layer tests. */
public abstract class apiDomainTestBase<TStartupModule> : apiTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
