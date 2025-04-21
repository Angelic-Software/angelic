using System.CodeDom.Compiler;
using System.Collections.Generic;
using Newtonsoft.Json;
using Angelic.AmazonSellerTaxClassifications;

namespace Angelic.AmazonSellerBuyerTaxInfo;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class AmazonSellerBuyerTaxInfo
{
    [JsonProperty("CompanyLegalName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CompanyLegalName { get; set; }
    
    [JsonProperty("TaxingRegion", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TaxingRegion { get; set; }
    
    [JsonProperty("TaxClassifications", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AmazonSellerTaxClassifications.AmazonSellerTaxClassifications>? TaxClassifications { get; set; }
}
