using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class EventMapping
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("eventrule_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Eventrule_id { get; set; } 

    [JsonProperty("eventrule_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Eventrule_guid { get; set; } 

    [JsonProperty("integration_method_value_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Integration_method_value_id { get; set; } 

    [JsonProperty("integration_method_value_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Integration_method_value_name { get; set; } 

    [JsonProperty("field_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Field_id { get; set; } 

    [JsonProperty("field_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Field_name { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

}