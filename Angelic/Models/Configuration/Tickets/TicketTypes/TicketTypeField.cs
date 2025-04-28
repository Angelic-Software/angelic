using System.CodeDom.Compiler;
using Angelic.Models.Configuration.Custom.CustomFields;
using Angelic.Models.Configuration.Language;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Tickets.TicketTypes;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class TicketTypeField
{
    [JsonProperty("copytochildonupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Copytochildonupdate { get; set; } 

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("rtid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RtId { get; set; } 

    [JsonProperty("fieldid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Fieldid { get; set; } 

    [JsonProperty("fieldguid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Fieldguid { get; set; } 

    [JsonProperty("seq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Seq { get; set; } 

    [JsonProperty("tableid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Tableid { get; set; } 

    [JsonProperty("tableguid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Tableguid { get; set; } 

    [JsonProperty("groupid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Groupid { get; set; } 

    [JsonProperty("groupguid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Groupguid { get; set; } 

    [JsonProperty("endusernew", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Endusernew { get; set; } 

    [JsonProperty("enduserdetail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Enduserdetail { get; set; } 

    [JsonProperty("enduserdetailrejected", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Enduserdetailrejected { get; set; } 

    [JsonProperty("technew", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Technew { get; set; } 

    [JsonProperty("techdetail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Techdetail { get; set; } 

    [JsonProperty("fieldname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? FieldName { get; set; } 

    [JsonProperty("fieldinfo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public FieldInfo? FieldInfo { get; set; } 

    [JsonProperty("visibility_conditions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomFieldVisibility>? VisibilityConditions { get; set; } 

    [JsonProperty("visibility_conditions_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomFieldVisibility>? VisibilityConditionsValue { get; set; } 

    [JsonProperty("value_restrictions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomFieldValueRestrictions>? ValueRestrictions { get; set; } 

    [JsonProperty("group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public FieldGroup? Group { get; set; } 

    [JsonProperty("technewlocation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Technewlocation { get; set; } 

    [JsonProperty("restrictupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Restrictupdate { get; set; } 

    [JsonProperty("update_restrictions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<TicketTypeFieldRestriction>? UpdateRestrictions { get; set; } 

    [JsonProperty("techtab_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TechtabId { get; set; } 

    [JsonProperty("techtab_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TechtabName { get; set; } 

    [JsonProperty("showdependency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Showdependency { get; set; } 

    [JsonProperty("canupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CanUpdate { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("override_fieldname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OverrideFieldName { get; set; } 

    [JsonProperty("override_action_fieldname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OverrideActionFieldName { get; set; } 

    [JsonProperty("boldlabelandvalue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Boldlabelandvalue { get; set; } 

    [JsonProperty("enduserdetailhideifempty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Enduserdetailhideifempty { get; set; } 

    [JsonProperty("techdetailhideifempty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Techdetailhideifempty { get; set; } 

    [JsonProperty("copytochild", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Copytochild { get; set; } 

    [JsonProperty("copytorelated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Copytorelated { get; set; } 

    [JsonProperty("restrictread", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Restrictread { get; set; } 

    [JsonProperty("read_restrictions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<TicketTypeFieldRestriction>? ReadRestrictions { get; set; } 

    [JsonProperty("techtab_columns", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TechtabColumns { get; set; } 

    [JsonProperty("chat_message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ChatMessage { get; set; } 

    [JsonProperty("techaction", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Techaction { get; set; } 

    [JsonProperty("enduseraction", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Enduseraction { get; set; } 

    [JsonProperty("endusercheckboxmandatory", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Endusercheckboxmandatory { get; set; } 

    [JsonProperty("translations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<LanguagePackTranslationsCustom>? Translations { get; set; } 

    [JsonProperty("display_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DisplayType { get; set; } 

}