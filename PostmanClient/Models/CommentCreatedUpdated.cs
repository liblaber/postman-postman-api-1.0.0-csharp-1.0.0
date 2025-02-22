// This file was generated by liblab | https://liblab.com/

using System.Text.Json.Serialization;

namespace PostmanClient.Models;

public record CommentCreatedUpdated(
    [property:
        JsonPropertyName("data"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        CommentCreatedUpdated.CommentCreatedUpdatedData? Data = null
)
{
    public record CommentCreatedUpdatedData(
        /// <value>The comment's ID.</value>
        [property:
            JsonPropertyName("id"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            long? Id = null,
        /// <value>The user ID of the user who created the comment.</value>
        [property:
            JsonPropertyName("createdBy"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            long? CreatedBy = null,
        /// <value>The date and time at which the comment was created.</value>
        [property:
            JsonPropertyName("createdAt"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            string? CreatedAt = null,
        /// <value>The date and time when the comment was last updated.</value>
        [property:
            JsonPropertyName("updatedAt"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            string? UpdatedAt = null,
        /// <value>The contents of the comment.</value>
        [property:
            JsonPropertyName("body"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            string? Body = null
    );
}
