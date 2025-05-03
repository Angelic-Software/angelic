using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Tag
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Text { get; set; } 

    [JsonProperty("add_to_kbid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AddToKbId { get; set; } 

    [JsonProperty("add_to_ctid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AddToCtId { get; set; } 

    [JsonProperty("add_to_stid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AddToStId { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}