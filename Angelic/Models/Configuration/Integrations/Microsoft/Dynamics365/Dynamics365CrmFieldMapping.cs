using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.Microsoft.Dynamics365;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Dynamics365CrmFieldMapping
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("halo_table", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? HaloTable { get; set; } 

    [JsonProperty("dynamics_table", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DynamicsTable { get; set; } 

    [JsonProperty("enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Enabled { get; set; } 

    [JsonProperty("synctype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Synctype { get; set; } 

    [JsonProperty("idfield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Idfield { get; set; } 

    [JsonProperty("details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DetailsId { get; set; } 

    [JsonProperty("entity_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EntityName { get; set; } 

    [JsonProperty("child_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Dynamics365CrmSubTable>? ChildMappings { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("field_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IntegrationFieldMapping>? FieldMappings { get; set; } 

}