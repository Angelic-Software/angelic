using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class FreshdeskPriority
{
    [JsonProperty("respond_within", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Respond_within { get; set; } 

    [JsonProperty("resolve_within", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Resolve_within { get; set; } 

    [JsonProperty("next_respond_within", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Next_respond_within { get; set; } 

    [JsonProperty("business_hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Business_hours { get; set; } 

    [JsonProperty("escalation_enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Escalation_enabled { get; set; } 

}