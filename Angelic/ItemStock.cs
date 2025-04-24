using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ItemStock
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("item_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Item_id { get; set; } 

    [JsonProperty("item_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Item_name { get; set; } 

    [JsonProperty("item_assettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Item_assettype_id { get; set; } 

    [JsonProperty("stocklocation_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Stocklocation_id { get; set; } 

    [JsonProperty("stocklocation_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Stocklocation_name { get; set; } 

    [JsonProperty("date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Date { get; set; } 

    [JsonProperty("quantity_in", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Quantity_in { get; set; } 

    [JsonProperty("quantity_issued", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Quantity_issued { get; set; } 

    [JsonProperty("quantity_remaining", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Quantity_remaining { get; set; } 

    [JsonProperty("cost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Cost { get; set; } 

    [JsonProperty("supplier_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Supplier_id { get; set; } 

    [JsonProperty("supplier_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Supplier_name { get; set; } 

    [JsonProperty("purchaseorder_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Purchaseorder_id { get; set; } 

    [JsonProperty("purchaseorder_line_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Purchaseorder_line_id { get; set; } 

    [JsonProperty("purchaseorder_ref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Purchaseorder_ref { get; set; } 

    [JsonProperty("salesorder_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Salesorder_id { get; set; } 

    [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Ticket_id { get; set; } 

    [JsonProperty("serialised_asset_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Serialised_asset_count { get; set; } 

    [JsonProperty("serialised_assets_in_stock", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Serialised_assets_in_stock { get; set; } 

    [JsonProperty("serialised_assets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Device_List>? Serialised_assets { get; set; } 

    [JsonProperty("is_stock_take", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Is_stock_take { get; set; } 

    [JsonProperty("delivering_to_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Delivering_to_user { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

    [JsonProperty("line_site_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Line_site_id { get; set; } 

    [JsonProperty("stockbin_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Stockbin_id { get; set; } 

    [JsonProperty("note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Note { get; set; } 

    [JsonProperty("real_quantity_in", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Real_quantity_in { get; set; } 

    [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _isimport { get; set; } 

    [JsonProperty("stockbin_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Stockbin_name { get; set; } 

    [JsonProperty("serialise_only_one", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Serialise_only_one { get; set; } 

}