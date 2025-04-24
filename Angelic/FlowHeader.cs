using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class FlowHeader
{
    [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Guid { get; set; } 

    [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Intent { get; set; } 

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Note { get; set; } 

    [JsonProperty("notinuse", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Notinuse { get; set; } 

    [JsonProperty("flow_chart_json", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Flow_chart_json { get; set; } 

    [JsonProperty("steps", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<FlowDetail>? Steps { get; set; } 

    [JsonProperty("always_allow_actions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<TOutcome>? Always_allow_actions { get; set; } 

    [JsonProperty("active", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Active { get; set; } 

    [JsonProperty("stages", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<FlowStages>? Stages { get; set; } 

    [JsonProperty("in_use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? In_use { get; set; } 

    [JsonProperty("access_control", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AccessControl>? Access_control { get; set; } 

    [JsonProperty("access_control_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Access_control_level { get; set; } 

    [JsonProperty("targets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<WorkflowTarget>? Targets { get; set; } 

    [JsonProperty("workflow_history", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<WorkflowHistory>? Workflow_history { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

}