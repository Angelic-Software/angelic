using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class SiteList
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? ClientId { get; set; } 

    [JsonProperty("client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ClientName { get; set; } 

    [JsonProperty("clientsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ClientsiteName { get; set; } 

    [JsonProperty("inactive", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Inactive { get; set; } 

    [JsonProperty("sla_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SlaId { get; set; } 

    [JsonProperty("phonenumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Phonenumber { get; set; } 

    [JsonProperty("colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Colour { get; set; } 

    [JsonProperty("timezone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Timezone { get; set; } 

    [JsonProperty("invoice_address_isdelivery", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? InvoiceAddressIsdelivery { get; set; } 

    [JsonProperty("notes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Notes { get; set; } 

    [JsonProperty("isstocklocation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Isstocklocation { get; set; } 

    [JsonProperty("messagegroup_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MessagegroupId { get; set; } 

    [JsonProperty("item_quantity_in_stock", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? ItemQuantityInStock { get; set; } 

    [JsonProperty("item_serialised_assets_in_stock", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? ItemSerialisedAssetsInStock { get; set; } 

    [JsonProperty("item_quantity_reserved", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? ItemQuantityReserved { get; set; } 

    [JsonProperty("item_quantity_reserved_on_order", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? ItemQuantityReservedOnOrder { get; set; } 

    [JsonProperty("item_quantity_available", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? ItemQuantityAvailable { get; set; } 

    [JsonProperty("use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Use { get; set; } 

    [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomField>? Customfields { get; set; } 

    [JsonProperty("site_fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<FieldHelper>? SiteFields { get; set; } 

    [JsonProperty("gfisiteid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Gfisiteid { get; set; } 

    [JsonProperty("delivery_address_line1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DeliveryAddressLine1 { get; set; } 

    [JsonProperty("delivery_address_line2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DeliveryAddressLine2 { get; set; } 

    [JsonProperty("delivery_address_line3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DeliveryAddressLine3 { get; set; } 

    [JsonProperty("delivery_address_line4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DeliveryAddressLine4 { get; set; } 

    [JsonProperty("delivery_address_line5", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DeliveryAddressLine5 { get; set; } 

    [JsonProperty("itglue_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ItglueId { get; set; } 

    [JsonProperty("client_itglue_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ClientItglueId { get; set; } 

    [JsonProperty("custombuttons", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomButton>? Custombuttons { get; set; } 

    [JsonProperty("stockbin_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? StockbinId { get; set; } 

    [JsonProperty("stockbin_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? StockbinName { get; set; } 

    [JsonProperty("country_code_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CountryCodeName { get; set; } 

    [JsonProperty("region_code_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RegionCodeName { get; set; } 

    [JsonProperty("ref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Ref { get; set; } 

    [JsonProperty("lapsafe_default_installation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? LapsafeDefaultInstallation { get; set; } 

    [JsonProperty("maincontact_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MaincontactId { get; set; } 

    [JsonProperty("site_item_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SiteItemTaxCode { get; set; } 

}