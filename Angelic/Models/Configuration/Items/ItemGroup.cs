using System.CodeDom.Compiler;
using Angelic.Models.KeyPairs;
using Angelic.Models.Quotation;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Items;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record ItemGroup
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
    public bool? HideItems { get; set; } 

    [JsonProperty("add_all_group_items_quote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AddAllGroupItemsQuote { get; set; } 

    [JsonProperty("quantity_group_items_quote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? QuantityGroupItemsQuote { get; set; } 

    [JsonProperty("hide_items_group_items_quote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? HideItemsGroupItemsQuote { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("access_control", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AccessControl>? AccessControl { get; set; } 

    [JsonProperty("access_control_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AccessControlLevel { get; set; } 

    [JsonProperty("hide_grouped_items_price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? HideGroupedItemsPrice { get; set; } 

    [JsonProperty("category", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Category { get; set; } 

    [JsonProperty("name_extra", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NameExtra { get; set; } 

    [JsonProperty("one_optional_mandatory", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<StringIdNameKeyPair>? OneOptionalMandatory { get; set; } 

    [JsonProperty("one_optional_mandatory_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OneOptionalMandatoryList { get; set; } 

    [JsonProperty("default_billingperiod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultBillingPeriod { get; set; } 

    [JsonProperty("nominal_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NominalCode { get; set; } 

    [JsonProperty("force_quantity_relationship", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ForceQuantityRelationship { get; set; } 

    [JsonProperty("force_price_relationship", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ForcePriceRelationship { get; set; } 

    [JsonProperty("force_term_relationship", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ForceTermRelationship { get; set; } 

    [JsonProperty("price_calculation_formula", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PriceCalculationFormula { get; set; } 

    [JsonProperty("_updaterecurringbundleprices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? UpdateRecurringBundlePrices { get; set; } 

}