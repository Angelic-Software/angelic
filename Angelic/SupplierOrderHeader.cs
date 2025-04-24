using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class SupplierOrderHeader
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

    [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Status { get; set; } 

    [JsonProperty("po_ref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Po_ref { get; set; } 

    [JsonProperty("date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Date { get; set; } 

    [JsonProperty("datesent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Datesent { get; set; } 

    [JsonProperty("carriage_desc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Carriage_desc { get; set; } 

    [JsonProperty("carriage_price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Carriage_price { get; set; } 

    [JsonProperty("auth_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Auth_by { get; set; } 

    [JsonProperty("note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Note { get; set; } 

    [JsonProperty("price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Price { get; set; } 

    [JsonProperty("total", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Total { get; set; } 

    [JsonProperty("supplier_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Supplier_id { get; set; } 

    [JsonProperty("supplier_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Supplier_name { get; set; } 

    [JsonProperty("goodsin_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Goodsin_status { get; set; } 

    [JsonProperty("3rd_party_ponumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _3rd_party_ponumber { get; set; } 

    [JsonProperty("date_published", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Date_published { get; set; } 

    [JsonProperty("approval_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Approval_status { get; set; } 

    [JsonProperty("approval_start", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Approval_start { get; set; } 

    [JsonProperty("assigned_agent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Assigned_agent { get; set; } 

    [JsonProperty("assigned_agent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Assigned_agent_name { get; set; } 

    [JsonProperty("approvalagent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Approvalagent { get; set; } 

    [JsonProperty("approvalemailaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Approvalemailaddress { get; set; } 

    [JsonProperty("approvalnote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Approvalnote { get; set; } 

    [JsonProperty("approvalagentid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Approvalagentid { get; set; } 

    [JsonProperty("approvaldatetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Approvaldatetime { get; set; } 

    [JsonProperty("thirdparty_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Thirdparty_status { get; set; } 

    [JsonProperty("accounts_ref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Accounts_ref { get; set; } 

    [JsonProperty("deliver_to_us", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Deliver_to_us { get; set; } 

    [JsonProperty("deliver_to_so_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Deliver_to_so_address { get; set; } 

    [JsonProperty("deliver_to_ticket_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Deliver_to_ticket_address { get; set; } 

    [JsonProperty("delivery_backup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Delivery_backup { get; set; } 

    [JsonProperty("est_delivery_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Est_delivery_date { get; set; } 

    [JsonProperty("salesorder_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Salesorder_id { get; set; } 

    [JsonProperty("currency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Currency { get; set; } 

    [JsonProperty("user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public object? User { get; set; } 

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

    [JsonProperty("cost_centre_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Cost_centre_id { get; set; } 

    [JsonProperty("cost_centre_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Cost_centre_name { get; set; } 

    [JsonProperty("ticket_summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Ticket_summary { get; set; } 

    [JsonProperty("ticket_note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Ticket_note { get; set; } 

    [JsonProperty("attachment_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Attachment_id { get; set; } 

    [JsonProperty("lines", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<SupplierOrderDetail>? Lines { get; set; } 

    [JsonProperty("add_lines", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<SupplierOrderDetail>? Add_lines { get; set; } 

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

    [JsonProperty("createdbyagentname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Createdbyagentname { get; set; } 

    [JsonProperty("xero_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Xero_id { get; set; } 

    [JsonProperty("xero_tenant_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Xero_tenant_id { get; set; } 

    [JsonProperty("xero_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Xero_status { get; set; } 

    [JsonProperty("last_synced", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Last_synced { get; set; } 

    [JsonProperty("last_update_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Last_update_time { get; set; } 

    [JsonProperty("requires_approval", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Requires_approval { get; set; } 

    [JsonProperty("below_approval_minimum", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Below_approval_minimum { get; set; } 

    [JsonProperty("approval_for_below_minimum", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Approval_for_below_minimum { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

    [JsonProperty("so_assets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Device_List>? So_assets { get; set; } 

    [JsonProperty("warrantyurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warrantyurl { get; set; } 

    [JsonProperty("qbo_company_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Qbo_company_id { get; set; } 

    [JsonProperty("qbo_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Qbo_id { get; set; } 

    [JsonProperty("_iscopy", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _iscopy { get; set; } 

    [JsonProperty("_create_invoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _create_invoice { get; set; } 

    [JsonProperty("_create_invoice_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? _create_invoice_method { get; set; } 

    [JsonProperty("_create_invoice_percentage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? _create_invoice_percentage { get; set; } 

    [JsonProperty("_create_invoice_lines", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<SupplierOrderDetail>? _create_invoice_lines { get; set; } 

    [JsonProperty("_return_invoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _return_invoice { get; set; } 

    [JsonProperty("percentage_invoiced", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Percentage_invoiced { get; set; } 

    [JsonProperty("invoices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<InvoiceHeader>? Invoices { get; set; } 

    [JsonProperty("invoice_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Invoice_count { get; set; } 

    [JsonProperty("intacct_save_location", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Intacct_save_location { get; set; } 

    [JsonProperty("currency_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Currency_code { get; set; } 

    [JsonProperty("currency_code_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Currency_code_name { get; set; } 

    [JsonProperty("currency_conversion_rate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Currency_conversion_rate { get; set; } 

    [JsonProperty("duedate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Duedate { get; set; } 

    [JsonProperty("intacct_class", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Intacct_class { get; set; } 

    [JsonProperty("intacct_class_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Intacct_class_name { get; set; } 

    [JsonProperty("suppliers_order_reference", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Suppliers_order_reference { get; set; } 

    [JsonProperty("_create_invoice_invoice_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? _create_invoice_invoice_date { get; set; } 

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

    [JsonProperty("_forcethirdpartysync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _forcethirdpartysync { get; set; } 

    [JsonProperty("_create_invoice_amount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? _create_invoice_amount { get; set; } 

    [JsonProperty("_create_invoice_qty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? _create_invoice_qty { get; set; } 

    [JsonProperty("_create_invoice_line_description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _create_invoice_line_description { get; set; } 

    [JsonProperty("_ticket_access", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _ticket_access { get; set; } 

    [JsonProperty("third_party_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Third_party_id { get; set; } 

    [JsonProperty("is_po_screen", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Is_po_screen { get; set; } 

    [JsonProperty("avalara_details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Avalara_details_id { get; set; } 

    [JsonProperty("avalara_details_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Avalara_details_name { get; set; } 

    [JsonProperty("_purchasing_run", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _purchasing_run { get; set; } 

    [JsonProperty("_novalidate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _novalidate { get; set; } 

    [JsonProperty("_dodistributorsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _dodistributorsync { get; set; } 

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

    [JsonProperty("_dont_fire_automations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _dont_fire_automations { get; set; } 

    [JsonProperty("approval_process_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Approval_process_id { get; set; } 

    [JsonProperty("use_ticket_approval", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Use_ticket_approval { get; set; } 

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

    [JsonProperty("new_approvalprocess_role_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? New_approvalprocess_role_id { get; set; } 

    [JsonProperty("_isbatch", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _isbatch { get; set; } 

    [JsonProperty("token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Token { get; set; } 

    [JsonProperty("receipt_confirmed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Receipt_confirmed { get; set; } 

    [JsonProperty("receipt_confirmation_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Receipt_confirmation_date { get; set; } 

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