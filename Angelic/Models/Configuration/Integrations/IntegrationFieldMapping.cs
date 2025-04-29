using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class IntegrationFieldMapping
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("fiid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? FiId { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("thirdpartyname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ThirdPartyname { get; set; } 

    [JsonProperty("msid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Msid { get; set; } 

    [JsonProperty("typeid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Typeid { get; set; } 

    [JsonProperty("isassetfield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsAssetfield { get; set; } 

    [JsonProperty("subtypeid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Subtypeid { get; set; } 

    [JsonProperty("newrecords", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Newrecords { get; set; } 

    [JsonProperty("xmvalue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Xmvalue { get; set; } 

    [JsonProperty("third_party_friendly_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ThirdPartyFriendlyName { get; set; } 

    [JsonProperty("sync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Sync { get; set; } 

    [JsonProperty("synctype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SyncType { get; set; } 

    [JsonProperty("product", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Product { get; set; } 

    [JsonProperty("dontupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DontUpdate { get; set; } 

    [JsonProperty("product_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ProductName { get; set; } 

    [JsonProperty("third_party_field_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ThirdPartyFieldType { get; set; } 

    [JsonProperty("populateemptyvalue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Populateemptyvalue { get; set; } 

    [JsonProperty("value_set", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ValueSet { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}