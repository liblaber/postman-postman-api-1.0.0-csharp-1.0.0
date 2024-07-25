// This file was generated by liblab | https://liblab.com/

using System.Text.Json.Serialization;

namespace PostmanClient.Models;

public record GetScimResourceTypes(
    /// <value>The [SCIM schema URI](https://www.iana.org/assignments/scim/scim.xhtml).</value>
    [property:
        JsonPropertyName("schemas"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        List<string>? Schemas = null,
    /// <value>The resource's ID.</value>
    [property: JsonPropertyName("id"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        string? Id = null,
    /// <value>The resource's friendly name.</value>
    [property:
        JsonPropertyName("name"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? Name = null,
    /// <value>The resource's endpoint.</value>
    [property:
        JsonPropertyName("endpoint"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? Endpoint = null,
    /// <value>The resource's description.</value>
    [property:
        JsonPropertyName("description"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? Description = null,
    /// <value>The [SCIM schema URI](https://www.iana.org/assignments/scim/scim.xhtml).</value>
    [property:
        JsonPropertyName("schema"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? Schema = null,
    /// <value>Information about the resource's schema extensions.</value>
    [property:
        JsonPropertyName("schemaExtensions"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        List<GetScimResourceTypes.SchemaExtensions>? SchemaExtensions_ = null
)
{
    public record SchemaExtensions(
        /// <value>The [SCIM schema URI](https://www.iana.org/assignments/scim/scim.xhtml).</value>
        [property:
            JsonPropertyName("schema"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            string? Schema = null,
        /// <value>If true, the resource must include this schema extension.</value>
        [property:
            JsonPropertyName("required"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            bool? Required = null
    );
}
