using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.Slack;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class SlackCommandDetail
{
    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public SlackCommandType? Type { get; set; } 

    [JsonProperty("application", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public WorkspaceApplication? Application { get; set; } 

    [JsonProperty("user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public SlackServiceUser? User { get; set; } 

    [JsonProperty("attributes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public IDictionary<string, object?>? Attributes { get; set; } 

    [JsonProperty("webhook", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public SlackWebhook? Webhook { get; set; } 

}