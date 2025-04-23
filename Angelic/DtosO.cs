using System.CodeDom.Compiler;
using Angelic.Dtos;
using Angelic.KeyPairs;
using Newtonsoft.Json;

namespace Angelic;


    public class OktaMapping
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("siteid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Siteid { get; set; } 

        [JsonProperty("site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Site_name { get; set; } 

        [JsonProperty("included_statuses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Included_statuses { get; set; } 

        [JsonProperty("included_statuses_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? Included_statuses_list { get; set; } 

        [JsonProperty("included_statuses_display", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Included_statuses_display { get; set; } 

        [JsonProperty("group_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Group_name { get; set; } 

        [JsonProperty("roleid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Roleid { get; set; } 

        [JsonProperty("applicationid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Applicationid { get; set; } 

        [JsonProperty("applicationid_display", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Applicationid_display { get; set; } 

        [JsonProperty("filterbyapp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Filterbyapp { get; set; } 

        [JsonProperty("userroleid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Userroleid { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("new_users_only", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? New_users_only { get; set; } 

        [JsonProperty("filters", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFilter>? Filters { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class OnlineStatus
    {
        [JsonProperty("techID", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TechID { get; set; } 

        [JsonProperty("lastOnlineDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? LastOnlineDate { get; set; } 

        [JsonProperty("isOnline", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsOnline { get; set; } 

        [JsonProperty("lastOnline", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? LastOnline { get; set; } 

        [JsonProperty("agent_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Agent_status { get; set; } 

        [JsonProperty("status_overidden", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Status_overidden { get; set; } 

        [JsonProperty("fetch_all", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Fetch_all { get; set; } 

        [JsonProperty("is_logout", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_logout { get; set; } 

        [JsonProperty("command", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Command { get; set; } 

        [JsonProperty("last_active", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Last_active { get; set; } 

        [JsonProperty("is_idle", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_idle { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class OpenIddictApplication
    {
        [JsonProperty("authorizations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<OpenIddictAuthorization>? Authorizations { get; set; } 

        [JsonProperty("clientId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ClientId { get; set; } 

        [JsonProperty("clientSecret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ClientSecret { get; set; } 

        [JsonProperty("concurrencyToken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ConcurrencyToken { get; set; } 

        [JsonProperty("consentType", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ConsentType { get; set; } 

        [JsonProperty("displayName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DisplayName { get; set; } 

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Id { get; set; } 

        [JsonProperty("permissions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Permissions { get; set; } 

        [JsonProperty("postLogoutRedirectUris", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PostLogoutRedirectUris { get; set; } 

        [JsonProperty("properties", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Properties { get; set; } 

        [JsonProperty("redirectUris", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? RedirectUris { get; set; } 

        [JsonProperty("tokens", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<OpenIddictToken>? Tokens { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Type { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class OpenIddictAuthorization
    {
        [JsonProperty("application", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public OpenIddictApplication? Application { get; set; } 

        [JsonProperty("concurrencyToken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ConcurrencyToken { get; set; } 

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Id { get; set; } 

        [JsonProperty("properties", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Properties { get; set; } 

        [JsonProperty("scopes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Scopes { get; set; } 

        [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Status { get; set; } 

        [JsonProperty("subject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Subject { get; set; } 

        [JsonProperty("tokens", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<OpenIddictToken>? Tokens { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Type { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class OpenIddictToken
    {
        [JsonProperty("application", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public OpenIddictApplication? Application { get; set; } 

        [JsonProperty("authorization", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public OpenIddictAuthorization? Authorization { get; set; } 

        [JsonProperty("concurrencyToken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ConcurrencyToken { get; set; } 

        [JsonProperty("creationDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? CreationDate { get; set; } 

        [JsonProperty("expirationDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? ExpirationDate { get; set; } 

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Id { get; set; } 

        [JsonProperty("payload", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Payload { get; set; } 

        [JsonProperty("properties", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Properties { get; set; } 

        [JsonProperty("referenceId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ReferenceId { get; set; } 

        [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Status { get; set; } 

        [JsonProperty("subject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Subject { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Type { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class OrderHead
    {
        [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CustomField>? Customfields { get; set; } 

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Use { get; set; } 

        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Title { get; set; } 

        [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ticket_id { get; set; } 

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

        [JsonProperty("client_to_invoice_to_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Client_to_invoice_to_id { get; set; } 

        [JsonProperty("assigned_agent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Assigned_agent { get; set; } 

        [JsonProperty("assigned_agent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Assigned_agent_name { get; set; } 

        [JsonProperty("open_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Open_status { get; set; } 

        [JsonProperty("date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Date { get; set; } 

        [JsonProperty("ship_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Ship_date { get; set; } 

        [JsonProperty("total", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Total { get; set; } 

        [JsonProperty("cost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Cost { get; set; } 

        [JsonProperty("profit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Profit { get; set; } 

        [JsonProperty("note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Note { get; set; } 

        [JsonProperty("po_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Po_number { get; set; } 

        [JsonProperty("createdby_agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Createdby_agent_id { get; set; } 

        [JsonProperty("deliverby", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Deliverby { get; set; } 

        [JsonProperty("summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Summary { get; set; } 

        [JsonProperty("datereceived", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Datereceived { get; set; } 

        [JsonProperty("numberbottles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Numberbottles { get; set; } 

        [JsonProperty("ship_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ship_status { get; set; } 

        [JsonProperty("soldby", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Soldby { get; set; } 

        [JsonProperty("accountsref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Accountsref { get; set; } 

        [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; } 

        [JsonProperty("leadsource", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Leadsource { get; set; } 

        [JsonProperty("canvasser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Canvasser { get; set; } 

        [JsonProperty("invoice_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Invoice_date { get; set; } 

        [JsonProperty("invoicenumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Invoicenumber { get; set; } 

        [JsonProperty("includegroupeditemprice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Includegroupeditemprice { get; set; } 

        [JsonProperty("includegroupeditemqty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Includegroupeditemqty { get; set; } 

        [JsonProperty("currency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Currency { get; set; } 

        [JsonProperty("currency_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Currency_code { get; set; } 

        [JsonProperty("currency_code_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Currency_code_name { get; set; } 

        [JsonProperty("currency_conversion_rate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Currency_conversion_rate { get; set; } 

        [JsonProperty("quotation_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Quotation_id { get; set; } 

        [JsonProperty("consignment_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Consignment_id { get; set; } 

        [JsonProperty("do_not_invoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Do_not_invoice { get; set; } 

        [JsonProperty("closeandconsignwhenpoprocessed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Closeandconsignwhenpoprocessed { get; set; } 

        [JsonProperty("lines", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<OrderLine>? Lines { get; set; } 

        [JsonProperty("add_lines", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<OrderLine>? Add_lines { get; set; } 

        [JsonProperty("_cancel_reserve", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _cancel_reserve { get; set; } 

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

        [JsonProperty("pdftemplate_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Pdftemplate_id { get; set; } 

        [JsonProperty("pdftemplate_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Pdftemplate_name { get; set; } 

        [JsonProperty("purchaseorder_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Purchaseorder_count { get; set; } 

        [JsonProperty("invoice_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Invoice_count { get; set; } 

        [JsonProperty("percentage_invoiced", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Percentage_invoiced { get; set; } 

        [JsonProperty("outstanding_total", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Outstanding_total { get; set; } 

        [JsonProperty("_create_po", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _create_po { get; set; } 

        [JsonProperty("_create_invoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _create_invoice { get; set; } 

        [JsonProperty("_create_invoice_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? _create_invoice_method { get; set; } 

        [JsonProperty("_create_invoice_percentage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? _create_invoice_percentage { get; set; } 

        [JsonProperty("_create_invoice_amount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? _create_invoice_amount { get; set; } 

        [JsonProperty("_create_invoice_qty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? _create_invoice_qty { get; set; } 

        [JsonProperty("_create_invoice_lines", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<OrderLine>? _create_invoice_lines { get; set; } 

        [JsonProperty("_create_invoice_line_description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _create_invoice_line_description { get; set; } 

        [JsonProperty("_create_invoice_invoice_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? _create_invoice_invoice_date { get; set; } 

        [JsonProperty("_return_invoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _return_invoice { get; set; } 

        [JsonProperty("createdbyagentname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Createdbyagentname { get; set; } 

        [JsonProperty("last_update_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Last_update_time { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("_distributorMessage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _distributorMessage { get; set; } 

        [JsonProperty("project_faultid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Project_faultid { get; set; } 

        [JsonProperty("order_project_template_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Order_project_template_id { get; set; } 

        [JsonProperty("order_project_template_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Order_project_template_name { get; set; } 

        [JsonProperty("_iscopy", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _iscopy { get; set; } 

        [JsonProperty("includegrouppriceandqty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Includegrouppriceandqty { get; set; } 

        [JsonProperty("costperweight", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Costperweight { get; set; } 

        [JsonProperty("showpercentageinvoiced", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showpercentageinvoiced { get; set; } 

        [JsonProperty("linked_to_opportunity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Linked_to_opportunity { get; set; } 

        [JsonProperty("linked_to_ticket", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Linked_to_ticket { get; set; } 

        [JsonProperty("linked_to_project", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Linked_to_project { get; set; } 

        [JsonProperty("intacct_class", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intacct_class { get; set; } 

        [JsonProperty("intacct_class_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intacct_class_name { get; set; } 

        [JsonProperty("intacct_save_location", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intacct_save_location { get; set; } 

        [JsonProperty("override_delivery_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Override_delivery_address { get; set; } 

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

        [JsonProperty("delivery_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AddressStore? Delivery_address { get; set; } 

        [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _isimport { get; set; } 

        [JsonProperty("_match_thirdparty_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _match_thirdparty_id { get; set; } 

        [JsonProperty("_match_integration_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? _match_integration_id { get; set; } 

        [JsonProperty("_match_integration_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _match_integration_name { get; set; } 

        [JsonProperty("dattocommerce_clientid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Dattocommerce_clientid { get; set; } 

        [JsonProperty("dattocommerce_contactname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Dattocommerce_contactname { get; set; } 

        [JsonProperty("dattocommerce_contactemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Dattocommerce_contactemail { get; set; } 

        [JsonProperty("deliveryamount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Deliveryamount { get; set; } 

        [JsonProperty("deliverytax", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Deliverytax { get; set; } 

        [JsonProperty("is_so_screen", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_so_screen { get; set; } 

        [JsonProperty("_novalidate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _novalidate { get; set; } 

        [JsonProperty("avalara_details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Avalara_details_id { get; set; } 

        [JsonProperty("avalara_details_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Avalara_details_name { get; set; } 

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

        [JsonProperty("custombuttons", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CustomButton>? Custombuttons { get; set; } 

        [JsonProperty("extratabs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Tabname>? Extratabs { get; set; } 

        [JsonProperty("_dotaxsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _dotaxsync { get; set; } 

        [JsonProperty("tax_total", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Tax_total { get; set; } 

        [JsonProperty("revenue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Revenue { get; set; } 

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
    public class OrderLine
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("salesorder_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Salesorder_id { get; set; } 

        [JsonProperty("sort_seq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sort_seq { get; set; } 

        [JsonProperty("group_sort_seq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Group_sort_seq { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("productcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Productcode { get; set; } 

        [JsonProperty("item_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Item_id { get; set; } 

        [JsonProperty("assetgroup_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Assetgroup_name { get; set; } 

        [JsonProperty("assettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Assettype_id { get; set; } 

        [JsonProperty("costprice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Costprice { get; set; } 

        [JsonProperty("profit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Profit { get; set; } 

        [JsonProperty("profit_percentage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Profit_percentage { get; set; } 

        [JsonProperty("quantity_shipped", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Quantity_shipped { get; set; } 

        [JsonProperty("quantity_reserved", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Quantity_reserved { get; set; } 

        [JsonProperty("invoiced_quantity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Invoiced_quantity { get; set; } 

        [JsonProperty("quantity_on_open_po", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Quantity_on_open_po { get; set; } 

        [JsonProperty("total_costprice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Total_costprice { get; set; } 

        [JsonProperty("total_profit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Total_profit { get; set; } 

        [JsonProperty("total_price_monthly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Total_price_monthly { get; set; } 

        [JsonProperty("total_net_total_monthly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Total_net_total_monthly { get; set; } 

        [JsonProperty("total_costprice_monthly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Total_costprice_monthly { get; set; } 

        [JsonProperty("total_profit_monthly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Total_profit_monthly { get; set; } 

        [JsonProperty("total_tax_monthly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Total_tax_monthly { get; set; } 

        [JsonProperty("total_price_annual", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Total_price_annual { get; set; } 

        [JsonProperty("total_net_total_annual", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Total_net_total_annual { get; set; } 

        [JsonProperty("total_costprice_annual", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Total_costprice_annual { get; set; } 

        [JsonProperty("total_profit_annual", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Total_profit_annual { get; set; } 

        [JsonProperty("total_tax_annual", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Total_tax_annual { get; set; } 

        [JsonProperty("total_price_yearone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Total_price_yearone { get; set; } 

        [JsonProperty("total_net_total_yearone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Total_net_total_yearone { get; set; } 

        [JsonProperty("total_costprice_yearone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Total_costprice_yearone { get; set; } 

        [JsonProperty("total_profit_yearone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Total_profit_yearone { get; set; } 

        [JsonProperty("total_tax_yearone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Total_tax_yearone { get; set; } 

        [JsonProperty("unit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Unit { get; set; } 

        [JsonProperty("note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Note { get; set; } 

        [JsonProperty("stocklocation_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Stocklocation_id { get; set; } 

        [JsonProperty("stocklocation_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Stocklocation_name { get; set; } 

        [JsonProperty("quantity_in_stock", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Quantity_in_stock { get; set; } 

        [JsonProperty("total_quantity_in_stock", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Total_quantity_in_stock { get; set; } 

        [JsonProperty("total_quantity_reserved", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Total_quantity_reserved { get; set; } 

        [JsonProperty("selected", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Selected { get; set; } 

        [JsonProperty("servicefee", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Servicefee { get; set; } 

        [JsonProperty("recovery", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Recovery { get; set; } 

        [JsonProperty("margin", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Margin { get; set; } 

        [JsonProperty("poqty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Poqty { get; set; } 

        [JsonProperty("billingperiod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Billingperiod { get; set; } 

        [JsonProperty("startdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Startdate { get; set; } 

        [JsonProperty("autorenew", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Autorenew { get; set; } 

        [JsonProperty("recurringinvoice_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Recurringinvoice_id { get; set; } 

        [JsonProperty("item_recurring", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Item_recurring { get; set; } 

        [JsonProperty("line_recurring", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Line_recurring { get; set; } 

        [JsonProperty("item_contract", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Item_contract { get; set; } 

        [JsonProperty("item_template", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Item_template { get; set; } 

        [JsonProperty("item_budgettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Item_budgettype { get; set; } 

        [JsonProperty("item_doesnotneedconsigning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Item_doesnotneedconsigning { get; set; } 

        [JsonProperty("supplier_po", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Supplier_po { get; set; } 

        [JsonProperty("supplier_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Supplier_id { get; set; } 

        [JsonProperty("supplier_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Supplier_name { get; set; } 

        [JsonProperty("consignment_ids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<int>? Consignment_ids { get; set; } 

        [JsonProperty("quotation_line_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Quotation_line_id { get; set; } 

        [JsonProperty("group_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Group_id { get; set; } 

        [JsonProperty("isgroupdesc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isgroupdesc { get; set; } 

        [JsonProperty("nominalcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Nominalcode { get; set; } 

        [JsonProperty("cost_centre", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Cost_centre { get; set; } 

        [JsonProperty("project_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Project_id { get; set; } 

        [JsonProperty("contract_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Contract_id { get; set; } 

        [JsonProperty("contract_ref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Contract_ref { get; set; } 

        [JsonProperty("do_not_invoice_line", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Do_not_invoice_line { get; set; } 

        [JsonProperty("item_description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Item_description { get; set; } 

        [JsonProperty("item_purchase_description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Item_purchase_description { get; set; } 

        [JsonProperty("item_note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Item_note { get; set; } 

        [JsonProperty("item_internal_reference", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Item_internal_reference { get; set; } 

        [JsonProperty("item_external_reference", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Item_external_reference { get; set; } 

        [JsonProperty("item_tax_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Item_tax_name { get; set; } 

        [JsonProperty("item_min_purchase_qty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Item_min_purchase_qty { get; set; } 

        [JsonProperty("_create_po", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _create_po { get; set; } 

        [JsonProperty("_create_ticket", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _create_ticket { get; set; } 

        [JsonProperty("quantity_to_reserve", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Quantity_to_reserve { get; set; } 

        [JsonProperty("assets_to_reserve", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Device_List>? Assets_to_reserve { get; set; } 

        [JsonProperty("reserved_assets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Device_List>? Reserved_assets { get; set; } 

        [JsonProperty("consigned_assets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Device_List>? Consigned_assets { get; set; } 

        [JsonProperty("invoice_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Invoice_id { get; set; } 

        [JsonProperty("soitemurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Soitemurl { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("line_site_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Line_site_id { get; set; } 

        [JsonProperty("site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Site_name { get; set; } 

        [JsonProperty("client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Client_name { get; set; } 

        [JsonProperty("user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? User_name { get; set; } 

        [JsonProperty("user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? User_id { get; set; } 

        [JsonProperty("sales_order_ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sales_order_ticket_id { get; set; } 

        [JsonProperty("sales_order_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Sales_order_date { get; set; } 

        [JsonProperty("sales_order_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sales_order_status { get; set; } 

        [JsonProperty("intacct_class", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intacct_class { get; set; } 

        [JsonProperty("intacct_class_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intacct_class_name { get; set; } 

        [JsonProperty("intacct_save_location", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intacct_save_location { get; set; } 

        [JsonProperty("line_periods", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Line_periods { get; set; } 

        [JsonProperty("hideitems", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hideitems { get; set; } 

        [JsonProperty("isleased", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isleased { get; set; } 

        [JsonProperty("addbudget", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Addbudget { get; set; } 

        [JsonProperty("add_child_templates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Add_child_templates { get; set; } 

        [JsonProperty("stockbin_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Stockbin_id { get; set; } 

        [JsonProperty("isfreightline", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isfreightline { get; set; } 

        [JsonProperty("asset_type_matching_field_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Asset_type_matching_field_name { get; set; } 

        [JsonProperty("items_in_group_no_consign", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Items_in_group_no_consign { get; set; } 

        [JsonProperty("serialise_only_one", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Serialise_only_one { get; set; } 

        [JsonProperty("invoice_ids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<int>? Invoice_ids { get; set; } 

        [JsonProperty("percentage_invoiced", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Percentage_invoiced { get; set; } 

        [JsonProperty("item_weight", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Item_weight { get; set; } 

        [JsonProperty("create_child_project", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Create_child_project { get; set; } 

        [JsonProperty("taxable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Taxable { get; set; } 

        [JsonProperty("project_child_faultid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Project_child_faultid { get; set; } 

        [JsonProperty("_create_invoice_percentage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? _create_invoice_percentage { get; set; } 

        [JsonProperty("is_bundled_line", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_bundled_line { get; set; } 

        [JsonProperty("dattocommercelineid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Dattocommercelineid { get; set; } 

        [JsonProperty("line_ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Line_ticket_id { get; set; } 

        [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CustomField>? Customfields { get; set; } 

        [JsonProperty("is_deferred_revenue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_deferred_revenue { get; set; } 

        [JsonProperty("chargerates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Lookup>? Chargerates { get; set; } 

        [JsonProperty("budgets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<FaultBudget>? Budgets { get; set; } 

        [JsonProperty("hide_grouped_items_price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hide_grouped_items_price { get; set; } 

        [JsonProperty("discount_perc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Discount_perc { get; set; } 

        [JsonProperty("purchase_currency_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Purchase_currency_code { get; set; } 

        [JsonProperty("item_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Item_tax_code { get; set; } 

        [JsonProperty("cost_converted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Cost_converted { get; set; } 

        [JsonProperty("purchase_currency_code_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Purchase_currency_code_name { get; set; } 

        [JsonProperty("purchase_currency_symbol", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Purchase_currency_symbol { get; set; } 

        [JsonProperty("purchase_conversion_rate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Purchase_conversion_rate { get; set; } 

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

        [JsonProperty("mark_as_complete", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Mark_as_complete { get; set; } 

        [JsonProperty("consignment_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AddressStore? Consignment_address { get; set; } 

        [JsonProperty("budget_add_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Budget_add_type { get; set; } 

        [JsonProperty("baseprice_converted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Baseprice_converted { get; set; } 

        [JsonProperty("baseprice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Baseprice { get; set; } 

        [JsonProperty("total_price_monthly_converted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Total_price_monthly_converted { get; set; } 

        [JsonProperty("total_price_annual_converted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Total_price_annual_converted { get; set; } 

        [JsonProperty("total_price_yearone_converted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Total_price_yearone_converted { get; set; } 

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
    public class Organisation
    {
        [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Guid { get; set; } 

        [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intent { get; set; } 

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("reply_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Reply_address { get; set; } 

        [JsonProperty("messagegroup_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Messagegroup_id { get; set; } 

        [JsonProperty("address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AddressStore? Address { get; set; } 

        [JsonProperty("phone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Phone { get; set; } 

        [JsonProperty("fax", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Fax { get; set; } 

        [JsonProperty("email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Email { get; set; } 

        [JsonProperty("website", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Website { get; set; } 

        [JsonProperty("logo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Logo { get; set; } 

        [JsonProperty("portal_logo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Portal_logo { get; set; } 

        [JsonProperty("portalbackgroundimageurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(500)]
        public string? Portalbackgroundimageurl { get; set; } 

        [JsonProperty("deliverysite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Deliverysite { get; set; } 

        [JsonProperty("portalurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Portalurl { get; set; } 

        [JsonProperty("portalcolour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Portalcolour { get; set; } 

        [JsonProperty("portalfolderlocation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Portalfolderlocation { get; set; } 

        [JsonProperty("departments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Tree_List>? Departments { get; set; } 

        [JsonProperty("linked_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Linked_client_id { get; set; } 

        [JsonProperty("allowall_tickettypes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allowall_tickettypes { get; set; } 

        [JsonProperty("allowed_tickettypes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<RequestType_List>? Allowed_tickettypes { get; set; } 

        [JsonProperty("faqlists", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<FAQListHead>? Faqlists { get; set; } 

        [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CustomField>? Customfields { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("isorganisationdetails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isorganisationdetails { get; set; } 

        [JsonProperty("bank_details_line_1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Bank_details_line_1 { get; set; } 

        [JsonProperty("bank_details_line_2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Bank_details_line_2 { get; set; } 

        [JsonProperty("bank_details_line_3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Bank_details_line_3 { get; set; } 

        [JsonProperty("bank_details_line_4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Bank_details_line_4 { get; set; } 

        [JsonProperty("bank_details_line_5", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Bank_details_line_5 { get; set; } 

        [JsonProperty("tax_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Tax_number { get; set; } 

        [JsonProperty("new_icon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_icon { get; set; } 

        [JsonProperty("portal_title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Portal_title { get; set; } 

        [JsonProperty("user_faqlists", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<FAQListHead>? User_faqlists { get; set; } 

        [JsonProperty("all_user_faqlists_allowed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? All_user_faqlists_allowed { get; set; } 

        [JsonProperty("portal_chat_profile_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Portal_chat_profile_override { get; set; } 

        [JsonProperty("portal_chat_profile_override_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Portal_chat_profile_override_name { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class OrganisationField
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("org_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Org_id { get; set; } 

        [JsonProperty("org_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Org_name { get; set; } 

        [JsonProperty("field_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Field_id { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class OrionAlert
    {
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Type { get; set; } 

        [JsonProperty("application", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Application { get; set; } 

        [JsonProperty("alert_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Alert_id { get; set; } 

        [JsonProperty("alert_active_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Alert_active_id { get; set; } 

        [JsonProperty("alert_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Alert_name { get; set; } 

        [JsonProperty("summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Summary { get; set; } 

        [JsonProperty("details", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Details { get; set; } 

        [JsonProperty("severity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Severity { get; set; } 

        [JsonProperty("asset_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Asset_value { get; set; } 

        [JsonProperty("team", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Team { get; set; } 

        [JsonProperty("agent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Agent { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class OutboundIntegration
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Guid { get; set; } 

        [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intent { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("module_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Module_id { get; set; } 

        [JsonProperty("authorizationtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Authorizationtype { get; set; } 

        [JsonProperty("granttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Granttype { get; set; } 

        [JsonProperty("authorizationurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Authorizationurl { get; set; } 

        [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Client_id { get; set; } 

        [JsonProperty("new_client_secret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_client_secret { get; set; } 

        [JsonProperty("username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Username { get; set; } 

        [JsonProperty("new_password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_password { get; set; } 

        [JsonProperty("tokenurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Tokenurl { get; set; } 

        [JsonProperty("scope", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Scope { get; set; } 

        [JsonProperty("state", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? State { get; set; } 

        [JsonProperty("headername", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(100)]
        public string? Headername { get; set; } 

        [JsonProperty("headerprefix", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(100)]
        public string? Headerprefix { get; set; } 

        [JsonProperty("algorithm", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Algorithm { get; set; } 

        [JsonProperty("bearername", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Bearername { get; set; } 

        [JsonProperty("bearerlocation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Bearerlocation { get; set; } 

        [JsonProperty("resourcebaseurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Resourcebaseurl { get; set; } 

        [JsonProperty("certificate_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Certificate_id { get; set; } 

        [JsonProperty("certificate_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Certificate_name { get; set; } 

        [JsonProperty("response_token_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Response_token_name { get; set; } 

        [JsonProperty("token_expiry_mins", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Token_expiry_mins { get; set; } 

        [JsonProperty("library_licence_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Library_licence_name { get; set; } 

        [JsonProperty("icon_base64", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Icon_base64 { get; set; } 

        [JsonProperty("icon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Icon { get; set; } 

        [JsonProperty("major_version_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Major_version_number { get; set; } 

        [JsonProperty("minor_version_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Minor_version_number { get; set; } 

        [JsonProperty("patch_version_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Patch_version_number { get; set; } 

        [JsonProperty("version_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Version_number { get; set; } 

        [JsonProperty("note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(4000)]
        public string? Note { get; set; } 

        [JsonProperty("install_popup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(4000)]
        public string? Install_popup { get; set; } 

        [JsonProperty("authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Authorized { get; set; } 

        [JsonProperty("methods", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<OutboundIntegrationMethod>? Methods { get; set; } 

        [JsonProperty("_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _code { get; set; } 

        [JsonProperty("_verifier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _verifier { get; set; } 

        [JsonProperty("_callback_uri", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _callback_uri { get; set; } 

        [JsonProperty("_disconnect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _disconnect { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class OutboundIntegrationMethod
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Guid { get; set; } 

        [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intent { get; set; } 

        [JsonProperty("integration_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Integration_id { get; set; } 

        [JsonProperty("integration_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Integration_guid { get; set; } 

        [JsonProperty("integration_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Integration_name { get; set; } 

        [JsonProperty("integration_baseurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Integration_baseurl { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("full_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Full_name { get; set; } 

        [JsonProperty("resource", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Resource { get; set; } 

        [JsonProperty("path", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Path { get; set; } 

        [JsonProperty("method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Method { get; set; } 

        [JsonProperty("authorizationtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Authorizationtype { get; set; } 

        [JsonProperty("requesttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Requesttype { get; set; } 

        [JsonProperty("responsetype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Responsetype { get; set; } 

        [JsonProperty("requestbody", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Requestbody { get; set; } 

        [JsonProperty("log_retention_policy_days", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Log_retention_policy_days { get; set; } 

        [JsonProperty("uri_params", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<OutboundIntegrationMethodValue>? Uri_params { get; set; } 

        [JsonProperty("headers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<OutboundIntegrationMethodValue>? Headers { get; set; } 

        [JsonProperty("body_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<OutboundIntegrationMethodValue>? Body_mappings { get; set; } 

        [JsonProperty("output_variables", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<OutboundIntegrationMethodValue>? Output_variables { get; set; } 

        [JsonProperty("_test", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _test { get; set; } 

        [JsonProperty("_test_variables", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationRunbookVariable>? _test_variables { get; set; } 

        [JsonProperty("_test_runbook_variables", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationRunbookVariable>? _test_runbook_variables { get; set; } 

        [JsonProperty("_test_output_variables", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationRunbookVariable>? _test_output_variables { get; set; } 

        [JsonProperty("_test_result", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public WebhookEvent? _test_result { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("_isbatch", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _isbatch { get; set; } 

        [JsonProperty("_is_system_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _is_system_method { get; set; } 

        [JsonProperty("_is_cf_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _is_cf_method { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class OutboundIntegrationMethodValue
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("method_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Method_id { get; set; } 

        [JsonProperty("runbook_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Runbook_id { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; } 

        [JsonProperty("data_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Data_type { get; set; } 

        [JsonProperty("key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Key { get; set; } 

        [JsonProperty("value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Value { get; set; } 

        [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Description { get; set; } 

        [JsonProperty("value_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<OutboundIntegrationMethodValueMapping>? Value_mappings { get; set; } 

        [JsonProperty("extra_process", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Extra_process { get; set; } 

        [JsonProperty("step_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Step_id { get; set; } 

        [JsonProperty("step_seq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Step_seq { get; set; } 

        [JsonProperty("step_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Step_name { get; set; } 

        [JsonProperty("persist", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Persist { get; set; } 

        [JsonProperty("mapping_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Mapping_type { get; set; } 

        [JsonProperty("object_mapping", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Object_mapping { get; set; } 

        [JsonProperty("rule_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Rule_id { get; set; } 

        [JsonProperty("rule_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Rule_guid { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class OutboundIntegrationMethodValueMapping
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("methodvalue_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Methodvalue_id { get; set; } 

        [JsonProperty("sequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sequence { get; set; } 

        [JsonProperty("input", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Input { get; set; } 

        [JsonProperty("output", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Output { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class Outgoingemail
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("datesent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Datesent { get; set; } 

        [JsonProperty("memo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Memo { get; set; } 

        [JsonProperty("html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Html { get; set; } 

        [JsonProperty("delete", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Delete { get; set; } 

        [JsonProperty("from", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? From { get; set; } 

        [JsonProperty("to", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? To { get; set; } 

        [JsonProperty("cc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Cc { get; set; } 

        [JsonProperty("subject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Subject { get; set; } 

        [JsonProperty("likely_cause", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Likely_cause { get; set; } 

        [JsonProperty("changeseq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Changeseq { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; } 

        [JsonProperty("idone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Idone { get; set; } 

        [JsonProperty("idtwo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Idtwo { get; set; } 

        [JsonProperty("actiondate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Actiondate { get; set; } 

        [JsonProperty("error", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Error { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }