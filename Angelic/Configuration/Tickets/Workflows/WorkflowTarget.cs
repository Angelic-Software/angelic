using System.CodeDom.Compiler;
using Angelic.Configuration.Tickets.TicketRule;
using Newtonsoft.Json;

namespace Angelic.Configuration.Tickets.Workflows;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class WorkflowTarget
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("flow_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? FlowId { get; set; } 

    [JsonProperty("flow_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? FlowGuid { get; set; } 

    [JsonProperty("target_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TargetType { get; set; } 

    [JsonProperty("start_stage_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? StartStageId { get; set; } 

    [JsonProperty("start_stage_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? StartStageName { get; set; } 

    [JsonProperty("end_stage_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? EndStageId { get; set; } 

    [JsonProperty("end_stage_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EndStageName { get; set; } 

    [JsonProperty("start_steps", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<WorkflowTargetStep>? StartSteps { get; set; } 

    [JsonProperty("end_steps", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<WorkflowTargetStep>? EndSteps { get; set; } 

    [JsonProperty("target", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Target { get; set; } 

    [JsonProperty("target_units", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TargetUnits { get; set; } 

    [JsonProperty("workday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Workday { get; set; } 

    [JsonProperty("workday_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? WorkdayName { get; set; } 

    [JsonProperty("rules", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<TicketRules>? Rules { get; set; } 

    [JsonProperty("rule_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RuleId { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}