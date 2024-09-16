# GetMonitor

**Properties**

| Name    | Type              | Required | Description |
| :------ | :---------------- | :------- | :---------- |
| Monitor | GetMonitorMonitor | ❌       |             |

# GetMonitorMonitor

**Properties**

| Name            | Type             | Required | Description                                                                                                                             |
| :-------------- | :--------------- | :------- | :-------------------------------------------------------------------------------------------------------------------------------------- |
| Id              | string           | ❌       | The monitor's ID.                                                                                                                       |
| Name            | string           | ❌       | The monitor's name.                                                                                                                     |
| Uid             | string           | ❌       | The monitor's unique ID.                                                                                                                |
| Owner           | double           | ❌       | The ID of monitor's owner.                                                                                                              |
| CollectionUid   | string           | ❌       | The unique ID of the monitor's associated collection.                                                                                   |
| EnvironmentUid  | string           | ❌       | The unique ID of the monitor's associated environment.                                                                                  |
| Distribution    | List`<string>`   | ❌       | A list of the monitor's [geographic regions](https://learning.postman.com/docs/monitoring-your-api/setting-up-monitor/#adding-regions). |
| LastRun\_       | LastRun          | ❌       | Information about the monitor's previous run.                                                                                           |
| Notifications\_ | Notifications    | ❌       | Information about the monitor's notification settings.                                                                                  |
| Options\_       | Options          | ❌       | Information about the monitor's option settings.                                                                                        |
| Schedule        | MonitorSchedule2 | ❌       | Information about the monitor's schedule.                                                                                               |

# LastRun

Information about the monitor's previous run.

**Properties**

| Name       | Type         | Required | Description                                                      |
| :--------- | :----------- | :------- | :--------------------------------------------------------------- |
| FinishedAt | string       | ❌       | The date and time at which the monitor's previous run completed. |
| StartedAt  | string       | ❌       | The date and time at which the monitor's previous run started.   |
| Stats      | LastRunStats | ❌       | Information about the monitor's stats.                           |
| Status     | string       | ❌       | The monitor's status after its last run.                         |

# LastRunStats

Information about the monitor's stats.

**Properties**

| Name       | Type             | Required | Description                                 |
| :--------- | :--------------- | :------- | :------------------------------------------ |
| Assertions | StatsAssertions1 | ❌       | Information about the monitor's assertions. |
| Requests   | StatsRequests1   | ❌       | Information about the monitor's requests.   |

# StatsAssertions1

Information about the monitor's assertions.

**Properties**

| Name   | Type   | Required | Description                          |
| :----- | :----- | :------- | :----------------------------------- |
| Failed | double | ❌       | The total number of test failures.   |
| Total  | double | ❌       | The total number of tests performed. |

# StatsRequests1

Information about the monitor's requests.

**Properties**

| Name  | Type   | Required | Description                   |
| :---- | :----- | :------- | :---------------------------- |
| Total | double | ❌       | The total number of requests. |

# Notifications

Information about the monitor's notification settings.

**Properties**

| Name        | Type              | Required | Description |
| :---------- | :---------------- | :------- | :---------- |
| OnError\_   | List`<OnError>`   | ❌       |             |
| OnFailure\_ | List`<OnFailure>` | ❌       |             |

# OnError

**Properties**

| Name  | Type   | Required | Description                                               |
| :---- | :----- | :------- | :-------------------------------------------------------- |
| Email | string | ❌       | The email address of the user to notify on monitor error. |

# OnFailure

**Properties**

| Name  | Type   | Required | Description                                                 |
| :---- | :----- | :------- | :---------------------------------------------------------- |
| Email | string | ❌       | The email address of the user to notify on monitor failure. |

# Options

Information about the monitor's option settings.

**Properties**

| Name            | Type   | Required | Description                          |
| :-------------- | :----- | :------- | :----------------------------------- |
| FollowRedirects | bool   | ❌       | If true, follow redirects enabled.   |
| RequestDelay    | double | ❌       | The monitor's request delay value.   |
| RequestTimeout  | double | ❌       | The monitor's request timeout value. |
| StrictSsl       | bool   | ❌       | If true, strict SSL enabled.         |

# MonitorSchedule2

Information about the monitor's schedule.

**Properties**

| Name     | Type   | Required | Description                                        |
| :------- | :----- | :------- | :------------------------------------------------- |
| Cron     | string | ❌       | The monitor's cron frequency value.                |
| NextRun  | string | ❌       | The date and time of monitor's next scheduled run. |
| Timezone | string | ❌       | The monitor's timezone.                            |

<!-- This file was generated by liblab | https://liblab.com/ -->
