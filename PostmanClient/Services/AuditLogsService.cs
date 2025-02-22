// This file was generated by liblab | https://liblab.com/

using System.Net.Http.Json;
using PostmanClient.Http;
using PostmanClient.Http.Exceptions;
using PostmanClient.Http.Extensions;
using PostmanClient.Http.Serialization;
using PostmanClient.Models;

namespace PostmanClient.Services;

public class AuditLogsService : BaseService
{
    internal AuditLogsService(HttpClient httpClient)
        : base(httpClient) { }

    /// <summary>Gets a list of your team's generated audit events. For a complete list of all audit events, read our [Utilizing audit logs](https://learning.postman.com/docs/administration/audit-logs/) documentation.</summary>
    /// <param name="since">Return logs created after the given time, in `YYYY-MM-DD` format.</param>
    /// <param name="until">Return logs created before the given time, in `YYYY-MM-DD` format.</param>
    /// <param name="limit">The maximum number of audit events to return at once.</param>
    /// <param name="cursor">The pointer to the first record of the set of paginated results. To view the next response, use the `nextCursor` value for this parameter.</param>
    /// <param name="orderBy">Return the records in ascending (`asc`) or descending (`desc`) order.</param>
    public async Task<GetAuditLogs> GetAuditLogsAsync(
        string? since = null,
        string? until = null,
        long? limit = null,
        string? cursor = null,
        AscDescDefaultDesc? orderBy = null,
        CancellationToken cancellationToken = default
    )
    {
        var request = new RequestBuilder(HttpMethod.Get, "audit/logs")
            .SetOptionalQueryParameter("since", since)
            .SetOptionalQueryParameter("until", until)
            .SetOptionalQueryParameter("limit", limit)
            .SetOptionalQueryParameter("cursor", cursor)
            .SetOptionalQueryParameter("order_by", orderBy?.Value)
            .Build();

        var response = await _httpClient
            .SendAsync(request, cancellationToken)
            .ConfigureAwait(false);

        return await response
                .EnsureSuccessfulResponse()
                .Content.ReadFromJsonAsync<GetAuditLogs>(_jsonSerializerOptions, cancellationToken)
                .ConfigureAwait(false) ?? throw new Exception("Failed to deserialize response.");
    }
}
