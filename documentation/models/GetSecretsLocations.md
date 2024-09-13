# GetSecretsLocations

**Properties**

| Name | Type                          | Required | Description |
| :--- | :---------------------------- | :------- | :---------- |
| Data | List`<GetSecretsLocationsData>` | ❌       |             |
| Meta | GetSecretsLocationsMeta       | ❌       |             |

# GetSecretsLocationsData

Information about the secret finding locations.

**Properties**

| Name              | Type             | Required | Description                                                                                                                                                                                            |
| :---------------- | :--------------- | :------- | :----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| IsResourceDeleted | bool             | ❌       | If true, the resource in which the secret was found was deleted.                                                                                                                                       |
| LeakedBy          | long             | ❌       | The ID of the user who exposed the secret.                                                                                                                                                             |
| Location          | string           | ❌       | The location where the secret was found.                                                                                                                                                               |
| Occurrences       | long             | ❌       | The number of times the secret occurs in the location.                                                                                                                                                 |
| ParentResourceId  | string           | ❌       | The parent resource's unique ID. If the resource is a request, folder, or example, this value is a collection ID. If the resource is a collection, globals, or environment, this is the resource's ID. |
| ResourceId        | string           | ❌       | The unique ID of the resource where the secret was detected.                                                                                                                                           |
| ResourceType      | DataResourceType | ❌       | The type of resource in which the secret was detected.                                                                                                                                                 |
| DetectedAt        | string           | ❌       | The date and time at which the secret was detected.                                                                                                                                                    |
| Url               | string           | ❌       | The URL to the resource that contains the secret.                                                                                                                                                      |

# DataResourceType

The type of resource in which the secret was detected.

**Properties**

| Name          | Type   | Required | Description   |
| :------------ | :----- | :------- | :------------ |
| Collection    | string | ✅       | "collection"  |
| Folder        | string | ✅       | "folder"      |
| Request\_     | string | ✅       | "request"     |
| Example       | string | ✅       | "example"     |
| Environment\_ | string | ✅       | "environment" |
| Globals       | string | ✅       | "globals"     |
| Api           | string | ✅       | "api"         |

# GetSecretsLocationsMeta

**Properties**

| Name             | Type               | Required | Description                                                                 |
| :--------------- | :----------------- | :------- | :-------------------------------------------------------------------------- |
| ActivityFeed\_   | List`<ActivityFeed>` | ❌       | The history of the secret's resolution status changes.                      |
| Cursor           | string             | ❌       | The pointer to the first record of the set of paginated results.            |
| Limit            | long               | ❌       | The maximum number of rows to return in the response.                       |
| NextCursor       | string             | ❌       | The Base64-encoded value that points to the next record in the results set. |
| ObfuscatedSecret | string             | ❌       | The secret's obfuscated value.                                              |
| SecretHash       | string             | ❌       | The secret's SHA-256 hash.                                                  |
| SecretType       | string             | ❌       | The type of thesecret.                                                      |
| Total            | long               | ❌       | The total number of discovered secret locations.                            |

# ActivityFeed

**Properties**

| Name       | Type               | Required | Description                                                                                                                                                                                                                                                                                                                                 |
| :--------- | :----------------- | :------- | :------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| ResolvedAt | string             | ❌       | The date and time at which the resolution status was last updated.                                                                                                                                                                                                                                                                          |
| ResolvedBy | long               | ❌       | The ID of the user that updated the secret's resolution status.                                                                                                                                                                                                                                                                             |
| Status     | ActivityFeedStatus | ❌       | The secret's current resolution status: - `ACTIVE` — The secret is active. - `FALSE_POSITIVE` — The discovered secret is not an actual secret. - `REVOKED` — The secret is valid, but the user rotated their key to resolve the issue. - `ACCEPTED_RISK` — The Secret Scanner found the secret, but user accepts the risk of publishing it. |

# ActivityFeedStatus

The secret's current resolution status: - `ACTIVE` — The secret is active. - `FALSE_POSITIVE` — The discovered secret is not an actual secret. - `REVOKED` — The secret is valid, but the user rotated their key to resolve the issue. - `ACCEPTED_RISK` — The Secret Scanner found the secret, but user accepts the risk of publishing it.

**Properties**

| Name          | Type   | Required | Description      |
| :------------ | :----- | :------- | :--------------- |
| FalsePositive | string | ✅       | "FALSE_POSITIVE" |
| AcceptedRisk  | string | ✅       | "ACCEPTED_RISK"  |
| Revoked       | string | ✅       | "REVOKED"        |
| Active        | string | ✅       | "ACTIVE"         |

<!-- This file was generated by liblab | https://liblab.com/ -->
