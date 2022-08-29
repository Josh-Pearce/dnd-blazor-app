using System.Text.Json.Serialization;

namespace DnD_BlazorApp.Models;

public class DndApiReference {

    [JsonPropertyName("index")]
    public string? Index { get; set; }
    [JsonPropertyName("name")]
    public string? Name { get; set; }
    [JsonPropertyName("url")]
    public string? Url { get; set; }
}