// This file was generated by liblab | https://liblab.com/

using System.Net.Http.Json;
using PostmanClient.Http;
using PostmanClient.Http.Serialization;
using PostmanClient.Models;

namespace PostmanClient.Services;

public class SecretScannerService : BaseService
{
    internal SecretScannerService(HttpClient httpClient)
        : base(httpClient) { }

    /// <summary>Returns all secrets detected by Postman's [Secret Scanner](https://learning.postman.com/docs/administration/secret-scanner/), grouped by workspace. If you pass an empty request body, this endpoint returns all results.</summary>
    /// <param name="limit">The maximum number of rows to return in the response.</param>
    /// <param name="cursor">The pointer to the first record of the set of paginated results. To view the next response, use the `nextCursor` value for this parameter.</param>
    /// <param name="include">The additional fields to be included as a part of the request.</param>
    public async Task<DetectedSecretsQueriesOkResponse> DetectedSecretsQueriesAsync(
        DetectedSecretsQueriesRequest input,
        long? limit = null,
        string? cursor = null,
        string? include = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));

        var request = new RequestBuilder(HttpMethod.Post, "detected-secrets-queries")
            .SetOptionalQueryParameter("limit", limit)
            .SetOptionalQueryParameter("cursor", cursor)
            .SetOptionalQueryParameter("include", include)
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<DetectedSecretsQueriesOkResponse>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Updates the resolution status of a secret detected in a workspace.</summary>
    /// <param name="secretId">The secret's ID.</param>
    public async Task<UpdateDetectedSecretResolutionsOkResponse> UpdateDetectedSecretResolutionsAsync(
        UpdateDetectedSecretResolutionsRequest input,
        string secretId,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));
        ArgumentNullException.ThrowIfNull(secretId, nameof(secretId));

        var request = new RequestBuilder(HttpMethod.Put, "detected-secrets/{secretId}")
            .SetPathParameter("secretId", secretId)
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<UpdateDetectedSecretResolutionsOkResponse>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Gets the locations of secrets detected by Postman's [Secret Scanner](https://learning.postman.com/docs/administration/secret-scanner/).</summary>
    /// <param name="secretId">The secret's ID.</param>
    /// <param name="workspaceId">The workspace's ID.</param>
    /// <param name="limit">The maximum number of rows to return in the response.</param>
    /// <param name="cursor">The pointer to the first record of the set of paginated results. To view the next response, use the `nextCursor` value for this parameter.</param>
    public async Task<GetSecretsLocations> GetDetectedSecretsLocationsAsync(
        string secretId,
        string workspaceId,
        long? limit = null,
        string? cursor = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(secretId, nameof(secretId));
        ArgumentNullException.ThrowIfNull(workspaceId, nameof(workspaceId));

        var request = new RequestBuilder(HttpMethod.Get, "detected-secrets/{secretId}/locations")
            .SetPathParameter("secretId", secretId)
            .SetQueryParameter("workspaceId", workspaceId)
            .SetOptionalQueryParameter("limit", limit)
            .SetOptionalQueryParameter("cursor", cursor)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<GetSecretsLocations>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Gets the metadata of the secret types supported by Postman's [Secret Scanner](https://learning.postman.com/docs/administration/secret-scanner/). You can use a secret type's ID in the response to query data with the POST `/detected-secrets/{secretId}` endpoint.</summary>
    public async Task<GetSecretTypes> GetSecretTypesAsync(
        CancellationToken cancellationToken = default
    )
    {
        var request = new RequestBuilder(HttpMethod.Get, "secret-types").Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<GetSecretTypes>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }
}
