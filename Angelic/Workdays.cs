using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Workdays
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
    public string? Timezone { get; set; } 

    [JsonProperty("start", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Start { get; set; } 

    [JsonProperty("end", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? End { get; set; } 

    [JsonProperty("incmonday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Incmonday { get; set; } 

    [JsonProperty("inctuesday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Inctuesday { get; set; } 

    [JsonProperty("incwednesday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Incwednesday { get; set; } 

    [JsonProperty("incthursday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Incthursday { get; set; } 

    [JsonProperty("incfriday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Incfriday { get; set; } 

    [JsonProperty("incsaturday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Incsaturday { get; set; } 

    [JsonProperty("incsunday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Incsunday { get; set; } 

    [JsonProperty("alldayssame", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Alldayssame { get; set; } 

    [JsonProperty("endmonday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Endmonday { get; set; } 

    [JsonProperty("endtuesday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Endtuesday { get; set; } 

    [JsonProperty("endwednesday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Endwednesday { get; set; } 

    [JsonProperty("endthursday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Endthursday { get; set; } 

    [JsonProperty("endfriday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Endfriday { get; set; } 

    [JsonProperty("endsaturday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Endsaturday { get; set; } 

    [JsonProperty("endsunday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Endsunday { get; set; } 

    [JsonProperty("startmonday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Startmonday { get; set; } 

    [JsonProperty("starttuesday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Starttuesday { get; set; } 

    [JsonProperty("startwednesday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Startwednesday { get; set; } 

    [JsonProperty("startthursday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Startthursday { get; set; } 

    [JsonProperty("startfriday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Startfriday { get; set; } 

    [JsonProperty("startsaturday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Startsaturday { get; set; } 

    [JsonProperty("startsunday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Startsunday { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

    [JsonProperty("holidays", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Holidays>? Holidays { get; set; } 

    [JsonProperty("timeslots", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Timeslot>? Timeslots { get; set; } 

    [JsonProperty("access_control", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AccessControl>? Access_control { get; set; } 

    [JsonProperty("access_control_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Access_control_level { get; set; } 

    [JsonProperty("breaks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<WorkdayBreak>? Breaks { get; set; } 

}