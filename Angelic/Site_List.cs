using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Site_List
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Client_id { get; set; } 

    [JsonProperty("client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Client_name { get; set; } 

    [JsonProperty("clientsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Clientsite_name { get; set; } 

    [JsonProperty("inactive", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Inactive { get; set; } 

    [JsonProperty("sla_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sla_id { get; set; } 

    [JsonProperty("phonenumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Phonenumber { get; set; } 

    [JsonProperty("colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Colour { get; set; } 

    [JsonProperty("timezone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Timezone { get; set; } 

    [JsonProperty("invoice_address_isdelivery", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Invoice_address_isdelivery { get; set; } 

    [JsonProperty("notes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Notes { get; set; } 

    [JsonProperty("isstocklocation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Isstocklocation { get; set; } 

    [JsonProperty("messagegroup_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Messagegroup_id { get; set; } 

    [JsonProperty("item_quantity_in_stock", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Item_quantity_in_stock { get; set; } 

    [JsonProperty("item_serialised_assets_in_stock", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Item_serialised_assets_in_stock { get; set; } 

    [JsonProperty("item_quantity_reserved", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Item_quantity_reserved { get; set; } 

    [JsonProperty("item_quantity_reserved_on_order", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Item_quantity_reserved_on_order { get; set; } 

    [JsonProperty("item_quantity_available", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Item_quantity_available { get; set; } 

    [JsonProperty("use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Use { get; set; } 

    [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomField>? Customfields { get; set; } 

    [JsonProperty("site_fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<FieldHelper>? Site_fields { get; set; } 

    [JsonProperty("gfisiteid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Gfisiteid { get; set; } 

    [JsonProperty("delivery_address_line1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Delivery_address_line1 { get; set; } 

    [JsonProperty("delivery_address_line2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Delivery_address_line2 { get; set; } 

    [JsonProperty("delivery_address_line3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Delivery_address_line3 { get; set; } 

    [JsonProperty("delivery_address_line4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Delivery_address_line4 { get; set; } 

    [JsonProperty("delivery_address_line5", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Delivery_address_line5 { get; set; } 

    [JsonProperty("itglue_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Itglue_id { get; set; } 

    [JsonProperty("client_itglue_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Client_itglue_id { get; set; } 

    [JsonProperty("custombuttons", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomButton>? Custombuttons { get; set; } 

    [JsonProperty("stockbin_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Stockbin_id { get; set; } 

    [JsonProperty("stockbin_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Stockbin_name { get; set; } 

    [JsonProperty("country_code_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Country_code_name { get; set; } 

    [JsonProperty("region_code_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Region_code_name { get; set; } 

    [JsonProperty("ref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Ref { get; set; } 

    [JsonProperty("lapsafe_default_installation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Lapsafe_default_installation { get; set; } 

    [JsonProperty("maincontact_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Maincontact_id { get; set; } 

    [JsonProperty("site_item_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Site_item_tax_code { get; set; } 

}