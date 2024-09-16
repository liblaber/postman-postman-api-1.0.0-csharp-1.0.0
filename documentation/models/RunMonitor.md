# RunMonitor

**Properties**

| Name  | Type | Required | Description                        |
| :---- | :--- | :------- | :--------------------------------- |
| Run\_ | Run  | ❌       | Information about the monitor run. |

# Run

Information about the monitor run.

**Properties**

| Name         | Type               | Required | Description                                                      |
| :----------- | :----------------- | :------- | :--------------------------------------------------------------- |
| Info         | RunInfo            | ❌       | Information about the monitor.                                   |
| Stats        | RunStats           | ❌       | Information about the monitor run's stats.                       |
| Executions\_ | List`<Executions>` | ❌       | Information about the monitor run's executions.                  |
| Failures     | List`<object>`     | ❌       | If the monitor run failed, information about the run's failures. |

# RunInfo

Information about the monitor.

**Properties**

| Name           | Type   | Required | Description                                             |
| :------------- | :----- | :------- | :------------------------------------------------------ |
| JobId          | string | ❌       | The monitor's run job ID.                               |
| CollectionUid  | string | ❌       | The unique ID of the monitor's associated collection.   |
| EnvironmentUid | string | ❌       | The unique ID of the monitor's associated environment.  |
| MonitorId      | string | ❌       | The monitor's ID.                                       |
| Name           | string | ❌       | The monitor's name.                                     |
| Status         | string | ❌       | The monitor run's status.                               |
| StartedAt      | string | ❌       | The date and time at which the monitor run began.       |
| FinishedAt     | string | ❌       | The date and time at which the monitor's run completed. |

# RunStats

Information about the monitor run's stats.

**Properties**

| Name       | Type             | Required | Description                         |
| :--------- | :--------------- | :------- | :---------------------------------- |
| Assertions | StatsAssertions2 | ❌       | The monitor run's assertions stats. |
| Requests   | StatsRequests2   | ❌       | The monitor run's request stats.    |

# StatsAssertions2

The monitor run's assertions stats.

**Properties**

| Name   | Type   | Required | Description                          |
| :----- | :----- | :------- | :----------------------------------- |
| Total  | double | ❌       | The total number of tests performed. |
| Failed | double | ❌       | The total number of test failures.   |

# StatsRequests2

The monitor run's request stats.

**Properties**

| Name   | Type   | Required | Description                     |
| :----- | :----- | :------- | :------------------------------ |
| Total  | double | ❌       | The total number of requests.   |
| Failed | double | ❌       | The number of request failures. |

# Executions

**Properties**

| Name       | Type               | Required | Description                                   |
| :--------- | :----------------- | :------- | :-------------------------------------------- |
| Id         | double             | ❌       | The execution ID.                             |
| Item       | ExecutionsItem     | ❌       | Information about the executed item.          |
| Request\_  | ExecutionsRequest  | ❌       | Information about the monitor run's requests. |
| Response\_ | ExecutionsResponse | ❌       | Information about the monitor run's response. |

# ExecutionsItem

Information about the executed item.

**Properties**

| Name | Type   | Required | Description               |
| :--- | :----- | :------- | :------------------------ |
| Name | string | ❌       | The executed item's name. |

# ExecutionsRequest

Information about the monitor run's requests.

**Properties**

| Name      | Type   | Required | Description                                                                                           |
| :-------- | :----- | :------- | :---------------------------------------------------------------------------------------------------- |
| Method    | string | ❌       | The request method.                                                                                   |
| Url       | string | ❌       | The request's URL.                                                                                    |
| Body      | object | ❌       | Information about the request body, such as Content-Length.                                           |
| Headers   | object | ❌       | Information about the request headers, such as Content-Type, Accept, encoding, and other information. |
| Timestamp | string | ❌       | The date and time of the request.                                                                     |

# ExecutionsResponse

Information about the monitor run's response.

**Properties**

| Name         | Type   | Required | Description                                                                                            |
| :----------- | :----- | :------- | :----------------------------------------------------------------------------------------------------- |
| Body         | object | ❌       | Information about the request body, such as Content-Length.                                            |
| Code         | double | ❌       | The response's HTTP status code.                                                                       |
| Headers      | object | ❌       | Information about the response headers, such as Content-Type, Accept, encoding, and other information. |
| ResponseSize | double | ❌       | The response size, in bytes.                                                                           |
| ResponseTime | double | ❌       | The response time, in milliseconds.                                                                    |

<!-- This file was generated by liblab | https://liblab.com/ -->
