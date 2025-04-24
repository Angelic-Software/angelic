using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Configuration.Integrations.Slack;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class SlackBlockElement
{
    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Type { get; set; } 

    [JsonProperty("text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public SlackBlockText? Text { get; set; } 

    [JsonProperty("style", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Style { get; set; } 

    [JsonProperty("value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Value { get; set; } 

    [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Url { get; set; } 

    [JsonProperty("action_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ActionId { get; set; } 

    [JsonProperty("multiline", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Multiline { get; set; } 

    [JsonProperty("initial_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? InitialValue { get; set; } 

    [JsonProperty("is_decimal_allowed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsDecimalAllowed { get; set; } 

    [JsonProperty("dispatch_action_config", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public SlackBlockElementDispatchActionConfig? DispatchActionConfig { get; set; } 

}