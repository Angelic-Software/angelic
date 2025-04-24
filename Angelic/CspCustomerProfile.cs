using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CspCustomerProfile
{
    [JsonProperty("tenantId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TenantId { get; set; } 

    [JsonProperty("domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Domain { get; set; } 

    [JsonProperty("companyName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CompanyName { get; set; } 

}