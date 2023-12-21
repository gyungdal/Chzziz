using System.Text.Json.Serialization;

namespace Chzziz.Models.Api;

public class LiveDetailServiceMeta {
    [JsonPropertyName("contentType")]
    public string ContentType { get; set; } 
}