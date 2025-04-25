using System.CodeDom.Compiler;
using Angelic.KeyPairs;
using Newtonsoft.Json;

namespace Angelic.Configuration.Integrations.Quickbooks;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class QuickBooksDetails
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("country", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Country { get; set; } 

    [JsonProperty("company_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CompanyId { get; set; } 

    [JsonProperty("company_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CompanyName { get; set; } 

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

    [JsonProperty("authorization_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AuthorizationCode { get; set; } 

    [JsonProperty("_exchangecode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Exchangecode { get; set; } 

    [JsonProperty("_disconnect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Disconnect { get; set; } 

    [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ImportType { get; set; } 

    [JsonProperty("new_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? NewMethod { get; set; } 

    [JsonProperty("automatic_sales_tax", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AutomaticSalesTax { get; set; } 

    [JsonProperty("online_payments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? OnlinePayments { get; set; } 

    [JsonProperty("api_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ApiUrl { get; set; } 

    [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ClientId { get; set; } 

    [JsonProperty("new_client_secret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewClientSecret { get; set; } 

    [JsonProperty("default_tax_code_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultTaxCodeId { get; set; } 

    [JsonProperty("default_tax_code_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultTaxCodeName { get; set; } 

    [JsonProperty("default_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ValueLabelIsNewKeyPair? DefaultTaxCode { get; set; } 

    [JsonProperty("zero_tax_rate_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ZeroTaxRateId { get; set; } 

    [JsonProperty("zero_tax_rate_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ZeroTaxRateName { get; set; } 

    [JsonProperty("zero_tax_rate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ValueLabelIsNewKeyPair? ZeroTaxRate { get; set; } 

    [JsonProperty("client_top_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ClientTopLevel { get; set; } 

    [JsonProperty("client_top_level_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ClientTopLevelName { get; set; } 

    [JsonProperty("client_name_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ClientNameField { get; set; } 

    [JsonProperty("inventory_item_group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? InventoryItemGroup { get; set; } 

    [JsonProperty("inventory_item_group_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? InventoryItemGroupName { get; set; } 

    [JsonProperty("non_inventory_item_group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? NonInventoryItemGroup { get; set; } 

    [JsonProperty("non_inventory_item_group_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NonInventoryItemGroupName { get; set; } 

    [JsonProperty("service_item_group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ServiceItemGroup { get; set; } 

    [JsonProperty("service_item_group_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ServiceItemGroupName { get; set; } 

    [JsonProperty("enable_sync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? EnableSync { get; set; } 

    [JsonProperty("sync_entities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SyncEntities { get; set; } 

    [JsonProperty("sync_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ValueLabelIsNewKeyPair>? SyncEntitiesList { get; set; } 

    [JsonProperty("show_message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowMessage { get; set; } 

    [JsonProperty("deactivate_customers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DeactivateCustomers { get; set; } 

    [JsonProperty("default_invoice_item", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultInvoiceItem { get; set; } 

    [JsonProperty("default_order_item", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultOrderItem { get; set; } 

    [JsonProperty("default_invoice_item_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultInvoiceItemName { get; set; } 

    [JsonProperty("default_order_item_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultOrderItemName { get; set; } 

    [JsonProperty("invoice_email_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? InvoiceEmailStatus { get; set; } 

    [JsonProperty("supplier_top_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SupplierTopLevel { get; set; } 

    [JsonProperty("supplier_top_level_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SupplierTopLevelName { get; set; } 

    [JsonProperty("supplier_name_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SupplierNameField { get; set; } 

    [JsonProperty("invoice_custom_po", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ValueLabelIsNewKeyPair? InvoiceCustomPo { get; set; } 

    [JsonProperty("invoice_custom_po_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? InvoiceCustomPoId { get; set; } 

    [JsonProperty("invoice_custom_po_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? InvoiceCustomPoName { get; set; } 

    [JsonProperty("default_order_account_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultOrderAccountId { get; set; } 

    [JsonProperty("default_order_account_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultOrderAccountName { get; set; } 

    [JsonProperty("default_order_account", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ValueLabelIsNewKeyPair? DefaultOrderAccount { get; set; } 

    [JsonProperty("order_email_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OrderEmailStatus { get; set; } 

    [JsonProperty("multi_currency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? MultiCurrency { get; set; } 

    [JsonProperty("default_sales_account_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultSalesAccountId { get; set; } 

    [JsonProperty("default_sales_account_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultSalesAccountName { get; set; } 

    [JsonProperty("default_sales_account", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ValueLabelIsNewKeyPair? DefaultSalesAccount { get; set; } 

    [JsonProperty("default_expense_account_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultExpenseAccountId { get; set; } 

    [JsonProperty("default_expense_account_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultExpenseAccountName { get; set; } 

    [JsonProperty("default_expense_account", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ValueLabelIsNewKeyPair? DefaultExpenseAccount { get; set; } 

    [JsonProperty("default_asset_account_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultAssetAccountId { get; set; } 

    [JsonProperty("default_asset_account_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultAssetAccountName { get; set; } 

    [JsonProperty("default_asset_account", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ValueLabelIsNewKeyPair? DefaultAssetAccount { get; set; } 

    [JsonProperty("receive_client_created", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ReceiveClientCreated { get; set; } 

    [JsonProperty("receive_client_updated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ReceiveClientUpdated { get; set; } 

    [JsonProperty("receive_payment_created", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ReceivePaymentCreated { get; set; } 

    [JsonProperty("receive_payment_updated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ReceivePaymentUpdated { get; set; } 

    [JsonProperty("sync_halo_invoice_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? SyncHaloInvoiceId { get; set; } 

    [JsonProperty("sync_invoice_class", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? SyncInvoiceClass { get; set; } 

    [JsonProperty("sync_invoice_bill_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? SyncInvoiceBillAddress { get; set; } 

    [JsonProperty("sync_invoice_ship_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? SyncInvoiceShipAddress { get; set; } 

    [JsonProperty("use_qbo_invoice_terms", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? UseQboInvoiceTerms { get; set; } 

    [JsonProperty("round_payments_to_2dp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? RoundPaymentsTo2Dp { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("default_deferred_code_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultDeferredCodeId { get; set; } 

    [JsonProperty("default_deferred_code_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultDeferredCodeName { get; set; } 

    [JsonProperty("dont_post_item_quantities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DontPostItemQuantities { get; set; } 

    [JsonProperty("dont_sync_cost_tracking_lines", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DontSyncCostTrackingLines { get; set; } 

    [JsonProperty("remove_unapplied_payments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? RemoveUnappliedPayments { get; set; } 

    [JsonProperty("default_deferred_account", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ValueLabelIsNewKeyPair? DefaultDeferredAccount { get; set; } 

    [JsonProperty("qbo_sitemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ExternalLinkList>? QboSitemappings { get; set; } 

    [JsonProperty("mark_as_void", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? MarkAsVoid { get; set; } 

    [JsonProperty("minor_version", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MinorVersion { get; set; } 

}