using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class PartsLookupMapping
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("lookup_profile_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Lookup_profile_id { get; set; } 

    [JsonProperty("field_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Field_id { get; set; } 

    [JsonProperty("field_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Field_name { get; set; } 

    [JsonProperty("lookup_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Lookup_field { get; set; } 

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Type { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

}