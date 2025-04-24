using System.CodeDom.Compiler;
using Angelic.KeyPairs;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class InvoiceHeader
{
    [JsonProperty("disabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Disabled { get; set; } 

    [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomField>? Customfields { get; set; } 

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Use { get; set; } 

    [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Client_id { get; set; } 

    [JsonProperty("client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Client_name { get; set; } 

    [JsonProperty("sitenumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sitenumber { get; set; } 

    [JsonProperty("site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Site_name { get; set; } 

    [JsonProperty("accountsid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Accountsid { get; set; } 

    [JsonProperty("uid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Uid { get; set; } 

    [JsonProperty("invoicenumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Invoicenumber { get; set; } 

    [JsonProperty("thirdpartyinvoicenumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Thirdpartyinvoicenumber { get; set; } 

    [JsonProperty("posted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Posted { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

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

    [JsonProperty("tel_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Tel_number { get; set; } 

    [JsonProperty("contactname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Contactname { get; set; } 

    [JsonProperty("global_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Global_tax_code { get; set; } 

    [JsonProperty("invoice_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Invoice_date { get; set; } 

    [JsonProperty("schedule_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Schedule_date { get; set; } 

    [JsonProperty("dateposted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Dateposted { get; set; } 

    [JsonProperty("last_synced", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Last_synced { get; set; } 

    [JsonProperty("last_modified", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Last_modified { get; set; } 

    [JsonProperty("notes_1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Notes_1 { get; set; } 

    [JsonProperty("notes_2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Notes_2 { get; set; } 

    [JsonProperty("notes_3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Notes_3 { get; set; } 

    [JsonProperty("taken_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Taken_by { get; set; } 

    [JsonProperty("order_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Order_number { get; set; } 

    [JsonProperty("cust_order_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Cust_order_number { get; set; } 

    [JsonProperty("payment_ref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Payment_ref { get; set; } 

    [JsonProperty("global_nom_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Global_nom_code { get; set; } 

    [JsonProperty("global_details", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Global_details { get; set; } 

    [JsonProperty("invoice_type_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Invoice_type_code { get; set; } 

    [JsonProperty("salesorder_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Salesorder_id { get; set; } 

    [JsonProperty("datetype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Datetype { get; set; } 

    [JsonProperty("percentold", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Percentold { get; set; } 

    [JsonProperty("percent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Percent { get; set; } 

    [JsonProperty("contract_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Contract_id { get; set; } 

    [JsonProperty("contract_ref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Contract_ref { get; set; } 

    [JsonProperty("datesent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Datesent { get; set; } 

    [JsonProperty("currency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Currency { get; set; } 

    [JsonProperty("currency_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Currency_code { get; set; } 

    [JsonProperty("currency_code_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Currency_code_name { get; set; } 

    [JsonProperty("currency_conversion_rate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Currency_conversion_rate { get; set; } 

    [JsonProperty("paymentterms", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Paymentterms { get; set; } 

    [JsonProperty("hideinvoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Hideinvoice { get; set; } 

    [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Ticket_id { get; set; } 

    [JsonProperty("invoicetype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Invoicetype { get; set; } 

    [JsonProperty("datepaid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Datepaid { get; set; } 

    [JsonProperty("paymentstatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Paymentstatus { get; set; } 

    [JsonProperty("xeroid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Xeroid { get; set; } 

    [JsonProperty("amountpaid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Amountpaid { get; set; } 

    [JsonProperty("amountdue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Amountdue { get; set; } 

    [JsonProperty("amount_remaining", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Amount_remaining { get; set; } 

    [JsonProperty("emailstatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Emailstatus { get; set; } 

    [JsonProperty("address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public AddressStore? Address { get; set; } 

    [JsonProperty("shipaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public AddressStore? Shipaddress { get; set; } 

    [JsonProperty("originaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public AddressStore? Originaddress { get; set; } 

    [JsonProperty("lines", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<InvoiceDetail>? Lines { get; set; } 

    [JsonProperty("add_lines", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<InvoiceDetail>? Add_lines { get; set; } 

    [JsonProperty("_print_preview", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _print_preview { get; set; } 

    [JsonProperty("_print_generate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _print_generate { get; set; } 

    [JsonProperty("printhtml", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Printhtml { get; set; } 

    [JsonProperty("pdf_attachment_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Pdf_attachment_id { get; set; } 

    [JsonProperty("pdf_attachment_date_created", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Pdf_attachment_date_created { get; set; } 

    [JsonProperty("pdftemplate_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Pdftemplate_id { get; set; } 

    [JsonProperty("pdftemplate_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Pdftemplate_name { get; set; } 

    [JsonProperty("composite_tax_total", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Composite_tax_total { get; set; } 

    [JsonProperty("total", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Total { get; set; } 

    [JsonProperty("reference", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Reference { get; set; } 

    [JsonProperty("duedate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Duedate { get; set; } 

    [JsonProperty("_is_invoice_run", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _is_invoice_run { get; set; } 

    [JsonProperty("_billing_cut_off", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? _billing_cut_off { get; set; } 

    [JsonProperty("is_recurring_invoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Is_recurring_invoice { get; set; } 

    [JsonProperty("schedule_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Schedule_id { get; set; } 

    [JsonProperty("lastcreated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Lastcreated { get; set; } 

    [JsonProperty("nextcreationdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Nextcreationdate { get; set; } 

    [JsonProperty("period", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Period { get; set; } 

    [JsonProperty("schedule", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public StdRequest? Schedule { get; set; } 

    [JsonProperty("create_recurring_invoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Create_recurring_invoice { get; set; } 

    [JsonProperty("take_auto_payment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Take_auto_payment { get; set; } 

    [JsonProperty("recurring_invoice_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Recurring_invoice_id { get; set; } 

    [JsonProperty("add_contract_assets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Add_contract_assets { get; set; } 

    [JsonProperty("add_labour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Add_labour { get; set; } 

    [JsonProperty("add_project", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Add_project { get; set; } 

    [JsonProperty("add_travel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Add_travel { get; set; } 

    [JsonProperty("add_mileage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Add_mileage { get; set; } 

    [JsonProperty("add_itemsissued", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Add_itemsissued { get; set; } 

    [JsonProperty("add_prepay", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Add_prepay { get; set; } 

    [JsonProperty("add_salesorder", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Add_salesorder { get; set; } 

    [JsonProperty("force_creation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Force_creation { get; set; } 

    [JsonProperty("_create_from_areaitems", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AreaItem>? _create_from_areaitems { get; set; } 

    [JsonProperty("_create_from_contract", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? _create_from_contract { get; set; } 

    [JsonProperty("_validateonly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _validateonly { get; set; } 

    [JsonProperty("qboid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Qboid { get; set; } 

    [JsonProperty("billingcategory", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Billingcategory { get; set; } 

    [JsonProperty("_sendmassinvoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _sendmassinvoice { get; set; } 

    [JsonProperty("xero_tenant_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Xero_tenant_id { get; set; } 

    [JsonProperty("xero_branding_theme_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Xero_branding_theme_id { get; set; } 

    [JsonProperty("xero_branding_theme_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Xero_branding_theme_name { get; set; } 

    [JsonProperty("xero_branding_theme", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ValueLabelIsNewKeyPair? Xero_branding_theme { get; set; } 

    [JsonProperty("due_date_int", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Due_date_int { get; set; } 

    [JsonProperty("due_date_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Due_date_type { get; set; } 

    [JsonProperty("createdbyagentname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Createdbyagentname { get; set; } 

    [JsonProperty("internal_note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Internal_note { get; set; } 

    [JsonProperty("mailboxid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Mailboxid { get; set; } 

    [JsonProperty("period_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Period_type { get; set; } 

    [JsonProperty("kashflow_tenant_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Kashflow_tenant_id { get; set; } 

    [JsonProperty("kashflowid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Kashflowid { get; set; } 

    [JsonProperty("kashflow_pdf", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Kashflow_pdf { get; set; } 

    [JsonProperty("original_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Original_client_id { get; set; } 

    [JsonProperty("original_client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Original_client_name { get; set; } 

    [JsonProperty("xero_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Xero_status { get; set; } 

    [JsonProperty("merge_data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<InvoiceHeaderMerge>? Merge_data { get; set; } 

    [JsonProperty("snelstart_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Snelstart_id { get; set; } 

    [JsonProperty("time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Time { get; set; } 

    [JsonProperty("startdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Startdate { get; set; } 

    [JsonProperty("enddate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Enddate { get; set; } 

    [JsonProperty("daysplus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Daysplus { get; set; } 

    [JsonProperty("periodname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Periodname { get; set; } 

    [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _isimport { get; set; } 

    [JsonProperty("duedatename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Duedatename { get; set; } 

    [JsonProperty("date_created", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Date_created { get; set; } 

    [JsonProperty("invoice_prorata_periods_ahead", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Invoice_prorata_periods_ahead { get; set; } 

    [JsonProperty("nextcreationperiod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Nextcreationperiod { get; set; } 

    [JsonProperty("qbo_company_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Qbo_company_id { get; set; } 

    [JsonProperty("intacct_recordno", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Intacct_recordno { get; set; } 

    [JsonProperty("period_start_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Period_start_date { get; set; } 

    [JsonProperty("period_end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Period_end_date { get; set; } 

    [JsonProperty("payments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<InvoicePayment_List>? Payments { get; set; } 

    [JsonProperty("markaspaid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Markaspaid { get; set; } 

    [JsonProperty("markaspaidmoduleid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Markaspaidmoduleid { get; set; } 

    [JsonProperty("dbc_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Dbc_id { get; set; } 

    [JsonProperty("dbc_company_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Dbc_company_id { get; set; } 

    [JsonProperty("reviewrequired", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Reviewrequired { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

    [JsonProperty("_xmlwarning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _xmlwarning { get; set; } 

    [JsonProperty("creditlinkedtoinvoiceid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Creditlinkedtoinvoiceid { get; set; } 

    [JsonProperty("creditlinkedtoinvoiceid_thirdpartynumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Creditlinkedtoinvoiceid_thirdpartynumber { get; set; } 

    [JsonProperty("creditlinkedtoinvoiceid_typeid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Creditlinkedtoinvoiceid_typeid { get; set; } 

    [JsonProperty("purchaseorder_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Purchaseorder_id { get; set; } 

    [JsonProperty("sage_business_cloud_details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sage_business_cloud_details_id { get; set; } 

    [JsonProperty("sage_business_cloud_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Sage_business_cloud_id { get; set; } 

    [JsonProperty("exact_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Exact_id { get; set; } 

    [JsonProperty("exact_division", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Exact_division { get; set; } 

    [JsonProperty("xero_line_tax", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Xero_line_tax { get; set; } 

    [JsonProperty("invoice_auto_increase_period", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Invoice_auto_increase_period { get; set; } 

    [JsonProperty("invoice_percent_increase", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Invoice_percent_increase { get; set; } 

    [JsonProperty("schedule_ignore_delete", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Schedule_ignore_delete { get; set; } 

    [JsonProperty("assigned_agent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Assigned_agent { get; set; } 

    [JsonProperty("assigned_agent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Assigned_agent_name { get; set; } 

    [JsonProperty("approval_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Approval_status { get; set; } 

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

    [JsonProperty("ticket_summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Ticket_summary { get; set; } 

    [JsonProperty("ticket_note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Ticket_note { get; set; } 

    [JsonProperty("approval_start", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Approval_start { get; set; } 

    [JsonProperty("requires_approval", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Requires_approval { get; set; } 

    [JsonProperty("xero_online_invoice_payment_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Xero_online_invoice_payment_url { get; set; } 

    [JsonProperty("generic_online_invoice_payment_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Generic_online_invoice_payment_url { get; set; } 

    [JsonProperty("intacct_save_location", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Intacct_save_location { get; set; } 

    [JsonProperty("intacctseparatetaxline", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Intacctseparatetaxline { get; set; } 

    [JsonProperty("intacct_class", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Intacct_class { get; set; } 

    [JsonProperty("intacct_class_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Intacct_class_name { get; set; } 

    [JsonProperty("take_payment_on_duedate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Take_payment_on_duedate { get; set; } 

    [JsonProperty("contains_calculated_quantity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Contains_calculated_quantity { get; set; } 

    [JsonProperty("intacct_tax_solution", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Intacct_tax_solution { get; set; } 

    [JsonProperty("intacct_tax_solution_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Intacct_tax_solution_name { get; set; } 

    [JsonProperty("intacct_project", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Intacct_project { get; set; } 

    [JsonProperty("intacct_project_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Intacct_project_name { get; set; } 

    [JsonProperty("_create_credit_note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _create_credit_note { get; set; } 

    [JsonProperty("credit_total", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Credit_total { get; set; } 

    [JsonProperty("supplier_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Supplier_id { get; set; } 

    [JsonProperty("supplier_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Supplier_name { get; set; } 

    [JsonProperty("_dont_fire_automations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _dont_fire_automations { get; set; } 

    [JsonProperty("_is_process", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _is_process { get; set; } 

    [JsonProperty("_is_task_schedule", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _is_task_schedule { get; set; } 

    [JsonProperty("payments_pending", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Payments_pending { get; set; } 

    [JsonProperty("include_in_autopay", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Include_in_autopay { get; set; } 

    [JsonProperty("_forcethirdpartysync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _forcethirdpartysync { get; set; } 

    [JsonProperty("client_to_invoice_to_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Client_to_invoice_to_id { get; set; } 

    [JsonProperty("creation_source", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Creation_source { get; set; } 

    [JsonProperty("typeid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Typeid { get; set; } 

    [JsonProperty("twilio_invoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Twilio_invoice { get; set; } 

    [JsonProperty("invoice_separately", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Invoice_separately { get; set; } 

    [JsonProperty("minimum_price_active", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Minimum_price_active { get; set; } 

    [JsonProperty("minimum_line_description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Minimum_line_description { get; set; } 

    [JsonProperty("minimum_amount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Minimum_amount { get; set; } 

    [JsonProperty("avalara_details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Avalara_details_id { get; set; } 

    [JsonProperty("qbo_term_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Qbo_term_name { get; set; } 

    [JsonProperty("qbo_term_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Qbo_term_id { get; set; } 

    [JsonProperty("qbo_term", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ValueLabelIsNewKeyPair? Qbo_term { get; set; } 

    [JsonProperty("exact_payment_conditon_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Exact_payment_conditon_name { get; set; } 

    [JsonProperty("exact_payment_conditon_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Exact_payment_conditon_id { get; set; } 

    [JsonProperty("exact_payment_conditon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ValueLabelIsNewKeyPair? Exact_payment_conditon { get; set; } 

    [JsonProperty("avalara_details_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Avalara_details_name { get; set; } 

    [JsonProperty("voided", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Voided { get; set; } 

    [JsonProperty("credit_outstanding_for_customer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Credit_outstanding_for_customer { get; set; } 

    [JsonProperty("credit_outstanding", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Credit_outstanding { get; set; } 

    [JsonProperty("credit_used", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Credit_used { get; set; } 

    [JsonProperty("mark_credit_as_used", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Mark_credit_as_used { get; set; } 

    [JsonProperty("apply_credit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Apply_credit { get; set; } 

    [JsonProperty("apply_credit_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Apply_credit_id { get; set; } 

    [JsonProperty("apply_credit_amount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Apply_credit_amount { get; set; } 

    [JsonProperty("apply_credit_description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Apply_credit_description { get; set; } 

    [JsonProperty("apply_credit_long_description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Apply_credit_long_description { get; set; } 

    [JsonProperty("apply_credit_tax_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Apply_credit_tax_type { get; set; } 

    [JsonProperty("invoice_display", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Invoice_display { get; set; } 

    [JsonProperty("_novalidate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _novalidate { get; set; } 

    [JsonProperty("sqlimport_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sqlimport_id { get; set; } 

    [JsonProperty("invoice_match_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Invoice_match_id { get; set; } 

    [JsonProperty("sync_include_paid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Sync_include_paid { get; set; } 

    [JsonProperty("dont_set_original_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Dont_set_original_client_id { get; set; } 

    [JsonProperty("_docommitsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _docommitsync { get; set; } 

    [JsonProperty("_ignore_dont_send_invoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _ignore_dont_send_invoice { get; set; } 

    [JsonProperty("ticket_client_to_invoice_to_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Ticket_client_to_invoice_to_id { get; set; } 

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

    [JsonProperty("most_recent_invoice_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Most_recent_invoice_id { get; set; } 

    [JsonProperty("most_recent_invoice_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Most_recent_invoice_type { get; set; } 

    [JsonProperty("custombuttons", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomButton>? Custombuttons { get; set; } 

    [JsonProperty("extratabs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Tabname>? Extratabs { get; set; } 

    [JsonProperty("update_invoice_conversion_rate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Update_invoice_conversion_rate { get; set; } 

    [JsonProperty("conversion_rate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Conversion_rate { get; set; } 

    [JsonProperty("dont_sync_to_3rd_party", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Dont_sync_to_3rd_party { get; set; } 

    [JsonProperty("is_invoice_screen", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Is_invoice_screen { get; set; } 

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