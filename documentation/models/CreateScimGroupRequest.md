# CreateScimGroupRequest

**Properties**

| Name        | Type                            | Required | Description                                                              |
| :---------- | :------------------------------ | :------- | :----------------------------------------------------------------------- |
| Schemas     | List`<string>`                  | ❌       | The [SCIM schema URI](https://www.iana.org/assignments/scim/scim.xhtml). |
| DisplayName | string                          | ❌       | The group's display name.                                                |
| Members     | List`<CreateScimGroupMembers1>` | ❌       |                                                                          |

# CreateScimGroupMembers1

An object containing the SCIM users to assign to the group.

**Properties**

| Name    | Type   | Required | Description              |
| :------ | :----- | :------- | :----------------------- |
| Value   | string | ❌       | The user's SCIM ID.      |
| Display | string | ❌       | The user's display name. |

<!-- This file was generated by liblab | https://liblab.com/ -->
