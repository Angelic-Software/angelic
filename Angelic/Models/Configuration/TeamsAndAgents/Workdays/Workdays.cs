using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.TeamsAndAgents.Workdays;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record Workdays
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Guid { get; set; } 

    [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Intent { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Summary { get; set; } 

    [JsonProperty("timezone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TimeZone { get; set; } 

    [JsonProperty("start", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Start { get; set; } 

    [JsonProperty("end", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? End { get; set; } 

    [JsonProperty("incmonday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IncMonday { get; set; } 

    [JsonProperty("inctuesday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IncTuesday { get; set; } 

    [JsonProperty("incwednesday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IncWednesday { get; set; } 

    [JsonProperty("incthursday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IncThursday { get; set; } 

    [JsonProperty("incfriday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IncFriday { get; set; } 

    [JsonProperty("incsaturday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IncSaturday { get; set; } 

    [JsonProperty("incsunday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IncSunday { get; set; } 

    [JsonProperty("alldayssame", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllDaysSame { get; set; } 

    [JsonProperty("endmonday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? EndMonday { get; set; } 

    [JsonProperty("endtuesday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? EndTuesday { get; set; } 

    [JsonProperty("endwednesday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? EndWednesday { get; set; } 

    [JsonProperty("endthursday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? EndThursday { get; set; } 

    [JsonProperty("endfriday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? EndFriday { get; set; } 

    [JsonProperty("endsaturday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? EndSaturday { get; set; } 

    [JsonProperty("endsunday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? EndSunday { get; set; } 

    [JsonProperty("startmonday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? StartMonday { get; set; } 

    [JsonProperty("starttuesday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? StartTuesday { get; set; } 

    [JsonProperty("startwednesday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? StartWednesday { get; set; } 

    [JsonProperty("startthursday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? StartThursday { get; set; } 

    [JsonProperty("startfriday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? StartFriday { get; set; } 

    [JsonProperty("startsaturday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? StartSaturday { get; set; } 

    [JsonProperty("startsunday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? StartSunday { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("holidays", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Holidays>? Holidays { get; set; } 

    [JsonProperty("timeslots", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Timeslot>? Timeslots { get; set; } 

    [JsonProperty("access_control", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AccessControl>? AccessControl { get; set; } 

    [JsonProperty("access_control_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AccessControlLevel { get; set; } 

    [JsonProperty("breaks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<WorkdayBreak>? Breaks { get; set; } 

}