using Newtonsoft.Json;

namespace Angelic.Configuration.Advanced.Controls;

public partial class Control
{
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
        public int? AteraDefaultSite { get; set; } 

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
        public int? JamfDefaultSite { get; set; } 

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
        public int? SyncroDefaultSite { get; set; } 

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
}