# CollectionsService

A list of all methods in the `CollectionsService` service. Click on the method name to view detailed information about that method.

| Methods                                                                 | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            |
| :---------------------------------------------------------------------- | :--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| [GetCollectionsAsync](#getcollectionsasync)                             | Gets all of your [collections](https://www.getpostman.com/docs/collections). The response includes all of your subscribed collections.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 |
| [CreateCollectionAsync](#createcollectionasync)                         | Creates a collection using the [Postman Collection v2 schema format](https://schema.postman.com/json/collection/v2.1.0/docs/index.html). For more information about the Collection Format, see the [Postman Collection Format documentation](https://learning.postman.com/collection-format/getting-started/overview/). **Note:** - For a complete list of available property values for this endpoint, use the following references available in the [collection.json schema file](https://schema.postman.com/json/collection/v2.1.0/collection.json): - `info` object — Use the `definitions.info` entry. - `item` object — Use the `definitions.items` entry. - For all other possible values, refer to the [collection.json schema file](https://schema.postman.com/json/collection/v2.1.0/collection.json).                                                                                                                                                                                                                                                                                                                                                                                                                                                       |
| [CreateCollectionForkAsync](#createcollectionforkasync)                 | Creates a [fork](https://learning.postman.com/docs/collaborating-in-postman/version-control/#creating-a-fork) from an existing collection into a workspace.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            |
| [MergeCollectionForkAsync](#mergecollectionforkasync)                   | Merges a forked collection back into its parent collection.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            |
| [GetCollectionAsync](#getcollectionasync)                               | Gets information about a collection. For a complete list of this endpoint's possible values, use the [collection.json schema file](https://schema.postman.com/json/collection/v2.1.0/collection.json).                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 |
| [PutCollectionAsync](#putcollectionasync)                               | Replaces the contents of a collection using the [Postman Collection v2 schema format](https://schema.postman.com/json/collection/v2.1.0/docs/index.html). Include the collection's ID values in the request body. If you do not, the endpoint removes the existing items and creates new items. > The maximum collection size this endpoint accepts cannot exceed 20 MB. For a complete list of available property values for this endpoint, use the following references available in the [collection.json schema file](https://schema.postman.com/json/collection/v2.1.0/collection.json): - `info` object — Use `../definitions/info"`. - `item` object — Use `../definitions/item"`. For all other possible values, refer to the [collection.json schema file](https://schema.postman.com/json/collection/v2.1.0/collection.json). For more information about the Collection Format, see the [Postman Collection Format documentation](https://learning.postman.com/collection-format/getting-started/overview/). **Note:** To copy another collection's contents to the given collection, remove all ID values before you pass it in this endpoint. If you do not, this endpoint returns an error. These values include the `id`, `uid`, and `postman_id` values. |
| [PatchCollectionAsync](#patchcollectionasync)                           | Updates specific collection information, such as its name, events, or its variables. For more information about the `auth`, `variables`, and `events` properties, refer to the [collection.json schema file](https://schema.postman.com/json/collection/v2.1.0/collection.json): - For `variables`, refer to `../definitions/variable"`. - For `auth`, refer to `../definitions/auth-attribute"`. - For `events`, refer to `../definitions/event"`. For more information about the Collection Format, see the [Postman Collection Format documentation](https://learning.postman.com/collection-format/getting-started/overview/).                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     |
| [DeleteCollectionAsync](#deletecollectionasync)                         | Deletes a collection.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  |
| [GetCollectionsForkedByUserAsync](#getcollectionsforkedbyuserasync)     | Gets a list of all the authenticated user's forked collections.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        |
| [GetCollectionCommentsAsync](#getcollectioncommentsasync)               | Gets all comments left by users in a collection.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       |
| [CreateCollectionCommentAsync](#createcollectioncommentasync)           | Creates a comment on a collection. **Note:** This endpoint accepts a max of 10,000 characters.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         |
| [UpdateCollectionCommentAsync](#updatecollectioncommentasync)           | Updates a comment on a collection. **Note:** This endpoint accepts a max of 10,000 characters.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         |
| [DeleteCollectionCommentAsync](#deletecollectioncommentasync)           | Deletes a comment from a collection. On success, this returns an HTTP `204 No Content` response **Note:** Deleting the first comment of a thread deletes all the comments in the thread.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               |
| [GetCollectionForksAsync](#getcollectionforksasync)                     | Gets a collection's forked collections. The response returns data for each fork, such as the fork's ID, the user who forked it, and the fork's creation date.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          |
| [PullCollectionChangesAsync](#pullcollectionchangesasync)               | Pulls the changes from a parent (source) collection into the forked collection. In the endpoint's response: - The `destinationId` is the ID of the forked collection. - The `sourceId` is the ID of the source collection.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             |
| [GetCollectionPullRequestsAsync](#getcollectionpullrequestsasync)       | Gets information about a collection's pull requests, such as the source and destination IDs, status of the pull requests, and a URL link to the pull requests.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         |
| [CreateCollectionPullRequestAsync](#createcollectionpullrequestasync)   | Creates a pull request for a forked collection into its parent collection.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             |
| [GetCollectionRolesAsync](#getcollectionrolesasync)                     | Gets information about all roles in a collection. The response returns the IDs of all users, teams, and groups with access to view or edit the collection.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             |
| [UpdateCollectionRolesAsync](#updatecollectionrolesasync)               | Updates the roles of users, groups, or teams in a collection. On success, this returns a `204 No Content` response. **Note:** - Only users assigned the EDITOR [role](https://learning.postman.com/docs/collaborating-in-postman/roles-and-permissions/#collection-roles) in the collection can use this endpoint. - This endpoint does not support the external [Partner or Guest roles](https://learning.postman.com/docs/collaborating-in-postman/roles-and-permissions/#team-roles).                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               |
| [GetSourceCollectionStatusAsync](#getsourcecollectionstatusasync)       | Checks whether there is a change between the forked collection and its parent (source) collection. If the value of the `isSourceAhead` property is `true` in the response, then there is a difference between the forked collection and its source collection. **Note:** This endpoint may take a few minutes to return an updated `isSourceAhead` status.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             |
| [TransformCollectionToOpenApiAsync](#transformcollectiontoopenapiasync) | Transforms an existing Postman Collection into a stringified OpenAPI definition. **Note:** This does not create an API.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                |
| [TransferCollectionFoldersAsync](#transfercollectionfoldersasync)       | Copies or moves folders into a collection or folder.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   |
| [TransferCollectionRequestsAsync](#transfercollectionrequestsasync)     | Copies or moves requests into a collection or folder.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  |
| [TransferCollectionResponsesAsync](#transfercollectionresponsesasync)   | Copies or moves responses into a request.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                              |

## GetCollectionsAsync

Gets all of your [collections](https://www.getpostman.com/docs/collections). The response includes all of your subscribed collections.

- HTTP Method: `GET`
- Endpoint: `/collections`

**Parameters**

| Name      | Type   | Required | Description                                              |
| :-------- | :----- | :------- | :------------------------------------------------------- |
| workspace | string | ❌       | The workspace's ID.                                      |
| name      | string | ❌       | Filter results by collections that match the given name. |

**Return Type**

`GetCollections`

**Example Usage Code Snippet**

```csharp
using PostmanClient;

var client = new PostmanClientClient();

var response = await client.Collections.GetCollectionsAsync("1f0df51a-8658-4ee8-a2a1-d2567dfa09a9", "Test Collection");

Console.WriteLine(response);
```

## CreateCollectionAsync

Creates a collection using the [Postman Collection v2 schema format](https://schema.postman.com/json/collection/v2.1.0/docs/index.html). For more information about the Collection Format, see the [Postman Collection Format documentation](https://learning.postman.com/collection-format/getting-started/overview/). **Note:** - For a complete list of available property values for this endpoint, use the following references available in the [collection.json schema file](https://schema.postman.com/json/collection/v2.1.0/collection.json): - `info` object — Use the `definitions.info` entry. - `item` object — Use the `definitions.items` entry. - For all other possible values, refer to the [collection.json schema file](https://schema.postman.com/json/collection/v2.1.0/collection.json).

- HTTP Method: `POST`
- Endpoint: `/collections`

**Parameters**

| Name      | Type                               | Required | Description         |
| :-------- | :--------------------------------- | :------- | :------------------ |
| input     | CollectionsCreateCollectionRequest | ❌       | The request body.   |
| workspace | string                             | ❌       | The workspace's ID. |

**Return Type**

`CreateCollectionOkResponse`

**Example Usage Code Snippet**

```csharp
using PostmanClient;
using PostmanClient.Models;

var client = new PostmanClientClient();

var input = new CollectionsCreateCollectionRequest();

var response = await client.Collections.CreateCollectionAsync(input, "1f0df51a-8658-4ee8-a2a1-d2567dfa09a9");

Console.WriteLine(response);
```

## CreateCollectionForkAsync

Creates a [fork](https://learning.postman.com/docs/collaborating-in-postman/version-control/#creating-a-fork) from an existing collection into a workspace.

- HTTP Method: `POST`
- Endpoint: `/collections/fork/{collectionId}`

**Parameters**

| Name         | Type                        | Required | Description                                   |
| :----------- | :-------------------------- | :------- | :-------------------------------------------- |
| input        | CreateCollectionForkRequest | ❌       | The request body.                             |
| collectionId | string                      | ✅       | The collection's ID.                          |
| workspace    | string                      | ✅       | The workspace ID in which to create the fork. |

**Return Type**

`CreateCollectionForkOkResponse`

**Example Usage Code Snippet**

```csharp
using PostmanClient;
using PostmanClient.Models;

var client = new PostmanClientClient();

var input = new CreateCollectionForkRequest("Test Fork");

var response = await client.Collections.CreateCollectionForkAsync(input, "12ece9e1-2abf-4edc-8e34-de66e74114d2", "1f0df51a-8658-4ee8-a2a1-d2567dfa09a9");

Console.WriteLine(response);
```

## MergeCollectionForkAsync

Merges a forked collection back into its parent collection.

- HTTP Method: `POST`
- Endpoint: `/collections/merge`

**Parameters**

| Name  | Type                       | Required | Description       |
| :---- | :------------------------- | :------- | :---------------- |
| input | MergeCollectionForkRequest | ❌       | The request body. |

**Return Type**

`MergeCollectionForkOkResponse`

**Example Usage Code Snippet**

```csharp
using PostmanClient;
using PostmanClient.Models;

var client = new PostmanClientClient();

var input = new MergeCollectionForkRequest("12345678-12ece9e1-2abf-4edc-8e34-de66e74114d2", "12345678-12ece9e1-2abf-4edc-8e34-de66e74114d2");

var response = await client.Collections.MergeCollectionForkAsync(input);

Console.WriteLine(response);
```

## GetCollectionAsync

Gets information about a collection. For a complete list of this endpoint's possible values, use the [collection.json schema file](https://schema.postman.com/json/collection/v2.1.0/collection.json).

- HTTP Method: `GET`
- Endpoint: `/collections/{collectionId}`

**Parameters**

| Name         | Type               | Required | Description                                                                                                                                                      |
| :----------- | :----------------- | :------- | :--------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| collectionId | string             | ✅       | The collection's ID.                                                                                                                                             |
| accessKey    | string             | ❌       | A collection's read-only access key. Using this query parameter does not require an API key to call the endpoint.                                                |
| model        | GetCollectionModel | ❌       | Return a list of only the collection's root-level request (`rootLevelRequests`) and folder (`rootLevelFolders`) IDs instead of the full collection element data. |

**Return Type**

`GetCollection`

**Example Usage Code Snippet**

```csharp
using PostmanClient;
using PostmanClient.Models;

var client = new PostmanClientClient();

var response = await client.Collections.GetCollectionAsync("12ece9e1-2abf-4edc-8e34-de66e74114d2", "PMAT-XXXXXXXXXXXXXXXXXXXXXXXXXX", GetCollectionModel.Minimal);

Console.WriteLine(response);
```

## PutCollectionAsync

Replaces the contents of a collection using the [Postman Collection v2 schema format](https://schema.postman.com/json/collection/v2.1.0/docs/index.html). Include the collection's ID values in the request body. If you do not, the endpoint removes the existing items and creates new items. > The maximum collection size this endpoint accepts cannot exceed 20 MB. For a complete list of available property values for this endpoint, use the following references available in the [collection.json schema file](https://schema.postman.com/json/collection/v2.1.0/collection.json): - `info` object — Use `../definitions/info"`. - `item` object — Use `../definitions/item"`. For all other possible values, refer to the [collection.json schema file](https://schema.postman.com/json/collection/v2.1.0/collection.json). For more information about the Collection Format, see the [Postman Collection Format documentation](https://learning.postman.com/collection-format/getting-started/overview/). **Note:** To copy another collection's contents to the given collection, remove all ID values before you pass it in this endpoint. If you do not, this endpoint returns an error. These values include the `id`, `uid`, and `postman_id` values.

- HTTP Method: `PUT`
- Endpoint: `/collections/{collectionId}`

**Parameters**

| Name         | Type                 | Required | Description          |
| :----------- | :------------------- | :------- | :------------------- |
| input        | PutCollectionRequest | ❌       | The request body.    |
| collectionId | string               | ✅       | The collection's ID. |

**Return Type**

`PutCollectionOkResponse`

**Example Usage Code Snippet**

```csharp
using PostmanClient;
using PostmanClient.Models;

var client = new PostmanClientClient();

var input = new PutCollectionRequest();

var response = await client.Collections.PutCollectionAsync(input, "12ece9e1-2abf-4edc-8e34-de66e74114d2");

Console.WriteLine(response);
```

## PatchCollectionAsync

Updates specific collection information, such as its name, events, or its variables. For more information about the `auth`, `variables`, and `events` properties, refer to the [collection.json schema file](https://schema.postman.com/json/collection/v2.1.0/collection.json): - For `variables`, refer to `../definitions/variable"`. - For `auth`, refer to `../definitions/auth-attribute"`. - For `events`, refer to `../definitions/event"`. For more information about the Collection Format, see the [Postman Collection Format documentation](https://learning.postman.com/collection-format/getting-started/overview/).

- HTTP Method: `PATCH`
- Endpoint: `/collections/{collectionId}`

**Parameters**

| Name         | Type                   | Required | Description          |
| :----------- | :--------------------- | :------- | :------------------- |
| input        | PatchCollectionRequest | ❌       | The request body.    |
| collectionId | string                 | ✅       | The collection's ID. |

**Return Type**

`PatchCollectionOkResponse`

**Example Usage Code Snippet**

```csharp
using PostmanClient;
using PostmanClient.Models;

var client = new PostmanClientClient();

var input = new PatchCollectionRequest();

var response = await client.Collections.PatchCollectionAsync(input, "12ece9e1-2abf-4edc-8e34-de66e74114d2");

Console.WriteLine(response);
```

## DeleteCollectionAsync

Deletes a collection.

- HTTP Method: `DELETE`
- Endpoint: `/collections/{collectionId}`

**Parameters**

| Name         | Type   | Required | Description          |
| :----------- | :----- | :------- | :------------------- |
| collectionId | string | ✅       | The collection's ID. |

**Return Type**

`DeleteCollection`

**Example Usage Code Snippet**

```csharp
using PostmanClient;

var client = new PostmanClientClient();

var response = await client.Collections.DeleteCollectionAsync("12ece9e1-2abf-4edc-8e34-de66e74114d2");

Console.WriteLine(response);
```

## GetCollectionsForkedByUserAsync

Gets a list of all the authenticated user's forked collections.

- HTTP Method: `GET`
- Endpoint: `/collections/{collectionId}/collection-forks`

**Parameters**

| Name         | Type    | Required | Description                                                                                                                                |
| :----------- | :------ | :------- | :----------------------------------------------------------------------------------------------------------------------------------------- |
| collectionId | string  | ✅       | The collection's ID.                                                                                                                       |
| cursor       | string  | ❌       | The pointer to the first record of the set of paginated results. To view the next response, use the `nextCursor` value for this parameter. |
| limit        | long    | ❌       | The maximum number of rows to return in the response.                                                                                      |
| direction    | AscDesc | ❌       | Sort the results by creation date in ascending (`asc`) or descending (`desc`) order.                                                       |

**Return Type**

`GetCollectionsForkedByUser`

**Example Usage Code Snippet**

```csharp
using PostmanClient;
using PostmanClient.Models;

var client = new PostmanClientClient();

var response = await client.Collections.GetCollectionsForkedByUserAsync("12ece9e1-2abf-4edc-8e34-de66e74114d2", "RnJpIEZlYiAyNCAyMDIzIDEzOjI0OjA5IEdNVCswMDAwIChDb29yZGluYXRlZCBVbml2ZXJzYWwgVGltZSk=", 10, AscDesc.Asc);

Console.WriteLine(response);
```

## GetCollectionCommentsAsync

Gets all comments left by users in a collection.

- HTTP Method: `GET`
- Endpoint: `/collections/{collectionId}/comments`

**Parameters**

| Name         | Type   | Required | Description                 |
| :----------- | :----- | :------- | :-------------------------- |
| collectionId | string | ✅       | The collection's unique ID. |

**Return Type**

`CommentResponse`

**Example Usage Code Snippet**

```csharp
using PostmanClient;

var client = new PostmanClientClient();

var response = await client.Collections.GetCollectionCommentsAsync("12345678-12ece9e1-2abf-4edc-8e34-de66e74114d2");

Console.WriteLine(response);
```

## CreateCollectionCommentAsync

Creates a comment on a collection. **Note:** This endpoint accepts a max of 10,000 characters.

- HTTP Method: `POST`
- Endpoint: `/collections/{collectionId}/comments`

**Parameters**

| Name         | Type                | Required | Description                 |
| :----------- | :------------------ | :------- | :-------------------------- |
| input        | CommentCreateUpdate | ✅       | The request body.           |
| collectionId | string              | ✅       | The collection's unique ID. |

**Return Type**

`CommentCreatedUpdated`

**Example Usage Code Snippet**

```csharp
using PostmanClient;
using PostmanClient.Models;

var client = new PostmanClientClient();

var input = new CommentCreateUpdate("This is an example.");

var response = await client.Collections.CreateCollectionCommentAsync(input, "12345678-12ece9e1-2abf-4edc-8e34-de66e74114d2");

Console.WriteLine(response);
```

## UpdateCollectionCommentAsync

Updates a comment on a collection. **Note:** This endpoint accepts a max of 10,000 characters.

- HTTP Method: `PUT`
- Endpoint: `/collections/{collectionId}/comments/{commentId}`

**Parameters**

| Name         | Type                | Required | Description                 |
| :----------- | :------------------ | :------- | :-------------------------- |
| input        | CommentCreateUpdate | ✅       | The request body.           |
| collectionId | string              | ✅       | The collection's unique ID. |
| commentId    | long                | ✅       | The comment's ID.           |

**Return Type**

`CommentCreatedUpdated`

**Example Usage Code Snippet**

```csharp
using PostmanClient;
using PostmanClient.Models;

var client = new PostmanClientClient();

var input = new CommentCreateUpdate("This is an example.");

var response = await client.Collections.UpdateCollectionCommentAsync(input, "12345678-12ece9e1-2abf-4edc-8e34-de66e74114d2", 46814);

Console.WriteLine(response);
```

## DeleteCollectionCommentAsync

Deletes a comment from a collection. On success, this returns an HTTP `204 No Content` response **Note:** Deleting the first comment of a thread deletes all the comments in the thread.

- HTTP Method: `DELETE`
- Endpoint: `/collections/{collectionId}/comments/{commentId}`

**Parameters**

| Name         | Type   | Required | Description                 |
| :----------- | :----- | :------- | :-------------------------- |
| collectionId | string | ✅       | The collection's unique ID. |
| commentId    | long   | ✅       | The comment's ID.           |

**Example Usage Code Snippet**

```csharp
using PostmanClient;

var client = new PostmanClientClient();

await client.Collections.DeleteCollectionCommentAsync("12345678-12ece9e1-2abf-4edc-8e34-de66e74114d2", 46814);
```

## GetCollectionForksAsync

Gets a collection's forked collections. The response returns data for each fork, such as the fork's ID, the user who forked it, and the fork's creation date.

- HTTP Method: `GET`
- Endpoint: `/collections/{collectionId}/forks`

**Parameters**

| Name         | Type    | Required | Description                                                                                                                                |
| :----------- | :------ | :------- | :----------------------------------------------------------------------------------------------------------------------------------------- |
| collectionId | string  | ✅       | The collection's ID.                                                                                                                       |
| cursor       | string  | ❌       | The pointer to the first record of the set of paginated results. To view the next response, use the `nextCursor` value for this parameter. |
| limit        | long    | ❌       | The maximum number of rows to return in the response.                                                                                      |
| direction    | AscDesc | ❌       | Sort the results by creation date in ascending (`asc`) or descending (`desc`) order.                                                       |

**Return Type**

`GetCollectionForks`

**Example Usage Code Snippet**

```csharp
using PostmanClient;
using PostmanClient.Models;

var client = new PostmanClientClient();

var response = await client.Collections.GetCollectionForksAsync("12ece9e1-2abf-4edc-8e34-de66e74114d2", "RnJpIEZlYiAyNCAyMDIzIDEzOjI0OjA5IEdNVCswMDAwIChDb29yZGluYXRlZCBVbml2ZXJzYWwgVGltZSk=", 10, AscDesc.Asc);

Console.WriteLine(response);
```

## PullCollectionChangesAsync

Pulls the changes from a parent (source) collection into the forked collection. In the endpoint's response: - The `destinationId` is the ID of the forked collection. - The `sourceId` is the ID of the source collection.

- HTTP Method: `PUT`
- Endpoint: `/collections/{collectionId}/pulls`

**Parameters**

| Name         | Type   | Required | Description          |
| :----------- | :----- | :------- | :------------------- |
| collectionId | string | ✅       | The collection's ID. |

**Return Type**

`PullCollectionChanges`

**Example Usage Code Snippet**

```csharp
using PostmanClient;

var client = new PostmanClientClient();

var response = await client.Collections.PullCollectionChangesAsync("12ece9e1-2abf-4edc-8e34-de66e74114d2");

Console.WriteLine(response);
```

## GetCollectionPullRequestsAsync

Gets information about a collection's pull requests, such as the source and destination IDs, status of the pull requests, and a URL link to the pull requests.

- HTTP Method: `GET`
- Endpoint: `/collections/{collectionId}/pull-requests`

**Parameters**

| Name         | Type   | Required | Description                 |
| :----------- | :----- | :------- | :-------------------------- |
| collectionId | string | ✅       | The collection's unique ID. |

**Return Type**

`GetCollectionPullRequests`

**Example Usage Code Snippet**

```csharp
using PostmanClient;

var client = new PostmanClientClient();

var response = await client.Collections.GetCollectionPullRequestsAsync("12345678-12ece9e1-2abf-4edc-8e34-de66e74114d2");

Console.WriteLine(response);
```

## CreateCollectionPullRequestAsync

Creates a pull request for a forked collection into its parent collection.

- HTTP Method: `POST`
- Endpoint: `/collections/{collectionId}/pull-requests`

**Parameters**

| Name         | Type              | Required | Description                 |
| :----------- | :---------------- | :------- | :-------------------------- |
| input        | PullRequestCreate | ❌       | The request body.           |
| collectionId | string            | ✅       | The collection's unique ID. |

**Return Type**

`PullRequestCreated`

**Example Usage Code Snippet**

```csharp
using PostmanClient;
using PostmanClient.Models;

var client = new PostmanClientClient();

var reviewers = new List<string>() { "87654321" };
var input = new PullRequestCreate("Test PR", "This is a test pull request.", reviewers, "12345678-ec548788-unftw-rgn8-83b8-0b59798648e4");

var response = await client.Collections.CreateCollectionPullRequestAsync(input, "12345678-12ece9e1-2abf-4edc-8e34-de66e74114d2");

Console.WriteLine(response);
```

## GetCollectionRolesAsync

Gets information about all roles in a collection. The response returns the IDs of all users, teams, and groups with access to view or edit the collection.

- HTTP Method: `GET`
- Endpoint: `/collections/{collectionId}/roles`

**Parameters**

| Name         | Type   | Required | Description          |
| :----------- | :----- | :------- | :------------------- |
| collectionId | string | ✅       | The collection's ID. |

**Return Type**

`GetCollectionRoles`

**Example Usage Code Snippet**

```csharp
using PostmanClient;

var client = new PostmanClientClient();

var response = await client.Collections.GetCollectionRolesAsync("12ece9e1-2abf-4edc-8e34-de66e74114d2");

Console.WriteLine(response);
```

## UpdateCollectionRolesAsync

Updates the roles of users, groups, or teams in a collection. On success, this returns a `204 No Content` response. **Note:** - Only users assigned the EDITOR [role](https://learning.postman.com/docs/collaborating-in-postman/roles-and-permissions/#collection-roles) in the collection can use this endpoint. - This endpoint does not support the external [Partner or Guest roles](https://learning.postman.com/docs/collaborating-in-postman/roles-and-permissions/#team-roles).

- HTTP Method: `PATCH`
- Endpoint: `/collections/{collectionId}/roles`

**Parameters**

| Name         | Type                  | Required | Description          |
| :----------- | :-------------------- | :------- | :------------------- |
| input        | UpdateCollectionRoles | ❌       | The request body.    |
| collectionId | string                | ✅       | The collection's ID. |

**Example Usage Code Snippet**

```csharp
using PostmanClient;
using PostmanClient.Models;

var client = new PostmanClientClient();

var valueItem = new UpdateCollectionRolesRoles.RolesValue1(12345678, RolesValue1.ValueRole1.Viewer);
var value = new List<UpdateCollectionRolesRoles.RolesValue1>() { valueItem };
var rolesItem = new UpdateCollectionRoles.UpdateCollectionRolesRoles(UpdateCollectionRolesRoles.RolesOp.Update, UpdateCollectionRolesRoles.RolesPath1.User, value);
var roles = new List<UpdateCollectionRoles.UpdateCollectionRolesRoles>() { rolesItem };
var input = new UpdateCollectionRoles(roles);

await client.Collections.UpdateCollectionRolesAsync(input, "12ece9e1-2abf-4edc-8e34-de66e74114d2");
```

## GetSourceCollectionStatusAsync

Checks whether there is a change between the forked collection and its parent (source) collection. If the value of the `isSourceAhead` property is `true` in the response, then there is a difference between the forked collection and its source collection. **Note:** This endpoint may take a few minutes to return an updated `isSourceAhead` status.

- HTTP Method: `GET`
- Endpoint: `/collections/{collectionId}/source-status`

**Parameters**

| Name         | Type   | Required | Description          |
| :----------- | :----- | :------- | :------------------- |
| collectionId | string | ✅       | The collection's ID. |

**Return Type**

`GetSourceCollectionStatus`

**Example Usage Code Snippet**

```csharp
using PostmanClient;

var client = new PostmanClientClient();

var response = await client.Collections.GetSourceCollectionStatusAsync("12ece9e1-2abf-4edc-8e34-de66e74114d2");

Console.WriteLine(response);
```

## TransformCollectionToOpenApiAsync

Transforms an existing Postman Collection into a stringified OpenAPI definition. **Note:** This does not create an API.

- HTTP Method: `GET`
- Endpoint: `/collections/{collectionId}/transformations`

**Parameters**

| Name         | Type   | Required | Description                                        |
| :----------- | :----- | :------- | :------------------------------------------------- |
| collectionId | string | ✅       | The collection's ID.                               |
| format       | Format | ❌       | Return the OpenAPI definition in the given format. |

**Return Type**

`TransformCollectionToOpenApi`

**Example Usage Code Snippet**

```csharp
using PostmanClient;
using PostmanClient.Models;

var client = new PostmanClientClient();

var response = await client.Collections.TransformCollectionToOpenApiAsync("12ece9e1-2abf-4edc-8e34-de66e74114d2", Format.Json);

Console.WriteLine(response);
```

## TransferCollectionFoldersAsync

Copies or moves folders into a collection or folder.

- HTTP Method: `POST`
- Endpoint: `/collection-folders-transfers`

**Parameters**

| Name  | Type                    | Required | Description       |
| :---- | :---------------------- | :------- | :---------------- |
| input | TransferCollectionItems | ❌       | The request body. |

**Return Type**

`TransferCollectionItems200Error`

**Example Usage Code Snippet**

```csharp
using PostmanClient;
using PostmanClient.Models;

var client = new PostmanClientClient();

var ids = new List<string>() { "12345678-a9b481c1-3e78-4af7-8db0-dce3f3f3c105" };
var target_ = new TransferCollectionItems.Target("12345678-b91270fa-048d-4f5f-a033-8b5523bf053f", Target.TargetModel.Collection);
var location_ = new TransferCollectionItems.Location(Location.Position.Start);
var input = new TransferCollectionItems(ids, TransferCollectionItems.Mode.Copy, target_, location_);

var response = await client.Collections.TransferCollectionFoldersAsync(input);

Console.WriteLine(response);
```

## TransferCollectionRequestsAsync

Copies or moves requests into a collection or folder.

- HTTP Method: `POST`
- Endpoint: `/collection-requests-transfers`

**Parameters**

| Name  | Type                    | Required | Description       |
| :---- | :---------------------- | :------- | :---------------- |
| input | TransferCollectionItems | ❌       | The request body. |

**Return Type**

`TransferCollectionItems200Error`

**Example Usage Code Snippet**

```csharp
using PostmanClient;
using PostmanClient.Models;

var client = new PostmanClientClient();

var ids = new List<string>() { "12345678-a9b481c1-3e78-4af7-8db0-dce3f3f3c105" };
var target_ = new TransferCollectionItems.Target("12345678-b91270fa-048d-4f5f-a033-8b5523bf053f", Target.TargetModel.Collection);
var location_ = new TransferCollectionItems.Location(Location.Position.Start);
var input = new TransferCollectionItems(ids, TransferCollectionItems.Mode.Copy, target_, location_);

var response = await client.Collections.TransferCollectionRequestsAsync(input);

Console.WriteLine(response);
```

## TransferCollectionResponsesAsync

Copies or moves responses into a request.

- HTTP Method: `POST`
- Endpoint: `/collection-responses-transfers`

**Parameters**

| Name  | Type                    | Required | Description       |
| :---- | :---------------------- | :------- | :---------------- |
| input | TransferCollectionItems | ❌       | The request body. |

**Return Type**

`TransferCollectionItems200Error`

**Example Usage Code Snippet**

```csharp
using PostmanClient;
using PostmanClient.Models;

var client = new PostmanClientClient();

var ids = new List<string>() { "12345678-a9b481c1-3e78-4af7-8db0-dce3f3f3c105" };
var target_ = new TransferCollectionItems.Target("12345678-b91270fa-048d-4f5f-a033-8b5523bf053f", Target.TargetModel.Collection);
var location_ = new TransferCollectionItems.Location(Location.Position.Start);
var input = new TransferCollectionItems(ids, TransferCollectionItems.Mode.Copy, target_, location_);

var response = await client.Collections.TransferCollectionResponsesAsync(input);

Console.WriteLine(response);
```

<!-- This file was generated by liblab | https://liblab.com/ -->
