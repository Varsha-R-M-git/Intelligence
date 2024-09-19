using Qsecure_Intelligence.api.MongoDB;
using Qsecure_Intelligence.api.Samples;
using Xunit;

namespace Qsecure_Intelligence.api.MongoDb.Applications;

[Collection(apiTestConsts.CollectionDefinitionName)]
public class MongoDBSampleAppServiceTests : SampleAppServiceTests<apiMongoDbTestModule>
{

}
