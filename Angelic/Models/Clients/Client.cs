using System.ComponentModel.DataAnnotations;
using Angelic.Models.Attachments;
using Angelic.Models.Configuration;
using Angelic.Models.Configuration.Addresses;
using Angelic.Models.Configuration.Billing.ChargeRates;
using Angelic.Models.Configuration.Billing.Prepay;
using Angelic.Models.Configuration.Custom;
using Angelic.Models.Configuration.Custom.CustomFields;
using Angelic.Models.Configuration.Integrations;
using Angelic.Models.Configuration.Integrations.Microsoft.Csp;
using Angelic.Models.Configuration.Integrations.Quickbooks;
using Angelic.Models.Configuration.Integrations.Snow;
using Angelic.Models.Configuration.Integrations.Stripe;
using Angelic.Models.Configuration.SelfServicePortal;
using Angelic.Models.Configuration.Tickets.TicketTypes;
using Angelic.Models.Contracts;
using Angelic.Models.CrmNotes;
using Angelic.Models.ExternalLinks;
using Angelic.Models.KeyPairs;
using Angelic.Models.KnowledgeBase;
using Angelic.Models.Sites;
using Newtonsoft.Json;

namespace Angelic.Models.Clients;

public class Client
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; }

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; }

    [JsonProperty("toplevel_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TopLevelId { get; set; }

    [JsonProperty("toplevel_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TopLevelName { get; set; }

    [JsonProperty("inactive", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Inactive { get; set; }

    [JsonProperty("colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Colour { get; set; }

    [JsonProperty("confirmemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ConfirmEmail { get; set; }

    [JsonProperty("actionemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ActionEmail { get; set; }

    [JsonProperty("clearemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ClearEmail { get; set; }

    [JsonProperty("messagegroup_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MessageGroupId { get; set; }

    [JsonProperty("from_address_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? FromAddressOverride { get; set; }

    [JsonProperty("override_org_logo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? OverrideOrgLogo { get; set; }

    [JsonProperty("override_org_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OverrideOrgName { get; set; }

    [JsonProperty("override_org_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Address? OverrideOrgAddress { get; set; }

    [JsonProperty("override_org_phone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OverrideOrgPhone { get; set; }

    [JsonProperty("override_org_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OverrideOrgEmail { get; set; }

    [JsonProperty("override_org_website", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OverrideOrgWebsite { get; set; }

    [JsonProperty("override_org_portalurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OverrideOrgPortalUrl { get; set; }

    [JsonProperty("mailbox_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MailboxOverride { get; set; }

    [JsonProperty("default_mailbox_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultMailboxId { get; set; }

    [JsonProperty("calldate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? CallDate { get; set; }

    [JsonProperty("item_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ItemTaxCode { get; set; }

    [JsonProperty("service_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ServiceTaxCode { get; set; }

    [JsonProperty("prepay_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PrepayTaxCode { get; set; }

    [JsonProperty("contract_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ContractTaxCode { get; set; }

    [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomField>? CustomFields { get; set; }

    [JsonProperty("custombuttons", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomButton>? CustomButtons { get; set; }

    [JsonProperty("attachments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Attachment>? Attachments { get; set; }

    [JsonProperty("site_fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<FieldHelper>? SiteFields { get; set; }

    [JsonProperty("pritech", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PriTech { get; set; }

    [JsonProperty("sectech", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SecTech { get; set; }

    [JsonProperty("accountmanagertech", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AccountManagerTech { get; set; }

    [JsonProperty("notes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Notes { get; set; }

    [JsonProperty("thirdpartynhdapiurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ThirdPartyNhdApiUrl { get; set; }

    [JsonProperty("xeroid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Xeroid { get; set; }

    [JsonProperty("open_ticket_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OpenTicketCount { get; set; }

    [JsonProperty("opps_ticket_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OppsTicketCount { get; set; }

    [JsonProperty("datecreated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? DateCreated { get; set; }

    [JsonProperty("createdfrom_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CreatedFromId { get; set; }

    [JsonProperty("announce", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Announce { get; set; }

    [JsonProperty("announcedate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? AnnounceDate { get; set; }

    [JsonProperty("pritech_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PritechName { get; set; }

    [JsonProperty("sectech_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SecTechName { get; set; }

    [JsonProperty("prinotify", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? PriNotify { get; set; }

    [JsonProperty("secnotify", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? SecNotify { get; set; }

    [JsonProperty("priassign", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? PriAssign { get; set; }

    [JsonProperty("secassign", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? SecAssign { get; set; }

    [JsonProperty("accountmanagertech_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AccountManagerTechName { get; set; }

    [JsonProperty("accountmanagertech_email", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public string? AccountManagerTechEmail { get; set; }

    [JsonProperty("chargeperiod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ChargePeriod { get; set; }

    [JsonProperty("chargehours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? ChargeHours { get; set; }

    [JsonProperty("chargecarryover", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? ChargeCarryover { get; set; }

    [JsonProperty("invoiceyes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? InvoiceYes { get; set; }

    [JsonProperty("fluserdef1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? FlUserDef1 { get; set; }

    [JsonProperty("fluserdef2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? FlUserDef2 { get; set; }

    [JsonProperty("fluserdef3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? FlUserDef3 { get; set; }

    [JsonProperty("fluserdef4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? FlUserDef4 { get; set; }

    [JsonProperty("fluserdef5", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? FlUserDef5 { get; set; }

    [JsonProperty("floverride", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? FlOverride { get; set; }

    [JsonProperty("fluserdef1hide", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? FlUserDef1Hide { get; set; }

    [JsonProperty("fluserdef2hide", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? FlUserDef2Hide { get; set; }

    [JsonProperty("fluserdef3hide", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? FlUserDef3Hide { get; set; }

    [JsonProperty("fluserdef4hide", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? FlUserDef4Hide { get; set; }

    [JsonProperty("fluserdef5hide", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? FlUserDef5Hide { get; set; }

    [JsonProperty("fluserdef1mand", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? FlUserDef1Mand { get; set; }

    [JsonProperty("fluserdef2mand", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? FlUserDef2Mand { get; set; }

    [JsonProperty("fluserdef3mand", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? FlUserDef3Mand { get; set; }

    [JsonProperty("fluserdef4mand", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? FlUserDef4Mand { get; set; }

    [JsonProperty("fluserdef5mand", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? FlUserDef5Mand { get; set; }

    [JsonProperty("includeactions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IncludeActions { get; set; }

    [JsonProperty("needsinvoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? NeedsInvoice { get; set; }

    [JsonProperty("startdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? StartDate { get; set; }

    [JsonProperty("startbalance", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? StartBalance { get; set; }

    [JsonProperty("hourlyrate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? HourlyRate { get; set; }

    [JsonProperty("periodcharge", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? PeriodCharge { get; set; }

    [JsonProperty("dontinvoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DontInvoice { get; set; }

    [JsonProperty("invoicetemplate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? InvoiceTemplate { get; set; }

    [JsonProperty("invoicecomment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? InvoiceComment { get; set; }

    [JsonProperty("lastinvoiceenddate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? LastInvoiceEndDate { get; set; }

    [JsonProperty("showslaonweb", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowSlaOnWeb { get; set; }

    [JsonProperty("item_tax_code_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ItemTaxCodeName { get; set; }

    [JsonProperty("service_tax_code_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ServiceTaxCodeName { get; set; }

    [JsonProperty("contract_tax_code_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ContractTaxCodeName { get; set; }

    [JsonProperty("prepay_tax_code_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PrepayTaxCodeName { get; set; }

    [JsonProperty("imageindex", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ImageIndex { get; set; }

    [JsonProperty("chargehours2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? ChargeHours2 { get; set; }

    [JsonProperty("hourlyrate2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? HourlyRate2 { get; set; }

    [JsonProperty("cat2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Cat2 { get; set; }

    [JsonProperty("cat3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Cat3 { get; set; }

    [JsonProperty("cat4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Cat4 { get; set; }

    [JsonProperty("cat5", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Cat5 { get; set; }

    [JsonProperty("enddate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? EndDate { get; set; }

    [JsonProperty("ucemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? UcEmail { get; set; }

    [JsonProperty("fcemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? FcEmail { get; set; }

    [JsonProperty("actguid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ActGuid { get; set; }

    [JsonProperty("smsbalance", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SmsBalance { get; set; }

    [JsonProperty("html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Html { get; set; }

    [JsonProperty("hv", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Hv { get; set; }

    [JsonProperty("hvdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? HvDate { get; set; }

    [JsonProperty("emailinvoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? EmailInvoice { get; set; }

    [JsonProperty("dont_auto_send_invoices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DontAutoSendInvoices { get; set; }

    [JsonProperty("seriousnesslevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SeriousnessLevel { get; set; }

    [JsonProperty("defcat1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefCat1 { get; set; }

    [JsonProperty("defcat2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefCat2 { get; set; }

    [JsonProperty("defcat3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefCat3 { get; set; }

    [JsonProperty("defcat4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefCat4 { get; set; }

    [JsonProperty("thresholdbreached", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ThresholdBreached { get; set; }

    [JsonProperty("monthlyreportinclude", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? MonthlyReportInclude { get; set; }

    [JsonProperty("monthlyreportlastrun", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? MonthlyReportLastRun { get; set; }

    [JsonProperty("monthlyreportemaildirect", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? MonthlyReportEmailDirect { get; set; }

    [JsonProperty("monthlyreportemailmanager", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? MonthlyReportEmailManager { get; set; }

    [JsonProperty("monthlyreportshowonweb", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? MonthlyReportShowOnWeb { get; set; }

    [JsonProperty("areatype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AreaType { get; set; }

    [JsonProperty("unmatchedcombinations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? UnmatchedCombinations { get; set; }

    [JsonProperty("prepayrecurringchargenextdate", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? PrepayRecurringChargeNextDate { get; set; }

    [JsonProperty("billforrecurringprepayamount", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? BillForRecurringPrepayAmount { get; set; }

    [JsonProperty("prepayrecurringcharge", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? PrepayRecurringCharge { get; set; }

    [JsonProperty("prepayrecurringhours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? PrepayRecurringHours { get; set; }

    [JsonProperty("prepayrecurringchargebp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PrepayRecurringChargeBp { get; set; }

    [JsonProperty("accountsemailaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AccountsEmailAddress { get; set; }

    [JsonProperty("disclaimermatchstring", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DisclaimerMatchString { get; set; }

    [JsonProperty("paymentterms", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PaymentTerms { get; set; }

    [JsonProperty("showallnonbillable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowAllNonBillable { get; set; }

    [JsonProperty("billinggroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? BillingGroup { get; set; }

    [JsonProperty("autotopupthreshhold", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? AutoTopUpThreshold { get; set; }

    [JsonProperty("autotopuptoamount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? AutoTopUpToAmount { get; set; }

    [JsonProperty("autotopupcostperhour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? AutoTopUpCostPerHour { get; set; }

    [JsonProperty("autotopupbyamount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? AutoTopUpByAmount { get; set; }

    [JsonProperty("surchargeid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SurchargeId { get; set; }

    [JsonProperty("billingtemplate_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? BillingTemplateId { get; set; }

    [JsonProperty("billingtemplate_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? BillingTemplateName { get; set; }

    [JsonProperty("overidegreeting", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OverrideGreeting { get; set; }

    [JsonProperty("clientpackage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ClientPackage { get; set; }

    [JsonProperty("scopeofbusiness", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Scopeofbusiness { get; set; }

    [JsonProperty("preferredagent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PreferredAgent { get; set; }

    [JsonProperty("callhandlingnotes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CallHandlingNotes { get; set; }

    [JsonProperty("automatic_callscript_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AutomaticCallsScriptId { get; set; }

    [JsonProperty("automatic_callscript_name", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public string? AutomaticCallScriptName { get; set; }

    [JsonProperty("teamviewerpassword", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TeamViewerPassword { get; set; }

    [JsonProperty("customertype_new", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CustomerTypeNew { get; set; }

    [JsonProperty("discountperc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? DiscountPerc { get; set; }

    [JsonProperty("showfaqfortoplevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowFaqForTopLevel { get; set; }

    [JsonProperty("accountsccemailaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AccountsCcEmailAddress { get; set; }

    [JsonProperty("isopportunity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? IsOpportunity { get; set; }

    [JsonProperty("snowname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SnowName { get; set; }

    [JsonProperty("main_site_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MainSiteId { get; set; }

    [JsonProperty("main_site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MainSiteName { get; set; }

    [JsonProperty("linked_organisation_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? LinkedOrganisationId { get; set; }

    [JsonProperty("all_organisations_allowed", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllOrganisationsAllowed { get; set; }

    [JsonProperty("allowed_organisations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Organisation>? AllowedOrganisations { get; set; }

    [JsonProperty("override_signature", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OverrideSignature { get; set; }

    [JsonProperty("contractaccountsdesc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ContractAccountsDesc { get; set; }

    [JsonProperty("prepayaccountsdesc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PrepayAccountsDesc { get; set; }

    [JsonProperty("site_update", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Site>? SiteUpdate { get; set; }

    [JsonProperty("newclient_sitename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewClientSiteName { get; set; }

    [JsonProperty("newclient_phonenumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewClientPhoneNumber { get; set; }

    [JsonProperty("newclient_domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewClientDomain { get; set; }

    [JsonProperty("newclient_timezone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewClientTimeZone { get; set; }

    [JsonProperty("newclient_contactname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewClientContactName { get; set; }

    [JsonProperty("newclient_contactemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewClientContactEmail { get; set; }

    [JsonProperty("newclient_contacttitle", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewClientContactTitle { get; set; }

    [JsonProperty("newclient_web_access_level", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? NewClientWebAccessLevel { get; set; }

    [JsonProperty("newclient_sendwelcomeemail", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? NewClientSendWelcomeEmail { get; set; }

    [JsonProperty("newclient_delivery_address", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public Address? NewClientDeliveryAddress { get; set; }

    [JsonProperty("newclient_countrycode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewClientCountrycode { get; set; }

    [JsonProperty("newclient_regioncode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? NewClientRegionCode { get; set; }

    [JsonProperty("faqlists", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<FaqListHead>? FaqLists { get; set; }

    [JsonProperty("popup_notes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<PopupNote>? PopupNotes { get; set; }

    [JsonProperty("_reassign_all_to_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ReassignAllToUser { get; set; }

    [JsonProperty("allowall_tickettypes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowAllTicketTypes { get; set; }

    [JsonProperty("allowed_tickettypes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<TicketTypeList>? AllowedTicketTypes { get; set; }

    [JsonProperty("allowall_category1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowAllCategory1 { get; set; }

    [JsonProperty("allowed_category1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CategoryRestriction>? AllowedCategory1 { get; set; }

    [JsonProperty("allowall_category2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowAllCategory2 { get; set; }

    [JsonProperty("allowed_category2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CategoryRestriction>? AllowedCategory2 { get; set; }

    [JsonProperty("allowall_category3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowAllCategory3 { get; set; }

    [JsonProperty("allowed_category3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CategoryRestriction>? AllowedCategory3 { get; set; }

    [JsonProperty("allowall_category4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowAllCategory4 { get; set; }

    [JsonProperty("alocked", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ALocked { get; set; }

    [JsonProperty("allowed_category4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CategoryRestriction>? AllowedCategory4 { get; set; }

    [JsonProperty("onhold_ticket_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OnholdTicketCount { get; set; }

    [JsonProperty("total_ticket_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TotalTicketCount { get; set; }

    [JsonProperty("opened_thismonth_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OpenedThisMonthCount { get; set; }

    [JsonProperty("billingplans", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ContractDetail>? BillingPlans { get; set; }

    [JsonProperty("overriding_rates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ChargeRate>? OverridingRates { get; set; }

    [JsonProperty("allowallchargerates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowAllChargeRates { get; set; }

    [JsonProperty("chargerates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ChargeRateArea>? ChargeRates { get; set; }

    [JsonProperty("newclient_siteguid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewClientSiteGuid { get; set; }

    [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsImport { get; set; }

    [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ImportType { get; set; }

    [JsonProperty("allow_api_access", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowApiAccess { get; set; }

    [JsonProperty("api_access_clientid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ApiAccessClientId { get; set; }

    [JsonProperty("api_access_clientsecret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ApiAccessClientSecret { get; set; }

    [JsonProperty("thirdpartynhdauthurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ThirdPartyNhdAuthUrl { get; set; }

    [JsonProperty("thirdpartynhdtenant", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ThirdPartyNhdTenant { get; set; }

    [JsonProperty("thirdpartynhdapiclientid", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public string? ThirdPartyNhdApiClientId { get; set; }

    [JsonProperty("new_thirdpartynhdapiclientsecret", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public string? NewThirdPartyNhdApiClientSecret { get; set; }

    [JsonProperty("areaitems", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<RecurringItem>? AreaItems { get; set; }

    [JsonProperty("portal_logo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PortalLogo { get; set; }

    [JsonProperty("override_portalcolour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? OverridePortalColour { get; set; }

    [JsonProperty("portalcolour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [StringLength(7)]
    public string? PortalColour { get; set; }

    [JsonProperty("portalbackgroundimageurl", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    [StringLength(500)]
    public string? PortalBackgroundImageUrl { get; set; }

    [JsonProperty("ninjarmmid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? NinjaRmmId { get; set; }

    [JsonProperty("sales_tax_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SalesTaxType { get; set; }

    [JsonProperty("purchase_tax_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PurchaseTaxType { get; set; }

    [JsonProperty("isarchived_xero", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsArchivedXero { get; set; }

    [JsonProperty("accountsfirstname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AccountsFirstName { get; set; }

    [JsonProperty("accountslastname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AccountsLastName { get; set; }

    [JsonProperty("sales_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SalesTaxCode { get; set; }

    [JsonProperty("purchase_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PurchaseTaxCode { get; set; }

    [JsonProperty("purchase_tax_code_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PurchaseTaxCodeName { get; set; }

    [JsonProperty("prepayhistory", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<PrepayHistory>? PrepayHistory { get; set; }

    [JsonProperty("periods", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<PrepayPeriod>? Periods { get; set; }

    [JsonProperty("prepayrecurringminimumdeduction", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public double? PrepayRecurringMinimumDeduction { get; set; }

    [JsonProperty("prepayrecurringminimumdeductiononlyactive", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? PrepayRecurringMinimumDeductionOnlyActive { get; set; }

    [JsonProperty("prepayrecurringautomaticdeduction", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public double? PrepayRecurringAutomaticDeduction { get; set; }

    [JsonProperty("prepaytotal", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? PrepayTotal { get; set; }

    [JsonProperty("prepayused", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? PrepayUsed { get; set; }

    [JsonProperty("prepaybalance", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? PrepayBalance { get; set; }

    [JsonProperty("preferreddeliverymethod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Preferreddeliverymethod { get; set; }

    [JsonProperty("qbodefaulttax", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? QboDefaulttax { get; set; }

    [JsonProperty("default_contract", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultContract { get; set; }

    [JsonProperty("device42id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Device42Id { get; set; }

    [JsonProperty("xerodetails_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? XeroDetailsId { get; set; }

    [JsonProperty("xero_tenant_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? XeroTenantName { get; set; }

    [JsonProperty("xero_tracking_category_1_name", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public string? XeroTrackingCategory1Name { get; set; }

    [JsonProperty("xero_tracking_category_2_name", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public string? XeroTrackingCategory2Name { get; set; }

    [JsonProperty("servicenowid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ServiceNowId { get; set; }

    [JsonProperty("isnhserveremaildefault", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsNhServerEmailDefault { get; set; }

    [JsonProperty("datto_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DattoId { get; set; }

    [JsonProperty("datto_alternate_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DattoAlternateId { get; set; }

    [JsonProperty("datto_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DattoUrl { get; set; }

    [JsonProperty("dattocommerce_tenantid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DattoCommerceTenantId { get; set; }

    [JsonProperty("qbodefaulttaxcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? QboDefaultTaxCodeAsInt { get; set; }

    [JsonProperty("qbodefaulttaxcodename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? QboDefaultTaxCodename { get; set; }

    [JsonProperty("qbo_default_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ValueLabelIsNewKeyPair? QboDefaultTaxCode { get; set; }

    [JsonProperty("connectwiseid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ConnectWiseId { get; set; }

    [JsonProperty("autotaskid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AutoTaskId { get; set; }

    [JsonProperty("import_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Address? ImportAddress { get; set; }

    [JsonProperty("import_notes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CrmNote>? ImportNotes { get; set; }

    [JsonProperty("ateraid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AteraId { get; set; }

    [JsonProperty("kashflowid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? KashflowId { get; set; }

    [JsonProperty("kashflow_tenant_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? KashflowTenantName { get; set; }

    [JsonProperty("website", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Website { get; set; }

    [JsonProperty("alastupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? ALastUpdate { get; set; }

    [JsonProperty("service_access", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ServiceRestriction>? ServiceAccess { get; set; }

    [JsonProperty("service_subscriptions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ServiceUser>? ServiceSubscriptions { get; set; }

    [JsonProperty("snelstart_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SnelStartId { get; set; }

    [JsonProperty("default_currency_code_name", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultCurrencyCodeName { get; set; }

    [JsonProperty("_apply_billingtemplate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ApplyBillingTemplate { get; set; }

    [JsonProperty("datto_commerce_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DattoCommerceId { get; set; }

    [JsonProperty("datto_commerce_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DattoCommerceUrl { get; set; }

    [JsonProperty("import_azure_tenant", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public CspCustomer? ImportAzureTenant { get; set; }

    [JsonProperty("import_details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ImportDetailsId { get; set; }

    [JsonProperty("syncroid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SyncroId { get; set; }

    [JsonProperty("kbentries", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<KbArticleList>? KbEntries { get; set; }

    [JsonProperty("auvik_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AuvikId { get; set; }

    [JsonProperty("hubspot_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? HubspotId { get; set; }

    [JsonProperty("hubspot_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? HubspotUrl { get; set; }

    [JsonProperty("hubspot_dont_sync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? HubspotDontSync { get; set; }

    [JsonProperty("hubspot_archived", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? HubspotArchived { get; set; }

    [JsonProperty("domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Domain { get; set; }

    [JsonProperty("passportal_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public long? PassportalId { get; set; }

    [JsonProperty("update_licences", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? UpdateLicences { get; set; }

    [JsonProperty("prepayasamount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? PrepayAsAmount { get; set; }

    [JsonProperty("synced_to_intacct", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? SyncedToIntacct { get; set; }

    [JsonProperty("qbo_company_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? QboCompanyName { get; set; }

    [JsonProperty("oppid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OppId { get; set; }

    [JsonProperty("tax_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TaxNumber { get; set; }

    [JsonProperty("isclientdetails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsClientDetails { get; set; }

    [JsonProperty("hubspot_lifecycle", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? HubspotLifecycle { get; set; }

    [JsonProperty("hudu_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? HuduUrl { get; set; }

    [JsonProperty("prepayrecurringexpirymonths", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? PrepayRecurringexpirymonths { get; set; }

    [JsonProperty("accountsbccemailaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AccountsBccEmailAddress { get; set; }

    [JsonProperty("defaultcontractoverride", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultContractOverride { get; set; }

    [JsonProperty("defaultcontractoverride_ref", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultContractOverrideRef { get; set; }

    [JsonProperty("sqlimport_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SqlImportId { get; set; }

    [JsonProperty("external_links", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ExternalLink>? ExternalLinks { get; set; }

    [JsonProperty("new_external_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ExternalLink? NewExternalLink { get; set; }

    [JsonProperty("_match_thirdparty_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MatchThirdPartyId { get; set; }

    [JsonProperty("_match_integration_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MatchIntegrationId { get; set; }

    [JsonProperty("_match_integration_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MatchIntegrationName { get; set; }

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; }

    [JsonProperty("donotimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DoNotImport { get; set; }

    [JsonProperty("liongardid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? LiongardId { get; set; }

    [JsonProperty("liongard_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? LiongardUrl { get; set; }

    [JsonProperty("sync_to_liongard", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? SyncToLiongard { get; set; }

    [JsonProperty("regmanagertech_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RegManagerTechName { get; set; }

    [JsonProperty("logmanagertech_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? LogManagerTechName { get; set; }

    [JsonProperty("salesreptech_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SalesRepTechName { get; set; }

    [JsonProperty("default_team_to_salesrep_override", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? DefaultTeamToSalesRepOverride { get; set; }

    [JsonProperty("default_team_to_salesrep_override_team", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultTeamToSalesRepOverrideTeam { get; set; }

    [JsonProperty("cxmleadtech_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CxmLeadTechName { get; set; }

    [JsonProperty("portalchatprofile", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PortalChatProfile { get; set; }

    [JsonProperty("portalchatprofile_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PortalChatProfileName { get; set; }

    [JsonProperty("kaseyaid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? KaseyaId { get; set; }

    [JsonProperty("trading_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TradingName { get; set; }

    [JsonProperty("dbc_company_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DbcCompanyName { get; set; }

    [JsonProperty("salesforce_dontsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? SalesforceDontSync { get; set; }

    [JsonProperty("stripe_customer_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? StripeCustomerId { get; set; }

    [JsonProperty("stripe_payment_method_id", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public string? StripePaymentMethodId { get; set; }

    [JsonProperty("stripe_payment_method_name", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public string? StripePaymentMethodName { get; set; }

    [JsonProperty("stripe_paymentmethod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public StripePaymentMethod? StripePaymentMethod { get; set; }

    [JsonProperty("current_licences", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CurrentLicences { get; set; }

    [JsonProperty("servicenow_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ServiceNowUrl { get; set; }

    [JsonProperty("servicenow_locale", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ServiceNowLocale { get; set; }

    [JsonProperty("servicenow_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ServiceNowUsername { get; set; }

    [JsonProperty("new_servicenowkey", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewServiceNowKey { get; set; }

    [JsonProperty("servicenow_priority_mappings", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IntegrationFieldMapping>? ServiceNowPriorityMappings { get; set; }

    [JsonProperty("servicenow_status_mappings", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IntegrationFieldMapping>? ServiceNowStatusMappings { get; set; }

    [JsonProperty("servicenow_impact_mappings", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IntegrationFieldMapping>? ServiceNowImpactMappings { get; set; }

    [JsonProperty("servicenow_urgency_mappings", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IntegrationFieldMapping>? ServiceNowUrgencyMappings { get; set; }

    [JsonProperty("servicenow_category_mappings", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IntegrationFieldMapping>? ServiceNowCategoryMappings { get; set; }

    [JsonProperty("servicenow_assignment_group", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public string? ServiceNowAssignmentGroupString { get; set; }

    [JsonProperty("servicenow_assignment_group_name", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public string? ServiceNowAssignmentGroupName { get; set; }

    [JsonProperty("servicenow_assignmentgroup", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public ValueLabelIsNewKeyPair? ServiceNowAssignmentGroup { get; set; }

    [JsonProperty("servicenow_defaultuser_id", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public string? ServiceNowDefaultUserId { get; set; }

    [JsonProperty("servicenow_defaultuser_name", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public string? ServiceNowDefaultUserName { get; set; }

    [JsonProperty("servicenow_defaultuser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ValueLabelIsNewKeyPair? ServiceNowDefaultUser { get; set; }

    [JsonProperty("test_servicenow", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? TestServiceNow { get; set; }

    [JsonProperty("sage_business_cloud_details_id", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? SageBusinessCloudDetailsId { get; set; }

    [JsonProperty("sage_business_cloud_details_name", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public string? SageBusinessCloudDetailsName { get; set; }

    [JsonProperty("exact_division", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ExactDivision { get; set; }

    [JsonProperty("exact_division_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ExactDivisionName { get; set; }

    [JsonProperty("ncentral_details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? NCentralDetailsId { get; set; }

    [JsonProperty("currencyisocode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CurrencyIsoCode { get; set; }

    [JsonProperty("intacct_location_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? IntacctLocationId { get; set; }

    [JsonProperty("intacct_location_id_list", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ValueLabelIsNewKeyPair>? IntacctLocationIdList { get; set; }

    [JsonProperty("intacct_location_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? IntacctLocationType { get; set; }

    [JsonProperty("new_categories", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<string>? NewCategories { get; set; }

    [JsonProperty("jira_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? JiraUrl { get; set; }

    [JsonProperty("jira_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? JiraUsername { get; set; }

    [JsonProperty("new_jirakey", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewJiraKey { get; set; }

    [JsonProperty("test_jira", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? TestJira { get; set; }

    [JsonProperty("jira_servicedesk_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? JiraServiceDeskId { get; set; }

    [JsonProperty("jira_servicedesk_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? JiraServiceDeskName { get; set; }

    [JsonProperty("jira_servicedesk", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ValueLabelIsNewKeyPair? JiraServiceDesk { get; set; }

    [JsonProperty("jira_requesttype_mappings", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IntegrationFieldMapping>? JiraRequestTypeMappings { get; set; }

    [JsonProperty("jira_user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? JiraUserId { get; set; }

    [JsonProperty("jira_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? JiraUserName { get; set; }

    [JsonProperty("jira_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ValueLabelIsNewKeyPair? JiraUser { get; set; }

    [JsonProperty("jira_priority_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IntegrationFieldMapping>? JiraPriorityMappings { get; set; }

    [JsonProperty("jira_status_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IntegrationFieldMapping>? JiraStatusMappings { get; set; }

    [JsonProperty("create_jira_webhook", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CreateJiraWebhook { get; set; }

    [JsonProperty("jira_webhook_created", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? JiraWebhookCreated { get; set; }

    [JsonProperty("defaultpdftemplateinvoicetickets", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultPdfTemplateInvoiceTickets { get; set; }

    [JsonProperty("defaultpdftemplateinvoiceorders", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultPdfTemplateInvoiceOrders { get; set; }

    [JsonProperty("defaultpdftemplateinvoicerecurring", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultPdfTemplateInvoiceRecurring { get; set; }

    [JsonProperty("defaultpdftemplateinvoicetickets_name", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultPdfTemplateInvoiceTicketsName { get; set; }

    [JsonProperty("defaultpdftemplateinvoiceorders_name", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultPdfTemplateInvoiceOrdersName { get; set; }

    [JsonProperty("defaultpdftemplateinvoicerecurring_name", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultPdfTemplateInvoiceRecurringName { get; set; }

    [JsonProperty("intacct_invoice_save_location", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public string? IntacctInvoiceSaveLocation { get; set; }

    [JsonProperty("ingram_micro_details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? IngramMicroDetailsId { get; set; }

    [JsonProperty("_dont_fire_automations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DontFireAutomations { get; set; }

    [JsonProperty("main_delivery_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Address? MainDeliveryAddress { get; set; }

    [JsonProperty("main_invoice_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Address? MainInvoiceAddress { get; set; }

    [JsonProperty("main_contact_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MainContactName { get; set; }

    [JsonProperty("main_contact_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MainContactEmail { get; set; }

    [Phone]
    [JsonProperty("main_contact_phonenumber", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public string? MainContactPhoneNumber { get; set; }

    [JsonProperty("main_contact_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MainContactId { get; set; }

    [Phone]
    [JsonProperty("main_phonenumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MainPhoneNumber { get; set; }

    [JsonProperty("auvik_site_inactive", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AuvikSiteInactive { get; set; }

    [JsonProperty("invoice_class", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? InvoiceClass { get; set; }

    [JsonProperty("new_icon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewIcon { get; set; }

    [JsonProperty("fortnox_tenant", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? FortnoxTenant { get; set; }

    [JsonProperty("fortnox_tenant_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? FortnoxTenantName { get; set; }

    [JsonProperty("servicenow_enable_webhook", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? ServiceNowEnableWebhook { get; set; }

    [JsonProperty("new_servicenow_webhooksecret", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public string? NewServiceNowWebhookSecret { get; set; }

    [JsonProperty("servicenow_webhook_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ServiceNowWebhookUser { get; set; }

    [JsonProperty("servicenow_webhook_user_name", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public string? ServiceNowWebhookUserName { get; set; }

    [JsonProperty("servicenow_webhook_tickettype", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? ServiceNowWebhookTicketType { get; set; }

    [JsonProperty("servicenow_webhook_tickettype_name", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public string? ServiceNowWebhookTicketTypeName { get; set; }

    [JsonProperty("myob_tenant", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MyobTenant { get; set; }

    [JsonProperty("myob_tenant_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MyobTenantName { get; set; }

    [JsonProperty("sync_servicenow_attachments", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? SyncServiceNowAttachments { get; set; }

    [JsonProperty("twilio_subaccount_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TwilioSubaccountName { get; set; }

    [JsonProperty("twilio_subaccount_created", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? TwilioSubaccountCreated { get; set; }

    [JsonProperty("twilio_subaccount_sid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TwilioSubaccountSid { get; set; }

    [JsonProperty("twilio_subaccount_status", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public string? TwilioSubaccountStatus { get; set; }

    [JsonProperty("twilio_subaccount_authtoken", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public string? TwilioSubaccountAuthToken { get; set; }

    [JsonProperty("_create_twilio_subaccount", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? CreateTwilioSubaccount { get; set; }

    [JsonProperty("_close_twilio_subaccount", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? CloseTwilioSubaccount { get; set; }

    [JsonProperty("_pauseunpause_twilio_subaccount", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? PauseUnpauseTwilioSubaccount { get; set; }

    [JsonProperty("_create_twilio_recurringinvoice", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? CreateTwilioRecurringInvoice { get; set; }

    [JsonProperty("twilio_recurring_invoice_id", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? TwilioRecurringInvoiceId { get; set; }

    [JsonProperty("override_layout_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OverrideLayoutId { get; set; }

    [JsonProperty("override_layout_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OverrideLayoutName { get; set; }

    [JsonProperty("extratabs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Tabs>? ExtraTabs { get; set; }

    [JsonProperty("servicenow_team_mappings", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IntegrationFieldMapping>? ServiceNowTeamMappings { get; set; }

    [JsonProperty("servicenow_ticket_sync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ServiceNowTicketSync { get; set; }

    [JsonProperty("servicenow_ticket_sync_list", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ValueLabelIsNewKeyPair>? ServiceNowTicketSyncList { get; set; }

    [JsonProperty("servicenow_fieldmappings", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IntegrationFieldMapping>? ServiceNowFieldMappings { get; set; }

    [JsonProperty("matching_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MatchingValue { get; set; }

    [JsonProperty("jira_webhook_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? JiraWebhookUser { get; set; }

    [JsonProperty("jira_webhook_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? JiraWebhookUsername { get; set; }

    [JsonProperty("avalara_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AvalaraCode { get; set; }

    [JsonProperty("avalara_tenant_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AvalaraTenantName { get; set; }

    [JsonProperty("avalara_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AvalaraId { get; set; }

    [JsonProperty("invoice_mailbox_override", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? InvoiceMailboxOverride { get; set; }

    [JsonProperty("quote_mailbox_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? QuoteMailboxOverride { get; set; }

    [JsonProperty("_merge_client_into", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MergeClientInto { get; set; }

    [JsonProperty("invoice_tickets_seperately_override", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? InvoiceTicketsSeparatelyOverride { get; set; }

    [JsonProperty("servicenow_authtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ServiceNowAuthType { get; set; }

    [JsonProperty("portal_title_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? PortalTitleOverride { get; set; }

    [JsonProperty("portal_title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PortalTitle { get; set; }

    [JsonProperty("reply_address_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ReplyAddressOverride { get; set; }

    [JsonProperty("use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Use { get; set; }

    [JsonProperty("key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Key { get; set; }

    [JsonProperty("table", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Table { get; set; }

    [JsonProperty("logo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Logo { get; set; }

    [JsonProperty("regmanagertech", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RegManagerTech { get; set; }

    [JsonProperty("logmanagertech", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? LogManagerTech { get; set; }

    [JsonProperty("salesreptech", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SalesRepTech { get; set; }

    [JsonProperty("accountownertech", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AccountOwnerTech { get; set; }

    [JsonProperty("cxmleadtech", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CxmLeadTech { get; set; }

    [JsonProperty("xero_tenant_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? XeroTenantId { get; set; }

    [JsonProperty("accountsid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AccountsId { get; set; }

    [JsonProperty("excludefrominvoicesync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ExcludeFromInvoiceSync { get; set; }

    [JsonProperty("gficlientid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? GfiClientId { get; set; }

    [JsonProperty("overridepdftemplateinvoice", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? OverridePdfTemplateInvoice { get; set; }

    [JsonProperty("overridepdftemplateinvoice_name", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public string? OverridePdfTemplateInvoiceName { get; set; }

    [JsonProperty("kashflow_tenant_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? KashflowTenantId { get; set; }

    [JsonProperty("client_to_invoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ClientToInvoice { get; set; }

    [JsonProperty("client_to_invoice_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ClientToInvoiceName { get; set; }

    [JsonProperty("invoiceduedaysextraclient", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? InvoiceDueDaysExtraClient { get; set; }

    [JsonProperty("itglue_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ItGlueId { get; set; }

    [JsonProperty("clientcurrency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ClientCurrency { get; set; }

    [JsonProperty("sentinel_subscription_id", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public string? SentinelSubscriptionId { get; set; }

    [JsonProperty("sentinel_workspace_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SentinelWorkspaceName { get; set; }

    [JsonProperty("sentinel_resource_group_name", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public string? SentinelResourceGroupName { get; set; }

    [JsonProperty("sentinel_tenant_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SentinelTenantId { get; set; }

    [JsonProperty("sentinel_tenant_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SentinelTenantName { get; set; }

    [JsonProperty("default_currency_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultCurrencyCode { get; set; }

    [JsonProperty("client_to_invoice_recurring", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? ClientToInvoiceRecurring { get; set; }

    [JsonProperty("client_to_invoice_recurring_name", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public string? ClientToInvoiceRecurringName { get; set; }

    [JsonProperty("azure_tenants", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ClientAzureTenant>? AzureTenants { get; set; }

    [JsonProperty("azure_tenant_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AzureTenantId { get; set; }

    [JsonProperty("snow_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SnowId { get; set; }

    [JsonProperty("snowLicences", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<SnowLicenseAbstract>? SnowLicences { get; set; }

    [JsonProperty("qbo_company_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? QboCompanyId { get; set; }

    [JsonProperty("automatic_sales_tax", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AutomaticSalesTax { get; set; }

    [JsonProperty("cautomateid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CAutomateId { get; set; }

    [JsonProperty("dbc_company_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DbcCompanyId { get; set; }

    [JsonProperty("stopped", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Stopped { get; set; }

    [JsonProperty("customertype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CustomerType { get; set; }

    [JsonProperty("customer_relationship", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<StringIdNameKeyPair>? CustomerRelationship { get; set; }

    [JsonProperty("customer_relationship_list", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public string? CustomerRelationshipList { get; set; }

    [JsonProperty("servicenow_validated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ServiceNowValidated { get; set; }

    [JsonProperty("sentinel_default_user_override", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? SentinelDefaultUserOverride { get; set; }

    [JsonProperty("sentinel_default_user_override_name", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public string? SentinelDefaultUserOverrideName { get; set; }

    [JsonProperty("jira_validated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? JiraValidated { get; set; }

    [JsonProperty("ref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Ref { get; set; }

    [JsonProperty("ticket_invoices_for_each_site", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? TicketInvoicesForEachSite { get; set; }

    [JsonProperty("intacct_save_location", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? IntacctSaveLocation { get; set; }

    [JsonProperty("is_vip", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsVip { get; set; }

    [JsonProperty("accountownertech_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AccountOwnerTechName { get; set; }

    [JsonProperty("taxable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Taxable { get; set; }

    [JsonProperty("quickbooks_details", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public QuickBooksDetails? QuickbooksDetails { get; set; }

    [JsonProperty("percentage_to_survey", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PercentageToSurvey { get; set; }

    [JsonProperty("billing_plan_text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? BillingPlanText { get; set; }

    [JsonProperty("overridepdftemplatequote", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? OverridePdfTemplateQuote { get; set; }

    [JsonProperty("overridepdftemplatequote_name", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public string? OverridePdfTemplateQuoteName { get; set; }

    [JsonProperty("avalara_tenant", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AvalaraTenant { get; set; }

    [JsonProperty("due_date_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DueDateType { get; set; }

    [JsonProperty("toplevel_quote_currency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TopLevelQuoteCurrency { get; set; }

    [JsonProperty("is_account", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsAccount { get; set; }

    [JsonProperty("_importtypeid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ImportTypeId { get; set; }

    [JsonProperty("_importthirdpartyid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ImportThirdPartyId { get; set; }
}