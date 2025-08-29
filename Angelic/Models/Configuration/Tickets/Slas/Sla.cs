using System.CodeDom.Compiler;
using Angelic.Models.Configuration.TeamsAndAgents;
using Angelic.Models.Configuration.TeamsAndAgents.Workdays;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Tickets.Slas;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Sla
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Guid { get; set; } 

    [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Intent { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("hoursaretechslocaltime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? HoursAreTechsLocalTime { get; set; } 

    [JsonProperty("workday_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? WorkdayId { get; set; } 

    [JsonProperty("workday_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? WorkdayGuid { get; set; } 

    [JsonProperty("responsereset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ResponseReset { get; set; } 

    [JsonProperty("autoreleaseoption", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AutoReleaseOption { get; set; } 

    [JsonProperty("workdays", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Workdays? Workdays { get; set; } 

    [JsonProperty("priorities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Priority>? Priorities { get; set; } 

    [JsonProperty("response_reset_approval", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ResponseResetApproval { get; set; } 

    [JsonProperty("autoreleaselimit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AutoReleaseLimit { get; set; } 

    [JsonProperty("trackslaresponsetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? TrackSlaResponseTime { get; set; } 

    [JsonProperty("trackslafixbytime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? TrackSlaFixByTime { get; set; } 

    [JsonProperty("statusafterautorelease", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? StatusAfterAutoRelease { get; set; } 

    [JsonProperty("slstatusafterfirstwarning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SlStatusAfterFirstWarning { get; set; } 

    [JsonProperty("slstatusaftersecondwarning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SlStatusAfterSecondWarning { get; set; } 

    [JsonProperty("workday_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? WorkdayName { get; set; } 

    [JsonProperty("dontsendholdreminders", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DontSendHoldReminders { get; set; } 

    [JsonProperty("statusafterautorelease_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? StatusAfterAutoReleaseName { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("access_control", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AccessControl>? AccessControl { get; set; } 

    [JsonProperty("access_control_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AccessControlLevel { get; set; } 

}