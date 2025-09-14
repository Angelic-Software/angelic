using System.CodeDom.Compiler;
using Angelic.Models.Assets;
using Newtonsoft.Json;

namespace Angelic.Models.Items;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record ItemStock
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("item_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ItemId { get; set; } 

    [JsonProperty("item_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ItemName { get; set; } 

    [JsonProperty("item_assettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ItemAssetTypeId { get; set; } 

    [JsonProperty("stocklocation_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? StockLocationId { get; set; } 

    [JsonProperty("stocklocation_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? StockLocationName { get; set; } 

    [JsonProperty("date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Date { get; set; } 

    [JsonProperty("quantity_in", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? QuantityIn { get; set; } 

    [JsonProperty("quantity_issued", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? QuantityIssued { get; set; } 

    [JsonProperty("quantity_remaining", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? QuantityRemaining { get; set; } 

    [JsonProperty("cost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Cost { get; set; } 

    [JsonProperty("supplier_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SupplierId { get; set; } 

    [JsonProperty("supplier_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SupplierName { get; set; } 

    [JsonProperty("purchaseorder_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PurchaseOrderId { get; set; } 

    [JsonProperty("purchaseorder_line_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PurchaseOrderLineId { get; set; } 

    [JsonProperty("purchaseorder_ref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PurchaseOrderRef { get; set; } 

    [JsonProperty("salesorder_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SalesOrderId { get; set; } 

    [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TicketId { get; set; } 

    [JsonProperty("serialised_asset_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SerialisedAssetCount { get; set; } 

    [JsonProperty("serialised_assets_in_stock", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SerialisedAssetsInStock { get; set; } 

    [JsonProperty("serialised_assets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AssetList>? SerialisedAssets { get; set; } 

    [JsonProperty("is_stock_take", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsStockTake { get; set; } 

    [JsonProperty("delivering_to_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DeliveringToUser { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("line_site_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? LineSiteId { get; set; } 

    [JsonProperty("stockbin_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? StockbinId { get; set; } 

    [JsonProperty("note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Note { get; set; } 

    [JsonProperty("real_quantity_in", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? RealQuantityIn { get; set; } 

    [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsImport { get; set; } 

    [JsonProperty("stockbin_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? StockbinName { get; set; } 

    [JsonProperty("serialise_only_one", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? SerialiseOnlyOne { get; set; } 

}