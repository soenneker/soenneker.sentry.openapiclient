using Soenneker.Tests.HostedUnit;

namespace Soenneker.Sentry.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class SentryOpenApiClientTests : HostedUnitTest
{
    public SentryOpenApiClientTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
