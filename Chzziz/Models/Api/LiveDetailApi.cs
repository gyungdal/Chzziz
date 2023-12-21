using System.Text.Json.Serialization;

namespace Chzziz.Models.Api;

public class LiveDetailApi {
    [JsonPropertyName("name")]
    public string Name { get; set; } 
    [JsonPropertyName("path")]
    public string Path { get; set; } 
}