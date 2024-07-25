// This file was generated by liblab | https://liblab.com/

using System.Text.Json.Serialization;

namespace PostmanClient.Models;

/// <summary>Information about the API.</summary>
public record CreateApiRequest(
    /// <value>The API's name.</value>
    [property: JsonPropertyName("name")]
        string Name,
    /// <value>The API's short summary.</value>
    [property:
        JsonPropertyName("summary"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? Summary = null,
    /// <value>The API's description. This supports Markdown formatting.</value>
    [property:
        JsonPropertyName("description"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? Description = null
);
