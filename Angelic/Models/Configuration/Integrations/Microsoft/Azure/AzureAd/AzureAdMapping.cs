using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.Microsoft.Azure.AzureAd;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class AzureAdMapping
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("connectionid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ConnectionId { get; set; } 

    [JsonProperty("siteid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SiteId { get; set; } 

    [JsonProperty("site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SiteName { get; set; } 

    [JsonProperty("roleid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RoleId { get; set; } 

    [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ClientIdWithUnderscore { get; set; } 

    [JsonProperty("tenant_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TenantId { get; set; } 

    [JsonProperty("tenant_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TenantName { get; set; } 

    [JsonProperty("filters", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AzureAdFilter>? Filters { get; set; } 

    [JsonProperty("filter_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? FilterCount { get; set; } 

    [JsonProperty("group_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? GroupName { get; set; } 

    [JsonProperty("external_users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ExternalUsers { get; set; } 

    [JsonProperty("group_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? GroupId { get; set; } 

    [JsonProperty("sequenceid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sequenceid { get; set; } 

    [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Description { get; set; } 

    [JsonProperty("site_mapping_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SiteMappingType { get; set; } 

    [JsonProperty("clientid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ClientId { get; set; } 

    [JsonProperty("client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ClientName { get; set; } 

    [JsonProperty("site_mapping_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SiteMappingField { get; set; } 

    [JsonProperty("default_site_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultSiteId { get; set; } 

    [JsonProperty("default_site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultSiteName { get; set; } 

    [JsonProperty("userroleid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? UserRoleId { get; set; } 

    [JsonProperty("import_photo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ImportPhoto { get; set; } 

    [JsonProperty("site_mappings_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IntegrationFieldMapping>? SiteMappingsUser { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}