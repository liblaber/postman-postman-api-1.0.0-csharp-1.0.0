// This file was generated by liblab | https://liblab.com/

using System.Text.Json.Serialization;
using PostmanClient.Json;

namespace PostmanClient.Models;

public record JsonStringified(
    /// <value>The OpenAPI definition type.</value>
    [property:
        JsonPropertyName("type"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        JsonStringified.JsonStringifiedType? Type_ = null,
    /// <value>The stringified OpenAPI definition.</value>
    [property:
        JsonPropertyName("input"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? Input_ = null,
    /// <value>An object that contains advanced creation options and their values. You can find a complete list of properties and their values in Postman's [OpenAPI 3.0 to Postman Collection v2.1.0 Converter OPTIONS documentation](https://github.com/postmanlabs/openapi-to-postman/blob/develop/OPTIONS.md). These properties are case-sensitive.</value>
    [property:
        JsonPropertyName("options"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        object? Options = null
)
{
    /// <summary>The OpenAPI definition type.</summary>
    public record JsonStringifiedType : ValueEnum<string>
    {
        internal JsonStringifiedType(string value)
            : base(value) { }

        public JsonStringifiedType()
            : base("json") { }

        public static JsonStringifiedType Json = new("json");
    }
}
