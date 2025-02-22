# GetScimUserResourceOkResponse

**Properties**

| Name       | Type                  | Required | Description                                                              |
| :--------- | :-------------------- | :------- | :----------------------------------------------------------------------- |
| Schemas    | List`<string>`        | ❌       | The [SCIM schema URI](https://www.iana.org/assignments/scim/scim.xhtml). |
| Id         | string                | ❌       | The team member's SCIM ID.                                               |
| UserName   | string                | ❌       | The team member's SCIM username.                                         |
| Name       | ScimUserResourceName2 | ❌       | Information about the Postman team member.                               |
| ExternalId | string                | ❌       | The team member's external ID.                                           |
| Active     | bool                  | ❌       | If true, the team member is active.                                      |
| Meta       | ScimUserResourceMeta2 | ❌       | The response's non-standard meta information.                            |

# ScimUserResourceName2

Information about the Postman team member.

**Properties**

| Name       | Type   | Required | Description                   |
| :--------- | :----- | :------- | :---------------------------- |
| GivenName  | string | ❌       | The team member's first name. |
| FamilyName | string | ❌       | The team member's last name.  |

# ScimUserResourceMeta2

The response's non-standard meta information.

**Properties**

| Name         | Type   | Required | Description                                                   |
| :----------- | :----- | :------- | :------------------------------------------------------------ |
| ResourceType | string | ❌       | The resource type.                                            |
| Created      | string | ❌       | The date and time at which the team member was created.       |
| LastModified | string | ❌       | The date and time at which the team member was last modified. |

<!-- This file was generated by liblab | https://liblab.com/ -->
