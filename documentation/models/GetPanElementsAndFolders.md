# GetPanElementsAndFolders

**Properties**

| Name       | Type                         | Required | Description                                                                                                |
| :--------- | :--------------------------- | :------- | :--------------------------------------------------------------------------------------------------------- |
| Elements\_ | List<Elements>               | ❌       | Information about a Private API Network's folder elements. Elements are APIs, collections, and workspaces. |
| Folders\_  | List<Folders>                | ❌       | Information about the Private API Network's folders.                                                       |
| Meta       | GetPanElementsAndFoldersMeta | ❌       | The response's non-standard meta information.                                                              |

# Elements

**Properties**

| Name           | Type   | Required | Description                                                                                                                   |
| :------------- | :----- | :------- | :---------------------------------------------------------------------------------------------------------------------------- |
| CreatedAt      | string | ❌       | The date and time at which the element was created.                                                                           |
| CreatedBy      | long   | ❌       | The user who created the element.                                                                                             |
| UpdatedAt      | string | ❌       | The date and time at which the element was last updated.                                                                      |
| UpdatedBy      | long   | ❌       | The user who updated the element.                                                                                             |
| AddedAt        | string | ❌       | The date and time at which the element was published to Private API Network. This value is the same as the `updatedAt` value. |
| AddedBy        | long   | ❌       | The user ID of the user who published the element.                                                                            |
| Description    | string | ❌       | The element's description.                                                                                                    |
| Id             | string | ❌       | The element's ID.                                                                                                             |
| Name           | string | ❌       | The element's name.                                                                                                           |
| Summary        | string | ❌       | The element's summary.                                                                                                        |
| Type\_         | string | ❌       | The element's type.                                                                                                           |
| ParentFolderId | long   | ❌       | The element's parent folder ID.                                                                                               |
| Href           | string | ❌       | The element's HREF.                                                                                                           |

# Folders

**Properties**

| Name           | Type   | Required | Description                                        |
| :------------- | :----- | :------- | :------------------------------------------------- |
| Id             | long   | ❌       | The folder's ID.                                   |
| ParentFolderId | long   | ❌       | The folder's parent folder ID.                     |
| UpdatedAt      | string | ❌       | The date and time at which the folder was updated. |
| UpdatedBy      | long   | ❌       | The user ID of the user who updated the folder.    |
| CreatedAt      | string | ❌       | The date and time at which the folder was created. |
| CreatedBy      | long   | ❌       | The user who created the folder.                   |
| Name           | string | ❌       | The folder's name.                                 |
| Description    | string | ❌       | The folder's description.                          |
| Type\_         | string | ❌       | The element's type. This value is always `folder`. |

# GetPanElementsAndFoldersMeta

The response's non-standard meta information.

**Properties**

| Name       | Type | Required | Description                                                                                                                       |
| :--------- | :--- | :------- | :-------------------------------------------------------------------------------------------------------------------------------- |
| Limit      | long | ❌       | The maximum number of elements returned. If the value exceeds the maximum value of `1000`, then the system uses the `1000` value. |
| Offset     | long | ❌       | The zero-based offset of the first item returned.                                                                                 |
| TotalCount | long | ❌       | The total count of the `elements` and `folders` items.                                                                            |

<!-- This file was generated by liblab | https://liblab.com/ -->
