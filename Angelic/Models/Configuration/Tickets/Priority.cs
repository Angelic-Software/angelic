using System.CodeDom.Compiler;
using Angelic.Models.Configuration.Language;
using Angelic.Models.Configuration.TeamsAndAgents;
using Angelic.Models.Configuration.TeamsAndAgents.Workdays;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Tickets;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Priority
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Id { get; set; } 

    [JsonProperty("slaid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SlaId { get; set; } 

    [JsonProperty("sla_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? SlaGuid { get; set; } 

    [JsonProperty("priorityid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PriorityId { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("fixtime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? FixTime { get; set; } 

    [JsonProperty("fixunits", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? FixUnits { get; set; } 

    [JsonProperty("enterslaexcuse", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? EnterSlaExcuse { get; set; } 

    [JsonProperty("responsetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? ResponseTime { get; set; } 

    [JsonProperty("responseunits", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ResponseUnits { get; set; } 

    [JsonProperty("ishidden", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsHidden { get; set; } 

    [JsonProperty("fixendofday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? FixEndOfDay { get; set; } 

    [JsonProperty("responseendofday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ResponseEndOfDay { get; set; } 

    [JsonProperty("colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Colour { get; set; } 

    [JsonProperty("catprompt", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CatPrompt { get; set; } 

    [JsonProperty("workdaysoverride", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? WorkdaysOverride { get; set; } 

    [JsonProperty("responsestartofday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ResponseStartOfDay { get; set; } 

    [JsonProperty("responsestartofdaytime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ResponseStartOfDayTime { get; set; } 

    [JsonProperty("startofday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? StartOfDay { get; set; } 

    [JsonProperty("startofdaytime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? StartOfDayTime { get; set; } 

    [JsonProperty("workdays", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Workdays? Workdays { get; set; } 

    [JsonProperty("setfixtostartdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? SetFixToStartDate { get; set; } 

    [JsonProperty("setfixtotargetdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? SetFixToTargetDate { get; set; } 

    [JsonProperty("translations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<LanguagePackTranslationsCustom>? Translations { get; set; } 

    [JsonProperty("enterslaresponseexcuse", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? EnterSlaResponseExcuse { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}