using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Assets.AssetTypes;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class AssetTypeAccountsMappings
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("gid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Gid { get; set; } 

    [JsonProperty("tenantid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TenantId { get; set; } 

    [JsonProperty("tenant_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TenantName { get; set; } 

    [JsonProperty("nominalcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NominalCode { get; set; } 

    [JsonProperty("nominalcode_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NominalCodeName { get; set; } 

    [JsonProperty("nominalcode_purchase", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NominalCodePurchase { get; set; } 

    [JsonProperty("nominalcode_name_purchase", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NominalCodeNamePurchase { get; set; } 

    [JsonProperty("itemcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ItemCode { get; set; } 

    [JsonProperty("itemcode_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ItemCodeName { get; set; } 

    [JsonProperty("taxcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TaxCode { get; set; } 

    [JsonProperty("tax_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TaxName { get; set; } 

    [JsonProperty("taxcode_purchase", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TaxCodePurchase { get; set; } 

    [JsonProperty("tax_name_purchase", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TaxNamePurchase { get; set; } 

    [JsonProperty("xero_category_1_lookup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? XeroCategory1Lookup { get; set; } 

    [JsonProperty("xero_category_2_lookup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? XeroCategory2Lookup { get; set; } 

    [JsonProperty("xero_category_1_lookup_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? XeroCategory1LookupName { get; set; } 

    [JsonProperty("xero_category_2_lookup_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? XeroCategory2LookupName { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}