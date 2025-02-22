# GetSecretTypes

**Properties**

| Name | Type                       | Required | Description |
| :--- | :------------------------- | :------- | :---------- |
| Data | List`<GetSecretTypesData>` | ❌       |             |
| Meta | GetSecretTypesMeta         | ❌       |             |

# GetSecretTypesData

Information about the secret type.

**Properties**

| Name   | Type     | Required | Description                                                                                                                                                                                                                                                                                    |
| :----- | :------- | :------- | :--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Name   | string   | ❌       | The name of the secret type.                                                                                                                                                                                                                                                                   |
| Id     | string   | ❌       | The ID of the secret type.                                                                                                                                                                                                                                                                     |
| Type\_ | DataType | ❌       | The origin of the secret type: - `DEFAULT` — Supported by default in Postman. - `TEAM_REGEX` — A custom regex added by an Admin or Super Admin user in the **Configure Alerts** section of the [**Team Settings**](https://learning.postman.com/docs/administration/team-settings/) interface. |

# DataType

The origin of the secret type: - `DEFAULT` — Supported by default in Postman. - `TEAM_REGEX` — A custom regex added by an Admin or Super Admin user in the **Configure Alerts** section of the [**Team Settings**](https://learning.postman.com/docs/administration/team-settings/) interface.

**Properties**

| Name      | Type   | Required | Description  |
| :-------- | :----- | :------- | :----------- |
| Default\_ | string | ✅       | "DEFAULT"    |
| TeamRegex | string | ✅       | "TEAM_REGEX" |

# GetSecretTypesMeta

**Properties**

| Name  | Type | Required | Description                            |
| :---- | :--- | :------- | :------------------------------------- |
| Total | long | ❌       | The total number of supported secrets. |

<!-- This file was generated by liblab | https://liblab.com/ -->
