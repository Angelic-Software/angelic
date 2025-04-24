using System.CodeDom.Compiler;
using Angelic.KeyPairs;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ItemGroup
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("lines", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<QuotationDetail>? Lines { get; set; } 

    [JsonProperty("oldLines", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<QuotationDetail>? OldLines { get; set; } 

    [JsonProperty("hideitems", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Hideitems { get; set; } 

    [JsonProperty("add_all_group_items_quote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Add_all_group_items_quote { get; set; } 

    [JsonProperty("quantity_group_items_quote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Quantity_group_items_quote { get; set; } 

    [JsonProperty("hide_items_group_items_quote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Hide_items_group_items_quote { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

    [JsonProperty("access_control", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AccessControl>? Access_control { get; set; } 

    [JsonProperty("access_control_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Access_control_level { get; set; } 

    [JsonProperty("hide_grouped_items_price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Hide_grouped_items_price { get; set; } 

    [JsonProperty("category", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Category { get; set; } 

    [JsonProperty("name_extra", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name_extra { get; set; } 

    [JsonProperty("one_optional_mandatory", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<StringIdNameKeyPair>? One_optional_mandatory { get; set; } 

    [JsonProperty("one_optional_mandatory_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? One_optional_mandatory_list { get; set; } 

    [JsonProperty("default_billingperiod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Default_billingperiod { get; set; } 

    [JsonProperty("nominal_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Nominal_code { get; set; } 

    [JsonProperty("force_quantity_relationship", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Force_quantity_relationship { get; set; } 

    [JsonProperty("force_price_relationship", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Force_price_relationship { get; set; } 

    [JsonProperty("force_term_relationship", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Force_term_relationship { get; set; } 

    [JsonProperty("price_calculation_formula", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Price_calculation_formula { get; set; } 

    [JsonProperty("_updaterecurringbundleprices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _updaterecurringbundleprices { get; set; } 

}