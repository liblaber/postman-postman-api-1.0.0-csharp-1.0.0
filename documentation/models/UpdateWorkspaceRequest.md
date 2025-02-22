# UpdateWorkspaceRequest

**Properties**

| Name      | Type                      | Required | Description |
| :-------- | :------------------------ | :------- | :---------- |
| Workspace | UpdateWorkspaceWorkspace1 | ❌       |             |

# UpdateWorkspaceWorkspace1

**Properties**

| Name        | Type           | Required | Description                                                                                                                                                                                                                                                                                                                                                                                                                        |
| :---------- | :------------- | :------- | :--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Name        | string         | ❌       | The workspace's new name.                                                                                                                                                                                                                                                                                                                                                                                                          |
| Type\_      | WorkspaceType3 | ❌       | The new workspace visibility [type](https://learning.postman.com/docs/collaborating-in-postman/using-workspaces/managing-workspaces/#changing-workspace-visibility). This property does not support the following workspace visibility changes: - `private` to `public`, `public` to `private`, and `private` to `personal` for Free and Basic [plans](https://www.postman.com/pricing/). - `public` to `personal` for team users. |
| Description | string         | ❌       | The new workspace description.                                                                                                                                                                                                                                                                                                                                                                                                     |

# WorkspaceType3

The new workspace visibility [type](https://learning.postman.com/docs/collaborating-in-postman/using-workspaces/managing-workspaces/#changing-workspace-visibility). This property does not support the following workspace visibility changes: - `private` to `public`, `public` to `private`, and `private` to `personal` for Free and Basic [plans](https://www.postman.com/pricing/). - `public` to `personal` for team users.

**Properties**

| Name      | Type   | Required | Description |
| :-------- | :----- | :------- | :---------- |
| Private\_ | string | ✅       | "private"   |
| Personal  | string | ✅       | "personal"  |
| Team      | string | ✅       | "team"      |
| Public\_  | string | ✅       | "public"    |

<!-- This file was generated by liblab | https://liblab.com/ -->
