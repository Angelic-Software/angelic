using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class MileStoneDependency
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("child", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Child { get; set; } 

    [JsonProperty("parent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Parent { get; set; } 

    [JsonProperty("parent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Parent_name { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

}