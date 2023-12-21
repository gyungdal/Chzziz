using System.Runtime.InteropServices.JavaScript;
using System.Text.Json.Serialization;

namespace Chzziz.Models.Api;

public class LiveDetailLive {
    [JsonPropertyName("start")]
    public JSType.Date Start { get; set; }
    [JsonPropertyName("open")]
    public JSType.Date Open { get; set; }
    [JsonPropertyName("timeMachine")]
    public bool TimeMachine { get; set; }
    [JsonPropertyName("status")]
    public string Status { get; set; }
}