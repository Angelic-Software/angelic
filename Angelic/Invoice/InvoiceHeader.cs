using System.CodeDom.Compiler;
using Angelic.Areas;
using Angelic.Configuration.CustomFields;
using Angelic.KeyPairs;
using Newtonsoft.Json;

namespace Angelic.Invoice;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class InvoiceHeader
{
    [JsonProperty("disabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Disabled { get; set; } 

    [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomField>? CustomFields { get; set; } 

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Use { get; set; } 

    [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ClientId { get; set; } 

    [JsonProperty("client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ClientName { get; set; } 

    [JsonProperty("sitenumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sitenumber { get; set; } 

    [JsonProperty("site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SiteName { get; set; } 

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
    public string? TelNumber { get; set; } 

    [JsonProperty("contactname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Contactname { get; set; } 

    [JsonProperty("global_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? GlobalTaxCode { get; set; } 

    [JsonProperty("invoice_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? InvoiceDate { get; set; } 

    [JsonProperty("schedule_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? ScheduleDate { get; set; } 

    [JsonProperty("dateposted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Dateposted { get; set; } 

    [JsonProperty("last_synced", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? LastSynced { get; set; } 

    [JsonProperty("last_modified", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? LastModified { get; set; } 

    [JsonProperty("notes_1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Notes1 { get; set; } 

    [JsonProperty("notes_2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Notes2 { get; set; } 

    [JsonProperty("notes_3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Notes3 { get; set; } 

    [JsonProperty("taken_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TakenBy { get; set; } 

    [JsonProperty("order_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OrderNumber { get; set; } 

    [JsonProperty("cust_order_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CustOrderNumber { get; set; } 

    [JsonProperty("payment_ref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PaymentRef { get; set; } 

    [JsonProperty("global_nom_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? GlobalNomCode { get; set; } 

    [JsonProperty("global_details", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? GlobalDetails { get; set; } 

    [JsonProperty("invoice_type_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? InvoiceTypeCode { get; set; } 

    [JsonProperty("salesorder_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SalesorderId { get; set; } 

    [JsonProperty("datetype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Datetype { get; set; } 

    [JsonProperty("percentold", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Percentold { get; set; } 

    [JsonProperty("percent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Percent { get; set; } 

    [JsonProperty("contract_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ContractId { get; set; } 

    [JsonProperty("contract_ref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ContractRef { get; set; } 

    [JsonProperty("datesent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Datesent { get; set; } 

    [JsonProperty("currency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Currency { get; set; } 

    [JsonProperty("currency_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CurrencyCode { get; set; } 

    [JsonProperty("currency_code_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CurrencyCodeName { get; set; } 

    [JsonProperty("currency_conversion_rate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? CurrencyConversionRate { get; set; } 

    [JsonProperty("paymentterms", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Paymentterms { get; set; } 

    [JsonProperty("hideinvoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Hideinvoice { get; set; } 

    [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TicketId { get; set; } 

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
    public double? AmountRemaining { get; set; } 

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
    public ICollection<InvoiceDetail>? AddLines { get; set; } 

    [JsonProperty("_print_preview", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? PrintPreview { get; set; } 

    [JsonProperty("_print_generate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? PrintGenerate { get; set; } 

    [JsonProperty("printhtml", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Printhtml { get; set; } 

    [JsonProperty("pdf_attachment_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PdfAttachmentId { get; set; } 

    [JsonProperty("pdf_attachment_date_created", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? PdfAttachmentDateCreated { get; set; } 

    [JsonProperty("pdftemplate_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PdftemplateId { get; set; } 

    [JsonProperty("pdftemplate_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PdftemplateName { get; set; } 

    [JsonProperty("composite_tax_total", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? CompositeTaxTotal { get; set; } 

    [JsonProperty("total", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Total { get; set; } 

    [JsonProperty("reference", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Reference { get; set; } 

    [JsonProperty("duedate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Duedate { get; set; } 

    [JsonProperty("_is_invoice_run", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsInvoiceRun { get; set; } 

    [JsonProperty("_billing_cut_off", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? BillingCutOff { get; set; } 

    [JsonProperty("is_recurring_invoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsRecurringInvoice { get; set; } 

    [JsonProperty("schedule_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ScheduleId { get; set; } 

    [JsonProperty("lastcreated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Lastcreated { get; set; } 

    [JsonProperty("nextcreationdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Nextcreationdate { get; set; } 

    [JsonProperty("period", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Period { get; set; } 

    [JsonProperty("schedule", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public StdRequest? Schedule { get; set; } 

    [JsonProperty("create_recurring_invoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CreateRecurringInvoice { get; set; } 

    [JsonProperty("take_auto_payment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? TakeAutoPayment { get; set; } 

    [JsonProperty("recurring_invoice_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RecurringInvoiceId { get; set; } 

    [JsonProperty("add_contract_assets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AddContractAssets { get; set; } 

    [JsonProperty("add_labour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AddLabour { get; set; } 

    [JsonProperty("add_project", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AddProject { get; set; } 

    [JsonProperty("add_travel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AddTravel { get; set; } 

    [JsonProperty("add_mileage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AddMileage { get; set; } 

    [JsonProperty("add_itemsissued", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AddItemsissued { get; set; } 

    [JsonProperty("add_prepay", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AddPrepay { get; set; } 

    [JsonProperty("add_salesorder", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AddSalesorder { get; set; } 

    [JsonProperty("force_creation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ForceCreation { get; set; } 

    [JsonProperty("_create_from_areaitems", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AreaItem>? CreateFromAreaitems { get; set; } 

    [JsonProperty("_create_from_contract", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CreateFromContract { get; set; } 

    [JsonProperty("_validateonly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Validateonly { get; set; } 

    [JsonProperty("qboid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Qboid { get; set; } 

    [JsonProperty("billingcategory", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Billingcategory { get; set; } 

    [JsonProperty("_sendmassinvoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Sendmassinvoice { get; set; } 

    [JsonProperty("xero_tenant_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? XeroTenantId { get; set; } 

    [JsonProperty("xero_branding_theme_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? XeroBrandingThemeId { get; set; } 

    [JsonProperty("xero_branding_theme_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? XeroBrandingThemeName { get; set; } 

    [JsonProperty("xero_branding_theme", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ValueLabelIsNewKeyPair? XeroBrandingTheme { get; set; } 

    [JsonProperty("due_date_int", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DueDateInt { get; set; } 

    [JsonProperty("due_date_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DueDateType { get; set; } 

    [JsonProperty("createdbyagentname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Createdbyagentname { get; set; } 

    [JsonProperty("internal_note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? InternalNote { get; set; } 

    [JsonProperty("mailboxid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Mailboxid { get; set; } 

    [JsonProperty("period_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PeriodType { get; set; } 

    [JsonProperty("kashflow_tenant_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? KashflowTenantId { get; set; } 

    [JsonProperty("kashflowid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Kashflowid { get; set; } 

    [JsonProperty("kashflow_pdf", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? KashflowPdf { get; set; } 

    [JsonProperty("original_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OriginalClientId { get; set; } 

    [JsonProperty("original_client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OriginalClientName { get; set; } 

    [JsonProperty("xero_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? XeroStatus { get; set; } 

    [JsonProperty("merge_data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<InvoiceHeaderMerge>? MergeData { get; set; } 

    [JsonProperty("snelstart_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SnelstartId { get; set; } 

    [JsonProperty("time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Time { get; set; } 

    [JsonProperty("startdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? StartDate { get; set; } 

    [JsonProperty("enddate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? EndDate { get; set; } 

    [JsonProperty("daysplus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Daysplus { get; set; } 

    [JsonProperty("periodname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Periodname { get; set; } 

    [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Isimport { get; set; } 

    [JsonProperty("duedatename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Duedatename { get; set; } 

    [JsonProperty("date_created", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? DateCreated { get; set; } 

    [JsonProperty("invoice_prorata_periods_ahead", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? InvoiceProrataPeriodsAhead { get; set; } 

    [JsonProperty("nextcreationperiod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Nextcreationperiod { get; set; } 

    [JsonProperty("qbo_company_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? QboCompanyId { get; set; } 

    [JsonProperty("intacct_recordno", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? IntacctRecordno { get; set; } 

    [JsonProperty("period_start_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? PeriodStartDate { get; set; } 

    [JsonProperty("period_end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? PeriodEndDate { get; set; } 

    [JsonProperty("payments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<InvoicePaymentList>? Payments { get; set; } 

    [JsonProperty("markaspaid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Markaspaid { get; set; } 

    [JsonProperty("markaspaidmoduleid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Markaspaidmoduleid { get; set; } 

    [JsonProperty("dbc_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DbcId { get; set; } 

    [JsonProperty("dbc_company_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DbcCompanyId { get; set; } 

    [JsonProperty("reviewrequired", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Reviewrequired { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("_xmlwarning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Xmlwarning { get; set; } 

    [JsonProperty("creditlinkedtoinvoiceid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Creditlinkedtoinvoiceid { get; set; } 

    [JsonProperty("creditlinkedtoinvoiceid_thirdpartynumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CreditlinkedtoinvoiceidThirdpartynumber { get; set; } 

    [JsonProperty("creditlinkedtoinvoiceid_typeid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CreditlinkedtoinvoiceidTypeid { get; set; } 

    [JsonProperty("purchaseorder_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PurchaseorderId { get; set; } 

    [JsonProperty("sage_business_cloud_details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SageBusinessCloudDetailsId { get; set; } 

    [JsonProperty("sage_business_cloud_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SageBusinessCloudId { get; set; } 

    [JsonProperty("exact_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ExactId { get; set; } 

    [JsonProperty("exact_division", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ExactDivision { get; set; } 

    [JsonProperty("xero_line_tax", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? XeroLineTax { get; set; } 

    [JsonProperty("invoice_auto_increase_period", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? InvoiceAutoIncreasePeriod { get; set; } 

    [JsonProperty("invoice_percent_increase", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? InvoicePercentIncrease { get; set; } 

    [JsonProperty("schedule_ignore_delete", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ScheduleIgnoreDelete { get; set; } 

    [JsonProperty("assigned_agent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AssignedAgent { get; set; } 

    [JsonProperty("assigned_agent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AssignedAgentName { get; set; } 

    [JsonProperty("approval_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ApprovalStatus { get; set; } 

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
    public string? TicketSummary { get; set; } 

    [JsonProperty("ticket_note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TicketNote { get; set; } 

    [JsonProperty("approval_start", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ApprovalStart { get; set; } 

    [JsonProperty("requires_approval", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? RequiresApproval { get; set; } 

    [JsonProperty("xero_online_invoice_payment_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? XeroOnlineInvoicePaymentUrl { get; set; } 

    [JsonProperty("generic_online_invoice_payment_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? GenericOnlineInvoicePaymentUrl { get; set; } 

    [JsonProperty("intacct_save_location", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? IntacctSaveLocation { get; set; } 

    [JsonProperty("intacctseparatetaxline", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Intacctseparatetaxline { get; set; } 

    [JsonProperty("intacct_class", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? IntacctClass { get; set; } 

    [JsonProperty("intacct_class_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? IntacctClassName { get; set; } 

    [JsonProperty("take_payment_on_duedate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TakePaymentOnDuedate { get; set; } 

    [JsonProperty("contains_calculated_quantity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ContainsCalculatedQuantity { get; set; } 

    [JsonProperty("intacct_tax_solution", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? IntacctTaxSolution { get; set; } 

    [JsonProperty("intacct_tax_solution_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? IntacctTaxSolutionName { get; set; } 

    [JsonProperty("intacct_project", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? IntacctProject { get; set; } 

    [JsonProperty("intacct_project_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? IntacctProjectName { get; set; } 

    [JsonProperty("_create_credit_note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CreateCreditNote { get; set; } 

    [JsonProperty("credit_total", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? CreditTotal { get; set; } 

    [JsonProperty("supplier_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SupplierId { get; set; } 

    [JsonProperty("supplier_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SupplierName { get; set; } 

    [JsonProperty("_dont_fire_automations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DontFireAutomations { get; set; } 

    [JsonProperty("_is_process", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsProcess { get; set; } 

    [JsonProperty("_is_task_schedule", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsTaskSchedule { get; set; } 

    [JsonProperty("payments_pending", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PaymentsPending { get; set; } 

    [JsonProperty("include_in_autopay", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IncludeInAutopay { get; set; } 

    [JsonProperty("_forcethirdpartysync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Forcethirdpartysync { get; set; } 

    [JsonProperty("client_to_invoice_to_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ClientToInvoiceToId { get; set; } 

    [JsonProperty("creation_source", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CreationSource { get; set; } 

    [JsonProperty("typeid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Typeid { get; set; } 

    [JsonProperty("twilio_invoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? TwilioInvoice { get; set; } 

    [JsonProperty("invoice_separately", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? InvoiceSeparately { get; set; } 

    [JsonProperty("minimum_price_active", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? MinimumPriceActive { get; set; } 

    [JsonProperty("minimum_line_description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MinimumLineDescription { get; set; } 

    [JsonProperty("minimum_amount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? MinimumAmount { get; set; } 

    [JsonProperty("avalara_details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AvalaraDetailsId { get; set; } 

    [JsonProperty("qbo_term_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? QboTermName { get; set; } 

    [JsonProperty("qbo_term_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? QboTermId { get; set; } 

    [JsonProperty("qbo_term", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ValueLabelIsNewKeyPair? QboTerm { get; set; } 

    [JsonProperty("exact_payment_conditon_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ExactPaymentConditonName { get; set; } 

    [JsonProperty("exact_payment_conditon_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ExactPaymentConditonId { get; set; } 

    [JsonProperty("exact_payment_conditon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ValueLabelIsNewKeyPair? ExactPaymentConditon { get; set; } 

    [JsonProperty("avalara_details_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AvalaraDetailsName { get; set; } 

    [JsonProperty("voided", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Voided { get; set; } 

    [JsonProperty("credit_outstanding_for_customer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? CreditOutstandingForCustomer { get; set; } 

    [JsonProperty("credit_outstanding", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? CreditOutstanding { get; set; } 

    [JsonProperty("credit_used", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? CreditUsed { get; set; } 

    [JsonProperty("mark_credit_as_used", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? MarkCreditAsUsed { get; set; } 

    [JsonProperty("apply_credit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ApplyCredit { get; set; } 

    [JsonProperty("apply_credit_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ApplyCreditId { get; set; } 

    [JsonProperty("apply_credit_amount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? ApplyCreditAmount { get; set; } 

    [JsonProperty("apply_credit_description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ApplyCreditDescription { get; set; } 

    [JsonProperty("apply_credit_long_description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ApplyCreditLongDescription { get; set; } 

    [JsonProperty("apply_credit_tax_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ApplyCreditTaxType { get; set; } 

    [JsonProperty("invoice_display", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? InvoiceDisplay { get; set; } 

    [JsonProperty("_novalidate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Novalidate { get; set; } 

    [JsonProperty("sqlimport_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SqlimportId { get; set; } 

    [JsonProperty("invoice_match_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? InvoiceMatchId { get; set; } 

    [JsonProperty("sync_include_paid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? SyncIncludePaid { get; set; } 

    [JsonProperty("dont_set_original_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DontSetOriginalClientId { get; set; } 

    [JsonProperty("_docommitsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Docommitsync { get; set; } 

    [JsonProperty("_ignore_dont_send_invoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IgnoreDontSendInvoice { get; set; } 

    [JsonProperty("ticket_client_to_invoice_to_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TicketClientToInvoiceToId { get; set; } 

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
    public int? MostRecentInvoiceId { get; set; } 

    [JsonProperty("most_recent_invoice_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MostRecentInvoiceType { get; set; } 

    [JsonProperty("custombuttons", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomButton>? Custombuttons { get; set; } 

    [JsonProperty("extratabs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Tabname>? Extratabs { get; set; } 

    [JsonProperty("update_invoice_conversion_rate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? UpdateInvoiceConversionRate { get; set; } 

    [JsonProperty("conversion_rate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? ConversionRate { get; set; } 

    [JsonProperty("dont_sync_to_3rd_party", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DontSyncTo3RdParty { get; set; } 

    [JsonProperty("is_invoice_screen", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsInvoiceScreen { get; set; } 

    [JsonProperty("_dotaxsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Dotaxsync { get; set; } 

    [JsonProperty("tax_total", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TaxTotal { get; set; } 

    [JsonProperty("revenue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Revenue { get; set; } 

    [JsonProperty("external_links", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ExternalLinkList>? ExternalLinks { get; set; } 

    [JsonProperty("_importtypeid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ImportTypeId { get; set; } 

    [JsonProperty("_importthirdpartyid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Importthirdpartyid { get; set; } 

    [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ImportType { get; set; } 

    [JsonProperty("new_external_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ExternalLinkList? NewExternalLink { get; set; } 

}