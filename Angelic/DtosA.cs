using Newtonsoft.Json;

namespace Angelic;


    public class Area
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("toplevel_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Toplevel_id { get; set; } 

        [JsonProperty("toplevel_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Toplevel_name { get; set; } 

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
        public int? Messagegroup_id { get; set; } 

        [JsonProperty("from_address_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? From_address_override { get; set; } 

        [JsonProperty("override_org_logo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Override_org_logo { get; set; } 

        [JsonProperty("override_org_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Override_org_name { get; set; } 

        [JsonProperty("override_org_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AddressStore? Override_org_address { get; set; } 

        [JsonProperty("override_org_phone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Override_org_phone { get; set; } 

        [JsonProperty("override_org_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Override_org_email { get; set; } 

        [JsonProperty("override_org_website", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Override_org_website { get; set; } 

        [JsonProperty("override_org_portalurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Override_org_portalurl { get; set; } 

        [JsonProperty("mailbox_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Mailbox_override { get; set; } 

        [JsonProperty("default_mailbox_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_mailbox_id { get; set; } 

        [JsonProperty("calldate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Calldate { get; set; } 

        [JsonProperty("item_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Item_tax_code { get; set; } 

        [JsonProperty("service_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Service_tax_code { get; set; } 

        [JsonProperty("prepay_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Prepay_tax_code { get; set; } 

        [JsonProperty("contract_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Contract_tax_code { get; set; } 

        [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CustomField>? Customfields { get; set; } 

        [JsonProperty("custombuttons", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CustomButton>? Custombuttons { get; set; } 

        [JsonProperty("attachments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Attachment>? Attachments { get; set; } 

        [JsonProperty("site_fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<FieldHelper>? Site_fields { get; set; } 

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
        public int? Open_ticket_count { get; set; } 

        [JsonProperty("opps_ticket_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Opps_ticket_count { get; set; } 

        [JsonProperty("datecreated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Datecreated { get; set; } 

        [JsonProperty("createdfrom_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Createdfrom_id { get; set; } 

        [JsonProperty("announce", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Announce { get; set; } 

        [JsonProperty("announcedate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Announcedate { get; set; } 

        [JsonProperty("pritech_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Pritech_name { get; set; } 

        [JsonProperty("sectech_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sectech_name { get; set; } 

        [JsonProperty("prinotify", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Prinotify { get; set; } 

        [JsonProperty("secnotify", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Secnotify { get; set; } 

        [JsonProperty("priassign", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Priassign { get; set; } 

        [JsonProperty("secassign", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Secassign { get; set; } 

        [JsonProperty("accountmanagertech_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Accountmanagertech_name { get; set; } 

        [JsonProperty("accountmanagertech_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Accountmanagertech_email { get; set; } 

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
        public bool? Fluserdef1hide { get; set; } 

        [JsonProperty("fluserdef2hide", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Fluserdef2hide { get; set; } 

        [JsonProperty("fluserdef3hide", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Fluserdef3hide { get; set; } 

        [JsonProperty("fluserdef4hide", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Fluserdef4hide { get; set; } 

        [JsonProperty("fluserdef5hide", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Fluserdef5hide { get; set; } 

        [JsonProperty("fluserdef1mand", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Fluserdef1mand { get; set; } 

        [JsonProperty("fluserdef2mand", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Fluserdef2mand { get; set; } 

        [JsonProperty("fluserdef3mand", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Fluserdef3mand { get; set; } 

        [JsonProperty("fluserdef4mand", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Fluserdef4mand { get; set; } 

        [JsonProperty("fluserdef5mand", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Fluserdef5mand { get; set; } 

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
        public string? Item_tax_code_name { get; set; } 

        [JsonProperty("service_tax_code_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Service_tax_code_name { get; set; } 

        [JsonProperty("contract_tax_code_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Contract_tax_code_name { get; set; } 

        [JsonProperty("prepay_tax_code_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Prepay_tax_code_name { get; set; } 

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
        public bool? Dont_auto_send_invoices { get; set; } 

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
        public int? Billingtemplate_id { get; set; } 

        [JsonProperty("billingtemplate_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Billingtemplate_name { get; set; } 

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
        public int? Automatic_callscript_id { get; set; } 

        [JsonProperty("automatic_callscript_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Automatic_callscript_name { get; set; } 

        [JsonProperty("teamviewerpassword", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Teamviewerpassword { get; set; } 

        [JsonProperty("customertype_new", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Customertype_new { get; set; } 

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
        public int? Main_site_id { get; set; } 

        [JsonProperty("main_site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Main_site_name { get; set; } 

        [JsonProperty("linked_organisation_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Linked_organisation_id { get; set; } 

        [JsonProperty("all_organisations_allowed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? All_organisations_allowed { get; set; } 

        [JsonProperty("allowed_organisations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Organisation>? Allowed_organisations { get; set; } 

        [JsonProperty("override_signature", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Override_signature { get; set; } 

        [JsonProperty("contractaccountsdesc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Contractaccountsdesc { get; set; } 

        [JsonProperty("prepayaccountsdesc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Prepayaccountsdesc { get; set; } 

        [JsonProperty("site_update", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Site>? Site_update { get; set; } 

        [JsonProperty("newclient_sitename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Newclient_sitename { get; set; } 

        [JsonProperty("newclient_phonenumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Newclient_phonenumber { get; set; } 

        [JsonProperty("newclient_domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Newclient_domain { get; set; } 

        [JsonProperty("newclient_timezone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Newclient_timezone { get; set; } 

        [JsonProperty("newclient_contactname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Newclient_contactname { get; set; } 

        [JsonProperty("newclient_contactemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Newclient_contactemail { get; set; } 

        [JsonProperty("newclient_contacttitle", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Newclient_contacttitle { get; set; } 

        [JsonProperty("newclient_web_access_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Newclient_web_access_level { get; set; } 

        [JsonProperty("newclient_sendwelcomeemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Newclient_sendwelcomeemail { get; set; } 

        [JsonProperty("newclient_delivery_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AddressStore? Newclient_delivery_address { get; set; } 

        [JsonProperty("newclient_countrycode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Newclient_countrycode { get; set; } 

        [JsonProperty("newclient_regioncode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Newclient_regioncode { get; set; } 

        [JsonProperty("faqlists", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<FAQListHead>? Faqlists { get; set; } 

        [JsonProperty("popup_notes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AreaPopup>? Popup_notes { get; set; } 

        [JsonProperty("_reassign_all_to_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? _reassign_all_to_user { get; set; } 

        [JsonProperty("allowall_tickettypes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allowall_tickettypes { get; set; } 

        [JsonProperty("allowed_tickettypes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<RequestType_List>? Allowed_tickettypes { get; set; } 

        [JsonProperty("allowall_category1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allowall_category1 { get; set; } 

        [JsonProperty("allowed_category1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CategoryRestriction>? Allowed_category1 { get; set; } 

        [JsonProperty("allowall_category2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allowall_category2 { get; set; } 

        [JsonProperty("allowed_category2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CategoryRestriction>? Allowed_category2 { get; set; } 

        [JsonProperty("allowall_category3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allowall_category3 { get; set; } 

        [JsonProperty("allowed_category3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CategoryRestriction>? Allowed_category3 { get; set; } 

        [JsonProperty("allowall_category4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allowall_category4 { get; set; } 

        [JsonProperty("alocked", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Alocked { get; set; } 

        [JsonProperty("allowed_category4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CategoryRestriction>? Allowed_category4 { get; set; } 

        [JsonProperty("onhold_ticket_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Onhold_ticket_count { get; set; } 

        [JsonProperty("total_ticket_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Total_ticket_count { get; set; } 

        [JsonProperty("opened_thismonth_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Opened_thismonth_count { get; set; } 

        [JsonProperty("billingplans", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ContractDetail>? Billingplans { get; set; } 

        [JsonProperty("overriding_rates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ChargeRate>? Overriding_rates { get; set; } 

        [JsonProperty("allowallchargerates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allowallchargerates { get; set; } 

        [JsonProperty("chargerates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ChargeRateArea>? Chargerates { get; set; } 

        [JsonProperty("newclient_siteguid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Newclient_siteguid { get; set; } 

        [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _isimport { get; set; } 

        [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _importtype { get; set; } 

        [JsonProperty("allow_api_access", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allow_api_access { get; set; } 

        [JsonProperty("api_access_clientid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Api_access_clientid { get; set; } 

        [JsonProperty("api_access_clientsecret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Api_access_clientsecret { get; set; } 

        [JsonProperty("thirdpartynhdauthurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Thirdpartynhdauthurl { get; set; } 

        [JsonProperty("thirdpartynhdtenant", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Thirdpartynhdtenant { get; set; } 

        [JsonProperty("thirdpartynhdapiclientid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Thirdpartynhdapiclientid { get; set; } 

        [JsonProperty("new_thirdpartynhdapiclientsecret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_thirdpartynhdapiclientsecret { get; set; } 

        [JsonProperty("areaitems", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AreaItem>? Areaitems { get; set; } 

        [JsonProperty("portal_logo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Portal_logo { get; set; } 

        [JsonProperty("override_portalcolour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Override_portalcolour { get; set; } 

        [JsonProperty("portalcolour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(7)]
        public string? Portalcolour { get; set; } 

        [JsonProperty("portalbackgroundimageurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(500)]
        public string? Portalbackgroundimageurl { get; set; } 

        [JsonProperty("ninjarmmid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ninjarmmid { get; set; } 

        [JsonProperty("sales_tax_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sales_tax_type { get; set; } 

        [JsonProperty("purchase_tax_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Purchase_tax_type { get; set; } 

        [JsonProperty("isarchived_xero", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isarchived_xero { get; set; } 

        [JsonProperty("accountsfirstname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Accountsfirstname { get; set; } 

        [JsonProperty("accountslastname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Accountslastname { get; set; } 

        [JsonProperty("sales_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sales_tax_code { get; set; } 

        [JsonProperty("purchase_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Purchase_tax_code { get; set; } 

        [JsonProperty("purchase_tax_code_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Purchase_tax_code_name { get; set; } 

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
        public int? Default_contract { get; set; } 

        [JsonProperty("device42id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Device42id { get; set; } 

        [JsonProperty("xerodetails_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Xerodetails_id { get; set; } 

        [JsonProperty("xero_tenant_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Xero_tenant_name { get; set; } 

        [JsonProperty("xero_tracking_category_1_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Xero_tracking_category_1_name { get; set; } 

        [JsonProperty("xero_tracking_category_2_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Xero_tracking_category_2_name { get; set; } 

        [JsonProperty("servicenowid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Servicenowid { get; set; } 

        [JsonProperty("isnhserveremaildefault", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isnhserveremaildefault { get; set; } 

        [JsonProperty("datto_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Datto_id { get; set; } 

        [JsonProperty("datto_alternate_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Datto_alternate_id { get; set; } 

        [JsonProperty("datto_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Datto_url { get; set; } 

        [JsonProperty("dattocommerce_tenantid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Dattocommerce_tenantid { get; set; } 

        [JsonProperty("qbodefaulttaxcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Qbodefaulttaxcode { get; set; } 

        [JsonProperty("qbodefaulttaxcodename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Qbodefaulttaxcodename { get; set; } 

        [JsonProperty("qbo_default_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ValueLabelIsNewKeyPair? Qbo_default_tax_code { get; set; } 

        [JsonProperty("connectwiseid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Connectwiseid { get; set; } 

        [JsonProperty("autotaskid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Autotaskid { get; set; } 

        [JsonProperty("import_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AddressStore? Import_address { get; set; } 

        [JsonProperty("import_notes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AreaNote>? Import_notes { get; set; } 

        [JsonProperty("ateraid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ateraid { get; set; } 

        [JsonProperty("kashflowid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Kashflowid { get; set; } 

        [JsonProperty("kashflow_tenant_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Kashflow_tenant_name { get; set; } 

        [JsonProperty("website", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Website { get; set; } 

        [JsonProperty("alastupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Alastupdate { get; set; } 

        [JsonProperty("service_access", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ServiceRestriction>? Service_access { get; set; } 

        [JsonProperty("service_subscriptions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ServiceUser>? Service_subscriptions { get; set; } 

        [JsonProperty("snelstart_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Snelstart_id { get; set; } 

        [JsonProperty("default_currency_code_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_currency_code_name { get; set; } 

        [JsonProperty("_apply_billingtemplate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _apply_billingtemplate { get; set; } 

        [JsonProperty("datto_commerce_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Datto_commerce_id { get; set; } 

        [JsonProperty("datto_commerce_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Datto_commerce_url { get; set; } 

        [JsonProperty("import_azure_tenant", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public CSPCustomer? Import_azure_tenant { get; set; } 

        [JsonProperty("import_details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Import_details_id { get; set; } 

        [JsonProperty("syncroid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Syncroid { get; set; } 

        [JsonProperty("kbentries", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KBEntry_List>? Kbentries { get; set; } 

        [JsonProperty("auvik_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Auvik_id { get; set; } 

        [JsonProperty("hubspot_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Hubspot_id { get; set; } 

        [JsonProperty("hubspot_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Hubspot_url { get; set; } 

        [JsonProperty("hubspot_dont_sync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hubspot_dont_sync { get; set; } 

        [JsonProperty("hubspot_archived", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hubspot_archived { get; set; } 

        [JsonProperty("domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Domain { get; set; } 

        [JsonProperty("passportal_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Passportal_id { get; set; } 

        [JsonProperty("update_licences", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Update_licences { get; set; } 

        [JsonProperty("prepayasamount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Prepayasamount { get; set; } 

        [JsonProperty("synced_to_intacct", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Synced_to_intacct { get; set; } 

        [JsonProperty("qbo_company_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Qbo_company_name { get; set; } 

        [JsonProperty("oppid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Oppid { get; set; } 

        [JsonProperty("tax_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Tax_number { get; set; } 

        [JsonProperty("isclientdetails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isclientdetails { get; set; } 

        [JsonProperty("hubspot_lifecycle", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Hubspot_lifecycle { get; set; } 

        [JsonProperty("hudu_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Hudu_url { get; set; } 

        [JsonProperty("prepayrecurringexpirymonths", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Prepayrecurringexpirymonths { get; set; } 

        [JsonProperty("accountsbccemailaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Accountsbccemailaddress { get; set; } 

        [JsonProperty("defaultcontractoverride", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Defaultcontractoverride { get; set; } 

        [JsonProperty("defaultcontractoverride_ref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Defaultcontractoverride_ref { get; set; } 

        [JsonProperty("sqlimport_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sqlimport_id { get; set; } 

        [JsonProperty("external_links", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLink_List>? External_links { get; set; } 

        [JsonProperty("new_external_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ExternalLink_List? New_external_link { get; set; } 

        [JsonProperty("_match_thirdparty_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _match_thirdparty_id { get; set; } 

        [JsonProperty("_match_integration_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? _match_integration_id { get; set; } 

        [JsonProperty("_match_integration_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _match_integration_name { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("donotimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Donotimport { get; set; } 

        [JsonProperty("liongardid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Liongardid { get; set; } 

        [JsonProperty("liongard_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Liongard_url { get; set; } 

        [JsonProperty("sync_to_liongard", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sync_to_liongard { get; set; } 

        [JsonProperty("regmanagertech_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Regmanagertech_name { get; set; } 

        [JsonProperty("logmanagertech_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Logmanagertech_name { get; set; } 

        [JsonProperty("salesreptech_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Salesreptech_name { get; set; } 

        [JsonProperty("default_team_to_salesrep_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Default_team_to_salesrep_override { get; set; } 

        [JsonProperty("default_team_to_salesrep_override_team", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_team_to_salesrep_override_team { get; set; } 

        [JsonProperty("cxmleadtech_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Cxmleadtech_name { get; set; } 

        [JsonProperty("portalchatprofile", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Portalchatprofile { get; set; } 

        [JsonProperty("portalchatprofile_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Portalchatprofile_name { get; set; } 

        [JsonProperty("kaseyaid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Kaseyaid { get; set; } 

        [JsonProperty("trading_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Trading_name { get; set; } 

        [JsonProperty("dbc_company_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Dbc_company_name { get; set; } 

        [JsonProperty("salesforce_dontsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Salesforce_dontsync { get; set; } 

        [JsonProperty("stripe_customer_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Stripe_customer_id { get; set; } 

        [JsonProperty("stripe_payment_method_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Stripe_payment_method_id { get; set; } 

        [JsonProperty("stripe_payment_method_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Stripe_payment_method_name { get; set; } 

        [JsonProperty("stripe_paymentmethod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public StripePaymentMethod? Stripe_paymentmethod { get; set; } 

        [JsonProperty("current_licences", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Current_licences { get; set; } 

        [JsonProperty("servicenow_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Servicenow_url { get; set; } 

        [JsonProperty("servicenow_locale", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Servicenow_locale { get; set; } 

        [JsonProperty("servicenow_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Servicenow_username { get; set; } 

        [JsonProperty("new_servicenowkey", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_servicenowkey { get; set; } 

        [JsonProperty("servicenow_priority_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Servicenow_priority_mappings { get; set; } 

        [JsonProperty("servicenow_status_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Servicenow_status_mappings { get; set; } 

        [JsonProperty("servicenow_impact_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Servicenow_impact_mappings { get; set; } 

        [JsonProperty("servicenow_urgency_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Servicenow_urgency_mappings { get; set; } 

        [JsonProperty("servicenow_category_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Servicenow_category_mappings { get; set; } 

        [JsonProperty("servicenow_assignment_group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Servicenow_assignment_group { get; set; } 

        [JsonProperty("servicenow_assignment_group_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Servicenow_assignment_group_name { get; set; } 

        [JsonProperty("servicenow_assignmentgroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ValueLabelIsNewKeyPair? Servicenow_assignmentgroup { get; set; } 

        [JsonProperty("servicenow_defaultuser_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Servicenow_defaultuser_id { get; set; } 

        [JsonProperty("servicenow_defaultuser_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Servicenow_defaultuser_name { get; set; } 

        [JsonProperty("servicenow_defaultuser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ValueLabelIsNewKeyPair? Servicenow_defaultuser { get; set; } 

        [JsonProperty("test_servicenow", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Test_servicenow { get; set; } 

        [JsonProperty("sage_business_cloud_details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sage_business_cloud_details_id { get; set; } 

        [JsonProperty("sage_business_cloud_details_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sage_business_cloud_details_name { get; set; } 

        [JsonProperty("exact_division", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Exact_division { get; set; } 

        [JsonProperty("exact_division_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Exact_division_name { get; set; } 

        [JsonProperty("ncentral_details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ncentral_details_id { get; set; } 

        [JsonProperty("currencyisocode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Currencyisocode { get; set; } 

        [JsonProperty("intacct_location_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intacct_location_id { get; set; } 

        [JsonProperty("intacct_location_id_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? Intacct_location_id_list { get; set; } 

        [JsonProperty("intacct_location_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intacct_location_type { get; set; } 

        [JsonProperty("new_categories", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<string>? New_categories { get; set; } 

        [JsonProperty("jira_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Jira_url { get; set; } 

        [JsonProperty("jira_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Jira_username { get; set; } 

        [JsonProperty("new_jirakey", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_jirakey { get; set; } 

        [JsonProperty("test_jira", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Test_jira { get; set; } 

        [JsonProperty("jira_servicedesk_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Jira_servicedesk_id { get; set; } 

        [JsonProperty("jira_servicedesk_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Jira_servicedesk_name { get; set; } 

        [JsonProperty("jira_servicedesk", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ValueLabelIsNewKeyPair? Jira_servicedesk { get; set; } 

        [JsonProperty("jira_requesttype_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Jira_requesttype_mappings { get; set; } 

        [JsonProperty("jira_user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Jira_user_id { get; set; } 

        [JsonProperty("jira_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Jira_user_name { get; set; } 

        [JsonProperty("jira_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ValueLabelIsNewKeyPair? Jira_user { get; set; } 

        [JsonProperty("jira_priority_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Jira_priority_mappings { get; set; } 

        [JsonProperty("jira_status_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Jira_status_mappings { get; set; } 

        [JsonProperty("create_jira_webhook", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Create_jira_webhook { get; set; } 

        [JsonProperty("jira_webhook_created", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Jira_webhook_created { get; set; } 

        [JsonProperty("defaultpdftemplateinvoicetickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Defaultpdftemplateinvoicetickets { get; set; } 

        [JsonProperty("defaultpdftemplateinvoiceorders", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Defaultpdftemplateinvoiceorders { get; set; } 

        [JsonProperty("defaultpdftemplateinvoicerecurring", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Defaultpdftemplateinvoicerecurring { get; set; } 

        [JsonProperty("defaultpdftemplateinvoicetickets_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Defaultpdftemplateinvoicetickets_name { get; set; } 

        [JsonProperty("defaultpdftemplateinvoiceorders_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Defaultpdftemplateinvoiceorders_name { get; set; } 

        [JsonProperty("defaultpdftemplateinvoicerecurring_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Defaultpdftemplateinvoicerecurring_name { get; set; } 

        [JsonProperty("intacct_invoice_save_location", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intacct_invoice_save_location { get; set; } 

        [JsonProperty("ingram_micro_details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ingram_micro_details_id { get; set; } 

        [JsonProperty("_dont_fire_automations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _dont_fire_automations { get; set; } 

        [JsonProperty("main_delivery_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AddressStore? Main_delivery_address { get; set; } 

        [JsonProperty("main_invoice_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AddressStore? Main_invoice_address { get; set; } 

        [JsonProperty("main_contact_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Main_contact_name { get; set; } 

        [JsonProperty("main_contact_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Main_contact_email { get; set; } 

        [JsonProperty("main_contact_phonenumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Main_contact_phonenumber { get; set; } 

        [JsonProperty("main_contact_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Main_contact_id { get; set; } 

        [JsonProperty("main_phonenumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Main_phonenumber { get; set; } 

        [JsonProperty("auvik_site_inactive", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Auvik_site_inactive { get; set; } 

        [JsonProperty("invoice_class", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Invoice_class { get; set; } 

        [JsonProperty("new_icon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_icon { get; set; } 

        [JsonProperty("fortnox_tenant", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Fortnox_tenant { get; set; } 

        [JsonProperty("fortnox_tenant_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Fortnox_tenant_name { get; set; } 

        [JsonProperty("servicenow_enable_webhook", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Servicenow_enable_webhook { get; set; } 

        [JsonProperty("new_servicenow_webhooksecret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_servicenow_webhooksecret { get; set; } 

        [JsonProperty("servicenow_webhook_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Servicenow_webhook_user { get; set; } 

        [JsonProperty("servicenow_webhook_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Servicenow_webhook_user_name { get; set; } 

        [JsonProperty("servicenow_webhook_tickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Servicenow_webhook_tickettype { get; set; } 

        [JsonProperty("servicenow_webhook_tickettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Servicenow_webhook_tickettype_name { get; set; } 

        [JsonProperty("myob_tenant", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Myob_tenant { get; set; } 

        [JsonProperty("myob_tenant_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Myob_tenant_name { get; set; } 

        [JsonProperty("sync_servicenow_attachments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sync_servicenow_attachments { get; set; } 

        [JsonProperty("twilio_subaccount_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Twilio_subaccount_name { get; set; } 

        [JsonProperty("twilio_subaccount_created", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Twilio_subaccount_created { get; set; } 

        [JsonProperty("twilio_subaccount_sid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Twilio_subaccount_sid { get; set; } 

        [JsonProperty("twilio_subaccount_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Twilio_subaccount_status { get; set; } 

        [JsonProperty("twilio_subaccount_authtoken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Twilio_subaccount_authtoken { get; set; } 

        [JsonProperty("_create_twilio_subaccount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _create_twilio_subaccount { get; set; } 

        [JsonProperty("_close_twilio_subaccount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _close_twilio_subaccount { get; set; } 

        [JsonProperty("_pauseunpause_twilio_subaccount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _pauseunpause_twilio_subaccount { get; set; } 

        [JsonProperty("_create_twilio_recurringinvoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _create_twilio_recurringinvoice { get; set; } 

        [JsonProperty("twilio_recurring_invoice_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Twilio_recurring_invoice_id { get; set; } 

        [JsonProperty("override_layout_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Override_layout_id { get; set; } 

        [JsonProperty("override_layout_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Override_layout_name { get; set; } 

        [JsonProperty("extratabs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Tabname>? Extratabs { get; set; } 

        [JsonProperty("servicenow_team_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Servicenow_team_mappings { get; set; } 

        [JsonProperty("servicenow_ticket_sync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Servicenow_ticket_sync { get; set; } 

        [JsonProperty("servicenow_ticket_sync_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? Servicenow_ticket_sync_list { get; set; } 

        [JsonProperty("servicenow_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Servicenow_fieldmappings { get; set; } 

        [JsonProperty("matching_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Matching_value { get; set; } 

        [JsonProperty("jira_webhook_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Jira_webhook_user { get; set; } 

        [JsonProperty("jira_webhook_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Jira_webhook_username { get; set; } 

        [JsonProperty("avalara_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Avalara_code { get; set; } 

        [JsonProperty("avalara_tenant_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Avalara_tenant_name { get; set; } 

        [JsonProperty("avalara_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Avalara_id { get; set; } 

        [JsonProperty("invoice_mailbox_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Invoice_mailbox_override { get; set; } 

        [JsonProperty("quote_mailbox_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Quote_mailbox_override { get; set; } 

        [JsonProperty("_merge_client_into", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? _merge_client_into { get; set; } 

        [JsonProperty("invoice_tickets_seperately_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Invoice_tickets_seperately_override { get; set; } 

        [JsonProperty("servicenow_authtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Servicenow_authtype { get; set; } 

        [JsonProperty("portal_title_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Portal_title_override { get; set; } 

        [JsonProperty("portal_title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Portal_title { get; set; } 

        [JsonProperty("reply_address_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Reply_address_override { get; set; } 

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
        public string? Xero_tenant_id { get; set; } 

        [JsonProperty("accountsid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Accountsid { get; set; } 

        [JsonProperty("excludefrominvoicesync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Excludefrominvoicesync { get; set; } 

        [JsonProperty("gficlientid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Gficlientid { get; set; } 

        [JsonProperty("overridepdftemplateinvoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Overridepdftemplateinvoice { get; set; } 

        [JsonProperty("overridepdftemplateinvoice_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Overridepdftemplateinvoice_name { get; set; } 

        [JsonProperty("kashflow_tenant_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Kashflow_tenant_id { get; set; } 

        [JsonProperty("client_to_invoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Client_to_invoice { get; set; } 

        [JsonProperty("client_to_invoice_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Client_to_invoice_name { get; set; } 

        [JsonProperty("invoiceduedaysextraclient", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Invoiceduedaysextraclient { get; set; } 

        [JsonProperty("itglue_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Itglue_id { get; set; } 

        [JsonProperty("clientcurrency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Clientcurrency { get; set; } 

        [JsonProperty("sentinel_subscription_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sentinel_subscription_id { get; set; } 

        [JsonProperty("sentinel_workspace_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sentinel_workspace_name { get; set; } 

        [JsonProperty("sentinel_resource_group_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sentinel_resource_group_name { get; set; } 

        [JsonProperty("sentinel_tenant_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sentinel_tenant_id { get; set; } 

        [JsonProperty("sentinel_tenant_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sentinel_tenant_name { get; set; } 

        [JsonProperty("default_currency_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_currency_code { get; set; } 

        [JsonProperty("client_to_invoice_recurring", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Client_to_invoice_recurring { get; set; } 

        [JsonProperty("client_to_invoice_recurring_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Client_to_invoice_recurring_name { get; set; } 

        [JsonProperty("azure_tenants", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AreaAzureTenant>? Azure_tenants { get; set; } 

        [JsonProperty("azure_tenant_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Azure_tenant_id { get; set; } 

        [JsonProperty("snow_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Snow_id { get; set; } 

        [JsonProperty("snowLicences", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<SnowLicenseAbstract>? SnowLicences { get; set; } 

        [JsonProperty("qbo_company_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Qbo_company_id { get; set; } 

        [JsonProperty("automatic_sales_tax", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Automatic_sales_tax { get; set; } 

        [JsonProperty("cautomateid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Cautomateid { get; set; } 

        [JsonProperty("dbc_company_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Dbc_company_id { get; set; } 

        [JsonProperty("stopped", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Stopped { get; set; } 

        [JsonProperty("customertype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Customertype { get; set; } 

        [JsonProperty("customer_relationship", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<StringIdNameKeyPair>? Customer_relationship { get; set; } 

        [JsonProperty("customer_relationship_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Customer_relationship_list { get; set; } 

        [JsonProperty("servicenow_validated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Servicenow_validated { get; set; } 

        [JsonProperty("sentinel_default_user_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sentinel_default_user_override { get; set; } 

        [JsonProperty("sentinel_default_user_override_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sentinel_default_user_override_name { get; set; } 

        [JsonProperty("jira_validated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Jira_validated { get; set; } 

        [JsonProperty("ref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ref { get; set; } 

        [JsonProperty("ticket_invoices_for_each_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ticket_invoices_for_each_site { get; set; } 

        [JsonProperty("intacct_save_location", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intacct_save_location { get; set; } 

        [JsonProperty("is_vip", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_vip { get; set; } 

        [JsonProperty("accountownertech_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Accountownertech_name { get; set; } 

        [JsonProperty("taxable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Taxable { get; set; } 

        [JsonProperty("quickbooks_details", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public QuickBooksDetails? Quickbooks_details { get; set; } 

        [JsonProperty("percentage_to_survey", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Percentage_to_survey { get; set; } 

        [JsonProperty("billing_plan_text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Billing_plan_text { get; set; } 

        [JsonProperty("overridepdftemplatequote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Overridepdftemplatequote { get; set; } 

        [JsonProperty("overridepdftemplatequote_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Overridepdftemplatequote_name { get; set; } 

        [JsonProperty("avalara_tenant", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Avalara_tenant { get; set; } 

        [JsonProperty("due_date_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Due_date_type { get; set; } 

        [JsonProperty("toplevel_quote_currency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Toplevel_quote_currency { get; set; } 

        [JsonProperty("is_account", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_account { get; set; } 

        [JsonProperty("_importtypeid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? _importtypeid { get; set; } 

        [JsonProperty("_importthirdpartyid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _importthirdpartyid { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class AreaAzureTenant
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Details_id { get; set; } 

        [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Client_id { get; set; } 

        [JsonProperty("azure_tenant_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Azure_tenant_id { get; set; } 

        [JsonProperty("azure_tenant_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Azure_tenant_name { get; set; } 

        [JsonProperty("new_access_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_access_token { get; set; } 

        [JsonProperty("token_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Token_expiry { get; set; } 

        [JsonProperty("client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Client_name { get; set; } 

        [JsonProperty("details_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Details_name { get; set; } 

        [JsonProperty("azure_tenant_domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Azure_tenant_domain { get; set; } 

        [JsonProperty("licence_import_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Licence_import_type { get; set; } 

        [JsonProperty("relationship_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Relationship_type { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class AreaField
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Client_id { get; set; } 

        [JsonProperty("client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Client_name { get; set; } 

        [JsonProperty("field_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Field_id { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class AreaItem
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Client_id { get; set; } 

        [JsonProperty("item_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Item_id { get; set; } 

        [JsonProperty("quantity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Quantity { get; set; } 

        [JsonProperty("areaitemdesc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Areaitemdesc { get; set; } 

        [JsonProperty("billingperiod_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Billingperiod_id { get; set; } 

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
        public string? Accounts_id { get; set; } 

        [JsonProperty("numberdayswarning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Numberdayswarning { get; set; } 

        [JsonProperty("dsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Dsite { get; set; } 

        [JsonProperty("ddevnum", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ddevnum { get; set; } 

        [JsonProperty("technician", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Technician { get; set; } 

        [JsonProperty("billingcategory_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Billingcategory_id { get; set; } 

        [JsonProperty("site_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Site_id { get; set; } 

        [JsonProperty("dontinvoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dontinvoice { get; set; } 

        [JsonProperty("enddate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Enddate { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class AreaNote
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Client_id { get; set; } 

        [JsonProperty("supplier_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Supplier_id { get; set; } 

        [JsonProperty("sales_order_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sales_order_id { get; set; } 

        [JsonProperty("purchase_order_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Purchase_order_id { get; set; } 

        [JsonProperty("quote_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Quote_id { get; set; } 

        [JsonProperty("invoice_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Invoice_id { get; set; } 

        [JsonProperty("site_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Site_id { get; set; } 

        [JsonProperty("user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? User_id { get; set; } 

        [JsonProperty("datetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Datetime { get; set; } 

        [JsonProperty("who_agentid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Who_agentid { get; set; } 

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
        public string? Third_party_id { get; set; } 

        [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CustomField>? Customfields { get; set; } 

        [JsonProperty("ticketid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ticketid { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("hide_time_taken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hide_time_taken { get; set; } 

        [JsonProperty("add_to_calendar", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Add_to_calendar { get; set; } 

        [JsonProperty("app_user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? App_user_id { get; set; } 

        [JsonProperty("app_agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? App_agent_id { get; set; } 

        [JsonProperty("app_subject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? App_subject { get; set; } 

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
        public int? Client_id { get; set; } 

        [JsonProperty("site_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Site_id { get; set; } 

        [JsonProperty("user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? User_id { get; set; } 

        [JsonProperty("date_created", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Date_created { get; set; } 

        [JsonProperty("note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Note { get; set; } 

        [JsonProperty("dismissable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dismissable { get; set; } 

        [JsonProperty("read_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Read_status { get; set; } 

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
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class AreaRequestType
    {
        [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Client_id { get; set; } 

        [JsonProperty("client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Client_name { get; set; } 

        [JsonProperty("request_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Request_type { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class AreaSectionDetail
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("ticket_area_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ticket_area_id { get; set; } 

        [JsonProperty("ticket_area_id_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Ticket_area_id_guid { get; set; } 

        [JsonProperty("team_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Team_id { get; set; } 

        [JsonProperty("team_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Team_guid { get; set; } 

        [JsonProperty("team_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Team_name { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class AreaToDo
    {
        [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Client_id { get; set; } 

        [JsonProperty("client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Client_name { get; set; } 

        [JsonProperty("template_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Template_id { get; set; } 

        [JsonProperty("todo_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Todo_id { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class Area_List
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("toplevel_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Toplevel_id { get; set; } 

        [JsonProperty("toplevel_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Toplevel_name { get; set; } 

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
        public int? Messagegroup_id { get; set; } 

        [JsonProperty("from_address_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? From_address_override { get; set; } 

        [JsonProperty("override_org_logo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Override_org_logo { get; set; } 

        [JsonProperty("override_org_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Override_org_name { get; set; } 

        [JsonProperty("override_org_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AddressStore? Override_org_address { get; set; } 

        [JsonProperty("override_org_phone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Override_org_phone { get; set; } 

        [JsonProperty("override_org_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Override_org_email { get; set; } 

        [JsonProperty("override_org_website", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Override_org_website { get; set; } 

        [JsonProperty("override_org_portalurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Override_org_portalurl { get; set; } 

        [JsonProperty("mailbox_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Mailbox_override { get; set; } 

        [JsonProperty("default_mailbox_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_mailbox_id { get; set; } 

        [JsonProperty("calldate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Calldate { get; set; } 

        [JsonProperty("item_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Item_tax_code { get; set; } 

        [JsonProperty("service_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Service_tax_code { get; set; } 

        [JsonProperty("prepay_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Prepay_tax_code { get; set; } 

        [JsonProperty("contract_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Contract_tax_code { get; set; } 

        [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CustomField>? Customfields { get; set; } 

        [JsonProperty("custombuttons", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CustomButton>? Custombuttons { get; set; } 

        [JsonProperty("attachments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Attachment>? Attachments { get; set; } 

        [JsonProperty("site_fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<FieldHelper>? Site_fields { get; set; } 

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
        public int? Open_ticket_count { get; set; } 

        [JsonProperty("opps_ticket_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Opps_ticket_count { get; set; } 

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
        public string? Xero_tenant_id { get; set; } 

        [JsonProperty("accountsid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Accountsid { get; set; } 

        [JsonProperty("excludefrominvoicesync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Excludefrominvoicesync { get; set; } 

        [JsonProperty("gficlientid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Gficlientid { get; set; } 

        [JsonProperty("overridepdftemplateinvoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Overridepdftemplateinvoice { get; set; } 

        [JsonProperty("overridepdftemplateinvoice_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Overridepdftemplateinvoice_name { get; set; } 

        [JsonProperty("kashflow_tenant_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Kashflow_tenant_id { get; set; } 

        [JsonProperty("client_to_invoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Client_to_invoice { get; set; } 

        [JsonProperty("client_to_invoice_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Client_to_invoice_name { get; set; } 

        [JsonProperty("invoiceduedaysextraclient", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Invoiceduedaysextraclient { get; set; } 

        [JsonProperty("itglue_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Itglue_id { get; set; } 

        [JsonProperty("clientcurrency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Clientcurrency { get; set; } 

        [JsonProperty("sentinel_subscription_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sentinel_subscription_id { get; set; } 

        [JsonProperty("sentinel_workspace_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sentinel_workspace_name { get; set; } 

        [JsonProperty("sentinel_resource_group_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sentinel_resource_group_name { get; set; } 

        [JsonProperty("sentinel_tenant_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sentinel_tenant_id { get; set; } 

        [JsonProperty("sentinel_tenant_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sentinel_tenant_name { get; set; } 

        [JsonProperty("default_currency_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_currency_code { get; set; } 

        [JsonProperty("client_to_invoice_recurring", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Client_to_invoice_recurring { get; set; } 

        [JsonProperty("client_to_invoice_recurring_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Client_to_invoice_recurring_name { get; set; } 

        [JsonProperty("azure_tenants", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AreaAzureTenant>? Azure_tenants { get; set; } 

        [JsonProperty("azure_tenant_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Azure_tenant_id { get; set; } 

        [JsonProperty("snow_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Snow_id { get; set; } 

        [JsonProperty("snowLicences", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<SnowLicenseAbstract>? SnowLicences { get; set; } 

        [JsonProperty("qbo_company_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Qbo_company_id { get; set; } 

        [JsonProperty("automatic_sales_tax", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Automatic_sales_tax { get; set; } 

        [JsonProperty("cautomateid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Cautomateid { get; set; } 

        [JsonProperty("dbc_company_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Dbc_company_id { get; set; } 

        [JsonProperty("stopped", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Stopped { get; set; } 

        [JsonProperty("customertype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Customertype { get; set; } 

        [JsonProperty("customer_relationship", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<StringIdNameKeyPair>? Customer_relationship { get; set; } 

        [JsonProperty("customer_relationship_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Customer_relationship_list { get; set; } 

        [JsonProperty("servicenow_validated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Servicenow_validated { get; set; } 

        [JsonProperty("sentinel_default_user_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sentinel_default_user_override { get; set; } 

        [JsonProperty("sentinel_default_user_override_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sentinel_default_user_override_name { get; set; } 

        [JsonProperty("jira_validated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Jira_validated { get; set; } 

        [JsonProperty("ref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ref { get; set; } 

        [JsonProperty("ticket_invoices_for_each_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ticket_invoices_for_each_site { get; set; } 

        [JsonProperty("intacct_save_location", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intacct_save_location { get; set; } 

        [JsonProperty("is_vip", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_vip { get; set; } 

        [JsonProperty("accountownertech_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Accountownertech_name { get; set; } 

        [JsonProperty("taxable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Taxable { get; set; } 

        [JsonProperty("quickbooks_details", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public QuickBooksDetails? Quickbooks_details { get; set; } 

        [JsonProperty("percentage_to_survey", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Percentage_to_survey { get; set; } 

        [JsonProperty("billing_plan_text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Billing_plan_text { get; set; } 

        [JsonProperty("overridepdftemplatequote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Overridepdftemplatequote { get; set; } 

        [JsonProperty("overridepdftemplatequote_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Overridepdftemplatequote_name { get; set; } 

        [JsonProperty("avalara_tenant", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Avalara_tenant { get; set; } 

        [JsonProperty("due_date_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Due_date_type { get; set; } 

        [JsonProperty("toplevel_quote_currency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Toplevel_quote_currency { get; set; } 

        [JsonProperty("is_account", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_account { get; set; } 

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
    public class AssignSchedule
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("day", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Day { get; set; } 

        [JsonProperty("time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Time { get; set; } 

        [JsonProperty("assignto_agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Assignto_agent_id { get; set; } 

        [JsonProperty("status_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Status_id { get; set; } 

        [JsonProperty("tickettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Tickettype_id { get; set; } 

        [JsonProperty("last_run_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Last_run_date { get; set; } 

        [JsonProperty("interval", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Interval { get; set; } 

        [JsonProperty("paused", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Paused { get; set; } 

        [JsonProperty("asslinked_tickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Asslinked_tickettype { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class AteraAlert
    {
        [JsonProperty("alertID", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AlertID { get; set; } 

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
        public string? AlertCategoryID { get; set; } 

        [JsonProperty("archivedDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? ArchivedDate { get; set; } 

        [JsonProperty("alertMessage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AlertMessage { get; set; } 

        [JsonProperty("deviceName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DeviceName { get; set; } 

        [JsonProperty("customerID", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CustomerID { get; set; } 

        [JsonProperty("customerName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CustomerName { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class Attachment
    {
        [JsonProperty("third_party_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Third_party_id { get; set; } 

        [JsonProperty("link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Link { get; set; } 

        [JsonProperty("content_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Content_type { get; set; } 

        [JsonProperty("last_updated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Last_updated { get; set; } 

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
        public int? Unique_id { get; set; } 

        [JsonProperty("desc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Desc { get; set; } 

        [JsonProperty("isimage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isimage { get; set; } 

        [JsonProperty("data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public byte[]? Data { get; set; } 

        [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ticket_id { get; set; } 

        [JsonProperty("action_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Action_id { get; set; } 

        [JsonProperty("user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? User_id { get; set; } 

        [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Agent_id { get; set; } 

        [JsonProperty("attachmentaction_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Attachmentaction_id { get; set; } 

        [JsonProperty("_canupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _canupdate { get; set; } 

        [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Guid { get; set; } 

        [JsonProperty("image_upload_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Image_upload_id { get; set; } 

        [JsonProperty("image_upload_key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Image_upload_key { get; set; } 

        [JsonProperty("file", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public byte[]? File { get; set; } 

        [JsonProperty("_enduserportalpdfprint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _enduserportalpdfprint { get; set; } 

        [JsonProperty("anon_outcomeid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Anon_outcomeid { get; set; } 

        [JsonProperty("has_scanned", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Has_scanned { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("_is_new_version", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _is_new_version { get; set; } 

        [JsonProperty("parent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Parent_name { get; set; } 

        [JsonProperty("version_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Version_count { get; set; } 

        [JsonProperty("_alreadyuploaded", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _alreadyuploaded { get; set; } 

        [JsonProperty("copy_from_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Copy_from_id { get; set; } 

        [JsonProperty("new_external_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ExternalLink_List? New_external_link { get; set; } 

        [JsonProperty("_match_thirdparty_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _match_thirdparty_id { get; set; } 

        [JsonProperty("_match_integration_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? _match_integration_id { get; set; } 

        [JsonProperty("_match_integration_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _match_integration_name { get; set; } 

        [JsonProperty("import_details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Import_details_id { get; set; } 

        [JsonProperty("external_links", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLink_List>? External_links { get; set; } 

        [JsonProperty("showforusers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showforusers { get; set; } 

        [JsonProperty("showonchild", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showonchild { get; set; } 

        [JsonProperty("showonrelated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showonrelated { get; set; } 

        [JsonProperty("data_base64", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Data_base64 { get; set; } 

        [JsonProperty("download_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Download_url { get; set; } 

        [JsonProperty("third_party_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Third_party_token { get; set; } 

        [JsonProperty("already_posted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Already_posted { get; set; } 

        [JsonProperty("faultid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Faultid { get; set; } 

        [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _isimport { get; set; } 

        [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _importtype { get; set; } 

        [JsonProperty("s3url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? S3url { get; set; } 

        [JsonProperty("att_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Att_link { get; set; } 

        [JsonProperty("child_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Child_count { get; set; } 

        [JsonProperty("parent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Parent_id { get; set; } 

        [JsonProperty("linked_version_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Linked_version_id { get; set; } 

        [JsonProperty("allow_anon_upload", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allow_anon_upload { get; set; } 

        [JsonProperty("tickettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Tickettype_id { get; set; } 

        [JsonProperty("tickettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Tickettype_guid { get; set; } 

        [JsonProperty("validate_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Validate_guid { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class Attachment_List
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
        public int? Unique_id { get; set; } 

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
        public string? Data_base64 { get; set; } 

        [JsonProperty("download_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Download_url { get; set; } 

        [JsonProperty("third_party_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Third_party_token { get; set; } 

        [JsonProperty("third_party_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Third_party_id { get; set; } 

        [JsonProperty("already_posted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Already_posted { get; set; } 

        [JsonProperty("faultid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Faultid { get; set; } 

        [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _isimport { get; set; } 

        [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _importtype { get; set; } 

        [JsonProperty("s3url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? S3url { get; set; } 

        [JsonProperty("att_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Att_link { get; set; } 

        [JsonProperty("child_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Child_count { get; set; } 

        [JsonProperty("parent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Parent_id { get; set; } 

        [JsonProperty("linked_version_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Linked_version_id { get; set; } 

        [JsonProperty("allow_anon_upload", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allow_anon_upload { get; set; } 

        [JsonProperty("tickettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Tickettype_id { get; set; } 

        [JsonProperty("tickettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Tickettype_guid { get; set; } 

        [JsonProperty("validate_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Validate_guid { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class Attachment_View
    {
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; } 

        [JsonProperty("unique_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Unique_id { get; set; } 

        [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ticket_id { get; set; } 

        [JsonProperty("action_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Action_id { get; set; } 

        [JsonProperty("record_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Record_count { get; set; } 

        [JsonProperty("attachments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Attachment_List>? Attachments { get; set; } 

        [JsonProperty("page_no", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Page_no { get; set; } 

        [JsonProperty("page_size", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Page_size { get; set; } 

        [JsonProperty("folders", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<LongIdNameKeyPair>? Folders { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class Audit
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ticket_id { get; set; } 

        [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Agent_id { get; set; } 

        [JsonProperty("date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Date { get; set; } 

        [JsonProperty("value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Value { get; set; } 

        [JsonProperty("to", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? To { get; set; } 

        [JsonProperty("from", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? From { get; set; } 

        [JsonProperty("table_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Table_name { get; set; } 

        [JsonProperty("id1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id1 { get; set; } 

        [JsonProperty("id2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id2 { get; set; } 

        [JsonProperty("clientid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Clientid { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("actoutcome", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Actoutcome { get; set; } 

        [JsonProperty("user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? User_id { get; set; } 

        [JsonProperty("username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Username { get; set; } 

        [JsonProperty("datetime_to", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Datetime_to { get; set; } 

        [JsonProperty("datetime_from", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Datetime_from { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class AuditPasswordField
    {
        [JsonProperty("object_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Object_type { get; set; } 

        [JsonProperty("object_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Object_id { get; set; } 

        [JsonProperty("field_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Field_id { get; set; } 

        [JsonProperty("value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Value { get; set; } 

        [JsonProperty("object", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public PasswordObjectType? Object { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

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
        public int? New_agent_id { get; set; } 

        [JsonProperty("new_agent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_agent_name { get; set; } 

        [JsonProperty("new_team", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_team { get; set; } 

        [JsonProperty("new_priority_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? New_priority_id { get; set; } 

        [JsonProperty("new_status_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? New_status_id { get; set; } 

        [JsonProperty("newstatus_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Newstatus_guid { get; set; } 

        [JsonProperty("new_sla_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? New_sla_id { get; set; } 

        [JsonProperty("new_sla_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? New_sla_guid { get; set; } 

        [JsonProperty("new_category_1_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? New_category_1_id { get; set; } 

        [JsonProperty("new_category_1_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? New_category_1_guid { get; set; } 

        [JsonProperty("new_category_1_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_category_1_name { get; set; } 

        [JsonProperty("new_product_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? New_product_id { get; set; } 

        [JsonProperty("new_product_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_product_name { get; set; } 

        [JsonProperty("new_workflow_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? New_workflow_id { get; set; } 

        [JsonProperty("newworkflow_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Newworkflow_guid { get; set; } 

        [JsonProperty("new_workflow_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_workflow_name { get; set; } 

        [JsonProperty("dontshownotification", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dontshownotification { get; set; } 

        [JsonProperty("criteria", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AutoassignCriteria>? Criteria { get; set; } 

        [JsonProperty("outcomes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AutoassignOutcome>? Outcomes { get; set; } 

        [JsonProperty("_domatch", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _domatch { get; set; } 

        [JsonProperty("user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Users? User { get; set; } 

        [JsonProperty("matched_rule_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Matched_rule_count { get; set; } 

        [JsonProperty("matched_ids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Matched_ids { get; set; } 

        [JsonProperty("outcome_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Outcome_id { get; set; } 

        [JsonProperty("outcome_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Outcome_name { get; set; } 

        [JsonProperty("new_category_2_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? New_category_2_id { get; set; } 

        [JsonProperty("new_category_2_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? New_category_2_guid { get; set; } 

        [JsonProperty("new_category_2_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_category_2_name { get; set; } 

        [JsonProperty("new_category_3_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? New_category_3_id { get; set; } 

        [JsonProperty("new_category_3_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? New_category_3_guid { get; set; } 

        [JsonProperty("new_category_3_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_category_3_name { get; set; } 

        [JsonProperty("new_category_4_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? New_category_4_id { get; set; } 

        [JsonProperty("new_category_4_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? New_category_4_guid { get; set; } 

        [JsonProperty("new_category_4_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_category_4_name { get; set; } 

        [JsonProperty("script_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Script_id { get; set; } 

        [JsonProperty("script_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Script_name { get; set; } 

        [JsonProperty("rule_ids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<int>? Rule_ids { get; set; } 

        [JsonProperty("new_template_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? New_template_id { get; set; } 

        [JsonProperty("newtemplate_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Newtemplate_guid { get; set; } 

        [JsonProperty("new_template_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_template_name { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("popupmsg", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Popupmsg { get; set; } 

        [JsonProperty("popup_notes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AreaPopup>? Popup_notes { get; set; } 

        [JsonProperty("flowdetail_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Flowdetail_id { get; set; } 

        [JsonProperty("batch_size", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Batch_size { get; set; } 

        [JsonProperty("batch_sleep", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Batch_sleep { get; set; } 

        [JsonProperty("access_control", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? Access_control { get; set; } 

        [JsonProperty("access_control_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Access_control_level { get; set; } 

        [JsonProperty("events", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<UnameNotification>? Events { get; set; } 

        [JsonProperty("new_colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_colour { get; set; } 

        [JsonProperty("set_colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Set_colour { get; set; } 

        [JsonProperty("active", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Active { get; set; } 

        [JsonProperty("olas", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<WorkflowTarget>? Olas { get; set; } 

        [JsonProperty("database_lookups", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<PartsLookup>? Database_lookups { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class AutoassignCriteria
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("rule_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Rule_id { get; set; } 

        [JsonProperty("autoassign_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Autoassign_guid { get; set; } 

        [JsonProperty("qualification_criteria_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Qualification_criteria_id { get; set; } 

        [JsonProperty("fieldname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Fieldname { get; set; } 

        [JsonProperty("value_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Value_type { get; set; } 

        [JsonProperty("value_type_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Value_type_id { get; set; } 

        [JsonProperty("value_int", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Value_int { get; set; } 

        [JsonProperty("valueint_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Valueint_guid { get; set; } 

        [JsonProperty("value_string", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Value_string { get; set; } 

        [JsonProperty("value_datetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Value_datetime { get; set; } 

        [JsonProperty("partialmatch", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Partialmatch { get; set; } 

        [JsonProperty("value_float", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Value_float { get; set; } 

        [JsonProperty("matchseparatedvalues", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Matchseparatedvalues { get; set; } 

        [JsonProperty("value_display", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Value_display { get; set; } 

        [JsonProperty("alt_value_display", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Alt_value_display { get; set; } 

        [JsonProperty("tablename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Tablename { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; } 

        [JsonProperty("flowsubdetails_criteria_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Flowsubdetails_criteria_id { get; set; } 

        [JsonProperty("use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Use { get; set; } 

        [JsonProperty("chatprofile_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Chatprofile_id { get; set; } 

        [JsonProperty("chatprofile_flow_seq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Chatprofile_flow_seq { get; set; } 

        [JsonProperty("timezonestring", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Timezonestring { get; set; } 

        [JsonProperty("match_after_start", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Match_after_start { get; set; } 

        [JsonProperty("match_after_target", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Match_after_target { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("stdid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Stdid { get; set; } 

        [JsonProperty("contract_rule_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Contract_rule_id { get; set; } 

        [JsonProperty("utcoffset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Utcoffset { get; set; } 

        [JsonProperty("eventrule_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Eventrule_id { get; set; } 

        [JsonProperty("eventrule_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Eventrule_guid { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class AutoassignOutcome
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("rule_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Rule_id { get; set; } 

        [JsonProperty("autoassign_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Autoassign_guid { get; set; } 

        [JsonProperty("fieldid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Fieldid { get; set; } 

        [JsonProperty("fieldname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Fieldname { get; set; } 

        [JsonProperty("value_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Value_type { get; set; } 

        [JsonProperty("value_int", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Value_int { get; set; } 

        [JsonProperty("value_string", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Value_string { get; set; } 

        [JsonProperty("value_datetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Value_datetime { get; set; } 

        [JsonProperty("value_float", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Value_float { get; set; } 

        [JsonProperty("value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public object? Value { get; set; } 

        [JsonProperty("value_display", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Value_display { get; set; } 

        [JsonProperty("value_type_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Value_type_id { get; set; } 

        [JsonProperty("is_dummy", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_dummy { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

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
        public string? New_password { get; set; } 

        [JsonProperty("new_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? New_method { get; set; } 

        [JsonProperty("companyid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Companyid { get; set; } 

        [JsonProperty("client_top_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Client_top_level { get; set; } 

        [JsonProperty("supplier_top_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Supplier_top_level { get; set; } 

        [JsonProperty("client_top_level_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Client_top_level_name { get; set; } 

        [JsonProperty("supplier_top_level_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Supplier_top_level_name { get; set; } 

        [JsonProperty("company_object", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public StringIdNameKeyPair? Company_object { get; set; } 

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
        public string? Default_customer_name { get; set; } 

        [JsonProperty("disablerecording", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Disablerecording { get; set; } 

        [JsonProperty("address_mapping_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Address_mapping_type { get; set; } 

        [JsonProperty("sync_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? Sync_entities_list { get; set; } 

        [JsonProperty("sync_committed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sync_committed { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class AzureADConnection
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
        public string? New_client_secret { get; set; } 

        [JsonProperty("new_access_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_access_token { get; set; } 

        [JsonProperty("new_refresh_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_refresh_token { get; set; } 

        [JsonProperty("token_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Token_expiry { get; set; } 

        [JsonProperty("_authcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _authcode { get; set; } 

        [JsonProperty("_exchangecodefortoken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _exchangecodefortoken { get; set; } 

        [JsonProperty("mappings_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Mappings_user { get; set; } 

        [JsonProperty("mappings_agent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Mappings_agent { get; set; } 

        [JsonProperty("mappings_agent_roles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Mappings_agent_roles { get; set; } 

        [JsonProperty("mappings_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AzureADMapping>? Mappings_site { get; set; } 

        [JsonProperty("user_matching_fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? User_matching_fields { get; set; } 

        [JsonProperty("agent_matching_fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Agent_matching_fields { get; set; } 

        [JsonProperty("user_matching_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? User_matching_list { get; set; } 

        [JsonProperty("agent_matching_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? Agent_matching_list { get; set; } 

        [JsonProperty("halointegratorenabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halointegratorenabled { get; set; } 

        [JsonProperty("halointegrator_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Halointegrator_lastsync { get; set; } 

        [JsonProperty("halointegrator_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_lasterror { get; set; } 

        [JsonProperty("redirect_uri", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Redirect_uri { get; set; } 

        [JsonProperty("mappings_cab", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Mappings_cab { get; set; } 

        [JsonProperty("manage_licenses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Manage_licenses { get; set; } 

        [JsonProperty("licensed_roles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Licensed_roles { get; set; } 

        [JsonProperty("licensed_roles_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<StringIdNameKeyPair>? Licensed_roles_list { get; set; } 

        [JsonProperty("tenant_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Tenant_type { get; set; } 

        [JsonProperty("mappings_device", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Mappings_device { get; set; } 

        [JsonProperty("defaultsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Defaultsite { get; set; } 

        [JsonProperty("defaultsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Defaultsite_name { get; set; } 

        [JsonProperty("assettype_choice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Assettype_choice { get; set; } 

        [JsonProperty("default_assetgroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_assetgroup { get; set; } 

        [JsonProperty("default_assetgroup_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Default_assetgroup_guid { get; set; } 

        [JsonProperty("default_assetgroup_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_assetgroup_name { get; set; } 

        [JsonProperty("default_assettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_assettype { get; set; } 

        [JsonProperty("default_assettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Default_assettype_guid { get; set; } 

        [JsonProperty("default_assettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_assettype_name { get; set; } 

        [JsonProperty("assettype_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Assettype_field { get; set; } 

        [JsonProperty("assettype_fieldname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Assettype_fieldname { get; set; } 

        [JsonProperty("import_identifier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Import_identifier { get; set; } 

        [JsonProperty("import_identifier_fieldname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Import_identifier_fieldname { get; set; } 

        [JsonProperty("accountenabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Accountenabled { get; set; } 

        [JsonProperty("authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Authorized { get; set; } 

        [JsonProperty("new_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? New_method { get; set; } 

        [JsonProperty("createunmatchedusers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Createunmatchedusers { get; set; } 

        [JsonProperty("unmatchedusersite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Unmatchedusersite { get; set; } 

        [JsonProperty("unmatchedusersite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Unmatchedusersite_name { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; } 

        [JsonProperty("top_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Top_level { get; set; } 

        [JsonProperty("auto_create_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Auto_create_mappings { get; set; } 

        [JsonProperty("auto_allow_sso", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Auto_allow_sso { get; set; } 

        [JsonProperty("top_level_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Top_level_name { get; set; } 

        [JsonProperty("mappings_client", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AreaAzureTenant>? Mappings_client { get; set; } 

        [JsonProperty("default_ticket_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_ticket_type { get; set; } 

        [JsonProperty("default_ticket_type_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_ticket_type_name { get; set; } 

        [JsonProperty("default_classification", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_classification { get; set; } 

        [JsonProperty("default_classification_reason", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_classification_reason { get; set; } 

        [JsonProperty("default_priority_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_priority_name { get; set; } 

        [JsonProperty("mappings_ticket", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Mappings_ticket { get; set; } 

        [JsonProperty("intune_dont_update_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Intune_dont_update_type { get; set; } 

        [JsonProperty("halo_integrator_import_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halo_integrator_import_list { get; set; } 

        [JsonProperty("halo_integrator_import_types", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? Halo_integrator_import_types { get; set; } 

        [JsonProperty("intune_enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Intune_enabled { get; set; } 

        [JsonProperty("licence_import_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Licence_import_type { get; set; } 

        [JsonProperty("graphendpoint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Graphendpoint { get; set; } 

        [JsonProperty("intuneusermatchingfield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Intuneusermatchingfield { get; set; } 

        [JsonProperty("current_scopes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<string>? Current_scopes { get; set; } 

        [JsonProperty("_dosave", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _dosave { get; set; } 

        [JsonProperty("dont_sync_new_tenants", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dont_sync_new_tenants { get; set; } 

        [JsonProperty("importunmatchedgroupasserviceaccount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Importunmatchedgroupasserviceaccount { get; set; } 

        [JsonProperty("deactivate_users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Deactivate_users { get; set; } 

        [JsonProperty("mappings_priority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Mappings_priority { get; set; } 

        [JsonProperty("allow_subscription_management", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allow_subscription_management { get; set; } 

        [JsonProperty("receive_subscription_updated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Receive_subscription_updated { get; set; } 

        [JsonProperty("graph_host", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Graph_host { get; set; } 

        [JsonProperty("mappings_user_roles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Mappings_user_roles { get; set; } 

        [JsonProperty("alternate_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Alternate_client_id { get; set; } 

        [JsonProperty("new_alternate_client_secret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_alternate_client_secret { get; set; } 

        [JsonProperty("default_relationship_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_relationship_type { get; set; } 

        [JsonProperty("mappings_xtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<XTypeMapping>? Mappings_xtype { get; set; } 

        [JsonProperty("intune_delete_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Intune_delete_status { get; set; } 

        [JsonProperty("intune_delete_status_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intune_delete_status_name { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("sentinel_default_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sentinel_default_user { get; set; } 

        [JsonProperty("sentinel_default_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sentinel_default_user_name { get; set; } 

        [JsonProperty("named_roles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Named_roles { get; set; } 

        [JsonProperty("named_roles_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<StringIdNameKeyPair>? Named_roles_list { get; set; } 

        [JsonProperty("new_user_template", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? New_user_template { get; set; } 

        [JsonProperty("new_user_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? New_user_type { get; set; } 

        [JsonProperty("mappings_new_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Mappings_new_user { get; set; } 

        [JsonProperty("new_user_template_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_user_template_name { get; set; } 

        [JsonProperty("software_import_licence_matching", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Software_import_licence_matching { get; set; } 

        [JsonProperty("default_intune_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_intune_status { get; set; } 

        [JsonProperty("default_intune_status_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_intune_status_name { get; set; } 

        [JsonProperty("no_manager_role", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? No_manager_role { get; set; } 

        [JsonProperty("no_manager_role_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? No_manager_role_name { get; set; } 

        [JsonProperty("track_sign_in_activity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Track_sign_in_activity { get; set; } 

        [JsonProperty("halointegrator_allowedclientidslist", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelKeyPair>? Halointegrator_allowedclientidslist { get; set; } 

        [JsonProperty("halointegrator_allowedclientids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_allowedclientids { get; set; } 

        [JsonProperty("user_licence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? User_licence { get; set; } 

        [JsonProperty("user_licence_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? User_licence_list { get; set; } 

        [JsonProperty("check_licence_list_for_service_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Check_licence_list_for_service_user { get; set; } 

        [JsonProperty("exclude_mssense_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Exclude_mssense_devices { get; set; } 

        [JsonProperty("authentication_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Authentication_type { get; set; } 

        [JsonProperty("_confirmmanagedidentitysetup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _confirmmanagedidentitysetup { get; set; } 

        [JsonProperty("_confirmclientcredentialssetup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _confirmclientcredentialssetup { get; set; } 

        [JsonProperty("allow_presence_notifications", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allow_presence_notifications { get; set; } 

        [JsonProperty("licence_import_client", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Licence_import_client { get; set; } 

        [JsonProperty("licence_import_client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Licence_import_client_name { get; set; } 

        [JsonProperty("assign_licences", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Assign_licences { get; set; } 

        [JsonProperty("resource", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Resource { get; set; } 

        [JsonProperty("only_import_sentinel_comments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Only_import_sentinel_comments { get; set; } 

        [JsonProperty("use_delta_queries", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Use_delta_queries { get; set; } 

        [JsonProperty("_deltareset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AzureDeltaReset? _deltareset { get; set; } 

        [JsonProperty("intune_user_matching_integration", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Intune_user_matching_integration { get; set; } 

        [JsonProperty("intune_recovered_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Intune_recovered_status { get; set; } 

        [JsonProperty("intune_recovered_status_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intune_recovered_status_name { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class AzureADFilter
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("mapping_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Mapping_id { get; set; } 

        [JsonProperty("filter_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Filter_field { get; set; } 

        [JsonProperty("filter_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Filter_type { get; set; } 

        [JsonProperty("filter_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Filter_value { get; set; } 

        [JsonProperty("query_string", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Query_string { get; set; } 

        [JsonProperty("version", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Version { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class AzureADMapping
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("connectionid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Connectionid { get; set; } 

        [JsonProperty("siteid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Siteid { get; set; } 

        [JsonProperty("site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Site_name { get; set; } 

        [JsonProperty("roleid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Roleid { get; set; } 

        [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Client_id { get; set; } 

        [JsonProperty("tenant_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Tenant_id { get; set; } 

        [JsonProperty("tenant_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Tenant_name { get; set; } 

        [JsonProperty("filters", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AzureADFilter>? Filters { get; set; } 

        [JsonProperty("filter_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Filter_count { get; set; } 

        [JsonProperty("group_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Group_name { get; set; } 

        [JsonProperty("external_users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? External_users { get; set; } 

        [JsonProperty("group_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Group_id { get; set; } 

        [JsonProperty("sequenceid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sequenceid { get; set; } 

        [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Description { get; set; } 

        [JsonProperty("site_mapping_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Site_mapping_type { get; set; } 

        [JsonProperty("clientid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Clientid { get; set; } 

        [JsonProperty("client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Client_name { get; set; } 

        [JsonProperty("site_mapping_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Site_mapping_field { get; set; } 

        [JsonProperty("default_site_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_site_id { get; set; } 

        [JsonProperty("default_site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_site_name { get; set; } 

        [JsonProperty("userroleid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Userroleid { get; set; } 

        [JsonProperty("import_photo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Import_photo { get; set; } 

        [JsonProperty("site_mappings_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Site_mappings_user { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

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
        public Guid? Related_guid { get; set; } 

        [JsonProperty("tenant_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Tenant_id { get; set; } 

        [JsonProperty("entity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Entity { get; set; } 

        [JsonProperty("next_delta", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Next_delta { get; set; } 

        [JsonProperty("last_updated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Last_updated { get; set; } 

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
        public string? Instance_url { get; set; } 

        [JsonProperty("new_access_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_access_token { get; set; } 

        [JsonProperty("new_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? New_method { get; set; } 

        [JsonProperty("fields_to_sync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Fields_to_sync { get; set; } 

        [JsonProperty("fields_to_sync_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? Fields_to_sync_list { get; set; } 

        [JsonProperty("sync_mapped_fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sync_mapped_fields { get; set; } 

        [JsonProperty("sync_attachments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sync_attachments { get; set; } 

        [JsonProperty("sync_area_path", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sync_area_path { get; set; } 

        [JsonProperty("sync_iteration_path", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sync_iteration_path { get; set; } 

        [JsonProperty("sync_priority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sync_priority { get; set; } 

        [JsonProperty("sync_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sync_status { get; set; } 

        [JsonProperty("sync_start_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sync_start_date { get; set; } 

        [JsonProperty("sync_target_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sync_target_date { get; set; } 

        [JsonProperty("status_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Status_mappings { get; set; } 

        [JsonProperty("priority_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Priority_mappings { get; set; } 

        [JsonProperty("areapath_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Areapath_mappings { get; set; } 

        [JsonProperty("iterationpath_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Iterationpath_mappings { get; set; } 

        [JsonProperty("otherfield_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Otherfield_mappings { get; set; } 

        [JsonProperty("area_path_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Area_path_field { get; set; } 

        [JsonProperty("iteration_path_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Iteration_path_field { get; set; } 

        [JsonProperty("work_item_description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Work_item_description { get; set; } 

        [JsonProperty("webhook_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Webhook_username { get; set; } 

        [JsonProperty("new_webhook_password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_webhook_password { get; set; } 

        [JsonProperty("webhook_salt", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Webhook_salt { get; set; } 

        [JsonProperty("webhook_iterations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Webhook_iterations { get; set; } 

        [JsonProperty("ticket_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ticket_type { get; set; } 

        [JsonProperty("ticket_type_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ticket_type_name { get; set; } 

        [JsonProperty("ticket_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ticket_user { get; set; } 

        [JsonProperty("ticket_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ticket_user_name { get; set; } 

        [JsonProperty("user_is_created_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? User_is_created_by { get; set; } 

        [JsonProperty("sync_summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sync_summary { get; set; } 

        [JsonProperty("private_updates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Private_updates { get; set; } 

        [JsonProperty("new_webhook_password_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? New_webhook_password_method { get; set; } 

        [JsonProperty("enableintegrator", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enableintegrator { get; set; } 

        [JsonProperty("lastsyncdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Lastsyncdate { get; set; } 

        [JsonProperty("lastsyncerror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Lastsyncerror { get; set; } 

        [JsonProperty("update_days", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Update_days { get; set; } 

        [JsonProperty("enablepipelines", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enablepipelines { get; set; } 

        [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _importtype { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("filters", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFilter>? Filters { get; set; } 

        [JsonProperty("import_entities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Import_entities { get; set; } 

        [JsonProperty("import_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? Import_entities_list { get; set; } 

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