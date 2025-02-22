// This file was generated by liblab | https://liblab.com/

using System.Text.Json.Serialization;
using PostmanClient.Json;

namespace PostmanClient.Models;

public record JsonSchema(
    /// <value>The OpenAPI definition type.</value>
    [property: JsonPropertyName("type")]
        JsonSchema.JsonSchemaType Type_,
    /// <value>An object that contains a valid JSON OpenAPI definition. For more information, read the [OpenAPI documentation](https://swagger.io/docs/specification/basic-structure/).</value>
    [property: JsonPropertyName("input")]
        object Input_,
    /// <value>An object that contains advanced creation options and their values. You can find a complete list of properties and their values in Postman's [OpenAPI 3.0 to Postman Collection v2.1.0 Converter OPTIONS documentation](https://github.com/postmanlabs/openapi-to-postman/blob/develop/OPTIONS.md). These properties are case-sensitive.</value>
    [property:
        JsonPropertyName("options"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        object? Options = null
)
{
    /// <summary>The OpenAPI definition type.</summary>
    public record JsonSchemaType : ValueEnum<string>
    {
        internal JsonSchemaType(string value)
            : base(value) { }

        public JsonSchemaType()
            : base("json") { }

        public static JsonSchemaType Json = new("json");
    }
}
