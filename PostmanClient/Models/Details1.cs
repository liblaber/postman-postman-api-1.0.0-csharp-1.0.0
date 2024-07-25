// This file was generated by liblab | https://liblab.com/

using System.Text.Json.Serialization;

namespace PostmanClient.Models;

/// <summary>Information about the task's resources.</summary>
public record Details1(
    [property:
        JsonPropertyName("resources"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        List<Details1.Details1Resources>? Resources = null
)
{
    public record Details1Resources(
        /// <value>The ID of the assigned resource.</value>
        [property:
            JsonPropertyName("id"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            string? Id = null,
        /// <value>The task's assigned resource URL.</value>
        [property:
            JsonPropertyName("url"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            string? Url = null
    );
}
