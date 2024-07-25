// This file was generated by liblab | https://liblab.com/

using System.Text.Json.Serialization;

namespace PostmanClient.Models;

public record GetEnvironmentForks(
    /// <value>A list of the environment's forks.</value>
    [property:
        JsonPropertyName("data"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        List<GetEnvironmentForks.GetEnvironmentForksData>? Data = null,
    /// <value>The response's meta information for paginated results.</value>
    [property:
        JsonPropertyName("meta"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        GetEnvironmentForks.GetEnvironmentForksMeta? Meta = null
)
{
    /// <summary>Information about the forked environment.</summary>
    public record GetEnvironmentForksData(
        /// <value>The forked environment's unique ID.</value>
        [property:
            JsonPropertyName("forkId"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            string? ForkId = null,
        /// <value>The forked environment's label.</value>
        [property:
            JsonPropertyName("forkName"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            string? ForkName = null,
        /// <value>The date and time at which the fork was created.</value>
        [property:
            JsonPropertyName("createdAt"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            string? CreatedAt = null,
        /// <value>The user who created the environment fork.</value>
        [property:
            JsonPropertyName("createdBy"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            string? CreatedBy = null,
        /// <value>The date and time at which the fork was last updated.</value>
        [property:
            JsonPropertyName("updatedAt"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            string? UpdatedAt = null
    );

    /// <summary>The response's meta information for paginated results.</summary>
    public record GetEnvironmentForksMeta(
        /// <value>The total number of forked environments.</value>
        [property:
            JsonPropertyName("total"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            double? Total = null,
        /// <value>The pagination cursor that points to the next record in the results set.</value>
        [property: JsonPropertyName("nextCursor")]
            string? NextCursor = null
    );
}
