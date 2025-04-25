using System.CodeDom.Compiler;
using Angelic.Configuration.TeamsAndAgents;
using Newtonsoft.Json;

namespace Angelic.Configuration.Tickets;

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
    public bool? Hoursaretechslocaltime { get; set; } 

    [JsonProperty("workday_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? WorkdayId { get; set; } 

    [JsonProperty("workday_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? WorkdayGuid { get; set; } 

    [JsonProperty("responsereset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Responsereset { get; set; } 

    [JsonProperty("autoreleaseoption", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Autoreleaseoption { get; set; } 

    [JsonProperty("workdays", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Workdays? Workdays { get; set; } 

    [JsonProperty("priorities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Priority>? Priorities { get; set; } 

    [JsonProperty("response_reset_approval", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ResponseResetApproval { get; set; } 

    [JsonProperty("autoreleaselimit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Autoreleaselimit { get; set; } 

    [JsonProperty("trackslaresponsetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Trackslaresponsetime { get; set; } 

    [JsonProperty("trackslafixbytime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Trackslafixbytime { get; set; } 

    [JsonProperty("statusafterautorelease", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Statusafterautorelease { get; set; } 

    [JsonProperty("slstatusafterfirstwarning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Slstatusafterfirstwarning { get; set; } 

    [JsonProperty("slstatusaftersecondwarning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Slstatusaftersecondwarning { get; set; } 

    [JsonProperty("workday_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? WorkdayName { get; set; } 

    [JsonProperty("dontsendholdreminders", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Dontsendholdreminders { get; set; } 

    [JsonProperty("statusafterautorelease_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? StatusafterautoreleaseName { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("access_control", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AccessControl>? AccessControl { get; set; } 

    [JsonProperty("access_control_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AccessControlLevel { get; set; } 

}