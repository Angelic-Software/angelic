using System.CodeDom.Compiler;
using Angelic.Models.Configuration.Custom.CustomFields;
using Angelic.Models.Configuration.Custom.CustomFields.Restrictions;
using Angelic.Models.Configuration.Language;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Tickets.TicketTypes;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record TicketTypeField
{
    [JsonProperty("copytochildonupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CopyToChildOnUpdate { get; set; } 

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("rtid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RtId { get; set; } 

    [JsonProperty("fieldid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? FieldId { get; set; } 

    [JsonProperty("fieldguid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? FieldGuid { get; set; } 

    [JsonProperty("seq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Seq { get; set; } 

    [JsonProperty("tableid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TableId { get; set; } 

    [JsonProperty("tableguid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? TableGuid { get; set; } 

    [JsonProperty("groupid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? GroupId { get; set; } 

    [JsonProperty("groupguid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? GroupGuid { get; set; } 

    [JsonProperty("endusernew", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? EndUserNew { get; set; } 

    [JsonProperty("enduserdetail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? EndUserDetail { get; set; } 

    [JsonProperty("enduserdetailrejected", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? EndUserDetailRejected { get; set; } 

    [JsonProperty("technew", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TechNew { get; set; } 

    [JsonProperty("techdetail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TechDetail { get; set; } 

    [JsonProperty("fieldname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? FieldName { get; set; } 

    [JsonProperty("fieldinfo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public FieldInfo? FieldInfo { get; set; } 

    [JsonProperty("visibility_conditions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomFieldVisibility>? VisibilityConditions { get; set; } 

    [JsonProperty("visibility_conditions_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomFieldVisibility>? VisibilityConditionsValue { get; set; } 

    [JsonProperty("value_restrictions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ValueRestrictions>? ValueRestrictions { get; set; } 

    [JsonProperty("group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public FieldGroup? Group { get; set; } 

    [JsonProperty("technewlocation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TechNewLocation { get; set; } 

    [JsonProperty("restrictupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RestrictUpdate { get; set; } 

    [JsonProperty("update_restrictions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<TicketTypeFieldRestriction>? UpdateRestrictions { get; set; } 

    [JsonProperty("techtab_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TechTabId { get; set; } 

    [JsonProperty("techtab_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TechTabName { get; set; } 

    [JsonProperty("showdependency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowDependency { get; set; } 

    [JsonProperty("canupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CanUpdate { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("override_fieldname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OverrideFieldName { get; set; } 

    [JsonProperty("override_action_fieldname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OverrideActionFieldName { get; set; } 

    [JsonProperty("boldlabelandvalue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? BoldLabelAndValue { get; set; } 

    [JsonProperty("enduserdetailhideifempty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? EndUserDetailHideIfEmpty { get; set; } 

    [JsonProperty("techdetailhideifempty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? TechDetailHideIfEmpty { get; set; } 

    [JsonProperty("copytochild", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CopyToChild { get; set; } 

    [JsonProperty("copytorelated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CopyToRelated { get; set; } 

    [JsonProperty("restrictread", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RestrictRead { get; set; } 

    [JsonProperty("read_restrictions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<TicketTypeFieldRestriction>? ReadRestrictions { get; set; } 

    [JsonProperty("techtab_columns", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TechTabColumns { get; set; } 

    [JsonProperty("chat_message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ChatMessage { get; set; } 

    [JsonProperty("techaction", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TechAction { get; set; } 

    [JsonProperty("enduseraction", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? EndUserAction { get; set; } 

    [JsonProperty("endusercheckboxmandatory", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? EndUserCheckboxMandatory { get; set; } 

    [JsonProperty("translations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<LanguagePackTranslationsCustom>? Translations { get; set; } 

    [JsonProperty("display_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DisplayType { get; set; } 

}