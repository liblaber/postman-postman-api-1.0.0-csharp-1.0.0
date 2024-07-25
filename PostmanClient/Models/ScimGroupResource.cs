// This file was generated by liblab | https://liblab.com/

using System.Text.Json.Serialization;

namespace PostmanClient.Models;

/// <summary>The SCIM group resource object.</summary>
public record ScimGroupResource(
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
    /// <value>A list of the group's members.</value>
    [property:
        JsonPropertyName("members"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        List<ScimGroupResource.ScimGroupResourceMembers>? Members = null,
    /// <value>The group's external ID.</value>
    [property:
        JsonPropertyName("externalId"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? ExternalId = null,
    /// <value>The response's non-standard meta information.</value>
    [property:
        JsonPropertyName("meta"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        ScimGroupResource.ScimGroupResourceMeta? Meta = null
)
{
    /// <summary>Information about the group's members.</summary>
    public record ScimGroupResourceMembers(
        /// <value>The resource value.</value>
        [property:
            JsonPropertyName("value"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            string? Value = null,
        /// <value>The resource's display name.</value>
        [property:
            JsonPropertyName("display"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            string? Display = null
    );

    /// <summary>The response's non-standard meta information.</summary>
    public record ScimGroupResourceMeta(
        /// <value>The resource type.</value>
        [property:
            JsonPropertyName("resourceType"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            string? ResourceType = null,
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
            string? LastModified = null
    );
}
