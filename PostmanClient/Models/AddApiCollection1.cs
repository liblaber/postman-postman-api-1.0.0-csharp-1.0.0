// This file was generated by liblab | https://liblab.com/

using System.Text.Json.Serialization;
using PostmanClient.Json;

namespace PostmanClient.Models;

public record AddApiCollection1(
    [property:
        JsonPropertyName("data"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        AddApiCollection1.AddApiCollection1Data? Data = null,
    /// <value>The `COPY_COLLECTION` method.</value>
    [property:
        JsonPropertyName("operationType"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        AddApiCollection1.AddApiCollection1OperationType? OperationType = null
)
{
    public record AddApiCollection1Data(
        /// <value>The collection ID to copy to the API.</value>
        [property:
            JsonPropertyName("collectionId"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            string? CollectionId = null
    );

    /// <summary>The `COPY_COLLECTION` method.</summary>
    public record AddApiCollection1OperationType : ValueEnum<string>
    {
        internal AddApiCollection1OperationType(string value)
            : base(value) { }

        public AddApiCollection1OperationType()
            : base("COPY_COLLECTION") { }

        public static AddApiCollection1OperationType CopyCollection = new("COPY_COLLECTION");
    }
}
