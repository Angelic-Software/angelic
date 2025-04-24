using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class SupplierOrderDetail
{
    [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomField>? Customfields { get; set; } 

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("sort_seq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sort_seq { get; set; } 

    [JsonProperty("productcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Productcode { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("quantity_received", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Quantity_received { get; set; } 

    [JsonProperty("purchaseorder_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Purchaseorder_id { get; set; } 

    [JsonProperty("item_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Item_id { get; set; } 

    [JsonProperty("assettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Assettype_id { get; set; } 

    [JsonProperty("note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Note { get; set; } 

    [JsonProperty("group_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Group_id { get; set; } 

    [JsonProperty("isgroupdesc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Isgroupdesc { get; set; } 

    [JsonProperty("salesorder_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Salesorder_id { get; set; } 

    [JsonProperty("salesorder_line_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Salesorder_line_id { get; set; } 

    [JsonProperty("sales_order_stock_location", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sales_order_stock_location { get; set; } 

    [JsonProperty("item_internal_reference", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Item_internal_reference { get; set; } 

    [JsonProperty("item_external_reference", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Item_external_reference { get; set; } 

    [JsonProperty("item_min_purchase_qty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Item_min_purchase_qty { get; set; } 

    [JsonProperty("xero_line_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Xero_line_id { get; set; } 

    [JsonProperty("item_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Item_code { get; set; } 

    [JsonProperty("accounts_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Accounts_code { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

    [JsonProperty("line_site_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Line_site_id { get; set; } 

    [JsonProperty("qbo_line_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Qbo_line_id { get; set; } 

    [JsonProperty("site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Site_name { get; set; } 

    [JsonProperty("hideitems", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Hideitems { get; set; } 

    [JsonProperty("invoiceid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Invoiceid { get; set; } 

    [JsonProperty("asset_type_matching_field_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Asset_type_matching_field_name { get; set; } 

    [JsonProperty("serialise_only_one", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Serialise_only_one { get; set; } 

    [JsonProperty("synced_to_intacct", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Synced_to_intacct { get; set; } 

    [JsonProperty("intacct_warehouse_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Intacct_warehouse_id { get; set; } 

    [JsonProperty("intacct_location_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Intacct_location_id { get; set; } 

    [JsonProperty("intacct_department_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Intacct_department_id { get; set; } 

    [JsonProperty("_create_invoice_percentage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? _create_invoice_percentage { get; set; } 

    [JsonProperty("percentage_invoiced", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Percentage_invoiced { get; set; } 

    [JsonProperty("invoiced_quantity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Invoiced_quantity { get; set; } 

    [JsonProperty("myob_location", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Myob_location { get; set; } 

    [JsonProperty("myob_row_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Myob_row_id { get; set; } 

    [JsonProperty("entity_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Entity_type { get; set; } 

    [JsonProperty("item_dont_receive_on_po", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Item_dont_receive_on_po { get; set; } 

    [JsonProperty("net_total", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Net_total { get; set; } 

    [JsonProperty("total_tax_converted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Total_tax_converted { get; set; } 

    [JsonProperty("tax_converted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Tax_converted { get; set; } 

    [JsonProperty("quote_line_distributor_external_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ExternalLink_List? Quote_line_distributor_external_link { get; set; } 

    [JsonProperty("new_external_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ExternalLink_List? New_external_link { get; set; } 

    [JsonProperty("date_received", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Date_received { get; set; } 

    [JsonProperty("override_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Override_tax_code { get; set; } 

    [JsonProperty("baseprice_converted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Baseprice_converted { get; set; } 

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