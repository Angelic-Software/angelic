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
    public bool? DefaultUserContacted { get; set; }

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
    public string? GbitDir { get; set; }

    [JsonProperty("mapfile", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MapFile { get; set; }

    [JsonProperty("dudir", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DuDir { get; set; }

    [JsonProperty("allowduplicateinv", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowDuplicateInv { get; set; }

    [JsonProperty("sendackemailsforwebrequests", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? SendAckEmailsForWebRequests { get; set; }

    [JsonProperty("usesage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? UseSage { get; set; }

    [JsonProperty("useqb", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? UseQb { get; set; }

    [JsonProperty("qbversion", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? QbVersion { get; set; }

    [JsonProperty("allowwebupload", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowWebUpload { get; set; }

    [JsonProperty("enablemultientitysearch", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? EnableMultiEntitySearch { get; set; }

    [JsonProperty("portalallowkbsearch", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? PortalAllowKbSearch { get; set; }

    [JsonProperty("portalallowservicesearch", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? PortalAllowServiceSearch { get; set; }

    [JsonProperty("portalallowticketsearch", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? PortalAllowTicketSearch { get; set; }

    [JsonProperty("multientitysearchincludefaults", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? MultiEntitySearchIncludeFaults { get; set; }

    [JsonProperty("multientitysearchincludekbentry", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? MultiEntitySearchIncludeKbEntry { get; set; }

    [JsonProperty("multientitysearchincludedevice", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? MultiEntitySearchIncludeDevice { get; set; }

    [JsonProperty("multientitysearchincludearea", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? MultiEntitySearchIncludeArea { get; set; }

    [JsonProperty("multientitysearchincludesite", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? MultiEntitySearchIncludeSite { get; set; }

    [JsonProperty("multientitysearchincludeusers", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? MultiEntitySearchIncludeUsers { get; set; }

    [JsonProperty("multientitysearchincludecompany", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? MultiEntitySearchIncludeCompany { get; set; }

    [JsonProperty("multientitysearchincludeitem", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? MultiEntitySearchIncludeItem { get; set; }

    [JsonProperty("multientitysearchincludequote", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? MultiEntitySearchIncludeQuote { get; set; }

    [JsonProperty("multientitysearchincludeso", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? MultiEntitySearchIncludeSo { get; set; }

    [JsonProperty("multientitysearchincludepo", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? MultiEntitySearchIncludePo { get; set; }

    [JsonProperty("multientitysearchincludeservices", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? MultiEntitySearchIncludeServices { get; set; }

    [JsonProperty("showquicksearch", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowQuickSearch { get; set; }

    [JsonProperty("showtreesearch", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowTreeSearch { get; set; }

    [JsonProperty("defaultpdftemplatecredit", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultPdfTemplateCredit { get; set; }

    [JsonProperty("allownewuserfromchangeuserscreen", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowNewUserFromChangeUserScreen { get; set; }

    [JsonProperty("adselfservicewebapppwdresettype", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? AdSelfServiceWebAppPwdResetType { get; set; }

    [JsonProperty("tickettimerdisplay", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TicketTimerDisplay { get; set; }

    [JsonProperty("portalbuttonmaxperrow", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PortalButtonMaxPerRow { get; set; }

    [JsonProperty("continuallyappid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ContinuallyAppId { get; set; }

    [JsonProperty("tawkappid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TawkAppId { get; set; }

    [JsonProperty("percentageoverdue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PercentageOverdue { get; set; }

    [JsonProperty("trackticketviews", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? TrackTicketViews { get; set; }

    [JsonProperty("showprepaybalanceonticket", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowPrepayBalanceOnTicket { get; set; }

    [JsonProperty("ssorememberme", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? SsoRememberMe { get; set; }

    [JsonProperty("eupallowsiteselection", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? EupAllowSiteSelection { get; set; }

    [JsonProperty("showtemplateselectionbutton", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowTemplateSelectionButton { get; set; }

    [JsonProperty("showsaveastemplatebutton", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowSaveAsTemplateButton { get; set; }

    [JsonProperty("welcome_message_label", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? WelcomeMessageLabel { get; set; }

    [JsonProperty("problemmatchsearchmode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ProblemMatchSearchMode { get; set; }

    [JsonProperty("sage50username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Sage50Username { get; set; }

    [JsonProperty("sage50version", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sage50Version { get; set; }

    [JsonProperty("sage50datapath", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Sage50DataPath { get; set; }

    [JsonProperty("updateticketwhenpoinstock", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? UpdateTicketWhenPoInStock { get; set; }

    [JsonProperty("updateticketwhenpoinstockstatus", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? UpdateTicketWhenPoInStockStatus { get; set; }

    [JsonProperty("updateticketwhenpoinstockstatus_guid", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public Guid? UpdateTicketWhenPoInStockStatusGuid { get; set; }

    [JsonProperty("allowstockreserve", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowStockReserve { get; set; }

    [JsonProperty("budgetcalctype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? BudgetCalcType { get; set; }

    [JsonProperty("periodsaheadforcontractinvoicestart", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? PeriodsAheadForContractInvoiceStart { get; set; }

    [JsonProperty("defaultcontractenddatetype", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultContractEndDateType { get; set; }

    [JsonProperty("encthumbprint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EncThumbPrint { get; set; }

    [JsonProperty("homescreendashboardid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? HomeScreenDashboardId { get; set; }

    [JsonProperty("sidemenudashboardid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SideMenuDashboardId { get; set; }

    [JsonProperty("loadimagesfromapitype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? LoadImagesFromApiType { get; set; }

    [JsonProperty("loadattachmentsfromapitype", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? LoadAttachmentsFromApiType { get; set; }

    [JsonProperty("loadimagesfromapilocation", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public string? LoadImagesFromApiLocation { get; set; }

    [JsonProperty("loadimagesfromapiurloverride", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public string? LoadImagesFromApiUrlOverride { get; set; }

    [JsonProperty("allowlivechatonnewportal", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowLiveChatOnNewPortal { get; set; }

    [JsonProperty("allowtaxcodeoverride", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowTaxCodeOverride { get; set; }

    [JsonProperty("mergerecurringinvoices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? MergeRecurringInvoices { get; set; }

    [JsonProperty("mergesalesorderinvoices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? MergeSalesOrderInvoices { get; set; }

    [JsonProperty("showusersassetsonticket", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowUsersAssetsOnTicket { get; set; }

    [JsonProperty("showusersassetsoncall", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowUsersAssetsOnCall { get; set; }

    [JsonProperty("enablementions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? EnableMentions { get; set; }

    [JsonProperty("enablementionscrm", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? EnableMentionsCrm { get; set; }

    [JsonProperty("enableteammentions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? EnableTeamMentions { get; set; }

    [JsonProperty("usetechfwdfunctionalityupdateparent", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? UseTechFwdFunctionalityUpdateParent { get; set; }

    [JsonProperty("pomincostforapproval", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? PoMinCostForApproval { get; set; }

    [JsonProperty("poapproverselectiontype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PoApproverSelectionType { get; set; }

    [JsonProperty("enablequoteapprovals", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? EnableQuoteApprovals { get; set; }

    [JsonProperty("quotemarginforapproval", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? QuoteMarginForApproval { get; set; }

    [JsonProperty("enablemyreports", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? EnableMyReports { get; set; }

    [JsonProperty("enablemyscheduledreports", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? EnableMyScheduledReports { get; set; }

    [JsonProperty("showquotecannedonapprovalscreen", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowQuoteCannedOnApprovalScreen { get; set; }

    [JsonProperty("enableagentbooking", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? EnableAgentBooking { get; set; }

    [JsonProperty("agentbooking_min_hours_advance", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public double? AgentBookingMinHoursAdvance { get; set; }

    [JsonProperty("agentbooking_max_days_advance", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public double? AgentBookingMaxDaysAdvance { get; set; }

    [JsonProperty("agentbookingonlyauthenticated", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? AgentBookingOnlyAuthenticated { get; set; }

    [JsonProperty("enableprojecttreeview", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? EnableProjectTreeView { get; set; }

    [JsonProperty("publishchangecalendar", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? PublishChangeCalendar { get; set; }

    [JsonProperty("enablekbdrafts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? EnableKbDrafts { get; set; }

    [JsonProperty("kbdrafttickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? KbDraftTicketType { get; set; }

    [JsonProperty("kbdrafttickettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? KbDraftTicketTypeGuid { get; set; }

    [JsonProperty("usecurrencyconversion", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? UseCurrencyConversion { get; set; }

    [JsonProperty("usetravelchargerates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? UseTravelChargeRates { get; set; }

    [JsonProperty("usersearchmode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? UserSearchMode { get; set; }

    [JsonProperty("usersearchmode2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? UserSearchMode2 { get; set; }

    [JsonProperty("detailsscreendisplaytype", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? DetailsScreenDisplayType { get; set; }

    [JsonProperty("navdisplaymode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? NavDisplayMode { get; set; }

    [JsonProperty("usesemanticversioning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? UseSemanticVersioning { get; set; }

    [JsonProperty("usesecurequotesigning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? UseSecureQuoteSigning { get; set; }

    [JsonProperty("timefieldinputtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TimeFieldInputType { get; set; }

    [JsonProperty("ticketdetailstitledisplaymode", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? TicketDetailsTitleDisplayMode { get; set; }

    [JsonProperty("allownewusersiteid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AllowNewUserSiteId { get; set; }

    [JsonProperty("allow_new_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowNewUser { get; set; }

    [JsonProperty("newusersite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewUserSiteName { get; set; }

    [JsonProperty("itemnamesunique", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ItemNamesUnique { get; set; }

    [JsonProperty("translationtexttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TranslationTextType { get; set; }

    [JsonProperty("translationmonthlycharactercap", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public long? TranslationMonthlyCharacterCap { get; set; }

    [JsonProperty("translationmonthlycharactercapcanedit", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? TranslationMonthlyCharacterCapCanEdit { get; set; }

    [JsonProperty("crmshowextradetails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CrmShowExtraDetails { get; set; }

    [JsonProperty("defaultclientdetailslayout", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultClientDetailsLayout { get; set; }

    [JsonProperty("kbviewagentapp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? KbViewAgentApp { get; set; }

    [JsonProperty("enablefulltextsearchactions", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? EnableFullTextSearchActions { get; set; }

    [JsonProperty("addressfieldtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AddressFieldType { get; set; }

    [JsonProperty("livechatconnectionmethod", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? LiveChatConnectionMethod { get; set; }

    [JsonProperty("portalchatprofile", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PortalChatProfile { get; set; }

    [JsonProperty("sage50ukinvoicetype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sage50UkInvoiceType { get; set; }

    [JsonProperty("twilliosmsaccountsid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TwillioSmsAccountsId { get; set; }

    [JsonProperty("twilliosmsauthtoken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TwillioSmsAuthToken { get; set; }

    [JsonProperty("new_twilliosmsauthtoken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewTwillioSmsAuthToken { get; set; }

    [JsonProperty("twilliosmsfromphonenumber", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public string? TwillioSmsFromPhoneNumber { get; set; }

    [JsonProperty("twilliosmsleadingzerosubstitute", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public string? TwillioSmsLeadingZeroSubstitute { get; set; }

    [JsonProperty("smstype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SmsType { get; set; }

    [JsonProperty("connectwisemanageclientid", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public string? ConnectWiseManageClientId { get; set; }

    [JsonProperty("showallphonenumbersonticketdetails", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowAllPhoneNumbersOnTicketDetails { get; set; }

    [JsonProperty("sendaccountmanagernotifications", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? SendAccountManagerNotifications { get; set; }

    [JsonProperty("useutcforappointments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? UseUtcForAppointments { get; set; }

    [JsonProperty("stopautomaticdevicemovementsinstock", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? StopAutomaticDeviceMovementsInStock { get; set; }

    [JsonProperty("setdisplaynametoagentname", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? SetDisplayNameToAgentName { get; set; }

    [JsonProperty("livechatjoinmode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? LiveChatJoinMode { get; set; }

    [JsonProperty("chatshownewbubble", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ChatShowNewBubble { get; set; }

    [JsonProperty("automateticketscriptid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AutomateTicketScriptId { get; set; }

    [JsonProperty("automateticketscriptentityid", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? AutomateTicketScriptEntityId { get; set; }

    [JsonProperty("syncingxeroproducts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? SyncingXeroProducts { get; set; }

    [JsonProperty("report_colour_palette", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ReportColourPalette { get; set; }

    [JsonProperty("enablehalostripe", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? EnableHaloStripe { get; set; }

    [JsonProperty("enablehalostripewebhooks", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? EnableHaloStripeWebhooks { get; set; }

    [JsonProperty("donotcreateuser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DoNotCreateUser { get; set; }

    [JsonProperty("attachmentstabtable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AttachmentsTabTable { get; set; }

    [JsonProperty("enablehalonews", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? EnableHaloNews { get; set; }

    [JsonProperty("enablestockbins", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? EnableStockbins { get; set; }

    [JsonProperty("defaultstockbinlocation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultStockbinLocation { get; set; }

    [JsonProperty("defaultmovestocklocation", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultMoveStockLocation { get; set; }

    [JsonProperty("defaultmovestockbinlocation", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultMoveStockbinLocation { get; set; }

    [JsonProperty("enableportalgdprscreen", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? EnablePortalGdprScreen { get; set; }

    [JsonProperty("autocreatecustomerreference", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? AutoCreateCustomerReference { get; set; }

    [JsonProperty("autogenerate_itemaccountsid", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? AutogenerateItemAccountsId { get; set; }

    [JsonProperty("useeventservice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? UseEventService { get; set; }

    [JsonProperty("useschedulingservice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? UseSchedulingService { get; set; }

    [JsonProperty("timesensitivemethod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TimeSensitiveMethod { get; set; }

    [JsonProperty("usedefaultsubjectmatchingtag", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? UseDefaultSubjectMatchingTag { get; set; }

    [JsonProperty("useprepaypurchasedatesforcalculatingbalance", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? UsePrepayPurchaseDatesForCalculatingBalance { get; set; }

    [JsonProperty("sagebusinessclouddefaulttenantid", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? SageBusinessCloudDefaultTenantId { get; set; }

    [JsonProperty("sagebusinesscloud_default_invoice_status", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? SageBusinessCloudDefaultInvoiceStatus { get; set; }

    [JsonProperty("sagebusinesscloud_default_invoice_status_guid", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public Guid? SageBusinessCloudDefaultInvoiceStatusGuid { get; set; }

    [JsonProperty("publishchangecalendartype", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? PublishChangeCalendarType { get; set; }

    [JsonProperty("xero_post_group_headers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? XeroPostGroupHeaders { get; set; }

    [JsonProperty("responsedontassign", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ResponseDontAssign { get; set; }

    [JsonProperty("automaticallysendsignedticketclosurepdf", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? AutomaticallySendSignedTicketClosurePdf { get; set; }

    [JsonProperty("linkrecurringapptticket", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? LinkRecurringApptTicket { get; set; }

    [JsonProperty("closetaskswhenclosingticket", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? CloseTasksWhenClosingTicket { get; set; }

    [JsonProperty("assetserializationtabbehaviour", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? AssetSerializationTabBehaviour { get; set; }

    [JsonProperty("showassettagongoodsout", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowAssetTagOnGoodsOut { get; set; }

    [JsonProperty("mustsetcustomerfirst", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? MustSetCustomerFirst { get; set; }

    [JsonProperty("dontsendacktononsitedomain", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? DontSendAckToNonSiteDomain { get; set; }

    [JsonProperty("salesorderstatusafterinvoiced", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? SalesOrderStatusAfterInvoiced { get; set; }

    [JsonProperty("salesorderstatusafterinvoicedandactionscomplete", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? SalesOrderStatusAfterInvoicedAndActionsComplete { get; set; }

    [JsonProperty("defaultfornewopportunityuser", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultForNewOpportunityUser { get; set; }

    [JsonProperty("donotshowwarrantyexpiration", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? DoNotShowWarrantyExpiration { get; set; }

    [JsonProperty("hide_default_opps_area", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? HideDefaultOppsArea { get; set; }

    [JsonProperty("show_asset_diagram_services", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowAssetDiagramServices { get; set; }

    [JsonProperty("portal_kb_matching_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PortalKbMatchingType { get; set; }

    [JsonProperty("checkticketclashes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CheckTicketClashes { get; set; }

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
    public bool? AdditionalResponseActionInfo { get; set; }

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
    public bool? PreventClashChangeLogging { get; set; }

    [JsonProperty("exactdefaultdivision", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ExactDefaultDivision { get; set; }

    [JsonProperty("removewelcomemessage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? RemoveWelcomeMessage { get; set; }

    [JsonProperty("new_search_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? NewSearchType { get; set; }

    [JsonProperty("limit_action_search", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? LimitActionSearch { get; set; }

    [JsonProperty("app_scheduler_show_all_agents", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? AppSchedulerShowAllAgents { get; set; }

    [JsonProperty("enableagentcheckins", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? EnableAgentCheckIns { get; set; }

    [JsonProperty("nabledeletedevices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? NAbleDeleteDevices { get; set; }

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
    public bool? EnableConfigChangeTracking { get; set; }

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
    public string? SamlIdpColour { get; set; }

    [JsonProperty("samlidp_logo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SamlIdpLogo { get; set; }

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
    public int? TicketStatusAfterQuoteApproval { get; set; }

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
    public int? NagAssetIpAddress { get; set; }

    [JsonProperty("nag_assethostname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? NagAssetHostname { get; set; }

    [JsonProperty("bulk_privatenote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? BulkPrivateNote { get; set; }

    [JsonProperty("bulk_publicnote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? BulkPublicNote { get; set; }

    [JsonProperty("connectwise_control_client_field", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? ConnectWiseControlClientField { get; set; }

    [JsonProperty("connectwise_control_site_field", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? ConnectWiseControlSiteField { get; set; }

    [JsonProperty("connectwisecontroltoplevel", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? ConnectWiseControlTopLevel { get; set; }

    [JsonProperty("connectwise_control_asset_type_field", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? ConnectWiseControlAssetTypeField { get; set; }

    [JsonProperty("connectwisecontrolassetdefaultsite", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? ConnectWiseControlAssetDefaultSite { get; set; }

    [JsonProperty("connectwisecontrol_delete_devices", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? ConnectWiseControlDeleteDevices { get; set; }

    [JsonProperty("connectwisecontrolimportentities", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public string? ConnectWiseControlImportEntities { get; set; }

    [JsonProperty("connectwisecontrol_defaultassettype", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? ConnectWiseControlDefaultAssetType { get; set; }

    [JsonProperty("showagentuserfieldsportal", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowAgentUserFieldPortal { get; set; }

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
    public int? BulkSlaChange { get; set; }

    [JsonProperty("assetshowsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AssetShowSite { get; set; }

    [JsonProperty("assetshowkeyfield1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AssetShowKeyField1 { get; set; }

    [JsonProperty("assetshowkeyfield2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AssetShowKeyField2 { get; set; }

    [JsonProperty("assetshowkeyfield3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AssetShowKeyField3 { get; set; }

    [JsonProperty("showopenjourneysintodo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowOpenJourneysInTodo { get; set; }

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
    public int? CreateProRataNormalLines { get; set; }

    [JsonProperty("enablekbfulltextsearch", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? EnableKbFullTextSearch { get; set; }

    [JsonProperty("roadmapcategory", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RoadmapCategory { get; set; }

    [JsonProperty("site_override_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SiteOverrideType { get; set; }

    [JsonProperty("defaultcostperweight", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? DefaultCostPerWeight { get; set; }

    [JsonProperty("defaultpdftemplatekb", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultPdfTemplateKb { get; set; }

    [JsonProperty("show_siteselect_client", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowSiteSelectClient { get; set; }

    [JsonProperty("enableinvoiceapprovals", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? EnableInvoiceApprovals { get; set; }

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
    public int? DecimalPlacesForInvoices { get; set; }

    [JsonProperty("createproratainvoicesautomatically", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? CreateProRataInvoicesAutomatically { get; set; }

    [JsonProperty("restrict_items_on_po_by_supplier", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? RestrictItemsOnPoBySupplier { get; set; }

    [JsonProperty("intacctdefaultloctype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? IntacctDefaultLocType { get; set; }

    [JsonProperty("tabnametype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TabNameType { get; set; }

    [JsonProperty("calcincminprojectlevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CalcIncMinProjectLevel { get; set; }

    [JsonProperty("etilizelocale", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EtilizeLocale { get; set; }

    [JsonProperty("etilizecatalog", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EtilizeCatalog { get; set; }

    [JsonProperty("b2cazuretenantid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? B2CAzureTenantId { get; set; }

    [JsonProperty("b2cazuressoappid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? B2CAzureSsoAppId { get; set; }

    [JsonProperty("b2cenableazuresinglesignon", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? B2CEnableAzureSingleSignOn { get; set; }

    [JsonProperty("b2cazureadsso", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? B2CAzureAdSso { get; set; }

    [JsonProperty("b2cazure_auto_create_users", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? B2CAzureAutoCreateUsers { get; set; }

    [JsonProperty("b2cazure_auto_creation_site", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? B2CAzureAutoCreationSite { get; set; }

    [JsonProperty("b2cazureautoredirect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? B2CAzureAutoRedirect { get; set; }

    [JsonProperty("po_CC_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PoCcAddress { get; set; }

    [JsonProperty("po_BCC_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PoBccAddress { get; set; }

    [JsonProperty("mandatoryapprovecomment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? MandatoryApproveComment { get; set; }

    [JsonProperty("exchange_appointment_sync_end_date", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? ExchangeAppointmentSyncEndDate { get; set; }

    [JsonProperty("forwardagentfollower", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ForwardAgentFollower { get; set; }

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