using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Configuration.Integrations.Microsoft.Dynamics365.BusinessCentral;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class BusinessCentralEnvironment
{
    [JsonProperty("aadTenantId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AadTenantId { get; set; } 

    [JsonProperty("applicationFamily", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ApplicationFamily { get; set; } 

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Type { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("countryCode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CountryCode { get; set; } 

    [JsonProperty("webServiceUrl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? WebServiceUrl { get; set; } 

    [JsonProperty("webClientLoginUrl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? WebClientLoginUrl { get; set; } 

}