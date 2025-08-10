using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Advanced.Controls;

public partial class Control
{
    [JsonProperty("default_site_opps", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultSiteOpps { get; set; } 

        [JsonProperty("default_clientsite_name_opps", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultClientSiteNameOpps { get; set; } 

        [JsonProperty("newuseremailmandatory", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? NewUserEmailMandatory { get; set; } 

        [JsonProperty("newuserphonemandatory", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? NewUserPhoneMandatory { get; set; } 

        [JsonProperty("callusenewreqscreen", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? CallUseNewReqScreen { get; set; } 

        [JsonProperty("hiderespondbutton", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HideRespondButton { get; set; } 

        [JsonProperty("timertype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TimerType { get; set; } 

        [JsonProperty("movesectiononrespond", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? MoveSectionOnRespond { get; set; } 

        [JsonProperty("cleanhtmlpasting", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? CleanHtmlPasting { get; set; } 

        [JsonProperty("taskscompleteallowclosure", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? TasksCompleteAllowClosure { get; set; } 

        [JsonProperty("mustassigntoclose", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? MustAssignToClose { get; set; } 

        [JsonProperty("allowclosureatunknownclient", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowClosureAtUnknownClient { get; set; } 

        [JsonProperty("alloweditonemailpreview", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowEditOnEmailPreview { get; set; } 

        [JsonProperty("sendattachmentsfromdb", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SendAttachmentsFromDb { get; set; } 

        [JsonProperty("emailsizelimitmb", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? EmailSizeLimitMb { get; set; } 

        [JsonProperty("enableroadmap", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableRoadmap { get; set; } 

        [JsonProperty("useoohack", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseOoHack { get; set; } 

        [JsonProperty("oncallunum", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? OnCallUnum { get; set; } 

        [JsonProperty("informoutofhdworkinghours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? InformOutOfHdWorkingHours { get; set; } 

        [JsonProperty("allowsiteoverride", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowSiteOverride { get; set; } 

        [JsonProperty("shownewrequsersearch", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowNewReqUserSearch { get; set; } 

        [JsonProperty("allowquicksiteadd", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowQuickSiteAdd { get; set; } 

        [JsonProperty("showcontractcoloursonassetchoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowContractColoursOnAssetChoice { get; set; } 

        [JsonProperty("assetundercontractifcontractnotstarted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AssetUnderContractIfContractNotStarted { get; set; } 

        [JsonProperty("selectfaqlistbeforesearch", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SelectFaqListBeforeSearch { get; set; } 

        [JsonProperty("selecttickettypebeforesearch", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SelectTicketTypeBeforeSearch { get; set; } 

        [JsonProperty("usetickettypegroups", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseTicketTypeGroups { get; set; } 

        [JsonProperty("userelativedates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseRelativeDates { get; set; } 

        [JsonProperty("enableticketcaching", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableTicketCaching { get; set; } 

        [JsonProperty("allowemailsubjectedit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowEmailSubjectEdit { get; set; } 

        [JsonProperty("recurringitembillingdescription", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? RecurringItemBillingDescription { get; set; } 

        [JsonProperty("mileagechargerate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MileageChargeRate { get; set; } 

        [JsonProperty("traveltimechargerate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TravelTimeChargeRate { get; set; } 

        [JsonProperty("ticketinvoices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? TicketInvoices { get; set; } 

        [JsonProperty("ticketasaccountsinvno", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? TicketAsAccountsInvNo { get; set; } 

        [JsonProperty("useassetcontractforbilling", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseAssetContractForBilling { get; set; } 

        [JsonProperty("enablenetworkconnectioncheck", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableNetworkConnectionCheck { get; set; } 

        [JsonProperty("useassetsonlytocalculatecontractvalue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseAssetsOnlyToCalculateContractValue { get; set; } 

        [JsonProperty("showassetlinesoncontractinvoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowAssetLinesOnContractInvoice { get; set; } 

        [JsonProperty("showassetvalueoninvoiceline", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowAssetValueOnInvoiceLine { get; set; } 

        [JsonProperty("assetlinesbillingdesc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AssetLinesBillingDesc { get; set; } 

        [JsonProperty("slaholdcolour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SlaHoldColour { get; set; } 

        [JsonProperty("pagesize", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PageSize { get; set; } 

        [JsonProperty("onlyusetimersonactionswithtimetaken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Onlyusetimersonactionswithtimetaken { get; set; } 

        [JsonProperty("use24hrclock", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Use24HrClock { get; set; } 

        [JsonProperty("usecannedtextprediction", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseCannedTextPrediction { get; set; } 

        [JsonProperty("usefreetexttable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? UseFreetextTable { get; set; } 

        [JsonProperty("usereadonlydbstring", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseReadonlyDbString { get; set; } 

        [JsonProperty("appointmentinvitetype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AppointmentInviteType { get; set; } 

        [JsonProperty("feedbackhigh", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? FeedbackHigh { get; set; } 

        [JsonProperty("feedbacklow", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? FeedbackLow { get; set; } 

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
        public bool? ShowFeedbackPopups { get; set; } 

        [JsonProperty("feedbackrecordtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? FeedbackRecordType { get; set; } 

        [JsonProperty("ssologin", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SsoLogin { get; set; } 

        [JsonProperty("ssologout", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SsoLogout { get; set; } 

        [JsonProperty("ssofingerprint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SsoFingerprint { get; set; } 

        [JsonProperty("ssoautoredirect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SsoAutoRedirect { get; set; } 

        [JsonProperty("allownhdsupport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowNhdSupport { get; set; } 

        [JsonProperty("showxlsexportbutton", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowXlsExportButton { get; set; } 

        [JsonProperty("showcsvexportbutton", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowCsvExportButton { get; set; } 

        [JsonProperty("allowticketmerging", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowTicketMerging { get; set; } 

        [JsonProperty("enablesap", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableSap { get; set; } 

        [JsonProperty("bugzillabugurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? BugzillaBugUrl { get; set; } 

        [JsonProperty("enablecontinuum", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableContinuum { get; set; } 

        [JsonProperty("showticketsearchonmerge", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowTicketSearchOnMerge { get; set; } 

        [JsonProperty("apptexchangetype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ApptExchangeType { get; set; } 

        [JsonProperty("apptadminuser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ApptAdminUser { get; set; } 

        [JsonProperty("ewsserverversion", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? EwsServerVersion { get; set; } 

        [JsonProperty("onlyshowmyteamsintree", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? OnlyShowMyTeamsInTree { get; set; } 

        [JsonProperty("nhserverversion", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? NhServerVersion { get; set; } 

        [JsonProperty("usetreeforcat", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseTreeForCat { get; set; } 

        [JsonProperty("setupstepscompleted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SetupStepsCompleted { get; set; } 

        [JsonProperty("enablefacebook", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableFacebook { get; set; } 

        [JsonProperty("itemmarkuppercdefault", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? ItemMarkUppercDefault { get; set; } 

        [JsonProperty("quoteexpirydays", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? QuoteExpiryDays { get; set; } 

        [JsonProperty("vatmethod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? VatMethod { get; set; } 

        [JsonProperty("2faemailallowed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? TwoFaEmailAllowed { get; set; } 

        [JsonProperty("2fasmsallowed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? TwoFaSmsAllowed { get; set; } 

        [JsonProperty("2faauthenticatorallowed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? TwoFaAuthenticatorAllowed { get; set; } 

        [JsonProperty("callscreencallscript", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CallScreenCallScript { get; set; } 

        [JsonProperty("showticketattachmenticon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowTicketAttachmentIcon { get; set; } 

        [JsonProperty("shownoapproverspopup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowNoApproversPopup { get; set; } 

        [JsonProperty("listagentuserfirst", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ListAgentUserFirst { get; set; } 

        [JsonProperty("quicktimeusermandatory", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? QuickTimeUserMandatory { get; set; }

        [JsonProperty("enablepowershell", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnablePowershell { get; set; } 

        [JsonProperty("sendacknowledgementemailstotoaddresses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SendAcknowledgementEmailsToToAddresses { get; set; } 

        [JsonProperty("agentlinkedusermanagementenabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AgentLinkedUserManagementEnabled { get; set; } 

        [JsonProperty("salesforce_tickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SalesforceTicketType { get; set; } 

        [JsonProperty("salesforce_tickettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? SalesforceTicketTypeGuid { get; set; } 

        [JsonProperty("clientimportidentifier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ClientImportIdentifier { get; set; } 

        [JsonProperty("siteimportidentifier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SiteImportIdentifier { get; set; } 

        [JsonProperty("userimportidentifier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? UserImportIdentifier { get; set; } 

        [JsonProperty("assetimportidentifier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AssetImportIdentifier { get; set; } 

        [JsonProperty("assetimportidentifier_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? AssetImportIdentifierGuid { get; set; } 

        [JsonProperty("supplierimportidentifier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SupplierImportIdentifier { get; set; } 

        [JsonProperty("itemimportidentifier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ItemImportIdentifier { get; set; } 

        [JsonProperty("assettypeimportidentifier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AssetTypeImportIdentifier { get; set; } 

        [JsonProperty("enableonlinepresence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableOnlinePresence { get; set; } 

        [JsonProperty("mainrefreshinterval", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? MainRefreshInterval { get; set; } 

        [JsonProperty("usecallplan", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseCallPlan { get; set; } 

        [JsonProperty("importazuredomain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ImportAzureDomain { get; set; } 

        [JsonProperty("importazureappid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ImportAzureAppId { get; set; } 

        [JsonProperty("importazuresite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ImportAzureSite { get; set; } 

        [JsonProperty("importazuresite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ImportAzureSiteName { get; set; } 

        [JsonProperty("azureuserfilter", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AzureUserFilter { get; set; } 

        [JsonProperty("importazuresitefield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ImportAzureSiteField { get; set; } 

        [JsonProperty("enableazuresinglesignon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableAzureSingleSignOn { get; set; } 

        [JsonProperty("azureautoredirect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AzureAutoRedirect { get; set; } 

        [JsonProperty("azureautoredirectuser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AzureAutoRedirectUser { get; set; } 

        [JsonProperty("useiconsforactionbuttonsmobile", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseIconsForActionButtonsMobile { get; set; } 

        [JsonProperty("updatebillingfieldsonchange", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UpdateBillingFieldsOnChange { get; set; } 

        [JsonProperty("showservicecataloglink", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowServiceCatalogLink { get; set; } 

        [JsonProperty("showmyservices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowMyServices { get; set; } 

        [JsonProperty("servicerequestrtid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ServiceRequestRtId { get; set; } 

        [JsonProperty("servicerequestrtid_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? ServiceRequestRtIdGuid { get; set; } 

        [JsonProperty("serviceincidentrtid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ServiceIncidentRtId { get; set; } 

        [JsonProperty("servicedefaultok", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ServiceDefaultOk { get; set; } 

        [JsonProperty("servicedefaultfault", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ServiceDefaultFault { get; set; } 

        [JsonProperty("servicedefaultmaintenance", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ServiceDefaultMaintenance { get; set; } 

        [JsonProperty("servicefailurert", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ServiceFailureRt { get; set; } 

        [JsonProperty("dynamicscrmdefaultsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DynamicsCrmDefaultSite { get; set; } 

        [JsonProperty("DefaultCustomerSiteUserView", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultCustomerSiteUserView { get; set; } 

        [JsonProperty("DefaultServiceAccessLevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultServiceAccessLevel { get; set; } 

        [JsonProperty("pagerdutydefrequesttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PagerDutyDefRequestType { get; set; } 

        [JsonProperty("pagerdutydefrequesttype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? PagerDutyDefRequestTypeGuid { get; set; } 

        [JsonProperty("pagerdutyaccount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PagerDutyAccount { get; set; } 

        [JsonProperty("pagerdutyservicekey", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PagerDutyServiceKey { get; set; } 

        [JsonProperty("pagerdutyservicename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PagerDutyServiceName { get; set; } 

        [JsonProperty("pagerdutysourcefield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PagerDutySourceField { get; set; } 

        [JsonProperty("showitilselection", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowItilSelection { get; set; } 

        [JsonProperty("splunk_tickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SplunkTicketType { get; set; } 

        [JsonProperty("splunk_tickettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? SplunkTicketTypeGuid { get; set; } 

        [JsonProperty("splunkuser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SplunkUser { get; set; } 

        [JsonProperty("enableoktasinglesignon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableOktaSingleSignOn { get; set; } 

        [JsonProperty("okta_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OktaUrl { get; set; } 

        [JsonProperty("okta_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OktaClientId { get; set; } 

        [JsonProperty("oktaautoredirect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? OktaAutoRedirect { get; set; } 

        [JsonProperty("salesforcedefaultsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SalesforceDefaultSite { get; set; } 

        [JsonProperty("salesforceuserfield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SalesforceUserField { get; set; } 

        [JsonProperty("salesforcedefaultsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SalesforceDefaultSiteName { get; set; } 

        [JsonProperty("usestatuscolouroncalendar", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseStatusColourOnCalendar { get; set; } 

        [JsonProperty("timelinestepinterval", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TimelineStepInterval { get; set; } 

        [JsonProperty("azuressoappid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AzureSsoAppId { get; set; } 

        [JsonProperty("azuretenantid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AzureTenantId { get; set; } 

        [JsonProperty("smtpusethismailboxid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SmtpUseThisMailboxId { get; set; } 

        [JsonProperty("usedaysforprojectbudgets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseDaysForProjectBudgets { get; set; } 

        [JsonProperty("hoursperday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? HoursPerDay { get; set; } 

        [JsonProperty("reopenticketstech", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ReopenTicketsTech { get; set; } 

        [JsonProperty("showusersitecustomernotesonticketdetails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowUserSiteCustomerNotesOnTicketDetails { get; set; } 

        [JsonProperty("lmirescueusername", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? LmiRescueUsername { get; set; } 

        [JsonProperty("expandtimelineitemtofillblock", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ExpandTimeLineItemToFillBlock { get; set; } 

        [JsonProperty("rtimezone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? RTimezone { get; set; } 

        [JsonProperty("sameclientmergeonly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SameClientMergeOnly { get; set; } 

        [JsonProperty("lmichannelurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? LmiChannelUrl { get; set; } 

        [JsonProperty("lmiallowothertechinvites", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? LmiAllowOtherTechInvites { get; set; } 

        [JsonProperty("lmichannelname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? LmiChannelName { get; set; } 

        [JsonProperty("defaultremotesessionuserid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultRemoteSessionUserId { get; set; } 

        [JsonProperty("azurecreatesites", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AzureCreateSites { get; set; } 

        [JsonProperty("remotesession_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? RemoteSessionUsername { get; set; } 

        [JsonProperty("allowquickinvites", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowQuickInvites { get; set; } 

        [JsonProperty("periodichistorydate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? PeriodicHistoryDate { get; set; } 

        [JsonProperty("adminsskippendingclosure", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AdminsSkipPendingClosure { get; set; } 

        [JsonProperty("timelinedaysspanthreshold", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TimelineDaySpanThreshold { get; set; } 

        [JsonProperty("timelinelineheight", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TimelineLineHeight { get; set; } 

        [JsonProperty("usenewportal", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseNewPortal { get; set; } 

        [JsonProperty("portalshowworkflow", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? PortalShowWorkflow { get; set; } 

        [JsonProperty("portalshowawaitinginput", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? PortalShowAwaitingInput { get; set; } 

        [JsonProperty("webdashboardtitle", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? WebDashboardTitle { get; set; } 

        [JsonProperty("sage200version", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sage200Version { get; set; } 

        [JsonProperty("sage200toplevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sage200TopLevel { get; set; } 

        [JsonProperty("sage200tenantid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sage200TenantId { get; set; } 

        [JsonProperty("sage200companyid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sage200CompanyId { get; set; } 

        [JsonProperty("sage200itemgroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sage200ItemGroup { get; set; } 

        [JsonProperty("sage200companyname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sage200CompanyName { get; set; } 

        [JsonProperty("usekashflow", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseKashflow { get; set; } 

        [JsonProperty("usexero", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseXero { get; set; } 

        [JsonProperty("useinvoicexml", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseInvoiceXml { get; set; } 

        [JsonProperty("useinvoicecsv", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseInvoiceCsv { get; set; } 

        [JsonProperty("usevaribill", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseVaribill { get; set; } 

        [JsonProperty("keepescmsgrecord", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? KeepEscMsgRecord { get; set; } 

        [JsonProperty("sage200token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sage200Token { get; set; } 

        [JsonProperty("sage200tokenexpiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Sage200TokenExpiry { get; set; } 

        [JsonProperty("callscreenusetimeonactions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? CallScreenUseTimeOnActions { get; set; } 

        [JsonProperty("oktasso", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? OktaSso { get; set; } 

        [JsonProperty("adfssso", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AdfsSso { get; set; } 

        [JsonProperty("azureadsso", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AzureAdSso { get; set; } 

        [JsonProperty("portalhomeshowkbsearch", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? PortalHomeShowKbSearch { get; set; } 

        [JsonProperty("searchkbbyid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SearchKbById { get; set; } 

        [JsonProperty("portalhomeshowfeed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? PortalHomeShowFeed { get; set; } 

        [JsonProperty("portalhomeshowtoparticles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? PortalHomeShowToParticles { get; set; } 

        [JsonProperty("portalhomeshownewsarticles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? PortalHomeShowNewsArticles { get; set; } 

        [JsonProperty("showapprovalsonseparatetab", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowApprovalsOnSeparateTab { get; set; } 

        [JsonProperty("pagerdutyserviceid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PagerDutyServiceId { get; set; } 

        [JsonProperty("autoswitchtodefaultremoteteam", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoSwitchToDefaultRemoteTeam { get; set; } 

        [JsonProperty("requireexternalkey", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? RequireExternalKey { get; set; } 

        [JsonProperty("change_collision_enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ChangeCollisionEnabled { get; set; } 

        [JsonProperty("cautomatedefaultsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CAutomateDefaultSite { get; set; } 

        [JsonProperty("cautomatetoplevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CAutomateTopLevel { get; set; } 

        [JsonProperty("cautomateassetdefaultsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CAutomateAssetDefaultSite { get; set; } 

        [JsonProperty("hideassetsystemfieldstatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HideAssetSystemFieldStatus { get; set; } 

        [JsonProperty("sendmultiplenotifications", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SendMultipleNotifications { get; set; } 

        [JsonProperty("allnotificationoverridessections", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllNotificationOverridesSections { get; set; } 

        [JsonProperty("sendnotificationemailforrtbcc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SendNotificationEmailForRtBcc { get; set; } 

        [JsonProperty("defaultpdftemplatequote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultPdfTemplateQuote { get; set; } 

        [JsonProperty("defaultcurrency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultCurrency { get; set; } 

        [JsonProperty("pagerdutydefaultagent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PagerDutyDefaultAgent { get; set; } 

        [JsonProperty("useareasfornewbtn", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseAreasForNewBtn { get; set; } 

        [JsonProperty("showservicecataloguebuttonnewticket", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowServiceCatalogueButtonNewTicket { get; set; } 

        [JsonProperty("showincidentcataloguebuttonnewticket", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowIncidentCatalogueButtonNewTicket { get; set; } 

        [JsonProperty("enablepasswordfieldaudit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnablePasswordFieldAudit { get; set; } 

        [JsonProperty("stopnewticketsviaemailreplywithtemplate_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? StopNewTicketsViaEmailReplyWithTemplateId { get; set; } 

        [JsonProperty("stopnewticketsviaemailreplywithtemplate_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? StopNewTicketsViaEmailReplyWithTemplateGuid { get; set; } 

        [JsonProperty("stopnewticketsviaemailreplywithtemplate_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? StopNewTicketsViaEmailReplyWithTemplateName { get; set; } 

        [JsonProperty("stopnewticketsviaemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? StopNewTicketsViaEmail { get; set; } 

        [JsonProperty("vipnoprioritychange", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? VipNoPriorityChange { get; set; } 

        [JsonProperty("svcatchoosecategoryfirst", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SvCatChooseCategoryFirst { get; set; } 

        [JsonProperty("skipresolved", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SkipResolved { get; set; } 

        [JsonProperty("ninjatoplevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NinjaTopLevel { get; set; } 

        [JsonProperty("ninjadefaultsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NinjaDefaultSite { get; set; } 

        [JsonProperty("ninjarmmmatchname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? NinjaRmmMatchName { get; set; } 

        [JsonProperty("ninjarmmlocation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NinjaRmmLocation { get; set; } 

        [JsonProperty("ninjarmmdefaultgroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NinjaRmmDefaultGroup { get; set; } 

        [JsonProperty("ninjarmmdefaultgroup_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? NinjaRmmDefaultGroupGuid { get; set; } 

        [JsonProperty("ninjarmmimporttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NinjaRmmImportType { get; set; } 

        [JsonProperty("solarwindsrmmtoplevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SolarwindsRmmTopLevel { get; set; } 

        [JsonProperty("solarwindsrmmmatchname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SolarwindsRmmMatchName { get; set; } 

        [JsonProperty("solarwindsrmmimporttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SolarwindsRmmImportType { get; set; }

        [JsonProperty("treecatforceleafselection", Required = Required.Default,
            NullValueHandling = NullValueHandling.Ignore)]
        public bool? TreeCatForceLeafSelection { get; set; } 

        [JsonProperty("contractexpirytemplate_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ContractExpiryTemplateId { get; set; } 

        [JsonProperty("contractexpirytemplate_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? ContractExpiryTemplateGuid { get; set; } 

        [JsonProperty("contractexpirytemplate_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ContractExpiryTemplateName { get; set; } 

        [JsonProperty("defaultpdftemplatepo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultPdfTemplatePo { get; set; } 

        [JsonProperty("poprefixr", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PoPrefixR { get; set; } 

        [JsonProperty("poprefixo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PoPrefixO { get; set; } 

        [JsonProperty("poprefixs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PoPrefixS { get; set; } 

        [JsonProperty("kbsearchmode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? KbSearchMode { get; set; } 

        [JsonProperty("showDateDoneOnAptCompletionScreen", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowDateDoneOnAptCompletionScreen { get; set; } 

        [JsonProperty("removeemailfromlistonuserchange", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? RemoveEmailFromListOnUserChange { get; set; } 

        [JsonProperty("defaultpdftemplateso", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultPdfTemplateSo { get; set; } 

        [JsonProperty("defaultpdftemplatefault", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultPdfTemplateFault { get; set; } 

        [JsonProperty("sendwindowsappprintrequestonclose", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SendWindowsAppPrintRequestOnClose { get; set; } 

        [JsonProperty("defaultpdftemplateinvoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultPdfTemplateInvoice { get; set; } 

        [JsonProperty("defaultpdftemplatecontract", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultPdfTemplateContract { get; set; } 

        [JsonProperty("defaultpdftemplatereport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultPdfTemplateReport { get; set; } 

        [JsonProperty("tracksoftwarechanges", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? TrackSoftwareChanges { get; set; } 

        [JsonProperty("allow_notloggedin", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowNotLoggedIn { get; set; } 

        [JsonProperty("allow_kbs_notloggedin", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowKbsNotLoggedIn { get; set; } 

        [JsonProperty("anonymoususersite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AnonymousUserSite { get; set; } 

        [JsonProperty("anonymoususersite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AnonymousUserSiteName { get; set; } 

        [JsonProperty("onlyShowApprovedChanges", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? OnlyShowApprovedChanges { get; set; } 

        [JsonProperty("dosearchonaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DoSearchOnAddress { get; set; } 

        [JsonProperty("clientMainContactCompulsary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ClientMainContactCompulsory { get; set; } 

        [JsonProperty("ignoreparentvisibilityforcustomfieldvisiblity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ignoreparentvisibilityforcustomfieldvisiblity { get; set; } 

        [JsonProperty("usescanners", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseScanners { get; set; } 

        [JsonProperty("barcodedecoder", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? BarcodeDecoder { get; set; } 

        [JsonProperty("ualluse2fa", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UAllUseTwoFa { get; set; } 

        [JsonProperty("defaultSiteTimeZone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultSiteTimeZone { get; set; } 

        [JsonProperty("toggleAnnouncementIconOff", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ToggleAnnouncementIconOff { get; set; } 

        [JsonProperty("donotsendfolloweremails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DoNotSendFollowerEmails { get; set; } 

        [JsonProperty("donotusedynamiclistsforresponse", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DoNotUseDynamicListsForResponse { get; set; } 

        [JsonProperty("prepaybalancethresholdperc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? PrepayBalanceThresholdPerc { get; set; } 

        [JsonProperty("prepaybalancethresholdupper", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? PrepayBalanceThresholdUpper { get; set; } 

        [JsonProperty("allow_anonymous_approvals", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowAnonymousApprovals { get; set; } 

        [JsonProperty("ncentralurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NCentralUrl { get; set; } 

        [JsonProperty("ncentral_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NCentralUsername { get; set; } 

        [JsonProperty("ncentraltoplevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NCentralTopLevel { get; set; } 

        [JsonProperty("ncentralmatchname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? NCentralMatchName { get; set; } 

        [JsonProperty("ncentraldefaultgroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NCentralDefaultGroup { get; set; } 

        [JsonProperty("ncentralimporttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NCentralImportType { get; set; } 

        [JsonProperty("nableticketingusername", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NAbleTicketingUsername { get; set; } 

        [JsonProperty("ncentral_tickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NCentralTicketType { get; set; } 

        [JsonProperty("ncentral_tickettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? NCentralTicketTypeGuid { get; set; } 

        [JsonProperty("ncentraluser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NCentralUser { get; set; } 

        [JsonProperty("ncentral_alerttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NCentralAlertType { get; set; } 

        [JsonProperty("defaultincludegroupeditemqty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DefaultIncludeGroupedItemQty { get; set; } 

        [JsonProperty("defaultincludegroupeditemprice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DefaultIncludeGroupedItemPrice { get; set; } 

        [JsonProperty("defaultincludegrouppriceandqty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DefaultIncludeGroupPriceAndQty { get; set; } 

        [JsonProperty("callscreenallownewclientcreation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? CallScreenAllowNewClientCreation { get; set; } 

        [JsonProperty("nextcontractref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NextContractRef { get; set; } 

        [JsonProperty("displaycategorynoteondetailscreen", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DisplayCategoryNoteOnDetailScreen { get; set; } 

        [JsonProperty("autocreaterecurringinvoices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoCreateRecurringInvoices { get; set; } 

        [JsonProperty("syncholidays", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SyncHolidays { get; set; } 

        [JsonProperty("hideadhocitem", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HideAdhocItem { get; set; } 

        [JsonProperty("enablekbmatchingforallitiltypes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableKbMatchingForAllItilTypes { get; set; } 

        [JsonProperty("allowuserapprovaldelegation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowUserApprovalDelegation { get; set; } 

        [JsonProperty("fixedassettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? FixedAssetType { get; set; } 

        [JsonProperty("fixedassettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? FixedAssetTypeGuid { get; set; } 

        [JsonProperty("businesscentral_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? BusinessCentralSite { get; set; } 

        [JsonProperty("enablebusinesscentralsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableBusinessCentralSync { get; set; } 

        [JsonProperty("timesheetstepinterval", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TimesheetStepInterval { get; set; } 

        [JsonProperty("azuressoconnectionid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AzureSsoConnectionId { get; set; } 

        [JsonProperty("azuressotenanttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AzureSsoTenantType { get; set; } 

        [JsonProperty("showapproversthatareyettovote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowApproversThatAreYetToVote { get; set; } 

        [JsonProperty("onlyinformofapprovalonfinalstep", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? OnlyInformOfApprovalOnFinalStep { get; set; } 

        [JsonProperty("alwayscheckrulesaftermerge", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AlwaysCheckRulesAfterMerge { get; set; } 

        [JsonProperty("checkruleswhenticketsubmitted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? CheckRulesWhenTicketSubmitted { get; set; } 

        [JsonProperty("storeoutgoingemails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? StoreOutgoingEmails { get; set; } 

        [JsonProperty("enabletemplatesuggestions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableTemplateSuggestions { get; set; } 

        [JsonProperty("auto_close_send_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoCloseSendEmail { get; set; } 

        [JsonProperty("portalbackgrounddisplaymode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PortalBackgroundDisplayMode { get; set; } 

        [JsonProperty("autoaddrecurringinvoiceaftercontract", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoAddRecurringInvoiceAfterContract { get; set; } 

        [JsonProperty("enableinternalticketconversations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableInternalTicketConversations { get; set; } 

        [JsonProperty("internalticketconversationtickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? InternalTicketConversationTicketType { get; set; } 

        [JsonProperty("internalticketconversationtickettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? InternalTicketConversationTicketTypeGuid { get; set; } 

        [JsonProperty("enableinternalreply", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableInternalReply { get; set; } 

        [JsonProperty("internalreplystatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? InternalReplyStatus { get; set; } 

        [JsonProperty("internalreplystatus_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? InternalReplyStatusGuid { get; set; } 

        [JsonProperty("hidefeedback", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HideFeedback { get; set; } 

        [JsonProperty("showallservicesoption", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowAllServicesOption { get; set; } 

        [JsonProperty("ordersevbyseq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? OrderSevBySeq { get; set; } 

        [JsonProperty("useworkhoursforreminders", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseWorkHoursForReminders { get; set; } 

        [JsonProperty("qborealmid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? QboRealMid { get; set; } 

        [JsonProperty("qbocompanyname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? QboCompanyName { get; set; } 

        [JsonProperty("qbotoplevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? QboTopLevel { get; set; } 

        [JsonProperty("qboserviceitemgroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? QboServiceItemGroup { get; set; } 

        [JsonProperty("qboinventoryitemgroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? QboInventoryItemGroup { get; set; } 
}