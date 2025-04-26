using Newtonsoft.Json;

namespace Angelic.Configuration.Advanced.Controls;

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
        public int? PassportalClienttoplevel { get; set; } 

        [JsonProperty("passportal_defaultusersite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PassportalDefaultusersite { get; set; } 

        [JsonProperty("passportal_defaultassetsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PassportalDefaultassetsite { get; set; } 

        [JsonProperty("rpassportal_integratorentitiestoimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? RpassportalIntegratorentitiestoimport { get; set; } 

        [JsonProperty("passportal_defaultassetgroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PassportalDefaultassetgroup { get; set; } 

        [JsonProperty("passportal_defaultassetgroup_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? PassportalDefaultassetgroupGuid { get; set; } 

        [JsonProperty("passportal_deactivate_assets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? PassportalDeactivateAssets { get; set; } 

        [JsonProperty("auvik_top_level_domain_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AuvikTopLevelDomainId { get; set; } 

        [JsonProperty("auvik_top_level_domain_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AuvikTopLevelDomainName { get; set; } 

        [JsonProperty("qbononinventoryitemgroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Qbononinventoryitemgroup { get; set; } 

        [JsonProperty("showmailboxname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowMailboxname { get; set; } 

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
        public bool? ItglueSyncNames { get; set; } 

        [JsonProperty("qbo_default_company", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? QboDefaultCompany { get; set; } 

        [JsonProperty("intaccttoplevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Intaccttoplevel { get; set; } 

        [JsonProperty("logticketwhenchatend", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Logticketwhenchatend { get; set; } 

        [JsonProperty("intacct_sync_entities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? IntacctSyncEntities { get; set; } 

        [JsonProperty("chatendtickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Chatendtickettype { get; set; } 

        [JsonProperty("chatendtickettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? ChatendtickettypeGuid { get; set; } 

        [JsonProperty("intacctinvoicetransactiondetail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intacctinvoicetransactiondetail { get; set; } 

        [JsonProperty("showcustomerlevelprepay", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowCustomerlevelprepay { get; set; } 

        [JsonProperty("lansweeper_dont_update_asset_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? LansweeperDontUpdateAssetType { get; set; } 

        [JsonProperty("navbar_new_ticket", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? NavbarNewTicket { get; set; } 

        [JsonProperty("added_view_customer_perm", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AddedViewCustomerPerm { get; set; } 

        [JsonProperty("quotepricedp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Quotepricedp { get; set; } 

        [JsonProperty("defaultassetstatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Defaultassetstatus { get; set; } 

        [JsonProperty("negativefeedbackcomment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Negativefeedbackcomment { get; set; } 

        [JsonProperty("sage50cacompanypath", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sage50Cacompanypath { get; set; } 

        [JsonProperty("sage50causername", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sage50Causername { get; set; } 

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
        public int? AnonymoususerId { get; set; } 

        [JsonProperty("anonymoususer_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AnonymoususerName { get; set; } 

        [JsonProperty("globalaccountsbccemailaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Globalaccountsbccemailaddress { get; set; } 

        [JsonProperty("mandatoryfaqlist", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Mandatoryfaqlist { get; set; } 

        [JsonProperty("teamscallmethod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Teamscallmethod { get; set; } 

        [JsonProperty("stripe_public_key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? StripePublicKey { get; set; } 

        [JsonProperty("stripe_currency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? StripeCurrency { get; set; } 

        [JsonProperty("addigy_defaultassetsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AddigyDefaultassetsite { get; set; } 

        [JsonProperty("addigy_defaultassetgroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AddigyDefaultassetgroup { get; set; } 

        [JsonProperty("addigy_defaultassetgroup_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? AddigyDefaultassetgroupGuid { get; set; } 

        [JsonProperty("addigy_assettypefield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AddigyAssetTypefield { get; set; } 

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
        public bool? ShowToplevelontickets { get; set; } 

        [JsonProperty("automatetimezone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Automatetimezone { get; set; } 

        [JsonProperty("recurringitembillingdescriptionlong", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Recurringitembillingdescriptionlong { get; set; } 

        [JsonProperty("sage50cadefaultpaidtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sage50Cadefaultpaidtype { get; set; } 

        [JsonProperty("sage50cadefaultpaidaccount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sage50Cadefaultpaidaccount { get; set; } 

        [JsonProperty("deleterowconfirmation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Deleterowconfirmation { get; set; } 

        [JsonProperty("salesforce_toplevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SalesforceToplevel { get; set; } 

        [JsonProperty("logactionforapprovalresponse", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Logactionforapprovalresponse { get; set; } 

        [JsonProperty("salesforce_accountwhere", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SalesforceAccountwhere { get; set; } 

        [JsonProperty("liongardassettypefield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Liongardassettypefield { get; set; } 

        [JsonProperty("salesforce_contactwhere", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SalesforceContactwhere { get; set; } 

        [JsonProperty("liongard_toplevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LiongardToplevel { get; set; } 

        [JsonProperty("salesforce_opportunitywhere", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SalesforceOpportunitywhere { get; set; } 

        [JsonProperty("liongard_defaultsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LiongardDefaultSite { get; set; } 

        [JsonProperty("salesforce_casewhere", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SalesforceCasewhere { get; set; } 

        [JsonProperty("liongard_defaultgroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LiongardDefaultgroup { get; set; } 

        [JsonProperty("liongard_defaultgroup_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? LiongardDefaultgroupGuid { get; set; } 

        [JsonProperty("salesforce_integratorentitiestoimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SalesforceIntegratorentitiestoimport { get; set; } 

        [JsonProperty("salesforce_updateaddresses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SalesforceUpdateaddresses { get; set; } 

        [JsonProperty("liongard_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LiongardImportType { get; set; } 

        [JsonProperty("salesforce_casetickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SalesforceCasetickettype { get; set; } 

        [JsonProperty("salesforce_casetickettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? SalesforceCasetickettypeGuid { get; set; } 

        [JsonProperty("liongard_delete_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? LiongardDeleteDevices { get; set; } 

        [JsonProperty("salesforce_integratoraccountlastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? SalesforceIntegratoraccountlastsync { get; set; } 

        [JsonProperty("liongard_customer_sync_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LiongardCustomerSyncType { get; set; } 

        [JsonProperty("salesforce_integratorcontactlastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? SalesforceIntegratorcontactlastsync { get; set; } 

        [JsonProperty("sync_liongard_customer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SyncLiongardCustomer { get; set; } 

        [JsonProperty("salesforce_integratoropportunitylastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? SalesforceIntegratoropportunitylastsync { get; set; } 

        [JsonProperty("show_liongard_success", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowLiongardSuccess { get; set; } 

        [JsonProperty("accmanagershowextradetails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Accmanagershowextradetails { get; set; } 

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
        public DateTimeOffset? SalesforceIntegratorcaselastsync { get; set; } 

        [JsonProperty("sendclosureremindertoccaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sendclosureremindertoccaddress { get; set; } 

        [JsonProperty("exchange_organizer_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ExchangeOrganizerOverride { get; set; } 

        [JsonProperty("showtickettypeselection", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ShowTicketTypeselection { get; set; } 

        [JsonProperty("azure_federation_domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AzureFederationDomain { get; set; } 

        [JsonProperty("azure_auto_create_users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AzureAutoCreateUsers { get; set; } 

        [JsonProperty("azure_auto_creation_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AzureAutoCreationSite { get; set; } 

        [JsonProperty("azureb2c_domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Azureb2CDomain { get; set; } 

        [JsonProperty("azureb2c_user_flow", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Azureb2CUserFlow { get; set; } 

        [JsonProperty("azure_login_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AzureLoginUrl { get; set; } 

        [JsonProperty("usercanviewapprovedtickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Usercanviewapprovedtickets { get; set; } 

        [JsonProperty("reauthorizeforapprovals", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Reauthorizeforapprovals { get; set; } 

        [JsonProperty("default_itemgroups_hideitems", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DefaultItemgroupsHideitems { get; set; } 

        [JsonProperty("enableshifts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enableshifts { get; set; } 

        [JsonProperty("newrelic_tickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewrelicTicketType { get; set; } 

        [JsonProperty("newrelic_tickettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? NewrelicTicketTypeGuid { get; set; } 

        [JsonProperty("newrelic_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewrelicUser { get; set; } 

        [JsonProperty("backupradar_alert_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? BackupradarAlertType { get; set; } 

        [JsonProperty("rbackupradarapiurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Rbackupradarapiurl { get; set; } 

        [JsonProperty("rbackupradarapikey", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Rbackupradarapikey { get; set; } 

        [JsonProperty("userscanviewitems", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Userscanviewitems { get; set; } 

        [JsonProperty("use_tickettab_areas", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseTickettabAreas { get; set; } 

        [JsonProperty("split_childtickets_tab", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SplitChildticketsTab { get; set; } 

        [JsonProperty("enable_contract_calculated_cost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableContractCalculatedCost { get; set; } 

        [JsonProperty("cipp_instance_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CippInstanceUrl { get; set; } 

        [JsonProperty("auto_create_next_asset_tag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AutoCreateNextAssetTag { get; set; } 

        [JsonProperty("bookingshowphonenumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Bookingshowphonenumber { get; set; } 

        [JsonProperty("bookingshowemailaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Bookingshowemailaddress { get; set; } 

        [JsonProperty("intacctdefaultdepid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intacctdefaultdepid { get; set; } 

        [JsonProperty("enablezoomcall", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enablezoomcall { get; set; } 

        [JsonProperty("enable_comparative_quoting", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableComparativeQuoting { get; set; } 

        [JsonProperty("ncentral_delete_clients", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? NcentralDeleteClients { get; set; } 

        [JsonProperty("ncentral_delete_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? NcentralDeleteDevices { get; set; } 

        [JsonProperty("gc_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? GcClientId { get; set; } 

        [JsonProperty("kaseya_defaultsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? KaseyaDefaultSite { get; set; } 

        [JsonProperty("kaseya_defaultassettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? KaseyaDefaultassettype { get; set; } 

        [JsonProperty("kaseya_defaultassettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? KaseyaDefaultassettypeGuid { get; set; } 

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
        public string? Kaseyaservicedesks { get; set; } 

        [JsonProperty("migration_ticket_end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? MigrationTicketEndDate { get; set; } 

        [JsonProperty("invoicelongdescriptionfromsalesorder", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Invoicelongdescriptionfromsalesorder { get; set; } 

        [JsonProperty("dbc_default_company", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DbcDefaultCompany { get; set; } 

        [JsonProperty("enable_legacy_dbc_integration", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableLegacyDbcIntegration { get; set; } 

        [JsonProperty("salesforce_accountsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SalesforceAccountsync { get; set; } 

        [JsonProperty("salesforce_contactsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SalesforceContactsync { get; set; } 

        [JsonProperty("salesforce_show_success_message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SalesforceShowSuccessMessage { get; set; } 

        [JsonProperty("salesforce_include_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SalesforceIncludeAddress { get; set; } 

        [JsonProperty("salesforce_deafult_stage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SalesforceDeafultStage { get; set; } 

        [JsonProperty("hide_consignment_costs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HideConsignmentCosts { get; set; } 

        [JsonProperty("select_consignment_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SelectConsignmentUser { get; set; } 

        [JsonProperty("select_consignment_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SelectConsignmentStatus { get; set; } 

        [JsonProperty("defaultconsignmentpdftemplate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Defaultconsignmentpdftemplate { get; set; } 

        [JsonProperty("stripenotificationemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Stripenotificationemail { get; set; } 

        [JsonProperty("enableautostripepayment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enableautostripepayment { get; set; } 

        [JsonProperty("stripepaymentmethodoptions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Stripepaymentmethodoptions { get; set; } 

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
        public int? TechdataTopLevel { get; set; } 

        [JsonProperty("techdata_import_entities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TechdataImportEntities { get; set; } 

        [JsonProperty("inty_update_addresses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IntyUpdateAddresses { get; set; } 

        [JsonProperty("inty_top_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? IntyTopLevel { get; set; } 

        [JsonProperty("inty_import_entities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? IntyImportEntities { get; set; } 

        [JsonProperty("westcoastcloud_update_addresses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? WestcoastcloudUpdateAddresses { get; set; } 

        [JsonProperty("westcoastcloud_top_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? WestcoastcloudTopLevel { get; set; } 

        [JsonProperty("westcoastcloud_import_entities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? WestcoastcloudImportEntities { get; set; } 

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
        public bool? ArrowsphereUpdateAddresses { get; set; } 

        [JsonProperty("arrowsphere_top_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ArrowsphereTopLevel { get; set; } 

        [JsonProperty("arrowsphere_import_entities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ArrowsphereImportEntities { get; set; } 

        [JsonProperty("dickerdata_update_addresses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DickerdataUpdateAddresses { get; set; } 

        [JsonProperty("dickerdata_top_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DickerdataTopLevel { get; set; } 

        [JsonProperty("dickerdata_import_entities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DickerdataImportEntities { get; set; } 

        [JsonProperty("oracle_email_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OracleEmailAddress { get; set; } 

        [JsonProperty("slack_ticket_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SlackTicketUser { get; set; } 

        [JsonProperty("autocomplete_email_address_behaviour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AutocompleteEmailAddressBehaviour { get; set; } 

        [JsonProperty("override_assertion_endpoint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OverrideAssertionEndpoint { get; set; } 

        [JsonProperty("noactionsaftermerge", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Noactionsaftermerge { get; set; } 

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
        public int? DefaultViewTicketsSelectedid { get; set; } 

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
        public int? DefaultViewOppsSelectedid { get; set; } 

        [JsonProperty("default_view_opps_selected_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? DefaultViewOppsSelectedGuid { get; set; } 

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
        public int? DefaultClient { get; set; } 

        [JsonProperty("force_accounts_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ForceAccountsId { get; set; } 

        [JsonProperty("new_client_template_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NewClientTemplateId { get; set; } 

        [JsonProperty("default_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultSite { get; set; } 

        [JsonProperty("default_clientsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultClientsiteName { get; set; } 

        [JsonProperty("deleteforever", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Deleteforever { get; set; } 

        [JsonProperty("parentstatusafterallchildclosed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Parentstatusafterallchildclosed { get; set; } 

        [JsonProperty("parentstatusafterallchildclosed_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? ParentstatusafterallchildclosedGuid { get; set; } 

        [JsonProperty("newchilduserisagent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Newchilduserisagent { get; set; } 

        [JsonProperty("percentage_to_survey", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PercentageToSurvey { get; set; } 

        [JsonProperty("feedback_tickettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? FeedbackTicketTypeId { get; set; } 

        [JsonProperty("feedback_tickettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? FeedbackTicketTypeGuid { get; set; } 

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
        public int? HolidayAgentstatus { get; set; } 

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
        public bool? ReleaseIncludeunsentnotesinemail { get; set; } 

        [JsonProperty("release_category", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ReleaseCategory { get; set; } 

        [JsonProperty("workflow_preview_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? WorkflowPreviewType { get; set; } 

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
        public int? ReassignLimit { get; set; } 

        [JsonProperty("app_colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AppColour { get; set; } 

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
        public string? NewSmsppassword { get; set; } 

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
        public bool? ShowChildunreadinlist { get; set; } 

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
        public Guid? CallrequesttypeGuid { get; set; } 

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
        public bool? Alluse2Fa { get; set; } 

        [JsonProperty("hidechangemanagementtab", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hidechangemanagementtab { get; set; } 

        [JsonProperty("problemmatchingposition", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Problemmatchingposition { get; set; } 

        [JsonProperty("default_opp_tickettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultOppTicketTypeId { get; set; } 

        [JsonProperty("default_opp_tickettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? DefaultOppTicketTypeGuid { get; set; } 

        [JsonProperty("default_client_opps", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultClientOpps { get; set; } 
}