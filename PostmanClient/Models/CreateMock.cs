// This file was generated by liblab | https://liblab.com/

using System.Text.Json.Serialization;

namespace PostmanClient.Models;

public record CreateMock(
    [property:
        JsonPropertyName("mock"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        CreateMock.CreateMockMock? Mock = null
)
{
    public record CreateMockMock(
        /// <value>The unique ID of the mock's associated collection.</value>
        [property: JsonPropertyName("collection")]
            string Collection,
        /// <value>The unique ID of the mock's associated environment.</value>
        [property:
            JsonPropertyName("environment"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            string? Environment_ = null,
        /// <value>The mock server's name.</value>
        [property:
            JsonPropertyName("name"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            string? Name = null,
        /// <value>If true, the mock server is set private. By default, mock servers are public and can receive requests from anyone and anywhere.</value>
        [property:
            JsonPropertyName("private"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            bool? Private_ = null
    );
}
