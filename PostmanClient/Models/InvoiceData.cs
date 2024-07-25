// This file was generated by liblab | https://liblab.com/

using System.Text.Json.Serialization;

namespace PostmanClient.Models;

/// <summary>Information about the invoice.</summary>
public record InvoiceData(
    /// <value>The invoice's ID.</value>
    [property: JsonPropertyName("id"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        string? Id = null,
    /// <value>The invoice's status.</value>
    [property:
        JsonPropertyName("status"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? Status = null,
    /// <value>The date on which the invoice was issued.</value>
    [property:
        JsonPropertyName("issuedAt"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        string? IssuedAt = null,
    /// <value>Information about the invoice's total billed amount.</value>
    [property:
        JsonPropertyName("totalAmount"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        InvoiceData.TotalAmount? TotalAmount_ = null,
    /// <value>A [JSON API spec](https://jsonapi.org/format/#document-links) object containing hypermedia links.</value>
    [property:
        JsonPropertyName("links"),
        JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
    ]
        InvoiceData.Links? Links_ = null
)
{
    /// <summary>Information about the invoice's total billed amount.</summary>
    public record TotalAmount(
        /// <value>The amount billed.</value>
        [property:
            JsonPropertyName("value"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            long? Value = null,
        /// <value>The currency of the billed amount. Currently only supports the `USD` value.</value>
        [property:
            JsonPropertyName("currency"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            string? Currency = null
    );

    /// <summary>A [JSON API spec](https://jsonapi.org/format/#document-links) object containing hypermedia links.</summary>
    public record Links(
        /// <value>An object containing web-based account references.</value>
        [property:
            JsonPropertyName("web"),
            JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
        ]
            Links.Web? Web_ = null
    )
    {
        /// <summary>An object containing web-based account references.</summary>
        public record Web(
            /// <value>A URL where you can download the invoice in PDF and view details.</value>
            [property:
                JsonPropertyName("href"),
                JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)
            ]
                string? Href = null
        );
    }
}
