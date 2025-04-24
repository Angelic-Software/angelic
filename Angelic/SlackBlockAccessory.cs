using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class SlackBlockAccessory
{
    [JsonProperty("action_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Action_id { get; set; } 

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Type { get; set; } 

    [JsonProperty("min_query_length", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Min_query_length { get; set; } 

    [JsonProperty("placeholder", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public SlackBlockText? Placeholder { get; set; } 

    [JsonProperty("initial_option", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public SlackOption? Initial_option { get; set; } 

}