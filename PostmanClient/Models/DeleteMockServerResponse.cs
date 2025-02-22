// This file was generated by liblab | https://liblab.com/

using System.Text.Json.Serialization;
using PostmanClient.Json;

namespace PostmanClient.Models;

/// <summary>Information about the deleted server response.</summary>
public record DeleteMockServerResponse(
    /// <value>The server response's ID.</value>
    [property: JsonPropertyName("id"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        string? Id = null,
    /// <value>The server response's name.</value>
    [property:
        JsonPropertyName("name"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? Name = null,
    /// <value>The server response's 5xx HTTP response code.</value>
    [property:
        JsonPropertyName("statusCode"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        double? StatusCode = null,
    /// <value>The server response's request headers, such as Content-Type, Accept, encoding, and other information.</value>
    [property:
        JsonPropertyName("headers"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        List<DeleteMockServerResponse.DeleteMockServerResponseHeaders>? Headers = null,
    /// <value>The server response's body language type.</value>
    [property: JsonPropertyName("language")]
        DeleteMockServerResponse.DeleteMockServerResponseLanguage? Language = null,
    /// <value>The server response's body that returns when calling the mock server.</value>
    [property:
        JsonPropertyName("body"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? Body = null,
    /// <value>The user ID of the user who created the server response.</value>
    [property:
        JsonPropertyName("createdBy"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? CreatedBy = null,
    /// <value>The user ID of the user who last updated the server response.</value>
    [property:
        JsonPropertyName("updatedBy"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? UpdatedBy = null,
    /// <value>The date and time at which the server response was created.</value>
    [property:
        JsonPropertyName("createdAt"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? CreatedAt = null
)
{
    public record DeleteMockServerResponseHeaders(
        /// <value>The request header's key value.</value>
        [property:
            JsonPropertyName("key"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            string? Key = null,
        /// <value>The request header's value.</value>
        [property:
            JsonPropertyName("value"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            string? Value = null
    );

    /// <summary>The server response's body language type.</summary>
    public record DeleteMockServerResponseLanguage : ValueEnum<string>
    {
        internal DeleteMockServerResponseLanguage(string value)
            : base(value) { }

        public DeleteMockServerResponseLanguage()
            : base("text") { }

        public static DeleteMockServerResponseLanguage Text = new("text");
        public static DeleteMockServerResponseLanguage Javascript = new("javascript");
        public static DeleteMockServerResponseLanguage Json = new("json");
        public static DeleteMockServerResponseLanguage Html = new("html");
        public static DeleteMockServerResponseLanguage Xml = new("xml");
    }
}
