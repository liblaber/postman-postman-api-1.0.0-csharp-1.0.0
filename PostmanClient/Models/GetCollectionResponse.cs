// This file was generated by liblab | https://liblab.com/

using System.Text.Json.Serialization;

namespace PostmanClient.Models;

public record GetCollectionResponse(
    /// <value>Information about the response. For a complete list of properties, refer to the `request.responses` property in the [collection.json schema file](https://schema.postman.com/collection/json/v1.0.0/draft-07/collection.json).</value>
    [property:
        JsonPropertyName("data"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        object? Data = null,
    /// <value>A Postman-specific response that contains information about the internal performed operation.</value>
    [property:
        JsonPropertyName("meta"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        object? Meta = null,
    /// <value>The response's ID.</value>
    [property:
        JsonPropertyName("model_id"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? ModelId = null
);
