using System.Text.Json.Serialization;

namespace Chzziz.Models.Api;

public class LiveDetailMeta {
    [JsonPropertyName("videoId")]
    public string VideoId { get; set; } 
    [JsonPropertyName("streamSeq")]
    public int StreamSeq { get; set; } 
    [JsonPropertyName("liveId")]
    public string LiveId { get; set; } 
    [JsonPropertyName("paidLive")]
    public bool PaidLive { get; set; } 
    [JsonPropertyName("cdnInfo")]
    public LiveDetailMetaCdnInfo CdnInfo { get; set; } 
    [JsonPropertyName("p2p")]
    public bool P2p { get; set; } 
}