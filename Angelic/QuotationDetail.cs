using System.CodeDom.Compiler;
using Angelic.KeyPairs;
using Angelic.Ticket;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class QuotationDetail
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("sort_seq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SortSeq { get; set; } 

    [JsonProperty("group_sort_seq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? GroupSortSeq { get; set; } 

    [JsonProperty("productcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Productcode { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("costprice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Costprice { get; set; } 

    [JsonProperty("total_price_monthly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TotalPriceMonthly { get; set; } 

    [JsonProperty("total_price_monthly_converted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TotalPriceMonthlyConverted { get; set; } 

    [JsonProperty("total_net_total_monthly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TotalNetTotalMonthly { get; set; } 

    [JsonProperty("total_costprice_monthly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TotalCostpriceMonthly { get; set; } 

    [JsonProperty("total_profit_monthly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TotalProfitMonthly { get; set; } 

    [JsonProperty("total_tax_monthly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TotalTaxMonthly { get; set; } 

    [JsonProperty("total_discount_monthly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TotalDiscountMonthly { get; set; } 

    [JsonProperty("total_price_annual", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TotalPriceAnnual { get; set; } 

    [JsonProperty("total_price_annual_converted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TotalPriceAnnualConverted { get; set; } 

    [JsonProperty("total_net_total_annual", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TotalNetTotalAnnual { get; set; } 

    [JsonProperty("total_costprice_annual", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TotalCostpriceAnnual { get; set; } 

    [JsonProperty("total_profit_annual", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TotalProfitAnnual { get; set; } 

    [JsonProperty("total_tax_annual", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TotalTaxAnnual { get; set; } 

    [JsonProperty("total_discount_annual", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TotalDiscountAnnual { get; set; } 

    [JsonProperty("total_price_yearone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TotalPriceYearone { get; set; } 

    [JsonProperty("total_price_yearone_converted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TotalPriceYearoneConverted { get; set; } 

    [JsonProperty("total_net_total_yearone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TotalNetTotalYearone { get; set; } 

    [JsonProperty("total_costprice_yearone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TotalCostpriceYearone { get; set; } 

    [JsonProperty("total_profit_yearone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TotalProfitYearone { get; set; } 

    [JsonProperty("total_tax_yearone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TotalTaxYearone { get; set; } 

    [JsonProperty("total_discount_yearone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TotalDiscountYearone { get; set; } 

    [JsonProperty("qhid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Qhid { get; set; } 

    [JsonProperty("item_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ItemId { get; set; } 

    [JsonProperty("note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Note { get; set; } 

    [JsonProperty("note_hidden", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? NoteHidden { get; set; } 

    [JsonProperty("servicefee", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Servicefee { get; set; } 

    [JsonProperty("recovery", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Recovery { get; set; } 

    [JsonProperty("margin", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Margin { get; set; } 

    [JsonProperty("billingperiod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Billingperiod { get; set; } 

    [JsonProperty("startdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Startdate { get; set; } 

    [JsonProperty("autorenew", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Autorenew { get; set; } 

    [JsonProperty("item_recurring", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ItemRecurring { get; set; } 

    [JsonProperty("item_taxable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ItemTaxable { get; set; } 

    [JsonProperty("group_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? GroupId { get; set; } 

    [JsonProperty("printitem", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Printitem { get; set; } 

    [JsonProperty("isgroupdesc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Isgroupdesc { get; set; } 

    [JsonProperty("discount_perc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? DiscountPerc { get; set; } 

    [JsonProperty("supplier_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SupplierId { get; set; } 

    [JsonProperty("supplier_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SupplierName { get; set; } 

    [JsonProperty("optional", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Optional { get; set; } 

    [JsonProperty("approval_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ApprovalStatus { get; set; } 

    [JsonProperty("cost_centre", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CostCentre { get; set; } 

    [JsonProperty("stock_location", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? StockLocation { get; set; } 

    [JsonProperty("item_internal_reference", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ItemInternalReference { get; set; } 

    [JsonProperty("item_external_reference", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ItemExternalReference { get; set; } 

    [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Description { get; set; } 

    [JsonProperty("item_tax_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ItemTaxName { get; set; } 

    [JsonProperty("quoteitemurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Quoteitemurl { get; set; } 

    [JsonProperty("addedtorecurring", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Addedtorecurring { get; set; } 

    [JsonProperty("addedtononrecurring", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Addedtononrecurring { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("assetgroup_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AssetgroupId { get; set; } 

    [JsonProperty("maxitemdiscount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Maxitemdiscount { get; set; } 

    [JsonProperty("line_site_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? LineSiteId { get; set; } 

    [JsonProperty("site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SiteName { get; set; } 

    [JsonProperty("line_periods", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? LinePeriods { get; set; } 

    [JsonProperty("hideitems", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Hideitems { get; set; } 

    [JsonProperty("ignoretaxcalc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Ignoretaxcalc { get; set; } 

    [JsonProperty("current_quantity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? CurrentQuantity { get; set; } 

    [JsonProperty("current_price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? CurrentPrice { get; set; } 

    [JsonProperty("current_net_price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? CurrentNetPrice { get; set; } 

    [JsonProperty("isleased", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Isleased { get; set; } 

    [JsonProperty("stockbin_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? StockbinId { get; set; } 

    [JsonProperty("quoter_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? QuoterId { get; set; } 

    [JsonProperty("is_bundled_line", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsBundledLine { get; set; } 

    [JsonProperty("optional_line_quantity_change", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? OptionalLineQuantityChange { get; set; } 

    [JsonProperty("created_from_group_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CreatedFromGroupId { get; set; } 

    [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomField>? Customfields { get; set; } 

    [JsonProperty("chargerates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Lookup>? Chargerates { get; set; } 

    [JsonProperty("budgets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<TicketBudget>? Budgets { get; set; } 

    [JsonProperty("item_template", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ItemTemplate { get; set; } 

    [JsonProperty("item_contract", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ItemContract { get; set; } 

    [JsonProperty("hide_grouped_items_price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? HideGroupedItemsPrice { get; set; } 

    [JsonProperty("nominal_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NominalCode { get; set; } 

    [JsonProperty("one_optional_mandatory", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<StringIdNameKeyPair>? OneOptionalMandatory { get; set; } 

    [JsonProperty("one_optional_mandatory_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OneOptionalMandatoryList { get; set; } 

    [JsonProperty("force_quantity_relationship", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ForceQuantityRelationship { get; set; } 

    [JsonProperty("force_price_relationship", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ForcePriceRelationship { get; set; } 

    [JsonProperty("force_term_relationship", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ForceTermRelationship { get; set; } 

    [JsonProperty("price_calculation_formula", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PriceCalculationFormula { get; set; } 

    [JsonProperty("purchase_currency_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PurchaseCurrencyCode { get; set; } 

    [JsonProperty("cost_converted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? CostConverted { get; set; } 

    [JsonProperty("purchase_currency_code_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PurchaseCurrencyCodeName { get; set; } 

    [JsonProperty("purchase_currency_symbol", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PurchaseCurrencySymbol { get; set; } 

    [JsonProperty("purchase_conversion_rate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? PurchaseConversionRate { get; set; } 

    [JsonProperty("stocklocation_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? StocklocationId { get; set; } 

    [JsonProperty("exclude_auto_increase", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ExcludeAutoIncrease { get; set; } 

    [JsonProperty("auto_increase_period", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AutoIncreasePeriod { get; set; } 

    [JsonProperty("percent_increase", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? PercentIncrease { get; set; } 

    [JsonProperty("use_rpi_increase", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? UseRpiIncrease { get; set; } 

    [JsonProperty("net_total", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? NetTotal { get; set; } 

    [JsonProperty("total_tax_converted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TotalTaxConverted { get; set; } 

    [JsonProperty("tax_converted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TaxConverted { get; set; } 

    [JsonProperty("new_external_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ExternalLinkList? NewExternalLink { get; set; } 

    [JsonProperty("external_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ExternalLinkList? ExternalLink { get; set; } 

    [JsonProperty("ingram_quote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? IngramQuote { get; set; } 

    [JsonProperty("hubspot_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? HubspotId { get; set; } 

    [JsonProperty("item_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ItemTaxCode { get; set; } 

    [JsonProperty("baseprice_converted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? BasepriceConverted { get; set; } 

    [JsonProperty("unitprice_converted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? UnitpriceConverted { get; set; } 

    [JsonProperty("override_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OverrideTaxCode { get; set; } 

    [JsonProperty("baseprice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Baseprice { get; set; } 

    [JsonProperty("total_tax", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TotalTax { get; set; } 

    [JsonProperty("total_price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TotalPrice { get; set; } 

    [JsonProperty("total_discount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TotalDiscount { get; set; } 

    [JsonProperty("conversion_rate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? ConversionRate { get; set; } 

    [JsonProperty("discount_converted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? DiscountConverted { get; set; } 

    [JsonProperty("net_amount_converted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? NetAmountConverted { get; set; } 

    [JsonProperty("total_price_converted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TotalPriceConverted { get; set; } 

    [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Importtype { get; set; } 

    [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Isimport { get; set; } 

    [JsonProperty("tax_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TaxName { get; set; } 

    [JsonProperty("taxRuleResult", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<TaxRuleResult>? TaxRuleResult { get; set; } 

    [JsonProperty("decimalplacesforinvoices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Decimalplacesforinvoices { get; set; } 

    [JsonProperty("total_net_total", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TotalNetTotal { get; set; } 

}