using System.CodeDom.Compiler;
using Angelic.Models.Configuration.Language;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Tickets;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CategoryDetail
{
    [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Guid { get; set; } 

    [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Intent { get; set; } 

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Value { get; set; } 

    [JsonProperty("category_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CategoryName { get; set; } 

    [JsonProperty("type_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TypeId { get; set; } 

    [JsonProperty("sla_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SlaId { get; set; } 

    [JsonProperty("priority_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PriorityId { get; set; } 

    [JsonProperty("chargerate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ChargeRate { get; set; } 

    [JsonProperty("category_group_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CategoryGroupId { get; set; } 

    [JsonProperty("_isnew", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsNew { get; set; } 

    [JsonProperty("include_note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IncludeNote { get; set; } 

    [JsonProperty("note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Note { get; set; } 

    [JsonProperty("user_note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? UserNote { get; set; } 

    [JsonProperty("itilrequesttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ItilRequestType { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("is_integration", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsIntegration { get; set; } 

    [JsonProperty("translations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<LanguagePackTranslationsCustom>? Translations { get; set; } 

}