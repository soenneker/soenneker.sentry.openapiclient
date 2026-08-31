[![](https://img.shields.io/nuget/v/soenneker.sentry.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.sentry.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.sentry.openapiclient/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.sentry.openapiclient/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.sentry.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.sentry.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.sentry.openapiclient/codeql.yml?style=for-the-badge&label=codeql)](https://github.com/soenneker/soenneker.sentry.openapiclient/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Sentry.OpenApiClient

Generated request builders and models for Sentry organizations, projects, teams, issues, events, releases, alerts, integrations, and account resources.

## Installation

```bash
dotnet add package Soenneker.Sentry.OpenApiClient
```

## Usage

```csharp
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using Soenneker.Sentry.OpenApiClient;

using var httpClient = new HttpClient();
httpClient.DefaultRequestHeaders.Authorization =
    new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", authToken);

var adapter = new HttpClientRequestAdapter(
    new AnonymousAuthenticationProvider(),
    httpClient: httpClient)
{
    BaseUrl = "https://sentry.io"
};

var client = new SentryOpenApiClient(adapter);
var organizations = await client.Api.Zero.Organizations.GetAsync(
    cancellationToken: cancellationToken);
```

Set `BaseUrl` explicitly because the generated schema default contains an unresolved `{region}` placeholder. For self-hosted Sentry, use the installation origin without appending `/api/0`; the generated builders include that route prefix.

Sentry auth tokens use the bearer scheme. The anonymous Kiota authentication provider is intentional because the supplied `HttpClient` already carries the `Authorization` header.
