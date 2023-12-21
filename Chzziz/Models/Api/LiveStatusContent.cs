using System.Text.Json.Serialization;

namespace Chzziz.Models.Api;

public class LiveStatusContent {
    
    [JsonPropertyName("liveTitle")]
    public string LiveTitle { get; set; }
    [JsonPropertyName("status")]
    public string Status { get; set; }
    [JsonPropertyName("concurrentUserCount")]
    public int ConcurrentUserCount { get; set; }
    [JsonPropertyName("accumulateCount")]
    public int AccumulateCount { get; set; }
    [JsonPropertyName("paidPromotion")]
    public bool PaidPromotion { get; set; }
    [JsonPropertyName("adult")]
    public bool Adult { get; set; }
    [JsonPropertyName("chatChannelId")]
    public string ChatChannelId { get; set; }
    [JsonPropertyName("categoryType")]
    public int CategoryType { get; set; }
    [JsonPropertyName("liveCategory")]
    public string LiveCategory { get; set; }
    [JsonPropertyName("liveCategoryValue")]
    public string LiveCategoryValue { get; set; }
    [JsonPropertyName("livePollingStatusJson")]
    public string LivePollingStatusJson { get; set; } 
    
    //ignore this property
    //[JsonPropertyName("faultStatus")]
    //public any FaultStatus;
}