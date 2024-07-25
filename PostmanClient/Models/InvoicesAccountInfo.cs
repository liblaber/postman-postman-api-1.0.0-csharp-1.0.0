// This file was generated by liblab | https://liblab.com/

using System.Text.Json.Serialization;
using PostmanClient.Json;

namespace PostmanClient.Models;

/// <summary>Information about the account.</summary>
public record InvoicesAccountInfo(
    /// <value>The email address to which invoices are sent.</value>
    [property:
        JsonPropertyName("billingEmail"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? BillingEmail = null,
    /// <value>The account's ID.</value>
    [property: JsonPropertyName("id"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        long? Id = null,
    /// <value>
    /// The account's current state:
    /// - `FREE`
    /// - `PAID`
    /// - `EXPIRED_TRIAL`
    /// - `OVERDUE`
    /// - `SUSPENDED`
    /// - `BLOCKED`
    /// - `PAYMENT_DISPUTED`
    /// </value>
    [property:
        JsonPropertyName("state"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? State = null,
    /// <value>The team's ID associated with the account.</value>
    [property:
        JsonPropertyName("teamId"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        long? TeamId = null,
    /// <value>
    /// The sales channel from which the account was created:
    /// - `SELF_SERVE` — The user purchased the account plan.
    /// - `SALES_SERVE` — The account was purchased through the Postman sales team process.
    /// </value>
    [property:
        JsonPropertyName("salesChannel"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        InvoicesAccountInfo.SalesChannel? SalesChannel_ = null,
    /// <value>Information about the team's slots.</value>
    [property:
        JsonPropertyName("slots"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        InvoicesAccountInfo.Slots? Slots_ = null
)
{
    /// <summary>
    /// The sales channel from which the account was created:
    /// - `SELF_SERVE` — The user purchased the account plan.
    /// - `SALES_SERVE` — The account was purchased through the Postman sales team process.
    /// </summary>
    public record SalesChannel : ValueEnum<string>
    {
        internal SalesChannel(string value)
            : base(value) { }

        public SalesChannel()
            : base("SELF_SERVE") { }

        public static SalesChannel SelfServe = new("SELF_SERVE");
        public static SalesChannel SalesServe = new("SALES_SERVE");
    }

    /// <summary>Information about the team's slots.</summary>
    public record Slots(
        /// <value>The number of the team's available slots.</value>
        [property:
            JsonPropertyName("available"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            long? Available = null,
        /// <value>The number of currently-billed team members.</value>
        [property:
            JsonPropertyName("consumed"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            long? Consumed = null,
        /// <value>The total number of slots available to the team.</value>
        [property:
            JsonPropertyName("total"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            long? Total = null,
        /// <value>The number of unbilled slots if [auto-flex billing](https://learning.postman.com/auto-flex-policy/) is available.</value>
        [property:
            JsonPropertyName("unbilled"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            long? Unbilled = null
    );
}
