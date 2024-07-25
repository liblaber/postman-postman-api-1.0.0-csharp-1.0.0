// This file was generated by liblab | https://liblab.com/

using System.Net.Http.Json;
using PostmanClient.Http;
using PostmanClient.Http.Serialization;
using PostmanClient.Models;

namespace PostmanClient.Services;

public class ScimService : BaseService
{
    internal ScimService(HttpClient httpClient)
        : base(httpClient) { }

    /// <summary>Gets information about all Postman team members.</summary>
    /// <param name="startIndex">The index entry by which to begin the list of returned results.</param>
    /// <param name="count">Limit the number of results returned in a single response.</param>
    /// <param name="filter">
    /// Filter results by a specific word or phrase. This query parameter only supports the `displayName` filter and has the following requirements:
    /// - Filter values are case-sensitive.
    /// - Special characters and spaces must be URL encoded.
    /// </param>
    public async Task<GetScimGroupResources> GetScimGroupResourcesAsync(
        double? startIndex = null,
        double? count = null,
        string? filter = null,
        CancellationToken cancellationToken = default
    )
    {
        var request = new RequestBuilder(HttpMethod.Get, "scim/v2/Groups")
            .SetOptionalQueryParameter("startIndex", startIndex)
            .SetOptionalQueryParameter("count", count)
            .SetOptionalQueryParameter("filter", filter)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<GetScimGroupResources>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>
    /// Creates a new user group in Postman and creates a new account for each group member.
    ///
    /// Each account is added to your Postman team and authentication is activated for each user. If an existing Postman account uses an email that matches a group member's email ID, an [email invite](https://postman.postman.co/docs/administration/managing-your-team/managing-your-team/#invites) to join your Postman team is sent to that user. Once the user accepts the invite, they'll be added to your team.
    ///
    /// By default, the system assigns new users the developer role. You can [update user roles in Postman](https://learning.postman.com/docs/administration/managing-your-team/managing-your-team/#managing-team-roles).
    /// </summary>
    public async Task<CreateScimGroupCreatedResponse> CreateScimGroupAsync(
        CreateScimGroupRequest input,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));

        var request = new RequestBuilder(HttpMethod.Post, "scim/v2/Groups")
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<CreateScimGroupCreatedResponse>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Gets information about a Postman group within the team.</summary>
    /// <param name="groupId">The group's ID.</param>
    public async Task<GetScimGroupResource> GetScimGroupResourceAsync(
        string groupId,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(groupId, nameof(groupId));

        var request = new RequestBuilder(HttpMethod.Get, "scim/v2/Groups/{groupId}")
            .SetPathParameter("groupId", groupId)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<GetScimGroupResource>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>
    /// Updates a group's information. Using this endpoint you can:
    ///
    /// - Update a group's name.
    /// - Add or remove members from a Postman group.
    /// </summary>
    /// <param name="groupId">The group's ID.</param>
    public async Task<ScimUpdateGroupOkResponse> ScimUpdateGroupAsync(
        ScimUpdateGroupRequest input,
        string groupId,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));
        ArgumentNullException.ThrowIfNull(groupId, nameof(groupId));

        var request = new RequestBuilder(HttpMethod.Patch, "scim/v2/Groups/{groupId}")
            .SetPathParameter("groupId", groupId)
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<ScimUpdateGroupOkResponse>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>
    /// Deletes a group in Postman.
    ///
    /// User accounts that were in the deleted group are deactivated in Postman if the app is assigned to the user only with the deleted group.
    ///
    /// User accounts and the data corresponding to them are not deleted. To permanently delete user accounts and their data, [contact Postman support](https://www.postman.com/support/).
    /// </summary>
    /// <param name="groupId">The group's ID.</param>
    public async Task DeleteScimGroupAsync(
        string groupId,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(groupId, nameof(groupId));

        var request = new RequestBuilder(HttpMethod.Delete, "scim/v2/Groups/{groupId}")
            .SetPathParameter("groupId", groupId)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();
    }

    /// <summary>Gets all the resource types supported by Postman's SCIM API.</summary>
    public async Task<List<GetScimResourceTypes>> GetScimResourceTypesAsync(
        CancellationToken cancellationToken = default
    )
    {
        var request = new RequestBuilder(HttpMethod.Get, "scim/v2/ResourceTypes").Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<List<GetScimResourceTypes>>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Gets the Postman SCIM API configuration information. This includes a list of supported operations.</summary>
    public async Task<GetScimServiceProviderConfig> GetScimServiceProviderConfigAsync(
        CancellationToken cancellationToken = default
    )
    {
        var request = new RequestBuilder(HttpMethod.Get, "scim/v2/ServiceProviderConfig").Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<GetScimServiceProviderConfig>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Gets information about all Postman team members.</summary>
    /// <param name="startIndex">The index entry by which to begin the list of returned results.</param>
    /// <param name="count">Limit the number of results returned in a single response.</param>
    /// <param name="filter">
    /// Filter results by a specific word or phrase. This query parameter only supports the `userName` filter and has the following requirements:
    /// - Filter values are case-sensitive.
    /// - Special characters and spaces must be URL encoded.
    /// </param>
    public async Task<GetScimUserResources> GetScimUserResourcesAsync(
        double? startIndex = null,
        double? count = null,
        string? filter = null,
        CancellationToken cancellationToken = default
    )
    {
        var request = new RequestBuilder(HttpMethod.Get, "scim/v2/Users")
            .SetOptionalQueryParameter("startIndex", startIndex)
            .SetOptionalQueryParameter("count", count)
            .SetOptionalQueryParameter("filter", filter)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<GetScimUserResources>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>
    /// Creates a new user account in Postman and adds the user to your organization's Postman team. If the account does not already exist, this also activates the user so they can authenticate in to your Postman team.
    ///
    /// If the account already exists, the system sends the user an [email invite](https://learning.postman.com/docs/administration/managing-your-team/managing-your-team/#inviting-users) to join the Postman team. The user joins the team once they accept the invite.
    ///
    /// By default, the system assigns new users the developer role. You can [update user roles in Postman](https://learning.postman.com/docs/administration/managing-your-team/managing-your-team/#managing-team-roles).
    /// </summary>
    public async Task<CreateScimUserCreatedResponse> CreateScimUserAsync(
        CreateScimUserRequest input,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));

        var request = new RequestBuilder(HttpMethod.Post, "scim/v2/Users")
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<CreateScimUserCreatedResponse>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>Gets information about a Postman team member.</summary>
    /// <param name="userId">The user's SCIM ID.</param>
    public async Task<GetScimUserResourceOkResponse> GetScimUserResourceAsync(
        string userId,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(userId, nameof(userId));

        var request = new RequestBuilder(HttpMethod.Get, "scim/v2/Users/{userId}")
            .SetPathParameter("userId", userId)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<GetScimUserResourceOkResponse>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>
    /// Updates a user's first and last name in Postman.
    ///
    /// **Note:**
    ///
    /// You can only use the SCIM API to update a user's first and last name. You cannot update any other user attributes with the API.
    /// </summary>
    /// <param name="userId">The user's SCIM ID.</param>
    public async Task<GetScimUserResourceOkResponse> UpdateScimUserAsync(
        UpdateScimUser input,
        string userId,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));
        ArgumentNullException.ThrowIfNull(userId, nameof(userId));

        var request = new RequestBuilder(HttpMethod.Put, "scim/v2/Users/{userId}")
            .SetPathParameter("userId", userId)
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<GetScimUserResourceOkResponse>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }

    /// <summary>
    /// Updates a user's active state in Postman.
    ///
    /// **Reactivating a user**
    ///
    /// By setting the `active` property from `false` to `true`, this reactivates an account. This allows the account to authenticate in to Postman and adds the account back on to your Postman team.
    /// </summary>
    /// <param name="userId">The user's SCIM ID.</param>
    public async Task<GetScimUserResourceOkResponse> UpdateScimUserStateAsync(
        UpdateScimUserState input,
        string userId,
        CancellationToken cancellationToken = default
    )
    {
        ArgumentNullException.ThrowIfNull(input, nameof(input));
        ArgumentNullException.ThrowIfNull(userId, nameof(userId));

        var request = new RequestBuilder(HttpMethod.Patch, "scim/v2/Users/{userId}")
            .SetPathParameter("userId", userId)
            .SetContentAsJson(input, _jsonSerializerOptions)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return await response
                .Content.ReadFromJsonAsync<GetScimUserResourceOkResponse>(
                    _jsonSerializerOptions,
                    cancellationToken
                )
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }
}
