// This file was generated by liblab | https://liblab.com/

using System.Text.Json.Serialization;

namespace PostmanClient.Models;

public record PutCollectionRequest(
    /// <value>For a complete list of values, refer to the [collection.json schema file](https://schema.postman.com/json/collection/v2.1.0/collection.json).</value>
    [property:
        JsonPropertyName("collection"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        PutCollectionRequest.PutCollectionCollection1? Collection = null
)
{
    /// <summary>For a complete list of values, refer to the [collection.json schema file](https://schema.postman.com/json/collection/v2.1.0/collection.json).</summary>
    public record PutCollectionCollection1(
        /// <value>An object that contains basic information about the collection. For a complete list of values, refer to the `definitions.info` entry in the [collection.json schema file](https://schema.postman.com/json/collection/v2.1.0/collection.json).</value>
        [property: JsonPropertyName("info")]
            object Info,
        /// <value>
        /// Information about the collection's contents, such as folders, requests, and responses. For a complete list of values, refer to the `#/definitions/item-group` entry in the [collection.json schema file](https://schema.postman.com/json/collection/v2.1.0/collection.json).
        ///
        /// The maximum collection size cannot exceed 20 MB.
        /// </value>
        [property: JsonPropertyName("item")]
            List<object> Item
    );
}
