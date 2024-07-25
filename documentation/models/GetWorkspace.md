# GetWorkspace

**Properties**

| Name      | Type                  | Required | Description                      |
| :-------- | :-------------------- | :------- | :------------------------------- |
| Workspace | GetWorkspaceWorkspace | ❌       | Information about the workspace. |

# GetWorkspaceWorkspace

Information about the workspace.

**Properties**

| Name         | Type                        | Required | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           |
| :----------- | :-------------------------- | :------- | :---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Id           | string                      | ❌       | The workspace's ID.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   |
| Name         | string                      | ❌       | The workspace's name.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 |
| Type\_       | WorkspaceType2              | ❌       | The type of workspace.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                |
| Description  | string                      | ❌       | The workspace's description.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          |
| Visibility   | WorkspaceVisibility         | ❌       | The workspace's visibility. [Visibility](https://learning.postman.com/docs/collaborating-in-postman/using-workspaces/managing-workspaces/#changing-workspace-visibility) determines who can access the workspace: - `personal` — Only you can access the workspace. - `team` — All team members can access the workspace. - `private` — Only invited team members can access the workspace ([**Professional** and **Enterprise** plans only](https://www.postman.com/pricing)). - `public` — Everyone can access the workspace. - `partner` — Only invited team members and [partners](https://learning.postman.com/docs/collaborating-in-postman/using-workspaces/partner-workspaces/) can access the workspace ([**Professional** and **Enterprise** plans only](https://www.postman.com/pricing)). |
| CreatedBy    | string                      | ❌       | The user ID of the user who created the workspace.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    |
| UpdatedBy    | string                      | ❌       | The user ID of the user who last updated the workspace.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               |
| CreatedAt    | string                      | ❌       | The date and time at which the workspace was created.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 |
| UpdatedAt    | string                      | ❌       | The date and time at which the workspace was last updated.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            |
| Collections  | List<WorkspaceCollections>  | ❌       | The workspace's collections.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          |
| Environments | List<WorkspaceEnvironments> | ❌       | The workspace's environments.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         |
| Mocks        | List<WorkspaceMocks>        | ❌       | The workspace's mock servers.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         |
| Monitors     | List<WorkspaceMonitors>     | ❌       | The workspace's monitors.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             |
| Apis         | List<WorkspaceApis>         | ❌       | The workspace's APIs.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 |

# WorkspaceType2

The type of workspace.

**Properties**

| Name      | Type   | Required | Description |
| :-------- | :----- | :------- | :---------- |
| Personal  | string | ✅       | "personal"  |
| Team      | string | ✅       | "team"      |
| Private\_ | string | ✅       | "private"   |
| Public\_  | string | ✅       | "public"    |
| Partner   | string | ✅       | "partner"   |

# WorkspaceVisibility

The workspace's visibility. [Visibility](https://learning.postman.com/docs/collaborating-in-postman/using-workspaces/managing-workspaces/#changing-workspace-visibility) determines who can access the workspace: - `personal` — Only you can access the workspace. - `team` — All team members can access the workspace. - `private` — Only invited team members can access the workspace ([**Professional** and **Enterprise** plans only](https://www.postman.com/pricing)). - `public` — Everyone can access the workspace. - `partner` — Only invited team members and [partners](https://learning.postman.com/docs/collaborating-in-postman/using-workspaces/partner-workspaces/) can access the workspace ([**Professional** and **Enterprise** plans only](https://www.postman.com/pricing)).

**Properties**

| Name      | Type   | Required | Description |
| :-------- | :----- | :------- | :---------- |
| Personal  | string | ✅       | "personal"  |
| Team      | string | ✅       | "team"      |
| Private\_ | string | ✅       | "private"   |
| Public\_  | string | ✅       | "public"    |
| Partner   | string | ✅       | "partner"   |

# WorkspaceCollections

Information about the collection.

**Properties**

| Name | Type   | Required | Description                 |
| :--- | :----- | :------- | :-------------------------- |
| Id   | string | ❌       | The collection's ID.        |
| Name | string | ❌       | The collection's name.      |
| Uid  | string | ❌       | The collection's unique ID. |

# WorkspaceEnvironments

Information about the environment.

**Properties**

| Name | Type   | Required | Description                  |
| :--- | :----- | :------- | :--------------------------- |
| Id   | string | ❌       | The environment's ID.        |
| Name | string | ❌       | The environment's name.      |
| Uid  | string | ❌       | The environment's unique ID. |

# WorkspaceMocks

Information about the mock server.

**Properties**

| Name        | Type   | Required | Description                                                                                                         |
| :---------- | :----- | :------- | :------------------------------------------------------------------------------------------------------------------ |
| Id          | string | ❌       | The mock server's ID.                                                                                               |
| Name        | string | ❌       | The mock server's name.                                                                                             |
| Uid         | string | ❌       | The mock server's unique ID.                                                                                        |
| Deactivated | bool   | ❌       | If true, the mock server is not active. Mock servers deactivate when a linked collection or environment is deleted. |

# WorkspaceMonitors

Information about the monitor.

**Properties**

| Name | Type   | Required | Description              |
| :--- | :----- | :------- | :----------------------- |
| Id   | string | ❌       | The monitor's ID.        |
| Name | string | ❌       | The monitor's name.      |
| Uid  | string | ❌       | The monitor's unique ID. |

# WorkspaceApis

Information about the API.

**Properties**

| Name | Type   | Required | Description          |
| :--- | :----- | :------- | :------------------- |
| Id   | string | ❌       | The API's ID.        |
| Name | string | ❌       | The API's name.      |
| Uid  | string | ❌       | The API's unique ID. |

<!-- This file was generated by liblab | https://liblab.com/ -->
