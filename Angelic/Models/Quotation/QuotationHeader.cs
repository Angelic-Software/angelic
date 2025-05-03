using System.CodeDom.Compiler;
using Angelic.Models.Attachments;
using Angelic.Models.Configuration;
using Angelic.Models.Configuration.Addresses;
using Angelic.Models.Configuration.Approval;
using Angelic.Models.Configuration.Approval.Cab;
using Angelic.Models.Configuration.Billing;
using Angelic.Models.Configuration.Custom;
using Angelic.Models.Configuration.Custom.CustomFields;
using Angelic.Models.Configuration.PdfTemplates;
using Angelic.Models.Configuration.Tickets.TicketTypes;
using Angelic.Models.Configuration.Tickets.Workflows;
using Angelic.Models.SalesOrders;
using Angelic.Models.Sites;
using Angelic.Models.Users;
using Newtonsoft.Json;

namespace Angelic.Models.Quotation;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class QuotationHeader
{
    [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomField>? CustomFields { get; set; } 

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Use { get; set; } 

    [JsonProperty("table", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public TableEnum? Table { get; set; } 

    [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Title { get; set; } 

    [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TicketId { get; set; } 

    [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Status { get; set; } 

    [JsonProperty("po_ref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PoRef { get; set; } 

    [JsonProperty("date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Date { get; set; } 

    [JsonProperty("expiry_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? ExpiryDate { get; set; } 

    [JsonProperty("revenue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Revenue { get; set; } 

    [JsonProperty("tax_total", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TaxTotal { get; set; } 

    [JsonProperty("total", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Total { get; set; } 

    [JsonProperty("carriage_desc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CarriageDesc { get; set; } 

    [JsonProperty("carriage_price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? CarriagePrice { get; set; } 

    [JsonProperty("tax_total_estimate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TaxTotalEstimate { get; set; } 

    [JsonProperty("auth_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AuthBy { get; set; } 

    [JsonProperty("note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Note { get; set; } 

    [JsonProperty("user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Users.User? User { get; set; } 

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

    [JsonProperty("scope", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Scope { get; set; } 

    [JsonProperty("risk", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Risk { get; set; } 

    [JsonProperty("qr2filename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Qr2Filename { get; set; } 

    [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AgentId { get; set; } 

    [JsonProperty("assigned_agent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AssignedAgent { get; set; } 

    [JsonProperty("assigned_agent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AssignedAgentName { get; set; } 

    [JsonProperty("includegroupeditemprice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IncludeGroupeditemprice { get; set; } 

    [JsonProperty("includegroupeditemqty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IncludeGroupeditemqty { get; set; } 

    [JsonProperty("daystodeliver", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Daystodeliver { get; set; } 

    [JsonProperty("currency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Currency { get; set; } 

    [JsonProperty("currency_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CurrencyCode { get; set; } 

    [JsonProperty("currency_code_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CurrencyCodeName { get; set; } 

    [JsonProperty("currency_conversion_rate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? CurrencyConversionRate { get; set; } 

    [JsonProperty("includequotationlinenotes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IncludeQuotationlinenotes { get; set; } 

    [JsonProperty("includegrouppriceandqty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IncludeGrouppriceandqty { get; set; } 

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
    public bool? ValidateOnly { get; set; } 

    [JsonProperty("_print_preview", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? PrintPreview { get; set; } 

    [JsonProperty("_print_generate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? PrintGenerate { get; set; } 

    [JsonProperty("printhtml", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PrintHtml { get; set; } 

    [JsonProperty("pdf_attachment_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PdfAttachmentId { get; set; } 

    [JsonProperty("ponumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Ponumber { get; set; } 

    [JsonProperty("pdftemplate_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PdfTemplateId { get; set; } 

    [JsonProperty("pdftemplate_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PdfTemplateName { get; set; } 

    [JsonProperty("portal_display_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PortalDisplayType { get; set; } 

    [JsonProperty("_create_so", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CreateSo { get; set; } 

    [JsonProperty("salesorder_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SalesOrderId { get; set; } 

    [JsonProperty("salesorder", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public SalesOrder? SalesOrder { get; set; } 

    [JsonProperty("signature", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Signature { get; set; } 

    [JsonProperty("createdbyagentname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CreatedByAgentname { get; set; } 

    [JsonProperty("quote_viewed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? QuoteViewed { get; set; } 

    [JsonProperty("canned_text_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CannedTextId { get; set; } 

    [JsonProperty("canned_text_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CannedTextName { get; set; } 

    [JsonProperty("canned_text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CannedText { get; set; } 

    [JsonProperty("last_update_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? LastUpdateTime { get; set; } 

    [JsonProperty("images", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AttachmentList>? Images { get; set; } 

    [JsonProperty("internal_approval_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? InternalApprovalStatus { get; set; } 

    [JsonProperty("approval_start", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ApprovalStart { get; set; } 

    [JsonProperty("internal_approvalagent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? InternalApprovalagent { get; set; } 

    [JsonProperty("internal_approvalemailaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? InternalApprovalemailaddress { get; set; } 

    [JsonProperty("internal_approvalnote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? InternalApprovalnote { get; set; } 

    [JsonProperty("internal_approvalagentid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? InternalApprovalagentid { get; set; } 

    [JsonProperty("internal_approvaldatetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? InternalApprovaldatetime { get; set; } 

    [JsonProperty("requires_approval", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? RequiresApproval { get; set; } 

    [JsonProperty("ticket_summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TicketSummary { get; set; } 

    [JsonProperty("ticket_note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TicketNote { get; set; } 

    [JsonProperty("new_ticket_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? NewTicketStatus { get; set; } 

    [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsImport { get; set; } 

    [JsonProperty("datto_commerce_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DattoCommerceId { get; set; } 

    [JsonProperty("datto_commerce_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DattoCommerceUrl { get; set; } 

    [JsonProperty("third_party_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ThirdPartyUrl { get; set; } 

    [JsonProperty("dattocommerce_clientid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DattoCommerceClientId { get; set; } 

    [JsonProperty("dattocommerce_contactname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DattoCommerceContactName { get; set; } 

    [JsonProperty("dattocommerce_contactemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DattoCommerceContactemail { get; set; } 

    [JsonProperty("deliveryamount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Deliveryamount { get; set; } 

    [JsonProperty("dattocommerce_tenantid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DattoCommerceTenantId { get; set; } 

    [JsonProperty("deliverytax", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Deliverytax { get; set; } 

    [JsonProperty("dontupdateporef", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DontUpdateporef { get; set; } 

    [JsonProperty("can_approve", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CanApprove { get; set; } 

    [JsonProperty("linked_pdf_list_append", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<QuotationHeaderPdf>? LinkedPdfListAppend { get; set; } 

    [JsonProperty("linked_pdf_list_prepend", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<QuotationHeaderPdf>? LinkedPdfListPrepend { get; set; } 

    [JsonProperty("automatic_sales_tax", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AutomaticSalesTax { get; set; } 

    [JsonProperty("contactuser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Contactuser { get; set; } 

    [JsonProperty("contactusername", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Contactusername { get; set; } 

    [JsonProperty("_match_thirdparty_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MatchThirdPartyId { get; set; } 

    [JsonProperty("_match_integration_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MatchIntegrationId { get; set; } 

    [JsonProperty("_match_integration_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MatchIntegrationName { get; set; } 

    [JsonProperty("third_party_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ThirdPartyNumber { get; set; } 

    [JsonProperty("intacct_class", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? IntacctClass { get; set; } 

    [JsonProperty("intacct_class_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? IntacctClassName { get; set; } 

    [JsonProperty("intacct_save_location", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? IntacctSaveLocation { get; set; } 

    [JsonProperty("is_leased", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsLeased { get; set; } 

    [JsonProperty("term_limit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TermLimit { get; set; } 

    [JsonProperty("margin", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Margin { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("billingcontactname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? BillingContactName { get; set; } 

    [JsonProperty("billingcontactemailaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? BillingContactemailaddress { get; set; } 

    [JsonProperty("billingcontactphonenumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? BillingContactphonenumber { get; set; } 

    [JsonProperty("so_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SoNumber { get; set; } 

    [JsonProperty("use_ticket_approval", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? UseTicketApproval { get; set; } 

    [JsonProperty("approval_process_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ApprovalProcessId { get; set; } 

    [JsonProperty("new_approvalprocess_agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? NewApprovalProcessAgentId { get; set; } 

    [JsonProperty("new_approvalprocess_user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? NewApprovalProcessUserId { get; set; } 

    [JsonProperty("new_approvalprocess_users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<UsersList>? NewApprovalProcessUsers { get; set; } 

    [JsonProperty("new_approvalprocess_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewApprovalProcessEmail { get; set; } 

    [JsonProperty("new_approvalprocess_cab_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? NewApprovalProcessCabId { get; set; } 

    [JsonProperty("new_approvalprocess_cab", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CabMember>? NewApprovalProcessCab { get; set; } 

    [JsonProperty("site_delivery_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SiteDeliveryOverride { get; set; } 

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
    public AddressStore? DeliveryAddress { get; set; } 

    [JsonProperty("workflow_history", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<WorkflowHistory>? WorkflowHistory { get; set; } 

    [JsonProperty("workflow_step", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? WorkflowStep { get; set; } 

    [JsonProperty("workflow_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? WorkflowId { get; set; } 

    [JsonProperty("_isclone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsClone { get; set; } 

    [JsonProperty("_revision_from_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RevisionFromId { get; set; } 

    [JsonProperty("_originalid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Originalid { get; set; } 

    [JsonProperty("_customisepdf", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Customisepdf { get; set; } 

    [JsonProperty("is_customised_pdf", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsCustomisedPdf { get; set; } 

    [JsonProperty("customisedpdf", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public PdfTemplate? Customisedpdf { get; set; } 

    [JsonProperty("new_approvalprocess_role_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? NewApprovalProcessRoleId { get; set; } 

    [JsonProperty("is_quote_screen", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsQuoteScreen { get; set; } 

    [JsonProperty("_novalidate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Novalidate { get; set; } 

    [JsonProperty("avalara_details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AvalaraDetailsId { get; set; } 

    [JsonProperty("adobe_details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AdobeDetailsId { get; set; } 

    [JsonProperty("avalara_details_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AvalaraDetailsName { get; set; } 

    [JsonProperty("_startthirdpartysign", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Startthirdpartysign { get; set; } 

    [JsonProperty("_hasadobesignopen", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Hasadobesignopen { get; set; } 

    [JsonProperty("user_approval_unavailable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? UserApprovalUnavailable { get; set; } 

    [JsonProperty("top_level_purchase_currency_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TopLevelPurchaseCurrencyCode { get; set; } 

    [JsonProperty("tree_purchase_currency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Currency? TreePurchaseCurrency { get; set; } 

    [JsonProperty("_updatepurchasecurrency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Updatepurchasecurrency { get; set; } 

    [JsonProperty("_remove_zero_quantity_lines", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? RemoveZeroQuantityLines { get; set; } 

    [JsonProperty("site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Site? Site { get; set; } 

    [JsonProperty("originaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public AddressStore? OriginAddress { get; set; } 

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

    [JsonProperty("original_revised_from_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OriginalRevisedFromId { get; set; } 

    [JsonProperty("quoteapprovalfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<TicketTypeField>? Quoteapprovalfields { get; set; } 

    [JsonProperty("custombuttons", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomButton>? CustomButtons { get; set; } 

    [JsonProperty("extratabs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<TabName>? ExtraTabs { get; set; } 

    [JsonProperty("status_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? StatusName { get; set; } 

    [JsonProperty("_dotaxsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DoTaxSync { get; set; } 

    [JsonProperty("external_links", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ExternalLinkList>? ExternalLinks { get; set; } 

    [JsonProperty("_importtypeid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ImportTypeId { get; set; } 

    [JsonProperty("_importthirdpartyid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ImportThirdPartyId { get; set; } 

    [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ImportType { get; set; } 

    [JsonProperty("new_external_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ExternalLinkList? NewExternalLink { get; set; } 

}