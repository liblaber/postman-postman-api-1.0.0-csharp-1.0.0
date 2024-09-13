# PullRequestGet

**Properties**

| Name          | Type            | Required | Description                                                                                                                                                                                                            |
| :------------ | :-------------- | :------- | :--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| CreatedAt     | string          | ❌       | The date and time at which the pull request was created.                                                                                                                                                               |
| UpdatedAt     | string          | ❌       | The date and time at which the pull request was updated.                                                                                                                                                               |
| Id            | string          | ❌       | The pull request's ID.                                                                                                                                                                                                 |
| Title         | string          | ❌       | The pull request's title.                                                                                                                                                                                              |
| Description   | string          | ❌       | The pull request's description.                                                                                                                                                                                        |
| CreatedBy     | string          | ❌       | The ID of the user who created the pull request.                                                                                                                                                                       |
| UpdatedBy     | string          | ❌       | The ID of the user who last updated the pull request.                                                                                                                                                                  |
| Comment       | string          | ❌       | If the pull request is a `decline` status, an optoinal comment about why the pull request was declined.                                                                                                                |
| FortkType     | string          | ❌       | The type of element the pull request was forked from.                                                                                                                                                                  |
| Source\_      | Source          | ❌       | Information about the pull request's source (parent) element.                                                                                                                                                          |
| Destination\_ | Destination     | ❌       | Information about the pull request destination element.                                                                                                                                                                |
| Status        | string          | ❌       | The pull request's current review status: - `open` — The pull request is still open. - `approved` — The pull request was approved by its reviewers. - `declined` — The pull request was not approved by its reviewers. |
| Merge\_       | Merge           | ❌       | Information about the current progress of the pull request's merge.                                                                                                                                                    |
| Reviewers\_   | List`<Reviewers>` | ❌       | Information about the reviewers assigned to the pull request.                                                                                                                                                          |

# Source

Information about the pull request's source (parent) element.

**Properties**

| Name     | Type   | Required | Description                                              |
| :------- | :----- | :------- | :------------------------------------------------------- |
| Id       | string | ❌       | The pull request's source ID.                            |
| Name     | string | ❌       | The source element's name.                               |
| ForkName | string | ❌       | The name of the fork created from the source element.    |
| Exists   | bool   | ❌       | If true, whether the element is present and not deleted. |

# Destination

Information about the pull request destination element.

**Properties**

| Name   | Type   | Required | Description                                              |
| :----- | :----- | :------- | :------------------------------------------------------- |
| Id     | string | ❌       | The destination element's ID.                            |
| Name   | string | ❌       | The destination element's name.                          |
| Exists | bool   | ❌       | If true, whether the element is present and not deleted. |

# Merge

Information about the current progress of the pull request's merge.

**Properties**

| Name   | Type        | Required | Description                                                                                                                                                                                  |
| :----- | :---------- | :------- | :------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| Status | MergeStatus | ❌       | The pull request's current merge status: - `inactive` — There is no merge in progress. - `inprogress` — The pull request is currently merging. - `failed` — The pull request's merge failed. |

# MergeStatus

The pull request's current merge status: - `inactive` — There is no merge in progress. - `inprogress` — The pull request is currently merging. - `failed` — The pull request's merge failed.

**Properties**

| Name       | Type   | Required | Description  |
| :--------- | :----- | :------- | :----------- |
| Inactive   | string | ✅       | "inactive"   |
| Inprogress | string | ✅       | "inprogress" |
| Failed     | string | ✅       | "failed"     |

# Reviewers

**Properties**

| Name   | Type   | Required | Description                                                              |
| :----- | :----- | :------- | :----------------------------------------------------------------------- |
| Id     | string | ❌       | The reviewer's user ID.                                                  |
| Status | string | ❌       | The reviewer's review status response. One of: - `approved` - `declined` |

<!-- This file was generated by liblab | https://liblab.com/ -->
