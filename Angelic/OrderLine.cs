using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class OrderLine
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("salesorder_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Salesorder_id { get; set; } 

    [JsonProperty("sort_seq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sort_seq { get; set; } 

    [JsonProperty("group_sort_seq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Group_sort_seq { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("productcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Productcode { get; set; } 

    [JsonProperty("item_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Item_id { get; set; } 

    [JsonProperty("assetgroup_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Assetgroup_name { get; set; } 

    [JsonProperty("assettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Assettype_id { get; set; } 

    [JsonProperty("costprice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Costprice { get; set; } 

    [JsonProperty("profit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Profit { get; set; } 

    [JsonProperty("profit_percentage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Profit_percentage { get; set; } 

    [JsonProperty("quantity_shipped", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Quantity_shipped { get; set; } 

    [JsonProperty("quantity_reserved", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Quantity_reserved { get; set; } 

    [JsonProperty("invoiced_quantity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Invoiced_quantity { get; set; } 

    [JsonProperty("quantity_on_open_po", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Quantity_on_open_po { get; set; } 

    [JsonProperty("total_costprice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Total_costprice { get; set; } 

    [JsonProperty("total_profit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Total_profit { get; set; } 

    [JsonProperty("total_price_monthly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Total_price_monthly { get; set; } 

    [JsonProperty("total_net_total_monthly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Total_net_total_monthly { get; set; } 

    [JsonProperty("total_costprice_monthly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Total_costprice_monthly { get; set; } 

    [JsonProperty("total_profit_monthly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Total_profit_monthly { get; set; } 

    [JsonProperty("total_tax_monthly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Total_tax_monthly { get; set; } 

    [JsonProperty("total_price_annual", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Total_price_annual { get; set; } 

    [JsonProperty("total_net_total_annual", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Total_net_total_annual { get; set; } 

    [JsonProperty("total_costprice_annual", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Total_costprice_annual { get; set; } 

    [JsonProperty("total_profit_annual", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Total_profit_annual { get; set; } 

    [JsonProperty("total_tax_annual", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Total_tax_annual { get; set; } 

    [JsonProperty("total_price_yearone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Total_price_yearone { get; set; } 

    [JsonProperty("total_net_total_yearone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Total_net_total_yearone { get; set; } 

    [JsonProperty("total_costprice_yearone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Total_costprice_yearone { get; set; } 

    [JsonProperty("total_profit_yearone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Total_profit_yearone { get; set; } 

    [JsonProperty("total_tax_yearone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Total_tax_yearone { get; set; } 

    [JsonProperty("unit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Unit { get; set; } 

    [JsonProperty("note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Note { get; set; } 

    [JsonProperty("stocklocation_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Stocklocation_id { get; set; } 

    [JsonProperty("stocklocation_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Stocklocation_name { get; set; } 

    [JsonProperty("quantity_in_stock", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Quantity_in_stock { get; set; } 

    [JsonProperty("total_quantity_in_stock", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Total_quantity_in_stock { get; set; } 

    [JsonProperty("total_quantity_reserved", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Total_quantity_reserved { get; set; } 

    [JsonProperty("selected", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Selected { get; set; } 

    [JsonProperty("servicefee", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Servicefee { get; set; } 

    [JsonProperty("recovery", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Recovery { get; set; } 

    [JsonProperty("margin", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Margin { get; set; } 

    [JsonProperty("poqty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Poqty { get; set; } 

    [JsonProperty("billingperiod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Billingperiod { get; set; } 

    [JsonProperty("startdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Startdate { get; set; } 

    [JsonProperty("autorenew", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Autorenew { get; set; } 

    [JsonProperty("recurringinvoice_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Recurringinvoice_id { get; set; } 

    [JsonProperty("item_recurring", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Item_recurring { get; set; } 

    [JsonProperty("line_recurring", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Line_recurring { get; set; } 

    [JsonProperty("item_contract", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Item_contract { get; set; } 

    [JsonProperty("item_template", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Item_template { get; set; } 

    [JsonProperty("item_budgettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Item_budgettype { get; set; } 

    [JsonProperty("item_doesnotneedconsigning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Item_doesnotneedconsigning { get; set; } 

    [JsonProperty("supplier_po", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Supplier_po { get; set; } 

    [JsonProperty("supplier_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Supplier_id { get; set; } 

    [JsonProperty("supplier_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Supplier_name { get; set; } 

    [JsonProperty("consignment_ids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<int>? Consignment_ids { get; set; } 

    [JsonProperty("quotation_line_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Quotation_line_id { get; set; } 

    [JsonProperty("group_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Group_id { get; set; } 

    [JsonProperty("isgroupdesc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Isgroupdesc { get; set; } 

    [JsonProperty("nominalcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Nominalcode { get; set; } 

    [JsonProperty("cost_centre", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Cost_centre { get; set; } 

    [JsonProperty("project_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Project_id { get; set; } 

    [JsonProperty("contract_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Contract_id { get; set; } 

    [JsonProperty("contract_ref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Contract_ref { get; set; } 

    [JsonProperty("do_not_invoice_line", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Do_not_invoice_line { get; set; } 

    [JsonProperty("item_description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Item_description { get; set; } 

    [JsonProperty("item_purchase_description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Item_purchase_description { get; set; } 

    [JsonProperty("item_note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Item_note { get; set; } 

    [JsonProperty("item_internal_reference", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Item_internal_reference { get; set; } 

    [JsonProperty("item_external_reference", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Item_external_reference { get; set; } 

    [JsonProperty("item_tax_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Item_tax_name { get; set; } 

    [JsonProperty("item_min_purchase_qty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Item_min_purchase_qty { get; set; } 

    [JsonProperty("_create_po", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _create_po { get; set; } 

    [JsonProperty("_create_ticket", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _create_ticket { get; set; } 

    [JsonProperty("quantity_to_reserve", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Quantity_to_reserve { get; set; } 

    [JsonProperty("assets_to_reserve", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Device_List>? Assets_to_reserve { get; set; } 

    [JsonProperty("reserved_assets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Device_List>? Reserved_assets { get; set; } 

    [JsonProperty("consigned_assets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Device_List>? Consigned_assets { get; set; } 

    [JsonProperty("invoice_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Invoice_id { get; set; } 

    [JsonProperty("soitemurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Soitemurl { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

    [JsonProperty("line_site_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Line_site_id { get; set; } 

    [JsonProperty("site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Site_name { get; set; } 

    [JsonProperty("client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Client_name { get; set; } 

    [JsonProperty("user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? User_name { get; set; } 

    [JsonProperty("user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? User_id { get; set; } 

    [JsonProperty("sales_order_ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Sales_order_ticket_id { get; set; } 

    [JsonProperty("sales_order_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Sales_order_date { get; set; } 

    [JsonProperty("sales_order_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sales_order_status { get; set; } 

    [JsonProperty("intacct_class", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Intacct_class { get; set; } 

    [JsonProperty("intacct_class_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Intacct_class_name { get; set; } 

    [JsonProperty("intacct_save_location", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Intacct_save_location { get; set; } 

    [JsonProperty("line_periods", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Line_periods { get; set; } 

    [JsonProperty("hideitems", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Hideitems { get; set; } 

    [JsonProperty("isleased", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Isleased { get; set; } 

    [JsonProperty("addbudget", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Addbudget { get; set; } 

    [JsonProperty("add_child_templates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Add_child_templates { get; set; } 

    [JsonProperty("stockbin_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Stockbin_id { get; set; } 

    [JsonProperty("isfreightline", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Isfreightline { get; set; } 

    [JsonProperty("asset_type_matching_field_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Asset_type_matching_field_name { get; set; } 

    [JsonProperty("items_in_group_no_consign", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Items_in_group_no_consign { get; set; } 

    [JsonProperty("serialise_only_one", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Serialise_only_one { get; set; } 

    [JsonProperty("invoice_ids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<int>? Invoice_ids { get; set; } 

    [JsonProperty("percentage_invoiced", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Percentage_invoiced { get; set; } 

    [JsonProperty("item_weight", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Item_weight { get; set; } 

    [JsonProperty("create_child_project", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Create_child_project { get; set; } 

    [JsonProperty("taxable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Taxable { get; set; } 

    [JsonProperty("project_child_faultid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Project_child_faultid { get; set; } 

    [JsonProperty("_create_invoice_percentage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? _create_invoice_percentage { get; set; } 

    [JsonProperty("is_bundled_line", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Is_bundled_line { get; set; } 

    [JsonProperty("dattocommercelineid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Dattocommercelineid { get; set; } 

    [JsonProperty("line_ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Line_ticket_id { get; set; } 

    [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomField>? Customfields { get; set; } 

    [JsonProperty("is_deferred_revenue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Is_deferred_revenue { get; set; } 

    [JsonProperty("chargerates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Lookup>? Chargerates { get; set; } 

    [JsonProperty("budgets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<FaultBudget>? Budgets { get; set; } 

    [JsonProperty("hide_grouped_items_price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Hide_grouped_items_price { get; set; } 

    [JsonProperty("discount_perc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Discount_perc { get; set; } 

    [JsonProperty("purchase_currency_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Purchase_currency_code { get; set; } 

    [JsonProperty("item_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Item_tax_code { get; set; } 

    [JsonProperty("cost_converted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Cost_converted { get; set; } 

    [JsonProperty("purchase_currency_code_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Purchase_currency_code_name { get; set; } 

    [JsonProperty("purchase_currency_symbol", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Purchase_currency_symbol { get; set; } 

    [JsonProperty("purchase_conversion_rate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Purchase_conversion_rate { get; set; } 

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

    [JsonProperty("mark_as_complete", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Mark_as_complete { get; set; } 

    [JsonProperty("consignment_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public AddressStore? Consignment_address { get; set; } 

    [JsonProperty("budget_add_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Budget_add_type { get; set; } 

    [JsonProperty("baseprice_converted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Baseprice_converted { get; set; } 

    [JsonProperty("baseprice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Baseprice { get; set; } 

    [JsonProperty("total_price_monthly_converted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Total_price_monthly_converted { get; set; } 

    [JsonProperty("total_price_annual_converted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Total_price_annual_converted { get; set; } 

    [JsonProperty("total_price_yearone_converted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Total_price_yearone_converted { get; set; } 

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