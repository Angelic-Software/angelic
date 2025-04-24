using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class InvoiceDetail
{
    [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomField>? Customfields { get; set; } 

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("ihid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Ihid { get; set; } 

    [JsonProperty("item_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Item_code { get; set; } 

    [JsonProperty("item_shortdescription", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Item_shortdescription { get; set; } 

    [JsonProperty("item_longdescription", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Item_longdescription { get; set; } 

    [JsonProperty("nominal_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Nominal_code { get; set; } 

    [JsonProperty("tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Tax_code { get; set; } 

    [JsonProperty("qty_order", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Qty_order { get; set; } 

    [JsonProperty("unit_price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Unit_price { get; set; } 

    [JsonProperty("unit_price_converted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Unit_price_converted { get; set; } 

    [JsonProperty("net_amount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Net_amount { get; set; } 

    [JsonProperty("tax_amount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Tax_amount { get; set; } 

    [JsonProperty("tax_rate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Tax_rate { get; set; } 

    [JsonProperty("comment_1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Comment_1 { get; set; } 

    [JsonProperty("comment_2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Comment_2 { get; set; } 

    [JsonProperty("itemonorder", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Itemonorder { get; set; } 

    [JsonProperty("dsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Dsite { get; set; } 

    [JsonProperty("ddevnum", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Ddevnum { get; set; } 

    [JsonProperty("_itemid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? _itemid { get; set; } 

    [JsonProperty("productnumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Productnumber { get; set; } 

    [JsonProperty("unit_cost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Unit_cost { get; set; } 

    [JsonProperty("asset_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Asset_id { get; set; } 

    [JsonProperty("asset_inventory_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Asset_inventory_number { get; set; } 

    [JsonProperty("contract_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Contract_id { get; set; } 

    [JsonProperty("recurring_invoice_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Recurring_invoice_id { get; set; } 

    [JsonProperty("recurring_invoice_line_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Recurring_invoice_line_id { get; set; } 

    [JsonProperty("actioncode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Actioncode { get; set; } 

    [JsonProperty("site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Site { get; set; } 

    [JsonProperty("meter_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Meter_id { get; set; } 

    [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Ticket_id { get; set; } 

    [JsonProperty("lineactiondate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Lineactiondate { get; set; } 

    [JsonProperty("labourdepartmentid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Labourdepartmentid { get; set; } 

    [JsonProperty("salesorder_line", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Salesorder_line { get; set; } 

    [JsonProperty("salesorder_line_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Salesorder_line_id { get; set; } 

    [JsonProperty("meter_pricing_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Meter_pricing_method { get; set; } 

    [JsonProperty("line_fully_invoiced", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Line_fully_invoiced { get; set; } 

    [JsonProperty("xero_lineid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Xero_lineid { get; set; } 

    [JsonProperty("prepay_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Prepay_id { get; set; } 

    [JsonProperty("calculate_price_from_assets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Calculate_price_from_assets { get; set; } 

    [JsonProperty("calculate_price_from_users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Calculate_price_from_users { get; set; } 

    [JsonProperty("creditlinkedidid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Creditlinkedidid { get; set; } 

    [JsonProperty("recurring_invoice_price_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Recurring_invoice_price_type { get; set; } 

    [JsonProperty("entity_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Entity_type { get; set; } 

    [JsonProperty("item_internal_reference", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Item_internal_reference { get; set; } 

    [JsonProperty("item_external_reference", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Item_external_reference { get; set; } 

    [JsonProperty("linked_item", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Item? Linked_item { get; set; } 

    [JsonProperty("item_tax_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Item_tax_name { get; set; } 

    [JsonProperty("xero_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Xero_tax_code { get; set; } 

    [JsonProperty("override_ast_total", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Override_ast_total { get; set; } 

    [JsonProperty("prorata_next_invoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Prorata_next_invoice { get; set; } 

    [JsonProperty("prorata_quantity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Prorata_quantity { get; set; } 

    [JsonProperty("prorata_unit_price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Prorata_unit_price { get; set; } 

    [JsonProperty("prorata_shortdescription", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Prorata_shortdescription { get; set; } 

    [JsonProperty("prorata_longdescription", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Prorata_longdescription { get; set; } 

    [JsonProperty("isinactive", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Isinactive { get; set; } 

    [JsonProperty("period_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Period_type { get; set; } 

    [JsonProperty("group_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Group_id { get; set; } 

    [JsonProperty("isgroupdesc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Isgroupdesc { get; set; } 

    [JsonProperty("kashflow_line_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Kashflow_line_id { get; set; } 

    [JsonProperty("_is_calculated_line", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _is_calculated_line { get; set; } 

    [JsonProperty("tax_code_overriden", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Tax_code_overriden { get; set; } 

    [JsonProperty("is_meter", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Is_meter { get; set; } 

    [JsonProperty("current_reading", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Current_reading { get; set; } 

    [JsonProperty("last_reading_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Last_reading_date { get; set; } 

    [JsonProperty("prorata_data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<InvoiceDetailProRata>? Prorata_data { get; set; } 

    [JsonProperty("quantity_users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<InvoiceDetailQuantity>? Quantity_users { get; set; } 

    [JsonProperty("quantity_assets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<InvoiceDetailQuantity>? Quantity_assets { get; set; } 

    [JsonProperty("quantity_licences", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<InvoiceDetailQuantity>? Quantity_licences { get; set; } 

    [JsonProperty("quantity_subscriptions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<InvoiceDetailQuantity>? Quantity_subscriptions { get; set; } 

    [JsonProperty("recurring_invoice_quantity_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Recurring_invoice_quantity_type { get; set; } 

    [JsonProperty("quantity_custom", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Quantity_custom { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

    [JsonProperty("billingperiod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Billingperiod { get; set; } 

    [JsonProperty("line_periods", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Line_periods { get; set; } 

    [JsonProperty("percent_increase", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Percent_increase { get; set; } 

    [JsonProperty("min_meter_units", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Min_meter_units { get; set; } 

    [JsonProperty("sequenceid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sequenceid { get; set; } 

    [JsonProperty("startdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Startdate { get; set; } 

    [JsonProperty("enddate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Enddate { get; set; } 

    [JsonProperty("autorenew", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Autorenew { get; set; } 

    [JsonProperty("autorenewperiod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Autorenewperiod { get; set; } 

    [JsonProperty("intacct_location_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Intacct_location_id { get; set; } 

    [JsonProperty("intacct_department_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Intacct_department_id { get; set; } 

    [JsonProperty("synced_to_intacct", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Synced_to_intacct { get; set; } 

    [JsonProperty("hideitems", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Hideitems { get; set; } 

    [JsonProperty("includegrouppriceandqty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Includegrouppriceandqty { get; set; } 

    [JsonProperty("auto_increase_period", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Auto_increase_period { get; set; } 

    [JsonProperty("auto_increase_last_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Auto_increase_last_date { get; set; } 

    [JsonProperty("onetimecharge", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Onetimecharge { get; set; } 

    [JsonProperty("onetimechargeinvoiceid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Onetimechargeinvoiceid { get; set; } 

    [JsonProperty("needsreviewbeforecreation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Needsreviewbeforecreation { get; set; } 

    [JsonProperty("reviewed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Reviewed { get; set; } 

    [JsonProperty("metertype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Metertype { get; set; } 

    [JsonProperty("importcsvid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Importcsvid { get; set; } 

    [JsonProperty("force_new", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Force_new { get; set; } 

    [JsonProperty("client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Client_name { get; set; } 

    [JsonProperty("dbc_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Dbc_id { get; set; } 

    [JsonProperty("purchaseorder_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Purchaseorder_id { get; set; } 

    [JsonProperty("purchaseorder_line_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Purchaseorder_line_id { get; set; } 

    [JsonProperty("discount_perc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Discount_perc { get; set; } 

    [JsonProperty("exclude_auto_increase", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Exclude_auto_increase { get; set; } 

    [JsonProperty("createproratanormallines", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Createproratanormallines { get; set; } 

    [JsonProperty("createproratadate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Createproratadate { get; set; } 

    [JsonProperty("pro_rata_line_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Pro_rata_line_id { get; set; } 

    [JsonProperty("supplier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Supplier { get; set; } 

    [JsonProperty("supplier_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Supplier_name { get; set; } 

    [JsonProperty("hide_on_pdf", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Hide_on_pdf { get; set; } 

    [JsonProperty("intacct_warehouse_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Intacct_warehouse_id { get; set; } 

    [JsonProperty("invoice_class", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Invoice_class { get; set; } 

    [JsonProperty("percent_invoiced", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Percent_invoiced { get; set; } 

    [JsonProperty("is_bundled_line", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Is_bundled_line { get; set; } 

    [JsonProperty("meter_tiers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<InvoiceDetailMeterTiers>? Meter_tiers { get; set; } 

    [JsonProperty("meter_min_quantity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Meter_min_quantity { get; set; } 

    [JsonProperty("original_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Original_client_id { get; set; } 

    [JsonProperty("myob_location", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Myob_location { get; set; } 

    [JsonProperty("myob_row_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Myob_row_id { get; set; } 

    [JsonProperty("dbc_sequence_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Dbc_sequence_id { get; set; } 

    [JsonProperty("minimum_line_total", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Minimum_line_total { get; set; } 

    [JsonProperty("hide_grouped_items_price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Hide_grouped_items_price { get; set; } 

    [JsonProperty("credit_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Credit_id { get; set; } 

    [JsonProperty("is_deferred_revenue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Is_deferred_revenue { get; set; } 

    [JsonProperty("deferred_revenue_olid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Deferred_revenue_olid { get; set; } 

    [JsonProperty("deferred_revenue_olseq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Deferred_revenue_olseq { get; set; } 

    [JsonProperty("is_recognised_revenue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Is_recognised_revenue { get; set; } 

    [JsonProperty("no_tax_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? No_tax_override { get; set; } 

    [JsonProperty("_temp_order_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? _temp_order_id { get; set; } 

    [JsonProperty("_temp_order_seq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? _temp_order_seq { get; set; } 

    [JsonProperty("_temp_order_qty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? _temp_order_qty { get; set; } 

    [JsonProperty("item_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Item_tax_code { get; set; } 

    [JsonProperty("_updateprorata", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _updateprorata { get; set; } 

    [JsonProperty("bundle_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Bundle_id { get; set; } 

    [JsonProperty("bundle_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Bundle_name { get; set; } 

    [JsonProperty("bundle_line_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Bundle_line_id { get; set; } 

    [JsonProperty("xero_category_1_lookup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Xero_category_1_lookup { get; set; } 

    [JsonProperty("xero_category_2_lookup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Xero_category_2_lookup { get; set; } 

    [JsonProperty("xero_category_1_lookup_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Xero_category_1_lookup_name { get; set; } 

    [JsonProperty("xero_category_2_lookup_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Xero_category_2_lookup_name { get; set; } 

    [JsonProperty("use_rpi_increase", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Use_rpi_increase { get; set; } 

    [JsonProperty("merge_lines_if_matched", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Merge_lines_if_matched { get; set; } 

    [JsonProperty("surcharge_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Surcharge_id { get; set; } 

    [JsonProperty("override_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Override_tax_code { get; set; } 

    [JsonProperty("baseprice_converted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Baseprice_converted { get; set; } 

    [JsonProperty("baseprice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Baseprice { get; set; } 

    [JsonProperty("unitprice_converted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Unitprice_converted { get; set; } 

    [JsonProperty("total_tax_converted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Total_tax_converted { get; set; } 

    [JsonProperty("net_total", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Net_total { get; set; } 

    [JsonProperty("tax_converted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Tax_converted { get; set; } 

    [JsonProperty("total_tax", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Total_tax { get; set; } 

    [JsonProperty("total_price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Total_price { get; set; } 

    [JsonProperty("total_discount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Total_discount { get; set; } 

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