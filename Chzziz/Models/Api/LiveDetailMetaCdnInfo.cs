using System.Text.Json.Serialization;

namespace Chzziz.Models.Api;

public class LiveDetailMetaCdnInfo {
    [JsonPropertyName("cdnType")]
    public string CdnType { get; set; }
    [JsonPropertyName("zeroRating")]
    public bool ZeroRating { get; set; }
}