using System.Text.Json.Serialization;

namespace Chzziz.Models.Api;

public class LiveDetailPlayback {
    [JsonPropertyName("meta")]
    public LiveDetailMeta Meta { get; set; }
    [JsonPropertyName("serviceMeta")]
    public LiveDetailServiceMeta ServiceMeta { get; set; }
    [JsonPropertyName("thumbnail")]
    public LiveDetailThumbnail Thumbnail { get; set; }
    [JsonPropertyName("live")]
    public LiveDetailLive Live { get; set; }
    [JsonPropertyName("api")]
    public LiveDetailApi[] Api { get; set; }
    [JsonPropertyName("media")]
    public LiveDetailMedia[] Media { get; set; }
    
}