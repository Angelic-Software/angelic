using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Area;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class AreaAzureTenant
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DetailsId { get; set; } 

    [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ClientId { get; set; } 

    [JsonProperty("azure_tenant_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AzureTenantId { get; set; } 

    [JsonProperty("azure_tenant_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AzureTenantName { get; set; } 

    [JsonProperty("new_access_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewAccessToken { get; set; } 

    [JsonProperty("token_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? TokenExpiry { get; set; } 

    [JsonProperty("client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ClientName { get; set; } 

    [JsonProperty("details_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DetailsName { get; set; } 

    [JsonProperty("azure_tenant_domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AzureTenantDomain { get; set; } 

    [JsonProperty("licence_import_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? LicenceImportType { get; set; } 

    [JsonProperty("relationship_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RelationshipType { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}