# SecretScannerService

A list of all methods in the `SecretScannerService` service. Click on the method name to view detailed information about that method.

| Methods                                                                       | Description                                                                                                                                                                                                                                                          |
| :---------------------------------------------------------------------------- | :------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| [DetectedSecretsQueriesAsync](#detectedsecretsqueriesasync)                   | Returns all secrets detected by Postman's [Secret Scanner](https://learning.postman.com/docs/administration/secret-scanner/), grouped by workspace. If you pass an empty request body, this endpoint returns all results.                                            |
| [UpdateDetectedSecretResolutionsAsync](#updatedetectedsecretresolutionsasync) | Updates the resolution status of a secret detected in a workspace.                                                                                                                                                                                                   |
| [GetDetectedSecretsLocationsAsync](#getdetectedsecretslocationsasync)         | Gets the locations of secrets detected by Postman's [Secret Scanner](https://learning.postman.com/docs/administration/secret-scanner/).                                                                                                                              |
| [GetSecretTypesAsync](#getsecrettypesasync)                                   | Gets the metadata of the secret types supported by Postman's [Secret Scanner](https://learning.postman.com/docs/administration/secret-scanner/). You can use a secret type's ID in the response to query data with the POST `/detected-secrets/{secretId}` endpoint. |

## DetectedSecretsQueriesAsync

Returns all secrets detected by Postman's [Secret Scanner](https://learning.postman.com/docs/administration/secret-scanner/), grouped by workspace. If you pass an empty request body, this endpoint returns all results.

- HTTP Method: `POST`
- Endpoint: `/detected-secrets-queries`

**Parameters**

| Name    | Type                          | Required | Description                                                                                                                                |
| :------ | :---------------------------- | :------- | :----------------------------------------------------------------------------------------------------------------------------------------- |
| input   | DetectedSecretsQueriesRequest | ❌       | The request body.                                                                                                                          |
| limit   | long                          | ❌       | The maximum number of rows to return in the response.                                                                                      |
| cursor  | string                        | ❌       | The pointer to the first record of the set of paginated results. To view the next response, use the `nextCursor` value for this parameter. |
| include | string                        | ❌       | The additional fields to be included as a part of the request.                                                                             |

**Return Type**

`DetectedSecretsQueriesOkResponse`

**Example Usage Code Snippet**

```csharp
using PostmanClient;
using PostmanClient.Models;

var client = new PostmanClientClient();

var input = new DetectedSecretsQueriesRequest();

var response = await client.SecretScanner.DetectedSecretsQueriesAsync(input, 10, "RnJpIEZlYiAyNCAyMDIzIDEzOjI0OjA5IEdNVCswMDAwIChDb29yZGluYXRlZCBVbml2ZXJzYWwgVGltZSk=", "meta.total");

Console.WriteLine(response);
```

## UpdateDetectedSecretResolutionsAsync

Updates the resolution status of a secret detected in a workspace.

- HTTP Method: `PUT`
- Endpoint: `/detected-secrets/{secretId}`

**Parameters**

| Name     | Type                                   | Required | Description       |
| :------- | :------------------------------------- | :------- | :---------------- |
| input    | UpdateDetectedSecretResolutionsRequest | ❌       | The request body. |
| secretId | string                                 | ✅       | The secret's ID.  |

**Return Type**

`UpdateDetectedSecretResolutionsOkResponse`

**Example Usage Code Snippet**

```csharp
using PostmanClient;
using PostmanClient.Models;

var client = new PostmanClientClient();

var input = new UpdateDetectedSecretResolutionsRequest(UpdateDetectedSecretResolutionsRequest.UpdateSecretResolutionsResolution1.FalsePositive, "e361eeb4-00dd-4225-9774-6146a2555999");

var response = await client.SecretScanner.UpdateDetectedSecretResolutionsAsync(input, "ODk0MTU2");

Console.WriteLine(response);
```

## GetDetectedSecretsLocationsAsync

Gets the locations of secrets detected by Postman's [Secret Scanner](https://learning.postman.com/docs/administration/secret-scanner/).

- HTTP Method: `GET`
- Endpoint: `/detected-secrets/{secretId}/locations`

**Parameters**

| Name        | Type   | Required | Description                                                                                                                                |
| :---------- | :----- | :------- | :----------------------------------------------------------------------------------------------------------------------------------------- |
| secretId    | string | ✅       | The secret's ID.                                                                                                                           |
| workspaceId | string | ✅       | The workspace's ID.                                                                                                                        |
| limit       | long   | ❌       | The maximum number of rows to return in the response.                                                                                      |
| cursor      | string | ❌       | The pointer to the first record of the set of paginated results. To view the next response, use the `nextCursor` value for this parameter. |

**Return Type**

`GetSecretsLocations`

**Example Usage Code Snippet**

```csharp
using PostmanClient;

var client = new PostmanClientClient();

var response = await client.SecretScanner.GetDetectedSecretsLocationsAsync("ODk0MTU2", "1f0df51a-8658-4ee8-a2a1-d2567dfa09a9", 10, "RnJpIEZlYiAyNCAyMDIzIDEzOjI0OjA5IEdNVCswMDAwIChDb29yZGluYXRlZCBVbml2ZXJzYWwgVGltZSk=");

Console.WriteLine(response);
```

## GetSecretTypesAsync

Gets the metadata of the secret types supported by Postman's [Secret Scanner](https://learning.postman.com/docs/administration/secret-scanner/). You can use a secret type's ID in the response to query data with the POST `/detected-secrets/{secretId}` endpoint.

- HTTP Method: `GET`
- Endpoint: `/secret-types`

**Return Type**

`GetSecretTypes`

**Example Usage Code Snippet**

```csharp
using PostmanClient;

var client = new PostmanClientClient();

var response = await client.SecretScanner.GetSecretTypesAsync();

Console.WriteLine(response);
```

<!-- This file was generated by liblab | https://liblab.com/ -->
