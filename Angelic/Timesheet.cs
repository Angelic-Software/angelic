using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Timesheet
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Agent_id { get; set; } 

    [JsonProperty("agent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Agent_name { get; set; } 

    [JsonProperty("colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Colour { get; set; } 

    [JsonProperty("date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Date { get; set; } 

    [JsonProperty("start_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Start_time { get; set; } 

    [JsonProperty("end_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? End_time { get; set; } 

    [JsonProperty("estimated_start_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Estimated_start_time { get; set; } 

    [JsonProperty("estimated_end_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Estimated_end_time { get; set; } 

    [JsonProperty("target_hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Target_hours { get; set; } 

    [JsonProperty("actual_hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Actual_hours { get; set; } 

    [JsonProperty("break_hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Break_hours { get; set; } 

    [JsonProperty("unlogged_hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Unlogged_hours { get; set; } 

    [JsonProperty("allowed_break_hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Allowed_break_hours { get; set; } 

    [JsonProperty("work_hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Work_hours { get; set; } 

    [JsonProperty("percentage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Percentage { get; set; } 

    [JsonProperty("workdayid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Workdayid { get; set; } 

    [JsonProperty("events", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<TimesheetEvent>? Events { get; set; } 

    [JsonProperty("timesheet_manager", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Timesheet_manager { get; set; } 

    [JsonProperty("forecasting_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Forecasting_id { get; set; } 

    [JsonProperty("_submitapproval", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _submitapproval { get; set; } 

    [JsonProperty("_approve", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _approve { get; set; } 

    [JsonProperty("_reject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _reject { get; set; } 

    [JsonProperty("approval", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public TimesheetApproval? Approval { get; set; } 

    [JsonProperty("_approval_message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _approval_message { get; set; } 

    [JsonProperty("chargeable_hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Chargeable_hours { get; set; } 

    [JsonProperty("forecasting_hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Forecasting_hours { get; set; } 

}