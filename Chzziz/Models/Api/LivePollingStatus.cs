using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Chzziz.Models.Api;

public class LivePollingStatus {
    [JsonPropertyName("status")]
    public string Status { get; set; } 
    [JsonPropertyName("isPublishing")]
    public bool IsPublishing { get; set; } 
    [JsonPropertyName("playableStatus")]
    public string PlayableStatus { get; set; } 
    [JsonPropertyName("trafficThrottling")]
    public int TrafficThrottling { get; set; } 
    [JsonPropertyName("callPeriodMilliSecond")]
    public int CallPeriodMilliSecond { get; set; } 
}