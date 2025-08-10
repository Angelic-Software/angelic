using System.CodeDom.Compiler;
using Angelic.Models.KeyPairs;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.Xero;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class XeroDetails
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("tenant_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TenantId { get; set; } 

    [JsonProperty("tenant_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TenantName { get; set; } 

    [JsonProperty("new_access_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewAccessToken { get; set; } 

    [JsonProperty("new_refresh_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewRefreshToken { get; set; } 

    [JsonProperty("token_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? TokenExpiry { get; set; } 

    [JsonProperty("authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Authorized { get; set; } 

    [JsonProperty("redirect_uri", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RedirectUri { get; set; } 

    [JsonProperty("code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Code { get; set; } 

    [JsonProperty("_exchangecode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ExchangeCode { get; set; } 

    [JsonProperty("_disconnect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Disconnect { get; set; } 

    [JsonProperty("client_top_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ClientTopLevel { get; set; } 

    [JsonProperty("client_top_level_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ClientTopLevelName { get; set; } 

    [JsonProperty("item_group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ItemGroup { get; set; } 

    [JsonProperty("item_group_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ItemGroupName { get; set; } 

    [JsonProperty("isdefault", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsDefault { get; set; } 

    [JsonProperty("enablesync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Enablesync { get; set; } 

    [JsonProperty("default_item_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultItemCode { get; set; } 

    [JsonProperty("show_message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowMessage { get; set; } 

    [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ImportType { get; set; } 

    [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ClientId { get; set; } 

    [JsonProperty("new_client_secret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewClientSecret { get; set; } 

    [JsonProperty("sync_entities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SyncEntities { get; set; } 

    [JsonProperty("sync_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ValueLabelIsNewKeyPair>? SyncEntitiesList { get; set; } 

    [JsonProperty("supplier_top_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SupplierTopLevel { get; set; } 

    [JsonProperty("supplier_top_level_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SupplierTopLevelName { get; set; } 

    [JsonProperty("archive_contacts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ArchiveContacts { get; set; } 

    [JsonProperty("default_order_item_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultOrderItemCode { get; set; } 

    [JsonProperty("rounding_adjustment_account_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RoundingAdjustmentAccountCode { get; set; } 

    [JsonProperty("group_rounding_adjustments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? GroupRoundingAdjustments { get; set; } 

    [JsonProperty("new_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? NewMethod { get; set; } 

    [JsonProperty("receive_client_created", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ReceiveClientCreated { get; set; } 

    [JsonProperty("receive_client_updated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ReceiveClientUpdated { get; set; } 

    [JsonProperty("receive_invoice_created", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ReceiveInvoiceCreated { get; set; } 

    [JsonProperty("receive_invoice_updated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ReceiveInvoiceUpdated { get; set; } 

    [JsonProperty("default_creditnote_item_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultCreditnoteItemCode { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("sync_currency_for_invoices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? SyncCurrencyForInvoices { get; set; } 

    [JsonProperty("no_item_group_sync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? NoItemGroupSync { get; set; } 

    [JsonProperty("invoice_description_data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? InvoiceDescriptionData { get; set; } 

    [JsonProperty("dont_sync_cost_tracking_lines", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DontSyncCostTrackingLines { get; set; } 

    [JsonProperty("organisation_version", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OrganisationVersion { get; set; } 

    [JsonProperty("no_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NoTaxCode { get; set; } 

    [JsonProperty("category_1_keypair", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ValueLabelIsNewKeyPair? Category1Keypair { get; set; } 

    [JsonProperty("category_2_keypair", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ValueLabelIsNewKeyPair? Category2Keypair { get; set; } 

    [JsonProperty("category_1_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Category1Name { get; set; } 

    [JsonProperty("category_1_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Category1Id { get; set; } 

    [JsonProperty("category_2_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Category2Name { get; set; } 

    [JsonProperty("category_2_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Category2Id { get; set; } 

}