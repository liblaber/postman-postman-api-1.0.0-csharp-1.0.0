# InvoiceData

Information about the invoice.

**Properties**

| Name          | Type        | Required | Description                                                                                       |
| :------------ | :---------- | :------- | :------------------------------------------------------------------------------------------------ |
| Id            | string      | ❌       | The invoice's ID.                                                                                 |
| Status        | string      | ❌       | The invoice's status.                                                                             |
| IssuedAt      | string      | ❌       | The date on which the invoice was issued.                                                         |
| TotalAmount\_ | TotalAmount | ❌       | Information about the invoice's total billed amount.                                              |
| Links\_       | Links       | ❌       | A [JSON API spec](https://jsonapi.org/format/#document-links) object containing hypermedia links. |

# TotalAmount

Information about the invoice's total billed amount.

**Properties**

| Name     | Type   | Required | Description                                                                 |
| :------- | :----- | :------- | :-------------------------------------------------------------------------- |
| Value    | long   | ❌       | The amount billed.                                                          |
| Currency | string | ❌       | The currency of the billed amount. Currently only supports the `USD` value. |

# Links

A [JSON API spec](https://jsonapi.org/format/#document-links) object containing hypermedia links.

**Properties**

| Name  | Type | Required | Description                                        |
| :---- | :--- | :------- | :------------------------------------------------- |
| Web\_ | Web  | ❌       | An object containing web-based account references. |

# Web

An object containing web-based account references.

**Properties**

| Name | Type   | Required | Description                                                       |
| :--- | :----- | :------- | :---------------------------------------------------------------- |
| Href | string | ❌       | A URL where you can download the invoice in PDF and view details. |

<!-- This file was generated by liblab | https://liblab.com/ -->
