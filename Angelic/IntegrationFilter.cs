using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class IntegrationFilter
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("integration_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Integration_id { get; set; } 

    [JsonProperty("mapping_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Mapping_id { get; set; } 

    [JsonProperty("mapping_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Mapping_name { get; set; } 

    [JsonProperty("filter_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Filter_field { get; set; } 

    [JsonProperty("filter_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Filter_type { get; set; } 

    [JsonProperty("filter_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Filter_value { get; set; } 

    [JsonProperty("query_string", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Query_string { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

    [JsonProperty("details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Details_id { get; set; } 

    [JsonProperty("value_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Value_type { get; set; } 

    [JsonProperty("filter_operator", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Filter_operator { get; set; } 

    [JsonProperty("filter_type2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Filter_type2 { get; set; } 

}