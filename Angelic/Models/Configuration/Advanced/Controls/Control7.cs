using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Advanced.Controls;

public partial class Control
{
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
        public bool? ShowUsersassetsonnewticket { get; set; } 

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
        public int? LogicmonitorDefaultGroup { get; set; } 

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
        public int? MerakiDefaultGroup { get; set; } 

        [JsonProperty("meraki_defaultgroup_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? MerakiDefaultGroupGuid { get; set; } 

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
        public string? ItGlueSyncEntities { get; set; } 

        [JsonProperty("itglue_show_message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ItGlueShowMessage { get; set; } 

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
        public bool? DefaultInvoiceDatetotoday { get; set; } 

        [JsonProperty("user_match_phonenumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UserMatchPhoneNumber { get; set; } 

        [JsonProperty("parent_and_related_cf_copy_priority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ParentAndRelatedCfCopyPriority { get; set; } 

        [JsonProperty("ticketstatusafterquoteinternalrejection", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ticketstatusafterquoteinternalrejection { get; set; } 

        [JsonProperty("show_child_templates_always", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowChildTemplatesAlways { get; set; } 

        [JsonProperty("whatsapp_defaultclientsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? WhatsappDefaultClientsite { get; set; } 

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
        public string? DynamicscrmSiteNamefilter { get; set; } 

        [JsonProperty("adobeacrobat_auto_expire_td", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AdobeacrobatAutoExpireTd { get; set; } 

        [JsonProperty("defaultadobeactenant", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultAdobeactenant { get; set; } 

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
        public int? AdobeCommercedefaultsite { get; set; } 

        [JsonProperty("adobecommerce_integratorentitiestoimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AdobeCommerceIntegratorentitiestoimport { get; set; } 

        [JsonProperty("update_all_actions_when_contract_changed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UpdateAllActionsWhenContractChanged { get; set; } 

        [JsonProperty("use_new_search_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseNewSearchMethod { get; set; } 

        [JsonProperty("assetdiscovery_defaultsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AssetdiscoveryDefaultSite { get; set; } 

        [JsonProperty("assetdiscovery_defaultsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AssetdiscoveryDefaultSiteName { get; set; } 

        [JsonProperty("lansweeper_override_site_rules", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? LansweeperOverrideSiteRules { get; set; } 

        [JsonProperty("salesforce_integratorattachmentstoimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SalesforceIntegratorattachmentstoimport { get; set; } 

        [JsonProperty("defaultpdftemplatebill", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultPdfTemplatebill { get; set; } 

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
        public bool? PortalServicedetailsdisplaytype { get; set; } 

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
        public int? DistributionlistsDefaultSite { get; set; } 

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
        public bool? SetAccountsIdToSku { get; set; } 

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
        public bool? ShowEmailInUseractivity { get; set; } 

        [JsonProperty("po_approval_email_addr", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PoApprovalEmailAddr { get; set; } 

        [JsonProperty("show_negative_tax_invoices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowNegativeTaxInvoices { get; set; } 

        [JsonProperty("donotalloweditingpostedinvoicesfreq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? DoNotAlloweditingpostedinvoicesfreq { get; set; } 

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
        public int? DefaultBulkdevicepdftemplate { get; set; } 

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
        public string? SnelStartInvoiceTemplate { get; set; } 

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
        public bool? HideEndDateTimeZone { get; set; } 

        [JsonProperty("enable_clear_nable_rmm_alert_check", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableClearNableRmmAlertCheck { get; set; } 

        [JsonProperty("show_asset_diagram_keyfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowAssetDiagramKeyFields { get; set; } 

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
        public int? DefaultContractdetailslayout { get; set; } 

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
        public string? ServicesPortalBackgroundImageUrl { get; set; } 

        [JsonProperty("itglue_disable_address_sync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ItGlueDisableAddressSync { get; set; } 

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
        public bool? HideKbviews { get; set; } 

        [JsonProperty("hidekbratings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HideKbratings { get; set; } 

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
        public int? PurchaseOrderstatusafterallitemsreceived { get; set; } 

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
}