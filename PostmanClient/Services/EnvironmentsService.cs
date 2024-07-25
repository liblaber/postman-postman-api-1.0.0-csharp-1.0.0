// This file was generated by liblab | https://liblab.com/

using System.Net.Http.Json;
using PostmanClient.Http;
using PostmanClient.Http.Serialization;
using PostmanClient.Models;

namespace PostmanClient.Services;

public class EnvironmentsService : BaseService
{
    internal EnvironmentsService(HttpClient httpClient)
        : base(httpClient) { }

    /// <summary>Gets information about all of your [environments](https://learning.postman.com/docs/sending-requests/managing-environments/).</summary>
    /// <param name="workspace">The workspace's ID.</param>
    public async Task<GetEnvironments> GetEnvironmentsAsync(
        string? workspace = null,
        CancellationToken cancellationToken = default
    )
    {
        var request = new RequestBuilder(HttpMethod.Get, "environments")
            .SetOptionalQueryParameter("workspace", workspace)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<GetEnvironments>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Creates an environment.</summary>
    /// <param name="workspace">The workspace's ID.</param>
    public async Task<CreateEnvironmentOkResponse> CreateEnvironmentAsync(
        CreateEnvironmentRequest input,
        string? workspace = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));

        var request = new RequestBuilder(HttpMethod.Post, "environments")
            .SetOptionalQueryParameter("workspace", workspace)
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<CreateEnvironmentOkResponse>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Gets information about an environment.</summary>
    /// <param name="environmentId">The environment's ID.</param>
    public async Task<GetEnvironment> GetEnvironmentAsync(
        string environmentId,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(environmentId, nameof(environmentId));

        var request = new RequestBuilder(HttpMethod.Get, "environments/{environmentId}")
            .SetPathParameter("environmentId", environmentId)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<GetEnvironment>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Updates an environment.</summary>
    /// <param name="environmentId">The environment's ID.</param>
    public async Task<UpdateEnvironmentOkResponse> UpdateEnvironmentAsync(
        UpdateEnvironmentRequest input,
        string environmentId,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));
        ArgumentNullException.ThrowIfNull(environmentId, nameof(environmentId));

        var request = new RequestBuilder(HttpMethod.Put, "environments/{environmentId}")
            .SetPathParameter("environmentId", environmentId)
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<UpdateEnvironmentOkResponse>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Deletes an environment.</summary>
    /// <param name="environmentId">The environment's ID.</param>
    public async Task<DeleteEnvironment> DeleteEnvironmentAsync(
        string environmentId,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(environmentId, nameof(environmentId));

        var request = new RequestBuilder(HttpMethod.Delete, "environments/{environmentId}")
            .SetPathParameter("environmentId", environmentId)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<DeleteEnvironment>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Gets all of an environment's forked environments.</summary>
    /// <param name="environmentId">The environment's unique ID.</param>
    /// <param name="cursor">The pointer to the first record of the set of paginated results. To view the next response, use the `nextCursor` value for this parameter.</param>
    /// <param name="direction">Sort results in ascending (`asc`) or descending (`desc`) order.</param>
    /// <param name="limit">The maximum number of rows to return in the response.</param>
    /// <param name="sort">Sort the results by the date and time of creation.</param>
    public async Task<GetEnvironmentForks> GetEnvironmentForksAsync(
        string environmentId,
        string? cursor = null,
        AscDesc? direction = null,
        long? limit = null,
        GetEnvironmentForksSort? sort = null,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(environmentId, nameof(environmentId));

        var request = new RequestBuilder(HttpMethod.Get, "environments/{environmentId}/forks")
            .SetPathParameter("environmentId", environmentId)
            .SetOptionalQueryParameter("cursor", cursor)
            .SetOptionalQueryParameter("direction", direction?.Value)
            .SetOptionalQueryParameter("limit", limit)
            .SetOptionalQueryParameter("sort", sort?.Value)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<GetEnvironmentForks>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Creates a [fork](https://learning.postman.com/docs/collaborating-in-postman/using-version-control/forking-elements/) of an existing environment.</summary>
    /// <param name="environmentId">The environment's unique ID.</param>
    /// <param name="workspaceId">The workspace's ID.</param>
    public async Task<ForkEnvironmentOkResponse> ForkEnvironmentAsync(
        ForkEnvironmentRequest input,
        string environmentId,
        string workspaceId,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));
        ArgumentNullException.ThrowIfNull(environmentId, nameof(environmentId));
        ArgumentNullException.ThrowIfNull(workspaceId, nameof(workspaceId));

        var request = new RequestBuilder(HttpMethod.Post, "environments/{environmentId}/forks")
            .SetPathParameter("environmentId", environmentId)
            .SetQueryParameter("workspaceId", workspaceId)
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<ForkEnvironmentOkResponse>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>
    /// [Merges](https://learning.postman.com/docs/collaborating-in-postman/using-version-control/forking-elements/#merge-changes-from-a-fork) a forked environment back into its parent environment.
    /// </summary>
    /// <param name="environmentId">The environment's unique ID.</param>
    public async Task<MergeEnvironmentForkOkResponse> MergeEnvironmentForkAsync(
        MergeEnvironmentForkRequest input,
        string environmentId,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));
        ArgumentNullException.ThrowIfNull(environmentId, nameof(environmentId));

        var request = new RequestBuilder(HttpMethod.Post, "environments/{environmentId}/merges")
            .SetPathParameter("environmentId", environmentId)
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<MergeEnvironmentForkOkResponse>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>
    /// [Pulls](https://learning.postman.com/docs/collaborating-in-postman/using-version-control/forking-elements/#pull-updates-from-a-parent-element) the changes from a parent (source) environment into the forked environment.
    /// </summary>
    /// <param name="environmentId">The environment's unique ID.</param>
    public async Task<PullEnvironmentOkResponse> PullEnvironmentAsync(
        PullEnvironmentRequest input,
        string environmentId,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));
        ArgumentNullException.ThrowIfNull(environmentId, nameof(environmentId));

        var request = new RequestBuilder(HttpMethod.Post, "environments/{environmentId}/pulls")
            .SetPathParameter("environmentId", environmentId)
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<PullEnvironmentOkResponse>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }
}
