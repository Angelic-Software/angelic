using System.CodeDom.Compiler;
using Angelic.Models.Configuration.Language;
using Angelic.Models.KeyPairs;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Tickets;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record Status
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
    public string? SlaAction { get; set; } 

    [JsonProperty("ticket_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TicketCount { get; set; } 

    [JsonProperty("showonquickchange", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowOnQuickChange { get; set; } 

    [JsonProperty("timeuntilloffhold", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TimeUntilOffHold { get; set; } 

    [JsonProperty("statuschangeto", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? StatusChangeTo { get; set; } 

    [JsonProperty("statuschangetofreq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? StatusChangeToFreq { get; set; } 

    [JsonProperty("statusnochangehours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? StatusNoChangeHours { get; set; } 

    [JsonProperty("nochangehoursrecurring", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? NoChangeHoursRecurring { get; set; } 

    [JsonProperty("statusnochangehoursmanager", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? StatusNoChangeHoursManager { get; set; } 

    [JsonProperty("statusnochangehoursmanagerrecurring", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Statusnochangehoursmanagerrecurring { get; set; } 

    [JsonProperty("statusnochangehourssection", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? StatusNoChangeHoursSection { get; set; } 

    [JsonProperty("statusnochangehourssectionrecurring", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Statusnochangehourssectionrecurring { get; set; } 

    [JsonProperty("nochangetemplate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? NoChangeTemplate { get; set; } 

    [JsonProperty("nochangetemplate_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? NoChangeTemplateGuid { get; set; } 

    [JsonProperty("includeinloadbalance", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IncludeInLoadBalance { get; set; } 

    [JsonProperty("statusemailfreqdays", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? StatusEmailFreqDays { get; set; } 

    [JsonProperty("statusemailid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? StatusEmailId { get; set; } 

    [JsonProperty("statusemail_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? StatusEmailGuid { get; set; } 

    [JsonProperty("statusemailname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? StatusEmailName { get; set; } 

    [JsonProperty("notifystatuschange", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? NotifyStatusChange { get; set; } 

    [JsonProperty("dontsendslareminders", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DontSendSlaReminders { get; set; } 

    [JsonProperty("nochangetemplatename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NoChangeTemplateName { get; set; } 

    [JsonProperty("slaignorerelease", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? SlaIgnoreRelease { get; set; } 

    [JsonProperty("statuschangetoname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? StatusChangeToName { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("useworkinghours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? UseWorkingHours { get; set; } 

    [JsonProperty("useworkinghours_statusnochangehours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? UseWorkingHoursStatusNoChangeHours { get; set; } 

    [JsonProperty("useworkinghours_statusnochangehourssection", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? UseWorkingHoursStatusNoChangeHoursSection { get; set; } 

    [JsonProperty("useworkinghours_statusnochangehoursmanager", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? UseWorkingHoursStatusNoChangeHoursManager { get; set; } 

    [JsonProperty("tickettypes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ValueLabelIsNewKeyPair>? TicketTypes { get; set; } 

    [JsonProperty("outcomes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ValueLabelIsNewKeyPair>? Outcomes { get; set; } 

    [JsonProperty("translations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<LanguagePackTranslationsCustom>? Translations { get; set; } 

}