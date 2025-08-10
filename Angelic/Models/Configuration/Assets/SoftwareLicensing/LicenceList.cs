using System.CodeDom.Compiler;
using Angelic.Models.Assets;
using Angelic.Models.Configuration.Integrations.Microsoft.Azure.AzureAd;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Assets.SoftwareLicensing;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class LicenceList
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
    public int? ClientId { get; set; } 

    [JsonProperty("site_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SiteId { get; set; } 

    [JsonProperty("client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ClientName { get; set; } 

    [JsonProperty("site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SiteName { get; set; } 

    [JsonProperty("purchase_price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? PurchasePrice { get; set; } 

    [JsonProperty("start_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? StartDate { get; set; } 

    [JsonProperty("snowid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SnowId { get; set; } 

    [JsonProperty("manufacturer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Manufacturer { get; set; } 

    [JsonProperty("notes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Notes { get; set; } 

    [JsonProperty("licences_in_use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? LicencesInUse { get; set; } 

    [JsonProperty("licences_in_use_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? LicencesInUseUser { get; set; } 

    [JsonProperty("licences_available", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? LicencesAvailable { get; set; } 

    [JsonProperty("supplier_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SupplierId { get; set; } 

    [JsonProperty("supplier_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SupplierName { get; set; } 

    [JsonProperty("licence_client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? LicenceClientName { get; set; } 

    [JsonProperty("vendor", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Vendor { get; set; } 

    [JsonProperty("licence_roles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<LicenceRole>? LicenceRoles { get; set; } 

    [JsonProperty("end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? EndDate { get; set; } 

    [JsonProperty("tenant_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TenantId { get; set; } 

    [JsonProperty("tenant_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TenantName { get; set; } 

    [JsonProperty("name_extra", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NameExtra { get; set; } 

    [JsonProperty("deleted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Deleted { get; set; } 

    [JsonProperty("assigned_at_deletion", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AssignedAtDeletion { get; set; } 

    [JsonProperty("billing_cycle", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? BillingCycle { get; set; } 

    [JsonProperty("term_duration", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TermDuration { get; set; } 

    [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Status { get; set; } 

    [JsonProperty("autorenew", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AutoRenew { get; set; } 

    [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsImport { get; set; } 

    [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ImportType { get; set; } 

    [JsonProperty("_importchildren", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ImportChildren { get; set; } 

    [JsonProperty("third_party_product", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ThirdPartyProduct { get; set; } 

    [JsonProperty("price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Price { get; set; } 

    [JsonProperty("monthly_price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? MonthlyPrice { get; set; } 

    [JsonProperty("monthly_cost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? MonthlyCost { get; set; } 

    [JsonProperty("_removed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Removed { get; set; } 

    [JsonProperty("distributor", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Distributor { get; set; } 

    [JsonProperty("is_active", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsActive { get; set; } 

    [JsonProperty("azure_connection_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AzureConnectionId { get; set; } 

    [JsonProperty("azure_connection", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public AzureAdConnection? AzureConnection { get; set; } 

    [JsonProperty("requested_quantity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RequestedQuantity { get; set; } 

    [JsonProperty("requested_quantity_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? RequestedQuantityDate { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("ingram_micro_details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? IngramMicroDetailsId { get; set; } 

    [JsonProperty("_details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DetailsId { get; set; } 

    [JsonProperty("snow_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SnowClientId { get; set; } 

    [JsonProperty("thirdparty_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ThirdPartyClientId { get; set; } 

    [JsonProperty("product_sku", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ProductSku { get; set; } 

    [JsonProperty("vendor_product_sku", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? VendorProductSku { get; set; } 

    [JsonProperty("parent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ParentId { get; set; } 

    [JsonProperty("configuration_items", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AssetList>? ConfigurationItems { get; set; } 

    [JsonProperty("add_configuration_items", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AssetList>? AddConfigurationItems { get; set; } 

    [JsonProperty("licence_match", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<LicenceMatch>? LicenceMatch { get; set; } 

    [JsonProperty("device_child_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DeviceChildId { get; set; } 

    [JsonProperty("device_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DeviceCount { get; set; } 

    [JsonProperty("new_software", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public AssetApplications? NewSoftware { get; set; } 

}