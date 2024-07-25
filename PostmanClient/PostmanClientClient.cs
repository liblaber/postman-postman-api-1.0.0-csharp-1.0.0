// This file was generated by liblab | https://liblab.com/

using PostmanClient.Config;
using PostmanClient.Http.Handlers;
using PostmanClient.Services;
using Environment = PostmanClient.Http.Environment;

namespace PostmanClient;

public class PostmanClientClient : IDisposable
{
    private readonly HttpClient _httpClient;
    private readonly TokenHandler _apiKeyHandler;

    public BillingService Billing { get; private set; }
    public ApiService Api { get; private set; }
    public TagsService Tags { get; private set; }
    public AuditLogsService AuditLogs { get; private set; }
    public CollectionsService Collections { get; private set; }
    public CollectionItemsService CollectionItems { get; private set; }
    public CollectionFoldersService CollectionFolders { get; private set; }
    public CollectionRequestsService CollectionRequests { get; private set; }
    public CollectionResponsesService CollectionResponses { get; private set; }
    public SecretScannerService SecretScanner { get; private set; }
    public EnvironmentsService Environments { get; private set; }
    public ImportService Import { get; private set; }
    public UserService User { get; private set; }
    public MocksService Mocks { get; private set; }
    public MonitorsService Monitors { get; private set; }
    public PrivateApiNetworkService PrivateApiNetwork { get; private set; }
    public PullRequestsService PullRequests { get; private set; }
    public ApiSecurityService ApiSecurity { get; private set; }
    public ScimService Scim { get; private set; }
    public WebhooksService Webhooks { get; private set; }
    public WorkspacesService Workspaces { get; private set; }

    public PostmanClientClient(PostmanClientConfig? config = null)
    {
        var retryHandler = new RetryHandler();
        _apiKeyHandler = new TokenHandler(retryHandler)
        {
            Header = config?.ApiKeyAuth?.ApiKeyHeader ?? ApiKeyAuthConfig.DefaultApiKeyHeader,
            Prefix = "",
            Token = config?.ApiKeyAuth?.ApiKey
        };

        _httpClient = new HttpClient(_apiKeyHandler)
        {
            BaseAddress = config?.Environment?.Uri ?? Environment.Default.Uri,
            DefaultRequestHeaders = { { "user-agent", "dotnet/7.0" } }
        };

        Billing = new BillingService(_httpClient);
        Api = new ApiService(_httpClient);
        Tags = new TagsService(_httpClient);
        AuditLogs = new AuditLogsService(_httpClient);
        Collections = new CollectionsService(_httpClient);
        CollectionItems = new CollectionItemsService(_httpClient);
        CollectionFolders = new CollectionFoldersService(_httpClient);
        CollectionRequests = new CollectionRequestsService(_httpClient);
        CollectionResponses = new CollectionResponsesService(_httpClient);
        SecretScanner = new SecretScannerService(_httpClient);
        Environments = new EnvironmentsService(_httpClient);
        Import = new ImportService(_httpClient);
        User = new UserService(_httpClient);
        Mocks = new MocksService(_httpClient);
        Monitors = new MonitorsService(_httpClient);
        PrivateApiNetwork = new PrivateApiNetworkService(_httpClient);
        PullRequests = new PullRequestsService(_httpClient);
        ApiSecurity = new ApiSecurityService(_httpClient);
        Scim = new ScimService(_httpClient);
        Webhooks = new WebhooksService(_httpClient);
        Workspaces = new WorkspacesService(_httpClient);
    }

    /// <summary>
    /// Set the environment for the entire SDK.
    /// </summary>
    public void SetEnvironment(Environment environment)
    {
        SetBaseUrl(environment.Uri);
    }

    /// <summary>
    /// Sets the base URL for entire SDK.
    /// </summary>
    public void SetBaseUrl(string baseUrl)
    {
        SetBaseUrl(new Uri(baseUrl));
    }

    /// <summary>
    /// Sets the base URL for the entire SDK.
    /// </summary>
    public void SetBaseUrl(Uri uri)
    {
        _httpClient.BaseAddress = uri;
    }

    /// <summary>
    /// Sets the API key for the entire SDK.
    /// </summary>
    public void SetApiKey(string apiKey)
    {
        _apiKeyHandler.Token = apiKey;
    }

    /// <summary>
    /// Sets the API key header for the entire SDK.
    /// </summary>
    public void SetApiKeyHeader(string apiKeyHeader)
    {
        _apiKeyHandler.Header = apiKeyHeader;
    }

    public void Dispose()
    {
        _httpClient.Dispose();
    }
}

// c029837e0e474b76bc487506e8799df5e3335891efe4fb02bda7a1441840310c
