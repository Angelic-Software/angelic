using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.Custom;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CustomIntegrationMethodValue
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("method_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MethodId { get; set; } 

    [JsonProperty("runbook_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RunbookId { get; set; } 

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Type { get; set; } 

    [JsonProperty("data_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DataType { get; set; } 

    [JsonProperty("key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Key { get; set; } 

    [JsonProperty("value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Value { get; set; } 

    [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Description { get; set; } 

    [JsonProperty("value_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomIntegrationMethodValueMapping>? ValueMappings { get; set; } 

    [JsonProperty("extra_process", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ExtraProcess { get; set; } 

    [JsonProperty("step_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? StepId { get; set; } 

    [JsonProperty("step_seq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? StepSeq { get; set; } 

    [JsonProperty("step_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? StepName { get; set; } 

    [JsonProperty("persist", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Persist { get; set; } 

    [JsonProperty("mapping_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MappingType { get; set; } 

    [JsonProperty("object_mapping", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ObjectMapping { get; set; } 

    [JsonProperty("rule_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RuleId { get; set; } 

    [JsonProperty("rule_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? RuleGuid { get; set; } 

}