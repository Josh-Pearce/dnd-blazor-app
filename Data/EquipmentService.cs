using System.Text.Json;
using DnD_BlazorApp.Interfaces;
using DnD_BlazorApp.Models;

namespace DnD_BlazorApp.Data;

public class EquipmentService
{
    private readonly IApiHelper _apiHelper;

    public EquipmentService(IApiHelper apiHelper)
    {
        _apiHelper = apiHelper;
    }

    public async Task<IEnumerable<DndApiReference>> GetMagicItems()
    {
        HttpRequestMessage request = new(HttpMethod.Get,"https://dnd5eapi.co/api/magic-items");
        
        using var response = await _apiHelper.ApiClient.SendAsync(request);

        if (response.IsSuccessStatusCode)
        {
            //using var responseStream = await response.Content.ReadAsStreamAsync();
            var items = await response.Content.ReadAsAsync<DndApiIndexResult>();//JsonSerializer.DeserializeAsync<IEnumerable<DndApiReference>>(responseStream);
            return items.Results!;
        }
        else
        {
            return Enumerable.Empty<DndApiReference>();
        }
    }
    

    // public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
    // {
    //     return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
    //     {
    //         Date = startDate.AddDays(index),
    //         TemperatureC = Random.Shared.Next(-20, 55),
    //         Summary = Summaries[Random.Shared.Next(Summaries.Length)]
    //     }).ToArray());
    // }
}