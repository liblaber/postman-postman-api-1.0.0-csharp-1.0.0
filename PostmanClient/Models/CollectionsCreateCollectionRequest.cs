// This file was generated by liblab | https://liblab.com/

using System.Text.Json.Serialization;

namespace PostmanClient.Models;

public record CollectionsCreateCollectionRequest(
    /// <value>For a complete list of values, refer to the [collection.json schema file](https://schema.postman.com/json/collection/v2.1.0/collection.json).</value>
    [property:
        JsonPropertyName("collection"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        CollectionsCreateCollectionRequest.CreateCollectionCollection1? Collection = null
)
{
    /// <summary>For a complete list of values, refer to the [collection.json schema file](https://schema.postman.com/json/collection/v2.1.0/collection.json).</summary>
    public record CreateCollectionCollection1(
        /// <value>An object that contains basic information about the collection. For a complete list of values, refer to the `definitions.info` entry in the [collection.json schema file](https://schema.postman.com/json/collection/v2.1.0/collection.json).</value>
        [property: JsonPropertyName("info")]
            CreateCollectionCollection1.CollectionInfo1 Info,
        /// <value>Information about the collection's HTTP requests and responses. For a complete list of values, refer to the `definitions.item` entry in the [collection.json schema file](https://schema.postman.com/json/collection/v2.1.0/collection.json).</value>
        [property:
            JsonPropertyName("item"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            List<CreateCollectionCollection1.CollectionItem>? Item = null
    )
    {
        /// <summary>An object that contains basic information about the collection. For a complete list of values, refer to the `definitions.info` entry in the [collection.json schema file](https://schema.postman.com/json/collection/v2.1.0/collection.json).</summary>
        public record CollectionInfo1(
            /// <value>The collection's name.</value>
            [property: JsonPropertyName("name")]
                string Name,
            /// <value>A URL to the collection's schema.</value>
            [property: JsonPropertyName("schema")]
                string Schema
        );

        public record CollectionItem(
            /// <value>The collection's request information. For a complete list of values, refer to the [collection.json schema file](https://schema.postman.com/json/collection/v2.1.0/collection.json). If you pass an empty object for this value, the system defaults to an untitled GET request.</value>
            [property: JsonPropertyName("request")]
                object Request_
        );
    }
}
