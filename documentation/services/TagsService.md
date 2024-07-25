# TagsService

A list of all methods in the `TagsService` service. Click on the method name to view detailed information about that method.

| Methods                                                 | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 |
| :------------------------------------------------------ | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| [GetApiTagsAsync](#getapitagsasync)                     | Gets all the tags associated with an API.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   |
| [UpdateApiTagsAsync](#updateapitagsasync)               | Updates an API's associated tags. This endpoint replaces all existing tags with those you pass in the request body.                                                                                                                                                                                                                                                                                                                                                                                                                                                         |
| [GetCollectionTagsAsync](#getcollectiontagsasync)       | Gets all the tags associated with a collection.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             |
| [UpdateCollectionTagsAsync](#updatecollectiontagsasync) | Updates a collection's associated tags. This endpoint replaces all existing tags with those you pass in the request body.                                                                                                                                                                                                                                                                                                                                                                                                                                                   |
| [GetTaggedEntitiesAsync](#gettaggedentitiesasync)       | Gets Postman elements (entities) by a given tag. Tags enable you to organize and search [workspaces](https://learning.postman.com/docs/collaborating-in-postman/using-workspaces/managing-workspaces/#tagging-a-workspace), [APIs](https://learning.postman.com/docs/designing-and-developing-your-api/managing-apis/#tagging-apis), and [collections](https://learning.postman.com/docs/collections/using-collections/#tagging-a-collection) that contain shared tags. **Note:** Tagging is available on Postman [**Enterprise** plans](https://www.postman.com/pricing/). |
| [GetWorkspaceTagsAsync](#getworkspacetagsasync)         | Gets all the tags associated with a workspace.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |
| [UpdateWorkspaceTagsAsync](#updateworkspacetagsasync)   | Updates a workspace's associated tags. This endpoint replaces all existing tags with those you pass in the request body.                                                                                                                                                                                                                                                                                                                                                                                                                                                    |

## GetApiTagsAsync

Gets all the tags associated with an API.

- HTTP Method: `GET`
- Endpoint: `/apis/{apiId}/tags`

**Parameters**

| Name   | Type   | Required | Description                                                                     |
| :----- | :----- | :------- | :------------------------------------------------------------------------------ |
| apiId  | string | ✅       | The API's unique ID.                                                            |
| accept | Accept | ✅       | The `application/vnd.api.v10+json` request header required to use the endpoint. |

**Return Type**

`TagGetPut`

**Example Usage Code Snippet**

```csharp
using PostmanClient;
using PostmanClient.Models;

var client = new PostmanClientClient();

var response = await client.Tags.GetApiTagsAsync("12345678-6fd634a3-79ba-451d-8f07-56a953f96667", Accept.ApplicationVndApiV10Json);

Console.WriteLine(response);
```

## UpdateApiTagsAsync

Updates an API's associated tags. This endpoint replaces all existing tags with those you pass in the request body.

- HTTP Method: `PUT`
- Endpoint: `/apis/{apiId}/tags`

**Parameters**

| Name   | Type          | Required | Description                                                                     |
| :----- | :------------ | :------- | :------------------------------------------------------------------------------ |
| input  | TagUpdateTags | ❌       | The request body.                                                               |
| apiId  | string        | ✅       | The API's unique ID.                                                            |
| accept | Accept        | ✅       | The `application/vnd.api.v10+json` request header required to use the endpoint. |

**Return Type**

`TagGetPut`

**Example Usage Code Snippet**

```csharp
using PostmanClient;
using PostmanClient.Models;

var client = new PostmanClientClient();

var tagsItem = new TagUpdateTags.TagUpdateTagsTags("needs-review");
var tags = new List<TagUpdateTags.TagUpdateTagsTags>() { tagsItem };
var input = new TagUpdateTags(tags);

var response = await client.Tags.UpdateApiTagsAsync(input, "12345678-6fd634a3-79ba-451d-8f07-56a953f96667", Accept.ApplicationVndApiV10Json);

Console.WriteLine(response);
```

## GetCollectionTagsAsync

Gets all the tags associated with a collection.

- HTTP Method: `GET`
- Endpoint: `/collections/{collectionId}/tags`

**Parameters**

| Name         | Type   | Required | Description                 |
| :----------- | :----- | :------- | :-------------------------- |
| collectionId | string | ✅       | The collection's unique ID. |

**Return Type**

`TagGetPut`

**Example Usage Code Snippet**

```csharp
using PostmanClient;

var client = new PostmanClientClient();

var response = await client.Tags.GetCollectionTagsAsync("12345678-12ece9e1-2abf-4edc-8e34-de66e74114d2");

Console.WriteLine(response);
```

## UpdateCollectionTagsAsync

Updates a collection's associated tags. This endpoint replaces all existing tags with those you pass in the request body.

- HTTP Method: `PUT`
- Endpoint: `/collections/{collectionId}/tags`

**Parameters**

| Name         | Type          | Required | Description                 |
| :----------- | :------------ | :------- | :-------------------------- |
| input        | TagUpdateTags | ❌       | The request body.           |
| collectionId | string        | ✅       | The collection's unique ID. |

**Return Type**

`TagGetPut`

**Example Usage Code Snippet**

```csharp
using PostmanClient;
using PostmanClient.Models;

var client = new PostmanClientClient();

var tagsItem = new TagUpdateTags.TagUpdateTagsTags("needs-review");
var tags = new List<TagUpdateTags.TagUpdateTagsTags>() { tagsItem };
var input = new TagUpdateTags(tags);

var response = await client.Tags.UpdateCollectionTagsAsync(input, "12345678-12ece9e1-2abf-4edc-8e34-de66e74114d2");

Console.WriteLine(response);
```

## GetTaggedEntitiesAsync

Gets Postman elements (entities) by a given tag. Tags enable you to organize and search [workspaces](https://learning.postman.com/docs/collaborating-in-postman/using-workspaces/managing-workspaces/#tagging-a-workspace), [APIs](https://learning.postman.com/docs/designing-and-developing-your-api/managing-apis/#tagging-apis), and [collections](https://learning.postman.com/docs/collections/using-collections/#tagging-a-collection) that contain shared tags. **Note:** Tagging is available on Postman [**Enterprise** plans](https://www.postman.com/pricing/).

- HTTP Method: `GET`
- Endpoint: `/tags/{slug}/entities`

**Parameters**

| Name       | Type                        | Required | Description                                                                                                                                       |
| :--------- | :-------------------------- | :------- | :------------------------------------------------------------------------------------------------------------------------------------------------ |
| slug       | string                      | ✅       | The tag's ID within a team or individual (non-team) user scope.                                                                                   |
| limit      | long                        | ❌       | The maximum number of tagged elements to return in a single call.                                                                                 |
| direction  | AscDescDefaultDesc          | ❌       | The ascending (`asc`) or descending (`desc`) order to sort the results by, based on the time of the entity's tagging.                             |
| cursor     | string                      | ❌       | The cursor to get the next set of results in the paginated response. If you pass an invalid value, the API only returns the first set of results. |
| entityType | GetTaggedEntitiesEntityType | ❌       | Filter results for the given entity type.                                                                                                         |

**Return Type**

`GetTaggedEntities`

**Example Usage Code Snippet**

```csharp
using PostmanClient;
using PostmanClient.Models;

var client = new PostmanClientClient();

var response = await client.Tags.GetTaggedEntitiesAsync("needs-review", 2, AscDescDefaultDesc.Asc, "eyJpZCI6ODYsImVudGl0eVR5cGUiOiJhcGkifQ==", GetTaggedEntitiesEntityType.Api);

Console.WriteLine(response);
```

## GetWorkspaceTagsAsync

Gets all the tags associated with a workspace.

- HTTP Method: `GET`
- Endpoint: `/workspaces/{workspaceId}/tags`

**Parameters**

| Name        | Type   | Required | Description         |
| :---------- | :----- | :------- | :------------------ |
| workspaceId | string | ✅       | The workspace's ID. |

**Return Type**

`TagGetPut`

**Example Usage Code Snippet**

```csharp
using PostmanClient;

var client = new PostmanClientClient();

var response = await client.Tags.GetWorkspaceTagsAsync("1f0df51a-8658-4ee8-a2a1-d2567dfa09a9");

Console.WriteLine(response);
```

## UpdateWorkspaceTagsAsync

Updates a workspace's associated tags. This endpoint replaces all existing tags with those you pass in the request body.

- HTTP Method: `PUT`
- Endpoint: `/workspaces/{workspaceId}/tags`

**Parameters**

| Name        | Type          | Required | Description         |
| :---------- | :------------ | :------- | :------------------ |
| input       | TagUpdateTags | ❌       | The request body.   |
| workspaceId | string        | ✅       | The workspace's ID. |

**Return Type**

`TagGetPut`

**Example Usage Code Snippet**

```csharp
using PostmanClient;
using PostmanClient.Models;

var client = new PostmanClientClient();

var tagsItem = new TagUpdateTags.TagUpdateTagsTags("needs-review");
var tags = new List<TagUpdateTags.TagUpdateTagsTags>() { tagsItem };
var input = new TagUpdateTags(tags);

var response = await client.Tags.UpdateWorkspaceTagsAsync(input, "1f0df51a-8658-4ee8-a2a1-d2567dfa09a9");

Console.WriteLine(response);
```

<!-- This file was generated by liblab | https://liblab.com/ -->
