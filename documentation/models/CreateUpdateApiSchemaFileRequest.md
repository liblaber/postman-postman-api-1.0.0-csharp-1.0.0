# CreateUpdateApiSchemaFileRequest

Information about schema file.

**Properties**

| Name    | Type                          | Required | Description                                                                                 |
| :------ | :---------------------------- | :------- | :------------------------------------------------------------------------------------------ |
| Name    | string                        | ❌       | The schema file's name.                                                                     |
| Root    | CreateUpdateApiSchemaFileRoot | ❌       | Information about the schema's root file. This tag only applies to protobuf specifications. |
| Content | string                        | ❌       | The schema file's content.                                                                  |

# CreateUpdateApiSchemaFileRoot

Information about the schema's root file. This tag only applies to protobuf specifications.

**Properties**

| Name    | Type | Required | Description                             |
| :------ | :--- | :------- | :-------------------------------------- |
| Enabled | bool | ❌       | If true, tag the file as the root file. |

<!-- This file was generated by liblab | https://liblab.com/ -->
