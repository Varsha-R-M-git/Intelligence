using Qsecure_Intelligence.api.Samples;
using Xunit;

namespace Qsecure_Intelligence.api.MongoDB.Domains;

[Collection(apiTestConsts.CollectionDefinitionName)]
public class MongoDBSampleDomainTests : SampleDomainTests<apiMongoDbTestModule>
{

}
