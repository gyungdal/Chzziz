using System.Text.Json.Serialization;

namespace Chzziz.Models.Api;

public class LiveDetailMedia {
    [JsonPropertyName("mediaId")]
    public string MediaId { get; set; }
    [JsonPropertyName("protocol")]
    public string Protocol { get; set; }
    [JsonPropertyName("path")]
    public string Path { get; set; }
}