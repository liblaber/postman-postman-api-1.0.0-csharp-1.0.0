# MonitorsService

A list of all methods in the `MonitorsService` service. Click on the method name to view detailed information about that method.

| Methods                                   | Description                                                                                         |
| :---------------------------------------- | :-------------------------------------------------------------------------------------------------- |
| [GetMonitorsAsync](#getmonitorsasync)     | Gets all monitors.                                                                                  |
| [CreateMonitorAsync](#createmonitorasync) | Creates a monitor. **Note:** You cannot create monitors for collections added to an API definition. |
| [GetMonitorAsync](#getmonitorasync)       | Gets information about a monitor.                                                                   |
| [UpdateMonitorAsync](#updatemonitorasync) | Updates a monitor.                                                                                  |
| [DeleteMonitorAsync](#deletemonitorasync) | Deletes a monitor.                                                                                  |
| [RunMonitorAsync](#runmonitorasync)       | Runs a monitor and returns its run results.                                                         |

## GetMonitorsAsync

Gets all monitors.

- HTTP Method: `GET`
- Endpoint: `/monitors`

**Parameters**

| Name      | Type   | Required | Description                                       |
| :-------- | :----- | :------- | :------------------------------------------------ |
| workspace | string | ❌       | Return only results found in the given workspace. |

**Return Type**

`GetMonitors`

**Example Usage Code Snippet**

```csharp
using PostmanClient;

var client = new PostmanClientClient();

var response = await client.Monitors.GetMonitorsAsync("1f0df51a-8658-4ee8-a2a1-d2567dfa09a9");

Console.WriteLine(response);
```

## CreateMonitorAsync

Creates a monitor. **Note:** You cannot create monitors for collections added to an API definition.

- HTTP Method: `POST`
- Endpoint: `/monitors`

**Parameters**

| Name      | Type                 | Required | Description         |
| :-------- | :------------------- | :------- | :------------------ |
| input     | CreateMonitorRequest | ❌       | The request body.   |
| workspace | string               | ❌       | The workspace's ID. |

**Return Type**

`CreateMonitorOkResponse`

**Example Usage Code Snippet**

```csharp
using PostmanClient;
using PostmanClient.Models;

var client = new PostmanClientClient();

var input = new CreateMonitorRequest();

var response = await client.Monitors.CreateMonitorAsync(input, "1f0df51a-8658-4ee8-a2a1-d2567dfa09a9");

Console.WriteLine(response);
```

## GetMonitorAsync

Gets information about a monitor.

- HTTP Method: `GET`
- Endpoint: `/monitors/{monitorId}`

**Parameters**

| Name      | Type   | Required | Description       |
| :-------- | :----- | :------- | :---------------- |
| monitorId | string | ✅       | The monitor's ID. |

**Return Type**

`GetMonitor`

**Example Usage Code Snippet**

```csharp
using PostmanClient;

var client = new PostmanClientClient();

var response = await client.Monitors.GetMonitorAsync("1e6b6cc1-c760-48e0-968f-4bfaeeae9af1");

Console.WriteLine(response);
```

## UpdateMonitorAsync

Updates a monitor.

- HTTP Method: `PUT`
- Endpoint: `/monitors/{monitorId}`

**Parameters**

| Name      | Type                 | Required | Description       |
| :-------- | :------------------- | :------- | :---------------- |
| input     | UpdateMonitorRequest | ❌       | The request body. |
| monitorId | string               | ✅       | The monitor's ID. |

**Return Type**

`UpdateMonitorOkResponse`

**Example Usage Code Snippet**

```csharp
using PostmanClient;
using PostmanClient.Models;

var client = new PostmanClientClient();

var input = new UpdateMonitorRequest();

var response = await client.Monitors.UpdateMonitorAsync(input, "1e6b6cc1-c760-48e0-968f-4bfaeeae9af1");

Console.WriteLine(response);
```

## DeleteMonitorAsync

Deletes a monitor.

- HTTP Method: `DELETE`
- Endpoint: `/monitors/{monitorId}`

**Parameters**

| Name      | Type   | Required | Description       |
| :-------- | :----- | :------- | :---------------- |
| monitorId | string | ✅       | The monitor's ID. |

**Return Type**

`DeleteMonitor`

**Example Usage Code Snippet**

```csharp
using PostmanClient;

var client = new PostmanClientClient();

var response = await client.Monitors.DeleteMonitorAsync("1e6b6cc1-c760-48e0-968f-4bfaeeae9af1");

Console.WriteLine(response);
```

## RunMonitorAsync

Runs a monitor and returns its run results.

- HTTP Method: `POST`
- Endpoint: `/monitors/{monitorId}/run`

**Parameters**

| Name      | Type   | Required | Description       |
| :-------- | :----- | :------- | :---------------- |
| monitorId | string | ✅       | The monitor's ID. |

**Return Type**

`RunMonitor`

**Example Usage Code Snippet**

```csharp
using PostmanClient;

var client = new PostmanClientClient();

var response = await client.Monitors.RunMonitorAsync("1e6b6cc1-c760-48e0-968f-4bfaeeae9af1");

Console.WriteLine(response);
```

<!-- This file was generated by liblab | https://liblab.com/ -->
