# GetMocks

**Properties**

| Name  | Type                | Required | Description |
| :---- | :------------------ | :------- | :---------- |
| Mocks | List<GetMocksMocks> | ❌       |             |

# GetMocksMocks

Information about the mock servers.

**Properties**

| Name          | Type        | Required | Description                                                                                                                        |
| :------------ | :---------- | :------- | :--------------------------------------------------------------------------------------------------------------------------------- |
| Id            | string      | ❌       | The mock server's ID.                                                                                                              |
| Owner         | string      | ❌       | The ID of mock server's owner.                                                                                                     |
| Uid           | string      | ❌       | The mock server's unique ID.                                                                                                       |
| Collection    | string      | ❌       | The unique ID of the mock's associated collection.                                                                                 |
| MockUrl       | string      | ❌       | The mock server URL.                                                                                                               |
| Config        | MocksConfig | ❌       | Information about the mock server's configuration.                                                                                 |
| CreatedAt     | string      | ❌       | The date and time at which the mock server was created.                                                                            |
| Environment\_ | string      | ❌       | The mock server's associated environment ID.                                                                                       |
| IsPublic      | bool        | ❌       | If true, the mock server is public and visible to all users. This field does not indicate the mock server's access control status. |
| Name          | string      | ❌       | The mock server's name.                                                                                                            |
| UpdatedAt     | string      | ❌       | The date and time at which the mock server was last updated.                                                                       |

# MocksConfig

Information about the mock server's configuration.

**Properties**

| Name             | Type         | Required | Description                                                                                                                                        |
| :--------------- | :----------- | :------- | :------------------------------------------------------------------------------------------------------------------------------------------------- |
| Delay\_          | Delay        | ❌       | Information about the mock server's simulated network delay settings. This returns a null value if there are no configured network delay settings. |
| Headers          | List<string> | ❌       | A list of the mock server's headers.                                                                                                               |
| MatchBody        | bool         | ❌       | If true, match the request body.                                                                                                                   |
| MatchQueryParams | bool         | ❌       | If true, match query parameters.                                                                                                                   |
| MatchWildcards   | bool         | ❌       | If true, use wildcard variable matching.                                                                                                           |
| ServerResponseId | string       | ❌       | The ID of mock server's default response for requests. All calls to the mock server will return the defined response.                              |

# Delay

Information about the mock server's simulated network delay settings. This returns a null value if there are no configured network delay settings.

**Properties**

| Name     | Type      | Required | Description                                                                                                                                       |
| :------- | :-------- | :------- | :------------------------------------------------------------------------------------------------------------------------------------------------ |
| Type\_   | DelayType | ❌       | The type of simulated delay value: - `fixed` — The delay value is a fixed value.                                                                  |
| Preset\_ | Preset    | ❌       | The simulated fixed network delay value: - `1` — 2G (300 ms). - `2` — 3G (100 ms). The object does not return this value for custom delay values. |
| Duration | long      | ❌       | The configured delay, in milliseconds.                                                                                                            |

# DelayType

The type of simulated delay value: - `fixed` — The delay value is a fixed value.

**Properties**

| Name    | Type   | Required | Description |
| :------ | :----- | :------- | :---------- |
| Fixed\_ | string | ✅       | "fixed"     |

# Preset

The simulated fixed network delay value: - `1` — 2G (300 ms). - `2` — 3G (100 ms). The object does not return this value for custom delay values.

**Properties**

| Name | Type   | Required | Description |
| :--- | :----- | :------- | :---------- |
| \_1  | string | ✅       | "1"         |
| \_2  | string | ✅       | "2"         |

<!-- This file was generated by liblab | https://liblab.com/ -->
