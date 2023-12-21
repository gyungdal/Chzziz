using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Chzziz.Models.Api;

public class ChzzkResponse<T> {
    [JsonPropertyName("code")]
    public int Code { get; set; }
    [JsonPropertyName("message")]
    public string? Message { get; set; }
    [JsonPropertyName("content")]
    public T Content { get; set; }
}