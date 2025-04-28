using System.CodeDom.Compiler;
using Angelic.Models.Assets;
using Angelic.Models.Attachments;
using Angelic.Models.Configuration.Billing.ChargeRates;
using Angelic.Models.Configuration.Billing.Prepay;
using Angelic.Models.Configuration.Custom;
using Angelic.Models.Configuration.Custom.CustomFields;
using Angelic.Models.Configuration.Tickets.TicketTypes;
using Angelic.Models.Sites;
using Angelic.Models.Users;
using Newtonsoft.Json;

namespace Angelic.Models.Contracts;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ContractHeader
{
    [JsonProperty("contract_contact_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ContractContactId { get; set; } 

    [JsonProperty("item_desc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ItemDesc { get; set; } 

    [JsonProperty("main_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MainSite { get; set; } 

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ClientId { get; set; } 

    [JsonProperty("client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ClientName { get; set; } 

    [JsonProperty("ref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Ref { get; set; } 

    [JsonProperty("refextra", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Refextra { get; set; } 

    [JsonProperty("start_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? StartDate { get; set; } 

    [JsonProperty("end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? EndDate { get; set; } 

    [JsonProperty("started", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Started { get; set; } 

    [JsonProperty("expired", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Expired { get; set; } 

    [JsonProperty("numberofunitsfree", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Numberofunitsfree { get; set; } 

    [JsonProperty("billingperiod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? BillingPeriod { get; set; } 

    [JsonProperty("billingdescription", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Billingdescription { get; set; } 

    [JsonProperty("subtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Subtype { get; set; } 

    [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Status { get; set; } 

    [JsonProperty("site_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SiteId { get; set; } 

    [JsonProperty("site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SiteName { get; set; } 

    [JsonProperty("user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? UserId { get; set; } 

    [JsonProperty("user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? UserName { get; set; } 

    [JsonProperty("sla_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SlaId { get; set; } 

    [JsonProperty("periodicinvoicenextdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Periodicinvoicenextdate { get; set; } 

    [JsonProperty("next_invoice_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? NextInvoiceDate { get; set; } 

    [JsonProperty("periodchargeamount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Periodchargeamount { get; set; } 

    [JsonProperty("note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Note { get; set; } 

    [JsonProperty("asset_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? AssetValue { get; set; } 

    [JsonProperty("refextra2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Refextra2 { get; set; } 

    [JsonProperty("contract_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ContractStatus { get; set; } 

    [JsonProperty("asset_sequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AssetSequence { get; set; } 

    [JsonProperty("next_call_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? NextCallDate { get; set; } 

    [JsonProperty("accounts_override_mailbox", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AccountsOverrideMailbox { get; set; } 

    [JsonProperty("sla_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SlaName { get; set; } 

    [JsonProperty("startbalance", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Startbalance { get; set; } 

    [JsonProperty("paymentscheme", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Paymentscheme { get; set; } 

    [JsonProperty("chargehoursperperiod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Chargehoursperperiod { get; set; } 

    [JsonProperty("chargerollover", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Chargerollover { get; set; } 

    [JsonProperty("outofhoursmultiplier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Outofhoursmultiplier { get; set; } 

    [JsonProperty("requestminimum", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Requestminimum { get; set; } 

    [JsonProperty("invoiceminimum", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Invoiceminimum { get; set; } 

    [JsonProperty("allowfixedprice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Allowfixedprice { get; set; } 

    [JsonProperty("allowpyg", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Allowpyg { get; set; } 

    [JsonProperty("allowprepay", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Allowprepay { get; set; } 

    [JsonProperty("chargeperdevice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Chargeperdevice { get; set; } 

    [JsonProperty("prepayrecurringcharge", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Prepayrecurringcharge { get; set; } 

    [JsonProperty("chargeprepaytravel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Chargeprepaytravel { get; set; } 

    [JsonProperty("chargeprepaymileage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Chargeprepaymileage { get; set; } 

    [JsonProperty("chargepygtravel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Chargepygtravel { get; set; } 

    [JsonProperty("chargepygmileage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Chargepygmileage { get; set; } 

    [JsonProperty("onlybillatendofperiod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Onlybillatendofperiod { get; set; } 

    [JsonProperty("unmatchedcombinations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Unmatchedcombinations { get; set; } 

    [JsonProperty("termmonths", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Termmonths { get; set; } 

    [JsonProperty("percentageincrease", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Percentageincrease { get; set; } 

    [JsonProperty("nextincrementdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Nextincrementdate { get; set; } 

    [JsonProperty("datereceived", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Datereceived { get; set; } 

    [JsonProperty("invoicedescription", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Invoicedescription { get; set; } 

    [JsonProperty("datesent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Datesent { get; set; } 

    [JsonProperty("paymentmethod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Paymentmethod { get; set; } 

    [JsonProperty("dontsendalarm", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Dontsendalarm { get; set; } 

    [JsonProperty("createdfrom_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CreatedfromId { get; set; } 

    [JsonProperty("costperperiod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Costperperiod { get; set; } 

    [JsonProperty("rollingcontract", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Rollingcontract { get; set; } 

    [JsonProperty("previouscontract", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Previouscontract { get; set; } 

    [JsonProperty("dontinvoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Dontinvoice { get; set; } 

    [JsonProperty("ohid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Ohid { get; set; } 

    [JsonProperty("emailaddresses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EmailAddresses { get; set; } 

    [JsonProperty("scheduleemails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Scheduleemails { get; set; } 

    [JsonProperty("schedulesendaccountmanager", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Schedulesendaccountmanager { get; set; } 

    [JsonProperty("accountsdesc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Accountsdesc { get; set; } 

    [JsonProperty("hasactions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Hasactions { get; set; } 

    [JsonProperty("billingperiods", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? BillingPeriods { get; set; } 

    [JsonProperty("assets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<DeviceList>? Assets { get; set; } 

    [JsonProperty("users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<UsersList>? Users { get; set; } 

    [JsonProperty("periods", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ContractPeriod>? Periods { get; set; } 

    [JsonProperty("surchargeid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Surchargeid { get; set; } 

    [JsonProperty("chargerate_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ChargeRateMethod { get; set; } 

    [JsonProperty("overriding_rates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ChargeRate>? OverridingRates { get; set; } 

    [JsonProperty("chargerates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Lookup>? ChargeRates { get; set; } 

    [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Isimport { get; set; } 

    [JsonProperty("_ignore_mandatory", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IgnoreMandatory { get; set; } 

    [JsonProperty("billing_description_string", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? BillingDescriptionString { get; set; } 

    [JsonProperty("billing_period_string", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? BillingPeriodString { get; set; } 

    [JsonProperty("dontchargeforitems", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Dontchargeforitems { get; set; } 

    [JsonProperty("custombuttons", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomButton>? Custombuttons { get; set; } 

    [JsonProperty("_print_preview", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? PrintPreview { get; set; } 

    [JsonProperty("_print_generate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? PrintGenerate { get; set; } 

    [JsonProperty("printhtml", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Printhtml { get; set; } 

    [JsonProperty("pdf_attachment_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PdfAttachmentId { get; set; } 

    [JsonProperty("pdftemplate_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PdfTemplateId { get; set; } 

    [JsonProperty("pdftemplate_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PdfTemplateName { get; set; } 

    [JsonProperty("schedule", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ContractSchedule>? Schedule { get; set; } 

    [JsonProperty("scheduleplan", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ContractSchedulePlan>? Scheduleplan { get; set; } 

    [JsonProperty("_send_outstanding_emails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? SendOutstandingEmails { get; set; } 

    [JsonProperty("_send_appointment_invites", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? SendAppointmentInvites { get; set; } 

    [JsonProperty("autotaskid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Autotaskid { get; set; } 

    [JsonProperty("import_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ImportUser { get; set; } 

    [JsonProperty("salesorder_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SalesOrderId { get; set; } 

    [JsonProperty("salesorder_line_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SalesOrderLineId { get; set; } 

    [JsonProperty("endtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Endtype { get; set; } 

    [JsonProperty("new_invoice_start_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? NewInvoiceStartDate { get; set; } 

    [JsonProperty("new_invoice_end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? NewInvoiceEndDate { get; set; } 

    [JsonProperty("chargeratemultiplier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? ChargeRatemultiplier { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("contract_prepaytotal", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? ContractPrepaytotal { get; set; } 

    [JsonProperty("contract_prepayused", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? ContractPrepayused { get; set; } 

    [JsonProperty("contract_prepaybalance", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? ContractPrepaybalance { get; set; } 

    [JsonProperty("contract_prepayhistory", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<PrepayHistory>? ContractPrepayhistory { get; set; } 

    [JsonProperty("contract_periods", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<PrepayPeriod>? ContractPeriods { get; set; } 

    [JsonProperty("contract_prepayasamount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ContractPrepayasamount { get; set; } 

    [JsonProperty("prepay_periods", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<PrepayPeriod>? PrepayPeriods { get; set; } 

    [JsonProperty("prepayrecurringchargenextdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Prepayrecurringchargenextdate { get; set; } 

    [JsonProperty("prepayrecurringhours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Prepayrecurringhours { get; set; } 

    [JsonProperty("billforrecurringprepayamount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Billforrecurringprepayamount { get; set; } 

    [JsonProperty("prepayrecurringminimumdeduction", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Prepayrecurringminimumdeduction { get; set; } 

    [JsonProperty("prepayrecurringminimumdeductiononlyactive", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Prepayrecurringminimumdeductiononlyactive { get; set; } 

    [JsonProperty("prepayrecurringautomaticdeduction", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Prepayrecurringautomaticdeduction { get; set; } 

    [JsonProperty("iscontractdetails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Iscontractdetails { get; set; } 

    [JsonProperty("labournominalcodeoverride", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Labournominalcodeoverride { get; set; } 

    [JsonProperty("labournominalcodeoverride_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? LabournominalcodeoverrideName { get; set; } 

    [JsonProperty("prepayrecurringexpirymonths", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Prepayrecurringexpirymonths { get; set; } 

    [JsonProperty("contracts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ContractHeaderContract>? Contracts { get; set; } 

    [JsonProperty("sites", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<SiteList>? Sites { get; set; } 

    [JsonProperty("emailaddress_to", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EmailAddressTo { get; set; } 

    [JsonProperty("emailaddress_cc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EmailAddressCc { get; set; } 

    [JsonProperty("use_cost_calculation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? UseCostCalculation { get; set; } 

    [JsonProperty("attachments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AttachmentList>? Attachments { get; set; } 

    [JsonProperty("billingplans", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ContractDetail>? Billingplans { get; set; } 

    [JsonProperty("send_to_oracle", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? SendToOracle { get; set; } 

    [JsonProperty("oracle_invoice_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OracleInvoiceId { get; set; } 

    [JsonProperty("datesent_to_oracle", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? DatesentToOracle { get; set; } 

    [JsonProperty("prepay_itemid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PrepayItemid { get; set; } 

    [JsonProperty("prepay_itemname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PrepayItemname { get; set; } 

    [JsonProperty("created_from_order", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CreatedFromOrder { get; set; } 

    [JsonProperty("autotopupthreshhold", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Autotopupthreshhold { get; set; } 

    [JsonProperty("autotopuptoamount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Autotopuptoamount { get; set; } 

    [JsonProperty("autotopupcostperhour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Autotopupcostperhour { get; set; } 

    [JsonProperty("autotopupbyamount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Autotopupbyamount { get; set; } 

    [JsonProperty("extratabs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Tabname>? Extratabs { get; set; } 

    [JsonProperty("approvername", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Approvername { get; set; } 

    [JsonProperty("approveremailaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Approveremailaddress { get; set; } 

    [JsonProperty("signature", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Signature { get; set; } 

    [JsonProperty("can_approve", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CanApprove { get; set; } 

    [JsonProperty("portal_display_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PortalDisplayType { get; set; } 

    [JsonProperty("contractapprovalfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<TicketTypeField>? Contractapprovalfields { get; set; } 

    [JsonProperty("use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Use { get; set; } 

    [JsonProperty("key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Key { get; set; } 

    [JsonProperty("table", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public TableEnum? Table { get; set; } 

    [JsonProperty("last_modified", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? LastModified { get; set; } 

    [JsonProperty("asset_end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? AssetEndDate { get; set; } 

    [JsonProperty("contracttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ContractType { get; set; } 

    [JsonProperty("contracttype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ContractTypeName { get; set; } 

    [JsonProperty("prepayrecurringchargebp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Prepayrecurringchargebp { get; set; } 

    [JsonProperty("force_recalculation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ForceRecalculation { get; set; } 

    [JsonProperty("cost_calculation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CostCalculation { get; set; } 

    [JsonProperty("active", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Active { get; set; } 

    [JsonProperty("sent_to_oracle", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? SentToOracle { get; set; } 

    [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomField>? CustomFields { get; set; } 

    [JsonProperty("createdby_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CreatedbyId { get; set; } 

    [JsonProperty("createdby_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CreatedbyName { get; set; } 

    [JsonProperty("billingcategory", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Billingcategory { get; set; } 

    [JsonProperty("_importtypeid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ImportTypeId { get; set; } 

    [JsonProperty("_importthirdpartyid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Importthirdpartyid { get; set; } 

    [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ImportType { get; set; } 

    [JsonProperty("new_external_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ExternalLinkList? NewExternalLink { get; set; } 

}