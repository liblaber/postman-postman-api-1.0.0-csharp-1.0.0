// This file was generated by liblab | https://liblab.com/

using System.Text.Json.Serialization;
using PostmanClient.Json;

namespace PostmanClient.Models;

public record CreateScimUserCreatedResponse(
    /// <value>The [SCIM schema URI](https://www.iana.org/assignments/scim/scim.xhtml).</value>
    [property:
        JsonPropertyName("schemas"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        List<string>? Schemas = null,
    /// <value>The user's SCIM ID.</value>
    [property: JsonPropertyName("id"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        string? Id = null,
    /// <value>The user's username.</value>
    [property:
        JsonPropertyName("userName"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? UserName = null,
    [property:
        JsonPropertyName("name"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        CreateScimUserCreatedResponse.CreateScimUserName2? Name = null,
    /// <value>The user's external ID.</value>
    [property:
        JsonPropertyName("externalId"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? ExternalId = null,
    /// <value>If true, the user is active.</value>
    [property:
        JsonPropertyName("active"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        bool? Active = null,
    /// <value>The response's non-standard meta information.</value>
    [property:
        JsonPropertyName("meta"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        CreateScimUserCreatedResponse.CreateScimUserMeta? Meta = null
)
{
    public record CreateScimUserName2(
        /// <value>The user's first name.</value>
        [property:
            JsonPropertyName("givenName"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            string? GivenName = null,
        /// <value>The user's last name.</value>
        [property:
            JsonPropertyName("familyName"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            string? FamilyName = null
    );

    /// <summary>The response's non-standard meta information.</summary>
    public record CreateScimUserMeta(
        /// <value>The date and time at which the user was created.</value>
        [property:
            JsonPropertyName("created"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            string? Created = null,
        /// <value>The date and time at which the user was last modified.</value>
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
            CreateScimUserMeta.MetaResourceType? ResourceType = null
    )
    {
        /// <summary>The SCIM resource type.</summary>
        public record MetaResourceType : ValueEnum<string>
        {
            internal MetaResourceType(string value)
                : base(value) { }

            public MetaResourceType()
                : base("User") { }

            public static MetaResourceType User = new("User");
        }
    }
}
