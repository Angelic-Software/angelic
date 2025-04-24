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
        public ICollection<FaqListHead>? Faqlists { get; set; } 

        [JsonProperty("popup_notes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AreaPopup>? PopupNotes { get; set; } 

        [JsonProperty("_reassign_all_to_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ReassignAllToUser { get; set; } 

        [JsonProperty("allowall_tickettypes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowallTickettypes { get; set; } 

        [JsonProperty("allowed_tickettypes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<RequestTypeList>? AllowedTickettypes { get; set; } 

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
        public ICollection<KbEntryList>? Kbentries { get; set; } 

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
        public ICollection<ExternalLinkList>? ExternalLinks { get; set; } 

        [JsonProperty("new_external_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ExternalLinkList? NewExternalLink { get; set; } 

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