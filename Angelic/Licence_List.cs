using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Licence_List
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Type { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Count { get; set; } 

    [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Client_id { get; set; } 

    [JsonProperty("site_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Site_id { get; set; } 

    [JsonProperty("client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Client_name { get; set; } 

    [JsonProperty("site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Site_name { get; set; } 

    [JsonProperty("purchase_price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Purchase_price { get; set; } 

    [JsonProperty("start_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Start_date { get; set; } 

    [JsonProperty("snowid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Snowid { get; set; } 

    [JsonProperty("manufacturer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Manufacturer { get; set; } 

    [JsonProperty("notes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Notes { get; set; } 

    [JsonProperty("licences_in_use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Licences_in_use { get; set; } 

    [JsonProperty("licences_in_use_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Licences_in_use_user { get; set; } 

    [JsonProperty("licences_available", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Licences_available { get; set; } 

    [JsonProperty("supplier_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Supplier_id { get; set; } 

    [JsonProperty("supplier_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Supplier_name { get; set; } 

    [JsonProperty("licence_client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Licence_client_name { get; set; } 

    [JsonProperty("vendor", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Vendor { get; set; } 

    [JsonProperty("licence_roles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<LicenceRole>? Licence_roles { get; set; } 

    [JsonProperty("end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? End_date { get; set; } 

    [JsonProperty("tenant_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Tenant_id { get; set; } 

    [JsonProperty("tenant_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Tenant_name { get; set; } 

    [JsonProperty("name_extra", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name_extra { get; set; } 

    [JsonProperty("deleted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Deleted { get; set; } 

    [JsonProperty("assigned_at_deletion", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Assigned_at_deletion { get; set; } 

    [JsonProperty("billing_cycle", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Billing_cycle { get; set; } 

    [JsonProperty("term_duration", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Term_duration { get; set; } 

    [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Status { get; set; } 

    [JsonProperty("autorenew", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Autorenew { get; set; } 

    [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _isimport { get; set; } 

    [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _importtype { get; set; } 

    [JsonProperty("_importchildren", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _importchildren { get; set; } 

    [JsonProperty("third_party_product", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Third_party_product { get; set; } 

    [JsonProperty("price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Price { get; set; } 

    [JsonProperty("monthly_price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Monthly_price { get; set; } 

    [JsonProperty("monthly_cost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Monthly_cost { get; set; } 

    [JsonProperty("_removed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _removed { get; set; } 

    [JsonProperty("distributor", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Distributor { get; set; } 

    [JsonProperty("is_active", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Is_active { get; set; } 

    [JsonProperty("azure_connection_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Azure_connection_id { get; set; } 

    [JsonProperty("azure_connection", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public AzureAdConnection? Azure_connection { get; set; } 

    [JsonProperty("requested_quantity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Requested_quantity { get; set; } 

    [JsonProperty("requested_quantity_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Requested_quantity_date { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

    [JsonProperty("ingram_micro_details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Ingram_micro_details_id { get; set; } 

    [JsonProperty("_details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? _details_id { get; set; } 

    [JsonProperty("snow_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Snow_client_id { get; set; } 

    [JsonProperty("thirdparty_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Thirdparty_client_id { get; set; } 

    [JsonProperty("product_sku", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Product_sku { get; set; } 

    [JsonProperty("vendor_product_sku", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Vendor_product_sku { get; set; } 

    [JsonProperty("parent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Parent_id { get; set; } 

    [JsonProperty("configuration_items", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Device_List>? Configuration_items { get; set; } 

    [JsonProperty("add_configuration_items", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Device_List>? Add_configuration_items { get; set; } 

    [JsonProperty("licence_match", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<LicenceMatch>? Licence_match { get; set; } 

    [JsonProperty("device_child_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Device_child_id { get; set; } 

    [JsonProperty("device_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Device_count { get; set; } 

    [JsonProperty("new_software", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DeviceApplications? New_software { get; set; } 

}