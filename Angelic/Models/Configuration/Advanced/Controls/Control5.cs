using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Advanced.Controls;

public partial class Control
{
    [JsonProperty("default_site_opps", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultSiteOpps { get; set; } 

        [JsonProperty("default_clientsite_name_opps", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultClientSiteNameOpps { get; set; } 

        [JsonProperty("newuseremailmandatory", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Newuseremailmandatory { get; set; } 

        [JsonProperty("newuserphonemandatory", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Newuserphonemandatory { get; set; } 

        [JsonProperty("callusenewreqscreen", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Callusenewreqscreen { get; set; } 

        [JsonProperty("hiderespondbutton", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HideRespondButton { get; set; } 

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
        public bool? SendAttachmentsfromdb { get; set; } 

        [JsonProperty("emailsizelimitmb", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Emailsizelimitmb { get; set; } 

        [JsonProperty("enableroadmap", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableRoadmap { get; set; } 

        [JsonProperty("useoohack", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Useoohack { get; set; } 

        [JsonProperty("oncallunum", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Oncallunum { get; set; } 

        [JsonProperty("informoutofhdworkinghours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Informoutofhdworkinghours { get; set; } 

        [JsonProperty("allowsiteoverride", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allowsiteoverride { get; set; } 

        [JsonProperty("shownewrequsersearch", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowNewrequsersearch { get; set; } 

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
        public bool? EnableTicketcaching { get; set; } 

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
        public string? SlaHoldcolour { get; set; } 

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
        public bool? ShowFeedbackpopups { get; set; } 

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
        public bool? ShowXlsExportButton { get; set; } 

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
        public bool? SendAcknowledgementemailstotoaddresses { get; set; } 

        [JsonProperty("agentlinkedusermanagementenabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Agentlinkedusermanagementenabled { get; set; } 

        [JsonProperty("salesforce_tickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SalesforceTicketType { get; set; } 

        [JsonProperty("salesforce_tickettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? SalesforceTicketTypeGuid { get; set; } 

        [JsonProperty("clientimportidentifier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Clientimportidentifier { get; set; } 

        [JsonProperty("siteimportidentifier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SiteImportidentifier { get; set; } 

        [JsonProperty("userimportidentifier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Userimportidentifier { get; set; } 

        [JsonProperty("assetimportidentifier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AssetImportIdentifier { get; set; } 

        [JsonProperty("assetimportidentifier_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? AssetImportIdentifierGuid { get; set; } 

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
        public bool? EnableAzuresinglesignon { get; set; } 

        [JsonProperty("azureautoredirect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Azureautoredirect { get; set; } 

        [JsonProperty("azureautoredirectuser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Azureautoredirectuser { get; set; } 

        [JsonProperty("useiconsforactionbuttonsmobile", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Useiconsforactionbuttonsmobile { get; set; } 

        [JsonProperty("updatebillingfieldsonchange", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Updatebillingfieldsonchange { get; set; } 

        [JsonProperty("showservicecataloglink", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowServicecataloglink { get; set; } 

        [JsonProperty("showmyservices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowMyservices { get; set; } 

        [JsonProperty("servicerequestrtid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ServiceRequestrtid { get; set; } 

        [JsonProperty("servicerequestrtid_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? ServiceRequestrtidGuid { get; set; } 

        [JsonProperty("serviceincidentrtid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Serviceincidentrtid { get; set; } 

        [JsonProperty("servicedefaultok", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ServiceDefaultOk { get; set; } 

        [JsonProperty("servicedefaultfault", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ServiceDefaultFault { get; set; } 

        [JsonProperty("servicedefaultmaintenance", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ServiceDefaultMaintenance { get; set; } 

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
        public bool? ShowItilselection { get; set; } 

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
        public bool? ShowUsersitecustomernotesonticketdetails { get; set; } 

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
        public int? DefaultRemotesessionuserid { get; set; } 

        [JsonProperty("azurecreatesites", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Azurecreatesites { get; set; } 

        [JsonProperty("remotesession_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? RemotesessionUsername { get; set; } 

        [JsonProperty("allowquickinvites", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allowquickinvites { get; set; } 

        [JsonProperty("periodichistorydate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? PeriodIchistorydate { get; set; } 

        [JsonProperty("adminsskippendingclosure", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Adminsskippendingclosure { get; set; } 

        [JsonProperty("timelinedaysspanthreshold", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Timelinedaysspanthreshold { get; set; } 

        [JsonProperty("timelinelineheight", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Timelinelineheight { get; set; } 

        [JsonProperty("usenewportal", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Usenewportal { get; set; } 

        [JsonProperty("portalshowworkflow", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? PortalShowworkflow { get; set; } 

        [JsonProperty("portalshowawaitinginput", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? PortalShowawaitinginput { get; set; } 

        [JsonProperty("webdashboardtitle", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Webdashboardtitle { get; set; } 

        [JsonProperty("sage200version", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sage200Version { get; set; } 

        [JsonProperty("sage200toplevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sage200TopLevel { get; set; } 

        [JsonProperty("sage200tenantid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sage200TenantId { get; set; } 

        [JsonProperty("sage200companyid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sage200Companyid { get; set; } 

        [JsonProperty("sage200itemgroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sage200ItemGroup { get; set; } 

        [JsonProperty("sage200companyname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sage200CompanyName { get; set; } 

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
        public bool? PortalHomeshowkbsearch { get; set; } 

        [JsonProperty("searchkbbyid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Searchkbbyid { get; set; } 

        [JsonProperty("portalhomeshowfeed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? PortalHomeshowfeed { get; set; } 

        [JsonProperty("portalhomeshowtoparticles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? PortalHomeshowtoparticles { get; set; } 

        [JsonProperty("portalhomeshownewsarticles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? PortalHomeshownewsarticles { get; set; } 

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
        public bool? HideAssetsystemfieldstatus { get; set; } 

        [JsonProperty("sendmultiplenotifications", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sendmultiplenotifications { get; set; } 

        [JsonProperty("allnotificationoverridessections", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allnotificationoverridessections { get; set; } 

        [JsonProperty("sendnotificationemailforrtbcc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sendnotificationemailforrtbcc { get; set; } 

        [JsonProperty("defaultpdftemplatequote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultPdfTemplateQuote { get; set; } 

        [JsonProperty("defaultcurrency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultCurrency { get; set; } 

        [JsonProperty("pagerdutydefaultagent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Pagerdutydefaultagent { get; set; } 

        [JsonProperty("useareasfornewbtn", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Useareasfornewbtn { get; set; } 

        [JsonProperty("showservicecataloguebuttonnewticket", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowServicecataloguebuttonnewticket { get; set; } 

        [JsonProperty("showincidentcataloguebuttonnewticket", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowIncidentcataloguebuttonnewticket { get; set; } 

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
        public bool? NinjaRmmmatchname { get; set; } 

        [JsonProperty("ninjarmmlocation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NinjaRmmlocation { get; set; } 

        [JsonProperty("ninjarmmdefaultgroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NinjaRmmdefaultgroup { get; set; } 

        [JsonProperty("ninjarmmdefaultgroup_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? NinjaRmmdefaultgroupGuid { get; set; } 

        [JsonProperty("ninjarmmimporttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NinjaRmmimporttype { get; set; } 

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
        public int? DefaultPdfTemplatepo { get; set; } 

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
        public int? DefaultPdfTemplateso { get; set; } 

        [JsonProperty("defaultpdftemplatefault", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultPdfTemplatefault { get; set; } 

        [JsonProperty("sendwindowsappprintrequestonclose", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sendwindowsappprintrequestonclose { get; set; } 

        [JsonProperty("defaultpdftemplateinvoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultPdfTemplateInvoice { get; set; } 

        [JsonProperty("defaultpdftemplatecontract", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultPdfTemplatecontract { get; set; } 

        [JsonProperty("defaultpdftemplatereport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultPdfTemplatereport { get; set; } 

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
        public bool? DoSearchOnAddress { get; set; } 

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

        [JsonProperty("defaultSiteTimeZone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultSiteTimeZone { get; set; } 

        [JsonProperty("toggleAnnouncementIconOff", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ToggleAnnouncementIconOff { get; set; } 

        [JsonProperty("donotsendfolloweremails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DoNotsendfolloweremails { get; set; } 

        [JsonProperty("donotusedynamiclistsforresponse", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DoNotUsedynamiclistsforresponse { get; set; } 

        [JsonProperty("prepaybalancethresholdperc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? PrepayBalancethresholdperc { get; set; } 

        [JsonProperty("prepaybalancethresholdupper", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? PrepayBalancethresholdupper { get; set; } 

        [JsonProperty("allow_anonymous_approvals", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowAnonymousApprovals { get; set; } 

        [JsonProperty("ncentralurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NCentralurl { get; set; } 

        [JsonProperty("ncentral_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NCentralUsername { get; set; } 

        [JsonProperty("ncentraltoplevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NCentraltoplevel { get; set; } 

        [JsonProperty("ncentralmatchname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? NCentralmatchname { get; set; } 

        [JsonProperty("ncentraldefaultgroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NCentraldefaultgroup { get; set; } 

        [JsonProperty("ncentralimporttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NCentralimporttype { get; set; } 

        [JsonProperty("nableticketingusername", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NAbleticketingusername { get; set; } 

        [JsonProperty("ncentral_tickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NCentralTicketType { get; set; } 

        [JsonProperty("ncentral_tickettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? NCentralTicketTypeGuid { get; set; } 

        [JsonProperty("ncentraluser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NCentraluser { get; set; } 

        [JsonProperty("ncentral_alerttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NCentralAlerttype { get; set; } 

        [JsonProperty("defaultincludegroupeditemqty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DefaultIncludeGroupeditemqty { get; set; } 

        [JsonProperty("defaultincludegroupeditemprice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DefaultIncludeGroupeditemprice { get; set; } 

        [JsonProperty("defaultincludegrouppriceandqty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DefaultIncludeGrouppriceandqty { get; set; } 

        [JsonProperty("callscreenallownewclientcreation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Callscreenallownewclientcreation { get; set; } 

        [JsonProperty("nextcontractref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NextContractref { get; set; } 

        [JsonProperty("displaycategorynoteondetailscreen", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Displaycategorynoteondetailscreen { get; set; } 

        [JsonProperty("autocreaterecurringinvoices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Autocreaterecurringinvoices { get; set; } 

        [JsonProperty("syncholidays", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SyncHolidays { get; set; } 

        [JsonProperty("hideadhocitem", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HideAdhocitem { get; set; } 

        [JsonProperty("enablekbmatchingforallitiltypes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enablekbmatchingforallitiltypes { get; set; } 

        [JsonProperty("allowuserapprovaldelegation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowUserapprovaldelegation { get; set; } 

        [JsonProperty("fixedassettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Fixedassettype { get; set; } 

        [JsonProperty("fixedassettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? FixedassettypeGuid { get; set; } 

        [JsonProperty("businesscentral_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? BusinessCentralSite { get; set; } 

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
        public bool? EnableTemplatesuggestions { get; set; } 

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
        public bool? HideFeedback { get; set; } 

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
}