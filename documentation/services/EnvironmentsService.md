# EnvironmentsService

A list of all methods in the `EnvironmentsService` service. Click on the method name to view detailed information about that method.

| Methods                                                 | Description                                                                                                                                                                                                                |
| :------------------------------------------------------ | :------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| [GetEnvironmentsAsync](#getenvironmentsasync)           | Gets information about all of your [environments](https://learning.postman.com/docs/sending-requests/managing-environments/).                                                                                              |
| [CreateEnvironmentAsync](#createenvironmentasync)       | Creates an environment.                                                                                                                                                                                                    |
| [GetEnvironmentAsync](#getenvironmentasync)             | Gets information about an environment.                                                                                                                                                                                     |
| [UpdateEnvironmentAsync](#updateenvironmentasync)       | Updates an environment.                                                                                                                                                                                                    |
| [DeleteEnvironmentAsync](#deleteenvironmentasync)       | Deletes an environment.                                                                                                                                                                                                    |
| [GetEnvironmentForksAsync](#getenvironmentforksasync)   | Gets all of an environment's forked environments.                                                                                                                                                                          |
| [ForkEnvironmentAsync](#forkenvironmentasync)           | Creates a [fork](https://learning.postman.com/docs/collaborating-in-postman/using-version-control/forking-elements/) of an existing environment.                                                                           |
| [MergeEnvironmentForkAsync](#mergeenvironmentforkasync) | [Merges](https://learning.postman.com/docs/collaborating-in-postman/using-version-control/forking-elements/#merge-changes-from-a-fork) a forked environment back into its parent environment.                              |
| [PullEnvironmentAsync](#pullenvironmentasync)           | [Pulls](https://learning.postman.com/docs/collaborating-in-postman/using-version-control/forking-elements/#pull-updates-from-a-parent-element) the changes from a parent (source) environment into the forked environment. |

## GetEnvironmentsAsync

Gets information about all of your [environments](https://learning.postman.com/docs/sending-requests/managing-environments/).

- HTTP Method: `GET`
- Endpoint: `/environments`

**Parameters**

| Name      | Type   | Required | Description         |
| :-------- | :----- | :------- | :------------------ |
| workspace | string | ❌       | The workspace's ID. |

**Return Type**

`GetEnvironments`

**Example Usage Code Snippet**

```csharp
using PostmanClient;

var client = new PostmanClientClient();

var response = await client.Environments.GetEnvironmentsAsync("1f0df51a-8658-4ee8-a2a1-d2567dfa09a9");

Console.WriteLine(response);
```

## CreateEnvironmentAsync

Creates an environment.

- HTTP Method: `POST`
- Endpoint: `/environments`

**Parameters**

| Name      | Type                     | Required | Description         |
| :-------- | :----------------------- | :------- | :------------------ |
| input     | CreateEnvironmentRequest | ❌       | The request body.   |
| workspace | string                   | ❌       | The workspace's ID. |

**Return Type**

`CreateEnvironmentOkResponse`

**Example Usage Code Snippet**

```csharp
using PostmanClient;
using PostmanClient.Models;

var client = new PostmanClientClient();

var input = new CreateEnvironmentRequest();

var response = await client.Environments.CreateEnvironmentAsync(input, "1f0df51a-8658-4ee8-a2a1-d2567dfa09a9");

Console.WriteLine(response);
```

## GetEnvironmentAsync

Gets information about an environment.

- HTTP Method: `GET`
- Endpoint: `/environments/{environmentId}`

**Parameters**

| Name          | Type   | Required | Description           |
| :------------ | :----- | :------- | :-------------------- |
| environmentId | string | ✅       | The environment's ID. |

**Return Type**

`GetEnvironment`

**Example Usage Code Snippet**

```csharp
using PostmanClient;

var client = new PostmanClientClient();

var response = await client.Environments.GetEnvironmentAsync("5daabc50-8451-43f6-922d-96b403b4f28e");

Console.WriteLine(response);
```

## UpdateEnvironmentAsync

Updates an environment.

- HTTP Method: `PUT`
- Endpoint: `/environments/{environmentId}`

**Parameters**

| Name          | Type                     | Required | Description           |
| :------------ | :----------------------- | :------- | :-------------------- |
| input         | UpdateEnvironmentRequest | ❌       | The request body.     |
| environmentId | string                   | ✅       | The environment's ID. |

**Return Type**

`UpdateEnvironmentOkResponse`

**Example Usage Code Snippet**

```csharp
using PostmanClient;
using PostmanClient.Models;

var client = new PostmanClientClient();

var input = new UpdateEnvironmentRequest();

var response = await client.Environments.UpdateEnvironmentAsync(input, "5daabc50-8451-43f6-922d-96b403b4f28e");

Console.WriteLine(response);
```

## DeleteEnvironmentAsync

Deletes an environment.

- HTTP Method: `DELETE`
- Endpoint: `/environments/{environmentId}`

**Parameters**

| Name          | Type   | Required | Description           |
| :------------ | :----- | :------- | :-------------------- |
| environmentId | string | ✅       | The environment's ID. |

**Return Type**

`DeleteEnvironment`

**Example Usage Code Snippet**

```csharp
using PostmanClient;

var client = new PostmanClientClient();

var response = await client.Environments.DeleteEnvironmentAsync("5daabc50-8451-43f6-922d-96b403b4f28e");

Console.WriteLine(response);
```

## GetEnvironmentForksAsync

Gets all of an environment's forked environments.

- HTTP Method: `GET`
- Endpoint: `/environments/{environmentId}/forks`

**Parameters**

| Name          | Type                    | Required | Description                                                                                                                                |
| :------------ | :---------------------- | :------- | :----------------------------------------------------------------------------------------------------------------------------------------- |
| environmentId | string                  | ✅       | The environment's unique ID.                                                                                                               |
| cursor        | string                  | ❌       | The pointer to the first record of the set of paginated results. To view the next response, use the `nextCursor` value for this parameter. |
| direction     | AscDesc                 | ❌       | Sort results in ascending (`asc`) or descending (`desc`) order.                                                                            |
| limit         | long                    | ❌       | The maximum number of rows to return in the response.                                                                                      |
| sort          | GetEnvironmentForksSort | ❌       | Sort the results by the date and time of creation.                                                                                         |

**Return Type**

`GetEnvironmentForks`

**Example Usage Code Snippet**

```csharp
using PostmanClient;
using PostmanClient.Models;

var client = new PostmanClientClient();

var response = await client.Environments.GetEnvironmentForksAsync("12345678-12ece9e1-2abf-4edc-8e34-de66e74114d2", "RnJpIEZlYiAyNCAyMDIzIDEzOjI0OjA5IEdNVCswMDAwIChDb29yZGluYXRlZCBVbml2ZXJzYWwgVGltZSk=", AscDesc.Asc, 10, GetEnvironmentForksSort.CreatedAt);

Console.WriteLine(response);
```

## ForkEnvironmentAsync

Creates a [fork](https://learning.postman.com/docs/collaborating-in-postman/using-version-control/forking-elements/) of an existing environment.

- HTTP Method: `POST`
- Endpoint: `/environments/{environmentId}/forks`

**Parameters**

| Name          | Type                   | Required | Description                  |
| :------------ | :--------------------- | :------- | :--------------------------- |
| input         | ForkEnvironmentRequest | ❌       | The request body.            |
| environmentId | string                 | ✅       | The environment's unique ID. |
| workspaceId   | string                 | ✅       | The workspace's ID.          |

**Return Type**

`ForkEnvironmentOkResponse`

**Example Usage Code Snippet**

```csharp
using PostmanClient;
using PostmanClient.Models;

var client = new PostmanClientClient();

var input = new ForkEnvironmentRequest("My fork");

var response = await client.Environments.ForkEnvironmentAsync(input, "12345678-12ece9e1-2abf-4edc-8e34-de66e74114d2", "1f0df51a-8658-4ee8-a2a1-d2567dfa09a9");

Console.WriteLine(response);
```

## MergeEnvironmentForkAsync

[Merges](https://learning.postman.com/docs/collaborating-in-postman/using-version-control/forking-elements/#merge-changes-from-a-fork) a forked environment back into its parent environment.

- HTTP Method: `POST`
- Endpoint: `/environments/{environmentId}/merges`

**Parameters**

| Name          | Type                        | Required | Description                  |
| :------------ | :-------------------------- | :------- | :--------------------------- |
| input         | MergeEnvironmentForkRequest | ❌       | The request body.            |
| environmentId | string                      | ✅       | The environment's unique ID. |

**Return Type**

`MergeEnvironmentForkOkResponse`

**Example Usage Code Snippet**

```csharp
using PostmanClient;
using PostmanClient.Models;

var client = new PostmanClientClient();

var input = new MergeEnvironmentForkRequest("12345678-d9c7dc8f-904e-4bba-99b5-4d490aae1957");

var response = await client.Environments.MergeEnvironmentForkAsync(input, "12345678-12ece9e1-2abf-4edc-8e34-de66e74114d2");

Console.WriteLine(response);
```

## PullEnvironmentAsync

[Pulls](https://learning.postman.com/docs/collaborating-in-postman/using-version-control/forking-elements/#pull-updates-from-a-parent-element) the changes from a parent (source) environment into the forked environment.

- HTTP Method: `POST`
- Endpoint: `/environments/{environmentId}/pulls`

**Parameters**

| Name          | Type                   | Required | Description                  |
| :------------ | :--------------------- | :------- | :--------------------------- |
| input         | PullEnvironmentRequest | ❌       | The request body.            |
| environmentId | string                 | ✅       | The environment's unique ID. |

**Return Type**

`PullEnvironmentOkResponse`

**Example Usage Code Snippet**

```csharp
using PostmanClient;
using PostmanClient.Models;

var client = new PostmanClientClient();

var input = new PullEnvironmentRequest();

var response = await client.Environments.PullEnvironmentAsync(input, "12345678-12ece9e1-2abf-4edc-8e34-de66e74114d2");

Console.WriteLine(response);
```

<!-- This file was generated by liblab | https://liblab.com/ -->
