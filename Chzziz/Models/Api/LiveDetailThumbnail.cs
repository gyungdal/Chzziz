using System.Text.Json.Serialization;

namespace Chzziz.Models.Api;

public class LiveDetailThumbnail {
    [JsonPropertyName("snapshotThumbnailTemplate")]
    public string SnapshotThumbnailTemplate { get; set; }
    [JsonPropertyName("types")]
    public string[] Types { get; set; }
}