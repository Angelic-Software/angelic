using System.CodeDom.Compiler;
using Angelic.Attributes;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.Amazon;

[HasEndpoint("AmazonSellerDetails")]
[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class AmazonSellerDetails
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; }
    
    [JsonProperty("storefrontname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? StorefrontName { get; set; }
    
    [JsonProperty("new_integration_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? NewIntegrationMethod { get; set; }
    
    [JsonProperty("new_access_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewAccessToken { get; set; }
    
    [JsonProperty("new_refresh_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewRefreshToken { get; set; }
    
    [JsonProperty("_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Code { get; set; }
    
    [JsonProperty("_exchangecode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ExchangeCode { get; set; }
    
    [JsonProperty("authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Authorized { get; set; }
    
    [JsonProperty("enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Enabled { get; set; }
    
    [JsonProperty("endpoint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Endpoint { get; set; }
    
    [JsonProperty("marketplace", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Marketplace { get; set; }
    
    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; }
}
