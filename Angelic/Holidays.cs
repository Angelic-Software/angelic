using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Holidays
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Id { get; set; } 

    [JsonProperty("holid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Holid { get; set; } 

    [JsonProperty("workday_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Workday_id { get; set; } 

    [JsonProperty("workday_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Workday_guid { get; set; } 

    [JsonProperty("date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Date { get; set; } 

    [JsonProperty("end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? End_date { get; set; } 

    [JsonProperty("allday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Allday { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("duration", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Duration { get; set; } 

    [JsonProperty("holiday_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Holiday_type { get; set; } 

    [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Agent_id { get; set; } 

    [JsonProperty("agent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Agent_name { get; set; } 

    [JsonProperty("entity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Entity { get; set; } 

    [JsonProperty("_force", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _force { get; set; } 

    [JsonProperty("date_only", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Date_only { get; set; } 

    [JsonProperty("end_date_only", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? End_date_only { get; set; } 

    [JsonProperty("isrecurring", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Isrecurring { get; set; } 

    [JsonProperty("schedule", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Schedule? Schedule { get; set; } 

    [JsonProperty("schedulehandledtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Schedulehandledtype { get; set; } 

    [JsonProperty("createnextappt", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Createnextappt { get; set; } 

    [JsonProperty("approval_start", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Approval_start { get; set; } 

    [JsonProperty("approvalnote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Approvalnote { get; set; } 

    [JsonProperty("approval_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Approval_status { get; set; } 

    [JsonProperty("_return_appointment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _return_appointment { get; set; } 

    [JsonProperty("appointmentobj", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Appointment? Appointmentobj { get; set; } 

    [JsonProperty("thirdpartyid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Thirdpartyid { get; set; } 

    [JsonProperty("date_datetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Date_datetime { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

}