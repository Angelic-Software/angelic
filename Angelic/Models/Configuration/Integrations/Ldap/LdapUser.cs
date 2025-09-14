using System.CodeDom.Compiler;
using Angelic.Models.KeyPairs;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.Ldap;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record LdapUser
{
    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("distinguishedname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DistinguishedName { get; set; } 

    [JsonProperty("userAccountControl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? UserAccountControl { get; set; } 

    [JsonProperty("objectguid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ObjectGuid { get; set; } 

    [JsonProperty("manager", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Manager { get; set; } 

    [JsonProperty("memberOf", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MemberOf { get; set; } 

    [JsonProperty("attributes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<StringIdNameKeyPair>? Attributes { get; set; } 

    [JsonProperty("uactguidMapping", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? UActGuidMapping { get; set; } 

}