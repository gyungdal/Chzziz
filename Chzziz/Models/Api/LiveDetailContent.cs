using System.Runtime.InteropServices.JavaScript;
using System.Text.Json.Serialization;

namespace Chzziz.Models.Api;

public class LiveDetailContent {
    [JsonPropertyName("liveId")]
    public int LiveId { get; set; }   
    [JsonPropertyName("liveImageUrl")]
    public string LiveImageUrl { get; set; }   
    [JsonPropertyName("defaultThumbnailImageUrl")]
    public string? DefaultThumbnailImageUrl { get; set; }   
    [JsonPropertyName("openDate")]
    public JSType.Date? OpenDate { get; set; }   
    [JsonPropertyName("closeDate")]
    public JSType.Date? CloseDate { get; set; }   
    [JsonPropertyName("chatActive")]
    public bool ChatActive { get; set; }   
    [JsonPropertyName("chatAvailableGroup")]
    public string ChatAvailableGroup { get; set; }   
    [JsonPropertyName("chatAvailableCondition")]
    public string ChatAvailableCondition { get; set; }   
    [JsonPropertyName("minFollowerMinute")]
    public int MinFollowerMinute { get; set; }   
    [JsonPropertyName("livePlaybackJson")]
    public string LivePlaybackJson { get; set; }   
    [JsonPropertyName("channel")]
    public LiveChannel Channel { get; set; }   
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
    [JsonPropertyName("chatChannelId")]
    public string ChatChannelId { get; set; }   
    [JsonPropertyName("categoryType")]
    public int? CategoryType { get; set; }   
    [JsonPropertyName("liveCategory")]
    public string LiveCategory { get; set; }   
    [JsonPropertyName("liveCategoryValue")]
    public string LiveCategoryValue { get; set; }   
    [JsonPropertyName("livePollingStatusJson")]
    public string LivePollingStatusJson { get; set; }   
}