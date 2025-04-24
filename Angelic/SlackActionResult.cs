using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class SlackActionResult
{
    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Type { get; set; } 

    [JsonProperty("block_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Block_id { get; set; } 

    [JsonProperty("action_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Action_id { get; set; } 

    [JsonProperty("value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Value { get; set; } 

    [JsonProperty("action_ts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Action_ts { get; set; } 

}