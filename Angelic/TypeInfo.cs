using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class TypeInfo
{
    [JsonProperty("typeinfo_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Typeinfo_id { get; set; } 

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Id { get; set; } 

    [JsonProperty("field_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Field_id { get; set; } 

    [JsonProperty("field_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Field_name { get; set; } 

    [JsonProperty("sequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sequence { get; set; } 

    [JsonProperty("keyfield_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Keyfield_id { get; set; } 

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Type { get; set; } 

    [JsonProperty("tab_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Tab_id { get; set; } 

    [JsonProperty("tab_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Tab_name { get; set; } 

    [JsonProperty("tab_sequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Tab_sequence { get; set; } 

    [JsonProperty("tab_columns", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Tab_columns { get; set; } 

    [JsonProperty("groupname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Groupname { get; set; } 

    [JsonProperty("techdetail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Techdetail { get; set; } 

    [JsonProperty("userdetail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Userdetail { get; set; } 

    [JsonProperty("visibility_conditions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomFieldVisibility>? Visibility_conditions { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

}