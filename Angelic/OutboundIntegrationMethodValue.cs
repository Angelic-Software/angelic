using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class OutboundIntegrationMethodValue
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("method_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Method_id { get; set; } 

    [JsonProperty("runbook_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Runbook_id { get; set; } 

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Type { get; set; } 

    [JsonProperty("data_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Data_type { get; set; } 

    [JsonProperty("key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Key { get; set; } 

    [JsonProperty("value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Value { get; set; } 

    [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Description { get; set; } 

    [JsonProperty("value_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<OutboundIntegrationMethodValueMapping>? Value_mappings { get; set; } 

    [JsonProperty("extra_process", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Extra_process { get; set; } 

    [JsonProperty("step_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Step_id { get; set; } 

    [JsonProperty("step_seq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Step_seq { get; set; } 

    [JsonProperty("step_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Step_name { get; set; } 

    [JsonProperty("persist", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Persist { get; set; } 

    [JsonProperty("mapping_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Mapping_type { get; set; } 

    [JsonProperty("object_mapping", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Object_mapping { get; set; } 

    [JsonProperty("rule_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Rule_id { get; set; } 

    [JsonProperty("rule_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Rule_guid { get; set; } 

}