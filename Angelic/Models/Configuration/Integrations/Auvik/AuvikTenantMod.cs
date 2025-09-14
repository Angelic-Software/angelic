using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.Auvik;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record AuvikTenantMod
{
    [JsonProperty("parentId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ParentId { get; set; } 

    [JsonProperty("parentName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ParentName { get; set; } 

    [JsonProperty("tenantId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TenantId { get; set; } 

    [JsonProperty("tenantName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TenantName { get; set; } 

    [JsonProperty("tenantDomain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TenantDomain { get; set; } 

    [JsonProperty("enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Enabled { get; set; } 

}