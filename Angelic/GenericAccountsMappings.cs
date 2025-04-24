using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class GenericAccountsMappings
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("gid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Gid { get; set; } 

    [JsonProperty("tenantid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Tenantid { get; set; } 

    [JsonProperty("tenant_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Tenant_name { get; set; } 

    [JsonProperty("nominalcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Nominalcode { get; set; } 

    [JsonProperty("nominalcode_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Nominalcode_name { get; set; } 

    [JsonProperty("nominalcode_purchase", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Nominalcode_purchase { get; set; } 

    [JsonProperty("nominalcode_name_purchase", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Nominalcode_name_purchase { get; set; } 

    [JsonProperty("itemcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Itemcode { get; set; } 

    [JsonProperty("itemcode_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Itemcode_name { get; set; } 

    [JsonProperty("taxcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Taxcode { get; set; } 

    [JsonProperty("tax_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Tax_name { get; set; } 

    [JsonProperty("taxcode_purchase", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Taxcode_purchase { get; set; } 

    [JsonProperty("tax_name_purchase", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Tax_name_purchase { get; set; } 

    [JsonProperty("xero_category_1_lookup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Xero_category_1_lookup { get; set; } 

    [JsonProperty("xero_category_2_lookup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Xero_category_2_lookup { get; set; } 

    [JsonProperty("xero_category_1_lookup_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Xero_category_1_lookup_name { get; set; } 

    [JsonProperty("xero_category_2_lookup_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Xero_category_2_lookup_name { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

}