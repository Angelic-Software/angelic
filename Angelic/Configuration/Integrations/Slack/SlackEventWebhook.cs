using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Configuration.Integrations.Slack;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class SlackEventWebhook
{
    [JsonProperty("token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Token { get; set; } 

    [JsonProperty("challenge", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Challenge { get; set; } 

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Type { get; set; } 

    [JsonProperty("event_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EventId { get; set; } 

    [JsonProperty("event_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public long? EventTime { get; set; } 

    [JsonProperty("team_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TeamId { get; set; } 

    [JsonProperty("context_team_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ContextTeamId { get; set; } 

    [JsonProperty("context_enterprise_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ContextEnterpriseId { get; set; } 

    [JsonProperty("api_app_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ApiAppId { get; set; } 

    [JsonProperty("is_ext_shared_channel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsExtSharedChannel { get; set; } 

    [JsonProperty("event", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public SlackEvent? Event { get; set; } 

    [JsonProperty("eventtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public SlackEventType? EventType { get; set; } 

}