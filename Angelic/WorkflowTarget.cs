using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class WorkflowTarget
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("flow_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Flow_id { get; set; } 

    [JsonProperty("flow_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Flow_guid { get; set; } 

    [JsonProperty("target_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Target_type { get; set; } 

    [JsonProperty("start_stage_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Start_stage_id { get; set; } 

    [JsonProperty("start_stage_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Start_stage_name { get; set; } 

    [JsonProperty("end_stage_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? End_stage_id { get; set; } 

    [JsonProperty("end_stage_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? End_stage_name { get; set; } 

    [JsonProperty("start_steps", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<WorkflowTargetStep>? Start_steps { get; set; } 

    [JsonProperty("end_steps", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<WorkflowTargetStep>? End_steps { get; set; } 

    [JsonProperty("target", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Target { get; set; } 

    [JsonProperty("target_units", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Target_units { get; set; } 

    [JsonProperty("workday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Workday { get; set; } 

    [JsonProperty("workday_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Workday_name { get; set; } 

    [JsonProperty("rules", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Autoassign>? Rules { get; set; } 

    [JsonProperty("rule_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Rule_id { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

}