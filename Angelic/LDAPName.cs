using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class LDAPName
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("connection_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Connection_id { get; set; } 

    [JsonProperty("ldap_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Ldap_field { get; set; } 

    [JsonProperty("nhd_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Nhd_field { get; set; } 

    [JsonProperty("is_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Is_user { get; set; } 

    [JsonProperty("is_userticket", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Is_userticket { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

}