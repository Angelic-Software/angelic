namespace Angelic.Control;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class Control
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intent { get; set; } 

        [JsonProperty("app_version", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? App_version { get; set; } 

        [JsonProperty("app_version_nopatch", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? App_version_nopatch { get; set; } 

        [JsonProperty("database_version", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Database_version { get; set; } 

        [JsonProperty("appname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Appname { get; set; } 

        [JsonProperty("license_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? License_count { get; set; } 

        [JsonProperty("concurrent_license_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Concurrent_license_count { get; set; } 

        [JsonProperty("license_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? License_name { get; set; } 

        [JsonProperty("trial_expires", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Trial_expires { get; set; } 

        [JsonProperty("licence_error", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Licence_error { get; set; } 

        [JsonProperty("syncid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Syncid { get; set; } 

        [JsonProperty("reports_directory", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Reports_directory { get; set; } 

        [JsonProperty("one_sla_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? One_sla_id { get; set; } 

        [JsonProperty("one_sla_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? One_sla_guid { get; set; } 

        [JsonProperty("email_start_tag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Email_start_tag { get; set; } 

        [JsonProperty("email_end_tag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Email_end_tag { get; set; } 

        [JsonProperty("contact_status_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Contact_status_id { get; set; } 

        [JsonProperty("contact_status_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Contact_status_guid { get; set; } 

        [JsonProperty("default_estimate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Default_estimate { get; set; } 

        [JsonProperty("default_usercontacted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Default_usercontacted { get; set; } 

        [JsonProperty("category_1_label", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Category_1_label { get; set; } 

        [JsonProperty("category_2_label", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Category_2_label { get; set; } 

        [JsonProperty("category_3_label", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Category_3_label { get; set; } 

        [JsonProperty("category_4_label", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Category_4_label { get; set; } 

        [JsonProperty("customers_label", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Customers_label { get; set; } 

        [JsonProperty("show_toplevels", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Show_toplevels { get; set; } 

        [JsonProperty("file_loc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? File_loc { get; set; } 

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
        public bool? Showtreesearch { get; set; } 

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
        public bool? Showtemplateselectionbutton { get; set; } 

        [JsonProperty("showsaveastemplatebutton", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showsaveastemplatebutton { get; set; } 

        [JsonProperty("welcome_message_label", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Welcome_message_label { get; set; } 

        [JsonProperty("problemmatchsearchmode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Problemmatchsearchmode { get; set; } 

        [JsonProperty("sage50username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sage50username { get; set; } 

        [JsonProperty("sage50version", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sage50version { get; set; } 

        [JsonProperty("sage50datapath", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sage50datapath { get; set; } 

        [JsonProperty("updateticketwhenpoinstock", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Updateticketwhenpoinstock { get; set; } 

        [JsonProperty("updateticketwhenpoinstockstatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Updateticketwhenpoinstockstatus { get; set; } 

        [JsonProperty("updateticketwhenpoinstockstatus_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Updateticketwhenpoinstockstatus_guid { get; set; } 

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
        public double? Agentbooking_min_hours_advance { get; set; } 

        [JsonProperty("agentbooking_max_days_advance", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Agentbooking_max_days_advance { get; set; } 

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
        public Guid? Kbdrafttickettype_guid { get; set; } 

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
        public bool? Allow_new_user { get; set; } 

        [JsonProperty("newusersite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Newusersite_name { get; set; } 

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
        public int? Sage50ukinvoicetype { get; set; } 

        [JsonProperty("twilliosmsaccountsid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Twilliosmsaccountsid { get; set; } 

        [JsonProperty("twilliosmsauthtoken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Twilliosmsauthtoken { get; set; } 

        [JsonProperty("new_twilliosmsauthtoken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_twilliosmsauthtoken { get; set; } 

        [JsonProperty("twilliosmsfromphonenumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Twilliosmsfromphonenumber { get; set; } 

        [JsonProperty("twilliosmsleadingzerosubstitute", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Twilliosmsleadingzerosubstitute { get; set; } 

        [JsonProperty("smstype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Smstype { get; set; } 

        [JsonProperty("connectwisemanageclientid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Connectwisemanageclientid { get; set; } 

        [JsonProperty("showallphonenumbersonticketdetails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showallphonenumbersonticketdetails { get; set; } 

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
        public int? Report_colour_palette { get; set; } 

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
        public bool? Autogenerate_itemaccountsid { get; set; } 

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
        public int? Sagebusinesscloud_default_invoice_status { get; set; } 

        [JsonProperty("sagebusinesscloud_default_invoice_status_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Sagebusinesscloud_default_invoice_status_guid { get; set; } 

        [JsonProperty("publishchangecalendartype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Publishchangecalendartype { get; set; } 

        [JsonProperty("xero_post_group_headers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Xero_post_group_headers { get; set; } 

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
        public bool? Showassettagongoodsout { get; set; } 

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
        public bool? Hide_default_opps_area { get; set; } 

        [JsonProperty("show_asset_diagram_services", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Show_asset_diagram_services { get; set; } 

        [JsonProperty("portal_kb_matching_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Portal_kb_matching_type { get; set; } 

        [JsonProperty("checkticketclashes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Checkticketclashes { get; set; } 

        [JsonProperty("enable_contract_rollover", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enable_contract_rollover { get; set; } 

        [JsonProperty("contract_usage_next_month_percent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Contract_usage_next_month_percent { get; set; } 

        [JsonProperty("ninja_alert_webhooks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ninja_alert_webhooks { get; set; } 

        [JsonProperty("additionalresponseactioninfo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Additionalresponseactioninfo { get; set; } 

        [JsonProperty("quoter_default_template", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Quoter_default_template { get; set; } 

        [JsonProperty("quoter_instance_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Quoter_instance_url { get; set; } 

        [JsonProperty("quoter_open_contact_form", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Quoter_open_contact_form { get; set; } 

        [JsonProperty("quoter_create_sales_orders", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Quoter_create_sales_orders { get; set; } 

        [JsonProperty("quoter_invoice_prefix", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Quoter_invoice_prefix { get; set; } 

        [JsonProperty("quoter_enable_xero_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Quoter_enable_xero_link { get; set; } 

        [JsonProperty("splashtop_email_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Splashtop_email_type { get; set; } 

        [JsonProperty("splashtop_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Splashtop_email { get; set; } 

        [JsonProperty("splashtop_mac_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Splashtop_mac_field { get; set; } 

        [JsonProperty("sso_bypass_2fa", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sso_bypass_2fa { get; set; } 

        [JsonProperty("default_user_role", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_user_role { get; set; } 

        [JsonProperty("default_user_role_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Default_user_role_guid { get; set; } 

        [JsonProperty("default_user_role_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_user_role_name { get; set; } 

        [JsonProperty("preventclashchangelogging", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Preventclashchangelogging { get; set; } 

        [JsonProperty("exactdefaultdivision", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Exactdefaultdivision { get; set; } 

        [JsonProperty("removewelcomemessage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Removewelcomemessage { get; set; } 

        [JsonProperty("new_search_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? New_search_type { get; set; } 

        [JsonProperty("limit_action_search", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Limit_action_search { get; set; } 

        [JsonProperty("app_scheduler_show_all_agents", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? App_scheduler_show_all_agents { get; set; } 

        [JsonProperty("enableagentcheckins", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enableagentcheckins { get; set; } 

        [JsonProperty("nabledeletedevices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Nabledeletedevices { get; set; } 

        [JsonProperty("allow_user_impersonation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allow_user_impersonation { get; set; } 

        [JsonProperty("allow_agent_impersonation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allow_agent_impersonation { get; set; } 

        [JsonProperty("copy_attachments_area", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Copy_attachments_area { get; set; } 

        [JsonProperty("enableconfigchangetracking", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enableconfigchangetracking { get; set; } 

        [JsonProperty("xero_default_invoice_line_tax", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Xero_default_invoice_line_tax { get; set; } 

        [JsonProperty("invoice_prepay_before_use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Invoice_prepay_before_use { get; set; } 

        [JsonProperty("add_attachment_tags", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Add_attachment_tags { get; set; } 

        [JsonProperty("show_back_button", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Show_back_button { get; set; } 

        [JsonProperty("samlidp_colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Samlidp_colour { get; set; } 

        [JsonProperty("samlidp_logo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Samlidp_logo { get; set; } 

        [JsonProperty("allow_idp_initiated_requests", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allow_idp_initiated_requests { get; set; } 

        [JsonProperty("authn_requests_signed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Authn_requests_signed { get; set; } 

        [JsonProperty("split_customers_area", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Split_customers_area { get; set; } 

        [JsonProperty("hide_customers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hide_customers { get; set; } 

        [JsonProperty("floating_contact_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Floating_contact_site { get; set; } 

        [JsonProperty("floating_contact_site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Floating_contact_site_name { get; set; } 

        [JsonProperty("ticketstatusafterquoteapproval", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ticketstatusafterquoteapproval { get; set; } 

        [JsonProperty("nag_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Nag_user { get; set; } 

        [JsonProperty("nag_tickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Nag_tickettype { get; set; } 

        [JsonProperty("nag_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Nag_user_name { get; set; } 

        [JsonProperty("nag_warning_priority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Nag_warning_priority { get; set; } 

        [JsonProperty("nag_critical_priority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Nag_critical_priority { get; set; } 

        [JsonProperty("nag_assetipaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Nag_assetipaddress { get; set; } 

        [JsonProperty("nag_assethostname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Nag_assethostname { get; set; } 

        [JsonProperty("bulk_privatenote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Bulk_privatenote { get; set; } 

        [JsonProperty("bulk_publicnote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Bulk_publicnote { get; set; } 

        [JsonProperty("connectwise_control_client_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Connectwise_control_client_field { get; set; } 

        [JsonProperty("connectwise_control_site_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Connectwise_control_site_field { get; set; } 

        [JsonProperty("connectwisecontroltoplevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Connectwisecontroltoplevel { get; set; } 

        [JsonProperty("connectwise_control_asset_type_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Connectwise_control_asset_type_field { get; set; } 

        [JsonProperty("connectwisecontrolassetdefaultsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Connectwisecontrolassetdefaultsite { get; set; } 

        [JsonProperty("connectwisecontrol_delete_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Connectwisecontrol_delete_devices { get; set; } 

        [JsonProperty("connectwisecontrolimportentities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Connectwisecontrolimportentities { get; set; } 

        [JsonProperty("connectwisecontrol_defaultassettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Connectwisecontrol_defaultassettype { get; set; } 

        [JsonProperty("showagentuserfieldsportal", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showagentuserfieldsportal { get; set; } 

        [JsonProperty("prepay_usage_next_month_percent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Prepay_usage_next_month_percent { get; set; } 

        [JsonProperty("group_service_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Group_service_status { get; set; } 

        [JsonProperty("force_user_2fa", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Force_user_2fa { get; set; } 

        [JsonProperty("quicktime_default_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Quicktime_default_site { get; set; } 

        [JsonProperty("quicktime_default_clientsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Quicktime_default_clientsite_name { get; set; } 

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
        public bool? Showopenjourneysintodo { get; set; } 

        [JsonProperty("workspace_defaultgroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Workspace_defaultgroup { get; set; } 

        [JsonProperty("workspace_defaultgroup_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Workspace_defaultgroup_guid { get; set; } 

        [JsonProperty("workspace_delete_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Workspace_delete_devices { get; set; } 

        [JsonProperty("workspace_assettypefield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Workspace_assettypefield { get; set; } 

        [JsonProperty("workspace_integrator_import_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Workspace_integrator_import_list { get; set; } 

        [JsonProperty("workspace_integrator_import_types", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? Workspace_integrator_import_types { get; set; } 

        [JsonProperty("workspace_dont_update_asset_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Workspace_dont_update_asset_type { get; set; } 

        [JsonProperty("addigy_assettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Addigy_assettype { get; set; } 

        [JsonProperty("addigy_assettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Addigy_assettype_guid { get; set; } 

        [JsonProperty("default_salesforce_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_salesforce_user { get; set; } 

        [JsonProperty("default_salesforce_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_salesforce_username { get; set; } 

        [JsonProperty("lansweeper_update_asset_only", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Lansweeper_update_asset_only { get; set; } 

        [JsonProperty("show_appointment_location", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Show_appointment_location { get; set; } 

        [JsonProperty("show_appointment_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Show_appointment_status { get; set; } 

        [JsonProperty("appointment_location_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Appointment_location_type { get; set; } 

        [JsonProperty("email_list_for_payments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Email_list_for_payments { get; set; } 

        [JsonProperty("createproratanormallines", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Createproratanormallines { get; set; } 

        [JsonProperty("enablekbfulltextsearch", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enablekbfulltextsearch { get; set; } 

        [JsonProperty("roadmapcategory", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Roadmapcategory { get; set; } 

        [JsonProperty("site_override_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Site_override_type { get; set; } 

        [JsonProperty("defaultcostperweight", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Defaultcostperweight { get; set; } 

        [JsonProperty("defaultpdftemplatekb", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Defaultpdftemplatekb { get; set; } 

        [JsonProperty("show_siteselect_client", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Show_siteselect_client { get; set; } 

        [JsonProperty("enableinvoiceapprovals", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enableinvoiceapprovals { get; set; } 

        [JsonProperty("ninjarmm_deeplink_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ninjarmm_deeplink_url { get; set; } 

        [JsonProperty("pagerduty_webhook_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Pagerduty_webhook_type { get; set; } 

        [JsonProperty("twilio_allow_inbound", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Twilio_allow_inbound { get; set; } 

        [JsonProperty("twilio_ticket_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Twilio_ticket_type { get; set; } 

        [JsonProperty("twilio_default_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Twilio_default_user { get; set; } 

        [JsonProperty("twilio_reopen_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Twilio_reopen_tickets { get; set; } 

        [JsonProperty("new_tickettypes_available_to_all_customers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? New_tickettypes_available_to_all_customers { get; set; } 

        [JsonProperty("mark_unassigned_closed_alerts_as_read", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Mark_unassigned_closed_alerts_as_read { get; set; } 

        [JsonProperty("decimalplacesforinvoices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Decimalplacesforinvoices { get; set; } 

        [JsonProperty("createproratainvoicesautomatically", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Createproratainvoicesautomatically { get; set; } 

        [JsonProperty("restrict_items_on_po_by_supplier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Restrict_items_on_po_by_supplier { get; set; } 

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
        public string? B2cazuretenantid { get; set; } 

        [JsonProperty("b2cazuressoappid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? B2cazuressoappid { get; set; } 

        [JsonProperty("b2cenableazuresinglesignon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? B2cenableazuresinglesignon { get; set; } 

        [JsonProperty("b2cazureadsso", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? B2cazureadsso { get; set; } 

        [JsonProperty("b2cazure_auto_create_users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? B2cazure_auto_create_users { get; set; } 

        [JsonProperty("b2cazure_auto_creation_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? B2cazure_auto_creation_site { get; set; } 

        [JsonProperty("b2cazureautoredirect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? B2cazureautoredirect { get; set; } 

        [JsonProperty("po_CC_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Po_CC_address { get; set; } 

        [JsonProperty("po_BCC_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Po_BCC_address { get; set; } 

        [JsonProperty("mandatoryapprovecomment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Mandatoryapprovecomment { get; set; } 

        [JsonProperty("exchange_appointment_sync_end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Exchange_appointment_sync_end_date { get; set; } 

        [JsonProperty("forwardagentfollower", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Forwardagentfollower { get; set; } 

        [JsonProperty("enable_image_popout", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enable_image_popout { get; set; } 

        [JsonProperty("intune_delete_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Intune_delete_status { get; set; } 

        [JsonProperty("lansweeper_relation_sync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Lansweeper_relation_sync { get; set; } 

        [JsonProperty("admin_extra_read", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Admin_extra_read { get; set; } 

        [JsonProperty("asset_display_data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Asset_display_data { get; set; } 

        [JsonProperty("use_project_start_and_target_date_for_appointment_action", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Use_project_start_and_target_date_for_appointment_action { get; set; } 

        [JsonProperty("showmigrations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showmigrations { get; set; } 

        [JsonProperty("salesforceimportcasefeed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Salesforceimportcasefeed { get; set; } 

        [JsonProperty("suzuki_gateway", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Suzuki_gateway { get; set; } 

        [JsonProperty("releases_from_devops_project", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Releases_from_devops_project { get; set; } 

        [JsonProperty("auto_load_dependency_chart", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Auto_load_dependency_chart { get; set; } 

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
        public bool? Default_showdefaultsite { get; set; } 

        [JsonProperty("default_showgeneralusers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Default_showgeneralusers { get; set; } 

        [JsonProperty("default_showagentusers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Default_showagentusers { get; set; } 

        [JsonProperty("default_showinternalcustomers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Default_showinternalcustomers { get; set; } 

        [JsonProperty("showmodalscreenforcannedtext", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showmodalscreenforcannedtext { get; set; } 

        [JsonProperty("logicmonitor_defaultsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Logicmonitor_defaultsite { get; set; } 

        [JsonProperty("logicmonitor_defaultassettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Logicmonitor_defaultassettype { get; set; } 

        [JsonProperty("logicmonitor_enable_alerting", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Logicmonitor_enable_alerting { get; set; } 

        [JsonProperty("logicmonitor_alert_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Logicmonitor_alert_type { get; set; } 

        [JsonProperty("logicmonitor_alert_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Logicmonitor_alert_user { get; set; } 

        [JsonProperty("logicmonitor_delete_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Logicmonitor_delete_devices { get; set; } 

        [JsonProperty("htmltemplateeditortype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Htmltemplateeditortype { get; set; } 

        [JsonProperty("allow_live_chat_teams", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allow_live_chat_teams { get; set; } 

        [JsonProperty("teams_chat_profile", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Teams_chat_profile { get; set; } 

        [JsonProperty("teams_options_style", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Teams_options_style { get; set; } 

        [JsonProperty("workspace_defaultsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Workspace_defaultsite { get; set; } 

        [JsonProperty("followers_scope", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Followers_scope { get; set; } 

        [JsonProperty("cc_scope", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Cc_scope { get; set; } 

        [JsonProperty("adjustpriceforsoinvoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Adjustpriceforsoinvoice { get; set; } 

        [JsonProperty("showallforopplink", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showallforopplink { get; set; } 

        [JsonProperty("intacct_sync_halo_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intacct_sync_halo_id { get; set; } 

        [JsonProperty("intacctdefaultwarid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intacctdefaultwarid { get; set; } 

        [JsonProperty("default_intacct_save_location", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_intacct_save_location { get; set; } 

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
        public string? Hubspot_default_lifecycle_stage { get; set; } 

        [JsonProperty("itsm_tickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Itsm_tickettype { get; set; } 

        [JsonProperty("send_new_users_welcome_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Send_new_users_welcome_email { get; set; } 

        [JsonProperty("logicmonitor_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Logicmonitor_importtype { get; set; } 

        [JsonProperty("barracuda_defaultsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Barracuda_defaultsite { get; set; } 

        [JsonProperty("barracudadefaultassettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Barracudadefaultassettype { get; set; } 

        [JsonProperty("barracuda_alert_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Barracuda_alert_user { get; set; } 

        [JsonProperty("barracuda_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Barracuda_importtype { get; set; } 

        [JsonProperty("barracuda_delete_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Barracuda_delete_devices { get; set; } 

        [JsonProperty("useoutgoingservice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Useoutgoingservice { get; set; } 

        [JsonProperty("enableteamsmsg", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enableteamsmsg { get; set; } 

        [JsonProperty("defaultteamsmsg", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Defaultteamsmsg { get; set; } 

        [JsonProperty("audit_teams_message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Audit_teams_message { get; set; } 

        [JsonProperty("whatsappcreatetickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Whatsappcreatetickets { get; set; } 

        [JsonProperty("prmerge_outcome_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Prmerge_outcome_id { get; set; } 

        [JsonProperty("hide_halo_invoice_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hide_halo_invoice_id { get; set; } 

        [JsonProperty("default_quoter_country_iso", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_quoter_country_iso { get; set; } 

        [JsonProperty("default_quoter_region_iso", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_quoter_region_iso { get; set; } 

        [JsonProperty("remove_licences_when_inactive", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Remove_licences_when_inactive { get; set; } 

        [JsonProperty("allow_additional_agents_on_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allow_additional_agents_on_tickets { get; set; } 

        [JsonProperty("users_label", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Users_label { get; set; } 

        [JsonProperty("showusernoteswhenempty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showusernoteswhenempty { get; set; } 

        [JsonProperty("showsitenoteswhenempty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showsitenoteswhenempty { get; set; } 

        [JsonProperty("showareanoteswhenempty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showareanoteswhenempty { get; set; } 

        [JsonProperty("show_enduser_details_opps", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Show_enduser_details_opps { get; set; } 

        [JsonProperty("max_parent_deps", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Max_parent_deps { get; set; } 

        [JsonProperty("max_child_deps", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Max_child_deps { get; set; } 

        [JsonProperty("invoiceitembillingdescriptionlong", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Invoiceitembillingdescriptionlong { get; set; } 

        [JsonProperty("invoiceitembillingdescriptionshort", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Invoiceitembillingdescriptionshort { get; set; } 

        [JsonProperty("default_columns_id_clients", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_columns_id_clients { get; set; } 

        [JsonProperty("default_columns_id_clients_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Default_columns_id_clients_guid { get; set; } 

        [JsonProperty("hide_other_dep_teams", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hide_other_dep_teams { get; set; } 

        [JsonProperty("kbeditorrich", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Kbeditorrich { get; set; } 

        [JsonProperty("kbeditormarkdown", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Kbeditormarkdown { get; set; } 

        [JsonProperty("chat_image_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Chat_image_type { get; set; } 

        [JsonProperty("cognigyendpoint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Cognigyendpoint { get; set; } 

        [JsonProperty("connectwiseautomatealertlastupdated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Connectwiseautomatealertlastupdated { get; set; } 

        [JsonProperty("cannedsuggestnewticket", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Cannedsuggestnewticket { get; set; } 

        [JsonProperty("service_permission_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Service_permission_type { get; set; } 

        [JsonProperty("includeslaholdloadbalancing", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Includeslaholdloadbalancing { get; set; } 

        [JsonProperty("milestone_update_all_dates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Milestone_update_all_dates { get; set; } 

        [JsonProperty("match_ninja_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Match_ninja_user { get; set; } 

        [JsonProperty("uselistgroups", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Uselistgroups { get; set; } 

        [JsonProperty("allowquickuseradd", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allowquickuseradd { get; set; } 

        [JsonProperty("connectwise_automate_control_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Connectwise_automate_control_guid { get; set; } 

        [JsonProperty("supp_contract_mandatory", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Supp_contract_mandatory { get; set; } 

        [JsonProperty("searchfullticketids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Searchfullticketids { get; set; } 

        [JsonProperty("qualysusertype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Qualysusertype { get; set; } 

        [JsonProperty("googleworkspacenamedroles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Googleworkspacenamedroles { get; set; } 

        [JsonProperty("oktanamedroles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Oktanamedroles { get; set; } 

        [JsonProperty("lansweeper_assettype_choice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Lansweeper_assettype_choice { get; set; } 

        [JsonProperty("lansweeper_default_assettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Lansweeper_default_assettype { get; set; } 

        [JsonProperty("lansweeper_assettype_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Lansweeper_assettype_field { get; set; } 

        [JsonProperty("barracuda_alert_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Barracuda_alert_type { get; set; } 

        [JsonProperty("preventparentchange", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Preventparentchange { get; set; } 

        [JsonProperty("planning_orange_percentage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Planning_orange_percentage { get; set; } 

        [JsonProperty("planning_red_percentage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Planning_red_percentage { get; set; } 

        [JsonProperty("whatsappreopentickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Whatsappreopentickets { get; set; } 

        [JsonProperty("whatsapptickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Whatsapptickettype { get; set; } 

        [JsonProperty("intacct_use_apinvoices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Intacct_use_apinvoices { get; set; } 

        [JsonProperty("intacct_use_arinvoices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Intacct_use_arinvoices { get; set; } 

        [JsonProperty("intacctitemgroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Intacctitemgroup { get; set; } 

        [JsonProperty("intacctdefaulttaxsol", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intacctdefaulttaxsol { get; set; } 

        [JsonProperty("showslaonkanban", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showslaonkanban { get; set; } 

        [JsonProperty("site24x7_alert_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Site24x7_alert_type { get; set; } 

        [JsonProperty("site24x7_alert_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Site24x7_alert_user { get; set; } 

        [JsonProperty("reset_security_stamps", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Reset_security_stamps { get; set; } 

        [JsonProperty("invoice_pay_prepay_before_use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Invoice_pay_prepay_before_use { get; set; } 

        [JsonProperty("new_user_template", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? New_user_template { get; set; } 

        [JsonProperty("new_user_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? New_user_type { get; set; } 

        [JsonProperty("child_template_recursion_depth", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Child_template_recursion_depth { get; set; } 

        [JsonProperty("kaseya_sync_agents_only", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Kaseya_sync_agents_only { get; set; } 

        [JsonProperty("kaseya_defaultassettype_server", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Kaseya_defaultassettype_server { get; set; } 

        [JsonProperty("kaseya_defaultassettype_server_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Kaseya_defaultassettype_server_guid { get; set; } 

        [JsonProperty("kaseya_defaultassettype_workstation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Kaseya_defaultassettype_workstation { get; set; } 

        [JsonProperty("kaseya_defaultassettype_workstation_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Kaseya_defaultassettype_workstation_guid { get; set; } 

        [JsonProperty("recaptcha_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Recaptcha_type { get; set; } 

        [JsonProperty("recaptcha_threshold", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Recaptcha_threshold { get; set; } 

        [JsonProperty("show_all_lic_for_quantity_calc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Show_all_lic_for_quantity_calc { get; set; } 

        [JsonProperty("jamf_instance_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Jamf_instance_type { get; set; } 

        [JsonProperty("jamf_site_match_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Jamf_site_match_type { get; set; } 

        [JsonProperty("software_import_licence_matching", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Software_import_licence_matching { get; set; } 

        [JsonProperty("show_services_cost_tile", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Show_services_cost_tile { get; set; } 

        [JsonProperty("show_services_cost_tile_endusers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Show_services_cost_tile_endusers { get; set; } 

        [JsonProperty("exclude_nonticket_app_todo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Exclude_nonticket_app_todo { get; set; } 

        [JsonProperty("po_hide_item_popup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Po_hide_item_popup { get; set; } 

        [JsonProperty("mergesalesorderinvoicessite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Mergesalesorderinvoicessite { get; set; } 

        [JsonProperty("prepay_itemid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Prepay_itemid { get; set; } 

        [JsonProperty("showintelrouting", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showintelrouting { get; set; } 

        [JsonProperty("showintelroutingonactions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showintelroutingonactions { get; set; } 

        [JsonProperty("intelroutingcutoffdays", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Intelroutingcutoffdays { get; set; } 

        [JsonProperty("intelroutingmaxtickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Intelroutingmaxtickets { get; set; } 

        [JsonProperty("close_all_children", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Close_all_children { get; set; } 

        [JsonProperty("showtraveltimesheet", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showtraveltimesheet { get; set; } 

        [JsonProperty("showfeedbackcaptcha", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showfeedbackcaptcha { get; set; } 

        [JsonProperty("recaptcha_isenterprise", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Recaptcha_isenterprise { get; set; } 

        [JsonProperty("call_charge_rate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Call_charge_rate { get; set; } 

        [JsonProperty("use_stripe_receipt_emails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Use_stripe_receipt_emails { get; set; } 

        [JsonProperty("invoicecreationengine", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Invoicecreationengine { get; set; } 

        [JsonProperty("showponumonapproval", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showponumonapproval { get; set; } 

        [JsonProperty("multientitysearchincludecontracts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Multientitysearchincludecontracts { get; set; } 

        [JsonProperty("hide_add_to_project_and_create_child", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hide_add_to_project_and_create_child { get; set; } 

        [JsonProperty("show_pipeline_stages", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Show_pipeline_stages { get; set; } 

        [JsonProperty("default_pipeline_stage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_pipeline_stage { get; set; } 

        [JsonProperty("timefieldstoshowontimesheet", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Timefieldstoshowontimesheet { get; set; } 

        [JsonProperty("showjsonexportbutton", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showjsonexportbutton { get; set; } 

        [JsonProperty("issueditemsdesclong", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Issueditemsdesclong { get; set; } 

        [JsonProperty("overridefeedbacklink", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Overridefeedbacklink { get; set; } 

        [JsonProperty("allow_user_drafts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allow_user_drafts { get; set; } 

        [JsonProperty("createuserifgeneraluser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Createuserifgeneraluser { get; set; } 

        [JsonProperty("icinga_defaultsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Icinga_defaultsite { get; set; } 

        [JsonProperty("icinga_defaultgroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Icinga_defaultgroup { get; set; } 

        [JsonProperty("icinga_defaultgroup_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Icinga_defaultgroup_guid { get; set; } 

        [JsonProperty("icingaassettypefield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Icingaassettypefield { get; set; } 

        [JsonProperty("icingadefaultassettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Icingadefaultassettype { get; set; } 

        [JsonProperty("icinga_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Icinga_importtype { get; set; } 

        [JsonProperty("icinga_delete_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Icinga_delete_devices { get; set; } 

        [JsonProperty("icinga_selfsigned_cert", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Icinga_selfsigned_cert { get; set; } 

        [JsonProperty("icinga_alert_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Icinga_alert_type { get; set; } 

        [JsonProperty("icinga_alert_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Icinga_alert_user { get; set; } 

        [JsonProperty("icinga_enable_alerting", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Icinga_enable_alerting { get; set; } 

        [JsonProperty("enable_document_previewer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enable_document_previewer { get; set; } 

        [JsonProperty("addigy_dont_import_software", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Addigy_dont_import_software { get; set; } 

        [JsonProperty("default_view_customers_selectedid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_view_customers_selectedid { get; set; } 

        [JsonProperty("default_view_users_selectedid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_view_users_selectedid { get; set; } 

        [JsonProperty("defaultnavscreenlayout", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Defaultnavscreenlayout { get; set; } 

        [JsonProperty("navbar_new_call", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Navbar_new_call { get; set; } 

        [JsonProperty("actiondatedisplay", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Actiondatedisplay { get; set; } 

        [JsonProperty("showcalllogonticket", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showcalllogonticket { get; set; } 

        [JsonProperty("use_charge_for_budgets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Use_charge_for_budgets { get; set; } 

        [JsonProperty("quote_hide_item_popup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Quote_hide_item_popup { get; set; } 

        [JsonProperty("so_hide_item_popup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? So_hide_item_popup { get; set; } 

        [JsonProperty("default_columns_id_contracts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_columns_id_contracts { get; set; } 

        [JsonProperty("default_columns_id_contracts_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Default_columns_id_contracts_guid { get; set; } 

        [JsonProperty("beyond_trust_instance_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Beyond_trust_instance_type { get; set; } 

        [JsonProperty("asset_permission_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Asset_permission_type { get; set; } 

        [JsonProperty("show_users_contracts_on_ticket_only", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Show_users_contracts_on_ticket_only { get; set; } 

        [JsonProperty("default_columns_id_sites", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_columns_id_sites { get; set; } 

        [JsonProperty("default_columns_id_users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_columns_id_users { get; set; } 

        [JsonProperty("jamf_dont_update_asset_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Jamf_dont_update_asset_type { get; set; } 

        [JsonProperty("billingcontactinfoonportal", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Billingcontactinfoonportal { get; set; } 

        [JsonProperty("rhipe_subscription_client", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Rhipe_subscription_client { get; set; } 

        [JsonProperty("followup_appointment_subject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Followup_appointment_subject { get; set; } 

        [JsonProperty("show_device_on_invoice_line", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Show_device_on_invoice_line { get; set; } 

        [JsonProperty("asset_return_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Asset_return_status { get; set; } 

        [JsonProperty("spellchecksuggestionscore", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Spellchecksuggestionscore { get; set; } 

        [JsonProperty("load_rinvoices_lines", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Load_rinvoices_lines { get; set; } 

        [JsonProperty("user_ticket_profile", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? User_ticket_profile { get; set; } 

        [JsonProperty("user_project_profile", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? User_project_profile { get; set; } 

        [JsonProperty("admin_override_quick_status_change", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Admin_override_quick_status_change { get; set; } 

        [JsonProperty("create_so_on_quote_approved", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Create_so_on_quote_approved { get; set; } 

        [JsonProperty("additional_agents_on_tickets_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Additional_agents_on_tickets_type { get; set; } 

        [JsonProperty("show_toplevel_access_portal_option", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Show_toplevel_access_portal_option { get; set; } 

        [JsonProperty("show_alllevel_access_portal_option", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Show_alllevel_access_portal_option { get; set; } 

        [JsonProperty("donttrackleavesite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Donttrackleavesite { get; set; } 

        [JsonProperty("meter_min_quantity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Meter_min_quantity { get; set; } 

        [JsonProperty("show_kb_menu", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Show_kb_menu { get; set; } 

        [JsonProperty("icinga_comment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Icinga_comment { get; set; } 

        [JsonProperty("sync_icinga_comment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sync_icinga_comment { get; set; } 

        [JsonProperty("icinga_asset_type_choice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Icinga_asset_type_choice { get; set; } 

        [JsonProperty("open_new_quote_in_new_tab", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Open_new_quote_in_new_tab { get; set; } 

        [JsonProperty("defaultaideployment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(50)]
        public string? Defaultaideployment { get; set; } 

        [JsonProperty("connectwise_rmm_default_client", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Connectwise_rmm_default_client { get; set; } 

        [JsonProperty("connectwise_rmm_default_asset_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Connectwise_rmm_default_asset_type { get; set; } 

        [JsonProperty("connectwise_rmm_delete_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Connectwise_rmm_delete_devices { get; set; } 

        [JsonProperty("connectwise_rmm_import_entities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Connectwise_rmm_import_entities { get; set; } 

        [JsonProperty("connectwise_rmm_top_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Connectwise_rmm_top_level { get; set; } 

        [JsonProperty("showeventstabforadmins", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showeventstabforadmins { get; set; } 

        [JsonProperty("def_inv_manual_pr_immediately", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Def_inv_manual_pr_immediately { get; set; } 

        [JsonProperty("salesorderstatusafterinvoicedeleted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Salesorderstatusafterinvoicedeleted { get; set; } 

        [JsonProperty("show_related_of_related", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Show_related_of_related { get; set; } 

        [JsonProperty("invertactionhistory", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Invertactionhistory { get; set; } 

        [JsonProperty("enablekbdraftsnews", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enablekbdraftsnews { get; set; } 

        [JsonProperty("kbdrafttickettypenews", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Kbdrafttickettypenews { get; set; } 

        [JsonProperty("kbdrafttickettype_guidnews", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Kbdrafttickettype_guidnews { get; set; } 

        [JsonProperty("halonewssandbox", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Halonewssandbox { get; set; } 

        [JsonProperty("shopifycustomerimporttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Shopifycustomerimporttype { get; set; } 

        [JsonProperty("shopifydefaultsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Shopifydefaultsite { get; set; } 

        [JsonProperty("shopify_integratorcustomerslastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Shopify_integratorcustomerslastsync { get; set; } 

        [JsonProperty("shopify_integratororderslastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Shopify_integratororderslastsync { get; set; } 

        [JsonProperty("shopify_integratorentitiestoimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Shopify_integratorentitiestoimport { get; set; } 

        [JsonProperty("ecommerceshowordersarea", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ecommerceshowordersarea { get; set; } 

        [JsonProperty("device42preventdeviceimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Device42preventdeviceimport { get; set; } 

        [JsonProperty("admins_access_all_reports", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Admins_access_all_reports { get; set; } 

        [JsonProperty("adminsecurityprompt", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Adminsecurityprompt { get; set; } 

        [JsonProperty("stripemanualpaymentmethodoptions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Stripemanualpaymentmethodoptions { get; set; } 

        [JsonProperty("log_action_responses_on_action_submit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Log_action_responses_on_action_submit { get; set; } 

        [JsonProperty("use_embedding_scores_openai", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Use_embedding_scores_openai { get; set; } 

        [JsonProperty("use_embedding_scores_azureopenai", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Use_embedding_scores_azureopenai { get; set; } 

        [JsonProperty("xensam_defaultsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Xensam_defaultsite { get; set; } 

        [JsonProperty("xensam_defaultassettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Xensam_defaultassettype { get; set; } 

        [JsonProperty("xensam_assettype_choice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Xensam_assettype_choice { get; set; } 

        [JsonProperty("xensam_assettype_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Xensam_assettype_field { get; set; } 

        [JsonProperty("xensam_assettype_field_datacentre", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Xensam_assettype_field_datacentre { get; set; } 

        [JsonProperty("xensam_defaultgroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Xensam_defaultgroup { get; set; } 

        [JsonProperty("xensamdefaultgroup_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Xensamdefaultgroup_guid { get; set; } 

        [JsonProperty("xensam_integratorentitiestoimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Xensam_integratorentitiestoimport { get; set; } 

        [JsonProperty("xensam_delete_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Xensam_delete_devices { get; set; } 

        [JsonProperty("xensam_dont_update_assettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Xensam_dont_update_assettype { get; set; } 

        [JsonProperty("useincomingservice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Useincomingservice { get; set; } 

        [JsonProperty("atera_alert_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Atera_alert_method { get; set; } 

        [JsonProperty("addigy_alert_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Addigy_alert_method { get; set; } 

        [JsonProperty("automate_alert_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Automate_alert_method { get; set; } 

        [JsonProperty("dattormm_alert_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Dattormm_alert_method { get; set; } 

        [JsonProperty("default_view_suppliers_selectedid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_view_suppliers_selectedid { get; set; } 

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
        public string? New_smtppassword { get; set; } 

        [JsonProperty("smtpusetls", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Smtpusetls { get; set; } 

        [JsonProperty("smtpport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Smtpport { get; set; } 

        [JsonProperty("generalusername", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Generalusername { get; set; } 

        [JsonProperty("enableuserclosureconf", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enableuserclosureconf { get; set; } 

        [JsonProperty("auto_close_hrs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Auto_close_hrs { get; set; } 

        [JsonProperty("pending_close_reminder_hrs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Pending_close_reminder_hrs { get; set; } 

        [JsonProperty("shownotrespondedwarning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Shownotrespondedwarning { get; set; } 

        [JsonProperty("statusafterrespond", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Statusafterrespond { get; set; } 

        [JsonProperty("statusafterrespond_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Statusafterrespond_guid { get; set; } 

        [JsonProperty("tracknonbill", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Tracknonbill { get; set; } 

        [JsonProperty("tracktravel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Tracktravel { get; set; } 

        [JsonProperty("trackmileage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Trackmileage { get; set; } 

        [JsonProperty("default_tickettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_tickettype_id { get; set; } 

        [JsonProperty("default_tickettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Default_tickettype_guid { get; set; } 

        [JsonProperty("allow_tickettype_selection_agents", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allow_tickettype_selection_agents { get; set; } 

        [JsonProperty("hide_generaluser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hide_generaluser { get; set; } 

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
        public bool? Allow_response_edit { get; set; } 

        [JsonProperty("cat2mandclear", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Cat2mandclear { get; set; } 

        [JsonProperty("cat3mandclear", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Cat3mandclear { get; set; } 

        [JsonProperty("cat4mandclear", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Cat4mandclear { get; set; } 

        [JsonProperty("cat5mandclear", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Cat5mandclear { get; set; } 

        [JsonProperty("showactioncalendaroption", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showactioncalendaroption { get; set; } 

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
        public Guid? Gfiservertype_guid { get; set; } 

        [JsonProperty("gfiwstype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Gfiwstype { get; set; } 

        [JsonProperty("gfiwstype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Gfiwstype_guid { get; set; } 

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
        public int? Migration_top_level { get; set; } 

        [JsonProperty("migration_default_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Migration_default_site { get; set; } 

        [JsonProperty("migration_faq_creation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Migration_faq_creation { get; set; } 

        [JsonProperty("migration_default_faq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Migration_default_faq { get; set; } 

        [JsonProperty("migration_incident", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Migration_incident { get; set; } 

        [JsonProperty("migration_problem", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Migration_problem { get; set; } 

        [JsonProperty("migration_change_request", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Migration_change_request { get; set; } 

        [JsonProperty("migration_service_request", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Migration_service_request { get; set; } 

        [JsonProperty("orion_webhook_authentication", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Orion_webhook_authentication { get; set; } 

        [JsonProperty("orion_tickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Orion_tickettype { get; set; } 

        [JsonProperty("orion_tickettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Orion_tickettype_guid { get; set; } 

        [JsonProperty("orion_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Orion_user { get; set; } 

        [JsonProperty("orion_devicefield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Orion_devicefield { get; set; } 

        [JsonProperty("prtgassetdefaultsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Prtgassetdefaultsite { get; set; } 

        [JsonProperty("prtgdefaultassettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Prtgdefaultassettype { get; set; } 

        [JsonProperty("prtgdefaultassettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Prtgdefaultassettype_guid { get; set; } 

        [JsonProperty("orion_enable_updates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Orion_enable_updates { get; set; } 

        [JsonProperty("showkbentrytags", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showkbentrytags { get; set; } 

        [JsonProperty("isphonemandatory", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isphonemandatory { get; set; } 

        [JsonProperty("enableteamscall", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enableteamscall { get; set; } 

        [JsonProperty("soc_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Soc_username { get; set; } 

        [JsonProperty("soc_show_success_message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Soc_show_success_message { get; set; } 

        [JsonProperty("soc_tickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Soc_tickettype { get; set; } 

        [JsonProperty("soc_tickettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Soc_tickettype_guid { get; set; } 

        [JsonProperty("soc_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Soc_user { get; set; } 

        [JsonProperty("dattodefaultassettypegroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Dattodefaultassettypegroup { get; set; } 

        [JsonProperty("dattodefaultassettypegroup_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Dattodefaultassettypegroup_guid { get; set; } 

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
        public bool? Datto_delete_devices { get; set; } 

        [JsonProperty("qboenableast", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Qboenableast { get; set; } 

        [JsonProperty("item_default_sales_nominal_code_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Item_default_sales_nominal_code_name { get; set; } 

        [JsonProperty("item_default_purchase_nominal_code_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Item_default_purchase_nominal_code_name { get; set; } 

        [JsonProperty("item_default_asset_account_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Item_default_asset_account_name { get; set; } 

        [JsonProperty("qborequestid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Qborequestid { get; set; } 

        [JsonProperty("percentageoverdue2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Percentageoverdue2 { get; set; } 

        [JsonProperty("default_phone_pref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_phone_pref { get; set; } 

        [JsonProperty("migration_ticket_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Migration_ticket_date { get; set; } 

        [JsonProperty("migration_ticket_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Migration_ticket_status { get; set; } 

        [JsonProperty("migration_custom_filter", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Migration_custom_filter { get; set; } 

        [JsonProperty("device42_toplevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Device42_toplevel { get; set; } 

        [JsonProperty("device42defaultsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Device42defaultsite { get; set; } 

        [JsonProperty("device42defaulttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Device42defaulttype { get; set; } 

        [JsonProperty("device42defaulttype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Device42defaulttype_guid { get; set; } 

        [JsonProperty("servicenow_locale", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Servicenow_locale { get; set; } 

        [JsonProperty("connectwise_instance_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Connectwise_instance_type { get; set; } 

        [JsonProperty("connectwise_company_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Connectwise_company_id { get; set; } 

        [JsonProperty("automaticprepaypaymentattheendoflastmonth", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Automaticprepaypaymentattheendoflastmonth { get; set; } 

        [JsonProperty("add_order_note_to_long_description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Add_order_note_to_long_description { get; set; } 

        [JsonProperty("display_user_on_asset_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Display_user_on_asset_list { get; set; } 

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
        public bool? Display_extra_options_on_quick_time { get; set; } 

        [JsonProperty("autotask_identifier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Autotask_identifier { get; set; } 

        [JsonProperty("migration_product_group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Migration_product_group { get; set; } 

        [JsonProperty("migration_service_group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Migration_service_group { get; set; } 

        [JsonProperty("migration_contract_enddate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Migration_contract_enddate { get; set; } 

        [JsonProperty("migration_tax_rate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Migration_tax_rate { get; set; } 

        [JsonProperty("migration_role", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Migration_role { get; set; } 

        [JsonProperty("logclosedpagerduty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Logclosedpagerduty { get; set; } 

        [JsonProperty("defaultischangeapprover", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Defaultischangeapprover { get; set; } 

        [JsonProperty("noapprovalwithnocabmembers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Noapprovalwithnocabmembers { get; set; } 

        [JsonProperty("exchange_connected_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Exchange_connected_user { get; set; } 

        [JsonProperty("exchange_start_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Exchange_start_date { get; set; } 

        [JsonProperty("exchange_import_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Exchange_import_type { get; set; } 

        [JsonProperty("showkbportalurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showkbportalurl { get; set; } 

        [JsonProperty("default_appt_to_original_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Default_appt_to_original_time { get; set; } 

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
        public int? Atera_toplevel { get; set; } 

        [JsonProperty("atera_devicetypes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Atera_devicetypes { get; set; } 

        [JsonProperty("atera_defaultsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Atera_defaultsite { get; set; } 

        [JsonProperty("atera_defaultgroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Atera_defaultgroup { get; set; } 

        [JsonProperty("atera_defaultgroup_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Atera_defaultgroup_guid { get; set; } 

        [JsonProperty("atera_delete_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Atera_delete_devices { get; set; } 

        [JsonProperty("atera_enable_alerting", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Atera_enable_alerting { get; set; } 

        [JsonProperty("atera_guid1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Atera_guid1 { get; set; } 

        [JsonProperty("atera_guid2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Atera_guid2 { get; set; } 

        [JsonProperty("atera_alert_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Atera_alert_type { get; set; } 

        [JsonProperty("atera_alert_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Atera_alert_user { get; set; } 

        [JsonProperty("kashflowdefaultconnectionid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Kashflowdefaultconnectionid { get; set; } 

        [JsonProperty("default_prepay_lines", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_prepay_lines { get; set; } 

        [JsonProperty("ticketstatusafterinternalconversation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ticketstatusafterinternalconversation { get; set; } 

        [JsonProperty("ticketstatusafterinternalconversation_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Ticketstatusafterinternalconversation_guid { get; set; } 

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
        public Guid? Merakitickettype_guid { get; set; } 

        [JsonProperty("merakiuser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Merakiuser { get; set; } 

        [JsonProperty("merakidevicematchingfield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Merakidevicematchingfield { get; set; } 

        [JsonProperty("lansweeper_instance_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Lansweeper_instance_type { get; set; } 

        [JsonProperty("lansweeper_default_group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Lansweeper_default_group { get; set; } 

        [JsonProperty("lansweeper_default_group_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Lansweeper_default_group_guid { get; set; } 

        [JsonProperty("lansweeper_use_users_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Lansweeper_use_users_site { get; set; } 

        [JsonProperty("lansweeper_dont_update_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Lansweeper_dont_update_site { get; set; } 

        [JsonProperty("lansweeper_dont_remove_users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Lansweeper_dont_remove_users { get; set; } 

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
        public string? Xero_default_invoice_status { get; set; } 

        [JsonProperty("useaccountscodeslookup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Useaccountscodeslookup { get; set; } 

        [JsonProperty("xero_default_order_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Xero_default_order_status { get; set; } 

        [JsonProperty("allowordernumberedit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allowordernumberedit { get; set; } 

        [JsonProperty("xero_allow_linked_items", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Xero_allow_linked_items { get; set; } 

        [JsonProperty("typeofdisplayanduseforassetswhenloggingonbehalfallowed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Typeofdisplayanduseforassetswhenloggingonbehalfallowed { get; set; } 

        [JsonProperty("samlidp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Samlidp { get; set; } 

        [JsonProperty("samlidp_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Samlidp_name { get; set; } 

        [JsonProperty("dynamicscrm_accountfilter", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Dynamicscrm_accountfilter { get; set; } 

        [JsonProperty("dynamicscrm_userfilter", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Dynamicscrm_userfilter { get; set; } 

        [JsonProperty("dattoassettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Dattoassettype { get; set; } 

        [JsonProperty("alarmminutes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Alarmminutes { get; set; } 

        [JsonProperty("link_new_assets_to_contract", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Link_new_assets_to_contract { get; set; } 

        [JsonProperty("onlyallowassetstatuschangefromnewactionscreen", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Onlyallowassetstatuschangefromnewactionscreen { get; set; } 

        [JsonProperty("invoiceduedaysextra", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Invoiceduedaysextra { get; set; } 

        [JsonProperty("use_gross_margin", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Use_gross_margin { get; set; } 

        [JsonProperty("ninja_alert_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ninja_alert_type { get; set; } 

        [JsonProperty("ninja_alert_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ninja_alert_user { get; set; } 

        [JsonProperty("ninja_delete_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ninja_delete_devices { get; set; } 

        [JsonProperty("orion_force_default_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Orion_force_default_user { get; set; } 

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
        public bool? Showattachmentsonapprovals { get; set; } 

        [JsonProperty("previewpdfinbrowser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Previewpdfinbrowser { get; set; } 

        [JsonProperty("ticketstartdatebeforeenddate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ticketstartdatebeforeenddate { get; set; } 

        [JsonProperty("migration_project", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Migration_project { get; set; } 

        [JsonProperty("migration_project_children", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Migration_project_children { get; set; } 

        [JsonProperty("itglue_top_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Itglue_top_level { get; set; } 

        [JsonProperty("itglue_customer_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Itglue_customer_type { get; set; } 

        [JsonProperty("itglue_import_active_statuses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Itglue_import_active_statuses { get; set; } 

        [JsonProperty("itglue_default_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Itglue_default_site { get; set; } 

        [JsonProperty("itglue_import_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Itglue_import_type { get; set; } 

        [JsonProperty("itglue_enable_sync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Itglue_enable_sync { get; set; } 

        [JsonProperty("itglue_active_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Itglue_active_status { get; set; } 

        [JsonProperty("itglue_inactive_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Itglue_inactive_status { get; set; } 

        [JsonProperty("itglue_instance_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Itglue_instance_url { get; set; } 

        [JsonProperty("move_quote_to_closed_on_so_creation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Move_quote_to_closed_on_so_creation { get; set; } 

        [JsonProperty("move_quotes_default_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Move_quotes_default_status { get; set; } 

        [JsonProperty("move_quotes_default_status_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Move_quotes_default_status_guid { get; set; } 

        [JsonProperty("show_child_sos_on_parent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Show_child_sos_on_parent { get; set; } 

        [JsonProperty("enduserchange_confirmation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enduserchange_confirmation { get; set; } 

        [JsonProperty("connectwise_markbilled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Connectwise_markbilled { get; set; } 

        [JsonProperty("billing_from_mailbox_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Billing_from_mailbox_id { get; set; } 

        [JsonProperty("quotes_from_mailbox_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Quotes_from_mailbox_id { get; set; } 

        [JsonProperty("so_from_mailbox_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? So_from_mailbox_id { get; set; } 

        [JsonProperty("po_from_mailbox_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Po_from_mailbox_id { get; set; } 

        [JsonProperty("snelstart_client_top_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Snelstart_client_top_level { get; set; } 

        [JsonProperty("snelstart_item_group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Snelstart_item_group { get; set; } 

        [JsonProperty("snelstart_item_group_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Snelstart_item_group_guid { get; set; } 

        [JsonProperty("snelstart_enable_sync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Snelstart_enable_sync { get; set; } 

        [JsonProperty("snelstart_default_item", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Snelstart_default_item { get; set; } 

        [JsonProperty("jamf_devicetypes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Jamf_devicetypes { get; set; } 

        [JsonProperty("allowed_files", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Allowed_files { get; set; } 

        [JsonProperty("jamf_defaultsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Jamf_defaultsite { get; set; } 

        [JsonProperty("allow_readall_passwords", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allow_readall_passwords { get; set; } 

        [JsonProperty("jamf_defaultdtypemobile", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Jamf_defaultdtypemobile { get; set; } 

        [JsonProperty("jamf_defaultdtypemobile_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Jamf_defaultdtypemobile_guid { get; set; } 

        [JsonProperty("scom_allowed_clientids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Scom_allowed_clientids { get; set; } 

        [JsonProperty("jamf_defaultdtypecomputer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Jamf_defaultdtypecomputer { get; set; } 

        [JsonProperty("jamf_defaultdtypecomputer_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Jamf_defaultdtypecomputer_guid { get; set; } 

        [JsonProperty("orion_allowed_clientids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Orion_allowed_clientids { get; set; } 

        [JsonProperty("google_calendar_authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Google_calendar_authorized { get; set; } 

        [JsonProperty("default_billing_period", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_billing_period { get; set; } 

        [JsonProperty("showvotecount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showvotecount { get; set; } 

        [JsonProperty("limit_news_by_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Limit_news_by_date { get; set; } 

        [JsonProperty("cc_list_is_dropdown", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Cc_list_is_dropdown { get; set; } 

        [JsonProperty("splitrecurringcontracts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Splitrecurringcontracts { get; set; } 

        [JsonProperty("default_expand_rows", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Default_expand_rows { get; set; } 

        [JsonProperty("samlmatchingfield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Samlmatchingfield { get; set; } 

        [JsonProperty("default_item_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_item_tax_code { get; set; } 

        [JsonProperty("default_service_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_service_tax_code { get; set; } 

        [JsonProperty("default_prepay_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_prepay_tax_code { get; set; } 

        [JsonProperty("default_contract_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_contract_tax_code { get; set; } 

        [JsonProperty("default_sentinel_ticket_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_sentinel_ticket_type { get; set; } 

        [JsonProperty("default_sentinel_ticket_type_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Default_sentinel_ticket_type_guid { get; set; } 

        [JsonProperty("default_sentinel_classification", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_sentinel_classification { get; set; } 

        [JsonProperty("default_sentinel_classification_reason", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_sentinel_classification_reason { get; set; } 

        [JsonProperty("default_sentinel_priority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_sentinel_priority { get; set; } 

        [JsonProperty("use_ticket_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Use_ticket_site { get; set; } 

        [JsonProperty("decimal_separator", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Decimal_separator { get; set; } 

        [JsonProperty("thousands_separator", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Thousands_separator { get; set; } 

        [JsonProperty("parent_project_template_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Parent_project_template_id { get; set; } 

        [JsonProperty("solarwindsncentraldontsyncaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Solarwindsncentraldontsyncaddress { get; set; } 

        [JsonProperty("default_asset_view", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_asset_view { get; set; } 

        [JsonProperty("oppvalue_from_quote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Oppvalue_from_quote { get; set; } 

        [JsonProperty("teamsbot_ticket_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Teamsbot_ticket_type { get; set; } 

        [JsonProperty("teamsbot_ticket_type_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Teamsbot_ticket_type_guid { get; set; } 

        [JsonProperty("teamsbot_default_subject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Teamsbot_default_subject { get; set; } 

        [JsonProperty("teamsbot_outcome_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Teamsbot_outcome_id { get; set; } 

        [JsonProperty("teamsbot_default_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Teamsbot_default_user { get; set; } 

        [JsonProperty("showsupplierupdatestoenduser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showsupplierupdatestoenduser { get; set; } 

        [JsonProperty("admin_only_report_sql", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Admin_only_report_sql { get; set; } 

        [JsonProperty("exchange_connection_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Exchange_connection_type { get; set; } 

        [JsonProperty("rexchangetenantid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Rexchangetenantid { get; set; } 

        [JsonProperty("rexchangeapplicationid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Rexchangeapplicationid { get; set; } 

        [JsonProperty("sentinel_tenant_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sentinel_tenant_id { get; set; } 

        [JsonProperty("sentinel_application_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sentinel_application_id { get; set; } 

        [JsonProperty("serializationassetfield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Serializationassetfield { get; set; } 

        [JsonProperty("serializationassetfield_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Serializationassetfield_guid { get; set; } 

        [JsonProperty("azuremonitortickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Azuremonitortickettype { get; set; } 

        [JsonProperty("azuremonitortickettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Azuremonitortickettype_guid { get; set; } 

        [JsonProperty("azuremonitoruser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Azuremonitoruser { get; set; } 

        [JsonProperty("azuremonitorreopenstatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Azuremonitorreopenstatus { get; set; } 

        [JsonProperty("azuremonitorreopenstatus_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Azuremonitorreopenstatus_guid { get; set; } 

        [JsonProperty("faqtreeview", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Faqtreeview { get; set; } 

        [JsonProperty("datto_connect_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Datto_connect_type { get; set; } 

        [JsonProperty("syncro_toplevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Syncro_toplevel { get; set; } 

        [JsonProperty("syncro_devicetypes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Syncro_devicetypes { get; set; } 

        [JsonProperty("syncro_defaultsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Syncro_defaultsite { get; set; } 

        [JsonProperty("syncro_defaultgroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Syncro_defaultgroup { get; set; } 

        [JsonProperty("syncro_defaultgroup_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Syncro_defaultgroup_guid { get; set; } 

        [JsonProperty("syncro_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Syncro_importtype { get; set; } 

        [JsonProperty("syncro_delete_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Syncro_delete_devices { get; set; } 

        [JsonProperty("syncro_enable_alerting", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Syncro_enable_alerting { get; set; } 

        [JsonProperty("syncro_alert_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Syncro_alert_type { get; set; } 

        [JsonProperty("syncro_alert_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Syncro_alert_user { get; set; } 

        [JsonProperty("exchangeapptsprivate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Exchangeapptsprivate { get; set; } 

        [JsonProperty("qb_allow_linked_items", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Qb_allow_linked_items { get; set; } 

        [JsonProperty("domotz_default_agentdevicetype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Domotz_default_agentdevicetype { get; set; } 

        [JsonProperty("domotz_default_agentdevicetype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Domotz_default_agentdevicetype_guid { get; set; } 

        [JsonProperty("domotz_default_agentsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Domotz_default_agentsite { get; set; } 

        [JsonProperty("domotz_default_devicetype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Domotz_default_devicetype { get; set; } 

        [JsonProperty("domotz_default_devicetype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Domotz_default_devicetype_guid { get; set; } 

        [JsonProperty("domotz_default_devicesite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Domotz_default_devicesite { get; set; } 

        [JsonProperty("domotz_delete_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Domotz_delete_devices { get; set; } 

        [JsonProperty("allow_quantity_calculations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allow_quantity_calculations { get; set; } 

        [JsonProperty("po_number_mandatory", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Po_number_mandatory { get; set; } 

        [JsonProperty("snow_toplevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Snow_toplevel { get; set; } 

        [JsonProperty("hideapptactionsfromuser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hideapptactionsfromuser { get; set; } 

        [JsonProperty("snow_default_devicetype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Snow_default_devicetype { get; set; } 

        [JsonProperty("snow_default_devicetype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Snow_default_devicetype_guid { get; set; } 

        [JsonProperty("okta_deactivate_entities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Okta_deactivate_entities { get; set; } 

        [JsonProperty("okta_last_agent_sync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Okta_last_agent_sync { get; set; } 

        [JsonProperty("okta_last_user_sync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Okta_last_user_sync { get; set; } 

        [JsonProperty("automate_import_entities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Automate_import_entities { get; set; } 

        [JsonProperty("automate_delete_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Automate_delete_devices { get; set; } 

        [JsonProperty("automate_connectwise_control", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Automate_connectwise_control { get; set; } 

        [JsonProperty("connectwise_control_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Connectwise_control_guid { get; set; } 

        [JsonProperty("automate_enable_alerting", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Automate_enable_alerting { get; set; } 

        [JsonProperty("automate_alert_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Automate_alert_type { get; set; } 

        [JsonProperty("automate_alert_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Automate_alert_user { get; set; } 

        [JsonProperty("automate_guid1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Automate_guid1 { get; set; } 

        [JsonProperty("snow_default_devicesite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Snow_default_devicesite { get; set; } 

        [JsonProperty("automate_guid2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Automate_guid2 { get; set; } 

        [JsonProperty("snow_delete_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Snow_delete_devices { get; set; } 

        [JsonProperty("haloassetdiscovery_instance_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Haloassetdiscovery_instance_type { get; set; } 

        [JsonProperty("default_showmenu", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Default_showmenu { get; set; } 

        [JsonProperty("prorata_periods_ahead", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Prorata_periods_ahead { get; set; } 

        [JsonProperty("childparentlinktableview", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Childparentlinktableview { get; set; } 

        [JsonProperty("mandatory_consignment_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Mandatory_consignment_site { get; set; } 

        [JsonProperty("same_client_consignment_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Same_client_consignment_site { get; set; } 

        [JsonProperty("project_use_consignment_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Project_use_consignment_site { get; set; } 

        [JsonProperty("snow_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Snow_importtype { get; set; } 

        [JsonProperty("snow_dont_create_new_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Snow_dont_create_new_devices { get; set; } 

        [JsonProperty("snow_dont_update_device_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Snow_dont_update_device_type { get; set; } 

        [JsonProperty("snow_dont_move_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Snow_dont_move_site { get; set; } 

        [JsonProperty("snow_user_matching_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Snow_user_matching_type { get; set; } 

        [JsonProperty("dont_use_vendorflag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dont_use_vendorflag { get; set; } 

        [JsonProperty("dont_use_cwticketfilter", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dont_use_cwticketfilter { get; set; } 

        [JsonProperty("allow_negative_prorata", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allow_negative_prorata { get; set; } 

        [JsonProperty("auvik_top_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Auvik_top_level { get; set; } 

        [JsonProperty("auvik_default_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Auvik_default_site { get; set; } 

        [JsonProperty("auvik_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Auvik_importtype { get; set; } 

        [JsonProperty("auvik_enable_alerting", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Auvik_enable_alerting { get; set; } 

        [JsonProperty("auvik_alert_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Auvik_alert_type { get; set; } 

        [JsonProperty("auvik_alert_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Auvik_alert_user { get; set; } 

        [JsonProperty("teamsbot_allowed_tenants", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Teamsbot_allowed_tenants { get; set; } 

        [JsonProperty("show_contract_balance_on_ticket", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Show_contract_balance_on_ticket { get; set; } 

        [JsonProperty("default_columns_id_assets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_columns_id_assets { get; set; } 

        [JsonProperty("default_columns_id_assets_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Default_columns_id_assets_guid { get; set; } 

        [JsonProperty("pin_important_actions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Pin_important_actions { get; set; } 

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
        public int? Hubspot_top_level { get; set; } 

        [JsonProperty("hubspot_include_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hubspot_include_address { get; set; } 

        [JsonProperty("hubspot_default_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Hubspot_default_site { get; set; } 

        [JsonProperty("hubspot_account", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Hubspot_account { get; set; } 

        [JsonProperty("hubspot_domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Hubspot_domain { get; set; } 

        [JsonProperty("hubspot_company_sync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Hubspot_company_sync { get; set; } 

        [JsonProperty("hubspot_contact_sync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Hubspot_contact_sync { get; set; } 

        [JsonProperty("hubspot_show_success_message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hubspot_show_success_message { get; set; } 

        [JsonProperty("hubspot_included_lifecycles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Hubspot_included_lifecycles { get; set; } 

        [JsonProperty("hubspot_archive", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hubspot_archive { get; set; } 

        [JsonProperty("hubspot_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Hubspot_importtype { get; set; } 

        [JsonProperty("qualys_default_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Qualys_default_site { get; set; } 

        [JsonProperty("passportal_clienttoplevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Passportal_clienttoplevel { get; set; } 

        [JsonProperty("passportal_defaultusersite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Passportal_defaultusersite { get; set; } 

        [JsonProperty("passportal_defaultassetsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Passportal_defaultassetsite { get; set; } 

        [JsonProperty("rpassportal_integratorentitiestoimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Rpassportal_integratorentitiestoimport { get; set; } 

        [JsonProperty("passportal_defaultassetgroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Passportal_defaultassetgroup { get; set; } 

        [JsonProperty("passportal_defaultassetgroup_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Passportal_defaultassetgroup_guid { get; set; } 

        [JsonProperty("passportal_deactivate_assets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Passportal_deactivate_assets { get; set; } 

        [JsonProperty("auvik_top_level_domain_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Auvik_top_level_domain_id { get; set; } 

        [JsonProperty("auvik_top_level_domain_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Auvik_top_level_domain_name { get; set; } 

        [JsonProperty("qbononinventoryitemgroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Qbononinventoryitemgroup { get; set; } 

        [JsonProperty("showmailboxname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showmailboxname { get; set; } 

        [JsonProperty("show_timer_seconds", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Show_timer_seconds { get; set; } 

        [JsonProperty("exchange_disable_integrator_delete", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Exchange_disable_integrator_delete { get; set; } 

        [JsonProperty("use_account_tax", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Use_account_tax { get; set; } 

        [JsonProperty("use_xero_for_sending", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Use_xero_for_sending { get; set; } 

        [JsonProperty("trial_purchase_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Trial_purchase_url { get; set; } 

        [JsonProperty("audit_teams_call", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Audit_teams_call { get; set; } 

        [JsonProperty("itglue_sync_names", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Itglue_sync_names { get; set; } 

        [JsonProperty("qbo_default_company", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Qbo_default_company { get; set; } 

        [JsonProperty("intaccttoplevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Intaccttoplevel { get; set; } 

        [JsonProperty("logticketwhenchatend", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Logticketwhenchatend { get; set; } 

        [JsonProperty("intacct_sync_entities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intacct_sync_entities { get; set; } 

        [JsonProperty("chatendtickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Chatendtickettype { get; set; } 

        [JsonProperty("chatendtickettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Chatendtickettype_guid { get; set; } 

        [JsonProperty("intacctinvoicetransactiondetail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intacctinvoicetransactiondetail { get; set; } 

        [JsonProperty("showcustomerlevelprepay", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showcustomerlevelprepay { get; set; } 

        [JsonProperty("lansweeper_dont_update_asset_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Lansweeper_dont_update_asset_type { get; set; } 

        [JsonProperty("navbar_new_ticket", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Navbar_new_ticket { get; set; } 

        [JsonProperty("added_view_customer_perm", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Added_view_customer_perm { get; set; } 

        [JsonProperty("quotepricedp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Quotepricedp { get; set; } 

        [JsonProperty("defaultassetstatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Defaultassetstatus { get; set; } 

        [JsonProperty("negativefeedbackcomment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Negativefeedbackcomment { get; set; } 

        [JsonProperty("sage50cacompanypath", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sage50cacompanypath { get; set; } 

        [JsonProperty("sage50causername", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sage50causername { get; set; } 

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
        public int? Anonymoususer_id { get; set; } 

        [JsonProperty("anonymoususer_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Anonymoususer_name { get; set; } 

        [JsonProperty("globalaccountsbccemailaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Globalaccountsbccemailaddress { get; set; } 

        [JsonProperty("mandatoryfaqlist", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Mandatoryfaqlist { get; set; } 

        [JsonProperty("teamscallmethod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Teamscallmethod { get; set; } 

        [JsonProperty("stripe_public_key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Stripe_public_key { get; set; } 

        [JsonProperty("stripe_currency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Stripe_currency { get; set; } 

        [JsonProperty("addigy_defaultassetsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Addigy_defaultassetsite { get; set; } 

        [JsonProperty("addigy_defaultassetgroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Addigy_defaultassetgroup { get; set; } 

        [JsonProperty("addigy_defaultassetgroup_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Addigy_defaultassetgroup_guid { get; set; } 

        [JsonProperty("addigy_assettypefield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Addigy_assettypefield { get; set; } 

        [JsonProperty("addigy_deactivate_assets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Addigy_deactivate_assets { get; set; } 

        [JsonProperty("addigy_enable_alerting", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Addigy_enable_alerting { get; set; } 

        [JsonProperty("addigy_alert_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Addigy_alert_type { get; set; } 

        [JsonProperty("addigy_alert_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Addigy_alert_user { get; set; } 

        [JsonProperty("domotz_dont_update_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Domotz_dont_update_site { get; set; } 

        [JsonProperty("showtoplevelontickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showtoplevelontickets { get; set; } 

        [JsonProperty("automatetimezone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Automatetimezone { get; set; } 

        [JsonProperty("recurringitembillingdescriptionlong", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Recurringitembillingdescriptionlong { get; set; } 

        [JsonProperty("sage50cadefaultpaidtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sage50cadefaultpaidtype { get; set; } 

        [JsonProperty("sage50cadefaultpaidaccount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sage50cadefaultpaidaccount { get; set; } 

        [JsonProperty("deleterowconfirmation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Deleterowconfirmation { get; set; } 

        [JsonProperty("salesforce_toplevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Salesforce_toplevel { get; set; } 

        [JsonProperty("logactionforapprovalresponse", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Logactionforapprovalresponse { get; set; } 

        [JsonProperty("salesforce_accountwhere", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Salesforce_accountwhere { get; set; } 

        [JsonProperty("liongardassettypefield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Liongardassettypefield { get; set; } 

        [JsonProperty("salesforce_contactwhere", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Salesforce_contactwhere { get; set; } 

        [JsonProperty("liongard_toplevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Liongard_toplevel { get; set; } 

        [JsonProperty("salesforce_opportunitywhere", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Salesforce_opportunitywhere { get; set; } 

        [JsonProperty("liongard_defaultsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Liongard_defaultsite { get; set; } 

        [JsonProperty("salesforce_casewhere", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Salesforce_casewhere { get; set; } 

        [JsonProperty("liongard_defaultgroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Liongard_defaultgroup { get; set; } 

        [JsonProperty("liongard_defaultgroup_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Liongard_defaultgroup_guid { get; set; } 

        [JsonProperty("salesforce_integratorentitiestoimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Salesforce_integratorentitiestoimport { get; set; } 

        [JsonProperty("salesforce_updateaddresses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Salesforce_updateaddresses { get; set; } 

        [JsonProperty("liongard_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Liongard_importtype { get; set; } 

        [JsonProperty("salesforce_casetickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Salesforce_casetickettype { get; set; } 

        [JsonProperty("salesforce_casetickettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Salesforce_casetickettype_guid { get; set; } 

        [JsonProperty("liongard_delete_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Liongard_delete_devices { get; set; } 

        [JsonProperty("salesforce_integratoraccountlastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Salesforce_integratoraccountlastsync { get; set; } 

        [JsonProperty("liongard_customer_sync_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Liongard_customer_sync_type { get; set; } 

        [JsonProperty("salesforce_integratorcontactlastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Salesforce_integratorcontactlastsync { get; set; } 

        [JsonProperty("sync_liongard_customer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sync_liongard_customer { get; set; } 

        [JsonProperty("salesforce_integratoropportunitylastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Salesforce_integratoropportunitylastsync { get; set; } 

        [JsonProperty("show_liongard_success", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Show_liongard_success { get; set; } 

        [JsonProperty("accmanagershowextradetails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Accmanagershowextradetails { get; set; } 

        [JsonProperty("ingram_micro_update_addresses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ingram_micro_update_addresses { get; set; } 

        [JsonProperty("ingram_micro_top_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ingram_micro_top_level { get; set; } 

        [JsonProperty("ingram_micro_import_entities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ingram_micro_import_entities { get; set; } 

        [JsonProperty("pax8_update_addresses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Pax8_update_addresses { get; set; } 

        [JsonProperty("pax8_top_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Pax8_top_level { get; set; } 

        [JsonProperty("pax8_import_entities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Pax8_import_entities { get; set; } 

        [JsonProperty("salesforce_integratorcaselastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Salesforce_integratorcaselastsync { get; set; } 

        [JsonProperty("sendclosureremindertoccaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sendclosureremindertoccaddress { get; set; } 

        [JsonProperty("exchange_organizer_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Exchange_organizer_override { get; set; } 

        [JsonProperty("showtickettypeselection", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showtickettypeselection { get; set; } 

        [JsonProperty("azure_federation_domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Azure_federation_domain { get; set; } 

        [JsonProperty("azure_auto_create_users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Azure_auto_create_users { get; set; } 

        [JsonProperty("azure_auto_creation_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Azure_auto_creation_site { get; set; } 

        [JsonProperty("azureb2c_domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Azureb2c_domain { get; set; } 

        [JsonProperty("azureb2c_user_flow", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Azureb2c_user_flow { get; set; } 

        [JsonProperty("azure_login_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Azure_login_url { get; set; } 

        [JsonProperty("usercanviewapprovedtickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Usercanviewapprovedtickets { get; set; } 

        [JsonProperty("reauthorizeforapprovals", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Reauthorizeforapprovals { get; set; } 

        [JsonProperty("default_itemgroups_hideitems", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Default_itemgroups_hideitems { get; set; } 

        [JsonProperty("enableshifts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enableshifts { get; set; } 

        [JsonProperty("newrelic_tickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Newrelic_tickettype { get; set; } 

        [JsonProperty("newrelic_tickettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Newrelic_tickettype_guid { get; set; } 

        [JsonProperty("newrelic_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Newrelic_user { get; set; } 

        [JsonProperty("backupradar_alert_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Backupradar_alert_type { get; set; } 

        [JsonProperty("rbackupradarapiurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Rbackupradarapiurl { get; set; } 

        [JsonProperty("rbackupradarapikey", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Rbackupradarapikey { get; set; } 

        [JsonProperty("userscanviewitems", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Userscanviewitems { get; set; } 

        [JsonProperty("use_tickettab_areas", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Use_tickettab_areas { get; set; } 

        [JsonProperty("split_childtickets_tab", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Split_childtickets_tab { get; set; } 

        [JsonProperty("enable_contract_calculated_cost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enable_contract_calculated_cost { get; set; } 

        [JsonProperty("cipp_instance_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Cipp_instance_url { get; set; } 

        [JsonProperty("auto_create_next_asset_tag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Auto_create_next_asset_tag { get; set; } 

        [JsonProperty("bookingshowphonenumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Bookingshowphonenumber { get; set; } 

        [JsonProperty("bookingshowemailaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Bookingshowemailaddress { get; set; } 

        [JsonProperty("intacctdefaultdepid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intacctdefaultdepid { get; set; } 

        [JsonProperty("enablezoomcall", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enablezoomcall { get; set; } 

        [JsonProperty("enable_comparative_quoting", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enable_comparative_quoting { get; set; } 

        [JsonProperty("ncentral_delete_clients", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ncentral_delete_clients { get; set; } 

        [JsonProperty("ncentral_delete_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ncentral_delete_devices { get; set; } 

        [JsonProperty("gc_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Gc_client_id { get; set; } 

        [JsonProperty("kaseya_defaultsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Kaseya_defaultsite { get; set; } 

        [JsonProperty("kaseya_defaultassettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Kaseya_defaultassettype { get; set; } 

        [JsonProperty("kaseya_defaultassettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Kaseya_defaultassettype_guid { get; set; } 

        [JsonProperty("kaseya_enable_alerting", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Kaseya_enable_alerting { get; set; } 

        [JsonProperty("kaseya_alert_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Kaseya_alert_type { get; set; } 

        [JsonProperty("kaseya_alert_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Kaseya_alert_user { get; set; } 

        [JsonProperty("kaseya_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Kaseya_importtype { get; set; } 

        [JsonProperty("kaseya_delete_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Kaseya_delete_devices { get; set; } 

        [JsonProperty("kaseyaservicedesks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Kaseyaservicedesks { get; set; } 

        [JsonProperty("migration_ticket_end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Migration_ticket_end_date { get; set; } 

        [JsonProperty("invoicelongdescriptionfromsalesorder", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Invoicelongdescriptionfromsalesorder { get; set; } 

        [JsonProperty("dbc_default_company", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Dbc_default_company { get; set; } 

        [JsonProperty("enable_legacy_dbc_integration", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enable_legacy_dbc_integration { get; set; } 

        [JsonProperty("salesforce_accountsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Salesforce_accountsync { get; set; } 

        [JsonProperty("salesforce_contactsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Salesforce_contactsync { get; set; } 

        [JsonProperty("salesforce_show_success_message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Salesforce_show_success_message { get; set; } 

        [JsonProperty("salesforce_include_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Salesforce_include_address { get; set; } 

        [JsonProperty("salesforce_deafult_stage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Salesforce_deafult_stage { get; set; } 

        [JsonProperty("hide_consignment_costs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hide_consignment_costs { get; set; } 

        [JsonProperty("select_consignment_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Select_consignment_user { get; set; } 

        [JsonProperty("select_consignment_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Select_consignment_status { get; set; } 

        [JsonProperty("defaultconsignmentpdftemplate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Defaultconsignmentpdftemplate { get; set; } 

        [JsonProperty("stripenotificationemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Stripenotificationemail { get; set; } 

        [JsonProperty("enableautostripepayment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enableautostripepayment { get; set; } 

        [JsonProperty("stripepaymentmethodoptions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Stripepaymentmethodoptions { get; set; } 

        [JsonProperty("zabbix_default_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Zabbix_default_type { get; set; } 

        [JsonProperty("zabbix_default_type_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Zabbix_default_type_guid { get; set; } 

        [JsonProperty("zabbix_default_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Zabbix_default_site { get; set; } 

        [JsonProperty("zabbix_dont_update_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Zabbix_dont_update_type { get; set; } 

        [JsonProperty("zabbix_dont_update_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Zabbix_dont_update_site { get; set; } 

        [JsonProperty("zabbix_delete_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Zabbix_delete_devices { get; set; } 

        [JsonProperty("show_favourite_services", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Show_favourite_services { get; set; } 

        [JsonProperty("slack_ticket_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Slack_ticket_type { get; set; } 

        [JsonProperty("allow_password_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allow_password_override { get; set; } 

        [JsonProperty("password_strength_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Password_strength_level { get; set; } 

        [JsonProperty("force_agent_2fa", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Force_agent_2fa { get; set; } 

        [JsonProperty("giacom_top_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Giacom_top_level { get; set; } 

        [JsonProperty("giacom_import_entities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Giacom_import_entities { get; set; } 

        [JsonProperty("rhipe_update_addresses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Rhipe_update_addresses { get; set; } 

        [JsonProperty("rhipe_top_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Rhipe_top_level { get; set; } 

        [JsonProperty("rhipe_import_entities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Rhipe_import_entities { get; set; } 

        [JsonProperty("techdata_top_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Techdata_top_level { get; set; } 

        [JsonProperty("techdata_import_entities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Techdata_import_entities { get; set; } 

        [JsonProperty("inty_update_addresses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Inty_update_addresses { get; set; } 

        [JsonProperty("inty_top_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Inty_top_level { get; set; } 

        [JsonProperty("inty_import_entities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Inty_import_entities { get; set; } 

        [JsonProperty("westcoastcloud_update_addresses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Westcoastcloud_update_addresses { get; set; } 

        [JsonProperty("westcoastcloud_top_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Westcoastcloud_top_level { get; set; } 

        [JsonProperty("westcoastcloud_import_entities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Westcoastcloud_import_entities { get; set; } 

        [JsonProperty("sherweb_top_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sherweb_top_level { get; set; } 

        [JsonProperty("sherweb_import_entities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sherweb_import_entities { get; set; } 

        [JsonProperty("also_update_addresses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Also_update_addresses { get; set; } 

        [JsonProperty("also_top_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Also_top_level { get; set; } 

        [JsonProperty("also_import_entities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Also_import_entities { get; set; } 

        [JsonProperty("arrowsphere_update_addresses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Arrowsphere_update_addresses { get; set; } 

        [JsonProperty("arrowsphere_top_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Arrowsphere_top_level { get; set; } 

        [JsonProperty("arrowsphere_import_entities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Arrowsphere_import_entities { get; set; } 

        [JsonProperty("dickerdata_update_addresses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dickerdata_update_addresses { get; set; } 

        [JsonProperty("dickerdata_top_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Dickerdata_top_level { get; set; } 

        [JsonProperty("dickerdata_import_entities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Dickerdata_import_entities { get; set; } 

        [JsonProperty("oracle_email_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Oracle_email_address { get; set; } 

        [JsonProperty("slack_ticket_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Slack_ticket_user { get; set; } 

        [JsonProperty("autocomplete_email_address_behaviour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Autocomplete_email_address_behaviour { get; set; } 

        [JsonProperty("override_assertion_endpoint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Override_assertion_endpoint { get; set; } 

        [JsonProperty("noactionsaftermerge", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Noactionsaftermerge { get; set; } 

        [JsonProperty("default_filter_id_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_filter_id_tickets { get; set; } 

        [JsonProperty("default_filter_id_tickets_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Default_filter_id_tickets_guid { get; set; } 

        [JsonProperty("default_columns_id_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_columns_id_tickets { get; set; } 

        [JsonProperty("default_columns_id_tickets_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Default_columns_id_tickets_guid { get; set; } 

        [JsonProperty("default_view_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_view_tickets { get; set; } 

        [JsonProperty("default_view_tickets_selectedid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_view_tickets_selectedid { get; set; } 

        [JsonProperty("default_view_tickets_selected_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Default_view_tickets_selected_guid { get; set; } 

        [JsonProperty("default_filter_id_opps", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_filter_id_opps { get; set; } 

        [JsonProperty("default_filter_id_opps_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Default_filter_id_opps_guid { get; set; } 

        [JsonProperty("default_columns_id_opps", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_columns_id_opps { get; set; } 

        [JsonProperty("default_columns_id_opps_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Default_columns_id_opps_guid { get; set; } 

        [JsonProperty("default_view_opps", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_view_opps { get; set; } 

        [JsonProperty("default_view_opps_selectedid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_view_opps_selectedid { get; set; } 

        [JsonProperty("default_view_opps_selected_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Default_view_opps_selected_guid { get; set; } 

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
        public int? Default_client { get; set; } 

        [JsonProperty("force_accounts_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Force_accounts_id { get; set; } 

        [JsonProperty("new_client_template_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? New_client_template_id { get; set; } 

        [JsonProperty("default_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_site { get; set; } 

        [JsonProperty("default_clientsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_clientsite_name { get; set; } 

        [JsonProperty("deleteforever", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Deleteforever { get; set; } 

        [JsonProperty("parentstatusafterallchildclosed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Parentstatusafterallchildclosed { get; set; } 

        [JsonProperty("parentstatusafterallchildclosed_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Parentstatusafterallchildclosed_guid { get; set; } 

        [JsonProperty("newchilduserisagent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Newchilduserisagent { get; set; } 

        [JsonProperty("percentage_to_survey", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Percentage_to_survey { get; set; } 

        [JsonProperty("feedback_tickettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Feedback_tickettype_id { get; set; } 

        [JsonProperty("feedback_tickettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Feedback_tickettype_guid { get; set; } 

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
        public int? Holiday_agentstatus { get; set; } 

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
        public bool? Use_release1 { get; set; } 

        [JsonProperty("use_release2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Use_release2 { get; set; } 

        [JsonProperty("use_release3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Use_release3 { get; set; } 

        [JsonProperty("release1_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Release1_name { get; set; } 

        [JsonProperty("release2_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Release2_name { get; set; } 

        [JsonProperty("release3_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Release3_name { get; set; } 

        [JsonProperty("release2_autoupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Release2_autoupdate { get; set; } 

        [JsonProperty("release3_autoupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Release3_autoupdate { get; set; } 

        [JsonProperty("release_includeunsentnotesinemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Release_includeunsentnotesinemail { get; set; } 

        [JsonProperty("release_category", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Release_category { get; set; } 

        [JsonProperty("workflow_preview_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Workflow_preview_type { get; set; } 

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
        public int? Reassign_limit { get; set; } 

        [JsonProperty("app_colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? App_colour { get; set; } 

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
        public string? New_smsppassword { get; set; } 

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
        public bool? Showchildunreadinlist { get; set; } 

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
        public Guid? Callrequesttype_guid { get; set; } 

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
        public bool? Alluse2fa { get; set; } 

        [JsonProperty("hidechangemanagementtab", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hidechangemanagementtab { get; set; } 

        [JsonProperty("problemmatchingposition", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Problemmatchingposition { get; set; } 

        [JsonProperty("default_opp_tickettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_opp_tickettype_id { get; set; } 

        [JsonProperty("default_opp_tickettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Default_opp_tickettype_guid { get; set; } 

        [JsonProperty("default_client_opps", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_client_opps { get; set; } 

        [JsonProperty("default_site_opps", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_site_opps { get; set; } 

        [JsonProperty("default_clientsite_name_opps", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_clientsite_name_opps { get; set; } 

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
        public bool? Showcontractcoloursonassetchoice { get; set; } 

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
        public bool? Showassetlinesoncontractinvoice { get; set; } 

        [JsonProperty("showassetvalueoninvoiceline", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showassetvalueoninvoiceline { get; set; } 

        [JsonProperty("assetlinesbillingdesc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Assetlinesbillingdesc { get; set; } 

        [JsonProperty("slaholdcolour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Slaholdcolour { get; set; } 

        [JsonProperty("pagesize", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Pagesize { get; set; } 

        [JsonProperty("onlyusetimersonactionswithtimetaken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Onlyusetimersonactionswithtimetaken { get; set; } 

        [JsonProperty("use24hrclock", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Use24hrclock { get; set; } 

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
        public int? Feedback1high { get; set; } 

        [JsonProperty("feedback1low", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Feedback1low { get; set; } 

        [JsonProperty("feedback2high", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Feedback2high { get; set; } 

        [JsonProperty("feedback2low", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Feedback2low { get; set; } 

        [JsonProperty("feedback3high", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Feedback3high { get; set; } 

        [JsonProperty("feedback3low", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Feedback3low { get; set; } 

        [JsonProperty("feedback4high", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Feedback4high { get; set; } 

        [JsonProperty("feedback4low", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Feedback4low { get; set; } 

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
        public bool? Showcsvexportbutton { get; set; } 

        [JsonProperty("allowticketmerging", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allowticketmerging { get; set; } 

        [JsonProperty("enablesap", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enablesap { get; set; } 

        [JsonProperty("bugzillabugurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Bugzillabugurl { get; set; } 

        [JsonProperty("enablecontinuum", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enablecontinuum { get; set; } 

        [JsonProperty("showticketsearchonmerge", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showticketsearchonmerge { get; set; } 

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
        public bool? Showticketattachmenticon { get; set; } 

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
        public int? Salesforce_tickettype { get; set; } 

        [JsonProperty("salesforce_tickettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Salesforce_tickettype_guid { get; set; } 

        [JsonProperty("clientimportidentifier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Clientimportidentifier { get; set; } 

        [JsonProperty("siteimportidentifier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Siteimportidentifier { get; set; } 

        [JsonProperty("userimportidentifier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Userimportidentifier { get; set; } 

        [JsonProperty("assetimportidentifier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Assetimportidentifier { get; set; } 

        [JsonProperty("assetimportidentifier_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Assetimportidentifier_guid { get; set; } 

        [JsonProperty("supplierimportidentifier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Supplierimportidentifier { get; set; } 

        [JsonProperty("itemimportidentifier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Itemimportidentifier { get; set; } 

        [JsonProperty("assettypeimportidentifier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Assettypeimportidentifier { get; set; } 

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
        public string? Importazuresite_name { get; set; } 

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
        public bool? Showmyservices { get; set; } 

        [JsonProperty("servicerequestrtid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Servicerequestrtid { get; set; } 

        [JsonProperty("servicerequestrtid_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Servicerequestrtid_guid { get; set; } 

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
        public Guid? Pagerdutydefrequesttype_guid { get; set; } 

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
        public int? Splunk_tickettype { get; set; } 

        [JsonProperty("splunk_tickettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Splunk_tickettype_guid { get; set; } 

        [JsonProperty("splunkuser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Splunkuser { get; set; } 

        [JsonProperty("enableoktasinglesignon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enableoktasinglesignon { get; set; } 

        [JsonProperty("okta_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Okta_url { get; set; } 

        [JsonProperty("okta_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Okta_client_id { get; set; } 

        [JsonProperty("oktaautoredirect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Oktaautoredirect { get; set; } 

        [JsonProperty("salesforcedefaultsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Salesforcedefaultsite { get; set; } 

        [JsonProperty("salesforceuserfield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Salesforceuserfield { get; set; } 

        [JsonProperty("salesforcedefaultsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Salesforcedefaultsite_name { get; set; } 

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
        public string? Remotesession_username { get; set; } 

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
        public int? Sage200version { get; set; } 

        [JsonProperty("sage200toplevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sage200toplevel { get; set; } 

        [JsonProperty("sage200tenantid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sage200tenantid { get; set; } 

        [JsonProperty("sage200companyid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sage200companyid { get; set; } 

        [JsonProperty("sage200itemgroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sage200itemgroup { get; set; } 

        [JsonProperty("sage200companyname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sage200companyname { get; set; } 

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
        public string? Sage200token { get; set; } 

        [JsonProperty("sage200tokenexpiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Sage200tokenexpiry { get; set; } 

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
        public bool? Showapprovalsonseparatetab { get; set; } 

        [JsonProperty("pagerdutyserviceid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Pagerdutyserviceid { get; set; } 

        [JsonProperty("autoswitchtodefaultremoteteam", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Autoswitchtodefaultremoteteam { get; set; } 

        [JsonProperty("requireexternalkey", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Requireexternalkey { get; set; } 

        [JsonProperty("change_collision_enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Change_collision_enabled { get; set; } 

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
        public int? Stopnewticketsviaemailreplywithtemplate_id { get; set; } 

        [JsonProperty("stopnewticketsviaemailreplywithtemplate_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Stopnewticketsviaemailreplywithtemplate_guid { get; set; } 

        [JsonProperty("stopnewticketsviaemailreplywithtemplate_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Stopnewticketsviaemailreplywithtemplate_name { get; set; } 

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
        public Guid? Ninjarmmdefaultgroup_guid { get; set; } 

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
        public int? Contractexpirytemplate_id { get; set; } 

        [JsonProperty("contractexpirytemplate_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Contractexpirytemplate_guid { get; set; } 

        [JsonProperty("contractexpirytemplate_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Contractexpirytemplate_name { get; set; } 

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
        public bool? Allow_notloggedin { get; set; } 

        [JsonProperty("allow_kbs_notloggedin", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allow_kbs_notloggedin { get; set; } 

        [JsonProperty("anonymoususersite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Anonymoususersite { get; set; } 

        [JsonProperty("anonymoususersite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Anonymoususersite_name { get; set; } 

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
        public bool? Ualluse2fa { get; set; } 

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
        public bool? Allow_anonymous_approvals { get; set; } 

        [JsonProperty("ncentralurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ncentralurl { get; set; } 

        [JsonProperty("ncentral_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ncentral_username { get; set; } 

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
        public int? Ncentral_tickettype { get; set; } 

        [JsonProperty("ncentral_tickettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Ncentral_tickettype_guid { get; set; } 

        [JsonProperty("ncentraluser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ncentraluser { get; set; } 

        [JsonProperty("ncentral_alerttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ncentral_alerttype { get; set; } 

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
        public Guid? Fixedassettype_guid { get; set; } 

        [JsonProperty("businesscentral_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Businesscentral_site { get; set; } 

        [JsonProperty("enablebusinesscentralsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enablebusinesscentralsync { get; set; } 

        [JsonProperty("timesheetstepinterval", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Timesheetstepinterval { get; set; } 

        [JsonProperty("azuressoconnectionid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Azuressoconnectionid { get; set; } 

        [JsonProperty("azuressotenanttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Azuressotenanttype { get; set; } 

        [JsonProperty("showapproversthatareyettovote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showapproversthatareyettovote { get; set; } 

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
        public bool? Auto_close_send_email { get; set; } 

        [JsonProperty("portalbackgrounddisplaymode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Portalbackgrounddisplaymode { get; set; } 

        [JsonProperty("autoaddrecurringinvoiceaftercontract", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Autoaddrecurringinvoiceaftercontract { get; set; } 

        [JsonProperty("enableinternalticketconversations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enableinternalticketconversations { get; set; } 

        [JsonProperty("internalticketconversationtickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Internalticketconversationtickettype { get; set; } 

        [JsonProperty("internalticketconversationtickettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Internalticketconversationtickettype_guid { get; set; } 

        [JsonProperty("enableinternalreply", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enableinternalreply { get; set; } 

        [JsonProperty("internalreplystatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Internalreplystatus { get; set; } 

        [JsonProperty("internalreplystatus_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Internalreplystatus_guid { get; set; } 

        [JsonProperty("hidefeedback", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hidefeedback { get; set; } 

        [JsonProperty("showallservicesoption", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showallservicesoption { get; set; } 

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
        public Guid? Ticketstatusafterquoteaccepted_guid { get; set; } 

        [JsonProperty("ticketstatusafterquoterejected", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ticketstatusafterquoterejected { get; set; } 

        [JsonProperty("ticketstatusafterquoterejected_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Ticketstatusafterquoterejected_guid { get; set; } 

        [JsonProperty("loadimagesfromapi", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Loadimagesfromapi { get; set; } 

        [JsonProperty("centrify_clientid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Centrify_clientid { get; set; } 

        [JsonProperty("centrify_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Centrify_url { get; set; } 

        [JsonProperty("centrify_applicationid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Centrify_applicationid { get; set; } 

        [JsonProperty("centrify_ssotype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Centrify_ssotype { get; set; } 

        [JsonProperty("centrify_autoredirect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Centrify_autoredirect { get; set; } 

        [JsonProperty("hide2fadontshowagain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hide2fadontshowagain { get; set; } 

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
        public bool? Autogenerate_accountsid { get; set; } 

        [JsonProperty("item_default_sales_nominal_code_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Item_default_sales_nominal_code_id { get; set; } 

        [JsonProperty("item_default_purchase_nominal_code_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Item_default_purchase_nominal_code_id { get; set; } 

        [JsonProperty("item_default_asset_account_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Item_default_asset_account_id { get; set; } 

        [JsonProperty("show_accounts_success_message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Show_accounts_success_message { get; set; } 

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
        public int? DefaultProblemTypeID { get; set; } 

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
        public string? Datto_url { get; set; } 

        [JsonProperty("datto_clientid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Datto_clientid { get; set; } 

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
        public int? Kaseya_toplevel { get; set; } 

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
        public bool? Prevent_stopped_ticket_creation { get; set; } 

        [JsonProperty("auto_reply_dont_update", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Auto_reply_dont_update { get; set; } 

        [JsonProperty("quote_auto_expiry_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Quote_auto_expiry_status { get; set; } 

        [JsonProperty("include_no_time_in_review", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Include_no_time_in_review { get; set; } 

        [JsonProperty("match_ninja_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Match_ninja_field { get; set; } 

        [JsonProperty("hide_opps_treeview_menu", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hide_opps_treeview_menu { get; set; } 

        [JsonProperty("westcoast_delete_licences", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Westcoast_delete_licences { get; set; } 

        [JsonProperty("defaultconsigmentuser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Defaultconsigmentuser { get; set; } 

        [JsonProperty("show_timezone_input", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Show_timezone_input { get; set; } 

        [JsonProperty("default_appointment_agent_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_appointment_agent_status { get; set; } 

        [JsonProperty("prorata_user_line_description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Prorata_user_line_description { get; set; } 

        [JsonProperty("prorata_device_line_description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Prorata_device_line_description { get; set; } 

        [JsonProperty("prorata_licence_line_description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Prorata_licence_line_description { get; set; } 

        [JsonProperty("default_quote_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_quote_status { get; set; } 

        [JsonProperty("default_quote_sent_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_quote_sent_status { get; set; } 

        [JsonProperty("default_quote_accepted_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_quote_accepted_status { get; set; } 

        [JsonProperty("default_quote_rejected_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_quote_rejected_status { get; set; } 

        [JsonProperty("useticketquoteapprovals", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Useticketquoteapprovals { get; set; } 

        [JsonProperty("trustpilot_allowwebhooks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Trustpilot_allowwebhooks { get; set; } 

        [JsonProperty("trustpilot_reviewthreshold", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Trustpilot_reviewthreshold { get; set; } 

        [JsonProperty("trustpilot_tickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Trustpilot_tickettype { get; set; } 

        [JsonProperty("trustpilot_autoreply", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Trustpilot_autoreply { get; set; } 

        [JsonProperty("trustpilot_autoreplythreshold", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Trustpilot_autoreplythreshold { get; set; } 

        [JsonProperty("trustpilot_enablesurveys", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Trustpilot_enablesurveys { get; set; } 

        [JsonProperty("trustpilot_defaultusersite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Trustpilot_defaultusersite { get; set; } 

        [JsonProperty("trustpilot_statusafterupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Trustpilot_statusafterupdate { get; set; } 

        [JsonProperty("xero_default_creditnote_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Xero_default_creditnote_status { get; set; } 

        [JsonProperty("xero_default_creditnote_line_tax", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Xero_default_creditnote_line_tax { get; set; } 

        [JsonProperty("enablehighcontrastportal", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enablehighcontrastportal { get; set; } 

        [JsonProperty("datepickermodal", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Datepickermodal { get; set; } 

        [JsonProperty("disablehalologinwithssoautoredirect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Disablehalologinwithssoautoredirect { get; set; } 

        [JsonProperty("accountemailpwdchange", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Accountemailpwdchange { get; set; } 

        [JsonProperty("accountemail2faon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Accountemail2faon { get; set; } 

        [JsonProperty("accountemail2faoff", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Accountemail2faoff { get; set; } 

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
        public int? Supplier_permission_type { get; set; } 

        [JsonProperty("cognigy_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Cognigy_url { get; set; } 

        [JsonProperty("show_user_searchbar", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Show_user_searchbar { get; set; } 

        [JsonProperty("bulkemailbatchsize", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Bulkemailbatchsize { get; set; } 

        [JsonProperty("addtional_agent_notifications", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Addtional_agent_notifications { get; set; } 

        [JsonProperty("hide_expired_quotes_portal", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hide_expired_quotes_portal { get; set; } 

        [JsonProperty("default_add_all_group_items_quote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Default_add_all_group_items_quote { get; set; } 

        [JsonProperty("dbconntype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Dbconntype { get; set; } 

        [JsonProperty("postgreslanguage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Postgreslanguage { get; set; } 

        [JsonProperty("link_to_confluence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Link_to_confluence { get; set; } 

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
        public int? Call_matching_field { get; set; } 

        [JsonProperty("automate_import_software", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Automate_import_software { get; set; } 

        [JsonProperty("ignore_special_characters_asset_matching", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ignore_special_characters_asset_matching { get; set; } 

        [JsonProperty("assign_sales_order_to_creator", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Assign_sales_order_to_creator { get; set; } 

        [JsonProperty("only_send_posted_invoices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Only_send_posted_invoices { get; set; } 

        [JsonProperty("stock_return_removes_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Stock_return_removes_user { get; set; } 

        [JsonProperty("azure_use_oid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Azure_use_oid { get; set; } 

        [JsonProperty("add_serialized_to_ticket", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Add_serialized_to_ticket { get; set; } 

        [JsonProperty("recalcbillingfaultcontractchange", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Recalcbillingfaultcontractchange { get; set; } 

        [JsonProperty("exclude_apionly_informownertech", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Exclude_apionly_informownertech { get; set; } 

        [JsonProperty("lastdailytaskdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Lastdailytaskdate { get; set; } 

        [JsonProperty("etilize_item_group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Etilize_item_group { get; set; } 

        [JsonProperty("zabbix_enable_alerting", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Zabbix_enable_alerting { get; set; } 

        [JsonProperty("zabbix_alert_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Zabbix_alert_type { get; set; } 

        [JsonProperty("zabbix_alert_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Zabbix_alert_user { get; set; } 

        [JsonProperty("gw_dont_update_sites", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Gw_dont_update_sites { get; set; } 

        [JsonProperty("generate_id_per_invoice_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Generate_id_per_invoice_type { get; set; } 

        [JsonProperty("embeddings_use_trial_data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Embeddings_use_trial_data { get; set; } 

        [JsonProperty("connectwise_rmm_enable_alerting", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Connectwise_rmm_enable_alerting { get; set; } 

        [JsonProperty("connectwise_rmm_alert_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Connectwise_rmm_alert_type { get; set; } 

        [JsonProperty("connectwise_rmm_alert_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Connectwise_rmm_alert_user { get; set; } 

        [JsonProperty("amazon_seller_create_users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Amazon_seller_create_users { get; set; } 

        [JsonProperty("amazon_seller_default_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Amazon_seller_default_site { get; set; } 

        [JsonProperty("allowpdfcustomisation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allowpdfcustomisation { get; set; } 

        [JsonProperty("ninja_user_matching_custom_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ninja_user_matching_custom_field { get; set; } 

        [JsonProperty("tracelevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Tracelevel { get; set; } 

        [JsonProperty("sales_order_project_linking_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sales_order_project_linking_type { get; set; } 

        [JsonProperty("enable_suggestions_on_call", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enable_suggestions_on_call { get; set; } 

        [JsonProperty("assetdiscovery_connection_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Assetdiscovery_connection_type { get; set; } 

        [JsonProperty("assetdiscovery_user_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Assetdiscovery_user_field { get; set; } 

        [JsonProperty("show_payment_data_on_portal", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Show_payment_data_on_portal { get; set; } 

        [JsonProperty("useintellisenseclientcache", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Useintellisenseclientcache { get; set; } 

        [JsonProperty("allow_quote_pdf_before_approval", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allow_quote_pdf_before_approval { get; set; } 

        [JsonProperty("stopbackgroundservices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Stopbackgroundservices { get; set; } 

        [JsonProperty("trace_level_reset_days", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Trace_level_reset_days { get; set; } 

        [JsonProperty("trace_level_reset_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Trace_level_reset_date { get; set; } 

        [JsonProperty("incoming_unmatched_users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Incoming_unmatched_users { get; set; } 

        [JsonProperty("incoming_default_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Incoming_default_user { get; set; } 

        [JsonProperty("incoming_newuser_default_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Incoming_newuser_default_site { get; set; } 

        [JsonProperty("incoming_newuser_send_welcome_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Incoming_newuser_send_welcome_email { get; set; } 

        [JsonProperty("incoming_newuser_send_ack", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Incoming_newuser_send_ack { get; set; } 

        [JsonProperty("showbilling_plan_text_on_ticket", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showbilling_plan_text_on_ticket { get; set; } 

        [JsonProperty("itquoter_application_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Itquoter_application_url { get; set; } 

        [JsonProperty("itquoter_view_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Itquoter_view_url { get; set; } 

        [JsonProperty("many_to_many_related_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Many_to_many_related_tickets { get; set; } 

        [JsonProperty("enabletsapprovals", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enabletsapprovals { get; set; } 

        [JsonProperty("logic_monitor_cleared_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Logic_monitor_cleared_status { get; set; } 

        [JsonProperty("prometheus_defaultsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Prometheus_defaultsite { get; set; } 

        [JsonProperty("prometheus_asset_type_choice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Prometheus_asset_type_choice { get; set; } 

        [JsonProperty("prometheus_defaultassettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Prometheus_defaultassettype { get; set; } 

        [JsonProperty("prometheus_assettypefield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Prometheus_assettypefield { get; set; } 

        [JsonProperty("prometheus_defaultgroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Prometheus_defaultgroup { get; set; } 

        [JsonProperty("prometheus_enable_alerting", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Prometheus_enable_alerting { get; set; } 

        [JsonProperty("prometheus_alerting_tickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Prometheus_alerting_tickettype { get; set; } 

        [JsonProperty("prometheus_alerting_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Prometheus_alerting_user { get; set; } 

        [JsonProperty("prometheus_deactivate_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Prometheus_deactivate_devices { get; set; } 

        [JsonProperty("default_fortnox_tenant", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_fortnox_tenant { get; set; } 

        [JsonProperty("newagent_apptsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Newagent_apptsync { get; set; } 

        [JsonProperty("lock_submitted_timesheets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Lock_submitted_timesheets { get; set; } 

        [JsonProperty("only_invoice_approved_timesheets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Only_invoice_approved_timesheets { get; set; } 

        [JsonProperty("reassigndropdownbehaviour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Reassigndropdownbehaviour { get; set; } 

        [JsonProperty("copy_contract_to_child_tasks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Copy_contract_to_child_tasks { get; set; } 

        [JsonProperty("use_subscription_status_for_invoice_line_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Use_subscription_status_for_invoice_line_status { get; set; } 

        [JsonProperty("show_appointment_other1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Show_appointment_other1 { get; set; } 

        [JsonProperty("show_appointment_other2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Show_appointment_other2 { get; set; } 

        [JsonProperty("wordpress_importcategories", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Wordpress_importcategories { get; set; } 

        [JsonProperty("wordpress_defaultfaqlist", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Wordpress_defaultfaqlist { get; set; } 

        [JsonProperty("wordpress_tagtoimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Wordpress_tagtoimport { get; set; } 

        [JsonProperty("atera_import_entities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Atera_import_entities { get; set; } 

        [JsonProperty("addigy_import_entities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Addigy_import_entities { get; set; } 

        [JsonProperty("comanaged_no_reassign", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Comanaged_no_reassign { get; set; } 

        [JsonProperty("myobdefaulttenantid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Myobdefaulttenantid { get; set; } 

        [JsonProperty("default_alert_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_alert_time { get; set; } 

        [JsonProperty("ticket_status_after_appointment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ticket_status_after_appointment { get; set; } 

        [JsonProperty("userwayaccount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Userwayaccount { get; set; } 

        [JsonProperty("checkreassignappclashes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Checkreassignappclashes { get; set; } 

        [JsonProperty("collapse_appt_filter", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Collapse_appt_filter { get; set; } 

        [JsonProperty("enable_deferred_revenue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enable_deferred_revenue { get; set; } 

        [JsonProperty("deferred_revenue_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Deferred_revenue_code { get; set; } 

        [JsonProperty("deferred_revenue_client", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Deferred_revenue_client { get; set; } 

        [JsonProperty("itglue_import_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Itglue_import_list { get; set; } 

        [JsonProperty("itglue_import_types", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? Itglue_import_types { get; set; } 

        [JsonProperty("childticketsdisplay", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Childticketsdisplay { get; set; } 

        [JsonProperty("childticketsdisplaysize", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Childticketsdisplaysize { get; set; } 

        [JsonProperty("newticketdisplay", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Newticketdisplay { get; set; } 

        [JsonProperty("auto_link_so_proj_contract", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Auto_link_so_proj_contract { get; set; } 

        [JsonProperty("google_reviewthreshold", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Google_reviewthreshold { get; set; } 

        [JsonProperty("google_reviewtickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Google_reviewtickettype { get; set; } 

        [JsonProperty("google_questiontickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Google_questiontickettype { get; set; } 

        [JsonProperty("google_reviewdefaultusersite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Google_reviewdefaultusersite { get; set; } 

        [JsonProperty("google_questiondefaultusersite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Google_questiondefaultusersite { get; set; } 

        [JsonProperty("google_reviewstatusafterupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Google_reviewstatusafterupdate { get; set; } 

        [JsonProperty("google_questionstatusafterupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Google_questionstatusafterupdate { get; set; } 

        [JsonProperty("default_columns_id_supplier_contracts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_columns_id_supplier_contracts { get; set; } 

        [JsonProperty("default_columns_id_supplier_contracts_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Default_columns_id_supplier_contracts_guid { get; set; } 

        [JsonProperty("enablefilescanning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enablefilescanning { get; set; } 

        [JsonProperty("enableclientsideuploads", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enableclientsideuploads { get; set; } 

        [JsonProperty("allow_link_attachments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allow_link_attachments { get; set; } 

        [JsonProperty("attachment_details_upload", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Attachment_details_upload { get; set; } 

        [JsonProperty("sync_servicenow_attachments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sync_servicenow_attachments { get; set; } 

        [JsonProperty("ninja_import_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ninja_import_list { get; set; } 

        [JsonProperty("ninja_import_types", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? Ninja_import_types { get; set; } 

        [JsonProperty("intacct_use_halo_creds", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Intacct_use_halo_creds { get; set; } 

        [JsonProperty("show_whatsapp_settings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Show_whatsapp_settings { get; set; } 

        [JsonProperty("enable_auto_anonuser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enable_auto_anonuser { get; set; } 

        [JsonProperty("days_until_anonuser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Days_until_anonuser { get; set; } 

        [JsonProperty("create_credit_notes_with_negative_price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Create_credit_notes_with_negative_price { get; set; } 

        [JsonProperty("always_display_halo_ihid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Always_display_halo_ihid { get; set; } 

        [JsonProperty("customise_multiple_portals", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Customise_multiple_portals { get; set; } 

        [JsonProperty("show_bundled_sales_order_lines", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Show_bundled_sales_order_lines { get; set; } 

        [JsonProperty("set_appointment_from_estimate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Set_appointment_from_estimate { get; set; } 

        [JsonProperty("override_locale", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Override_locale { get; set; } 

        [JsonProperty("vector_score_minimum", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Vector_score_minimum { get; set; } 

        [JsonProperty("vector_score_knowledge_minimum", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Vector_score_knowledge_minimum { get; set; } 

        [JsonProperty("vector_category2_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Vector_category2_type { get; set; } 

        [JsonProperty("show_review_on_billing_screen", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Show_review_on_billing_screen { get; set; } 

        [JsonProperty("default_view_assets_selectedid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_view_assets_selectedid { get; set; } 

        [JsonProperty("default_list_assets_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Default_list_assets_guid { get; set; } 

        [JsonProperty("logicmonitor_alerting_assetidentifier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Logicmonitor_alerting_assetidentifier { get; set; } 

        [JsonProperty("project_notes_tab_display", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Project_notes_tab_display { get; set; } 

        [JsonProperty("send_timesheet_rejection_emails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Send_timesheet_rejection_emails { get; set; } 

        [JsonProperty("dont_show_empty_stock_locations_on_consign", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dont_show_empty_stock_locations_on_consign { get; set; } 

        [JsonProperty("teams_chat_management", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Teams_chat_management { get; set; } 

        [JsonProperty("teams_azure_authority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Teams_azure_authority { get; set; } 

        [JsonProperty("teams_chat_default_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Teams_chat_default_name { get; set; } 

        [JsonProperty("teams_connected_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Teams_connected_user { get; set; } 

        [JsonProperty("teams_connected_user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Teams_connected_user_id { get; set; } 

        [JsonProperty("teams_connected_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Teams_connected_user_name { get; set; } 

        [JsonProperty("default_quote_ticket_approval", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_quote_ticket_approval { get; set; } 

        [JsonProperty("only_quote_ticket_approval", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Only_quote_ticket_approval { get; set; } 

        [JsonProperty("show_currency_conversion_for_quote_lines", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Show_currency_conversion_for_quote_lines { get; set; } 

        [JsonProperty("update_first_action_details_via_template", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Update_first_action_details_via_template { get; set; } 

        [JsonProperty("unlink_ticket_advanced_edit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Unlink_ticket_advanced_edit { get; set; } 

        [JsonProperty("showseperateresolutionandfixbars", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showseperateresolutionandfixbars { get; set; } 

        [JsonProperty("bigpanda_tickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Bigpanda_tickettype { get; set; } 

        [JsonProperty("bigpanda_asset_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Bigpanda_asset_list { get; set; } 

        [JsonProperty("google_cal_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Google_cal_method { get; set; } 

        [JsonProperty("google_import_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Google_import_type { get; set; } 

        [JsonProperty("accent_insensitive_search", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Accent_insensitive_search { get; set; } 

        [JsonProperty("azure_single_logout", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Azure_single_logout { get; set; } 

        [JsonProperty("okta_single_logout", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Okta_single_logout { get; set; } 

        [JsonProperty("google_single_logout", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Google_single_logout { get; set; } 

        [JsonProperty("default_salesorder_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_salesorder_status { get; set; } 

        [JsonProperty("use_default_call_summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Use_default_call_summary { get; set; } 

        [JsonProperty("show_quote_approval_signature", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Show_quote_approval_signature { get; set; } 

        [JsonProperty("update_respond_by_date_with_hold_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Update_respond_by_date_with_hold_time { get; set; } 

        [JsonProperty("giacom_use_new_endpoint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Giacom_use_new_endpoint { get; set; } 

        [JsonProperty("dattormm_alert_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Dattormm_alert_user { get; set; } 

        [JsonProperty("invoice_minimum_item_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Invoice_minimum_item_id { get; set; } 

        [JsonProperty("dattormm_webhook_ticket_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Dattormm_webhook_ticket_type { get; set; } 

        [JsonProperty("appt_import_agent_identifier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Appt_import_agent_identifier { get; set; } 

        [JsonProperty("appt_import_user_identifier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Appt_import_user_identifier { get; set; } 

        [JsonProperty("planning_green_colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Planning_green_colour { get; set; } 

        [JsonProperty("planning_orange_colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Planning_orange_colour { get; set; } 

        [JsonProperty("planning_red_colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Planning_red_colour { get; set; } 

        [JsonProperty("crmshowsatisfaction", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Crmshowsatisfaction { get; set; } 

        [JsonProperty("update_milestone_dates_via_tasks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Update_milestone_dates_via_tasks { get; set; } 

        [JsonProperty("hide_unknown_software_from_lists", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hide_unknown_software_from_lists { get; set; } 

        [JsonProperty("wordpressorg_importcategories", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Wordpressorg_importcategories { get; set; } 

        [JsonProperty("wordpressorg_defaultfaqlist", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Wordpressorg_defaultfaqlist { get; set; } 

        [JsonProperty("only_show_needs_order_lines_when_supplier_set", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Only_show_needs_order_lines_when_supplier_set { get; set; } 

        [JsonProperty("show_attachments_from_linked_quote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Show_attachments_from_linked_quote { get; set; } 

        [JsonProperty("show_attachments_from_linked_so", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Show_attachments_from_linked_so { get; set; } 

        [JsonProperty("allow_sla_target_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allow_sla_target_override { get; set; } 

        [JsonProperty("show_invoice_totals_on_portal", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Show_invoice_totals_on_portal { get; set; } 

        [JsonProperty("show_all_sites_for_device_quantity_calc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Show_all_sites_for_device_quantity_calc { get; set; } 

        [JsonProperty("user_portal_theme", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? User_portal_theme { get; set; } 

        [JsonProperty("prometheus_create_devices_from_webhooks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Prometheus_create_devices_from_webhooks { get; set; } 

        [JsonProperty("prometheus_api_urls", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Prometheus_api_urls { get; set; } 

        [JsonProperty("allow_followers_modify_ticket", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allow_followers_modify_ticket { get; set; } 

        [JsonProperty("gocardless_companyname_matching", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Gocardless_companyname_matching { get; set; } 

        [JsonProperty("gocardless_defaultsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Gocardless_defaultsite { get; set; } 

        [JsonProperty("gocardless_use_sandbox", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Gocardless_use_sandbox { get; set; } 

        [JsonProperty("show_lang_navbar", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Show_lang_navbar { get; set; } 

        [JsonProperty("sync_salesforce_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sync_salesforce_status { get; set; } 

        [JsonProperty("agreement_default_billing_period", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Agreement_default_billing_period { get; set; } 

        [JsonProperty("show_contributor_quality", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Show_contributor_quality { get; set; } 

        [JsonProperty("show_holiday_timesheet", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Show_holiday_timesheet { get; set; } 

        [JsonProperty("reply_outcome", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Reply_outcome { get; set; } 

        [JsonProperty("round_labour_invoice_quantity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Round_labour_invoice_quantity { get; set; } 

        [JsonProperty("import_pax8_usage_lines", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Import_pax8_usage_lines { get; set; } 

        [JsonProperty("related_assets_column_profile", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Related_assets_column_profile { get; set; } 

        [JsonProperty("showusersassetsonnewticket", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showusersassetsonnewticket { get; set; } 

        [JsonProperty("auto_approve_pos", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Auto_approve_pos { get; set; } 

        [JsonProperty("mark_notifications_as_done_before_deleting", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Mark_notifications_as_done_before_deleting { get; set; } 

        [JsonProperty("track_category_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Track_category_id { get; set; } 

        [JsonProperty("show_auto_payment_on_portal", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Show_auto_payment_on_portal { get; set; } 

        [JsonProperty("include_bundled_lines_for_recurring_invoices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Include_bundled_lines_for_recurring_invoices { get; set; } 

        [JsonProperty("default_avalara_tenant", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_avalara_tenant { get; set; } 

        [JsonProperty("default_meter_pricing_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_meter_pricing_method { get; set; } 

        [JsonProperty("logicmonitor_asset_type_choice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Logicmonitor_asset_type_choice { get; set; } 

        [JsonProperty("logicmonitor_assettypefield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Logicmonitor_assettypefield { get; set; } 

        [JsonProperty("logicmonitor_defaultgroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Logicmonitor_defaultgroup { get; set; } 

        [JsonProperty("show_note_after_completed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Show_note_after_completed { get; set; } 

        [JsonProperty("use_halo_invoice_id_for_pdf", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Use_halo_invoice_id_for_pdf { get; set; } 

        [JsonProperty("stripe_send_recipient_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Stripe_send_recipient_email { get; set; } 

        [JsonProperty("meraki_top_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Meraki_top_level { get; set; } 

        [JsonProperty("meraki_asset_type_choice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Meraki_asset_type_choice { get; set; } 

        [JsonProperty("merakidefaultassettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Merakidefaultassettype { get; set; } 

        [JsonProperty("merakiassettypefield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Merakiassettypefield { get; set; } 

        [JsonProperty("meraki_defaultgroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Meraki_defaultgroup { get; set; } 

        [JsonProperty("meraki_defaultgroup_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Meraki_defaultgroup_guid { get; set; } 

        [JsonProperty("lapsafe_default_installation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Lapsafe_default_installation { get; set; } 

        [JsonProperty("lapsafe_default_bay_size", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Lapsafe_default_bay_size { get; set; } 

        [JsonProperty("lapsafe_default_expiry_hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Lapsafe_default_expiry_hours { get; set; } 

        [JsonProperty("lapsafe_status_after_webhook", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Lapsafe_status_after_webhook { get; set; } 

        [JsonProperty("lapsafe_status_after_webhook_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Lapsafe_status_after_webhook_guid { get; set; } 

        [JsonProperty("lapsafedefaultdropoffemailtemplate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Lapsafedefaultdropoffemailtemplate { get; set; } 

        [JsonProperty("lapsafedefaultdropoffemailtemplate_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Lapsafedefaultdropoffemailtemplate_guid { get; set; } 

        [JsonProperty("lapsafedefaultcollectionemailtemplate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Lapsafedefaultcollectionemailtemplate { get; set; } 

        [JsonProperty("lapsafedefaultcollectionemailtemplate_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Lapsafedefaultcollectionemailtemplate_guid { get; set; } 

        [JsonProperty("zabbix_dont_close_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Zabbix_dont_close_tickets { get; set; } 

        [JsonProperty("warn_customtable_delete", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Warn_customtable_delete { get; set; } 

        [JsonProperty("ai_thankyou_detection", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ai_thankyou_detection { get; set; } 

        [JsonProperty("techdata_default_tenant", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Techdata_default_tenant { get; set; } 

        [JsonProperty("ingram_default_tenant", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ingram_default_tenant { get; set; } 

        [JsonProperty("credit_item", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Credit_item { get; set; } 

        [JsonProperty("itglue_sync_entities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Itglue_sync_entities { get; set; } 

        [JsonProperty("itglue_show_message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Itglue_show_message { get; set; } 

        [JsonProperty("slack_channel_management", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Slack_channel_management { get; set; } 

        [JsonProperty("slack_channel_default_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Slack_channel_default_name { get; set; } 

        [JsonProperty("slack_channel_access_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Slack_channel_access_type { get; set; } 

        [JsonProperty("hide_text_override_service", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hide_text_override_service { get; set; } 

        [JsonProperty("nextfaultidcalculationmethod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Nextfaultidcalculationmethod { get; set; } 

        [JsonProperty("taskmonitorsnoozeseverity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Taskmonitorsnoozeseverity { get; set; } 

        [JsonProperty("taskmonitorsnoozedate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Taskmonitorsnoozedate { get; set; } 

        [JsonProperty("slack_channel_workspace", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Slack_channel_workspace { get; set; } 

        [JsonProperty("slack_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Slack_client_id { get; set; } 

        [JsonProperty("slack_action_outcome", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Slack_action_outcome { get; set; } 

        [JsonProperty("slack_command_ticket_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Slack_command_ticket_type { get; set; } 

        [JsonProperty("slack_command_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Slack_command_user { get; set; } 

        [JsonProperty("quote_expiry_ticket_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Quote_expiry_ticket_status { get; set; } 

        [JsonProperty("default_online_report_group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_online_report_group { get; set; } 

        [JsonProperty("new_cf_storage_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? New_cf_storage_method { get; set; } 

        [JsonProperty("default_for_action_reviewed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Default_for_action_reviewed { get; set; } 

        [JsonProperty("ticket_info_display_top", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ticket_info_display_top { get; set; } 

        [JsonProperty("sla_bar_time_display", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sla_bar_time_display { get; set; } 

        [JsonProperty("assign_sales_order", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Assign_sales_order { get; set; } 

        [JsonProperty("sync_customers_to_stripe", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sync_customers_to_stripe { get; set; } 

        [JsonProperty("show_accept_reject_all", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Show_accept_reject_all { get; set; } 

        [JsonProperty("disable_edit_kb_fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Disable_edit_kb_fields { get; set; } 

        [JsonProperty("workflow_progress_display_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Workflow_progress_display_type { get; set; } 

        [JsonProperty("showclosureattachment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showclosureattachment { get; set; } 

        [JsonProperty("defaultinvoicedatetotoday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Defaultinvoicedatetotoday { get; set; } 

        [JsonProperty("user_match_phonenumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? User_match_phonenumber { get; set; } 

        [JsonProperty("parent_and_related_cf_copy_priority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Parent_and_related_cf_copy_priority { get; set; } 

        [JsonProperty("ticketstatusafterquoteinternalrejection", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ticketstatusafterquoteinternalrejection { get; set; } 

        [JsonProperty("show_child_templates_always", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Show_child_templates_always { get; set; } 

        [JsonProperty("whatsapp_defaultclientsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Whatsapp_defaultclientsite { get; set; } 

        [JsonProperty("xsoar_default_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Xsoar_default_user { get; set; } 

        [JsonProperty("xsoar_default_tickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Xsoar_default_tickettype { get; set; } 

        [JsonProperty("use_charge_rate_item_tax", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Use_charge_rate_item_tax { get; set; } 

        [JsonProperty("emailsendervalidation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Emailsendervalidation { get; set; } 

        [JsonProperty("2faemailallowedifnoothermethods", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _2faemailallowedifnoothermethods { get; set; } 

        [JsonProperty("useteamshifts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Useteamshifts { get; set; } 

        [JsonProperty("dynamicscrm_sitenamefilter", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Dynamicscrm_sitenamefilter { get; set; } 

        [JsonProperty("adobeacrobat_auto_expire_td", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Adobeacrobat_auto_expire_td { get; set; } 

        [JsonProperty("defaultadobeactenant", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Defaultadobeactenant { get; set; } 

        [JsonProperty("adobeacrobat_accept_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Adobeacrobat_accept_status { get; set; } 

        [JsonProperty("adobeacrobat_reject_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Adobeacrobat_reject_status { get; set; } 

        [JsonProperty("display_ticket_workflow_on_quote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Display_ticket_workflow_on_quote { get; set; } 

        [JsonProperty("line_action_display_behaviour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Line_action_display_behaviour { get; set; } 

        [JsonProperty("hide_addr_footer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hide_addr_footer { get; set; } 

        [JsonProperty("hide_phone_footer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hide_phone_footer { get; set; } 

        [JsonProperty("hide_email_footer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hide_email_footer { get; set; } 

        [JsonProperty("hide_lang_footer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hide_lang_footer { get; set; } 

        [JsonProperty("show_html_footer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Show_html_footer { get; set; } 

        [JsonProperty("html_footer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Html_footer { get; set; } 

        [JsonProperty("adobecommercedefaultsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Adobecommercedefaultsite { get; set; } 

        [JsonProperty("adobecommerce_integratorentitiestoimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Adobecommerce_integratorentitiestoimport { get; set; } 

        [JsonProperty("update_all_actions_when_contract_changed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Update_all_actions_when_contract_changed { get; set; } 

        [JsonProperty("use_new_search_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Use_new_search_method { get; set; } 

        [JsonProperty("assetdiscovery_defaultsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Assetdiscovery_defaultsite { get; set; } 

        [JsonProperty("assetdiscovery_defaultsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Assetdiscovery_defaultsite_name { get; set; } 

        [JsonProperty("lansweeper_override_site_rules", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Lansweeper_override_site_rules { get; set; } 

        [JsonProperty("salesforce_integratorattachmentstoimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Salesforce_integratorattachmentstoimport { get; set; } 

        [JsonProperty("defaultpdftemplatebill", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Defaultpdftemplatebill { get; set; } 

        [JsonProperty("default_filter_open_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_filter_open_tickets { get; set; } 

        [JsonProperty("assetdateformat", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Assetdateformat { get; set; } 

        [JsonProperty("use_item_catalogue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Use_item_catalogue { get; set; } 

        [JsonProperty("only_show_invoices_after_3rd_party_sync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Only_show_invoices_after_3rd_party_sync { get; set; } 

        [JsonProperty("always_show_line_actions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Always_show_line_actions { get; set; } 

        [JsonProperty("due_date_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Due_date_type { get; set; } 

        [JsonProperty("ai_connection_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ai_connection_type { get; set; } 

        [JsonProperty("enable_ai_kb_articles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enable_ai_kb_articles { get; set; } 

        [JsonProperty("azureopenai_enable_ai_kb_articles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Azureopenai_enable_ai_kb_articles { get; set; } 

        [JsonProperty("enable_openai_emotion_detection", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enable_openai_emotion_detection { get; set; } 

        [JsonProperty("enable_azureopenai_emotion_detection", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enable_azureopenai_emotion_detection { get; set; } 

        [JsonProperty("embeddingaideployment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(50)]
        public string? Embeddingaideployment { get; set; } 

        [JsonProperty("enable_openai_insights", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enable_openai_insights { get; set; } 

        [JsonProperty("enable_azureopenai_insights", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enable_azureopenai_insights { get; set; } 

        [JsonProperty("auto_extend_end_dates_on_recurring_invoices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Auto_extend_end_dates_on_recurring_invoices { get; set; } 

        [JsonProperty("portalservicedetailsdisplaytype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Portalservicedetailsdisplaytype { get; set; } 

        [JsonProperty("ticket_embeddings_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ticket_embeddings_method { get; set; } 

        [JsonProperty("ticket_embeddings_db", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ticket_embeddings_db { get; set; } 

        [JsonProperty("ai_knowledge_search_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ai_knowledge_search_method { get; set; } 

        [JsonProperty("last_day_of_month_billing", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Last_day_of_month_billing { get; set; } 

        [JsonProperty("use_qbo_invoice_terms", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Use_qbo_invoice_terms { get; set; } 

        [JsonProperty("show_status_filter", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Show_status_filter { get; set; } 

        [JsonProperty("auvik_delete_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Auvik_delete_devices { get; set; } 

        [JsonProperty("order_teams_by_sequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Order_teams_by_sequence { get; set; } 

        [JsonProperty("email_template_for_pending_closure", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Email_template_for_pending_closure { get; set; } 

        [JsonProperty("showaccountmanageronclientdetails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showaccountmanageronclientdetails { get; set; } 

        [JsonProperty("show_asset_diagram_licences", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Show_asset_diagram_licences { get; set; } 

        [JsonProperty("issue_project_non_consignable_items", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Issue_project_non_consignable_items { get; set; } 

        [JsonProperty("ticketstatusafterquotesent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ticketstatusafterquotesent { get; set; } 

        [JsonProperty("ticketstatusafterquotesent_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Ticketstatusafterquotesent_guid { get; set; } 

        [JsonProperty("use_azure_openai_surveys", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Use_azure_openai_surveys { get; set; } 

        [JsonProperty("use_openai_surveys", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Use_openai_surveys { get; set; } 

        [JsonProperty("ai_survey_sample_rate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ai_survey_sample_rate { get; set; } 

        [JsonProperty("default_asset_chart_relationships", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Default_asset_chart_relationships { get; set; } 

        [JsonProperty("saml_matching_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Saml_matching_type { get; set; } 

        [JsonProperty("saml_matching_attr", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Saml_matching_attr { get; set; } 

        [JsonProperty("freshdesk_statusfilter", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Freshdesk_statusfilter { get; set; } 

        [JsonProperty("freshdesk_matchusername", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Freshdesk_matchusername { get; set; } 

        [JsonProperty("enhancedAnnouncement", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnhancedAnnouncement { get; set; } 

        [JsonProperty("distributionlists_createusers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Distributionlists_createusers { get; set; } 

        [JsonProperty("distributionlists_defaultsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Distributionlists_defaultsite { get; set; } 

        [JsonProperty("distributionlists_activityinuserfeed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Distributionlists_activityinuserfeed { get; set; } 

        [JsonProperty("password_char_length", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Password_char_length { get; set; } 

        [JsonProperty("agent_status_for_free_appointments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Agent_status_for_free_appointments { get; set; } 

        [JsonProperty("gw_assettype_choice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Gw_assettype_choice { get; set; } 

        [JsonProperty("gw_default_devicetype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Gw_default_devicetype { get; set; } 

        [JsonProperty("gw_mobile_site_matching", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Gw_mobile_site_matching { get; set; } 

        [JsonProperty("document_view_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Document_view_type { get; set; } 

        [JsonProperty("quote_any_line_profit_for_approval_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Quote_any_line_profit_for_approval_type { get; set; } 

        [JsonProperty("quote_any_line_profit_for_approval_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Quote_any_line_profit_for_approval_value { get; set; } 

        [JsonProperty("quote_average_profit_for_approval_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Quote_average_profit_for_approval_type { get; set; } 

        [JsonProperty("quote_average_profit_for_approval_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Quote_average_profit_for_approval_value { get; set; } 

        [JsonProperty("gotoresolve_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Gotoresolve_client_id { get; set; } 

        [JsonProperty("allowclientmerging", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allowclientmerging { get; set; } 

        [JsonProperty("addclientdeleteperm", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Addclientdeleteperm { get; set; } 

        [JsonProperty("only_use_out_of_hours_priority_for_user_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Only_use_out_of_hours_priority_for_user_tickets { get; set; } 

        [JsonProperty("allow_reponse_edit_after", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allow_reponse_edit_after { get; set; } 

        [JsonProperty("show_linked_articles_users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Show_linked_articles_users { get; set; } 

        [JsonProperty("timelineshowagentworkhours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Timelineshowagentworkhours { get; set; } 

        [JsonProperty("feedback_comment_mandatory", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Feedback_comment_mandatory { get; set; } 

        [JsonProperty("ai_search_store_descriptions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ai_search_store_descriptions { get; set; } 

        [JsonProperty("textsplit_chunk_size", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Textsplit_chunk_size { get; set; } 

        [JsonProperty("textsplit_chunk_overlap", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Textsplit_chunk_overlap { get; set; } 

        [JsonProperty("ai_description_mapping", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ai_description_mapping { get; set; } 

        [JsonProperty("ai_description_mapping_custom", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(255)]
        public string? Ai_description_mapping_custom { get; set; } 

        [JsonProperty("ai_embedding_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ai_embedding_field { get; set; } 

        [JsonProperty("enable_purchase_currency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enable_purchase_currency { get; set; } 

        [JsonProperty("last_license_sync_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Last_license_sync_date { get; set; } 

        [JsonProperty("show_home_html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Show_home_html { get; set; } 

        [JsonProperty("home_html_position", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Home_html_position { get; set; } 

        [JsonProperty("match_datto_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Match_datto_user { get; set; } 

        [JsonProperty("match_datto_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Match_datto_field { get; set; } 

        [JsonProperty("datto_user_matching_custom_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Datto_user_matching_custom_field { get; set; } 

        [JsonProperty("optional_default_unchecked", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Optional_default_unchecked { get; set; } 

        [JsonProperty("prorata_default_line_description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Prorata_default_line_description { get; set; } 

        [JsonProperty("ai_insights_context", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(255)]
        public string? Ai_insights_context { get; set; } 

        [JsonProperty("enable_ai_article_suggestions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enable_ai_article_suggestions { get; set; } 

        [JsonProperty("ignore_visibilty_restrictions_on_action_links", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ignore_visibilty_restrictions_on_action_links { get; set; } 

        [JsonProperty("enableoppteamscall", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enableoppteamscall { get; set; } 

        [JsonProperty("allow_kb_publishing", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allow_kb_publishing { get; set; } 

        [JsonProperty("hide_credit_lines_on_invoices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hide_credit_lines_on_invoices { get; set; } 

        [JsonProperty("user_match_alternative_email_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? User_match_alternative_email_address { get; set; } 

        [JsonProperty("default_site_sla", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_site_sla { get; set; } 

        [JsonProperty("auto_submit_auto_generated_is_auto_reply", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Auto_submit_auto_generated_is_auto_reply { get; set; } 

        [JsonProperty("auto_submit_auto_replied_is_auto_reply", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Auto_submit_auto_replied_is_auto_reply { get; set; } 

        [JsonProperty("default_use_linked_subscription_price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Default_use_linked_subscription_price { get; set; } 

        [JsonProperty("default_use_linked_subscription_cost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Default_use_linked_subscription_cost { get; set; } 

        [JsonProperty("default_item_view", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_item_view { get; set; } 

        [JsonProperty("restrict_portal_new_ticket", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Restrict_portal_new_ticket { get; set; } 

        [JsonProperty("mailchimp_integratorentitiestoimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Mailchimp_integratorentitiestoimport { get; set; } 

        [JsonProperty("mailcampaign_activityinuserfeed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Mailcampaign_activityinuserfeed { get; set; } 

        [JsonProperty("addautosuppressheader", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Addautosuppressheader { get; set; } 

        [JsonProperty("approval_showcomment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Approval_showcomment { get; set; } 

        [JsonProperty("enableperperiodexpirycalculation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enableperperiodexpirycalculation { get; set; } 

        [JsonProperty("show_agents_forgot_password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Show_agents_forgot_password { get; set; } 

        [JsonProperty("show_users_forgot_password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Show_users_forgot_password { get; set; } 

        [JsonProperty("lookup_search_filters", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Lookup_search_filters { get; set; } 

        [JsonProperty("assets_show_genpdf", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Assets_show_genpdf { get; set; } 

        [JsonProperty("allow_presence_notifications", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allow_presence_notifications { get; set; } 

        [JsonProperty("po_visible_to_users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Po_visible_to_users { get; set; } 

        [JsonProperty("default_columns_id_supplier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_columns_id_supplier { get; set; } 

        [JsonProperty("default_columns_id_supplier_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Default_columns_id_supplier_guid { get; set; } 

        [JsonProperty("problemmatchproductmatch", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Problemmatchproductmatch { get; set; } 

        [JsonProperty("icinga_assigned_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Icinga_assigned_status { get; set; } 

        [JsonProperty("use_purchase_order_id_for_reference", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Use_purchase_order_id_for_reference { get; set; } 

        [JsonProperty("show_res_in_desc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Show_res_in_desc { get; set; } 

        [JsonProperty("freshdesk_action_userid_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Freshdesk_action_userid_field { get; set; } 

        [JsonProperty("update_recurring_bundle_price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Update_recurring_bundle_price { get; set; } 

        [JsonProperty("sync_invoices_manually", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sync_invoices_manually { get; set; } 

        [JsonProperty("set_accountsid_to_sku", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Set_accountsid_to_sku { get; set; } 

        [JsonProperty("item_sku_is_unique", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Item_sku_is_unique { get; set; } 

        [JsonProperty("match_item_on_sku", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Match_item_on_sku { get; set; } 

        [JsonProperty("allow_requestor_in_cab_approvals", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allow_requestor_in_cab_approvals { get; set; } 

        [JsonProperty("meraki_import_entities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Meraki_import_entities { get; set; } 

        [JsonProperty("group_ticket_po_creation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Group_ticket_po_creation { get; set; } 

        [JsonProperty("show_orderlines_no_supplier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Show_orderlines_no_supplier { get; set; } 

        [JsonProperty("addigy_dont_update_device_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Addigy_dont_update_device_type { get; set; } 

        [JsonProperty("void_invoice_rewinds_billing_entites", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Void_invoice_rewinds_billing_entites { get; set; } 

        [JsonProperty("dont_show_zero_charge_rate_ready_for_invoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dont_show_zero_charge_rate_ready_for_invoice { get; set; } 

        [JsonProperty("supplier_currency_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Supplier_currency_override { get; set; } 

        [JsonProperty("idle_session_timeout_mins_agent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Idle_session_timeout_mins_agent { get; set; } 

        [JsonProperty("record_online_presence_snapshots", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Record_online_presence_snapshots { get; set; } 

        [JsonProperty("check_same_customer_for_change_collision", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Check_same_customer_for_change_collision { get; set; } 

        [JsonProperty("default_show_inactive_assets_on_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Default_show_inactive_assets_on_site { get; set; } 

        [JsonProperty("showemailinuseractivity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showemailinuseractivity { get; set; } 

        [JsonProperty("po_approval_email_addr", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Po_approval_email_addr { get; set; } 

        [JsonProperty("show_negative_tax_invoices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Show_negative_tax_invoices { get; set; } 

        [JsonProperty("donotalloweditingpostedinvoicesfreq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Donotalloweditingpostedinvoicesfreq { get; set; } 

        [JsonProperty("default_quote_revised_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_quote_revised_status { get; set; } 

        [JsonProperty("reservedintfield1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Reservedintfield1 { get; set; } 

        [JsonProperty("nag_down_priority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Nag_down_priority { get; set; } 

        [JsonProperty("nag_unreachable_priority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Nag_unreachable_priority { get; set; } 

        [JsonProperty("nag_unknown_priority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Nag_unknown_priority { get; set; } 

        [JsonProperty("defaultbulkdevicepdftemplate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Defaultbulkdevicepdftemplate { get; set; } 

        [JsonProperty("allow_invoice_deletion_when_sent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allow_invoice_deletion_when_sent { get; set; } 

        [JsonProperty("datadog_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Datadog_user { get; set; } 

        [JsonProperty("datadog_tickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Datadog_tickettype { get; set; } 

        [JsonProperty("datadog_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Datadog_user_name { get; set; } 

        [JsonProperty("truncate_salesmb_reply_chain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Truncate_salesmb_reply_chain { get; set; } 

        [JsonProperty("users_department_view_scope", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Users_department_view_scope { get; set; } 

        [JsonProperty("limit_po_stock_received", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Limit_po_stock_received { get; set; } 

        [JsonProperty("set_budget_total_to_budget_table", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Set_budget_total_to_budget_table { get; set; } 

        [JsonProperty("show_favourite_services_at_start", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Show_favourite_services_at_start { get; set; } 

        [JsonProperty("reservedboolfield1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Reservedboolfield1 { get; set; } 

        [JsonProperty("use_contract_rules", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Use_contract_rules { get; set; } 

        [JsonProperty("contract_rules_match_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Contract_rules_match_type { get; set; } 

        [JsonProperty("snelstart_invoice_template", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Snelstart_invoice_template { get; set; } 

        [JsonProperty("problemmatchcustomfield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Problemmatchcustomfield { get; set; } 

        [JsonProperty("apply_rules_on_drag_and_drop", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Apply_rules_on_drag_and_drop { get; set; } 

        [JsonProperty("open_report_without_loading", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Open_report_without_loading { get; set; } 

        [JsonProperty("show_livechat_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Show_livechat_url { get; set; } 

        [JsonProperty("category_auto_expand", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Category_auto_expand { get; set; } 

        [JsonProperty("hide_enddate_timezone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hide_enddate_timezone { get; set; } 

        [JsonProperty("enable_clear_nable_rmm_alert_check", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enable_clear_nable_rmm_alert_check { get; set; } 

        [JsonProperty("show_asset_diagram_keyfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Show_asset_diagram_keyfields { get; set; } 

        [JsonProperty("allowkbinfaqgroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allowkbinfaqgroup { get; set; } 

        [JsonProperty("giacomdeletelicences", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Giacomdeletelicences { get; set; } 

        [JsonProperty("apply_query_builder_perms", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Apply_query_builder_perms { get; set; } 

        [JsonProperty("ai_summary_description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(255)]
        public string? Ai_summary_description { get; set; } 

        [JsonProperty("enable_ai_conversation_summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enable_ai_conversation_summary { get; set; } 

        [JsonProperty("ticket_hover_summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ticket_hover_summary { get; set; } 

        [JsonProperty("autogroupnewitems", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Autogroupnewitems { get; set; } 

        [JsonProperty("use_prospects", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Use_prospects { get; set; } 

        [JsonProperty("can_edit_sent_invoice_lines", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Can_edit_sent_invoice_lines { get; set; } 

        [JsonProperty("defaultcontractdetailslayout", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Defaultcontractdetailslayout { get; set; } 

        [JsonProperty("allow_kb_anonymous", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allow_kb_anonymous { get; set; } 

        [JsonProperty("lapsafedefaultswapemailtemplate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Lapsafedefaultswapemailtemplate { get; set; } 

        [JsonProperty("lapsafedefaultswapemailtemplate_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Lapsafedefaultswapemailtemplate_guid { get; set; } 

        [JsonProperty("orion_reset_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Orion_reset_status { get; set; } 

        [JsonProperty("access_change_calendar_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Access_change_calendar_tickets { get; set; } 

        [JsonProperty("services_portalbackgroundimageurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(500)]
        public string? Services_portalbackgroundimageurl { get; set; } 

        [JsonProperty("itglue_disable_address_sync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Itglue_disable_address_sync { get; set; } 

        [JsonProperty("conversion_probability_colour1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Conversion_probability_colour1 { get; set; } 

        [JsonProperty("conversion_probability_colour2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Conversion_probability_colour2 { get; set; } 

        [JsonProperty("conversion_probability_colour3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Conversion_probability_colour3 { get; set; } 

        [JsonProperty("conversion_probability_colour4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Conversion_probability_colour4 { get; set; } 

        [JsonProperty("nextattachmentidcalculationmethod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Nextattachmentidcalculationmethod { get; set; } 

        [JsonProperty("portal_action_date_display", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Portal_action_date_display { get; set; } 

        [JsonProperty("show_action_date_display_toggle", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Show_action_date_display_toggle { get; set; } 

        [JsonProperty("ignore_duplicate_emails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ignore_duplicate_emails { get; set; } 

        [JsonProperty("hidekbviews", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hidekbviews { get; set; } 

        [JsonProperty("hidekbratings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hidekbratings { get; set; } 

        [JsonProperty("show_markup_for_sales_orders", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Show_markup_for_sales_orders { get; set; } 

        [JsonProperty("ai_suggestion_alert", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ai_suggestion_alert { get; set; } 

        [JsonProperty("quotes_from_mailbox_fallback_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Quotes_from_mailbox_fallback_id { get; set; } 

        [JsonProperty("matchinreplyto", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Matchinreplyto { get; set; } 

        [JsonProperty("kbfeedbacktickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Kbfeedbacktickettype { get; set; } 

        [JsonProperty("usetravelchargeratesonbpc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Usetravelchargeratesonbpc { get; set; } 

        [JsonProperty("assetimportsecondaryidentifier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Assetimportsecondaryidentifier { get; set; } 

        [JsonProperty("assetimportsecondaryidentifier_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Assetimportsecondaryidentifier_guid { get; set; } 

        [JsonProperty("appointment_sla_procedure_mins", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Appointment_sla_procedure_mins { get; set; } 

        [JsonProperty("treat_comanaged_agent_emails_as_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Treat_comanaged_agent_emails_as_user { get; set; } 

        [JsonProperty("gw_dont_create_new_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Gw_dont_create_new_devices { get; set; } 

        [JsonProperty("exchange_calendar_webhooks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Exchange_calendar_webhooks { get; set; } 

        [JsonProperty("exchange_azure_authority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Exchange_azure_authority { get; set; } 

        [JsonProperty("exchange_use_immutable_ids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Exchange_use_immutable_ids { get; set; } 

        [JsonProperty("exchange_no_mutable_ids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Exchange_no_mutable_ids { get; set; } 

        [JsonProperty("exchange_calendar_webhook_import_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Exchange_calendar_webhook_import_type { get; set; } 

        [JsonProperty("warningafterxminutes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Warningafterxminutes { get; set; } 

        [JsonProperty("use_phone_int_search", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Use_phone_int_search { get; set; } 

        [JsonProperty("use_xero_tracking_categories", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Use_xero_tracking_categories { get; set; } 

        [JsonProperty("xero_tracking_category_1_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Xero_tracking_category_1_name { get; set; } 

        [JsonProperty("xero_tracking_category_2_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Xero_tracking_category_2_name { get; set; } 

        [JsonProperty("rpi_percent_increase", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Rpi_percent_increase { get; set; } 

        [JsonProperty("google_analytics_measurement_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Google_analytics_measurement_id { get; set; } 

        [JsonProperty("tickettimermodalpause", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Tickettimermodalpause { get; set; } 

        [JsonProperty("hubspot_item_group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Hubspot_item_group { get; set; } 

        [JsonProperty("hubspot_deal_tickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Hubspot_deal_tickettype { get; set; } 

        [JsonProperty("hubspot_item_sync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Hubspot_item_sync { get; set; } 

        [JsonProperty("hubspot_webhooks_products", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hubspot_webhooks_products { get; set; } 

        [JsonProperty("hubspot_webhooks_deals", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hubspot_webhooks_deals { get; set; } 

        [JsonProperty("hubspot_webhooks_quotes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hubspot_webhooks_quotes { get; set; } 

        [JsonProperty("auto_complete_appointments_to_add_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Auto_complete_appointments_to_add_time { get; set; } 

        [JsonProperty("matched_event_retention", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Matched_event_retention { get; set; } 

        [JsonProperty("unmatched_event_retention", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Unmatched_event_retention { get; set; } 

        [JsonProperty("auto_reorder_items", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Auto_reorder_items { get; set; } 

        [JsonProperty("delivery_default", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Delivery_default { get; set; } 

        [JsonProperty("redact_card_details", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Redact_card_details { get; set; } 

        [JsonProperty("appointment_sla_procedure_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Appointment_sla_procedure_status { get; set; } 

        [JsonProperty("invoicesalesorderbillingdescriptionlong", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(500)]
        public string? Invoicesalesorderbillingdescriptionlong { get; set; } 

        [JsonProperty("invoicesalesorderprojectsbillingdescriptionlong", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(500)]
        public string? Invoicesalesorderprojectsbillingdescriptionlong { get; set; } 

        [JsonProperty("show_client_user_only", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Show_client_user_only { get; set; } 

        [JsonProperty("orderingchecktype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Orderingchecktype { get; set; } 

        [JsonProperty("purchaseorderstatusafterallitemsreceived", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Purchaseorderstatusafterallitemsreceived { get; set; } 

        [JsonProperty("software_audit_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Software_audit_level { get; set; } 

        [JsonProperty("track_service_availability", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Track_service_availability { get; set; } 

        [JsonProperty("default_expand_item_catalogue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Default_expand_item_catalogue { get; set; } 

        [JsonProperty("services_skip_to_new_ticket", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Services_skip_to_new_ticket { get; set; } 

        [JsonProperty("surcharge_once_per_ticket", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Surcharge_once_per_ticket { get; set; } 

        [JsonProperty("checktoplevelmailboxoverride", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Checktoplevelmailboxoverride { get; set; } 

        [JsonProperty("enable_check_ticket_details", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enable_check_ticket_details { get; set; } 

        [JsonProperty("precedence_bulk_is_auto_reply", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Precedence_bulk_is_auto_reply { get; set; } 

        [JsonProperty("reservedboolfield2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Reservedboolfield2 { get; set; } 

        [JsonProperty("azure_allowed_tenants_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Azure_allowed_tenants_type { get; set; } 

        [JsonProperty("usesecurecontractsigning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Usesecurecontractsigning { get; set; } 

        [JsonProperty("default_use_rpi_increase", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Default_use_rpi_increase { get; set; } 

        [JsonProperty("enableemailthreading", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enableemailthreading { get; set; } 

        [JsonProperty("att_item_group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Att_item_group { get; set; } 

        [JsonProperty("att_company_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Att_company_id { get; set; } 

        [JsonProperty("processunclosedtravel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Processunclosedtravel { get; set; } 

        [JsonProperty("use_document_management_for_clientsiteuser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Use_document_management_for_clientsiteuser { get; set; } 

        [JsonProperty("use_geo_restrictions_kb", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Use_geo_restrictions_kb { get; set; } 

        [JsonProperty("use_geo_restrictions_faqlist", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Use_geo_restrictions_faqlist { get; set; } 

        [JsonProperty("calculate_composite_tax_after_line_tax", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Calculate_composite_tax_after_line_tax { get; set; } 

        [JsonProperty("hide_rule_checks_on_automations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hide_rule_checks_on_automations { get; set; } 

        [JsonProperty("showassettagongoodsin", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showassettagongoodsin { get; set; } 

        [JsonProperty("display_long_description_on_invoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Display_long_description_on_invoice { get; set; } 

        [JsonProperty("defaultuserdetailslayout", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Defaultuserdetailslayout { get; set; } 

        [JsonProperty("default_jira_connection", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_jira_connection { get; set; } 

        [JsonProperty("use_portal_faq_restrictions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Use_portal_faq_restrictions { get; set; } 

        [JsonProperty("order_groups_by_name_ignore_emojis", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Order_groups_by_name_ignore_emojis { get; set; } 

        [JsonProperty("sendagentemailafterquoterejected", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sendagentemailafterquoterejected { get; set; } 

        [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Guid { get; set; } 

        [JsonProperty("log_clientsiteuser_views", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Log_clientsiteuser_views { get; set; } 

        [JsonProperty("enable_xml_generation_warnings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enable_xml_generation_warnings { get; set; } 

        [JsonProperty("last_auto_invoice_process_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Last_auto_invoice_process_date { get; set; } 

        [JsonProperty("send_incomplete_timesheet_notifications", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Send_incomplete_timesheet_notifications { get; set; } 

        [JsonProperty("release2_autoupdate_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Release2_autoupdate_method { get; set; } 

        [JsonProperty("release3_autoupdate_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Release3_autoupdate_method { get; set; } 

        [JsonProperty("max_custom_extra_table_fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Max_custom_extra_table_fields { get; set; } 

        [JsonProperty("new_chat_window_controls", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? New_chat_window_controls { get; set; } 

        [JsonProperty("welcome_email_expiry_days", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Welcome_email_expiry_days { get; set; } 

        [JsonProperty("use_charge_rate_price_for_budget", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Use_charge_rate_price_for_budget { get; set; } 

        [JsonProperty("suppliers_use_column_view_search", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Suppliers_use_column_view_search { get; set; } 

        [JsonProperty("lock_tickets_during_action", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Lock_tickets_during_action { get; set; } 

        [JsonProperty("default_consigned_asset_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_consigned_asset_status { get; set; } 

        [JsonProperty("useticketpoapprovals", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Useticketpoapprovals { get; set; } 

        [JsonProperty("only_po_ticket_approval", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Only_po_ticket_approval { get; set; } 

        [JsonProperty("default_po_ticket_approval", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_po_ticket_approval { get; set; } 

        [JsonProperty("default_columns_id_pos", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_columns_id_pos { get; set; } 

        [JsonProperty("default_columns_id_pos_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Default_columns_id_pos_guid { get; set; } 

        [JsonProperty("default_site_details_layout", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_site_details_layout { get; set; } 

        [JsonProperty("action_calendar_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Action_calendar_type { get; set; } 

        [JsonProperty("action_calendar_ap_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Action_calendar_ap_type { get; set; } 

        [JsonProperty("meraki_dont_update_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Meraki_dont_update_site { get; set; } 

        [JsonProperty("select_all_in_team_calendar", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Select_all_in_team_calendar { get; set; } 

        [JsonProperty("azuretranslate_allowchat", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Azuretranslate_allowchat { get; set; } 

        [JsonProperty("chat_canned_text_paste", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Chat_canned_text_paste { get; set; } 

        [JsonProperty("call_screen_category", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Call_screen_category { get; set; } 

        [JsonProperty("call_screen_show_transferred", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Call_screen_show_transferred { get; set; } 

        [JsonProperty("teamsshifts_authentication_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Teamsshifts_authentication_type { get; set; } 

        [JsonProperty("enable_teamsshifts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enable_teamsshifts { get; set; } 

        [JsonProperty("teamsshifts_azure_authority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Teamsshifts_azure_authority { get; set; } 

        [JsonProperty("exact_default_invoice_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Exact_default_invoice_status { get; set; } 

        [JsonProperty("dont_set_list_colour_on_portal", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dont_set_list_colour_on_portal { get; set; } 

        [JsonProperty("prepay_amount_as_price", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Prepay_amount_as_price { get; set; } 

        [JsonProperty("allow_multiselect_ticket_filtering", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allow_multiselect_ticket_filtering { get; set; } 

        [JsonProperty("enable_cmdb_service_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enable_cmdb_service_link { get; set; } 

        [JsonProperty("allow_all_asset_returns", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allow_all_asset_returns { get; set; } 

        [JsonProperty("liongard_default_devicetype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Liongard_default_devicetype { get; set; } 

        [JsonProperty("liongard_assettype_choice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Liongard_assettype_choice { get; set; } 

        [JsonProperty("error_notification_min_severity_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Error_notification_min_severity_level { get; set; } 

        [JsonProperty("process_approval_results_in_background", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Process_approval_results_in_background { get; set; } 

        [JsonProperty("asset_search_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Asset_search_method { get; set; } 

        [JsonProperty("check_asset_fields_on_closure", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Check_asset_fields_on_closure { get; set; } 

        [JsonProperty("show_all_related", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Show_all_related { get; set; } 

        [JsonProperty("enable_idle_session_timeout_named_lic", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enable_idle_session_timeout_named_lic { get; set; } 

        [JsonProperty("enable_idle_session_timeout_concurrent_lic", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enable_idle_session_timeout_concurrent_lic { get; set; } 

        [JsonProperty("colour_hidden_notes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Colour_hidden_notes { get; set; } 

        [JsonProperty("lansweeper_delete_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Lansweeper_delete_devices { get; set; } 

        [JsonProperty("lansweeper_delete_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Lansweeper_delete_status { get; set; } 

        [JsonProperty("prevent_edit_email_recipients", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Prevent_edit_email_recipients { get; set; } 

        [JsonProperty("default_filter_onhold_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_filter_onhold_tickets { get; set; } 

        [JsonProperty("ninja_import_warranty_data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ninja_import_warranty_data { get; set; } 

        [JsonProperty("ready_for_invoice_recurring_review_check_all", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ready_for_invoice_recurring_review_check_all { get; set; } 

        [JsonProperty("follow_sla_hold_procedure_for_excluded_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Follow_sla_hold_procedure_for_excluded_tickets { get; set; } 

        [JsonProperty("allow_agent_status_reassign", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allow_agent_status_reassign { get; set; } 

        [JsonProperty("enable_agent_status_permission", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enable_agent_status_permission { get; set; } 

        [JsonProperty("allow_agent_status_reassign_manual", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allow_agent_status_reassign_manual { get; set; } 

        [JsonProperty("abandoned_live_chat_enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Abandoned_live_chat_enabled { get; set; } 

        [JsonProperty("abandoned_live_chat_time_period", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Abandoned_live_chat_time_period { get; set; } 

        [JsonProperty("abandoned_live_chat_close_ticket", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Abandoned_live_chat_close_ticket { get; set; } 

        [JsonProperty("abandoned_live_chat_check_period", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Abandoned_live_chat_check_period { get; set; } 

        [JsonProperty("chat_agent_large_box", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Chat_agent_large_box { get; set; } 

        [JsonProperty("input_variable_upgrade_hint_shown", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Input_variable_upgrade_hint_shown { get; set; } 

        [JsonProperty("saml_pass_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Saml_pass_client_id { get; set; } 

        [JsonProperty("log_reportevent_data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Log_reportevent_data { get; set; } 

        [JsonProperty("zabbix_auth_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Zabbix_auth_type { get; set; } 

        [JsonProperty("hosted_group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Hosted_group { get; set; } 

        [JsonProperty("is_uat", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_uat { get; set; } 

        [JsonProperty("pwd", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Pwd { get; set; } 

        [JsonProperty("read_only_db_admin_setting", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Read_only_db_admin_setting { get; set; } 

        [JsonProperty("next_ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Next_ticket_id { get; set; } 

        [JsonProperty("next_invoice_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Next_invoice_id { get; set; } 

        [JsonProperty("next_quote_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Next_quote_id { get; set; } 

        [JsonProperty("next_salesorder_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Next_salesorder_id { get; set; } 

        [JsonProperty("next_supplierorder_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Next_supplierorder_id { get; set; } 

        [JsonProperty("multitenancy_enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Multitenancy_enabled { get; set; } 

        [JsonProperty("using_comanaged_it", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Using_comanaged_it { get; set; } 

        [JsonProperty("portal_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Portal_url { get; set; } 

        [JsonProperty("portal_colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Portal_colour { get; set; } 

        [JsonProperty("portal_logo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Portal_logo { get; set; } 

        [JsonProperty("portalbackgroundimageurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(500)]
        public string? Portalbackgroundimageurl { get; set; } 

        [JsonProperty("mobileapp_disabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Mobileapp_disabled { get; set; } 

        [JsonProperty("using_manual_rules", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Using_manual_rules { get; set; } 

        [JsonProperty("using_browser_push_notifications", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Using_browser_push_notifications { get; set; } 

        [JsonProperty("using_automations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Using_automations { get; set; } 

        [JsonProperty("app_colour_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? App_colour_type { get; set; } 

        [JsonProperty("send_or_ask_response_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Send_or_ask_response_email { get; set; } 

        [JsonProperty("chat_cannedtexts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CannedText>? Chat_cannedtexts { get; set; } 

        [JsonProperty("signalr_enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Signalr_enabled { get; set; } 

        [JsonProperty("pr_liccount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Pr_liccount { get; set; } 

        [JsonProperty("domain_user_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Domain_user_count { get; set; } 

        [JsonProperty("pr_licence_exceeded", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Pr_licence_exceeded { get; set; } 

        [JsonProperty("pr_licence_msg", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Pr_licence_msg { get; set; } 

        [JsonProperty("security_questions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<SecurityQuestion>? Security_questions { get; set; } 

        [JsonProperty("clearalldata", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Clearalldata { get; set; } 

        [JsonProperty("clearcustomerdata", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Clearcustomerdata { get; set; } 

        [JsonProperty("actisbillable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Actisbillable { get; set; } 

        [JsonProperty("use_slaholdcolour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Use_slaholdcolour { get; set; } 

        [JsonProperty("use_team_mgs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Use_team_mgs { get; set; } 

        [JsonProperty("use_department_mgs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Use_department_mgs { get; set; } 

        [JsonProperty("teamviewer_assetfield_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Teamviewer_assetfield_id { get; set; } 

        [JsonProperty("teamviewer_sitefield_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Teamviewer_sitefield_id { get; set; } 

        [JsonProperty("default_mailbox_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_mailbox_id { get; set; } 

        [JsonProperty("default_mailbox_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_mailbox_name { get; set; } 

        [JsonProperty("tenant_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Tenant_id { get; set; } 

        [JsonProperty("tenantalias", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Tenantalias { get; set; } 

        [JsonProperty("opportunity_fieldmappings_salesforce", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Opportunity_fieldmappings_salesforce { get; set; } 

        [JsonProperty("account_fieldmappings_salesforce", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Account_fieldmappings_salesforce { get; set; } 

        [JsonProperty("contact_fieldmappings_salesforce", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Contact_fieldmappings_salesforce { get; set; } 

        [JsonProperty("anydesk_assetfield_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Anydesk_assetfield_id { get; set; } 

        [JsonProperty("anydesk_sitefield_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Anydesk_sitefield_id { get; set; } 

        [JsonProperty("agent_rolemappings_azuread", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Agent_rolemappings_azuread { get; set; } 

        [JsonProperty("_getsagedata", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _getsagedata { get; set; } 

        [JsonProperty("_getsagetoken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _getsagetoken { get; set; } 

        [JsonProperty("_clearsagetoken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _clearsagetoken { get; set; } 

        [JsonProperty("sageauthcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sageauthcode { get; set; } 

        [JsonProperty("sageauthredirect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sageauthredirect { get; set; } 

        [JsonProperty("gointegrator_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Gointegrator_id { get; set; } 

        [JsonProperty("gointegrator_clientid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Gointegrator_clientid { get; set; } 

        [JsonProperty("beyondtrust_teams", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<RemoteSessionTeams>? Beyondtrust_teams { get; set; } 

        [JsonProperty("change_freeze_periods", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Holidays>? Change_freeze_periods { get; set; } 

        [JsonProperty("dynamicscrmdefaultsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Dynamicscrmdefaultsite_name { get; set; } 

        [JsonProperty("cautomatedefaultsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Cautomatedefaultsite_name { get; set; } 

        [JsonProperty("cautomateassetdefaultsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Cautomateassetdefaultsite_name { get; set; } 

        [JsonProperty("automate_typemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<XTypeMapping>? Automate_typemappings { get; set; } 

        [JsonProperty("client_id_halointegrator", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Client_id_halointegrator { get; set; } 

        [JsonProperty("client_secret_halointegrator", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Client_secret_halointegrator { get; set; } 

        [JsonProperty("loginas_halointegrator", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Loginas_halointegrator { get; set; } 

        [JsonProperty("sccm_udl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sccm_udl { get; set; } 

        [JsonProperty("sccm_query", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sccm_query { get; set; } 

        [JsonProperty("sccm_sql_timeout", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sccm_sql_timeout { get; set; } 

        [JsonProperty("sccm_idfield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sccm_idfield { get; set; } 

        [JsonProperty("sccm_typefield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sccm_typefield { get; set; } 

        [JsonProperty("sccm_sitefield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sccm_sitefield { get; set; } 

        [JsonProperty("sccm_userfield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sccm_userfield { get; set; } 

        [JsonProperty("sccm_usermatchingfield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sccm_usermatchingfield { get; set; } 

        [JsonProperty("sccm_defaultsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sccm_defaultsite { get; set; } 

        [JsonProperty("sccm_defaultsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sccm_defaultsite_name { get; set; } 

        [JsonProperty("sccm_updateonly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sccm_updateonly { get; set; } 

        [JsonProperty("sccm_donotvalidate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sccm_donotvalidate { get; set; } 

        [JsonProperty("sccm_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<SQLImportField>? Sccm_fieldmappings { get; set; } 

        [JsonProperty("sccm_sqlserver", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sccm_sqlserver { get; set; } 

        [JsonProperty("sccm_sqldatabase", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sccm_sqldatabase { get; set; } 

        [JsonProperty("sccm_sqlusername", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sccm_sqlusername { get; set; } 

        [JsonProperty("sccm_assetimportidentifier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sccm_assetimportidentifier { get; set; } 

        [JsonProperty("sccm_new_sql_password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sccm_new_sql_password { get; set; } 

        [JsonProperty("sccm_new_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sccm_new_method { get; set; } 

        [JsonProperty("sccm_updated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sccm_updated { get; set; } 

        [JsonProperty("sccm_dontupdatesite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sccm_dontupdatesite { get; set; } 

        [JsonProperty("sccm_dontremoveusers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sccm_dontremoveusers { get; set; } 

        [JsonProperty("halointegrator_sccm", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halointegrator_sccm { get; set; } 

        [JsonProperty("halointegrator_sccm_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Halointegrator_sccm_lastsync { get; set; } 

        [JsonProperty("halointegrator_sccm_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_sccm_lasterror { get; set; } 

        [JsonProperty("sccm_allowed_clientids_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? Sccm_allowed_clientids_list { get; set; } 

        [JsonProperty("exapptsubject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Exapptsubject { get; set; } 

        [JsonProperty("exapptlocation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Exapptlocation { get; set; } 

        [JsonProperty("exapptbody", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Exapptbody { get; set; } 

        [JsonProperty("portalbuttons", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<UserDashboardButtons>? Portalbuttons { get; set; } 

        [JsonProperty("ninjadefaultsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ninjadefaultsite_name { get; set; } 

        [JsonProperty("ninja_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Ninja_fieldmappings { get; set; } 

        [JsonProperty("halointegrator_ninjarmm", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halointegrator_ninjarmm { get; set; } 

        [JsonProperty("halointegrator_ninjarmm_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Halointegrator_ninjarmm_lastsync { get; set; } 

        [JsonProperty("halointegrator_ninjarmm_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_ninjarmm_lasterror { get; set; } 

        [JsonProperty("halointegrator_solarwindsrmm", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halointegrator_solarwindsrmm { get; set; } 

        [JsonProperty("halointegrator_solarwindsrmm_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Halointegrator_solarwindsrmm_lastsync { get; set; } 

        [JsonProperty("halointegrator_solarwindsrmm_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_solarwindsrmm_lasterror { get; set; } 

        [JsonProperty("solarwindsrmm_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Solarwindsrmm_fieldmappings { get; set; } 

        [JsonProperty("_getintegrationdata", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _getintegrationdata { get; set; } 

        [JsonProperty("_resendunsentemails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _resendunsentemails { get; set; } 

        [JsonProperty("_emailprocessed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? _emailprocessed { get; set; } 

        [JsonProperty("_addactiontofaultid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? _addactiontofaultid { get; set; } 

        [JsonProperty("integration_data_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Integration_data_name { get; set; } 

        [JsonProperty("integration_data_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Integration_data_type { get; set; } 

        [JsonProperty("takecontrol_button_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Takecontrol_button_id { get; set; } 

        [JsonProperty("halointegrator_lansweeper", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halointegrator_lansweeper { get; set; } 

        [JsonProperty("halointegrator_lansweeper_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Halointegrator_lansweeper_lastsync { get; set; } 

        [JsonProperty("halointegrator_lansweeper_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_lansweeper_lasterror { get; set; } 

        [JsonProperty("lansweeper_updated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Lansweeper_updated { get; set; } 

        [JsonProperty("lansweeper_databasetype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Lansweeper_databasetype { get; set; } 

        [JsonProperty("lansweeper_sqlserver", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Lansweeper_sqlserver { get; set; } 

        [JsonProperty("lansweeper_sqldatabase", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Lansweeper_sqldatabase { get; set; } 

        [JsonProperty("lansweeper_sqlusername", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Lansweeper_sqlusername { get; set; } 

        [JsonProperty("lansweeper_new_sql_password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Lansweeper_new_sql_password { get; set; } 

        [JsonProperty("lansweeper_new_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Lansweeper_new_method { get; set; } 

        [JsonProperty("lansweeper_allowed_clientids_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? Lansweeper_allowed_clientids_list { get; set; } 

        [JsonProperty("lansweeper_query", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Lansweeper_query { get; set; } 

        [JsonProperty("lansweeper_sql_timeout", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Lansweeper_sql_timeout { get; set; } 

        [JsonProperty("lansweeper_idfield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Lansweeper_idfield { get; set; } 

        [JsonProperty("lansweeper_typefield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Lansweeper_typefield { get; set; } 

        [JsonProperty("lansweeper_sitefield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Lansweeper_sitefield { get; set; } 

        [JsonProperty("lansweeper_userfield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Lansweeper_userfield { get; set; } 

        [JsonProperty("lansweeper_usermatchingfield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Lansweeper_usermatchingfield { get; set; } 

        [JsonProperty("lansweeper_defaultsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Lansweeper_defaultsite { get; set; } 

        [JsonProperty("lansweeper_defaultsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Lansweeper_defaultsite_name { get; set; } 

        [JsonProperty("sccm_userssite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sccm_userssite { get; set; } 

        [JsonProperty("lansweeper_userssite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Lansweeper_userssite { get; set; } 

        [JsonProperty("lansweeper_updateonly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Lansweeper_updateonly { get; set; } 

        [JsonProperty("lansweeper_donotvalidate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Lansweeper_donotvalidate { get; set; } 

        [JsonProperty("lansweeper_dontupdatesite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Lansweeper_dontupdatesite { get; set; } 

        [JsonProperty("lansweeper_dontremoveusers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Lansweeper_dontremoveusers { get; set; } 

        [JsonProperty("lansweeper_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<SQLImportField>? Lansweeper_fieldmappings { get; set; } 

        [JsonProperty("lansweeper_assetimportidentifier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Lansweeper_assetimportidentifier { get; set; } 

        [JsonProperty("dattormm_fromaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Dattormm_fromaddress { get; set; } 

        [JsonProperty("dattormm_tickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Dattormm_tickettype { get; set; } 

        [JsonProperty("dattormm_tickettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Dattormm_tickettype_guid { get; set; } 

        [JsonProperty("cautomate_fromaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Cautomate_fromaddress { get; set; } 

        [JsonProperty("cautomate_requesttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Cautomate_requesttype { get; set; } 

        [JsonProperty("cautomate_requesttype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Cautomate_requesttype_guid { get; set; } 

        [JsonProperty("solarwindsrmm_fromaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Solarwindsrmm_fromaddress { get; set; } 

        [JsonProperty("solarwindsrmm_requesttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Solarwindsrmm_requesttype { get; set; } 

        [JsonProperty("solarwindsrmm_requesttype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Solarwindsrmm_requesttype_guid { get; set; } 

        [JsonProperty("halointegrator_integrations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? Halointegrator_integrations { get; set; } 

        [JsonProperty("splunkuser_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Splunkuser_name { get; set; } 

        [JsonProperty("ncentral_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Ncentral_fieldmappings { get; set; } 

        [JsonProperty("halointegrator_ncentral", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halointegrator_ncentral { get; set; } 

        [JsonProperty("halointegrator_ncentral_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Halointegrator_ncentral_lastsync { get; set; } 

        [JsonProperty("halointegrator_ncentral_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_ncentral_lasterror { get; set; } 

        [JsonProperty("client_secret_ncentral", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Client_secret_ncentral { get; set; } 

        [JsonProperty("ncentraluser_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ncentraluser_name { get; set; } 

        [JsonProperty("azureconnection", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Azureconnection { get; set; } 

        [JsonProperty("azuremapping", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Azuremapping { get; set; } 

        [JsonProperty("businesscentral_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Businesscentral_fieldmappings { get; set; } 

        [JsonProperty("businesscentralsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Businesscentralsite_name { get; set; } 

        [JsonProperty("_createbusinesscentralasset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _createbusinesscentralasset { get; set; } 

        [JsonProperty("businesscentralasset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Device? Businesscentralasset { get; set; } 

        [JsonProperty("defaultquicktimemethod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Defaultquicktimemethod { get; set; } 

        [JsonProperty("allowticketselectionduringquicktime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allowticketselectionduringquicktime { get; set; } 

        [JsonProperty("miscitemidquotetaxrate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Miscitemidquotetaxrate { get; set; } 

        [JsonProperty("miscitemidquotetaxratepo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Miscitemidquotetaxratepo { get; set; } 

        [JsonProperty("_getautomationbody", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _getautomationbody { get; set; } 

        [JsonProperty("_sendautomationhook", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _sendautomationhook { get; set; } 

        [JsonProperty("_automationwebhookid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? _automationwebhookid { get; set; } 

        [JsonProperty("_automationwebhookmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<WebhookMapping>? _automationwebhookmappings { get; set; } 

        [JsonProperty("_automationticketid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? _automationticketid { get; set; } 

        [JsonProperty("_getwebhookbody", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _getwebhookbody { get; set; } 

        [JsonProperty("_webhookid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? _webhookid { get; set; } 

        [JsonProperty("_webhookmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<WebhookMapping>? _webhookmappings { get; set; } 

        [JsonProperty("_webhookticketid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? _webhookticketid { get; set; } 

        [JsonProperty("qbozerotaxcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Qbozerotaxcode { get; set; } 

        [JsonProperty("_areaitems_to_convert", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AreaItem>? _areaitems_to_convert { get; set; } 

        [JsonProperty("_contracts_to_convert", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ContractHeader_List>? _contracts_to_convert { get; set; } 

        [JsonProperty("remotesession_trackingid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Remotesession_trackingid { get; set; } 

        [JsonProperty("takecontrol_deviceid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Takecontrol_deviceid { get; set; } 

        [JsonProperty("showing_customer_fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showing_customer_fields { get; set; } 

        [JsonProperty("_getgoogletoken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _getgoogletoken { get; set; } 

        [JsonProperty("google_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Google_code { get; set; } 

        [JsonProperty("google_redirect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Google_redirect { get; set; } 

        [JsonProperty("_googlecalendardisconnect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _googlecalendardisconnect { get; set; } 

        [JsonProperty("google_application", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Google_application { get; set; } 

        [JsonProperty("googleworkplace_usermappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Googleworkplace_usermappings { get; set; } 

        [JsonProperty("googleworkplace_agentmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Googleworkplace_agentmappings { get; set; } 

        [JsonProperty("googleworkplace_sitemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<GoogleWorkplaceMapping>? Googleworkplace_sitemappings { get; set; } 

        [JsonProperty("googleworkplace_rolemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Googleworkplace_rolemappings { get; set; } 

        [JsonProperty("googleworkplace_cabmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Googleworkplace_cabmappings { get; set; } 

        [JsonProperty("gw_user_matching_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? Gw_user_matching_list { get; set; } 

        [JsonProperty("gw_agent_matching_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? Gw_agent_matching_list { get; set; } 

        [JsonProperty("gw_licensed_roles_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair>? Gw_licensed_roles_list { get; set; } 

        [JsonProperty("halointegrator_googleworkplace", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halointegrator_googleworkplace { get; set; } 

        [JsonProperty("halointegrator_googleworkplace_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Halointegrator_googleworkplace_lastsync { get; set; } 

        [JsonProperty("halointegrator_googleworkplace_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_googleworkplace_lasterror { get; set; } 

        [JsonProperty("dynamicscrm_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Dynamicscrm_fieldmappings { get; set; } 

        [JsonProperty("scom_fromaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Scom_fromaddress { get; set; } 

        [JsonProperty("scom_requesttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Scom_requesttype { get; set; } 

        [JsonProperty("scom_requesttype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Scom_requesttype_guid { get; set; } 

        [JsonProperty("scom_devicefield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Scom_devicefield { get; set; } 

        [JsonProperty("halointegrator_scom", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halointegrator_scom { get; set; } 

        [JsonProperty("halointegrator_scom_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Halointegrator_scom_lastsync { get; set; } 

        [JsonProperty("halointegrator_scom_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_scom_lasterror { get; set; } 

        [JsonProperty("ncentral_customerid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ncentral_customerid { get; set; } 

        [JsonProperty("rdattodefaultassettypegroup_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Rdattodefaultassettypegroup_name { get; set; } 

        [JsonProperty("prtgassetdefaultsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Prtgassetdefaultsite_name { get; set; } 

        [JsonProperty("prtgdefaultassettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Prtgdefaultassettype_name { get; set; } 

        [JsonProperty("prtg_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Prtg_fieldmappings { get; set; } 

        [JsonProperty("halointegrator_prtg", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halointegrator_prtg { get; set; } 

        [JsonProperty("halointegrator_prtg_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Halointegrator_prtg_lastsync { get; set; } 

        [JsonProperty("halointegrator_prtg_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_prtg_lasterror { get; set; } 

        [JsonProperty("migration_default_site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Migration_default_site_name { get; set; } 

        [JsonProperty("client_secret_orion", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Client_secret_orion { get; set; } 

        [JsonProperty("orionuser_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Orionuser_name { get; set; } 

        [JsonProperty("halointegrator_orion", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halointegrator_orion { get; set; } 

        [JsonProperty("halointegrator_orion_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Halointegrator_orion_lastsync { get; set; } 

        [JsonProperty("halointegrator_orion_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_orion_lasterror { get; set; } 

        [JsonProperty("device42_customermappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Device42_customermappings { get; set; } 

        [JsonProperty("device42_typemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<XTypeMapping>? Device42_typemappings { get; set; } 

        [JsonProperty("device42_devicemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Device42_devicemappings { get; set; } 

        [JsonProperty("device42defaultsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Device42defaultsite_name { get; set; } 

        [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _importtype { get; set; } 

        [JsonProperty("item_default_sales_nominal_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public KeyPair2? Item_default_sales_nominal_code { get; set; } 

        [JsonProperty("item_default_purchase_nominal_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public KeyPair2? Item_default_purchase_nominal_code { get; set; } 

        [JsonProperty("item_default_asset_account", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public KeyPair2? Item_default_asset_account { get; set; } 

        [JsonProperty("socuser_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Socuser_name { get; set; } 

        [JsonProperty("client_secret_device42", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Client_secret_device42 { get; set; } 

        [JsonProperty("datto_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Datto_fieldmappings { get; set; } 

        [JsonProperty("dattodefaultcustomer_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Dattodefaultcustomer_name { get; set; } 

        [JsonProperty("dattodefaulttoplevel_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Dattodefaulttoplevel_name { get; set; } 

        [JsonProperty("dattodefaultassetsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Dattodefaultassetsite_name { get; set; } 

        [JsonProperty("halointegrator_datto", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halointegrator_datto { get; set; } 

        [JsonProperty("halointegrator_datto_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Halointegrator_datto_lastsync { get; set; } 

        [JsonProperty("halointegrator_datto_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_datto_lasterror { get; set; } 

        [JsonProperty("csp_sitemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AzureADMapping>? Csp_sitemappings { get; set; } 

        [JsonProperty("_generatecspmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? _generatecspmappings { get; set; } 

        [JsonProperty("atera_defaultsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Atera_defaultsite_name { get; set; } 

        [JsonProperty("atera_device_types", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? Atera_device_types { get; set; } 

        [JsonProperty("atera_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Atera_fieldmappings { get; set; } 

        [JsonProperty("halointegrator_atera", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halointegrator_atera { get; set; } 

        [JsonProperty("halointegrator_atera_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Halointegrator_atera_lastsync { get; set; } 

        [JsonProperty("halointegrator_atera_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_atera_lasterror { get; set; } 

        [JsonProperty("_deletedevices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _deletedevices { get; set; } 

        [JsonProperty("_deletedevices_integration", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _deletedevices_integration { get; set; } 

        [JsonProperty("device_guids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<string>? Device_guids { get; set; } 

        [JsonProperty("client_guids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<string>? Client_guids { get; set; } 

        [JsonProperty("site_guids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<string>? Site_guids { get; set; } 

        [JsonProperty("_deletelicences", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _deletelicences { get; set; } 

        [JsonProperty("licence_guids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<string>? Licence_guids { get; set; } 

        [JsonProperty("atera_alert_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Atera_alert_user_name { get; set; } 

        [JsonProperty("teams_default_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Teams_default_user_name { get; set; } 

        [JsonProperty("_exchangeaction", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _exchangeaction { get; set; } 

        [JsonProperty("halointegrator_exchange", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halointegrator_exchange { get; set; } 

        [JsonProperty("halointegrator_exchange_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Halointegrator_exchange_lastsync { get; set; } 

        [JsonProperty("halointegrator_exchange_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_exchange_lasterror { get; set; } 

        [JsonProperty("okta_sitemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<OktaMapping>? Okta_sitemappings { get; set; } 

        [JsonProperty("okta_usermappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Okta_usermappings { get; set; } 

        [JsonProperty("okta_agentmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Okta_agentmappings { get; set; } 

        [JsonProperty("okta_rolemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Okta_rolemappings { get; set; } 

        [JsonProperty("okta_cabmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Okta_cabmappings { get; set; } 

        [JsonProperty("okta_user_matching_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? Okta_user_matching_list { get; set; } 

        [JsonProperty("okta_agent_matching_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? Okta_agent_matching_list { get; set; } 

        [JsonProperty("okta_active_statuses_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? Okta_active_statuses_list { get; set; } 

        [JsonProperty("halointegrator_okta", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halointegrator_okta { get; set; } 

        [JsonProperty("halointegrator_okta_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Halointegrator_okta_lastsync { get; set; } 

        [JsonProperty("halointegrator_okta_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_okta_lasterror { get; set; } 

        [JsonProperty("reset_okta_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Reset_okta_lastsync { get; set; } 

        [JsonProperty("quote_cannedtext", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CannedText>? Quote_cannedtext { get; set; } 

        [JsonProperty("merakiapplicationsecret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Merakiapplicationsecret { get; set; } 

        [JsonProperty("merakiusername", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Merakiusername { get; set; } 

        [JsonProperty("merakitickettypename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Merakitickettypename { get; set; } 

        [JsonProperty("lansweeper_authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Lansweeper_authorized { get; set; } 

        [JsonProperty("_getoauthtoken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _getoauthtoken { get; set; } 

        [JsonProperty("oauth_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Oauth_code { get; set; } 

        [JsonProperty("oauth_redirect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Oauth_redirect { get; set; } 

        [JsonProperty("oauth_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Oauth_type { get; set; } 

        [JsonProperty("graph_host", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Graph_host { get; set; } 

        [JsonProperty("_disconnectintegration", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _disconnectintegration { get; set; } 

        [JsonProperty("lansweeper_sitemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationSiteMapping>? Lansweeper_sitemappings { get; set; } 

        [JsonProperty("lansweeper_site_rules", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationSiteMapping>? Lansweeper_site_rules { get; set; } 

        [JsonProperty("lansweeper_fieldmappings_api", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Lansweeper_fieldmappings_api { get; set; } 

        [JsonProperty("alarmminutes_bool", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Alarmminutes_bool { get; set; } 

        [JsonProperty("_integrationid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? _integrationid { get; set; } 

        [JsonProperty("ninja_sitemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationSiteMapping>? Ninja_sitemappings { get; set; } 

        [JsonProperty("ninja_alert_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ninja_alert_user_name { get; set; } 

        [JsonProperty("dattormm_alert_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Dattormm_alert_user_name { get; set; } 

        [JsonProperty("_closealerts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _closealerts { get; set; } 

        [JsonProperty("_closealerts_integration", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _closealerts_integration { get; set; } 

        [JsonProperty("alert_guids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<string>? Alert_guids { get; set; } 

        [JsonProperty("hashostedintegrator", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hashostedintegrator { get; set; } 

        [JsonProperty("halointegrator_xlsimports", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halointegrator_xlsimports { get; set; } 

        [JsonProperty("halointegrator_xlsimports_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Halointegrator_xlsimports_lastsync { get; set; } 

        [JsonProperty("halointegrator_xlsimports_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_xlsimports_lasterror { get; set; } 

        [JsonProperty("snelstart_old_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Snelstart_old_client_id { get; set; } 

        [JsonProperty("_getsnelstartlink", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _getsnelstartlink { get; set; } 

        [JsonProperty("itglue_clientmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLink_List>? Itglue_clientmappings { get; set; } 

        [JsonProperty("itglue_sitemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLink_List>? Itglue_sitemappings { get; set; } 

        [JsonProperty("itglue_active_statuses_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? Itglue_active_statuses_list { get; set; } 

        [JsonProperty("itglue_typemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<XTypeMapping>? Itglue_typemappings { get; set; } 

        [JsonProperty("itglue_configtypemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<XTypeMapping>? Itglue_configtypemappings { get; set; } 

        [JsonProperty("itglue_statusmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Itglue_statusmappings { get; set; } 

        [JsonProperty("itglue_default_site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Itglue_default_site_name { get; set; } 

        [JsonProperty("halointegrator_itglue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halointegrator_itglue { get; set; } 

        [JsonProperty("halointegrator_itglue_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Halointegrator_itglue_lastsync { get; set; } 

        [JsonProperty("halointegrator_itglue_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_itglue_lasterror { get; set; } 

        [JsonProperty("bookingtypes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<BookingType>? Bookingtypes { get; set; } 

        [JsonProperty("appsettings_encthumbprint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Appsettings_encthumbprint { get; set; } 

        [JsonProperty("old_pwd_enc_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Old_pwd_enc_count { get; set; } 

        [JsonProperty("scom_allowed_clientids_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? Scom_allowed_clientids_list { get; set; } 

        [JsonProperty("orion_allowed_clientids_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? Orion_allowed_clientids_list { get; set; } 

        [JsonProperty("teamsbot_disabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Teamsbot_disabled { get; set; } 

        [JsonProperty("datto_sitemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationSiteMapping>? Datto_sitemappings { get; set; } 

        [JsonProperty("halointegrator_dynamics365crm", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halointegrator_dynamics365crm { get; set; } 

        [JsonProperty("halointegrator_dynamics365crm_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Halointegrator_dynamics365crm_lastsync { get; set; } 

        [JsonProperty("halointegrator_dynamics365crm_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_dynamics365crm_lasterror { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("jamf_defaultsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Jamf_defaultsite_name { get; set; } 

        [JsonProperty("jamf_defaultdtypecomputer_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Jamf_defaultdtypecomputer_name { get; set; } 

        [JsonProperty("jamf_defaultdtypemobile_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Jamf_defaultdtypemobile_name { get; set; } 

        [JsonProperty("jamf_device_types", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? Jamf_device_types { get; set; } 

        [JsonProperty("jamf_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Jamf_fieldmappings { get; set; } 

        [JsonProperty("halointegrator_jamf", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halointegrator_jamf { get; set; } 

        [JsonProperty("halointegrator_jamf_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Halointegrator_jamf_lastsync { get; set; } 

        [JsonProperty("halointegrator_jamf_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_jamf_lasterror { get; set; } 

        [JsonProperty("sentinel_ticketmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Sentinel_ticketmappings { get; set; } 

        [JsonProperty("halointegrator_sentinel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halointegrator_sentinel { get; set; } 

        [JsonProperty("halointegrator_sentinel_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Halointegrator_sentinel_lastsync { get; set; } 

        [JsonProperty("halointegrator_sentinel_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_sentinel_lasterror { get; set; } 

        [JsonProperty("server_time_zone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Server_time_zone { get; set; } 

        [JsonProperty("use_project_datetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Use_project_datetime { get; set; } 

        [JsonProperty("allow_cf_values_not_on_tickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allow_cf_values_not_on_tickettype { get; set; } 

        [JsonProperty("azuremonitor_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Azuremonitor_fieldmappings { get; set; } 

        [JsonProperty("azuremonitoruser_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Azuremonitoruser_name { get; set; } 

        [JsonProperty("syncro_defaultsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Syncro_defaultsite_name { get; set; } 

        [JsonProperty("syncro_device_types", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? Syncro_device_types { get; set; } 

        [JsonProperty("syncro_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Syncro_fieldmappings { get; set; } 

        [JsonProperty("halointegrator_syncro", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halointegrator_syncro { get; set; } 

        [JsonProperty("halointegrator_syncro_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Halointegrator_syncro_lastsync { get; set; } 

        [JsonProperty("halointegrator_syncro_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_syncro_lasterror { get; set; } 

        [JsonProperty("syncro_alert_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Syncro_alert_user_name { get; set; } 

        [JsonProperty("domotz_agentfieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Domotz_agentfieldmappings { get; set; } 

        [JsonProperty("domotz_devicefieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Domotz_devicefieldmappings { get; set; } 

        [JsonProperty("domotz_default_agentsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Domotz_default_agentsite_name { get; set; } 

        [JsonProperty("domotz_default_devicesite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Domotz_default_devicesite_name { get; set; } 

        [JsonProperty("domotz_devicetypemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<XTypeMapping>? Domotz_devicetypemappings { get; set; } 

        [JsonProperty("halointegrator_domotz", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halointegrator_domotz { get; set; } 

        [JsonProperty("halointegrator_domotz_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Halointegrator_domotz_lastsync { get; set; } 

        [JsonProperty("halointegrator_domotz_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_domotz_lasterror { get; set; } 

        [JsonProperty("_deactivateusers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _deactivateusers { get; set; } 

        [JsonProperty("_deactivateusers_integration", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _deactivateusers_integration { get; set; } 

        [JsonProperty("user_guids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<string>? User_guids { get; set; } 

        [JsonProperty("user_tenantids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<string>? User_tenantids { get; set; } 

        [JsonProperty("_deactivateagents", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _deactivateagents { get; set; } 

        [JsonProperty("_deactivateagents_integration", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _deactivateagents_integration { get; set; } 

        [JsonProperty("agent_guids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<string>? Agent_guids { get; set; } 

        [JsonProperty("halointegrator_haloassetdiscovery", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halointegrator_haloassetdiscovery { get; set; } 

        [JsonProperty("halointegrator_haloassetdiscovery_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Halointegrator_haloassetdiscovery_lastsync { get; set; } 

        [JsonProperty("halointegrator_haloassetdiscovery_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_haloassetdiscovery_lasterror { get; set; } 

        [JsonProperty("automate_sitemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationSiteMapping>? Automate_sitemappings { get; set; } 

        [JsonProperty("halointegrator_automate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halointegrator_automate { get; set; } 

        [JsonProperty("halointegrator_automate_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Halointegrator_automate_lastsync { get; set; } 

        [JsonProperty("halointegrator_automate_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_automate_lasterror { get; set; } 

        [JsonProperty("automate_import_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? Automate_import_entities_list { get; set; } 

        [JsonProperty("atera_import_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? Atera_import_entities_list { get; set; } 

        [JsonProperty("addigy_import_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? Addigy_import_entities_list { get; set; } 

        [JsonProperty("meraki_import_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? Meraki_import_entities_list { get; set; } 

        [JsonProperty("automate_alert_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Automate_alert_user_name { get; set; } 

        [JsonProperty("lansweeper_exports", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationExport>? Lansweeper_exports { get; set; } 

        [JsonProperty("_checkexportprogress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _checkexportprogress { get; set; } 

        [JsonProperty("export_module", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Export_module { get; set; } 

        [JsonProperty("atera_sitemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationSiteMapping>? Atera_sitemappings { get; set; } 

        [JsonProperty("device42_sitemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationSiteMapping>? Device42_sitemappings { get; set; } 

        [JsonProperty("ncentral_sitemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationSiteMapping>? Ncentral_sitemappings { get; set; } 

        [JsonProperty("syncro_sitemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationSiteMapping>? Syncro_sitemappings { get; set; } 

        [JsonProperty("halointegrator_g2aremote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halointegrator_g2aremote { get; set; } 

        [JsonProperty("halointegrator_g2aremote_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Halointegrator_g2aremote_lastsync { get; set; } 

        [JsonProperty("halointegrator_g2aremote_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_g2aremote_lasterror { get; set; } 

        [JsonProperty("snow_default_devicesite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Snow_default_devicesite_name { get; set; } 

        [JsonProperty("snow_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Snow_fieldmappings { get; set; } 

        [JsonProperty("halointegrator_snow", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halointegrator_snow { get; set; } 

        [JsonProperty("halointegrator_snow_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Halointegrator_snow_lastsync { get; set; } 

        [JsonProperty("halointegrator_snow_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_snow_lasterror { get; set; } 

        [JsonProperty("auvik_sitemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationSiteMapping>? Auvik_sitemappings { get; set; } 

        [JsonProperty("auvik_network_typemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<XTypeMapping>? Auvik_network_typemappings { get; set; } 

        [JsonProperty("auvik_device_typemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<XTypeMapping>? Auvik_device_typemappings { get; set; } 

        [JsonProperty("auvik_network_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Auvik_network_fieldmappings { get; set; } 

        [JsonProperty("auvik_device_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Auvik_device_fieldmappings { get; set; } 

        [JsonProperty("auvik_default_site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Auvik_default_site_name { get; set; } 

        [JsonProperty("halointegrator_auvik", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halointegrator_auvik { get; set; } 

        [JsonProperty("halointegrator_auvik_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Halointegrator_auvik_lastsync { get; set; } 

        [JsonProperty("halointegrator_auvik_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_auvik_lasterror { get; set; } 

        [JsonProperty("auvik_alert_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Auvik_alert_user_name { get; set; } 

        [JsonProperty("teamsbot_allowed_tenants_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? Teamsbot_allowed_tenants_list { get; set; } 

        [JsonProperty("hubspot_sitemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationSiteMapping>? Hubspot_sitemappings { get; set; } 

        [JsonProperty("hubspot_company_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Hubspot_company_fieldmappings { get; set; } 

        [JsonProperty("hubspot_contact_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Hubspot_contact_fieldmappings { get; set; } 

        [JsonProperty("hubspot_deals_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Hubspot_deals_fieldmappings { get; set; } 

        [JsonProperty("hubspot_items_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Hubspot_items_fieldmappings { get; set; } 

        [JsonProperty("hubspot_quotes_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Hubspot_quotes_fieldmappings { get; set; } 

        [JsonProperty("hubspot_top_level_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Hubspot_top_level_name { get; set; } 

        [JsonProperty("hubspot_default_site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Hubspot_default_site_name { get; set; } 

        [JsonProperty("hubspot_included_lifecycles_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair>? Hubspot_included_lifecycles_list { get; set; } 

        [JsonProperty("halointegrator_hubspot", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halointegrator_hubspot { get; set; } 

        [JsonProperty("halointegrator_hubspot_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Halointegrator_hubspot_lastsync { get; set; } 

        [JsonProperty("halointegrator_hubspot_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_hubspot_lasterror { get; set; } 

        [JsonProperty("qualys_typemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<XTypeMapping>? Qualys_typemappings { get; set; } 

        [JsonProperty("qualys_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Qualys_fieldmappings { get; set; } 

        [JsonProperty("qualys_default_site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Qualys_default_site_name { get; set; } 

        [JsonProperty("halointegrator_qualys", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halointegrator_qualys { get; set; } 

        [JsonProperty("halointegrator_qualys_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Halointegrator_qualys_lastsync { get; set; } 

        [JsonProperty("halointegrator_qualys_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_qualys_lasterror { get; set; } 

        [JsonProperty("passportal_defaultclientsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Passportal_defaultclientsite_name { get; set; } 

        [JsonProperty("passportal_defaultusersite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Passportal_defaultusersite_name { get; set; } 

        [JsonProperty("passportal_clientmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationSiteMapping>? Passportal_clientmappings { get; set; } 

        [JsonProperty("halointegrator_passportal", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halointegrator_passportal { get; set; } 

        [JsonProperty("halointegrator_passportal_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Halointegrator_passportal_lastsync { get; set; } 

        [JsonProperty("halointegrator_passportal_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_passportal_lasterror { get; set; } 

        [JsonProperty("passportal_assetfieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Passportal_assetfieldmappings { get; set; } 

        [JsonProperty("passportal_defaultassetsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Passportal_defaultassetsite_name { get; set; } 

        [JsonProperty("passportal_import_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? Passportal_import_entities_list { get; set; } 

        [JsonProperty("auvik_top_level_domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AuvikTenantMod? Auvik_top_level_domain { get; set; } 

        [JsonProperty("lansweeper_include_linux", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Lansweeper_include_linux { get; set; } 

        [JsonProperty("intacct_sync_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? Intacct_sync_entities_list { get; set; } 

        [JsonProperty("license_model", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public LicenseModel? License_model { get; set; } 

        [JsonProperty("addigy_clientmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationSiteMapping>? Addigy_clientmappings { get; set; } 

        [JsonProperty("addigy_defaultassetsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Addigy_defaultassetsite_name { get; set; } 

        [JsonProperty("addigy_assetfieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Addigy_assetfieldmappings { get; set; } 

        [JsonProperty("halointegrator_addigy", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halointegrator_addigy { get; set; } 

        [JsonProperty("halointegrator_addigy_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Halointegrator_addigy_lastsync { get; set; } 

        [JsonProperty("halointegrator_addigy_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_addigy_lasterror { get; set; } 

        [JsonProperty("addigy_alert_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Addigy_alert_user_name { get; set; } 

        [JsonProperty("domotz_sitemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationSiteMapping>? Domotz_sitemappings { get; set; } 

        [JsonProperty("halointegrator_liongard", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halointegrator_liongard { get; set; } 

        [JsonProperty("halointegrator_liongard_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Halointegrator_liongard_lastsync { get; set; } 

        [JsonProperty("halointegrator_liongard_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_liongard_lasterror { get; set; } 

        [JsonProperty("liongard_sitemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationSiteMapping>? Liongard_sitemappings { get; set; } 

        [JsonProperty("liongard_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Liongard_fieldmappings { get; set; } 

        [JsonProperty("liongard_defaultsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Liongard_defaultsite_name { get; set; } 

        [JsonProperty("liongard_mappings_xtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<XTypeMapping>? Liongard_mappings_xtype { get; set; } 

        [JsonProperty("halointegrator_stripe", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halointegrator_stripe { get; set; } 

        [JsonProperty("halointegrator_stripe_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Halointegrator_stripe_lastsync { get; set; } 

        [JsonProperty("halointegrator_stripe_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_stripe_lasterror { get; set; } 

        [JsonProperty("ingram_micro_client_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLink_List>? Ingram_micro_client_mappings { get; set; } 

        [JsonProperty("ingram_micro_top_level_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ingram_micro_top_level_name { get; set; } 

        [JsonProperty("halointegrator_ingram_micro", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halointegrator_ingram_micro { get; set; } 

        [JsonProperty("halointegrator_ingram_micro_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Halointegrator_ingram_micro_lastsync { get; set; } 

        [JsonProperty("halointegrator_ingram_micro_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_ingram_micro_lasterror { get; set; } 

        [JsonProperty("ingram_micro_import_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? Ingram_micro_import_entities_list { get; set; } 

        [JsonProperty("pax8_client_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLink_List>? Pax8_client_mappings { get; set; } 

        [JsonProperty("quoter_item_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLink_List>? Quoter_item_mappings { get; set; } 

        [JsonProperty("etilize_item_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLink_List>? Etilize_item_mappings { get; set; } 

        [JsonProperty("pax8_top_level_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Pax8_top_level_name { get; set; } 

        [JsonProperty("halointegrator_pax8", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halointegrator_pax8 { get; set; } 

        [JsonProperty("halointegrator_pax8_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Halointegrator_pax8_lastsync { get; set; } 

        [JsonProperty("halointegrator_pax8_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_pax8_lasterror { get; set; } 

        [JsonProperty("pax8_import_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? Pax8_import_entities_list { get; set; } 

        [JsonProperty("halointegrator_giacom", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halointegrator_giacom { get; set; } 

        [JsonProperty("halointegrator_giacom_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Halointegrator_giacom_lastsync { get; set; } 

        [JsonProperty("halointegrator_giacom_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_giacom_lasterror { get; set; } 

        [JsonProperty("giacom_import_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? Giacom_import_entities_list { get; set; } 

        [JsonProperty("salesforce_contactfieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Salesforce_contactfieldmappings { get; set; } 

        [JsonProperty("salesforce_accountfieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Salesforce_accountfieldmappings { get; set; } 

        [JsonProperty("salesforce_opportunityfieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Salesforce_opportunityfieldmappings { get; set; } 

        [JsonProperty("salesforce_casefieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Salesforce_casefieldmappings { get; set; } 

        [JsonProperty("halointegrator_salesforce", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halointegrator_salesforce { get; set; } 

        [JsonProperty("halointegrator_salesforce_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Halointegrator_salesforce_lastsync { get; set; } 

        [JsonProperty("halointegrator_salesforce_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_salesforce_lasterror { get; set; } 

        [JsonProperty("salesforce_import_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? Salesforce_import_entities_list { get; set; } 

        [JsonProperty("salesforce_import_attachments_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? Salesforce_import_attachments_list { get; set; } 

        [JsonProperty("salesforce_clientmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLink_List>? Salesforce_clientmappings { get; set; } 

        [JsonProperty("azure_allowed_tenants", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Azure_allowed_tenants { get; set; } 

        [JsonProperty("azure_allowed_tenants_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? Azure_allowed_tenants_list { get; set; } 

        [JsonProperty("azure_auto_creation_site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Azure_auto_creation_site_name { get; set; } 

        [JsonProperty("b2cazure_auto_creation_site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? B2cazure_auto_creation_site_name { get; set; } 

        [JsonProperty("halointegrator_newrelic", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halointegrator_newrelic { get; set; } 

        [JsonProperty("halointegrator_newrelic_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Halointegrator_newrelic_lastsync { get; set; } 

        [JsonProperty("halointegrator_newrelic_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_newrelic_lasterror { get; set; } 

        [JsonProperty("halointegrator_backupradar", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halointegrator_backupradar { get; set; } 

        [JsonProperty("halointegrator_backupradar_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Halointegrator_backupradar_lastsync { get; set; } 

        [JsonProperty("halointegrator_backupradar_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_backupradar_lasterror { get; set; } 

        [JsonProperty("_deactivateclients", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _deactivateclients { get; set; } 

        [JsonProperty("kaseya_defaultsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Kaseya_defaultsite_name { get; set; } 

        [JsonProperty("halointegrator_kaseya", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halointegrator_kaseya { get; set; } 

        [JsonProperty("halointegrator_kaseya_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Halointegrator_kaseya_lastsync { get; set; } 

        [JsonProperty("halointegrator_kaseya_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_kaseya_lasterror { get; set; } 

        [JsonProperty("kaseya_agentfieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Kaseya_agentfieldmappings { get; set; } 

        [JsonProperty("kaseya_sitemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationSiteMapping>? Kaseya_sitemappings { get; set; } 

        [JsonProperty("kaseya_typemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<XTypeMapping>? Kaseya_typemappings { get; set; } 

        [JsonProperty("stripe_client_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLink_List>? Stripe_client_mappings { get; set; } 

        [JsonProperty("stripe_paymentmethod_options_keypair", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? Stripe_paymentmethod_options_keypair { get; set; } 

        [JsonProperty("stripe_manual_paymentmethod_options_keypair", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? Stripe_manual_paymentmethod_options_keypair { get; set; } 

        [JsonProperty("zabbix_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Zabbix_fieldmappings { get; set; } 

        [JsonProperty("zabbix_typemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<XTypeMapping>? Zabbix_typemappings { get; set; } 

        [JsonProperty("zabbix_default_type_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Zabbix_default_type_name { get; set; } 

        [JsonProperty("zabbix_default_site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Zabbix_default_site_name { get; set; } 

        [JsonProperty("halointegrator_zabbix", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halointegrator_zabbix { get; set; } 

        [JsonProperty("halointegrator_zabbix_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Halointegrator_zabbix_lastsync { get; set; } 

        [JsonProperty("halointegrator_zabbix_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_zabbix_lasterror { get; set; } 

        [JsonProperty("giacom_client_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLink_List>? Giacom_client_mappings { get; set; } 

        [JsonProperty("giacom_top_level_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Giacom_top_level_name { get; set; } 

        [JsonProperty("rhipe_client_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLink_List>? Rhipe_client_mappings { get; set; } 

        [JsonProperty("rhipe_top_level_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Rhipe_top_level_name { get; set; } 

        [JsonProperty("halointegrator_rhipe", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halointegrator_rhipe { get; set; } 

        [JsonProperty("halointegrator_rhipe_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Halointegrator_rhipe_lastsync { get; set; } 

        [JsonProperty("halointegrator_rhipe_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_rhipe_lasterror { get; set; } 

        [JsonProperty("rhipe_import_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? Rhipe_import_entities_list { get; set; } 

        [JsonProperty("techdata_client_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLink_List>? Techdata_client_mappings { get; set; } 

        [JsonProperty("techdata_top_level_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Techdata_top_level_name { get; set; } 

        [JsonProperty("halointegrator_techdata", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halointegrator_techdata { get; set; } 

        [JsonProperty("halointegrator_techdata_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Halointegrator_techdata_lastsync { get; set; } 

        [JsonProperty("halointegrator_techdata_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_techdata_lasterror { get; set; } 

        [JsonProperty("techdata_import_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? Techdata_import_entities_list { get; set; } 

        [JsonProperty("inty_client_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLink_List>? Inty_client_mappings { get; set; } 

        [JsonProperty("inty_top_level_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Inty_top_level_name { get; set; } 

        [JsonProperty("halointegrator_inty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halointegrator_inty { get; set; } 

        [JsonProperty("halointegrator_inty_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Halointegrator_inty_lastsync { get; set; } 

        [JsonProperty("halointegrator_inty_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_inty_lasterror { get; set; } 

        [JsonProperty("inty_import_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? Inty_import_entities_list { get; set; } 

        [JsonProperty("westcoastcloud_client_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLink_List>? Westcoastcloud_client_mappings { get; set; } 

        [JsonProperty("westcoastcloud_top_level_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Westcoastcloud_top_level_name { get; set; } 

        [JsonProperty("halointegrator_westcoastcloud", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halointegrator_westcoastcloud { get; set; } 

        [JsonProperty("halointegrator_westcoastcloud_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Halointegrator_westcoastcloud_lastsync { get; set; } 

        [JsonProperty("halointegrator_westcoastcloud_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_westcoastcloud_lasterror { get; set; } 

        [JsonProperty("westcoastcloud_import_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? Westcoastcloud_import_entities_list { get; set; } 

        [JsonProperty("sherweb_client_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLink_List>? Sherweb_client_mappings { get; set; } 

        [JsonProperty("sherweb_top_level_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sherweb_top_level_name { get; set; } 

        [JsonProperty("halointegrator_sherweb", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halointegrator_sherweb { get; set; } 

        [JsonProperty("halointegrator_sherweb_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Halointegrator_sherweb_lastsync { get; set; } 

        [JsonProperty("halointegrator_sherweb_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_sherweb_lasterror { get; set; } 

        [JsonProperty("sherweb_import_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? Sherweb_import_entities_list { get; set; } 

        [JsonProperty("also_client_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLink_List>? Also_client_mappings { get; set; } 

        [JsonProperty("also_top_level_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Also_top_level_name { get; set; } 

        [JsonProperty("halointegrator_also", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halointegrator_also { get; set; } 

        [JsonProperty("halointegrator_also_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Halointegrator_also_lastsync { get; set; } 

        [JsonProperty("halointegrator_also_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_also_lasterror { get; set; } 

        [JsonProperty("also_import_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? Also_import_entities_list { get; set; } 

        [JsonProperty("arrowsphere_client_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLink_List>? Arrowsphere_client_mappings { get; set; } 

        [JsonProperty("arrowsphere_top_level_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Arrowsphere_top_level_name { get; set; } 

        [JsonProperty("halointegrator_arrowsphere", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halointegrator_arrowsphere { get; set; } 

        [JsonProperty("halointegrator_arrowsphere_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Halointegrator_arrowsphere_lastsync { get; set; } 

        [JsonProperty("halointegrator_arrowsphere_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_arrowsphere_lasterror { get; set; } 

        [JsonProperty("arrowsphere_import_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? Arrowsphere_import_entities_list { get; set; } 

        [JsonProperty("dickerdata_client_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLink_List>? Dickerdata_client_mappings { get; set; } 

        [JsonProperty("dickerdata_top_level_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Dickerdata_top_level_name { get; set; } 

        [JsonProperty("halointegrator_dickerdata", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halointegrator_dickerdata { get; set; } 

        [JsonProperty("halointegrator_dickerdata_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Halointegrator_dickerdata_lastsync { get; set; } 

        [JsonProperty("halointegrator_dickerdata_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_dickerdata_lasterror { get; set; } 

        [JsonProperty("dickerdata_import_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? Dickerdata_import_entities_list { get; set; } 

        [JsonProperty("halointegrator_oracle", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halointegrator_oracle { get; set; } 

        [JsonProperty("halointegrator_oracle_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Halointegrator_oracle_lastsync { get; set; } 

        [JsonProperty("halointegrator_oracle_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_oracle_lasterror { get; set; } 

        [JsonProperty("halointegrator_servicenow", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halointegrator_servicenow { get; set; } 

        [JsonProperty("halointegrator_servicenow_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Halointegrator_servicenow_lastsync { get; set; } 

        [JsonProperty("halointegrator_servicenow_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_servicenow_lasterror { get; set; } 

        [JsonProperty("xerodefaulttenantname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Xerodefaulttenantname { get; set; } 

        [JsonProperty("qbdefaultcompanyname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Qbdefaultcompanyname { get; set; } 

        [JsonProperty("kashflowdefaultconnectionname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Kashflowdefaultconnectionname { get; set; } 

        [JsonProperty("dbcdefaulttenantname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Dbcdefaulttenantname { get; set; } 

        [JsonProperty("datadog_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Datadog_url { get; set; } 

        [JsonProperty("clear_billing_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Clear_billing_mappings { get; set; } 

        [JsonProperty("clearunsentactions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Clearunsentactions { get; set; } 

        [JsonProperty("clearunsentemailstore", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Clearunsentemailstore { get; set; } 

        [JsonProperty("clearunsentescmsg", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Clearunsentescmsg { get; set; } 

        [JsonProperty("clearunsentactions_attempted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Clearunsentactions_attempted { get; set; } 

        [JsonProperty("clearunsentemailstore_attempted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Clearunsentemailstore_attempted { get; set; } 

        [JsonProperty("clearunsentescmsg_attempted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Clearunsentescmsg_attempted { get; set; } 

        [JsonProperty("slack_ticket_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Slack_ticket_user_name { get; set; } 

        [JsonProperty("slack_command_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Slack_command_user_name { get; set; } 

        [JsonProperty("_checkexport_returnerrors", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _checkexport_returnerrors { get; set; } 

        [JsonProperty("device_tenantids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<int>? Device_tenantids { get; set; } 

        [JsonProperty("client_tenantids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<int>? Client_tenantids { get; set; } 

        [JsonProperty("connectwisecontrol_sitemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLink_List>? Connectwisecontrol_sitemappings { get; set; } 

        [JsonProperty("connectwisecontrol_typemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<XTypeMapping>? Connectwisecontrol_typemappings { get; set; } 

        [JsonProperty("halointegrator_connectwisecontrol", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halointegrator_connectwisecontrol { get; set; } 

        [JsonProperty("connectwisecontrol_import_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? Connectwisecontrol_import_entities_list { get; set; } 

        [JsonProperty("halointegrator_connectwisecontrol_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Halointegrator_connectwisecontrol_lastsync { get; set; } 

        [JsonProperty("halointegrator_connectwisecontrol_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_connectwisecontrol_lasterror { get; set; } 

        [JsonProperty("connectwisecontrolassetdefaultsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Connectwisecontrolassetdefaultsite_name { get; set; } 

        [JsonProperty("salesforce_priority_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Salesforce_priority_mappings { get; set; } 

        [JsonProperty("cors_whitelist_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? Cors_whitelist_list { get; set; } 

        [JsonProperty("okta_userrolemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Okta_userrolemappings { get; set; } 

        [JsonProperty("workspace_devicemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Workspace_devicemappings { get; set; } 

        [JsonProperty("workspace_site_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLink_List>? Workspace_site_mappings { get; set; } 

        [JsonProperty("twilio_ticket_type_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Twilio_ticket_type_name { get; set; } 

        [JsonProperty("twilio_default_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Twilio_default_user_name { get; set; } 

        [JsonProperty("sccm_sqldriver", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sccm_sqldriver { get; set; } 

        [JsonProperty("sccm_sqlprovider", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sccm_sqlprovider { get; set; } 

        [JsonProperty("lansweeper_sqldriver", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Lansweeper_sqldriver { get; set; } 

        [JsonProperty("lansweeper_sqlprovider", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Lansweeper_sqlprovider { get; set; } 

        [JsonProperty("processstreettickettypename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Processstreettickettypename { get; set; } 

        [JsonProperty("processstreetusername", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Processstreetusername { get; set; } 

        [JsonProperty("intacct_sync_halo_id_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? Intacct_sync_halo_id_list { get; set; } 

        [JsonProperty("intacctdefaultlocid_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? Intacctdefaultlocid_list { get; set; } 

        [JsonProperty("intacct_warehouse_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Intacct_warehouse_mappings { get; set; } 

        [JsonProperty("teams_chat_tenant_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? Teams_chat_tenant_list { get; set; } 

        [JsonProperty("workspace_defaultsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Workspace_defaultsite_name { get; set; } 

        [JsonProperty("halo_status_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Halo_status_mappings { get; set; } 

        [JsonProperty("halo_priority_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Halo_priority_mappings { get; set; } 

        [JsonProperty("etilizeurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Etilizeurl { get; set; } 

        [JsonProperty("barracuda_sitemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLink_List>? Barracuda_sitemappings { get; set; } 

        [JsonProperty("barracuda_clientmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLink_List>? Barracuda_clientmappings { get; set; } 

        [JsonProperty("barracuda_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Barracuda_fieldmappings { get; set; } 

        [JsonProperty("logicmonitor_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Logicmonitor_fieldmappings { get; set; } 

        [JsonProperty("halointegrator_logicmonitor", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halointegrator_logicmonitor { get; set; } 

        [JsonProperty("halointegrator_logicmonitor_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Halointegrator_logicmonitor_lastsync { get; set; } 

        [JsonProperty("halointegrator_logicmonitor_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_logicmonitor_lasterror { get; set; } 

        [JsonProperty("logicmonitor_defaultsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Logicmonitor_defaultsite_name { get; set; } 

        [JsonProperty("logicmonitor_alert_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Logicmonitor_alert_user_name { get; set; } 

        [JsonProperty("logicmonitor_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Logicmonitor_url { get; set; } 

        [JsonProperty("halointegrator_barracuda", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halointegrator_barracuda { get; set; } 

        [JsonProperty("halointegrator_barracuda_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Halointegrator_barracuda_lastsync { get; set; } 

        [JsonProperty("halointegrator_barracuda_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_barracuda_lasterror { get; set; } 

        [JsonProperty("barracuda_defaultsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Barracuda_defaultsite_name { get; set; } 

        [JsonProperty("barracudadefaultassettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Barracudadefaultassettype_name { get; set; } 

        [JsonProperty("barracuda_alert_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Barracuda_alert_user_name { get; set; } 

        [JsonProperty("teams_chat_tenants", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Teams_chat_tenants { get; set; } 

        [JsonProperty("teams_chat_welcome_message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Teams_chat_welcome_message { get; set; } 

        [JsonProperty("teams_chat_help_message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Teams_chat_help_message { get; set; } 

        [JsonProperty("gw_named_roles_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair>? Gw_named_roles_list { get; set; } 

        [JsonProperty("okta_named_roles_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair>? Okta_named_roles_list { get; set; } 

        [JsonProperty("lansweeper_mappings_xtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<XTypeMapping>? Lansweeper_mappings_xtype { get; set; } 

        [JsonProperty("gw_userrolemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Gw_userrolemappings { get; set; } 

        [JsonProperty("whatsapptickettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Whatsapptickettype_name { get; set; } 

        [JsonProperty("twilio_whatsapp_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Twilio_whatsapp_number { get; set; } 

        [JsonProperty("appointment_notification_body", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Appointment_notification_body { get; set; } 

        [JsonProperty("task_notification_body", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Task_notification_body { get; set; } 

        [JsonProperty("site24x7_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Site24x7_fieldmappings { get; set; } 

        [JsonProperty("site24x7_alert_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Site24x7_alert_user_name { get; set; } 

        [JsonProperty("gw_mappings_new_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Gw_mappings_new_user { get; set; } 

        [JsonProperty("okta_mappings_new_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Okta_mappings_new_user { get; set; } 

        [JsonProperty("recaptcha_site_key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Recaptcha_site_key { get; set; } 

        [JsonProperty("jamf_site_links", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLink_List>? Jamf_site_links { get; set; } 

        [JsonProperty("total_setup_steps", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Total_setup_steps { get; set; } 

        [JsonProperty("completed_setup_steps", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Completed_setup_steps { get; set; } 

        [JsonProperty("cleardatakey", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Cleardatakey { get; set; } 

        [JsonProperty("halointegrator_icinga", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halointegrator_icinga { get; set; } 

        [JsonProperty("halointegrator_icinga_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Halointegrator_icinga_lastsync { get; set; } 

        [JsonProperty("halointegrator_icinga_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_icinga_lasterror { get; set; } 

        [JsonProperty("icinga_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Icinga_fieldmappings { get; set; } 

        [JsonProperty("icinga_defaultsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Icinga_defaultsite_name { get; set; } 

        [JsonProperty("icingadefaultassettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Icingadefaultassettype_name { get; set; } 

        [JsonProperty("icinga_sitemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationSiteMapping>? Icinga_sitemappings { get; set; } 

        [JsonProperty("icinga_alert_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Icinga_alert_user_name { get; set; } 

        [JsonProperty("default_columns_id_sites_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Default_columns_id_sites_guid { get; set; } 

        [JsonProperty("default_columns_id_users_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Default_columns_id_users_guid { get; set; } 

        [JsonProperty("translations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<LanguagePackTranslationsCustom>? Translations { get; set; } 

        [JsonProperty("default_meter_tiers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<InvoiceDetailMeterTiers>? Default_meter_tiers { get; set; } 

        [JsonProperty("connectwisermm_sitemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLink_List>? Connectwisermm_sitemappings { get; set; } 

        [JsonProperty("connectwisermm_typemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<XTypeMapping>? Connectwisermm_typemappings { get; set; } 

        [JsonProperty("connectwise_rmm_defaultclient_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Connectwise_rmm_defaultclient_name { get; set; } 

        [JsonProperty("halointegrator_connectwisermm", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halointegrator_connectwisermm { get; set; } 

        [JsonProperty("connectwisermm_import_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? Connectwisermm_import_entities_list { get; set; } 

        [JsonProperty("halointegrator_connectwisermm_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Halointegrator_connectwisermm_lastsync { get; set; } 

        [JsonProperty("halointegrator_connectwisermm_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_connectwisermm_lasterror { get; set; } 

        [JsonProperty("cookiemessage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Cookiemessage { get; set; } 

        [JsonProperty("icinga_xtype_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<XTypeMapping>? Icinga_xtype_mappings { get; set; } 

        [JsonProperty("logicmonitor_xtype_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<XTypeMapping>? Logicmonitor_xtype_mappings { get; set; } 

        [JsonProperty("shopifydefaultsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Shopifydefaultsite_name { get; set; } 

        [JsonProperty("shopify_userfieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Shopify_userfieldmappings { get; set; } 

        [JsonProperty("shopify_customerfieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Shopify_customerfieldmappings { get; set; } 

        [JsonProperty("halointegrator_shopify", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halointegrator_shopify { get; set; } 

        [JsonProperty("halointegrator_shopify_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Halointegrator_shopify_lastsync { get; set; } 

        [JsonProperty("halointegrator_shopify_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_shopify_lasterror { get; set; } 

        [JsonProperty("shopify_import_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? Shopify_import_entities_list { get; set; } 

        [JsonProperty("intacct_invoicefieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Intacct_invoicefieldmappings { get; set; } 

        [JsonProperty("intacct_invoicelinefieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Intacct_invoicelinefieldmappings { get; set; } 

        [JsonProperty("intacct_orderfieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Intacct_orderfieldmappings { get; set; } 

        [JsonProperty("intacct_orderlinefieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Intacct_orderlinefieldmappings { get; set; } 

        [JsonProperty("intacct_creditfieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Intacct_creditfieldmappings { get; set; } 

        [JsonProperty("intacct_creditlinefieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Intacct_creditlinefieldmappings { get; set; } 

        [JsonProperty("intacct_billfieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Intacct_billfieldmappings { get; set; } 

        [JsonProperty("intacct_billlinefieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Intacct_billlinefieldmappings { get; set; } 

        [JsonProperty("halointegrator_xensam", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halointegrator_xensam { get; set; } 

        [JsonProperty("halointegrator_xensam_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Halointegrator_xensam_lastsync { get; set; } 

        [JsonProperty("halointegrator_xensam_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_xensam_lasterror { get; set; } 

        [JsonProperty("xensam_defaultsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Xensam_defaultsite_name { get; set; } 

        [JsonProperty("xensam_import_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? Xensam_import_entities_list { get; set; } 

        [JsonProperty("xensam_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Xensam_fieldmappings { get; set; } 

        [JsonProperty("xensam_datacentre_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Xensam_datacentre_fieldmappings { get; set; } 

        [JsonProperty("xensam_clientmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLink_List>? Xensam_clientmappings { get; set; } 

        [JsonProperty("xensam_mappings_xtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<XTypeMapping>? Xensam_mappings_xtype { get; set; } 

        [JsonProperty("trustpilot_defaultusersite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Trustpilot_defaultusersite_name { get; set; } 

        [JsonProperty("okta_sitegroup_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLink_List>? Okta_sitegroup_mappings { get; set; } 

        [JsonProperty("lansweeper_sql_port", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Lansweeper_sql_port { get; set; } 

        [JsonProperty("sccm_sql_port", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sccm_sql_port { get; set; } 

        [JsonProperty("can_disable_incoming_service", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Can_disable_incoming_service { get; set; } 

        [JsonProperty("zabbix_alert_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Zabbix_alert_user_name { get; set; } 

        [JsonProperty("connectwise_rmm_alert_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Connectwise_rmm_alert_user_name { get; set; } 

        [JsonProperty("amazon_seller_default_site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Amazon_seller_default_site_name { get; set; } 

        [JsonProperty("halointegrator_amazonseller", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halointegrator_amazonseller { get; set; } 

        [JsonProperty("halointegrator_amazonseller_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Halointegrator_amazonseller_lastsync { get; set; } 

        [JsonProperty("halointegrator_amazonseller_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_amazonseller_lasterror { get; set; } 

        [JsonProperty("is_nhserverless", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_nhserverless { get; set; } 

        [JsonProperty("incoming_default_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Incoming_default_user_name { get; set; } 

        [JsonProperty("incoming_newuser_default_site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Incoming_newuser_default_site_name { get; set; } 

        [JsonProperty("prometheus_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Prometheus_fieldmappings { get; set; } 

        [JsonProperty("prometheus_defaultassettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Prometheus_defaultassettype_name { get; set; } 

        [JsonProperty("prometheus_defaultsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Prometheus_defaultsite_name { get; set; } 

        [JsonProperty("prometheus_xtype_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<XTypeMapping>? Prometheus_xtype_mappings { get; set; } 

        [JsonProperty("prometheus_alerting_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Prometheus_alerting_user_name { get; set; } 

        [JsonProperty("halointegrator_prometheus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halointegrator_prometheus { get; set; } 

        [JsonProperty("halointegrator_prometheus_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Halointegrator_prometheus_lastsync { get; set; } 

        [JsonProperty("halointegrator_prometheus_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_prometheus_lasterror { get; set; } 

        [JsonProperty("halointegrator_mattermost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halointegrator_mattermost { get; set; } 

        [JsonProperty("halointegrator_mattermost_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Halointegrator_mattermost_lastsync { get; set; } 

        [JsonProperty("halointegrator_mattermost_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_mattermost_lasterror { get; set; } 

        [JsonProperty("halointegrator_wordpress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halointegrator_wordpress { get; set; } 

        [JsonProperty("halointegrator_wordpress_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Halointegrator_wordpress_lastsync { get; set; } 

        [JsonProperty("halointegrator_wordpress_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_wordpress_lasterror { get; set; } 

        [JsonProperty("reset_halointegrator_wordpress_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Reset_halointegrator_wordpress_lastsync { get; set; } 

        [JsonProperty("_dbintegrator_success", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _dbintegrator_success { get; set; } 

        [JsonProperty("deferred_revenue_client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Deferred_revenue_client_name { get; set; } 

        [JsonProperty("halointegrator_googlebusiness", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halointegrator_googlebusiness { get; set; } 

        [JsonProperty("halointegrator_googlebusiness_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Halointegrator_googlebusiness_lastsync { get; set; } 

        [JsonProperty("halointegrator_googlebusiness_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_googlebusiness_lasterror { get; set; } 

        [JsonProperty("reset_halointegrator_googlebusiness_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Reset_halointegrator_googlebusiness_lastsync { get; set; } 

        [JsonProperty("google_reviewdefaultusersite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Google_reviewdefaultusersite_name { get; set; } 

        [JsonProperty("google_questiondefaultusersite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Google_questiondefaultusersite_name { get; set; } 

        [JsonProperty("device_tenantids_strings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<string>? Device_tenantids_strings { get; set; } 

        [JsonProperty("twilio_account_sid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Twilio_account_sid { get; set; } 

        [JsonProperty("halointegrator_googlecalendars", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halointegrator_googlecalendars { get; set; } 

        [JsonProperty("halointegrator_googlecalendars_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Halointegrator_googlecalendars_lastsync { get; set; } 

        [JsonProperty("halointegrator_googlecalendars_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_googlecalendars_lasterror { get; set; } 

        [JsonProperty("aireports_enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Aireports_enabled { get; set; } 

        [JsonProperty("halointegrator_wordpressorg", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halointegrator_wordpressorg { get; set; } 

        [JsonProperty("halointegrator_wordpressorg_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Halointegrator_wordpressorg_lastsync { get; set; } 

        [JsonProperty("halointegrator_wordpressorg_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_wordpressorg_lasterror { get; set; } 

        [JsonProperty("reset_halointegrator_wordpressorg_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Reset_halointegrator_wordpressorg_lastsync { get; set; } 

        [JsonProperty("halointegrator_splashtop", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halointegrator_splashtop { get; set; } 

        [JsonProperty("halointegrator_splashtop_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Halointegrator_splashtop_lastsync { get; set; } 

        [JsonProperty("halointegrator_splashtop_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_splashtop_lasterror { get; set; } 

        [JsonProperty("gocardless_userfieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Gocardless_userfieldmappings { get; set; } 

        [JsonProperty("gocardless_defaultsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Gocardless_defaultsite_name { get; set; } 

        [JsonProperty("halointegrator_gocardless", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halointegrator_gocardless { get; set; } 

        [JsonProperty("halointegrator_gocardless_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Halointegrator_gocardless_lastsync { get; set; } 

        [JsonProperty("halointegrator_gocardless_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_gocardless_lasterror { get; set; } 

        [JsonProperty("reset_halointegrator_gocardless_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Reset_halointegrator_gocardless_lastsync { get; set; } 

        [JsonProperty("prometheus_api_url_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? Prometheus_api_url_list { get; set; } 

        [JsonProperty("aidetection_enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Aidetection_enabled { get; set; } 

        [JsonProperty("itglue_sync_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? Itglue_sync_entities_list { get; set; } 

        [JsonProperty("slack_command_workspaces", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? Slack_command_workspaces { get; set; } 

        [JsonProperty("meraki_top_level_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Meraki_top_level_name { get; set; } 

        [JsonProperty("meraki_client_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLink_List>? Meraki_client_mappings { get; set; } 

        [JsonProperty("meraki_device_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Meraki_device_fieldmappings { get; set; } 

        [JsonProperty("merakidefaultassettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Merakidefaultassettype_name { get; set; } 

        [JsonProperty("meraki_xtype_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<XTypeMapping>? Meraki_xtype_mappings { get; set; } 

        [JsonProperty("halointegrator_meraki", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halointegrator_meraki { get; set; } 

        [JsonProperty("halointegrator_meraki_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Halointegrator_meraki_lastsync { get; set; } 

        [JsonProperty("halointegrator_meraki_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_meraki_lasterror { get; set; } 

        [JsonProperty("meraki_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Meraki_url { get; set; } 

        [JsonProperty("saml_certififcate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Saml_certififcate { get; set; } 

        [JsonProperty("whatsapp_defaultclientsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Whatsapp_defaultclientsite_name { get; set; } 

        [JsonProperty("xsoar_default_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Xsoar_default_username { get; set; } 

        [JsonProperty("halointegrator_adobecommerce", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halointegrator_adobecommerce { get; set; } 

        [JsonProperty("halointegrator_adobecommerce_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Halointegrator_adobecommerce_lastsync { get; set; } 

        [JsonProperty("halointegrator_adobecommerce_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_adobecommerce_lasterror { get; set; } 

        [JsonProperty("adobecommercedefaultsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Adobecommercedefaultsite_name { get; set; } 

        [JsonProperty("adobecommerce_import_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? Adobecommerce_import_entities_list { get; set; } 

        [JsonProperty("openai_enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Openai_enabled { get; set; } 

        [JsonProperty("azureopenai_enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Azureopenai_enabled { get; set; } 

        [JsonProperty("azureopenai_embedding_enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Azureopenai_embedding_enabled { get; set; } 

        [JsonProperty("azureaisearch_demo_enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Azureaisearch_demo_enabled { get; set; } 

        [JsonProperty("freshdesk_statusfilter_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? Freshdesk_statusfilter_list { get; set; } 

        [JsonProperty("distributionlists_defaultsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Distributionlists_defaultsite_name { get; set; } 

        [JsonProperty("workspace_mobilemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Workspace_mobilemappings { get; set; } 

        [JsonProperty("workspace_mappings_xtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<XTypeMapping>? Workspace_mappings_xtype { get; set; } 

        [JsonProperty("_index_kbs_now", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _index_kbs_now { get; set; } 

        [JsonProperty("_index_services_now", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _index_services_now { get; set; } 

        [JsonProperty("home_html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Home_html { get; set; } 

        [JsonProperty("home_html_top", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Home_html_top { get; set; } 

        [JsonProperty("agent_presence_rules", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<UnamePresenceRule>? Agent_presence_rules { get; set; } 

        [JsonProperty("halointegrator_mailchimp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halointegrator_mailchimp { get; set; } 

        [JsonProperty("halointegrator_mailchimp_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Halointegrator_mailchimp_lastsync { get; set; } 

        [JsonProperty("halointegrator_mailchimp_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_mailchimp_lasterror { get; set; } 

        [JsonProperty("mailchimp_import_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? Mailchimp_import_entities_list { get; set; } 

        [JsonProperty("reset_halointegrator_mailchimp_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Reset_halointegrator_mailchimp_lastsync { get; set; } 

        [JsonProperty("quoteapprovalfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<RequestTypeField>? Quoteapprovalfields { get; set; } 

        [JsonProperty("recordonlinepresence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Recordonlinepresence { get; set; } 

        [JsonProperty("exchange_agent_subscriptions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<UnameEventSubscription>? Exchange_agent_subscriptions { get; set; } 

        [JsonProperty("_do_convert_to_prospects", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _do_convert_to_prospects { get; set; } 

        [JsonProperty("dynamicscrm_customtable_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Dynamics365CRMFieldMapping>? Dynamicscrm_customtable_mappings { get; set; } 

        [JsonProperty("webdashboardtitle_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Webdashboardtitle_override { get; set; } 

        [JsonProperty("contractapprovalfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<RequestTypeField>? Contractapprovalfields { get; set; } 

        [JsonProperty("sccm_dontupdatetype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sccm_dontupdatetype { get; set; } 

        [JsonProperty("lansweeper_dontupdatetype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Lansweeper_dontupdatetype { get; set; } 

        [JsonProperty("portal_requestor_display_attribute1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Portal_requestor_display_attribute1 { get; set; } 

        [JsonProperty("portal_requestor_display_attribute2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Portal_requestor_display_attribute2 { get; set; } 

        [JsonProperty("converted_currency_rounding_behaviour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Converted_currency_rounding_behaviour { get; set; } 

        [JsonProperty("agent_status_reassign_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AgentStatusReassignMapping>? Agent_status_reassign_mappings { get; set; } 

        [JsonProperty("new_integration_key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_integration_key { get; set; } 

        [JsonProperty("new_integration_key2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_integration_key2 { get; set; } 

        [JsonProperty("new_integration_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? New_integration_method { get; set; } 

        [JsonProperty("new_integration_webhook_key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_integration_webhook_key { get; set; } 

        [JsonProperty("integration_webhook_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Integration_webhook_username { get; set; } 

        [JsonProperty("new_integration_webhook_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? New_integration_webhook_method { get; set; } 

        [JsonProperty("atera_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Atera_url { get; set; } 

        [JsonProperty("businesscentral_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Businesscentral_url { get; set; } 

        [JsonProperty("businesscentral_appid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Businesscentral_appid { get; set; } 

        [JsonProperty("businesscentral_domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Businesscentral_domain { get; set; } 

        [JsonProperty("businesscentral_tokenexpiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Businesscentral_tokenexpiry { get; set; } 

        [JsonProperty("businesscentral_redirect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Businesscentral_redirect { get; set; } 

        [JsonProperty("businesscentral_authorised", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Businesscentral_authorised { get; set; } 

        [JsonProperty("dynamicscrm_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Dynamicscrm_url { get; set; } 

        [JsonProperty("dynamicscrm_appid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Dynamicscrm_appid { get; set; } 

        [JsonProperty("dynamicscrm_domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Dynamicscrm_domain { get; set; } 

        [JsonProperty("dynamicscrm_tokenexpiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Dynamicscrm_tokenexpiry { get; set; } 

        [JsonProperty("dynamicscrm_redirect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Dynamicscrm_redirect { get; set; } 

        [JsonProperty("dynamicscrm_authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dynamicscrm_authorized { get; set; } 

        [JsonProperty("exchange_application_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Exchange_application_id { get; set; } 

        [JsonProperty("exchange_tenant_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Exchange_tenant_id { get; set; } 

        [JsonProperty("exchange_token_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Exchange_token_expiry { get; set; } 

        [JsonProperty("exchange_redirect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Exchange_redirect { get; set; } 

        [JsonProperty("exchange_authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Exchange_authorized { get; set; } 

        [JsonProperty("device42_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Device42_url { get; set; } 

        [JsonProperty("device42_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Device42_username { get; set; } 

        [JsonProperty("prtg_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Prtg_url { get; set; } 

        [JsonProperty("prtg_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Prtg_username { get; set; } 

        [JsonProperty("prtg_password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Prtg_password { get; set; } 

        [JsonProperty("gfi_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Gfi_url { get; set; } 

        [JsonProperty("soc_api_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Soc_api_id { get; set; } 

        [JsonProperty("qbo_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Qbo_client_id { get; set; } 

        [JsonProperty("qbo_token_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Qbo_token_expiry { get; set; } 

        [JsonProperty("qbo_authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Qbo_authorized { get; set; } 

        [JsonProperty("qbo_redirect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Qbo_redirect { get; set; } 

        [JsonProperty("qbo_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Qbo_url { get; set; } 

        [JsonProperty("sage50password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sage50password { get; set; } 

        [JsonProperty("servicenow_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Servicenow_url { get; set; } 

        [JsonProperty("servicenow_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Servicenow_username { get; set; } 

        [JsonProperty("autotask_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Autotask_username { get; set; } 

        [JsonProperty("connectwise_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Connectwise_url { get; set; } 

        [JsonProperty("connectwise_public_key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Connectwise_public_key { get; set; } 

        [JsonProperty("connectwise_private_key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Connectwise_private_key { get; set; } 

        [JsonProperty("ninja_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ninja_url { get; set; } 

        [JsonProperty("ninja_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ninja_client_id { get; set; } 

        [JsonProperty("ninja_authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ninja_authorized { get; set; } 

        [JsonProperty("ninja_token_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Ninja_token_expiry { get; set; } 

        [JsonProperty("ninja_redirect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ninja_redirect { get; set; } 

        [JsonProperty("itglue_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Itglue_url { get; set; } 

        [JsonProperty("snelstart_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Snelstart_url { get; set; } 

        [JsonProperty("snelstart_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Snelstart_client_id { get; set; } 

        [JsonProperty("snelstart_authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Snelstart_authorized { get; set; } 

        [JsonProperty("snelstart_token_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Snelstart_token_expiry { get; set; } 

        [JsonProperty("jamf_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Jamf_url { get; set; } 

        [JsonProperty("jamf_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Jamf_username { get; set; } 

        [JsonProperty("interact_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Interact_url { get; set; } 

        [JsonProperty("interact_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Interact_username { get; set; } 

        [JsonProperty("interact_tenant", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Interact_tenant { get; set; } 

        [JsonProperty("interact_token_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Interact_token_expiry { get; set; } 

        [JsonProperty("gw_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Gw_url { get; set; } 

        [JsonProperty("gw_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Gw_client_id { get; set; } 

        [JsonProperty("gw_token_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Gw_token_expiry { get; set; } 

        [JsonProperty("gw_redirect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Gw_redirect { get; set; } 

        [JsonProperty("gw_authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Gw_authorized { get; set; } 

        [JsonProperty("scomservername", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Scomservername { get; set; } 

        [JsonProperty("scomdomain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Scomdomain { get; set; } 

        [JsonProperty("scomusername", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Scomusername { get; set; } 

        [JsonProperty("scompassword", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Scompassword { get; set; } 

        [JsonProperty("scom_access", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Scom_access { get; set; } 

        [JsonProperty("orion_server_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Orion_server_name { get; set; } 

        [JsonProperty("orion_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Orion_username { get; set; } 

        [JsonProperty("orion_password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Orion_password { get; set; } 

        [JsonProperty("orion_access", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Orion_access { get; set; } 

        [JsonProperty("beyondtrust_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Beyondtrust_url { get; set; } 

        [JsonProperty("beyondtrust_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Beyondtrust_username { get; set; } 

        [JsonProperty("beyondtrust_token_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Beyondtrust_token_expiry { get; set; } 

        [JsonProperty("beyondtrust_authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Beyondtrust_authorized { get; set; } 

        [JsonProperty("sentinel_token_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Sentinel_token_expiry { get; set; } 

        [JsonProperty("sentinel_redirect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sentinel_redirect { get; set; } 

        [JsonProperty("sentinel_authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sentinel_authorized { get; set; } 

        [JsonProperty("syncro_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Syncro_url { get; set; } 

        [JsonProperty("domotz_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Domotz_url { get; set; } 

        [JsonProperty("g2aremote_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? G2aremote_client_id { get; set; } 

        [JsonProperty("automate_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Automate_url { get; set; } 

        [JsonProperty("automate_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Automate_username { get; set; } 

        [JsonProperty("g2aremote_authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? G2aremote_authorized { get; set; } 

        [JsonProperty("automate_token_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Automate_token_expiry { get; set; } 

        [JsonProperty("g2aremote_refresh_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? G2aremote_refresh_token { get; set; } 

        [JsonProperty("g2aremote_token_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? G2aremote_token_expiry { get; set; } 

        [JsonProperty("g2aremote_redirect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? G2aremote_redirect { get; set; } 

        [JsonProperty("snow_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Snow_username { get; set; } 

        [JsonProperty("snow_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Snow_url { get; set; } 

        [JsonProperty("auvik_tenant", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Auvik_tenant { get; set; } 

        [JsonProperty("auvik_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Auvik_username { get; set; } 

        [JsonProperty("hubspot_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Hubspot_url { get; set; } 

        [JsonProperty("hubspot_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Hubspot_client_id { get; set; } 

        [JsonProperty("hubspot_authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hubspot_authorized { get; set; } 

        [JsonProperty("hubspot_token_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Hubspot_token_expiry { get; set; } 

        [JsonProperty("hubspot_redirect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Hubspot_redirect { get; set; } 

        [JsonProperty("qualys_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Qualys_url { get; set; } 

        [JsonProperty("qualys_domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Qualys_domain { get; set; } 

        [JsonProperty("qualys_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Qualys_username { get; set; } 

        [JsonProperty("azuretranslate_region", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Azuretranslate_region { get; set; } 

        [JsonProperty("azuretranslate_currentusage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Azuretranslate_currentusage { get; set; } 

        [JsonProperty("passportal_apikey", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Passportal_apikey { get; set; } 

        [JsonProperty("passportal_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Passportal_url { get; set; } 

        [JsonProperty("passportal_refresh_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Passportal_refresh_token { get; set; } 

        [JsonProperty("passportal_token_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Passportal_token_expiry { get; set; } 

        [JsonProperty("hudu_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Hudu_url { get; set; } 

        [JsonProperty("cipp_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Cipp_url { get; set; } 

        [JsonProperty("intacct_sender_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intacct_sender_id { get; set; } 

        [JsonProperty("intacct_company_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intacct_company_id { get; set; } 

        [JsonProperty("intacct_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intacct_username { get; set; } 

        [JsonProperty("backupradar_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Backupradar_url { get; set; } 

        [JsonProperty("addigy_clientid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Addigy_clientid { get; set; } 

        [JsonProperty("ingram_micro_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ingram_micro_url { get; set; } 

        [JsonProperty("ingram_micro_marketplace", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ingram_micro_marketplace { get; set; } 

        [JsonProperty("ingram_micro_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ingram_micro_username { get; set; } 

        [JsonProperty("ingram_micro_token_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Ingram_micro_token_expiry { get; set; } 

        [JsonProperty("freshdesk_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Freshdesk_url { get; set; } 

        [JsonProperty("liongard_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Liongard_url { get; set; } 

        [JsonProperty("liongard_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Liongard_client_id { get; set; } 

        [JsonProperty("salesforce_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Salesforce_client_id { get; set; } 

        [JsonProperty("pax8_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Pax8_client_id { get; set; } 

        [JsonProperty("salesforce_authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Salesforce_authorized { get; set; } 

        [JsonProperty("pax8_token_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Pax8_token_expiry { get; set; } 

        [JsonProperty("salesforce_refresh_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Salesforce_refresh_token { get; set; } 

        [JsonProperty("salesforce_token_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Salesforce_token_expiry { get; set; } 

        [JsonProperty("salesforce_redirect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Salesforce_redirect { get; set; } 

        [JsonProperty("salesforce_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Salesforce_url { get; set; } 

        [JsonProperty("client_secret_newrelic", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Client_secret_newrelic { get; set; } 

        [JsonProperty("newrelicuser_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Newrelicuser_name { get; set; } 

        [JsonProperty("newrelic_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Newrelic_url { get; set; } 

        [JsonProperty("new_glclientsecret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_glclientsecret { get; set; } 

        [JsonProperty("kaseya_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Kaseya_client_id { get; set; } 

        [JsonProperty("kaseya_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Kaseya_url { get; set; } 

        [JsonProperty("kaseya_authorised", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Kaseya_authorised { get; set; } 

        [JsonProperty("kaseya_alert_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Kaseya_alert_user_name { get; set; } 

        [JsonProperty("kaseya_servicedesks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair2>? Kaseya_servicedesks { get; set; } 

        [JsonProperty("chat_service_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Chat_service_url { get; set; } 

        [JsonProperty("report_service_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Report_service_url { get; set; } 

        [JsonProperty("zabbix_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Zabbix_url { get; set; } 

        [JsonProperty("zabbix_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Zabbix_username { get; set; } 

        [JsonProperty("rhipe_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Rhipe_client_id { get; set; } 

        [JsonProperty("techdata_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Techdata_client_id { get; set; } 

        [JsonProperty("inty_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Inty_url { get; set; } 

        [JsonProperty("inty_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Inty_username { get; set; } 

        [JsonProperty("westcoastcloud_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Westcoastcloud_url { get; set; } 

        [JsonProperty("westcoastcloud_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Westcoastcloud_username { get; set; } 

        [JsonProperty("sherweb_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sherweb_client_id { get; set; } 

        [JsonProperty("sherweb_tenant", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sherweb_tenant { get; set; } 

        [JsonProperty("also_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Also_url { get; set; } 

        [JsonProperty("also_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Also_username { get; set; } 

        [JsonProperty("dickerdata_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Dickerdata_url { get; set; } 

        [JsonProperty("quoter_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Quoter_url { get; set; } 

        [JsonProperty("quoter_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Quoter_client_id { get; set; } 

        [JsonProperty("halolink_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halolink_url { get; set; } 

        [JsonProperty("halolink_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halolink_client_id { get; set; } 

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
        public ICollection<string>? Gw_scopes { get; set; } 

        [JsonProperty("gw_asset_scopes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Gw_asset_scopes { get; set; } 

        [JsonProperty("pagerduty_services", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<PagerDutyMapping>? Pagerduty_services { get; set; } 

        [JsonProperty("integration_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Integration_client_id { get; set; } 

        [JsonProperty("whatsapp_authorised", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Whatsapp_authorised { get; set; } 

        [JsonProperty("logicmonitor_access_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Logicmonitor_access_id { get; set; } 

        [JsonProperty("openai_default_model", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Openai_default_model { get; set; } 

        [JsonProperty("azure_openai_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Azure_openai_url { get; set; } 

        [JsonProperty("azure_openai_version", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Azure_openai_version { get; set; } 

        [JsonProperty("azure_ai_search_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Azure_ai_search_url { get; set; } 

        [JsonProperty("azure_ai_search_version", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Azure_ai_search_version { get; set; } 

        [JsonProperty("integration_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Integration_url { get; set; } 

        [JsonProperty("integration_tenant", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Integration_tenant { get; set; } 

        [JsonProperty("openai_embeddings_tickettypes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<RequestType_List>? Openai_embeddings_tickettypes { get; set; } 

        [JsonProperty("azureopenai_embeddings_tickettypes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<RequestType_List>? Azureopenai_embeddings_tickettypes { get; set; } 

        [JsonProperty("aiembedding_enabled_tickettypes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair4>? Aiembedding_enabled_tickettypes { get; set; } 

        [JsonProperty("vectorise_tickettypes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<RequestType_List>? Vectorise_tickettypes { get; set; } 

        [JsonProperty("vectorise_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Vectorise_date { get; set; } 

        [JsonProperty("opsgenie_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Opsgenie_url { get; set; } 

        [JsonProperty("opsgenie_instance_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Opsgenie_instance_url { get; set; } 

        [JsonProperty("teams_tenant_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Teams_tenant_id { get; set; } 

        [JsonProperty("teams_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Teams_client_id { get; set; } 

        [JsonProperty("teams_authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Teams_authorized { get; set; } 

        [JsonProperty("freshdesk_status_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Freshdesk_status_mappings { get; set; } 

        [JsonProperty("freshdesk_priority_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Freshdesk_priority_mappings { get; set; } 

        [JsonProperty("freshdesk_team_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Freshdesk_team_mappings { get; set; } 

        [JsonProperty("freshdesk_field_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Freshdesk_field_mappings { get; set; } 

        [JsonProperty("coralogix_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Coralogix_url { get; set; } 

        [JsonProperty("coralogix_uuid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Coralogix_uuid { get; set; } 

        [JsonProperty("gw_mobile_scopes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Gw_mobile_scopes { get; set; } 

        [JsonProperty("mailchimp_authorised", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Mailchimp_authorised { get; set; } 

        [JsonProperty("zendesk_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Zendesk_url { get; set; } 

        [JsonProperty("zendesk_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Zendesk_email { get; set; } 

        [JsonProperty("teamsshifts_tenant_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Teamsshifts_tenant_id { get; set; } 

        [JsonProperty("teamsshifts_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Teamsshifts_client_id { get; set; } 

        [JsonProperty("teamsshifts_authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Teamsshifts_authorized { get; set; } 

        [JsonProperty("teamsshifts_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<MicrosoftTeamsMapping>? Teamsshifts_mappings { get; set; } 

        [JsonProperty("halointegrator_microsoftteams", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Halointegrator_microsoftteams { get; set; } 

        [JsonProperty("halointegrator_microsoftteams_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Halointegrator_microsoftteams_lastsync { get; set; } 

        [JsonProperty("halointegrator_microsoftteams_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Halointegrator_microsoftteams_lasterror { get; set; } 

        [JsonProperty("reset_halointegrator_microsoftteams_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Reset_halointegrator_microsoftteams_lastsync { get; set; } 

        [JsonProperty("hopewiser_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Hopewiser_user { get; set; } 

        [JsonProperty("hopewiser_maf", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Hopewiser_maf { get; set; } 

        [JsonProperty("teamsshifts_shifttype_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLink_List>? Teamsshifts_shifttype_mappings { get; set; } 

        [JsonProperty("webhook_iterations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Webhook_iterations { get; set; } 

    }