# MocksService

A list of all methods in the `MocksService` service. Click on the method name to view detailed information about that method.

| Methods                                                         | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               |
| :-------------------------------------------------------------- | :------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| [GetMocksAsync](#getmocksasync)                                 | Gets all mock servers. By default, this endpoint returns only mock servers you created across all workspaces. **Note:** If you pass both the `teamId` and `workspace` query parameters, this endpoint only accepts the `workspace` query.                                                                                                                                                                                                                                                                                                                                 |
| [CreateMockAsync](#createmockasync)                             | Creates a mock server in a collection. **Note:** - If you do not include the `workspaceId` query parameter, the system creates the mock server in your [Personal workspace](https://learning.postman.com/docs/collaborating-in-postman/using-workspaces/creating-workspaces/). - You cannot create mocks for collections added to an API definition.                                                                                                                                                                                                                      |
| [GetMockAsync](#getmockasync)                                   | Gets information about a mock server.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     |
| [UpdateMockAsync](#updatemockasync)                             | Updates a mock server.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    |
| [DeleteMockAsync](#deletemockasync)                             | Deletes a mock server.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                    |
| [GetMockCallLogsAsync](#getmockcalllogsasync)                   | Gets a mock server's call logs. You can get a maximum of 6.5MB of call logs or a total of 100 call logs, whichever limit is met first in one API call. Call logs contain exchanged request and response data made to mock servers. The logs provide visibility into how the mock servers are being used. You can log data to debug, test, analyze, and more, depending upon the use case.                                                                                                                                                                                 |
| [PublishMockAsync](#publishmockasync)                           | Publishes a mock server. Publishing a mock server sets its **Access Control** configuration setting to public.                                                                                                                                                                                                                                                                                                                                                                                                                                                            |
| [UnpublishMockAsync](#unpublishmockasync)                       | Unpublishes a mock server. Unpublishing a mock server sets its **Access Control** configuration setting to private.                                                                                                                                                                                                                                                                                                                                                                                                                                                       |
| [GetMockServerResponsesAsync](#getmockserverresponsesasync)     | Gets all of a mock server's server responses.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             |
| [CreateMockServerResponseAsync](#createmockserverresponseasync) | Creates a server response. Server responses let you simulate 5xx server-level responses, such as 500 or 503. Server-level responses are agnostic to application-level logic. Server responses let you simulate this behavior on a mock server. You do not need to define each error for all exposed paths on the mock server. If you set a server response as active, then all the calls to the mock server return with that active server response. **Note:** You can create multiple server responses for a mock server, but only one mock server can be set as active. |
| [GetMockServerResponseAsync](#getmockserverresponseasync)       | Gets information about a server response.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 |
| [UpdateMockServerResponseAsync](#updatemockserverresponseasync) | Updates a server response.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                |
| [DeleteMockServerResponseAsync](#deletemockserverresponseasync) | Deletes a mock server's server response.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  |

## GetMocksAsync

Gets all mock servers. By default, this endpoint returns only mock servers you created across all workspaces. **Note:** If you pass both the `teamId` and `workspace` query parameters, this endpoint only accepts the `workspace` query.

- HTTP Method: `GET`
- Endpoint: `/mocks`

**Parameters**

| Name      | Type   | Required | Description                                           |
| :-------- | :----- | :------- | :---------------------------------------------------- |
| teamId    | string | ❌       | Return only results that belong to the given team ID. |
| workspace | string | ❌       | Return only results found in the given workspace.     |

**Return Type**

`GetMocks`

**Example Usage Code Snippet**

```csharp
using PostmanClient;

var client = new PostmanClientClient();

var response = await client.Mocks.GetMocksAsync("1b96f65f-8d23-4e1d-b5e2-055992c3b8cbd2567dfa09a9", "1f0df51a-8658-4ee8-a2a1-d2567dfa09a9");

Console.WriteLine(response);
```

## CreateMockAsync

Creates a mock server in a collection. **Note:** - If you do not include the `workspaceId` query parameter, the system creates the mock server in your [Personal workspace](https://learning.postman.com/docs/collaborating-in-postman/using-workspaces/creating-workspaces/). - You cannot create mocks for collections added to an API definition.

- HTTP Method: `POST`
- Endpoint: `/mocks`

**Parameters**

| Name        | Type       | Required | Description         |
| :---------- | :--------- | :------- | :------------------ |
| input       | CreateMock | ✅       | The request body.   |
| workspaceId | string     | ❌       | The workspace's ID. |

**Return Type**

`MockCreateUpdate`

**Example Usage Code Snippet**

```csharp
using PostmanClient;
using PostmanClient.Models;

var client = new PostmanClientClient();

var input = new CreateMock();

var response = await client.Mocks.CreateMockAsync(input, "1f0df51a-8658-4ee8-a2a1-d2567dfa09a9");

Console.WriteLine(response);
```

## GetMockAsync

Gets information about a mock server.

- HTTP Method: `GET`
- Endpoint: `/mocks/{mockId}`

**Parameters**

| Name   | Type   | Required | Description    |
| :----- | :----- | :------- | :------------- |
| mockId | string | ✅       | The mock's ID. |

**Return Type**

`GetMock`

**Example Usage Code Snippet**

```csharp
using PostmanClient;

var client = new PostmanClientClient();

var response = await client.Mocks.GetMockAsync("e3d951bf-873f-49ac-a658-b2dcb91d3289");

Console.WriteLine(response);
```

## UpdateMockAsync

Updates a mock server.

- HTTP Method: `PUT`
- Endpoint: `/mocks/{mockId}`

**Parameters**

| Name   | Type       | Required | Description       |
| :----- | :--------- | :------- | :---------------- |
| input  | UpdateMock | ❌       | The request body. |
| mockId | string     | ✅       | The mock's ID.    |

**Return Type**

`MockCreateUpdate`

**Example Usage Code Snippet**

```csharp
using PostmanClient;
using PostmanClient.Models;

var client = new PostmanClientClient();

var input = new UpdateMock();

var response = await client.Mocks.UpdateMockAsync(input, "e3d951bf-873f-49ac-a658-b2dcb91d3289");

Console.WriteLine(response);
```

## DeleteMockAsync

Deletes a mock server.

- HTTP Method: `DELETE`
- Endpoint: `/mocks/{mockId}`

**Parameters**

| Name   | Type   | Required | Description    |
| :----- | :----- | :------- | :------------- |
| mockId | string | ✅       | The mock's ID. |

**Return Type**

`DeleteMock`

**Example Usage Code Snippet**

```csharp
using PostmanClient;

var client = new PostmanClientClient();

var response = await client.Mocks.DeleteMockAsync("e3d951bf-873f-49ac-a658-b2dcb91d3289");

Console.WriteLine(response);
```

## GetMockCallLogsAsync

Gets a mock server's call logs. You can get a maximum of 6.5MB of call logs or a total of 100 call logs, whichever limit is met first in one API call. Call logs contain exchanged request and response data made to mock servers. The logs provide visibility into how the mock servers are being used. You can log data to debug, test, analyze, and more, depending upon the use case.

- HTTP Method: `GET`
- Endpoint: `/mocks/{mockId}/call-logs`

**Parameters**

| Name               | Type                | Required | Description                                                                                                                                                                                                                    |
| :----------------- | :------------------ | :------- | :----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| mockId             | string              | ✅       | The mock's ID.                                                                                                                                                                                                                 |
| limit              | double              | ❌       | The maximum number of rows to return in the response.                                                                                                                                                                          |
| cursor             | string              | ❌       | The pointer to the first record of the set of paginated results. To view the next response, use the `nextCursor` value for this parameter.                                                                                     |
| until              | string              | ❌       | Return only results created until this given time, in [ISO 8601](https://datatracker.ietf.org/doc/html/rfc3339#section-5.6) format. This value cannot be earlier than the `since` value.                                       |
| since              | string              | ❌       | Return only results created since the given time, in [ISO 8601](https://datatracker.ietf.org/doc/html/rfc3339#section-5.6) format. This value cannot be later than the `until` value.                                          |
| responseStatusCode | double              | ❌       | Return only call logs that match the given HTTP response status code.                                                                                                                                                          |
| responseType       | string              | ❌       | Return only call logs that match the given response type. Matching is not case-sensitive.                                                                                                                                      |
| requestMethod      | string              | ❌       | Return only call logs that match the given HTTP method. Matching is not case-sensitive.                                                                                                                                        |
| requestPath        | string              | ❌       | Return only call logs that match the given request path. Matching is not case-sensitive.                                                                                                                                       |
| sort               | GetMockCallLogsSort | ❌       | Sort the results by the given value. If you use this query parameter, you must also use the `direction` parameter.                                                                                                             |
| direction          | AscDesc             | ❌       | Sort in ascending (`asc`) or descending (`desc`) order. Matching is not case-sensitive. If you use this query parameter, you must also use the `sort` parameter.                                                               |
| include            | string              | ❌       | Include call log records with header and body data. This query parameter accepts the `request.headers`, `request.body`, `response.headers`, and `response.body` values. For multiple include types, comma-separate each value. |

**Return Type**

`GetMockCallLogs`

**Example Usage Code Snippet**

```csharp
using PostmanClient;
using PostmanClient.Models;

var client = new PostmanClientClient();

var response = await client.Mocks.GetMockCallLogsAsync("e3d951bf-873f-49ac-a658-b2dcb91d3289", 3, "RnJpIEZlYiAyNCAyMDIzIDEzOjI0OjA5IEdNVCswMDAwIChDb29yZGluYXRlZCBVbml2ZXJzYWwgVGltZSk=", "2022-06-15T00:00:00.000Z", "2022-06-01T00:00:00.000Z", 500, "success", "post", "/animals?type=Dog", GetMockCallLogsSort.ServedAt, AscDesc.Asc, "request.headers,request.body,response.headers,response.body");

Console.WriteLine(response);
```

## PublishMockAsync

Publishes a mock server. Publishing a mock server sets its **Access Control** configuration setting to public.

- HTTP Method: `POST`
- Endpoint: `/mocks/{mockId}/publish`

**Parameters**

| Name   | Type   | Required | Description    |
| :----- | :----- | :------- | :------------- |
| mockId | string | ✅       | The mock's ID. |

**Return Type**

`PublishMock`

**Example Usage Code Snippet**

```csharp
using PostmanClient;

var client = new PostmanClientClient();

var response = await client.Mocks.PublishMockAsync("e3d951bf-873f-49ac-a658-b2dcb91d3289");

Console.WriteLine(response);
```

## UnpublishMockAsync

Unpublishes a mock server. Unpublishing a mock server sets its **Access Control** configuration setting to private.

- HTTP Method: `DELETE`
- Endpoint: `/mocks/{mockId}/unpublish`

**Parameters**

| Name   | Type   | Required | Description    |
| :----- | :----- | :------- | :------------- |
| mockId | string | ✅       | The mock's ID. |

**Return Type**

`UnpublishMock`

**Example Usage Code Snippet**

```csharp
using PostmanClient;

var client = new PostmanClientClient();

var response = await client.Mocks.UnpublishMockAsync("e3d951bf-873f-49ac-a658-b2dcb91d3289");

Console.WriteLine(response);
```

## GetMockServerResponsesAsync

Gets all of a mock server's server responses.

- HTTP Method: `GET`
- Endpoint: `/mocks/{mockId}/server-responses`

**Parameters**

| Name   | Type   | Required | Description    |
| :----- | :----- | :------- | :------------- |
| mockId | string | ✅       | The mock's ID. |

**Return Type**

`List<GetMockServerResponses>`

**Example Usage Code Snippet**

```csharp
using PostmanClient;

var client = new PostmanClientClient();

var response = await client.Mocks.GetMockServerResponsesAsync("e3d951bf-873f-49ac-a658-b2dcb91d3289");

Console.WriteLine(response);
```

## CreateMockServerResponseAsync

Creates a server response. Server responses let you simulate 5xx server-level responses, such as 500 or 503. Server-level responses are agnostic to application-level logic. Server responses let you simulate this behavior on a mock server. You do not need to define each error for all exposed paths on the mock server. If you set a server response as active, then all the calls to the mock server return with that active server response. **Note:** You can create multiple server responses for a mock server, but only one mock server can be set as active.

- HTTP Method: `POST`
- Endpoint: `/mocks/{mockId}/server-responses`

**Parameters**

| Name   | Type                     | Required | Description       |
| :----- | :----------------------- | :------- | :---------------- |
| input  | CreateMockServerResponse | ✅       | The request body. |
| mockId | string                   | ✅       | The mock's ID.    |

**Return Type**

`object`

**Example Usage Code Snippet**

```csharp
using PostmanClient;
using PostmanClient.Models;

var client = new PostmanClientClient();

var input = new CreateMockServerResponse();

var response = await client.Mocks.CreateMockServerResponseAsync(input, "e3d951bf-873f-49ac-a658-b2dcb91d3289");

Console.WriteLine(response);
```

## GetMockServerResponseAsync

Gets information about a server response.

- HTTP Method: `GET`
- Endpoint: `/mocks/{mockId}/server-responses/{serverResponseId}`

**Parameters**

| Name             | Type   | Required | Description               |
| :--------------- | :----- | :------- | :------------------------ |
| mockId           | string | ✅       | The mock's ID.            |
| serverResponseId | string | ✅       | The server response's ID. |

**Return Type**

`object`

**Example Usage Code Snippet**

```csharp
using PostmanClient;

var client = new PostmanClientClient();

var response = await client.Mocks.GetMockServerResponseAsync("e3d951bf-873f-49ac-a658-b2dcb91d3289", "965cdd16-fe22-4d96-a161-3d05490ac421");

Console.WriteLine(response);
```

## UpdateMockServerResponseAsync

Updates a server response.

- HTTP Method: `PUT`
- Endpoint: `/mocks/{mockId}/server-responses/{serverResponseId}`

**Parameters**

| Name             | Type                     | Required | Description               |
| :--------------- | :----------------------- | :------- | :------------------------ |
| input            | UpdateMockServerResponse | ✅       | The request body.         |
| mockId           | string                   | ✅       | The mock's ID.            |
| serverResponseId | string                   | ✅       | The server response's ID. |

**Return Type**

`object`

**Example Usage Code Snippet**

```csharp
using PostmanClient;
using PostmanClient.Models;

var client = new PostmanClientClient();

var input = new UpdateMockServerResponse();

var response = await client.Mocks.UpdateMockServerResponseAsync(input, "e3d951bf-873f-49ac-a658-b2dcb91d3289", "965cdd16-fe22-4d96-a161-3d05490ac421");

Console.WriteLine(response);
```

## DeleteMockServerResponseAsync

Deletes a mock server's server response.

- HTTP Method: `DELETE`
- Endpoint: `/mocks/{mockId}/server-responses/{serverResponseId}`

**Parameters**

| Name             | Type   | Required | Description               |
| :--------------- | :----- | :------- | :------------------------ |
| mockId           | string | ✅       | The mock's ID.            |
| serverResponseId | string | ✅       | The server response's ID. |

**Return Type**

`DeleteMockServerResponse`

**Example Usage Code Snippet**

```csharp
using PostmanClient;

var client = new PostmanClientClient();

var response = await client.Mocks.DeleteMockServerResponseAsync("e3d951bf-873f-49ac-a658-b2dcb91d3289", "965cdd16-fe22-4d96-a161-3d05490ac421");

Console.WriteLine(response);
```

<!-- This file was generated by liblab | https://liblab.com/ -->
