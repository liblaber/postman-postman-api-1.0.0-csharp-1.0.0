# DetectedSecretsQueriesOkResponse

**Properties**

| Name | Type                               | Required | Description                                            |
| :--- | :--------------------------------- | :------- | :----------------------------------------------------- |
| Data | List`<DetectedSecretsQueriesData>` | ❌       |                                                        |
| Meta | DetectedSecretsQueriesMeta         | ❌       | The response's meta information for paginated results. |

# DetectedSecretsQueriesData

Information about the secret finding.

**Properties**

| Name                | Type                    | Required | Description                                                                                                                                                                                                                                                                                                                      |
| :------------------ | :---------------------- | :------- | :------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| ObfuscatedSecret    | string                  | ❌       | The secret's obfuscated value.                                                                                                                                                                                                                                                                                                   |
| Occurrences         | double                  | ❌       | The number of times the secret was found in the workspace.                                                                                                                                                                                                                                                                       |
| Resolution          | DataResolution          | ❌       | The secret's current status: - `ACTIVE` — The secret is active. - `FALSE_POSITIVE` — The discovered secret is not an actual secret. - `REVOKED` — The secret is valid, but the user rotated their key to resolve the issue. - `ACCEPTED_RISK` — The Secret Scanner found the secret, but user accepts the risk of publishing it. |
| SecretHash          | string                  | ❌       | The SHA-256 hash of the detected secret.                                                                                                                                                                                                                                                                                         |
| SecretId            | string                  | ❌       | The detected secret's ID.                                                                                                                                                                                                                                                                                                        |
| SecretType          | string                  | ❌       | The type of the secret.                                                                                                                                                                                                                                                                                                          |
| DetectedAt          | string                  | ❌       | The date and time at which the secret was first detected.                                                                                                                                                                                                                                                                        |
| WorkspaceId         | string                  | ❌       | The ID of the workspace that contains the secret.                                                                                                                                                                                                                                                                                |
| WorkspaceVisibility | DataWorkspaceVisibility | ❌       | The workspace's [visibility setting](https://learning.postman.com/docs/collaborating-in-postman/using-workspaces/managing-workspaces/#changing-workspace-visibility).                                                                                                                                                            |

# DataResolution

The secret's current status: - `ACTIVE` — The secret is active. - `FALSE_POSITIVE` — The discovered secret is not an actual secret. - `REVOKED` — The secret is valid, but the user rotated their key to resolve the issue. - `ACCEPTED_RISK` — The Secret Scanner found the secret, but user accepts the risk of publishing it.

**Properties**

| Name          | Type   | Required | Description      |
| :------------ | :----- | :------- | :--------------- |
| FalsePositive | string | ✅       | "FALSE_POSITIVE" |
| AcceptedRisk  | string | ✅       | "ACCEPTED_RISK"  |
| Revoked       | string | ✅       | "REVOKED"        |
| Active        | string | ✅       | "ACTIVE"         |

# DataWorkspaceVisibility

The workspace's [visibility setting](https://learning.postman.com/docs/collaborating-in-postman/using-workspaces/managing-workspaces/#changing-workspace-visibility).

**Properties**

| Name      | Type   | Required | Description |
| :-------- | :----- | :------- | :---------- |
| Personal  | string | ✅       | "personal"  |
| Private\_ | string | ✅       | "private"   |
| Team      | string | ✅       | "team"      |
| Public\_  | string | ✅       | "public"    |

# DetectedSecretsQueriesMeta

The response's meta information for paginated results.

**Properties**

| Name       | Type   | Required | Description                                                                                                                                                 |
| :--------- | :----- | :------- | :---------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Limit      | double | ❌       | The maximum number of records in the paginated response.                                                                                                    |
| NextCursor | string | ❌       | The pagination cursor that points to the next record in the results set.                                                                                    |
| Total      | double | ❌       | The number of records that match the defined criteria. This will only be present if the `include` query parameter is specified with the `meta.total` value. |

<!-- This file was generated by liblab | https://liblab.com/ -->
