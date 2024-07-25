# CollectionItemsService

A list of all methods in the `CollectionItemsService` service. Click on the method name to view detailed information about that method.

| Methods                                                         | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             |
| :-------------------------------------------------------------- | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| [CreateCollectionFolderAsync](#createcollectionfolderasync)     | Creates a folder in a collection. For a complete list of properties, refer to "Folder" in the [collection.json schema file](https://schema.postman.com/collection/json/v2.1.0/draft-07/collection.json). You can use this endpoint to to import requests and responses into a newly-created folder. To do this, include the `requests` field and the list of request objects in the request body. For more information, see the provided example. **Note:** It is recommended that you pass the `name` property in the request body. If you do not, the system uses a null value. As a result, this creates a folder with a blank name. |
| [CreateCollectionRequestAsync](#createcollectionrequestasync)   | Creates a request in a collection. For a complete list of properties, see the [Collection Format Request documentation](https://learning.postman.com/collection-format/reference/request/). **Note:** It is recommended that you pass the `name` property in the request body. If you do not, the system uses a null value. As a result, this creates a request with a blank name.                                                                                                                                                                                                                                                      |
| [CreateCollectionResponseAsync](#createcollectionresponseasync) | Creates a request response in a collection. For a complete list of request body properties, see the [Collection Format Response documentation](https://learning.postman.com/collection-format/reference/response/#reference-diagram). **Note:** It is recommended that you pass the `name` property in the request body. If you do not, the system uses a null value. As a result, this creates a response with a blank name.                                                                                                                                                                                                           |
| [GetCollectionFolderAsync](#getcollectionfolderasync)           | Gets information about a folder in a collection.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        |
| [UpdateCollectionFolderAsync](#updatecollectionfolderasync)     | Updates a folder in a collection. For a complete list of properties, refer to "Folder" in the [collection.json schema file](https://schema.postman.com/collection/json/v2.1.0/draft-07/collection.json). **Note:** This endpoint acts like a PATCH method. It only updates the values that you pass in the request body (for example, the `name` property). The endpoint does not update the entire resource.                                                                                                                                                                                                                           |
| [DeleteCollectionFolderAsync](#deletecollectionfolderasync)     | Deletes a folder in a collection.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       |
| [GetCollectionRequestAsync](#getcollectionrequestasync)         | Gets information about a request in a collection.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       |
| [UpdateCollectionRequestAsync](#updatecollectionrequestasync)   | Updates a request in a collection. For a complete list of properties, see the [Collection Format Request documentation](https://learning.postman.com/collection-format/reference/request/). **Note:** - You must pass a collection ID (`12ece9e1-2abf-4edc-8e34-de66e74114d2`), not a collection(`12345678-12ece9e1-2abf-4edc-8e34-de66e74114d2`), in this endpoint. - This endpoint does not support changing the folder of a request.                                                                                                                                                                                                 |
| [DeleteCollectionRequestAsync](#deletecollectionrequestasync)   | Deletes a request in a collection.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      |
| [GetCollectionResponseAsync](#getcollectionresponseasync)       | Gets information about a response in a collection.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      |
| [UpdateCollectionResponseAsync](#updatecollectionresponseasync) | Updates a response in a collection. For a complete list of properties, see the [Collection Format Response documentation](https://learning.postman.com/collection-format/reference/response/#reference-diagram). **Note:** - You must pass a collection ID (`12ece9e1-2abf-4edc-8e34-de66e74114d2`), not a collection UID (`12345678-12ece9e1-2abf-4edc-8e34-de66e74114d2`), in this endpoint. - This endpoint acts like a PATCH method. It only updates the values that you pass in the request body (for example, the `name` property). The endpoint does not update the entire resource.                                             |
| [DeleteCollectionResponseAsync](#deletecollectionresponseasync) | Deletes a response in a collection.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     |

## CreateCollectionFolderAsync

Creates a folder in a collection. For a complete list of properties, refer to "Folder" in the [collection.json schema file](https://schema.postman.com/collection/json/v2.1.0/draft-07/collection.json). You can use this endpoint to to import requests and responses into a newly-created folder. To do this, include the `requests` field and the list of request objects in the request body. For more information, see the provided example. **Note:** It is recommended that you pass the `name` property in the request body. If you do not, the system uses a null value. As a result, this creates a folder with a blank name.

- HTTP Method: `POST`
- Endpoint: `/collections/{collectionId}/folders`

**Parameters**

| Name         | Type   | Required | Description          |
| :----------- | :----- | :------- | :------------------- |
| input        | object | ❌       | The request body.    |
| collectionId | string | ✅       | The collection's ID. |

**Return Type**

`CreateCollectionFolder`

**Example Usage Code Snippet**

```csharp
using PostmanClient;

var client = new PostmanClientClient();

var response = await client.CollectionItems.CreateCollectionFolderAsync(new object {}, "12ece9e1-2abf-4edc-8e34-de66e74114d2");

Console.WriteLine(response);
```

## CreateCollectionRequestAsync

Creates a request in a collection. For a complete list of properties, see the [Collection Format Request documentation](https://learning.postman.com/collection-format/reference/request/). **Note:** It is recommended that you pass the `name` property in the request body. If you do not, the system uses a null value. As a result, this creates a request with a blank name.

- HTTP Method: `POST`
- Endpoint: `/collections/{collectionId}/requests`

**Parameters**

| Name         | Type   | Required | Description                                                                                                           |
| :----------- | :----- | :------- | :-------------------------------------------------------------------------------------------------------------------- |
| input        | object | ❌       | The request body.                                                                                                     |
| collectionId | string | ✅       | The collection's ID.                                                                                                  |
| folderId     | string | ❌       | The folder ID in which to create the request. By default, the system will create the request at the collection level. |

**Return Type**

`CreateCollectionRequestOkResponse`

**Example Usage Code Snippet**

```csharp
using PostmanClient;

var client = new PostmanClientClient();

var response = await client.CollectionItems.CreateCollectionRequestAsync(new object {}, "12ece9e1-2abf-4edc-8e34-de66e74114d2", "65a99e60-8e0a-4b6e-b79c-7d8264cc5caa");

Console.WriteLine(response);
```

## CreateCollectionResponseAsync

Creates a request response in a collection. For a complete list of request body properties, see the [Collection Format Response documentation](https://learning.postman.com/collection-format/reference/response/#reference-diagram). **Note:** It is recommended that you pass the `name` property in the request body. If you do not, the system uses a null value. As a result, this creates a response with a blank name.

- HTTP Method: `POST`
- Endpoint: `/collections/{collectionId}/responses`

**Parameters**

| Name         | Type   | Required | Description              |
| :----------- | :----- | :------- | :----------------------- |
| input        | object | ❌       | The request body.        |
| collectionId | string | ✅       | The collection's ID.     |
| requestId    | string | ✅       | The parent request's ID. |

**Return Type**

`CreateCollectionResponse`

**Example Usage Code Snippet**

```csharp
using PostmanClient;

var client = new PostmanClientClient();

var response = await client.CollectionItems.CreateCollectionResponseAsync(new object {}, "12ece9e1-2abf-4edc-8e34-de66e74114d2", "c82dd02c-4870-4907-8fcb-593a876cf05b");

Console.WriteLine(response);
```

## GetCollectionFolderAsync

Gets information about a folder in a collection.

- HTTP Method: `GET`
- Endpoint: `/collections/{collectionId}/folders/{folderId}`

**Parameters**

| Name         | Type   | Required | Description                                                              |
| :----------- | :----- | :------- | :----------------------------------------------------------------------- |
| folderId     | string | ✅       | The folder's ID.                                                         |
| collectionId | string | ✅       | The collection's ID.                                                     |
| ids          | bool   | ❌       | If true, returns only properties that contain ID values in the response. |
| uid          | bool   | ❌       | If true, returns all IDs in UID format (`userId`-`id`).                  |
| populate     | bool   | ❌       | If true, returns all of the collection item's contents.                  |

**Return Type**

`GetCollectionFolder`

**Example Usage Code Snippet**

```csharp
using PostmanClient;

var client = new PostmanClientClient();

var response = await client.CollectionItems.GetCollectionFolderAsync("65a99e60-8e0a-4b6e-b79c-7d8264cc5caa", "12ece9e1-2abf-4edc-8e34-de66e74114d2", true, true, true);

Console.WriteLine(response);
```

## UpdateCollectionFolderAsync

Updates a folder in a collection. For a complete list of properties, refer to "Folder" in the [collection.json schema file](https://schema.postman.com/collection/json/v2.1.0/draft-07/collection.json). **Note:** This endpoint acts like a PATCH method. It only updates the values that you pass in the request body (for example, the `name` property). The endpoint does not update the entire resource.

- HTTP Method: `PUT`
- Endpoint: `/collections/{collectionId}/folders/{folderId}`

**Parameters**

| Name         | Type   | Required | Description          |
| :----------- | :----- | :------- | :------------------- |
| input        | object | ❌       | The request body.    |
| folderId     | string | ✅       | The folder's ID.     |
| collectionId | string | ✅       | The collection's ID. |

**Return Type**

`UpdateCollectionFolder`

**Example Usage Code Snippet**

```csharp
using PostmanClient;

var client = new PostmanClientClient();

var response = await client.CollectionItems.UpdateCollectionFolderAsync(new object {}, "65a99e60-8e0a-4b6e-b79c-7d8264cc5caa", "12ece9e1-2abf-4edc-8e34-de66e74114d2");

Console.WriteLine(response);
```

## DeleteCollectionFolderAsync

Deletes a folder in a collection.

- HTTP Method: `DELETE`
- Endpoint: `/collections/{collectionId}/folders/{folderId}`

**Parameters**

| Name         | Type   | Required | Description          |
| :----------- | :----- | :------- | :------------------- |
| folderId     | string | ✅       | The folder's ID.     |
| collectionId | string | ✅       | The collection's ID. |

**Return Type**

`DeleteCollectionFolder`

**Example Usage Code Snippet**

```csharp
using PostmanClient;

var client = new PostmanClientClient();

var response = await client.CollectionItems.DeleteCollectionFolderAsync("65a99e60-8e0a-4b6e-b79c-7d8264cc5caa", "12ece9e1-2abf-4edc-8e34-de66e74114d2");

Console.WriteLine(response);
```

## GetCollectionRequestAsync

Gets information about a request in a collection.

- HTTP Method: `GET`
- Endpoint: `/collections/{collectionId}/requests/{requestId}`

**Parameters**

| Name         | Type   | Required | Description                                                              |
| :----------- | :----- | :------- | :----------------------------------------------------------------------- |
| requestId    | string | ✅       | The request's ID.                                                        |
| collectionId | string | ✅       | The collection's ID.                                                     |
| ids          | bool   | ❌       | If true, returns only properties that contain ID values in the response. |
| uid          | bool   | ❌       | If true, returns all IDs in UID format (`userId`-`id`).                  |
| populate     | bool   | ❌       | If true, returns all of the collection item's contents.                  |

**Return Type**

`GetCollectionRequest`

**Example Usage Code Snippet**

```csharp
using PostmanClient;

var client = new PostmanClientClient();

var response = await client.CollectionItems.GetCollectionRequestAsync("c82dd02c-4870-4907-8fcb-593a876cf05b", "12ece9e1-2abf-4edc-8e34-de66e74114d2", true, true, true);

Console.WriteLine(response);
```

## UpdateCollectionRequestAsync

Updates a request in a collection. For a complete list of properties, see the [Collection Format Request documentation](https://learning.postman.com/collection-format/reference/request/). **Note:** - You must pass a collection ID (`12ece9e1-2abf-4edc-8e34-de66e74114d2`), not a collection(`12345678-12ece9e1-2abf-4edc-8e34-de66e74114d2`), in this endpoint. - This endpoint does not support changing the folder of a request.

- HTTP Method: `PUT`
- Endpoint: `/collections/{collectionId}/requests/{requestId}`

**Parameters**

| Name         | Type   | Required | Description          |
| :----------- | :----- | :------- | :------------------- |
| input        | object | ❌       | The request body.    |
| requestId    | string | ✅       | The request's ID.    |
| collectionId | string | ✅       | The collection's ID. |

**Return Type**

`UpdateCollectionRequest`

**Example Usage Code Snippet**

```csharp
using PostmanClient;

var client = new PostmanClientClient();

var response = await client.CollectionItems.UpdateCollectionRequestAsync(new object {}, "c82dd02c-4870-4907-8fcb-593a876cf05b", "12ece9e1-2abf-4edc-8e34-de66e74114d2");

Console.WriteLine(response);
```

## DeleteCollectionRequestAsync

Deletes a request in a collection.

- HTTP Method: `DELETE`
- Endpoint: `/collections/{collectionId}/requests/{requestId}`

**Parameters**

| Name         | Type   | Required | Description          |
| :----------- | :----- | :------- | :------------------- |
| requestId    | string | ✅       | The request's ID.    |
| collectionId | string | ✅       | The collection's ID. |

**Return Type**

`DeleteCollectionRequest`

**Example Usage Code Snippet**

```csharp
using PostmanClient;

var client = new PostmanClientClient();

var response = await client.CollectionItems.DeleteCollectionRequestAsync("c82dd02c-4870-4907-8fcb-593a876cf05b", "12ece9e1-2abf-4edc-8e34-de66e74114d2");

Console.WriteLine(response);
```

## GetCollectionResponseAsync

Gets information about a response in a collection.

- HTTP Method: `GET`
- Endpoint: `/collections/{collectionId}/responses/{responseId}`

**Parameters**

| Name         | Type   | Required | Description                                                              |
| :----------- | :----- | :------- | :----------------------------------------------------------------------- |
| responseId   | string | ✅       | The response's ID.                                                       |
| collectionId | string | ✅       | The collection's ID.                                                     |
| ids          | bool   | ❌       | If true, returns only properties that contain ID values in the response. |
| uid          | bool   | ❌       | If true, returns all IDs in UID format (`userId`-`id`).                  |
| populate     | bool   | ❌       | If true, returns all of the collection item's contents.                  |

**Return Type**

`GetCollectionResponse`

**Example Usage Code Snippet**

```csharp
using PostmanClient;

var client = new PostmanClientClient();

var response = await client.CollectionItems.GetCollectionResponseAsync("cc364734-7dfd-4bfc-897d-be763dcdbb07", "12ece9e1-2abf-4edc-8e34-de66e74114d2", true, true, true);

Console.WriteLine(response);
```

## UpdateCollectionResponseAsync

Updates a response in a collection. For a complete list of properties, see the [Collection Format Response documentation](https://learning.postman.com/collection-format/reference/response/#reference-diagram). **Note:** - You must pass a collection ID (`12ece9e1-2abf-4edc-8e34-de66e74114d2`), not a collection UID (`12345678-12ece9e1-2abf-4edc-8e34-de66e74114d2`), in this endpoint. - This endpoint acts like a PATCH method. It only updates the values that you pass in the request body (for example, the `name` property). The endpoint does not update the entire resource.

- HTTP Method: `PUT`
- Endpoint: `/collections/{collectionId}/responses/{responseId}`

**Parameters**

| Name         | Type   | Required | Description          |
| :----------- | :----- | :------- | :------------------- |
| input        | object | ❌       | The request body.    |
| responseId   | string | ✅       | The response's ID.   |
| collectionId | string | ✅       | The collection's ID. |

**Return Type**

`UpdateCollectionResponse`

**Example Usage Code Snippet**

```csharp
using PostmanClient;

var client = new PostmanClientClient();

var response = await client.CollectionItems.UpdateCollectionResponseAsync(new object {}, "cc364734-7dfd-4bfc-897d-be763dcdbb07", "12ece9e1-2abf-4edc-8e34-de66e74114d2");

Console.WriteLine(response);
```

## DeleteCollectionResponseAsync

Deletes a response in a collection.

- HTTP Method: `DELETE`
- Endpoint: `/collections/{collectionId}/responses/{responseId}`

**Parameters**

| Name         | Type   | Required | Description          |
| :----------- | :----- | :------- | :------------------- |
| responseId   | string | ✅       | The response's ID.   |
| collectionId | string | ✅       | The collection's ID. |

**Return Type**

`DeleteCollectionResponse`

**Example Usage Code Snippet**

```csharp
using PostmanClient;

var client = new PostmanClientClient();

var response = await client.CollectionItems.DeleteCollectionResponseAsync("cc364734-7dfd-4bfc-897d-be763dcdbb07", "12ece9e1-2abf-4edc-8e34-de66e74114d2");

Console.WriteLine(response);
```

<!-- This file was generated by liblab | https://liblab.com/ -->
