using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class WorkflowHistory
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TicketId { get; set; } 

    [JsonProperty("moved_from", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MovedFrom { get; set; } 

    [JsonProperty("moved_to", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MovedTo { get; set; } 

    [JsonProperty("flow_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? FlowId { get; set; } 

    [JsonProperty("moved_from_stage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MovedFromStage { get; set; } 

    [JsonProperty("moved_to_stage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MovedToStage { get; set; } 

    [JsonProperty("moved_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? MovedDate { get; set; } 

    [JsonProperty("target_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? TargetDate { get; set; } 

    [JsonProperty("target_hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TargetHours { get; set; } 

    [JsonProperty("actual_hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? ActualHours { get; set; } 

    [JsonProperty("target_met", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? TargetMet { get; set; } 

    [JsonProperty("override_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? OverrideDate { get; set; } 

    [JsonProperty("summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Summary { get; set; } 

    [JsonProperty("action_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ActionId { get; set; } 

}