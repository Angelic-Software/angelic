using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class FaultRuleMatch
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("fault_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Fault_id { get; set; } 

    [JsonProperty("rule_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Rule_id { get; set; } 

    [JsonProperty("rule_sequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Rule_sequence { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

    [JsonProperty("popupmsg", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Popupmsg { get; set; } 

}