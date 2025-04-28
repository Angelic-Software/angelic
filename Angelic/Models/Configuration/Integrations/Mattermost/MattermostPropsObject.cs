using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.Mattermost;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class MattermostPropsObject
{
    [JsonProperty("from_webhook", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? FromWebhook { get; set; } 

    [JsonProperty("haloid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Haloid { get; set; } 

    [JsonProperty("override_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OverrideUsername { get; set; } 

    [JsonProperty("webhook_display_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? WebhookDisplayName { get; set; } 

}