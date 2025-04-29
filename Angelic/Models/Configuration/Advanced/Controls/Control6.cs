using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Advanced.Controls;

public partial class Control
{
    [JsonProperty("qbocountry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Qbocountry { get; set; } 

        [JsonProperty("qbodefaultitemcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? QboDefaultitemcode { get; set; } 

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
        public string? CentrifyClientId { get; set; } 

        [JsonProperty("centrify_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CentrifyUrl { get; set; } 

        [JsonProperty("centrify_applicationid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CentrifyApplicationId { get; set; } 

        [JsonProperty("centrify_ssotype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CentrifySsotype { get; set; } 

        [JsonProperty("centrify_autoredirect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? CentrifyAutoRedirect { get; set; } 

        [JsonProperty("hide2fadontshowagain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hide2Fadontshowagain { get; set; } 

        [JsonProperty("choosedefaultcontractfrombillingdescription", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Choosedefaultcontractfrombillingdescription { get; set; } 

        [JsonProperty("enablearticlesuggestionsoneup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableArticlesuggestionsoneup { get; set; } 

        [JsonProperty("allowsitesassetseup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allowsitesassetseup { get; set; } 

        [JsonProperty("ruletickettypemandatory", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ruletickettypemandatory { get; set; } 

        [JsonProperty("enablekbarticleversioning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enablekbarticleversioning { get; set; } 

        [JsonProperty("useagentdefaultrateonlogtime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Useagentdefaultrateonlogtime { get; set; } 

        [JsonProperty("autogenerate_accountsid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutogenerateAccountsId { get; set; } 

        [JsonProperty("item_default_sales_nominal_code_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ItemDefaultSalesNominalCodeId { get; set; } 

        [JsonProperty("item_default_purchase_nominal_code_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ItemDefaultPurchaseNominalCodeId { get; set; } 

        [JsonProperty("item_default_asset_account_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ItemDefaultAssetAccountId { get; set; } 

        [JsonProperty("show_accounts_success_message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowAccountsSuccessMessage { get; set; } 

        [JsonProperty("donotalloweditingpostedinvoices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DoNotAlloweditingpostedinvoices { get; set; } 

        [JsonProperty("enablekbreview", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enablekbreview { get; set; } 

        [JsonProperty("defaultnumberofdaysbetweenkbreviews", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultNumberofdaysbetweenkbreviews { get; set; } 

        [JsonProperty("trackkbsearches", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Trackkbsearches { get; set; } 

        [JsonProperty("createemailactionsviawebapp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Createemailactionsviawebapp { get; set; } 

        [JsonProperty("portalhomescreenservicedisplaytype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PortalHomescreenservicedisplaytype { get; set; } 

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
        public string? SalesOrderlinedescriptionwhencreatedfromquotation { get; set; } 

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
        public string? DattoClientId { get; set; } 

        [JsonProperty("invoicecsvlocation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? InvoiceCsvlocation { get; set; } 

        [JsonProperty("svsearchmode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Svsearchmode { get; set; } 

        [JsonProperty("defaultcurrencycode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultCurrencycode { get; set; } 

        [JsonProperty("sendfollowernotifications", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sendfollowernotifications { get; set; } 

        [JsonProperty("matchemailsonsubjectandfrom", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Matchemailsonsubjectandfrom { get; set; } 

        [JsonProperty("myfollowertickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Myfollowertickets { get; set; } 

        [JsonProperty("mandatoryrejectcomment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Mandatoryrejectcomment { get; set; } 

        [JsonProperty("kaseya_toplevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? KaseyaTopLevel { get; set; } 

        [JsonProperty("googlenewmethod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Googlenewmethod { get; set; } 

        [JsonProperty("integrationuserbatch", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Integrationuserbatch { get; set; } 

        [JsonProperty("serviceaddsareanote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Serviceaddsareanote { get; set; } 

        [JsonProperty("linkcallstoexistingtickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Linkcallstoexistingtickets { get; set; } 

        [JsonProperty("showpopupforvip", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowPopupforvip { get; set; } 

        [JsonProperty("hidesiteoncontract", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HideSiteoncontract { get; set; } 

        [JsonProperty("removezeroquantitylines", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Removezeroquantitylines { get; set; } 

        [JsonProperty("showkbviewsinuseractivity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowKbviewsinuseractivity { get; set; } 

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
        public int? DefaultConsigmentuser { get; set; } 

        [JsonProperty("show_timezone_input", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowTimeZoneInput { get; set; } 

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
        public bool? TrustpilotAutoReply { get; set; } 

        [JsonProperty("trustpilot_autoreplythreshold", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TrustpilotAutoReplythreshold { get; set; } 

        [JsonProperty("trustpilot_enablesurveys", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? TrustpilotEnablesurveys { get; set; } 

        [JsonProperty("trustpilot_defaultusersite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TrustpilotDefaultUsersite { get; set; } 

        [JsonProperty("trustpilot_statusafterupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TrustpilotStatusafterupdate { get; set; } 

        [JsonProperty("xero_default_creditnote_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? XeroDefaultCreditnoteStatus { get; set; } 

        [JsonProperty("xero_default_creditnote_line_tax", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? XeroDefaultCreditnoteLineTax { get; set; } 

        [JsonProperty("enablehighcontrastportal", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enablehighcontrastportal { get; set; } 

        [JsonProperty("datepickermodal", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DatePickermodal { get; set; } 

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
        public bool? SyncInvoiceToAccountsPackageWhenApproved { get; set; } 

        [JsonProperty("syncpotoaccountspackagewhenapproved", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SyncPoToAccountsPackageWhenApproved { get; set; } 

        [JsonProperty("allowusereditoptionallines", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowUsereditoptionallines { get; set; } 

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
        public bool? EnableAgentreactions { get; set; } 

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
        public bool? ShowBillingPlanTextOnTicket { get; set; } 

        [JsonProperty("itquoter_application_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ItquoterApplicationUrl { get; set; } 

        [JsonProperty("itquoter_view_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ItquoterViewUrl { get; set; } 

        [JsonProperty("many_to_many_related_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ManyToManyRelatedTickets { get; set; } 

        [JsonProperty("enabletsapprovals", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableTsapprovals { get; set; } 

        [JsonProperty("logic_monitor_cleared_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LogicMonitorClearedStatus { get; set; } 

        [JsonProperty("prometheus_defaultsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PrometheusDefaultSite { get; set; } 

        [JsonProperty("prometheus_asset_type_choice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PrometheusAssetTypeChoice { get; set; } 

        [JsonProperty("prometheus_defaultassettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PrometheusDefaultAssettype { get; set; } 

        [JsonProperty("prometheus_assettypefield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PrometheusAssetTypefield { get; set; } 

        [JsonProperty("prometheus_defaultgroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PrometheusDefaultGroup { get; set; } 

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
        public int? NewAgentApptsync { get; set; } 

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
        public int? WordpressDefaultFaqList { get; set; } 

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
        public string? ItGlueImportList { get; set; } 

        [JsonProperty("itglue_import_types", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? ItGlueImportTypes { get; set; } 

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
        public bool? SyncServiceNowAttachments { get; set; } 

        [JsonProperty("ninja_import_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NinjaImportList { get; set; } 

        [JsonProperty("ninja_import_types", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? NinjaImportTypes { get; set; } 

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
        public int? DefaultViewAssetsSelectedId { get; set; } 

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
        public bool? ShowSeperateresolutionandfixbars { get; set; } 

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
        public int? DefaultSalesOrderStatus { get; set; } 

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
        public int? WordpressorgDefaultFaqList { get; set; } 

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
        public int? GocardlessDefaultSite { get; set; } 

        [JsonProperty("gocardless_use_sandbox", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? GocardlessUseSandbox { get; set; } 

        [JsonProperty("show_lang_navbar", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowLangNavbar { get; set; } 

        [JsonProperty("sync_salesforce_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SyncSalesforceStatus { get; set; } 

        [JsonProperty("agreement_default_billing_period", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AgreementDefaultBillingPeriod { get; set; } 

}