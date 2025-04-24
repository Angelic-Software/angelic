using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class FaultItem
{
    [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Ticket_id { get; set; } 

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("item_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Item_id { get; set; } 

    [JsonProperty("quantity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Quantity { get; set; } 

    [JsonProperty("quantity_shipped", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Quantity_shipped { get; set; } 

    [JsonProperty("unit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Unit { get; set; } 

    [JsonProperty("costprice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Costprice { get; set; } 

    [JsonProperty("price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Price { get; set; } 

    [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Status { get; set; } 

    [JsonProperty("date_shipped", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Date_shipped { get; set; } 

    [JsonProperty("note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Note { get; set; } 

    [JsonProperty("note2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Note2 { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("supplier_part_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Supplier_part_code { get; set; } 

    [JsonProperty("stocklocation_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Stocklocation_id { get; set; } 

    [JsonProperty("stocklocation_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Stocklocation_name { get; set; } 

    [JsonProperty("quantity_in_stock", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Quantity_in_stock { get; set; } 

    [JsonProperty("asset_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Asset_number { get; set; } 

    [JsonProperty("asset_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Asset_site { get; set; } 

    [JsonProperty("warranty_reported", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Warranty_reported { get; set; } 

    [JsonProperty("selected", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Selected { get; set; } 

    [JsonProperty("stock_adjusted_already", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Stock_adjusted_already { get; set; } 

    [JsonProperty("cost_centre", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Cost_centre { get; set; } 

    [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Agent_id { get; set; } 

    [JsonProperty("assetgroup_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Assetgroup_name { get; set; } 

    [JsonProperty("assettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Assettype_id { get; set; } 

    [JsonProperty("assettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Assettype_name { get; set; } 

    [JsonProperty("supplier_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Supplier_name { get; set; } 

    [JsonProperty("tax", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Tax { get; set; } 

    [JsonProperty("item_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Item_tax_code { get; set; } 

    [JsonProperty("item_taxable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Item_taxable { get; set; } 

    [JsonProperty("item_generic", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Item_generic { get; set; } 

    [JsonProperty("item_recurring", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Item_recurring { get; set; } 

    [JsonProperty("item_internal_reference", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Item_internal_reference { get; set; } 

    [JsonProperty("item_external_reference", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Item_external_reference { get; set; } 

    [JsonProperty("item_tax_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Item_tax_name { get; set; } 

    [JsonProperty("net_total", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Net_total { get; set; } 

    [JsonProperty("total_price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Total_price { get; set; } 

    [JsonProperty("total_tax", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Total_tax { get; set; } 

    [JsonProperty("total_net_total", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Total_net_total { get; set; } 

    [JsonProperty("consignment_ids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<int>? Consignment_ids { get; set; } 

    [JsonProperty("asset_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Asset_id { get; set; } 

    [JsonProperty("from_order_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? From_order_id { get; set; } 

    [JsonProperty("from_order_line", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? From_order_line { get; set; } 

    [JsonProperty("reserved_assets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Device_List>? Reserved_assets { get; set; } 

    [JsonProperty("inventory_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Inventory_number { get; set; } 

    [JsonProperty("stockbin_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Stockbin_id { get; set; } 

    [JsonProperty("asset_type_matching_field_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Asset_type_matching_field_name { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

    [JsonProperty("budgettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Budgettype_id { get; set; } 

}