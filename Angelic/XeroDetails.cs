using System.CodeDom.Compiler;
using Angelic.KeyPairs;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class XeroDetails
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("tenant_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Tenant_id { get; set; } 

    [JsonProperty("tenant_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Tenant_name { get; set; } 

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

    [JsonProperty("code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Code { get; set; } 

    [JsonProperty("_exchangecode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _exchangecode { get; set; } 

    [JsonProperty("_disconnect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _disconnect { get; set; } 

    [JsonProperty("client_top_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Client_top_level { get; set; } 

    [JsonProperty("client_top_level_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Client_top_level_name { get; set; } 

    [JsonProperty("item_group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Item_group { get; set; } 

    [JsonProperty("item_group_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Item_group_name { get; set; } 

    [JsonProperty("isdefault", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Isdefault { get; set; } 

    [JsonProperty("enablesync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Enablesync { get; set; } 

    [JsonProperty("default_item_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Default_item_code { get; set; } 

    [JsonProperty("show_message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Show_message { get; set; } 

    [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _importtype { get; set; } 

    [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Client_id { get; set; } 

    [JsonProperty("new_client_secret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? New_client_secret { get; set; } 

    [JsonProperty("sync_entities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Sync_entities { get; set; } 

    [JsonProperty("sync_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ValueLabelIsNewKeyPair>? Sync_entities_list { get; set; } 

    [JsonProperty("supplier_top_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Supplier_top_level { get; set; } 

    [JsonProperty("supplier_top_level_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Supplier_top_level_name { get; set; } 

    [JsonProperty("archive_contacts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Archive_contacts { get; set; } 

    [JsonProperty("default_order_item_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Default_order_item_code { get; set; } 

    [JsonProperty("rounding_adjustment_account_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Rounding_adjustment_account_code { get; set; } 

    [JsonProperty("group_rounding_adjustments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Group_rounding_adjustments { get; set; } 

    [JsonProperty("new_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? New_method { get; set; } 

    [JsonProperty("receive_client_created", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Receive_client_created { get; set; } 

    [JsonProperty("receive_client_updated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Receive_client_updated { get; set; } 

    [JsonProperty("receive_invoice_created", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Receive_invoice_created { get; set; } 

    [JsonProperty("receive_invoice_updated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Receive_invoice_updated { get; set; } 

    [JsonProperty("default_creditnote_item_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Default_creditnote_item_code { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

    [JsonProperty("sync_currency_for_invoices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Sync_currency_for_invoices { get; set; } 

    [JsonProperty("no_item_group_sync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? No_item_group_sync { get; set; } 

    [JsonProperty("invoice_description_data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Invoice_description_data { get; set; } 

    [JsonProperty("dont_sync_cost_tracking_lines", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Dont_sync_cost_tracking_lines { get; set; } 

    [JsonProperty("organisation_version", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Organisation_version { get; set; } 

    [JsonProperty("no_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? No_tax_code { get; set; } 

    [JsonProperty("category_1_keypair", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ValueLabelIsNewKeyPair? Category_1_keypair { get; set; } 

    [JsonProperty("category_2_keypair", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ValueLabelIsNewKeyPair? Category_2_keypair { get; set; } 

    [JsonProperty("category_1_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Category_1_name { get; set; } 

    [JsonProperty("category_1_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Category_1_id { get; set; } 

    [JsonProperty("category_2_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Category_2_name { get; set; } 

    [JsonProperty("category_2_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Category_2_id { get; set; } 

}