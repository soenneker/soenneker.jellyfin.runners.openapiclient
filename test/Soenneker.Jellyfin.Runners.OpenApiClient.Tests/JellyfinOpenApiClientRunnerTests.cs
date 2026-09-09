using Soenneker.Tests.HostedUnit;

namespace Soenneker.Jellyfin.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class JellyfinOpenApiClientRunnerTests : HostedUnitTest
{
    public JellyfinOpenApiClientRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
