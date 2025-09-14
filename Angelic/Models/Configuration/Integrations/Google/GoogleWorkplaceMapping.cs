using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.Google;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record GoogleWorkplaceMapping
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("customerid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CustomerId { get; set; } 

    [JsonProperty("siteid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SiteId { get; set; } 

    [JsonProperty("site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SiteName { get; set; } 

    [JsonProperty("filterfield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? FilterField { get; set; } 

    [JsonProperty("filtertype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? FilterType { get; set; } 

    [JsonProperty("filtervalue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? FilterValue { get; set; } 

    [JsonProperty("roleid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RoleId { get; set; } 

    [JsonProperty("filter", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Filter { get; set; } 

    [JsonProperty("userroleid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? UserRoleId { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}