// This file was generated by liblab | https://liblab.com/

using System.Text.Json.Serialization;

namespace PostmanClient.Models;

public record GetCollections(
    [property:
        JsonPropertyName("collections"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        List<GetCollections.GetCollectionsCollections>? Collections = null
)
{
    /// <summary>Information about the collection.</summary>
    public record GetCollectionsCollections(
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
        /// <value>The owner of the collection.</value>
        [property:
            JsonPropertyName("owner"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            string? Owner = null,
        /// <value>The collection's creation date and time.</value>
        [property:
            JsonPropertyName("createdAt"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            string? CreatedAt = null,
        /// <value>The date and time at which the collection was last updated.</value>
        [property:
            JsonPropertyName("updatedAt"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            string? UpdatedAt = null,
        /// <value>The collection's unique ID.</value>
        [property:
            JsonPropertyName("uid"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            string? Uid = null,
        /// <value>If the collection is [forked](https://learning.postman.com/docs/collaborating-in-postman/version-control/#forking-postman-entities), the fork's information.</value>
        [property:
            JsonPropertyName("fork"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            GetCollectionsCollections.CollectionsFork? Fork = null,
        /// <value>If true, the collection is public and visible to all users.</value>
        [property:
            JsonPropertyName("isPublic"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            bool? IsPublic = null
    )
    {
        /// <summary>If the collection is [forked](https://learning.postman.com/docs/collaborating-in-postman/version-control/#forking-postman-entities), the fork's information.</summary>
        public record CollectionsFork(
            /// <value>The fork's label.</value>
            [property:
                JsonPropertyName("label"),
                JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
            ]
                string? Label = null,
            /// <value>The fork's creation date and time.</value>
            [property:
                JsonPropertyName("createdAt"),
                JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
            ]
                string? CreatedAt = null,
            /// <value>The unique ID of the fork's source collection.</value>
            [property:
                JsonPropertyName("from"),
                JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
            ]
                string? From = null
        );
    }
}
