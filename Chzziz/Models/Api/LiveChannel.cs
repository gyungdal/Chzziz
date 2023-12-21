using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Chzziz.Models.Api;

public class LiveChannel {
    [JsonPropertyName("channelId")]
    public string ChannelId { get; set; }
    [JsonPropertyName("channelName")]
    public string ChannelName { get; set; }
    [JsonPropertyName("channelImageUrl")]
    public string ChannelImageUrl { get; set; }
    [JsonPropertyName("verifiedMark")]
    public bool VerifiedMark { get; set; }
}