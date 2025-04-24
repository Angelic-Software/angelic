using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class LDAPString
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("connection_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Connection_id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("dn", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Dn { get; set; } 

    [JsonProperty("ldapstring", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Ldapstring { get; set; } 

    [JsonProperty("site_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Site_id { get; set; } 

    [JsonProperty("site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Site_name { get; set; } 

    [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Client_id { get; set; } 

    [JsonProperty("lastnewuserdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Lastnewuserdate { get; set; } 

    [JsonProperty("filter", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Filter { get; set; } 

    [JsonProperty("agentmapping", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Agentmapping { get; set; } 

    [JsonProperty("isrecursive", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Isrecursive { get; set; } 

    [JsonProperty("mapping_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Mapping_type { get; set; } 

    [JsonProperty("role_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Role_id { get; set; } 

    [JsonProperty("users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<LDAPUser>? Users { get; set; } 

    [JsonProperty("cabmapping", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Cabmapping { get; set; } 

    [JsonProperty("cab_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Cab_id { get; set; } 

    [JsonProperty("cab_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Cab_name { get; set; } 

    [JsonProperty("lastsynced", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Lastsynced { get; set; } 

    [JsonProperty("userrole_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Userrole_id { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

}