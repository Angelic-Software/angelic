using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Advanced.Controls;

public partial class Control
{
    [JsonProperty("hubspot_top_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? HubspotTopLevel { get; set; } 

        [JsonProperty("hubspot_include_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HubspotIncludeAddress { get; set; } 

        [JsonProperty("hubspot_default_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? HubspotDefaultSite { get; set; } 

        [JsonProperty("hubspot_account", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HubspotAccount { get; set; } 

        [JsonProperty("hubspot_domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HubspotDomain { get; set; } 

        [JsonProperty("hubspot_company_sync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? HubspotCompanySync { get; set; } 

        [JsonProperty("hubspot_contact_sync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? HubspotContactSync { get; set; } 

        [JsonProperty("hubspot_show_success_message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HubspotShowSuccessMessage { get; set; } 

        [JsonProperty("hubspot_included_lifecycles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HubspotIncludedLifecycles { get; set; } 

        [JsonProperty("hubspot_archive", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HubspotArchive { get; set; } 

        [JsonProperty("hubspot_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? HubspotImportType { get; set; } 

        [JsonProperty("qualys_default_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? QualysDefaultSite { get; set; } 

        [JsonProperty("passportal_clienttoplevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PassportalClientTopLevel { get; set; } 

        [JsonProperty("passportal_defaultusersite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PassportalDefaultUserSite { get; set; } 

        [JsonProperty("passportal_defaultassetsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PassportalDefaultAssetSite { get; set; } 

        [JsonProperty("rpassportal_integratorentitiestoimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? RPassportalIntegratorEntitiesToImport { get; set; } 

        [JsonProperty("passportal_defaultassetgroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PassportalDefaultAssetGroup { get; set; } 

        [JsonProperty("passportal_defaultassetgroup_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? PassportalDefaultAssetGroupGuid { get; set; } 

        [JsonProperty("passportal_deactivate_assets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? PassportalDeactivateAssets { get; set; } 

        [JsonProperty("auvik_top_level_domain_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AuvikTopLevelDomainId { get; set; } 

        [JsonProperty("auvik_top_level_domain_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AuvikTopLevelDomainName { get; set; } 

        [JsonProperty("qbononinventoryitemgroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? QboNonInventoryItemGroup { get; set; } 

        [JsonProperty("showmailboxname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowMailboxName { get; set; } 

        [JsonProperty("show_timer_seconds", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowTimerSeconds { get; set; } 

        [JsonProperty("exchange_disable_integrator_delete", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ExchangeDisableIntegratorDelete { get; set; } 

        [JsonProperty("use_account_tax", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseAccountTax { get; set; } 

        [JsonProperty("use_xero_for_sending", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseXeroForSending { get; set; } 

        [JsonProperty("trial_purchase_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TrialPurchaseUrl { get; set; } 

        [JsonProperty("audit_teams_call", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AuditTeamsCall { get; set; } 

        [JsonProperty("itglue_sync_names", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ItGlueSyncNames { get; set; } 

        [JsonProperty("qbo_default_company", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? QboDefaultCompany { get; set; } 

        [JsonProperty("intaccttoplevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? IntacctTopLevel { get; set; } 

        [JsonProperty("logticketwhenchatend", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? LogTicketWhenChatEnd { get; set; } 

        [JsonProperty("intacct_sync_entities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? IntacctSyncEntities { get; set; } 

        [JsonProperty("chatendtickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ChatEndTicketType { get; set; } 

        [JsonProperty("chatendtickettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? ChatEndTicketTypeGuid { get; set; } 

        [JsonProperty("intacctinvoicetransactiondetail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? IntacctInvoiceTransactionDetail { get; set; } 

        [JsonProperty("showcustomerlevelprepay", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowCustomerLevelPrepay { get; set; } 

        [JsonProperty("lansweeper_dont_update_asset_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? LansweeperDontUpdateAssetType { get; set; } 

        [JsonProperty("navbar_new_ticket", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? NavbarNewTicket { get; set; } 

        [JsonProperty("added_view_customer_perm", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AddedViewCustomerPerm { get; set; } 

        [JsonProperty("quotepricedp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? QuotePriceDp { get; set; } 

        [JsonProperty("defaultassetstatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultAssetStatus { get; set; } 

        [JsonProperty("negativefeedbackcomment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? NegativeFeedbackComment { get; set; } 

        [JsonProperty("sage50cacompanypath", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sage50CaCompanyPath { get; set; } 

        [JsonProperty("sage50causername", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sage50CaUsername { get; set; } 

        [JsonProperty("usehaloinvoiceidforaccounts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseHaloInvoiceIdForAccounts { get; set; } 

        [JsonProperty("reviewnotbillable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReviewNotBillable { get; set; } 

        [JsonProperty("autofollowonbehalf", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoFollowOnBehalf { get; set; } 

        [JsonProperty("mandatorytags", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? MandatoryTags { get; set; } 

        [JsonProperty("updatecurrencytableautomatically", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UpdateCurrencyTableAutomatically { get; set; } 

        [JsonProperty("intacctdefaultlocid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? IntacctDefaultLocId { get; set; } 

        [JsonProperty("anonymoususer_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AnonymousUserId { get; set; } 

        [JsonProperty("anonymoususer_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AnonymousUserName { get; set; } 

        [JsonProperty("globalaccountsbccemailaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? GlobalAccountsBccEmailAddress { get; set; } 

        [JsonProperty("mandatoryfaqlist", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? MandatoryFaqList { get; set; } 

        [JsonProperty("teamscallmethod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TeamsCallMethod { get; set; } 

        [JsonProperty("stripe_public_key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? StripePublicKey { get; set; } 

        [JsonProperty("stripe_currency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? StripeCurrency { get; set; } 

        [JsonProperty("addigy_defaultassetsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AddigyDefaultAssetSite { get; set; } 

        [JsonProperty("addigy_defaultassetgroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AddigyDefaultAssetGroup { get; set; } 

        [JsonProperty("addigy_defaultassetgroup_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? AddigyDefaultAssetGroupGuid { get; set; } 

        [JsonProperty("addigy_assettypefield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AddigyAssetTypeField { get; set; } 

        [JsonProperty("addigy_deactivate_assets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AddigyDeactivateAssets { get; set; } 

        [JsonProperty("addigy_enable_alerting", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AddigyEnableAlerting { get; set; } 

        [JsonProperty("addigy_alert_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AddigyAlertType { get; set; } 

        [JsonProperty("addigy_alert_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AddigyAlertUser { get; set; } 

        [JsonProperty("domotz_dont_update_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DomotzDontUpdateSite { get; set; } 

        [JsonProperty("showtoplevelontickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowTopLevelOnTickets { get; set; } 

        [JsonProperty("automatetimezone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AutomateTimezone { get; set; } 

        [JsonProperty("recurringitembillingdescriptionlong", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? RecurringItemBillingDescriptionLong { get; set; } 

        [JsonProperty("sage50cadefaultpaidtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sage50CaDefaultPaidType { get; set; } 

        [JsonProperty("sage50cadefaultpaidaccount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sage50CaDefaultPaidAccount { get; set; } 

        [JsonProperty("deleterowconfirmation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DeleteRowConfirmation { get; set; } 

        [JsonProperty("salesforce_toplevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SalesforceTopLevel { get; set; } 

        [JsonProperty("logactionforapprovalresponse", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? LogActionForApprovalResponse { get; set; } 

        [JsonProperty("salesforce_accountwhere", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SalesforceAccountWhere { get; set; } 

        [JsonProperty("liongardassettypefield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LiongardAssetTypeField { get; set; } 

        [JsonProperty("salesforce_contactwhere", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SalesforceContactWhere { get; set; } 

        [JsonProperty("liongard_toplevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LiongardTopLevel { get; set; } 

        [JsonProperty("salesforce_opportunitywhere", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SalesforceOpportunityWhere { get; set; } 

        [JsonProperty("liongard_defaultsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LiongardDefaultSite { get; set; } 

        [JsonProperty("salesforce_casewhere", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SalesforceCaseWhere { get; set; } 

        [JsonProperty("liongard_defaultgroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LiongardDefaultGroup { get; set; } 

        [JsonProperty("liongard_defaultgroup_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? LiongardDefaultGroupGuid { get; set; } 

        [JsonProperty("salesforce_integratorentitiestoimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SalesforceIntegratorEntitiesToImport { get; set; } 

        [JsonProperty("salesforce_updateaddresses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SalesforceUpdateAddresses { get; set; } 

        [JsonProperty("liongard_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LiongardImportType { get; set; } 

        [JsonProperty("salesforce_casetickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SalesforceCaseTicketType { get; set; } 

        [JsonProperty("salesforce_casetickettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? SalesforceCaseTicketTypeGuid { get; set; } 

        [JsonProperty("liongard_delete_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? LiongardDeleteDevices { get; set; } 

        [JsonProperty("salesforce_integratoraccountlastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? SalesforceIntegratorAccountLastSync { get; set; } 

        [JsonProperty("liongard_customer_sync_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LiongardCustomerSyncType { get; set; } 

        [JsonProperty("salesforce_integratorcontactlastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? SalesforceIntegratorContactLastSync { get; set; } 

        [JsonProperty("sync_liongard_customer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SyncLiongardCustomer { get; set; } 

        [JsonProperty("salesforce_integratoropportunitylastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? SalesforceIntegratorOpportunityLastSync { get; set; } 

        [JsonProperty("show_liongard_success", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowLiongardSuccess { get; set; } 

        [JsonProperty("accmanagershowextradetails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AccManagerShowExtraDetails { get; set; } 

        [JsonProperty("ingram_micro_update_addresses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IngramMicroUpdateAddresses { get; set; } 

        [JsonProperty("ingram_micro_top_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? IngramMicroTopLevel { get; set; } 

        [JsonProperty("ingram_micro_import_entities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? IngramMicroImportEntities { get; set; } 

        [JsonProperty("pax8_update_addresses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Pax8UpdateAddresses { get; set; } 

        [JsonProperty("pax8_top_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Pax8TopLevel { get; set; } 

        [JsonProperty("pax8_import_entities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Pax8ImportEntities { get; set; } 

        [JsonProperty("salesforce_integratorcaselastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? SalesforceIntegratorCaseLastSync { get; set; } 

        [JsonProperty("sendclosureremindertoccaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SendClosureReminderToCcAddress { get; set; } 

        [JsonProperty("exchange_organizer_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ExchangeOrganizerOverride { get; set; } 

        [JsonProperty("showtickettypeselection", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowTicketTypeSelection { get; set; } 

        [JsonProperty("azure_federation_domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AzureFederationDomain { get; set; } 

        [JsonProperty("azure_auto_create_users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AzureAutoCreateUsers { get; set; } 

        [JsonProperty("azure_auto_creation_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AzureAutoCreationSite { get; set; } 

        [JsonProperty("azureb2c_domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AzureB2CDomain { get; set; } 

        [JsonProperty("azureb2c_user_flow", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AzureB2CUserFlow { get; set; } 

        [JsonProperty("azure_login_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AzureLoginUrl { get; set; } 

        [JsonProperty("usercanviewapprovedtickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UserCanViewApprovedTickets { get; set; } 

        [JsonProperty("reauthorizeforapprovals", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReauthorizeForApprovals { get; set; } 

        [JsonProperty("default_itemgroups_hideitems", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DefaultItemGroupsHideItems { get; set; } 

        [JsonProperty("enableshifts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableShifts { get; set; } 

        [JsonProperty("newrelic_tickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewrelicTicketType { get; set; } 

        [JsonProperty("newrelic_tickettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? NewrelicTicketTypeGuid { get; set; } 

        [JsonProperty("newrelic_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewrelicUser { get; set; } 

        [JsonProperty("backupradar_alert_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? BackupRadarAlertType { get; set; } 

        [JsonProperty("rbackupradarapiurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? RBackupRadarApiUrl { get; set; } 

        [JsonProperty("rbackupradarapikey", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? RBackupRadarApiKey { get; set; } 

        [JsonProperty("userscanviewitems", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UsersCanViewItems { get; set; } 

        [JsonProperty("use_tickettab_areas", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseTicketTabAreas { get; set; } 

        [JsonProperty("split_childtickets_tab", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SplitChildTicketsTab { get; set; } 

        [JsonProperty("enable_contract_calculated_cost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableContractCalculatedCost { get; set; } 

        [JsonProperty("cipp_instance_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CippInstanceUrl { get; set; } 

        [JsonProperty("auto_create_next_asset_tag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoCreateNextAssetTag { get; set; } 

        [JsonProperty("bookingshowphonenumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? BookingShowPhoneNumber { get; set; } 

        [JsonProperty("bookingshowemailaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? BookingShowEmailAddress { get; set; } 

        [JsonProperty("intacctdefaultdepid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? IntacctDefaultDepId { get; set; } 

        [JsonProperty("enablezoomcall", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableZoomCall { get; set; } 

        [JsonProperty("enable_comparative_quoting", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableComparativeQuoting { get; set; } 

        [JsonProperty("ncentral_delete_clients", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? NCentralDeleteClients { get; set; } 

        [JsonProperty("ncentral_delete_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? NCentralDeleteDevices { get; set; } 

        [JsonProperty("gc_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? GcClientId { get; set; } 

        [JsonProperty("kaseya_defaultsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? KaseyaDefaultSite { get; set; } 

        [JsonProperty("kaseya_defaultassettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? KaseyaDefaultAssetType { get; set; } 

        [JsonProperty("kaseya_defaultassettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? KaseyaDefaultAssetTypeGuid { get; set; } 

        [JsonProperty("kaseya_enable_alerting", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? KaseyaEnableAlerting { get; set; } 

        [JsonProperty("kaseya_alert_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? KaseyaAlertType { get; set; } 

        [JsonProperty("kaseya_alert_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? KaseyaAlertUser { get; set; } 

        [JsonProperty("kaseya_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? KaseyaImportType { get; set; } 

        [JsonProperty("kaseya_delete_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? KaseyaDeleteDevices { get; set; } 

        [JsonProperty("kaseyaservicedesks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? KaseyaServiceDesksNoSpaces { get; set; } 

        [JsonProperty("migration_ticket_end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? MigrationTicketEndDate { get; set; } 

        [JsonProperty("invoicelongdescriptionfromsalesorder", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? InvoiceLongDescriptionFromSalesOrder { get; set; } 

        [JsonProperty("dbc_default_company", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DbcDefaultCompany { get; set; } 

        [JsonProperty("enable_legacy_dbc_integration", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableLegacyDbcIntegration { get; set; } 

        [JsonProperty("salesforce_accountsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SalesforceAccountSync { get; set; } 

        [JsonProperty("salesforce_contactsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SalesforceContactSync { get; set; } 

        [JsonProperty("salesforce_show_success_message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SalesforceShowSuccessMessage { get; set; } 

        [JsonProperty("salesforce_include_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SalesforceIncludeAddress { get; set; } 

        [JsonProperty("salesforce_deafult_stage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SalesforceDefaultStage { get; set; } 

        [JsonProperty("hide_consignment_costs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HideConsignmentCosts { get; set; } 

        [JsonProperty("select_consignment_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SelectConsignmentUser { get; set; } 

        [JsonProperty("select_consignment_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SelectConsignmentStatus { get; set; } 

        [JsonProperty("defaultconsignmentpdftemplate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultConsignmentPdfTemplate { get; set; } 

        [JsonProperty("stripenotificationemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? StripeNotificationEmail { get; set; } 

        [JsonProperty("enableautostripepayment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableAutoStripePayment { get; set; } 

        [JsonProperty("stripepaymentmethodoptions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? StripePaymentMethodOptions { get; set; } 

        [JsonProperty("zabbix_default_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ZabbixDefaultType { get; set; } 

        [JsonProperty("zabbix_default_type_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? ZabbixDefaultTypeGuid { get; set; } 

        [JsonProperty("zabbix_default_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ZabbixDefaultSite { get; set; } 

        [JsonProperty("zabbix_dont_update_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ZabbixDontUpdateType { get; set; } 

        [JsonProperty("zabbix_dont_update_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ZabbixDontUpdateSite { get; set; } 

        [JsonProperty("zabbix_delete_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ZabbixDeleteDevices { get; set; } 

        [JsonProperty("show_favourite_services", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowFavouriteServices { get; set; } 

        [JsonProperty("slack_ticket_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SlackTicketType { get; set; } 

        [JsonProperty("allow_password_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowPasswordOverride { get; set; } 

        [JsonProperty("password_strength_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PasswordStrengthLevel { get; set; } 

        [JsonProperty("force_agent_2fa", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ForceAgent2Fa { get; set; } 

        [JsonProperty("giacom_top_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? GiacomTopLevel { get; set; } 

        [JsonProperty("giacom_import_entities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? GiacomImportEntities { get; set; } 

        [JsonProperty("rhipe_update_addresses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? RhipeUpdateAddresses { get; set; } 

        [JsonProperty("rhipe_top_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? RhipeTopLevel { get; set; } 

        [JsonProperty("rhipe_import_entities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? RhipeImportEntities { get; set; } 

        [JsonProperty("techdata_top_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TechDataTopLevel { get; set; } 

        [JsonProperty("techdata_import_entities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TechDataImportEntities { get; set; } 

        [JsonProperty("inty_update_addresses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IntyUpdateAddresses { get; set; } 

        [JsonProperty("inty_top_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? IntyTopLevel { get; set; } 

        [JsonProperty("inty_import_entities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? IntyImportEntities { get; set; } 

        [JsonProperty("westcoastcloud_update_addresses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? WestCoastCloudUpdateAddresses { get; set; } 

        [JsonProperty("westcoastcloud_top_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? WestCoastCloudTopLevel { get; set; } 

        [JsonProperty("westcoastcloud_import_entities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? WestCoastCloudImportEntities { get; set; } 

        [JsonProperty("sherweb_top_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SherwebTopLevel { get; set; } 

        [JsonProperty("sherweb_import_entities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SherwebImportEntities { get; set; } 

        [JsonProperty("also_update_addresses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AlsoUpdateAddresses { get; set; } 

        [JsonProperty("also_top_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AlsoTopLevel { get; set; } 

        [JsonProperty("also_import_entities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AlsoImportEntities { get; set; } 

        [JsonProperty("arrowsphere_update_addresses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ArrowSphereUpdateAddresses { get; set; } 

        [JsonProperty("arrowsphere_top_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ArrowSphereTopLevel { get; set; } 

        [JsonProperty("arrowsphere_import_entities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ArrowSphereImportEntities { get; set; } 

        [JsonProperty("dickerdata_update_addresses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DickerDataUpdateAddresses { get; set; } 

        [JsonProperty("dickerdata_top_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DickerDataTopLevel { get; set; } 

        [JsonProperty("dickerdata_import_entities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DickerDataImportEntities { get; set; } 

        [JsonProperty("oracle_email_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OracleEmailAddress { get; set; } 

        [JsonProperty("slack_ticket_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SlackTicketUser { get; set; } 

        [JsonProperty("autocomplete_email_address_behaviour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AutocompleteEmailAddressBehaviour { get; set; } 

        [JsonProperty("override_assertion_endpoint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OverrideAssertionEndpoint { get; set; } 

        [JsonProperty("noactionsaftermerge", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? NoActionsAfterMerge { get; set; } 

        [JsonProperty("default_filter_id_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultFilterIdTickets { get; set; } 

        [JsonProperty("default_filter_id_tickets_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? DefaultFilterIdTicketsGuid { get; set; } 

        [JsonProperty("default_columns_id_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultColumnsIdTickets { get; set; } 

        [JsonProperty("default_columns_id_tickets_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? DefaultColumnsIdTicketsGuid { get; set; } 

        [JsonProperty("default_view_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultViewTickets { get; set; } 

        [JsonProperty("default_view_tickets_selectedid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultViewTicketsSelectedId { get; set; } 

        [JsonProperty("default_view_tickets_selected_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? DefaultViewTicketsSelectedGuid { get; set; } 

        [JsonProperty("default_filter_id_opps", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultFilterIdOpps { get; set; } 

        [JsonProperty("default_filter_id_opps_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? DefaultFilterIdOppsGuid { get; set; } 

        [JsonProperty("default_columns_id_opps", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultColumnsIdOpps { get; set; } 

        [JsonProperty("default_columns_id_opps_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? DefaultColumnsIdOppsGuid { get; set; } 

        [JsonProperty("default_view_opps", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultViewOpps { get; set; } 

        [JsonProperty("default_view_opps_selectedid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultViewOppsSelectedId { get; set; } 

        [JsonProperty("default_view_opps_selected_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? DefaultViewOppsSelectedGuid { get; set; } 

        [JsonProperty("forwardinboundupdates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ForwardInboundUpdates { get; set; } 

        [JsonProperty("usetechfwdfunctionality", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseTechFwdFunctionality { get; set; } 

        [JsonProperty("techupdatesareprivate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? TechUpdatesArePrivate { get; set; } 

        [JsonProperty("smtpdisplayname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SmtpDisplayName { get; set; } 

        [JsonProperty("attachmentsizelimitmb", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AttachmentSizeLimitMb { get; set; } 

        [JsonProperty("respondprivate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? RespondPrivate { get; set; } 

        [JsonProperty("default_client", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultClient { get; set; } 

        [JsonProperty("force_accounts_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ForceAccountsId { get; set; } 

        [JsonProperty("new_client_template_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewClientTemplateId { get; set; } 

        [JsonProperty("default_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultSite { get; set; } 

        [JsonProperty("default_clientsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultClientSiteName { get; set; } 

        [JsonProperty("deleteforever", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DeleteForever { get; set; } 

        [JsonProperty("parentstatusafterallchildclosed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ParentStatusAfterAllChildClosed { get; set; } 

        [JsonProperty("parentstatusafterallchildclosed_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? ParentStatusAfterAllChildClosedGuid { get; set; } 

        [JsonProperty("newchilduserisagent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? NewChildUserIsAgent { get; set; } 

        [JsonProperty("percentage_to_survey", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PercentageToSurvey { get; set; } 

        [JsonProperty("feedback_tickettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? FeedbackTicketTypeId { get; set; } 

        [JsonProperty("feedback_tickettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? FeedbackTicketTypeGuid { get; set; } 

        [JsonProperty("allowcabchoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowCabChoice { get; set; } 

        [JsonProperty("showlbandrr", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowLbandrr { get; set; } 

        [JsonProperty("showlbandrrinactions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowLbandrrInActions { get; set; } 

        [JsonProperty("onlyrrorlbtologgedintechs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? OnlyRrorLbToLoggedInTechs { get; set; } // maybe a spelling mistake -- unsure 03/08/25

        [JsonProperty("roundrobinreassign", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? RoundRobinReassign { get; set; } 

        [JsonProperty("loadbalanceuseestimates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? LoadBalanceUseEstimates { get; set; } 

        [JsonProperty("loadbalanceonfollowupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? LoadBalanceOnFollowUpdate { get; set; } 

        [JsonProperty("appointmentslaprocedure", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AppointmentsLaProcedure { get; set; } 

        [JsonProperty("holiday_agentstatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? HolidayAgentStatus { get; set; } 

        [JsonProperty("changeshowchangedetails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ChangeShowChangeDetails { get; set; } 

        [JsonProperty("changeshowjustification", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ChangeShowJustification { get; set; } 

        [JsonProperty("changeshowimpact", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ChangeShowImpact { get; set; } 

        [JsonProperty("changeshowrisk", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ChangeShowRisk { get; set; } 

        [JsonProperty("changeshowbackout", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ChangeShowBackout { get; set; } 

        [JsonProperty("changeshowcommunication", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ChangeShowCommunication { get; set; } 

        [JsonProperty("changeshowtest", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ChangeShowTest { get; set; } 

        [JsonProperty("use_release1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseRelease1 { get; set; } 

        [JsonProperty("use_release2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseRelease2 { get; set; } 

        [JsonProperty("use_release3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseRelease3 { get; set; } 

        [JsonProperty("release1_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Release1Name { get; set; } 

        [JsonProperty("release2_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Release2Name { get; set; } 

        [JsonProperty("release3_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Release3Name { get; set; } 

        [JsonProperty("release2_autoupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Release2Autoupdate { get; set; } 

        [JsonProperty("release3_autoupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Release3Autoupdate { get; set; } 

        [JsonProperty("release_includeunsentnotesinemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ReleaseIncludeUnsentNotesInEmail { get; set; } 

        [JsonProperty("release_category", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ReleaseCategory { get; set; } 

        [JsonProperty("workflow_preview_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? WorkflowPreviewType { get; set; } 

        [JsonProperty("usepaygafterprepay", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UsePaygAfterPrepay { get; set; } 

        [JsonProperty("calcincminticketlevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? CalcIncMinTicketLevel { get; set; } 

        [JsonProperty("continueusingrulesafterlogging", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ContinueUsingRulesAfterLogging { get; set; } 

        [JsonProperty("defaultlanguage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultLanguage { get; set; } 

        [JsonProperty("enablemultilanguage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableMultiLanguage { get; set; } 

        [JsonProperty("reassign_limit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ReassignLimit { get; set; } 

        [JsonProperty("app_colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AppColour { get; set; } 

        [JsonProperty("enablekbmatching", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableKbMatching { get; set; } 

        [JsonProperty("kbmatchingcategorymatch", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? KbMatchingCategoryMatch { get; set; } 

        [JsonProperty("kbaddshowpreview", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? KbAddShowPreview { get; set; } 

        [JsonProperty("enablefulltextsearch", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableFullTextSearch { get; set; } 

        [JsonProperty("problemmatchcategorymatch", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ProblemMatchCategoryMatch { get; set; } 

        [JsonProperty("problemmatchautoproblemnew", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ProblemMatchAutoProblemNew { get; set; } 

        [JsonProperty("problemmatchautoincidentnew", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ProblemMatchAutoIncidentNew { get; set; } 

        [JsonProperty("problemmatchautoproblemview", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ProblemMatchAutoProblemView { get; set; } 

        [JsonProperty("problemmatchautoincidentview", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ProblemMatchAutoIncidentView { get; set; } 

        [JsonProperty("quicktimertid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? QuickTimerTid { get; set; } 

        [JsonProperty("smsprovideraddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SmsProviderAddress { get; set; } 

        [JsonProperty("smsfromaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SmsFromAddress { get; set; } 

        [JsonProperty("new_smsppassword", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewSmsPassword { get; set; } 

        [JsonProperty("smsdisplay", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SmsDisplay { get; set; } 

        [JsonProperty("autostarttimer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoStartTimer { get; set; } 

        [JsonProperty("opentickettimer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? OpenTicketTimer { get; set; } 

        [JsonProperty("enablequickclose", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableQuickClose { get; set; } 

        [JsonProperty("sendemailsviawebapp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SendEmailsViaWebApp { get; set; } 

        [JsonProperty("showchildunreadinlist", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowChildUnreadInList { get; set; } 

        [JsonProperty("storekbattachmentsindb", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? StoreKbAttachmentsInDb { get; set; } 

        [JsonProperty("kbmatchcustomfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? KbMatchCustomFields { get; set; } 

        [JsonProperty("kbmatchignoresubject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? KbMatchIgnoreSubject { get; set; } 

        [JsonProperty("enablecollisiondetection", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableCollisionDetection { get; set; } 

        [JsonProperty("mustclosewithaction", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? MustCloseWithAction { get; set; } 

        [JsonProperty("dontshowclosurestatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DontShowClosureStatus { get; set; } 

        [JsonProperty("usetechtimesheets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseTechTimesheets { get; set; } 

        [JsonProperty("allowquicktime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowQuickTime { get; set; } 

        [JsonProperty("livechatallowusers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? LiveChatAllowUsers { get; set; } 

        [JsonProperty("livechatallowvisitors", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? LiveChatAllowVisitors { get; set; } 

        [JsonProperty("livechattechmustonline", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? LiveChatTechMustOnline { get; set; } 

        [JsonProperty("livechatworkhours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LiveChatWorkHours { get; set; } 

        [JsonProperty("livechattechnamevisibility", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LiveChatTechNameVisibility { get; set; } 

        [JsonProperty("livechattechnamevisibilitytext", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? LiveChatTechNameVisibilityText { get; set; } 

        [JsonProperty("livechatnewchatmsg", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? LiveChatNewChatMsg { get; set; } 

        [JsonProperty("livechatincludeemailinname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? LiveChatIncludeEmailInName { get; set; } 

        [JsonProperty("passwordreseturl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PasswordResetUrl { get; set; } 

        [JsonProperty("passwordenrollurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PasswordEnrollUrl { get; set; } 

        [JsonProperty("questioncount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? QuestionCount { get; set; } 

        [JsonProperty("hideusersanswers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HideUsersAnswers { get; set; } 

        [JsonProperty("quickstatuschangeallowed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? QuickStatusChangeAllowed { get; set; } 

        [JsonProperty("quickagentchangeallowed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? QuickAgentChangeAllowed { get; set; } 

        [JsonProperty("calendarstepinterval", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CalendarStepInterval { get; set; } 

        [JsonProperty("callrequesttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CallRequestType { get; set; } 

        [JsonProperty("callrequesttype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? CallRequestTypeGuid { get; set; } 

        [JsonProperty("callsendack", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CallSendAck { get; set; } 

        [JsonProperty("showspambutton", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowSpamButton { get; set; } 

        [JsonProperty("shownewcallbtn", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowNewCallBtn { get; set; } 

        [JsonProperty("showsendemailbtn", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowSendEmailBtn { get; set; } 

        [JsonProperty("actioncalendardefault", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ActionCalendarDefault { get; set; } 

        [JsonProperty("homescreenchartid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? HomeScreenChartId { get; set; } 

        [JsonProperty("alluse2fa", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllUse2Fa { get; set; } 

        [JsonProperty("hidechangemanagementtab", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HideChangeManagementTab { get; set; } 

        [JsonProperty("problemmatchingposition", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ProblemMatchingPosition { get; set; } 

        [JsonProperty("default_opp_tickettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultOppTicketTypeId { get; set; } 

        [JsonProperty("default_opp_tickettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? DefaultOppTicketTypeGuid { get; set; } 

        [JsonProperty("default_client_opps", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultClientOpps { get; set; } 
}