// This file was generated by liblab | https://liblab.com/

using System.Text.Json.Serialization;

namespace PostmanClient.Models;

public record PullEnvironmentOkResponse(
    /// <value>Information about the merged environment.</value>
    [property:
        JsonPropertyName("environment"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        PullEnvironmentOkResponse.PullEnvironmentEnvironment? Environment_ = null
)
{
    /// <summary>Information about the merged environment.</summary>
    public record PullEnvironmentEnvironment(
        /// <value>The merged environment's unique ID.</value>
        [property:
            JsonPropertyName("uid"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            string? Uid = null
    );
}
