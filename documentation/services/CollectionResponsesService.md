# CollectionResponsesService

A list of all methods in the `CollectionResponsesService` service. Click on the method name to view detailed information about that method.

| Methods                                                   | Description                                                                                                                                                                            |
| :-------------------------------------------------------- | :------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| [GetResponseCommentsAsync](#getresponsecommentsasync)     | Gets all comments left by users in a response.                                                                                                                                         |
| [CreateResponseCommentAsync](#createresponsecommentasync) | Creates a comment on a response. **Note:** This endpoint accepts a max of 10,000 characters.                                                                                           |
| [UpdateResponseCommentAsync](#updateresponsecommentasync) | Updates a comment on a response. **Note:** This endpoint accepts a max of 10,000 characters.                                                                                           |
| [DeleteResponseCommentAsync](#deleteresponsecommentasync) | Deletes a comment from a response. On success, this returns an HTTP `204 No Content` response **Note:** Deleting the first comment of a thread deletes all the comments in the thread. |

## GetResponseCommentsAsync

Gets all comments left by users in a response.

- HTTP Method: `GET`
- Endpoint: `/collections/{collectionId}/responses/{responseId}/comments`

**Parameters**

| Name         | Type   | Required | Description                 |
| :----------- | :----- | :------- | :-------------------------- |
| collectionId | string | ✅       | The collection's unique ID. |
| responseId   | string | ✅       | The response's unique ID.   |

**Return Type**

`CommentResponse`

**Example Usage Code Snippet**

```csharp
using PostmanClient;

var client = new PostmanClientClient();

var response = await client.CollectionResponses.GetResponseCommentsAsync("12345678-12ece9e1-2abf-4edc-8e34-de66e74114d2", "12345678-cc364734-7dfd-4bfc-897d-be763dcdbb07");

Console.WriteLine(response);
```

## CreateResponseCommentAsync

Creates a comment on a response. **Note:** This endpoint accepts a max of 10,000 characters.

- HTTP Method: `POST`
- Endpoint: `/collections/{collectionId}/responses/{responseId}/comments`

**Parameters**

| Name         | Type                | Required | Description                 |
| :----------- | :------------------ | :------- | :-------------------------- |
| input        | CommentCreateUpdate | ✅       | The request body.           |
| collectionId | string              | ✅       | The collection's unique ID. |
| responseId   | string              | ✅       | The response's unique ID.   |

**Return Type**

`CommentCreatedUpdated`

**Example Usage Code Snippet**

```csharp
using PostmanClient;
using PostmanClient.Models;

var client = new PostmanClientClient();

var input = new CommentCreateUpdate("This is an example.");

var response = await client.CollectionResponses.CreateResponseCommentAsync(input, "12345678-12ece9e1-2abf-4edc-8e34-de66e74114d2", "12345678-cc364734-7dfd-4bfc-897d-be763dcdbb07");

Console.WriteLine(response);
```

## UpdateResponseCommentAsync

Updates a comment on a response. **Note:** This endpoint accepts a max of 10,000 characters.

- HTTP Method: `PUT`
- Endpoint: `/collections/{collectionId}/responses/{responseId}/comments/{commentId}`

**Parameters**

| Name         | Type                | Required | Description                 |
| :----------- | :------------------ | :------- | :-------------------------- |
| input        | CommentCreateUpdate | ✅       | The request body.           |
| collectionId | string              | ✅       | The collection's unique ID. |
| responseId   | string              | ✅       | The response's unique ID.   |
| commentId    | long                | ✅       | The comment's ID.           |

**Return Type**

`CommentCreatedUpdated`

**Example Usage Code Snippet**

```csharp
using PostmanClient;
using PostmanClient.Models;

var client = new PostmanClientClient();

var input = new CommentCreateUpdate("This is an example.");

var response = await client.CollectionResponses.UpdateResponseCommentAsync(input, "12345678-12ece9e1-2abf-4edc-8e34-de66e74114d2", "12345678-cc364734-7dfd-4bfc-897d-be763dcdbb07", 46814);

Console.WriteLine(response);
```

## DeleteResponseCommentAsync

Deletes a comment from a response. On success, this returns an HTTP `204 No Content` response **Note:** Deleting the first comment of a thread deletes all the comments in the thread.

- HTTP Method: `DELETE`
- Endpoint: `/collections/{collectionId}/responses/{responseId}/comments/{commentId}`

**Parameters**

| Name         | Type   | Required | Description                 |
| :----------- | :----- | :------- | :-------------------------- |
| collectionId | string | ✅       | The collection's unique ID. |
| responseId   | string | ✅       | The response's unique ID.   |
| commentId    | long   | ✅       | The comment's ID.           |

**Example Usage Code Snippet**

```csharp
using PostmanClient;

var client = new PostmanClientClient();

await client.CollectionResponses.DeleteResponseCommentAsync("12345678-12ece9e1-2abf-4edc-8e34-de66e74114d2", "12345678-cc364734-7dfd-4bfc-897d-be763dcdbb07", 46814);
```

<!-- This file was generated by liblab | https://liblab.com/ -->
