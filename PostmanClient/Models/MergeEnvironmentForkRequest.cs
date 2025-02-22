// This file was generated by liblab | https://liblab.com/

using System.Text.Json.Serialization;

namespace PostmanClient.Models;

public record MergeEnvironmentForkRequest(
    /// <value>The source environment's unique ID to merge data from.</value>
    [property: JsonPropertyName("source")]
        string Source,
    /// <value>If true, the forked environment will be deleted.</value>
    [property:
        JsonPropertyName("deleteSource"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        bool? DeleteSource = null
);
