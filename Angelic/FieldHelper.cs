using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class FieldHelper
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("validate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Validate { get; set; } 

    [JsonProperty("value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public object? Value { get; set; } 

    [JsonProperty("display", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Display { get; set; } 

    [JsonProperty("mandatory", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Mandatory { get; set; } 

    [JsonProperty("showonactivity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Showonactivity { get; set; } 

    [JsonProperty("lookup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Lookup { get; set; } 

    [JsonProperty("systemuse", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Systemuse { get; set; } 

    [JsonProperty("parenttype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Parenttype_id { get; set; } 

    [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Url { get; set; } 

    [JsonProperty("mapping_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Mapping_id { get; set; } 

    [JsonProperty("access_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Access_level { get; set; } 

    [JsonProperty("typeinfo_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Typeinfo_id { get; set; } 

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

}