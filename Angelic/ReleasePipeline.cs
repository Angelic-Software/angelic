using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ReleasePipeline
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("integration_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Integration_link { get; set; } 

    [JsonProperty("linked_product", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Linked_product { get; set; } 

    [JsonProperty("devops_pipeline_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Devops_pipeline_id { get; set; } 

    [JsonProperty("devops_details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Devops_details_id { get; set; } 

    [JsonProperty("active", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Active { get; set; } 

    [JsonProperty("devops_project_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Devops_project_id { get; set; } 

    [JsonProperty("pipeline_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IntegrationFieldMapping>? Pipeline_mappings { get; set; } 

    [JsonProperty("linked_product_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Linked_product_name { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

}