using System.CodeDom.Compiler;
using Angelic.KeyPairs;
using Newtonsoft.Json;

namespace Angelic;

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
    public string? Company_id { get; set; } 

    [JsonProperty("company_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Company_name { get; set; } 

    [JsonProperty("new_access_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? New_access_token { get; set; } 

    [JsonProperty("new_refresh_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? New_refresh_token { get; set; } 

    [JsonProperty("token_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Token_expiry { get; set; } 

    [JsonProperty("authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Authorized { get; set; } 

    [JsonProperty("redirect_uri", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Redirect_uri { get; set; } 

    [JsonProperty("authorization_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Authorization_code { get; set; } 

    [JsonProperty("_exchangecode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _exchangecode { get; set; } 

    [JsonProperty("_disconnect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _disconnect { get; set; } 

    [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _importtype { get; set; } 

    [JsonProperty("new_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? New_method { get; set; } 

    [JsonProperty("automatic_sales_tax", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Automatic_sales_tax { get; set; } 

    [JsonProperty("online_payments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Online_payments { get; set; } 

    [JsonProperty("api_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Api_url { get; set; } 

    [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Client_id { get; set; } 

    [JsonProperty("new_client_secret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? New_client_secret { get; set; } 

    [JsonProperty("default_tax_code_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Default_tax_code_id { get; set; } 

    [JsonProperty("default_tax_code_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Default_tax_code_name { get; set; } 

    [JsonProperty("default_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ValueLabelIsNewKeyPair? Default_tax_code { get; set; } 

    [JsonProperty("zero_tax_rate_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Zero_tax_rate_id { get; set; } 

    [JsonProperty("zero_tax_rate_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Zero_tax_rate_name { get; set; } 

    [JsonProperty("zero_tax_rate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ValueLabelIsNewKeyPair? Zero_tax_rate { get; set; } 

    [JsonProperty("client_top_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Client_top_level { get; set; } 

    [JsonProperty("client_top_level_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Client_top_level_name { get; set; } 

    [JsonProperty("client_name_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Client_name_field { get; set; } 

    [JsonProperty("inventory_item_group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Inventory_item_group { get; set; } 

    [JsonProperty("inventory_item_group_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Inventory_item_group_name { get; set; } 

    [JsonProperty("non_inventory_item_group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Non_inventory_item_group { get; set; } 

    [JsonProperty("non_inventory_item_group_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Non_inventory_item_group_name { get; set; } 

    [JsonProperty("service_item_group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Service_item_group { get; set; } 

    [JsonProperty("service_item_group_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Service_item_group_name { get; set; } 

    [JsonProperty("enable_sync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Enable_sync { get; set; } 

    [JsonProperty("sync_entities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Sync_entities { get; set; } 

    [JsonProperty("sync_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ValueLabelIsNewKeyPair>? Sync_entities_list { get; set; } 

    [JsonProperty("show_message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Show_message { get; set; } 

    [JsonProperty("deactivate_customers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Deactivate_customers { get; set; } 

    [JsonProperty("default_invoice_item", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Default_invoice_item { get; set; } 

    [JsonProperty("default_order_item", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Default_order_item { get; set; } 

    [JsonProperty("default_invoice_item_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Default_invoice_item_name { get; set; } 

    [JsonProperty("default_order_item_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Default_order_item_name { get; set; } 

    [JsonProperty("invoice_email_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Invoice_email_status { get; set; } 

    [JsonProperty("supplier_top_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Supplier_top_level { get; set; } 

    [JsonProperty("supplier_top_level_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Supplier_top_level_name { get; set; } 

    [JsonProperty("supplier_name_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Supplier_name_field { get; set; } 

    [JsonProperty("invoice_custom_po", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ValueLabelIsNewKeyPair? Invoice_custom_po { get; set; } 

    [JsonProperty("invoice_custom_po_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Invoice_custom_po_id { get; set; } 

    [JsonProperty("invoice_custom_po_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Invoice_custom_po_name { get; set; } 

    [JsonProperty("default_order_account_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Default_order_account_id { get; set; } 

    [JsonProperty("default_order_account_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Default_order_account_name { get; set; } 

    [JsonProperty("default_order_account", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ValueLabelIsNewKeyPair? Default_order_account { get; set; } 

    [JsonProperty("order_email_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Order_email_status { get; set; } 

    [JsonProperty("multi_currency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Multi_currency { get; set; } 

    [JsonProperty("default_sales_account_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Default_sales_account_id { get; set; } 

    [JsonProperty("default_sales_account_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Default_sales_account_name { get; set; } 

    [JsonProperty("default_sales_account", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ValueLabelIsNewKeyPair? Default_sales_account { get; set; } 

    [JsonProperty("default_expense_account_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Default_expense_account_id { get; set; } 

    [JsonProperty("default_expense_account_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Default_expense_account_name { get; set; } 

    [JsonProperty("default_expense_account", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ValueLabelIsNewKeyPair? Default_expense_account { get; set; } 

    [JsonProperty("default_asset_account_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Default_asset_account_id { get; set; } 

    [JsonProperty("default_asset_account_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Default_asset_account_name { get; set; } 

    [JsonProperty("default_asset_account", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ValueLabelIsNewKeyPair? Default_asset_account { get; set; } 

    [JsonProperty("receive_client_created", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Receive_client_created { get; set; } 

    [JsonProperty("receive_client_updated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Receive_client_updated { get; set; } 

    [JsonProperty("receive_payment_created", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Receive_payment_created { get; set; } 

    [JsonProperty("receive_payment_updated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Receive_payment_updated { get; set; } 

    [JsonProperty("sync_halo_invoice_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Sync_halo_invoice_id { get; set; } 

    [JsonProperty("sync_invoice_class", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Sync_invoice_class { get; set; } 

    [JsonProperty("sync_invoice_bill_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Sync_invoice_bill_address { get; set; } 

    [JsonProperty("sync_invoice_ship_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Sync_invoice_ship_address { get; set; } 

    [JsonProperty("use_qbo_invoice_terms", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Use_qbo_invoice_terms { get; set; } 

    [JsonProperty("round_payments_to_2dp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Round_payments_to_2dp { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

    [JsonProperty("default_deferred_code_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Default_deferred_code_id { get; set; } 

    [JsonProperty("default_deferred_code_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Default_deferred_code_name { get; set; } 

    [JsonProperty("dont_post_item_quantities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Dont_post_item_quantities { get; set; } 

    [JsonProperty("dont_sync_cost_tracking_lines", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Dont_sync_cost_tracking_lines { get; set; } 

    [JsonProperty("remove_unapplied_payments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Remove_unapplied_payments { get; set; } 

    [JsonProperty("default_deferred_account", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ValueLabelIsNewKeyPair? Default_deferred_account { get; set; } 

    [JsonProperty("qbo_sitemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ExternalLink_List>? Qbo_sitemappings { get; set; } 

    [JsonProperty("mark_as_void", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Mark_as_void { get; set; } 

    [JsonProperty("minor_version", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Minor_version { get; set; } 

}