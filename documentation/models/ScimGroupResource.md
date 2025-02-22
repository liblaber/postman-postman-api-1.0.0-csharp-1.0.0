# ScimGroupResource

The SCIM group resource object.

**Properties**

| Name        | Type                             | Required | Description                                                              |
| :---------- | :------------------------------- | :------- | :----------------------------------------------------------------------- |
| Schemas     | List`<string>`                   | ❌       | The [SCIM schema URI](https://www.iana.org/assignments/scim/scim.xhtml). |
| Id          | string                           | ❌       | The group's SCIM ID.                                                     |
| DisplayName | string                           | ❌       | The group's display name.                                                |
| Members     | List`<ScimGroupResourceMembers>` | ❌       | A list of the group's members.                                           |
| ExternalId  | string                           | ❌       | The group's external ID.                                                 |
| Meta        | ScimGroupResourceMeta            | ❌       | The response's non-standard meta information.                            |

# ScimGroupResourceMembers

Information about the group's members.

**Properties**

| Name    | Type   | Required | Description                  |
| :------ | :----- | :------- | :--------------------------- |
| Value   | string | ❌       | The resource value.          |
| Display | string | ❌       | The resource's display name. |

# ScimGroupResourceMeta

The response's non-standard meta information.

**Properties**

| Name         | Type   | Required | Description                                             |
| :----------- | :----- | :------- | :------------------------------------------------------ |
| ResourceType | string | ❌       | The resource type.                                      |
| Created      | string | ❌       | The date and time at which the group was created.       |
| LastModified | string | ❌       | The date and time at which the group was last modified. |

<!-- This file was generated by liblab | https://liblab.com/ -->
