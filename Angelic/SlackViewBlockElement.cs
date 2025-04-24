using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class SlackViewBlockElement
{
    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Type { get; set; } 

    [JsonProperty("action_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Action_id { get; set; } 

    [JsonProperty("multiline", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Multiline { get; set; } 

    [JsonProperty("initial_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Initial_value { get; set; } 

}