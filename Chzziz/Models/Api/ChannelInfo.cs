using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace Chzziz.Models.Api;

public class ChannelInfo : LiveChannel {
    [JsonPropertyName("channelType")]
    public string ChannelType { get; set; }
    [JsonPropertyName("channelDescription")]
    public string ChannelDescription { get; set; }
    [JsonPropertyName("followerCount")]
    public int FollowerCount { get; set; }
    [JsonPropertyName("openLive")]
    public bool OpenLive { get; set; }
}