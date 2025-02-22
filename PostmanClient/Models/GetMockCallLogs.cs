// This file was generated by liblab | https://liblab.com/

using System.Text.Json.Serialization;

namespace PostmanClient.Models;

public record GetMockCallLogs(
    [property:
        JsonPropertyName("call-logs"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        List<GetMockCallLogs.CallLogs>? CallLogs_ = null,
    /// <value>The response's non-standard meta information.</value>
    [property:
        JsonPropertyName("meta"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        GetMockCallLogs.GetMockCallLogsMeta? Meta = null
)
{
    /// <summary>Information about the mock server's server responses.</summary>
    public record CallLogs(
        /// <value>The server response's ID.</value>
        [property:
            JsonPropertyName("id"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            string? Id = null,
        /// <value>The server response's name.</value>
        [property:
            JsonPropertyName("responseName"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            string? ResponseName = null,
        /// <value>The date and time at which the server response was served.</value>
        [property:
            JsonPropertyName("servedAt"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            string? ServedAt = null,
        /// <value>The server response's request information.</value>
        [property:
            JsonPropertyName("request"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            CallLogs.CallLogsRequest? Request_ = null,
        /// <value>The server response's response information.</value>
        [property:
            JsonPropertyName("response"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            CallLogs.CallLogsResponse? Response_ = null
    )
    {
        /// <summary>The server response's request information.</summary>
        public record CallLogsRequest(
            /// <value>The request method.</value>
            [property:
                JsonPropertyName("method"),
                JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
            ]
                string? Method = null,
            /// <value>The request's path.</value>
            [property:
                JsonPropertyName("path"),
                JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
            ]
                string? Path = null,
            /// <value>The request's headers.</value>
            [property:
                JsonPropertyName("headers"),
                JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
            ]
                CallLogsRequest.RequestHeaders? Headers = null,
            /// <value>The request's body information.</value>
            [property:
                JsonPropertyName("body"),
                JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
            ]
                CallLogsRequest.RequestBody? Body = null
        )
        {
            /// <summary>The request's headers.</summary>
            public record RequestHeaders(
                /// <value>The request header's name.</value>
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

            /// <summary>The request's body information.</summary>
            public record RequestBody(
                /// <value>The request body's media type (mode).</value>
                [property:
                    JsonPropertyName("mode"),
                    JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
                ]
                    string? Mode = null,
                /// <value>The request body's contents.</value>
                [property:
                    JsonPropertyName("data"),
                    JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
                ]
                    string? Data = null
            );
        }

        /// <summary>The server response's response information.</summary>
        public record CallLogsResponse(
            /// <value>The type of response.</value>
            [property:
                JsonPropertyName("type"),
                JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
            ]
                string? Type_ = null,
            /// <value>The response's status code.</value>
            [property:
                JsonPropertyName("statusCode"),
                JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
            ]
                double? StatusCode = null,
            /// <value>The response's headers.</value>
            [property:
                JsonPropertyName("headers"),
                JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
            ]
                CallLogsResponse.ResponseHeaders? Headers = null,
            /// <value>The response's body information.</value>
            [property:
                JsonPropertyName("body"),
                JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
            ]
                CallLogsResponse.ResponseBody? Body = null
        )
        {
            /// <summary>The response's headers.</summary>
            public record ResponseHeaders(
                /// <value>The response header's description information.</value>
                [property:
                    JsonPropertyName("description"),
                    JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
                ]
                    ResponseHeaders.Description? Description_ = null,
                /// <value>The response header's name.</value>
                [property:
                    JsonPropertyName("key"),
                    JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
                ]
                    string? Key = null,
                /// <value>The response header's value.</value>
                [property:
                    JsonPropertyName("value"),
                    JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
                ]
                    string? Value = null
            )
            {
                /// <summary>The response header's description information.</summary>
                public record Description(
                    /// <value>The response header description's content.</value>
                    [property:
                        JsonPropertyName("content"),
                        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
                    ]
                        string? Content = null,
                    /// <value>The response header description's media type.</value>
                    [property:
                        JsonPropertyName("type"),
                        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
                    ]
                        string? Type_ = null
                );
            }

            /// <summary>The response's body information.</summary>
            public record ResponseBody(
                /// <value>The response body's contents.</value>
                [property:
                    JsonPropertyName("data"),
                    JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
                ]
                    string? Data = null
            );
        }
    }

    /// <summary>The response's non-standard meta information.</summary>
    public record GetMockCallLogsMeta(
        /// <value>The pagination cursor that points to the next record in the results set.</value>
        [property: JsonPropertyName("nextCursor")]
            string? NextCursor = null
    );
}
