using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Items;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ItemDeviceDefaults
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("iid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? IId { get; set; } 

    [JsonProperty("dtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DType { get; set; } 

    [JsonProperty("yseq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? YSeq { get; set; } 

    [JsonProperty("value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Value { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}