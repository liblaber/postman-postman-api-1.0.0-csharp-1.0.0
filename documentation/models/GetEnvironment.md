# GetEnvironment

**Properties**

| Name          | Type                      | Required | Description |
| :------------ | :------------------------ | :------- | :---------- |
| Environment\_ | GetEnvironmentEnvironment | ❌       |             |

# GetEnvironmentEnvironment

**Properties**

| Name      | Type                       | Required | Description                                                  |
| :-------- | :------------------------- | :------- | :----------------------------------------------------------- |
| Id        | string                     | ❌       | The environment's ID.                                        |
| Name      | string                     | ❌       | The environment's name.                                      |
| Owner     | string                     | ❌       | The ID of environment's owner.                               |
| CreatedAt | string                     | ❌       | The date and time at which the environment was created.      |
| UpdatedAt | string                     | ❌       | The date and time at which the environment was last updated. |
| Values    | List`<EnvironmentValues2>` | ❌       | Information about the environment's variables.               |
| IsPublic  | bool                       | ❌       | If true, the environment is public and visible to all users. |

# EnvironmentValues2

**Properties**

| Name    | Type        | Required | Description                       |
| :------ | :---------- | :------- | :-------------------------------- |
| Enabled | bool        | ❌       | If true, the variable is enabled. |
| Key     | string      | ❌       | The variable's name.              |
| Value   | string      | ❌       | The variable's value.             |
| Type\_  | ValuesType2 | ❌       | The variable type.                |

# ValuesType2

The variable type.

**Properties**

| Name      | Type   | Required | Description |
| :-------- | :----- | :------- | :---------- |
| Secret    | string | ✅       | "secret"    |
| Default\_ | string | ✅       | "default"   |
| Any       | string | ✅       | "any"       |

<!-- This file was generated by liblab | https://liblab.com/ -->
