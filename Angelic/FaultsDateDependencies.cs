using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class FaultsDateDependencies
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("parentfaultid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Parentfaultid { get; set; } 

    [JsonProperty("faultid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Faultid { get; set; } 

    [JsonProperty("dependentfaultid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Dependentfaultid { get; set; } 

    [JsonProperty("applied_from_template", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Applied_from_template { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

}