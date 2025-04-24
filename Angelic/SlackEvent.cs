using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class SlackEvent
{
    [JsonProperty("client_msg_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Client_msg_id { get; set; } 

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Type { get; set; } 

    [JsonProperty("text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Text { get; set; } 

    [JsonProperty("user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? User { get; set; } 

    [JsonProperty("ts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Ts { get; set; } 

    [JsonProperty("team", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Team { get; set; } 

    [JsonProperty("channel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Channel { get; set; } 

    [JsonProperty("event_ts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Event_ts { get; set; } 

    [JsonProperty("channel_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Channel_type { get; set; } 

    [JsonProperty("blocks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<SlackBlock>? Blocks { get; set; } 

}