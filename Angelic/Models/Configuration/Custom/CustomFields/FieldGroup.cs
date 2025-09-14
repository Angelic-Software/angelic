using System.CodeDom.Compiler;
using Angelic.Models.Configuration.Language;
using Angelic.Models.Configuration.Tickets.TicketTypes;
using Angelic.Models.KeyPairs;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Custom.CustomFields;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record FieldGroup
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Guid { get; set; } 

    [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Intent { get; set; } 

    [JsonProperty("header", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Header { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Description { get; set; } 

    [JsonProperty("fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<TicketTypeField>? Fields { get; set; } 

    [JsonProperty("translations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<LanguagePackTranslationsCustom>? Translations { get; set; } 

    [JsonProperty("access_control", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AccessControl>? AccessControl { get; set; } 

    [JsonProperty("access_control_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AccessControlLevel { get; set; } 

    [JsonProperty("tickettypes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ValueLabelIsNewKeyPair>? TicketTypes { get; set; } 

    [JsonProperty("outcomes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ValueLabelIsNewKeyPair>? Outcomes { get; set; } 

    [JsonProperty("visibility_conditions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomFieldVisibility>? VisibilityConditions { get; set; } 

    [JsonProperty("endusernew", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? EndUserNew { get; set; } 

    [JsonProperty("enduserdetail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? EndUserDetail { get; set; } 

    [JsonProperty("technew", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TechNew { get; set; } 

    [JsonProperty("techdetail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TechDetail { get; set; } 

    [JsonProperty("enduseraction", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? EndUserAction { get; set; } 

    [JsonProperty("techaction", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TechAction { get; set; } 

    [JsonProperty("techdetailhideifempty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? TechDetailHideIfEmpty { get; set; } 

    [JsonProperty("enduserdetailhideifempty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? EndUserDetailHideIfEmpty { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("collapsedbydefault", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CollapsedByDefault { get; set; } 

}