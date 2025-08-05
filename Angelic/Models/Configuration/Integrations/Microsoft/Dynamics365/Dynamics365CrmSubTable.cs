using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.Microsoft.Dynamics365;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Dynamics365CrmSubTable
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("parent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ParentId { get; set; } 

    [JsonProperty("dynamics_table", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DynamicsTable { get; set; } 

    [JsonProperty("entityname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EntityName { get; set; } 

    [JsonProperty("parentidfield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ParentIdField { get; set; } 

    [JsonProperty("child_field_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IntegrationFieldMapping>? ChildFieldMappings { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}