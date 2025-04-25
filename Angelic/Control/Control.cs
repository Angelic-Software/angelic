using System.CodeDom.Compiler;
using Angelic.Areas;
using Angelic.Assets;
using Angelic.Configuration.Integrations;
using Angelic.Configuration.Integrations.Auvik;
using Angelic.Configuration.Integrations.Google;
using Angelic.Configuration.Integrations.Microsoft;
using Angelic.Configuration.Integrations.Microsoft.Azure.AzureAd;
using Angelic.Configuration.Integrations.Microsoft.Dynamics365;
using Angelic.Configuration.Integrations.Okta;
using Angelic.Configuration.SqlImports;
using Angelic.Configuration.TeamsAndAgents;
using Angelic.Configuration.TeamsAndAgents.Agents;
using Angelic.Configuration.Tickets.TicketTypes;
using Angelic.Contracts;
using Angelic.Invoice;
using Newtonsoft.Json;

namespace Angelic.Control;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class Control
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intent { get; set; } 

        [JsonProperty("app_version", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AppVersion { get; set; } 

        [JsonProperty("app_version_nopatch", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AppVersionNopatch { get; set; } 

        [JsonProperty("database_version", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DatabaseVersion { get; set; } 

        [JsonProperty("appname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Appname { get; set; } 

        [JsonProperty("license_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LicenseCount { get; set; } 

        [JsonProperty("concurrent_license_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ConcurrentLicenseCount { get; set; } 

        [JsonProperty("license_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? LicenseName { get; set; } 

        [JsonProperty("trial_expires", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? TrialExpires { get; set; } 

        [JsonProperty("licence_error", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? LicenceError { get; set; } 

        [JsonProperty("syncid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Syncid { get; set; } 

        [JsonProperty("reports_directory", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ReportsDirectory { get; set; } 

        [JsonProperty("one_sla_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? OneSlaId { get; set; } 

        [JsonProperty("one_sla_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? OneSlaGuid { get; set; } 

        [JsonProperty("email_start_tag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? EmailStartTag { get; set; } 

        [JsonProperty("email_end_tag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? EmailEndTag { get; set; } 

        [JsonProperty("contact_status_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ContactStatusId { get; set; } 

        [JsonProperty("contact_status_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? ContactStatusGuid { get; set; } 

        [JsonProperty("default_estimate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? DefaultEstimate { get; set; } 

        [JsonProperty("default_usercontacted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DefaultUsercontacted { get; set; } 

        [JsonProperty("category_1_label", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Category1Label { get; set; } 

        [JsonProperty("category_2_label", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Category2Label { get; set; } 

        [JsonProperty("category_3_label", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Category3Label { get; set; } 

        [JsonProperty("category_4_label", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Category4Label { get; set; } 

        [JsonProperty("customers_label", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CustomersLabel { get; set; } 

        [JsonProperty("show_toplevels", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowToplevels { get; set; } 

        [JsonProperty("file_loc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? FileLoc { get; set; } 

        [JsonProperty("gbitdir", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Gbitdir { get; set; } 

        [JsonProperty("mapfile", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Mapfile { get; set; } 

        [JsonProperty("dudir", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Dudir { get; set; } 

        [JsonProperty("allowduplicateinv", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allowduplicateinv { get; set; } 

        [JsonProperty("sendackemailsforwebrequests", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sendackemailsforwebrequests { get; set; } 

        [JsonProperty("usesage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Usesage { get; set; } 

        [JsonProperty("useqb", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Useqb { get; set; } 

        [JsonProperty("qbversion", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Qbversion { get; set; } 

        [JsonProperty("allowwebupload", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allowwebupload { get; set; } 

        [JsonProperty("enablemultientitysearch", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enablemultientitysearch { get; set; } 

        [JsonProperty("portalallowkbsearch", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Portalallowkbsearch { get; set; } 

        [JsonProperty("portalallowservicesearch", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Portalallowservicesearch { get; set; } 

        [JsonProperty("portalallowticketsearch", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Portalallowticketsearch { get; set; } 

        [JsonProperty("multientitysearchincludefaults", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Multientitysearchincludefaults { get; set; } 

        [JsonProperty("multientitysearchincludekbentry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Multientitysearchincludekbentry { get; set; } 

        [JsonProperty("multientitysearchincludedevice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Multientitysearchincludedevice { get; set; } 

        [JsonProperty("multientitysearchincludearea", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Multientitysearchincludearea { get; set; } 

        [JsonProperty("multientitysearchincludesite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Multientitysearchincludesite { get; set; } 

        [JsonProperty("multientitysearchincludeusers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Multientitysearchincludeusers { get; set; } 

        [JsonProperty("multientitysearchincludecompany", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Multientitysearchincludecompany { get; set; } 

        [JsonProperty("multientitysearchincludeitem", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Multientitysearchincludeitem { get; set; } 

        [JsonProperty("multientitysearchincludequote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Multientitysearchincludequote { get; set; } 

        [JsonProperty("multientitysearchincludeso", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Multientitysearchincludeso { get; set; } 

        [JsonProperty("multientitysearchincludepo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Multientitysearchincludepo { get; set; } 

        [JsonProperty("multientitysearchincludeservices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Multientitysearchincludeservices { get; set; } 

        [JsonProperty("showquicksearch", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showquicksearch { get; set; } 

        [JsonProperty("showtreesearch", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowTreesearch { get; set; } 

        [JsonProperty("defaultpdftemplatecredit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Defaultpdftemplatecredit { get; set; } 

        [JsonProperty("allownewuserfromchangeuserscreen", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allownewuserfromchangeuserscreen { get; set; } 

        [JsonProperty("adselfservicewebapppwdresettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Adselfservicewebapppwdresettype { get; set; } 

        [JsonProperty("tickettimerdisplay", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Tickettimerdisplay { get; set; } 

        [JsonProperty("portalbuttonmaxperrow", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Portalbuttonmaxperrow { get; set; } 

        [JsonProperty("continuallyappid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Continuallyappid { get; set; } 

        [JsonProperty("tawkappid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Tawkappid { get; set; } 

        [JsonProperty("percentageoverdue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Percentageoverdue { get; set; } 

        [JsonProperty("trackticketviews", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Trackticketviews { get; set; } 

        [JsonProperty("showprepaybalanceonticket", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showprepaybalanceonticket { get; set; } 

        [JsonProperty("ssorememberme", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ssorememberme { get; set; } 

        [JsonProperty("eupallowsiteselection", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Eupallowsiteselection { get; set; } 

        [JsonProperty("showtemplateselectionbutton", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowTemplateselectionbutton { get; set; } 

        [JsonProperty("showsaveastemplatebutton", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showsaveastemplatebutton { get; set; } 

        [JsonProperty("welcome_message_label", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? WelcomeMessageLabel { get; set; } 

        [JsonProperty("problemmatchsearchmode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Problemmatchsearchmode { get; set; } 

        [JsonProperty("sage50username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sage50Username { get; set; } 

        [JsonProperty("sage50version", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sage50Version { get; set; } 

        [JsonProperty("sage50datapath", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sage50datapath { get; set; } 

        [JsonProperty("updateticketwhenpoinstock", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Updateticketwhenpoinstock { get; set; } 

        [JsonProperty("updateticketwhenpoinstockstatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Updateticketwhenpoinstockstatus { get; set; } 

        [JsonProperty("updateticketwhenpoinstockstatus_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? UpdateticketwhenpoinstockstatusGuid { get; set; } 

        [JsonProperty("allowstockreserve", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allowstockreserve { get; set; } 

        [JsonProperty("budgetcalctype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Budgetcalctype { get; set; } 

        [JsonProperty("periodsaheadforcontractinvoicestart", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Periodsaheadforcontractinvoicestart { get; set; } 

        [JsonProperty("defaultcontractenddatetype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Defaultcontractenddatetype { get; set; } 

        [JsonProperty("encthumbprint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Encthumbprint { get; set; } 

        [JsonProperty("homescreendashboardid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Homescreendashboardid { get; set; } 

        [JsonProperty("sidemenudashboardid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sidemenudashboardid { get; set; } 

        [JsonProperty("loadimagesfromapitype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Loadimagesfromapitype { get; set; } 

        [JsonProperty("loadattachmentsfromapitype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Loadattachmentsfromapitype { get; set; } 

        [JsonProperty("loadimagesfromapilocation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Loadimagesfromapilocation { get; set; } 

        [JsonProperty("loadimagesfromapiurloverride", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Loadimagesfromapiurloverride { get; set; } 

        [JsonProperty("allowlivechatonnewportal", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allowlivechatonnewportal { get; set; } 

        [JsonProperty("allowtaxcodeoverride", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allowtaxcodeoverride { get; set; } 

        [JsonProperty("mergerecurringinvoices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Mergerecurringinvoices { get; set; } 

        [JsonProperty("mergesalesorderinvoices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Mergesalesorderinvoices { get; set; } 

        [JsonProperty("showusersassetsonticket", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showusersassetsonticket { get; set; } 

        [JsonProperty("showusersassetsoncall", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showusersassetsoncall { get; set; } 

        [JsonProperty("enablementions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enablementions { get; set; } 

        [JsonProperty("enablementionscrm", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enablementionscrm { get; set; } 

        [JsonProperty("enableteammentions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enableteammentions { get; set; } 

        [JsonProperty("usetechfwdfunctionalityupdateparent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Usetechfwdfunctionalityupdateparent { get; set; } 

        [JsonProperty("pomincostforapproval", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Pomincostforapproval { get; set; } 

        [JsonProperty("poapproverselectiontype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Poapproverselectiontype { get; set; } 

        [JsonProperty("enablequoteapprovals", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enablequoteapprovals { get; set; } 

        [JsonProperty("quotemarginforapproval", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Quotemarginforapproval { get; set; } 

        [JsonProperty("enablemyreports", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enablemyreports { get; set; } 

        [JsonProperty("enablemyscheduledreports", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enablemyscheduledreports { get; set; } 

        [JsonProperty("showquotecannedonapprovalscreen", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showquotecannedonapprovalscreen { get; set; } 

        [JsonProperty("enableagentbooking", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enableagentbooking { get; set; } 

        [JsonProperty("agentbooking_min_hours_advance", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? AgentbookingMinHoursAdvance { get; set; } 

        [JsonProperty("agentbooking_max_days_advance", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? AgentbookingMaxDaysAdvance { get; set; } 

        [JsonProperty("agentbookingonlyauthenticated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Agentbookingonlyauthenticated { get; set; } 

        [JsonProperty("enableprojecttreeview", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enableprojecttreeview { get; set; } 

        [JsonProperty("publishchangecalendar", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Publishchangecalendar { get; set; } 

        [JsonProperty("enablekbdrafts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enablekbdrafts { get; set; } 

        [JsonProperty("kbdrafttickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Kbdrafttickettype { get; set; } 

        [JsonProperty("kbdrafttickettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? KbdrafttickettypeGuid { get; set; } 

        [JsonProperty("usecurrencyconversion", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Usecurrencyconversion { get; set; } 

        [JsonProperty("usetravelchargerates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Usetravelchargerates { get; set; } 

        [JsonProperty("usersearchmode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Usersearchmode { get; set; } 

        [JsonProperty("usersearchmode2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Usersearchmode2 { get; set; } 

        [JsonProperty("detailsscreendisplaytype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Detailsscreendisplaytype { get; set; } 

        [JsonProperty("navdisplaymode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Navdisplaymode { get; set; } 

        [JsonProperty("usesemanticversioning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Usesemanticversioning { get; set; } 

        [JsonProperty("usesecurequotesigning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Usesecurequotesigning { get; set; } 

        [JsonProperty("timefieldinputtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Timefieldinputtype { get; set; } 

        [JsonProperty("ticketdetailstitledisplaymode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ticketdetailstitledisplaymode { get; set; } 

        [JsonProperty("allownewusersiteid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Allownewusersiteid { get; set; } 

        [JsonProperty("allow_new_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowNewUser { get; set; } 

        [JsonProperty("newusersite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewusersiteName { get; set; } 

        [JsonProperty("itemnamesunique", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Itemnamesunique { get; set; } 

        [JsonProperty("translationtexttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Translationtexttype { get; set; } 

        [JsonProperty("translationmonthlycharactercap", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Translationmonthlycharactercap { get; set; } 

        [JsonProperty("translationmonthlycharactercapcanedit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Translationmonthlycharactercapcanedit { get; set; } 

        [JsonProperty("crmshowextradetails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Crmshowextradetails { get; set; } 

        [JsonProperty("defaultclientdetailslayout", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Defaultclientdetailslayout { get; set; } 

        [JsonProperty("kbviewagentapp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Kbviewagentapp { get; set; } 

        [JsonProperty("enablefulltextsearchactions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enablefulltextsearchactions { get; set; } 

        [JsonProperty("addressfieldtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Addressfieldtype { get; set; } 

        [JsonProperty("livechatconnectionmethod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Livechatconnectionmethod { get; set; } 

        [JsonProperty("portalchatprofile", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Portalchatprofile { get; set; } 

        [JsonProperty("sage50ukinvoicetype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sage50Ukinvoicetype { get; set; } 

        [JsonProperty("twilliosmsaccountsid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Twilliosmsaccountsid { get; set; } 

        [JsonProperty("twilliosmsauthtoken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Twilliosmsauthtoken { get; set; } 

        [JsonProperty("new_twilliosmsauthtoken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewTwilliosmsauthtoken { get; set; } 

        [JsonProperty("twilliosmsfromphonenumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Twilliosmsfromphonenumber { get; set; } 

        [JsonProperty("twilliosmsleadingzerosubstitute", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Twilliosmsleadingzerosubstitute { get; set; } 

        [JsonProperty("smstype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Smstype { get; set; } 

        [JsonProperty("connectwisemanageclientid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Connectwisemanageclientid { get; set; } 

        [JsonProperty("showallphonenumbersonticketdetails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowAllphonenumbersonticketdetails { get; set; } 

        [JsonProperty("sendaccountmanagernotifications", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sendaccountmanagernotifications { get; set; } 

        [JsonProperty("useutcforappointments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Useutcforappointments { get; set; } 

        [JsonProperty("stopautomaticdevicemovementsinstock", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Stopautomaticdevicemovementsinstock { get; set; } 

        [JsonProperty("setdisplaynametoagentname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Setdisplaynametoagentname { get; set; } 

        [JsonProperty("livechatjoinmode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Livechatjoinmode { get; set; } 

        [JsonProperty("chatshownewbubble", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Chatshownewbubble { get; set; } 

        [JsonProperty("automateticketscriptid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Automateticketscriptid { get; set; } 

        [JsonProperty("automateticketscriptentityid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Automateticketscriptentityid { get; set; } 

        [JsonProperty("syncingxeroproducts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Syncingxeroproducts { get; set; } 

        [JsonProperty("report_colour_palette", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ReportColourPalette { get; set; } 

        [JsonProperty("enablehalostripe", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enablehalostripe { get; set; } 

        [JsonProperty("enablehalostripewebhooks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enablehalostripewebhooks { get; set; } 

        [JsonProperty("donotcreateuser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Donotcreateuser { get; set; } 

        [JsonProperty("attachmentstabtable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Attachmentstabtable { get; set; } 

        [JsonProperty("enablehalonews", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enablehalonews { get; set; } 

        [JsonProperty("enablestockbins", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enablestockbins { get; set; } 

        [JsonProperty("defaultstockbinlocation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Defaultstockbinlocation { get; set; } 

        [JsonProperty("defaultmovestocklocation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Defaultmovestocklocation { get; set; } 

        [JsonProperty("defaultmovestockbinlocation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Defaultmovestockbinlocation { get; set; } 

        [JsonProperty("enableportalgdprscreen", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enableportalgdprscreen { get; set; } 

        [JsonProperty("autocreatecustomerreference", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Autocreatecustomerreference { get; set; } 

        [JsonProperty("autogenerate_itemaccountsid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutogenerateItemaccountsid { get; set; } 

        [JsonProperty("useeventservice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Useeventservice { get; set; } 

        [JsonProperty("useschedulingservice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Useschedulingservice { get; set; } 

        [JsonProperty("timesensitivemethod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Timesensitivemethod { get; set; } 

        [JsonProperty("usedefaultsubjectmatchingtag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Usedefaultsubjectmatchingtag { get; set; } 

        [JsonProperty("useprepaypurchasedatesforcalculatingbalance", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Useprepaypurchasedatesforcalculatingbalance { get; set; } 

        [JsonProperty("sagebusinessclouddefaulttenantid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sagebusinessclouddefaulttenantid { get; set; } 

        [JsonProperty("sagebusinesscloud_default_invoice_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SagebusinesscloudDefaultInvoiceStatus { get; set; } 

        [JsonProperty("sagebusinesscloud_default_invoice_status_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? SagebusinesscloudDefaultInvoiceStatusGuid { get; set; } 

        [JsonProperty("publishchangecalendartype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Publishchangecalendartype { get; set; } 

        [JsonProperty("xero_post_group_headers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? XeroPostGroupHeaders { get; set; } 

        [JsonProperty("responsedontassign", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Responsedontassign { get; set; } 

        [JsonProperty("automaticallysendsignedticketclosurepdf", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Automaticallysendsignedticketclosurepdf { get; set; } 

        [JsonProperty("linkrecurringapptticket", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Linkrecurringapptticket { get; set; } 

        [JsonProperty("closetaskswhenclosingticket", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Closetaskswhenclosingticket { get; set; } 

        [JsonProperty("assetserializationtabbehaviour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Assetserializationtabbehaviour { get; set; } 

        [JsonProperty("showassettagongoodsout", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowAssettagongoodsout { get; set; } 

        [JsonProperty("mustsetcustomerfirst", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Mustsetcustomerfirst { get; set; } 

        [JsonProperty("dontsendacktononsitedomain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dontsendacktononsitedomain { get; set; } 

        [JsonProperty("salesorderstatusafterinvoiced", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Salesorderstatusafterinvoiced { get; set; } 

        [JsonProperty("salesorderstatusafterinvoicedandactionscomplete", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Salesorderstatusafterinvoicedandactionscomplete { get; set; } 

        [JsonProperty("defaultfornewopportunityuser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Defaultfornewopportunityuser { get; set; } 

        [JsonProperty("donotshowwarrantyexpiration", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Donotshowwarrantyexpiration { get; set; } 

        [JsonProperty("hide_default_opps_area", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HideDefaultOppsArea { get; set; } 

        [JsonProperty("show_asset_diagram_services", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowAssetDiagramServices { get; set; } 

        [JsonProperty("portal_kb_matching_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PortalKbMatchingType { get; set; } 

        [JsonProperty("checkticketclashes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Checkticketclashes { get; set; } 

        [JsonProperty("enable_contract_rollover", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableContractRollover { get; set; } 

        [JsonProperty("contract_usage_next_month_percent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? ContractUsageNextMonthPercent { get; set; } 

        [JsonProperty("ninja_alert_webhooks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? NinjaAlertWebhooks { get; set; } 

        [JsonProperty("additionalresponseactioninfo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Additionalresponseactioninfo { get; set; } 

        [JsonProperty("quoter_default_template", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? QuoterDefaultTemplate { get; set; } 

        [JsonProperty("quoter_instance_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? QuoterInstanceUrl { get; set; } 

        [JsonProperty("quoter_open_contact_form", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? QuoterOpenContactForm { get; set; } 

        [JsonProperty("quoter_create_sales_orders", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? QuoterCreateSalesOrders { get; set; } 

        [JsonProperty("quoter_invoice_prefix", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? QuoterInvoicePrefix { get; set; } 

        [JsonProperty("quoter_enable_xero_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? QuoterEnableXeroLink { get; set; } 

        [JsonProperty("splashtop_email_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SplashtopEmailType { get; set; } 

        [JsonProperty("splashtop_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SplashtopEmail { get; set; } 

        [JsonProperty("splashtop_mac_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SplashtopMacField { get; set; } 

        [JsonProperty("sso_bypass_2fa", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SsoBypass2Fa { get; set; } 

        [JsonProperty("default_user_role", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultUserRole { get; set; } 

        [JsonProperty("default_user_role_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? DefaultUserRoleGuid { get; set; } 

        [JsonProperty("default_user_role_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultUserRoleName { get; set; } 

        [JsonProperty("preventclashchangelogging", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Preventclashchangelogging { get; set; } 

        [JsonProperty("exactdefaultdivision", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Exactdefaultdivision { get; set; } 

        [JsonProperty("removewelcomemessage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Removewelcomemessage { get; set; } 

        [JsonProperty("new_search_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewSearchType { get; set; } 

        [JsonProperty("limit_action_search", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? LimitActionSearch { get; set; } 

        [JsonProperty("app_scheduler_show_all_agents", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AppSchedulerShowAllAgents { get; set; } 

        [JsonProperty("enableagentcheckins", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enableagentcheckins { get; set; } 

        [JsonProperty("nabledeletedevices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Nabledeletedevices { get; set; } 

        [JsonProperty("allow_user_impersonation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowUserImpersonation { get; set; } 

        [JsonProperty("allow_agent_impersonation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowAgentImpersonation { get; set; } 

        [JsonProperty("copy_attachments_area", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? CopyAttachmentsArea { get; set; } 

        [JsonProperty("enableconfigchangetracking", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enableconfigchangetracking { get; set; } 

        [JsonProperty("xero_default_invoice_line_tax", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? XeroDefaultInvoiceLineTax { get; set; } 

        [JsonProperty("invoice_prepay_before_use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? InvoicePrepayBeforeUse { get; set; } 

        [JsonProperty("add_attachment_tags", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AddAttachmentTags { get; set; } 

        [JsonProperty("show_back_button", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowBackButton { get; set; } 

        [JsonProperty("samlidp_colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SamlidpColour { get; set; } 

        [JsonProperty("samlidp_logo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SamlidpLogo { get; set; } 

        [JsonProperty("allow_idp_initiated_requests", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowIdpInitiatedRequests { get; set; } 

        [JsonProperty("authn_requests_signed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AuthnRequestsSigned { get; set; } 

        [JsonProperty("split_customers_area", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SplitCustomersArea { get; set; } 

        [JsonProperty("hide_customers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HideCustomers { get; set; } 

        [JsonProperty("floating_contact_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? FloatingContactSite { get; set; } 

        [JsonProperty("floating_contact_site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? FloatingContactSiteName { get; set; } 

        [JsonProperty("ticketstatusafterquoteapproval", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ticketstatusafterquoteapproval { get; set; } 

        [JsonProperty("nag_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NagUser { get; set; } 

        [JsonProperty("nag_tickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NagTicketType { get; set; } 

        [JsonProperty("nag_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NagUserName { get; set; } 

        [JsonProperty("nag_warning_priority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NagWarningPriority { get; set; } 

        [JsonProperty("nag_critical_priority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NagCriticalPriority { get; set; } 

        [JsonProperty("nag_assetipaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NagAssetipaddress { get; set; } 

        [JsonProperty("nag_assethostname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NagAssethostname { get; set; } 

        [JsonProperty("bulk_privatenote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? BulkPrivatenote { get; set; } 

        [JsonProperty("bulk_publicnote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? BulkPublicnote { get; set; } 

        [JsonProperty("connectwise_control_client_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ConnectwiseControlClientField { get; set; } 

        [JsonProperty("connectwise_control_site_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ConnectwiseControlSiteField { get; set; } 

        [JsonProperty("connectwisecontroltoplevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Connectwisecontroltoplevel { get; set; } 

        [JsonProperty("connectwise_control_asset_type_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ConnectwiseControlAssetTypeField { get; set; } 

        [JsonProperty("connectwisecontrolassetdefaultsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Connectwisecontrolassetdefaultsite { get; set; } 

        [JsonProperty("connectwisecontrol_delete_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ConnectwisecontrolDeleteDevices { get; set; } 

        [JsonProperty("connectwisecontrolimportentities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Connectwisecontrolimportentities { get; set; } 

        [JsonProperty("connectwisecontrol_defaultassettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ConnectwisecontrolDefaultassettype { get; set; } 

        [JsonProperty("showagentuserfieldsportal", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowAgentuserfieldsportal { get; set; } 

        [JsonProperty("prepay_usage_next_month_percent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PrepayUsageNextMonthPercent { get; set; } 

        [JsonProperty("group_service_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? GroupServiceStatus { get; set; } 

        [JsonProperty("force_user_2fa", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ForceUser2Fa { get; set; } 

        [JsonProperty("quicktime_default_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? QuicktimeDefaultSite { get; set; } 

        [JsonProperty("quicktime_default_clientsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? QuicktimeDefaultClientsiteName { get; set; } 

        [JsonProperty("bulkslachange", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Bulkslachange { get; set; } 

        [JsonProperty("assetshowsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Assetshowsite { get; set; } 

        [JsonProperty("assetshowkeyfield1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Assetshowkeyfield1 { get; set; } 

        [JsonProperty("assetshowkeyfield2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Assetshowkeyfield2 { get; set; } 

        [JsonProperty("assetshowkeyfield3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Assetshowkeyfield3 { get; set; } 

        [JsonProperty("showopenjourneysintodo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowOpenjourneysintodo { get; set; } 

        [JsonProperty("workspace_defaultgroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? WorkspaceDefaultgroup { get; set; } 

        [JsonProperty("workspace_defaultgroup_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? WorkspaceDefaultgroupGuid { get; set; } 

        [JsonProperty("workspace_delete_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? WorkspaceDeleteDevices { get; set; } 

        [JsonProperty("workspace_assettypefield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? WorkspaceAssetTypefield { get; set; } 

        [JsonProperty("workspace_integrator_import_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? WorkspaceIntegratorImportList { get; set; } 

        [JsonProperty("workspace_integrator_import_types", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? WorkspaceIntegratorImportTypes { get; set; } 

        [JsonProperty("workspace_dont_update_asset_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? WorkspaceDontUpdateAssetType { get; set; } 

        [JsonProperty("addigy_assettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AddigyAssetType { get; set; } 

        [JsonProperty("addigy_assettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? AddigyAssetTypeGuid { get; set; } 

        [JsonProperty("default_salesforce_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultSalesforceUser { get; set; } 

        [JsonProperty("default_salesforce_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultSalesforceUsername { get; set; } 

        [JsonProperty("lansweeper_update_asset_only", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? LansweeperUpdateAssetOnly { get; set; } 

        [JsonProperty("show_appointment_location", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowAppointmentLocation { get; set; } 

        [JsonProperty("show_appointment_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowAppointmentStatus { get; set; } 

        [JsonProperty("appointment_location_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AppointmentLocationType { get; set; } 

        [JsonProperty("email_list_for_payments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? EmailListForPayments { get; set; } 

        [JsonProperty("createproratanormallines", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Createproratanormallines { get; set; } 

        [JsonProperty("enablekbfulltextsearch", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enablekbfulltextsearch { get; set; } 

        [JsonProperty("roadmapcategory", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Roadmapcategory { get; set; } 

        [JsonProperty("site_override_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SiteOverrideType { get; set; } 

        [JsonProperty("defaultcostperweight", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Defaultcostperweight { get; set; } 

        [JsonProperty("defaultpdftemplatekb", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Defaultpdftemplatekb { get; set; } 

        [JsonProperty("show_siteselect_client", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowSiteselectClient { get; set; } 

        [JsonProperty("enableinvoiceapprovals", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enableinvoiceapprovals { get; set; } 

        [JsonProperty("ninjarmm_deeplink_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NinjarmmDeeplinkUrl { get; set; } 

        [JsonProperty("pagerduty_webhook_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PagerdutyWebhookType { get; set; } 

        [JsonProperty("twilio_allow_inbound", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? TwilioAllowInbound { get; set; } 

        [JsonProperty("twilio_ticket_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TwilioTicketType { get; set; } 

        [JsonProperty("twilio_default_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TwilioDefaultUser { get; set; } 

        [JsonProperty("twilio_reopen_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? TwilioReopenTickets { get; set; } 

        [JsonProperty("new_tickettypes_available_to_all_customers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? NewTicketTypesAvailableToAllCustomers { get; set; } 

        [JsonProperty("mark_unassigned_closed_alerts_as_read", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? MarkUnassignedClosedAlertsAsRead { get; set; } 

        [JsonProperty("decimalplacesforinvoices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Decimalplacesforinvoices { get; set; } 

        [JsonProperty("createproratainvoicesautomatically", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Createproratainvoicesautomatically { get; set; } 

        [JsonProperty("restrict_items_on_po_by_supplier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? RestrictItemsOnPoBySupplier { get; set; } 

        [JsonProperty("intacctdefaultloctype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intacctdefaultloctype { get; set; } 

        [JsonProperty("tabnametype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Tabnametype { get; set; } 

        [JsonProperty("calcincminprojectlevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Calcincminprojectlevel { get; set; } 

        [JsonProperty("etilizelocale", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Etilizelocale { get; set; } 

        [JsonProperty("etilizecatalog", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Etilizecatalog { get; set; } 

        [JsonProperty("b2cazuretenantid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? B2Cazuretenantid { get; set; } 

        [JsonProperty("b2cazuressoappid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? B2Cazuressoappid { get; set; } 

        [JsonProperty("b2cenableazuresinglesignon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? B2Cenableazuresinglesignon { get; set; } 

        [JsonProperty("b2cazureadsso", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? B2Cazureadsso { get; set; } 

        [JsonProperty("b2cazure_auto_create_users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? B2CazureAutoCreateUsers { get; set; } 

        [JsonProperty("b2cazure_auto_creation_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? B2CazureAutoCreationSite { get; set; } 

        [JsonProperty("b2cazureautoredirect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? B2Cazureautoredirect { get; set; } 

        [JsonProperty("po_CC_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PoCcAddress { get; set; } 

        [JsonProperty("po_BCC_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PoBccAddress { get; set; } 

        [JsonProperty("mandatoryapprovecomment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Mandatoryapprovecomment { get; set; } 

        [JsonProperty("exchange_appointment_sync_end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ExchangeAppointmentSyncEndDate { get; set; } 

        [JsonProperty("forwardagentfollower", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Forwardagentfollower { get; set; } 

        [JsonProperty("enable_image_popout", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableImagePopout { get; set; } 

        [JsonProperty("intune_delete_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? IntuneDeleteStatus { get; set; } 

        [JsonProperty("lansweeper_relation_sync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? LansweeperRelationSync { get; set; } 

        [JsonProperty("admin_extra_read", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AdminExtraRead { get; set; } 

        [JsonProperty("asset_display_data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AssetDisplayData { get; set; } 

        [JsonProperty("use_project_start_and_target_date_for_appointment_action", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseProjectStartAndTargetDateForAppointmentAction { get; set; } 

        [JsonProperty("showmigrations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowMigrations { get; set; } 

        [JsonProperty("salesforceimportcasefeed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Salesforceimportcasefeed { get; set; } 

        [JsonProperty("suzuki_gateway", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SuzukiGateway { get; set; } 

        [JsonProperty("releases_from_devops_project", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReleasesFromDevOpsProject { get; set; } 

        [JsonProperty("auto_load_dependency_chart", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoLoadDependencyChart { get; set; } 

        [JsonProperty("processstreettickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Processstreettickettype { get; set; } 

        [JsonProperty("processstreetuser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Processstreetuser { get; set; } 

        [JsonProperty("chargerateroundmultorder", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Chargerateroundmultorder { get; set; } 

        [JsonProperty("qbodisablecfsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Qbodisablecfsync { get; set; } 

        [JsonProperty("qbocfdefinition", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Qbocfdefinition { get; set; } 

        [JsonProperty("qbocfname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Qbocfname { get; set; } 

        [JsonProperty("preventuserchange", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Preventuserchange { get; set; } 

        [JsonProperty("default_showdefaultsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DefaultShowdefaultsite { get; set; } 

        [JsonProperty("default_showgeneralusers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DefaultShowgeneralusers { get; set; } 

        [JsonProperty("default_showagentusers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DefaultShowAgentusers { get; set; } 

        [JsonProperty("default_showinternalcustomers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DefaultShowinternalcustomers { get; set; } 

        [JsonProperty("showmodalscreenforcannedtext", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowModalscreenforcannedtext { get; set; } 

        [JsonProperty("logicmonitor_defaultsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LogicmonitorDefaultsite { get; set; } 

        [JsonProperty("logicmonitor_defaultassettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LogicmonitorDefaultassettype { get; set; } 

        [JsonProperty("logicmonitor_enable_alerting", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? LogicmonitorEnableAlerting { get; set; } 

        [JsonProperty("logicmonitor_alert_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LogicmonitorAlertType { get; set; } 

        [JsonProperty("logicmonitor_alert_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LogicmonitorAlertUser { get; set; } 

        [JsonProperty("logicmonitor_delete_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? LogicmonitorDeleteDevices { get; set; } 

        [JsonProperty("htmltemplateeditortype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Htmltemplateeditortype { get; set; } 

        [JsonProperty("allow_live_chat_teams", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowLiveChatTeams { get; set; } 

        [JsonProperty("teams_chat_profile", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TeamsChatProfile { get; set; } 

        [JsonProperty("teams_options_style", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TeamsOptionsStyle { get; set; } 

        [JsonProperty("workspace_defaultsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? WorkspaceDefaultsite { get; set; } 

        [JsonProperty("followers_scope", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? FollowersScope { get; set; } 

        [JsonProperty("cc_scope", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CcScope { get; set; } 

        [JsonProperty("adjustpriceforsoinvoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Adjustpriceforsoinvoice { get; set; } 

        [JsonProperty("showallforopplink", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowAllforopplink { get; set; } 

        [JsonProperty("intacct_sync_halo_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? IntacctSyncHaloId { get; set; } 

        [JsonProperty("intacctdefaultwarid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intacctdefaultwarid { get; set; } 

        [JsonProperty("default_intacct_save_location", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultIntacctSaveLocation { get; set; } 

        [JsonProperty("intacctdonttaxpos", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Intacctdonttaxpos { get; set; } 

        [JsonProperty("intacctdefaultglgroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intacctdefaultglgroup { get; set; } 

        [JsonProperty("intacctdefaultmanualitemtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intacctdefaultmanualitemtype { get; set; } 

        [JsonProperty("intacctdefaultautoitemtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intacctdefaultautoitemtype { get; set; } 

        [JsonProperty("intaccttaxonseparateline", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Intaccttaxonseparateline { get; set; } 

        [JsonProperty("intaccttaxonseparatelineitem", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intaccttaxonseparatelineitem { get; set; } 

        [JsonProperty("intacctcredittransdef", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intacctcredittransdef { get; set; } 

        [JsonProperty("intacctpotransdef", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intacctpotransdef { get; set; } 

        [JsonProperty("intacctbilltransdef", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intacctbilltransdef { get; set; } 

        [JsonProperty("intacctsigtax", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Intacctsigtax { get; set; } 

        [JsonProperty("allowusermerging", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allowusermerging { get; set; } 

        [JsonProperty("defaultpdftemplateinvoicetickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Defaultpdftemplateinvoicetickets { get; set; } 

        [JsonProperty("defaultpdftemplateinvoiceorders", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Defaultpdftemplateinvoiceorders { get; set; } 

        [JsonProperty("defaultpdftemplateinvoicerecurring", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Defaultpdftemplateinvoicerecurring { get; set; } 

        [JsonProperty("stripetakepaymentonduedate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Stripetakepaymentonduedate { get; set; } 

        [JsonProperty("hubspot_default_lifecycle_stage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HubspotDefaultLifecycleStage { get; set; } 

        [JsonProperty("itsm_tickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ItsmTicketType { get; set; } 

        [JsonProperty("send_new_users_welcome_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SendNewUsersWelcomeEmail { get; set; } 

        [JsonProperty("logicmonitor_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LogicmonitorImportType { get; set; } 

        [JsonProperty("barracuda_defaultsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? BarracudaDefaultsite { get; set; } 

        [JsonProperty("barracudadefaultassettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Barracudadefaultassettype { get; set; } 

        [JsonProperty("barracuda_alert_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? BarracudaAlertUser { get; set; } 

        [JsonProperty("barracuda_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? BarracudaImportType { get; set; } 

        [JsonProperty("barracuda_delete_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? BarracudaDeleteDevices { get; set; } 

        [JsonProperty("useoutgoingservice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Useoutgoingservice { get; set; } 

        [JsonProperty("enableteamsmsg", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enableteamsmsg { get; set; } 

        [JsonProperty("defaultteamsmsg", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Defaultteamsmsg { get; set; } 

        [JsonProperty("audit_teams_message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AuditTeamsMessage { get; set; } 

        [JsonProperty("whatsappcreatetickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Whatsappcreatetickets { get; set; } 

        [JsonProperty("prmerge_outcome_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PrmergeOutcomeId { get; set; } 

        [JsonProperty("hide_halo_invoice_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HideHaloInvoiceId { get; set; } 

        [JsonProperty("default_quoter_country_iso", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultQuoterCountryIso { get; set; } 

        [JsonProperty("default_quoter_region_iso", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultQuoterRegionIso { get; set; } 

        [JsonProperty("remove_licences_when_inactive", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? RemoveLicencesWhenInactive { get; set; } 

        [JsonProperty("allow_additional_agents_on_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowAdditionalAgentsOnTickets { get; set; } 

        [JsonProperty("users_label", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? UsersLabel { get; set; } 

        [JsonProperty("showusernoteswhenempty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showusernoteswhenempty { get; set; } 

        [JsonProperty("showsitenoteswhenempty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showsitenoteswhenempty { get; set; } 

        [JsonProperty("showareanoteswhenempty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowAreanoteswhenempty { get; set; } 

        [JsonProperty("show_enduser_details_opps", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowEnduserDetailsOpps { get; set; } 

        [JsonProperty("max_parent_deps", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxParentDeps { get; set; } 

        [JsonProperty("max_child_deps", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxChildDeps { get; set; } 

        [JsonProperty("invoiceitembillingdescriptionlong", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Invoiceitembillingdescriptionlong { get; set; } 

        [JsonProperty("invoiceitembillingdescriptionshort", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Invoiceitembillingdescriptionshort { get; set; } 

        [JsonProperty("default_columns_id_clients", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultColumnsIdClients { get; set; } 

        [JsonProperty("default_columns_id_clients_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? DefaultColumnsIdClientsGuid { get; set; } 

        [JsonProperty("hide_other_dep_teams", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HideOtherDepTeams { get; set; } 

        [JsonProperty("kbeditorrich", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Kbeditorrich { get; set; } 

        [JsonProperty("kbeditormarkdown", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Kbeditormarkdown { get; set; } 

        [JsonProperty("chat_image_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ChatImageType { get; set; } 

        [JsonProperty("cognigyendpoint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Cognigyendpoint { get; set; } 

        [JsonProperty("connectwiseautomatealertlastupdated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Connectwiseautomatealertlastupdated { get; set; } 

        [JsonProperty("cannedsuggestnewticket", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Cannedsuggestnewticket { get; set; } 

        [JsonProperty("service_permission_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ServicePermissionType { get; set; } 

        [JsonProperty("includeslaholdloadbalancing", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Includeslaholdloadbalancing { get; set; } 

        [JsonProperty("milestone_update_all_dates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? MilestoneUpdateAllDates { get; set; } 

        [JsonProperty("match_ninja_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? MatchNinjaUser { get; set; } 

        [JsonProperty("uselistgroups", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Uselistgroups { get; set; } 

        [JsonProperty("allowquickuseradd", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allowquickuseradd { get; set; } 

        [JsonProperty("connectwise_automate_control_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ConnectwiseAutomateControlGuid { get; set; } 

        [JsonProperty("supp_contract_mandatory", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SuppContractMandatory { get; set; } 

        [JsonProperty("searchfullticketids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Searchfullticketids { get; set; } 

        [JsonProperty("qualysusertype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Qualysusertype { get; set; } 

        [JsonProperty("googleworkspacenamedroles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Googleworkspacenamedroles { get; set; } 

        [JsonProperty("oktanamedroles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Oktanamedroles { get; set; } 

        [JsonProperty("lansweeper_assettype_choice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LansweeperAssetTypeChoice { get; set; } 

        [JsonProperty("lansweeper_default_assettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LansweeperDefaultAssetType { get; set; } 

        [JsonProperty("lansweeper_assettype_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? LansweeperAssetTypeField { get; set; } 

        [JsonProperty("barracuda_alert_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? BarracudaAlertType { get; set; } 

        [JsonProperty("preventparentchange", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Preventparentchange { get; set; } 

        [JsonProperty("planning_orange_percentage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? PlanningOrangePercentage { get; set; } 

        [JsonProperty("planning_red_percentage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? PlanningRedPercentage { get; set; } 

        [JsonProperty("whatsappreopentickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Whatsappreopentickets { get; set; } 

        [JsonProperty("whatsapptickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Whatsapptickettype { get; set; } 

        [JsonProperty("intacct_use_apinvoices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IntacctUseApinvoices { get; set; } 

        [JsonProperty("intacct_use_arinvoices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IntacctUseArinvoices { get; set; } 

        [JsonProperty("intacctitemgroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Intacctitemgroup { get; set; } 

        [JsonProperty("intacctdefaulttaxsol", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intacctdefaulttaxsol { get; set; } 

        [JsonProperty("showslaonkanban", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showslaonkanban { get; set; } 

        [JsonProperty("site24x7_alert_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Site24X7AlertType { get; set; } 

        [JsonProperty("site24x7_alert_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Site24X7AlertUser { get; set; } 

        [JsonProperty("reset_security_stamps", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ResetSecurityStamps { get; set; } 

        [JsonProperty("invoice_pay_prepay_before_use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? InvoicePayPrepayBeforeUse { get; set; } 

        [JsonProperty("new_user_template", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewUserTemplate { get; set; } 

        [JsonProperty("new_user_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewUserType { get; set; } 

        [JsonProperty("child_template_recursion_depth", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ChildTemplateRecursionDepth { get; set; } 

        [JsonProperty("kaseya_sync_agents_only", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? KaseyaSyncAgentsOnly { get; set; } 

        [JsonProperty("kaseya_defaultassettype_server", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? KaseyaDefaultassettypeServer { get; set; } 

        [JsonProperty("kaseya_defaultassettype_server_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? KaseyaDefaultassettypeServerGuid { get; set; } 

        [JsonProperty("kaseya_defaultassettype_workstation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? KaseyaDefaultassettypeWorkstation { get; set; } 

        [JsonProperty("kaseya_defaultassettype_workstation_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? KaseyaDefaultassettypeWorkstationGuid { get; set; } 

        [JsonProperty("recaptcha_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? RecaptchaType { get; set; } 

        [JsonProperty("recaptcha_threshold", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? RecaptchaThreshold { get; set; } 

        [JsonProperty("show_all_lic_for_quantity_calc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowAllLicForQuantityCalc { get; set; } 

        [JsonProperty("jamf_instance_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? JamfInstanceType { get; set; } 

        [JsonProperty("jamf_site_match_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? JamfSiteMatchType { get; set; } 

        [JsonProperty("software_import_licence_matching", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SoftwareImportLicenceMatching { get; set; } 

        [JsonProperty("show_services_cost_tile", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowServicesCostTile { get; set; } 

        [JsonProperty("show_services_cost_tile_endusers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowServicesCostTileEndusers { get; set; } 

        [JsonProperty("exclude_nonticket_app_todo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ExcludeNonticketAppTodo { get; set; } 

        [JsonProperty("po_hide_item_popup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? PoHideItemPopup { get; set; } 

        [JsonProperty("mergesalesorderinvoicessite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Mergesalesorderinvoicessite { get; set; } 

        [JsonProperty("prepay_itemid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PrepayItemid { get; set; } 

        [JsonProperty("showintelrouting", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showintelrouting { get; set; } 

        [JsonProperty("showintelroutingonactions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showintelroutingonactions { get; set; } 

        [JsonProperty("intelroutingcutoffdays", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Intelroutingcutoffdays { get; set; } 

        [JsonProperty("intelroutingmaxtickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Intelroutingmaxtickets { get; set; } 

        [JsonProperty("close_all_children", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? CloseAllChildren { get; set; } 

        [JsonProperty("showtraveltimesheet", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowTraveltimesheet { get; set; } 

        [JsonProperty("showfeedbackcaptcha", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showfeedbackcaptcha { get; set; } 

        [JsonProperty("recaptcha_isenterprise", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? RecaptchaIsenterprise { get; set; } 

        [JsonProperty("call_charge_rate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CallChargeRate { get; set; } 

        [JsonProperty("use_stripe_receipt_emails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseStripeReceiptEmails { get; set; } 

        [JsonProperty("invoicecreationengine", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Invoicecreationengine { get; set; } 

        [JsonProperty("showponumonapproval", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showponumonapproval { get; set; } 

        [JsonProperty("multientitysearchincludecontracts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Multientitysearchincludecontracts { get; set; } 

        [JsonProperty("hide_add_to_project_and_create_child", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HideAddToProjectAndCreateChild { get; set; } 

        [JsonProperty("show_pipeline_stages", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowPipelineStages { get; set; } 

        [JsonProperty("default_pipeline_stage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultPipelineStage { get; set; } 

        [JsonProperty("timefieldstoshowontimesheet", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Timefieldstoshowontimesheet { get; set; } 

        [JsonProperty("showjsonexportbutton", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showjsonexportbutton { get; set; } 

        [JsonProperty("issueditemsdesclong", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Issueditemsdesclong { get; set; } 

        [JsonProperty("overridefeedbacklink", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Overridefeedbacklink { get; set; } 

        [JsonProperty("allow_user_drafts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowUserDrafts { get; set; } 

        [JsonProperty("createuserifgeneraluser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Createuserifgeneraluser { get; set; } 

        [JsonProperty("icinga_defaultsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? IcingaDefaultsite { get; set; } 

        [JsonProperty("icinga_defaultgroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? IcingaDefaultgroup { get; set; } 

        [JsonProperty("icinga_defaultgroup_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? IcingaDefaultgroupGuid { get; set; } 

        [JsonProperty("icingaassettypefield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Icingaassettypefield { get; set; } 

        [JsonProperty("icingadefaultassettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Icingadefaultassettype { get; set; } 

        [JsonProperty("icinga_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? IcingaImportType { get; set; } 

        [JsonProperty("icinga_delete_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IcingaDeleteDevices { get; set; } 

        [JsonProperty("icinga_selfsigned_cert", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IcingaSelfsignedCert { get; set; } 

        [JsonProperty("icinga_alert_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? IcingaAlertType { get; set; } 

        [JsonProperty("icinga_alert_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? IcingaAlertUser { get; set; } 

        [JsonProperty("icinga_enable_alerting", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IcingaEnableAlerting { get; set; } 

        [JsonProperty("enable_document_previewer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableDocumentPreviewer { get; set; } 

        [JsonProperty("addigy_dont_import_software", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AddigyDontImportSoftware { get; set; } 

        [JsonProperty("default_view_customers_selectedid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultViewCustomersSelectedid { get; set; } 

        [JsonProperty("default_view_users_selectedid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultViewUsersSelectedid { get; set; } 

        [JsonProperty("defaultnavscreenlayout", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Defaultnavscreenlayout { get; set; } 

        [JsonProperty("navbar_new_call", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? NavbarNewCall { get; set; } 

        [JsonProperty("actiondatedisplay", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Actiondatedisplay { get; set; } 

        [JsonProperty("showcalllogonticket", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowCalllogonticket { get; set; } 

        [JsonProperty("use_charge_for_budgets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseChargeForBudgets { get; set; } 

        [JsonProperty("quote_hide_item_popup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? QuoteHideItemPopup { get; set; } 

        [JsonProperty("so_hide_item_popup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SoHideItemPopup { get; set; } 

        [JsonProperty("default_columns_id_contracts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultColumnsIdContracts { get; set; } 

        [JsonProperty("default_columns_id_contracts_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? DefaultColumnsIdContractsGuid { get; set; } 

        [JsonProperty("beyond_trust_instance_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? BeyondTrustInstanceType { get; set; } 

        [JsonProperty("asset_permission_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AssetPermissionType { get; set; } 

        [JsonProperty("show_users_contracts_on_ticket_only", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowUsersContractsOnTicketOnly { get; set; } 

        [JsonProperty("default_columns_id_sites", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultColumnsIdSites { get; set; } 

        [JsonProperty("default_columns_id_users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultColumnsIdUsers { get; set; } 

        [JsonProperty("jamf_dont_update_asset_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? JamfDontUpdateAssetType { get; set; } 

        [JsonProperty("billingcontactinfoonportal", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Billingcontactinfoonportal { get; set; } 

        [JsonProperty("rhipe_subscription_client", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? RhipeSubscriptionClient { get; set; } 

        [JsonProperty("followup_appointment_subject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? FollowupAppointmentSubject { get; set; } 

        [JsonProperty("show_device_on_invoice_line", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowDeviceOnInvoiceLine { get; set; } 

        [JsonProperty("asset_return_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AssetReturnStatus { get; set; } 

        [JsonProperty("spellchecksuggestionscore", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Spellchecksuggestionscore { get; set; } 

        [JsonProperty("load_rinvoices_lines", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? LoadRinvoicesLines { get; set; } 

        [JsonProperty("user_ticket_profile", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? UserTicketProfile { get; set; } 

        [JsonProperty("user_project_profile", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? UserProjectProfile { get; set; } 

        [JsonProperty("admin_override_quick_status_change", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AdminOverrideQuickStatusChange { get; set; } 

        [JsonProperty("create_so_on_quote_approved", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? CreateSoOnQuoteApproved { get; set; } 

        [JsonProperty("additional_agents_on_tickets_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AdditionalAgentsOnTicketsType { get; set; } 

        [JsonProperty("show_toplevel_access_portal_option", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowToplevelAccessPortalOption { get; set; } 

        [JsonProperty("show_alllevel_access_portal_option", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowAlllevelAccessPortalOption { get; set; } 

        [JsonProperty("donttrackleavesite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Donttrackleavesite { get; set; } 

        [JsonProperty("meter_min_quantity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? MeterMinQuantity { get; set; } 

        [JsonProperty("show_kb_menu", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowKbMenu { get; set; } 

        [JsonProperty("icinga_comment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? IcingaComment { get; set; } 

        [JsonProperty("sync_icinga_comment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SyncIcingaComment { get; set; } 

        [JsonProperty("icinga_asset_type_choice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? IcingaAssetTypeChoice { get; set; } 

        [JsonProperty("open_new_quote_in_new_tab", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? OpenNewQuoteInNewTab { get; set; } 

        [JsonProperty("defaultaideployment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(50)]
        public string? Defaultaideployment { get; set; } 

        [JsonProperty("connectwise_rmm_default_client", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ConnectwiseRmmDefaultClient { get; set; } 

        [JsonProperty("connectwise_rmm_default_asset_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ConnectwiseRmmDefaultAssetType { get; set; } 

        [JsonProperty("connectwise_rmm_delete_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ConnectwiseRmmDeleteDevices { get; set; } 

        [JsonProperty("connectwise_rmm_import_entities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ConnectwiseRmmImportEntities { get; set; } 

        [JsonProperty("connectwise_rmm_top_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ConnectwiseRmmTopLevel { get; set; } 

        [JsonProperty("showeventstabforadmins", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showeventstabforadmins { get; set; } 

        [JsonProperty("def_inv_manual_pr_immediately", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefInvManualPrImmediately { get; set; } 

        [JsonProperty("salesorderstatusafterinvoicedeleted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Salesorderstatusafterinvoicedeleted { get; set; } 

        [JsonProperty("show_related_of_related", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowRelatedOfRelated { get; set; } 

        [JsonProperty("invertactionhistory", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Invertactionhistory { get; set; } 

        [JsonProperty("enablekbdraftsnews", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enablekbdraftsnews { get; set; } 

        [JsonProperty("kbdrafttickettypenews", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Kbdrafttickettypenews { get; set; } 

        [JsonProperty("kbdrafttickettype_guidnews", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? KbdrafttickettypeGuidnews { get; set; } 

        [JsonProperty("halonewssandbox", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Halonewssandbox { get; set; } 

        [JsonProperty("shopifycustomerimporttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Shopifycustomerimporttype { get; set; } 

        [JsonProperty("shopifydefaultsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Shopifydefaultsite { get; set; } 

        [JsonProperty("shopify_integratorcustomerslastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? ShopifyIntegratorcustomerslastsync { get; set; } 

        [JsonProperty("shopify_integratororderslastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? ShopifyIntegratororderslastsync { get; set; } 

        [JsonProperty("shopify_integratorentitiestoimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ShopifyIntegratorentitiestoimport { get; set; } 

        [JsonProperty("ecommerceshowordersarea", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ecommerceshowordersarea { get; set; } 

        [JsonProperty("device42preventdeviceimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Device42Preventdeviceimport { get; set; } 

        [JsonProperty("admins_access_all_reports", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AdminsAccessAllReports { get; set; } 

        [JsonProperty("adminsecurityprompt", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Adminsecurityprompt { get; set; } 

        [JsonProperty("stripemanualpaymentmethodoptions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Stripemanualpaymentmethodoptions { get; set; } 

        [JsonProperty("log_action_responses_on_action_submit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LogActionResponsesOnActionSubmit { get; set; } 

        [JsonProperty("use_embedding_scores_openai", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseEmbeddingScoresOpenai { get; set; } 

        [JsonProperty("use_embedding_scores_azureopenai", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseEmbeddingScoresAzureopenai { get; set; } 

        [JsonProperty("xensam_defaultsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? XensamDefaultsite { get; set; } 

        [JsonProperty("xensam_defaultassettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? XensamDefaultassettype { get; set; } 

        [JsonProperty("xensam_assettype_choice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? XensamAssetTypeChoice { get; set; } 

        [JsonProperty("xensam_assettype_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? XensamAssetTypeField { get; set; } 

        [JsonProperty("xensam_assettype_field_datacentre", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? XensamAssetTypeFieldDatacentre { get; set; } 

        [JsonProperty("xensam_defaultgroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? XensamDefaultgroup { get; set; } 

        [JsonProperty("xensamdefaultgroup_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? XensamdefaultgroupGuid { get; set; } 

        [JsonProperty("xensam_integratorentitiestoimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? XensamIntegratorentitiestoimport { get; set; } 

        [JsonProperty("xensam_delete_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? XensamDeleteDevices { get; set; } 

        [JsonProperty("xensam_dont_update_assettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? XensamDontUpdateAssetType { get; set; } 

        [JsonProperty("useincomingservice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Useincomingservice { get; set; } 

        [JsonProperty("atera_alert_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AteraAlertMethod { get; set; } 

        [JsonProperty("addigy_alert_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AddigyAlertMethod { get; set; } 

        [JsonProperty("automate_alert_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AutomateAlertMethod { get; set; } 

        [JsonProperty("dattormm_alert_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DattormmAlertMethod { get; set; } 

        [JsonProperty("default_view_suppliers_selectedid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultViewSuppliersSelectedid { get; set; } 

        [JsonProperty("trackresponsetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Trackresponsetime { get; set; } 

        [JsonProperty("trackfixbytime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Trackfixbytime { get; set; } 

        [JsonProperty("reviewprocessenabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Reviewprocessenabled { get; set; } 

        [JsonProperty("usedynamicemaillist", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Usedynamicemaillist { get; set; } 

        [JsonProperty("emailmustmatchrule", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Emailmustmatchrule { get; set; } 

        [JsonProperty("donteditemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Donteditemail { get; set; } 

        [JsonProperty("sendacknowledgementemailstoccaddresses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sendacknowledgementemailstoccaddresses { get; set; } 

        [JsonProperty("autoforwardemailupdates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Autoforwardemailupdates { get; set; } 

        [JsonProperty("disablereplytome", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Disablereplytome { get; set; } 

        [JsonProperty("useintellisense", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Useintellisense { get; set; } 

        [JsonProperty("smtpserver", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Smtpserver { get; set; } 

        [JsonProperty("smtpaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Smtpaddress { get; set; } 

        [JsonProperty("smtpusername", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Smtpusername { get; set; } 

        [JsonProperty("new_smtppassword", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewSmtppassword { get; set; } 

        [JsonProperty("smtpusetls", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Smtpusetls { get; set; } 

        [JsonProperty("smtpport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Smtpport { get; set; } 

        [JsonProperty("generalusername", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Generalusername { get; set; } 

        [JsonProperty("enableuserclosureconf", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enableuserclosureconf { get; set; } 

        [JsonProperty("auto_close_hrs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AutoCloseHrs { get; set; } 

        [JsonProperty("pending_close_reminder_hrs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PendingCloseReminderHrs { get; set; } 

        [JsonProperty("shownotrespondedwarning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Shownotrespondedwarning { get; set; } 

        [JsonProperty("statusafterrespond", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Statusafterrespond { get; set; } 

        [JsonProperty("statusafterrespond_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? StatusafterrespondGuid { get; set; } 

        [JsonProperty("tracknonbill", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Tracknonbill { get; set; } 

        [JsonProperty("tracktravel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Tracktravel { get; set; } 

        [JsonProperty("trackmileage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Trackmileage { get; set; } 

        [JsonProperty("default_tickettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultTicketTypeId { get; set; } 

        [JsonProperty("default_tickettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? DefaultTicketTypeGuid { get; set; } 

        [JsonProperty("allow_tickettype_selection_agents", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowTicketTypeSelectionAgents { get; set; } 

        [JsonProperty("hide_generaluser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HideGeneraluser { get; set; } 

        [JsonProperty("addactionstolinked", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Addactionstolinked { get; set; } 

        [JsonProperty("enableslareminders", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enableslareminders { get; set; } 

        [JsonProperty("slareminderintervalhrs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Slareminderintervalhrs { get; set; } 

        [JsonProperty("slareminderautoclosehrs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Slareminderautoclosehrs { get; set; } 

        [JsonProperty("hourswarningnotapproved", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Hourswarningnotapproved { get; set; } 

        [JsonProperty("enablequalificationmatching", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enablequalificationmatching { get; set; } 

        [JsonProperty("onlyprocessclosedrequests", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Onlyprocessclosedrequests { get; set; } 

        [JsonProperty("defaultischargeable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Defaultischargeable { get; set; } 

        [JsonProperty("processunclosedactions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Processunclosedactions { get; set; } 

        [JsonProperty("useactioneventtimes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Useactioneventtimes { get; set; } 

        [JsonProperty("acctinterfacefolder", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Acctinterfacefolder { get; set; } 

        [JsonProperty("xmlinterfacefolder", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Xmlinterfacefolder { get; set; } 

        [JsonProperty("allow_response_edit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowResponseEdit { get; set; } 

        [JsonProperty("cat2mandclear", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Cat2Mandclear { get; set; } 

        [JsonProperty("cat3mandclear", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Cat3Mandclear { get; set; } 

        [JsonProperty("cat4mandclear", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Cat4Mandclear { get; set; } 

        [JsonProperty("cat5mandclear", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Cat5Mandclear { get; set; } 

        [JsonProperty("showactioncalendaroption", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowActioncalendaroption { get; set; } 

        [JsonProperty("matchchargecodes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Matchchargecodes { get; set; } 

        [JsonProperty("forcestrongpasswords", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Forcestrongpasswords { get; set; } 

        [JsonProperty("auditdelete", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Auditdelete { get; set; } 

        [JsonProperty("outofhourspriority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Outofhourspriority { get; set; } 

        [JsonProperty("informownertech", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Informownertech { get; set; } 

        [JsonProperty("sageslaitemcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sageslaitemcode { get; set; } 

        [JsonProperty("sageslaitemcodedesc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sageslaitemcodedesc { get; set; } 

        [JsonProperty("sagedetaildesc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sagedetaildesc { get; set; } 

        [JsonProperty("billingreportvariable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Billingreportvariable { get; set; } 

        [JsonProperty("allowinvoicenumberedit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allowinvoicenumberedit { get; set; } 

        [JsonProperty("actionlineitems", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Actionlineitems { get; set; } 

        [JsonProperty("projectlineitems", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Projectlineitems { get; set; } 

        [JsonProperty("invoiceaddgroupheaders", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Invoiceaddgroupheaders { get; set; } 

        [JsonProperty("includezerocharge", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Includezerocharge { get; set; } 

        [JsonProperty("linknonchargabletoinvoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Linknonchargabletoinvoice { get; set; } 

        [JsonProperty("weeksaheadtocreateperiodicinvoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Weeksaheadtocreateperiodicinvoice { get; set; } 

        [JsonProperty("contractexpirydays", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Contractexpirydays { get; set; } 

        [JsonProperty("apptservername", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Apptservername { get; set; } 

        [JsonProperty("apptsetting", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Apptsetting { get; set; } 

        [JsonProperty("syncallappts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Syncallappts { get; set; } 

        [JsonProperty("calendarchoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Calendarchoice { get; set; } 

        [JsonProperty("miscitemidquote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Miscitemidquote { get; set; } 

        [JsonProperty("rtdefwebendusers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Rtdefwebendusers { get; set; } 

        [JsonProperty("newrequestmessage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Newrequestmessage { get; set; } 

        [JsonProperty("endusersclose", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Endusersclose { get; set; } 

        [JsonProperty("hideslastatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hideslastatus { get; set; } 

        [JsonProperty("miscitemidsupppo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Miscitemidsupppo { get; set; } 

        [JsonProperty("gfiservertype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Gfiservertype { get; set; } 

        [JsonProperty("gfiservertype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? GfiservertypeGuid { get; set; } 

        [JsonProperty("gfiwstype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Gfiwstype { get; set; } 

        [JsonProperty("gfiwstype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? GfiwstypeGuid { get; set; } 

        [JsonProperty("showsendsmstouser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showsendsmstouser { get; set; } 

        [JsonProperty("checkprepaybalances", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Checkprepaybalances { get; set; } 

        [JsonProperty("prepaybalancethreshold", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Prepaybalancethreshold { get; set; } 

        [JsonProperty("shownewrequestbillinginfo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Shownewrequestbillinginfo { get; set; } 

        [JsonProperty("sendreminderstoccaddresses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sendreminderstoccaddresses { get; set; } 

        [JsonProperty("firstroadmapcolumn", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Firstroadmapcolumn { get; set; } 

        [JsonProperty("secondroadmapcolumn", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Secondroadmapcolumn { get; set; } 

        [JsonProperty("thidroadmapcolumn", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Thidroadmapcolumn { get; set; } 

        [JsonProperty("migration_top_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MigrationTopLevel { get; set; } 

        [JsonProperty("migration_default_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MigrationDefaultSite { get; set; } 

        [JsonProperty("migration_faq_creation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MigrationFaqCreation { get; set; } 

        [JsonProperty("migration_default_faq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MigrationDefaultFaq { get; set; } 

        [JsonProperty("migration_incident", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MigrationIncident { get; set; } 

        [JsonProperty("migration_problem", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MigrationProblem { get; set; } 

        [JsonProperty("migration_change_request", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MigrationChangeRequest { get; set; } 

        [JsonProperty("migration_service_request", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MigrationServiceRequest { get; set; } 

        [JsonProperty("orion_webhook_authentication", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? OrionWebhookAuthentication { get; set; } 

        [JsonProperty("orion_tickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? OrionTicketType { get; set; } 

        [JsonProperty("orion_tickettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? OrionTicketTypeGuid { get; set; } 

        [JsonProperty("orion_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? OrionUser { get; set; } 

        [JsonProperty("orion_devicefield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? OrionDevicefield { get; set; } 

        [JsonProperty("prtgassetdefaultsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Prtgassetdefaultsite { get; set; } 

        [JsonProperty("prtgdefaultassettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Prtgdefaultassettype { get; set; } 

        [JsonProperty("prtgdefaultassettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? PrtgdefaultassettypeGuid { get; set; } 

        [JsonProperty("orion_enable_updates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? OrionEnableUpdates { get; set; } 

        [JsonProperty("showkbentrytags", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showkbentrytags { get; set; } 

        [JsonProperty("isphonemandatory", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isphonemandatory { get; set; } 

        [JsonProperty("enableteamscall", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enableteamscall { get; set; } 

        [JsonProperty("soc_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SocUsername { get; set; } 

        [JsonProperty("soc_show_success_message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SocShowSuccessMessage { get; set; } 

        [JsonProperty("soc_tickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SocTicketType { get; set; } 

        [JsonProperty("soc_tickettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? SocTicketTypeGuid { get; set; } 

        [JsonProperty("soc_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SocUser { get; set; } 

        [JsonProperty("dattodefaultassettypegroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Dattodefaultassettypegroup { get; set; } 

        [JsonProperty("dattodefaultassettypegroup_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? DattodefaultassettypegroupGuid { get; set; } 

        [JsonProperty("dattositeimporttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Dattositeimporttype { get; set; } 

        [JsonProperty("dattodefaulttoplevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Dattodefaulttoplevel { get; set; } 

        [JsonProperty("dattodefaultcustomer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Dattodefaultcustomer { get; set; } 

        [JsonProperty("dattodefaultassetsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Dattodefaultassetsite { get; set; } 

        [JsonProperty("dattomatchname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dattomatchname { get; set; } 

        [JsonProperty("dattoimporttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Dattoimporttype { get; set; } 

        [JsonProperty("datto_delete_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DattoDeleteDevices { get; set; } 

        [JsonProperty("qboenableast", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Qboenableast { get; set; } 

        [JsonProperty("item_default_sales_nominal_code_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ItemDefaultSalesNominalCodeName { get; set; } 

        [JsonProperty("item_default_purchase_nominal_code_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ItemDefaultPurchaseNominalCodeName { get; set; } 

        [JsonProperty("item_default_asset_account_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ItemDefaultAssetAccountName { get; set; } 

        [JsonProperty("qborequestid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Qborequestid { get; set; } 

        [JsonProperty("percentageoverdue2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Percentageoverdue2 { get; set; } 

        [JsonProperty("default_phone_pref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultPhonePref { get; set; } 

        [JsonProperty("migration_ticket_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? MigrationTicketDate { get; set; } 

        [JsonProperty("migration_ticket_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MigrationTicketStatus { get; set; } 

        [JsonProperty("migration_custom_filter", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? MigrationCustomFilter { get; set; } 

        [JsonProperty("device42_toplevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Device42Toplevel { get; set; } 

        [JsonProperty("device42defaultsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Device42defaultsite { get; set; } 

        [JsonProperty("device42defaulttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Device42defaulttype { get; set; } 

        [JsonProperty("device42defaulttype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Device42defaulttypeGuid { get; set; } 

        [JsonProperty("servicenow_locale", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ServicenowLocale { get; set; } 

        [JsonProperty("connectwise_instance_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ConnectwiseInstanceType { get; set; } 

        [JsonProperty("connectwise_company_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ConnectwiseCompanyId { get; set; } 

        [JsonProperty("automaticprepaypaymentattheendoflastmonth", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Automaticprepaypaymentattheendoflastmonth { get; set; } 

        [JsonProperty("add_order_note_to_long_description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AddOrderNoteToLongDescription { get; set; } 

        [JsonProperty("display_user_on_asset_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DisplayUserOnAssetList { get; set; } 

        [JsonProperty("actiondatedoneisstartdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Actiondatedoneisstartdate { get; set; } 

        [JsonProperty("rusesagepo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Rusesagepo { get; set; } 

        [JsonProperty("callscreencreatenewcalltab", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Callscreencreatenewcalltab { get; set; } 

        [JsonProperty("makeemailsfromdifferentdomainprivate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Makeemailsfromdifferentdomainprivate { get; set; } 

        [JsonProperty("automaticallysendinvoiceemails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Automaticallysendinvoiceemails { get; set; } 

        [JsonProperty("sendapptemails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sendapptemails { get; set; } 

        [JsonProperty("display_extra_options_on_quick_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DisplayExtraOptionsOnQuickTime { get; set; } 

        [JsonProperty("autotask_identifier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AutotaskIdentifier { get; set; } 

        [JsonProperty("migration_product_group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MigrationProductGroup { get; set; } 

        [JsonProperty("migration_service_group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MigrationServiceGroup { get; set; } 

        [JsonProperty("migration_contract_enddate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? MigrationContractEndDate { get; set; } 

        [JsonProperty("migration_tax_rate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MigrationTaxRate { get; set; } 

        [JsonProperty("migration_role", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MigrationRole { get; set; } 

        [JsonProperty("logclosedpagerduty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Logclosedpagerduty { get; set; } 

        [JsonProperty("defaultischangeapprover", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Defaultischangeapprover { get; set; } 

        [JsonProperty("noapprovalwithnocabmembers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Noapprovalwithnocabmembers { get; set; } 

        [JsonProperty("exchange_connected_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ExchangeConnectedUser { get; set; } 

        [JsonProperty("exchange_start_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? ExchangeStartDate { get; set; } 

        [JsonProperty("exchange_import_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ExchangeImportType { get; set; } 

        [JsonProperty("showkbportalurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showkbportalurl { get; set; } 

        [JsonProperty("default_appt_to_original_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DefaultApptToOriginalTime { get; set; } 

        [JsonProperty("nablerequireuserdetails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Nablerequireuserdetails { get; set; } 

        [JsonProperty("sendquotepdf", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sendquotepdf { get; set; } 

        [JsonProperty("ninjarmmassettypefield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ninjarmmassettypefield { get; set; } 

        [JsonProperty("oktausermatchingfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Oktausermatchingfields { get; set; } 

        [JsonProperty("oktaagentmatchingfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Oktaagentmatchingfields { get; set; } 

        [JsonProperty("oktaactivestatuses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Oktaactivestatuses { get; set; } 

        [JsonProperty("oktaimporttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Oktaimporttype { get; set; } 

        [JsonProperty("populatephoneworknumberforuserwhennotmatched", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Populatephoneworknumberforuserwhennotmatched { get; set; } 

        [JsonProperty("atera_toplevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AteraToplevel { get; set; } 

        [JsonProperty("atera_devicetypes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AteraDevicetypes { get; set; } 

        [JsonProperty("atera_defaultsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AteraDefaultsite { get; set; } 

        [JsonProperty("atera_defaultgroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AteraDefaultgroup { get; set; } 

        [JsonProperty("atera_defaultgroup_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? AteraDefaultgroupGuid { get; set; } 

        [JsonProperty("atera_delete_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AteraDeleteDevices { get; set; } 

        [JsonProperty("atera_enable_alerting", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AteraEnableAlerting { get; set; } 

        [JsonProperty("atera_guid1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AteraGuid1 { get; set; } 

        [JsonProperty("atera_guid2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AteraGuid2 { get; set; } 

        [JsonProperty("atera_alert_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AteraAlertType { get; set; } 

        [JsonProperty("atera_alert_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AteraAlertUser { get; set; } 

        [JsonProperty("kashflowdefaultconnectionid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Kashflowdefaultconnectionid { get; set; } 

        [JsonProperty("default_prepay_lines", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultPrepayLines { get; set; } 

        [JsonProperty("ticketstatusafterinternalconversation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ticketstatusafterinternalconversation { get; set; } 

        [JsonProperty("ticketstatusafterinternalconversation_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? TicketstatusafterinternalconversationGuid { get; set; } 

        [JsonProperty("enableitemurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enableitemurl { get; set; } 

        [JsonProperty("userviewedquotenotification", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Userviewedquotenotification { get; set; } 

        [JsonProperty("senduseremailafterquoteaccepted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Senduseremailafterquoteaccepted { get; set; } 

        [JsonProperty("defaultcustomersalestax", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Defaultcustomersalestax { get; set; } 

        [JsonProperty("defaultcustomerpurchasestax", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Defaultcustomerpurchasestax { get; set; } 

        [JsonProperty("merakitickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Merakitickettype { get; set; } 

        [JsonProperty("merakitickettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? MerakitickettypeGuid { get; set; } 

        [JsonProperty("merakiuser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Merakiuser { get; set; } 

        [JsonProperty("merakidevicematchingfield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Merakidevicematchingfield { get; set; } 

        [JsonProperty("lansweeper_instance_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LansweeperInstanceType { get; set; } 

        [JsonProperty("lansweeper_default_group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LansweeperDefaultGroup { get; set; } 

        [JsonProperty("lansweeper_default_group_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? LansweeperDefaultGroupGuid { get; set; } 

        [JsonProperty("lansweeper_use_users_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? LansweeperUseUsersSite { get; set; } 

        [JsonProperty("lansweeper_dont_update_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? LansweeperDontUpdateSite { get; set; } 

        [JsonProperty("lansweeper_dont_remove_users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? LansweeperDontRemoveUsers { get; set; } 

        [JsonProperty("allowappointmentfaultidchange", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allowappointmentfaultidchange { get; set; } 

        [JsonProperty("autocreateprojectsonso", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Autocreateprojectsonso { get; set; } 

        [JsonProperty("enablepoapprovals", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enablepoapprovals { get; set; } 

        [JsonProperty("delivertouser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Delivertouser { get; set; } 

        [JsonProperty("defaultappointmentbody", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Defaultappointmentbody { get; set; } 

        [JsonProperty("interactUseWhere", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? InteractUseWhere { get; set; } 

        [JsonProperty("interactUrlStandard", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? InteractUrlStandard { get; set; } 

        [JsonProperty("xero_default_invoice_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? XeroDefaultInvoiceStatus { get; set; } 

        [JsonProperty("useaccountscodeslookup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Useaccountscodeslookup { get; set; } 

        [JsonProperty("xero_default_order_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? XeroDefaultOrderStatus { get; set; } 

        [JsonProperty("allowordernumberedit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allowordernumberedit { get; set; } 

        [JsonProperty("xero_allow_linked_items", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? XeroAllowLinkedItems { get; set; } 

        [JsonProperty("typeofdisplayanduseforassetswhenloggingonbehalfallowed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Typeofdisplayanduseforassetswhenloggingonbehalfallowed { get; set; } 

        [JsonProperty("samlidp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Samlidp { get; set; } 

        [JsonProperty("samlidp_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SamlidpName { get; set; } 

        [JsonProperty("dynamicscrm_accountfilter", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DynamicscrmAccountfilter { get; set; } 

        [JsonProperty("dynamicscrm_userfilter", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DynamicscrmUserfilter { get; set; } 

        [JsonProperty("dattoassettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Dattoassettype { get; set; } 

        [JsonProperty("alarmminutes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Alarmminutes { get; set; } 

        [JsonProperty("link_new_assets_to_contract", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? LinkNewAssetsToContract { get; set; } 

        [JsonProperty("onlyallowassetstatuschangefromnewactionscreen", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Onlyallowassetstatuschangefromnewactionscreen { get; set; } 

        [JsonProperty("invoiceduedaysextra", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Invoiceduedaysextra { get; set; } 

        [JsonProperty("use_gross_margin", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseGrossMargin { get; set; } 

        [JsonProperty("ninja_alert_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NinjaAlertType { get; set; } 

        [JsonProperty("ninja_alert_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NinjaAlertUser { get; set; } 

        [JsonProperty("ninja_delete_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? NinjaDeleteDevices { get; set; } 

        [JsonProperty("orion_force_default_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? OrionForceDefaultUser { get; set; } 

        [JsonProperty("createnewitemsfromquotes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Createnewitemsfromquotes { get; set; } 

        [JsonProperty("kbcreateifnoresults", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Kbcreateifnoresults { get; set; } 

        [JsonProperty("kbcreateticketortemplate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Kbcreateticketortemplate { get; set; } 

        [JsonProperty("kbtemplateid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Kbtemplateid { get; set; } 

        [JsonProperty("kbticketid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Kbticketid { get; set; } 

        [JsonProperty("displayextraquicktimefields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Displayextraquicktimefields { get; set; } 

        [JsonProperty("disablebusinesscentralautosync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Disablebusinesscentralautosync { get; set; } 

        [JsonProperty("showattachmentsonapprovals", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowAttachmentsonapprovals { get; set; } 

        [JsonProperty("previewpdfinbrowser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Previewpdfinbrowser { get; set; } 

        [JsonProperty("ticketstartdatebeforeenddate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ticketstartdatebeforeenddate { get; set; } 

        [JsonProperty("migration_project", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MigrationProject { get; set; } 

        [JsonProperty("migration_project_children", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MigrationProjectChildren { get; set; } 

        [JsonProperty("itglue_top_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ItglueTopLevel { get; set; } 

        [JsonProperty("itglue_customer_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ItglueCustomerType { get; set; } 

        [JsonProperty("itglue_import_active_statuses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ItglueImportActiveStatuses { get; set; } 

        [JsonProperty("itglue_default_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ItglueDefaultSite { get; set; } 

        [JsonProperty("itglue_import_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ItglueImportType { get; set; } 

        [JsonProperty("itglue_enable_sync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ItglueEnableSync { get; set; } 

        [JsonProperty("itglue_active_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ItglueActiveStatus { get; set; } 

        [JsonProperty("itglue_inactive_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ItglueInactiveStatus { get; set; } 

        [JsonProperty("itglue_instance_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ItglueInstanceUrl { get; set; } 

        [JsonProperty("move_quote_to_closed_on_so_creation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? MoveQuoteToClosedOnSoCreation { get; set; } 

        [JsonProperty("move_quotes_default_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MoveQuotesDefaultStatus { get; set; } 

        [JsonProperty("move_quotes_default_status_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? MoveQuotesDefaultStatusGuid { get; set; } 

        [JsonProperty("show_child_sos_on_parent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowChildSosOnParent { get; set; } 

        [JsonProperty("enduserchange_confirmation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnduserchangeConfirmation { get; set; } 

        [JsonProperty("connectwise_markbilled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ConnectwiseMarkbilled { get; set; } 

        [JsonProperty("billing_from_mailbox_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? BillingFromMailboxId { get; set; } 

        [JsonProperty("quotes_from_mailbox_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? QuotesFromMailboxId { get; set; } 

        [JsonProperty("so_from_mailbox_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SoFromMailboxId { get; set; } 

        [JsonProperty("po_from_mailbox_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PoFromMailboxId { get; set; } 

        [JsonProperty("snelstart_client_top_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SnelstartClientTopLevel { get; set; } 

        [JsonProperty("snelstart_item_group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SnelstartItemGroup { get; set; } 

        [JsonProperty("snelstart_item_group_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? SnelstartItemGroupGuid { get; set; } 

        [JsonProperty("snelstart_enable_sync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SnelstartEnableSync { get; set; } 

        [JsonProperty("snelstart_default_item", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SnelstartDefaultItem { get; set; } 

        [JsonProperty("jamf_devicetypes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? JamfDevicetypes { get; set; } 

        [JsonProperty("allowed_files", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AllowedFiles { get; set; } 

        [JsonProperty("jamf_defaultsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? JamfDefaultsite { get; set; } 

        [JsonProperty("allow_readall_passwords", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowReadallPasswords { get; set; } 

        [JsonProperty("jamf_defaultdtypemobile", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? JamfDefaultdtypemobile { get; set; } 

        [JsonProperty("jamf_defaultdtypemobile_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? JamfDefaultdtypemobileGuid { get; set; } 

        [JsonProperty("scom_allowed_clientids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ScomAllowedClientids { get; set; } 

        [JsonProperty("jamf_defaultdtypecomputer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? JamfDefaultdtypecomputer { get; set; } 

        [JsonProperty("jamf_defaultdtypecomputer_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? JamfDefaultdtypecomputerGuid { get; set; } 

        [JsonProperty("orion_allowed_clientids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OrionAllowedClientids { get; set; } 

        [JsonProperty("google_calendar_authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? GoogleCalendarAuthorized { get; set; } 

        [JsonProperty("default_billing_period", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultBillingPeriod { get; set; } 

        [JsonProperty("showvotecount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showvotecount { get; set; } 

        [JsonProperty("limit_news_by_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? LimitNewsByDate { get; set; } 

        [JsonProperty("cc_list_is_dropdown", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? CcListIsDropdown { get; set; } 

        [JsonProperty("splitrecurringcontracts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Splitrecurringcontracts { get; set; } 

        [JsonProperty("default_expand_rows", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DefaultExpandRows { get; set; } 

        [JsonProperty("samlmatchingfield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Samlmatchingfield { get; set; } 

        [JsonProperty("default_item_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultItemTaxCode { get; set; } 

        [JsonProperty("default_service_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultServiceTaxCode { get; set; } 

        [JsonProperty("default_prepay_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultPrepayTaxCode { get; set; } 

        [JsonProperty("default_contract_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultContractTaxCode { get; set; } 

        [JsonProperty("default_sentinel_ticket_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultSentinelTicketType { get; set; } 

        [JsonProperty("default_sentinel_ticket_type_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? DefaultSentinelTicketTypeGuid { get; set; } 

        [JsonProperty("default_sentinel_classification", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultSentinelClassification { get; set; } 

        [JsonProperty("default_sentinel_classification_reason", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultSentinelClassificationReason { get; set; } 

        [JsonProperty("default_sentinel_priority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultSentinelPriority { get; set; } 

        [JsonProperty("use_ticket_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseTicketSite { get; set; } 

        [JsonProperty("decimal_separator", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DecimalSeparator { get; set; } 

        [JsonProperty("thousands_separator", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ThousandsSeparator { get; set; } 

        [JsonProperty("parent_project_template_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ParentProjectTemplateId { get; set; } 

        [JsonProperty("solarwindsncentraldontsyncaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Solarwindsncentraldontsyncaddress { get; set; } 

        [JsonProperty("default_asset_view", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultAssetView { get; set; } 

        [JsonProperty("oppvalue_from_quote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? OppvalueFromQuote { get; set; } 

        [JsonProperty("teamsbot_ticket_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TeamsbotTicketType { get; set; } 

        [JsonProperty("teamsbot_ticket_type_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? TeamsbotTicketTypeGuid { get; set; } 

        [JsonProperty("teamsbot_default_subject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TeamsbotDefaultSubject { get; set; } 

        [JsonProperty("teamsbot_outcome_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TeamsbotOutcomeId { get; set; } 

        [JsonProperty("teamsbot_default_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TeamsbotDefaultUser { get; set; } 

        [JsonProperty("showsupplierupdatestoenduser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showsupplierupdatestoenduser { get; set; } 

        [JsonProperty("admin_only_report_sql", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AdminOnlyReportSql { get; set; } 

        [JsonProperty("exchange_connection_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ExchangeConnectionType { get; set; } 

        [JsonProperty("rexchangetenantid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Rexchangetenantid { get; set; } 

        [JsonProperty("rexchangeapplicationid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Rexchangeapplicationid { get; set; } 

        [JsonProperty("sentinel_tenant_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SentinelTenantId { get; set; } 

        [JsonProperty("sentinel_application_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SentinelApplicationId { get; set; } 

        [JsonProperty("serializationassetfield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Serializationassetfield { get; set; } 

        [JsonProperty("serializationassetfield_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? SerializationassetfieldGuid { get; set; } 

        [JsonProperty("azuremonitortickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Azuremonitortickettype { get; set; } 

        [JsonProperty("azuremonitortickettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? AzuremonitortickettypeGuid { get; set; } 

        [JsonProperty("azuremonitoruser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Azuremonitoruser { get; set; } 

        [JsonProperty("azuremonitorreopenstatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Azuremonitorreopenstatus { get; set; } 

        [JsonProperty("azuremonitorreopenstatus_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? AzuremonitorreopenstatusGuid { get; set; } 

        [JsonProperty("faqtreeview", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Faqtreeview { get; set; } 

        [JsonProperty("datto_connect_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DattoConnectType { get; set; } 

        [JsonProperty("syncro_toplevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SyncroToplevel { get; set; } 

        [JsonProperty("syncro_devicetypes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SyncroDevicetypes { get; set; } 

        [JsonProperty("syncro_defaultsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SyncroDefaultsite { get; set; } 

        [JsonProperty("syncro_defaultgroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SyncroDefaultgroup { get; set; } 

        [JsonProperty("syncro_defaultgroup_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? SyncroDefaultgroupGuid { get; set; } 

        [JsonProperty("syncro_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SyncroImportType { get; set; } 

        [JsonProperty("syncro_delete_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SyncroDeleteDevices { get; set; } 

        [JsonProperty("syncro_enable_alerting", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SyncroEnableAlerting { get; set; } 

        [JsonProperty("syncro_alert_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SyncroAlertType { get; set; } 

        [JsonProperty("syncro_alert_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SyncroAlertUser { get; set; } 

        [JsonProperty("exchangeapptsprivate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Exchangeapptsprivate { get; set; } 

        [JsonProperty("qb_allow_linked_items", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? QbAllowLinkedItems { get; set; } 

        [JsonProperty("domotz_default_agentdevicetype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DomotzDefaultAgentdevicetype { get; set; } 

        [JsonProperty("domotz_default_agentdevicetype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? DomotzDefaultAgentdevicetypeGuid { get; set; } 

        [JsonProperty("domotz_default_agentsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DomotzDefaultAgentsite { get; set; } 

        [JsonProperty("domotz_default_devicetype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DomotzDefaultDevicetype { get; set; } 

        [JsonProperty("domotz_default_devicetype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? DomotzDefaultDevicetypeGuid { get; set; } 

        [JsonProperty("domotz_default_devicesite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DomotzDefaultDevicesite { get; set; } 

        [JsonProperty("domotz_delete_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DomotzDeleteDevices { get; set; } 

        [JsonProperty("allow_quantity_calculations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowQuantityCalculations { get; set; } 

        [JsonProperty("po_number_mandatory", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? PoNumberMandatory { get; set; } 

        [JsonProperty("snow_toplevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SnowToplevel { get; set; } 

        [JsonProperty("hideapptactionsfromuser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hideapptactionsfromuser { get; set; } 

        [JsonProperty("snow_default_devicetype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SnowDefaultDevicetype { get; set; } 

        [JsonProperty("snow_default_devicetype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? SnowDefaultDevicetypeGuid { get; set; } 

        [JsonProperty("okta_deactivate_entities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? OktaDeactivateEntities { get; set; } 

        [JsonProperty("okta_last_agent_sync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? OktaLastAgentSync { get; set; } 

        [JsonProperty("okta_last_user_sync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? OktaLastUserSync { get; set; } 

        [JsonProperty("automate_import_entities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AutomateImportEntities { get; set; } 

        [JsonProperty("automate_delete_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutomateDeleteDevices { get; set; } 

        [JsonProperty("automate_connectwise_control", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutomateConnectwiseControl { get; set; } 

        [JsonProperty("connectwise_control_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ConnectwiseControlGuid { get; set; } 

        [JsonProperty("automate_enable_alerting", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutomateEnableAlerting { get; set; } 

        [JsonProperty("automate_alert_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AutomateAlertType { get; set; } 

        [JsonProperty("automate_alert_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AutomateAlertUser { get; set; } 

        [JsonProperty("automate_guid1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AutomateGuid1 { get; set; } 

        [JsonProperty("snow_default_devicesite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SnowDefaultDevicesite { get; set; } 

        [JsonProperty("automate_guid2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AutomateGuid2 { get; set; } 

        [JsonProperty("snow_delete_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SnowDeleteDevices { get; set; } 

        [JsonProperty("haloassetdiscovery_instance_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? HaloassetdiscoveryInstanceType { get; set; } 

        [JsonProperty("default_showmenu", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DefaultShowMenu { get; set; } 

        [JsonProperty("prorata_periods_ahead", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ProrataPeriodsAhead { get; set; } 

        [JsonProperty("childparentlinktableview", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Childparentlinktableview { get; set; } 

        [JsonProperty("mandatory_consignment_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? MandatoryConsignmentSite { get; set; } 

        [JsonProperty("same_client_consignment_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SameClientConsignmentSite { get; set; } 

        [JsonProperty("project_use_consignment_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ProjectUseConsignmentSite { get; set; } 

        [JsonProperty("snow_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SnowImportType { get; set; } 

        [JsonProperty("snow_dont_create_new_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SnowDontCreateNewDevices { get; set; } 

        [JsonProperty("snow_dont_update_device_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SnowDontUpdateDeviceType { get; set; } 

        [JsonProperty("snow_dont_move_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SnowDontMoveSite { get; set; } 

        [JsonProperty("snow_user_matching_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SnowUserMatchingType { get; set; } 

        [JsonProperty("dont_use_vendorflag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DontUseVendorflag { get; set; } 

        [JsonProperty("dont_use_cwticketfilter", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DontUseCwticketfilter { get; set; } 

        [JsonProperty("allow_negative_prorata", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowNegativeProrata { get; set; } 

        [JsonProperty("auvik_top_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AuvikTopLevel { get; set; } 

        [JsonProperty("auvik_default_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AuvikDefaultSite { get; set; } 

        [JsonProperty("auvik_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AuvikImportType { get; set; } 

        [JsonProperty("auvik_enable_alerting", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AuvikEnableAlerting { get; set; } 

        [JsonProperty("auvik_alert_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AuvikAlertType { get; set; } 

        [JsonProperty("auvik_alert_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AuvikAlertUser { get; set; } 

        [JsonProperty("teamsbot_allowed_tenants", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TeamsbotAllowedTenants { get; set; } 

        [JsonProperty("show_contract_balance_on_ticket", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowContractBalanceOnTicket { get; set; } 

        [JsonProperty("default_columns_id_assets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultColumnsIdAssets { get; set; } 

        [JsonProperty("default_columns_id_assets_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? DefaultColumnsIdAssetsGuid { get; set; } 

        [JsonProperty("pin_important_actions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? PinImportantActions { get; set; } 

        [JsonProperty("issueditemsdesc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Issueditemsdesc { get; set; } 

        [JsonProperty("siteassetenduserlink", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Siteassetenduserlink { get; set; } 

        [JsonProperty("webannouncementlocation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Webannouncementlocation { get; set; } 

        [JsonProperty("ticketdrivenservstatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ticketdrivenservstatus { get; set; } 

        [JsonProperty("autosendemailforautorinvoices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Autosendemailforautorinvoices { get; set; } 

        [JsonProperty("isversionreleased", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isversionreleased { get; set; } 

        [JsonProperty("quicktimeagentselect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Quicktimeagentselect { get; set; } 

        [JsonProperty("enableapprovalsigning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enableapprovalsigning { get; set; } 

        [JsonProperty("showenterdetailsmanually", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showenterdetailsmanually { get; set; } 

        [JsonProperty("costupdatemethod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Costupdatemethod { get; set; } 

        [JsonProperty("assigntoapptagent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Assigntoapptagent { get; set; } 

        [JsonProperty("slatimeleftcalcmethod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Slatimeleftcalcmethod { get; set; } 

        [JsonProperty("searchbodyfortag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Searchbodyfortag { get; set; } 

        [JsonProperty("hubspot_top_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? HubspotTopLevel { get; set; } 

        [JsonProperty("hubspot_include_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HubspotIncludeAddress { get; set; } 

        [JsonProperty("hubspot_default_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? HubspotDefaultSite { get; set; } 

        [JsonProperty("hubspot_account", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HubspotAccount { get; set; } 

        [JsonProperty("hubspot_domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HubspotDomain { get; set; } 

        [JsonProperty("hubspot_company_sync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? HubspotCompanySync { get; set; } 

        [JsonProperty("hubspot_contact_sync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? HubspotContactSync { get; set; } 

        [JsonProperty("hubspot_show_success_message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HubspotShowSuccessMessage { get; set; } 

        [JsonProperty("hubspot_included_lifecycles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HubspotIncludedLifecycles { get; set; } 

        [JsonProperty("hubspot_archive", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HubspotArchive { get; set; } 

        [JsonProperty("hubspot_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? HubspotImportType { get; set; } 

        [JsonProperty("qualys_default_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? QualysDefaultSite { get; set; } 

        [JsonProperty("passportal_clienttoplevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PassportalClienttoplevel { get; set; } 

        [JsonProperty("passportal_defaultusersite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PassportalDefaultusersite { get; set; } 

        [JsonProperty("passportal_defaultassetsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PassportalDefaultassetsite { get; set; } 

        [JsonProperty("rpassportal_integratorentitiestoimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? RpassportalIntegratorentitiestoimport { get; set; } 

        [JsonProperty("passportal_defaultassetgroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PassportalDefaultassetgroup { get; set; } 

        [JsonProperty("passportal_defaultassetgroup_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? PassportalDefaultassetgroupGuid { get; set; } 

        [JsonProperty("passportal_deactivate_assets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? PassportalDeactivateAssets { get; set; } 

        [JsonProperty("auvik_top_level_domain_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AuvikTopLevelDomainId { get; set; } 

        [JsonProperty("auvik_top_level_domain_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AuvikTopLevelDomainName { get; set; } 

        [JsonProperty("qbononinventoryitemgroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Qbononinventoryitemgroup { get; set; } 

        [JsonProperty("showmailboxname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowMailboxname { get; set; } 

        [JsonProperty("show_timer_seconds", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowTimerSeconds { get; set; } 

        [JsonProperty("exchange_disable_integrator_delete", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ExchangeDisableIntegratorDelete { get; set; } 

        [JsonProperty("use_account_tax", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseAccountTax { get; set; } 

        [JsonProperty("use_xero_for_sending", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseXeroForSending { get; set; } 

        [JsonProperty("trial_purchase_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TrialPurchaseUrl { get; set; } 

        [JsonProperty("audit_teams_call", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AuditTeamsCall { get; set; } 

        [JsonProperty("itglue_sync_names", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ItglueSyncNames { get; set; } 

        [JsonProperty("qbo_default_company", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? QboDefaultCompany { get; set; } 

        [JsonProperty("intaccttoplevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Intaccttoplevel { get; set; } 

        [JsonProperty("logticketwhenchatend", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Logticketwhenchatend { get; set; } 

        [JsonProperty("intacct_sync_entities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? IntacctSyncEntities { get; set; } 

        [JsonProperty("chatendtickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Chatendtickettype { get; set; } 

        [JsonProperty("chatendtickettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? ChatendtickettypeGuid { get; set; } 

        [JsonProperty("intacctinvoicetransactiondetail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intacctinvoicetransactiondetail { get; set; } 

        [JsonProperty("showcustomerlevelprepay", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowCustomerlevelprepay { get; set; } 

        [JsonProperty("lansweeper_dont_update_asset_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? LansweeperDontUpdateAssetType { get; set; } 

        [JsonProperty("navbar_new_ticket", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? NavbarNewTicket { get; set; } 

        [JsonProperty("added_view_customer_perm", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AddedViewCustomerPerm { get; set; } 

        [JsonProperty("quotepricedp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Quotepricedp { get; set; } 

        [JsonProperty("defaultassetstatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Defaultassetstatus { get; set; } 

        [JsonProperty("negativefeedbackcomment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Negativefeedbackcomment { get; set; } 

        [JsonProperty("sage50cacompanypath", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sage50Cacompanypath { get; set; } 

        [JsonProperty("sage50causername", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sage50Causername { get; set; } 

        [JsonProperty("usehaloinvoiceidforaccounts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Usehaloinvoiceidforaccounts { get; set; } 

        [JsonProperty("reviewnotbillable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Reviewnotbillable { get; set; } 

        [JsonProperty("autofollowonbehalf", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Autofollowonbehalf { get; set; } 

        [JsonProperty("mandatorytags", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Mandatorytags { get; set; } 

        [JsonProperty("updatecurrencytableautomatically", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Updatecurrencytableautomatically { get; set; } 

        [JsonProperty("intacctdefaultlocid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intacctdefaultlocid { get; set; } 

        [JsonProperty("anonymoususer_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AnonymoususerId { get; set; } 

        [JsonProperty("anonymoususer_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AnonymoususerName { get; set; } 

        [JsonProperty("globalaccountsbccemailaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Globalaccountsbccemailaddress { get; set; } 

        [JsonProperty("mandatoryfaqlist", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Mandatoryfaqlist { get; set; } 

        [JsonProperty("teamscallmethod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Teamscallmethod { get; set; } 

        [JsonProperty("stripe_public_key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? StripePublicKey { get; set; } 

        [JsonProperty("stripe_currency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? StripeCurrency { get; set; } 

        [JsonProperty("addigy_defaultassetsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AddigyDefaultassetsite { get; set; } 

        [JsonProperty("addigy_defaultassetgroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AddigyDefaultassetgroup { get; set; } 

        [JsonProperty("addigy_defaultassetgroup_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? AddigyDefaultassetgroupGuid { get; set; } 

        [JsonProperty("addigy_assettypefield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AddigyAssetTypefield { get; set; } 

        [JsonProperty("addigy_deactivate_assets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AddigyDeactivateAssets { get; set; } 

        [JsonProperty("addigy_enable_alerting", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AddigyEnableAlerting { get; set; } 

        [JsonProperty("addigy_alert_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AddigyAlertType { get; set; } 

        [JsonProperty("addigy_alert_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AddigyAlertUser { get; set; } 

        [JsonProperty("domotz_dont_update_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DomotzDontUpdateSite { get; set; } 

        [JsonProperty("showtoplevelontickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowToplevelontickets { get; set; } 

        [JsonProperty("automatetimezone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Automatetimezone { get; set; } 

        [JsonProperty("recurringitembillingdescriptionlong", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Recurringitembillingdescriptionlong { get; set; } 

        [JsonProperty("sage50cadefaultpaidtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sage50Cadefaultpaidtype { get; set; } 

        [JsonProperty("sage50cadefaultpaidaccount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sage50Cadefaultpaidaccount { get; set; } 

        [JsonProperty("deleterowconfirmation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Deleterowconfirmation { get; set; } 

        [JsonProperty("salesforce_toplevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SalesforceToplevel { get; set; } 

        [JsonProperty("logactionforapprovalresponse", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Logactionforapprovalresponse { get; set; } 

        [JsonProperty("salesforce_accountwhere", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SalesforceAccountwhere { get; set; } 

        [JsonProperty("liongardassettypefield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Liongardassettypefield { get; set; } 

        [JsonProperty("salesforce_contactwhere", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SalesforceContactwhere { get; set; } 

        [JsonProperty("liongard_toplevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LiongardToplevel { get; set; } 

        [JsonProperty("salesforce_opportunitywhere", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SalesforceOpportunitywhere { get; set; } 

        [JsonProperty("liongard_defaultsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LiongardDefaultsite { get; set; } 

        [JsonProperty("salesforce_casewhere", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SalesforceCasewhere { get; set; } 

        [JsonProperty("liongard_defaultgroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LiongardDefaultgroup { get; set; } 

        [JsonProperty("liongard_defaultgroup_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? LiongardDefaultgroupGuid { get; set; } 

        [JsonProperty("salesforce_integratorentitiestoimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SalesforceIntegratorentitiestoimport { get; set; } 

        [JsonProperty("salesforce_updateaddresses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SalesforceUpdateaddresses { get; set; } 

        [JsonProperty("liongard_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LiongardImportType { get; set; } 

        [JsonProperty("salesforce_casetickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SalesforceCasetickettype { get; set; } 

        [JsonProperty("salesforce_casetickettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? SalesforceCasetickettypeGuid { get; set; } 

        [JsonProperty("liongard_delete_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? LiongardDeleteDevices { get; set; } 

        [JsonProperty("salesforce_integratoraccountlastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? SalesforceIntegratoraccountlastsync { get; set; } 

        [JsonProperty("liongard_customer_sync_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LiongardCustomerSyncType { get; set; } 

        [JsonProperty("salesforce_integratorcontactlastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? SalesforceIntegratorcontactlastsync { get; set; } 

        [JsonProperty("sync_liongard_customer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SyncLiongardCustomer { get; set; } 

        [JsonProperty("salesforce_integratoropportunitylastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? SalesforceIntegratoropportunitylastsync { get; set; } 

        [JsonProperty("show_liongard_success", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowLiongardSuccess { get; set; } 

        [JsonProperty("accmanagershowextradetails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Accmanagershowextradetails { get; set; } 

        [JsonProperty("ingram_micro_update_addresses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IngramMicroUpdateAddresses { get; set; } 

        [JsonProperty("ingram_micro_top_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? IngramMicroTopLevel { get; set; } 

        [JsonProperty("ingram_micro_import_entities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? IngramMicroImportEntities { get; set; } 

        [JsonProperty("pax8_update_addresses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Pax8UpdateAddresses { get; set; } 

        [JsonProperty("pax8_top_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Pax8TopLevel { get; set; } 

        [JsonProperty("pax8_import_entities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Pax8ImportEntities { get; set; } 

        [JsonProperty("salesforce_integratorcaselastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? SalesforceIntegratorcaselastsync { get; set; } 

        [JsonProperty("sendclosureremindertoccaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sendclosureremindertoccaddress { get; set; } 

        [JsonProperty("exchange_organizer_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ExchangeOrganizerOverride { get; set; } 

        [JsonProperty("showtickettypeselection", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowTicketTypeselection { get; set; } 

        [JsonProperty("azure_federation_domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AzureFederationDomain { get; set; } 

        [JsonProperty("azure_auto_create_users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AzureAutoCreateUsers { get; set; } 

        [JsonProperty("azure_auto_creation_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AzureAutoCreationSite { get; set; } 

        [JsonProperty("azureb2c_domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Azureb2CDomain { get; set; } 

        [JsonProperty("azureb2c_user_flow", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Azureb2CUserFlow { get; set; } 

        [JsonProperty("azure_login_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AzureLoginUrl { get; set; } 

        [JsonProperty("usercanviewapprovedtickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Usercanviewapprovedtickets { get; set; } 

        [JsonProperty("reauthorizeforapprovals", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Reauthorizeforapprovals { get; set; } 

        [JsonProperty("default_itemgroups_hideitems", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DefaultItemgroupsHideitems { get; set; } 

        [JsonProperty("enableshifts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enableshifts { get; set; } 

        [JsonProperty("newrelic_tickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewrelicTicketType { get; set; } 

        [JsonProperty("newrelic_tickettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? NewrelicTicketTypeGuid { get; set; } 

        [JsonProperty("newrelic_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewrelicUser { get; set; } 

        [JsonProperty("backupradar_alert_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? BackupradarAlertType { get; set; } 

        [JsonProperty("rbackupradarapiurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Rbackupradarapiurl { get; set; } 

        [JsonProperty("rbackupradarapikey", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Rbackupradarapikey { get; set; } 

        [JsonProperty("userscanviewitems", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Userscanviewitems { get; set; } 

        [JsonProperty("use_tickettab_areas", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseTickettabAreas { get; set; } 

        [JsonProperty("split_childtickets_tab", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SplitChildticketsTab { get; set; } 

        [JsonProperty("enable_contract_calculated_cost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableContractCalculatedCost { get; set; } 

        [JsonProperty("cipp_instance_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CippInstanceUrl { get; set; } 

        [JsonProperty("auto_create_next_asset_tag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoCreateNextAssetTag { get; set; } 

        [JsonProperty("bookingshowphonenumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Bookingshowphonenumber { get; set; } 

        [JsonProperty("bookingshowemailaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Bookingshowemailaddress { get; set; } 

        [JsonProperty("intacctdefaultdepid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intacctdefaultdepid { get; set; } 

        [JsonProperty("enablezoomcall", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enablezoomcall { get; set; } 

        [JsonProperty("enable_comparative_quoting", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableComparativeQuoting { get; set; } 

        [JsonProperty("ncentral_delete_clients", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? NcentralDeleteClients { get; set; } 

        [JsonProperty("ncentral_delete_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? NcentralDeleteDevices { get; set; } 

        [JsonProperty("gc_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? GcClientId { get; set; } 

        [JsonProperty("kaseya_defaultsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? KaseyaDefaultsite { get; set; } 

        [JsonProperty("kaseya_defaultassettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? KaseyaDefaultassettype { get; set; } 

        [JsonProperty("kaseya_defaultassettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? KaseyaDefaultassettypeGuid { get; set; } 

        [JsonProperty("kaseya_enable_alerting", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? KaseyaEnableAlerting { get; set; } 

        [JsonProperty("kaseya_alert_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? KaseyaAlertType { get; set; } 

        [JsonProperty("kaseya_alert_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? KaseyaAlertUser { get; set; } 

        [JsonProperty("kaseya_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? KaseyaImportType { get; set; } 

        [JsonProperty("kaseya_delete_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? KaseyaDeleteDevices { get; set; } 

        [JsonProperty("kaseyaservicedesks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Kaseyaservicedesks { get; set; } 

        [JsonProperty("migration_ticket_end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? MigrationTicketEndDate { get; set; } 

        [JsonProperty("invoicelongdescriptionfromsalesorder", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Invoicelongdescriptionfromsalesorder { get; set; } 

        [JsonProperty("dbc_default_company", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DbcDefaultCompany { get; set; } 

        [JsonProperty("enable_legacy_dbc_integration", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableLegacyDbcIntegration { get; set; } 

        [JsonProperty("salesforce_accountsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SalesforceAccountsync { get; set; } 

        [JsonProperty("salesforce_contactsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SalesforceContactsync { get; set; } 

        [JsonProperty("salesforce_show_success_message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SalesforceShowSuccessMessage { get; set; } 

        [JsonProperty("salesforce_include_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SalesforceIncludeAddress { get; set; } 

        [JsonProperty("salesforce_deafult_stage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SalesforceDeafultStage { get; set; } 

        [JsonProperty("hide_consignment_costs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HideConsignmentCosts { get; set; } 

        [JsonProperty("select_consignment_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SelectConsignmentUser { get; set; } 

        [JsonProperty("select_consignment_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SelectConsignmentStatus { get; set; } 

        [JsonProperty("defaultconsignmentpdftemplate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Defaultconsignmentpdftemplate { get; set; } 

        [JsonProperty("stripenotificationemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Stripenotificationemail { get; set; } 

        [JsonProperty("enableautostripepayment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enableautostripepayment { get; set; } 

        [JsonProperty("stripepaymentmethodoptions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Stripepaymentmethodoptions { get; set; } 

        [JsonProperty("zabbix_default_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ZabbixDefaultType { get; set; } 

        [JsonProperty("zabbix_default_type_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? ZabbixDefaultTypeGuid { get; set; } 

        [JsonProperty("zabbix_default_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ZabbixDefaultSite { get; set; } 

        [JsonProperty("zabbix_dont_update_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ZabbixDontUpdateType { get; set; } 

        [JsonProperty("zabbix_dont_update_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ZabbixDontUpdateSite { get; set; } 

        [JsonProperty("zabbix_delete_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ZabbixDeleteDevices { get; set; } 

        [JsonProperty("show_favourite_services", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowFavouriteServices { get; set; } 

        [JsonProperty("slack_ticket_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SlackTicketType { get; set; } 

        [JsonProperty("allow_password_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowPasswordOverride { get; set; } 

        [JsonProperty("password_strength_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PasswordStrengthLevel { get; set; } 

        [JsonProperty("force_agent_2fa", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ForceAgent2Fa { get; set; } 

        [JsonProperty("giacom_top_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? GiacomTopLevel { get; set; } 

        [JsonProperty("giacom_import_entities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? GiacomImportEntities { get; set; } 

        [JsonProperty("rhipe_update_addresses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? RhipeUpdateAddresses { get; set; } 

        [JsonProperty("rhipe_top_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? RhipeTopLevel { get; set; } 

        [JsonProperty("rhipe_import_entities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? RhipeImportEntities { get; set; } 

        [JsonProperty("techdata_top_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TechdataTopLevel { get; set; } 

        [JsonProperty("techdata_import_entities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TechdataImportEntities { get; set; } 

        [JsonProperty("inty_update_addresses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IntyUpdateAddresses { get; set; } 

        [JsonProperty("inty_top_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? IntyTopLevel { get; set; } 

        [JsonProperty("inty_import_entities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? IntyImportEntities { get; set; } 

        [JsonProperty("westcoastcloud_update_addresses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? WestcoastcloudUpdateAddresses { get; set; } 

        [JsonProperty("westcoastcloud_top_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? WestcoastcloudTopLevel { get; set; } 

        [JsonProperty("westcoastcloud_import_entities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? WestcoastcloudImportEntities { get; set; } 

        [JsonProperty("sherweb_top_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SherwebTopLevel { get; set; } 

        [JsonProperty("sherweb_import_entities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SherwebImportEntities { get; set; } 

        [JsonProperty("also_update_addresses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AlsoUpdateAddresses { get; set; } 

        [JsonProperty("also_top_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AlsoTopLevel { get; set; } 

        [JsonProperty("also_import_entities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AlsoImportEntities { get; set; } 

        [JsonProperty("arrowsphere_update_addresses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ArrowsphereUpdateAddresses { get; set; } 

        [JsonProperty("arrowsphere_top_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ArrowsphereTopLevel { get; set; } 

        [JsonProperty("arrowsphere_import_entities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ArrowsphereImportEntities { get; set; } 

        [JsonProperty("dickerdata_update_addresses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DickerdataUpdateAddresses { get; set; } 

        [JsonProperty("dickerdata_top_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DickerdataTopLevel { get; set; } 

        [JsonProperty("dickerdata_import_entities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DickerdataImportEntities { get; set; } 

        [JsonProperty("oracle_email_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OracleEmailAddress { get; set; } 

        [JsonProperty("slack_ticket_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SlackTicketUser { get; set; } 

        [JsonProperty("autocomplete_email_address_behaviour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AutocompleteEmailAddressBehaviour { get; set; } 

        [JsonProperty("override_assertion_endpoint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OverrideAssertionEndpoint { get; set; } 

        [JsonProperty("noactionsaftermerge", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Noactionsaftermerge { get; set; } 

        [JsonProperty("default_filter_id_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultFilterIdTickets { get; set; } 

        [JsonProperty("default_filter_id_tickets_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? DefaultFilterIdTicketsGuid { get; set; } 

        [JsonProperty("default_columns_id_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultColumnsIdTickets { get; set; } 

        [JsonProperty("default_columns_id_tickets_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? DefaultColumnsIdTicketsGuid { get; set; } 

        [JsonProperty("default_view_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultViewTickets { get; set; } 

        [JsonProperty("default_view_tickets_selectedid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultViewTicketsSelectedid { get; set; } 

        [JsonProperty("default_view_tickets_selected_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? DefaultViewTicketsSelectedGuid { get; set; } 

        [JsonProperty("default_filter_id_opps", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultFilterIdOpps { get; set; } 

        [JsonProperty("default_filter_id_opps_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? DefaultFilterIdOppsGuid { get; set; } 

        [JsonProperty("default_columns_id_opps", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultColumnsIdOpps { get; set; } 

        [JsonProperty("default_columns_id_opps_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? DefaultColumnsIdOppsGuid { get; set; } 

        [JsonProperty("default_view_opps", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultViewOpps { get; set; } 

        [JsonProperty("default_view_opps_selectedid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultViewOppsSelectedid { get; set; } 

        [JsonProperty("default_view_opps_selected_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? DefaultViewOppsSelectedGuid { get; set; } 

        [JsonProperty("forwardinboundupdates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Forwardinboundupdates { get; set; } 

        [JsonProperty("usetechfwdfunctionality", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Usetechfwdfunctionality { get; set; } 

        [JsonProperty("techupdatesareprivate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Techupdatesareprivate { get; set; } 

        [JsonProperty("smtpdisplayname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Smtpdisplayname { get; set; } 

        [JsonProperty("attachmentsizelimitmb", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Attachmentsizelimitmb { get; set; } 

        [JsonProperty("respondprivate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Respondprivate { get; set; } 

        [JsonProperty("default_client", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultClient { get; set; } 

        [JsonProperty("force_accounts_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ForceAccountsId { get; set; } 

        [JsonProperty("new_client_template_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewClientTemplateId { get; set; } 

        [JsonProperty("default_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultSite { get; set; } 

        [JsonProperty("default_clientsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultClientsiteName { get; set; } 

        [JsonProperty("deleteforever", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Deleteforever { get; set; } 

        [JsonProperty("parentstatusafterallchildclosed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Parentstatusafterallchildclosed { get; set; } 

        [JsonProperty("parentstatusafterallchildclosed_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? ParentstatusafterallchildclosedGuid { get; set; } 

        [JsonProperty("newchilduserisagent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Newchilduserisagent { get; set; } 

        [JsonProperty("percentage_to_survey", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PercentageToSurvey { get; set; } 

        [JsonProperty("feedback_tickettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? FeedbackTicketTypeId { get; set; } 

        [JsonProperty("feedback_tickettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? FeedbackTicketTypeGuid { get; set; } 

        [JsonProperty("allowcabchoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allowcabchoice { get; set; } 

        [JsonProperty("showlbandrr", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showlbandrr { get; set; } 

        [JsonProperty("showlbandrrinactions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showlbandrrinactions { get; set; } 

        [JsonProperty("onlyrrorlbtologgedintechs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Onlyrrorlbtologgedintechs { get; set; } 

        [JsonProperty("roundrobinreassign", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Roundrobinreassign { get; set; } 

        [JsonProperty("loadbalanceuseestimates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Loadbalanceuseestimates { get; set; } 

        [JsonProperty("loadbalanceonfollowupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Loadbalanceonfollowupdate { get; set; } 

        [JsonProperty("appointmentslaprocedure", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Appointmentslaprocedure { get; set; } 

        [JsonProperty("holiday_agentstatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? HolidayAgentstatus { get; set; } 

        [JsonProperty("changeshowchangedetails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Changeshowchangedetails { get; set; } 

        [JsonProperty("changeshowjustification", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Changeshowjustification { get; set; } 

        [JsonProperty("changeshowimpact", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Changeshowimpact { get; set; } 

        [JsonProperty("changeshowrisk", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Changeshowrisk { get; set; } 

        [JsonProperty("changeshowbackout", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Changeshowbackout { get; set; } 

        [JsonProperty("changeshowcommunication", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Changeshowcommunication { get; set; } 

        [JsonProperty("changeshowtest", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Changeshowtest { get; set; } 

        [JsonProperty("use_release1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseRelease1 { get; set; } 

        [JsonProperty("use_release2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseRelease2 { get; set; } 

        [JsonProperty("use_release3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseRelease3 { get; set; } 

        [JsonProperty("release1_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Release1Name { get; set; } 

        [JsonProperty("release2_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Release2Name { get; set; } 

        [JsonProperty("release3_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Release3Name { get; set; } 

        [JsonProperty("release2_autoupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Release2Autoupdate { get; set; } 

        [JsonProperty("release3_autoupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Release3Autoupdate { get; set; } 

        [JsonProperty("release_includeunsentnotesinemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReleaseIncludeunsentnotesinemail { get; set; } 

        [JsonProperty("release_category", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ReleaseCategory { get; set; } 

        [JsonProperty("workflow_preview_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? WorkflowPreviewType { get; set; } 

        [JsonProperty("usepaygafterprepay", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Usepaygafterprepay { get; set; } 

        [JsonProperty("calcincminticketlevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Calcincminticketlevel { get; set; } 

        [JsonProperty("continueusingrulesafterlogging", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Continueusingrulesafterlogging { get; set; } 

        [JsonProperty("defaultlanguage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Defaultlanguage { get; set; } 

        [JsonProperty("enablemultilanguage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enablemultilanguage { get; set; } 

        [JsonProperty("reassign_limit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ReassignLimit { get; set; } 

        [JsonProperty("app_colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AppColour { get; set; } 

        [JsonProperty("enablekbmatching", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enablekbmatching { get; set; } 

        [JsonProperty("kbmatchingcategorymatch", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Kbmatchingcategorymatch { get; set; } 

        [JsonProperty("kbaddshowpreview", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Kbaddshowpreview { get; set; } 

        [JsonProperty("enablefulltextsearch", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enablefulltextsearch { get; set; } 

        [JsonProperty("problemmatchcategorymatch", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Problemmatchcategorymatch { get; set; } 

        [JsonProperty("problemmatchautoproblemnew", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Problemmatchautoproblemnew { get; set; } 

        [JsonProperty("problemmatchautoincidentnew", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Problemmatchautoincidentnew { get; set; } 

        [JsonProperty("problemmatchautoproblemview", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Problemmatchautoproblemview { get; set; } 

        [JsonProperty("problemmatchautoincidentview", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Problemmatchautoincidentview { get; set; } 

        [JsonProperty("quicktimertid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Quicktimertid { get; set; } 

        [JsonProperty("smsprovideraddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Smsprovideraddress { get; set; } 

        [JsonProperty("smsfromaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Smsfromaddress { get; set; } 

        [JsonProperty("new_smsppassword", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewSmsppassword { get; set; } 

        [JsonProperty("smsdisplay", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Smsdisplay { get; set; } 

        [JsonProperty("autostarttimer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Autostarttimer { get; set; } 

        [JsonProperty("opentickettimer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Opentickettimer { get; set; } 

        [JsonProperty("enablequickclose", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enablequickclose { get; set; } 

        [JsonProperty("sendemailsviawebapp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sendemailsviawebapp { get; set; } 

        [JsonProperty("showchildunreadinlist", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowChildunreadinlist { get; set; } 

        [JsonProperty("storekbattachmentsindb", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Storekbattachmentsindb { get; set; } 

        [JsonProperty("kbmatchcustomfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Kbmatchcustomfields { get; set; } 

        [JsonProperty("kbmatchignoresubject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Kbmatchignoresubject { get; set; } 

        [JsonProperty("enablecollisiondetection", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enablecollisiondetection { get; set; } 

        [JsonProperty("mustclosewithaction", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Mustclosewithaction { get; set; } 

        [JsonProperty("dontshowclosurestatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dontshowclosurestatus { get; set; } 

        [JsonProperty("usetechtimesheets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Usetechtimesheets { get; set; } 

        [JsonProperty("allowquicktime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allowquicktime { get; set; } 

        [JsonProperty("livechatallowusers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Livechatallowusers { get; set; } 

        [JsonProperty("livechatallowvisitors", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Livechatallowvisitors { get; set; } 

        [JsonProperty("livechattechmustonline", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Livechattechmustonline { get; set; } 

        [JsonProperty("livechatworkhours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Livechatworkhours { get; set; } 

        [JsonProperty("livechattechnamevisibility", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Livechattechnamevisibility { get; set; } 

        [JsonProperty("livechattechnamevisibilitytext", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Livechattechnamevisibilitytext { get; set; } 

        [JsonProperty("livechatnewchatmsg", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Livechatnewchatmsg { get; set; } 

        [JsonProperty("livechatincludeemailinname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Livechatincludeemailinname { get; set; } 

        [JsonProperty("passwordreseturl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Passwordreseturl { get; set; } 

        [JsonProperty("passwordenrollurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Passwordenrollurl { get; set; } 

        [JsonProperty("questioncount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Questioncount { get; set; } 

        [JsonProperty("hideusersanswers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hideusersanswers { get; set; } 

        [JsonProperty("quickstatuschangeallowed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Quickstatuschangeallowed { get; set; } 

        [JsonProperty("quickagentchangeallowed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Quickagentchangeallowed { get; set; } 

        [JsonProperty("calendarstepinterval", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Calendarstepinterval { get; set; } 

        [JsonProperty("callrequesttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Callrequesttype { get; set; } 

        [JsonProperty("callrequesttype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? CallrequesttypeGuid { get; set; } 

        [JsonProperty("callsendack", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Callsendack { get; set; } 

        [JsonProperty("showspambutton", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showspambutton { get; set; } 

        [JsonProperty("shownewcallbtn", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Shownewcallbtn { get; set; } 

        [JsonProperty("showsendemailbtn", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showsendemailbtn { get; set; } 

        [JsonProperty("actioncalendardefault", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Actioncalendardefault { get; set; } 

        [JsonProperty("homescreenchartid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Homescreenchartid { get; set; } 

        [JsonProperty("alluse2fa", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Alluse2Fa { get; set; } 

        [JsonProperty("hidechangemanagementtab", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hidechangemanagementtab { get; set; } 

        [JsonProperty("problemmatchingposition", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Problemmatchingposition { get; set; } 

        [JsonProperty("default_opp_tickettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultOppTicketTypeId { get; set; } 

        [JsonProperty("default_opp_tickettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? DefaultOppTicketTypeGuid { get; set; } 

        [JsonProperty("default_client_opps", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultClientOpps { get; set; } 

        [JsonProperty("default_site_opps", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultSiteOpps { get; set; } 

        [JsonProperty("default_clientsite_name_opps", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultClientsiteNameOpps { get; set; } 

        [JsonProperty("newuseremailmandatory", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Newuseremailmandatory { get; set; } 

        [JsonProperty("newuserphonemandatory", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Newuserphonemandatory { get; set; } 

        [JsonProperty("callusenewreqscreen", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Callusenewreqscreen { get; set; } 

        [JsonProperty("hiderespondbutton", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hiderespondbutton { get; set; } 

        [JsonProperty("timertype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Timertype { get; set; } 

        [JsonProperty("movesectiononrespond", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Movesectiononrespond { get; set; } 

        [JsonProperty("cleanhtmlpasting", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Cleanhtmlpasting { get; set; } 

        [JsonProperty("taskscompleteallowclosure", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Taskscompleteallowclosure { get; set; } 

        [JsonProperty("mustassigntoclose", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Mustassigntoclose { get; set; } 

        [JsonProperty("allowclosureatunknownclient", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allowclosureatunknownclient { get; set; } 

        [JsonProperty("alloweditonemailpreview", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Alloweditonemailpreview { get; set; } 

        [JsonProperty("sendattachmentsfromdb", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sendattachmentsfromdb { get; set; } 

        [JsonProperty("emailsizelimitmb", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Emailsizelimitmb { get; set; } 

        [JsonProperty("enableroadmap", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enableroadmap { get; set; } 

        [JsonProperty("useoohack", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Useoohack { get; set; } 

        [JsonProperty("oncallunum", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Oncallunum { get; set; } 

        [JsonProperty("informoutofhdworkinghours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Informoutofhdworkinghours { get; set; } 

        [JsonProperty("allowsiteoverride", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allowsiteoverride { get; set; } 

        [JsonProperty("shownewrequsersearch", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Shownewrequsersearch { get; set; } 

        [JsonProperty("allowquicksiteadd", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allowquicksiteadd { get; set; } 

        [JsonProperty("showcontractcoloursonassetchoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowContractcoloursonassetchoice { get; set; } 

        [JsonProperty("assetundercontractifcontractnotstarted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Assetundercontractifcontractnotstarted { get; set; } 

        [JsonProperty("selectfaqlistbeforesearch", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Selectfaqlistbeforesearch { get; set; } 

        [JsonProperty("selecttickettypebeforesearch", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Selecttickettypebeforesearch { get; set; } 

        [JsonProperty("usetickettypegroups", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Usetickettypegroups { get; set; } 

        [JsonProperty("userelativedates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Userelativedates { get; set; } 

        [JsonProperty("enableticketcaching", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enableticketcaching { get; set; } 

        [JsonProperty("allowemailsubjectedit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allowemailsubjectedit { get; set; } 

        [JsonProperty("recurringitembillingdescription", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Recurringitembillingdescription { get; set; } 

        [JsonProperty("mileagechargerate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Mileagechargerate { get; set; } 

        [JsonProperty("traveltimechargerate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Traveltimechargerate { get; set; } 

        [JsonProperty("ticketinvoices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ticketinvoices { get; set; } 

        [JsonProperty("ticketasaccountsinvno", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ticketasaccountsinvno { get; set; } 

        [JsonProperty("useassetcontractforbilling", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Useassetcontractforbilling { get; set; } 

        [JsonProperty("enablenetworkconnectioncheck", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enablenetworkconnectioncheck { get; set; } 

        [JsonProperty("useassetsonlytocalculatecontractvalue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Useassetsonlytocalculatecontractvalue { get; set; } 

        [JsonProperty("showassetlinesoncontractinvoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowAssetlinesoncontractinvoice { get; set; } 

        [JsonProperty("showassetvalueoninvoiceline", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowAssetvalueoninvoiceline { get; set; } 

        [JsonProperty("assetlinesbillingdesc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Assetlinesbillingdesc { get; set; } 

        [JsonProperty("slaholdcolour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Slaholdcolour { get; set; } 

        [JsonProperty("pagesize", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Pagesize { get; set; } 

        [JsonProperty("onlyusetimersonactionswithtimetaken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Onlyusetimersonactionswithtimetaken { get; set; } 

        [JsonProperty("use24hrclock", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Use24Hrclock { get; set; } 

        [JsonProperty("usecannedtextprediction", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Usecannedtextprediction { get; set; } 

        [JsonProperty("usefreetexttable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Usefreetexttable { get; set; } 

        [JsonProperty("usereadonlydbstring", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Usereadonlydbstring { get; set; } 

        [JsonProperty("appointmentinvitetype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Appointmentinvitetype { get; set; } 

        [JsonProperty("feedbackhigh", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Feedbackhigh { get; set; } 

        [JsonProperty("feedbacklow", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Feedbacklow { get; set; } 

        [JsonProperty("feedback1high", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Feedback1High { get; set; } 

        [JsonProperty("feedback1low", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Feedback1Low { get; set; } 

        [JsonProperty("feedback2high", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Feedback2High { get; set; } 

        [JsonProperty("feedback2low", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Feedback2Low { get; set; } 

        [JsonProperty("feedback3high", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Feedback3High { get; set; } 

        [JsonProperty("feedback3low", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Feedback3Low { get; set; } 

        [JsonProperty("feedback4high", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Feedback4High { get; set; } 

        [JsonProperty("feedback4low", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Feedback4Low { get; set; } 

        [JsonProperty("showfeedbackpopups", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showfeedbackpopups { get; set; } 

        [JsonProperty("feedbackrecordtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Feedbackrecordtype { get; set; } 

        [JsonProperty("ssologin", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ssologin { get; set; } 

        [JsonProperty("ssologout", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ssologout { get; set; } 

        [JsonProperty("ssofingerprint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ssofingerprint { get; set; } 

        [JsonProperty("ssoautoredirect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ssoautoredirect { get; set; } 

        [JsonProperty("allownhdsupport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allownhdsupport { get; set; } 

        [JsonProperty("showxlsexportbutton", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showxlsexportbutton { get; set; } 

        [JsonProperty("showcsvexportbutton", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowCsvexportbutton { get; set; } 

        [JsonProperty("allowticketmerging", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allowticketmerging { get; set; } 

        [JsonProperty("enablesap", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enablesap { get; set; } 

        [JsonProperty("bugzillabugurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Bugzillabugurl { get; set; } 

        [JsonProperty("enablecontinuum", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enablecontinuum { get; set; } 

        [JsonProperty("showticketsearchonmerge", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowTicketsearchonmerge { get; set; } 

        [JsonProperty("apptexchangetype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Apptexchangetype { get; set; } 

        [JsonProperty("apptadminuser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Apptadminuser { get; set; } 

        [JsonProperty("ewsserverversion", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ewsserverversion { get; set; } 

        [JsonProperty("onlyshowmyteamsintree", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Onlyshowmyteamsintree { get; set; } 

        [JsonProperty("nhserverversion", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Nhserverversion { get; set; } 

        [JsonProperty("usetreeforcat", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Usetreeforcat { get; set; } 

        [JsonProperty("setupstepscompleted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Setupstepscompleted { get; set; } 

        [JsonProperty("enablefacebook", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enablefacebook { get; set; } 

        [JsonProperty("itemmarkuppercdefault", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Itemmarkuppercdefault { get; set; } 

        [JsonProperty("quoteexpirydays", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Quoteexpirydays { get; set; } 

        [JsonProperty("vatmethod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Vatmethod { get; set; } 

        [JsonProperty("2faemailallowed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _2faemailallowed { get; set; } 

        [JsonProperty("2fasmsallowed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _2fasmsallowed { get; set; } 

        [JsonProperty("2faauthenticatorallowed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _2faauthenticatorallowed { get; set; } 

        [JsonProperty("callscreencallscript", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Callscreencallscript { get; set; } 

        [JsonProperty("showticketattachmenticon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowTicketattachmenticon { get; set; } 

        [JsonProperty("shownoapproverspopup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Shownoapproverspopup { get; set; } 

        [JsonProperty("listagentuserfirst", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Listagentuserfirst { get; set; } 

        [JsonProperty("quicktimeusermandatory", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Quicktimeusermandatory { get; set; } 

        [JsonProperty("enablepowershell", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enablepowershell { get; set; } 

        [JsonProperty("sendacknowledgementemailstotoaddresses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sendacknowledgementemailstotoaddresses { get; set; } 

        [JsonProperty("agentlinkedusermanagementenabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Agentlinkedusermanagementenabled { get; set; } 

        [JsonProperty("salesforce_tickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SalesforceTicketType { get; set; } 

        [JsonProperty("salesforce_tickettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? SalesforceTicketTypeGuid { get; set; } 

        [JsonProperty("clientimportidentifier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Clientimportidentifier { get; set; } 

        [JsonProperty("siteimportidentifier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Siteimportidentifier { get; set; } 

        [JsonProperty("userimportidentifier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Userimportidentifier { get; set; } 

        [JsonProperty("assetimportidentifier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Assetimportidentifier { get; set; } 

        [JsonProperty("assetimportidentifier_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? AssetimportidentifierGuid { get; set; } 

        [JsonProperty("supplierimportidentifier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Supplierimportidentifier { get; set; } 

        [JsonProperty("itemimportidentifier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Itemimportidentifier { get; set; } 

        [JsonProperty("assettypeimportidentifier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AssetTypeimportidentifier { get; set; } 

        [JsonProperty("enableonlinepresence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enableonlinepresence { get; set; } 

        [JsonProperty("mainrefreshinterval", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Mainrefreshinterval { get; set; } 

        [JsonProperty("usecallplan", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Usecallplan { get; set; } 

        [JsonProperty("importazuredomain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Importazuredomain { get; set; } 

        [JsonProperty("importazureappid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Importazureappid { get; set; } 

        [JsonProperty("importazuresite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Importazuresite { get; set; } 

        [JsonProperty("importazuresite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ImportazuresiteName { get; set; } 

        [JsonProperty("azureuserfilter", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Azureuserfilter { get; set; } 

        [JsonProperty("importazuresitefield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Importazuresitefield { get; set; } 

        [JsonProperty("enableazuresinglesignon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enableazuresinglesignon { get; set; } 

        [JsonProperty("azureautoredirect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Azureautoredirect { get; set; } 

        [JsonProperty("azureautoredirectuser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Azureautoredirectuser { get; set; } 

        [JsonProperty("useiconsforactionbuttonsmobile", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Useiconsforactionbuttonsmobile { get; set; } 

        [JsonProperty("updatebillingfieldsonchange", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Updatebillingfieldsonchange { get; set; } 

        [JsonProperty("showservicecataloglink", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showservicecataloglink { get; set; } 

        [JsonProperty("showmyservices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowMyservices { get; set; } 

        [JsonProperty("servicerequestrtid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Servicerequestrtid { get; set; } 

        [JsonProperty("servicerequestrtid_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? ServicerequestrtidGuid { get; set; } 

        [JsonProperty("serviceincidentrtid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Serviceincidentrtid { get; set; } 

        [JsonProperty("servicedefaultok", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Servicedefaultok { get; set; } 

        [JsonProperty("servicedefaultfault", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Servicedefaultfault { get; set; } 

        [JsonProperty("servicedefaultmaintenance", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Servicedefaultmaintenance { get; set; } 

        [JsonProperty("servicefailurert", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Servicefailurert { get; set; } 

        [JsonProperty("dynamicscrmdefaultsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Dynamicscrmdefaultsite { get; set; } 

        [JsonProperty("DefaultCustomerSiteUserView", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultCustomerSiteUserView { get; set; } 

        [JsonProperty("DefaultServiceAccessLevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultServiceAccessLevel { get; set; } 

        [JsonProperty("pagerdutydefrequesttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Pagerdutydefrequesttype { get; set; } 

        [JsonProperty("pagerdutydefrequesttype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? PagerdutydefrequesttypeGuid { get; set; } 

        [JsonProperty("pagerdutyaccount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Pagerdutyaccount { get; set; } 

        [JsonProperty("pagerdutyservicekey", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Pagerdutyservicekey { get; set; } 

        [JsonProperty("pagerdutyservicename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Pagerdutyservicename { get; set; } 

        [JsonProperty("pagerdutysourcefield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Pagerdutysourcefield { get; set; } 

        [JsonProperty("showitilselection", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showitilselection { get; set; } 

        [JsonProperty("splunk_tickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SplunkTicketType { get; set; } 

        [JsonProperty("splunk_tickettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? SplunkTicketTypeGuid { get; set; } 

        [JsonProperty("splunkuser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Splunkuser { get; set; } 

        [JsonProperty("enableoktasinglesignon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enableoktasinglesignon { get; set; } 

        [JsonProperty("okta_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OktaUrl { get; set; } 

        [JsonProperty("okta_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OktaClientId { get; set; } 

        [JsonProperty("oktaautoredirect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Oktaautoredirect { get; set; } 

        [JsonProperty("salesforcedefaultsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Salesforcedefaultsite { get; set; } 

        [JsonProperty("salesforceuserfield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Salesforceuserfield { get; set; } 

        [JsonProperty("salesforcedefaultsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SalesforcedefaultsiteName { get; set; } 

        [JsonProperty("usestatuscolouroncalendar", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Usestatuscolouroncalendar { get; set; } 

        [JsonProperty("timelinestepinterval", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Timelinestepinterval { get; set; } 

        [JsonProperty("azuressoappid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Azuressoappid { get; set; } 

        [JsonProperty("azuretenantid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Azuretenantid { get; set; } 

        [JsonProperty("smtpusethismailboxid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Smtpusethismailboxid { get; set; } 

        [JsonProperty("usedaysforprojectbudgets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Usedaysforprojectbudgets { get; set; } 

        [JsonProperty("hoursperday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Hoursperday { get; set; } 

        [JsonProperty("reopenticketstech", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Reopenticketstech { get; set; } 

        [JsonProperty("showusersitecustomernotesonticketdetails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showusersitecustomernotesonticketdetails { get; set; } 

        [JsonProperty("lmirescueusername", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Lmirescueusername { get; set; } 

        [JsonProperty("expandtimelineitemtofillblock", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Expandtimelineitemtofillblock { get; set; } 

        [JsonProperty("rtimezone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Rtimezone { get; set; } 

        [JsonProperty("sameclientmergeonly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sameclientmergeonly { get; set; } 

        [JsonProperty("lmichannelurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Lmichannelurl { get; set; } 

        [JsonProperty("lmiallowothertechinvites", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Lmiallowothertechinvites { get; set; } 

        [JsonProperty("lmichannelname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Lmichannelname { get; set; } 

        [JsonProperty("defaultremotesessionuserid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Defaultremotesessionuserid { get; set; } 

        [JsonProperty("azurecreatesites", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Azurecreatesites { get; set; } 

        [JsonProperty("remotesession_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? RemotesessionUsername { get; set; } 

        [JsonProperty("allowquickinvites", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allowquickinvites { get; set; } 

        [JsonProperty("periodichistorydate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Periodichistorydate { get; set; } 

        [JsonProperty("adminsskippendingclosure", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Adminsskippendingclosure { get; set; } 

        [JsonProperty("timelinedaysspanthreshold", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Timelinedaysspanthreshold { get; set; } 

        [JsonProperty("timelinelineheight", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Timelinelineheight { get; set; } 

        [JsonProperty("usenewportal", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Usenewportal { get; set; } 

        [JsonProperty("portalshowworkflow", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Portalshowworkflow { get; set; } 

        [JsonProperty("portalshowawaitinginput", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Portalshowawaitinginput { get; set; } 

        [JsonProperty("webdashboardtitle", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Webdashboardtitle { get; set; } 

        [JsonProperty("sage200version", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sage200Version { get; set; } 

        [JsonProperty("sage200toplevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sage200Toplevel { get; set; } 

        [JsonProperty("sage200tenantid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sage200Tenantid { get; set; } 

        [JsonProperty("sage200companyid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sage200Companyid { get; set; } 

        [JsonProperty("sage200itemgroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sage200Itemgroup { get; set; } 

        [JsonProperty("sage200companyname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sage200Companyname { get; set; } 

        [JsonProperty("usekashflow", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Usekashflow { get; set; } 

        [JsonProperty("usexero", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Usexero { get; set; } 

        [JsonProperty("useinvoicexml", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Useinvoicexml { get; set; } 

        [JsonProperty("useinvoicecsv", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Useinvoicecsv { get; set; } 

        [JsonProperty("usevaribill", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Usevaribill { get; set; } 

        [JsonProperty("keepescmsgrecord", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Keepescmsgrecord { get; set; } 

        [JsonProperty("sage200token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sage200Token { get; set; } 

        [JsonProperty("sage200tokenexpiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Sage200Tokenexpiry { get; set; } 

        [JsonProperty("callscreenusetimeonactions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Callscreenusetimeonactions { get; set; } 

        [JsonProperty("oktasso", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Oktasso { get; set; } 

        [JsonProperty("adfssso", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Adfssso { get; set; } 

        [JsonProperty("azureadsso", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Azureadsso { get; set; } 

        [JsonProperty("portalhomeshowkbsearch", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Portalhomeshowkbsearch { get; set; } 

        [JsonProperty("searchkbbyid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Searchkbbyid { get; set; } 

        [JsonProperty("portalhomeshowfeed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Portalhomeshowfeed { get; set; } 

        [JsonProperty("portalhomeshowtoparticles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Portalhomeshowtoparticles { get; set; } 

        [JsonProperty("portalhomeshownewsarticles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Portalhomeshownewsarticles { get; set; } 

        [JsonProperty("showapprovalsonseparatetab", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowApprovalsonseparatetab { get; set; } 

        [JsonProperty("pagerdutyserviceid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Pagerdutyserviceid { get; set; } 

        [JsonProperty("autoswitchtodefaultremoteteam", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Autoswitchtodefaultremoteteam { get; set; } 

        [JsonProperty("requireexternalkey", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Requireexternalkey { get; set; } 

        [JsonProperty("change_collision_enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ChangeCollisionEnabled { get; set; } 

        [JsonProperty("cautomatedefaultsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Cautomatedefaultsite { get; set; } 

        [JsonProperty("cautomatetoplevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Cautomatetoplevel { get; set; } 

        [JsonProperty("cautomateassetdefaultsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Cautomateassetdefaultsite { get; set; } 

        [JsonProperty("hideassetsystemfieldstatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hideassetsystemfieldstatus { get; set; } 

        [JsonProperty("sendmultiplenotifications", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sendmultiplenotifications { get; set; } 

        [JsonProperty("allnotificationoverridessections", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allnotificationoverridessections { get; set; } 

        [JsonProperty("sendnotificationemailforrtbcc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sendnotificationemailforrtbcc { get; set; } 

        [JsonProperty("defaultpdftemplatequote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Defaultpdftemplatequote { get; set; } 

        [JsonProperty("defaultcurrency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Defaultcurrency { get; set; } 

        [JsonProperty("pagerdutydefaultagent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Pagerdutydefaultagent { get; set; } 

        [JsonProperty("useareasfornewbtn", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Useareasfornewbtn { get; set; } 

        [JsonProperty("showservicecataloguebuttonnewticket", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showservicecataloguebuttonnewticket { get; set; } 

        [JsonProperty("showincidentcataloguebuttonnewticket", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showincidentcataloguebuttonnewticket { get; set; } 

        [JsonProperty("enablepasswordfieldaudit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enablepasswordfieldaudit { get; set; } 

        [JsonProperty("stopnewticketsviaemailreplywithtemplate_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? StopnewticketsviaemailreplywithtemplateId { get; set; } 

        [JsonProperty("stopnewticketsviaemailreplywithtemplate_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? StopnewticketsviaemailreplywithtemplateGuid { get; set; } 

        [JsonProperty("stopnewticketsviaemailreplywithtemplate_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? StopnewticketsviaemailreplywithtemplateName { get; set; } 

        [JsonProperty("stopnewticketsviaemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Stopnewticketsviaemail { get; set; } 

        [JsonProperty("vipnoprioritychange", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Vipnoprioritychange { get; set; } 

        [JsonProperty("svcatchoosecategoryfirst", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Svcatchoosecategoryfirst { get; set; } 

        [JsonProperty("skipresolved", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Skipresolved { get; set; } 

        [JsonProperty("ninjatoplevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ninjatoplevel { get; set; } 

        [JsonProperty("ninjadefaultsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ninjadefaultsite { get; set; } 

        [JsonProperty("ninjarmmmatchname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ninjarmmmatchname { get; set; } 

        [JsonProperty("ninjarmmlocation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ninjarmmlocation { get; set; } 

        [JsonProperty("ninjarmmdefaultgroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ninjarmmdefaultgroup { get; set; } 

        [JsonProperty("ninjarmmdefaultgroup_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? NinjarmmdefaultgroupGuid { get; set; } 

        [JsonProperty("ninjarmmimporttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ninjarmmimporttype { get; set; } 

        [JsonProperty("solarwindsrmmtoplevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Solarwindsrmmtoplevel { get; set; } 

        [JsonProperty("solarwindsrmmmatchname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Solarwindsrmmmatchname { get; set; } 

        [JsonProperty("solarwindsrmmimporttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Solarwindsrmmimporttype { get; set; } 

        [JsonProperty("treecatforceleafselection", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Treecatforceleafselection { get; set; } 

        [JsonProperty("contractexpirytemplate_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ContractexpirytemplateId { get; set; } 

        [JsonProperty("contractexpirytemplate_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? ContractexpirytemplateGuid { get; set; } 

        [JsonProperty("contractexpirytemplate_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ContractexpirytemplateName { get; set; } 

        [JsonProperty("defaultpdftemplatepo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Defaultpdftemplatepo { get; set; } 

        [JsonProperty("poprefixr", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Poprefixr { get; set; } 

        [JsonProperty("poprefixo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Poprefixo { get; set; } 

        [JsonProperty("poprefixs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Poprefixs { get; set; } 

        [JsonProperty("kbsearchmode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Kbsearchmode { get; set; } 

        [JsonProperty("showDateDoneOnAptCompletionScreen", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowDateDoneOnAptCompletionScreen { get; set; } 

        [JsonProperty("removeemailfromlistonuserchange", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Removeemailfromlistonuserchange { get; set; } 

        [JsonProperty("defaultpdftemplateso", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Defaultpdftemplateso { get; set; } 

        [JsonProperty("defaultpdftemplatefault", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Defaultpdftemplatefault { get; set; } 

        [JsonProperty("sendwindowsappprintrequestonclose", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sendwindowsappprintrequestonclose { get; set; } 

        [JsonProperty("defaultpdftemplateinvoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Defaultpdftemplateinvoice { get; set; } 

        [JsonProperty("defaultpdftemplatecontract", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Defaultpdftemplatecontract { get; set; } 

        [JsonProperty("defaultpdftemplatereport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Defaultpdftemplatereport { get; set; } 

        [JsonProperty("tracksoftwarechanges", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Tracksoftwarechanges { get; set; } 

        [JsonProperty("allow_notloggedin", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowNotloggedin { get; set; } 

        [JsonProperty("allow_kbs_notloggedin", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowKbsNotloggedin { get; set; } 

        [JsonProperty("anonymoususersite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Anonymoususersite { get; set; } 

        [JsonProperty("anonymoususersite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AnonymoususersiteName { get; set; } 

        [JsonProperty("onlyShowApprovedChanges", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? OnlyShowApprovedChanges { get; set; } 

        [JsonProperty("dosearchonaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dosearchonaddress { get; set; } 

        [JsonProperty("clientMainContactCompulsary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ClientMainContactCompulsary { get; set; } 

        [JsonProperty("ignoreparentvisibilityforcustomfieldvisiblity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ignoreparentvisibilityforcustomfieldvisiblity { get; set; } 

        [JsonProperty("usescanners", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Usescanners { get; set; } 

        [JsonProperty("barcodedecoder", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Barcodedecoder { get; set; } 

        [JsonProperty("ualluse2fa", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ualluse2Fa { get; set; } 

        [JsonProperty("defaultSiteTimezone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultSiteTimezone { get; set; } 

        [JsonProperty("toggleAnnouncementIconOff", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ToggleAnnouncementIconOff { get; set; } 

        [JsonProperty("donotsendfolloweremails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Donotsendfolloweremails { get; set; } 

        [JsonProperty("donotusedynamiclistsforresponse", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Donotusedynamiclistsforresponse { get; set; } 

        [JsonProperty("prepaybalancethresholdperc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Prepaybalancethresholdperc { get; set; } 

        [JsonProperty("prepaybalancethresholdupper", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Prepaybalancethresholdupper { get; set; } 

        [JsonProperty("allow_anonymous_approvals", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowAnonymousApprovals { get; set; } 

        [JsonProperty("ncentralurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ncentralurl { get; set; } 

        [JsonProperty("ncentral_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NcentralUsername { get; set; } 

        [JsonProperty("ncentraltoplevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ncentraltoplevel { get; set; } 

        [JsonProperty("ncentralmatchname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ncentralmatchname { get; set; } 

        [JsonProperty("ncentraldefaultgroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ncentraldefaultgroup { get; set; } 

        [JsonProperty("ncentralimporttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ncentralimporttype { get; set; } 

        [JsonProperty("nableticketingusername", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Nableticketingusername { get; set; } 

        [JsonProperty("ncentral_tickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NcentralTicketType { get; set; } 

        [JsonProperty("ncentral_tickettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? NcentralTicketTypeGuid { get; set; } 

        [JsonProperty("ncentraluser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ncentraluser { get; set; } 

        [JsonProperty("ncentral_alerttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NcentralAlerttype { get; set; } 

        [JsonProperty("defaultincludegroupeditemqty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Defaultincludegroupeditemqty { get; set; } 

        [JsonProperty("defaultincludegroupeditemprice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Defaultincludegroupeditemprice { get; set; } 

        [JsonProperty("defaultincludegrouppriceandqty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Defaultincludegrouppriceandqty { get; set; } 

        [JsonProperty("callscreenallownewclientcreation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Callscreenallownewclientcreation { get; set; } 

        [JsonProperty("nextcontractref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Nextcontractref { get; set; } 

        [JsonProperty("displaycategorynoteondetailscreen", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Displaycategorynoteondetailscreen { get; set; } 

        [JsonProperty("autocreaterecurringinvoices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Autocreaterecurringinvoices { get; set; } 

        [JsonProperty("syncholidays", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Syncholidays { get; set; } 

        [JsonProperty("hideadhocitem", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hideadhocitem { get; set; } 

        [JsonProperty("enablekbmatchingforallitiltypes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enablekbmatchingforallitiltypes { get; set; } 

        [JsonProperty("allowuserapprovaldelegation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allowuserapprovaldelegation { get; set; } 

        [JsonProperty("fixedassettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Fixedassettype { get; set; } 

        [JsonProperty("fixedassettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? FixedassettypeGuid { get; set; } 

        [JsonProperty("businesscentral_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? BusinesscentralSite { get; set; } 

        [JsonProperty("enablebusinesscentralsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enablebusinesscentralsync { get; set; } 

        [JsonProperty("timesheetstepinterval", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Timesheetstepinterval { get; set; } 

        [JsonProperty("azuressoconnectionid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Azuressoconnectionid { get; set; } 

        [JsonProperty("azuressotenanttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Azuressotenanttype { get; set; } 

        [JsonProperty("showapproversthatareyettovote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowApproversthatareyettovote { get; set; } 

        [JsonProperty("onlyinformofapprovalonfinalstep", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Onlyinformofapprovalonfinalstep { get; set; } 

        [JsonProperty("alwayscheckrulesaftermerge", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Alwayscheckrulesaftermerge { get; set; } 

        [JsonProperty("checkruleswhenticketsubmitted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Checkruleswhenticketsubmitted { get; set; } 

        [JsonProperty("storeoutgoingemails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Storeoutgoingemails { get; set; } 

        [JsonProperty("enabletemplatesuggestions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabletemplatesuggestions { get; set; } 

        [JsonProperty("auto_close_send_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoCloseSendEmail { get; set; } 

        [JsonProperty("portalbackgrounddisplaymode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Portalbackgrounddisplaymode { get; set; } 

        [JsonProperty("autoaddrecurringinvoiceaftercontract", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Autoaddrecurringinvoiceaftercontract { get; set; } 

        [JsonProperty("enableinternalticketconversations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enableinternalticketconversations { get; set; } 

        [JsonProperty("internalticketconversationtickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Internalticketconversationtickettype { get; set; } 

        [JsonProperty("internalticketconversationtickettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? InternalticketconversationtickettypeGuid { get; set; } 

        [JsonProperty("enableinternalreply", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enableinternalreply { get; set; } 

        [JsonProperty("internalreplystatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Internalreplystatus { get; set; } 

        [JsonProperty("internalreplystatus_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? InternalreplystatusGuid { get; set; } 

        [JsonProperty("hidefeedback", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hidefeedback { get; set; } 

        [JsonProperty("showallservicesoption", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowAllservicesoption { get; set; } 

        [JsonProperty("ordersevbyseq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ordersevbyseq { get; set; } 

        [JsonProperty("useworkhoursforreminders", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Useworkhoursforreminders { get; set; } 

        [JsonProperty("qborealmid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Qborealmid { get; set; } 

        [JsonProperty("qbocompanyname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Qbocompanyname { get; set; } 

        [JsonProperty("qbotoplevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Qbotoplevel { get; set; } 

        [JsonProperty("qboserviceitemgroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Qboserviceitemgroup { get; set; } 

        [JsonProperty("qboinventoryitemgroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Qboinventoryitemgroup { get; set; } 

        [JsonProperty("qbocountry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Qbocountry { get; set; } 

        [JsonProperty("qbodefaultitemcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Qbodefaultitemcode { get; set; } 

        [JsonProperty("qboinvoiceemailstatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Qboinvoiceemailstatus { get; set; } 

        [JsonProperty("enableqbosync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enableqbosync { get; set; } 

        [JsonProperty("allowcodegeneration", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allowcodegeneration { get; set; } 

        [JsonProperty("googlecalendartokenexpiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Googlecalendartokenexpiry { get; set; } 

        [JsonProperty("googlecalendaraccount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Googlecalendaraccount { get; set; } 

        [JsonProperty("googleworkplaceaccount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Googleworkplaceaccount { get; set; } 

        [JsonProperty("googleworkplacereseller", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Googleworkplacereseller { get; set; } 

        [JsonProperty("googleworkplaceusermatchingfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Googleworkplaceusermatchingfields { get; set; } 

        [JsonProperty("googleworkplaceagentmatchingfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Googleworkplaceagentmatchingfields { get; set; } 

        [JsonProperty("googleworkplacemanagelicenses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Googleworkplacemanagelicenses { get; set; } 

        [JsonProperty("googleworkplacelicensedroles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Googleworkplacelicensedroles { get; set; } 

        [JsonProperty("googleworkplaceimporttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Googleworkplaceimporttype { get; set; } 

        [JsonProperty("enablegooglesso", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enablegooglesso { get; set; } 

        [JsonProperty("googlessoautoredirect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Googlessoautoredirect { get; set; } 

        [JsonProperty("googlessotype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Googlessotype { get; set; } 

        [JsonProperty("googleportalloginappname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Googleportalloginappname { get; set; } 

        [JsonProperty("allowlogonbehalfof", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Allowlogonbehalfof { get; set; } 

        [JsonProperty("nhserverversionused", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Nhserverversionused { get; set; } 

        [JsonProperty("disableStartTargetDateTimeAdjustements", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DisableStartTargetDateTimeAdjustements { get; set; } 

        [JsonProperty("ticketstatusafterquoteaccepted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ticketstatusafterquoteaccepted { get; set; } 

        [JsonProperty("ticketstatusafterquoteaccepted_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? TicketstatusafterquoteacceptedGuid { get; set; } 

        [JsonProperty("ticketstatusafterquoterejected", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ticketstatusafterquoterejected { get; set; } 

        [JsonProperty("ticketstatusafterquoterejected_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? TicketstatusafterquoterejectedGuid { get; set; } 

        [JsonProperty("loadimagesfromapi", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Loadimagesfromapi { get; set; } 

        [JsonProperty("centrify_clientid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CentrifyClientid { get; set; } 

        [JsonProperty("centrify_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CentrifyUrl { get; set; } 

        [JsonProperty("centrify_applicationid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CentrifyApplicationid { get; set; } 

        [JsonProperty("centrify_ssotype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CentrifySsotype { get; set; } 

        [JsonProperty("centrify_autoredirect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? CentrifyAutoredirect { get; set; } 

        [JsonProperty("hide2fadontshowagain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hide2Fadontshowagain { get; set; } 

        [JsonProperty("choosedefaultcontractfrombillingdescription", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Choosedefaultcontractfrombillingdescription { get; set; } 

        [JsonProperty("enablearticlesuggestionsoneup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enablearticlesuggestionsoneup { get; set; } 

        [JsonProperty("allowsitesassetseup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allowsitesassetseup { get; set; } 

        [JsonProperty("ruletickettypemandatory", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ruletickettypemandatory { get; set; } 

        [JsonProperty("enablekbarticleversioning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enablekbarticleversioning { get; set; } 

        [JsonProperty("useagentdefaultrateonlogtime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Useagentdefaultrateonlogtime { get; set; } 

        [JsonProperty("autogenerate_accountsid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutogenerateAccountsid { get; set; } 

        [JsonProperty("item_default_sales_nominal_code_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ItemDefaultSalesNominalCodeId { get; set; } 

        [JsonProperty("item_default_purchase_nominal_code_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ItemDefaultPurchaseNominalCodeId { get; set; } 

        [JsonProperty("item_default_asset_account_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ItemDefaultAssetAccountId { get; set; } 

        [JsonProperty("show_accounts_success_message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowAccountsSuccessMessage { get; set; } 

        [JsonProperty("donotalloweditingpostedinvoices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Donotalloweditingpostedinvoices { get; set; } 

        [JsonProperty("enablekbreview", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enablekbreview { get; set; } 

        [JsonProperty("defaultnumberofdaysbetweenkbreviews", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Defaultnumberofdaysbetweenkbreviews { get; set; } 

        [JsonProperty("trackkbsearches", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Trackkbsearches { get; set; } 

        [JsonProperty("createemailactionsviawebapp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Createemailactionsviawebapp { get; set; } 

        [JsonProperty("portalhomescreenservicedisplaytype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Portalhomescreenservicedisplaytype { get; set; } 

        [JsonProperty("groupallinvoicetypes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Groupallinvoicetypes { get; set; } 

        [JsonProperty("contractselectionincluderecentrenew", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Contractselectionincluderecentrenew { get; set; } 

        [JsonProperty("defaultProblemTypeID", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultProblemTypeId { get; set; } 

        [JsonProperty("lmirescueurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Lmirescueurl { get; set; } 

        [JsonProperty("trackstock", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Trackstock { get; set; } 

        [JsonProperty("stockserialisationtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Stockserialisationtype { get; set; } 

        [JsonProperty("autocreateserialisedassets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Autocreateserialisedassets { get; set; } 

        [JsonProperty("enablenewsarticles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enablenewsarticles { get; set; } 

        [JsonProperty("usepdftemplatesforscheduledreports", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Usepdftemplatesforscheduledreports { get; set; } 

        [JsonProperty("onlyrouteemailtoexistingticketifsamemailbox", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Onlyrouteemailtoexistingticketifsamemailbox { get; set; } 

        [JsonProperty("xerodefaulttenantid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Xerodefaulttenantid { get; set; } 

        [JsonProperty("salesorderlinedescriptionwhencreatedfromquotation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Salesorderlinedescriptionwhencreatedfromquotation { get; set; } 

        [JsonProperty("allowapplytemplatetoexistingticket", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allowapplytemplatetoexistingticket { get; set; } 

        [JsonProperty("defaultstocklocation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Defaultstocklocation { get; set; } 

        [JsonProperty("mustconsignorderstoinvoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Mustconsignorderstoinvoice { get; set; } 

        [JsonProperty("mailboxsmtpforprojectschedule", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Mailboxsmtpforprojectschedule { get; set; } 

        [JsonProperty("mailboxsmtpforcontractschedule", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Mailboxsmtpforcontractschedule { get; set; } 

        [JsonProperty("rusesageso", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Rusesageso { get; set; } 

        [JsonProperty("rsyncinvoices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Rsyncinvoices { get; set; } 

        [JsonProperty("updateemaillists", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Updateemaillists { get; set; } 

        [JsonProperty("contractexpirydays2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Contractexpirydays2 { get; set; } 

        [JsonProperty("contractexpirydays3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Contractexpirydays3 { get; set; } 

        [JsonProperty("datto_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DattoUrl { get; set; } 

        [JsonProperty("datto_clientid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DattoClientid { get; set; } 

        [JsonProperty("invoicecsvlocation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Invoicecsvlocation { get; set; } 

        [JsonProperty("svsearchmode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Svsearchmode { get; set; } 

        [JsonProperty("defaultcurrencycode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Defaultcurrencycode { get; set; } 

        [JsonProperty("sendfollowernotifications", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sendfollowernotifications { get; set; } 

        [JsonProperty("matchemailsonsubjectandfrom", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Matchemailsonsubjectandfrom { get; set; } 

        [JsonProperty("myfollowertickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Myfollowertickets { get; set; } 

        [JsonProperty("mandatoryrejectcomment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Mandatoryrejectcomment { get; set; } 

        [JsonProperty("kaseya_toplevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? KaseyaToplevel { get; set; } 

        [JsonProperty("googlenewmethod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Googlenewmethod { get; set; } 

        [JsonProperty("integrationuserbatch", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Integrationuserbatch { get; set; } 

        [JsonProperty("serviceaddsareanote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Serviceaddsareanote { get; set; } 

        [JsonProperty("linkcallstoexistingtickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Linkcallstoexistingtickets { get; set; } 

        [JsonProperty("showpopupforvip", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showpopupforvip { get; set; } 

        [JsonProperty("hidesiteoncontract", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hidesiteoncontract { get; set; } 

        [JsonProperty("removezeroquantitylines", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Removezeroquantitylines { get; set; } 

        [JsonProperty("showkbviewsinuseractivity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showkbviewsinuseractivity { get; set; } 

        [JsonProperty("overduetype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Overduetype { get; set; } 

        [JsonProperty("overduetype2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Overduetype2 { get; set; } 

        [JsonProperty("prevent_stopped_ticket_creation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? PreventStoppedTicketCreation { get; set; } 

        [JsonProperty("auto_reply_dont_update", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoReplyDontUpdate { get; set; } 

        [JsonProperty("quote_auto_expiry_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? QuoteAutoExpiryStatus { get; set; } 

        [JsonProperty("include_no_time_in_review", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeNoTimeInReview { get; set; } 

        [JsonProperty("match_ninja_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? MatchNinjaField { get; set; } 

        [JsonProperty("hide_opps_treeview_menu", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HideOppsTreeviewMenu { get; set; } 

        [JsonProperty("westcoast_delete_licences", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? WestcoastDeleteLicences { get; set; } 

        [JsonProperty("defaultconsigmentuser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Defaultconsigmentuser { get; set; } 

        [JsonProperty("show_timezone_input", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowTimezoneInput { get; set; } 

        [JsonProperty("default_appointment_agent_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultAppointmentAgentStatus { get; set; } 

        [JsonProperty("prorata_user_line_description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ProrataUserLineDescription { get; set; } 

        [JsonProperty("prorata_device_line_description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ProrataDeviceLineDescription { get; set; } 

        [JsonProperty("prorata_licence_line_description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ProrataLicenceLineDescription { get; set; } 

        [JsonProperty("default_quote_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultQuoteStatus { get; set; } 

        [JsonProperty("default_quote_sent_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultQuoteSentStatus { get; set; } 

        [JsonProperty("default_quote_accepted_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultQuoteAcceptedStatus { get; set; } 

        [JsonProperty("default_quote_rejected_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultQuoteRejectedStatus { get; set; } 

        [JsonProperty("useticketquoteapprovals", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Useticketquoteapprovals { get; set; } 

        [JsonProperty("trustpilot_allowwebhooks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? TrustpilotAllowwebhooks { get; set; } 

        [JsonProperty("trustpilot_reviewthreshold", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TrustpilotReviewthreshold { get; set; } 

        [JsonProperty("trustpilot_tickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TrustpilotTicketType { get; set; } 

        [JsonProperty("trustpilot_autoreply", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? TrustpilotAutoreply { get; set; } 

        [JsonProperty("trustpilot_autoreplythreshold", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TrustpilotAutoreplythreshold { get; set; } 

        [JsonProperty("trustpilot_enablesurveys", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? TrustpilotEnablesurveys { get; set; } 

        [JsonProperty("trustpilot_defaultusersite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TrustpilotDefaultusersite { get; set; } 

        [JsonProperty("trustpilot_statusafterupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TrustpilotStatusafterupdate { get; set; } 

        [JsonProperty("xero_default_creditnote_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? XeroDefaultCreditnoteStatus { get; set; } 

        [JsonProperty("xero_default_creditnote_line_tax", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? XeroDefaultCreditnoteLineTax { get; set; } 

        [JsonProperty("enablehighcontrastportal", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enablehighcontrastportal { get; set; } 

        [JsonProperty("datepickermodal", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Datepickermodal { get; set; } 

        [JsonProperty("disablehalologinwithssoautoredirect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Disablehalologinwithssoautoredirect { get; set; } 

        [JsonProperty("accountemailpwdchange", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Accountemailpwdchange { get; set; } 

        [JsonProperty("accountemail2faon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Accountemail2Faon { get; set; } 

        [JsonProperty("accountemail2faoff", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Accountemail2Faoff { get; set; } 

        [JsonProperty("accountemailauthenticatoron", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Accountemailauthenticatoron { get; set; } 

        [JsonProperty("accountemailauthenticatoroff", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Accountemailauthenticatoroff { get; set; } 

        [JsonProperty("accountemailemailaddresschange", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Accountemailemailaddresschange { get; set; } 

        [JsonProperty("accountemailusernamechange", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Accountemailusernamechange { get; set; } 

        [JsonProperty("syncinvoicetoaccountspackagewhenapproved", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Syncinvoicetoaccountspackagewhenapproved { get; set; } 

        [JsonProperty("syncpotoaccountspackagewhenapproved", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Syncpotoaccountspackagewhenapproved { get; set; } 

        [JsonProperty("allowusereditoptionallines", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allowusereditoptionallines { get; set; } 

        [JsonProperty("supplier_permission_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SupplierPermissionType { get; set; } 

        [JsonProperty("cognigy_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CognigyUrl { get; set; } 

        [JsonProperty("show_user_searchbar", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowUserSearchbar { get; set; } 

        [JsonProperty("bulkemailbatchsize", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Bulkemailbatchsize { get; set; } 

        [JsonProperty("addtional_agent_notifications", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AddtionalAgentNotifications { get; set; } 

        [JsonProperty("hide_expired_quotes_portal", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HideExpiredQuotesPortal { get; set; } 

        [JsonProperty("default_add_all_group_items_quote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DefaultAddAllGroupItemsQuote { get; set; } 

        [JsonProperty("dbconntype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Dbconntype { get; set; } 

        [JsonProperty("postgreslanguage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Postgreslanguage { get; set; } 

        [JsonProperty("link_to_confluence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? LinkToConfluence { get; set; } 

        [JsonProperty("defaultdevicepdftemplate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Defaultdevicepdftemplate { get; set; } 

        [JsonProperty("splitchannels", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Splitchannels { get; set; } 

        [JsonProperty("enableagentreactions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enableagentreactions { get; set; } 

        [JsonProperty("useiframesforhtml", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Useiframesforhtml { get; set; } 

        [JsonProperty("useiframesforhtml2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Useiframesforhtml2 { get; set; } 

        [JsonProperty("darkthemenotedisplay", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Darkthemenotedisplay { get; set; } 

        [JsonProperty("call_matching_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CallMatchingField { get; set; } 

        [JsonProperty("automate_import_software", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutomateImportSoftware { get; set; } 

        [JsonProperty("ignore_special_characters_asset_matching", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IgnoreSpecialCharactersAssetMatching { get; set; } 

        [JsonProperty("assign_sales_order_to_creator", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AssignSalesOrderToCreator { get; set; } 

        [JsonProperty("only_send_posted_invoices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? OnlySendPostedInvoices { get; set; } 

        [JsonProperty("stock_return_removes_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? StockReturnRemovesUser { get; set; } 

        [JsonProperty("azure_use_oid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AzureUseOid { get; set; } 

        [JsonProperty("add_serialized_to_ticket", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AddSerializedToTicket { get; set; } 

        [JsonProperty("recalcbillingfaultcontractchange", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Recalcbillingfaultcontractchange { get; set; } 

        [JsonProperty("exclude_apionly_informownertech", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ExcludeApionlyInformownertech { get; set; } 

        [JsonProperty("lastdailytaskdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Lastdailytaskdate { get; set; } 

        [JsonProperty("etilize_item_group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? EtilizeItemGroup { get; set; } 

        [JsonProperty("zabbix_enable_alerting", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ZabbixEnableAlerting { get; set; } 

        [JsonProperty("zabbix_alert_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ZabbixAlertType { get; set; } 

        [JsonProperty("zabbix_alert_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ZabbixAlertUser { get; set; } 

        [JsonProperty("gw_dont_update_sites", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? GwDontUpdateSites { get; set; } 

        [JsonProperty("generate_id_per_invoice_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? GenerateIdPerInvoiceType { get; set; } 

        [JsonProperty("embeddings_use_trial_data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EmbeddingsUseTrialData { get; set; } 

        [JsonProperty("connectwise_rmm_enable_alerting", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ConnectwiseRmmEnableAlerting { get; set; } 

        [JsonProperty("connectwise_rmm_alert_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ConnectwiseRmmAlertType { get; set; } 

        [JsonProperty("connectwise_rmm_alert_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ConnectwiseRmmAlertUser { get; set; } 

        [JsonProperty("amazon_seller_create_users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AmazonSellerCreateUsers { get; set; } 

        [JsonProperty("amazon_seller_default_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AmazonSellerDefaultSite { get; set; } 

        [JsonProperty("allowpdfcustomisation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allowpdfcustomisation { get; set; } 

        [JsonProperty("ninja_user_matching_custom_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NinjaUserMatchingCustomField { get; set; } 

        [JsonProperty("tracelevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Tracelevel { get; set; } 

        [JsonProperty("sales_order_project_linking_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SalesOrderProjectLinkingType { get; set; } 

        [JsonProperty("enable_suggestions_on_call", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableSuggestionsOnCall { get; set; } 

        [JsonProperty("assetdiscovery_connection_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AssetdiscoveryConnectionType { get; set; } 

        [JsonProperty("assetdiscovery_user_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AssetdiscoveryUserField { get; set; } 

        [JsonProperty("show_payment_data_on_portal", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowPaymentDataOnPortal { get; set; } 

        [JsonProperty("useintellisenseclientcache", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Useintellisenseclientcache { get; set; } 

        [JsonProperty("allow_quote_pdf_before_approval", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowQuotePdfBeforeApproval { get; set; } 

        [JsonProperty("stopbackgroundservices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Stopbackgroundservices { get; set; } 

        [JsonProperty("trace_level_reset_days", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TraceLevelResetDays { get; set; } 

        [JsonProperty("trace_level_reset_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? TraceLevelResetDate { get; set; } 

        [JsonProperty("incoming_unmatched_users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? IncomingUnmatchedUsers { get; set; } 

        [JsonProperty("incoming_default_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? IncomingDefaultUser { get; set; } 

        [JsonProperty("incoming_newuser_default_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? IncomingNewuserDefaultSite { get; set; } 

        [JsonProperty("incoming_newuser_send_welcome_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncomingNewuserSendWelcomeEmail { get; set; } 

        [JsonProperty("incoming_newuser_send_ack", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncomingNewuserSendAck { get; set; } 

        [JsonProperty("showbilling_plan_text_on_ticket", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowbillingPlanTextOnTicket { get; set; } 

        [JsonProperty("itquoter_application_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ItquoterApplicationUrl { get; set; } 

        [JsonProperty("itquoter_view_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ItquoterViewUrl { get; set; } 

        [JsonProperty("many_to_many_related_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ManyToManyRelatedTickets { get; set; } 

        [JsonProperty("enabletsapprovals", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabletsapprovals { get; set; } 

        [JsonProperty("logic_monitor_cleared_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LogicMonitorClearedStatus { get; set; } 

        [JsonProperty("prometheus_defaultsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PrometheusDefaultsite { get; set; } 

        [JsonProperty("prometheus_asset_type_choice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PrometheusAssetTypeChoice { get; set; } 

        [JsonProperty("prometheus_defaultassettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PrometheusDefaultassettype { get; set; } 

        [JsonProperty("prometheus_assettypefield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PrometheusAssetTypefield { get; set; } 

        [JsonProperty("prometheus_defaultgroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PrometheusDefaultgroup { get; set; } 

        [JsonProperty("prometheus_enable_alerting", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? PrometheusEnableAlerting { get; set; } 

        [JsonProperty("prometheus_alerting_tickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PrometheusAlertingTicketType { get; set; } 

        [JsonProperty("prometheus_alerting_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PrometheusAlertingUser { get; set; } 

        [JsonProperty("prometheus_deactivate_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? PrometheusDeactivateDevices { get; set; } 

        [JsonProperty("default_fortnox_tenant", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultFortnoxTenant { get; set; } 

        [JsonProperty("newagent_apptsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewagentApptsync { get; set; } 

        [JsonProperty("lock_submitted_timesheets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? LockSubmittedTimesheets { get; set; } 

        [JsonProperty("only_invoice_approved_timesheets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? OnlyInvoiceApprovedTimesheets { get; set; } 

        [JsonProperty("reassigndropdownbehaviour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Reassigndropdownbehaviour { get; set; } 

        [JsonProperty("copy_contract_to_child_tasks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? CopyContractToChildTasks { get; set; } 

        [JsonProperty("use_subscription_status_for_invoice_line_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseSubscriptionStatusForInvoiceLineStatus { get; set; } 

        [JsonProperty("show_appointment_other1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowAppointmentOther1 { get; set; } 

        [JsonProperty("show_appointment_other2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowAppointmentOther2 { get; set; } 

        [JsonProperty("wordpress_importcategories", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? WordpressImportcategories { get; set; } 

        [JsonProperty("wordpress_defaultfaqlist", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? WordpressDefaultfaqlist { get; set; } 

        [JsonProperty("wordpress_tagtoimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? WordpressTagtoimport { get; set; } 

        [JsonProperty("atera_import_entities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AteraImportEntities { get; set; } 

        [JsonProperty("addigy_import_entities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AddigyImportEntities { get; set; } 

        [JsonProperty("comanaged_no_reassign", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ComanagedNoReassign { get; set; } 

        [JsonProperty("myobdefaulttenantid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Myobdefaulttenantid { get; set; } 

        [JsonProperty("default_alert_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultAlertTime { get; set; } 

        [JsonProperty("ticket_status_after_appointment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TicketStatusAfterAppointment { get; set; } 

        [JsonProperty("userwayaccount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Userwayaccount { get; set; } 

        [JsonProperty("checkreassignappclashes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Checkreassignappclashes { get; set; } 

        [JsonProperty("collapse_appt_filter", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? CollapseApptFilter { get; set; } 

        [JsonProperty("enable_deferred_revenue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableDeferredRevenue { get; set; } 

        [JsonProperty("deferred_revenue_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DeferredRevenueCode { get; set; } 

        [JsonProperty("deferred_revenue_client", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DeferredRevenueClient { get; set; } 

        [JsonProperty("itglue_import_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ItglueImportList { get; set; } 

        [JsonProperty("itglue_import_types", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? ItglueImportTypes { get; set; } 

        [JsonProperty("childticketsdisplay", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Childticketsdisplay { get; set; } 

        [JsonProperty("childticketsdisplaysize", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Childticketsdisplaysize { get; set; } 

        [JsonProperty("newticketdisplay", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewTicketdisplay { get; set; } 

        [JsonProperty("auto_link_so_proj_contract", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoLinkSoProjContract { get; set; } 

        [JsonProperty("google_reviewthreshold", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? GoogleReviewthreshold { get; set; } 

        [JsonProperty("google_reviewtickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? GoogleReviewtickettype { get; set; } 

        [JsonProperty("google_questiontickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? GoogleQuestiontickettype { get; set; } 

        [JsonProperty("google_reviewdefaultusersite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? GoogleReviewdefaultusersite { get; set; } 

        [JsonProperty("google_questiondefaultusersite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? GoogleQuestiondefaultusersite { get; set; } 

        [JsonProperty("google_reviewstatusafterupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? GoogleReviewstatusafterupdate { get; set; } 

        [JsonProperty("google_questionstatusafterupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? GoogleQuestionstatusafterupdate { get; set; } 

        [JsonProperty("default_columns_id_supplier_contracts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultColumnsIdSupplierContracts { get; set; } 

        [JsonProperty("default_columns_id_supplier_contracts_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? DefaultColumnsIdSupplierContractsGuid { get; set; } 

        [JsonProperty("enablefilescanning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enablefilescanning { get; set; } 

        [JsonProperty("enableclientsideuploads", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enableclientsideuploads { get; set; } 

        [JsonProperty("allow_link_attachments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowLinkAttachments { get; set; } 

        [JsonProperty("attachment_details_upload", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AttachmentDetailsUpload { get; set; } 

        [JsonProperty("sync_servicenow_attachments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SyncServicenowAttachments { get; set; } 

        [JsonProperty("ninja_import_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NinjaImportList { get; set; } 

        [JsonProperty("ninja_import_types", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? NinjaImportTypes { get; set; } 

        [JsonProperty("intacct_use_halo_creds", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IntacctUseHaloCreds { get; set; } 

        [JsonProperty("show_whatsapp_settings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowWhatsappSettings { get; set; } 

        [JsonProperty("enable_auto_anonuser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableAutoAnonuser { get; set; } 

        [JsonProperty("days_until_anonuser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DaysUntilAnonuser { get; set; } 

        [JsonProperty("create_credit_notes_with_negative_price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? CreateCreditNotesWithNegativePrice { get; set; } 

        [JsonProperty("always_display_halo_ihid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AlwaysDisplayHaloIhid { get; set; } 

        [JsonProperty("customise_multiple_portals", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? CustomiseMultiplePortals { get; set; } 

        [JsonProperty("show_bundled_sales_order_lines", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowBundledSalesOrderLines { get; set; } 

        [JsonProperty("set_appointment_from_estimate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SetAppointmentFromEstimate { get; set; } 

        [JsonProperty("override_locale", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? OverrideLocale { get; set; } 

        [JsonProperty("vector_score_minimum", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? VectorScoreMinimum { get; set; } 

        [JsonProperty("vector_score_knowledge_minimum", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? VectorScoreKnowledgeMinimum { get; set; } 

        [JsonProperty("vector_category2_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? VectorCategory2Type { get; set; } 

        [JsonProperty("show_review_on_billing_screen", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowReviewOnBillingScreen { get; set; } 

        [JsonProperty("default_view_assets_selectedid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultViewAssetsSelectedid { get; set; } 

        [JsonProperty("default_list_assets_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? DefaultListAssetsGuid { get; set; } 

        [JsonProperty("logicmonitor_alerting_assetidentifier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LogicmonitorAlertingAssetidentifier { get; set; } 

        [JsonProperty("project_notes_tab_display", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ProjectNotesTabDisplay { get; set; } 

        [JsonProperty("send_timesheet_rejection_emails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SendTimesheetRejectionEmails { get; set; } 

        [JsonProperty("dont_show_empty_stock_locations_on_consign", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DontShowEmptyStockLocationsOnConsign { get; set; } 

        [JsonProperty("teams_chat_management", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? TeamsChatManagement { get; set; } 

        [JsonProperty("teams_azure_authority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TeamsAzureAuthority { get; set; } 

        [JsonProperty("teams_chat_default_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TeamsChatDefaultName { get; set; } 

        [JsonProperty("teams_connected_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TeamsConnectedUser { get; set; } 

        [JsonProperty("teams_connected_user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TeamsConnectedUserId { get; set; } 

        [JsonProperty("teams_connected_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TeamsConnectedUserName { get; set; } 

        [JsonProperty("default_quote_ticket_approval", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultQuoteTicketApproval { get; set; } 

        [JsonProperty("only_quote_ticket_approval", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? OnlyQuoteTicketApproval { get; set; } 

        [JsonProperty("show_currency_conversion_for_quote_lines", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowCurrencyConversionForQuoteLines { get; set; } 

        [JsonProperty("update_first_action_details_via_template", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UpdateFirstActionDetailsViaTemplate { get; set; } 

        [JsonProperty("unlink_ticket_advanced_edit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UnlinkTicketAdvancedEdit { get; set; } 

        [JsonProperty("showseperateresolutionandfixbars", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showseperateresolutionandfixbars { get; set; } 

        [JsonProperty("bigpanda_tickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? BigpandaTicketType { get; set; } 

        [JsonProperty("bigpanda_asset_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? BigpandaAssetList { get; set; } 

        [JsonProperty("google_cal_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? GoogleCalMethod { get; set; } 

        [JsonProperty("google_import_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? GoogleImportType { get; set; } 

        [JsonProperty("accent_insensitive_search", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AccentInsensitiveSearch { get; set; } 

        [JsonProperty("azure_single_logout", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AzureSingleLogout { get; set; } 

        [JsonProperty("okta_single_logout", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? OktaSingleLogout { get; set; } 

        [JsonProperty("google_single_logout", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? GoogleSingleLogout { get; set; } 

        [JsonProperty("default_salesorder_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultSalesorderStatus { get; set; } 

        [JsonProperty("use_default_call_summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseDefaultCallSummary { get; set; } 

        [JsonProperty("show_quote_approval_signature", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowQuoteApprovalSignature { get; set; } 

        [JsonProperty("update_respond_by_date_with_hold_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UpdateRespondByDateWithHoldTime { get; set; } 

        [JsonProperty("giacom_use_new_endpoint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? GiacomUseNewEndpoint { get; set; } 

        [JsonProperty("dattormm_alert_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DattormmAlertUser { get; set; } 

        [JsonProperty("invoice_minimum_item_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? InvoiceMinimumItemId { get; set; } 

        [JsonProperty("dattormm_webhook_ticket_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DattormmWebhookTicketType { get; set; } 

        [JsonProperty("appt_import_agent_identifier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ApptImportAgentIdentifier { get; set; } 

        [JsonProperty("appt_import_user_identifier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ApptImportUserIdentifier { get; set; } 

        [JsonProperty("planning_green_colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PlanningGreenColour { get; set; } 

        [JsonProperty("planning_orange_colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PlanningOrangeColour { get; set; } 

        [JsonProperty("planning_red_colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PlanningRedColour { get; set; } 

        [JsonProperty("crmshowsatisfaction", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Crmshowsatisfaction { get; set; } 

        [JsonProperty("update_milestone_dates_via_tasks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UpdateMilestoneDatesViaTasks { get; set; } 

        [JsonProperty("hide_unknown_software_from_lists", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HideUnknownSoftwareFromLists { get; set; } 

        [JsonProperty("wordpressorg_importcategories", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? WordpressorgImportcategories { get; set; } 

        [JsonProperty("wordpressorg_defaultfaqlist", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? WordpressorgDefaultfaqlist { get; set; } 

        [JsonProperty("only_show_needs_order_lines_when_supplier_set", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? OnlyShowNeedsOrderLinesWhenSupplierSet { get; set; } 

        [JsonProperty("show_attachments_from_linked_quote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowAttachmentsFromLinkedQuote { get; set; } 

        [JsonProperty("show_attachments_from_linked_so", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowAttachmentsFromLinkedSo { get; set; } 

        [JsonProperty("allow_sla_target_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowSlaTargetOverride { get; set; } 

        [JsonProperty("show_invoice_totals_on_portal", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowInvoiceTotalsOnPortal { get; set; } 

        [JsonProperty("show_all_sites_for_device_quantity_calc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowAllSitesForDeviceQuantityCalc { get; set; } 

        [JsonProperty("user_portal_theme", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? UserPortalTheme { get; set; } 

        [JsonProperty("prometheus_create_devices_from_webhooks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? PrometheusCreateDevicesFromWebhooks { get; set; } 

        [JsonProperty("prometheus_api_urls", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PrometheusApiUrls { get; set; } 

        [JsonProperty("allow_followers_modify_ticket", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowFollowersModifyTicket { get; set; } 

        [JsonProperty("gocardless_companyname_matching", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? GocardlessCompanynameMatching { get; set; } 

        [JsonProperty("gocardless_defaultsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? GocardlessDefaultsite { get; set; } 

        [JsonProperty("gocardless_use_sandbox", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? GocardlessUseSandbox { get; set; } 

        [JsonProperty("show_lang_navbar", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowLangNavbar { get; set; } 

        [JsonProperty("sync_salesforce_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SyncSalesforceStatus { get; set; } 

        [JsonProperty("agreement_default_billing_period", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AgreementDefaultBillingPeriod { get; set; } 

        [JsonProperty("show_contributor_quality", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowContributorQuality { get; set; } 

        [JsonProperty("show_holiday_timesheet", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowHolidayTimesheet { get; set; } 

        [JsonProperty("reply_outcome", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ReplyOutcome { get; set; } 

        [JsonProperty("round_labour_invoice_quantity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? RoundLabourInvoiceQuantity { get; set; } 

        [JsonProperty("import_pax8_usage_lines", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ImportPax8UsageLines { get; set; } 

        [JsonProperty("related_assets_column_profile", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? RelatedAssetsColumnProfile { get; set; } 

        [JsonProperty("showusersassetsonnewticket", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showusersassetsonnewticket { get; set; } 

        [JsonProperty("auto_approve_pos", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoApprovePos { get; set; } 

        [JsonProperty("mark_notifications_as_done_before_deleting", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? MarkNotificationsAsDoneBeforeDeleting { get; set; } 

        [JsonProperty("track_category_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? TrackCategoryId { get; set; } 

        [JsonProperty("show_auto_payment_on_portal", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ShowAutoPaymentOnPortal { get; set; } 

        [JsonProperty("include_bundled_lines_for_recurring_invoices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeBundledLinesForRecurringInvoices { get; set; } 

        [JsonProperty("default_avalara_tenant", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultAvalaraTenant { get; set; } 

        [JsonProperty("default_meter_pricing_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultMeterPricingMethod { get; set; } 

        [JsonProperty("logicmonitor_asset_type_choice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LogicmonitorAssetTypeChoice { get; set; } 

        [JsonProperty("logicmonitor_assettypefield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LogicmonitorAssetTypefield { get; set; } 

        [JsonProperty("logicmonitor_defaultgroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LogicmonitorDefaultgroup { get; set; } 

        [JsonProperty("show_note_after_completed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowNoteAfterCompleted { get; set; } 

        [JsonProperty("use_halo_invoice_id_for_pdf", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseHaloInvoiceIdForPdf { get; set; } 

        [JsonProperty("stripe_send_recipient_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? StripeSendRecipientEmail { get; set; } 

        [JsonProperty("meraki_top_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MerakiTopLevel { get; set; } 

        [JsonProperty("meraki_asset_type_choice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MerakiAssetTypeChoice { get; set; } 

        [JsonProperty("merakidefaultassettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Merakidefaultassettype { get; set; } 

        [JsonProperty("merakiassettypefield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Merakiassettypefield { get; set; } 

        [JsonProperty("meraki_defaultgroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MerakiDefaultgroup { get; set; } 

        [JsonProperty("meraki_defaultgroup_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? MerakiDefaultgroupGuid { get; set; } 

        [JsonProperty("lapsafe_default_installation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? LapsafeDefaultInstallation { get; set; } 

        [JsonProperty("lapsafe_default_bay_size", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LapsafeDefaultBaySize { get; set; } 

        [JsonProperty("lapsafe_default_expiry_hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LapsafeDefaultExpiryHours { get; set; } 

        [JsonProperty("lapsafe_status_after_webhook", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LapsafeStatusAfterWebhook { get; set; } 

        [JsonProperty("lapsafe_status_after_webhook_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? LapsafeStatusAfterWebhookGuid { get; set; } 

        [JsonProperty("lapsafedefaultdropoffemailtemplate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Lapsafedefaultdropoffemailtemplate { get; set; } 

        [JsonProperty("lapsafedefaultdropoffemailtemplate_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? LapsafedefaultdropoffemailtemplateGuid { get; set; } 

        [JsonProperty("lapsafedefaultcollectionemailtemplate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Lapsafedefaultcollectionemailtemplate { get; set; } 

        [JsonProperty("lapsafedefaultcollectionemailtemplate_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? LapsafedefaultcollectionemailtemplateGuid { get; set; } 

        [JsonProperty("zabbix_dont_close_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ZabbixDontCloseTickets { get; set; } 

        [JsonProperty("warn_customtable_delete", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? WarnCustomtableDelete { get; set; } 

        [JsonProperty("ai_thankyou_detection", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AiThankyouDetection { get; set; } 

        [JsonProperty("techdata_default_tenant", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TechdataDefaultTenant { get; set; } 

        [JsonProperty("ingram_default_tenant", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? IngramDefaultTenant { get; set; } 

        [JsonProperty("credit_item", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CreditItem { get; set; } 

        [JsonProperty("itglue_sync_entities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ItglueSyncEntities { get; set; } 

        [JsonProperty("itglue_show_message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ItglueShowMessage { get; set; } 

        [JsonProperty("slack_channel_management", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SlackChannelManagement { get; set; } 

        [JsonProperty("slack_channel_default_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SlackChannelDefaultName { get; set; } 

        [JsonProperty("slack_channel_access_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SlackChannelAccessType { get; set; } 

        [JsonProperty("hide_text_override_service", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HideTextOverrideService { get; set; } 

        [JsonProperty("nextfaultidcalculationmethod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Nextfaultidcalculationmethod { get; set; } 

        [JsonProperty("taskmonitorsnoozeseverity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Taskmonitorsnoozeseverity { get; set; } 

        [JsonProperty("taskmonitorsnoozedate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Taskmonitorsnoozedate { get; set; } 

        [JsonProperty("slack_channel_workspace", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SlackChannelWorkspace { get; set; } 

        [JsonProperty("slack_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SlackClientId { get; set; } 

        [JsonProperty("slack_action_outcome", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SlackActionOutcome { get; set; } 

        [JsonProperty("slack_command_ticket_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SlackCommandTicketType { get; set; } 

        [JsonProperty("slack_command_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SlackCommandUser { get; set; } 

        [JsonProperty("quote_expiry_ticket_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? QuoteExpiryTicketStatus { get; set; } 

        [JsonProperty("default_online_report_group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultOnlineReportGroup { get; set; } 

        [JsonProperty("new_cf_storage_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? NewCfStorageMethod { get; set; } 

        [JsonProperty("default_for_action_reviewed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DefaultForActionReviewed { get; set; } 

        [JsonProperty("ticket_info_display_top", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? TicketInfoDisplayTop { get; set; } 

        [JsonProperty("sla_bar_time_display", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SlaBarTimeDisplay { get; set; } 

        [JsonProperty("assign_sales_order", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AssignSalesOrder { get; set; } 

        [JsonProperty("sync_customers_to_stripe", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SyncCustomersToStripe { get; set; } 

        [JsonProperty("show_accept_reject_all", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowAcceptRejectAll { get; set; } 

        [JsonProperty("disable_edit_kb_fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DisableEditKbFields { get; set; } 

        [JsonProperty("workflow_progress_display_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? WorkflowProgressDisplayType { get; set; } 

        [JsonProperty("showclosureattachment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowClosureattachment { get; set; } 

        [JsonProperty("defaultinvoicedatetotoday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Defaultinvoicedatetotoday { get; set; } 

        [JsonProperty("user_match_phonenumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UserMatchPhonenumber { get; set; } 

        [JsonProperty("parent_and_related_cf_copy_priority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ParentAndRelatedCfCopyPriority { get; set; } 

        [JsonProperty("ticketstatusafterquoteinternalrejection", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ticketstatusafterquoteinternalrejection { get; set; } 

        [JsonProperty("show_child_templates_always", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowChildTemplatesAlways { get; set; } 

        [JsonProperty("whatsapp_defaultclientsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? WhatsappDefaultclientsite { get; set; } 

        [JsonProperty("xsoar_default_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? XsoarDefaultUser { get; set; } 

        [JsonProperty("xsoar_default_tickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? XsoarDefaultTicketType { get; set; } 

        [JsonProperty("use_charge_rate_item_tax", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseChargeRateItemTax { get; set; } 

        [JsonProperty("emailsendervalidation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Emailsendervalidation { get; set; } 

        [JsonProperty("2faemailallowedifnoothermethods", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _2faemailallowedifnoothermethods { get; set; } 

        [JsonProperty("useteamshifts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Useteamshifts { get; set; } 

        [JsonProperty("dynamicscrm_sitenamefilter", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DynamicscrmSitenamefilter { get; set; } 

        [JsonProperty("adobeacrobat_auto_expire_td", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AdobeacrobatAutoExpireTd { get; set; } 

        [JsonProperty("defaultadobeactenant", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Defaultadobeactenant { get; set; } 

        [JsonProperty("adobeacrobat_accept_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AdobeacrobatAcceptStatus { get; set; } 

        [JsonProperty("adobeacrobat_reject_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AdobeacrobatRejectStatus { get; set; } 

        [JsonProperty("display_ticket_workflow_on_quote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DisplayTicketWorkflowOnQuote { get; set; } 

        [JsonProperty("line_action_display_behaviour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LineActionDisplayBehaviour { get; set; } 

        [JsonProperty("hide_addr_footer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HideAddrFooter { get; set; } 

        [JsonProperty("hide_phone_footer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HidePhoneFooter { get; set; } 

        [JsonProperty("hide_email_footer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HideEmailFooter { get; set; } 

        [JsonProperty("hide_lang_footer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HideLangFooter { get; set; } 

        [JsonProperty("show_html_footer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowHtmlFooter { get; set; } 

        [JsonProperty("html_footer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HtmlFooter { get; set; } 

        [JsonProperty("adobecommercedefaultsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Adobecommercedefaultsite { get; set; } 

        [JsonProperty("adobecommerce_integratorentitiestoimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AdobecommerceIntegratorentitiestoimport { get; set; } 

        [JsonProperty("update_all_actions_when_contract_changed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UpdateAllActionsWhenContractChanged { get; set; } 

        [JsonProperty("use_new_search_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseNewSearchMethod { get; set; } 

        [JsonProperty("assetdiscovery_defaultsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AssetdiscoveryDefaultsite { get; set; } 

        [JsonProperty("assetdiscovery_defaultsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AssetdiscoveryDefaultsiteName { get; set; } 

        [JsonProperty("lansweeper_override_site_rules", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? LansweeperOverrideSiteRules { get; set; } 

        [JsonProperty("salesforce_integratorattachmentstoimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SalesforceIntegratorattachmentstoimport { get; set; } 

        [JsonProperty("defaultpdftemplatebill", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Defaultpdftemplatebill { get; set; } 

        [JsonProperty("default_filter_open_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultFilterOpenTickets { get; set; } 

        [JsonProperty("assetdateformat", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Assetdateformat { get; set; } 

        [JsonProperty("use_item_catalogue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseItemCatalogue { get; set; } 

        [JsonProperty("only_show_invoices_after_3rd_party_sync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? OnlyShowInvoicesAfter3RdPartySync { get; set; } 

        [JsonProperty("always_show_line_actions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AlwaysShowLineActions { get; set; } 

        [JsonProperty("due_date_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DueDateType { get; set; } 

        [JsonProperty("ai_connection_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AiConnectionType { get; set; } 

        [JsonProperty("enable_ai_kb_articles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableAiKbArticles { get; set; } 

        [JsonProperty("azureopenai_enable_ai_kb_articles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AzureopenaiEnableAiKbArticles { get; set; } 

        [JsonProperty("enable_openai_emotion_detection", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableOpenaiEmotionDetection { get; set; } 

        [JsonProperty("enable_azureopenai_emotion_detection", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableAzureopenaiEmotionDetection { get; set; } 

        [JsonProperty("embeddingaideployment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(50)]
        public string? Embeddingaideployment { get; set; } 

        [JsonProperty("enable_openai_insights", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableOpenaiInsights { get; set; } 

        [JsonProperty("enable_azureopenai_insights", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableAzureopenaiInsights { get; set; } 

        [JsonProperty("auto_extend_end_dates_on_recurring_invoices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoExtendEndDatesOnRecurringInvoices { get; set; } 

        [JsonProperty("portalservicedetailsdisplaytype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Portalservicedetailsdisplaytype { get; set; } 

        [JsonProperty("ticket_embeddings_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TicketEmbeddingsMethod { get; set; } 

        [JsonProperty("ticket_embeddings_db", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TicketEmbeddingsDb { get; set; } 

        [JsonProperty("ai_knowledge_search_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AiKnowledgeSearchMethod { get; set; } 

        [JsonProperty("last_day_of_month_billing", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? LastDayOfMonthBilling { get; set; } 

        [JsonProperty("use_qbo_invoice_terms", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseQboInvoiceTerms { get; set; } 

        [JsonProperty("show_status_filter", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowStatusFilter { get; set; } 

        [JsonProperty("auvik_delete_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AuvikDeleteDevices { get; set; } 

        [JsonProperty("order_teams_by_sequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? OrderTeamsBySequence { get; set; } 

        [JsonProperty("email_template_for_pending_closure", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? EmailTemplateForPendingClosure { get; set; } 

        [JsonProperty("showaccountmanageronclientdetails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowAccountmanageronclientdetails { get; set; } 

        [JsonProperty("show_asset_diagram_licences", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowAssetDiagramLicences { get; set; } 

        [JsonProperty("issue_project_non_consignable_items", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IssueProjectNonConsignableItems { get; set; } 

        [JsonProperty("ticketstatusafterquotesent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ticketstatusafterquotesent { get; set; } 

        [JsonProperty("ticketstatusafterquotesent_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? TicketstatusafterquotesentGuid { get; set; } 

        [JsonProperty("use_azure_openai_surveys", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseAzureOpenaiSurveys { get; set; } 

        [JsonProperty("use_openai_surveys", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseOpenaiSurveys { get; set; } 

        [JsonProperty("ai_survey_sample_rate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AiSurveySampleRate { get; set; } 

        [JsonProperty("default_asset_chart_relationships", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DefaultAssetChartRelationships { get; set; } 

        [JsonProperty("saml_matching_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SamlMatchingType { get; set; } 

        [JsonProperty("saml_matching_attr", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SamlMatchingAttr { get; set; } 

        [JsonProperty("freshdesk_statusfilter", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? FreshdeskStatusfilter { get; set; } 

        [JsonProperty("freshdesk_matchusername", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? FreshdeskMatchusername { get; set; } 

        [JsonProperty("enhancedAnnouncement", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnhancedAnnouncement { get; set; } 

        [JsonProperty("distributionlists_createusers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DistributionlistsCreateusers { get; set; } 

        [JsonProperty("distributionlists_defaultsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DistributionlistsDefaultsite { get; set; } 

        [JsonProperty("distributionlists_activityinuserfeed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DistributionlistsActivityinuserfeed { get; set; } 

        [JsonProperty("password_char_length", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PasswordCharLength { get; set; } 

        [JsonProperty("agent_status_for_free_appointments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AgentStatusForFreeAppointments { get; set; } 

        [JsonProperty("gw_assettype_choice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? GwAssetTypeChoice { get; set; } 

        [JsonProperty("gw_default_devicetype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? GwDefaultDevicetype { get; set; } 

        [JsonProperty("gw_mobile_site_matching", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? GwMobileSiteMatching { get; set; } 

        [JsonProperty("document_view_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DocumentViewType { get; set; } 

        [JsonProperty("quote_any_line_profit_for_approval_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? QuoteAnyLineProfitForApprovalType { get; set; } 

        [JsonProperty("quote_any_line_profit_for_approval_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? QuoteAnyLineProfitForApprovalValue { get; set; } 

        [JsonProperty("quote_average_profit_for_approval_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? QuoteAverageProfitForApprovalType { get; set; } 

        [JsonProperty("quote_average_profit_for_approval_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? QuoteAverageProfitForApprovalValue { get; set; } 

        [JsonProperty("gotoresolve_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? GotoresolveClientId { get; set; } 

        [JsonProperty("allowclientmerging", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allowclientmerging { get; set; } 

        [JsonProperty("addclientdeleteperm", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Addclientdeleteperm { get; set; } 

        [JsonProperty("only_use_out_of_hours_priority_for_user_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? OnlyUseOutOfHoursPriorityForUserTickets { get; set; } 

        [JsonProperty("allow_reponse_edit_after", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowReponseEditAfter { get; set; } 

        [JsonProperty("show_linked_articles_users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowLinkedArticlesUsers { get; set; } 

        [JsonProperty("timelineshowagentworkhours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Timelineshowagentworkhours { get; set; } 

        [JsonProperty("feedback_comment_mandatory", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? FeedbackCommentMandatory { get; set; } 

        [JsonProperty("ai_search_store_descriptions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AiSearchStoreDescriptions { get; set; } 

        [JsonProperty("textsplit_chunk_size", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TextsplitChunkSize { get; set; } 

        [JsonProperty("textsplit_chunk_overlap", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TextsplitChunkOverlap { get; set; } 

        [JsonProperty("ai_description_mapping", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AiDescriptionMapping { get; set; } 

        [JsonProperty("ai_description_mapping_custom", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(255)]
        public string? AiDescriptionMappingCustom { get; set; } 

        [JsonProperty("ai_embedding_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AiEmbeddingField { get; set; } 

        [JsonProperty("enable_purchase_currency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnablePurchaseCurrency { get; set; } 

        [JsonProperty("last_license_sync_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? LastLicenseSyncDate { get; set; } 

        [JsonProperty("show_home_html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowHomeHtml { get; set; } 

        [JsonProperty("home_html_position", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? HomeHtmlPosition { get; set; } 

        [JsonProperty("match_datto_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? MatchDattoUser { get; set; } 

        [JsonProperty("match_datto_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? MatchDattoField { get; set; } 

        [JsonProperty("datto_user_matching_custom_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DattoUserMatchingCustomField { get; set; } 

        [JsonProperty("optional_default_unchecked", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? OptionalDefaultUnchecked { get; set; } 

        [JsonProperty("prorata_default_line_description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ProrataDefaultLineDescription { get; set; } 

        [JsonProperty("ai_insights_context", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(255)]
        public string? AiInsightsContext { get; set; } 

        [JsonProperty("enable_ai_article_suggestions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableAiArticleSuggestions { get; set; } 

        [JsonProperty("ignore_visibilty_restrictions_on_action_links", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IgnoreVisibiltyRestrictionsOnActionLinks { get; set; } 

        [JsonProperty("enableoppteamscall", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enableoppteamscall { get; set; } 

        [JsonProperty("allow_kb_publishing", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowKbPublishing { get; set; } 

        [JsonProperty("hide_credit_lines_on_invoices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HideCreditLinesOnInvoices { get; set; } 

        [JsonProperty("user_match_alternative_email_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UserMatchAlternativeEmailAddress { get; set; } 

        [JsonProperty("default_site_sla", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultSiteSla { get; set; } 

        [JsonProperty("auto_submit_auto_generated_is_auto_reply", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoSubmitAutoGeneratedIsAutoReply { get; set; } 

        [JsonProperty("auto_submit_auto_replied_is_auto_reply", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoSubmitAutoRepliedIsAutoReply { get; set; } 

        [JsonProperty("default_use_linked_subscription_price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DefaultUseLinkedSubscriptionPrice { get; set; } 

        [JsonProperty("default_use_linked_subscription_cost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DefaultUseLinkedSubscriptionCost { get; set; } 

        [JsonProperty("default_item_view", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultItemView { get; set; } 

        [JsonProperty("restrict_portal_new_ticket", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? RestrictPortalNewTicket { get; set; } 

        [JsonProperty("mailchimp_integratorentitiestoimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? MailchimpIntegratorentitiestoimport { get; set; } 

        [JsonProperty("mailcampaign_activityinuserfeed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? MailcampaignActivityinuserfeed { get; set; } 

        [JsonProperty("addautosuppressheader", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Addautosuppressheader { get; set; } 

        [JsonProperty("approval_showcomment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ApprovalShowComment { get; set; } 

        [JsonProperty("enableperperiodexpirycalculation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enableperperiodexpirycalculation { get; set; } 

        [JsonProperty("show_agents_forgot_password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowAgentsForgotPassword { get; set; } 

        [JsonProperty("show_users_forgot_password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowUsersForgotPassword { get; set; } 

        [JsonProperty("lookup_search_filters", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? LookupSearchFilters { get; set; } 

        [JsonProperty("assets_show_genpdf", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AssetsShowGenpdf { get; set; } 

        [JsonProperty("allow_presence_notifications", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowPresenceNotifications { get; set; } 

        [JsonProperty("po_visible_to_users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? PoVisibleToUsers { get; set; } 

        [JsonProperty("default_columns_id_supplier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultColumnsIdSupplier { get; set; } 

        [JsonProperty("default_columns_id_supplier_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? DefaultColumnsIdSupplierGuid { get; set; } 

        [JsonProperty("problemmatchproductmatch", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Problemmatchproductmatch { get; set; } 

        [JsonProperty("icinga_assigned_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? IcingaAssignedStatus { get; set; } 

        [JsonProperty("use_purchase_order_id_for_reference", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UsePurchaseOrderIdForReference { get; set; } 

        [JsonProperty("show_res_in_desc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowResInDesc { get; set; } 

        [JsonProperty("freshdesk_action_userid_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? FreshdeskActionUseridField { get; set; } 

        [JsonProperty("update_recurring_bundle_price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? UpdateRecurringBundlePrice { get; set; } 

        [JsonProperty("sync_invoices_manually", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SyncInvoicesManually { get; set; } 

        [JsonProperty("set_accountsid_to_sku", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SetAccountsidToSku { get; set; } 

        [JsonProperty("item_sku_is_unique", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ItemSkuIsUnique { get; set; } 

        [JsonProperty("match_item_on_sku", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? MatchItemOnSku { get; set; } 

        [JsonProperty("allow_requestor_in_cab_approvals", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowRequestorInCabApprovals { get; set; } 

        [JsonProperty("meraki_import_entities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? MerakiImportEntities { get; set; } 

        [JsonProperty("group_ticket_po_creation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? GroupTicketPoCreation { get; set; } 

        [JsonProperty("show_orderlines_no_supplier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowOrderlinesNoSupplier { get; set; } 

        [JsonProperty("addigy_dont_update_device_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AddigyDontUpdateDeviceType { get; set; } 

        [JsonProperty("void_invoice_rewinds_billing_entites", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? VoidInvoiceRewindsBillingEntites { get; set; } 

        [JsonProperty("dont_show_zero_charge_rate_ready_for_invoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DontShowZeroChargeRateReadyForInvoice { get; set; } 

        [JsonProperty("supplier_currency_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SupplierCurrencyOverride { get; set; } 

        [JsonProperty("idle_session_timeout_mins_agent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? IdleSessionTimeoutMinsAgent { get; set; } 

        [JsonProperty("record_online_presence_snapshots", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? RecordOnlinePresenceSnapshots { get; set; } 

        [JsonProperty("check_same_customer_for_change_collision", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? CheckSameCustomerForChangeCollision { get; set; } 

        [JsonProperty("default_show_inactive_assets_on_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DefaultShowInactiveAssetsOnSite { get; set; } 

        [JsonProperty("showemailinuseractivity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showemailinuseractivity { get; set; } 

        [JsonProperty("po_approval_email_addr", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PoApprovalEmailAddr { get; set; } 

        [JsonProperty("show_negative_tax_invoices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowNegativeTaxInvoices { get; set; } 

        [JsonProperty("donotalloweditingpostedinvoicesfreq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Donotalloweditingpostedinvoicesfreq { get; set; } 

        [JsonProperty("default_quote_revised_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultQuoteRevisedStatus { get; set; } 

        [JsonProperty("reservedintfield1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Reservedintfield1 { get; set; } 

        [JsonProperty("nag_down_priority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NagDownPriority { get; set; } 

        [JsonProperty("nag_unreachable_priority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NagUnreachablePriority { get; set; } 

        [JsonProperty("nag_unknown_priority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NagUnknownPriority { get; set; } 

        [JsonProperty("defaultbulkdevicepdftemplate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Defaultbulkdevicepdftemplate { get; set; } 

        [JsonProperty("allow_invoice_deletion_when_sent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowInvoiceDeletionWhenSent { get; set; } 

        [JsonProperty("datadog_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DatadogUser { get; set; } 

        [JsonProperty("datadog_tickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DatadogTicketType { get; set; } 

        [JsonProperty("datadog_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DatadogUserName { get; set; } 

        [JsonProperty("truncate_salesmb_reply_chain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? TruncateSalesmbReplyChain { get; set; } 

        [JsonProperty("users_department_view_scope", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? UsersDepartmentViewScope { get; set; } 

        [JsonProperty("limit_po_stock_received", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? LimitPoStockReceived { get; set; } 

        [JsonProperty("set_budget_total_to_budget_table", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SetBudgetTotalToBudgetTable { get; set; } 

        [JsonProperty("show_favourite_services_at_start", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowFavouriteServicesAtStart { get; set; } 

        [JsonProperty("reservedboolfield1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Reservedboolfield1 { get; set; } 

        [JsonProperty("use_contract_rules", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseContractRules { get; set; } 

        [JsonProperty("contract_rules_match_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ContractRulesMatchType { get; set; } 

        [JsonProperty("snelstart_invoice_template", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SnelstartInvoiceTemplate { get; set; } 

        [JsonProperty("problemmatchcustomfield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Problemmatchcustomfield { get; set; } 

        [JsonProperty("apply_rules_on_drag_and_drop", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ApplyRulesOnDragAndDrop { get; set; } 

        [JsonProperty("open_report_without_loading", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? OpenReportWithoutLoading { get; set; } 

        [JsonProperty("show_livechat_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowLivechatUrl { get; set; } 

        [JsonProperty("category_auto_expand", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CategoryAutoExpand { get; set; } 

        [JsonProperty("hide_enddate_timezone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HideEndDateTimezone { get; set; } 

        [JsonProperty("enable_clear_nable_rmm_alert_check", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableClearNableRmmAlertCheck { get; set; } 

        [JsonProperty("show_asset_diagram_keyfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowAssetDiagramKeyfields { get; set; } 

        [JsonProperty("allowkbinfaqgroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allowkbinfaqgroup { get; set; } 

        [JsonProperty("giacomdeletelicences", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Giacomdeletelicences { get; set; } 

        [JsonProperty("apply_query_builder_perms", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ApplyQueryBuilderPerms { get; set; } 

        [JsonProperty("ai_summary_description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(255)]
        public string? AiSummaryDescription { get; set; } 

        [JsonProperty("enable_ai_conversation_summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableAiConversationSummary { get; set; } 

        [JsonProperty("ticket_hover_summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TicketHoverSummary { get; set; } 

        [JsonProperty("autogroupnewitems", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Autogroupnewitems { get; set; } 

        [JsonProperty("use_prospects", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseProspects { get; set; } 

        [JsonProperty("can_edit_sent_invoice_lines", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanEditSentInvoiceLines { get; set; } 

        [JsonProperty("defaultcontractdetailslayout", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Defaultcontractdetailslayout { get; set; } 

        [JsonProperty("allow_kb_anonymous", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowKbAnonymous { get; set; } 

        [JsonProperty("lapsafedefaultswapemailtemplate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Lapsafedefaultswapemailtemplate { get; set; } 

        [JsonProperty("lapsafedefaultswapemailtemplate_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? LapsafedefaultswapemailtemplateGuid { get; set; } 

        [JsonProperty("orion_reset_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? OrionResetStatus { get; set; } 

        [JsonProperty("access_change_calendar_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AccessChangeCalendarTickets { get; set; } 

        [JsonProperty("services_portalbackgroundimageurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(500)]
        public string? ServicesPortalbackgroundimageurl { get; set; } 

        [JsonProperty("itglue_disable_address_sync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ItglueDisableAddressSync { get; set; } 

        [JsonProperty("conversion_probability_colour1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ConversionProbabilityColour1 { get; set; } 

        [JsonProperty("conversion_probability_colour2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ConversionProbabilityColour2 { get; set; } 

        [JsonProperty("conversion_probability_colour3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ConversionProbabilityColour3 { get; set; } 

        [JsonProperty("conversion_probability_colour4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ConversionProbabilityColour4 { get; set; } 

        [JsonProperty("nextattachmentidcalculationmethod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Nextattachmentidcalculationmethod { get; set; } 

        [JsonProperty("portal_action_date_display", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PortalActionDateDisplay { get; set; } 

        [JsonProperty("show_action_date_display_toggle", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowActionDateDisplayToggle { get; set; } 

        [JsonProperty("ignore_duplicate_emails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IgnoreDuplicateEmails { get; set; } 

        [JsonProperty("hidekbviews", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hidekbviews { get; set; } 

        [JsonProperty("hidekbratings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hidekbratings { get; set; } 

        [JsonProperty("show_markup_for_sales_orders", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowMarkupForSalesOrders { get; set; } 

        [JsonProperty("ai_suggestion_alert", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AiSuggestionAlert { get; set; } 

        [JsonProperty("quotes_from_mailbox_fallback_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? QuotesFromMailboxFallbackId { get; set; } 

        [JsonProperty("matchinreplyto", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Matchinreplyto { get; set; } 

        [JsonProperty("kbfeedbacktickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Kbfeedbacktickettype { get; set; } 

        [JsonProperty("usetravelchargeratesonbpc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Usetravelchargeratesonbpc { get; set; } 

        [JsonProperty("assetimportsecondaryidentifier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Assetimportsecondaryidentifier { get; set; } 

        [JsonProperty("assetimportsecondaryidentifier_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? AssetimportsecondaryidentifierGuid { get; set; } 

        [JsonProperty("appointment_sla_procedure_mins", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AppointmentSlaProcedureMins { get; set; } 

        [JsonProperty("treat_comanaged_agent_emails_as_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? TreatComanagedAgentEmailsAsUser { get; set; } 

        [JsonProperty("gw_dont_create_new_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? GwDontCreateNewDevices { get; set; } 

        [JsonProperty("exchange_calendar_webhooks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ExchangeCalendarWebhooks { get; set; } 

        [JsonProperty("exchange_azure_authority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ExchangeAzureAuthority { get; set; } 

        [JsonProperty("exchange_use_immutable_ids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ExchangeUseImmutableIds { get; set; } 

        [JsonProperty("exchange_no_mutable_ids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ExchangeNoMutableIds { get; set; } 

        [JsonProperty("exchange_calendar_webhook_import_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ExchangeCalendarWebhookImportType { get; set; } 

        [JsonProperty("warningafterxminutes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Warningafterxminutes { get; set; } 

        [JsonProperty("use_phone_int_search", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UsePhoneIntSearch { get; set; } 

        [JsonProperty("use_xero_tracking_categories", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseXeroTrackingCategories { get; set; } 

        [JsonProperty("xero_tracking_category_1_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? XeroTrackingCategory1Name { get; set; } 

        [JsonProperty("xero_tracking_category_2_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? XeroTrackingCategory2Name { get; set; } 

        [JsonProperty("rpi_percent_increase", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? RpiPercentIncrease { get; set; } 

        [JsonProperty("google_analytics_measurement_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? GoogleAnalyticsMeasurementId { get; set; } 

        [JsonProperty("tickettimermodalpause", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Tickettimermodalpause { get; set; } 

        [JsonProperty("hubspot_item_group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? HubspotItemGroup { get; set; } 

        [JsonProperty("hubspot_deal_tickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? HubspotDealTicketType { get; set; } 

        [JsonProperty("hubspot_item_sync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? HubspotItemSync { get; set; } 

        [JsonProperty("hubspot_webhooks_products", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HubspotWebhooksProducts { get; set; } 

        [JsonProperty("hubspot_webhooks_deals", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HubspotWebhooksDeals { get; set; } 

        [JsonProperty("hubspot_webhooks_quotes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HubspotWebhooksQuotes { get; set; } 

        [JsonProperty("auto_complete_appointments_to_add_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoCompleteAppointmentsToAddTime { get; set; } 

        [JsonProperty("matched_event_retention", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MatchedEventRetention { get; set; } 

        [JsonProperty("unmatched_event_retention", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? UnmatchedEventRetention { get; set; } 

        [JsonProperty("auto_reorder_items", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoReorderItems { get; set; } 

        [JsonProperty("delivery_default", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DeliveryDefault { get; set; } 

        [JsonProperty("redact_card_details", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? RedactCardDetails { get; set; } 

        [JsonProperty("appointment_sla_procedure_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AppointmentSlaProcedureStatus { get; set; } 

        [JsonProperty("invoicesalesorderbillingdescriptionlong", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(500)]
        public string? Invoicesalesorderbillingdescriptionlong { get; set; } 

        [JsonProperty("invoicesalesorderprojectsbillingdescriptionlong", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(500)]
        public string? Invoicesalesorderprojectsbillingdescriptionlong { get; set; } 

        [JsonProperty("show_client_user_only", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowClientUserOnly { get; set; } 

        [JsonProperty("orderingchecktype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Orderingchecktype { get; set; } 

        [JsonProperty("purchaseorderstatusafterallitemsreceived", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Purchaseorderstatusafterallitemsreceived { get; set; } 

        [JsonProperty("software_audit_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SoftwareAuditLevel { get; set; } 

        [JsonProperty("track_service_availability", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? TrackServiceAvailability { get; set; } 

        [JsonProperty("default_expand_item_catalogue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DefaultExpandItemCatalogue { get; set; } 

        [JsonProperty("services_skip_to_new_ticket", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ServicesSkipToNewTicket { get; set; } 

        [JsonProperty("surcharge_once_per_ticket", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SurchargeOncePerTicket { get; set; } 

        [JsonProperty("checktoplevelmailboxoverride", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Checktoplevelmailboxoverride { get; set; } 

        [JsonProperty("enable_check_ticket_details", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableCheckTicketDetails { get; set; } 

        [JsonProperty("precedence_bulk_is_auto_reply", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? PrecedenceBulkIsAutoReply { get; set; } 

        [JsonProperty("reservedboolfield2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Reservedboolfield2 { get; set; } 

        [JsonProperty("azure_allowed_tenants_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AzureAllowedTenantsType { get; set; } 

        [JsonProperty("usesecurecontractsigning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Usesecurecontractsigning { get; set; } 

        [JsonProperty("default_use_rpi_increase", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DefaultUseRpiIncrease { get; set; } 

        [JsonProperty("enableemailthreading", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enableemailthreading { get; set; } 

        [JsonProperty("att_item_group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AttItemGroup { get; set; } 

        [JsonProperty("att_company_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AttCompanyId { get; set; } 

        [JsonProperty("processunclosedtravel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Processunclosedtravel { get; set; } 

        [JsonProperty("use_document_management_for_clientsiteuser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseDocumentManagementForClientsiteuser { get; set; } 

        [JsonProperty("use_geo_restrictions_kb", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseGeoRestrictionsKb { get; set; } 

        [JsonProperty("use_geo_restrictions_faqlist", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseGeoRestrictionsFaqlist { get; set; } 

        [JsonProperty("calculate_composite_tax_after_line_tax", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? CalculateCompositeTaxAfterLineTax { get; set; } 

        [JsonProperty("hide_rule_checks_on_automations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HideRuleChecksOnAutomations { get; set; } 

        [JsonProperty("showassettagongoodsin", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowAssettagongoodsin { get; set; } 

        [JsonProperty("display_long_description_on_invoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DisplayLongDescriptionOnInvoice { get; set; } 

        [JsonProperty("defaultuserdetailslayout", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Defaultuserdetailslayout { get; set; } 

        [JsonProperty("default_jira_connection", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultJiraConnection { get; set; } 

        [JsonProperty("use_portal_faq_restrictions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UsePortalFaqRestrictions { get; set; } 

        [JsonProperty("order_groups_by_name_ignore_emojis", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? OrderGroupsByNameIgnoreEmojis { get; set; } 

        [JsonProperty("sendagentemailafterquoterejected", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sendagentemailafterquoterejected { get; set; } 

        [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Guid { get; set; } 

        [JsonProperty("log_clientsiteuser_views", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? LogClientsiteuserViews { get; set; } 

        [JsonProperty("enable_xml_generation_warnings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableXmlGenerationWarnings { get; set; } 

        [JsonProperty("last_auto_invoice_process_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? LastAutoInvoiceProcessDate { get; set; } 

        [JsonProperty("send_incomplete_timesheet_notifications", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SendIncompleteTimesheetNotifications { get; set; } 

        [JsonProperty("release2_autoupdate_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Release2AutoupdateMethod { get; set; } 

        [JsonProperty("release3_autoupdate_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Release3AutoupdateMethod { get; set; } 

        [JsonProperty("max_custom_extra_table_fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxCustomExtraTableFields { get; set; } 

        [JsonProperty("new_chat_window_controls", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? NewChatWindowControls { get; set; } 

        [JsonProperty("welcome_email_expiry_days", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? WelcomeEmailExpiryDays { get; set; } 

        [JsonProperty("use_charge_rate_price_for_budget", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseChargeRatePriceForBudget { get; set; } 

        [JsonProperty("suppliers_use_column_view_search", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SuppliersUseColumnViewSearch { get; set; } 

        [JsonProperty("lock_tickets_during_action", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? LockTicketsDuringAction { get; set; } 

        [JsonProperty("default_consigned_asset_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultConsignedAssetStatus { get; set; } 

        [JsonProperty("useticketpoapprovals", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Useticketpoapprovals { get; set; } 

        [JsonProperty("only_po_ticket_approval", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? OnlyPoTicketApproval { get; set; } 

        [JsonProperty("default_po_ticket_approval", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultPoTicketApproval { get; set; } 

        [JsonProperty("default_columns_id_pos", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultColumnsIdPos { get; set; } 

        [JsonProperty("default_columns_id_pos_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? DefaultColumnsIdPosGuid { get; set; } 

        [JsonProperty("default_site_details_layout", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultSiteDetailsLayout { get; set; } 

        [JsonProperty("action_calendar_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ActionCalendarType { get; set; } 

        [JsonProperty("action_calendar_ap_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ActionCalendarApType { get; set; } 

        [JsonProperty("meraki_dont_update_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? MerakiDontUpdateSite { get; set; } 

        [JsonProperty("select_all_in_team_calendar", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SelectAllInTeamCalendar { get; set; } 

        [JsonProperty("azuretranslate_allowchat", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AzuretranslateAllowchat { get; set; } 

        [JsonProperty("chat_canned_text_paste", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ChatCannedTextPaste { get; set; } 

        [JsonProperty("call_screen_category", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CallScreenCategory { get; set; } 

        [JsonProperty("call_screen_show_transferred", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? CallScreenShowTransferred { get; set; } 

        [JsonProperty("teamsshifts_authentication_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TeamsshiftsAuthenticationType { get; set; } 

        [JsonProperty("enable_teamsshifts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableTeamsshifts { get; set; } 

        [JsonProperty("teamsshifts_azure_authority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TeamsshiftsAzureAuthority { get; set; } 

        [JsonProperty("exact_default_invoice_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ExactDefaultInvoiceStatus { get; set; } 

        [JsonProperty("dont_set_list_colour_on_portal", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DontSetListColourOnPortal { get; set; } 

        [JsonProperty("prepay_amount_as_price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? PrepayAmountAsPrice { get; set; } 

        [JsonProperty("allow_multiselect_ticket_filtering", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowMultiselectTicketFiltering { get; set; } 

        [JsonProperty("enable_cmdb_service_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableCmdbServiceLink { get; set; } 

        [JsonProperty("allow_all_asset_returns", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowAllAssetReturns { get; set; } 

        [JsonProperty("liongard_default_devicetype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LiongardDefaultDevicetype { get; set; } 

        [JsonProperty("liongard_assettype_choice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LiongardAssetTypeChoice { get; set; } 

        [JsonProperty("error_notification_min_severity_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ErrorNotificationMinSeverityLevel { get; set; } 

        [JsonProperty("process_approval_results_in_background", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ProcessApprovalResultsInBackground { get; set; } 

        [JsonProperty("asset_search_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AssetSearchMethod { get; set; } 

        [JsonProperty("check_asset_fields_on_closure", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? CheckAssetFieldsOnClosure { get; set; } 

        [JsonProperty("show_all_related", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowAllRelated { get; set; } 

        [JsonProperty("enable_idle_session_timeout_named_lic", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableIdleSessionTimeoutNamedLic { get; set; } 

        [JsonProperty("enable_idle_session_timeout_concurrent_lic", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableIdleSessionTimeoutConcurrentLic { get; set; } 

        [JsonProperty("colour_hidden_notes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ColourHiddenNotes { get; set; } 

        [JsonProperty("lansweeper_delete_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? LansweeperDeleteDevices { get; set; } 

        [JsonProperty("lansweeper_delete_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LansweeperDeleteStatus { get; set; } 

        [JsonProperty("prevent_edit_email_recipients", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? PreventEditEmailRecipients { get; set; } 

        [JsonProperty("default_filter_onhold_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultFilterOnholdTickets { get; set; } 

        [JsonProperty("ninja_import_warranty_data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? NinjaImportWarrantyData { get; set; } 

        [JsonProperty("ready_for_invoice_recurring_review_check_all", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReadyForInvoiceRecurringReviewCheckAll { get; set; } 

        [JsonProperty("follow_sla_hold_procedure_for_excluded_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? FollowSlaHoldProcedureForExcludedTickets { get; set; } 

        [JsonProperty("allow_agent_status_reassign", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowAgentStatusReassign { get; set; } 

        [JsonProperty("enable_agent_status_permission", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableAgentStatusPermission { get; set; } 

        [JsonProperty("allow_agent_status_reassign_manual", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowAgentStatusReassignManual { get; set; } 

        [JsonProperty("abandoned_live_chat_enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AbandonedLiveChatEnabled { get; set; } 

        [JsonProperty("abandoned_live_chat_time_period", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AbandonedLiveChatTimePeriod { get; set; } 

        [JsonProperty("abandoned_live_chat_close_ticket", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AbandonedLiveChatCloseTicket { get; set; } 

        [JsonProperty("abandoned_live_chat_check_period", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AbandonedLiveChatCheckPeriod { get; set; } 

        [JsonProperty("chat_agent_large_box", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ChatAgentLargeBox { get; set; } 

        [JsonProperty("input_variable_upgrade_hint_shown", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? InputVariableUpgradeHintShown { get; set; } 

        [JsonProperty("saml_pass_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SamlPassClientId { get; set; } 

        [JsonProperty("log_reportevent_data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? LogReporteventData { get; set; } 

        [JsonProperty("zabbix_auth_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ZabbixAuthType { get; set; } 

        [JsonProperty("hosted_group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HostedGroup { get; set; } 

        [JsonProperty("is_uat", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsUat { get; set; } 

        [JsonProperty("pwd", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Pwd { get; set; } 

        [JsonProperty("read_only_db_admin_setting", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ReadOnlyDbAdminSetting { get; set; } 

        [JsonProperty("next_ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NextTicketId { get; set; } 

        [JsonProperty("next_invoice_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NextInvoiceId { get; set; } 

        [JsonProperty("next_quote_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NextQuoteId { get; set; } 

        [JsonProperty("next_salesorder_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NextSalesorderId { get; set; } 

        [JsonProperty("next_supplierorder_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NextSupplierorderId { get; set; } 

        [JsonProperty("multitenancy_enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? MultitenancyEnabled { get; set; } 

        [JsonProperty("using_comanaged_it", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UsingComanagedIt { get; set; } 

        [JsonProperty("portal_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PortalUrl { get; set; } 

        [JsonProperty("portal_colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PortalColour { get; set; } 

        [JsonProperty("portal_logo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PortalLogo { get; set; } 

        [JsonProperty("portalbackgroundimageurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(500)]
        public string? Portalbackgroundimageurl { get; set; } 

        [JsonProperty("mobileapp_disabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? MobileappDisabled { get; set; } 

        [JsonProperty("using_manual_rules", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UsingManualRules { get; set; } 

        [JsonProperty("using_browser_push_notifications", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UsingBrowserPushNotifications { get; set; } 

        [JsonProperty("using_automations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UsingAutomations { get; set; } 

        [JsonProperty("app_colour_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AppColourType { get; set; } 

        [JsonProperty("send_or_ask_response_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SendOrAskResponseEmail { get; set; } 

        [JsonProperty("chat_cannedtexts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CannedText>? ChatCannedTexts { get; set; } 

        [JsonProperty("signalr_enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SignalrEnabled { get; set; } 

        [JsonProperty("pr_liccount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PrLiccount { get; set; } 

        [JsonProperty("domain_user_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DomainUserCount { get; set; } 

        [JsonProperty("pr_licence_exceeded", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? PrLicenceExceeded { get; set; } 

        [JsonProperty("pr_licence_msg", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PrLicenceMsg { get; set; } 

        [JsonProperty("security_questions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<SecurityQuestion>? SecurityQuestions { get; set; } 

        [JsonProperty("clearalldata", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Clearalldata { get; set; } 

        [JsonProperty("clearcustomerdata", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Clearcustomerdata { get; set; } 

        [JsonProperty("actisbillable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Actisbillable { get; set; } 

        [JsonProperty("use_slaholdcolour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseSlaholdcolour { get; set; } 

        [JsonProperty("use_team_mgs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseTeamMgs { get; set; } 

        [JsonProperty("use_department_mgs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseDepartmentMgs { get; set; } 

        [JsonProperty("teamviewer_assetfield_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TeamviewerAssetfieldId { get; set; } 

        [JsonProperty("teamviewer_sitefield_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TeamviewerSitefieldId { get; set; } 

        [JsonProperty("default_mailbox_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultMailboxId { get; set; } 

        [JsonProperty("default_mailbox_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultMailboxName { get; set; } 

        [JsonProperty("tenant_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TenantId { get; set; } 

        [JsonProperty("tenantalias", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Tenantalias { get; set; } 

        [JsonProperty("opportunity_fieldmappings_salesforce", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? OpportunityFieldmappingsSalesforce { get; set; } 

        [JsonProperty("account_fieldmappings_salesforce", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? AccountFieldmappingsSalesforce { get; set; } 

        [JsonProperty("contact_fieldmappings_salesforce", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? ContactFieldmappingsSalesforce { get; set; } 

        [JsonProperty("anydesk_assetfield_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AnydeskAssetfieldId { get; set; } 

        [JsonProperty("anydesk_sitefield_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AnydeskSitefieldId { get; set; } 

        [JsonProperty("agent_rolemappings_azuread", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? AgentRolemappingsAzuread { get; set; } 

        [JsonProperty("_getsagedata", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Getsagedata { get; set; } 

        [JsonProperty("_getsagetoken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Getsagetoken { get; set; } 

        [JsonProperty("_clearsagetoken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Clearsagetoken { get; set; } 

        [JsonProperty("sageauthcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sageauthcode { get; set; } 

        [JsonProperty("sageauthredirect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sageauthredirect { get; set; } 

        [JsonProperty("gointegrator_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? GointegratorId { get; set; } 

        [JsonProperty("gointegrator_clientid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? GointegratorClientid { get; set; } 

        [JsonProperty("beyondtrust_teams", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<RemoteSessionTeams>? BeyondtrustTeams { get; set; } 

        [JsonProperty("change_freeze_periods", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Holidays>? ChangeFreezePeriods { get; set; } 

        [JsonProperty("dynamicscrmdefaultsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DynamicscrmdefaultsiteName { get; set; } 

        [JsonProperty("cautomatedefaultsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CautomatedefaultsiteName { get; set; } 

        [JsonProperty("cautomateassetdefaultsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CautomateassetdefaultsiteName { get; set; } 

        [JsonProperty("automate_typemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<XTypeMapping>? AutomateTypemappings { get; set; } 

        [JsonProperty("client_id_halointegrator", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ClientIdHaloIntegrator { get; set; } 

        [JsonProperty("client_secret_halointegrator", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ClientSecretHaloIntegrator { get; set; } 

        [JsonProperty("loginas_halointegrator", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LoginasHaloIntegrator { get; set; } 

        [JsonProperty("sccm_udl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SccmUdl { get; set; } 

        [JsonProperty("sccm_query", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SccmQuery { get; set; } 

        [JsonProperty("sccm_sql_timeout", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SccmSqlTimeout { get; set; } 

        [JsonProperty("sccm_idfield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SccmIdfield { get; set; } 

        [JsonProperty("sccm_typefield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SccmTypefield { get; set; } 

        [JsonProperty("sccm_sitefield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SccmSitefield { get; set; } 

        [JsonProperty("sccm_userfield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SccmUserfield { get; set; } 

        [JsonProperty("sccm_usermatchingfield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SccmUsermatchingfield { get; set; } 

        [JsonProperty("sccm_defaultsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SccmDefaultsite { get; set; } 

        [JsonProperty("sccm_defaultsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SccmDefaultsiteName { get; set; } 

        [JsonProperty("sccm_updateonly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SccmUpdateonly { get; set; } 

        [JsonProperty("sccm_donotvalidate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SccmDonotvalidate { get; set; } 

        [JsonProperty("sccm_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<SqlImportField>? SccmFieldmappings { get; set; } 

        [JsonProperty("sccm_sqlserver", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SccmSqlserver { get; set; } 

        [JsonProperty("sccm_sqldatabase", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SccmSqldatabase { get; set; } 

        [JsonProperty("sccm_sqlusername", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SccmSqlusername { get; set; } 

        [JsonProperty("sccm_assetimportidentifier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SccmAssetimportidentifier { get; set; } 

        [JsonProperty("sccm_new_sql_password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SccmNewSqlPassword { get; set; } 

        [JsonProperty("sccm_new_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SccmNewMethod { get; set; } 

        [JsonProperty("sccm_updated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SccmUpdated { get; set; } 

        [JsonProperty("sccm_dontupdatesite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SccmDontupdatesite { get; set; } 

        [JsonProperty("sccm_dontremoveusers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SccmDontremoveusers { get; set; } 

        [JsonProperty("halointegrator_sccm", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorSccm { get; set; } 

        [JsonProperty("halointegrator_sccm_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorSccmLastsync { get; set; } 

        [JsonProperty("halointegrator_sccm_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorSccmLasterror { get; set; } 

        [JsonProperty("sccm_allowed_clientids_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? SccmAllowedClientidsList { get; set; } 

        [JsonProperty("exapptsubject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Exapptsubject { get; set; } 

        [JsonProperty("exapptlocation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Exapptlocation { get; set; } 

        [JsonProperty("exapptbody", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Exapptbody { get; set; } 

        [JsonProperty("portalbuttons", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<UserDashboardButtons>? Portalbuttons { get; set; } 

        [JsonProperty("ninjadefaultsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NinjadefaultsiteName { get; set; } 

        [JsonProperty("ninja_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? NinjaFieldmappings { get; set; } 

        [JsonProperty("halointegrator_ninjarmm", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorNinjarmm { get; set; } 

        [JsonProperty("halointegrator_ninjarmm_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorNinjarmmLastsync { get; set; } 

        [JsonProperty("halointegrator_ninjarmm_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorNinjarmmLasterror { get; set; } 

        [JsonProperty("halointegrator_solarwindsrmm", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorSolarwindsrmm { get; set; } 

        [JsonProperty("halointegrator_solarwindsrmm_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorSolarwindsrmmLastsync { get; set; } 

        [JsonProperty("halointegrator_solarwindsrmm_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorSolarwindsrmmLasterror { get; set; } 

        [JsonProperty("solarwindsrmm_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? SolarwindsrmmFieldmappings { get; set; } 

        [JsonProperty("_getintegrationdata", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Getintegrationdata { get; set; } 

        [JsonProperty("_resendunsentemails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Resendunsentemails { get; set; } 

        [JsonProperty("_emailprocessed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Emailprocessed { get; set; } 

        [JsonProperty("_addactiontofaultid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Addactiontofaultid { get; set; } 

        [JsonProperty("integration_data_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? IntegrationDataName { get; set; } 

        [JsonProperty("integration_data_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? IntegrationDataType { get; set; } 

        [JsonProperty("takecontrol_button_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TakecontrolButtonId { get; set; } 

        [JsonProperty("halointegrator_lansweeper", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorLansweeper { get; set; } 

        [JsonProperty("halointegrator_lansweeper_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorLansweeperLastsync { get; set; } 

        [JsonProperty("halointegrator_lansweeper_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorLansweeperLasterror { get; set; } 

        [JsonProperty("lansweeper_updated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? LansweeperUpdated { get; set; } 

        [JsonProperty("lansweeper_databasetype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LansweeperDatabasetype { get; set; } 

        [JsonProperty("lansweeper_sqlserver", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? LansweeperSqlserver { get; set; } 

        [JsonProperty("lansweeper_sqldatabase", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? LansweeperSqldatabase { get; set; } 

        [JsonProperty("lansweeper_sqlusername", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? LansweeperSqlusername { get; set; } 

        [JsonProperty("lansweeper_new_sql_password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? LansweeperNewSqlPassword { get; set; } 

        [JsonProperty("lansweeper_new_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? LansweeperNewMethod { get; set; } 

        [JsonProperty("lansweeper_allowed_clientids_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? LansweeperAllowedClientidsList { get; set; } 

        [JsonProperty("lansweeper_query", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? LansweeperQuery { get; set; } 

        [JsonProperty("lansweeper_sql_timeout", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LansweeperSqlTimeout { get; set; } 

        [JsonProperty("lansweeper_idfield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? LansweeperIdfield { get; set; } 

        [JsonProperty("lansweeper_typefield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? LansweeperTypefield { get; set; } 

        [JsonProperty("lansweeper_sitefield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? LansweeperSitefield { get; set; } 

        [JsonProperty("lansweeper_userfield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? LansweeperUserfield { get; set; } 

        [JsonProperty("lansweeper_usermatchingfield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? LansweeperUsermatchingfield { get; set; } 

        [JsonProperty("lansweeper_defaultsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LansweeperDefaultsite { get; set; } 

        [JsonProperty("lansweeper_defaultsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? LansweeperDefaultsiteName { get; set; } 

        [JsonProperty("sccm_userssite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SccmUserssite { get; set; } 

        [JsonProperty("lansweeper_userssite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? LansweeperUserssite { get; set; } 

        [JsonProperty("lansweeper_updateonly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? LansweeperUpdateonly { get; set; } 

        [JsonProperty("lansweeper_donotvalidate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? LansweeperDonotvalidate { get; set; } 

        [JsonProperty("lansweeper_dontupdatesite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? LansweeperDontupdatesite { get; set; } 

        [JsonProperty("lansweeper_dontremoveusers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? LansweeperDontremoveusers { get; set; } 

        [JsonProperty("lansweeper_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<SqlImportField>? LansweeperFieldmappings { get; set; } 

        [JsonProperty("lansweeper_assetimportidentifier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LansweeperAssetimportidentifier { get; set; } 

        [JsonProperty("dattormm_fromaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DattormmFromaddress { get; set; } 

        [JsonProperty("dattormm_tickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DattormmTicketType { get; set; } 

        [JsonProperty("dattormm_tickettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? DattormmTicketTypeGuid { get; set; } 

        [JsonProperty("cautomate_fromaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CautomateFromaddress { get; set; } 

        [JsonProperty("cautomate_requesttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CautomateRequesttype { get; set; } 

        [JsonProperty("cautomate_requesttype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? CautomateRequesttypeGuid { get; set; } 

        [JsonProperty("solarwindsrmm_fromaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SolarwindsrmmFromaddress { get; set; } 

        [JsonProperty("solarwindsrmm_requesttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SolarwindsrmmRequesttype { get; set; } 

        [JsonProperty("solarwindsrmm_requesttype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? SolarwindsrmmRequesttypeGuid { get; set; } 

        [JsonProperty("halointegrator_integrations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? HaloIntegratorIntegrations { get; set; } 

        [JsonProperty("splunkuser_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SplunkuserName { get; set; } 

        [JsonProperty("ncentral_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? NcentralFieldmappings { get; set; } 

        [JsonProperty("halointegrator_ncentral", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorNcentral { get; set; } 

        [JsonProperty("halointegrator_ncentral_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorNcentralLastsync { get; set; } 

        [JsonProperty("halointegrator_ncentral_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorNcentralLasterror { get; set; } 

        [JsonProperty("client_secret_ncentral", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ClientSecretNcentral { get; set; } 

        [JsonProperty("ncentraluser_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NcentraluserName { get; set; } 

        [JsonProperty("azureconnection", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Azureconnection { get; set; } 

        [JsonProperty("azuremapping", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Azuremapping { get; set; } 

        [JsonProperty("businesscentral_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? BusinesscentralFieldmappings { get; set; } 

        [JsonProperty("businesscentralsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? BusinesscentralsiteName { get; set; } 

        [JsonProperty("_createbusinesscentralasset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Createbusinesscentralasset { get; set; } 

        [JsonProperty("businesscentralasset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Asset? Businesscentralasset { get; set; } 

        [JsonProperty("defaultquicktimemethod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Defaultquicktimemethod { get; set; } 

        [JsonProperty("allowticketselectionduringquicktime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allowticketselectionduringquicktime { get; set; } 

        [JsonProperty("miscitemidquotetaxrate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Miscitemidquotetaxrate { get; set; } 

        [JsonProperty("miscitemidquotetaxratepo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Miscitemidquotetaxratepo { get; set; } 

        [JsonProperty("_getautomationbody", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Getautomationbody { get; set; } 

        [JsonProperty("_sendautomationhook", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sendautomationhook { get; set; } 

        [JsonProperty("_automationwebhookid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Automationwebhookid { get; set; } 

        [JsonProperty("_automationwebhookmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<WebhookMapping>? Automationwebhookmappings { get; set; } 

        [JsonProperty("_automationticketid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Automationticketid { get; set; } 

        [JsonProperty("_getwebhookbody", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Getwebhookbody { get; set; } 

        [JsonProperty("_webhookid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Webhookid { get; set; } 

        [JsonProperty("_webhookmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<WebhookMapping>? Webhookmappings { get; set; } 

        [JsonProperty("_webhookticketid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Webhookticketid { get; set; } 

        [JsonProperty("qbozerotaxcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Qbozerotaxcode { get; set; } 

        [JsonProperty("_areaitems_to_convert", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AreaItem>? AreaitemsToConvert { get; set; } 

        [JsonProperty("_contracts_to_convert", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ContractHeaderList>? ContractsToConvert { get; set; } 

        [JsonProperty("remotesession_trackingid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? RemotesessionTrackingid { get; set; } 

        [JsonProperty("takecontrol_deviceid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TakecontrolDeviceid { get; set; } 

        [JsonProperty("showing_customer_fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowingCustomerFields { get; set; } 

        [JsonProperty("_getgoogletoken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Getgoogletoken { get; set; } 

        [JsonProperty("google_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? GoogleCode { get; set; } 

        [JsonProperty("google_redirect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? GoogleRedirect { get; set; } 

        [JsonProperty("_googlecalendardisconnect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Googlecalendardisconnect { get; set; } 

        [JsonProperty("google_application", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? GoogleApplication { get; set; } 

        [JsonProperty("googleworkplace_usermappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? GoogleworkplaceUsermappings { get; set; } 

        [JsonProperty("googleworkplace_agentmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? GoogleworkplaceAgentmappings { get; set; } 

        [JsonProperty("googleworkplace_sitemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<GoogleWorkplaceMapping>? GoogleworkplaceSitemappings { get; set; } 

        [JsonProperty("googleworkplace_rolemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? GoogleworkplaceRolemappings { get; set; } 

        [JsonProperty("googleworkplace_cabmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? GoogleworkplaceCabmappings { get; set; } 

        [JsonProperty("gw_user_matching_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? GwUserMatchingList { get; set; } 

        [JsonProperty("gw_agent_matching_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? GwAgentMatchingList { get; set; } 

        [JsonProperty("gw_licensed_roles_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair>? GwLicensedRolesList { get; set; } 

        [JsonProperty("halointegrator_googleworkplace", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorGoogleworkplace { get; set; } 

        [JsonProperty("halointegrator_googleworkplace_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorGoogleworkplaceLastsync { get; set; } 

        [JsonProperty("halointegrator_googleworkplace_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorGoogleworkplaceLasterror { get; set; } 

        [JsonProperty("dynamicscrm_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? DynamicscrmFieldmappings { get; set; } 

        [JsonProperty("scom_fromaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ScomFromaddress { get; set; } 

        [JsonProperty("scom_requesttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ScomRequesttype { get; set; } 

        [JsonProperty("scom_requesttype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? ScomRequesttypeGuid { get; set; } 

        [JsonProperty("scom_devicefield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ScomDevicefield { get; set; } 

        [JsonProperty("halointegrator_scom", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorScom { get; set; } 

        [JsonProperty("halointegrator_scom_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorScomLastsync { get; set; } 

        [JsonProperty("halointegrator_scom_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorScomLasterror { get; set; } 

        [JsonProperty("ncentral_customerid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NcentralCustomerid { get; set; } 

        [JsonProperty("rdattodefaultassettypegroup_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? RdattodefaultassettypegroupName { get; set; } 

        [JsonProperty("prtgassetdefaultsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PrtgassetdefaultsiteName { get; set; } 

        [JsonProperty("prtgdefaultassettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PrtgdefaultassettypeName { get; set; } 

        [JsonProperty("prtg_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? PrtgFieldmappings { get; set; } 

        [JsonProperty("halointegrator_prtg", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorPrtg { get; set; } 

        [JsonProperty("halointegrator_prtg_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorPrtgLastsync { get; set; } 

        [JsonProperty("halointegrator_prtg_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorPrtgLasterror { get; set; } 

        [JsonProperty("migration_default_site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? MigrationDefaultSiteName { get; set; } 

        [JsonProperty("client_secret_orion", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ClientSecretOrion { get; set; } 

        [JsonProperty("orionuser_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OrionuserName { get; set; } 

        [JsonProperty("halointegrator_orion", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorOrion { get; set; } 

        [JsonProperty("halointegrator_orion_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorOrionLastsync { get; set; } 

        [JsonProperty("halointegrator_orion_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorOrionLasterror { get; set; } 

        [JsonProperty("device42_customermappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Device42Customermappings { get; set; } 

        [JsonProperty("device42_typemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<XTypeMapping>? Device42Typemappings { get; set; } 

        [JsonProperty("device42_devicemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Device42Devicemappings { get; set; } 

        [JsonProperty("device42defaultsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Device42defaultsiteName { get; set; } 

        [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ImportType { get; set; } 

        [JsonProperty("item_default_sales_nominal_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public KeyPair2? ItemDefaultSalesNominalCode { get; set; } 

        [JsonProperty("item_default_purchase_nominal_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public KeyPair2? ItemDefaultPurchaseNominalCode { get; set; } 

        [JsonProperty("item_default_asset_account", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public KeyPair2? ItemDefaultAssetAccount { get; set; } 

        [JsonProperty("socuser_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SocuserName { get; set; } 

        [JsonProperty("client_secret_device42", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ClientSecretDevice42 { get; set; } 

        [JsonProperty("datto_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? DattoFieldmappings { get; set; } 

        [JsonProperty("dattodefaultcustomer_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DattodefaultcustomerName { get; set; } 

        [JsonProperty("dattodefaulttoplevel_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DattodefaulttoplevelName { get; set; } 

        [JsonProperty("dattodefaultassetsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DattodefaultassetsiteName { get; set; } 

        [JsonProperty("halointegrator_datto", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorDatto { get; set; } 

        [JsonProperty("halointegrator_datto_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorDattoLastsync { get; set; } 

        [JsonProperty("halointegrator_datto_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorDattoLasterror { get; set; } 

        [JsonProperty("csp_sitemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AzureAdMapping>? CspSitemappings { get; set; } 

        [JsonProperty("_generatecspmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Generatecspmappings { get; set; } 

        [JsonProperty("atera_defaultsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AteraDefaultsiteName { get; set; } 

        [JsonProperty("atera_device_types", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? AteraDeviceTypes { get; set; } 

        [JsonProperty("atera_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? AteraFieldmappings { get; set; } 

        [JsonProperty("halointegrator_atera", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorAtera { get; set; } 

        [JsonProperty("halointegrator_atera_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorAteraLastsync { get; set; } 

        [JsonProperty("halointegrator_atera_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorAteraLasterror { get; set; } 

        [JsonProperty("_deletedevices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Deletedevices { get; set; } 

        [JsonProperty("_deletedevices_integration", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DeletedevicesIntegration { get; set; } 

        [JsonProperty("device_guids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<string>? DeviceGuids { get; set; } 

        [JsonProperty("client_guids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<string>? ClientGuids { get; set; } 

        [JsonProperty("site_guids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<string>? SiteGuids { get; set; } 

        [JsonProperty("_deletelicences", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Deletelicences { get; set; } 

        [JsonProperty("licence_guids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<string>? LicenceGuids { get; set; } 

        [JsonProperty("atera_alert_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AteraAlertUserName { get; set; } 

        [JsonProperty("teams_default_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TeamsDefaultUserName { get; set; } 

        [JsonProperty("_exchangeaction", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Exchangeaction { get; set; } 

        [JsonProperty("halointegrator_exchange", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorExchange { get; set; } 

        [JsonProperty("halointegrator_exchange_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorExchangeLastsync { get; set; } 

        [JsonProperty("halointegrator_exchange_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorExchangeLasterror { get; set; } 

        [JsonProperty("okta_sitemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<OktaMapping>? OktaSitemappings { get; set; } 

        [JsonProperty("okta_usermappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? OktaUsermappings { get; set; } 

        [JsonProperty("okta_agentmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? OktaAgentmappings { get; set; } 

        [JsonProperty("okta_rolemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? OktaRolemappings { get; set; } 

        [JsonProperty("okta_cabmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? OktaCabmappings { get; set; } 

        [JsonProperty("okta_user_matching_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? OktaUserMatchingList { get; set; } 

        [JsonProperty("okta_agent_matching_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? OktaAgentMatchingList { get; set; } 

        [JsonProperty("okta_active_statuses_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? OktaActiveStatusesList { get; set; } 

        [JsonProperty("halointegrator_okta", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorOkta { get; set; } 

        [JsonProperty("halointegrator_okta_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorOktaLastsync { get; set; } 

        [JsonProperty("halointegrator_okta_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorOktaLasterror { get; set; } 

        [JsonProperty("reset_okta_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ResetOktaLastsync { get; set; } 

        [JsonProperty("quote_cannedtext", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CannedText>? QuoteCannedText { get; set; } 

        [JsonProperty("merakiapplicationsecret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Merakiapplicationsecret { get; set; } 

        [JsonProperty("merakiusername", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Merakiusername { get; set; } 

        [JsonProperty("merakitickettypename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Merakitickettypename { get; set; } 

        [JsonProperty("lansweeper_authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? LansweeperAuthorized { get; set; } 

        [JsonProperty("_getoauthtoken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Getoauthtoken { get; set; } 

        [JsonProperty("oauth_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OauthCode { get; set; } 

        [JsonProperty("oauth_redirect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OauthRedirect { get; set; } 

        [JsonProperty("oauth_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OauthType { get; set; } 

        [JsonProperty("graph_host", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? GraphHost { get; set; } 

        [JsonProperty("_disconnectintegration", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Disconnectintegration { get; set; } 

        [JsonProperty("lansweeper_sitemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationSiteMapping>? LansweeperSitemappings { get; set; } 

        [JsonProperty("lansweeper_site_rules", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationSiteMapping>? LansweeperSiteRules { get; set; } 

        [JsonProperty("lansweeper_fieldmappings_api", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? LansweeperFieldmappingsApi { get; set; } 

        [JsonProperty("alarmminutes_bool", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AlarmminutesBool { get; set; } 

        [JsonProperty("_integrationid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Integrationid { get; set; } 

        [JsonProperty("ninja_sitemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationSiteMapping>? NinjaSitemappings { get; set; } 

        [JsonProperty("ninja_alert_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NinjaAlertUserName { get; set; } 

        [JsonProperty("dattormm_alert_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DattormmAlertUserName { get; set; } 

        [JsonProperty("_closealerts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Closealerts { get; set; } 

        [JsonProperty("_closealerts_integration", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ClosealertsIntegration { get; set; } 

        [JsonProperty("alert_guids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<string>? AlertGuids { get; set; } 

        [JsonProperty("hashostedintegrator", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hashostedintegrator { get; set; } 

        [JsonProperty("halointegrator_xlsimports", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorXlsimports { get; set; } 

        [JsonProperty("halointegrator_xlsimports_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorXlsimportsLastsync { get; set; } 

        [JsonProperty("halointegrator_xlsimports_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorXlsimportsLasterror { get; set; } 

        [JsonProperty("snelstart_old_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SnelstartOldClientId { get; set; } 

        [JsonProperty("_getsnelstartlink", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Getsnelstartlink { get; set; } 

        [JsonProperty("itglue_clientmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLinkList>? ItglueClientmappings { get; set; } 

        [JsonProperty("itglue_sitemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLinkList>? ItglueSitemappings { get; set; } 

        [JsonProperty("itglue_active_statuses_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? ItglueActiveStatusesList { get; set; } 

        [JsonProperty("itglue_typemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<XTypeMapping>? ItglueTypemappings { get; set; } 

        [JsonProperty("itglue_configtypemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<XTypeMapping>? ItglueConfigtypemappings { get; set; } 

        [JsonProperty("itglue_statusmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? ItglueStatusmappings { get; set; } 

        [JsonProperty("itglue_default_site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ItglueDefaultSiteName { get; set; } 

        [JsonProperty("halointegrator_itglue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorItglue { get; set; } 

        [JsonProperty("halointegrator_itglue_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorItglueLastsync { get; set; } 

        [JsonProperty("halointegrator_itglue_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorItglueLasterror { get; set; } 

        [JsonProperty("bookingtypes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<BookingType>? Bookingtypes { get; set; } 

        [JsonProperty("appsettings_encthumbprint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AppsettingsEncthumbprint { get; set; } 

        [JsonProperty("old_pwd_enc_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? OldPwdEncCount { get; set; } 

        [JsonProperty("scom_allowed_clientids_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? ScomAllowedClientidsList { get; set; } 

        [JsonProperty("orion_allowed_clientids_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? OrionAllowedClientidsList { get; set; } 

        [JsonProperty("teamsbot_disabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? TeamsbotDisabled { get; set; } 

        [JsonProperty("datto_sitemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationSiteMapping>? DattoSitemappings { get; set; } 

        [JsonProperty("halointegrator_dynamics365crm", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorDynamics365Crm { get; set; } 

        [JsonProperty("halointegrator_dynamics365crm_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorDynamics365CrmLastsync { get; set; } 

        [JsonProperty("halointegrator_dynamics365crm_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorDynamics365CrmLasterror { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warning { get; set; } 

        [JsonProperty("jamf_defaultsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? JamfDefaultsiteName { get; set; } 

        [JsonProperty("jamf_defaultdtypecomputer_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? JamfDefaultdtypecomputerName { get; set; } 

        [JsonProperty("jamf_defaultdtypemobile_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? JamfDefaultdtypemobileName { get; set; } 

        [JsonProperty("jamf_device_types", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? JamfDeviceTypes { get; set; } 

        [JsonProperty("jamf_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? JamfFieldmappings { get; set; } 

        [JsonProperty("halointegrator_jamf", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorJamf { get; set; } 

        [JsonProperty("halointegrator_jamf_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorJamfLastsync { get; set; } 

        [JsonProperty("halointegrator_jamf_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorJamfLasterror { get; set; } 

        [JsonProperty("sentinel_ticketmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? SentinelTicketmappings { get; set; } 

        [JsonProperty("halointegrator_sentinel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorSentinel { get; set; } 

        [JsonProperty("halointegrator_sentinel_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorSentinelLastsync { get; set; } 

        [JsonProperty("halointegrator_sentinel_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorSentinelLasterror { get; set; } 

        [JsonProperty("server_time_zone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ServerTimeZone { get; set; } 

        [JsonProperty("use_project_datetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseProjectDatetime { get; set; } 

        [JsonProperty("allow_cf_values_not_on_tickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowCfValuesNotOnTicketType { get; set; } 

        [JsonProperty("azuremonitor_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? AzuremonitorFieldmappings { get; set; } 

        [JsonProperty("azuremonitoruser_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AzuremonitoruserName { get; set; } 

        [JsonProperty("syncro_defaultsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SyncroDefaultsiteName { get; set; } 

        [JsonProperty("syncro_device_types", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? SyncroDeviceTypes { get; set; } 

        [JsonProperty("syncro_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? SyncroFieldmappings { get; set; } 

        [JsonProperty("halointegrator_syncro", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorSyncro { get; set; } 

        [JsonProperty("halointegrator_syncro_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorSyncroLastsync { get; set; } 

        [JsonProperty("halointegrator_syncro_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorSyncroLasterror { get; set; } 

        [JsonProperty("syncro_alert_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SyncroAlertUserName { get; set; } 

        [JsonProperty("domotz_agentfieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? DomotzAgentfieldmappings { get; set; } 

        [JsonProperty("domotz_devicefieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? DomotzDevicefieldmappings { get; set; } 

        [JsonProperty("domotz_default_agentsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DomotzDefaultAgentsiteName { get; set; } 

        [JsonProperty("domotz_default_devicesite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DomotzDefaultDevicesiteName { get; set; } 

        [JsonProperty("domotz_devicetypemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<XTypeMapping>? DomotzDevicetypemappings { get; set; } 

        [JsonProperty("halointegrator_domotz", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorDomotz { get; set; } 

        [JsonProperty("halointegrator_domotz_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorDomotzLastsync { get; set; } 

        [JsonProperty("halointegrator_domotz_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorDomotzLasterror { get; set; } 

        [JsonProperty("_deactivateusers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Deactivateusers { get; set; } 

        [JsonProperty("_deactivateusers_integration", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DeactivateusersIntegration { get; set; } 

        [JsonProperty("user_guids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<string>? UserGuids { get; set; } 

        [JsonProperty("user_tenantids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<string>? UserTenantids { get; set; } 

        [JsonProperty("_deactivateagents", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Deactivateagents { get; set; } 

        [JsonProperty("_deactivateagents_integration", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DeactivateagentsIntegration { get; set; } 

        [JsonProperty("agent_guids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<string>? AgentGuids { get; set; } 

        [JsonProperty("halointegrator_haloassetdiscovery", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorHaloassetdiscovery { get; set; } 

        [JsonProperty("halointegrator_haloassetdiscovery_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorHaloassetdiscoveryLastsync { get; set; } 

        [JsonProperty("halointegrator_haloassetdiscovery_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorHaloassetdiscoveryLasterror { get; set; } 

        [JsonProperty("automate_sitemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationSiteMapping>? AutomateSitemappings { get; set; } 

        [JsonProperty("halointegrator_automate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorAutomate { get; set; } 

        [JsonProperty("halointegrator_automate_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorAutomateLastsync { get; set; } 

        [JsonProperty("halointegrator_automate_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorAutomateLasterror { get; set; } 

        [JsonProperty("automate_import_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? AutomateImportEntitiesList { get; set; } 

        [JsonProperty("atera_import_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? AteraImportEntitiesList { get; set; } 

        [JsonProperty("addigy_import_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? AddigyImportEntitiesList { get; set; } 

        [JsonProperty("meraki_import_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? MerakiImportEntitiesList { get; set; } 

        [JsonProperty("automate_alert_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AutomateAlertUserName { get; set; } 

        [JsonProperty("lansweeper_exports", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationExport>? LansweeperExports { get; set; } 

        [JsonProperty("_checkexportprogress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Checkexportprogress { get; set; } 

        [JsonProperty("export_module", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ExportModule { get; set; } 

        [JsonProperty("atera_sitemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationSiteMapping>? AteraSitemappings { get; set; } 

        [JsonProperty("device42_sitemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationSiteMapping>? Device42Sitemappings { get; set; } 

        [JsonProperty("ncentral_sitemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationSiteMapping>? NcentralSitemappings { get; set; } 

        [JsonProperty("syncro_sitemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationSiteMapping>? SyncroSitemappings { get; set; } 

        [JsonProperty("halointegrator_g2aremote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorG2Aremote { get; set; } 

        [JsonProperty("halointegrator_g2aremote_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorG2AremoteLastsync { get; set; } 

        [JsonProperty("halointegrator_g2aremote_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorG2AremoteLasterror { get; set; } 

        [JsonProperty("snow_default_devicesite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SnowDefaultDevicesiteName { get; set; } 

        [JsonProperty("snow_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? SnowFieldmappings { get; set; } 

        [JsonProperty("halointegrator_snow", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorSnow { get; set; } 

        [JsonProperty("halointegrator_snow_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorSnowLastsync { get; set; } 

        [JsonProperty("halointegrator_snow_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorSnowLasterror { get; set; } 

        [JsonProperty("auvik_sitemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationSiteMapping>? AuvikSitemappings { get; set; } 

        [JsonProperty("auvik_network_typemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<XTypeMapping>? AuvikNetworkTypemappings { get; set; } 

        [JsonProperty("auvik_device_typemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<XTypeMapping>? AuvikDeviceTypemappings { get; set; } 

        [JsonProperty("auvik_network_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? AuvikNetworkFieldmappings { get; set; } 

        [JsonProperty("auvik_device_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? AuvikDeviceFieldmappings { get; set; } 

        [JsonProperty("auvik_default_site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AuvikDefaultSiteName { get; set; } 

        [JsonProperty("halointegrator_auvik", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorAuvik { get; set; } 

        [JsonProperty("halointegrator_auvik_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorAuvikLastsync { get; set; } 

        [JsonProperty("halointegrator_auvik_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorAuvikLasterror { get; set; } 

        [JsonProperty("auvik_alert_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AuvikAlertUserName { get; set; } 

        [JsonProperty("teamsbot_allowed_tenants_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? TeamsbotAllowedTenantsList { get; set; } 

        [JsonProperty("hubspot_sitemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationSiteMapping>? HubspotSitemappings { get; set; } 

        [JsonProperty("hubspot_company_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? HubspotCompanyFieldmappings { get; set; } 

        [JsonProperty("hubspot_contact_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? HubspotContactFieldmappings { get; set; } 

        [JsonProperty("hubspot_deals_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? HubspotDealsFieldmappings { get; set; } 

        [JsonProperty("hubspot_items_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? HubspotItemsFieldmappings { get; set; } 

        [JsonProperty("hubspot_quotes_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? HubspotQuotesFieldmappings { get; set; } 

        [JsonProperty("hubspot_top_level_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HubspotTopLevelName { get; set; } 

        [JsonProperty("hubspot_default_site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HubspotDefaultSiteName { get; set; } 

        [JsonProperty("hubspot_included_lifecycles_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair>? HubspotIncludedLifecyclesList { get; set; } 

        [JsonProperty("halointegrator_hubspot", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorHubspot { get; set; } 

        [JsonProperty("halointegrator_hubspot_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorHubspotLastsync { get; set; } 

        [JsonProperty("halointegrator_hubspot_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorHubspotLasterror { get; set; } 

        [JsonProperty("qualys_typemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<XTypeMapping>? QualysTypemappings { get; set; } 

        [JsonProperty("qualys_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? QualysFieldmappings { get; set; } 

        [JsonProperty("qualys_default_site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? QualysDefaultSiteName { get; set; } 

        [JsonProperty("halointegrator_qualys", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorQualys { get; set; } 

        [JsonProperty("halointegrator_qualys_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorQualysLastsync { get; set; } 

        [JsonProperty("halointegrator_qualys_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorQualysLasterror { get; set; } 

        [JsonProperty("passportal_defaultclientsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PassportalDefaultclientsiteName { get; set; } 

        [JsonProperty("passportal_defaultusersite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PassportalDefaultusersiteName { get; set; } 

        [JsonProperty("passportal_clientmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationSiteMapping>? PassportalClientmappings { get; set; } 

        [JsonProperty("halointegrator_passportal", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorPassportal { get; set; } 

        [JsonProperty("halointegrator_passportal_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorPassportalLastsync { get; set; } 

        [JsonProperty("halointegrator_passportal_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorPassportalLasterror { get; set; } 

        [JsonProperty("passportal_assetfieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? PassportalAssetfieldmappings { get; set; } 

        [JsonProperty("passportal_defaultassetsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PassportalDefaultassetsiteName { get; set; } 

        [JsonProperty("passportal_import_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? PassportalImportEntitiesList { get; set; } 

        [JsonProperty("auvik_top_level_domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AuvikTenantMod? AuvikTopLevelDomain { get; set; } 

        [JsonProperty("lansweeper_include_linux", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? LansweeperIncludeLinux { get; set; } 

        [JsonProperty("intacct_sync_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? IntacctSyncEntitiesList { get; set; } 

        [JsonProperty("license_model", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public LicenseModel? LicenseModel { get; set; } 

        [JsonProperty("addigy_clientmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationSiteMapping>? AddigyClientmappings { get; set; } 

        [JsonProperty("addigy_defaultassetsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AddigyDefaultassetsiteName { get; set; } 

        [JsonProperty("addigy_assetfieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? AddigyAssetfieldmappings { get; set; } 

        [JsonProperty("halointegrator_addigy", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorAddigy { get; set; } 

        [JsonProperty("halointegrator_addigy_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorAddigyLastsync { get; set; } 

        [JsonProperty("halointegrator_addigy_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorAddigyLasterror { get; set; } 

        [JsonProperty("addigy_alert_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AddigyAlertUserName { get; set; } 

        [JsonProperty("domotz_sitemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationSiteMapping>? DomotzSitemappings { get; set; } 

        [JsonProperty("halointegrator_liongard", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorLiongard { get; set; } 

        [JsonProperty("halointegrator_liongard_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorLiongardLastsync { get; set; } 

        [JsonProperty("halointegrator_liongard_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorLiongardLasterror { get; set; } 

        [JsonProperty("liongard_sitemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationSiteMapping>? LiongardSitemappings { get; set; } 

        [JsonProperty("liongard_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? LiongardFieldmappings { get; set; } 

        [JsonProperty("liongard_defaultsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? LiongardDefaultsiteName { get; set; } 

        [JsonProperty("liongard_mappings_xtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<XTypeMapping>? LiongardMappingsXtype { get; set; } 

        [JsonProperty("halointegrator_stripe", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorStripe { get; set; } 

        [JsonProperty("halointegrator_stripe_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorStripeLastsync { get; set; } 

        [JsonProperty("halointegrator_stripe_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorStripeLasterror { get; set; } 

        [JsonProperty("ingram_micro_client_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLinkList>? IngramMicroClientMappings { get; set; } 

        [JsonProperty("ingram_micro_top_level_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? IngramMicroTopLevelName { get; set; } 

        [JsonProperty("halointegrator_ingram_micro", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorIngramMicro { get; set; } 

        [JsonProperty("halointegrator_ingram_micro_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorIngramMicroLastsync { get; set; } 

        [JsonProperty("halointegrator_ingram_micro_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorIngramMicroLasterror { get; set; } 

        [JsonProperty("ingram_micro_import_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? IngramMicroImportEntitiesList { get; set; } 

        [JsonProperty("pax8_client_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLinkList>? Pax8ClientMappings { get; set; } 

        [JsonProperty("quoter_item_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLinkList>? QuoterItemMappings { get; set; } 

        [JsonProperty("etilize_item_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLinkList>? EtilizeItemMappings { get; set; } 

        [JsonProperty("pax8_top_level_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Pax8TopLevelName { get; set; } 

        [JsonProperty("halointegrator_pax8", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorPax8 { get; set; } 

        [JsonProperty("halointegrator_pax8_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorPax8Lastsync { get; set; } 

        [JsonProperty("halointegrator_pax8_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorPax8Lasterror { get; set; } 

        [JsonProperty("pax8_import_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? Pax8ImportEntitiesList { get; set; } 

        [JsonProperty("halointegrator_giacom", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorGiacom { get; set; } 

        [JsonProperty("halointegrator_giacom_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorGiacomLastsync { get; set; } 

        [JsonProperty("halointegrator_giacom_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorGiacomLasterror { get; set; } 

        [JsonProperty("giacom_import_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? GiacomImportEntitiesList { get; set; } 

        [JsonProperty("salesforce_contactfieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? SalesforceContactfieldmappings { get; set; } 

        [JsonProperty("salesforce_accountfieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? SalesforceAccountfieldmappings { get; set; } 

        [JsonProperty("salesforce_opportunityfieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? SalesforceOpportunityfieldmappings { get; set; } 

        [JsonProperty("salesforce_casefieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? SalesforceCasefieldmappings { get; set; } 

        [JsonProperty("halointegrator_salesforce", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorSalesforce { get; set; } 

        [JsonProperty("halointegrator_salesforce_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorSalesforceLastsync { get; set; } 

        [JsonProperty("halointegrator_salesforce_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorSalesforceLasterror { get; set; } 

        [JsonProperty("salesforce_import_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? SalesforceImportEntitiesList { get; set; } 

        [JsonProperty("salesforce_import_attachments_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? SalesforceImportAttachmentsList { get; set; } 

        [JsonProperty("salesforce_clientmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLinkList>? SalesforceClientmappings { get; set; } 

        [JsonProperty("azure_allowed_tenants", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AzureAllowedTenants { get; set; } 

        [JsonProperty("azure_allowed_tenants_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? AzureAllowedTenantsList { get; set; } 

        [JsonProperty("azure_auto_creation_site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AzureAutoCreationSiteName { get; set; } 

        [JsonProperty("b2cazure_auto_creation_site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? B2CazureAutoCreationSiteName { get; set; } 

        [JsonProperty("halointegrator_newrelic", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorNewrelic { get; set; } 

        [JsonProperty("halointegrator_newrelic_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorNewrelicLastsync { get; set; } 

        [JsonProperty("halointegrator_newrelic_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorNewrelicLasterror { get; set; } 

        [JsonProperty("halointegrator_backupradar", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorBackupradar { get; set; } 

        [JsonProperty("halointegrator_backupradar_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorBackupradarLastsync { get; set; } 

        [JsonProperty("halointegrator_backupradar_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorBackupradarLasterror { get; set; } 

        [JsonProperty("_deactivateclients", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Deactivateclients { get; set; } 

        [JsonProperty("kaseya_defaultsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? KaseyaDefaultsiteName { get; set; } 

        [JsonProperty("halointegrator_kaseya", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorKaseya { get; set; } 

        [JsonProperty("halointegrator_kaseya_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorKaseyaLastsync { get; set; } 

        [JsonProperty("halointegrator_kaseya_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorKaseyaLasterror { get; set; } 

        [JsonProperty("kaseya_agentfieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? KaseyaAgentfieldmappings { get; set; } 

        [JsonProperty("kaseya_sitemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationSiteMapping>? KaseyaSitemappings { get; set; } 

        [JsonProperty("kaseya_typemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<XTypeMapping>? KaseyaTypemappings { get; set; } 

        [JsonProperty("stripe_client_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLinkList>? StripeClientMappings { get; set; } 

        [JsonProperty("stripe_paymentmethod_options_keypair", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? StripePaymentmethodOptionsKeypair { get; set; } 

        [JsonProperty("stripe_manual_paymentmethod_options_keypair", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? StripeManualPaymentmethodOptionsKeypair { get; set; } 

        [JsonProperty("zabbix_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? ZabbixFieldmappings { get; set; } 

        [JsonProperty("zabbix_typemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<XTypeMapping>? ZabbixTypemappings { get; set; } 

        [JsonProperty("zabbix_default_type_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ZabbixDefaultTypeName { get; set; } 

        [JsonProperty("zabbix_default_site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ZabbixDefaultSiteName { get; set; } 

        [JsonProperty("halointegrator_zabbix", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorZabbix { get; set; } 

        [JsonProperty("halointegrator_zabbix_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorZabbixLastsync { get; set; } 

        [JsonProperty("halointegrator_zabbix_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorZabbixLasterror { get; set; } 

        [JsonProperty("giacom_client_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLinkList>? GiacomClientMappings { get; set; } 

        [JsonProperty("giacom_top_level_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? GiacomTopLevelName { get; set; } 

        [JsonProperty("rhipe_client_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLinkList>? RhipeClientMappings { get; set; } 

        [JsonProperty("rhipe_top_level_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? RhipeTopLevelName { get; set; } 

        [JsonProperty("halointegrator_rhipe", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorRhipe { get; set; } 

        [JsonProperty("halointegrator_rhipe_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorRhipeLastsync { get; set; } 

        [JsonProperty("halointegrator_rhipe_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorRhipeLasterror { get; set; } 

        [JsonProperty("rhipe_import_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? RhipeImportEntitiesList { get; set; } 

        [JsonProperty("techdata_client_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLinkList>? TechdataClientMappings { get; set; } 

        [JsonProperty("techdata_top_level_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TechdataTopLevelName { get; set; } 

        [JsonProperty("halointegrator_techdata", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorTechdata { get; set; } 

        [JsonProperty("halointegrator_techdata_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorTechdataLastsync { get; set; } 

        [JsonProperty("halointegrator_techdata_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorTechdataLasterror { get; set; } 

        [JsonProperty("techdata_import_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? TechdataImportEntitiesList { get; set; } 

        [JsonProperty("inty_client_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLinkList>? IntyClientMappings { get; set; } 

        [JsonProperty("inty_top_level_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? IntyTopLevelName { get; set; } 

        [JsonProperty("halointegrator_inty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorInty { get; set; } 

        [JsonProperty("halointegrator_inty_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorIntyLastsync { get; set; } 

        [JsonProperty("halointegrator_inty_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorIntyLasterror { get; set; } 

        [JsonProperty("inty_import_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? IntyImportEntitiesList { get; set; } 

        [JsonProperty("westcoastcloud_client_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLinkList>? WestcoastcloudClientMappings { get; set; } 

        [JsonProperty("westcoastcloud_top_level_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? WestcoastcloudTopLevelName { get; set; } 

        [JsonProperty("halointegrator_westcoastcloud", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorWestcoastcloud { get; set; } 

        [JsonProperty("halointegrator_westcoastcloud_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorWestcoastcloudLastsync { get; set; } 

        [JsonProperty("halointegrator_westcoastcloud_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorWestcoastcloudLasterror { get; set; } 

        [JsonProperty("westcoastcloud_import_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? WestcoastcloudImportEntitiesList { get; set; } 

        [JsonProperty("sherweb_client_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLinkList>? SherwebClientMappings { get; set; } 

        [JsonProperty("sherweb_top_level_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SherwebTopLevelName { get; set; } 

        [JsonProperty("halointegrator_sherweb", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorSherweb { get; set; } 

        [JsonProperty("halointegrator_sherweb_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorSherwebLastsync { get; set; } 

        [JsonProperty("halointegrator_sherweb_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorSherwebLasterror { get; set; } 

        [JsonProperty("sherweb_import_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? SherwebImportEntitiesList { get; set; } 

        [JsonProperty("also_client_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLinkList>? AlsoClientMappings { get; set; } 

        [JsonProperty("also_top_level_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AlsoTopLevelName { get; set; } 

        [JsonProperty("halointegrator_also", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorAlso { get; set; } 

        [JsonProperty("halointegrator_also_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorAlsoLastsync { get; set; } 

        [JsonProperty("halointegrator_also_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorAlsoLasterror { get; set; } 

        [JsonProperty("also_import_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? AlsoImportEntitiesList { get; set; } 

        [JsonProperty("arrowsphere_client_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLinkList>? ArrowsphereClientMappings { get; set; } 

        [JsonProperty("arrowsphere_top_level_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ArrowsphereTopLevelName { get; set; } 

        [JsonProperty("halointegrator_arrowsphere", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorArrowsphere { get; set; } 

        [JsonProperty("halointegrator_arrowsphere_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorArrowsphereLastsync { get; set; } 

        [JsonProperty("halointegrator_arrowsphere_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorArrowsphereLasterror { get; set; } 

        [JsonProperty("arrowsphere_import_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? ArrowsphereImportEntitiesList { get; set; } 

        [JsonProperty("dickerdata_client_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLinkList>? DickerdataClientMappings { get; set; } 

        [JsonProperty("dickerdata_top_level_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DickerdataTopLevelName { get; set; } 

        [JsonProperty("halointegrator_dickerdata", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorDickerdata { get; set; } 

        [JsonProperty("halointegrator_dickerdata_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorDickerdataLastsync { get; set; } 

        [JsonProperty("halointegrator_dickerdata_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorDickerdataLasterror { get; set; } 

        [JsonProperty("dickerdata_import_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? DickerdataImportEntitiesList { get; set; } 

        [JsonProperty("halointegrator_oracle", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorOracle { get; set; } 

        [JsonProperty("halointegrator_oracle_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorOracleLastsync { get; set; } 

        [JsonProperty("halointegrator_oracle_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorOracleLasterror { get; set; } 

        [JsonProperty("halointegrator_servicenow", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorServicenow { get; set; } 

        [JsonProperty("halointegrator_servicenow_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorServicenowLastsync { get; set; } 

        [JsonProperty("halointegrator_servicenow_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorServicenowLasterror { get; set; } 

        [JsonProperty("xerodefaulttenantname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Xerodefaulttenantname { get; set; } 

        [JsonProperty("qbdefaultcompanyname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Qbdefaultcompanyname { get; set; } 

        [JsonProperty("kashflowdefaultconnectionname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Kashflowdefaultconnectionname { get; set; } 

        [JsonProperty("dbcdefaulttenantname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Dbcdefaulttenantname { get; set; } 

        [JsonProperty("datadog_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DatadogUrl { get; set; } 

        [JsonProperty("clear_billing_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ClearBillingMappings { get; set; } 

        [JsonProperty("clearunsentactions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Clearunsentactions { get; set; } 

        [JsonProperty("clearunsentemailstore", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Clearunsentemailstore { get; set; } 

        [JsonProperty("clearunsentescmsg", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Clearunsentescmsg { get; set; } 

        [JsonProperty("clearunsentactions_attempted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ClearunsentactionsAttempted { get; set; } 

        [JsonProperty("clearunsentemailstore_attempted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ClearunsentemailstoreAttempted { get; set; } 

        [JsonProperty("clearunsentescmsg_attempted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ClearunsentescmsgAttempted { get; set; } 

        [JsonProperty("slack_ticket_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SlackTicketUserName { get; set; } 

        [JsonProperty("slack_command_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SlackCommandUserName { get; set; } 

        [JsonProperty("_checkexport_returnerrors", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? CheckexportReturnerrors { get; set; } 

        [JsonProperty("device_tenantids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<int>? DeviceTenantids { get; set; } 

        [JsonProperty("client_tenantids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<int>? ClientTenantids { get; set; } 

        [JsonProperty("connectwisecontrol_sitemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLinkList>? ConnectwisecontrolSitemappings { get; set; } 

        [JsonProperty("connectwisecontrol_typemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<XTypeMapping>? ConnectwisecontrolTypemappings { get; set; } 

        [JsonProperty("halointegrator_connectwisecontrol", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorConnectwisecontrol { get; set; } 

        [JsonProperty("connectwisecontrol_import_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? ConnectwisecontrolImportEntitiesList { get; set; } 

        [JsonProperty("halointegrator_connectwisecontrol_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorConnectwisecontrolLastsync { get; set; } 

        [JsonProperty("halointegrator_connectwisecontrol_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorConnectwisecontrolLasterror { get; set; } 

        [JsonProperty("connectwisecontrolassetdefaultsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ConnectwisecontrolassetdefaultsiteName { get; set; } 

        [JsonProperty("salesforce_priority_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? SalesforcePriorityMappings { get; set; } 

        [JsonProperty("cors_whitelist_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? CorsWhitelistList { get; set; } 

        [JsonProperty("okta_userrolemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? OktaUserrolemappings { get; set; } 

        [JsonProperty("workspace_devicemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? WorkspaceDevicemappings { get; set; } 

        [JsonProperty("workspace_site_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLinkList>? WorkspaceSiteMappings { get; set; } 

        [JsonProperty("twilio_ticket_type_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TwilioTicketTypeName { get; set; } 

        [JsonProperty("twilio_default_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TwilioDefaultUserName { get; set; } 

        [JsonProperty("sccm_sqldriver", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SccmSqldriver { get; set; } 

        [JsonProperty("sccm_sqlprovider", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SccmSqlprovider { get; set; } 

        [JsonProperty("lansweeper_sqldriver", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? LansweeperSqldriver { get; set; } 

        [JsonProperty("lansweeper_sqlprovider", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LansweeperSqlprovider { get; set; } 

        [JsonProperty("processstreettickettypename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Processstreettickettypename { get; set; } 

        [JsonProperty("processstreetusername", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Processstreetusername { get; set; } 

        [JsonProperty("intacct_sync_halo_id_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? IntacctSyncHaloIdList { get; set; } 

        [JsonProperty("intacctdefaultlocid_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? IntacctdefaultlocidList { get; set; } 

        [JsonProperty("intacct_warehouse_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? IntacctWarehouseMappings { get; set; } 

        [JsonProperty("teams_chat_tenant_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? TeamsChatTenantList { get; set; } 

        [JsonProperty("workspace_defaultsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? WorkspaceDefaultsiteName { get; set; } 

        [JsonProperty("halo_status_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? HaloStatusMappings { get; set; } 

        [JsonProperty("halo_priority_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? HaloPriorityMappings { get; set; } 

        [JsonProperty("etilizeurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Etilizeurl { get; set; } 

        [JsonProperty("barracuda_sitemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLinkList>? BarracudaSitemappings { get; set; } 

        [JsonProperty("barracuda_clientmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLinkList>? BarracudaClientmappings { get; set; } 

        [JsonProperty("barracuda_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? BarracudaFieldmappings { get; set; } 

        [JsonProperty("logicmonitor_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? LogicmonitorFieldmappings { get; set; } 

        [JsonProperty("halointegrator_logicmonitor", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorLogicmonitor { get; set; } 

        [JsonProperty("halointegrator_logicmonitor_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorLogicmonitorLastsync { get; set; } 

        [JsonProperty("halointegrator_logicmonitor_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorLogicmonitorLasterror { get; set; } 

        [JsonProperty("logicmonitor_defaultsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? LogicmonitorDefaultsiteName { get; set; } 

        [JsonProperty("logicmonitor_alert_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? LogicmonitorAlertUserName { get; set; } 

        [JsonProperty("logicmonitor_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? LogicmonitorUrl { get; set; } 

        [JsonProperty("halointegrator_barracuda", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorBarracuda { get; set; } 

        [JsonProperty("halointegrator_barracuda_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorBarracudaLastsync { get; set; } 

        [JsonProperty("halointegrator_barracuda_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorBarracudaLasterror { get; set; } 

        [JsonProperty("barracuda_defaultsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? BarracudaDefaultsiteName { get; set; } 

        [JsonProperty("barracudadefaultassettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? BarracudadefaultassettypeName { get; set; } 

        [JsonProperty("barracuda_alert_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? BarracudaAlertUserName { get; set; } 

        [JsonProperty("teams_chat_tenants", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TeamsChatTenants { get; set; } 

        [JsonProperty("teams_chat_welcome_message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TeamsChatWelcomeMessage { get; set; } 

        [JsonProperty("teams_chat_help_message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TeamsChatHelpMessage { get; set; } 

        [JsonProperty("gw_named_roles_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair>? GwNamedRolesList { get; set; } 

        [JsonProperty("okta_named_roles_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair>? OktaNamedRolesList { get; set; } 

        [JsonProperty("lansweeper_mappings_xtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<XTypeMapping>? LansweeperMappingsXtype { get; set; } 

        [JsonProperty("gw_userrolemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? GwUserrolemappings { get; set; } 

        [JsonProperty("whatsapptickettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? WhatsapptickettypeName { get; set; } 

        [JsonProperty("twilio_whatsapp_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TwilioWhatsappNumber { get; set; } 

        [JsonProperty("appointment_notification_body", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AppointmentNotificationBody { get; set; } 

        [JsonProperty("task_notification_body", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TaskNotificationBody { get; set; } 

        [JsonProperty("site24x7_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Site24X7Fieldmappings { get; set; } 

        [JsonProperty("site24x7_alert_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Site24X7AlertUserName { get; set; } 

        [JsonProperty("gw_mappings_new_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? GwMappingsNewUser { get; set; } 

        [JsonProperty("okta_mappings_new_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? OktaMappingsNewUser { get; set; } 

        [JsonProperty("recaptcha_site_key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? RecaptchaSiteKey { get; set; } 

        [JsonProperty("jamf_site_links", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLinkList>? JamfSiteLinks { get; set; } 

        [JsonProperty("total_setup_steps", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalSetupSteps { get; set; } 

        [JsonProperty("completed_setup_steps", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CompletedSetupSteps { get; set; } 

        [JsonProperty("cleardatakey", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Cleardatakey { get; set; } 

        [JsonProperty("halointegrator_icinga", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorIcinga { get; set; } 

        [JsonProperty("halointegrator_icinga_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorIcingaLastsync { get; set; } 

        [JsonProperty("halointegrator_icinga_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorIcingaLasterror { get; set; } 

        [JsonProperty("icinga_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? IcingaFieldmappings { get; set; } 

        [JsonProperty("icinga_defaultsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? IcingaDefaultsiteName { get; set; } 

        [JsonProperty("icingadefaultassettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? IcingadefaultassettypeName { get; set; } 

        [JsonProperty("icinga_sitemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationSiteMapping>? IcingaSitemappings { get; set; } 

        [JsonProperty("icinga_alert_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? IcingaAlertUserName { get; set; } 

        [JsonProperty("default_columns_id_sites_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? DefaultColumnsIdSitesGuid { get; set; } 

        [JsonProperty("default_columns_id_users_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? DefaultColumnsIdUsersGuid { get; set; } 

        [JsonProperty("translations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<LanguagePackTranslationsCustom>? Translations { get; set; } 

        [JsonProperty("default_meter_tiers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<InvoiceDetailMeterTiers>? DefaultMeterTiers { get; set; } 

        [JsonProperty("connectwisermm_sitemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLinkList>? ConnectwisermmSitemappings { get; set; } 

        [JsonProperty("connectwisermm_typemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<XTypeMapping>? ConnectwisermmTypemappings { get; set; } 

        [JsonProperty("connectwise_rmm_defaultclient_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ConnectwiseRmmDefaultclientName { get; set; } 

        [JsonProperty("halointegrator_connectwisermm", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorConnectwisermm { get; set; } 

        [JsonProperty("connectwisermm_import_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? ConnectwisermmImportEntitiesList { get; set; } 

        [JsonProperty("halointegrator_connectwisermm_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorConnectwisermmLastsync { get; set; } 

        [JsonProperty("halointegrator_connectwisermm_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorConnectwisermmLasterror { get; set; } 

        [JsonProperty("cookiemessage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Cookiemessage { get; set; } 

        [JsonProperty("icinga_xtype_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<XTypeMapping>? IcingaXtypeMappings { get; set; } 

        [JsonProperty("logicmonitor_xtype_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<XTypeMapping>? LogicmonitorXtypeMappings { get; set; } 

        [JsonProperty("shopifydefaultsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ShopifydefaultsiteName { get; set; } 

        [JsonProperty("shopify_userfieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? ShopifyUserfieldmappings { get; set; } 

        [JsonProperty("shopify_customerfieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? ShopifyCustomerfieldmappings { get; set; } 

        [JsonProperty("halointegrator_shopify", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorShopify { get; set; } 

        [JsonProperty("halointegrator_shopify_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorShopifyLastsync { get; set; } 

        [JsonProperty("halointegrator_shopify_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorShopifyLasterror { get; set; } 

        [JsonProperty("shopify_import_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? ShopifyImportEntitiesList { get; set; } 

        [JsonProperty("intacct_invoicefieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? IntacctInvoicefieldmappings { get; set; } 

        [JsonProperty("intacct_invoicelinefieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? IntacctInvoicelinefieldmappings { get; set; } 

        [JsonProperty("intacct_orderfieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? IntacctOrderfieldmappings { get; set; } 

        [JsonProperty("intacct_orderlinefieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? IntacctOrderlinefieldmappings { get; set; } 

        [JsonProperty("intacct_creditfieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? IntacctCreditfieldmappings { get; set; } 

        [JsonProperty("intacct_creditlinefieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? IntacctCreditlinefieldmappings { get; set; } 

        [JsonProperty("intacct_billfieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? IntacctBillfieldmappings { get; set; } 

        [JsonProperty("intacct_billlinefieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? IntacctBilllinefieldmappings { get; set; } 

        [JsonProperty("halointegrator_xensam", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorXensam { get; set; } 

        [JsonProperty("halointegrator_xensam_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorXensamLastsync { get; set; } 

        [JsonProperty("halointegrator_xensam_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorXensamLasterror { get; set; } 

        [JsonProperty("xensam_defaultsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? XensamDefaultsiteName { get; set; } 

        [JsonProperty("xensam_import_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? XensamImportEntitiesList { get; set; } 

        [JsonProperty("xensam_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? XensamFieldmappings { get; set; } 

        [JsonProperty("xensam_datacentre_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? XensamDatacentreFieldmappings { get; set; } 

        [JsonProperty("xensam_clientmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLinkList>? XensamClientmappings { get; set; } 

        [JsonProperty("xensam_mappings_xtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<XTypeMapping>? XensamMappingsXtype { get; set; } 

        [JsonProperty("trustpilot_defaultusersite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TrustpilotDefaultusersiteName { get; set; } 

        [JsonProperty("okta_sitegroup_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLinkList>? OktaSitegroupMappings { get; set; } 

        [JsonProperty("lansweeper_sql_port", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? LansweeperSqlPort { get; set; } 

        [JsonProperty("sccm_sql_port", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SccmSqlPort { get; set; } 

        [JsonProperty("can_disable_incoming_service", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanDisableIncomingService { get; set; } 

        [JsonProperty("zabbix_alert_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ZabbixAlertUserName { get; set; } 

        [JsonProperty("connectwise_rmm_alert_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ConnectwiseRmmAlertUserName { get; set; } 

        [JsonProperty("amazon_seller_default_site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AmazonSellerDefaultSiteName { get; set; } 

        [JsonProperty("halointegrator_amazonseller", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorAmazonseller { get; set; } 

        [JsonProperty("halointegrator_amazonseller_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorAmazonsellerLastsync { get; set; } 

        [JsonProperty("halointegrator_amazonseller_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorAmazonsellerLasterror { get; set; } 

        [JsonProperty("is_nhserverless", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsNhserverless { get; set; } 

        [JsonProperty("incoming_default_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? IncomingDefaultUserName { get; set; } 

        [JsonProperty("incoming_newuser_default_site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? IncomingNewuserDefaultSiteName { get; set; } 

        [JsonProperty("prometheus_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? PrometheusFieldmappings { get; set; } 

        [JsonProperty("prometheus_defaultassettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PrometheusDefaultassettypeName { get; set; } 

        [JsonProperty("prometheus_defaultsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PrometheusDefaultsiteName { get; set; } 

        [JsonProperty("prometheus_xtype_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<XTypeMapping>? PrometheusXtypeMappings { get; set; } 

        [JsonProperty("prometheus_alerting_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PrometheusAlertingUserName { get; set; } 

        [JsonProperty("halointegrator_prometheus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorPrometheus { get; set; } 

        [JsonProperty("halointegrator_prometheus_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorPrometheusLastsync { get; set; } 

        [JsonProperty("halointegrator_prometheus_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorPrometheusLasterror { get; set; } 

        [JsonProperty("halointegrator_mattermost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorMattermost { get; set; } 

        [JsonProperty("halointegrator_mattermost_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorMattermostLastsync { get; set; } 

        [JsonProperty("halointegrator_mattermost_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorMattermostLasterror { get; set; } 

        [JsonProperty("halointegrator_wordpress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorWordpress { get; set; } 

        [JsonProperty("halointegrator_wordpress_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorWordpressLastsync { get; set; } 

        [JsonProperty("halointegrator_wordpress_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorWordpressLasterror { get; set; } 

        [JsonProperty("reset_halointegrator_wordpress_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ResetHaloIntegratorWordpressLastsync { get; set; } 

        [JsonProperty("_dbintegrator_success", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DbintegratorSuccess { get; set; } 

        [JsonProperty("deferred_revenue_client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DeferredRevenueClientName { get; set; } 

        [JsonProperty("halointegrator_googlebusiness", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorGooglebusiness { get; set; } 

        [JsonProperty("halointegrator_googlebusiness_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorGooglebusinessLastsync { get; set; } 

        [JsonProperty("halointegrator_googlebusiness_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorGooglebusinessLasterror { get; set; } 

        [JsonProperty("reset_halointegrator_googlebusiness_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ResetHaloIntegratorGooglebusinessLastsync { get; set; } 

        [JsonProperty("google_reviewdefaultusersite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? GoogleReviewdefaultusersiteName { get; set; } 

        [JsonProperty("google_questiondefaultusersite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? GoogleQuestiondefaultusersiteName { get; set; } 

        [JsonProperty("device_tenantids_strings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<string>? DeviceTenantidsStrings { get; set; } 

        [JsonProperty("twilio_account_sid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TwilioAccountSid { get; set; } 

        [JsonProperty("halointegrator_googlecalendars", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorGooglecalendars { get; set; } 

        [JsonProperty("halointegrator_googlecalendars_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorGooglecalendarsLastsync { get; set; } 

        [JsonProperty("halointegrator_googlecalendars_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorGooglecalendarsLasterror { get; set; } 

        [JsonProperty("aireports_enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AireportsEnabled { get; set; } 

        [JsonProperty("halointegrator_wordpressorg", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorWordpressorg { get; set; } 

        [JsonProperty("halointegrator_wordpressorg_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorWordpressorgLastsync { get; set; } 

        [JsonProperty("halointegrator_wordpressorg_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorWordpressorgLasterror { get; set; } 

        [JsonProperty("reset_halointegrator_wordpressorg_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ResetHaloIntegratorWordpressorgLastsync { get; set; } 

        [JsonProperty("halointegrator_splashtop", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorSplashtop { get; set; } 

        [JsonProperty("halointegrator_splashtop_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorSplashtopLastsync { get; set; } 

        [JsonProperty("halointegrator_splashtop_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorSplashtopLasterror { get; set; } 

        [JsonProperty("gocardless_userfieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? GocardlessUserfieldmappings { get; set; } 

        [JsonProperty("gocardless_defaultsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? GocardlessDefaultsiteName { get; set; } 

        [JsonProperty("halointegrator_gocardless", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorGocardless { get; set; } 

        [JsonProperty("halointegrator_gocardless_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorGocardlessLastsync { get; set; } 

        [JsonProperty("halointegrator_gocardless_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorGocardlessLasterror { get; set; } 

        [JsonProperty("reset_halointegrator_gocardless_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ResetHaloIntegratorGocardlessLastsync { get; set; } 

        [JsonProperty("prometheus_api_url_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? PrometheusApiUrlList { get; set; } 

        [JsonProperty("aidetection_enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AidetectionEnabled { get; set; } 

        [JsonProperty("itglue_sync_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? ItglueSyncEntitiesList { get; set; } 

        [JsonProperty("slack_command_workspaces", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? SlackCommandWorkspaces { get; set; } 

        [JsonProperty("meraki_top_level_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? MerakiTopLevelName { get; set; } 

        [JsonProperty("meraki_client_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLinkList>? MerakiClientMappings { get; set; } 

        [JsonProperty("meraki_device_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? MerakiDeviceFieldmappings { get; set; } 

        [JsonProperty("merakidefaultassettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? MerakidefaultassettypeName { get; set; } 

        [JsonProperty("meraki_xtype_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<XTypeMapping>? MerakiXtypeMappings { get; set; } 

        [JsonProperty("halointegrator_meraki", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorMeraki { get; set; } 

        [JsonProperty("halointegrator_meraki_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorMerakiLastsync { get; set; } 

        [JsonProperty("halointegrator_meraki_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorMerakiLasterror { get; set; } 

        [JsonProperty("meraki_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? MerakiUrl { get; set; } 

        [JsonProperty("saml_certififcate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SamlCertififcate { get; set; } 

        [JsonProperty("whatsapp_defaultclientsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? WhatsappDefaultclientsiteName { get; set; } 

        [JsonProperty("xsoar_default_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? XsoarDefaultUsername { get; set; } 

        [JsonProperty("halointegrator_adobecommerce", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorAdobecommerce { get; set; } 

        [JsonProperty("halointegrator_adobecommerce_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorAdobecommerceLastsync { get; set; } 

        [JsonProperty("halointegrator_adobecommerce_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorAdobecommerceLasterror { get; set; } 

        [JsonProperty("adobecommercedefaultsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AdobecommercedefaultsiteName { get; set; } 

        [JsonProperty("adobecommerce_import_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? AdobecommerceImportEntitiesList { get; set; } 

        [JsonProperty("openai_enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? OpenaiEnabled { get; set; } 

        [JsonProperty("azureopenai_enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AzureopenaiEnabled { get; set; } 

        [JsonProperty("azureopenai_embedding_enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AzureopenaiEmbeddingEnabled { get; set; } 

        [JsonProperty("azureaisearch_demo_enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AzureaisearchDemoEnabled { get; set; } 

        [JsonProperty("freshdesk_statusfilter_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? FreshdeskStatusfilterList { get; set; } 

        [JsonProperty("distributionlists_defaultsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DistributionlistsDefaultsiteName { get; set; } 

        [JsonProperty("workspace_mobilemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? WorkspaceMobilemappings { get; set; } 

        [JsonProperty("workspace_mappings_xtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<XTypeMapping>? WorkspaceMappingsXtype { get; set; } 

        [JsonProperty("_index_kbs_now", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IndexKbsNow { get; set; } 

        [JsonProperty("_index_services_now", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IndexServicesNow { get; set; } 

        [JsonProperty("home_html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HomeHtml { get; set; } 

        [JsonProperty("home_html_top", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HomeHtmlTop { get; set; } 

        [JsonProperty("agent_presence_rules", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AgentPresenceRule>? AgentPresenceRules { get; set; } 

        [JsonProperty("halointegrator_mailchimp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorMailchimp { get; set; } 

        [JsonProperty("halointegrator_mailchimp_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorMailchimpLastsync { get; set; } 

        [JsonProperty("halointegrator_mailchimp_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorMailchimpLasterror { get; set; } 

        [JsonProperty("mailchimp_import_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? MailchimpImportEntitiesList { get; set; } 

        [JsonProperty("reset_halointegrator_mailchimp_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ResetHaloIntegratorMailchimpLastsync { get; set; } 

        [JsonProperty("quoteapprovalfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<TicketTypeField>? Quoteapprovalfields { get; set; } 

        [JsonProperty("recordonlinepresence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Recordonlinepresence { get; set; } 

        [JsonProperty("exchange_agent_subscriptions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AgentEventSubscription>? ExchangeAgentSubscriptions { get; set; } 

        [JsonProperty("_do_convert_to_prospects", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DoConvertToProspects { get; set; } 

        [JsonProperty("dynamicscrm_customtable_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Dynamics365CrmFieldMapping>? DynamicscrmCustomtableMappings { get; set; } 

        [JsonProperty("webdashboardtitle_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? WebdashboardtitleOverride { get; set; } 

        [JsonProperty("contractapprovalfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<TicketTypeField>? Contractapprovalfields { get; set; } 

        [JsonProperty("sccm_dontupdatetype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SccmDontupdatetype { get; set; } 

        [JsonProperty("lansweeper_dontupdatetype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? LansweeperDontupdatetype { get; set; } 

        [JsonProperty("portal_requestor_display_attribute1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PortalRequestorDisplayAttribute1 { get; set; } 

        [JsonProperty("portal_requestor_display_attribute2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PortalRequestorDisplayAttribute2 { get; set; } 

        [JsonProperty("converted_currency_rounding_behaviour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ConvertedCurrencyRoundingBehaviour { get; set; } 

        [JsonProperty("agent_status_reassign_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AgentStatusReassignMapping>? AgentStatusReassignMappings { get; set; } 

        [JsonProperty("new_integration_key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewIntegrationKey { get; set; } 

        [JsonProperty("new_integration_key2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewIntegrationKey2 { get; set; } 

        [JsonProperty("new_integration_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? NewIntegrationMethod { get; set; } 

        [JsonProperty("new_integration_webhook_key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewIntegrationWebhookKey { get; set; } 

        [JsonProperty("integration_webhook_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? IntegrationWebhookUsername { get; set; } 

        [JsonProperty("new_integration_webhook_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? NewIntegrationWebhookMethod { get; set; } 

        [JsonProperty("atera_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AteraUrl { get; set; } 

        [JsonProperty("businesscentral_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? BusinesscentralUrl { get; set; } 

        [JsonProperty("businesscentral_appid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? BusinesscentralAppid { get; set; } 

        [JsonProperty("businesscentral_domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? BusinesscentralDomain { get; set; } 

        [JsonProperty("businesscentral_tokenexpiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? BusinesscentralTokenexpiry { get; set; } 

        [JsonProperty("businesscentral_redirect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? BusinesscentralRedirect { get; set; } 

        [JsonProperty("businesscentral_authorised", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? BusinesscentralAuthorised { get; set; } 

        [JsonProperty("dynamicscrm_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DynamicscrmUrl { get; set; } 

        [JsonProperty("dynamicscrm_appid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DynamicscrmAppid { get; set; } 

        [JsonProperty("dynamicscrm_domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DynamicscrmDomain { get; set; } 

        [JsonProperty("dynamicscrm_tokenexpiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? DynamicscrmTokenexpiry { get; set; } 

        [JsonProperty("dynamicscrm_redirect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DynamicscrmRedirect { get; set; } 

        [JsonProperty("dynamicscrm_authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DynamicscrmAuthorized { get; set; } 

        [JsonProperty("exchange_application_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ExchangeApplicationId { get; set; } 

        [JsonProperty("exchange_tenant_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ExchangeTenantId { get; set; } 

        [JsonProperty("exchange_token_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? ExchangeTokenExpiry { get; set; } 

        [JsonProperty("exchange_redirect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ExchangeRedirect { get; set; } 

        [JsonProperty("exchange_authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ExchangeAuthorized { get; set; } 

        [JsonProperty("device42_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Device42Url { get; set; } 

        [JsonProperty("device42_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Device42Username { get; set; } 

        [JsonProperty("prtg_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PrtgUrl { get; set; } 

        [JsonProperty("prtg_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PrtgUsername { get; set; } 

        [JsonProperty("prtg_password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PrtgPassword { get; set; } 

        [JsonProperty("gfi_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? GfiUrl { get; set; } 

        [JsonProperty("soc_api_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SocApiId { get; set; } 

        [JsonProperty("qbo_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? QboClientId { get; set; } 

        [JsonProperty("qbo_token_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? QboTokenExpiry { get; set; } 

        [JsonProperty("qbo_authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? QboAuthorized { get; set; } 

        [JsonProperty("qbo_redirect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? QboRedirect { get; set; } 

        [JsonProperty("qbo_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? QboUrl { get; set; } 

        [JsonProperty("sage50password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sage50Password { get; set; } 

        [JsonProperty("servicenow_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ServicenowUrl { get; set; } 

        [JsonProperty("servicenow_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ServicenowUsername { get; set; } 

        [JsonProperty("autotask_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AutotaskUsername { get; set; } 

        [JsonProperty("connectwise_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ConnectwiseUrl { get; set; } 

        [JsonProperty("connectwise_public_key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ConnectwisePublicKey { get; set; } 

        [JsonProperty("connectwise_private_key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ConnectwisePrivateKey { get; set; } 

        [JsonProperty("ninja_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NinjaUrl { get; set; } 

        [JsonProperty("ninja_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NinjaClientId { get; set; } 

        [JsonProperty("ninja_authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? NinjaAuthorized { get; set; } 

        [JsonProperty("ninja_token_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? NinjaTokenExpiry { get; set; } 

        [JsonProperty("ninja_redirect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NinjaRedirect { get; set; } 

        [JsonProperty("itglue_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ItglueUrl { get; set; } 

        [JsonProperty("snelstart_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SnelstartUrl { get; set; } 

        [JsonProperty("snelstart_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SnelstartClientId { get; set; } 

        [JsonProperty("snelstart_authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SnelstartAuthorized { get; set; } 

        [JsonProperty("snelstart_token_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? SnelstartTokenExpiry { get; set; } 

        [JsonProperty("jamf_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? JamfUrl { get; set; } 

        [JsonProperty("jamf_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? JamfUsername { get; set; } 

        [JsonProperty("interact_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? InteractUrl { get; set; } 

        [JsonProperty("interact_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? InteractUsername { get; set; } 

        [JsonProperty("interact_tenant", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? InteractTenant { get; set; } 

        [JsonProperty("interact_token_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? InteractTokenExpiry { get; set; } 

        [JsonProperty("gw_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? GwUrl { get; set; } 

        [JsonProperty("gw_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? GwClientId { get; set; } 

        [JsonProperty("gw_token_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? GwTokenExpiry { get; set; } 

        [JsonProperty("gw_redirect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? GwRedirect { get; set; } 

        [JsonProperty("gw_authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? GwAuthorized { get; set; } 

        [JsonProperty("scomservername", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Scomservername { get; set; } 

        [JsonProperty("scomdomain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Scomdomain { get; set; } 

        [JsonProperty("scomusername", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Scomusername { get; set; } 

        [JsonProperty("scompassword", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Scompassword { get; set; } 

        [JsonProperty("scom_access", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ScomAccess { get; set; } 

        [JsonProperty("orion_server_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OrionServerName { get; set; } 

        [JsonProperty("orion_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OrionUsername { get; set; } 

        [JsonProperty("orion_password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OrionPassword { get; set; } 

        [JsonProperty("orion_access", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? OrionAccess { get; set; } 

        [JsonProperty("beyondtrust_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? BeyondtrustUrl { get; set; } 

        [JsonProperty("beyondtrust_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? BeyondtrustUsername { get; set; } 

        [JsonProperty("beyondtrust_token_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? BeyondtrustTokenExpiry { get; set; } 

        [JsonProperty("beyondtrust_authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? BeyondtrustAuthorized { get; set; } 

        [JsonProperty("sentinel_token_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? SentinelTokenExpiry { get; set; } 

        [JsonProperty("sentinel_redirect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SentinelRedirect { get; set; } 

        [JsonProperty("sentinel_authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SentinelAuthorized { get; set; } 

        [JsonProperty("syncro_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SyncroUrl { get; set; } 

        [JsonProperty("domotz_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DomotzUrl { get; set; } 

        [JsonProperty("g2aremote_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? G2AremoteClientId { get; set; } 

        [JsonProperty("automate_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AutomateUrl { get; set; } 

        [JsonProperty("automate_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AutomateUsername { get; set; } 

        [JsonProperty("g2aremote_authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? G2AremoteAuthorized { get; set; } 

        [JsonProperty("automate_token_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? AutomateTokenExpiry { get; set; } 

        [JsonProperty("g2aremote_refresh_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? G2AremoteRefreshToken { get; set; } 

        [JsonProperty("g2aremote_token_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? G2AremoteTokenExpiry { get; set; } 

        [JsonProperty("g2aremote_redirect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? G2AremoteRedirect { get; set; } 

        [JsonProperty("snow_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SnowUsername { get; set; } 

        [JsonProperty("snow_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SnowUrl { get; set; } 

        [JsonProperty("auvik_tenant", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AuvikTenant { get; set; } 

        [JsonProperty("auvik_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AuvikUsername { get; set; } 

        [JsonProperty("hubspot_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HubspotUrl { get; set; } 

        [JsonProperty("hubspot_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HubspotClientId { get; set; } 

        [JsonProperty("hubspot_authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HubspotAuthorized { get; set; } 

        [JsonProperty("hubspot_token_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HubspotTokenExpiry { get; set; } 

        [JsonProperty("hubspot_redirect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HubspotRedirect { get; set; } 

        [JsonProperty("qualys_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? QualysUrl { get; set; } 

        [JsonProperty("qualys_domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? QualysDomain { get; set; } 

        [JsonProperty("qualys_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? QualysUsername { get; set; } 

        [JsonProperty("azuretranslate_region", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AzuretranslateRegion { get; set; } 

        [JsonProperty("azuretranslate_currentusage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? AzuretranslateCurrentusage { get; set; } 

        [JsonProperty("passportal_apikey", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PassportalApikey { get; set; } 

        [JsonProperty("passportal_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PassportalUrl { get; set; } 

        [JsonProperty("passportal_refresh_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PassportalRefreshToken { get; set; } 

        [JsonProperty("passportal_token_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? PassportalTokenExpiry { get; set; } 

        [JsonProperty("hudu_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HuduUrl { get; set; } 

        [JsonProperty("cipp_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CippUrl { get; set; } 

        [JsonProperty("intacct_sender_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? IntacctSenderId { get; set; } 

        [JsonProperty("intacct_company_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? IntacctCompanyId { get; set; } 

        [JsonProperty("intacct_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? IntacctUsername { get; set; } 

        [JsonProperty("backupradar_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? BackupradarUrl { get; set; } 

        [JsonProperty("addigy_clientid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AddigyClientid { get; set; } 

        [JsonProperty("ingram_micro_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? IngramMicroUrl { get; set; } 

        [JsonProperty("ingram_micro_marketplace", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? IngramMicroMarketplace { get; set; } 

        [JsonProperty("ingram_micro_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? IngramMicroUsername { get; set; } 

        [JsonProperty("ingram_micro_token_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? IngramMicroTokenExpiry { get; set; } 

        [JsonProperty("freshdesk_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? FreshdeskUrl { get; set; } 

        [JsonProperty("liongard_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? LiongardUrl { get; set; } 

        [JsonProperty("liongard_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? LiongardClientId { get; set; } 

        [JsonProperty("salesforce_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SalesforceClientId { get; set; } 

        [JsonProperty("pax8_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Pax8ClientId { get; set; } 

        [JsonProperty("salesforce_authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SalesforceAuthorized { get; set; } 

        [JsonProperty("pax8_token_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Pax8TokenExpiry { get; set; } 

        [JsonProperty("salesforce_refresh_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SalesforceRefreshToken { get; set; } 

        [JsonProperty("salesforce_token_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? SalesforceTokenExpiry { get; set; } 

        [JsonProperty("salesforce_redirect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SalesforceRedirect { get; set; } 

        [JsonProperty("salesforce_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SalesforceUrl { get; set; } 

        [JsonProperty("client_secret_newrelic", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ClientSecretNewrelic { get; set; } 

        [JsonProperty("newrelicuser_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewrelicuserName { get; set; } 

        [JsonProperty("newrelic_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewrelicUrl { get; set; } 

        [JsonProperty("new_glclientsecret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewGlclientsecret { get; set; } 

        [JsonProperty("kaseya_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? KaseyaClientId { get; set; } 

        [JsonProperty("kaseya_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? KaseyaUrl { get; set; } 

        [JsonProperty("kaseya_authorised", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? KaseyaAuthorised { get; set; } 

        [JsonProperty("kaseya_alert_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? KaseyaAlertUserName { get; set; } 

        [JsonProperty("kaseya_servicedesks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? KaseyaServicedesks { get; set; } 

        [JsonProperty("chat_service_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ChatServiceUrl { get; set; } 

        [JsonProperty("report_service_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ReportServiceUrl { get; set; } 

        [JsonProperty("zabbix_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ZabbixUrl { get; set; } 

        [JsonProperty("zabbix_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ZabbixUsername { get; set; } 

        [JsonProperty("rhipe_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? RhipeClientId { get; set; } 

        [JsonProperty("techdata_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TechdataClientId { get; set; } 

        [JsonProperty("inty_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? IntyUrl { get; set; } 

        [JsonProperty("inty_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? IntyUsername { get; set; } 

        [JsonProperty("westcoastcloud_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? WestcoastcloudUrl { get; set; } 

        [JsonProperty("westcoastcloud_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? WestcoastcloudUsername { get; set; } 

        [JsonProperty("sherweb_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SherwebClientId { get; set; } 

        [JsonProperty("sherweb_tenant", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SherwebTenant { get; set; } 

        [JsonProperty("also_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AlsoUrl { get; set; } 

        [JsonProperty("also_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AlsoUsername { get; set; } 

        [JsonProperty("dickerdata_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DickerdataUrl { get; set; } 

        [JsonProperty("quoter_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? QuoterUrl { get; set; } 

        [JsonProperty("quoter_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? QuoterClientId { get; set; } 

        [JsonProperty("halolink_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HalolinkUrl { get; set; } 

        [JsonProperty("halolink_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HalolinkClientId { get; set; } 

        [JsonProperty("includechatsettings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Includechatsettings { get; set; } 

        [JsonProperty("includeprsettings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Includeprsettings { get; set; } 

        [JsonProperty("includeintegrationsettings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Includeintegrationsettings { get; set; } 

        [JsonProperty("includebillingsettings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Includebillingsettings { get; set; } 

        [JsonProperty("includeemailsettings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Includeemailsettings { get; set; } 

        [JsonProperty("includechangefreezesettings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Includechangefreezesettings { get; set; } 

        [JsonProperty("includeportalsettings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Includeportalsettings { get; set; } 

        [JsonProperty("includerecurringinvoicesettings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Includerecurringinvoicesettings { get; set; } 

        [JsonProperty("includequotesettings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Includequotesettings { get; set; } 

        [JsonProperty("includecontractsettings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Includecontractsettings { get; set; } 

        [JsonProperty("integrationmoduleid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Integrationmoduleid { get; set; } 

        [JsonProperty("includeresourcebookingsettings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Includeresourcebookingsettings { get; set; } 

        [JsonProperty("includecalendarsettings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Includecalendarsettings { get; set; } 

        [JsonProperty("includeadvancedsettings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Includeadvancedsettings { get; set; } 

        [JsonProperty("gw_scopes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<string>? GwScopes { get; set; } 

        [JsonProperty("gw_asset_scopes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? GwAssetScopes { get; set; } 

        [JsonProperty("pagerduty_services", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<PagerDutyMapping>? PagerdutyServices { get; set; } 

        [JsonProperty("integration_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? IntegrationClientId { get; set; } 

        [JsonProperty("whatsapp_authorised", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? WhatsappAuthorised { get; set; } 

        [JsonProperty("logicmonitor_access_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? LogicmonitorAccessId { get; set; } 

        [JsonProperty("openai_default_model", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OpenaiDefaultModel { get; set; } 

        [JsonProperty("azure_openai_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AzureOpenaiUrl { get; set; } 

        [JsonProperty("azure_openai_version", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AzureOpenaiVersion { get; set; } 

        [JsonProperty("azure_ai_search_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AzureAiSearchUrl { get; set; } 

        [JsonProperty("azure_ai_search_version", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AzureAiSearchVersion { get; set; } 

        [JsonProperty("integration_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? IntegrationUrl { get; set; } 

        [JsonProperty("integration_tenant", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? IntegrationTenant { get; set; } 

        [JsonProperty("openai_embeddings_tickettypes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<TicketTypeList>? OpenaiEmbeddingsTicketTypes { get; set; } 

        [JsonProperty("azureopenai_embeddings_tickettypes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<TicketTypeList>? AzureopenaiEmbeddingsTicketTypes { get; set; } 

        [JsonProperty("aiembedding_enabled_tickettypes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair4>? AiembeddingEnabledTicketTypes { get; set; } 

        [JsonProperty("vectorise_tickettypes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<TicketTypeList>? VectoriseTicketTypes { get; set; } 

        [JsonProperty("vectorise_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? VectoriseDate { get; set; } 

        [JsonProperty("opsgenie_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OpsgenieUrl { get; set; } 

        [JsonProperty("opsgenie_instance_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OpsgenieInstanceUrl { get; set; } 

        [JsonProperty("teams_tenant_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TeamsTenantId { get; set; } 

        [JsonProperty("teams_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TeamsClientId { get; set; } 

        [JsonProperty("teams_authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? TeamsAuthorized { get; set; } 

        [JsonProperty("freshdesk_status_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? FreshdeskStatusMappings { get; set; } 

        [JsonProperty("freshdesk_priority_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? FreshdeskPriorityMappings { get; set; } 

        [JsonProperty("freshdesk_team_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? FreshdeskTeamMappings { get; set; } 

        [JsonProperty("freshdesk_field_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? FreshdeskFieldMappings { get; set; } 

        [JsonProperty("coralogix_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CoralogixUrl { get; set; } 

        [JsonProperty("coralogix_uuid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CoralogixUuid { get; set; } 

        [JsonProperty("gw_mobile_scopes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? GwMobileScopes { get; set; } 

        [JsonProperty("mailchimp_authorised", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? MailchimpAuthorised { get; set; } 

        [JsonProperty("zendesk_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ZendeskUrl { get; set; } 

        [JsonProperty("zendesk_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ZendeskEmail { get; set; } 

        [JsonProperty("teamsshifts_tenant_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TeamsshiftsTenantId { get; set; } 

        [JsonProperty("teamsshifts_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TeamsshiftsClientId { get; set; } 

        [JsonProperty("teamsshifts_authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? TeamsshiftsAuthorized { get; set; } 

        [JsonProperty("teamsshifts_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<MicrosoftTeamsMapping>? TeamsshiftsMappings { get; set; } 

        [JsonProperty("halointegrator_microsoftteams", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorMicrosoftteams { get; set; } 

        [JsonProperty("halointegrator_microsoftteams_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorMicrosoftteamsLastsync { get; set; } 

        [JsonProperty("halointegrator_microsoftteams_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorMicrosoftteamsLasterror { get; set; } 

        [JsonProperty("reset_halointegrator_microsoftteams_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ResetHaloIntegratorMicrosoftteamsLastsync { get; set; } 

        [JsonProperty("hopewiser_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HopewiserUser { get; set; } 

        [JsonProperty("hopewiser_maf", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HopewiserMaf { get; set; } 

        [JsonProperty("teamsshifts_shifttype_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLinkList>? TeamsshiftsShifttypeMappings { get; set; } 

        [JsonProperty("webhook_iterations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? WebhookIterations { get; set; } 

    }