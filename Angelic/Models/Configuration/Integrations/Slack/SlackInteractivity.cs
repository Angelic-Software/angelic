using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.Slack;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record SlackInteractivity
{
    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Type { get; set; } 

    [JsonProperty("token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Token { get; set; } 

    [JsonProperty("action_ts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ActionTs { get; set; } 

    [JsonProperty("api_app_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ApiAppId { get; set; } 

    [JsonProperty("team", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public SlackTeam? Team { get; set; } 

    [JsonProperty("user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public SlackUser? User { get; set; } 

    [JsonProperty("channel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public SlackChannel? Channel { get; set; } 

    [JsonProperty("is_enterprise_install", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsEnterpriseInstall { get; set; } 

    [JsonProperty("callback_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CallbackId { get; set; } 

    [JsonProperty("trigger_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TriggerId { get; set; } 

    [JsonProperty("response_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ResponseUrl { get; set; } 

    [JsonProperty("message_ts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MessageTs { get; set; } 

    [JsonProperty("message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public SlackMessage? Message { get; set; } 

    [JsonProperty("view", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public SlackView? View { get; set; } 

    [JsonProperty("actions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<SlackActionResult>? Actions { get; set; } 

    [JsonProperty("detail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public SlackCommandDetail? Detail { get; set; } 

}