# WorkspacesService

A list of all methods in the `WorkspacesService` service. Click on the method name to view detailed information about that method.

| Methods                                                                     | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           |
| :-------------------------------------------------------------------------- | :---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| [GetWorkspacesAsync](#getworkspacesasync)                                   | Gets all [workspaces](https://learning.postman.com/docs/collaborating-in-postman/using-workspaces/creating-workspaces/). The response includes your workspaces and any workspaces that you have access to. **Note:** This endpoint's response contains the visibility field. Visibility determines who can access the workspace: - `personal` — Only you can access the workspace. - `team` — All team members can access the workspace. - `private` — Only invited team members can access the workspace ([**Professional** and **Enterprise** plans only](https://www.postman.com/pricing)). - `public` — Everyone can access the workspace. - `partner` — Only invited team members and [partners](https://learning.postman.com/docs/collaborating-in-postman/using-workspaces/partner-workspaces/) can access the workspace ([**Professional** and **Enterprise** plans only](https://www.postman.com/pricing)).                                                                                                                                  |
| [CreateWorkspaceAsync](#createworkspaceasync)                               | Creates a new [workspace](https://learning.postman.com/docs/collaborating-in-postman/using-workspaces/creating-workspaces/). **Note:** This endpoint returns a 403 `Forbidden` response if the user does not have permission to create workspaces. [Admins and Super Admins](https://learning.postman.com/docs/collaborating-in-postman/roles-and-permissions/#team-roles) can configure workspace permissions to restrict users and/or user groups from creating workspaces or require approvals for the creation of team workspaces. ### Important We deprecated linking collections or environments between workspaces. We do not recommend that you do this. If you have a linked collection or environment, note the following: - The endpoint does not create a clone of a collection or environment. - Any changes you make to a linked collection or environment changes them in all workspaces. - If you delete a collection or environment linked between workspaces, the system deletes it in all the workspaces.                          |
| [GetWorkspaceRolesAsync](#getworkspacerolesasync)                           | Gets information about all roles in a workspace, based on the team's [plan](https://www.postman.com/pricing/).                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        |
| [GetWorkspaceAsync](#getworkspaceasync)                                     | Gets information about a workspace. **Note:** This endpoint's response contains the `visibility` field. [Visibility](https://learning.postman.com/docs/collaborating-in-postman/using-workspaces/managing-workspaces/#changing-workspace-visibility) determines who can access the workspace: - `personal` — Only you can access the workspace. - `team` — All team members can access the workspace. - `private` — Only invited team members can access the workspace ([**Professional** and **Enterprise** plans only](https://www.postman.com/pricing)). - `public` — Everyone can access the workspace. - `partner` — Only invited team members and [partners](https://learning.postman.com/docs/collaborating-in-postman/using-workspaces/partner-workspaces/) can access the workspace ([**Professional** and **Enterprise** plans only](https://www.postman.com/pricing)). ### Important We have deprecated the `name` and `uid` responses in the following array of objects: - `collections` - `environments` - `mocks` - `monitors` - `apis` |
| [UpdateWorkspaceAsync](#updateworkspaceasync)                               | Updates a workspace. ### Important We deprecated linking collections or environments between workspaces. We do not recommend that you do this. If you have a linked collection or environment, note the following: - The endpoint does not create a clone of a collection or environment. - Any changes you make to a linked collection or environment changes them in all workspaces. - If you delete a collection or environment linked between workspaces, the system deletes it in all the workspaces.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            |
| [DeleteWorkspaceAsync](#deleteworkspaceasync)                               | Deletes an existing workspace. ### Important If you delete a workspace that has a linked collection or environment with another workspace, this will delete the collection and environment in all workspaces.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         |
| [GetWorkspaceGlobalVariablesAsync](#getworkspaceglobalvariablesasync)       | Gets a workspace's global [variables](https://learning.postman.com/docs/sending-requests/variables/#variable-scopes).                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 |
| [UpdateWorkspaceGlobalVariablesAsync](#updateworkspaceglobalvariablesasync) | Updates and replaces a workspace's global [variables](https://learning.postman.com/docs/sending-requests/variables/#variable-scopes). This endpoint replaces all existing global variables with the variables you pass in the request body.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           |
| [UpdateWorkspaceRolesAsync](#updateworkspacerolesasync)                     | Updates the roles of [users](https://learning.postman.com/docs/collaborating-in-postman/roles-and-permissions/#team-roles) or [user groups](https://learning.postman.com/docs/collaborating-in-postman/user-groups/) in a workspace. To get a list of roles, use the `GET /workspace-roles` endpoint. **Note:** - This endpoint does not support the external [Partner or Guest roles](https://learning.postman.com/docs/collaborating-in-postman/roles-and-permissions/#team-roles). - This endpoint is restricted to 50 operations per call. - The request body must contain one unique action per user or user group. For example, you cannot add and remove multiple roles for a user in the same request body.                                                                                                                                                                                                                                                                                                                                   |

## GetWorkspacesAsync

Gets all [workspaces](https://learning.postman.com/docs/collaborating-in-postman/using-workspaces/creating-workspaces/). The response includes your workspaces and any workspaces that you have access to. **Note:** This endpoint's response contains the visibility field. Visibility determines who can access the workspace: - `personal` — Only you can access the workspace. - `team` — All team members can access the workspace. - `private` — Only invited team members can access the workspace ([**Professional** and **Enterprise** plans only](https://www.postman.com/pricing)). - `public` — Everyone can access the workspace. - `partner` — Only invited team members and [partners](https://learning.postman.com/docs/collaborating-in-postman/using-workspaces/partner-workspaces/) can access the workspace ([**Professional** and **Enterprise** plans only](https://www.postman.com/pricing)).

- HTTP Method: `GET`
- Endpoint: `/workspaces`

**Parameters**

| Name      | Type                 | Required | Description                                                                                                                                                                                    |
| :-------- | :------------------- | :------- | :--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| type\_    | GetWorkspacesType    | ❌       | The type of workspace to filter the response by.                                                                                                                                               |
| createdBy | long                 | ❌       | Return only workspaces created by a specific user ID. For multiple users, pass this value as a comma-separated list of user IDs. The response only returns workspaces that you have access to. |
| include   | GetWorkspacesInclude | ❌       | Include the following information in the endpoint's response: - `mocks:deactivated` — Include all deactivated mock servers in the response.                                                    |

**Return Type**

`GetWorkspaces`

**Example Usage Code Snippet**

```csharp
using PostmanClient;
using PostmanClient.Models;

var client = new PostmanClientClient();

var response = await client.Workspaces.GetWorkspacesAsync(GetWorkspacesType.Personal, 12345678, GetWorkspacesInclude.MocksDeactivated);

Console.WriteLine(response);
```

## CreateWorkspaceAsync

Creates a new [workspace](https://learning.postman.com/docs/collaborating-in-postman/using-workspaces/creating-workspaces/). **Note:** This endpoint returns a 403 `Forbidden` response if the user does not have permission to create workspaces. [Admins and Super Admins](https://learning.postman.com/docs/collaborating-in-postman/roles-and-permissions/#team-roles) can configure workspace permissions to restrict users and/or user groups from creating workspaces or require approvals for the creation of team workspaces. ### Important We deprecated linking collections or environments between workspaces. We do not recommend that you do this. If you have a linked collection or environment, note the following: - The endpoint does not create a clone of a collection or environment. - Any changes you make to a linked collection or environment changes them in all workspaces. - If you delete a collection or environment linked between workspaces, the system deletes it in all the workspaces.

- HTTP Method: `POST`
- Endpoint: `/workspaces`

**Parameters**

| Name  | Type                   | Required | Description       |
| :---- | :--------------------- | :------- | :---------------- |
| input | CreateWorkspaceRequest | ❌       | The request body. |

**Return Type**

`CreateWorkspaceOkResponse`

**Example Usage Code Snippet**

```csharp
using PostmanClient;
using PostmanClient.Models;

var client = new PostmanClientClient();

var input = new CreateWorkspaceRequest();

var response = await client.Workspaces.CreateWorkspaceAsync(input);

Console.WriteLine(response);
```

## GetWorkspaceRolesAsync

Gets information about all roles in a workspace, based on the team's [plan](https://www.postman.com/pricing/).

- HTTP Method: `GET`
- Endpoint: `/workspaces-roles`

**Return Type**

`GetWorkspaceRoles`

**Example Usage Code Snippet**

```csharp
using PostmanClient;

var client = new PostmanClientClient();

var response = await client.Workspaces.GetWorkspaceRolesAsync();

Console.WriteLine(response);
```

## GetWorkspaceAsync

Gets information about a workspace. **Note:** This endpoint's response contains the `visibility` field. [Visibility](https://learning.postman.com/docs/collaborating-in-postman/using-workspaces/managing-workspaces/#changing-workspace-visibility) determines who can access the workspace: - `personal` — Only you can access the workspace. - `team` — All team members can access the workspace. - `private` — Only invited team members can access the workspace ([**Professional** and **Enterprise** plans only](https://www.postman.com/pricing)). - `public` — Everyone can access the workspace. - `partner` — Only invited team members and [partners](https://learning.postman.com/docs/collaborating-in-postman/using-workspaces/partner-workspaces/) can access the workspace ([**Professional** and **Enterprise** plans only](https://www.postman.com/pricing)). ### Important We have deprecated the `name` and `uid` responses in the following array of objects: - `collections` - `environments` - `mocks` - `monitors` - `apis`

- HTTP Method: `GET`
- Endpoint: `/workspaces/{workspaceId}`

**Parameters**

| Name        | Type   | Required | Description         |
| :---------- | :----- | :------- | :------------------ |
| workspaceId | string | ✅       | The workspace's ID. |

**Return Type**

`GetWorkspace`

**Example Usage Code Snippet**

```csharp
using PostmanClient;

var client = new PostmanClientClient();

var response = await client.Workspaces.GetWorkspaceAsync("1f0df51a-8658-4ee8-a2a1-d2567dfa09a9");

Console.WriteLine(response);
```

## UpdateWorkspaceAsync

Updates a workspace. ### Important We deprecated linking collections or environments between workspaces. We do not recommend that you do this. If you have a linked collection or environment, note the following: - The endpoint does not create a clone of a collection or environment. - Any changes you make to a linked collection or environment changes them in all workspaces. - If you delete a collection or environment linked between workspaces, the system deletes it in all the workspaces.

- HTTP Method: `PUT`
- Endpoint: `/workspaces/{workspaceId}`

**Parameters**

| Name        | Type                   | Required | Description         |
| :---------- | :--------------------- | :------- | :------------------ |
| input       | UpdateWorkspaceRequest | ❌       | The request body.   |
| workspaceId | string                 | ✅       | The workspace's ID. |

**Return Type**

`UpdateWorkspaceOkResponse`

**Example Usage Code Snippet**

```csharp
using PostmanClient;
using PostmanClient.Models;

var client = new PostmanClientClient();

var input = new UpdateWorkspaceRequest();

var response = await client.Workspaces.UpdateWorkspaceAsync(input, "1f0df51a-8658-4ee8-a2a1-d2567dfa09a9");

Console.WriteLine(response);
```

## DeleteWorkspaceAsync

Deletes an existing workspace. ### Important If you delete a workspace that has a linked collection or environment with another workspace, this will delete the collection and environment in all workspaces.

- HTTP Method: `DELETE`
- Endpoint: `/workspaces/{workspaceId}`

**Parameters**

| Name        | Type   | Required | Description         |
| :---------- | :----- | :------- | :------------------ |
| workspaceId | string | ✅       | The workspace's ID. |

**Return Type**

`DeleteWorkspace`

**Example Usage Code Snippet**

```csharp
using PostmanClient;

var client = new PostmanClientClient();

var response = await client.Workspaces.DeleteWorkspaceAsync("1f0df51a-8658-4ee8-a2a1-d2567dfa09a9");

Console.WriteLine(response);
```

## GetWorkspaceGlobalVariablesAsync

Gets a workspace's global [variables](https://learning.postman.com/docs/sending-requests/variables/#variable-scopes).

- HTTP Method: `GET`
- Endpoint: `/workspaces/{workspaceId}/global-variables`

**Parameters**

| Name        | Type   | Required | Description         |
| :---------- | :----- | :------- | :------------------ |
| workspaceId | string | ✅       | The workspace's ID. |

**Return Type**

`GetWorkspaceGlobalVariables`

**Example Usage Code Snippet**

```csharp
using PostmanClient;

var client = new PostmanClientClient();

var response = await client.Workspaces.GetWorkspaceGlobalVariablesAsync("1f0df51a-8658-4ee8-a2a1-d2567dfa09a9");

Console.WriteLine(response);
```

## UpdateWorkspaceGlobalVariablesAsync

Updates and replaces a workspace's global [variables](https://learning.postman.com/docs/sending-requests/variables/#variable-scopes). This endpoint replaces all existing global variables with the variables you pass in the request body.

- HTTP Method: `PUT`
- Endpoint: `/workspaces/{workspaceId}/global-variables`

**Parameters**

| Name        | Type                                  | Required | Description         |
| :---------- | :------------------------------------ | :------- | :------------------ |
| input       | UpdateWorkspaceGlobalVariablesRequest | ❌       | The request body.   |
| workspaceId | string                                | ✅       | The workspace's ID. |

**Return Type**

`UpdateWorkspaceGlobalVariablesOkResponse`

**Example Usage Code Snippet**

```csharp
using PostmanClient;
using PostmanClient.Models;

var client = new PostmanClientClient();

var input = new UpdateWorkspaceGlobalVariablesRequest();

var response = await client.Workspaces.UpdateWorkspaceGlobalVariablesAsync(input, "1f0df51a-8658-4ee8-a2a1-d2567dfa09a9");

Console.WriteLine(response);
```

## UpdateWorkspaceRolesAsync

Updates the roles of [users](https://learning.postman.com/docs/collaborating-in-postman/roles-and-permissions/#team-roles) or [user groups](https://learning.postman.com/docs/collaborating-in-postman/user-groups/) in a workspace. To get a list of roles, use the `GET /workspace-roles` endpoint. **Note:** - This endpoint does not support the external [Partner or Guest roles](https://learning.postman.com/docs/collaborating-in-postman/roles-and-permissions/#team-roles). - This endpoint is restricted to 50 operations per call. - The request body must contain one unique action per user or user group. For example, you cannot add and remove multiple roles for a user in the same request body.

- HTTP Method: `PATCH`
- Endpoint: `/workspaces/{workspaceId}/roles`

**Parameters**

| Name        | Type                        | Required | Description         |
| :---------- | :-------------------------- | :------- | :------------------ |
| input       | UpdateWorkspaceRolesRequest | ❌       | The request body.   |
| workspaceId | string                      | ✅       | The workspace's ID. |

**Return Type**

`UpdateWorkspaceRolesOkResponse`

**Example Usage Code Snippet**

```csharp
using PostmanClient;
using PostmanClient.Models;

var client = new PostmanClientClient();

var input = new UpdateWorkspaceRolesRequest();

var response = await client.Workspaces.UpdateWorkspaceRolesAsync(input, "1f0df51a-8658-4ee8-a2a1-d2567dfa09a9");

Console.WriteLine(response);
```

<!-- This file was generated by liblab | https://liblab.com/ -->
