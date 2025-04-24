using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class IntegrationSiteMapping
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("halo_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Halo_id { get; set; } 

    [JsonProperty("halo_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Halo_name { get; set; } 

    [JsonProperty("third_party_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Third_party_id { get; set; } 

    [JsonProperty("third_party_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Third_party_name { get; set; } 

    [JsonProperty("module_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Module_id { get; set; } 

    [JsonProperty("third_party_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Third_party_client_id { get; set; } 

    [JsonProperty("third_party_client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Third_party_client_name { get; set; } 

    [JsonProperty("third_party_full_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Third_party_full_name { get; set; } 

    [JsonProperty("halo_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Halo_client_id { get; set; } 

    [JsonProperty("halo_client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Halo_client_name { get; set; } 

    [JsonProperty("halo_site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Halo_site_name { get; set; } 

    [JsonProperty("userules", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Userules { get; set; } 

    [JsonProperty("criteria", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<XTypeMappingCriteria>? Criteria { get; set; } 

    [JsonProperty("rule_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Rule_count { get; set; } 

    [JsonProperty("seq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Seq { get; set; } 

    [JsonProperty("details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Details_id { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

}