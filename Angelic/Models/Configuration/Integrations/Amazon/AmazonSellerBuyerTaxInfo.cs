using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.Amazon;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record AmazonSellerBuyerTaxInfo
{
    [JsonProperty("CompanyLegalName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CompanyLegalName { get; set; }
    
    [JsonProperty("TaxingRegion", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TaxingRegion { get; set; }
    
    [JsonProperty("TaxClassifications", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AmazonSellerTaxClassifications>? TaxClassifications { get; set; }
}
