// This file was generated by liblab | https://liblab.com/

using System.Text.Json.Serialization;

namespace PostmanClient.Models;

/// <summary>Information about the schema.</summary>
public record GetApiSchema2(
    /// <value>The schema's ID.</value>
    [property: JsonPropertyName("id"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        string? Id = null,
    /// <value>The schema's type.</value>
    [property:
        JsonPropertyName("type"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? Type_ = null,
    /// <value>The user ID of the user that created the schema.</value>
    [property:
        JsonPropertyName("createdBy"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? CreatedBy = null,
    /// <value>The user ID of the user that last updated the schema.</value>
    [property:
        JsonPropertyName("updatedBy"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? UpdatedBy = null,
    /// <value>The date and time at which the schema was created.</value>
    [property:
        JsonPropertyName("createdAt"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? CreatedAt = null,
    /// <value>The date and time at which the schema was last updated.</value>
    [property:
        JsonPropertyName("updatedAt"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? UpdatedAt = null,
    /// <value>The schema file, in a bundled format.</value>
    [property:
        JsonPropertyName("content"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? Content = null
);
