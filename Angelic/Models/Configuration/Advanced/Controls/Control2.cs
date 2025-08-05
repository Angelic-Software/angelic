using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Advanced.Controls;

public partial class Control
{
    [JsonProperty("salesforceimportcasefeed", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? SalesforceImportCaseFeed { get; set; }

    [JsonProperty("suzuki_gateway", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SuzukiGateway { get; set; }

    [JsonProperty("releases_from_devops_project", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? ReleasesFromDevOpsProject { get; set; }

    [JsonProperty("auto_load_dependency_chart", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? AutoLoadDependencyChart { get; set; }

    [JsonProperty("processstreettickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ProcessStreetTicketType { get; set; }

    [JsonProperty("processstreetuser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ProcessStreetUser { get; set; }

    [JsonProperty("chargerateroundmultorder", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? ChargeRateRoundMultOrder { get; set; }

    [JsonProperty("qbodisablecfsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? QboDisableCfSync { get; set; }

    [JsonProperty("qbocfdefinition", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? QboCfDefinition { get; set; }

    [JsonProperty("qbocfname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? QboCfName { get; set; }

    [JsonProperty("preventuserchange", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? PreventUserChange { get; set; }

    [JsonProperty("default_showdefaultsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DefaultShowDefaultSite { get; set; }

    [JsonProperty("default_showgeneralusers", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? DefaultShowGeneralUsers { get; set; }

    [JsonProperty("default_showagentusers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DefaultShowAgentUsers { get; set; }

    [JsonProperty("default_showinternalcustomers", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? DefaultShowInternalCustomers { get; set; }

    [JsonProperty("showmodalscreenforcannedtext", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowModalScreenForCannedText { get; set; }

    [JsonProperty("logicmonitor_defaultsite", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? LogicMonitorDefaultSite { get; set; }

    [JsonProperty("logicmonitor_defaultassettype", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? LogicMonitorDefaultAssetType { get; set; }

    [JsonProperty("logicmonitor_enable_alerting", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? LogicMonitorEnableAlerting { get; set; }

    [JsonProperty("logicmonitor_alert_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? LogicMonitorAlertType { get; set; }

    [JsonProperty("logicmonitor_alert_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? LogicMonitorAlertUser { get; set; }

    [JsonProperty("logicmonitor_delete_devices", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? LogicMonitorDeleteDevices { get; set; }

    [JsonProperty("htmltemplateeditortype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? HtmlTemplateEditorType { get; set; }

    [JsonProperty("allow_live_chat_teams", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowLiveChatTeams { get; set; }

    [JsonProperty("teams_chat_profile", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TeamsChatProfile { get; set; }

    [JsonProperty("teams_options_style", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TeamsOptionsStyle { get; set; }

    [JsonProperty("workspace_defaultsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? WorkspaceDefaultSite { get; set; }

    [JsonProperty("followers_scope", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? FollowersScope { get; set; }

    [JsonProperty("cc_scope", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CcScope { get; set; }

    [JsonProperty("adjustpriceforsoinvoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AdjustPriceForSoInvoice { get; set; }

    [JsonProperty("showallforopplink", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowAllForOppLink { get; set; }

    [JsonProperty("intacct_sync_halo_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? IntacctSyncHaloId { get; set; }

    [JsonProperty("intacctdefaultwarid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? IntacctDefaultWarId { get; set; }

    [JsonProperty("default_intacct_save_location", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultIntacctSaveLocation { get; set; }

    [JsonProperty("intacctdonttaxpos", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IntacctDontTaxPos { get; set; }

    [JsonProperty("intacctdefaultglgroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? IntacctDefaultGlGroup { get; set; }

    [JsonProperty("intacctdefaultmanualitemtype", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public string? IntacctDefaultManualItemType { get; set; }

    [JsonProperty("intacctdefaultautoitemtype", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public string? IntacctDefaultAutoItemType { get; set; }

    [JsonProperty("intaccttaxonseparateline", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? IntacctTaxOnSeparateLine { get; set; }

    [JsonProperty("intaccttaxonseparatelineitem", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public string? IntacctTaxOnSeparateLineItem { get; set; }

    [JsonProperty("intacctcredittransdef", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? IntacctCreditTransDef { get; set; }

    [JsonProperty("intacctpotransdef", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? IntacctPoTransDef { get; set; }

    [JsonProperty("intacctbilltransdef", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? IntacctBillTransDef { get; set; }

    [JsonProperty("intacctsigtax", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IntacctSigTax { get; set; }

    [JsonProperty("allowusermerging", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowUserMerging { get; set; }

    [JsonProperty("defaultpdftemplateinvoicetickets", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultPdfTemplateInvoiceTickets { get; set; }

    [JsonProperty("defaultpdftemplateinvoiceorders", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultPdfTemplateInvoiceOrders { get; set; }

    [JsonProperty("defaultpdftemplateinvoicerecurring", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultPdfTemplateInvoiceRecurring { get; set; }

    [JsonProperty("stripetakepaymentonduedate", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? StripeTakePaymentOnDueDate { get; set; }

    [JsonProperty("hubspot_default_lifecycle_stage", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public string? HubspotDefaultLifecycleStage { get; set; }

    [JsonProperty("itsm_tickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ItsmTicketType { get; set; }

    [JsonProperty("send_new_users_welcome_email", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? SendNewUsersWelcomeEmail { get; set; }

    [JsonProperty("logicmonitor_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? LogicMonitorImportType { get; set; }

    [JsonProperty("barracuda_defaultsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? BarracudaDefaultSite { get; set; }

    [JsonProperty("barracudadefaultassettype", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? BarracudaDefaultAssetType { get; set; }

    [JsonProperty("barracuda_alert_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? BarracudaAlertUser { get; set; }

    [JsonProperty("barracuda_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? BarracudaImportType { get; set; }

    [JsonProperty("barracuda_delete_devices", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? BarracudaDeleteDevices { get; set; }

    [JsonProperty("useoutgoingservice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? UseOutgoingService { get; set; }

    [JsonProperty("enableteamsmsg", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? EnableTeamsMsg { get; set; }

    [JsonProperty("defaultteamsmsg", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultTeamsMsg { get; set; }

    [JsonProperty("audit_teams_message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AuditTeamsMessage { get; set; }

    [JsonProperty("whatsappcreatetickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? WhatsAppCreateTickets { get; set; }

    [JsonProperty("prmerge_outcome_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PrMergeOutcomeId { get; set; }

    [JsonProperty("hide_halo_invoice_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? HideHaloInvoiceId { get; set; }

    [JsonProperty("default_quoter_country_iso", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultQuoterCountryIso { get; set; }

    [JsonProperty("default_quoter_region_iso", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultQuoterRegionIso { get; set; }

    [JsonProperty("remove_licences_when_inactive", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? RemoveLicencesWhenInactive { get; set; }

    [JsonProperty("allow_additional_agents_on_tickets", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowAdditionalAgentsOnTickets { get; set; }

    [JsonProperty("users_label", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? UsersLabel { get; set; }

    [JsonProperty("showusernoteswhenempty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowUserNotesWhenEmpty { get; set; }

    [JsonProperty("showsitenoteswhenempty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowSiteNotesWhenEmpty { get; set; }

    [JsonProperty("showareanoteswhenempty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowAreaNotesWhenEmpty { get; set; }

    [JsonProperty("show_enduser_details_opps", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowEndUserDetailsOpps { get; set; }

    [JsonProperty("max_parent_deps", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MaxParentDeps { get; set; }

    [JsonProperty("max_child_deps", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MaxChildDeps { get; set; }

    [JsonProperty("invoiceitembillingdescriptionlong", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public string? InvoiceItemBillingDescriptionLong { get; set; }

    [JsonProperty("invoiceitembillingdescriptionshort", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public string? InvoiceItemBillingDescriptionShort { get; set; }

    [JsonProperty("default_columns_id_clients", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultColumnsIdClients { get; set; }

    [JsonProperty("default_columns_id_clients_guid", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public Guid? DefaultColumnsIdClientsGuid { get; set; }

    [JsonProperty("hide_other_dep_teams", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? HideOtherDepTeams { get; set; }

    [JsonProperty("kbeditorrich", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? KbEditorRich { get; set; }

    [JsonProperty("kbeditormarkdown", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? KbEditorMarkdown { get; set; }

    [JsonProperty("chat_image_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ChatImageType { get; set; }

    [JsonProperty("cognigyendpoint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CognigyEndpoint { get; set; }

    [JsonProperty("connectwiseautomatealertlastupdated", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? ConnectWiseAutomateAlertLastUpdated { get; set; }

    [JsonProperty("cannedsuggestnewticket", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CannedSuggestNewTicket { get; set; }

    [JsonProperty("service_permission_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ServicePermissionType { get; set; }

    [JsonProperty("includeslaholdloadbalancing", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? IncludeSlaHoldLoadBalancing { get; set; }

    [JsonProperty("milestone_update_all_dates", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? MilestoneUpdateAllDates { get; set; }

    [JsonProperty("match_ninja_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? MatchNinjaUser { get; set; }

    [JsonProperty("uselistgroups", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? UseListGroups { get; set; }

    [JsonProperty("allowquickuseradd", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowQuickUserAdd { get; set; }

    [JsonProperty("connectwise_automate_control_guid", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public string? ConnectWiseAutomateControlGuid { get; set; }

    [JsonProperty("supp_contract_mandatory", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? SuppContractMandatory { get; set; }

    [JsonProperty("searchfullticketids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? SearchFullTicketIds { get; set; }

    [JsonProperty("qualysusertype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? QualysUserType { get; set; }

    [JsonProperty("googleworkspacenamedroles", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public string? GoogleWorkspaceNamedRoles { get; set; }

    [JsonProperty("oktanamedroles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OktaNamedRoles { get; set; }

    [JsonProperty("lansweeper_assettype_choice", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? LansweeperAssetTypeChoice { get; set; }

    [JsonProperty("lansweeper_default_assettype", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? LansweeperDefaultAssetType { get; set; }

    [JsonProperty("lansweeper_assettype_field", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public string? LansweeperAssetTypeField { get; set; }

    [JsonProperty("barracuda_alert_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? BarracudaAlertType { get; set; }

    [JsonProperty("preventparentchange", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? PreventParentChange { get; set; }

    [JsonProperty("planning_orange_percentage", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public double? PlanningOrangePercentage { get; set; }

    [JsonProperty("planning_red_percentage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? PlanningRedPercentage { get; set; }

    [JsonProperty("whatsappreopentickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? WhatsAppReopenTickets { get; set; }

    [JsonProperty("whatsapptickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? WhatsAppTicketType { get; set; }

    [JsonProperty("intacct_use_apinvoices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IntacctUseApInvoices { get; set; }

    [JsonProperty("intacct_use_arinvoices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IntacctUseArInvoices { get; set; }

    [JsonProperty("intacctitemgroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? IntacctItemGroup { get; set; }

    [JsonProperty("intacctdefaulttaxsol", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? IntacctDefaultTaxSol { get; set; }

    [JsonProperty("showslaonkanban", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowSlaOnKanban { get; set; }

    [JsonProperty("site24x7_alert_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Site24X7AlertType { get; set; }

    [JsonProperty("site24x7_alert_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Site24X7AlertUser { get; set; }

    [JsonProperty("reset_security_stamps", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ResetSecurityStamps { get; set; }

    [JsonProperty("invoice_pay_prepay_before_use", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? InvoicePayPrepayBeforeUse { get; set; }

    [JsonProperty("new_user_template", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? NewUserTemplate { get; set; }

    [JsonProperty("new_user_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? NewUserType { get; set; }

    [JsonProperty("child_template_recursion_depth", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? ChildTemplateRecursionDepth { get; set; }

    [JsonProperty("kaseya_sync_agents_only", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? KaseyaSyncAgentsOnly { get; set; }

    [JsonProperty("kaseya_defaultassettype_server", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? KaseyaDefaultAssetTypeServer { get; set; }

    [JsonProperty("kaseya_defaultassettype_server_guid", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public Guid? KaseyaDefaultAssetTypeServerGuid { get; set; }

    [JsonProperty("kaseya_defaultassettype_workstation", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? KaseyaDefaultAssetTypeWorkstation { get; set; }

    [JsonProperty("kaseya_defaultassettype_workstation_guid", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public Guid? KaseyaDefaultAssetTypeWorkstationGuid { get; set; }

    [JsonProperty("recaptcha_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RecaptchaType { get; set; }

    [JsonProperty("recaptcha_threshold", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? RecaptchaThreshold { get; set; }

    [JsonProperty("show_all_lic_for_quantity_calc", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowAllLicForQuantityCalc { get; set; }

    [JsonProperty("jamf_instance_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? JamfInstanceType { get; set; }

    [JsonProperty("jamf_site_match_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? JamfSiteMatchType { get; set; }

    [JsonProperty("software_import_licence_matching", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? SoftwareImportLicenceMatching { get; set; }

    [JsonProperty("show_services_cost_tile", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowServicesCostTile { get; set; }

    [JsonProperty("show_services_cost_tile_endusers", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowServicesCostTileEndUsers { get; set; }

    [JsonProperty("exclude_nonticket_app_todo", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? ExcludeNonticketAppTodo { get; set; }

    [JsonProperty("po_hide_item_popup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? PoHideItemPopup { get; set; }

    [JsonProperty("mergesalesorderinvoicessite", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? MergeSalesOrderInvoicesSite { get; set; }

    [JsonProperty("prepay_itemid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PrepayItemId { get; set; }

    [JsonProperty("showintelrouting", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowIntelRouting { get; set; }

    [JsonProperty("showintelroutingonactions", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowIntelRoutingOnActions { get; set; }

    [JsonProperty("intelroutingcutoffdays", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? IntelRoutingCutoffDays { get; set; }

    [JsonProperty("intelroutingmaxtickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? IntelRoutingMaxTickets { get; set; }

    [JsonProperty("close_all_children", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CloseAllChildren { get; set; }

    [JsonProperty("showtraveltimesheet", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowTravelTimesheet { get; set; }

    [JsonProperty("showfeedbackcaptcha", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowFeedbackCaptcha { get; set; }

    [JsonProperty("recaptcha_isenterprise", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? RecaptchaIsEnterprise { get; set; }

    [JsonProperty("call_charge_rate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CallChargeRate { get; set; }

    [JsonProperty("use_stripe_receipt_emails", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? UseStripeReceiptEmails { get; set; }

    [JsonProperty("invoicecreationengine", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? InvoiceCreationEngine { get; set; }

    [JsonProperty("showponumonapproval", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowPoNumOnApproval { get; set; }

    [JsonProperty("multientitysearchincludecontracts", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? MultiEntitySearchIncludeContracts { get; set; }

    [JsonProperty("hide_add_to_project_and_create_child", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? HideAddToProjectAndCreateChild { get; set; }

    [JsonProperty("show_pipeline_stages", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowPipelineStages { get; set; }

    [JsonProperty("default_pipeline_stage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultPipelineStage { get; set; }

    [JsonProperty("timefieldstoshowontimesheet", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? TimeFieldsToShowOnTimesheet { get; set; }

    [JsonProperty("showjsonexportbutton", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowJsonExportButton { get; set; }

    [JsonProperty("issueditemsdesclong", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? IssuedItemsDescLong { get; set; }

    [JsonProperty("overridefeedbacklink", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? OverrideFeedbackLink { get; set; }

    [JsonProperty("allow_user_drafts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowUserDrafts { get; set; }

    [JsonProperty("createuserifgeneraluser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CreateUserIfGeneralUser { get; set; }

    [JsonProperty("icinga_defaultsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? IcingaDefaultSite { get; set; }

    [JsonProperty("icinga_defaultgroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? IcingaDefaultGroup { get; set; }

    [JsonProperty("icinga_defaultgroup_guid", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public Guid? IcingaDefaultGroupGuid { get; set; }

    [JsonProperty("icingaassettypefield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? IcingaAssetTypeField { get; set; }

    [JsonProperty("icingadefaultassettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? IcingaDefaultAssetType { get; set; }

    [JsonProperty("icinga_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? IcingaImportType { get; set; }

    [JsonProperty("icinga_delete_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IcingaDeleteDevices { get; set; }

    [JsonProperty("icinga_selfsigned_cert", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IcingaSelfSignedCert { get; set; }

    [JsonProperty("icinga_alert_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? IcingaAlertType { get; set; }

    [JsonProperty("icinga_alert_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? IcingaAlertUser { get; set; }

    [JsonProperty("icinga_enable_alerting", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IcingaEnableAlerting { get; set; }

    [JsonProperty("enable_document_previewer", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? EnableDocumentPreviewer { get; set; }

    [JsonProperty("addigy_dont_import_software", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? AddigyDontImportSoftware { get; set; }

    [JsonProperty("default_view_customers_selectedid", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultViewCustomersSelectedId { get; set; }

    [JsonProperty("default_view_users_selectedid", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultViewUsersSelectedId { get; set; }

    [JsonProperty("defaultnavscreenlayout", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultNavScreenLayout { get; set; }

    [JsonProperty("navbar_new_call", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? NavbarNewCall { get; set; }

    [JsonProperty("actiondatedisplay", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ActionDateDisplay { get; set; }

    [JsonProperty("showcalllogonticket", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowCallLogonTicket { get; set; }

    [JsonProperty("use_charge_for_budgets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? UseChargeForBudgets { get; set; }

    [JsonProperty("quote_hide_item_popup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? QuoteHideItemPopup { get; set; }

    [JsonProperty("so_hide_item_popup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? SoHideItemPopup { get; set; }

    [JsonProperty("default_columns_id_contracts", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultColumnsIdContracts { get; set; }

    [JsonProperty("default_columns_id_contracts_guid", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public Guid? DefaultColumnsIdContractsGuid { get; set; }

    [JsonProperty("beyond_trust_instance_type", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? BeyondTrustInstanceType { get; set; }

    [JsonProperty("asset_permission_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AssetPermissionType { get; set; }

    [JsonProperty("show_users_contracts_on_ticket_only", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowUsersContractsOnTicketOnly { get; set; }

    [JsonProperty("default_columns_id_sites", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultColumnsIdSites { get; set; }

    [JsonProperty("default_columns_id_users", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultColumnsIdUsers { get; set; }

    [JsonProperty("jamf_dont_update_asset_type", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? JamfDontUpdateAssetType { get; set; }

    [JsonProperty("billingcontactinfoonportal", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? BillingContactInfoOnPortal { get; set; }

    [JsonProperty("rhipe_subscription_client", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? RhipeSubscriptionClient { get; set; }

    [JsonProperty("followup_appointment_subject", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? FollowupAppointmentSubject { get; set; }

    [JsonProperty("show_device_on_invoice_line", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowDeviceOnInvoiceLine { get; set; }

    [JsonProperty("asset_return_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AssetReturnStatus { get; set; }

    [JsonProperty("spellchecksuggestionscore", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public double? SpellCheckSuggestionScore { get; set; }

    [JsonProperty("load_rinvoices_lines", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? LoadRInvoicesLines { get; set; }

    [JsonProperty("user_ticket_profile", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? UserTicketProfile { get; set; }

    [JsonProperty("user_project_profile", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? UserProjectProfile { get; set; }

    [JsonProperty("admin_override_quick_status_change", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? AdminOverrideQuickStatusChange { get; set; }

    [JsonProperty("create_so_on_quote_approved", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? CreateSoOnQuoteApproved { get; set; }

    [JsonProperty("additional_agents_on_tickets_type", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? AdditionalAgentsOnTicketsType { get; set; }

    [JsonProperty("show_toplevel_access_portal_option", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowTopLevelAccessPortalOption { get; set; }

    [JsonProperty("show_alllevel_access_portal_option", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowAllLevelAccessPortalOption { get; set; }

    [JsonProperty("donttrackleavesite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DontTrackLeaveSite { get; set; }

    [JsonProperty("meter_min_quantity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? MeterMinQuantity { get; set; }

    [JsonProperty("show_kb_menu", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowKbMenu { get; set; }

    [JsonProperty("icinga_comment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? IcingaComment { get; set; }

    [JsonProperty("sync_icinga_comment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? SyncIcingaComment { get; set; }

    [JsonProperty("icinga_asset_type_choice", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? IcingaAssetTypeChoice { get; set; }

    [JsonProperty("open_new_quote_in_new_tab", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? OpenNewQuoteInNewTab { get; set; }

    [JsonProperty("defaultaideployment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(50)]
    public string? DefaultAiDeployment { get; set; }

    [JsonProperty("connectwise_rmm_default_client", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? ConnectWiseRmmDefaultClient { get; set; }

    [JsonProperty("connectwise_rmm_default_asset_type", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? ConnectWiseRmmDefaultAssetType { get; set; }

    [JsonProperty("connectwise_rmm_delete_devices", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? ConnectWiseRmmDeleteDevices { get; set; }

    [JsonProperty("connectwise_rmm_import_entities", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public string? ConnectWiseRmmImportEntities { get; set; }

    [JsonProperty("connectwise_rmm_top_level", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? ConnectWiseRmmTopLevel { get; set; }

    [JsonProperty("showeventstabforadmins", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowEventStabForAdmins { get; set; }

    [JsonProperty("def_inv_manual_pr_immediately", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? DefInvManualPrImmediately { get; set; }

    [JsonProperty("salesorderstatusafterinvoicedeleted", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? SalesOrderStatusAfterInvoiceDeleted { get; set; }

    [JsonProperty("show_related_of_related", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowRelatedOfRelated { get; set; }

    [JsonProperty("invertactionhistory", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? InvertActionHistory { get; set; }

    [JsonProperty("enablekbdraftsnews", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? EnableKbDraftsNews { get; set; }

    [JsonProperty("kbdrafttickettypenews", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? KbDraftTicketTypeNews { get; set; }

    [JsonProperty("kbdrafttickettype_guidnews", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public Guid? KbDraftTicketTypeGuidNews { get; set; }

    [JsonProperty("halonewssandbox", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? HaloNewsSandbox { get; set; }

    [JsonProperty("shopifycustomerimporttype", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? ShopifyCustomerImportType { get; set; }

    [JsonProperty("shopifydefaultsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ShopifyDefaultSite { get; set; }

    [JsonProperty("shopify_integratorcustomerslastsync", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? ShopifyIntegratorCustomersLastSync { get; set; }

    [JsonProperty("shopify_integratororderslastsync", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? ShopifyIntegratorOrdersLastSync { get; set; }

    [JsonProperty("shopify_integratorentitiestoimport", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public string? ShopifyIntegratorEntitiesToImport { get; set; }

    [JsonProperty("ecommerceshowordersarea", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? EcommerceShowOrdersArea { get; set; }

    [JsonProperty("device42preventdeviceimport", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? Device42PreventDeviceImport { get; set; }

    [JsonProperty("admins_access_all_reports", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? AdminsAccessAllReports { get; set; }

    [JsonProperty("adminsecurityprompt", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AdminSecurityPrompt { get; set; }

    [JsonProperty("stripemanualpaymentmethodoptions", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public string? StripeManualPaymentMethodOptions { get; set; }

    [JsonProperty("log_action_responses_on_action_submit", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? LogActionResponsesOnActionSubmit { get; set; }

    [JsonProperty("use_embedding_scores_openai", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? UseEmbeddingScoresOpenAi { get; set; }

    [JsonProperty("use_embedding_scores_azureopenai", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? UseEmbeddingScoresAzureOpenai { get; set; }

    [JsonProperty("xensam_defaultsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? XensamDefaultSite { get; set; }

    [JsonProperty("xensam_defaultassettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? XensamDefaultAssetType { get; set; }

    [JsonProperty("xensam_assettype_choice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? XensamAssetTypeChoice { get; set; }

    [JsonProperty("xensam_assettype_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? XensamAssetTypeField { get; set; }

    [JsonProperty("xensam_assettype_field_datacentre", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public string? XensamAssetTypeFieldDatacentre { get; set; }

    [JsonProperty("xensam_defaultgroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? XensamDefaultGroup { get; set; }

    [JsonProperty("xensamdefaultgroup_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? XensamDefaultGroupGuid { get; set; }

    [JsonProperty("xensam_integratorentitiestoimport", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public string? XensamIntegratorEntitiesToImport { get; set; }

    [JsonProperty("xensam_delete_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? XensamDeleteDevices { get; set; }

    [JsonProperty("xensam_dont_update_assettype", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? XensamDontUpdateAssetType { get; set; }

    [JsonProperty("useincomingservice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? UseIncomingService { get; set; }

    [JsonProperty("atera_alert_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AteraAlertMethod { get; set; }

    [JsonProperty("addigy_alert_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AddigyAlertMethod { get; set; }

    [JsonProperty("automate_alert_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AutomateAlertMethod { get; set; }

    [JsonProperty("dattormm_alert_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DattoRmmAlertMethod { get; set; }

    [JsonProperty("default_view_suppliers_selectedid", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultViewSuppliersSelectedId { get; set; }

    [JsonProperty("trackresponsetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? TrackResponseTime { get; set; }

    [JsonProperty("trackfixbytime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? TrackFixByTime { get; set; }

    [JsonProperty("reviewprocessenabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ReviewProcessEnabled { get; set; }

    [JsonProperty("usedynamicemaillist", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? UseDynamicEmailList { get; set; }

    [JsonProperty("emailmustmatchrule", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? EmailMustMatchRule { get; set; }

    [JsonProperty("donteditemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DontEditEmail { get; set; }

    [JsonProperty("sendacknowledgementemailstoccaddresses", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? SendAcknowledgementEmailsToCcAddresses { get; set; }

    [JsonProperty("autoforwardemailupdates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AutoForwardEmailUpdates { get; set; }

    [JsonProperty("disablereplytome", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DisableReplyToMe { get; set; }

    [JsonProperty("useintellisense", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? UseIntellisense { get; set; }

    [JsonProperty("smtpserver", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SmtpServer { get; set; }

    [JsonProperty("smtpaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SmtpAddress { get; set; }

    [JsonProperty("smtpusername", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SmtpUsername { get; set; }

    [JsonProperty("new_smtppassword", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewSmtpPassword { get; set; }

    [JsonProperty("smtpusetls", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? SmtpUseTls { get; set; }

    [JsonProperty("smtpport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SmtpPort { get; set; }

    [JsonProperty("generalusername", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? GeneralUserName { get; set; }

    [JsonProperty("enableuserclosureconf", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? EnableUserClosureConf { get; set; }

    [JsonProperty("auto_close_hrs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AutoCloseHrs { get; set; }

    [JsonProperty("pending_close_reminder_hrs", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? PendingCloseReminderHrs { get; set; }

    [JsonProperty("shownotrespondedwarning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowNotRespondedWarning { get; set; }

    [JsonProperty("statusafterrespond", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? StatusAfterRespond { get; set; }

    [JsonProperty("statusafterrespond_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? StatusAfterRespondGuid { get; set; }

    [JsonProperty("tracknonbill", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? TrackNonBill { get; set; }

    [JsonProperty("tracktravel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? TrackTravel { get; set; }

    [JsonProperty("trackmileage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? TrackMileage { get; set; }

    [JsonProperty("default_tickettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultTicketTypeId { get; set; }

    [JsonProperty("default_tickettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? DefaultTicketTypeGuid { get; set; }

    [JsonProperty("allow_tickettype_selection_agents", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowTicketTypeSelectionAgents { get; set; }

    [JsonProperty("hide_generaluser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? HideGeneralUser { get; set; }

    [JsonProperty("addactionstolinked", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AddActionsToLinked { get; set; }

    [JsonProperty("enableslareminders", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? EnableSlaReminders { get; set; }

    [JsonProperty("slareminderintervalhrs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SlaReminderIntervalHrs { get; set; }

    [JsonProperty("slareminderautoclosehrs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SlaReminderAutoCloseHrs { get; set; }

    [JsonProperty("hourswarningnotapproved", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? HoursWarningNotApproved { get; set; }

    [JsonProperty("enablequalificationmatching", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? EnableQualificationMatching { get; set; }

    [JsonProperty("onlyprocessclosedrequests", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? OnlyProcessClosedRequests { get; set; }

    [JsonProperty("defaultischargeable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DefaultIsChargeable { get; set; }

    [JsonProperty("processunclosedactions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ProcessUnclosedActions { get; set; }

    [JsonProperty("useactioneventtimes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? UseActionEventTimes { get; set; }

    [JsonProperty("acctinterfacefolder", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AcctInterfaceFolder { get; set; }

    [JsonProperty("xmlinterfacefolder", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? XmlInterfaceFolder { get; set; }

    [JsonProperty("allow_response_edit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowResponseEdit { get; set; }

    [JsonProperty("cat2mandclear", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Cat2MandClear { get; set; }

    [JsonProperty("cat3mandclear", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Cat3MandClear { get; set; }

    [JsonProperty("cat4mandclear", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Cat4MandClear { get; set; }

    [JsonProperty("cat5mandclear", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Cat5MandClear { get; set; }

    [JsonProperty("showactioncalendaroption", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowActionCalendarOption { get; set; }

    [JsonProperty("matchchargecodes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? MatchChargeCodes { get; set; }

    [JsonProperty("forcestrongpasswords", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ForceStrongPasswords { get; set; }

    [JsonProperty("auditdelete", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AuditDelete { get; set; }

    [JsonProperty("outofhourspriority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OutOfHoursPriority { get; set; }

    [JsonProperty("informownertech", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? InformOwnerTech { get; set; }

    [JsonProperty("sageslaitemcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SageSlaItemCode { get; set; }

    [JsonProperty("sageslaitemcodedesc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SageSlaItemCodeDesc { get; set; }

    [JsonProperty("sagedetaildesc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SageDetailDesc { get; set; }

    [JsonProperty("billingreportvariable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? BillingReportVariable { get; set; }

    [JsonProperty("allowinvoicenumberedit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowInvoiceNumberEdit { get; set; }

    [JsonProperty("actionlineitems", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ActionLineItems { get; set; }

    [JsonProperty("projectlineitems", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ProjectLineItems { get; set; }

    [JsonProperty("invoiceaddgroupheaders", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? InvoiceAddGroupHeaders { get; set; }

    [JsonProperty("includezerocharge", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IncludeZeroCharge { get; set; }

    [JsonProperty("linknonchargabletoinvoice", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public bool? LinkNonChargeableToInvoice { get; set; }

    [JsonProperty("weeksaheadtocreateperiodicinvoice", Required = Required.Default,
        NullValueHandling = NullValueHandling.Ignore)]
    public int? WeeksAheadToCreatePeriodicInvoice { get; set; }

    [JsonProperty("contractexpirydays", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ContractExpiryDays { get; set; }

    [JsonProperty("apptservername", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ApptServerName { get; set; }

    [JsonProperty("apptsetting", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ApptSetting { get; set; }

    [JsonProperty("syncallappts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? SyncAllAppts { get; set; }

    [JsonProperty("calendarchoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CalendarChoice { get; set; }

    [JsonProperty("miscitemidquote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MiscItemIdQuote { get; set; }

    [JsonProperty("rtdefwebendusers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RtDefWebEndUsers { get; set; }
}