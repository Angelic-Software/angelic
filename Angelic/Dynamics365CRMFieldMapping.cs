using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Dynamics365CRMFieldMapping
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("halo_table", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Halo_table { get; set; } 

    [JsonProperty("dynamics_table", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Dynamics_table { get; set; } 

    [JsonProperty("enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Enabled { get; set; } 

    [JsonProperty("synctype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Synctype { get; set; } 

    [JsonProperty("idfield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Idfield { get; set; } 

    [JsonProperty("details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Details_id { get; set; } 

    [JsonProperty("entity_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Entity_name { get; set; } 

    [JsonProperty("child_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Dynamics365CRMSubTable>? Child_mappings { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

    [JsonProperty("field_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IntegrationFieldMapping>? Field_mappings { get; set; } 

}