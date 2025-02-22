// This file was generated by liblab | https://liblab.com/

using System.Text.Json.Serialization;

namespace PostmanClient.Models;

public record CreateScimGroupCreatedResponse(
    /// <value>The [SCIM schema URI](https://www.iana.org/assignments/scim/scim.xhtml).</value>
    [property:
        JsonPropertyName("schemas"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        List<string>? Schemas = null,
    /// <value>The group's SCIM ID.</value>
    [property: JsonPropertyName("id"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        string? Id = null,
    /// <value>The group's display name.</value>
    [property:
        JsonPropertyName("displayName"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? DisplayName = null,
    /// <value>The group's external ID.</value>
    [property:
        JsonPropertyName("externalId"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? ExternalId = null,
    [property:
        JsonPropertyName("members"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        List<CreateScimGroupCreatedResponse.CreateScimGroupMembers2>? Members = null,
    /// <value>The response's non-standard meta information.</value>
    [property:
        JsonPropertyName("meta"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        CreateScimGroupCreatedResponse.CreateScimGroupMeta? Meta = null
)
{
    /// <summary>An object containing the group's assigned SCIM members.</summary>
    public record CreateScimGroupMembers2(
        /// <value>The user's SCIM ID.</value>
        [property:
            JsonPropertyName("value"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            string? Value = null,
        /// <value>The user's display name.</value>
        [property:
            JsonPropertyName("display"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            string? Display = null
    );

    /// <summary>The response's non-standard meta information.</summary>
    public record CreateScimGroupMeta(
        /// <value>The date and time at which the group was created.</value>
        [property:
            JsonPropertyName("created"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            string? Created = null,
        /// <value>The date and time at which the group was last modified.</value>
        [property:
            JsonPropertyName("lastModified"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            string? LastModified = null,
        /// <value>The SCIM resource type.</value>
        [property:
            JsonPropertyName("resourceType"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            string? ResourceType = null
    );
}
