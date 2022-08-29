using System.Net.Http.Headers;
using DndBlazorApp.Interfaces;

namespace DndBlazorApp.Data;

public class ApiHelper : IApiHelper
{
    private readonly IHttpClientFactory _clientFactory;
    private readonly HttpClient _apiClient;

    public HttpClient ApiClient { get => _apiClient; }

    public ApiHelper(IHttpClientFactory clientFactory)
    {
        _clientFactory = clientFactory;
        _apiClient = _clientFactory.CreateClient();
        ConfigureClient();
    }

    private void ConfigureClient()
    {
        ApiClient.DefaultRequestHeaders.Accept
            .Add(new MediaTypeWithQualityHeaderValue("application/json"));
    }
}