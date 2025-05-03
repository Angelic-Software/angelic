using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Custom.CustomFields;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Field
{
    [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Guid { get; set; } 

    [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Intent { get; set; } 

    [JsonProperty("kind", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Kind { get; set; } 

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("typeinfo_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TypeInfoId { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("validate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Validate { get; set; } 

    [JsonProperty("systemuse", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SystemUse { get; set; } 

    [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Url { get; set; } 

    [JsonProperty("idstring", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Idstring { get; set; } 

    [JsonProperty("datafrom", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Datafrom { get; set; } 

    [JsonProperty("datalength", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Datalength { get; set; } 

    [JsonProperty("issoftware", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Issoftware { get; set; } 

    [JsonProperty("sequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sequence { get; set; } 

    [JsonProperty("lookup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Lookup { get; set; } 

    [JsonProperty("mandatory", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Mandatory { get; set; } 

    [JsonProperty("showoncalendar", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowOncalendar { get; set; } 

    [JsonProperty("moveupdatetype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Moveupdatetype { get; set; } 

    [JsonProperty("inactiveupdatetype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Inactiveupdatetype { get; set; } 

    [JsonProperty("moveupdatedefault", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Moveupdatedefault { get; set; } 

    [JsonProperty("showonactivity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowOnactivity { get; set; } 

    [JsonProperty("values", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Lookup>? Values { get; set; } 

    [JsonProperty("new_values", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewValues { get; set; } 

    [JsonProperty("parenttype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ParenttypeId { get; set; } 

    [JsonProperty("parenttype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ParenttypeName { get; set; } 

    [JsonProperty("mapping_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MappingId { get; set; } 

    [JsonProperty("order_values_alphanumerically", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? OrderValuesAlphanumerically { get; set; } 

    [JsonProperty("tab_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TabId { get; set; } 

    [JsonProperty("tab_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TabName { get; set; } 

    [JsonProperty("tab_sequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TabSequence { get; set; } 

    [JsonProperty("tab_columns", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TabColumns { get; set; } 

    [JsonProperty("groupname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? GroupName { get; set; } 

    [JsonProperty("techdetail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TechDetail { get; set; } 

    [JsonProperty("userdetail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? UserDetail { get; set; } 

    [JsonProperty("visibility_conditions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomFieldVisibility>? VisibilityConditions { get; set; } 

    [JsonProperty("access_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AccessLevel { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}