# UpdateMonitorRequest

**Properties**

| Name    | Type                  | Required | Description |
| :------ | :-------------------- | :------- | :---------- |
| Monitor | UpdateMonitorMonitor1 | ❌       |             |

# UpdateMonitorMonitor1

**Properties**

| Name     | Type             | Required | Description                               |
| :------- | :--------------- | :------- | :---------------------------------------- |
| Name     | string           | ❌       | The monitor's name.                       |
| Schedule | MonitorSchedule3 | ❌       | Information about the monitor's schedule. |

# MonitorSchedule3

Information about the monitor's schedule.

**Properties**

| Name     | Type   | Required | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                     |
| :------- | :----- | :------- | :---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Cron     | string | ❌       | The monitor's run frequency, based on the given cron pattern: \| Frequency \| Pattern \| \| --------- \| ------- \| \| Every 5 minutes \| `*/5 * * * *` \| \| Every 30 minutes \| `*/30 * * * *` \| \| Every hour \| `0 */1 * * *` \| \| Every 6 hours \| `0 */6 * * *` \| \| Every day at 5 pm \| `0 17 * * *` \| \| Every Monday at 12 pm \| `0 12 * * MON` \| \| Every weekday (Mon — Fri) at 6 am \| `0 6 * * MON-FRI` \| At this time you can only create monitors with limited schedules. |
| Timezone | string | ❌       | The monitor's [timezone](https://en.wikipedia.org/wiki/List_of_tz_database_time_zones).                                                                                                                                                                                                                                                                                                                                                                                                         |

<!-- This file was generated by liblab | https://liblab.com/ -->
