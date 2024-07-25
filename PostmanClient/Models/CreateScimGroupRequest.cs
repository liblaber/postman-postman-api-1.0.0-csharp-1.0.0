// This file was generated by liblab | https://liblab.com/

using System.Text.Json.Serialization;

namespace PostmanClient.Models;

public record CreateScimGroupRequest(
    /// <value>The [SCIM schema URI](https://www.iana.org/assignments/scim/scim.xhtml).</value>
    [property:
        JsonPropertyName("schemas"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        List<string>? Schemas = null,
    /// <value>The group's display name.</value>
    [property:
        JsonPropertyName("displayName"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? DisplayName = null,
    [property:
        JsonPropertyName("members"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        List<CreateScimGroupRequest.CreateScimGroupMembers1>? Members = null
)
{
    /// <summary>An object containing the SCIM users to assign to the group.</summary>
    public record CreateScimGroupMembers1(
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
}
