# ScimService

A list of all methods in the `ScimService` service. Click on the method name to view detailed information about that method.

| Methods                                                                 | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             |
| :---------------------------------------------------------------------- | :---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| [GetScimGroupResourcesAsync](#getscimgroupresourcesasync)               | Gets information about all Postman team members.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        |
| [CreateScimGroupAsync](#createscimgroupasync)                           | Creates a new user group in Postman and creates a new account for each group member. Each account is added to your Postman team and authentication is activated for each user. If an existing Postman account uses an email that matches a group member's email ID, an [email invite](https://postman.postman.co/docs/administration/managing-your-team/managing-your-team/#invites) to join your Postman team is sent to that user. Once the user accepts the invite, they'll be added to your team. By default, the system assigns new users the developer role. You can [update user roles in Postman](https://learning.postman.com/docs/administration/managing-your-team/managing-your-team/#managing-team-roles). |
| [GetScimGroupResourceAsync](#getscimgroupresourceasync)                 | Gets information about a Postman group within the team.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 |
| [ScimUpdateGroupAsync](#scimupdategroupasync)                           | Updates a group's information. Using this endpoint you can: - Update a group's name. - Add or remove members from a Postman group.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      |
| [DeleteScimGroupAsync](#deletescimgroupasync)                           | Deletes a group in Postman. User accounts that were in the deleted group are deactivated in Postman if the app is assigned to the user only with the deleted group. User accounts and the data corresponding to them are not deleted. To permanently delete user accounts and their data, [contact Postman support](https://www.postman.com/support/).                                                                                                                                                                                                                                                                                                                                                                  |
| [GetScimResourceTypesAsync](#getscimresourcetypesasync)                 | Gets all the resource types supported by Postman's SCIM API.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            |
| [GetScimServiceProviderConfigAsync](#getscimserviceproviderconfigasync) | Gets the Postman SCIM API configuration information. This includes a list of supported operations.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      |
| [GetScimUserResourcesAsync](#getscimuserresourcesasync)                 | Gets information about all Postman team members.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        |
| [CreateScimUserAsync](#createscimuserasync)                             | Creates a new user account in Postman and adds the user to your organization's Postman team. If the account does not already exist, this also activates the user so they can authenticate in to your Postman team. If the account already exists, the system sends the user an [email invite](https://learning.postman.com/docs/administration/managing-your-team/managing-your-team/#inviting-users) to join the Postman team. The user joins the team once they accept the invite. By default, the system assigns new users the developer role. You can [update user roles in Postman](https://learning.postman.com/docs/administration/managing-your-team/managing-your-team/#managing-team-roles).                  |
| [GetScimUserResourceAsync](#getscimuserresourceasync)                   | Gets information about a Postman team member.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           |
| [UpdateScimUserAsync](#updatescimuserasync)                             | Updates a user's first and last name in Postman. **Note:** You can only use the SCIM API to update a user's first and last name. You cannot update any other user attributes with the API.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
| [UpdateScimUserStateAsync](#updatescimuserstateasync)                   | Updates a user's active state in Postman. **Reactivating a user** By setting the `active` property from `false` to `true`, this reactivates an account. This allows the account to authenticate in to Postman and adds the account back on to your Postman team.                                                                                                                                                                                                                                                                                                                                                                                                                                                        |

## GetScimGroupResourcesAsync

Gets information about all Postman team members.

- HTTP Method: `GET`
- Endpoint: `/scim/v2/Groups`

**Parameters**

| Name       | Type   | Required | Description                                                                                                                                                                                                                           |
| :--------- | :----- | :------- | :------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| startIndex | double | ❌       | The index entry by which to begin the list of returned results.                                                                                                                                                                       |
| count      | double | ❌       | Limit the number of results returned in a single response.                                                                                                                                                                            |
| filter     | string | ❌       | Filter results by a specific word or phrase. This query parameter only supports the `displayName` filter and has the following requirements: - Filter values are case-sensitive. - Special characters and spaces must be URL encoded. |

**Return Type**

`GetScimGroupResources`

**Example Usage Code Snippet**

```csharp
using PostmanClient;

var client = new PostmanClientClient();

var response = await client.Scim.GetScimGroupResourcesAsync(1, 2, "displayName eq "Test-API"");

Console.WriteLine(response);
```

## CreateScimGroupAsync

Creates a new user group in Postman and creates a new account for each group member. Each account is added to your Postman team and authentication is activated for each user. If an existing Postman account uses an email that matches a group member's email ID, an [email invite](https://postman.postman.co/docs/administration/managing-your-team/managing-your-team/#invites) to join your Postman team is sent to that user. Once the user accepts the invite, they'll be added to your team. By default, the system assigns new users the developer role. You can [update user roles in Postman](https://learning.postman.com/docs/administration/managing-your-team/managing-your-team/#managing-team-roles).

- HTTP Method: `POST`
- Endpoint: `/scim/v2/Groups`

**Parameters**

| Name  | Type                   | Required | Description       |
| :---- | :--------------------- | :------- | :---------------- |
| input | CreateScimGroupRequest | ❌       | The request body. |

**Return Type**

`CreateScimGroupCreatedResponse`

**Example Usage Code Snippet**

```csharp
using PostmanClient;
using PostmanClient.Models;

var client = new PostmanClientClient();

var input = new CreateScimGroupRequest();

var response = await client.Scim.CreateScimGroupAsync(input);

Console.WriteLine(response);
```

## GetScimGroupResourceAsync

Gets information about a Postman group within the team.

- HTTP Method: `GET`
- Endpoint: `/scim/v2/Groups/{groupId}`

**Parameters**

| Name    | Type   | Required | Description     |
| :------ | :----- | :------- | :-------------- |
| groupId | string | ✅       | The group's ID. |

**Return Type**

`GetScimGroupResource`

**Example Usage Code Snippet**

```csharp
using PostmanClient;

var client = new PostmanClientClient();

var response = await client.Scim.GetScimGroupResourceAsync("405775fe15ed41872a8eea4c8aa2b38cda9749812cc55c99");

Console.WriteLine(response);
```

## ScimUpdateGroupAsync

Updates a group's information. Using this endpoint you can: - Update a group's name. - Add or remove members from a Postman group.

- HTTP Method: `PATCH`
- Endpoint: `/scim/v2/Groups/{groupId}`

**Parameters**

| Name    | Type                   | Required | Description       |
| :------ | :--------------------- | :------- | :---------------- |
| input   | ScimUpdateGroupRequest | ❌       | The request body. |
| groupId | string                 | ✅       | The group's ID.   |

**Return Type**

`ScimUpdateGroupOkResponse`

**Example Usage Code Snippet**

```csharp
using PostmanClient;
using PostmanClient.Models;

var client = new PostmanClientClient();

var input = new ScimUpdateGroupRequest();

var response = await client.Scim.ScimUpdateGroupAsync(input, "405775fe15ed41872a8eea4c8aa2b38cda9749812cc55c99");

Console.WriteLine(response);
```

## DeleteScimGroupAsync

Deletes a group in Postman. User accounts that were in the deleted group are deactivated in Postman if the app is assigned to the user only with the deleted group. User accounts and the data corresponding to them are not deleted. To permanently delete user accounts and their data, [contact Postman support](https://www.postman.com/support/).

- HTTP Method: `DELETE`
- Endpoint: `/scim/v2/Groups/{groupId}`

**Parameters**

| Name    | Type   | Required | Description     |
| :------ | :----- | :------- | :-------------- |
| groupId | string | ✅       | The group's ID. |

**Example Usage Code Snippet**

```csharp
using PostmanClient;

var client = new PostmanClientClient();

await client.Scim.DeleteScimGroupAsync("405775fe15ed41872a8eea4c8aa2b38cda9749812cc55c99");
```

## GetScimResourceTypesAsync

Gets all the resource types supported by Postman's SCIM API.

- HTTP Method: `GET`
- Endpoint: `/scim/v2/ResourceTypes`

**Return Type**

`List<GetScimResourceTypes>`

**Example Usage Code Snippet**

```csharp
using PostmanClient;

var client = new PostmanClientClient();

var response = await client.Scim.GetScimResourceTypesAsync();

Console.WriteLine(response);
```

## GetScimServiceProviderConfigAsync

Gets the Postman SCIM API configuration information. This includes a list of supported operations.

- HTTP Method: `GET`
- Endpoint: `/scim/v2/ServiceProviderConfig`

**Return Type**

`GetScimServiceProviderConfig`

**Example Usage Code Snippet**

```csharp
using PostmanClient;

var client = new PostmanClientClient();

var response = await client.Scim.GetScimServiceProviderConfigAsync();

Console.WriteLine(response);
```

## GetScimUserResourcesAsync

Gets information about all Postman team members.

- HTTP Method: `GET`
- Endpoint: `/scim/v2/Users`

**Parameters**

| Name       | Type   | Required | Description                                                                                                                                                                                                                        |
| :--------- | :----- | :------- | :--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| startIndex | double | ❌       | The index entry by which to begin the list of returned results.                                                                                                                                                                    |
| count      | double | ❌       | Limit the number of results returned in a single response.                                                                                                                                                                         |
| filter     | string | ❌       | Filter results by a specific word or phrase. This query parameter only supports the `userName` filter and has the following requirements: - Filter values are case-sensitive. - Special characters and spaces must be URL encoded. |

**Return Type**

`GetScimUserResources`

**Example Usage Code Snippet**

```csharp
using PostmanClient;

var client = new PostmanClientClient();

var response = await client.Scim.GetScimUserResourcesAsync(1, 2, "filter");

Console.WriteLine(response);
```

## CreateScimUserAsync

Creates a new user account in Postman and adds the user to your organization's Postman team. If the account does not already exist, this also activates the user so they can authenticate in to your Postman team. If the account already exists, the system sends the user an [email invite](https://learning.postman.com/docs/administration/managing-your-team/managing-your-team/#inviting-users) to join the Postman team. The user joins the team once they accept the invite. By default, the system assigns new users the developer role. You can [update user roles in Postman](https://learning.postman.com/docs/administration/managing-your-team/managing-your-team/#managing-team-roles).

- HTTP Method: `POST`
- Endpoint: `/scim/v2/Users`

**Parameters**

| Name  | Type                  | Required | Description       |
| :---- | :-------------------- | :------- | :---------------- |
| input | CreateScimUserRequest | ❌       | The request body. |

**Return Type**

`CreateScimUserCreatedResponse`

**Example Usage Code Snippet**

```csharp
using PostmanClient;
using PostmanClient.Models;

var client = new PostmanClientClient();

var input = new CreateScimUserRequest();

var response = await client.Scim.CreateScimUserAsync(input);

Console.WriteLine(response);
```

## GetScimUserResourceAsync

Gets information about a Postman team member.

- HTTP Method: `GET`
- Endpoint: `/scim/v2/Users/{userId}`

**Parameters**

| Name   | Type   | Required | Description         |
| :----- | :----- | :------- | :------------------ |
| userId | string | ✅       | The user's SCIM ID. |

**Return Type**

`GetScimUserResourceOkResponse`

**Example Usage Code Snippet**

```csharp
using PostmanClient;

var client = new PostmanClientClient();

var response = await client.Scim.GetScimUserResourceAsync("405775fe15ed41872a8eea4c8aa2b38cda9749812cc55c99");

Console.WriteLine(response);
```

## UpdateScimUserAsync

Updates a user's first and last name in Postman. **Note:** You can only use the SCIM API to update a user's first and last name. You cannot update any other user attributes with the API.

- HTTP Method: `PUT`
- Endpoint: `/scim/v2/Users/{userId}`

**Parameters**

| Name   | Type           | Required | Description         |
| :----- | :------------- | :------- | :------------------ |
| input  | UpdateScimUser | ❌       | The request body.   |
| userId | string         | ✅       | The user's SCIM ID. |

**Return Type**

`GetScimUserResourceOkResponse`

**Example Usage Code Snippet**

```csharp
using PostmanClient;
using PostmanClient.Models;

var client = new PostmanClientClient();

var input = new UpdateScimUser();

var response = await client.Scim.UpdateScimUserAsync(input, "405775fe15ed41872a8eea4c8aa2b38cda9749812cc55c99");

Console.WriteLine(response);
```

## UpdateScimUserStateAsync

Updates a user's active state in Postman. **Reactivating a user** By setting the `active` property from `false` to `true`, this reactivates an account. This allows the account to authenticate in to Postman and adds the account back on to your Postman team.

- HTTP Method: `PATCH`
- Endpoint: `/scim/v2/Users/{userId}`

**Parameters**

| Name   | Type                | Required | Description         |
| :----- | :------------------ | :------- | :------------------ |
| input  | UpdateScimUserState | ❌       | The request body.   |
| userId | string              | ✅       | The user's SCIM ID. |

**Return Type**

`GetScimUserResourceOkResponse`

**Example Usage Code Snippet**

```csharp
using PostmanClient;
using PostmanClient.Models;

var client = new PostmanClientClient();

var input = new UpdateScimUserState();

var response = await client.Scim.UpdateScimUserStateAsync(input, "405775fe15ed41872a8eea4c8aa2b38cda9749812cc55c99");

Console.WriteLine(response);
```

<!-- This file was generated by liblab | https://liblab.com/ -->
