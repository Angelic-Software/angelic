using System.CodeDom.Compiler;
using Angelic.Configuration.Custom.CustomFields;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class TypeInfo
{
    [JsonProperty("typeinfo_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TypeinfoId { get; set; } 

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Id { get; set; } 

    [JsonProperty("field_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? FieldId { get; set; } 

    [JsonProperty("field_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? FieldName { get; set; } 

    [JsonProperty("sequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sequence { get; set; } 

    [JsonProperty("keyfield_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? KeyfieldId { get; set; } 

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Type { get; set; } 

    [JsonProperty("tab_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TabId { get; set; } 

    [JsonProperty("tab_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TabName { get; set; } 

    [JsonProperty("tab_sequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TabSequence { get; set; } 

    [JsonProperty("tab_columns", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TabColumns { get; set; } 

    [JsonProperty("groupname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Groupname { get; set; } 

    [JsonProperty("techdetail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Techdetail { get; set; } 

    [JsonProperty("userdetail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? UserDetail { get; set; } 

    [JsonProperty("visibility_conditions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomFieldVisibility>? VisibilityConditions { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}