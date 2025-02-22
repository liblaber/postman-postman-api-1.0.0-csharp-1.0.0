// This file was generated by liblab | https://liblab.com/

using System.Text.Json.Serialization;

namespace PostmanClient.Models;

/// <summary>Information about the Private API Network element.</summary>
public record PanElementCreated(
    /// <value>The date and time at which the element was added.</value>
    [property:
        JsonPropertyName("addedAt"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? AddedAt = null,
    /// <value>The user who added the element.</value>
    [property:
        JsonPropertyName("addedBy"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? AddedBy = null,
    /// <value>The user who created the element.</value>
    [property:
        JsonPropertyName("createdBy"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? CreatedBy = null,
    /// <value>The date and time at which the element was created.</value>
    [property:
        JsonPropertyName("createdAt"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? CreatedAt = null,
    /// <value>The user who last updated the element.</value>
    [property:
        JsonPropertyName("updatedBy"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? UpdatedBy = null,
    /// <value>The date and time at which the element was last updated.</value>
    [property:
        JsonPropertyName("updatedAt"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? UpdatedAt = null,
    /// <value>The element's type.</value>
    [property:
        JsonPropertyName("type"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? Type_ = null,
    /// <value>The element's ID or UID.</value>
    [property: JsonPropertyName("id"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        string? Id = null,
    /// <value>The element's name.</value>
    [property:
        JsonPropertyName("name"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? Name = null,
    /// <value>The element's summary.</value>
    [property: JsonPropertyName("summary")]
        string? Summary = null,
    /// <value>The element's description.</value>
    [property:
        JsonPropertyName("description"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? Description = null,
    /// <value>The element's Postman URL.</value>
    [property:
        JsonPropertyName("href"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? Href = null,
    /// <value>The parent folder's ID.</value>
    [property:
        JsonPropertyName("parentFolderId"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? ParentFolderId = null,
    /// <value>A list of the element's environments.</value>
    [property:
        JsonPropertyName("environments"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        List<string>? Environments = null
);
