# CollectionFoldersService

A list of all methods in the `CollectionFoldersService` service. Click on the method name to view detailed information about that method.

| Methods                                               | Description                                                                                                                                                                          |
| :---------------------------------------------------- | :----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| [GetFolderCommentsAsync](#getfoldercommentsasync)     | Gets all comments left by users in a folder.                                                                                                                                         |
| [CreateFolderCommentAsync](#createfoldercommentasync) | Creates a comment on a folder. **Note:** This endpoint accepts a max of 10,000 characters.                                                                                           |
| [UpdateFolderCommentAsync](#updatefoldercommentasync) | Updates a comment on a folder. **Note:** This endpoint accepts a max of 10,000 characters.                                                                                           |
| [DeleteFolderCommentAsync](#deletefoldercommentasync) | Deletes a comment from a folder. On success, this returns an HTTP `204 No Content` response **Note:** Deleting the first comment of a thread deletes all the comments in the thread. |

## GetFolderCommentsAsync

Gets all comments left by users in a folder.

- HTTP Method: `GET`
- Endpoint: `/collections/{collectionId}/folders/{folderId}/comments`

**Parameters**

| Name         | Type   | Required | Description                 |
| :----------- | :----- | :------- | :-------------------------- |
| collectionId | string | ✅       | The collection's unique ID. |
| folderId     | string | ✅       | The folder's unique ID.     |

**Return Type**

`CommentResponse`

**Example Usage Code Snippet**

```csharp
using PostmanClient;

var client = new PostmanClientClient();

var response = await client.CollectionFolders.GetFolderCommentsAsync("12345678-12ece9e1-2abf-4edc-8e34-de66e74114d2", "12345678-65a99e60-8e0a-4b6e-b79c-7d8264cc5caa");

Console.WriteLine(response);
```

## CreateFolderCommentAsync

Creates a comment on a folder. **Note:** This endpoint accepts a max of 10,000 characters.

- HTTP Method: `POST`
- Endpoint: `/collections/{collectionId}/folders/{folderId}/comments`

**Parameters**

| Name         | Type                | Required | Description                 |
| :----------- | :------------------ | :------- | :-------------------------- |
| input        | CommentCreateUpdate | ✅       | The request body.           |
| collectionId | string              | ✅       | The collection's unique ID. |
| folderId     | string              | ✅       | The folder's unique ID.     |

**Return Type**

`CommentCreatedUpdated`

**Example Usage Code Snippet**

```csharp
using PostmanClient;
using PostmanClient.Models;

var client = new PostmanClientClient();

var input = new CommentCreateUpdate("This is an example.");

var response = await client.CollectionFolders.CreateFolderCommentAsync(input, "12345678-12ece9e1-2abf-4edc-8e34-de66e74114d2", "12345678-65a99e60-8e0a-4b6e-b79c-7d8264cc5caa");

Console.WriteLine(response);
```

## UpdateFolderCommentAsync

Updates a comment on a folder. **Note:** This endpoint accepts a max of 10,000 characters.

- HTTP Method: `PUT`
- Endpoint: `/collections/{collectionId}/folders/{folderId}/comments/{commentId}`

**Parameters**

| Name         | Type                | Required | Description                 |
| :----------- | :------------------ | :------- | :-------------------------- |
| input        | CommentCreateUpdate | ✅       | The request body.           |
| collectionId | string              | ✅       | The collection's unique ID. |
| folderId     | string              | ✅       | The folder's unique ID.     |
| commentId    | long                | ✅       | The comment's ID.           |

**Return Type**

`CommentCreatedUpdated`

**Example Usage Code Snippet**

```csharp
using PostmanClient;
using PostmanClient.Models;

var client = new PostmanClientClient();

var input = new CommentCreateUpdate("This is an example.");

var response = await client.CollectionFolders.UpdateFolderCommentAsync(input, "12345678-12ece9e1-2abf-4edc-8e34-de66e74114d2", "12345678-65a99e60-8e0a-4b6e-b79c-7d8264cc5caa", 46814);

Console.WriteLine(response);
```

## DeleteFolderCommentAsync

Deletes a comment from a folder. On success, this returns an HTTP `204 No Content` response **Note:** Deleting the first comment of a thread deletes all the comments in the thread.

- HTTP Method: `DELETE`
- Endpoint: `/collections/{collectionId}/folders/{folderId}/comments/{commentId}`

**Parameters**

| Name         | Type   | Required | Description                 |
| :----------- | :----- | :------- | :-------------------------- |
| collectionId | string | ✅       | The collection's unique ID. |
| folderId     | string | ✅       | The folder's unique ID.     |
| commentId    | long   | ✅       | The comment's ID.           |

**Example Usage Code Snippet**

```csharp
using PostmanClient;

var client = new PostmanClientClient();

await client.CollectionFolders.DeleteFolderCommentAsync("12345678-12ece9e1-2abf-4edc-8e34-de66e74114d2", "12345678-65a99e60-8e0a-4b6e-b79c-7d8264cc5caa", 46814);
```

<!-- This file was generated by liblab | https://liblab.com/ -->
