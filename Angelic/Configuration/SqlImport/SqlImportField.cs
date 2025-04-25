using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Configuration.SqlImport;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class SqlImportField
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("siid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Siid { get; set; } 

    [JsonProperty("thirdpartyname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Thirdpartyname { get; set; } 

    [JsonProperty("nhdname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Nhdname { get; set; } 

    [JsonProperty("is_site_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsSiteField { get; set; } 

    [JsonProperty("field_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? FieldId { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}