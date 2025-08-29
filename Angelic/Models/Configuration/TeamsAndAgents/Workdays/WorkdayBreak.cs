using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.TeamsAndAgents.Workdays;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class WorkdayBreak
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("workday_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? WorkdayId { get; set; } 

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

}