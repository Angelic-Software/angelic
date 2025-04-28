using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Timesheet;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Timesheet
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AgentId { get; set; } 

    [JsonProperty("agent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AgentName { get; set; } 

    [JsonProperty("colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Colour { get; set; } 

    [JsonProperty("date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Date { get; set; } 

    [JsonProperty("start_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? StartTime { get; set; } 

    [JsonProperty("end_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? EndTime { get; set; } 

    [JsonProperty("estimated_start_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? EstimatedStartTime { get; set; } 

    [JsonProperty("estimated_end_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? EstimatedEndTime { get; set; } 

    [JsonProperty("target_hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TargetHours { get; set; } 

    [JsonProperty("actual_hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? ActualHours { get; set; } 

    [JsonProperty("break_hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? BreakHours { get; set; } 

    [JsonProperty("unlogged_hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? UnloggedHours { get; set; } 

    [JsonProperty("allowed_break_hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? AllowedBreakHours { get; set; } 

    [JsonProperty("work_hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? WorkHours { get; set; } 

    [JsonProperty("percentage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Percentage { get; set; } 

    [JsonProperty("workdayid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Workdayid { get; set; } 

    [JsonProperty("events", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<TimesheetEvent>? Events { get; set; } 

    [JsonProperty("timesheet_manager", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TimesheetManager { get; set; } 

    [JsonProperty("forecasting_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ForecastingId { get; set; } 

    [JsonProperty("_submitapproval", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Submitapproval { get; set; } 

    [JsonProperty("_approve", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Approve { get; set; } 

    [JsonProperty("_reject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Reject { get; set; } 

    [JsonProperty("approval", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public TimesheetApproval? Approval { get; set; } 

    [JsonProperty("_approval_message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ApprovalMessage { get; set; } 

    [JsonProperty("chargeable_hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? ChargeableHours { get; set; } 

    [JsonProperty("forecasting_hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? ForecastingHours { get; set; } 

}