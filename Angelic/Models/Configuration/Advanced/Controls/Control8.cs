using Angelic.Models.Assets;
using Angelic.Models.Clients;
using Angelic.Models.Configuration.Assets;
using Angelic.Models.Configuration.Integrations;
using Angelic.Models.Configuration.Integrations.Google;
using Angelic.Models.Configuration.Integrations.Microsoft.Azure.AzureAd;
using Angelic.Models.Configuration.SqlImports;
using Angelic.Models.Configuration.TeamsAndAgents;
using Angelic.Models.Configuration.TeamsAndAgents.Workdays;
using Angelic.Models.Configuration.Tickets;
using Angelic.Models.Configuration.Users;
using Angelic.Models.Contracts;
using Angelic.Models.KeyPairs;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Advanced.Controls;

public partial class Control
{
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
        public bool? EnableEmailThreading { get; set; } 

        [JsonProperty("att_item_group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AttItemGroup { get; set; } 

        [JsonProperty("att_company_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AttCompanyId { get; set; } 

        [JsonProperty("processunclosedtravel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Processunclosedtravel { get; set; } 

        [JsonProperty("use_document_management_for_clientsiteuser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseDocumentManagementForClientSiteuser { get; set; } 

        [JsonProperty("use_geo_restrictions_kb", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseGeoRestrictionsKb { get; set; } 

        [JsonProperty("use_geo_restrictions_faqlist", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseGeoRestrictionsFaqList { get; set; } 

        [JsonProperty("calculate_composite_tax_after_line_tax", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? CalculateCompositeTaxAfterLineTax { get; set; } 

        [JsonProperty("hide_rule_checks_on_automations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HideRuleChecksOnAutomations { get; set; } 

        [JsonProperty("showassettagongoodsin", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowAssettagongoodsin { get; set; } 

        [JsonProperty("display_long_description_on_invoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DisplayLongDescriptionOnInvoice { get; set; } 

        [JsonProperty("defaultuserdetailslayout", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultUserdetailslayout { get; set; } 

        [JsonProperty("default_jira_connection", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultJiraConnection { get; set; } 

        [JsonProperty("use_portal_faq_restrictions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UsePortalFaqRestrictions { get; set; } 

        [JsonProperty("order_groups_by_name_ignore_emojis", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? OrderGroupsByNameIgnoreEmojis { get; set; } 

        [JsonProperty("sendagentemailafterquoterejected", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SendAgentemailafterquoterejected { get; set; } 

        [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Guid { get; set; } 

        [JsonProperty("log_clientsiteuser_views", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? LogClientSiteuserViews { get; set; } 

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
        public int? LiongardDefaultDeviceType { get; set; } 

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
        public int? NextSalesOrderId { get; set; } 

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
        public string? PortalBackgroundImageUrl { get; set; } 

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
        public bool? UseSlaHoldcolour { get; set; } 

        [JsonProperty("use_team_mgs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseTeamMgs { get; set; } 

        [JsonProperty("use_department_mgs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseDepartmentMgs { get; set; } 

        [JsonProperty("teamviewer_assetfield_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TeamviewerAssetFieldId { get; set; } 

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
        public ICollection<IntegrationFieldMapping>? OpportunityFieldMappingsSalesforce { get; set; } 

        [JsonProperty("account_fieldmappings_salesforce", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? AccountFieldMappingsSalesforce { get; set; } 

        [JsonProperty("contact_fieldmappings_salesforce", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? ContactFieldMappingsSalesforce { get; set; } 

        [JsonProperty("anydesk_assetfield_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AnydeskAssetFieldId { get; set; } 

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
        public string? GointegratorClientId { get; set; } 

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
        public ICollection<AssetTypeMapping>? AutomateTypemappings { get; set; } 

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
        public string? SccmTypeField { get; set; } 

        [JsonProperty("sccm_sitefield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SccmSitefield { get; set; } 

        [JsonProperty("sccm_userfield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SccmUserfield { get; set; } 

        [JsonProperty("sccm_usermatchingfield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SccmUsermatchingfield { get; set; } 

        [JsonProperty("sccm_defaultsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SccmDefaultSite { get; set; } 

        [JsonProperty("sccm_defaultsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SccmDefaultSiteName { get; set; } 

        [JsonProperty("sccm_updateonly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SccmUpdateonly { get; set; } 

        [JsonProperty("sccm_donotvalidate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SccmDoNotValidate { get; set; } 

        [JsonProperty("sccm_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<SqlImportField>? SccmFieldMappings { get; set; } 

        [JsonProperty("sccm_sqlserver", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SccmSqlserver { get; set; } 

        [JsonProperty("sccm_sqldatabase", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SccmSqldatabase { get; set; } 

        [JsonProperty("sccm_sqlusername", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SccmSqlusername { get; set; } 

        [JsonProperty("sccm_assetimportidentifier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SccmAssetImportIdentifier { get; set; } 

        [JsonProperty("sccm_new_sql_password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SccmNewSqlPassword { get; set; } 

        [JsonProperty("sccm_new_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SccmNewMethod { get; set; } 

        [JsonProperty("sccm_updated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SccmUpdated { get; set; } 

        [JsonProperty("sccm_dontupdatesite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SccmDontUpdatesite { get; set; } 

        [JsonProperty("sccm_dontremoveusers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SccmDontRemoveUsers { get; set; } 

        [JsonProperty("halointegrator_sccm", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorSccm { get; set; } 

        [JsonProperty("halointegrator_sccm_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorSccmLastSync { get; set; } 

        [JsonProperty("halointegrator_sccm_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorSccmLastError { get; set; } 

        [JsonProperty("sccm_allowed_clientids_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? SccmAllowedClientIdsList { get; set; } 

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
        public ICollection<IntegrationFieldMapping>? NinjaFieldMappings { get; set; } 

        [JsonProperty("halointegrator_ninjarmm", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorNinjaRmm { get; set; } 

        [JsonProperty("halointegrator_ninjarmm_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorNinjaRmmLastSync { get; set; } 

        [JsonProperty("halointegrator_ninjarmm_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorNinjaRmmLastError { get; set; } 

        [JsonProperty("halointegrator_solarwindsrmm", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorSolarwindsrmm { get; set; } 

        [JsonProperty("halointegrator_solarwindsrmm_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorSolarwindsrmmLastSync { get; set; } 

        [JsonProperty("halointegrator_solarwindsrmm_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorSolarwindsrmmLastError { get; set; } 

        [JsonProperty("solarwindsrmm_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? SolarwindsrmmFieldMappings { get; set; } 

        [JsonProperty("_getintegrationdata", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Getintegrationdata { get; set; } 

        [JsonProperty("_resendunsentemails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Resendunsentemails { get; set; } 

        [JsonProperty("_emailprocessed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? EmailProcessed { get; set; } 

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
        public DateTimeOffset? HaloIntegratorLansweeperLastSync { get; set; } 

        [JsonProperty("halointegrator_lansweeper_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorLansweeperLastError { get; set; } 

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
        public ICollection<ValueLabelIsNewKeyPair>? LansweeperAllowedClientIdsList { get; set; } 

        [JsonProperty("lansweeper_query", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? LansweeperQuery { get; set; } 

        [JsonProperty("lansweeper_sql_timeout", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LansweeperSqlTimeout { get; set; } 

        [JsonProperty("lansweeper_idfield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? LansweeperIdfield { get; set; } 

        [JsonProperty("lansweeper_typefield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? LansweeperTypeField { get; set; } 

        [JsonProperty("lansweeper_sitefield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? LansweeperSitefield { get; set; } 

        [JsonProperty("lansweeper_userfield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? LansweeperUserfield { get; set; } 

        [JsonProperty("lansweeper_usermatchingfield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? LansweeperUsermatchingfield { get; set; } 

        [JsonProperty("lansweeper_defaultsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LansweeperDefaultSite { get; set; } 

        [JsonProperty("lansweeper_defaultsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? LansweeperDefaultSiteName { get; set; } 

        [JsonProperty("sccm_userssite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SccmUserssite { get; set; } 

        [JsonProperty("lansweeper_userssite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? LansweeperUserssite { get; set; } 

        [JsonProperty("lansweeper_updateonly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? LansweeperUpdateonly { get; set; } 

        [JsonProperty("lansweeper_donotvalidate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? LansweeperDoNotValidate { get; set; } 

        [JsonProperty("lansweeper_dontupdatesite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? LansweeperDontUpdatesite { get; set; } 

        [JsonProperty("lansweeper_dontremoveusers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? LansweeperUnderscoreDontRemoveUsers { get; set; } 

        [JsonProperty("lansweeper_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<SqlImportField>? LansweeperFieldMappings { get; set; } 

        [JsonProperty("lansweeper_assetimportidentifier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LansweeperAssetImportIdentifier { get; set; } 

        [JsonProperty("dattormm_fromaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DattormmFromAddress { get; set; } 

        [JsonProperty("dattormm_tickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DattormmTicketType { get; set; } 

        [JsonProperty("dattormm_tickettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? DattormmTicketTypeGuid { get; set; } 

        [JsonProperty("cautomate_fromaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CautomateFromAddress { get; set; } 

        [JsonProperty("cautomate_requesttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CautomateRequestType { get; set; } 

        [JsonProperty("cautomate_requesttype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? CautomateRequestTypeGuid { get; set; } 

        [JsonProperty("solarwindsrmm_fromaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SolarwindsrmmFromAddress { get; set; } 

        [JsonProperty("solarwindsrmm_requesttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SolarwindsrmmRequestType { get; set; } 

        [JsonProperty("solarwindsrmm_requesttype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? SolarwindsrmmRequestTypeGuid { get; set; } 

        [JsonProperty("halointegrator_integrations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? HaloIntegratorIntegrations { get; set; } 

        [JsonProperty("splunkuser_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SplunkuserName { get; set; } 

        [JsonProperty("ncentral_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? NCentralFieldMappings { get; set; } 

        [JsonProperty("halointegrator_ncentral", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorNCentral { get; set; } 

        [JsonProperty("halointegrator_ncentral_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorNCentralLastSync { get; set; } 

        [JsonProperty("halointegrator_ncentral_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorNCentralLastError { get; set; } 

        [JsonProperty("client_secret_ncentral", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ClientSecretNCentral { get; set; } 

        [JsonProperty("ncentraluser_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NCentraluserName { get; set; } 

        [JsonProperty("azureconnection", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Azureconnection { get; set; } 

        [JsonProperty("azuremapping", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Azuremapping { get; set; } 

        [JsonProperty("businesscentral_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? BusinessCentralFieldMappings { get; set; } 

        [JsonProperty("businesscentralsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? BusinessCentralsiteName { get; set; } 

        [JsonProperty("_createbusinesscentralasset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Createbusinesscentralasset { get; set; } 

        [JsonProperty("businesscentralasset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Asset? BusinessCentralasset { get; set; } 

        [JsonProperty("defaultquicktimemethod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultQuicktimemethod { get; set; } 

        [JsonProperty("allowticketselectionduringquicktime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allowticketselectionduringquicktime { get; set; } 

        [JsonProperty("miscitemidquotetaxrate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Miscitemidquotetaxrate { get; set; } 

        [JsonProperty("miscitemidquotetaxratepo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Miscitemidquotetaxratepo { get; set; } 

        [JsonProperty("_getautomationbody", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Getautomationbody { get; set; } 

        [JsonProperty("_sendautomationhook", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SendAutomationhook { get; set; } 

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
        public ICollection<RecurringItem>? AreaItemsToConvert { get; set; } 

        [JsonProperty("_contracts_to_convert", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ContractHeaderList>? ContractsToConvert { get; set; } 

        [JsonProperty("remotesession_trackingid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? RemotesessionTrackingid { get; set; } 

        [JsonProperty("takecontrol_deviceid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TakecontrolDeviceid { get; set; } 

        [JsonProperty("showing_customer_fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowIngCustomerFields { get; set; } 

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
        public ICollection<ValueLabelIsNewKeyPair>? GwUserMatchingList { get; set; } 

        [JsonProperty("gw_agent_matching_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? GwAgentMatchingList { get; set; } 

        [JsonProperty("gw_licensed_roles_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<StringIdNameKeyPair>? GwLicensedRolesList { get; set; } 

        [JsonProperty("halointegrator_googleworkplace", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorGoogleworkplace { get; set; } 

        [JsonProperty("halointegrator_googleworkplace_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorGoogleworkplaceLastSync { get; set; } 

        [JsonProperty("halointegrator_googleworkplace_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorGoogleworkplaceLastError { get; set; } 

        [JsonProperty("dynamicscrm_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? DynamicscrmFieldMappings { get; set; } 

        [JsonProperty("scom_fromaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ScomFromAddress { get; set; } 

        [JsonProperty("scom_requesttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ScomRequestType { get; set; } 

        [JsonProperty("scom_requesttype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? ScomRequestTypeGuid { get; set; } 

        [JsonProperty("scom_devicefield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ScomDevicefield { get; set; } 

        [JsonProperty("halointegrator_scom", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorScom { get; set; } 

        [JsonProperty("halointegrator_scom_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorScomLastSync { get; set; } 

        [JsonProperty("halointegrator_scom_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorScomLastError { get; set; } 

        [JsonProperty("ncentral_customerid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NCentralCustomerid { get; set; } 

        [JsonProperty("rdattodefaultassettypegroup_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? RdattodefaultassettypegroupName { get; set; } 

        [JsonProperty("prtgassetdefaultsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PrtgassetdefaultsiteName { get; set; } 

        [JsonProperty("prtgdefaultassettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PrtgdefaultassettypeName { get; set; } 

        [JsonProperty("prtg_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? PrtgFieldMappings { get; set; } 

        [JsonProperty("halointegrator_prtg", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorPrtg { get; set; } 

        [JsonProperty("halointegrator_prtg_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorPrtgLastSync { get; set; } 

        [JsonProperty("halointegrator_prtg_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorPrtgLastError { get; set; } 

        [JsonProperty("migration_default_site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? MigrationDefaultSiteName { get; set; } 

        [JsonProperty("client_secret_orion", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ClientSecretOrion { get; set; } 

        [JsonProperty("orionuser_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OrionuserName { get; set; } 

        [JsonProperty("halointegrator_orion", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorOrion { get; set; } 

        [JsonProperty("halointegrator_orion_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorOrionLastSync { get; set; } 

        [JsonProperty("halointegrator_orion_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorOrionLastError { get; set; } 

        [JsonProperty("device42_customermappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Device42Customermappings { get; set; } 

        [JsonProperty("device42_typemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AssetTypeMapping>? Device42Typemappings { get; set; } 

        [JsonProperty("device42_devicemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Device42Devicemappings { get; set; } 

        [JsonProperty("device42defaultsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Device42defaultsiteName { get; set; } 

        [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ImportType { get; set; } 

        [JsonProperty("item_default_sales_nominal_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ValueLabelIsNewKeyPair? ItemDefaultSalesNominalCode { get; set; } 

        [JsonProperty("item_default_purchase_nominal_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ValueLabelIsNewKeyPair? ItemDefaultPurchaseNominalCode { get; set; } 

        [JsonProperty("item_default_asset_account", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ValueLabelIsNewKeyPair? ItemDefaultAssetAccount { get; set; } 

        [JsonProperty("socuser_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SocuserName { get; set; } 

        [JsonProperty("client_secret_device42", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ClientSecretDevice42 { get; set; } 

        [JsonProperty("datto_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? DattoFieldMappings { get; set; } 

        [JsonProperty("dattodefaultcustomer_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DattodefaultcustomerName { get; set; } 

        [JsonProperty("dattodefaulttoplevel_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DattodefaulttoplevelName { get; set; } 

        [JsonProperty("dattodefaultassetsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DattodefaultassetsiteName { get; set; } 

        [JsonProperty("halointegrator_datto", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorDatto { get; set; } 

        [JsonProperty("halointegrator_datto_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorDattoLastSync { get; set; } 

        [JsonProperty("halointegrator_datto_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorDattoLastError { get; set; } 

        [JsonProperty("csp_sitemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AzureAdMapping>? CspSiteMappings { get; set; } 

        [JsonProperty("_generatecspmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Generatecspmappings { get; set; } 

        [JsonProperty("atera_defaultsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AteraDefaultSiteName { get; set; } 

        [JsonProperty("atera_device_types", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? AteraDeviceTypesAsKeyPair { get; set; } 

        [JsonProperty("atera_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? AteraFieldMappings { get; set; } 

        [JsonProperty("halointegrator_atera", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorAtera { get; set; } 

        [JsonProperty("halointegrator_atera_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorAteraLastSync { get; set; } 

        [JsonProperty("halointegrator_atera_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorAteraLastError { get; set; } 

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

}