using System.CodeDom.Compiler;
using Angelic.Agent;
using Angelic.KeyPairs;
using Newtonsoft.Json;

namespace Angelic;


    public class Area
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("toplevel_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ToplevelId { get; set; } 

        [JsonProperty("toplevel_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ToplevelName { get; set; } 

        [JsonProperty("inactive", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Inactive { get; set; } 

        [JsonProperty("colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Colour { get; set; } 

        [JsonProperty("confirmemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Confirmemail { get; set; } 

        [JsonProperty("actionemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Actionemail { get; set; } 

        [JsonProperty("clearemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Clearemail { get; set; } 

        [JsonProperty("messagegroup_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MessagegroupId { get; set; } 

        [JsonProperty("from_address_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? FromAddressOverride { get; set; } 

        [JsonProperty("override_org_logo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? OverrideOrgLogo { get; set; } 

        [JsonProperty("override_org_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OverrideOrgName { get; set; } 

        [JsonProperty("override_org_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AddressStore? OverrideOrgAddress { get; set; } 

        [JsonProperty("override_org_phone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OverrideOrgPhone { get; set; } 

        [JsonProperty("override_org_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OverrideOrgEmail { get; set; } 

        [JsonProperty("override_org_website", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OverrideOrgWebsite { get; set; } 

        [JsonProperty("override_org_portalurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OverrideOrgPortalurl { get; set; } 

        [JsonProperty("mailbox_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MailboxOverride { get; set; } 

        [JsonProperty("default_mailbox_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultMailboxId { get; set; } 

        [JsonProperty("calldate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Calldate { get; set; } 

        [JsonProperty("item_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ItemTaxCode { get; set; } 

        [JsonProperty("service_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ServiceTaxCode { get; set; } 

        [JsonProperty("prepay_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PrepayTaxCode { get; set; } 

        [JsonProperty("contract_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ContractTaxCode { get; set; } 

        [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CustomField>? Customfields { get; set; } 

        [JsonProperty("custombuttons", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CustomButton>? Custombuttons { get; set; } 

        [JsonProperty("attachments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Attachment>? Attachments { get; set; } 

        [JsonProperty("site_fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<FieldHelper>? SiteFields { get; set; } 

        [JsonProperty("pritech", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Pritech { get; set; } 

        [JsonProperty("sectech", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sectech { get; set; } 

        [JsonProperty("accountmanagertech", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Accountmanagertech { get; set; } 

        [JsonProperty("notes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Notes { get; set; } 

        [JsonProperty("thirdpartynhdapiurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Thirdpartynhdapiurl { get; set; } 

        [JsonProperty("xeroid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Xeroid { get; set; } 

        [JsonProperty("open_ticket_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? OpenTicketCount { get; set; } 

        [JsonProperty("opps_ticket_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? OppsTicketCount { get; set; } 

        [JsonProperty("datecreated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Datecreated { get; set; } 

        [JsonProperty("createdfrom_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CreatedfromId { get; set; } 

        [JsonProperty("announce", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Announce { get; set; } 

        [JsonProperty("announcedate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Announcedate { get; set; } 

        [JsonProperty("pritech_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PritechName { get; set; } 

        [JsonProperty("sectech_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SectechName { get; set; } 

        [JsonProperty("prinotify", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Prinotify { get; set; } 

        [JsonProperty("secnotify", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Secnotify { get; set; } 

        [JsonProperty("priassign", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Priassign { get; set; } 

        [JsonProperty("secassign", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Secassign { get; set; } 

        [JsonProperty("accountmanagertech_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AccountmanagertechName { get; set; } 

        [JsonProperty("accountmanagertech_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AccountmanagertechEmail { get; set; } 

        [JsonProperty("chargeperiod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Chargeperiod { get; set; } 

        [JsonProperty("chargehours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Chargehours { get; set; } 

        [JsonProperty("chargecarryover", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Chargecarryover { get; set; } 

        [JsonProperty("invoiceyes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Invoiceyes { get; set; } 

        [JsonProperty("fluserdef1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Fluserdef1 { get; set; } 

        [JsonProperty("fluserdef2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Fluserdef2 { get; set; } 

        [JsonProperty("fluserdef3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Fluserdef3 { get; set; } 

        [JsonProperty("fluserdef4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Fluserdef4 { get; set; } 

        [JsonProperty("fluserdef5", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Fluserdef5 { get; set; } 

        [JsonProperty("floverride", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Floverride { get; set; } 

        [JsonProperty("fluserdef1hide", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Fluserdef1Hide { get; set; } 

        [JsonProperty("fluserdef2hide", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Fluserdef2Hide { get; set; } 

        [JsonProperty("fluserdef3hide", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Fluserdef3Hide { get; set; } 

        [JsonProperty("fluserdef4hide", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Fluserdef4Hide { get; set; } 

        [JsonProperty("fluserdef5hide", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Fluserdef5Hide { get; set; } 

        [JsonProperty("fluserdef1mand", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Fluserdef1Mand { get; set; } 

        [JsonProperty("fluserdef2mand", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Fluserdef2Mand { get; set; } 

        [JsonProperty("fluserdef3mand", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Fluserdef3Mand { get; set; } 

        [JsonProperty("fluserdef4mand", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Fluserdef4Mand { get; set; } 

        [JsonProperty("fluserdef5mand", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Fluserdef5Mand { get; set; } 

        [JsonProperty("includeactions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Includeactions { get; set; } 

        [JsonProperty("needsinvoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Needsinvoice { get; set; } 

        [JsonProperty("startdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Startdate { get; set; } 

        [JsonProperty("startbalance", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Startbalance { get; set; } 

        [JsonProperty("hourlyrate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Hourlyrate { get; set; } 

        [JsonProperty("periodcharge", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Periodcharge { get; set; } 

        [JsonProperty("dontinvoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dontinvoice { get; set; } 

        [JsonProperty("invoicetemplate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Invoicetemplate { get; set; } 

        [JsonProperty("invoicecomment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Invoicecomment { get; set; } 

        [JsonProperty("lastinvoiceenddate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Lastinvoiceenddate { get; set; } 

        [JsonProperty("showslaonweb", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showslaonweb { get; set; } 

        [JsonProperty("item_tax_code_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ItemTaxCodeName { get; set; } 

        [JsonProperty("service_tax_code_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ServiceTaxCodeName { get; set; } 

        [JsonProperty("contract_tax_code_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ContractTaxCodeName { get; set; } 

        [JsonProperty("prepay_tax_code_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PrepayTaxCodeName { get; set; } 

        [JsonProperty("imageindex", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Imageindex { get; set; } 

        [JsonProperty("chargehours2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Chargehours2 { get; set; } 

        [JsonProperty("hourlyrate2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Hourlyrate2 { get; set; } 

        [JsonProperty("cat2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Cat2 { get; set; } 

        [JsonProperty("cat3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Cat3 { get; set; } 

        [JsonProperty("cat4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Cat4 { get; set; } 

        [JsonProperty("cat5", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Cat5 { get; set; } 

        [JsonProperty("enddate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Enddate { get; set; } 

        [JsonProperty("ucemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ucemail { get; set; } 

        [JsonProperty("fcemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Fcemail { get; set; } 

        [JsonProperty("actguid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Actguid { get; set; } 

        [JsonProperty("smsbalance", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Smsbalance { get; set; } 

        [JsonProperty("html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Html { get; set; } 

        [JsonProperty("hv", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Hv { get; set; } 

        [JsonProperty("hvdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Hvdate { get; set; } 

        [JsonProperty("emailinvoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Emailinvoice { get; set; } 

        [JsonProperty("dont_auto_send_invoices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DontAutoSendInvoices { get; set; } 

        [JsonProperty("seriousnesslevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Seriousnesslevel { get; set; } 

        [JsonProperty("defcat1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Defcat1 { get; set; } 

        [JsonProperty("defcat2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Defcat2 { get; set; } 

        [JsonProperty("defcat3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Defcat3 { get; set; } 

        [JsonProperty("defcat4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Defcat4 { get; set; } 

        [JsonProperty("thresholdbreached", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Thresholdbreached { get; set; } 

        [JsonProperty("monthlyreportinclude", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Monthlyreportinclude { get; set; } 

        [JsonProperty("monthlyreportlastrun", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Monthlyreportlastrun { get; set; } 

        [JsonProperty("monthlyreportemaildirect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Monthlyreportemaildirect { get; set; } 

        [JsonProperty("monthlyreportemailmanager", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Monthlyreportemailmanager { get; set; } 

        [JsonProperty("monthlyreportshowonweb", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Monthlyreportshowonweb { get; set; } 

        [JsonProperty("areatype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Areatype { get; set; } 

        [JsonProperty("unmatchedcombinations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Unmatchedcombinations { get; set; } 

        [JsonProperty("prepayrecurringchargenextdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Prepayrecurringchargenextdate { get; set; } 

        [JsonProperty("billforrecurringprepayamount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Billforrecurringprepayamount { get; set; } 

        [JsonProperty("prepayrecurringcharge", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Prepayrecurringcharge { get; set; } 

        [JsonProperty("prepayrecurringhours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Prepayrecurringhours { get; set; } 

        [JsonProperty("prepayrecurringchargebp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Prepayrecurringchargebp { get; set; } 

        [JsonProperty("accountsemailaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Accountsemailaddress { get; set; } 

        [JsonProperty("disclaimermatchstring", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Disclaimermatchstring { get; set; } 

        [JsonProperty("paymentterms", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Paymentterms { get; set; } 

        [JsonProperty("showallnonbillable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showallnonbillable { get; set; } 

        [JsonProperty("billinggroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Billinggroup { get; set; } 

        [JsonProperty("autotopupthreshhold", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Autotopupthreshhold { get; set; } 

        [JsonProperty("autotopuptoamount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Autotopuptoamount { get; set; } 

        [JsonProperty("autotopupcostperhour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Autotopupcostperhour { get; set; } 

        [JsonProperty("autotopupbyamount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Autotopupbyamount { get; set; } 

        [JsonProperty("surchargeid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Surchargeid { get; set; } 

        [JsonProperty("billingtemplate_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? BillingtemplateId { get; set; } 

        [JsonProperty("billingtemplate_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? BillingtemplateName { get; set; } 

        [JsonProperty("overidegreeting", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Overidegreeting { get; set; } 

        [JsonProperty("clientpackage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Clientpackage { get; set; } 

        [JsonProperty("scopeofbusiness", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Scopeofbusiness { get; set; } 

        [JsonProperty("preferredagent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Preferredagent { get; set; } 

        [JsonProperty("callhandlingnotes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Callhandlingnotes { get; set; } 

        [JsonProperty("automatic_callscript_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AutomaticCallscriptId { get; set; } 

        [JsonProperty("automatic_callscript_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AutomaticCallscriptName { get; set; } 

        [JsonProperty("teamviewerpassword", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Teamviewerpassword { get; set; } 

        [JsonProperty("customertype_new", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CustomertypeNew { get; set; } 

        [JsonProperty("discountperc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Discountperc { get; set; } 

        [JsonProperty("showfaqfortoplevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showfaqfortoplevel { get; set; } 

        [JsonProperty("accountsccemailaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Accountsccemailaddress { get; set; } 

        [JsonProperty("isopportunity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Isopportunity { get; set; } 

        [JsonProperty("snowname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Snowname { get; set; } 

        [JsonProperty("main_site_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MainSiteId { get; set; } 

        [JsonProperty("main_site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? MainSiteName { get; set; } 

        [JsonProperty("linked_organisation_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LinkedOrganisationId { get; set; } 

        [JsonProperty("all_organisations_allowed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllOrganisationsAllowed { get; set; } 

        [JsonProperty("allowed_organisations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Organisation>? AllowedOrganisations { get; set; } 

        [JsonProperty("override_signature", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OverrideSignature { get; set; } 

        [JsonProperty("contractaccountsdesc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Contractaccountsdesc { get; set; } 

        [JsonProperty("prepayaccountsdesc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Prepayaccountsdesc { get; set; } 

        [JsonProperty("site_update", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Site>? SiteUpdate { get; set; } 

        [JsonProperty("newclient_sitename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewclientSitename { get; set; } 

        [JsonProperty("newclient_phonenumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewclientPhonenumber { get; set; } 

        [JsonProperty("newclient_domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewclientDomain { get; set; } 

        [JsonProperty("newclient_timezone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewclientTimezone { get; set; } 

        [JsonProperty("newclient_contactname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewclientContactname { get; set; } 

        [JsonProperty("newclient_contactemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewclientContactemail { get; set; } 

        [JsonProperty("newclient_contacttitle", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewclientContacttitle { get; set; } 

        [JsonProperty("newclient_web_access_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewclientWebAccessLevel { get; set; } 

        [JsonProperty("newclient_sendwelcomeemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? NewclientSendwelcomeemail { get; set; } 

        [JsonProperty("newclient_delivery_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AddressStore? NewclientDeliveryAddress { get; set; } 

        [JsonProperty("newclient_countrycode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewclientCountrycode { get; set; } 

        [JsonProperty("newclient_regioncode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewclientRegioncode { get; set; } 

        [JsonProperty("faqlists", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<FAQListHead>? Faqlists { get; set; } 

        [JsonProperty("popup_notes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AreaPopup>? PopupNotes { get; set; } 

        [JsonProperty("_reassign_all_to_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ReassignAllToUser { get; set; } 

        [JsonProperty("allowall_tickettypes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowallTickettypes { get; set; } 

        [JsonProperty("allowed_tickettypes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<RequestType_List>? AllowedTickettypes { get; set; } 

        [JsonProperty("allowall_category1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowallCategory1 { get; set; } 

        [JsonProperty("allowed_category1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CategoryRestriction>? AllowedCategory1 { get; set; } 

        [JsonProperty("allowall_category2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowallCategory2 { get; set; } 

        [JsonProperty("allowed_category2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CategoryRestriction>? AllowedCategory2 { get; set; } 

        [JsonProperty("allowall_category3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowallCategory3 { get; set; } 

        [JsonProperty("allowed_category3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CategoryRestriction>? AllowedCategory3 { get; set; } 

        [JsonProperty("allowall_category4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowallCategory4 { get; set; } 

        [JsonProperty("alocked", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Alocked { get; set; } 

        [JsonProperty("allowed_category4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CategoryRestriction>? AllowedCategory4 { get; set; } 

        [JsonProperty("onhold_ticket_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? OnholdTicketCount { get; set; } 

        [JsonProperty("total_ticket_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalTicketCount { get; set; } 

        [JsonProperty("opened_thismonth_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? OpenedThismonthCount { get; set; } 

        [JsonProperty("billingplans", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ContractDetail>? Billingplans { get; set; } 

        [JsonProperty("overriding_rates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ChargeRate>? OverridingRates { get; set; } 

        [JsonProperty("allowallchargerates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allowallchargerates { get; set; } 

        [JsonProperty("chargerates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ChargeRateArea>? Chargerates { get; set; } 

        [JsonProperty("newclient_siteguid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewclientSiteguid { get; set; } 

        [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isimport { get; set; } 

        [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Importtype { get; set; } 

        [JsonProperty("allow_api_access", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowApiAccess { get; set; } 

        [JsonProperty("api_access_clientid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ApiAccessClientid { get; set; } 

        [JsonProperty("api_access_clientsecret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ApiAccessClientsecret { get; set; } 

        [JsonProperty("thirdpartynhdauthurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Thirdpartynhdauthurl { get; set; } 

        [JsonProperty("thirdpartynhdtenant", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Thirdpartynhdtenant { get; set; } 

        [JsonProperty("thirdpartynhdapiclientid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Thirdpartynhdapiclientid { get; set; } 

        [JsonProperty("new_thirdpartynhdapiclientsecret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewThirdpartynhdapiclientsecret { get; set; } 

        [JsonProperty("areaitems", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AreaItem>? Areaitems { get; set; } 

        [JsonProperty("portal_logo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PortalLogo { get; set; } 

        [JsonProperty("override_portalcolour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? OverridePortalcolour { get; set; } 

        [JsonProperty("portalcolour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(7)]
        public string? Portalcolour { get; set; } 

        [JsonProperty("portalbackgroundimageurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(500)]
        public string? Portalbackgroundimageurl { get; set; } 

        [JsonProperty("ninjarmmid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ninjarmmid { get; set; } 

        [JsonProperty("sales_tax_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SalesTaxType { get; set; } 

        [JsonProperty("purchase_tax_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PurchaseTaxType { get; set; } 

        [JsonProperty("isarchived_xero", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsarchivedXero { get; set; } 

        [JsonProperty("accountsfirstname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Accountsfirstname { get; set; } 

        [JsonProperty("accountslastname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Accountslastname { get; set; } 

        [JsonProperty("sales_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SalesTaxCode { get; set; } 

        [JsonProperty("purchase_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PurchaseTaxCode { get; set; } 

        [JsonProperty("purchase_tax_code_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PurchaseTaxCodeName { get; set; } 

        [JsonProperty("prepayhistory", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<PrepayHistory>? Prepayhistory { get; set; } 

        [JsonProperty("periods", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<PrepayPeriod>? Periods { get; set; } 

        [JsonProperty("prepayrecurringminimumdeduction", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Prepayrecurringminimumdeduction { get; set; } 

        [JsonProperty("prepayrecurringminimumdeductiononlyactive", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Prepayrecurringminimumdeductiononlyactive { get; set; } 

        [JsonProperty("prepayrecurringautomaticdeduction", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Prepayrecurringautomaticdeduction { get; set; } 

        [JsonProperty("prepaytotal", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Prepaytotal { get; set; } 

        [JsonProperty("prepayused", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Prepayused { get; set; } 

        [JsonProperty("prepaybalance", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Prepaybalance { get; set; } 

        [JsonProperty("preferreddeliverymethod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Preferreddeliverymethod { get; set; } 

        [JsonProperty("qbodefaulttax", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Qbodefaulttax { get; set; } 

        [JsonProperty("default_contract", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultContract { get; set; } 

        [JsonProperty("device42id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Device42Id { get; set; } 

        [JsonProperty("xerodetails_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? XerodetailsId { get; set; } 

        [JsonProperty("xero_tenant_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? XeroTenantName { get; set; } 

        [JsonProperty("xero_tracking_category_1_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? XeroTrackingCategory1Name { get; set; } 

        [JsonProperty("xero_tracking_category_2_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? XeroTrackingCategory2Name { get; set; } 

        [JsonProperty("servicenowid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Servicenowid { get; set; } 

        [JsonProperty("isnhserveremaildefault", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isnhserveremaildefault { get; set; } 

        [JsonProperty("datto_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DattoId { get; set; } 

        [JsonProperty("datto_alternate_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DattoAlternateId { get; set; } 

        [JsonProperty("datto_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DattoUrl { get; set; } 

        [JsonProperty("dattocommerce_tenantid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DattocommerceTenantid { get; set; } 

        [JsonProperty("qbodefaulttaxcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Qbodefaulttaxcode { get; set; } 

        [JsonProperty("qbodefaulttaxcodename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Qbodefaulttaxcodename { get; set; } 

        [JsonProperty("qbo_default_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ValueLabelIsNewKeyPair? QboDefaultTaxCode { get; set; } 

        [JsonProperty("connectwiseid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Connectwiseid { get; set; } 

        [JsonProperty("autotaskid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Autotaskid { get; set; } 

        [JsonProperty("import_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AddressStore? ImportAddress { get; set; } 

        [JsonProperty("import_notes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AreaNote>? ImportNotes { get; set; } 

        [JsonProperty("ateraid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ateraid { get; set; } 

        [JsonProperty("kashflowid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Kashflowid { get; set; } 

        [JsonProperty("kashflow_tenant_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? KashflowTenantName { get; set; } 

        [JsonProperty("website", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Website { get; set; } 

        [JsonProperty("alastupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Alastupdate { get; set; } 

        [JsonProperty("service_access", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ServiceRestriction>? ServiceAccess { get; set; } 

        [JsonProperty("service_subscriptions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ServiceUser>? ServiceSubscriptions { get; set; } 

        [JsonProperty("snelstart_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SnelstartId { get; set; } 

        [JsonProperty("default_currency_code_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultCurrencyCodeName { get; set; } 

        [JsonProperty("_apply_billingtemplate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ApplyBillingtemplate { get; set; } 

        [JsonProperty("datto_commerce_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DattoCommerceId { get; set; } 

        [JsonProperty("datto_commerce_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DattoCommerceUrl { get; set; } 

        [JsonProperty("import_azure_tenant", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public CspCustomer? ImportAzureTenant { get; set; } 

        [JsonProperty("import_details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ImportDetailsId { get; set; } 

        [JsonProperty("syncroid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Syncroid { get; set; } 

        [JsonProperty("kbentries", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KBEntry_List>? Kbentries { get; set; } 

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
        public bool? Prepayasamount { get; set; } 

        [JsonProperty("synced_to_intacct", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SyncedToIntacct { get; set; } 

        [JsonProperty("qbo_company_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? QboCompanyName { get; set; } 

        [JsonProperty("oppid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Oppid { get; set; } 

        [JsonProperty("tax_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TaxNumber { get; set; } 

        [JsonProperty("isclientdetails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isclientdetails { get; set; } 

        [JsonProperty("hubspot_lifecycle", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HubspotLifecycle { get; set; } 

        [JsonProperty("hudu_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HuduUrl { get; set; } 

        [JsonProperty("prepayrecurringexpirymonths", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Prepayrecurringexpirymonths { get; set; } 

        [JsonProperty("accountsbccemailaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Accountsbccemailaddress { get; set; } 

        [JsonProperty("defaultcontractoverride", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Defaultcontractoverride { get; set; } 

        [JsonProperty("defaultcontractoverride_ref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultcontractoverrideRef { get; set; } 

        [JsonProperty("sqlimport_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SqlimportId { get; set; } 

        [JsonProperty("external_links", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLink_List>? ExternalLinks { get; set; } 

        [JsonProperty("new_external_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ExternalLink_List? NewExternalLink { get; set; } 

        [JsonProperty("_match_thirdparty_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? MatchThirdpartyId { get; set; } 

        [JsonProperty("_match_integration_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MatchIntegrationId { get; set; } 

        [JsonProperty("_match_integration_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? MatchIntegrationName { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warning { get; set; } 

        [JsonProperty("donotimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Donotimport { get; set; } 

        [JsonProperty("liongardid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Liongardid { get; set; } 

        [JsonProperty("liongard_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? LiongardUrl { get; set; } 

        [JsonProperty("sync_to_liongard", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SyncToLiongard { get; set; } 

        [JsonProperty("regmanagertech_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? RegmanagertechName { get; set; } 

        [JsonProperty("logmanagertech_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? LogmanagertechName { get; set; } 

        [JsonProperty("salesreptech_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SalesreptechName { get; set; } 

        [JsonProperty("default_team_to_salesrep_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DefaultTeamToSalesrepOverride { get; set; } 

        [JsonProperty("default_team_to_salesrep_override_team", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultTeamToSalesrepOverrideTeam { get; set; } 

        [JsonProperty("cxmleadtech_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CxmleadtechName { get; set; } 

        [JsonProperty("portalchatprofile", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Portalchatprofile { get; set; } 

        [JsonProperty("portalchatprofile_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PortalchatprofileName { get; set; } 

        [JsonProperty("kaseyaid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Kaseyaid { get; set; } 

        [JsonProperty("trading_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TradingName { get; set; } 

        [JsonProperty("dbc_company_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DbcCompanyName { get; set; } 

        [JsonProperty("salesforce_dontsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SalesforceDontsync { get; set; } 

        [JsonProperty("stripe_customer_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? StripeCustomerId { get; set; } 

        [JsonProperty("stripe_payment_method_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? StripePaymentMethodId { get; set; } 

        [JsonProperty("stripe_payment_method_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? StripePaymentMethodName { get; set; } 

        [JsonProperty("stripe_paymentmethod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public StripePaymentMethod? StripePaymentmethod { get; set; } 

        [JsonProperty("current_licences", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CurrentLicences { get; set; } 

        [JsonProperty("servicenow_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ServicenowUrl { get; set; } 

        [JsonProperty("servicenow_locale", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ServicenowLocale { get; set; } 

        [JsonProperty("servicenow_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ServicenowUsername { get; set; } 

        [JsonProperty("new_servicenowkey", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewServicenowkey { get; set; } 

        [JsonProperty("servicenow_priority_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? ServicenowPriorityMappings { get; set; } 

        [JsonProperty("servicenow_status_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? ServicenowStatusMappings { get; set; } 

        [JsonProperty("servicenow_impact_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? ServicenowImpactMappings { get; set; } 

        [JsonProperty("servicenow_urgency_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? ServicenowUrgencyMappings { get; set; } 

        [JsonProperty("servicenow_category_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? ServicenowCategoryMappings { get; set; } 

        [JsonProperty("servicenow_assignment_group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ServicenowAssignmentGroup { get; set; } 

        [JsonProperty("servicenow_assignment_group_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ServicenowAssignmentGroupName { get; set; } 

        [JsonProperty("servicenow_assignmentgroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ValueLabelIsNewKeyPair? ServicenowAssignmentgroup { get; set; } 

        [JsonProperty("servicenow_defaultuser_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ServicenowDefaultuserId { get; set; } 

        [JsonProperty("servicenow_defaultuser_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ServicenowDefaultuserName { get; set; } 

        [JsonProperty("servicenow_defaultuser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ValueLabelIsNewKeyPair? ServicenowDefaultuser { get; set; } 

        [JsonProperty("test_servicenow", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? TestServicenow { get; set; } 

        [JsonProperty("sage_business_cloud_details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SageBusinessCloudDetailsId { get; set; } 

        [JsonProperty("sage_business_cloud_details_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SageBusinessCloudDetailsName { get; set; } 

        [JsonProperty("exact_division", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ExactDivision { get; set; } 

        [JsonProperty("exact_division_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ExactDivisionName { get; set; } 

        [JsonProperty("ncentral_details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NcentralDetailsId { get; set; } 

        [JsonProperty("currencyisocode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Currencyisocode { get; set; } 

        [JsonProperty("intacct_location_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? IntacctLocationId { get; set; } 

        [JsonProperty("intacct_location_id_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
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
        public string? NewJirakey { get; set; } 

        [JsonProperty("test_jira", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? TestJira { get; set; } 

        [JsonProperty("jira_servicedesk_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? JiraServicedeskId { get; set; } 

        [JsonProperty("jira_servicedesk_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? JiraServicedeskName { get; set; } 

        [JsonProperty("jira_servicedesk", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ValueLabelIsNewKeyPair? JiraServicedesk { get; set; } 

        [JsonProperty("jira_requesttype_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? JiraRequesttypeMappings { get; set; } 

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

        [JsonProperty("defaultpdftemplateinvoicetickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Defaultpdftemplateinvoicetickets { get; set; } 

        [JsonProperty("defaultpdftemplateinvoiceorders", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Defaultpdftemplateinvoiceorders { get; set; } 

        [JsonProperty("defaultpdftemplateinvoicerecurring", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Defaultpdftemplateinvoicerecurring { get; set; } 

        [JsonProperty("defaultpdftemplateinvoicetickets_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultpdftemplateinvoiceticketsName { get; set; } 

        [JsonProperty("defaultpdftemplateinvoiceorders_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultpdftemplateinvoiceordersName { get; set; } 

        [JsonProperty("defaultpdftemplateinvoicerecurring_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultpdftemplateinvoicerecurringName { get; set; } 

        [JsonProperty("intacct_invoice_save_location", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? IntacctInvoiceSaveLocation { get; set; } 

        [JsonProperty("ingram_micro_details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? IngramMicroDetailsId { get; set; } 

        [JsonProperty("_dont_fire_automations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DontFireAutomations { get; set; } 

        [JsonProperty("main_delivery_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AddressStore? MainDeliveryAddress { get; set; } 

        [JsonProperty("main_invoice_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AddressStore? MainInvoiceAddress { get; set; } 

        [JsonProperty("main_contact_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? MainContactName { get; set; } 

        [JsonProperty("main_contact_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? MainContactEmail { get; set; } 

        [JsonProperty("main_contact_phonenumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? MainContactPhonenumber { get; set; } 

        [JsonProperty("main_contact_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MainContactId { get; set; } 

        [JsonProperty("main_phonenumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? MainPhonenumber { get; set; } 

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

        [JsonProperty("servicenow_enable_webhook", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ServicenowEnableWebhook { get; set; } 

        [JsonProperty("new_servicenow_webhooksecret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewServicenowWebhooksecret { get; set; } 

        [JsonProperty("servicenow_webhook_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ServicenowWebhookUser { get; set; } 

        [JsonProperty("servicenow_webhook_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ServicenowWebhookUserName { get; set; } 

        [JsonProperty("servicenow_webhook_tickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ServicenowWebhookTickettype { get; set; } 

        [JsonProperty("servicenow_webhook_tickettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ServicenowWebhookTickettypeName { get; set; } 

        [JsonProperty("myob_tenant", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MyobTenant { get; set; } 

        [JsonProperty("myob_tenant_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? MyobTenantName { get; set; } 

        [JsonProperty("sync_servicenow_attachments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SyncServicenowAttachments { get; set; } 

        [JsonProperty("twilio_subaccount_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TwilioSubaccountName { get; set; } 

        [JsonProperty("twilio_subaccount_created", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? TwilioSubaccountCreated { get; set; } 

        [JsonProperty("twilio_subaccount_sid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TwilioSubaccountSid { get; set; } 

        [JsonProperty("twilio_subaccount_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TwilioSubaccountStatus { get; set; } 

        [JsonProperty("twilio_subaccount_authtoken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TwilioSubaccountAuthtoken { get; set; } 

        [JsonProperty("_create_twilio_subaccount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? CreateTwilioSubaccount { get; set; } 

        [JsonProperty("_close_twilio_subaccount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? CloseTwilioSubaccount { get; set; } 

        [JsonProperty("_pauseunpause_twilio_subaccount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? PauseunpauseTwilioSubaccount { get; set; } 

        [JsonProperty("_create_twilio_recurringinvoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? CreateTwilioRecurringinvoice { get; set; } 

        [JsonProperty("twilio_recurring_invoice_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TwilioRecurringInvoiceId { get; set; } 

        [JsonProperty("override_layout_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? OverrideLayoutId { get; set; } 

        [JsonProperty("override_layout_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OverrideLayoutName { get; set; } 

        [JsonProperty("extratabs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Tabname>? Extratabs { get; set; } 

        [JsonProperty("servicenow_team_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? ServicenowTeamMappings { get; set; } 

        [JsonProperty("servicenow_ticket_sync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ServicenowTicketSync { get; set; } 

        [JsonProperty("servicenow_ticket_sync_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? ServicenowTicketSyncList { get; set; } 

        [JsonProperty("servicenow_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? ServicenowFieldmappings { get; set; } 

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

        [JsonProperty("invoice_mailbox_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? InvoiceMailboxOverride { get; set; } 

        [JsonProperty("quote_mailbox_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? QuoteMailboxOverride { get; set; } 

        [JsonProperty("_merge_client_into", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MergeClientInto { get; set; } 

        [JsonProperty("invoice_tickets_seperately_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? InvoiceTicketsSeperatelyOverride { get; set; } 

        [JsonProperty("servicenow_authtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ServicenowAuthtype { get; set; } 

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
        public TableEnum? Table { get; set; } 

        [JsonProperty("logo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Logo { get; set; } 

        [JsonProperty("regmanagertech", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Regmanagertech { get; set; } 

        [JsonProperty("logmanagertech", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Logmanagertech { get; set; } 

        [JsonProperty("salesreptech", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Salesreptech { get; set; } 

        [JsonProperty("accountownertech", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Accountownertech { get; set; } 

        [JsonProperty("cxmleadtech", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Cxmleadtech { get; set; } 

        [JsonProperty("xero_tenant_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? XeroTenantId { get; set; } 

        [JsonProperty("accountsid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Accountsid { get; set; } 

        [JsonProperty("excludefrominvoicesync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Excludefrominvoicesync { get; set; } 

        [JsonProperty("gficlientid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Gficlientid { get; set; } 

        [JsonProperty("overridepdftemplateinvoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Overridepdftemplateinvoice { get; set; } 

        [JsonProperty("overridepdftemplateinvoice_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OverridepdftemplateinvoiceName { get; set; } 

        [JsonProperty("kashflow_tenant_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? KashflowTenantId { get; set; } 

        [JsonProperty("client_to_invoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ClientToInvoice { get; set; } 

        [JsonProperty("client_to_invoice_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ClientToInvoiceName { get; set; } 

        [JsonProperty("invoiceduedaysextraclient", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Invoiceduedaysextraclient { get; set; } 

        [JsonProperty("itglue_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ItglueId { get; set; } 

        [JsonProperty("clientcurrency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Clientcurrency { get; set; } 

        [JsonProperty("sentinel_subscription_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SentinelSubscriptionId { get; set; } 

        [JsonProperty("sentinel_workspace_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SentinelWorkspaceName { get; set; } 

        [JsonProperty("sentinel_resource_group_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SentinelResourceGroupName { get; set; } 

        [JsonProperty("sentinel_tenant_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SentinelTenantId { get; set; } 

        [JsonProperty("sentinel_tenant_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SentinelTenantName { get; set; } 

        [JsonProperty("default_currency_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultCurrencyCode { get; set; } 

        [JsonProperty("client_to_invoice_recurring", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ClientToInvoiceRecurring { get; set; } 

        [JsonProperty("client_to_invoice_recurring_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ClientToInvoiceRecurringName { get; set; } 

        [JsonProperty("azure_tenants", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AreaAzureTenant>? AzureTenants { get; set; } 

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
        public int? Cautomateid { get; set; } 

        [JsonProperty("dbc_company_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DbcCompanyId { get; set; } 

        [JsonProperty("stopped", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Stopped { get; set; } 

        [JsonProperty("customertype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Customertype { get; set; } 

        [JsonProperty("customer_relationship", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<StringIdNameKeyPair>? CustomerRelationship { get; set; } 

        [JsonProperty("customer_relationship_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CustomerRelationshipList { get; set; } 

        [JsonProperty("servicenow_validated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ServicenowValidated { get; set; } 

        [JsonProperty("sentinel_default_user_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SentinelDefaultUserOverride { get; set; } 

        [JsonProperty("sentinel_default_user_override_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SentinelDefaultUserOverrideName { get; set; } 

        [JsonProperty("jira_validated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? JiraValidated { get; set; } 

        [JsonProperty("ref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ref { get; set; } 

        [JsonProperty("ticket_invoices_for_each_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? TicketInvoicesForEachSite { get; set; } 

        [JsonProperty("intacct_save_location", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? IntacctSaveLocation { get; set; } 

        [JsonProperty("is_vip", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsVip { get; set; } 

        [JsonProperty("accountownertech_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AccountownertechName { get; set; } 

        [JsonProperty("taxable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Taxable { get; set; } 

        [JsonProperty("quickbooks_details", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public QuickBooksDetails? QuickbooksDetails { get; set; } 

        [JsonProperty("percentage_to_survey", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PercentageToSurvey { get; set; } 

        [JsonProperty("billing_plan_text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? BillingPlanText { get; set; } 

        [JsonProperty("overridepdftemplatequote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Overridepdftemplatequote { get; set; } 

        [JsonProperty("overridepdftemplatequote_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OverridepdftemplatequoteName { get; set; } 

        [JsonProperty("avalara_tenant", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AvalaraTenant { get; set; } 

        [JsonProperty("due_date_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DueDateType { get; set; } 

        [JsonProperty("toplevel_quote_currency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ToplevelQuoteCurrency { get; set; } 

        [JsonProperty("is_account", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAccount { get; set; } 

        [JsonProperty("_importtypeid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Importtypeid { get; set; } 

        [JsonProperty("_importthirdpartyid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Importthirdpartyid { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class AreaAzureTenant
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DetailsId { get; set; } 

        [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ClientId { get; set; } 

        [JsonProperty("azure_tenant_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AzureTenantId { get; set; } 

        [JsonProperty("azure_tenant_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AzureTenantName { get; set; } 

        [JsonProperty("new_access_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewAccessToken { get; set; } 

        [JsonProperty("token_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? TokenExpiry { get; set; } 

        [JsonProperty("client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ClientName { get; set; } 

        [JsonProperty("details_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DetailsName { get; set; } 

        [JsonProperty("azure_tenant_domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AzureTenantDomain { get; set; } 

        [JsonProperty("licence_import_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LicenceImportType { get; set; } 

        [JsonProperty("relationship_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? RelationshipType { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class AreaField
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ClientId { get; set; } 

        [JsonProperty("client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ClientName { get; set; } 

        [JsonProperty("field_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? FieldId { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class AreaItem
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ClientId { get; set; } 

        [JsonProperty("item_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ItemId { get; set; } 

        [JsonProperty("quantity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Quantity { get; set; } 

        [JsonProperty("areaitemdesc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Areaitemdesc { get; set; } 

        [JsonProperty("billingperiod_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? BillingperiodId { get; set; } 

        [JsonProperty("startdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Startdate { get; set; } 

        [JsonProperty("invoicenumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Invoicenumber { get; set; } 

        [JsonProperty("lastinvoicedate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Lastinvoicedate { get; set; } 

        [JsonProperty("nextinvoicedate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Nextinvoicedate { get; set; } 

        [JsonProperty("autorenew", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Autorenew { get; set; } 

        [JsonProperty("note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Note { get; set; } 

        [JsonProperty("costprice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Costprice { get; set; } 

        [JsonProperty("sellingprice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Sellingprice { get; set; } 

        [JsonProperty("accounts_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AccountsId { get; set; } 

        [JsonProperty("numberdayswarning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Numberdayswarning { get; set; } 

        [JsonProperty("dsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Dsite { get; set; } 

        [JsonProperty("ddevnum", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ddevnum { get; set; } 

        [JsonProperty("technician", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Technician { get; set; } 

        [JsonProperty("billingcategory_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? BillingcategoryId { get; set; } 

        [JsonProperty("site_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SiteId { get; set; } 

        [JsonProperty("dontinvoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dontinvoice { get; set; } 

        [JsonProperty("enddate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Enddate { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class AreaNote
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ClientId { get; set; } 

        [JsonProperty("supplier_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SupplierId { get; set; } 

        [JsonProperty("sales_order_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SalesOrderId { get; set; } 

        [JsonProperty("purchase_order_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PurchaseOrderId { get; set; } 

        [JsonProperty("quote_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? QuoteId { get; set; } 

        [JsonProperty("invoice_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? InvoiceId { get; set; } 

        [JsonProperty("site_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SiteId { get; set; } 

        [JsonProperty("user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? UserId { get; set; } 

        [JsonProperty("datetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Datetime { get; set; } 

        [JsonProperty("who_agentid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? WhoAgentid { get; set; } 

        [JsonProperty("note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Note { get; set; } 

        [JsonProperty("detail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Detail { get; set; } 

        [JsonProperty("timetaken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Timetaken { get; set; } 

        [JsonProperty("mailentryid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Mailentryid { get; set; } 

        [JsonProperty("nextcalldate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Nextcalldate { get; set; } 

        [JsonProperty("satisfaction", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Satisfaction { get; set; } 

        [JsonProperty("third_party_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ThirdPartyId { get; set; } 

        [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CustomField>? Customfields { get; set; } 

        [JsonProperty("ticketid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ticketid { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warning { get; set; } 

        [JsonProperty("hide_time_taken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HideTimeTaken { get; set; } 

        [JsonProperty("add_to_calendar", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AddToCalendar { get; set; } 

        [JsonProperty("app_user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AppUserId { get; set; } 

        [JsonProperty("app_agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AppAgentId { get; set; } 

        [JsonProperty("app_subject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AppSubject { get; set; } 

        [JsonProperty("nextcallduration", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Nextcallduration { get; set; } 

        [JsonProperty("createdfromaction", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Createdfromaction { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class AreaPopup
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ClientId { get; set; } 

        [JsonProperty("site_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SiteId { get; set; } 

        [JsonProperty("user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? UserId { get; set; } 

        [JsonProperty("date_created", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? DateCreated { get; set; } 

        [JsonProperty("note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Note { get; set; } 

        [JsonProperty("dismissable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dismissable { get; set; } 

        [JsonProperty("read_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ReadStatus { get; set; } 

        [JsonProperty("displaymodal", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Displaymodal { get; set; } 

        [JsonProperty("displayhtml", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Displayhtml { get; set; } 

        [JsonProperty("limitdaterange", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Limitdaterange { get; set; } 

        [JsonProperty("startdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Startdate { get; set; } 

        [JsonProperty("enddate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Enddate { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class AreaRequestType
    {
        [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ClientId { get; set; } 

        [JsonProperty("client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ClientName { get; set; } 

        [JsonProperty("request_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? RequestType { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class AreaSectionDetail
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("ticket_area_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TicketAreaId { get; set; } 

        [JsonProperty("ticket_area_id_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? TicketAreaIdGuid { get; set; } 

        [JsonProperty("team_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TeamId { get; set; } 

        [JsonProperty("team_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? TeamGuid { get; set; } 

        [JsonProperty("team_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TeamName { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class AreaToDo
    {
        [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ClientId { get; set; } 

        [JsonProperty("client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ClientName { get; set; } 

        [JsonProperty("template_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TemplateId { get; set; } 

        [JsonProperty("todo_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TodoId { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class AreaList
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("toplevel_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ToplevelId { get; set; } 

        [JsonProperty("toplevel_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ToplevelName { get; set; } 

        [JsonProperty("inactive", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Inactive { get; set; } 

        [JsonProperty("colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Colour { get; set; } 

        [JsonProperty("confirmemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Confirmemail { get; set; } 

        [JsonProperty("actionemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Actionemail { get; set; } 

        [JsonProperty("clearemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Clearemail { get; set; } 

        [JsonProperty("messagegroup_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MessagegroupId { get; set; } 

        [JsonProperty("from_address_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? FromAddressOverride { get; set; } 

        [JsonProperty("override_org_logo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? OverrideOrgLogo { get; set; } 

        [JsonProperty("override_org_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OverrideOrgName { get; set; } 

        [JsonProperty("override_org_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AddressStore? OverrideOrgAddress { get; set; } 

        [JsonProperty("override_org_phone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OverrideOrgPhone { get; set; } 

        [JsonProperty("override_org_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OverrideOrgEmail { get; set; } 

        [JsonProperty("override_org_website", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OverrideOrgWebsite { get; set; } 

        [JsonProperty("override_org_portalurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OverrideOrgPortalurl { get; set; } 

        [JsonProperty("mailbox_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MailboxOverride { get; set; } 

        [JsonProperty("default_mailbox_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultMailboxId { get; set; } 

        [JsonProperty("calldate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Calldate { get; set; } 

        [JsonProperty("item_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ItemTaxCode { get; set; } 

        [JsonProperty("service_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ServiceTaxCode { get; set; } 

        [JsonProperty("prepay_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PrepayTaxCode { get; set; } 

        [JsonProperty("contract_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ContractTaxCode { get; set; } 

        [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CustomField>? Customfields { get; set; } 

        [JsonProperty("custombuttons", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CustomButton>? Custombuttons { get; set; } 

        [JsonProperty("attachments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Attachment>? Attachments { get; set; } 

        [JsonProperty("site_fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<FieldHelper>? SiteFields { get; set; } 

        [JsonProperty("pritech", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Pritech { get; set; } 

        [JsonProperty("sectech", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sectech { get; set; } 

        [JsonProperty("accountmanagertech", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Accountmanagertech { get; set; } 

        [JsonProperty("notes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Notes { get; set; } 

        [JsonProperty("thirdpartynhdapiurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Thirdpartynhdapiurl { get; set; } 

        [JsonProperty("xeroid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Xeroid { get; set; } 

        [JsonProperty("open_ticket_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? OpenTicketCount { get; set; } 

        [JsonProperty("opps_ticket_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? OppsTicketCount { get; set; } 

        [JsonProperty("use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Use { get; set; } 

        [JsonProperty("key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Key { get; set; } 

        [JsonProperty("table", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public TableEnum? Table { get; set; } 

        [JsonProperty("logo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Logo { get; set; } 

        [JsonProperty("regmanagertech", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Regmanagertech { get; set; } 

        [JsonProperty("logmanagertech", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Logmanagertech { get; set; } 

        [JsonProperty("salesreptech", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Salesreptech { get; set; } 

        [JsonProperty("accountownertech", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Accountownertech { get; set; } 

        [JsonProperty("cxmleadtech", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Cxmleadtech { get; set; } 

        [JsonProperty("xero_tenant_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? XeroTenantId { get; set; } 

        [JsonProperty("accountsid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Accountsid { get; set; } 

        [JsonProperty("excludefrominvoicesync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Excludefrominvoicesync { get; set; } 

        [JsonProperty("gficlientid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Gficlientid { get; set; } 

        [JsonProperty("overridepdftemplateinvoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Overridepdftemplateinvoice { get; set; } 

        [JsonProperty("overridepdftemplateinvoice_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OverridepdftemplateinvoiceName { get; set; } 

        [JsonProperty("kashflow_tenant_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? KashflowTenantId { get; set; } 

        [JsonProperty("client_to_invoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ClientToInvoice { get; set; } 

        [JsonProperty("client_to_invoice_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ClientToInvoiceName { get; set; } 

        [JsonProperty("invoiceduedaysextraclient", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Invoiceduedaysextraclient { get; set; } 

        [JsonProperty("itglue_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ItglueId { get; set; } 

        [JsonProperty("clientcurrency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Clientcurrency { get; set; } 

        [JsonProperty("sentinel_subscription_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SentinelSubscriptionId { get; set; } 

        [JsonProperty("sentinel_workspace_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SentinelWorkspaceName { get; set; } 

        [JsonProperty("sentinel_resource_group_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SentinelResourceGroupName { get; set; } 

        [JsonProperty("sentinel_tenant_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SentinelTenantId { get; set; } 

        [JsonProperty("sentinel_tenant_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SentinelTenantName { get; set; } 

        [JsonProperty("default_currency_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultCurrencyCode { get; set; } 

        [JsonProperty("client_to_invoice_recurring", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ClientToInvoiceRecurring { get; set; } 

        [JsonProperty("client_to_invoice_recurring_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ClientToInvoiceRecurringName { get; set; } 

        [JsonProperty("azure_tenants", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AreaAzureTenant>? AzureTenants { get; set; } 

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
        public int? Cautomateid { get; set; } 

        [JsonProperty("dbc_company_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DbcCompanyId { get; set; } 

        [JsonProperty("stopped", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Stopped { get; set; } 

        [JsonProperty("customertype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Customertype { get; set; } 

        [JsonProperty("customer_relationship", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<StringIdNameKeyPair>? CustomerRelationship { get; set; } 

        [JsonProperty("customer_relationship_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CustomerRelationshipList { get; set; } 

        [JsonProperty("servicenow_validated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ServicenowValidated { get; set; } 

        [JsonProperty("sentinel_default_user_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SentinelDefaultUserOverride { get; set; } 

        [JsonProperty("sentinel_default_user_override_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SentinelDefaultUserOverrideName { get; set; } 

        [JsonProperty("jira_validated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? JiraValidated { get; set; } 

        [JsonProperty("ref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ref { get; set; } 

        [JsonProperty("ticket_invoices_for_each_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? TicketInvoicesForEachSite { get; set; } 

        [JsonProperty("intacct_save_location", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? IntacctSaveLocation { get; set; } 

        [JsonProperty("is_vip", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsVip { get; set; } 

        [JsonProperty("accountownertech_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AccountownertechName { get; set; } 

        [JsonProperty("taxable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Taxable { get; set; } 

        [JsonProperty("quickbooks_details", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public QuickBooksDetails? QuickbooksDetails { get; set; } 

        [JsonProperty("percentage_to_survey", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PercentageToSurvey { get; set; } 

        [JsonProperty("billing_plan_text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? BillingPlanText { get; set; } 

        [JsonProperty("overridepdftemplatequote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Overridepdftemplatequote { get; set; } 

        [JsonProperty("overridepdftemplatequote_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OverridepdftemplatequoteName { get; set; } 

        [JsonProperty("avalara_tenant", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AvalaraTenant { get; set; } 

        [JsonProperty("due_date_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DueDateType { get; set; } 

        [JsonProperty("toplevel_quote_currency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ToplevelQuoteCurrency { get; set; } 

        [JsonProperty("is_account", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAccount { get; set; } 

        [JsonProperty("_importtypeid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Importtypeid { get; set; } 

        [JsonProperty("_importthirdpartyid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Importthirdpartyid { get; set; } 

        [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Importtype { get; set; } 

        [JsonProperty("new_external_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ExternalLink_List? NewExternalLink { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class AssignSchedule
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("day", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Day { get; set; } 

        [JsonProperty("time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Time { get; set; } 

        [JsonProperty("assignto_agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AssigntoAgentId { get; set; } 

        [JsonProperty("status_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? StatusId { get; set; } 

        [JsonProperty("tickettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TickettypeId { get; set; } 

        [JsonProperty("last_run_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? LastRunDate { get; set; } 

        [JsonProperty("interval", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Interval { get; set; } 

        [JsonProperty("paused", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Paused { get; set; } 

        [JsonProperty("asslinked_tickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AsslinkedTickettype { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class AteraAlert
    {
        [JsonProperty("alertID", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AlertId { get; set; } 

        [JsonProperty("code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Code { get; set; } 

        [JsonProperty("source", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Source { get; set; } 

        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Title { get; set; } 

        [JsonProperty("severity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Severity { get; set; } 

        [JsonProperty("created", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Created { get; set; } 

        [JsonProperty("snoozedEndDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? SnoozedEndDate { get; set; } 

        [JsonProperty("deviceGuid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DeviceGuid { get; set; } 

        [JsonProperty("archived", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Archived { get; set; } 

        [JsonProperty("alertCategoryID", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AlertCategoryId { get; set; } 

        [JsonProperty("archivedDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? ArchivedDate { get; set; } 

        [JsonProperty("alertMessage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AlertMessage { get; set; } 

        [JsonProperty("deviceName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DeviceName { get; set; } 

        [JsonProperty("customerID", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CustomerId { get; set; } 

        [JsonProperty("customerName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CustomerName { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class Attachment
    {
        [JsonProperty("third_party_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ThirdPartyId { get; set; } 

        [JsonProperty("link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Link { get; set; } 

        [JsonProperty("content_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ContentType { get; set; } 

        [JsonProperty("last_updated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? LastUpdated { get; set; } 

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("filename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Filename { get; set; } 

        [JsonProperty("datecreated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Datecreated { get; set; } 

        [JsonProperty("note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Note { get; set; } 

        [JsonProperty("filesize", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Filesize { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; } 

        [JsonProperty("unique_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? UniqueId { get; set; } 

        [JsonProperty("desc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Desc { get; set; } 

        [JsonProperty("isimage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isimage { get; set; } 

        [JsonProperty("data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public byte[]? Data { get; set; } 

        [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TicketId { get; set; } 

        [JsonProperty("action_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ActionId { get; set; } 

        [JsonProperty("user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? UserId { get; set; } 

        [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AgentId { get; set; } 

        [JsonProperty("attachmentaction_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AttachmentactionId { get; set; } 

        [JsonProperty("_canupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Canupdate { get; set; } 

        [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Guid { get; set; } 

        [JsonProperty("image_upload_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ImageUploadId { get; set; } 

        [JsonProperty("image_upload_key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ImageUploadKey { get; set; } 

        [JsonProperty("file", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public byte[]? File { get; set; } 

        [JsonProperty("_enduserportalpdfprint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enduserportalpdfprint { get; set; } 

        [JsonProperty("anon_outcomeid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AnonOutcomeid { get; set; } 

        [JsonProperty("has_scanned", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HasScanned { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warning { get; set; } 

        [JsonProperty("_is_new_version", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsNewVersion { get; set; } 

        [JsonProperty("parent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ParentName { get; set; } 

        [JsonProperty("version_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? VersionCount { get; set; } 

        [JsonProperty("_alreadyuploaded", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Alreadyuploaded { get; set; } 

        [JsonProperty("copy_from_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CopyFromId { get; set; } 

        [JsonProperty("new_external_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ExternalLink_List? NewExternalLink { get; set; } 

        [JsonProperty("_match_thirdparty_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? MatchThirdpartyId { get; set; } 

        [JsonProperty("_match_integration_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MatchIntegrationId { get; set; } 

        [JsonProperty("_match_integration_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? MatchIntegrationName { get; set; } 

        [JsonProperty("import_details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ImportDetailsId { get; set; } 

        [JsonProperty("external_links", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLink_List>? ExternalLinks { get; set; } 

        [JsonProperty("showforusers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showforusers { get; set; } 

        [JsonProperty("showonchild", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showonchild { get; set; } 

        [JsonProperty("showonrelated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showonrelated { get; set; } 

        [JsonProperty("data_base64", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DataBase64 { get; set; } 

        [JsonProperty("download_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DownloadUrl { get; set; } 

        [JsonProperty("third_party_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ThirdPartyToken { get; set; } 

        [JsonProperty("already_posted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AlreadyPosted { get; set; } 

        [JsonProperty("faultid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Faultid { get; set; } 

        [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isimport { get; set; } 

        [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Importtype { get; set; } 

        [JsonProperty("s3url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? S3Url { get; set; } 

        [JsonProperty("att_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AttLink { get; set; } 

        [JsonProperty("child_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ChildCount { get; set; } 

        [JsonProperty("parent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ParentId { get; set; } 

        [JsonProperty("linked_version_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LinkedVersionId { get; set; } 

        [JsonProperty("allow_anon_upload", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowAnonUpload { get; set; } 

        [JsonProperty("tickettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TickettypeId { get; set; } 

        [JsonProperty("tickettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TickettypeGuid { get; set; } 

        [JsonProperty("validate_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ValidateGuid { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class AttachmentList
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("filename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Filename { get; set; } 

        [JsonProperty("datecreated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Datecreated { get; set; } 

        [JsonProperty("note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Note { get; set; } 

        [JsonProperty("filesize", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Filesize { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; } 

        [JsonProperty("unique_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? UniqueId { get; set; } 

        [JsonProperty("desc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Desc { get; set; } 

        [JsonProperty("isimage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isimage { get; set; } 

        [JsonProperty("showforusers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showforusers { get; set; } 

        [JsonProperty("showonchild", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showonchild { get; set; } 

        [JsonProperty("showonrelated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showonrelated { get; set; } 

        [JsonProperty("data_base64", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DataBase64 { get; set; } 

        [JsonProperty("download_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DownloadUrl { get; set; } 

        [JsonProperty("third_party_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ThirdPartyToken { get; set; } 

        [JsonProperty("third_party_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ThirdPartyId { get; set; } 

        [JsonProperty("already_posted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AlreadyPosted { get; set; } 

        [JsonProperty("faultid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Faultid { get; set; } 

        [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isimport { get; set; } 

        [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Importtype { get; set; } 

        [JsonProperty("s3url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? S3Url { get; set; } 

        [JsonProperty("att_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AttLink { get; set; } 

        [JsonProperty("child_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ChildCount { get; set; } 

        [JsonProperty("parent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ParentId { get; set; } 

        [JsonProperty("linked_version_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LinkedVersionId { get; set; } 

        [JsonProperty("allow_anon_upload", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowAnonUpload { get; set; } 

        [JsonProperty("tickettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TickettypeId { get; set; } 

        [JsonProperty("tickettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TickettypeGuid { get; set; } 

        [JsonProperty("validate_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ValidateGuid { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class AttachmentView
    {
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; } 

        [JsonProperty("unique_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? UniqueId { get; set; } 

        [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TicketId { get; set; } 

        [JsonProperty("action_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ActionId { get; set; } 

        [JsonProperty("record_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? RecordCount { get; set; } 

        [JsonProperty("attachments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AttachmentList>? Attachments { get; set; } 

        [JsonProperty("page_no", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PageNo { get; set; } 

        [JsonProperty("page_size", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PageSize { get; set; } 

        [JsonProperty("folders", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<LongIdNameKeyPair>? Folders { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class Audit
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TicketId { get; set; } 

        [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AgentId { get; set; } 

        [JsonProperty("date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Date { get; set; } 

        [JsonProperty("value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Value { get; set; } 

        [JsonProperty("to", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? To { get; set; } 

        [JsonProperty("from", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? From { get; set; } 

        [JsonProperty("table_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TableName { get; set; } 

        [JsonProperty("id1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id1 { get; set; } 

        [JsonProperty("id2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id2 { get; set; } 

        [JsonProperty("clientid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Clientid { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warning { get; set; } 

        [JsonProperty("actoutcome", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Actoutcome { get; set; } 

        [JsonProperty("user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? UserId { get; set; } 

        [JsonProperty("username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Username { get; set; } 

        [JsonProperty("datetime_to", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? DatetimeTo { get; set; } 

        [JsonProperty("datetime_from", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? DatetimeFrom { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class AuditPasswordField
    {
        [JsonProperty("object_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ObjectType { get; set; } 

        [JsonProperty("object_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ObjectId { get; set; } 

        [JsonProperty("field_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? FieldId { get; set; } 

        [JsonProperty("value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Value { get; set; } 

        [JsonProperty("object", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public PasswordObjectType? Object { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class Autoassign
    {
        [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Guid { get; set; } 

        [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intent { get; set; } 

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("precedence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Precedence { get; set; } 

        [JsonProperty("use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Use { get; set; } 

        [JsonProperty("stopmatching", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Stopmatching { get; set; } 

        [JsonProperty("new_agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewAgentId { get; set; } 

        [JsonProperty("new_agent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewAgentName { get; set; } 

        [JsonProperty("new_team", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewTeam { get; set; } 

        [JsonProperty("new_priority_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewPriorityId { get; set; } 

        [JsonProperty("new_status_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewStatusId { get; set; } 

        [JsonProperty("newstatus_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? NewstatusGuid { get; set; } 

        [JsonProperty("new_sla_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewSlaId { get; set; } 

        [JsonProperty("new_sla_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? NewSlaGuid { get; set; } 

        [JsonProperty("new_category_1_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewCategory1Id { get; set; } 

        [JsonProperty("new_category_1_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? NewCategory1Guid { get; set; } 

        [JsonProperty("new_category_1_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewCategory1Name { get; set; } 

        [JsonProperty("new_product_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewProductId { get; set; } 

        [JsonProperty("new_product_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewProductName { get; set; } 

        [JsonProperty("new_workflow_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewWorkflowId { get; set; } 

        [JsonProperty("newworkflow_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? NewworkflowGuid { get; set; } 

        [JsonProperty("new_workflow_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewWorkflowName { get; set; } 

        [JsonProperty("dontshownotification", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dontshownotification { get; set; } 

        [JsonProperty("criteria", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AutoassignCriteria>? Criteria { get; set; } 

        [JsonProperty("outcomes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AutoassignOutcome>? Outcomes { get; set; } 

        [JsonProperty("_domatch", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Domatch { get; set; } 

        [JsonProperty("user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Users? User { get; set; } 

        [JsonProperty("matched_rule_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MatchedRuleCount { get; set; } 

        [JsonProperty("matched_ids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? MatchedIds { get; set; } 

        [JsonProperty("outcome_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? OutcomeId { get; set; } 

        [JsonProperty("outcome_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OutcomeName { get; set; } 

        [JsonProperty("new_category_2_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewCategory2Id { get; set; } 

        [JsonProperty("new_category_2_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? NewCategory2Guid { get; set; } 

        [JsonProperty("new_category_2_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewCategory2Name { get; set; } 

        [JsonProperty("new_category_3_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewCategory3Id { get; set; } 

        [JsonProperty("new_category_3_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? NewCategory3Guid { get; set; } 

        [JsonProperty("new_category_3_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewCategory3Name { get; set; } 

        [JsonProperty("new_category_4_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewCategory4Id { get; set; } 

        [JsonProperty("new_category_4_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? NewCategory4Guid { get; set; } 

        [JsonProperty("new_category_4_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewCategory4Name { get; set; } 

        [JsonProperty("script_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ScriptId { get; set; } 

        [JsonProperty("script_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ScriptName { get; set; } 

        [JsonProperty("rule_ids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<int>? RuleIds { get; set; } 

        [JsonProperty("new_template_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewTemplateId { get; set; } 

        [JsonProperty("newtemplate_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? NewtemplateGuid { get; set; } 

        [JsonProperty("new_template_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewTemplateName { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warning { get; set; } 

        [JsonProperty("popupmsg", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Popupmsg { get; set; } 

        [JsonProperty("popup_notes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AreaPopup>? PopupNotes { get; set; } 

        [JsonProperty("flowdetail_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? FlowdetailId { get; set; } 

        [JsonProperty("batch_size", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? BatchSize { get; set; } 

        [JsonProperty("batch_sleep", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? BatchSleep { get; set; } 

        [JsonProperty("access_control", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? AccessControl { get; set; } 

        [JsonProperty("access_control_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AccessControlLevel { get; set; } 

        [JsonProperty("events", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AgentNotification>? Events { get; set; } 

        [JsonProperty("new_colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewColour { get; set; } 

        [JsonProperty("set_colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SetColour { get; set; } 

        [JsonProperty("active", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Active { get; set; } 

        [JsonProperty("olas", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<WorkflowTarget>? Olas { get; set; } 

        [JsonProperty("database_lookups", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<PartsLookup>? DatabaseLookups { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class AutoassignCriteria
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("rule_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? RuleId { get; set; } 

        [JsonProperty("autoassign_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? AutoassignGuid { get; set; } 

        [JsonProperty("qualification_criteria_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? QualificationCriteriaId { get; set; } 

        [JsonProperty("fieldname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Fieldname { get; set; } 

        [JsonProperty("value_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ValueType { get; set; } 

        [JsonProperty("value_type_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ValueTypeId { get; set; } 

        [JsonProperty("value_int", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ValueInt { get; set; } 

        [JsonProperty("valueint_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? ValueintGuid { get; set; } 

        [JsonProperty("value_string", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ValueString { get; set; } 

        [JsonProperty("value_datetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? ValueDatetime { get; set; } 

        [JsonProperty("partialmatch", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Partialmatch { get; set; } 

        [JsonProperty("value_float", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? ValueFloat { get; set; } 

        [JsonProperty("matchseparatedvalues", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Matchseparatedvalues { get; set; } 

        [JsonProperty("value_display", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ValueDisplay { get; set; } 

        [JsonProperty("alt_value_display", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AltValueDisplay { get; set; } 

        [JsonProperty("tablename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Tablename { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; } 

        [JsonProperty("flowsubdetails_criteria_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? FlowsubdetailsCriteriaId { get; set; } 

        [JsonProperty("use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Use { get; set; } 

        [JsonProperty("chatprofile_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ChatprofileId { get; set; } 

        [JsonProperty("chatprofile_flow_seq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ChatprofileFlowSeq { get; set; } 

        [JsonProperty("timezonestring", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Timezonestring { get; set; } 

        [JsonProperty("match_after_start", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? MatchAfterStart { get; set; } 

        [JsonProperty("match_after_target", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? MatchAfterTarget { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warning { get; set; } 

        [JsonProperty("stdid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Stdid { get; set; } 

        [JsonProperty("contract_rule_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ContractRuleId { get; set; } 

        [JsonProperty("utcoffset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Utcoffset { get; set; } 

        [JsonProperty("eventrule_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? EventruleId { get; set; } 

        [JsonProperty("eventrule_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? EventruleGuid { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class AutoassignOutcome
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("rule_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? RuleId { get; set; } 

        [JsonProperty("autoassign_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? AutoassignGuid { get; set; } 

        [JsonProperty("fieldid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Fieldid { get; set; } 

        [JsonProperty("fieldname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Fieldname { get; set; } 

        [JsonProperty("value_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ValueType { get; set; } 

        [JsonProperty("value_int", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ValueInt { get; set; } 

        [JsonProperty("value_string", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ValueString { get; set; } 

        [JsonProperty("value_datetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? ValueDatetime { get; set; } 

        [JsonProperty("value_float", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? ValueFloat { get; set; } 

        [JsonProperty("value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public object? Value { get; set; } 

        [JsonProperty("value_display", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ValueDisplay { get; set; } 

        [JsonProperty("value_type_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ValueTypeId { get; set; } 

        [JsonProperty("is_dummy", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDummy { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class AutomateAlert
    {
        [JsonProperty("action", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Action { get; set; } 

        [JsonProperty("ticket", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AutomateTicket? Ticket { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class AutomateComment
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("body", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Body { get; set; } 

        [JsonProperty("user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AutomateUser? User { get; set; } 

        [JsonProperty("createdDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? CreatedDate { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class AutomateReference
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class AutomateTicket
    {
        [JsonProperty("ticketId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TicketId { get; set; } 

        [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AutomateReference? Status { get; set; } 

        [JsonProperty("subject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Subject { get; set; } 

        [JsonProperty("body", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Body { get; set; } 

        [JsonProperty("category", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AutomateReference? Category { get; set; } 

        [JsonProperty("priority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AutomateReference? Priority { get; set; } 

        [JsonProperty("client", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AutomateReference? Client { get; set; } 

        [JsonProperty("location", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AutomateReference? Location { get; set; } 

        [JsonProperty("computer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AutomateReference? Computer { get; set; } 

        [JsonProperty("dueDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? DueDate { get; set; } 

        [JsonProperty("startDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? StartDate { get; set; } 

        [JsonProperty("contactDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? ContactDate { get; set; } 

        [JsonProperty("updateDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? UpdateDate { get; set; } 

        [JsonProperty("from", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? From { get; set; } 

        [JsonProperty("cc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Cc { get; set; } 

        [JsonProperty("supportLevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SupportLevel { get; set; } 

        [JsonProperty("externalId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ExternalId { get; set; } 

        [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Guid { get; set; } 

        [JsonProperty("comments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AutomateComment>? Comments { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class AutomateUser
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("emailAddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? EmailAddress { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class AuvikAlert
    {
        [JsonProperty("entityId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? EntityId { get; set; } 

        [JsonProperty("subject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Subject { get; set; } 

        [JsonProperty("alertStatusString", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AlertStatusString { get; set; } 

        [JsonProperty("alertId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AlertId { get; set; } 

        [JsonProperty("alertName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AlertName { get; set; } 

        [JsonProperty("entityName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? EntityName { get; set; } 

        [JsonProperty("companyName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CompanyName { get; set; } 

        [JsonProperty("entityType", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? EntityType { get; set; } 

        [JsonProperty("date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Date { get; set; } 

        [JsonProperty("link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Link { get; set; } 

        [JsonProperty("alertStatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AlertStatus { get; set; } 

        [JsonProperty("alertDescription", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AlertDescription { get; set; } 

        [JsonProperty("alertSeverityString", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AlertSeverityString { get; set; } 

        [JsonProperty("alertSeverity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AlertSeverity { get; set; } 

        [JsonProperty("companyId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CompanyId { get; set; } 

        [JsonProperty("correlationId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CorrelationId { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class AuvikTenantMod
    {
        [JsonProperty("parentId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ParentId { get; set; } 

        [JsonProperty("parentName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ParentName { get; set; } 

        [JsonProperty("tenantId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TenantId { get; set; } 

        [JsonProperty("tenantName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TenantName { get; set; } 

        [JsonProperty("tenantDomain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TenantDomain { get; set; } 

        [JsonProperty("enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabled { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class AvalaraDetails
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("environment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Environment { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Username { get; set; } 

        [JsonProperty("new_password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewPassword { get; set; } 

        [JsonProperty("new_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? NewMethod { get; set; } 

        [JsonProperty("companyid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Companyid { get; set; } 

        [JsonProperty("client_top_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ClientTopLevel { get; set; } 

        [JsonProperty("supplier_top_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SupplierTopLevel { get; set; } 

        [JsonProperty("client_top_level_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ClientTopLevelName { get; set; } 

        [JsonProperty("supplier_top_level_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SupplierTopLevelName { get; set; } 

        [JsonProperty("company_object", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public StringIdNameKeyPair? CompanyObject { get; set; } 

        [JsonProperty("defaulttax", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Defaulttax { get; set; } 

        [JsonProperty("defaultitem", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Defaultitem { get; set; } 

        [JsonProperty("autosyncentities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Autosyncentities { get; set; } 

        [JsonProperty("autosyncentitiesonupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Autosyncentitiesonupdate { get; set; } 

        [JsonProperty("showmessage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showmessage { get; set; } 

        [JsonProperty("authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Authorized { get; set; } 

        [JsonProperty("syncentities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Syncentities { get; set; } 

        [JsonProperty("defaultcustomercode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Defaultcustomercode { get; set; } 

        [JsonProperty("default_customer_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultCustomerName { get; set; } 

        [JsonProperty("disablerecording", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Disablerecording { get; set; } 

        [JsonProperty("address_mapping_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AddressMappingType { get; set; } 

        [JsonProperty("sync_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? SyncEntitiesList { get; set; } 

        [JsonProperty("sync_committed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SyncCommitted { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class AzureAdConnection
    {
        [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Guid { get; set; } 

        [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intent { get; set; } 

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Domain { get; set; } 

        [JsonProperty("directoryid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Directoryid { get; set; } 

        [JsonProperty("applicationid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Applicationid { get; set; } 

        [JsonProperty("new_client_secret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewClientSecret { get; set; } 

        [JsonProperty("new_access_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewAccessToken { get; set; } 

        [JsonProperty("new_refresh_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewRefreshToken { get; set; } 

        [JsonProperty("token_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? TokenExpiry { get; set; } 

        [JsonProperty("_authcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Authcode { get; set; } 

        [JsonProperty("_exchangecodefortoken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Exchangecodefortoken { get; set; } 

        [JsonProperty("mappings_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? MappingsUser { get; set; } 

        [JsonProperty("mappings_agent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? MappingsAgent { get; set; } 

        [JsonProperty("mappings_agent_roles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? MappingsAgentRoles { get; set; } 

        [JsonProperty("mappings_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AzureAdMapping>? MappingsSite { get; set; } 

        [JsonProperty("user_matching_fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? UserMatchingFields { get; set; } 

        [JsonProperty("agent_matching_fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AgentMatchingFields { get; set; } 

        [JsonProperty("user_matching_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? UserMatchingList { get; set; } 

        [JsonProperty("agent_matching_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? AgentMatchingList { get; set; } 

        [JsonProperty("halointegratorenabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halointegratorenabled { get; set; } 

        [JsonProperty("halointegrator_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HalointegratorLastsync { get; set; } 

        [JsonProperty("halointegrator_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HalointegratorLasterror { get; set; } 

        [JsonProperty("redirect_uri", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? RedirectUri { get; set; } 

        [JsonProperty("mappings_cab", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? MappingsCab { get; set; } 

        [JsonProperty("manage_licenses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ManageLicenses { get; set; } 

        [JsonProperty("licensed_roles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? LicensedRoles { get; set; } 

        [JsonProperty("licensed_roles_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<StringIdNameKeyPair>? LicensedRolesList { get; set; } 

        [JsonProperty("tenant_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TenantType { get; set; } 

        [JsonProperty("mappings_device", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? MappingsDevice { get; set; } 

        [JsonProperty("defaultsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Defaultsite { get; set; } 

        [JsonProperty("defaultsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultsiteName { get; set; } 

        [JsonProperty("assettype_choice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AssettypeChoice { get; set; } 

        [JsonProperty("default_assetgroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultAssetgroup { get; set; } 

        [JsonProperty("default_assetgroup_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? DefaultAssetgroupGuid { get; set; } 

        [JsonProperty("default_assetgroup_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultAssetgroupName { get; set; } 

        [JsonProperty("default_assettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultAssettype { get; set; } 

        [JsonProperty("default_assettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? DefaultAssettypeGuid { get; set; } 

        [JsonProperty("default_assettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultAssettypeName { get; set; } 

        [JsonProperty("assettype_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AssettypeField { get; set; } 

        [JsonProperty("assettype_fieldname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AssettypeFieldname { get; set; } 

        [JsonProperty("import_identifier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ImportIdentifier { get; set; } 

        [JsonProperty("import_identifier_fieldname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ImportIdentifierFieldname { get; set; } 

        [JsonProperty("accountenabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Accountenabled { get; set; } 

        [JsonProperty("authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Authorized { get; set; } 

        [JsonProperty("new_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? NewMethod { get; set; } 

        [JsonProperty("createunmatchedusers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Createunmatchedusers { get; set; } 

        [JsonProperty("unmatchedusersite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Unmatchedusersite { get; set; } 

        [JsonProperty("unmatchedusersite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? UnmatchedusersiteName { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; } 

        [JsonProperty("top_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TopLevel { get; set; } 

        [JsonProperty("auto_create_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoCreateMappings { get; set; } 

        [JsonProperty("auto_allow_sso", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoAllowSso { get; set; } 

        [JsonProperty("top_level_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TopLevelName { get; set; } 

        [JsonProperty("mappings_client", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AreaAzureTenant>? MappingsClient { get; set; } 

        [JsonProperty("default_ticket_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultTicketType { get; set; } 

        [JsonProperty("default_ticket_type_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultTicketTypeName { get; set; } 

        [JsonProperty("default_classification", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultClassification { get; set; } 

        [JsonProperty("default_classification_reason", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultClassificationReason { get; set; } 

        [JsonProperty("default_priority_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultPriorityName { get; set; } 

        [JsonProperty("mappings_ticket", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? MappingsTicket { get; set; } 

        [JsonProperty("intune_dont_update_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IntuneDontUpdateType { get; set; } 

        [JsonProperty("halo_integrator_import_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorImportList { get; set; } 

        [JsonProperty("halo_integrator_import_types", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? HaloIntegratorImportTypes { get; set; } 

        [JsonProperty("intune_enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IntuneEnabled { get; set; } 

        [JsonProperty("licence_import_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LicenceImportType { get; set; } 

        [JsonProperty("graphendpoint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Graphendpoint { get; set; } 

        [JsonProperty("intuneusermatchingfield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Intuneusermatchingfield { get; set; } 

        [JsonProperty("current_scopes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<string>? CurrentScopes { get; set; } 

        [JsonProperty("_dosave", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dosave { get; set; } 

        [JsonProperty("dont_sync_new_tenants", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DontSyncNewTenants { get; set; } 

        [JsonProperty("importunmatchedgroupasserviceaccount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Importunmatchedgroupasserviceaccount { get; set; } 

        [JsonProperty("deactivate_users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DeactivateUsers { get; set; } 

        [JsonProperty("mappings_priority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? MappingsPriority { get; set; } 

        [JsonProperty("allow_subscription_management", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowSubscriptionManagement { get; set; } 

        [JsonProperty("receive_subscription_updated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReceiveSubscriptionUpdated { get; set; } 

        [JsonProperty("graph_host", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? GraphHost { get; set; } 

        [JsonProperty("mappings_user_roles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? MappingsUserRoles { get; set; } 

        [JsonProperty("alternate_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AlternateClientId { get; set; } 

        [JsonProperty("new_alternate_client_secret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewAlternateClientSecret { get; set; } 

        [JsonProperty("default_relationship_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultRelationshipType { get; set; } 

        [JsonProperty("mappings_xtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<XTypeMapping>? MappingsXtype { get; set; } 

        [JsonProperty("intune_delete_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? IntuneDeleteStatus { get; set; } 

        [JsonProperty("intune_delete_status_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? IntuneDeleteStatusName { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warning { get; set; } 

        [JsonProperty("sentinel_default_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SentinelDefaultUser { get; set; } 

        [JsonProperty("sentinel_default_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SentinelDefaultUserName { get; set; } 

        [JsonProperty("named_roles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NamedRoles { get; set; } 

        [JsonProperty("named_roles_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<StringIdNameKeyPair>? NamedRolesList { get; set; } 

        [JsonProperty("new_user_template", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewUserTemplate { get; set; } 

        [JsonProperty("new_user_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewUserType { get; set; } 

        [JsonProperty("mappings_new_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? MappingsNewUser { get; set; } 

        [JsonProperty("new_user_template_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewUserTemplateName { get; set; } 

        [JsonProperty("software_import_licence_matching", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SoftwareImportLicenceMatching { get; set; } 

        [JsonProperty("default_intune_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultIntuneStatus { get; set; } 

        [JsonProperty("default_intune_status_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultIntuneStatusName { get; set; } 

        [JsonProperty("no_manager_role", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NoManagerRole { get; set; } 

        [JsonProperty("no_manager_role_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NoManagerRoleName { get; set; } 

        [JsonProperty("track_sign_in_activity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? TrackSignInActivity { get; set; } 

        [JsonProperty("halointegrator_allowedclientidslist", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelKeyPair>? HalointegratorAllowedclientidslist { get; set; } 

        [JsonProperty("halointegrator_allowedclientids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HalointegratorAllowedclientids { get; set; } 

        [JsonProperty("user_licence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? UserLicence { get; set; } 

        [JsonProperty("user_licence_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? UserLicenceList { get; set; } 

        [JsonProperty("check_licence_list_for_service_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? CheckLicenceListForServiceUser { get; set; } 

        [JsonProperty("exclude_mssense_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ExcludeMssenseDevices { get; set; } 

        [JsonProperty("authentication_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AuthenticationType { get; set; } 

        [JsonProperty("_confirmmanagedidentitysetup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Confirmmanagedidentitysetup { get; set; } 

        [JsonProperty("_confirmclientcredentialssetup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Confirmclientcredentialssetup { get; set; } 

        [JsonProperty("allow_presence_notifications", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowPresenceNotifications { get; set; } 

        [JsonProperty("licence_import_client", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LicenceImportClient { get; set; } 

        [JsonProperty("licence_import_client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? LicenceImportClientName { get; set; } 

        [JsonProperty("assign_licences", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AssignLicences { get; set; } 

        [JsonProperty("resource", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Resource { get; set; } 

        [JsonProperty("only_import_sentinel_comments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? OnlyImportSentinelComments { get; set; } 

        [JsonProperty("use_delta_queries", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseDeltaQueries { get; set; } 

        [JsonProperty("_deltareset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AzureDeltaReset? Deltareset { get; set; } 

        [JsonProperty("intune_user_matching_integration", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? IntuneUserMatchingIntegration { get; set; } 

        [JsonProperty("intune_recovered_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? IntuneRecoveredStatus { get; set; } 

        [JsonProperty("intune_recovered_status_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? IntuneRecoveredStatusName { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class AzureAdFilter
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("mapping_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MappingId { get; set; } 

        [JsonProperty("filter_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? FilterField { get; set; } 

        [JsonProperty("filter_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? FilterType { get; set; } 

        [JsonProperty("filter_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? FilterValue { get; set; } 

        [JsonProperty("query_string", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? QueryString { get; set; } 

        [JsonProperty("version", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Version { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class AzureAdMapping
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("connectionid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Connectionid { get; set; } 

        [JsonProperty("siteid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Siteid { get; set; } 

        [JsonProperty("site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SiteName { get; set; } 

        [JsonProperty("roleid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Roleid { get; set; } 

        [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ClientId { get; set; } 

        [JsonProperty("tenant_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TenantId { get; set; } 

        [JsonProperty("tenant_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TenantName { get; set; } 

        [JsonProperty("filters", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AzureAdFilter>? Filters { get; set; } 

        [JsonProperty("filter_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? FilterCount { get; set; } 

        [JsonProperty("group_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? GroupName { get; set; } 

        [JsonProperty("external_users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ExternalUsers { get; set; } 

        [JsonProperty("group_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? GroupId { get; set; } 

        [JsonProperty("sequenceid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sequenceid { get; set; } 

        [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Description { get; set; } 

        [JsonProperty("site_mapping_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SiteMappingType { get; set; } 

        [JsonProperty("clientid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Clientid { get; set; } 

        [JsonProperty("client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ClientName { get; set; } 

        [JsonProperty("site_mapping_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SiteMappingField { get; set; } 

        [JsonProperty("default_site_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultSiteId { get; set; } 

        [JsonProperty("default_site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultSiteName { get; set; } 

        [JsonProperty("userroleid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Userroleid { get; set; } 

        [JsonProperty("import_photo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ImportPhoto { get; set; } 

        [JsonProperty("site_mappings_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? SiteMappingsUser { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class AzureAssignedLicenses
    {
        [JsonProperty("skuId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SkuId { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class AzureDelta
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("related_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? RelatedGuid { get; set; } 

        [JsonProperty("tenant_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? TenantId { get; set; } 

        [JsonProperty("entity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Entity { get; set; } 

        [JsonProperty("next_delta", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NextDelta { get; set; } 

        [JsonProperty("last_updated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? LastUpdated { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class AzureDeltaReset
    {
        [JsonProperty("tenant", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Tenant { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; } 

        [JsonProperty("result", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Result { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class AzureDevOpsDetails
    {
        [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Guid { get; set; } 

        [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intent { get; set; } 

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("instance_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? InstanceUrl { get; set; } 

        [JsonProperty("new_access_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewAccessToken { get; set; } 

        [JsonProperty("new_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? NewMethod { get; set; } 

        [JsonProperty("fields_to_sync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? FieldsToSync { get; set; } 

        [JsonProperty("fields_to_sync_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? FieldsToSyncList { get; set; } 

        [JsonProperty("sync_mapped_fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SyncMappedFields { get; set; } 

        [JsonProperty("sync_attachments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SyncAttachments { get; set; } 

        [JsonProperty("sync_area_path", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SyncAreaPath { get; set; } 

        [JsonProperty("sync_iteration_path", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SyncIterationPath { get; set; } 

        [JsonProperty("sync_priority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SyncPriority { get; set; } 

        [JsonProperty("sync_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SyncStatus { get; set; } 

        [JsonProperty("sync_start_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SyncStartDate { get; set; } 

        [JsonProperty("sync_target_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SyncTargetDate { get; set; } 

        [JsonProperty("status_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? StatusMappings { get; set; } 

        [JsonProperty("priority_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? PriorityMappings { get; set; } 

        [JsonProperty("areapath_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? AreapathMappings { get; set; } 

        [JsonProperty("iterationpath_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? IterationpathMappings { get; set; } 

        [JsonProperty("otherfield_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? OtherfieldMappings { get; set; } 

        [JsonProperty("area_path_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AreaPathField { get; set; } 

        [JsonProperty("iteration_path_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? IterationPathField { get; set; } 

        [JsonProperty("work_item_description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? WorkItemDescription { get; set; } 

        [JsonProperty("webhook_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? WebhookUsername { get; set; } 

        [JsonProperty("new_webhook_password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewWebhookPassword { get; set; } 

        [JsonProperty("webhook_salt", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? WebhookSalt { get; set; } 

        [JsonProperty("webhook_iterations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? WebhookIterations { get; set; } 

        [JsonProperty("ticket_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TicketType { get; set; } 

        [JsonProperty("ticket_type_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TicketTypeName { get; set; } 

        [JsonProperty("ticket_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TicketUser { get; set; } 

        [JsonProperty("ticket_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TicketUserName { get; set; } 

        [JsonProperty("user_is_created_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UserIsCreatedBy { get; set; } 

        [JsonProperty("sync_summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SyncSummary { get; set; } 

        [JsonProperty("private_updates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? PrivateUpdates { get; set; } 

        [JsonProperty("new_webhook_password_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? NewWebhookPasswordMethod { get; set; } 

        [JsonProperty("enableintegrator", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enableintegrator { get; set; } 

        [JsonProperty("lastsyncdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Lastsyncdate { get; set; } 

        [JsonProperty("lastsyncerror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Lastsyncerror { get; set; } 

        [JsonProperty("update_days", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? UpdateDays { get; set; } 

        [JsonProperty("enablepipelines", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enablepipelines { get; set; } 

        [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Importtype { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warning { get; set; } 

        [JsonProperty("filters", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFilter>? Filters { get; set; } 

        [JsonProperty("import_entities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ImportEntities { get; set; } 

        [JsonProperty("import_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? ImportEntitiesList { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class AzureMonitorData
    {
        [JsonProperty("essentials", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AzureMonitorEssentials? Essentials { get; set; } 

        [JsonProperty("alertContext", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public object? AlertContext { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class AzureMonitorEssentials
    {
        [JsonProperty("alertId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AlertId { get; set; } 

        [JsonProperty("alertRule", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AlertRule { get; set; } 

        [JsonProperty("severity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Severity { get; set; } 

        [JsonProperty("signalType", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SignalType { get; set; } 

        [JsonProperty("monitorCondition", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? MonitorCondition { get; set; } 

        [JsonProperty("monitoringService", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? MonitoringService { get; set; } 

        [JsonProperty("alertTargetIds", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<string>? AlertTargetIds { get; set; } 

        [JsonProperty("configurationItems", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<string>? ConfigurationItems { get; set; } 

        [JsonProperty("originAlertId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OriginAlertId { get; set; } 

        [JsonProperty("firedDateTime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? FiredDateTime { get; set; } 

        [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Description { get; set; } 

        [JsonProperty("essentialsVersion", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? EssentialsVersion { get; set; } 

        [JsonProperty("alertContextVersion", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AlertContextVersion { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class AzureMonitorWebhook
    {
        [JsonProperty("schemaId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SchemaId { get; set; } 

        [JsonProperty("data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AzureMonitorData? Data { get; set; } 

    }