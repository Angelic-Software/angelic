using System.CodeDom.Compiler;
using Angelic.Models.Configuration;
using Angelic.Models.Configuration.Addresses;
using Angelic.Models.Configuration.Custom;
using Angelic.Models.Configuration.Custom.CustomFields;
using Angelic.Models.ExternalLinks;
using Newtonsoft.Json;

namespace Angelic.Models.SalesOrders;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class SalesOrder
{
    [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomField>? CustomFields { get; set; } 

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Use { get; set; } 

    [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Title { get; set; } 

    [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TicketId { get; set; } 

    [JsonProperty("user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? UserId { get; set; } 

    [JsonProperty("user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? UserName { get; set; } 

    [JsonProperty("site_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SiteId { get; set; } 

    [JsonProperty("site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SiteName { get; set; } 

    [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ClientId { get; set; } 

    [JsonProperty("client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ClientName { get; set; } 

    [JsonProperty("client_to_invoice_to_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ClientToInvoiceToId { get; set; } 

    [JsonProperty("assigned_agent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AssignedAgent { get; set; } 

    [JsonProperty("assigned_agent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AssignedAgentName { get; set; } 

    [JsonProperty("open_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OpenStatus { get; set; } 

    [JsonProperty("date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Date { get; set; } 

    [JsonProperty("ship_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? ShipDate { get; set; } 

    [JsonProperty("total", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Total { get; set; } 

    [JsonProperty("cost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Cost { get; set; } 

    [JsonProperty("profit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Profit { get; set; } 

    [JsonProperty("note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Note { get; set; } 

    [JsonProperty("po_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PoNumber { get; set; } 

    [JsonProperty("createdby_agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CreatedByAgentId { get; set; } 

    [JsonProperty("deliverby", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Deliverby { get; set; } 

    [JsonProperty("summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Summary { get; set; } 

    [JsonProperty("datereceived", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? DateReceived { get; set; } 

    [JsonProperty("numberbottles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Numberbottles { get; set; } 

    [JsonProperty("ship_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ShipStatus { get; set; } 

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
    public DateTimeOffset? InvoiceDate { get; set; } 

    [JsonProperty("invoicenumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? InvoiceNumber { get; set; } 

    [JsonProperty("includegroupeditemprice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IncludeGroupeditemprice { get; set; } 

    [JsonProperty("includegroupeditemqty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IncludeGroupeditemqty { get; set; } 

    [JsonProperty("currency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Currency { get; set; } 

    [JsonProperty("currency_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CurrencyCode { get; set; } 

    [JsonProperty("currency_code_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CurrencyCodeName { get; set; } 

    [JsonProperty("currency_conversion_rate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? CurrencyConversionRate { get; set; } 

    [JsonProperty("quotation_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? QuotationId { get; set; } 

    [JsonProperty("consignment_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ConsignmentId { get; set; } 

    [JsonProperty("do_not_invoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DoNotInvoice { get; set; } 

    [JsonProperty("closeandconsignwhenpoprocessed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Closeandconsignwhenpoprocessed { get; set; } 

    [JsonProperty("lines", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<SalesOrderLine>? Lines { get; set; } 

    [JsonProperty("add_lines", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<SalesOrderLine>? AddLines { get; set; } 

    [JsonProperty("_cancel_reserve", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CancelReserve { get; set; } 

    [JsonProperty("_validateonly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ValidateOnly { get; set; } 

    [JsonProperty("_print_preview", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? PrintPreview { get; set; } 

    [JsonProperty("_print_generate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? PrintGenerate { get; set; } 

    [JsonProperty("printhtml", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PrintHtml { get; set; } 

    [JsonProperty("pdf_attachment_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PdfAttachmentId { get; set; } 

    [JsonProperty("pdftemplate_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PdfTemplateId { get; set; } 

    [JsonProperty("pdftemplate_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PdfTemplateName { get; set; } 

    [JsonProperty("purchaseorder_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PurchaseOrderCount { get; set; } 

    [JsonProperty("invoice_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? InvoiceCount { get; set; } 

    [JsonProperty("percentage_invoiced", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? PercentageInvoiced { get; set; } 

    [JsonProperty("outstanding_total", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? OutstandingTotal { get; set; } 

    [JsonProperty("_create_po", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CreatePo { get; set; } 

    [JsonProperty("_create_invoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CreateInvoice { get; set; } 

    [JsonProperty("_create_invoice_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CreateInvoiceMethod { get; set; } 

    [JsonProperty("_create_invoice_percentage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? CreateInvoicePercentage { get; set; } 

    [JsonProperty("_create_invoice_amount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? CreateInvoiceAmount { get; set; } 

    [JsonProperty("_create_invoice_qty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? CreateInvoiceQty { get; set; } 

    [JsonProperty("_create_invoice_lines", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<SalesOrderLine>? CreateInvoiceLines { get; set; } 

    [JsonProperty("_create_invoice_line_description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CreateInvoiceLineDescription { get; set; } 

    [JsonProperty("_create_invoice_invoice_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? CreateInvoiceInvoiceDate { get; set; } 

    [JsonProperty("_return_invoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ReturnInvoice { get; set; } 

    [JsonProperty("createdbyagentname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CreatedByAgentname { get; set; } 

    [JsonProperty("last_update_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? LastUpdateTime { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("_distributorMessage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DistributorMessage { get; set; } 

    [JsonProperty("project_faultid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ProjectFaultId { get; set; } 

    [JsonProperty("order_project_template_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OrderProjectTemplateId { get; set; } 

    [JsonProperty("order_project_template_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OrderProjectTemplateName { get; set; } 

    [JsonProperty("_iscopy", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsCopy { get; set; } 

    [JsonProperty("includegrouppriceandqty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IncludeGrouppriceandqty { get; set; } 

    [JsonProperty("costperweight", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? CostPerWeight { get; set; } 

    [JsonProperty("showpercentageinvoiced", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowPercentageinvoiced { get; set; } 

    [JsonProperty("linked_to_opportunity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? LinkedToOpportunity { get; set; } 

    [JsonProperty("linked_to_ticket", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? LinkedToTicket { get; set; } 

    [JsonProperty("linked_to_project", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? LinkedToProject { get; set; } 

    [JsonProperty("intacct_class", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? IntacctClass { get; set; } 

    [JsonProperty("intacct_class_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? IntacctClassName { get; set; } 

    [JsonProperty("intacct_save_location", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? IntacctSaveLocation { get; set; } 

    [JsonProperty("override_delivery_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? OverrideDeliveryAddress { get; set; } 

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
    public Address? DeliveryAddress { get; set; } 

    [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsImport { get; set; } 

    [JsonProperty("_match_thirdparty_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MatchThirdPartyId { get; set; } 

    [JsonProperty("_match_integration_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MatchIntegrationId { get; set; } 

    [JsonProperty("_match_integration_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MatchIntegrationName { get; set; } 

    [JsonProperty("dattocommerce_clientid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DattoCommerceClientId { get; set; } 

    [JsonProperty("dattocommerce_contactname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DattoCommerceContactName { get; set; } 

    [JsonProperty("dattocommerce_contactemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DattoCommerceContactemail { get; set; } 

    [JsonProperty("deliveryamount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Deliveryamount { get; set; } 

    [JsonProperty("deliverytax", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Deliverytax { get; set; } 

    [JsonProperty("is_so_screen", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsSoScreen { get; set; } 

    [JsonProperty("_novalidate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Novalidate { get; set; } 

    [JsonProperty("avalara_details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AvalaraDetailsId { get; set; } 

    [JsonProperty("avalara_details_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AvalaraDetailsName { get; set; } 

    [JsonProperty("originaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Address? OriginAddress { get; set; } 

    [JsonProperty("originaddress1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OriginAddress1 { get; set; } 

    [JsonProperty("originaddress2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OriginAddress2 { get; set; } 

    [JsonProperty("originaddress3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OriginAddress3 { get; set; } 

    [JsonProperty("originaddress4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OriginAddress4 { get; set; } 

    [JsonProperty("originaddress5", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OriginAddress5 { get; set; } 

    [JsonProperty("custombuttons", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomButton>? CustomButtons { get; set; } 

    [JsonProperty("extratabs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Tabs>? ExtraTabs { get; set; } 

    [JsonProperty("_dotaxsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DoTaxSync { get; set; } 

    [JsonProperty("tax_total", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TaxTotal { get; set; } 

    [JsonProperty("revenue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Revenue { get; set; } 

    [JsonProperty("external_links", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ExternalLink>? ExternalLinks { get; set; } 

    [JsonProperty("_importtypeid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ImportTypeId { get; set; } 

    [JsonProperty("_importthirdpartyid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ImportThirdPartyId { get; set; } 

    [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ImportType { get; set; } 

    [JsonProperty("new_external_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ExternalLink? NewExternalLink { get; set; } 

}