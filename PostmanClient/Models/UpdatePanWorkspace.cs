// This file was generated by liblab | https://liblab.com/

using System.Text.Json.Serialization;

namespace PostmanClient.Models;

public record UpdatePanWorkspace(
    [property:
        JsonPropertyName("workspace"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        UpdatePanWorkspace.UpdatePanWorkspaceWorkspace? Workspace = null
)
{
    public record UpdatePanWorkspaceWorkspace(
        /// <value>The workspace's new parent folder ID.</value>
        [property:
            JsonPropertyName("parentFolderId"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            long? ParentFolderId = null
    );
}
