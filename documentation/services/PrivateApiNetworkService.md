# PrivateApiNetworkService

A list of all methods in the `PrivateApiNetworkService` service. Click on the method name to view detailed information about that method.

| Methods                                                               | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          |
| :-------------------------------------------------------------------- | :----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| [GetAllElementsAndFoldersAsync](#getallelementsandfoldersasync)       | Gets information about the folders and their elements added to your [Private API Network](https://learning.postman.com/docs/collaborating-in-postman/adding-private-network/). **Note:** The `limit` and `offset` parameters are separately applied to elements and folders. For example, if you query a `limit` value of `10` and an `offset` value `0`, the endpoint returns 10 elements and 10 folders for a total of 20 items. The `totalCount` property in the `meta` response is the total count of both elements and folders. |
| [PostPanElementOrFolderAsync](#postpanelementorfolderasync)           | Publishes a element or creates a folder in your [Private API Network](https://learning.postman.com/docs/collaborating-in-postman/adding-private-network/). An element is a Postman API, collection, or workspace. **Note:** You can only pass one element object type per call. For example, you cannot pass both `api` and `collection` in a single request.                                                                                                                                                                        |
| [UpdatePanElementOrFolderAsync](#updatepanelementorfolderasync)       | Updates an element or folder in your [Private API Network](https://learning.postman.com/docs/collaborating-in-postman/adding-private-network/). **Note:** You can only pass one element object type per call. For example, you cannot pass both `api` and `collection` in a single request.                                                                                                                                                                                                                                          |
| [DeletePanElementOrFolderAsync](#deletepanelementorfolderasync)       | Removes an element or delete a folder from your [Private API Network](https://learning.postman.com/docs/collaborating-in-postman/adding-private-network/). **Note:** Removing an API, collection, or workspace element does not delete it. It only removes it from the Private API Network folder.                                                                                                                                                                                                                                   |
| [GetAllPanAddElementRequestsAsync](#getallpanaddelementrequestsasync) | Gets a list requests to add elements to the [Private API Network](https://learning.postman.com/docs/collaborating-in-postman/adding-private-network/).                                                                                                                                                                                                                                                                                                                                                                               |
| [RespondPanElementAddRequestAsync](#respondpanelementaddrequestasync) | Responds to a request to add an element to the [Private API Network](https://learning.postman.com/docs/collaborating-in-postman/adding-private-network/). Only managers can approve or deny a request. Once approved, the element will appear in the team's Private API Network.                                                                                                                                                                                                                                                     |

## GetAllElementsAndFoldersAsync

Gets information about the folders and their elements added to your [Private API Network](https://learning.postman.com/docs/collaborating-in-postman/adding-private-network/). **Note:** The `limit` and `offset` parameters are separately applied to elements and folders. For example, if you query a `limit` value of `10` and an `offset` value `0`, the endpoint returns 10 elements and 10 folders for a total of 20 items. The `totalCount` property in the `meta` response is the total count of both elements and folders.

- HTTP Method: `GET`
- Endpoint: `/network/private`

**Parameters**

| Name           | Type                         | Required | Description                                                                                                                                                                              |
| :------------- | :--------------------------- | :------- | :--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| since          | string                       | ❌       | Return only results created since the given time, in [ISO 8601](https://datatracker.ietf.org/doc/html/rfc3339#section-5.6) format. This value cannot be later than the `until` value.    |
| until          | string                       | ❌       | Return only results created until this given time, in [ISO 8601](https://datatracker.ietf.org/doc/html/rfc3339#section-5.6) format. This value cannot be earlier than the `since` value. |
| addedBy        | long                         | ❌       | Return only elements published by the given user ID.                                                                                                                                     |
| name           | string                       | ❌       | Return only elements whose name includes the given value. Matching is not case-sensitive.                                                                                                |
| summary        | string                       | ❌       | Return only elements whose summary includes the given value. Matching is not case-sensitive.                                                                                             |
| description    | string                       | ❌       | Return only elements whose description includes the given value. Matching is not case-sensitive.                                                                                         |
| sort           | GetAllElementsAndFoldersSort | ❌       | Sort the results by the given value. If you use this query parameter, you must also use the `direction` parameter.                                                                       |
| direction      | AscDesc                      | ❌       | Sort in ascending (`asc`) or descending (`desc`) order. Matching is not case-sensitive. If you use this query parameter, you must also use the `sort` parameter.                         |
| createdBy      | long                         | ❌       | Return only results created by the given user ID.                                                                                                                                        |
| offset         | long                         | ❌       | The zero-based offset of the first item to return.                                                                                                                                       |
| limit          | long                         | ❌       | The maximum number of elements to return. If the value exceeds the maximum value of `1000`, then the system uses the `1000` value.                                                       |
| parentFolderId | long                         | ❌       | Return the folders and elements in a specific folder. If this value is `0`, then the endpoint only returns the root folder's elements.                                                   |
| type\_         | GetAllElementsAndFoldersType | ❌       | Filter by the element type.                                                                                                                                                              |

**Return Type**

`GetPanElementsAndFolders`

**Example Usage Code Snippet**

```csharp
using PostmanClient;
using PostmanClient.Models;

var client = new PostmanClientClient();

var response = await client.PrivateApiNetwork.GetAllElementsAndFoldersAsync("2022-06-01T00:00:00.000Z", "2022-06-15T00:00:00.000Z", 12345678, "billing", "payments", "payments", GetAllElementsAndFoldersSort.CreatedAt, AscDesc.Asc, 12345678, 5, 10, 1, GetAllElementsAndFoldersType.Api);

Console.WriteLine(response);
```

## PostPanElementOrFolderAsync

Publishes a element or creates a folder in your [Private API Network](https://learning.postman.com/docs/collaborating-in-postman/adding-private-network/). An element is a Postman API, collection, or workspace. **Note:** You can only pass one element object type per call. For example, you cannot pass both `api` and `collection` in a single request.

- HTTP Method: `POST`
- Endpoint: `/network/private`

**Parameters**

| Name  | Type                                                                            | Required | Description       |
| :---- | :------------------------------------------------------------------------------ | :------- | :---------------- |
| input | OneOf`<PanCreateApi, PanCreateCollection, PanCreateWorkspace, PanCreateFolder>` | ✅       | The request body. |

**Return Type**

`OneOf<PanElementCreated, PanFolderCreated>`

**Example Usage Code Snippet**

```csharp
using PostmanClient;
using PostmanClient.Models;

var client = new PostmanClientClient();

var input = new PanCreateApi();

var response = await client.PrivateApiNetwork.PostPanElementOrFolderAsync(input);

Console.WriteLine(response);
```

## UpdatePanElementOrFolderAsync

Updates an element or folder in your [Private API Network](https://learning.postman.com/docs/collaborating-in-postman/adding-private-network/). **Note:** You can only pass one element object type per call. For example, you cannot pass both `api` and `collection` in a single request.

- HTTP Method: `PUT`
- Endpoint: `/network/private/{elementType}/{elementId}`

**Parameters**

| Name        | Type                                                                            | Required | Description                                                                                                           |
| :---------- | :------------------------------------------------------------------------------ | :------- | :-------------------------------------------------------------------------------------------------------------------- |
| input       | OneOf`<UpdatePanApi, UpdatePanCollection, UpdatePanWorkspace, UpdatePanFolder>` | ✅       | The request body.                                                                                                     |
| elementId   | string                                                                          | ✅       | The element's ID or UUID. For Postman Collections you must pass the collection's UID (`userId`-`collectionId`) value. |
| elementType | UpdatePanElementOrFolderElementType                                             | ✅       | The element type.                                                                                                     |

**Return Type**

`OneOf<PanElementCreated, PanFolderCreated>`

**Example Usage Code Snippet**

```csharp
using PostmanClient;
using PostmanClient.Models;

var client = new PostmanClientClient();

var input = new UpdatePanApi();

var response = await client.PrivateApiNetwork.UpdatePanElementOrFolderAsync(input, "5360b75f-447e-467c-9299-12fd6c92450d", UpdatePanElementOrFolderElementType.Api);

Console.WriteLine(response);
```

## DeletePanElementOrFolderAsync

Removes an element or delete a folder from your [Private API Network](https://learning.postman.com/docs/collaborating-in-postman/adding-private-network/). **Note:** Removing an API, collection, or workspace element does not delete it. It only removes it from the Private API Network folder.

- HTTP Method: `DELETE`
- Endpoint: `/network/private/{elementType}/{elementId}`

**Parameters**

| Name        | Type                                | Required | Description                                                                                                           |
| :---------- | :---------------------------------- | :------- | :-------------------------------------------------------------------------------------------------------------------- |
| elementId   | string                              | ✅       | The element's ID or UUID. For Postman Collections you must pass the collection's UID (`userId`-`collectionId`) value. |
| elementType | UpdatePanElementOrFolderElementType | ✅       | The element type.                                                                                                     |

**Return Type**

`DeletePanElementOrFolder`

**Example Usage Code Snippet**

```csharp
using PostmanClient;
using PostmanClient.Models;

var client = new PostmanClientClient();

var response = await client.PrivateApiNetwork.DeletePanElementOrFolderAsync("5360b75f-447e-467c-9299-12fd6c92450d", UpdatePanElementOrFolderElementType.Api);

Console.WriteLine(response);
```

## GetAllPanAddElementRequestsAsync

Gets a list requests to add elements to the [Private API Network](https://learning.postman.com/docs/collaborating-in-postman/adding-private-network/).

- HTTP Method: `GET`
- Endpoint: `/network/private/network-entity/request/all`

**Parameters**

| Name        | Type                              | Required | Description                                                                                                                                                                              |
| :---------- | :-------------------------------- | :------- | :--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| since       | string                            | ❌       | Return only results created since the given time, in [ISO 8601](https://datatracker.ietf.org/doc/html/rfc3339#section-5.6) format. This value cannot be later than the `until` value.    |
| until       | string                            | ❌       | Return only results created until this given time, in [ISO 8601](https://datatracker.ietf.org/doc/html/rfc3339#section-5.6) format. This value cannot be earlier than the `since` value. |
| requestedBy | long                              | ❌       | Return a user's element requests by their user ID.                                                                                                                                       |
| type\_      | GetAllElementsAndFoldersType      | ❌       | Filter by the element type.                                                                                                                                                              |
| status      | GetAllPanAddElementRequestsStatus | ❌       | Filter by the request status.                                                                                                                                                            |
| name        | string                            | ❌       | Return only elements whose name includes the given value. Matching is not case-sensitive.                                                                                                |
| sort        | GetAllElementsAndFoldersSort      | ❌       | Sort the results by the given value. If you use this query parameter, you must also use the `direction` parameter.                                                                       |
| direction   | AscDesc                           | ❌       | Sort in ascending (`asc`) or descending (`desc`) order. Matching is not case-sensitive. If you use this query parameter, you must also use the `sort` parameter.                         |
| offset      | long                              | ❌       | The zero-based offset of the first item to return.                                                                                                                                       |
| limit       | long                              | ❌       | The maximum number of elements to return. If the value exceeds the maximum value of `1000`, then the system uses the `1000` value.                                                       |

**Return Type**

`GetAllPanAddElementRequests`

**Example Usage Code Snippet**

```csharp
using PostmanClient;
using PostmanClient.Models;

var client = new PostmanClientClient();

var response = await client.PrivateApiNetwork.GetAllPanAddElementRequestsAsync("2022-06-01T00:00:00.000Z", "2022-06-15T00:00:00.000Z", 12345678, GetAllElementsAndFoldersType.Api, GetAllPanAddElementRequestsStatus.Pending, "billing", GetAllElementsAndFoldersSort.CreatedAt, AscDesc.Asc, 5, 10);

Console.WriteLine(response);
```

## RespondPanElementAddRequestAsync

Responds to a request to add an element to the [Private API Network](https://learning.postman.com/docs/collaborating-in-postman/adding-private-network/). Only managers can approve or deny a request. Once approved, the element will appear in the team's Private API Network.

- HTTP Method: `PUT`
- Endpoint: `/network/private/network-entity/request/{requestId}`

**Parameters**

| Name      | Type                                                 | Required | Description               |
| :-------- | :--------------------------------------------------- | :------- | :------------------------ |
| input     | PrivateApiNetworkRespondPanElementAddRequestRequest1 | ❌       | The request body.         |
| requestId | long                                                 | ✅       | The element request's ID. |

**Return Type**

`RespondPanElementAddRequestOkResponse`

**Example Usage Code Snippet**

```csharp
using PostmanClient;
using PostmanClient.Models;

var client = new PostmanClientClient();

var input = new PrivateApiNetworkRespondPanElementAddRequestRequest1(PrivateApiNetworkRespondPanElementAddRequestRequest1.RespondPanElementAddRequestStatus.Denied);

var response = await client.PrivateApiNetwork.RespondPanElementAddRequestAsync(input, 232);

Console.WriteLine(response);
```

<!-- This file was generated by liblab | https://liblab.com/ -->
