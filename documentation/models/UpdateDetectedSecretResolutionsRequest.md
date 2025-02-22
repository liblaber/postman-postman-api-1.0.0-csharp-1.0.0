# UpdateDetectedSecretResolutionsRequest

**Properties**

| Name        | Type                               | Required | Description                                                                                                                                                                                                                                                                                              |
| :---------- | :--------------------------------- | :------- | :------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Resolution  | UpdateSecretResolutionsResolution1 | ✅       | The secret's updated resolution status: - `FALSE_POSITIVE` — The discovered secret is not an actual secret. - `REVOKED` — The secret is valid, but the user rotated their key to resolve the issue. - `ACCEPTED_RISK` — The Secret Scanner found the secret, but user accepts the risk of publishing it. |
| WorkspaceId | string                             | ✅       | The ID of the workspace that contains the secret.                                                                                                                                                                                                                                                        |

# UpdateSecretResolutionsResolution1

The secret's updated resolution status: - `FALSE_POSITIVE` — The discovered secret is not an actual secret. - `REVOKED` — The secret is valid, but the user rotated their key to resolve the issue. - `ACCEPTED_RISK` — The Secret Scanner found the secret, but user accepts the risk of publishing it.

**Properties**

| Name          | Type   | Required | Description      |
| :------------ | :----- | :------- | :--------------- |
| FalsePositive | string | ✅       | "FALSE_POSITIVE" |
| Revoked       | string | ✅       | "REVOKED"        |
| AcceptedRisk  | string | ✅       | "ACCEPTED_RISK"  |

<!-- This file was generated by liblab | https://liblab.com/ -->
