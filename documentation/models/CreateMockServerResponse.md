# CreateMockServerResponse

**Properties**

| Name           | Type                                   | Required | Description |
| :------------- | :------------------------------------- | :------- | :---------- |
| ServerResponse | CreateMockServerResponseServerResponse | ❌       |             |

# CreateMockServerResponseServerResponse

**Properties**

| Name       | Type                           | Required | Description                                                                                           |
| :--------- | :----------------------------- | :------- | :---------------------------------------------------------------------------------------------------- |
| Name       | string                         | ✅       | The server response's name.                                                                           |
| StatusCode | long                           | ✅       | The server response's 5xx HTTP response code. This property only accepts 5xx values.                  |
| Headers    | List`<ServerResponseHeaders1>` | ❌       | The server response's request headers, such as Content-Type, Accept, encoding, and other information. |
| Language   | ServerResponseLanguage1        | ❌       | The server response's body language type.                                                             |
| Body       | string                         | ❌       | The server response's body that returns when calling the mock server.                                 |

# ServerResponseHeaders1

**Properties**

| Name  | Type   | Required | Description                     |
| :---- | :----- | :------- | :------------------------------ |
| Key   | string | ❌       | The request header's key value. |
| Value | string | ❌       | The request header's value.     |

# ServerResponseLanguage1

The server response's body language type.

**Properties**

| Name       | Type   | Required | Description  |
| :--------- | :----- | :------- | :----------- |
| Text       | string | ✅       | "text"       |
| Javascript | string | ✅       | "javascript" |
| Json       | string | ✅       | "json"       |
| Html       | string | ✅       | "html"       |
| Xml        | string | ✅       | "xml"        |

<!-- This file was generated by liblab | https://liblab.com/ -->
