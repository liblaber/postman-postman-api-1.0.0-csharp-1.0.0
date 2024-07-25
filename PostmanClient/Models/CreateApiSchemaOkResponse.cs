// This file was generated by liblab | https://liblab.com/

using System.Text.Json.Serialization;
using PostmanClient.Json;

namespace PostmanClient.Models;

/// <summary>Information about the created API schema.</summary>
public record CreateApiSchemaOkResponse(
    /// <value>The schema's ID.</value>
    [property: JsonPropertyName("id"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        string? Id = null,
    /// <value>The schema's type.</value>
    [property:
        JsonPropertyName("type"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        CreateApiSchemaOkResponse.CreateApiSchemaType2? Type_ = null,
    /// <value>The list of the schema's files.</value>
    [property:
        JsonPropertyName("files"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        List<CreateApiSchemaOkResponse.CreateApiSchemaFiles2>? Files = null,
    /// <value>The date and time at which the schema was created.</value>
    [property:
        JsonPropertyName("createdAt"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? CreatedAt = null,
    /// <value>The user ID of the user that created the schema.</value>
    [property:
        JsonPropertyName("createdBy"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? CreatedBy = null,
    /// <value>The date and time at which the schema was last updated.</value>
    [property:
        JsonPropertyName("updatedAt"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? UpdatedAt = null,
    /// <value>The user ID of the user that updated the schema.</value>
    [property:
        JsonPropertyName("updatedBy"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? UpdatedBy = null
)
{
    /// <summary>The schema's type.</summary>
    public record CreateApiSchemaType2 : ValueEnum<string>
    {
        internal CreateApiSchemaType2(string value)
            : base(value) { }

        public CreateApiSchemaType2()
            : base("proto:2") { }

        public static CreateApiSchemaType2 Proto2 = new("proto:2");
        public static CreateApiSchemaType2 Proto3 = new("proto:3");
        public static CreateApiSchemaType2 Graphql = new("graphql");
        public static CreateApiSchemaType2 Openapi3_1 = new("openapi:3_1");
        public static CreateApiSchemaType2 Openapi3 = new("openapi:3");
        public static CreateApiSchemaType2 Openapi2 = new("openapi:2");
        public static CreateApiSchemaType2 Openapi1 = new("openapi:1");
        public static CreateApiSchemaType2 Raml1 = new("raml:1");
        public static CreateApiSchemaType2 Raml0_8 = new("raml:0_8");
        public static CreateApiSchemaType2 Wsdl2 = new("wsdl:2");
        public static CreateApiSchemaType2 Wsdl1 = new("wsdl:1");
        public static CreateApiSchemaType2 Asyncapi2 = new("asyncapi:2");
    }

    /// <summary>Information about the schema file.</summary>
    public record CreateApiSchemaFiles2(
        /// <value>The schema file's ID.</value>
        [property:
            JsonPropertyName("id"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            string? Id = null,
        /// <value>The schema file's name.</value>
        [property:
            JsonPropertyName("name"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            string? Name = null,
        /// <value>The file system path to the schema file.</value>
        [property:
            JsonPropertyName("path"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            string? Path = null,
        /// <value>The date and time at which the file was created.</value>
        [property:
            JsonPropertyName("createdAt"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            string? CreatedAt = null,
        /// <value>The user ID of the user that created the file.</value>
        [property:
            JsonPropertyName("createdBy"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            string? CreatedBy = null,
        /// <value>The date and time at which the file was last updated.</value>
        [property:
            JsonPropertyName("updatedAt"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            string? UpdatedAt = null,
        /// <value>The user ID of the user that last updated the file.</value>
        [property:
            JsonPropertyName("updatedBy"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            string? UpdatedBy = null
    );
}
