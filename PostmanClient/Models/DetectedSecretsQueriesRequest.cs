// This file was generated by liblab | https://liblab.com/

using System.Text.Json.Serialization;
using PostmanClient.Json;

namespace PostmanClient.Models;

public record DetectedSecretsQueriesRequest(
    /// <value>If true, return secrets with a `resolved` status.</value>
    [property:
        JsonPropertyName("resolved"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        bool? Resolved = null,
    /// <value>A list of secrets types to query. For a list of valid IDs, use the GET `/secret-types` endpoint.</value>
    [property:
        JsonPropertyName("secretTypes"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        List<string>? SecretTypes = null,
    /// <value>A list of the types of resolution statuses to query.</value>
    [property:
        JsonPropertyName("statuses"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        List<DetectedSecretsQueriesRequest.Statuses>? Statuses_ = null,
    /// <value>A list of workspaces IDs to query.</value>
    [property:
        JsonPropertyName("workspaceIds"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        List<string>? WorkspaceIds = null,
    /// <value>A list of workspace [visibility settings](https://learning.postman.com/docs/collaborating-in-postman/using-workspaces/managing-workspaces/#changing-workspace-visibility) to query. This currently supports the `team` and `public` settings.</value>
    [property:
        JsonPropertyName("workspaceVisiblities"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        List<DetectedSecretsQueriesRequest.WorkspaceVisiblities>? WorkspaceVisiblities_ = null
)
{
    /// <summary>
    /// The secret resolution status type:
    /// - `FALSE_POSITIVE` — The discovered secret is not an actual secret.
    /// - `REVOKED` — The secret is valid, but the user rotated their key to resolve the issue.
    /// - `ACCEPTED_RISK` — The Secret Scanner found the secret, but user accepts the risk of publishing it.
    /// </summary>
    public record Statuses : ValueEnum<string>
    {
        internal Statuses(string value)
            : base(value) { }

        public Statuses()
            : base("FALSE_POSITIVE") { }

        public static Statuses FalsePositive = new("FALSE_POSITIVE");
        public static Statuses AcceptedRisk = new("ACCEPTED_RISK");
        public static Statuses Revoked = new("REVOKED");
    }

    /// <summary>The type of visibility setting.</summary>
    public record WorkspaceVisiblities : ValueEnum<string>
    {
        internal WorkspaceVisiblities(string value)
            : base(value) { }

        public WorkspaceVisiblities()
            : base("team") { }

        public static WorkspaceVisiblities Team = new("team");
        public static WorkspaceVisiblities Public_ = new("public");
    }
}
