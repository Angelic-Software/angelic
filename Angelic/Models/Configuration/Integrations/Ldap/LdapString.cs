using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.Ldap;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record LdapString
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("connection_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ConnectionId { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("dn", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Dn { get; set; } 

    /// <summary>
    /// This property contains an underscore because the class name is the same as the property, and this is illegal.
    /// </summary>
    [JsonProperty("ldapstring", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _LdapString { get; set; } 

    [JsonProperty("site_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SiteId { get; set; } 

    [JsonProperty("site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SiteName { get; set; } 

    [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ClientId { get; set; } 

    [JsonProperty("lastnewuserdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? LastNewUserDate { get; set; } 

    [JsonProperty("filter", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Filter { get; set; } 

    [JsonProperty("agentmapping", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AgentMapping { get; set; } 

    [JsonProperty("isrecursive", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsRecursive { get; set; } 

    [JsonProperty("mapping_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MappingType { get; set; } 

    [JsonProperty("role_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RoleId { get; set; } 

    [JsonProperty("users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<LdapUser>? Users { get; set; } 

    [JsonProperty("cabmapping", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CabMapping { get; set; } 

    [JsonProperty("cab_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CabId { get; set; } 

    [JsonProperty("cab_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CabName { get; set; } 

    [JsonProperty("lastsynced", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? LastSynced { get; set; } 

    [JsonProperty("userrole_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? UserRoleId { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}