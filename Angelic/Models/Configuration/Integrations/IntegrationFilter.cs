using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record IntegrationFilter
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("integration_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? IntegrationId { get; set; } 

    [JsonProperty("mapping_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MappingId { get; set; } 

    [JsonProperty("mapping_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MappingName { get; set; } 

    [JsonProperty("filter_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? FilterField { get; set; } 

    [JsonProperty("filter_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? FilterType { get; set; } 

    [JsonProperty("filter_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? FilterValue { get; set; } 

    [JsonProperty("query_string", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? QueryString { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DetailsId { get; set; } 

    [JsonProperty("value_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ValueType { get; set; } 

    [JsonProperty("filter_operator", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? FilterOperator { get; set; } 

    [JsonProperty("filter_type2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? FilterType2 { get; set; } 

}