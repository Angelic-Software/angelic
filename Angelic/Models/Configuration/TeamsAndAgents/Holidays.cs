using System.CodeDom.Compiler;
using Angelic.Models.Appointments;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.TeamsAndAgents;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Holidays
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Id { get; set; } 

    [JsonProperty("holid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? HolId { get; set; } 

    [JsonProperty("workday_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? WorkdayId { get; set; } 

    [JsonProperty("workday_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? WorkdayGuid { get; set; } 

    [JsonProperty("date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Date { get; set; } 

    [JsonProperty("end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? EndDate { get; set; } 

    [JsonProperty("allday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllDay { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("duration", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Duration { get; set; } 

    [JsonProperty("holiday_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? HolidayType { get; set; } 

    [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AgentId { get; set; } 

    [JsonProperty("agent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AgentName { get; set; } 

    [JsonProperty("entity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Entity { get; set; } 

    [JsonProperty("_force", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Force { get; set; } 

    [JsonProperty("date_only", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? DateOnly { get; set; } 

    [JsonProperty("end_date_only", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? EndDateOnly { get; set; } 

    [JsonProperty("isrecurring", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsRecurring { get; set; } 

    [JsonProperty("schedule", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Schedule? Schedule { get; set; } 

    [JsonProperty("schedulehandledtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ScheduleHandledType { get; set; } 

    [JsonProperty("createnextappt", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CreateNextAppt { get; set; } 

    [JsonProperty("approval_start", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ApprovalStart { get; set; } 

    [JsonProperty("approvalnote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ApprovalNote { get; set; } 

    [JsonProperty("approval_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ApprovalStatus { get; set; } 

    [JsonProperty("_return_appointment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ReturnAppointment { get; set; } 

    [JsonProperty("appointmentobj", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Appointment? AppointmentObj { get; set; } 

    [JsonProperty("thirdpartyid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ThirdPartyId { get; set; } 

    [JsonProperty("date_datetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? DateDateTime { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}