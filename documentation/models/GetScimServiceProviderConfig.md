# GetScimServiceProviderConfig

Information about Postman's SCIM API configurations and supported operations.

**Properties**

| Name                    | Type                             | Required | Description                                                                                                                                   |
| :---------------------- | :------------------------------- | :------- | :-------------------------------------------------------------------------------------------------------------------------------------------- |
| Schemas                 | List`<string>`                     | ❌       | The [SCIM schema URI](https://www.iana.org/assignments/scim/scim.xhtml).                                                                      |
| DocumentationUri        | string                           | ❌       | A link to the URI's documentation.                                                                                                            |
| Patch\_                 | Patch                            | ❌       | Information about patch configuration.                                                                                                        |
| Bulk\_                  | Bulk                             | ❌       | Information about bulk configuration.                                                                                                         |
| Filter\_                | Filter                           | ❌       | Information about the filter configuration.                                                                                                   |
| ChangePassword\_        | ChangePassword                   | ❌       | Information about the change password configuration.                                                                                          |
| Sort                    | GetScimServiceProviderConfigSort | ❌       | Information about the sort configuration.                                                                                                     |
| AuthenticationSchemes\_ | List`<AuthenticationSchemes>`      | ❌       | A list of authentication schemes.                                                                                                             |
| Etag\_                  | Etag                             | ❌       | Information about the [entity tag](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/ETag) (Etag) HTTP response header configuration. |
| Meta                    | GetScimServiceProviderConfigMeta | ❌       | The response's non-standard meta information.                                                                                                 |

# Patch

Information about patch configuration.

**Properties**

| Name      | Type | Required | Description                        |
| :-------- | :--- | :------- | :--------------------------------- |
| Supported | bool | ❌       | If true, the feature is supported. |

# Bulk

Information about bulk configuration.

**Properties**

| Name           | Type   | Required | Description                                                         |
| :------------- | :----- | :------- | :------------------------------------------------------------------ |
| MaxOperations  | double | ❌       | The total number of maximum operations allowed for bulk operations. |
| MaxPayloadSize | double | ❌       | The maximum payload allowed for bulk operations.                    |
| Supported      | bool   | ❌       | If true, the feature is supported.                                  |

# Filter

Information about the filter configuration.

**Properties**

| Name       | Type   | Required | Description                                                        |
| :--------- | :----- | :------- | :----------------------------------------------------------------- |
| MaxResults | double | ❌       | The total number of maximum results allowed for filter operations. |
| Supported  | bool   | ❌       | If true, the feature is supported.                                 |

# ChangePassword

Information about the change password configuration.

**Properties**

| Name      | Type | Required | Description                        |
| :-------- | :--- | :------- | :--------------------------------- |
| Supported | bool | ❌       | If true, the feature is supported. |

# GetScimServiceProviderConfigSort

Information about the sort configuration.

**Properties**

| Name      | Type | Required | Description                        |
| :-------- | :--- | :------- | :--------------------------------- |
| Supported | bool | ❌       | If true, the feature is supported. |

# AuthenticationSchemes

Information about the scheme.

**Properties**

| Name        | Type   | Required | Description                                         |
| :---------- | :----- | :------- | :-------------------------------------------------- |
| Description | string | ❌       | The scheme's description.                           |
| Name        | string | ❌       | The scheme's friendly name.                         |
| SpecUri     | string | ❌       | A link to the scheme's specification documentation. |
| Type\_      | string | ❌       | The scheme's type.                                  |

# Etag

Information about the [entity tag](https://developer.mozilla.org/en-US/docs/Web/HTTP/Headers/ETag) (Etag) HTTP response header configuration.

**Properties**

| Name      | Type | Required | Description                        |
| :-------- | :--- | :------- | :--------------------------------- |
| Supported | bool | ❌       | If true, the feature is supported. |

# GetScimServiceProviderConfigMeta

The response's non-standard meta information.

**Properties**

| Name         | Type   | Required | Description |
| :----------- | :----- | :------- | :---------- |
| ResourceType | string | ❌       |             |
| Location     | string | ❌       |             |

<!-- This file was generated by liblab | https://liblab.com/ -->
