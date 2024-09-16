// This file was generated by liblab | https://liblab.com/

using System.Text.Json.Serialization;

namespace PostmanClient.Models;

public record CreateMonitorRequest(
    [property:
        JsonPropertyName("monitor"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        CreateMonitorRequest.CreateMonitorMonitor1? Monitor = null
)
{
    public record CreateMonitorMonitor1(
        /// <value>The unique ID of the monitor's associated collection.</value>
        [property:
            JsonPropertyName("collection"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            string? Collection = null,
        /// <value>The unique ID of the monitor's associated environment.</value>
        [property:
            JsonPropertyName("environment"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            string? Environment_ = null,
        /// <value>The monitor's name.</value>
        [property:
            JsonPropertyName("name"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            string? Name = null,
        /// <value>Information about the monitor's schedule.</value>
        [property:
            JsonPropertyName("schedule"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            CreateMonitorMonitor1.MonitorSchedule1? Schedule = null
    )
    {
        /// <summary>Information about the monitor's schedule.</summary>
        public record MonitorSchedule1(
            /// <value>
            /// The monitor's run frequency, based on the given cron pattern:
            ///
            /// | Frequency | Pattern |
            /// | --------- | ------- |
            /// | Every 5 minutes | `*/5 * * * *` |
            /// | Every 30 minutes | `*/30 * * * *` |
            /// | Every hour | `0 */1 * * *` |
            /// | Every 6 hours | `0 */6 * * *` |
            /// | Every day at 5 pm | `0 17 * * *` |
            /// | Every Monday at 12 pm | `0 12 * * MON` |
            /// | Every weekday (Mon — Fri) at 6 am | `0 6 * * MON-FRI` |
            ///
            /// At this time you can only create monitors with limited schedules.
            /// </value>
            [property:
                JsonPropertyName("cron"),
                JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
            ]
                string? Cron = null,
            /// <value>The monitor's [timezone](https://en.wikipedia.org/wiki/List_of_tz_database_time_zones).</value>
            [property:
                JsonPropertyName("timezone"),
                JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
            ]
                string? Timezone = null
        );
    }
}
