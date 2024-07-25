# CollectionRequestsService

A list of all methods in the `CollectionRequestsService` service. Click on the method name to view detailed information about that method.

| Methods                                                 | Description                                                                                                                                                                           |
| :------------------------------------------------------ | :------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| [GetRequestCommentsAsync](#getrequestcommentsasync)     | Gets all comments left by users in a request.                                                                                                                                         |
| [CreateRequestCommentAsync](#createrequestcommentasync) | Creates a comment on a request. **Note:** This endpoint accepts a max of 10,000 characters.                                                                                           |
| [UpdateRequestCommentAsync](#updaterequestcommentasync) | Updates a comment on a request. **Note:** This endpoint accepts a max of 10,000 characters.                                                                                           |
| [DeleteRequestCommentAsync](#deleterequestcommentasync) | Deletes a comment from a request. On success, this returns an HTTP `204 No Content` response **Note:** Deleting the first comment of a thread deletes all the comments in the thread. |

## GetRequestCommentsAsync

Gets all comments left by users in a request.

- HTTP Method: `GET`
- Endpoint: `/collections/{collectionId}/requests/{requestId}/comments`

**Parameters**

| Name         | Type   | Required | Description                 |
| :----------- | :----- | :------- | :-------------------------- |
| collectionId | string | ✅       | The collection's unique ID. |
| requestId    | string | ✅       | The request's unique ID.    |

**Return Type**

`CommentResponse`

**Example Usage Code Snippet**

```csharp
using PostmanClient;

var client = new PostmanClientClient();

var response = await client.CollectionRequests.GetRequestCommentsAsync("12345678-12ece9e1-2abf-4edc-8e34-de66e74114d2", "12345678-c82dd02c-4870-4907-8fcb-593a876cf05b");

Console.WriteLine(response);
```

## CreateRequestCommentAsync

Creates a comment on a request. **Note:** This endpoint accepts a max of 10,000 characters.

- HTTP Method: `POST`
- Endpoint: `/collections/{collectionId}/requests/{requestId}/comments`

**Parameters**

| Name         | Type                | Required | Description                 |
| :----------- | :------------------ | :------- | :-------------------------- |
| input        | CommentCreateUpdate | ✅       | The request body.           |
| collectionId | string              | ✅       | The collection's unique ID. |
| requestId    | string              | ✅       | The request's unique ID.    |

**Return Type**

`CommentCreatedUpdated`

**Example Usage Code Snippet**

```csharp
using PostmanClient;
using PostmanClient.Models;

var client = new PostmanClientClient();

var input = new CommentCreateUpdate("This is an example.");

var response = await client.CollectionRequests.CreateRequestCommentAsync(input, "12345678-12ece9e1-2abf-4edc-8e34-de66e74114d2", "12345678-c82dd02c-4870-4907-8fcb-593a876cf05b");

Console.WriteLine(response);
```

## UpdateRequestCommentAsync

Updates a comment on a request. **Note:** This endpoint accepts a max of 10,000 characters.

- HTTP Method: `PUT`
- Endpoint: `/collections/{collectionId}/requests/{requestId}/comments/{commentId}`

**Parameters**

| Name         | Type                | Required | Description                 |
| :----------- | :------------------ | :------- | :-------------------------- |
| input        | CommentCreateUpdate | ✅       | The request body.           |
| collectionId | string              | ✅       | The collection's unique ID. |
| requestId    | string              | ✅       | The request's unique ID.    |
| commentId    | long                | ✅       | The comment's ID.           |

**Return Type**

`CommentCreatedUpdated`

**Example Usage Code Snippet**

```csharp
using PostmanClient;
using PostmanClient.Models;

var client = new PostmanClientClient();

var input = new CommentCreateUpdate("This is an example.");

var response = await client.CollectionRequests.UpdateRequestCommentAsync(input, "12345678-12ece9e1-2abf-4edc-8e34-de66e74114d2", "12345678-c82dd02c-4870-4907-8fcb-593a876cf05b", 46814);

Console.WriteLine(response);
```

## DeleteRequestCommentAsync

Deletes a comment from a request. On success, this returns an HTTP `204 No Content` response **Note:** Deleting the first comment of a thread deletes all the comments in the thread.

- HTTP Method: `DELETE`
- Endpoint: `/collections/{collectionId}/requests/{requestId}/comments/{commentId}`

**Parameters**

| Name         | Type   | Required | Description                 |
| :----------- | :----- | :------- | :-------------------------- |
| collectionId | string | ✅       | The collection's unique ID. |
| requestId    | string | ✅       | The request's unique ID.    |
| commentId    | long   | ✅       | The comment's ID.           |

**Example Usage Code Snippet**

```csharp
using PostmanClient;

var client = new PostmanClientClient();

await client.CollectionRequests.DeleteRequestCommentAsync("12345678-12ece9e1-2abf-4edc-8e34-de66e74114d2", "12345678-c82dd02c-4870-4907-8fcb-593a876cf05b", 46814);
```

<!-- This file was generated by liblab | https://liblab.com/ -->
