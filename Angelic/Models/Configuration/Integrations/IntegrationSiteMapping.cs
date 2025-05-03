using System.CodeDom.Compiler;
using Angelic.Models.Configuration.Assets;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class IntegrationSiteMapping
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("halo_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? HaloId { get; set; } 

    [JsonProperty("halo_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? HaloName { get; set; } 

    [JsonProperty("third_party_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ThirdPartyId { get; set; } 

    [JsonProperty("third_party_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ThirdPartyName { get; set; } 

    [JsonProperty("module_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ModuleId { get; set; } 

    [JsonProperty("third_party_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ThirdPartyClientId { get; set; } 

    [JsonProperty("third_party_client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ThirdPartyClientName { get; set; } 

    [JsonProperty("third_party_full_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ThirdPartyFullName { get; set; } 

    [JsonProperty("halo_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? HaloClientId { get; set; } 

    [JsonProperty("halo_client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? HaloClientName { get; set; } 

    [JsonProperty("halo_site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? HaloSiteName { get; set; } 

    [JsonProperty("userules", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Userules { get; set; } 

    [JsonProperty("criteria", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AssetTypeMappingCriteria>? Criteria { get; set; } 

    [JsonProperty("rule_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RuleCount { get; set; } 

    [JsonProperty("seq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Seq { get; set; } 

    [JsonProperty("details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DetailsId { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}