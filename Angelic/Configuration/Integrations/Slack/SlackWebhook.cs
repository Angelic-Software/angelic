using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Configuration.Integrations.Slack;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class SlackWebhook
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Date { get; set; } 

    [JsonProperty("channel_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ChannelId { get; set; } 

    [JsonProperty("view_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ViewId { get; set; } 

    [JsonProperty("response_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ResponseUrl { get; set; } 

    [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TicketId { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}