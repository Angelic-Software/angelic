using System.CodeDom.Compiler;
using Angelic.Configuration.TeamsAndAgents;
using Newtonsoft.Json;

namespace Angelic.Configuration;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Priority
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Id { get; set; } 

    [JsonProperty("slaid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Slaid { get; set; } 

    [JsonProperty("sla_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? SlaGuid { get; set; } 

    [JsonProperty("priorityid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Priorityid { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("fixtime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Fixtime { get; set; } 

    [JsonProperty("fixunits", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Fixunits { get; set; } 

    [JsonProperty("enterslaexcuse", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Enterslaexcuse { get; set; } 

    [JsonProperty("responsetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Responsetime { get; set; } 

    [JsonProperty("responseunits", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Responseunits { get; set; } 

    [JsonProperty("ishidden", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Ishidden { get; set; } 

    [JsonProperty("fixendofday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Fixendofday { get; set; } 

    [JsonProperty("responseendofday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Responseendofday { get; set; } 

    [JsonProperty("colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Colour { get; set; } 

    [JsonProperty("catprompt", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Catprompt { get; set; } 

    [JsonProperty("workdaysoverride", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Workdaysoverride { get; set; } 

    [JsonProperty("responsestartofday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Responsestartofday { get; set; } 

    [JsonProperty("responsestartofdaytime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Responsestartofdaytime { get; set; } 

    [JsonProperty("startofday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Startofday { get; set; } 

    [JsonProperty("startofdaytime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Startofdaytime { get; set; } 

    [JsonProperty("workdays", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Workdays? Workdays { get; set; } 

    [JsonProperty("setfixtostartdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Setfixtostartdate { get; set; } 

    [JsonProperty("setfixtotargetdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Setfixtotargetdate { get; set; } 

    [JsonProperty("translations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<LanguagePackTranslationsCustom>? Translations { get; set; } 

    [JsonProperty("enterslaresponseexcuse", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Enterslaresponseexcuse { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}