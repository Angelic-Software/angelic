using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class SlackWebhook
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Date { get; set; } 

    [JsonProperty("channel_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Channel_id { get; set; } 

    [JsonProperty("view_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? View_id { get; set; } 

    [JsonProperty("response_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Response_url { get; set; } 

    [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Ticket_id { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

}