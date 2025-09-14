using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.Slack;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record SlackBlock
{
    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Type { get; set; } 

    [JsonProperty("block_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? BlockId { get; set; } 

    [JsonProperty("optional", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Optional { get; set; } 

    [JsonProperty("label", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public SlackBlockText? Label { get; set; } 

    [JsonProperty("text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public SlackBlockText? Text { get; set; } 

    [JsonProperty("fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<SlackBlockText>? Fields { get; set; } 

    [JsonProperty("elements", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<SlackBlockElement>? Elements { get; set; } 

    [JsonProperty("element", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public SlackBlockElement? Element { get; set; } 

    [JsonProperty("accessory", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public SlackBlockAccessory? Accessory { get; set; } 

    [JsonProperty("dispatch_action", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DispatchAction { get; set; } 

}