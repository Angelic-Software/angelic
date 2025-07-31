using Angelic.Models.KeyPairs;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Advanced.Controls;

public partial class Control
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; }

    [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Intent { get; set; }

    [JsonProperty("app_version", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AppVersion { get; set; }

    [JsonProperty("app_version_nopatch", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AppVersionNoPatch { get; set; }

    [JsonProperty("database_version", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DatabaseVersion { get; set; }

    [JsonProperty("appname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AppName { get; set; }

    [JsonProperty("license_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? LicenseCount { get; set; }

    [JsonProperty("concurrent_license_count", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? ConcurrentLicenseCount { get; set; }

    [JsonProperty("license_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? LicenseName { get; set; }

    [JsonProperty("trial_expires", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? TrialExpires { get; set; }

    [JsonProperty("licence_error", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? LicenceError { get; set; }

    [JsonProperty("syncid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SyncId { get; set; }

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
    public bool? ShowTopLevels { get; set; }

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

    [JsonProperty("sendackemailsforwebrequests", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? SendAckemailsforwebrequests { get; set; }

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
    public bool? PortalAllowkbsearch { get; set; }

    [JsonProperty("portalallowservicesearch", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? PortalAllowservicesearch { get; set; }

    [JsonProperty("portalallowticketsearch", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? PortalAllowticketsearch { get; set; }

    [JsonProperty("multientitysearchincludefaults", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? Multientitysearchincludefaults { get; set; }

    [JsonProperty("multientitysearchincludekbentry", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? Multientitysearchincludekbentry { get; set; }

    [JsonProperty("multientitysearchincludedevice", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? Multientitysearchincludedevice { get; set; }

    [JsonProperty("multientitysearchincludearea", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? Multientitysearchincludearea { get; set; }

    [JsonProperty("multientitysearchincludesite", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? Multientitysearchincludesite { get; set; }

    [JsonProperty("multientitysearchincludeusers", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? Multientitysearchincludeusers { get; set; }

    [JsonProperty("multientitysearchincludecompany", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? Multientitysearchincludecompany { get; set; }

    [JsonProperty("multientitysearchincludeitem", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? Multientitysearchincludeitem { get; set; }

    [JsonProperty("multientitysearchincludequote", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? Multientitysearchincludequote { get; set; }

    [JsonProperty("multientitysearchincludeso", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? Multientitysearchincludeso { get; set; }

    [JsonProperty("multientitysearchincludepo", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? Multientitysearchincludepo { get; set; }

    [JsonProperty("multientitysearchincludeservices", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? Multientitysearchincludeservices { get; set; }

    [JsonProperty("showquicksearch", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowQuicksearch { get; set; }

    [JsonProperty("showtreesearch", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowTreesearch { get; set; }

    [JsonProperty("defaultpdftemplatecredit", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultPdfTemplatecredit { get; set; }

    [JsonProperty("allownewuserfromchangeuserscreen", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? Allownewuserfromchangeuserscreen { get; set; }

    [JsonProperty("adselfservicewebapppwdresettype", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
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

    [JsonProperty("showprepaybalanceonticket", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowPrepayBalanceonticket { get; set; }

    [JsonProperty("ssorememberme", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Ssorememberme { get; set; }

    [JsonProperty("eupallowsiteselection", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Eupallowsiteselection { get; set; }

    [JsonProperty("showtemplateselectionbutton", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowTemplateselectionbutton { get; set; }

    [JsonProperty("showsaveastemplatebutton", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowSaveastemplatebutton { get; set; }

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

    [JsonProperty("updateticketwhenpoinstock", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? UpdateTicketwhenpoinstock { get; set; }

    [JsonProperty("updateticketwhenpoinstockstatus", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? UpdateTicketwhenpoinstockstatus { get; set; }

    [JsonProperty("updateticketwhenpoinstockstatus_guid", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public Guid? UpdateTicketwhenpoinstockstatusGuid { get; set; }

    [JsonProperty("allowstockreserve", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Allowstockreserve { get; set; }

    [JsonProperty("budgetcalctype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Budgetcalctype { get; set; }

    [JsonProperty("periodsaheadforcontractinvoicestart", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? Periodsaheadforcontractinvoicestart { get; set; }

    [JsonProperty("defaultcontractenddatetype", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultContractenddatetype { get; set; }

    [JsonProperty("encthumbprint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Encthumbprint { get; set; }

    [JsonProperty("homescreendashboardid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Homescreendashboardid { get; set; }

    [JsonProperty("sidemenudashboardid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sidemenudashboardid { get; set; }

    [JsonProperty("loadimagesfromapitype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Loadimagesfromapitype { get; set; }

    [JsonProperty("loadattachmentsfromapitype", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? Loadattachmentsfromapitype { get; set; }

    [JsonProperty("loadimagesfromapilocation", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public string? Loadimagesfromapilocation { get; set; }

    [JsonProperty("loadimagesfromapiurloverride", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public string? Loadimagesfromapiurloverride { get; set; }

    [JsonProperty("allowlivechatonnewportal", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? Allowlivechatonnewportal { get; set; }

    [JsonProperty("allowtaxcodeoverride", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Allowtaxcodeoverride { get; set; }

    [JsonProperty("mergerecurringinvoices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Mergerecurringinvoices { get; set; }

    [JsonProperty("mergesalesorderinvoices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Mergesalesorderinvoices { get; set; }

    [JsonProperty("showusersassetsonticket", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowUsersassetsonticket { get; set; }

    [JsonProperty("showusersassetsoncall", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowUsersassetsoncall { get; set; }

    [JsonProperty("enablementions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Enablementions { get; set; }

    [JsonProperty("enablementionscrm", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Enablementionscrm { get; set; }

    [JsonProperty("enableteammentions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? EnableTeammentions { get; set; }

    [JsonProperty("usetechfwdfunctionalityupdateparent", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
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

    [JsonProperty("enablemyscheduledreports", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? Enablemyscheduledreports { get; set; }

    [JsonProperty("showquotecannedonapprovalscreen", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowQuotecannedonapprovalscreen { get; set; }

    [JsonProperty("enableagentbooking", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? EnableAgentbooking { get; set; }

    [JsonProperty("agentbooking_min_hours_advance", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public double? AgentbookingMinHoursAdvance { get; set; }

    [JsonProperty("agentbooking_max_days_advance", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public double? AgentbookingMaxDaysAdvance { get; set; }

    [JsonProperty("agentbookingonlyauthenticated", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
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

    [JsonProperty("detailsscreendisplaytype", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? Detailsscreendisplaytype { get; set; }

    [JsonProperty("navdisplaymode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Navdisplaymode { get; set; }

    [JsonProperty("usesemanticversioning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Usesemanticversioning { get; set; }

    [JsonProperty("usesecurequotesigning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Usesecurequotesigning { get; set; }

    [JsonProperty("timefieldinputtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Timefieldinputtype { get; set; }

    [JsonProperty("ticketdetailstitledisplaymode", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
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

    [JsonProperty("translationmonthlycharactercap", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public long? Translationmonthlycharactercap { get; set; }

    [JsonProperty("translationmonthlycharactercapcanedit", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? Translationmonthlycharactercapcanedit { get; set; }

    [JsonProperty("crmshowextradetails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Crmshowextradetails { get; set; }

    [JsonProperty("defaultclientdetailslayout", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultClientDetailslayout { get; set; }

    [JsonProperty("kbviewagentapp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Kbviewagentapp { get; set; }

    [JsonProperty("enablefulltextsearchactions", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? Enablefulltextsearchactions { get; set; }

    [JsonProperty("addressfieldtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Addressfieldtype { get; set; }

    [JsonProperty("livechatconnectionmethod", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? LiveChatconnectionmethod { get; set; }

    [JsonProperty("portalchatprofile", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PortalChatProfile { get; set; }

    [JsonProperty("sage50ukinvoicetype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sage50Ukinvoicetype { get; set; }

    [JsonProperty("twilliosmsaccountsid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Twilliosmsaccountsid { get; set; }

    [JsonProperty("twilliosmsauthtoken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Twilliosmsauthtoken { get; set; }

    [JsonProperty("new_twilliosmsauthtoken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewTwilliosmsauthtoken { get; set; }

    [JsonProperty("twilliosmsfromphonenumber", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public string? Twilliosmsfromphonenumber { get; set; }

    [JsonProperty("twilliosmsleadingzerosubstitute", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public string? Twilliosmsleadingzerosubstitute { get; set; }

    [JsonProperty("smstype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SmsType { get; set; }

    [JsonProperty("connectwisemanageclientid", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public string? ConnectWisemanageclientid { get; set; }

    [JsonProperty("showallphonenumbersonticketdetails", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowAllphonenumbersonticketdetails { get; set; }

    [JsonProperty("sendaccountmanagernotifications", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? SendAccountmanagernotifications { get; set; }

    [JsonProperty("useutcforappointments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Useutcforappointments { get; set; }

    [JsonProperty("stopautomaticdevicemovementsinstock", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? Stopautomaticdevicemovementsinstock { get; set; }

    [JsonProperty("setdisplaynametoagentname", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? Setdisplaynametoagentname { get; set; }

    [JsonProperty("livechatjoinmode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? LiveChatjoinmode { get; set; }

    [JsonProperty("chatshownewbubble", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Chatshownewbubble { get; set; }

    [JsonProperty("automateticketscriptid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Automateticketscriptid { get; set; }

    [JsonProperty("automateticketscriptentityid", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? Automateticketscriptentityid { get; set; }

    [JsonProperty("syncingxeroproducts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Syncingxeroproducts { get; set; }

    [JsonProperty("report_colour_palette", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ReportColourPalette { get; set; }

    [JsonProperty("enablehalostripe", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Enablehalostripe { get; set; }

    [JsonProperty("enablehalostripewebhooks", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? Enablehalostripewebhooks { get; set; }

    [JsonProperty("donotcreateuser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DoNotcreateuser { get; set; }

    [JsonProperty("attachmentstabtable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Attachmentstabtable { get; set; }

    [JsonProperty("enablehalonews", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Enablehalonews { get; set; }

    [JsonProperty("enablestockbins", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Enablestockbins { get; set; }

    [JsonProperty("defaultstockbinlocation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultStockbinlocation { get; set; }

    [JsonProperty("defaultmovestocklocation", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultMovestocklocation { get; set; }

    [JsonProperty("defaultmovestockbinlocation", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultMovestockbinlocation { get; set; }

    [JsonProperty("enableportalgdprscreen", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Enableportalgdprscreen { get; set; }

    [JsonProperty("autocreatecustomerreference", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? Autocreatecustomerreference { get; set; }

    [JsonProperty("autogenerate_itemaccountsid", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? AutogenerateItemaccountsid { get; set; }

    [JsonProperty("useeventservice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Useeventservice { get; set; }

    [JsonProperty("useschedulingservice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Useschedulingservice { get; set; }

    [JsonProperty("timesensitivemethod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Timesensitivemethod { get; set; }

    [JsonProperty("usedefaultsubjectmatchingtag", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? Usedefaultsubjectmatchingtag { get; set; }

    [JsonProperty("useprepaypurchasedatesforcalculatingbalance", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? Useprepaypurchasedatesforcalculatingbalance { get; set; }

    [JsonProperty("sagebusinessclouddefaulttenantid", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? Sagebusinessclouddefaulttenantid { get; set; }

    [JsonProperty("sagebusinesscloud_default_invoice_status", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? SagebusinesscloudDefaultInvoiceStatus { get; set; }

    [JsonProperty("sagebusinesscloud_default_invoice_status_guid", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public Guid? SagebusinesscloudDefaultInvoiceStatusGuid { get; set; }

    [JsonProperty("publishchangecalendartype", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? Publishchangecalendartype { get; set; }

    [JsonProperty("xero_post_group_headers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? XeroPostGroupHeaders { get; set; }

    [JsonProperty("responsedontassign", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ResponseDontassign { get; set; }

    [JsonProperty("automaticallysendsignedticketclosurepdf", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? Automaticallysendsignedticketclosurepdf { get; set; }

    [JsonProperty("linkrecurringapptticket", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Linkrecurringapptticket { get; set; }

    [JsonProperty("closetaskswhenclosingticket", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? Closetaskswhenclosingticket { get; set; }

    [JsonProperty("assetserializationtabbehaviour", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? Assetserializationtabbehaviour { get; set; }

    [JsonProperty("showassettagongoodsout", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowAssettagongoodsout { get; set; }

    [JsonProperty("mustsetcustomerfirst", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Mustsetcustomerfirst { get; set; }

    [JsonProperty("dontsendacktononsitedomain", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? DontSendAcktononsitedomain { get; set; }

    [JsonProperty("salesorderstatusafterinvoiced", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? SalesOrderstatusafterinvoiced { get; set; }

    [JsonProperty("salesorderstatusafterinvoicedandactionscomplete", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? SalesOrderstatusafterinvoicedandactionscomplete { get; set; }

    [JsonProperty("defaultfornewopportunityuser", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultFornewopportunityuser { get; set; }

    [JsonProperty("donotshowwarrantyexpiration", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? DoNotshowwarrantyexpiration { get; set; }

    [JsonProperty("hide_default_opps_area", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? HideDefaultOppsArea { get; set; }

    [JsonProperty("show_asset_diagram_services", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowAssetDiagramServices { get; set; }

    [JsonProperty("portal_kb_matching_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PortalKbMatchingType { get; set; }

    [JsonProperty("checkticketclashes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Checkticketclashes { get; set; }

    [JsonProperty("enable_contract_rollover", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? EnableContractRollover { get; set; }

    [JsonProperty("contract_usage_next_month_percent", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public double? ContractUsageNextMonthPercent { get; set; }

    [JsonProperty("ninja_alert_webhooks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? NinjaAlertWebhooks { get; set; }

    [JsonProperty("additionalresponseactioninfo", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? Additionalresponseactioninfo { get; set; }

    [JsonProperty("quoter_default_template", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? QuoterDefaultTemplate { get; set; }

    [JsonProperty("quoter_instance_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? QuoterInstanceUrl { get; set; }

    [JsonProperty("quoter_open_contact_form", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? QuoterOpenContactForm { get; set; }

    [JsonProperty("quoter_create_sales_orders", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
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

    [JsonProperty("preventclashchangelogging", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? Preventclashchangelogging { get; set; }

    [JsonProperty("exactdefaultdivision", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Exactdefaultdivision { get; set; }

    [JsonProperty("removewelcomemessage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Removewelcomemessage { get; set; }

    [JsonProperty("new_search_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? NewSearchType { get; set; }

    [JsonProperty("limit_action_search", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? LimitActionSearch { get; set; }

    [JsonProperty("app_scheduler_show_all_agents", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? AppSchedulerShowAllAgents { get; set; }

    [JsonProperty("enableagentcheckins", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? EnableAgentcheckins { get; set; }

    [JsonProperty("nabledeletedevices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? NAbledeletedevices { get; set; }

    [JsonProperty("allow_user_impersonation", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowUserImpersonation { get; set; }

    [JsonProperty("allow_agent_impersonation", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowAgentImpersonation { get; set; }

    [JsonProperty("copy_attachments_area", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CopyAttachmentsArea { get; set; }

    [JsonProperty("enableconfigchangetracking", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? Enableconfigchangetracking { get; set; }

    [JsonProperty("xero_default_invoice_line_tax", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public string? XeroDefaultInvoiceLineTax { get; set; }

    [JsonProperty("invoice_prepay_before_use", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? InvoicePrepayBeforeUse { get; set; }

    [JsonProperty("add_attachment_tags", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AddAttachmentTags { get; set; }

    [JsonProperty("show_back_button", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowBackButton { get; set; }

    [JsonProperty("samlidp_colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SamlidpColour { get; set; }

    [JsonProperty("samlidp_logo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SamlidpLogo { get; set; }

    [JsonProperty("allow_idp_initiated_requests", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowIdpInitiatedRequests { get; set; }

    [JsonProperty("authn_requests_signed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AuthnRequestsSigned { get; set; }

    [JsonProperty("split_customers_area", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? SplitCustomersArea { get; set; }

    [JsonProperty("hide_customers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? HideCustomers { get; set; }

    [JsonProperty("floating_contact_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? FloatingContactSite { get; set; }

    [JsonProperty("floating_contact_site_name", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public string? FloatingContactSiteName { get; set; }

    [JsonProperty("ticketstatusafterquoteapproval", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
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

    [JsonProperty("connectwise_control_client_field", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? ConnectWiseControlClientField { get; set; }

    [JsonProperty("connectwise_control_site_field", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? ConnectWiseControlSiteField { get; set; }

    [JsonProperty("connectwisecontroltoplevel", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? ConnectWiseControltoplevel { get; set; }

    [JsonProperty("connectwise_control_asset_type_field", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? ConnectWiseControlAssetTypeField { get; set; }

    [JsonProperty("connectwisecontrolassetdefaultsite", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? ConnectWiseControlassetdefaultsite { get; set; }

    [JsonProperty("connectwisecontrol_delete_devices", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? ConnectWiseControlDeleteDevices { get; set; }

    [JsonProperty("connectwisecontrolimportentities", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public string? ConnectWiseControlimportentities { get; set; }

    [JsonProperty("connectwisecontrol_defaultassettype", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? ConnectWiseControlDefaultAssetType { get; set; }

    [JsonProperty("showagentuserfieldsportal", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowAgentuserfieldsportal { get; set; }

    [JsonProperty("prepay_usage_next_month_percent", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? PrepayUsageNextMonthPercent { get; set; }

    [JsonProperty("group_service_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? GroupServiceStatus { get; set; }

    [JsonProperty("force_user_2fa", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ForceUser2Fa { get; set; }

    [JsonProperty("quicktime_default_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? QuicktimeDefaultSite { get; set; }

    [JsonProperty("quicktime_default_clientsite_name", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public string? QuicktimeDefaultClientSiteName { get; set; }

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
    public int? WorkspaceDefaultGroup { get; set; }

    [JsonProperty("workspace_defaultgroup_guid", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public Guid? WorkspaceDefaultGroupGuid { get; set; }

    [JsonProperty("workspace_delete_devices", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? WorkspaceDeleteDevices { get; set; }

    [JsonProperty("workspace_assettypefield", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? WorkspaceAssetTypeField { get; set; }

    [JsonProperty("workspace_integrator_import_list", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public string? WorkspaceIntegratorImportList { get; set; }

    [JsonProperty("workspace_integrator_import_types", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ValueLabelIsNewKeyPair>? WorkspaceIntegratorImportTypes { get; set; }

    [JsonProperty("workspace_dont_update_asset_type", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? WorkspaceDontUpdateAssetType { get; set; }

    [JsonProperty("addigy_assettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AddigyAssetType { get; set; }

    [JsonProperty("addigy_assettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? AddigyAssetTypeGuid { get; set; }

    [JsonProperty("default_salesforce_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultSalesforceUser { get; set; }

    [JsonProperty("default_salesforce_username", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultSalesforceUsername { get; set; }

    [JsonProperty("lansweeper_update_asset_only", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? LansweeperUpdateAssetOnly { get; set; }

    [JsonProperty("show_appointment_location", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowAppointmentLocation { get; set; }

    [JsonProperty("show_appointment_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowAppointmentStatus { get; set; }

    [JsonProperty("appointment_location_type", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? AppointmentLocationType { get; set; }

    [JsonProperty("email_list_for_payments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EmailListForPayments { get; set; }

    [JsonProperty("createproratanormallines", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? Createproratanormallines { get; set; }

    [JsonProperty("enablekbfulltextsearch", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Enablekbfulltextsearch { get; set; }

    [JsonProperty("roadmapcategory", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Roadmapcategory { get; set; }

    [JsonProperty("site_override_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SiteOverrideType { get; set; }

    [JsonProperty("defaultcostperweight", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? DefaultCostPerWeight { get; set; }

    [JsonProperty("defaultpdftemplatekb", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultPdfTemplatekb { get; set; }

    [JsonProperty("show_siteselect_client", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowSiteselectClient { get; set; }

    [JsonProperty("enableinvoiceapprovals", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Enableinvoiceapprovals { get; set; }

    [JsonProperty("ninjarmm_deeplink_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NinjaRmmDeeplinkUrl { get; set; }

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

    [JsonProperty("new_tickettypes_available_to_all_customers", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? NewTicketTypesAvailableToAllCustomers { get; set; }

    [JsonProperty("mark_unassigned_closed_alerts_as_read", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? MarkUnassignedClosedAlertsAsRead { get; set; }

    [JsonProperty("decimalplacesforinvoices", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? Decimalplacesforinvoices { get; set; }

    [JsonProperty("createproratainvoicesautomatically", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? Createproratainvoicesautomatically { get; set; }

    [JsonProperty("restrict_items_on_po_by_supplier", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
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

    [JsonProperty("b2cenableazuresinglesignon", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? B2Cenableazuresinglesignon { get; set; }

    [JsonProperty("b2cazureadsso", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? B2Cazureadsso { get; set; }

    [JsonProperty("b2cazure_auto_create_users", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? B2CazureAutoCreateUsers { get; set; }

    [JsonProperty("b2cazure_auto_creation_site", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? B2CazureAutoCreationSite { get; set; }

    [JsonProperty("b2cazureautoredirect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? B2Cazureautoredirect { get; set; }

    [JsonProperty("po_CC_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PoCcAddress { get; set; }

    [JsonProperty("po_BCC_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PoBccAddress { get; set; }

    [JsonProperty("mandatoryapprovecomment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Mandatoryapprovecomment { get; set; }

    [JsonProperty("exchange_appointment_sync_end_date", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? ExchangeAppointmentSyncEndDate { get; set; }

    [JsonProperty("forwardagentfollower", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Forwardagentfollower { get; set; }

    [JsonProperty("enable_image_popout", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? EnableImagePopout { get; set; }

    [JsonProperty("intune_delete_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? IntuneDeleteStatus { get; set; }

    [JsonProperty("lansweeper_relation_sync", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? LansweeperRelationSync { get; set; }

    [JsonProperty("admin_extra_read", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AdminExtraRead { get; set; }

    [JsonProperty("asset_display_data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AssetDisplayData { get; set; }

    [JsonProperty("use_project_start_and_target_date_for_appointment_action", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? UseProjectStartAndTargetDateForAppointmentAction { get; set; }

    [JsonProperty("showmigrations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowMigrations { get; set; }
}