using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.Ldap;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record LdapName
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("connection_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ConnectionId { get; set; } 

    [JsonProperty("ldap_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? LdapField { get; set; } 

    [JsonProperty("nhd_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NhdField { get; set; } 

    [JsonProperty("is_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsUser { get; set; } 

    [JsonProperty("is_userticket", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsUserTicket { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}