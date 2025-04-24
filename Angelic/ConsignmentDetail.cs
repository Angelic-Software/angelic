using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ConsignmentDetail
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("consignment_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ConsignmentId { get; set; } 

    [JsonProperty("item_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ItemId { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("quantity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Quantity { get; set; } 

    [JsonProperty("invoice_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? InvoiceId { get; set; } 

    [JsonProperty("salesorder_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SalesorderId { get; set; } 

    [JsonProperty("salesorder_line", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SalesorderLine { get; set; } 

    [JsonProperty("stocklocation_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? StocklocationId { get; set; } 

    [JsonProperty("costprice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Costprice { get; set; } 

    [JsonProperty("price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Price { get; set; } 

    [JsonProperty("itemstock_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ItemstockId { get; set; } 

    [JsonProperty("item_assettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ItemAssettypeId { get; set; } 

    [JsonProperty("supplier_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SupplierId { get; set; } 

    [JsonProperty("stockadjustedamount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Stockadjustedamount { get; set; } 

    [JsonProperty("serialised_assets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Device_List>? SerialisedAssets { get; set; } 

    [JsonProperty("stockbin_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? StockbinId { get; set; } 

    [JsonProperty("serialise_only_one", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? SerialiseOnlyOne { get; set; } 

    [JsonProperty("is_return", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsReturn { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("item_internalreference", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ItemInternalreference { get; set; } 

    [JsonProperty("item_externalreference", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ItemExternalreference { get; set; } 

    [JsonProperty("item_supplier_part_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ItemSupplierPartCode { get; set; } 

    [JsonProperty("item_description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ItemDescription { get; set; } 

    [JsonProperty("item_purchase_description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ItemPurchaseDescription { get; set; } 

    [JsonProperty("item_location", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ItemLocation { get; set; } 

}