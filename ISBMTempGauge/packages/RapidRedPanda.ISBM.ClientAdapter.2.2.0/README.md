# RapidRedPanda.ISBM.ClientAdapter

RapidRedPanda.ISBM.ClientAdapter is a .NET client library for working with ISBM 2.0 services in Open Industrial Interoperability Ecosystem (OIIE) scenarios. It provides a developer-friendly adapter for ISA-95 ISBM 2.0 message bus implementations, including publication, subscription, request/response, and channel management workflows.

## Package Information

- Package ID: `RapidRedPanda.ISBM.ClientAdapter`
- Current version: `2.2.0`
- License: MIT
- Documentation and samples: [RapidRedPanda.ISBM.ClientAdapter.SDK.Samples](https://github.com/claire-wong/RapidRedPanda.ISBM.ClientAdapter.SDK.Samples)

## Target Frameworks

RapidRedPanda.ISBM.ClientAdapter 2.2.0 ships package assets for:

- `netstandard2.0`
- `net8.0`
- `net10.0`

## Core Capabilities

- Channel management
- Publication workflows
- Subscription/read publication workflows
- Request/response workflows
- Synchronous and asynchronous APIs
- MessageContent media type handling
- Basic and custom authentication support

## Quick Start

The example below opens a publication session, posts one JSON object message to a topic, and closes the session.

```csharp
using RapidRedPanda.ISBM.ClientAdapter;
using RapidRedPanda.ISBM.ClientAdapter.ResponseType;

string hostAddress = "https://example.com/isbm/2.0";
string channelId = "Demo.Channel";

ProviderPublicationService publicationProvider = new ProviderPublicationService();

OpenPublicationSessionResponse openResponse =
    publicationProvider.OpenPublicationSession(hostAddress, channelId);

PostPublicationResponse postResponse = publicationProvider.PostPublication(
    hostAddress,
    openResponse.SessionID,
    "Demo.Topic",
    "{\"value\":1}");

publicationProvider.ClosePublicationSession(hostAddress, openResponse.SessionID);

string messageId = postResponse.MessageID;
```

## MessageContent Media Type Handling

When `MediaType` is omitted, empty, or whitespace, message content is treated as native JSON object content. In native JSON-object mode, the content must parse as a JSON object and is sent without `mediaType`.

XML, plain text, and JSON string payloads should provide explicit `MediaType` values, such as `application/xml`, `text/plain`, or `application/json`.

```csharp
using RapidRedPanda.ISBM.ClientAdapter.EndpointOptions;

PostPublicationOptions options = new PostPublicationOptions
{
    MediaType = "application/xml"
};

publicationProvider.PostPublication(
    hostAddress,
    sessionId,
    "Demo.Topic",
    "<message><value>1</value></message>",
    options);
```

`PostRequestOptions.MediaType` and `PostResponseOptions.MediaType` are also supported for request/response workflows.

## FilterExpression Options

Subscription sessions and provider request sessions can include ISBM REST `filterExpressions`. `ApplicableMediaTypes` is `List<string>` and serializes as a JSON string array aligned with the ISBM 2.0 REST wire format.

```csharp
using System.Collections.Generic;
using RapidRedPanda.ISBM.ClientAdapter.EndpointOptions;

OpenSubscriptionSessionOptions options = new OpenSubscriptionSessionOptions
{
    FilterExpressions = new List<FilterExpression>
    {
        new FilterExpression
        {
            ApplicableMediaTypes = new List<string>
            {
                "application/json"
            },
            ExpressionString = new ExpressionString
            {
                Expression = "$.DataArea.Show.Measurement[?(@.value > 100)]",
                Language = "JsonPath",
                LanguageVersion = "1.0"
            }
        }
    }
};
```

`LanguageVersion`, `ApplicableMediaTypes`, and `Namespaces` are optional. Namespace entries serialize with REST field names `prefix` and `name`.

```csharp
FilterExpression xmlFilter = new FilterExpression
{
    ApplicableMediaTypes = new List<string>
    {
        "application/xml"
    },
    ExpressionString = new ExpressionString
    {
        Expression = "/x:Root/x:Measurement[x:Value > 100]",
        Language = "XPath",
        LanguageVersion = "1.0"
    },
    Namespaces = new List<FilterExpressionNamespace>
    {
        new FilterExpressionNamespace
        {
            Prefix = "x",
            Name = "urn:example"
        }
    }
};
```

The adapter serializes `FilterExpression` values according to the ISBM 2.0 REST schema. The adapter does not evaluate filters locally. Backend filtering support depends on the Host implementation, and Host support requires a Host version that accepts and persists `filterExpressions`.

Migration note: existing callers using `ApplicableMediaType` objects should replace them with string entries.

Old:

```csharp
ApplicableMediaTypes = new List<ApplicableMediaType>
{
    new ApplicableMediaType { MediaType = "application/json" }
}
```

New:

```csharp
ApplicableMediaTypes = new List<string>
{
    "application/json"
}
```

## Documentation and Samples

This README is a quick start for the NuGet package. Full interface documentation, complete service-by-service examples, toolkit scenarios, and advanced option validation are maintained in the RapidRedPanda ISBM ClientAdapter SDK Samples repository:

https://github.com/claire-wong/RapidRedPanda.ISBM.ClientAdapter.SDK.Samples

## Release Notes

RapidRedPanda.ISBM.ClientAdapter 2.2.0 aligns the `FilterExpression` REST wire format with ISBM 2.0. `ApplicableMediaTypes` is now represented as string entries, and `languageVersion`, `applicableMediaTypes`, and `namespaces` remain optional.

RapidRedPanda.ISBM.ClientAdapter 2.1.2 omits empty PostRequest expiry values while preserving explicit expiry and MessageContent media type behavior.

## Useful Links

- [OpenO&M](https://openoandm.org/)
- [MIMOSA](https://www.mimosa.org/)
- [OIIE](https://www.mimosa.org/open-industrial-interoperability-ecosystem-oiie/)
- [ISBM 2.0](https://openoandm.org/files/standards/ISBM-2.0.pdf)
- [OAGi](https://oagi.org/)

## License

MIT
