using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Ticket;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class TicketOla
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("fault_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? FaultId { get; set; } 

    [JsonProperty("target_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TargetId { get; set; } 

    [JsonProperty("target_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TargetName { get; set; } 

    [JsonProperty("target_hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TargetHours { get; set; } 

    [JsonProperty("actual_hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? ActualHours { get; set; } 

    [JsonProperty("target_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? TargetDate { get; set; } 

    [JsonProperty("target_met", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? TargetMet { get; set; } 

    [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Status { get; set; } 

    [JsonProperty("dates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<TicketOlaDates>? Dates { get; set; } 

    [JsonProperty("target", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public WorkflowTarget? Target { get; set; } 

    [JsonProperty("start_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? StartDate { get; set; } 

    [JsonProperty("pause_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? PauseDate { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? EndDate { get; set; } 

}