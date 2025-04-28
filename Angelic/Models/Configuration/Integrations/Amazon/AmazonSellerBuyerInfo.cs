using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.Amazon;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class AmazonSellerBuyerInfo
{
    [JsonProperty("BuyerEmail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? BuyerEmail { get; set; }
    
    [JsonProperty("BuyerName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? BuyerName { get; set; }
    
    [JsonProperty("BuyerCountry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? BuyerCountry { get; set; }
    
    [JsonProperty("BuyerTaxInfo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public AmazonSellerBuyerTaxInfo? BuyerTaxInfo { get; set; }
    
    [JsonProperty("PurchaseOrderNumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PurchaseOrderNumber { get; set; }
}
