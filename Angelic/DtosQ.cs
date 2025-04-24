using System.CodeDom.Compiler;
using Angelic.Agent;
using Angelic.Dtos;
using Angelic.KeyPairs;
using Newtonsoft.Json;

namespace Angelic;

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class QBOWebhookEventEntity
    {
        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Id { get; set; } 

        [JsonProperty("operation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Operation { get; set; } 

        [JsonProperty("lastUpdated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? LastUpdated { get; set; } 

        [JsonProperty("realmId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? RealmId { get; set; } 

        [JsonProperty("resourceObject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public object? ResourceObject { get; set; } 

        [JsonProperty("eventTypeNum", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public RelayEventType? EventTypeNum { get; set; } 

        [JsonProperty("eventCategoryNum", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public RelayEventCategory? EventCategoryNum { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class Qualification
    {
        [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Guid { get; set; } 

        [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intent { get; set; } 

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("weight", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Weight { get; set; } 

        [JsonProperty("mustmatch", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Mustmatch { get; set; } 

        [JsonProperty("criteria", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<QualificationCategory>? Criteria { get; set; } 

        [JsonProperty("agents", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AgentQualification>? Agents { get; set; } 

        [JsonProperty("agent_matched", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Agent_matched { get; set; } 

        [JsonProperty("_domatch", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _domatch { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class QualificationCategory
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("qlid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Qlid { get; set; } 

        [JsonProperty("qualification_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Qualification_guid { get; set; } 

        [JsonProperty("fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AutoassignCriteria>? Fields { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class QualysHostAssetSoftwareHostAssetSoftware
    {
        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("version", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Version { get; set; } 

    }

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

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class QuotationApproval
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Token { get; set; } 

        [JsonProperty("result", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Result { get; set; } 

        [JsonProperty("approvalname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Approvalname { get; set; } 

        [JsonProperty("approvalemailaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Approvalemailaddress { get; set; } 

        [JsonProperty("approvalnote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Approvalnote { get; set; } 

        [JsonProperty("ponumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ponumber { get; set; } 

        [JsonProperty("signature", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Signature { get; set; } 

        [JsonProperty("optional_lines", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<QuotationDetail>? Optional_lines { get; set; } 

        [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CustomField>? Customfields { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class QuotationDetail
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("sort_seq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sort_seq { get; set; } 

        [JsonProperty("group_sort_seq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Group_sort_seq { get; set; } 

        [JsonProperty("productcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Productcode { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("costprice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Costprice { get; set; } 

        [JsonProperty("total_price_monthly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Total_price_monthly { get; set; } 

        [JsonProperty("total_price_monthly_converted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Total_price_monthly_converted { get; set; } 

        [JsonProperty("total_net_total_monthly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Total_net_total_monthly { get; set; } 

        [JsonProperty("total_costprice_monthly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Total_costprice_monthly { get; set; } 

        [JsonProperty("total_profit_monthly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Total_profit_monthly { get; set; } 

        [JsonProperty("total_tax_monthly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Total_tax_monthly { get; set; } 

        [JsonProperty("total_discount_monthly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Total_discount_monthly { get; set; } 

        [JsonProperty("total_price_annual", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Total_price_annual { get; set; } 

        [JsonProperty("total_price_annual_converted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Total_price_annual_converted { get; set; } 

        [JsonProperty("total_net_total_annual", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Total_net_total_annual { get; set; } 

        [JsonProperty("total_costprice_annual", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Total_costprice_annual { get; set; } 

        [JsonProperty("total_profit_annual", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Total_profit_annual { get; set; } 

        [JsonProperty("total_tax_annual", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Total_tax_annual { get; set; } 

        [JsonProperty("total_discount_annual", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Total_discount_annual { get; set; } 

        [JsonProperty("total_price_yearone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Total_price_yearone { get; set; } 

        [JsonProperty("total_price_yearone_converted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Total_price_yearone_converted { get; set; } 

        [JsonProperty("total_net_total_yearone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Total_net_total_yearone { get; set; } 

        [JsonProperty("total_costprice_yearone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Total_costprice_yearone { get; set; } 

        [JsonProperty("total_profit_yearone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Total_profit_yearone { get; set; } 

        [JsonProperty("total_tax_yearone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Total_tax_yearone { get; set; } 

        [JsonProperty("total_discount_yearone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Total_discount_yearone { get; set; } 

        [JsonProperty("qhid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Qhid { get; set; } 

        [JsonProperty("item_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Item_id { get; set; } 

        [JsonProperty("note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Note { get; set; } 

        [JsonProperty("note_hidden", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Note_hidden { get; set; } 

        [JsonProperty("servicefee", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Servicefee { get; set; } 

        [JsonProperty("recovery", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Recovery { get; set; } 

        [JsonProperty("margin", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Margin { get; set; } 

        [JsonProperty("billingperiod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Billingperiod { get; set; } 

        [JsonProperty("startdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Startdate { get; set; } 

        [JsonProperty("autorenew", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Autorenew { get; set; } 

        [JsonProperty("item_recurring", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Item_recurring { get; set; } 

        [JsonProperty("item_taxable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Item_taxable { get; set; } 

        [JsonProperty("group_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Group_id { get; set; } 

        [JsonProperty("printitem", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Printitem { get; set; } 

        [JsonProperty("isgroupdesc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isgroupdesc { get; set; } 

        [JsonProperty("discount_perc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Discount_perc { get; set; } 

        [JsonProperty("supplier_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Supplier_id { get; set; } 

        [JsonProperty("supplier_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Supplier_name { get; set; } 

        [JsonProperty("optional", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Optional { get; set; } 

        [JsonProperty("approval_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Approval_status { get; set; } 

        [JsonProperty("cost_centre", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Cost_centre { get; set; } 

        [JsonProperty("stock_location", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Stock_location { get; set; } 

        [JsonProperty("item_internal_reference", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Item_internal_reference { get; set; } 

        [JsonProperty("item_external_reference", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Item_external_reference { get; set; } 

        [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Description { get; set; } 

        [JsonProperty("item_tax_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Item_tax_name { get; set; } 

        [JsonProperty("quoteitemurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Quoteitemurl { get; set; } 

        [JsonProperty("addedtorecurring", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Addedtorecurring { get; set; } 

        [JsonProperty("addedtononrecurring", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Addedtononrecurring { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("assetgroup_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Assetgroup_id { get; set; } 

        [JsonProperty("maxitemdiscount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Maxitemdiscount { get; set; } 

        [JsonProperty("line_site_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Line_site_id { get; set; } 

        [JsonProperty("site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Site_name { get; set; } 

        [JsonProperty("line_periods", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Line_periods { get; set; } 

        [JsonProperty("hideitems", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hideitems { get; set; } 

        [JsonProperty("ignoretaxcalc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ignoretaxcalc { get; set; } 

        [JsonProperty("current_quantity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Current_quantity { get; set; } 

        [JsonProperty("current_price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Current_price { get; set; } 

        [JsonProperty("current_net_price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Current_net_price { get; set; } 

        [JsonProperty("isleased", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isleased { get; set; } 

        [JsonProperty("stockbin_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Stockbin_id { get; set; } 

        [JsonProperty("quoter_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Quoter_id { get; set; } 

        [JsonProperty("is_bundled_line", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_bundled_line { get; set; } 

        [JsonProperty("optional_line_quantity_change", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Optional_line_quantity_change { get; set; } 

        [JsonProperty("created_from_group_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Created_from_group_id { get; set; } 

        [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CustomField>? Customfields { get; set; } 

        [JsonProperty("chargerates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Lookup>? Chargerates { get; set; } 

        [JsonProperty("budgets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<FaultBudget>? Budgets { get; set; } 

        [JsonProperty("item_template", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Item_template { get; set; } 

        [JsonProperty("item_contract", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Item_contract { get; set; } 

        [JsonProperty("hide_grouped_items_price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hide_grouped_items_price { get; set; } 

        [JsonProperty("nominal_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Nominal_code { get; set; } 

        [JsonProperty("one_optional_mandatory", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<StringIdNameKeyPair>? One_optional_mandatory { get; set; } 

        [JsonProperty("one_optional_mandatory_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? One_optional_mandatory_list { get; set; } 

        [JsonProperty("force_quantity_relationship", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Force_quantity_relationship { get; set; } 

        [JsonProperty("force_price_relationship", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Force_price_relationship { get; set; } 

        [JsonProperty("force_term_relationship", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Force_term_relationship { get; set; } 

        [JsonProperty("price_calculation_formula", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Price_calculation_formula { get; set; } 

        [JsonProperty("purchase_currency_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Purchase_currency_code { get; set; } 

        [JsonProperty("cost_converted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Cost_converted { get; set; } 

        [JsonProperty("purchase_currency_code_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Purchase_currency_code_name { get; set; } 

        [JsonProperty("purchase_currency_symbol", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Purchase_currency_symbol { get; set; } 

        [JsonProperty("purchase_conversion_rate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Purchase_conversion_rate { get; set; } 

        [JsonProperty("stocklocation_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Stocklocation_id { get; set; } 

        [JsonProperty("exclude_auto_increase", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Exclude_auto_increase { get; set; } 

        [JsonProperty("auto_increase_period", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Auto_increase_period { get; set; } 

        [JsonProperty("percent_increase", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Percent_increase { get; set; } 

        [JsonProperty("use_rpi_increase", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Use_rpi_increase { get; set; } 

        [JsonProperty("net_total", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Net_total { get; set; } 

        [JsonProperty("total_tax_converted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Total_tax_converted { get; set; } 

        [JsonProperty("tax_converted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Tax_converted { get; set; } 

        [JsonProperty("new_external_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ExternalLink_List? New_external_link { get; set; } 

        [JsonProperty("external_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ExternalLink_List? External_link { get; set; } 

        [JsonProperty("ingram_quote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ingram_quote { get; set; } 

        [JsonProperty("hubspot_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Hubspot_id { get; set; } 

        [JsonProperty("item_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Item_tax_code { get; set; } 

        [JsonProperty("baseprice_converted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Baseprice_converted { get; set; } 

        [JsonProperty("unitprice_converted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Unitprice_converted { get; set; } 

        [JsonProperty("override_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Override_tax_code { get; set; } 

        [JsonProperty("baseprice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Baseprice { get; set; } 

        [JsonProperty("total_tax", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Total_tax { get; set; } 

        [JsonProperty("total_price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Total_price { get; set; } 

        [JsonProperty("total_discount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Total_discount { get; set; } 

        [JsonProperty("conversion_rate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Conversion_rate { get; set; } 

        [JsonProperty("discount_converted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Discount_converted { get; set; } 

        [JsonProperty("net_amount_converted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Net_amount_converted { get; set; } 

        [JsonProperty("total_price_converted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Total_price_converted { get; set; } 

        [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _importtype { get; set; } 

        [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _isimport { get; set; } 

        [JsonProperty("tax_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Tax_name { get; set; } 

        [JsonProperty("taxRuleResult", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<TaxRuleResult>? TaxRuleResult { get; set; } 

        [JsonProperty("decimalplacesforinvoices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Decimalplacesforinvoices { get; set; } 

        [JsonProperty("total_net_total", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Total_net_total { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class QuotationHeader
    {
        [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CustomField>? Customfields { get; set; } 

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Use { get; set; } 

        [JsonProperty("table", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public TableEnum? Table { get; set; } 

        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Title { get; set; } 

        [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ticket_id { get; set; } 

        [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; } 

        [JsonProperty("po_ref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Po_ref { get; set; } 

        [JsonProperty("date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Date { get; set; } 

        [JsonProperty("expiry_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Expiry_date { get; set; } 

        [JsonProperty("revenue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Revenue { get; set; } 

        [JsonProperty("tax_total", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Tax_total { get; set; } 

        [JsonProperty("total", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Total { get; set; } 

        [JsonProperty("carriage_desc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Carriage_desc { get; set; } 

        [JsonProperty("carriage_price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Carriage_price { get; set; } 

        [JsonProperty("tax_total_estimate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Tax_total_estimate { get; set; } 

        [JsonProperty("auth_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Auth_by { get; set; } 

        [JsonProperty("note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Note { get; set; } 

        [JsonProperty("user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Users? User { get; set; } 

        [JsonProperty("user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? User_id { get; set; } 

        [JsonProperty("user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? User_name { get; set; } 

        [JsonProperty("site_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Site_id { get; set; } 

        [JsonProperty("site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Site_name { get; set; } 

        [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Client_id { get; set; } 

        [JsonProperty("client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Client_name { get; set; } 

        [JsonProperty("scope", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Scope { get; set; } 

        [JsonProperty("risk", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Risk { get; set; } 

        [JsonProperty("qr2filename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Qr2filename { get; set; } 

        [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Agent_id { get; set; } 

        [JsonProperty("assigned_agent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Assigned_agent { get; set; } 

        [JsonProperty("assigned_agent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Assigned_agent_name { get; set; } 

        [JsonProperty("includegroupeditemprice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Includegroupeditemprice { get; set; } 

        [JsonProperty("includegroupeditemqty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Includegroupeditemqty { get; set; } 

        [JsonProperty("daystodeliver", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Daystodeliver { get; set; } 

        [JsonProperty("currency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Currency { get; set; } 

        [JsonProperty("currency_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Currency_code { get; set; } 

        [JsonProperty("currency_code_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Currency_code_name { get; set; } 

        [JsonProperty("currency_conversion_rate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Currency_conversion_rate { get; set; } 

        [JsonProperty("includequotationlinenotes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Includequotationlinenotes { get; set; } 

        [JsonProperty("includegrouppriceandqty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Includegrouppriceandqty { get; set; } 

        [JsonProperty("approvalname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Approvalname { get; set; } 

        [JsonProperty("approvalemailaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Approvalemailaddress { get; set; } 

        [JsonProperty("approvaldatetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Approvaldatetime { get; set; } 

        [JsonProperty("approvalnote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Approvalnote { get; set; } 

        [JsonProperty("approvalstate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Approvalstate { get; set; } 

        [JsonProperty("lines", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<QuotationDetail>? Lines { get; set; } 

        [JsonProperty("_validateonly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _validateonly { get; set; } 

        [JsonProperty("_print_preview", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _print_preview { get; set; } 

        [JsonProperty("_print_generate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _print_generate { get; set; } 

        [JsonProperty("printhtml", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Printhtml { get; set; } 

        [JsonProperty("pdf_attachment_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Pdf_attachment_id { get; set; } 

        [JsonProperty("ponumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ponumber { get; set; } 

        [JsonProperty("pdftemplate_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Pdftemplate_id { get; set; } 

        [JsonProperty("pdftemplate_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Pdftemplate_name { get; set; } 

        [JsonProperty("portal_display_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Portal_display_type { get; set; } 

        [JsonProperty("_create_so", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _create_so { get; set; } 

        [JsonProperty("salesorder_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Salesorder_id { get; set; } 

        [JsonProperty("salesorder", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public OrderHead? Salesorder { get; set; } 

        [JsonProperty("signature", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Signature { get; set; } 

        [JsonProperty("createdbyagentname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Createdbyagentname { get; set; } 

        [JsonProperty("quote_viewed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Quote_viewed { get; set; } 

        [JsonProperty("canned_text_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Canned_text_id { get; set; } 

        [JsonProperty("canned_text_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Canned_text_name { get; set; } 

        [JsonProperty("canned_text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Canned_text { get; set; } 

        [JsonProperty("last_update_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Last_update_time { get; set; } 

        [JsonProperty("images", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AttachmentList>? Images { get; set; } 

        [JsonProperty("internal_approval_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Internal_approval_status { get; set; } 

        [JsonProperty("approval_start", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Approval_start { get; set; } 

        [JsonProperty("internal_approvalagent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Internal_approvalagent { get; set; } 

        [JsonProperty("internal_approvalemailaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Internal_approvalemailaddress { get; set; } 

        [JsonProperty("internal_approvalnote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Internal_approvalnote { get; set; } 

        [JsonProperty("internal_approvalagentid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Internal_approvalagentid { get; set; } 

        [JsonProperty("internal_approvaldatetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Internal_approvaldatetime { get; set; } 

        [JsonProperty("requires_approval", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Requires_approval { get; set; } 

        [JsonProperty("ticket_summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ticket_summary { get; set; } 

        [JsonProperty("ticket_note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ticket_note { get; set; } 

        [JsonProperty("new_ticket_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? New_ticket_status { get; set; } 

        [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _isimport { get; set; } 

        [JsonProperty("datto_commerce_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Datto_commerce_id { get; set; } 

        [JsonProperty("datto_commerce_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Datto_commerce_url { get; set; } 

        [JsonProperty("third_party_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Third_party_url { get; set; } 

        [JsonProperty("dattocommerce_clientid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Dattocommerce_clientid { get; set; } 

        [JsonProperty("dattocommerce_contactname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Dattocommerce_contactname { get; set; } 

        [JsonProperty("dattocommerce_contactemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Dattocommerce_contactemail { get; set; } 

        [JsonProperty("deliveryamount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Deliveryamount { get; set; } 

        [JsonProperty("dattocommerce_tenantid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Dattocommerce_tenantid { get; set; } 

        [JsonProperty("deliverytax", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Deliverytax { get; set; } 

        [JsonProperty("dontupdateporef", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dontupdateporef { get; set; } 

        [JsonProperty("can_approve", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Can_approve { get; set; } 

        [JsonProperty("linked_pdf_list_append", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<QuotationHeaderPdf>? Linked_pdf_list_append { get; set; } 

        [JsonProperty("linked_pdf_list_prepend", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<QuotationHeaderPdf>? Linked_pdf_list_prepend { get; set; } 

        [JsonProperty("automatic_sales_tax", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Automatic_sales_tax { get; set; } 

        [JsonProperty("contactuser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Contactuser { get; set; } 

        [JsonProperty("contactusername", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Contactusername { get; set; } 

        [JsonProperty("_match_thirdparty_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _match_thirdparty_id { get; set; } 

        [JsonProperty("_match_integration_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? _match_integration_id { get; set; } 

        [JsonProperty("_match_integration_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _match_integration_name { get; set; } 

        [JsonProperty("third_party_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Third_party_number { get; set; } 

        [JsonProperty("intacct_class", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intacct_class { get; set; } 

        [JsonProperty("intacct_class_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intacct_class_name { get; set; } 

        [JsonProperty("intacct_save_location", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intacct_save_location { get; set; } 

        [JsonProperty("is_leased", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_leased { get; set; } 

        [JsonProperty("term_limit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Term_limit { get; set; } 

        [JsonProperty("margin", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Margin { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("billingcontactname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Billingcontactname { get; set; } 

        [JsonProperty("billingcontactemailaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Billingcontactemailaddress { get; set; } 

        [JsonProperty("billingcontactphonenumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Billingcontactphonenumber { get; set; } 

        [JsonProperty("so_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? So_number { get; set; } 

        [JsonProperty("use_ticket_approval", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Use_ticket_approval { get; set; } 

        [JsonProperty("approval_process_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Approval_process_id { get; set; } 

        [JsonProperty("new_approvalprocess_agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? New_approvalprocess_agent_id { get; set; } 

        [JsonProperty("new_approvalprocess_user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? New_approvalprocess_user_id { get; set; } 

        [JsonProperty("new_approvalprocess_users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<UsersList>? New_approvalprocess_users { get; set; } 

        [JsonProperty("new_approvalprocess_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_approvalprocess_email { get; set; } 

        [JsonProperty("new_approvalprocess_cab_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? New_approvalprocess_cab_id { get; set; } 

        [JsonProperty("new_approvalprocess_cab", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CabMember>? New_approvalprocess_cab { get; set; } 

        [JsonProperty("site_delivery_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Site_delivery_override { get; set; } 

        [JsonProperty("address1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Address1 { get; set; } 

        [JsonProperty("address2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Address2 { get; set; } 

        [JsonProperty("address3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Address3 { get; set; } 

        [JsonProperty("address4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Address4 { get; set; } 

        [JsonProperty("address5", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Address5 { get; set; } 

        [JsonProperty("deladdress1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Deladdress1 { get; set; } 

        [JsonProperty("deladdress2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Deladdress2 { get; set; } 

        [JsonProperty("deladdress3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Deladdress3 { get; set; } 

        [JsonProperty("deladdress4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Deladdress4 { get; set; } 

        [JsonProperty("deladdress5", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Deladdress5 { get; set; } 

        [JsonProperty("address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AddressStore? Address { get; set; } 

        [JsonProperty("delivery_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AddressStore? Delivery_address { get; set; } 

        [JsonProperty("workflow_history", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<WorkflowHistory>? Workflow_history { get; set; } 

        [JsonProperty("workflow_step", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Workflow_step { get; set; } 

        [JsonProperty("workflow_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Workflow_id { get; set; } 

        [JsonProperty("_isclone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _isclone { get; set; } 

        [JsonProperty("_revision_from_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? _revision_from_id { get; set; } 

        [JsonProperty("_originalid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? _originalid { get; set; } 

        [JsonProperty("_customisepdf", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _customisepdf { get; set; } 

        [JsonProperty("is_customised_pdf", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_customised_pdf { get; set; } 

        [JsonProperty("customisedpdf", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public PdfTemplate? Customisedpdf { get; set; } 

        [JsonProperty("new_approvalprocess_role_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? New_approvalprocess_role_id { get; set; } 

        [JsonProperty("is_quote_screen", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_quote_screen { get; set; } 

        [JsonProperty("_novalidate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _novalidate { get; set; } 

        [JsonProperty("avalara_details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Avalara_details_id { get; set; } 

        [JsonProperty("adobe_details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Adobe_details_id { get; set; } 

        [JsonProperty("avalara_details_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Avalara_details_name { get; set; } 

        [JsonProperty("_startthirdpartysign", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _startthirdpartysign { get; set; } 

        [JsonProperty("_hasadobesignopen", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _hasadobesignopen { get; set; } 

        [JsonProperty("user_approval_unavailable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? User_approval_unavailable { get; set; } 

        [JsonProperty("top_level_purchase_currency_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Top_level_purchase_currency_code { get; set; } 

        [JsonProperty("tree_purchase_currency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Currency? Tree_purchase_currency { get; set; } 

        [JsonProperty("_updatepurchasecurrency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _updatepurchasecurrency { get; set; } 

        [JsonProperty("_remove_zero_quantity_lines", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _remove_zero_quantity_lines { get; set; } 

        [JsonProperty("site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Site? Site { get; set; } 

        [JsonProperty("originaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AddressStore? Originaddress { get; set; } 

        [JsonProperty("originaddress1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Originaddress1 { get; set; } 

        [JsonProperty("originaddress2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Originaddress2 { get; set; } 

        [JsonProperty("originaddress3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Originaddress3 { get; set; } 

        [JsonProperty("originaddress4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Originaddress4 { get; set; } 

        [JsonProperty("originaddress5", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Originaddress5 { get; set; } 

        [JsonProperty("original_revised_from_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Original_revised_from_id { get; set; } 

        [JsonProperty("quoteapprovalfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<RequestTypeField>? Quoteapprovalfields { get; set; } 

        [JsonProperty("custombuttons", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CustomButton>? Custombuttons { get; set; } 

        [JsonProperty("extratabs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Tabname>? Extratabs { get; set; } 

        [JsonProperty("status_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Status_name { get; set; } 

        [JsonProperty("_dotaxsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _dotaxsync { get; set; } 

        [JsonProperty("external_links", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLink_List>? External_links { get; set; } 

        [JsonProperty("_importtypeid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? _importtypeid { get; set; } 

        [JsonProperty("_importthirdpartyid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _importthirdpartyid { get; set; } 

        [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _importtype { get; set; } 

        [JsonProperty("new_external_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ExternalLink_List? New_external_link { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class QuotationHeaderPdf
    {
        [JsonProperty("desc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Desc { get; set; } 

        [JsonProperty("uniqueid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Uniqueid { get; set; } 

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("quotationheaderid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Quotationheaderid { get; set; } 

        [JsonProperty("prepend", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Prepend { get; set; } 

    }