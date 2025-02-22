// This file was generated by liblab | https://liblab.com/

using System.Net.Http.Json;
using PostmanClient.Http;
using PostmanClient.Http.Exceptions;
using PostmanClient.Http.Extensions;
using PostmanClient.Http.Serialization;
using PostmanClient.Models;

namespace PostmanClient.Services;

public class CollectionItemsService : BaseService
{
    internal CollectionItemsService(HttpClient httpClient)
        : base(httpClient) { }

    /// <summary>
    /// Creates a folder in a collection. For a complete list of properties, refer to "Folder" in the [collection.json schema file](https://schema.postman.com/collection/json/v2.1.0/draft-07/collection.json).
    ///
    /// You can use this endpoint to to import requests and responses into a newly-created folder. To do this, include the `requests` field and the list of request objects in the request body. For more information, see the provided example.
    ///
    /// **Note:**
    ///
    /// It is recommended that you pass the `name` property in the request body. If you do not, the system uses a null value. As a result, this creates a folder with a blank name.
    /// </summary>
    /// <param name="collectionId">The collection's ID.</param>
    public async Task<CreateCollectionFolder> CreateCollectionFolderAsync(
        object input,
        string collectionId,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));
        ArgumentNullException.ThrowIfNull(collectionId, nameof(collectionId));

        var request = new RequestBuilder(HttpMethod.Post, "collections/{collectionId}/folders")
            .SetPathParameter("collectionId", collectionId)
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);

        return await response
                .EnsureSuccessfulResponse()
                .Content.ReadFromJsonAsync<CreateCollectionFolder>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>
    /// Creates a request in a collection. For a complete list of properties, see the [Collection Format Request documentation](https://learning.postman.com/collection-format/reference/request/).
    ///
    /// **Note:**
    ///
    /// It is recommended that you pass the `name` property in the request body. If you do not, the system uses a null value. As a result, this creates a request with a blank name.
    /// </summary>
    /// <param name="collectionId">The collection's ID.</param>
    /// <param name="folderId">The folder ID in which to create the request. By default, the system will create the request at the collection level.</param>
    public async Task<CreateCollectionRequestOkResponse> CreateCollectionRequestAsync(
        object input,
        string collectionId,
        string? folderId = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));
        ArgumentNullException.ThrowIfNull(collectionId, nameof(collectionId));

        var request = new RequestBuilder(HttpMethod.Post, "collections/{collectionId}/requests")
            .SetPathParameter("collectionId", collectionId)
            .SetOptionalQueryParameter("folderId", folderId)
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);

        return await response
                .EnsureSuccessfulResponse()
                .Content.ReadFromJsonAsync<CreateCollectionRequestOkResponse>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>
    /// Creates a request response in a collection. For a complete list of request body properties, see the [Collection Format Response documentation](https://learning.postman.com/collection-format/reference/response/#reference-diagram).
    ///
    /// **Note:**
    ///
    /// It is recommended that you pass the `name` property in the request body. If you do not, the system uses a null value. As a result, this creates a response with a blank name.
    /// </summary>
    /// <param name="collectionId">The collection's ID.</param>
    /// <param name="requestId">The parent request's ID.</param>
    public async Task<CreateCollectionResponse> CreateCollectionResponseAsync(
        object input,
        string collectionId,
        string requestId,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));
        ArgumentNullException.ThrowIfNull(collectionId, nameof(collectionId));
        ArgumentNullException.ThrowIfNull(requestId, nameof(requestId));

        var request = new RequestBuilder(HttpMethod.Post, "collections/{collectionId}/responses")
            .SetPathParameter("collectionId", collectionId)
            .SetQueryParameter("requestId", requestId)
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);

        return await response
                .EnsureSuccessfulResponse()
                .Content.ReadFromJsonAsync<CreateCollectionResponse>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Gets information about a folder in a collection.</summary>
    /// <param name="folderId">The folder's ID.</param>
    /// <param name="collectionId">The collection's ID.</param>
    /// <param name="ids">If true, returns only properties that contain ID values in the response.</param>
    /// <param name="uid">If true, returns all IDs in UID format (`userId`-`id`).</param>
    /// <param name="populate">If true, returns all of the collection item's contents.</param>
    public async Task<GetCollectionFolder> GetCollectionFolderAsync(
        string folderId,
        string collectionId,
        bool? ids = null,
        bool? uid = null,
        bool? populate = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(folderId, nameof(folderId));
        ArgumentNullException.ThrowIfNull(collectionId, nameof(collectionId));

        var request = new RequestBuilder(
            HttpMethod.Get,
            "collections/{collectionId}/folders/{folderId}"
        )
            .SetPathParameter("folderId", folderId)
            .SetPathParameter("collectionId", collectionId)
            .SetOptionalQueryParameter("ids", ids)
            .SetOptionalQueryParameter("uid", uid)
            .SetOptionalQueryParameter("populate", populate)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);

        return await response
                .EnsureSuccessfulResponse()
                .Content.ReadFromJsonAsync<GetCollectionFolder>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>
    /// Updates a folder in a collection. For a complete list of properties, refer to "Folder" in the [collection.json schema file](https://schema.postman.com/collection/json/v2.1.0/draft-07/collection.json).
    ///
    /// **Note:**
    ///
    /// This endpoint acts like a PATCH method. It only updates the values that you pass in the request body (for example, the `name` property). The endpoint does not update the entire resource.
    /// </summary>
    /// <param name="folderId">The folder's ID.</param>
    /// <param name="collectionId">The collection's ID.</param>
    public async Task<UpdateCollectionFolder> UpdateCollectionFolderAsync(
        object input,
        string folderId,
        string collectionId,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));
        ArgumentNullException.ThrowIfNull(folderId, nameof(folderId));
        ArgumentNullException.ThrowIfNull(collectionId, nameof(collectionId));

        var request = new RequestBuilder(
            HttpMethod.Put,
            "collections/{collectionId}/folders/{folderId}"
        )
            .SetPathParameter("folderId", folderId)
            .SetPathParameter("collectionId", collectionId)
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);

        return await response
                .EnsureSuccessfulResponse()
                .Content.ReadFromJsonAsync<UpdateCollectionFolder>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Deletes a folder in a collection.</summary>
    /// <param name="folderId">The folder's ID.</param>
    /// <param name="collectionId">The collection's ID.</param>
    public async Task<DeleteCollectionFolder> DeleteCollectionFolderAsync(
        string folderId,
        string collectionId,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(folderId, nameof(folderId));
        ArgumentNullException.ThrowIfNull(collectionId, nameof(collectionId));

        var request = new RequestBuilder(
            HttpMethod.Delete,
            "collections/{collectionId}/folders/{folderId}"
        )
            .SetPathParameter("folderId", folderId)
            .SetPathParameter("collectionId", collectionId)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);

        return await response
                .EnsureSuccessfulResponse()
                .Content.ReadFromJsonAsync<DeleteCollectionFolder>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Gets information about a request in a collection.</summary>
    /// <param name="requestId">The request's ID.</param>
    /// <param name="collectionId">The collection's ID.</param>
    /// <param name="ids">If true, returns only properties that contain ID values in the response.</param>
    /// <param name="uid">If true, returns all IDs in UID format (`userId`-`id`).</param>
    /// <param name="populate">If true, returns all of the collection item's contents.</param>
    public async Task<GetCollectionRequest> GetCollectionRequestAsync(
        string requestId,
        string collectionId,
        bool? ids = null,
        bool? uid = null,
        bool? populate = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(requestId, nameof(requestId));
        ArgumentNullException.ThrowIfNull(collectionId, nameof(collectionId));

        var request = new RequestBuilder(
            HttpMethod.Get,
            "collections/{collectionId}/requests/{requestId}"
        )
            .SetPathParameter("requestId", requestId)
            .SetPathParameter("collectionId", collectionId)
            .SetOptionalQueryParameter("ids", ids)
            .SetOptionalQueryParameter("uid", uid)
            .SetOptionalQueryParameter("populate", populate)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);

        return await response
                .EnsureSuccessfulResponse()
                .Content.ReadFromJsonAsync<GetCollectionRequest>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>
    /// Updates a request in a collection. For a complete list of properties, see the [Collection Format Request documentation](https://learning.postman.com/collection-format/reference/request/).
    ///
    /// **Note:**
    ///
    /// - You must pass a collection ID (`12ece9e1-2abf-4edc-8e34-de66e74114d2`), not a collection(`12345678-12ece9e1-2abf-4edc-8e34-de66e74114d2`), in this endpoint.
    /// - This endpoint does not support changing the folder of a request.
    /// </summary>
    /// <param name="requestId">The request's ID.</param>
    /// <param name="collectionId">The collection's ID.</param>
    public async Task<UpdateCollectionRequest> UpdateCollectionRequestAsync(
        object input,
        string requestId,
        string collectionId,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));
        ArgumentNullException.ThrowIfNull(requestId, nameof(requestId));
        ArgumentNullException.ThrowIfNull(collectionId, nameof(collectionId));

        var request = new RequestBuilder(
            HttpMethod.Put,
            "collections/{collectionId}/requests/{requestId}"
        )
            .SetPathParameter("requestId", requestId)
            .SetPathParameter("collectionId", collectionId)
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);

        return await response
                .EnsureSuccessfulResponse()
                .Content.ReadFromJsonAsync<UpdateCollectionRequest>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Deletes a request in a collection.</summary>
    /// <param name="requestId">The request's ID.</param>
    /// <param name="collectionId">The collection's ID.</param>
    public async Task<DeleteCollectionRequest> DeleteCollectionRequestAsync(
        string requestId,
        string collectionId,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(requestId, nameof(requestId));
        ArgumentNullException.ThrowIfNull(collectionId, nameof(collectionId));

        var request = new RequestBuilder(
            HttpMethod.Delete,
            "collections/{collectionId}/requests/{requestId}"
        )
            .SetPathParameter("requestId", requestId)
            .SetPathParameter("collectionId", collectionId)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);

        return await response
                .EnsureSuccessfulResponse()
                .Content.ReadFromJsonAsync<DeleteCollectionRequest>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Gets information about a response in a collection.</summary>
    /// <param name="responseId">The response's ID.</param>
    /// <param name="collectionId">The collection's ID.</param>
    /// <param name="ids">If true, returns only properties that contain ID values in the response.</param>
    /// <param name="uid">If true, returns all IDs in UID format (`userId`-`id`).</param>
    /// <param name="populate">If true, returns all of the collection item's contents.</param>
    public async Task<GetCollectionResponse> GetCollectionResponseAsync(
        string responseId,
        string collectionId,
        bool? ids = null,
        bool? uid = null,
        bool? populate = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(responseId, nameof(responseId));
        ArgumentNullException.ThrowIfNull(collectionId, nameof(collectionId));

        var request = new RequestBuilder(
            HttpMethod.Get,
            "collections/{collectionId}/responses/{responseId}"
        )
            .SetPathParameter("responseId", responseId)
            .SetPathParameter("collectionId", collectionId)
            .SetOptionalQueryParameter("ids", ids)
            .SetOptionalQueryParameter("uid", uid)
            .SetOptionalQueryParameter("populate", populate)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);

        return await response
                .EnsureSuccessfulResponse()
                .Content.ReadFromJsonAsync<GetCollectionResponse>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>
    /// Updates a response in a collection. For a complete list of properties, see the [Collection Format Response documentation](https://learning.postman.com/collection-format/reference/response/#reference-diagram).
    ///
    /// **Note:**
    ///
    /// - You must pass a collection ID (`12ece9e1-2abf-4edc-8e34-de66e74114d2`), not a collection UID (`12345678-12ece9e1-2abf-4edc-8e34-de66e74114d2`), in this endpoint.
    /// - This endpoint acts like a PATCH method. It only updates the values that you pass in the request body (for example, the `name` property). The endpoint does not update the entire resource.
    /// </summary>
    /// <param name="responseId">The response's ID.</param>
    /// <param name="collectionId">The collection's ID.</param>
    public async Task<UpdateCollectionResponse> UpdateCollectionResponseAsync(
        object input,
        string responseId,
        string collectionId,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));
        ArgumentNullException.ThrowIfNull(responseId, nameof(responseId));
        ArgumentNullException.ThrowIfNull(collectionId, nameof(collectionId));

        var request = new RequestBuilder(
            HttpMethod.Put,
            "collections/{collectionId}/responses/{responseId}"
        )
            .SetPathParameter("responseId", responseId)
            .SetPathParameter("collectionId", collectionId)
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);

        return await response
                .EnsureSuccessfulResponse()
                .Content.ReadFromJsonAsync<UpdateCollectionResponse>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Deletes a response in a collection.</summary>
    /// <param name="responseId">The response's ID.</param>
    /// <param name="collectionId">The collection's ID.</param>
    public async Task<DeleteCollectionResponse> DeleteCollectionResponseAsync(
        string responseId,
        string collectionId,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(responseId, nameof(responseId));
        ArgumentNullException.ThrowIfNull(collectionId, nameof(collectionId));

        var request = new RequestBuilder(
            HttpMethod.Delete,
            "collections/{collectionId}/responses/{responseId}"
        )
            .SetPathParameter("responseId", responseId)
            .SetPathParameter("collectionId", collectionId)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);

        return await response
                .EnsureSuccessfulResponse()
                .Content.ReadFromJsonAsync<DeleteCollectionResponse>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }
}
