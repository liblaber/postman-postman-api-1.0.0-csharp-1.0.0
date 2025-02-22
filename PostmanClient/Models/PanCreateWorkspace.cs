// This file was generated by liblab | https://liblab.com/

using System.Text.Json.Serialization;

namespace PostmanClient.Models;

public record PanCreateWorkspace(
    [property:
        JsonPropertyName("workspace"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        PanCreateWorkspace.PanCreateWorkspaceWorkspace? Workspace = null
)
{
    public record PanCreateWorkspaceWorkspace(
        /// <value>The workspace's ID.</value>
        [property: JsonPropertyName("id")]
            string Id,
        /// <value>The workspace's parent folder ID.</value>
        [property: JsonPropertyName("parentFolderId")]
            long ParentFolderId
    );
}
