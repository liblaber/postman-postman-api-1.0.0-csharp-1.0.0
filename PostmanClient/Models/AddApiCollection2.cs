// This file was generated by liblab | https://liblab.com/

using System.Text.Json.Serialization;
using PostmanClient.Json;

namespace PostmanClient.Models;

public record AddApiCollection2(
    /// <value>The collection's name.</value>
    [property:
        JsonPropertyName("name"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? Name = null,
    /// <value>The `GENERATE_FROM_SCHEMA` method.</value>
    [property:
        JsonPropertyName("operationType"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        AddApiCollection2.AddApiCollection2OperationType? OperationType = null,
    /// <value>The advanced creation options for collections and their values. For a complete list of properties and their values, see Postman's [OpenAPI 3.0 to Postman Collection v2.1.0 Converter OPTIONS documentation](https://github.com/postmanlabs/openapi-to-postman/blob/develop/OPTIONS.md). These properties are case-sensitive.</value>
    [property:
        JsonPropertyName("options"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        object? Options = null
)
{
    /// <summary>The `GENERATE_FROM_SCHEMA` method.</summary>
    public record AddApiCollection2OperationType : ValueEnum<string>
    {
        internal AddApiCollection2OperationType(string value)
            : base(value) { }

        public AddApiCollection2OperationType()
            : base("GENERATE_FROM_SCHEMA") { }

        public static AddApiCollection2OperationType GenerateFromSchema =
            new("GENERATE_FROM_SCHEMA");
    }
}
