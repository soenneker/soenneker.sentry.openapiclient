using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Sentry.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class SentryOpenApiClientTests : FixturedUnitTest
{
    public SentryOpenApiClientTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
