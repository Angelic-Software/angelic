using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class FieldRoleRestriction
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("assettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Assettype_id { get; set; } 

    [JsonProperty("role_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Role_id { get; set; } 

    [JsonProperty("role_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Role_name { get; set; } 

    [JsonProperty("field_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Field_id { get; set; } 

}