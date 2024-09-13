# ApiService

A list of all methods in the `ApiService` service. Click on the method name to view detailed information about that method.

| Methods                                                           | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                |
| :---------------------------------------------------------------- | :----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| [GetApisAsync](#getapisasync)                                     | Gets information about all APIs in a workspace.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            |
| [CreateApiAsync](#createapiasync)                                 | Creates an API.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            |
| [GetApiAsync](#getapiasync)                                       | Gets information about an API. **Note:** - Git-connected APIs will only return the `versions` and `gitInfo` query responses. This is because schema and collection information is stored in the connected Git repository. The `gitInfo` object only lists the repository and folder locations of the files. - API viewers can only use the `versions` option in the `include` query parameter.                                                                                                                                                                                                                                                                                             |
| [UpdateApiAsync](#updateapiasync)                                 | Updates an API.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            |
| [DeleteApiAsync](#deleteapiasync)                                 | Deletes an API.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                            |
| [AddApiCollectionAsync](#addapicollectionasync)                   | Adds a collection to an API. To do this, use the following `operationType` values: - `COPY_COLLECTION` — Copies a collection from the workspace and adds it to an API. - `CREATE_NEW` — Creates a new collection by providing the new collection's content. - `GENERATE_FROM_SCHEMA` — Generates the collection from an API schema. - `options` — An object that contains advanced creation options and their values. You can find a complete list of properties and their values in Postman's [OpenAPI 3.0 to Postman Collection v2.1.0 Converter OPTIONS documentation](https://github.com/postmanlabs/openapi-to-postman/blob/develop/OPTIONS.md). These properties are case-sensitive. |
| [GetApiCollectionAsync](#getapicollectionasync)                   | Gets a collection attached to an API. You can use the `versionId` query parameter to get a collection published in a version. **Note:** The `versionId` query parameter is a required parameter for API viewers.                                                                                                                                                                                                                                                                                                                                                                                                                                                                           |
| [SyncCollectionWithSchemaAsync](#synccollectionwithschemaasync)   | Syncs a collection attached to an API with the API schema. This is an asynchronous endpoint that returns an HTTP `202 Accepted` response. The response contains a polling link to the `/apis/{apiId}/tasks/{taskId}` endpoint in the `Location` header. **Note:** This endpoint only supports the OpenAPI 3 schema type.                                                                                                                                                                                                                                                                                                                                                                   |
| [GetApiCommentsAsync](#getapicommentsasync)                       | Gets all comments left by users in an API.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 |
| [CreateApiCommentAsync](#createapicommentasync)                   | Creates a comment on an API. **Note:** This endpoint accepts a max of 10,000 characters.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   |
| [UpdateApiCommentAsync](#updateapicommentasync)                   | Updates a comment on an API. **Note:** This endpoint accepts a max of 10,000 characters.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   |
| [DeleteApiCommentAsync](#deleteapicommentasync)                   | Deletes a comment from an API. On success, this returns an HTTP `204 No Content` response. **Note:** Deleting the first comment of a thread deletes all the comments in the thread.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        |
| [CreateApiSchemaAsync](#createapischemaasync)                     | Creates a schema for an API.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               |
| [GetApiSchemaAsync](#getapischemaasync)                           | Gets information about API schema. You can use the `versionId` query parameter to get a schema published in an API version. You can use this API to do the following: - Get a schema's metadata. - Get all the files in a schema. This only returns the first file in the schema. The endpoint response contains a link to the next set of response results. - Get a schema's contents in multi-file or bundled format. **Note:** The `versionId` query parameter is a required parameter for API viewers.                                                                                                                                                                                 |
| [GetApiSchemaFilesAsync](#getapischemafilesasync)                 | Gets the files in an API schema. You can use the `versionId` query parameter to get schema files published in an API version. **Note:** The `versionId` query parameter is a required parameter for API viewers.                                                                                                                                                                                                                                                                                                                                                                                                                                                                           |
| [GetApiSchemaFileContentsAsync](#getapischemafilecontentsasync)   | Gets an API schema file contents at the defined path. You can use the `versionId` query parameter to get schema file contents published in an API version. **Note:** The `versionId` query parameter is a required parameter for API viewers.                                                                                                                                                                                                                                                                                                                                                                                                                                              |
| [CreateUpdateApiSchemaFileAsync](#createupdateapischemafileasync) | Creates or updates an API schema file. **Note:** - If the provided file path exists, the file will be updated with the new contents. - If the provided file path does not exist, then a new schema file will be created. - If the file path contains a `/` (forward slash) character, then a folder is created. For example, if the file path is the `dir/schema.json` value, then a `dir` folder is created with the `schema.json` file inside.                                                                                                                                                                                                                                           |
| [DeleteApiSchemaFileAsync](#deleteapischemafileasync)             | Deletes a file in an API schema.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                           |
| [GetStatusOfAnAsyncTaskAsync](#getstatusofanasynctaskasync)       | Gets the status of an asynchronous task.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   |
| [GetApiVersionsAsync](#getapiversionsasync)                       | Gets all the published versions of an API.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 |
| [CreateApiVersionAsync](#createapiversionasync)                   | Creates a new API version asynchronously and immediately returns an HTTP `202 Accepted` response. The response contains a polling link to the task status API in the `Location` header. This endpoint is equivalent to publishing a version in Postman app, which is the snapshot of API collections and schema at a given point in time.                                                                                                                                                                                                                                                                                                                                                  |
| [GetApiVersionAsync](#getapiversionasync)                         | Gets information about an API version. **Note:** - For API editors, this endpoint returns an HTTP `302 Found` status code when the version status is pending. It also returns the `/apis/{apiId}/tasks/{taskId}` task status response header. - For API viewers, this endpoint returns an HTTP `404 Not Found` when the version status is pending.                                                                                                                                                                                                                                                                                                                                         |
| [UpdateApiVersionAsync](#updateapiversionasync)                   | Updates an API version. **Note:** This endpoint returns an HTTP `404 Not Found` response when an API version is pending publication.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       |
| [DeleteApiVersionAsync](#deleteapiversionasync)                   | Deletes an API version. **Note:** This endpoint returns an HTTP `404 Not Found` response when an API version is pending publication.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       |

## GetApisAsync

Gets information about all APIs in a workspace.

- HTTP Method: `GET`
- Endpoint: `/apis`

**Parameters**

| Name        | Type   | Required | Description                                                                                                                                |
| :---------- | :----- | :------- | :----------------------------------------------------------------------------------------------------------------------------------------- |
| workspaceId | string | ✅       | The workspace's ID.                                                                                                                        |
| accept      | Accept | ✅       | The `application/vnd.api.v10+json` request header required to use the endpoint.                                                            |
| createdBy   | long   | ❌       | Return only results created by the given user ID.                                                                                          |
| cursor      | string | ❌       | The pointer to the first record of the set of paginated results. To view the next response, use the `nextCursor` value for this parameter. |
| description | string | ❌       | Return only APIs whose description includes the given value. Matching is not case-sensitive.                                               |
| limit       | long   | ❌       | The maximum number of rows to return in the response.                                                                                      |

**Return Type**

`GetApis`

**Example Usage Code Snippet**

```csharp
using PostmanClient;
using PostmanClient.Models;

var client = new PostmanClientClient();

var response = await client.Api.GetApisAsync("1f0df51a-8658-4ee8-a2a1-d2567dfa09a9", Accept.ApplicationVndApiV10Json, 12345678, "RnJpIEZlYiAyNCAyMDIzIDEzOjI0OjA5IEdNVCswMDAwIChDb29yZGluYXRlZCBVbml2ZXJzYWwgVGltZSk=", "This is an API for testing purposes", 10);

Console.WriteLine(response);
```

## CreateApiAsync

Creates an API.

- HTTP Method: `POST`
- Endpoint: `/apis`

**Parameters**

| Name        | Type             | Required | Description                                                                     |
| :---------- | :--------------- | :------- | :------------------------------------------------------------------------------ |
| input       | CreateApiRequest | ❌       | The request body.                                                               |
| workspaceId | string           | ✅       | The workspace's ID.                                                             |
| accept      | Accept           | ✅       | The `application/vnd.api.v10+json` request header required to use the endpoint. |

**Return Type**

`CreateApiOkResponse`

**Example Usage Code Snippet**

```csharp
using PostmanClient;
using PostmanClient.Models;

var client = new PostmanClientClient();

var input = new CreateApiRequest("Test API");

var response = await client.Api.CreateApiAsync(input, "1f0df51a-8658-4ee8-a2a1-d2567dfa09a9", Accept.ApplicationVndApiV10Json);

Console.WriteLine(response);
```

## GetApiAsync

Gets information about an API. **Note:** - Git-connected APIs will only return the `versions` and `gitInfo` query responses. This is because schema and collection information is stored in the connected Git repository. The `gitInfo` object only lists the repository and folder locations of the files. - API viewers can only use the `versions` option in the `include` query parameter.

- HTTP Method: `GET`
- Endpoint: `/apis/{apiId}`

**Parameters**

| Name    | Type                | Required | Description                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   |
| :------ | :------------------ | :------- | :-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| apiId   | string              | ✅       | The API's ID.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                 |
| accept  | Accept              | ✅       | The `application/vnd.api.v10+json` request header required to use the endpoint.                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               |
| include | List`<GetApiInclude>` | ❌       | An array that contains additional resources to include in the response. Use this parameter to query for element links to the API, such as collections and schemas: - `collections` — Query for linked Postman collections. - `versions` — Query for linked versions. - `schemas` — Query for linked schemas. - `gitInfo` — Query for information about the API's git-linked repository. This query only returns the linked repository and folder locations of the files. It does not return `collections` or `schemas` information. **Note:** API viewers can only use the `versions` option. |

**Return Type**

`OneOf<GetApi1, GetApi2>`

**Example Usage Code Snippet**

```csharp
using PostmanClient;
using PostmanClient.Models;

var client = new PostmanClientClient();

var include = new List`<GetApiInclude>`() { GetApiInclude.Collections };

var response = await client.Api.GetApiAsync("90ca9f5a-c4c4-11ed-afa1-0242ac120002", Accept.ApplicationVndApiV10Json, include);

Console.WriteLine(response);
```

## UpdateApiAsync

Updates an API.

- HTTP Method: `PUT`
- Endpoint: `/apis/{apiId}`

**Parameters**

| Name   | Type             | Required | Description                                                                     |
| :----- | :--------------- | :------- | :------------------------------------------------------------------------------ |
| input  | UpdateApiRequest | ❌       | The request body.                                                               |
| apiId  | string           | ✅       | The API's ID.                                                                   |
| accept | Accept           | ✅       | The `application/vnd.api.v10+json` request header required to use the endpoint. |

**Return Type**

`UpdateApiOkResponse`

**Example Usage Code Snippet**

```csharp
using PostmanClient;
using PostmanClient.Models;

var client = new PostmanClientClient();

var input = new UpdateApiRequest("Test API");

var response = await client.Api.UpdateApiAsync(input, "90ca9f5a-c4c4-11ed-afa1-0242ac120002", Accept.ApplicationVndApiV10Json);

Console.WriteLine(response);
```

## DeleteApiAsync

Deletes an API.

- HTTP Method: `DELETE`
- Endpoint: `/apis/{apiId}`

**Parameters**

| Name   | Type   | Required | Description                                                                     |
| :----- | :----- | :------- | :------------------------------------------------------------------------------ |
| apiId  | string | ✅       | The API's ID.                                                                   |
| accept | Accept | ✅       | The `application/vnd.api.v10+json` request header required to use the endpoint. |

**Example Usage Code Snippet**

```csharp
using PostmanClient;
using PostmanClient.Models;

var client = new PostmanClientClient();

await client.Api.DeleteApiAsync("90ca9f5a-c4c4-11ed-afa1-0242ac120002", Accept.ApplicationVndApiV10Json);
```

## AddApiCollectionAsync

Adds a collection to an API. To do this, use the following `operationType` values: - `COPY_COLLECTION` — Copies a collection from the workspace and adds it to an API. - `CREATE_NEW` — Creates a new collection by providing the new collection's content. - `GENERATE_FROM_SCHEMA` — Generates the collection from an API schema. - `options` — An object that contains advanced creation options and their values. You can find a complete list of properties and their values in Postman's [OpenAPI 3.0 to Postman Collection v2.1.0 Converter OPTIONS documentation](https://github.com/postmanlabs/openapi-to-postman/blob/develop/OPTIONS.md). These properties are case-sensitive.

- HTTP Method: `POST`
- Endpoint: `/apis/{apiId}/collections`

**Parameters**

| Name   | Type                                                           | Required | Description                                                                     |
| :----- | :------------------------------------------------------------- | :------- | :------------------------------------------------------------------------------ |
| input  | OneOf<AddApiCollection1, AddApiCollection2, AddApiCollection3> | ❌       | The request body.                                                               |
| apiId  | string                                                         | ✅       | The API's ID.                                                                   |
| accept | Accept                                                         | ✅       | The `application/vnd.api.v10+json` request header required to use the endpoint. |

**Return Type**

`AddApiCollectionOkResponse`

**Example Usage Code Snippet**

```csharp
using PostmanClient;
using PostmanClient.Models;

var client = new PostmanClientClient();

var input = new AddApiCollection1();

var response = await client.Api.AddApiCollectionAsync(input, "90ca9f5a-c4c4-11ed-afa1-0242ac120002", Accept.ApplicationVndApiV10Json);

Console.WriteLine(response);
```

## GetApiCollectionAsync

Gets a collection attached to an API. You can use the `versionId` query parameter to get a collection published in a version. **Note:** The `versionId` query parameter is a required parameter for API viewers.

- HTTP Method: `GET`
- Endpoint: `/apis/{apiId}/collections/{collectionId}`

**Parameters**

| Name         | Type   | Required | Description                                                                     |
| :----------- | :----- | :------- | :------------------------------------------------------------------------------ |
| apiId        | string | ✅       | The API's ID.                                                                   |
| collectionId | string | ✅       | The collection's unique ID.                                                     |
| accept       | Accept | ✅       | The `application/vnd.api.v10+json` request header required to use the endpoint. |
| versionId    | string | ❌       | The API's version ID.                                                           |

**Return Type**

`object`

**Example Usage Code Snippet**

```csharp
using PostmanClient;
using PostmanClient.Models;

var client = new PostmanClientClient();

var response = await client.Api.GetApiCollectionAsync("90ca9f5a-c4c4-11ed-afa1-0242ac120002", "12345678-61867bcc-c4c1-11ed-afa1-0242ac120002", Accept.ApplicationVndApiV10Json, "12ece9e1-2abf-4edc-8e34-de66e74114d2");

Console.WriteLine(response);
```

## SyncCollectionWithSchemaAsync

Syncs a collection attached to an API with the API schema. This is an asynchronous endpoint that returns an HTTP `202 Accepted` response. The response contains a polling link to the `/apis/{apiId}/tasks/{taskId}` endpoint in the `Location` header. **Note:** This endpoint only supports the OpenAPI 3 schema type.

- HTTP Method: `PUT`
- Endpoint: `/apis/{apiId}/collections/{collectionId}/sync-with-schema-tasks`

**Parameters**

| Name         | Type   | Required | Description                                                                     |
| :----------- | :----- | :------- | :------------------------------------------------------------------------------ |
| apiId        | string | ✅       | The API's ID.                                                                   |
| collectionId | string | ✅       | The collection's unique ID.                                                     |
| accept       | Accept | ✅       | The `application/vnd.api.v10+json` request header required to use the endpoint. |

**Return Type**

`SyncCollectionWithSchema`

**Example Usage Code Snippet**

```csharp
using PostmanClient;
using PostmanClient.Models;

var client = new PostmanClientClient();

var response = await client.Api.SyncCollectionWithSchemaAsync("90ca9f5a-c4c4-11ed-afa1-0242ac120002", "12345678-61867bcc-c4c1-11ed-afa1-0242ac120002", Accept.ApplicationVndApiV10Json);

Console.WriteLine(response);
```

## GetApiCommentsAsync

Gets all comments left by users in an API.

- HTTP Method: `GET`
- Endpoint: `/apis/{apiId}/comments`

**Parameters**

| Name  | Type   | Required | Description   |
| :---- | :----- | :------- | :------------ |
| apiId | string | ✅       | The API's ID. |

**Return Type**

`CommentResponse`

**Example Usage Code Snippet**

```csharp
using PostmanClient;

var client = new PostmanClientClient();

var response = await client.Api.GetApiCommentsAsync("90ca9f5a-c4c4-11ed-afa1-0242ac120002");

Console.WriteLine(response);
```

## CreateApiCommentAsync

Creates a comment on an API. **Note:** This endpoint accepts a max of 10,000 characters.

- HTTP Method: `POST`
- Endpoint: `/apis/{apiId}/comments`

**Parameters**

| Name  | Type                | Required | Description       |
| :---- | :------------------ | :------- | :---------------- |
| input | CommentCreateUpdate | ✅       | The request body. |
| apiId | string              | ✅       | The API's ID.     |

**Return Type**

`CommentCreatedUpdated`

**Example Usage Code Snippet**

```csharp
using PostmanClient;
using PostmanClient.Models;

var client = new PostmanClientClient();

var input = new CommentCreateUpdate("This is an example.");

var response = await client.Api.CreateApiCommentAsync(input, "90ca9f5a-c4c4-11ed-afa1-0242ac120002");

Console.WriteLine(response);
```

## UpdateApiCommentAsync

Updates a comment on an API. **Note:** This endpoint accepts a max of 10,000 characters.

- HTTP Method: `PUT`
- Endpoint: `/apis/{apiId}/comments/{commentId}`

**Parameters**

| Name      | Type                | Required | Description       |
| :-------- | :------------------ | :------- | :---------------- |
| input     | CommentCreateUpdate | ✅       | The request body. |
| apiId     | string              | ✅       | The API's ID.     |
| commentId | long                | ✅       | The comment's ID. |

**Return Type**

`CommentCreatedUpdated`

**Example Usage Code Snippet**

```csharp
using PostmanClient;
using PostmanClient.Models;

var client = new PostmanClientClient();

var input = new CommentCreateUpdate("This is an example.");

var response = await client.Api.UpdateApiCommentAsync(input, "90ca9f5a-c4c4-11ed-afa1-0242ac120002", 46814);

Console.WriteLine(response);
```

## DeleteApiCommentAsync

Deletes a comment from an API. On success, this returns an HTTP `204 No Content` response. **Note:** Deleting the first comment of a thread deletes all the comments in the thread.

- HTTP Method: `DELETE`
- Endpoint: `/apis/{apiId}/comments/{commentId}`

**Parameters**

| Name      | Type   | Required | Description       |
| :-------- | :----- | :------- | :---------------- |
| apiId     | string | ✅       | The API's ID.     |
| commentId | long   | ✅       | The comment's ID. |

**Example Usage Code Snippet**

```csharp
using PostmanClient;

var client = new PostmanClientClient();

await client.Api.DeleteApiCommentAsync("90ca9f5a-c4c4-11ed-afa1-0242ac120002", 46814);
```

## CreateApiSchemaAsync

Creates a schema for an API.

- HTTP Method: `POST`
- Endpoint: `/apis/{apiId}/schemas`

**Parameters**

| Name   | Type                   | Required | Description                                                                     |
| :----- | :--------------------- | :------- | :------------------------------------------------------------------------------ |
| input  | CreateApiSchemaRequest | ❌       | The request body.                                                               |
| apiId  | string                 | ✅       | The API's ID.                                                                   |
| accept | Accept                 | ✅       | The `application/vnd.api.v10+json` request header required to use the endpoint. |

**Return Type**

`CreateApiSchemaOkResponse`

**Example Usage Code Snippet**

```csharp
using PostmanClient;
using PostmanClient.Models;

var client = new PostmanClientClient();

var filesItem = new CreateApiSchemaRequest.CreateApiSchemaFiles1();
var files = new List<CreateApiSchemaRequest.CreateApiSchemaFiles1>() { filesItem };
var input = new CreateApiSchemaRequest(CreateApiSchemaRequest.CreateApiSchemaType1.Proto2, files);

var response = await client.Api.CreateApiSchemaAsync(input, "90ca9f5a-c4c4-11ed-afa1-0242ac120002", Accept.ApplicationVndApiV10Json);

Console.WriteLine(response);
```

## GetApiSchemaAsync

Gets information about API schema. You can use the `versionId` query parameter to get a schema published in an API version. You can use this API to do the following: - Get a schema's metadata. - Get all the files in a schema. This only returns the first file in the schema. The endpoint response contains a link to the next set of response results. - Get a schema's contents in multi-file or bundled format. **Note:** The `versionId` query parameter is a required parameter for API viewers.

- HTTP Method: `GET`
- Endpoint: `/apis/{apiId}/schemas/{schemaId}`

**Parameters**

| Name      | Type   | Required | Description                                                                     |
| :-------- | :----- | :------- | :------------------------------------------------------------------------------ |
| apiId     | string | ✅       | The API's ID.                                                                   |
| schemaId  | string | ✅       | The API schema's ID.                                                            |
| accept    | Accept | ✅       | The `application/vnd.api.v10+json` request header required to use the endpoint. |
| versionId | string | ❌       | The API's version ID.                                                           |
| bundled   | bool   | ❌       | If true, return the schema in a bundled format.                                 |

**Return Type**

`OneOf<GetApiSchema1, GetApiSchema2>`

**Example Usage Code Snippet**

```csharp
using PostmanClient;
using PostmanClient.Models;

var client = new PostmanClientClient();

var response = await client.Api.GetApiSchemaAsync("90ca9f5a-c4c4-11ed-afa1-0242ac120002", "5381f010-c4c1-11ed-afa1-0242ac120002", Accept.ApplicationVndApiV10Json, "12ece9e1-2abf-4edc-8e34-de66e74114d2", true);

Console.WriteLine(response);
```

## GetApiSchemaFilesAsync

Gets the files in an API schema. You can use the `versionId` query parameter to get schema files published in an API version. **Note:** The `versionId` query parameter is a required parameter for API viewers.

- HTTP Method: `GET`
- Endpoint: `/apis/{apiId}/schemas/{schemaId}/files`

**Parameters**

| Name      | Type   | Required | Description                                                                                                                                |
| :-------- | :----- | :------- | :----------------------------------------------------------------------------------------------------------------------------------------- |
| apiId     | string | ✅       | The API's ID.                                                                                                                              |
| schemaId  | string | ✅       | The API schema's ID.                                                                                                                       |
| accept    | Accept | ✅       | The `application/vnd.api.v10+json` request header required to use the endpoint.                                                            |
| versionId | string | ❌       | The API's version ID.                                                                                                                      |
| limit     | long   | ❌       | The maximum number of rows to return in the response.                                                                                      |
| cursor    | string | ❌       | The pointer to the first record of the set of paginated results. To view the next response, use the `nextCursor` value for this parameter. |

**Return Type**

`GetApiSchemaFiles`

**Example Usage Code Snippet**

```csharp
using PostmanClient;
using PostmanClient.Models;

var client = new PostmanClientClient();

var response = await client.Api.GetApiSchemaFilesAsync("90ca9f5a-c4c4-11ed-afa1-0242ac120002", "5381f010-c4c1-11ed-afa1-0242ac120002", Accept.ApplicationVndApiV10Json, "12ece9e1-2abf-4edc-8e34-de66e74114d2", 10, "RnJpIEZlYiAyNCAyMDIzIDEzOjI0OjA5IEdNVCswMDAwIChDb29yZGluYXRlZCBVbml2ZXJzYWwgVGltZSk=");

Console.WriteLine(response);
```

## GetApiSchemaFileContentsAsync

Gets an API schema file contents at the defined path. You can use the `versionId` query parameter to get schema file contents published in an API version. **Note:** The `versionId` query parameter is a required parameter for API viewers.

- HTTP Method: `GET`
- Endpoint: `/apis/{apiId}/schemas/{schemaId}/files/{file-path}`

**Parameters**

| Name      | Type   | Required | Description                                                                     |
| :-------- | :----- | :------- | :------------------------------------------------------------------------------ |
| apiId     | string | ✅       | The API's ID.                                                                   |
| schemaId  | string | ✅       | The API schema's ID.                                                            |
| filePath  | string | ✅       | The path to the schema file.                                                    |
| accept    | Accept | ✅       | The `application/vnd.api.v10+json` request header required to use the endpoint. |
| versionId | string | ❌       | The API's version ID.                                                           |

**Return Type**

`GetApiSchemaFileContents`

**Example Usage Code Snippet**

```csharp
using PostmanClient;
using PostmanClient.Models;

var client = new PostmanClientClient();

var response = await client.Api.GetApiSchemaFileContentsAsync("90ca9f5a-c4c4-11ed-afa1-0242ac120002", "5381f010-c4c1-11ed-afa1-0242ac120002", "postman/collection/c1.json", Accept.ApplicationVndApiV10Json, "12ece9e1-2abf-4edc-8e34-de66e74114d2");

Console.WriteLine(response);
```

## CreateUpdateApiSchemaFileAsync

Creates or updates an API schema file. **Note:** - If the provided file path exists, the file will be updated with the new contents. - If the provided file path does not exist, then a new schema file will be created. - If the file path contains a `/` (forward slash) character, then a folder is created. For example, if the file path is the `dir/schema.json` value, then a `dir` folder is created with the `schema.json` file inside.

- HTTP Method: `PUT`
- Endpoint: `/apis/{apiId}/schemas/{schemaId}/files/{file-path}`

**Parameters**

| Name     | Type                             | Required | Description                                                                     |
| :------- | :------------------------------- | :------- | :------------------------------------------------------------------------------ |
| input    | CreateUpdateApiSchemaFileRequest | ❌       | The request body.                                                               |
| apiId    | string                           | ✅       | The API's ID.                                                                   |
| schemaId | string                           | ✅       | The API schema's ID.                                                            |
| filePath | string                           | ✅       | The path to the schema file.                                                    |
| accept   | Accept                           | ✅       | The `application/vnd.api.v10+json` request header required to use the endpoint. |

**Return Type**

`CreateUpdateApiSchemaFileOkResponse`

**Example Usage Code Snippet**

```csharp
using PostmanClient;
using PostmanClient.Models;

var client = new PostmanClientClient();

var input = new CreateUpdateApiSchemaFileRequest();

var response = await client.Api.CreateUpdateApiSchemaFileAsync(input, "90ca9f5a-c4c4-11ed-afa1-0242ac120002", "5381f010-c4c1-11ed-afa1-0242ac120002", "postman/collection/c1.json", Accept.ApplicationVndApiV10Json);

Console.WriteLine(response);
```

## DeleteApiSchemaFileAsync

Deletes a file in an API schema.

- HTTP Method: `DELETE`
- Endpoint: `/apis/{apiId}/schemas/{schemaId}/files/{file-path}`

**Parameters**

| Name     | Type   | Required | Description                                                                     |
| :------- | :----- | :------- | :------------------------------------------------------------------------------ |
| apiId    | string | ✅       | The API's ID.                                                                   |
| schemaId | string | ✅       | The API schema's ID.                                                            |
| filePath | string | ✅       | The path to the schema file.                                                    |
| accept   | Accept | ✅       | The `application/vnd.api.v10+json` request header required to use the endpoint. |

**Example Usage Code Snippet**

```csharp
using PostmanClient;
using PostmanClient.Models;

var client = new PostmanClientClient();

await client.Api.DeleteApiSchemaFileAsync("90ca9f5a-c4c4-11ed-afa1-0242ac120002", "5381f010-c4c1-11ed-afa1-0242ac120002", "postman/collection/c1.json", Accept.ApplicationVndApiV10Json);
```

## GetStatusOfAnAsyncTaskAsync

Gets the status of an asynchronous task.

- HTTP Method: `GET`
- Endpoint: `/apis/{apiId}/tasks/{taskId}`

**Parameters**

| Name   | Type   | Required | Description                                                                     |
| :----- | :----- | :------- | :------------------------------------------------------------------------------ |
| apiId  | string | ✅       | The API's ID.                                                                   |
| taskId | string | ✅       | The task's ID.                                                                  |
| accept | Accept | ✅       | The `application/vnd.api.v10+json` request header required to use the endpoint. |

**Return Type**

`GetStatusOfAnAsyncTask`

**Example Usage Code Snippet**

```csharp
using PostmanClient;
using PostmanClient.Models;

var client = new PostmanClientClient();

var response = await client.Api.GetStatusOfAnAsyncTaskAsync("90ca9f5a-c4c4-11ed-afa1-0242ac120002", "90ca9f5a-c4c4-21ed-afa1-0242ac120002", Accept.ApplicationVndApiV10Json);

Console.WriteLine(response);
```

## GetApiVersionsAsync

Gets all the published versions of an API.

- HTTP Method: `GET`
- Endpoint: `/apis/{apiId}/versions`

**Parameters**

| Name   | Type   | Required | Description                                                                                                                                |
| :----- | :----- | :------- | :----------------------------------------------------------------------------------------------------------------------------------------- |
| apiId  | string | ✅       | The API's ID.                                                                                                                              |
| accept | Accept | ✅       | The `application/vnd.api.v10+json` request header required to use the endpoint.                                                            |
| cursor | string | ❌       | The pointer to the first record of the set of paginated results. To view the next response, use the `nextCursor` value for this parameter. |
| limit  | long   | ❌       | The maximum number of rows to return in the response.                                                                                      |

**Return Type**

`GetApiVersions`

**Example Usage Code Snippet**

```csharp
using PostmanClient;
using PostmanClient.Models;

var client = new PostmanClientClient();

var response = await client.Api.GetApiVersionsAsync("90ca9f5a-c4c4-11ed-afa1-0242ac120002", Accept.ApplicationVndApiV10Json, "RnJpIEZlYiAyNCAyMDIzIDEzOjI0OjA5IEdNVCswMDAwIChDb29yZGluYXRlZCBVbml2ZXJzYWwgVGltZSk=", 10);

Console.WriteLine(response);
```

## CreateApiVersionAsync

Creates a new API version asynchronously and immediately returns an HTTP `202 Accepted` response. The response contains a polling link to the task status API in the `Location` header. This endpoint is equivalent to publishing a version in Postman app, which is the snapshot of API collections and schema at a given point in time.

- HTTP Method: `POST`
- Endpoint: `/apis/{apiId}/versions`

**Parameters**

| Name   | Type                                                           | Required | Description                                                                     |
| :----- | :------------------------------------------------------------- | :------- | :------------------------------------------------------------------------------ |
| input  | OneOf<CreateApiVersion1, CreateApiVersion2, CreateApiVersion3> | ❌       | The request body.                                                               |
| apiId  | string                                                         | ✅       | The API's ID.                                                                   |
| accept | Accept                                                         | ✅       | The `application/vnd.api.v10+json` request header required to use the endpoint. |

**Return Type**

`CreateApiVersionAcceptedResponse`

**Example Usage Code Snippet**

```csharp
using PostmanClient;
using PostmanClient.Models;

var client = new PostmanClientClient();

var schemasItem = new CreateApiVersion1.CreateApiVersion1Schemas();
var schemas = new List<CreateApiVersion1.CreateApiVersion1Schemas>() { schemasItem };
var collectionsItem = new CreateApiVersion1.CreateApiVersion1Collections();
var collections = new List<CreateApiVersion1.CreateApiVersion1Collections>() { collectionsItem };
var input = new CreateApiVersion1("v1", schemas, collections);

var response = await client.Api.CreateApiVersionAsync(input, "90ca9f5a-c4c4-11ed-afa1-0242ac120002", Accept.ApplicationVndApiV10Json);

Console.WriteLine(response);
```

## GetApiVersionAsync

Gets information about an API version. **Note:** - For API editors, this endpoint returns an HTTP `302 Found` status code when the version status is pending. It also returns the `/apis/{apiId}/tasks/{taskId}` task status response header. - For API viewers, this endpoint returns an HTTP `404 Not Found` when the version status is pending.

- HTTP Method: `GET`
- Endpoint: `/apis/{apiId}/versions/{versionId}`

**Parameters**

| Name      | Type   | Required | Description                                                                     |
| :-------- | :----- | :------- | :------------------------------------------------------------------------------ |
| apiId     | string | ✅       | The API's ID.                                                                   |
| versionId | string | ✅       | The API's version ID.                                                           |
| accept    | Accept | ✅       | The `application/vnd.api.v10+json` request header required to use the endpoint. |

**Return Type**

`GetApiVersion`

**Example Usage Code Snippet**

```csharp
using PostmanClient;
using PostmanClient.Models;

var client = new PostmanClientClient();

var response = await client.Api.GetApiVersionAsync("90ca9f5a-c4c4-11ed-afa1-0242ac120002", "12ece9e1-2abf-4edc-8e34-de66e74114d2", Accept.ApplicationVndApiV10Json);

Console.WriteLine(response);
```

## UpdateApiVersionAsync

Updates an API version. **Note:** This endpoint returns an HTTP `404 Not Found` response when an API version is pending publication.

- HTTP Method: `PUT`
- Endpoint: `/apis/{apiId}/versions/{versionId}`

**Parameters**

| Name      | Type                    | Required | Description                                                                     |
| :-------- | :---------------------- | :------- | :------------------------------------------------------------------------------ |
| input     | UpdateApiVersionRequest | ❌       | The request body.                                                               |
| apiId     | string                  | ✅       | The API's ID.                                                                   |
| versionId | string                  | ✅       | The API's version ID.                                                           |
| accept    | Accept                  | ✅       | The `application/vnd.api.v10+json` request header required to use the endpoint. |

**Return Type**

`UpdateApiVersionOkResponse`

**Example Usage Code Snippet**

```csharp
using PostmanClient;
using PostmanClient.Models;

var client = new PostmanClientClient();

var input = new UpdateApiVersionRequest("Release 1.5");

var response = await client.Api.UpdateApiVersionAsync(input, "90ca9f5a-c4c4-11ed-afa1-0242ac120002", "12ece9e1-2abf-4edc-8e34-de66e74114d2", Accept.ApplicationVndApiV10Json);

Console.WriteLine(response);
```

## DeleteApiVersionAsync

Deletes an API version. **Note:** This endpoint returns an HTTP `404 Not Found` response when an API version is pending publication.

- HTTP Method: `DELETE`
- Endpoint: `/apis/{apiId}/versions/{versionId}`

**Parameters**

| Name      | Type   | Required | Description                                                                     |
| :-------- | :----- | :------- | :------------------------------------------------------------------------------ |
| apiId     | string | ✅       | The API's ID.                                                                   |
| versionId | string | ✅       | The API's version ID.                                                           |
| accept    | Accept | ✅       | The `application/vnd.api.v10+json` request header required to use the endpoint. |

**Example Usage Code Snippet**

```csharp
using PostmanClient;
using PostmanClient.Models;

var client = new PostmanClientClient();

await client.Api.DeleteApiVersionAsync("90ca9f5a-c4c4-11ed-afa1-0242ac120002", "12ece9e1-2abf-4edc-8e34-de66e74114d2", Accept.ApplicationVndApiV10Json);
```

<!-- This file was generated by liblab | https://liblab.com/ -->
