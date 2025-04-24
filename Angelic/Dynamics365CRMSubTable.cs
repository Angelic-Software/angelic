using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Dynamics365CRMSubTable
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("parent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Parent_id { get; set; } 

    [JsonProperty("dynamics_table", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Dynamics_table { get; set; } 

    [JsonProperty("entityname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Entityname { get; set; } 

    [JsonProperty("parentidfield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Parentidfield { get; set; } 

    [JsonProperty("child_field_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IntegrationFieldMapping>? Child_field_mappings { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

}