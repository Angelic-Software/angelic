using System.CodeDom.Compiler;
using Angelic.KeyPairs;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class QuotationDetail
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("sort_seq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sort_seq { get; set; } 

    [JsonProperty("group_sort_seq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Group_sort_seq { get; set; } 

    [JsonProperty("productcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Productcode { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("costprice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Costprice { get; set; } 

    [JsonProperty("total_price_monthly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Total_price_monthly { get; set; } 

    [JsonProperty("total_price_monthly_converted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Total_price_monthly_converted { get; set; } 

    [JsonProperty("total_net_total_monthly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Total_net_total_monthly { get; set; } 

    [JsonProperty("total_costprice_monthly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Total_costprice_monthly { get; set; } 

    [JsonProperty("total_profit_monthly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Total_profit_monthly { get; set; } 

    [JsonProperty("total_tax_monthly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Total_tax_monthly { get; set; } 

    [JsonProperty("total_discount_monthly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Total_discount_monthly { get; set; } 

    [JsonProperty("total_price_annual", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Total_price_annual { get; set; } 

    [JsonProperty("total_price_annual_converted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Total_price_annual_converted { get; set; } 

    [JsonProperty("total_net_total_annual", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Total_net_total_annual { get; set; } 

    [JsonProperty("total_costprice_annual", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Total_costprice_annual { get; set; } 

    [JsonProperty("total_profit_annual", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Total_profit_annual { get; set; } 

    [JsonProperty("total_tax_annual", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Total_tax_annual { get; set; } 

    [JsonProperty("total_discount_annual", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Total_discount_annual { get; set; } 

    [JsonProperty("total_price_yearone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Total_price_yearone { get; set; } 

    [JsonProperty("total_price_yearone_converted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Total_price_yearone_converted { get; set; } 

    [JsonProperty("total_net_total_yearone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Total_net_total_yearone { get; set; } 

    [JsonProperty("total_costprice_yearone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Total_costprice_yearone { get; set; } 

    [JsonProperty("total_profit_yearone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Total_profit_yearone { get; set; } 

    [JsonProperty("total_tax_yearone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Total_tax_yearone { get; set; } 

    [JsonProperty("total_discount_yearone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Total_discount_yearone { get; set; } 

    [JsonProperty("qhid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Qhid { get; set; } 

    [JsonProperty("item_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Item_id { get; set; } 

    [JsonProperty("note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Note { get; set; } 

    [JsonProperty("note_hidden", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Note_hidden { get; set; } 

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
    public bool? Item_recurring { get; set; } 

    [JsonProperty("item_taxable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Item_taxable { get; set; } 

    [JsonProperty("group_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Group_id { get; set; } 

    [JsonProperty("printitem", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Printitem { get; set; } 

    [JsonProperty("isgroupdesc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Isgroupdesc { get; set; } 

    [JsonProperty("discount_perc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Discount_perc { get; set; } 

    [JsonProperty("supplier_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Supplier_id { get; set; } 

    [JsonProperty("supplier_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Supplier_name { get; set; } 

    [JsonProperty("optional", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Optional { get; set; } 

    [JsonProperty("approval_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Approval_status { get; set; } 

    [JsonProperty("cost_centre", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Cost_centre { get; set; } 

    [JsonProperty("stock_location", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Stock_location { get; set; } 

    [JsonProperty("item_internal_reference", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Item_internal_reference { get; set; } 

    [JsonProperty("item_external_reference", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Item_external_reference { get; set; } 

    [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Description { get; set; } 

    [JsonProperty("item_tax_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Item_tax_name { get; set; } 

    [JsonProperty("quoteitemurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Quoteitemurl { get; set; } 

    [JsonProperty("addedtorecurring", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Addedtorecurring { get; set; } 

    [JsonProperty("addedtononrecurring", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Addedtononrecurring { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

    [JsonProperty("assetgroup_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Assetgroup_id { get; set; } 

    [JsonProperty("maxitemdiscount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Maxitemdiscount { get; set; } 

    [JsonProperty("line_site_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Line_site_id { get; set; } 

    [JsonProperty("site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Site_name { get; set; } 

    [JsonProperty("line_periods", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Line_periods { get; set; } 

    [JsonProperty("hideitems", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Hideitems { get; set; } 

    [JsonProperty("ignoretaxcalc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Ignoretaxcalc { get; set; } 

    [JsonProperty("current_quantity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Current_quantity { get; set; } 

    [JsonProperty("current_price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Current_price { get; set; } 

    [JsonProperty("current_net_price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Current_net_price { get; set; } 

    [JsonProperty("isleased", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Isleased { get; set; } 

    [JsonProperty("stockbin_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Stockbin_id { get; set; } 

    [JsonProperty("quoter_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Quoter_id { get; set; } 

    [JsonProperty("is_bundled_line", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Is_bundled_line { get; set; } 

    [JsonProperty("optional_line_quantity_change", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Optional_line_quantity_change { get; set; } 

    [JsonProperty("created_from_group_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Created_from_group_id { get; set; } 

    [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomField>? Customfields { get; set; } 

    [JsonProperty("chargerates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Lookup>? Chargerates { get; set; } 

    [JsonProperty("budgets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<FaultBudget>? Budgets { get; set; } 

    [JsonProperty("item_template", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Item_template { get; set; } 

    [JsonProperty("item_contract", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Item_contract { get; set; } 

    [JsonProperty("hide_grouped_items_price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Hide_grouped_items_price { get; set; } 

    [JsonProperty("nominal_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Nominal_code { get; set; } 

    [JsonProperty("one_optional_mandatory", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<StringIdNameKeyPair>? One_optional_mandatory { get; set; } 

    [JsonProperty("one_optional_mandatory_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? One_optional_mandatory_list { get; set; } 

    [JsonProperty("force_quantity_relationship", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Force_quantity_relationship { get; set; } 

    [JsonProperty("force_price_relationship", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Force_price_relationship { get; set; } 

    [JsonProperty("force_term_relationship", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Force_term_relationship { get; set; } 

    [JsonProperty("price_calculation_formula", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Price_calculation_formula { get; set; } 

    [JsonProperty("purchase_currency_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Purchase_currency_code { get; set; } 

    [JsonProperty("cost_converted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Cost_converted { get; set; } 

    [JsonProperty("purchase_currency_code_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Purchase_currency_code_name { get; set; } 

    [JsonProperty("purchase_currency_symbol", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Purchase_currency_symbol { get; set; } 

    [JsonProperty("purchase_conversion_rate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Purchase_conversion_rate { get; set; } 

    [JsonProperty("stocklocation_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Stocklocation_id { get; set; } 

    [JsonProperty("exclude_auto_increase", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Exclude_auto_increase { get; set; } 

    [JsonProperty("auto_increase_period", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Auto_increase_period { get; set; } 

    [JsonProperty("percent_increase", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Percent_increase { get; set; } 

    [JsonProperty("use_rpi_increase", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Use_rpi_increase { get; set; } 

    [JsonProperty("net_total", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Net_total { get; set; } 

    [JsonProperty("total_tax_converted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Total_tax_converted { get; set; } 

    [JsonProperty("tax_converted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Tax_converted { get; set; } 

    [JsonProperty("new_external_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ExternalLink_List? New_external_link { get; set; } 

    [JsonProperty("external_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ExternalLink_List? External_link { get; set; } 

    [JsonProperty("ingram_quote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Ingram_quote { get; set; } 

    [JsonProperty("hubspot_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Hubspot_id { get; set; } 

    [JsonProperty("item_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Item_tax_code { get; set; } 

    [JsonProperty("baseprice_converted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Baseprice_converted { get; set; } 

    [JsonProperty("unitprice_converted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Unitprice_converted { get; set; } 

    [JsonProperty("override_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Override_tax_code { get; set; } 

    [JsonProperty("baseprice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Baseprice { get; set; } 

    [JsonProperty("total_tax", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Total_tax { get; set; } 

    [JsonProperty("total_price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Total_price { get; set; } 

    [JsonProperty("total_discount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Total_discount { get; set; } 

    [JsonProperty("conversion_rate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Conversion_rate { get; set; } 

    [JsonProperty("discount_converted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Discount_converted { get; set; } 

    [JsonProperty("net_amount_converted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Net_amount_converted { get; set; } 

    [JsonProperty("total_price_converted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Total_price_converted { get; set; } 

    [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _importtype { get; set; } 

    [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _isimport { get; set; } 

    [JsonProperty("tax_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Tax_name { get; set; } 

    [JsonProperty("taxRuleResult", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<TaxRuleResult>? TaxRuleResult { get; set; } 

    [JsonProperty("decimalplacesforinvoices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Decimalplacesforinvoices { get; set; } 

    [JsonProperty("total_net_total", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Total_net_total { get; set; } 

}