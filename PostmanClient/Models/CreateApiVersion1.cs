// This file was generated by liblab | https://liblab.com/

using System.Text.Json.Serialization;

namespace PostmanClient.Models;

/// <summary>Information about the API version.</summary>
public record CreateApiVersion1(
    /// <value>The version's name.</value>
    [property: JsonPropertyName("name")]
        string Name,
    /// <value>A list of the version's schemas.</value>
    [property: JsonPropertyName("schemas")]
        List<CreateApiVersion1.CreateApiVersion1Schemas> Schemas,
    /// <value>A list of the version's collections.</value>
    [property: JsonPropertyName("collections")]
        List<CreateApiVersion1.CreateApiVersion1Collections> Collections,
    /// <value>Information about the API version release. For example, changelog notes.</value>
    [property:
        JsonPropertyName("releaseNotes"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? ReleaseNotes = null
)
{
    /// <summary>Information about the schema.</summary>
    public record CreateApiVersion1Schemas(
        /// <value>The schema's ID.</value>
        [property:
            JsonPropertyName("id"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            string? Id = null
    );

    /// <summary>Information about the collection.</summary>
    public record CreateApiVersion1Collections(
        /// <value>The collection's ID.</value>
        [property:
            JsonPropertyName("id"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            string? Id = null
    );
}
