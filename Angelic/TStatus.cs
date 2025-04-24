using System.CodeDom.Compiler;
using Angelic.KeyPairs;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Status
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Guid { get; set; } 

    [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Intent { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("shortname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Shortname { get; set; } 

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Type { get; set; } 

    [JsonProperty("sequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sequence { get; set; } 

    [JsonProperty("colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Colour { get; set; } 

    [JsonProperty("slaaction", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Slaaction { get; set; } 

    [JsonProperty("ticket_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TicketCount { get; set; } 

    [JsonProperty("showonquickchange", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Showonquickchange { get; set; } 

    [JsonProperty("timeuntilloffhold", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Timeuntilloffhold { get; set; } 

    [JsonProperty("statuschangeto", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Statuschangeto { get; set; } 

    [JsonProperty("statuschangetofreq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Statuschangetofreq { get; set; } 

    [JsonProperty("statusnochangehours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Statusnochangehours { get; set; } 

    [JsonProperty("nochangehoursrecurring", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Nochangehoursrecurring { get; set; } 

    [JsonProperty("statusnochangehoursmanager", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Statusnochangehoursmanager { get; set; } 

    [JsonProperty("statusnochangehoursmanagerrecurring", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Statusnochangehoursmanagerrecurring { get; set; } 

    [JsonProperty("statusnochangehourssection", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Statusnochangehourssection { get; set; } 

    [JsonProperty("statusnochangehourssectionrecurring", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Statusnochangehourssectionrecurring { get; set; } 

    [JsonProperty("nochangetemplate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Nochangetemplate { get; set; } 

    [JsonProperty("nochangetemplate_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? NochangetemplateGuid { get; set; } 

    [JsonProperty("includeinloadbalance", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Includeinloadbalance { get; set; } 

    [JsonProperty("statusemailfreqdays", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Statusemailfreqdays { get; set; } 

    [JsonProperty("statusemailid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Statusemailid { get; set; } 

    [JsonProperty("statusemail_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? StatusemailGuid { get; set; } 

    [JsonProperty("statusemailname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Statusemailname { get; set; } 

    [JsonProperty("notifystatuschange", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Notifystatuschange { get; set; } 

    [JsonProperty("dontsendslareminders", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Dontsendslareminders { get; set; } 

    [JsonProperty("nochangetemplatename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Nochangetemplatename { get; set; } 

    [JsonProperty("slaignorerelease", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Slaignorerelease { get; set; } 

    [JsonProperty("statuschangetoname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Statuschangetoname { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("useworkinghours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Useworkinghours { get; set; } 

    [JsonProperty("useworkinghours_statusnochangehours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? UseworkinghoursStatusnochangehours { get; set; } 

    [JsonProperty("useworkinghours_statusnochangehourssection", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? UseworkinghoursStatusnochangehourssection { get; set; } 

    [JsonProperty("useworkinghours_statusnochangehoursmanager", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? UseworkinghoursStatusnochangehoursmanager { get; set; } 

    [JsonProperty("tickettypes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ValueLabelIsNewKeyPair>? Tickettypes { get; set; } 

    [JsonProperty("outcomes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ValueLabelIsNewKeyPair>? Outcomes { get; set; } 

    [JsonProperty("translations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<LanguagePackTranslationsCustom>? Translations { get; set; } 

}