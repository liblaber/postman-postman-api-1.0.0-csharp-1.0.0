// This file was generated by liblab | https://liblab.com/

using System.Text.Json.Serialization;

namespace PostmanClient.Models;

public record PutCollectionOkResponse(
    [property:
        JsonPropertyName("collection"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        PutCollectionOkResponse.PutCollectionCollection2? Collection = null
)
{
    public record PutCollectionCollection2(
        /// <value>The collection's ID.</value>
        [property:
            JsonPropertyName("id"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            string? Id = null,
        /// <value>The collection's name.</value>
        [property:
            JsonPropertyName("name"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            string? Name = null,
        /// <value>The collection's unique ID.</value>
        [property:
            JsonPropertyName("uid"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            string? Uid = null
    );
}
