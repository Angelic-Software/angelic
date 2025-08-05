using System.CodeDom.Compiler;
using Angelic.Models.Configuration.Assets;
using Angelic.Models.Configuration.Assets.AssetTypes;
using Angelic.Models.Configuration.Integrations;
using Angelic.Models.Configuration.Integrations.Microsoft;
using Angelic.Models.Configuration.Integrations.Microsoft.Dynamics365;
using Angelic.Models.Configuration.Language;
using Angelic.Models.Configuration.TeamsAndAgents.Agents;
using Angelic.Models.Configuration.Tickets.TicketTypes;
using Angelic.Models.ExternalLinks;
using Angelic.Models.Invoice;
using Angelic.Models.KeyPairs;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Advanced.Controls;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public partial class Control
    {
        [JsonProperty("workspace_site_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLink>? WorkspaceSiteMappings { get; set; } 

        [JsonProperty("twilio_ticket_type_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TwilioTicketTypeName { get; set; } 

        [JsonProperty("twilio_default_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TwilioDefaultUserName { get; set; } 

        [JsonProperty("sccm_sqldriver", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SccmSqlDriver { get; set; } 

        [JsonProperty("sccm_sqlprovider", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SccmSqlProvider { get; set; } 

        [JsonProperty("lansweeper_sqldriver", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? LansweeperSqlDriver { get; set; } 

        [JsonProperty("lansweeper_sqlprovider", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LansweeperSqlProvider { get; set; } 

        [JsonProperty("processstreettickettypename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ProcessTreeTicketTypeName { get; set; } 

        [JsonProperty("processstreetusername", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ProcessTreeUsername { get; set; } 

        [JsonProperty("intacct_sync_halo_id_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? IntacctSyncHaloIdList { get; set; } 

        [JsonProperty("intacctdefaultlocid_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? IntacctDefaultLocIdList { get; set; } 

        [JsonProperty("intacct_warehouse_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? IntacctWarehouseMappings { get; set; } 

        [JsonProperty("teams_chat_tenant_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? TeamsChatTenantList { get; set; } 

        [JsonProperty("workspace_defaultsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? WorkspaceDefaultSiteName { get; set; } 

        [JsonProperty("halo_status_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? HaloStatusMappings { get; set; } 

        [JsonProperty("halo_priority_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? HaloPriorityMappings { get; set; } 

        [JsonProperty("etilizeurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? EtilizeUrl { get; set; } 

        [JsonProperty("barracuda_sitemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLink>? BarracudaSiteMappings { get; set; } 

        [JsonProperty("barracuda_clientmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLink>? BarracudaClientMappings { get; set; } 

        [JsonProperty("barracuda_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? BarracudaFieldMappings { get; set; } 

        [JsonProperty("logicmonitor_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? LogicMonitorFieldMappings { get; set; } 

        [JsonProperty("halointegrator_logicmonitor", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorLogicMonitor { get; set; } 

        [JsonProperty("halointegrator_logicmonitor_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorLogicMonitorLastSync { get; set; } 

        [JsonProperty("halointegrator_logicmonitor_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorLogicMonitorLastError { get; set; } 

        [JsonProperty("logicmonitor_defaultsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? LogicMonitorDefaultSiteName { get; set; } 

        [JsonProperty("logicmonitor_alert_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? LogicMonitorAlertUserName { get; set; } 

        [JsonProperty("logicmonitor_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? LogicMonitorUrl { get; set; } 

        [JsonProperty("halointegrator_barracuda", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorBarracuda { get; set; } 

        [JsonProperty("halointegrator_barracuda_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorBarracudaLastSync { get; set; } 

        [JsonProperty("halointegrator_barracuda_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorBarracudaLastError { get; set; } 

        [JsonProperty("barracuda_defaultsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? BarracudaDefaultSiteName { get; set; } 

        [JsonProperty("barracudadefaultassettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? BarracudaDefaultAssetTypeName { get; set; } 

        [JsonProperty("barracuda_alert_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? BarracudaAlertUserName { get; set; } 

        [JsonProperty("teams_chat_tenants", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TeamsChatTenants { get; set; } 

        [JsonProperty("teams_chat_welcome_message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TeamsChatWelcomeMessage { get; set; } 

        [JsonProperty("teams_chat_help_message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TeamsChatHelpMessage { get; set; } 

        [JsonProperty("gw_named_roles_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<StringIdNameKeyPair>? GwNamedRolesList { get; set; } 

        [JsonProperty("okta_named_roles_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<StringIdNameKeyPair>? OktaNamedRolesList { get; set; } 

        [JsonProperty("lansweeper_mappings_xtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AssetTypeMapping>? LansweeperMappingsXType { get; set; } 

        [JsonProperty("gw_userrolemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? GwUserRoleMappings { get; set; } 

        [JsonProperty("whatsapptickettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? WhatsappTicketTypeName { get; set; } 

        [JsonProperty("twilio_whatsapp_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TwilioWhatsappNumber { get; set; } 

        [JsonProperty("appointment_notification_body", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AppointmentNotificationBody { get; set; } 

        [JsonProperty("task_notification_body", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TaskNotificationBody { get; set; } 

        [JsonProperty("site24x7_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Site24X7FieldMappings { get; set; } 

        [JsonProperty("site24x7_alert_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Site24X7AlertUserName { get; set; } 

        [JsonProperty("gw_mappings_new_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? GwMappingsNewUser { get; set; } 

        [JsonProperty("okta_mappings_new_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? OktaMappingsNewUser { get; set; } 

        [JsonProperty("recaptcha_site_key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? RecaptchaSiteKey { get; set; } 

        [JsonProperty("jamf_site_links", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLink>? JamfSiteLinks { get; set; } 

        [JsonProperty("total_setup_steps", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalSetupSteps { get; set; } 

        [JsonProperty("completed_setup_steps", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? CompletedSetupSteps { get; set; } 

        [JsonProperty("cleardatakey", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ClearDataKey { get; set; } 

        [JsonProperty("halointegrator_icinga", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorIcinga { get; set; } 

        [JsonProperty("halointegrator_icinga_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorIcingaLastSync { get; set; } 

        [JsonProperty("halointegrator_icinga_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorIcingaLastError { get; set; } 

        [JsonProperty("icinga_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? IcingaFieldMappings { get; set; } 

        [JsonProperty("icinga_defaultsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? IcingaDefaultSiteName { get; set; } 

        [JsonProperty("icingadefaultassettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? IcingaDefaultAssetTypeName { get; set; } 

        [JsonProperty("icinga_sitemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationSiteMapping>? IcingaSiteMappings { get; set; } 

        [JsonProperty("icinga_alert_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? IcingaAlertUserName { get; set; } 

        [JsonProperty("default_columns_id_sites_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? DefaultColumnsIdSitesGuid { get; set; } 

        [JsonProperty("default_columns_id_users_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? DefaultColumnsIdUsersGuid { get; set; } 

        [JsonProperty("translations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<LanguagePackTranslationsCustom>? Translations { get; set; } 

        [JsonProperty("default_meter_tiers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<InvoiceDetailMeterTiers>? DefaultMeterTiers { get; set; } 

        [JsonProperty("connectwisermm_sitemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLink>? ConnectWiseRmmSiteMappings { get; set; } 

        [JsonProperty("connectwisermm_typemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AssetTypeMapping>? ConnectWiseRmmTypeMappings { get; set; } 

        [JsonProperty("connectwise_rmm_defaultclient_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ConnectWiseRmmDefaultClientName { get; set; } 

        [JsonProperty("halointegrator_connectwisermm", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorConnectWiseRmm { get; set; } 

        [JsonProperty("connectwisermm_import_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? ConnectWiseRmmImportEntitiesList { get; set; } 

        [JsonProperty("halointegrator_connectwisermm_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorConnectWiseRmmLastSync { get; set; } 

        [JsonProperty("halointegrator_connectwisermm_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorConnectWiseRmmLastError { get; set; } 

        [JsonProperty("cookiemessage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CookieMessage { get; set; } 

        [JsonProperty("icinga_xtype_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AssetTypeMapping>? IcingaXTypeMappings { get; set; } 

        [JsonProperty("logicmonitor_xtype_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AssetTypeMapping>? LogicMonitorXTypeMappings { get; set; } 

        [JsonProperty("shopifydefaultsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ShopifyDefaultSiteName { get; set; } 

        [JsonProperty("shopify_userfieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? ShopifyUserFieldMappings { get; set; } 

        [JsonProperty("shopify_customerfieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? ShopifyCustomerFieldMappings { get; set; } 

        [JsonProperty("halointegrator_shopify", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorShopify { get; set; } 

        [JsonProperty("halointegrator_shopify_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorShopifyLastSync { get; set; } 

        [JsonProperty("halointegrator_shopify_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorShopifyLastError { get; set; } 

        [JsonProperty("shopify_import_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? ShopifyImportEntitiesList { get; set; } 

        [JsonProperty("intacct_invoicefieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? IntacctInvoiceFieldMappings { get; set; } 

        [JsonProperty("intacct_invoicelinefieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? IntacctInvoiceLineFieldMappings { get; set; } 

        [JsonProperty("intacct_orderfieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? IntacctOrderFieldMappings { get; set; } 

        [JsonProperty("intacct_orderlinefieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? IntacctOrderLineFieldMappings { get; set; } 

        [JsonProperty("intacct_creditfieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? IntacctCreditFieldMappings { get; set; } 

        [JsonProperty("intacct_creditlinefieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? IntacctCreditLineFieldMappings { get; set; } 

        [JsonProperty("intacct_billfieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? IntacctBillFieldMappings { get; set; } 

        [JsonProperty("intacct_billlinefieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? IntacctBillingFieldMappings { get; set; } 

        [JsonProperty("halointegrator_xensam", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorXensam { get; set; } 

        [JsonProperty("halointegrator_xensam_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorXensamLastSync { get; set; } 

        [JsonProperty("halointegrator_xensam_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorXensamLastError { get; set; } 

        [JsonProperty("xensam_defaultsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? XensamDefaultSiteName { get; set; } 

        [JsonProperty("xensam_import_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? XensamImportEntitiesList { get; set; } 

        [JsonProperty("xensam_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? XensamFieldMappings { get; set; } 

        [JsonProperty("xensam_datacentre_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? XensamDatacentreFieldMappings { get; set; } 

        [JsonProperty("xensam_clientmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLink>? XensamClientMappings { get; set; } 

        [JsonProperty("xensam_mappings_xtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AssetTypeMapping>? XensamMappingsXType { get; set; } 

        [JsonProperty("trustpilot_defaultusersite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TrustpilotDefaultUserSiteName { get; set; } 

        [JsonProperty("okta_sitegroup_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLink>? OktaSiteGroupMappings { get; set; } 

        [JsonProperty("lansweeper_sql_port", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? LansweeperSqlPort { get; set; } 

        [JsonProperty("sccm_sql_port", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SccmSqlPort { get; set; } 

        [JsonProperty("can_disable_incoming_service", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanDisableIncomingService { get; set; } 

        [JsonProperty("zabbix_alert_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ZabbixAlertUserName { get; set; } 

        [JsonProperty("connectwise_rmm_alert_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ConnectWiseRmmAlertUserName { get; set; } 

        [JsonProperty("amazon_seller_default_site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AmazonSellerDefaultSiteName { get; set; } 

        [JsonProperty("halointegrator_amazonseller", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorAmazonSeller { get; set; } 

        [JsonProperty("halointegrator_amazonseller_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorAmazonSellerLastSync { get; set; } 

        [JsonProperty("halointegrator_amazonseller_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorAmazonSellerLastError { get; set; } 

        [JsonProperty("is_nhserverless", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsNhServerless { get; set; } 

        [JsonProperty("incoming_default_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? IncomingDefaultUserName { get; set; } 

        [JsonProperty("incoming_newuser_default_site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? IncomingNewUserDefaultSiteName { get; set; } 

        [JsonProperty("prometheus_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? PrometheusFieldMappings { get; set; } 

        [JsonProperty("prometheus_defaultassettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PrometheusDefaultAssetTypeName { get; set; } 

        [JsonProperty("prometheus_defaultsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PrometheusDefaultSiteName { get; set; } 

        [JsonProperty("prometheus_xtype_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AssetTypeMapping>? PrometheusXTypeMappings { get; set; } 

        [JsonProperty("prometheus_alerting_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PrometheusAlertingUserName { get; set; } 

        [JsonProperty("halointegrator_prometheus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorPrometheus { get; set; } 

        [JsonProperty("halointegrator_prometheus_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorPrometheusLastSync { get; set; } 

        [JsonProperty("halointegrator_prometheus_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorPrometheusLastError { get; set; } 

        [JsonProperty("halointegrator_mattermost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorMattermost { get; set; } 

        [JsonProperty("halointegrator_mattermost_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorMattermostLastSync { get; set; } 

        [JsonProperty("halointegrator_mattermost_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorMattermostLastError { get; set; } 

        [JsonProperty("halointegrator_wordpress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorWordPress { get; set; } 

        [JsonProperty("halointegrator_wordpress_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorWordPressLastSync { get; set; } 

        [JsonProperty("halointegrator_wordpress_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorWordPressLastError { get; set; } 

        [JsonProperty("reset_halointegrator_wordpress_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ResetHaloIntegratorWordPressLastSync { get; set; } 

        [JsonProperty("_dbintegrator_success", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DbIntegratorSuccess { get; set; } 

        [JsonProperty("deferred_revenue_client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DeferredRevenueClientName { get; set; } 

        [JsonProperty("halointegrator_googlebusiness", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorGoogleBusiness { get; set; } 

        [JsonProperty("halointegrator_googlebusiness_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorGoogleBusinessLastSync { get; set; } 

        [JsonProperty("halointegrator_googlebusiness_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorGoogleBusinessLastError { get; set; } 

        [JsonProperty("reset_halointegrator_googlebusiness_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ResetHaloIntegratorGoogleBusinessLastSync { get; set; } 

        [JsonProperty("google_reviewdefaultusersite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? GoogleReviewDefaultUserSiteName { get; set; } 

        [JsonProperty("google_questiondefaultusersite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? GoogleQuestionDefaultUserSiteName { get; set; } 

        [JsonProperty("device_tenantids_strings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<string>? DeviceTenantIdsStrings { get; set; } 

        [JsonProperty("twilio_account_sid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TwilioAccountSid { get; set; } 

        [JsonProperty("halointegrator_googlecalendars", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorGoogleCalendars { get; set; } 

        [JsonProperty("halointegrator_googlecalendars_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorGoogleCalendarsLastSync { get; set; } 

        [JsonProperty("halointegrator_googlecalendars_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorGoogleCalendarsLastError { get; set; } 

        [JsonProperty("aireports_enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AiReportsEnabled { get; set; } 

        [JsonProperty("halointegrator_wordpressorg", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorWordPressOrg { get; set; } 

        [JsonProperty("halointegrator_wordpressorg_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorWordPressOrgLastSync { get; set; } 

        [JsonProperty("halointegrator_wordpressorg_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorWordPressOrgLastError { get; set; } 

        [JsonProperty("reset_halointegrator_wordpressorg_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ResetHaloIntegratorWordPressOrgLastSync { get; set; } 

        [JsonProperty("halointegrator_splashtop", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorSplashtop { get; set; } 

        [JsonProperty("halointegrator_splashtop_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorSplashtopLastSync { get; set; } 

        [JsonProperty("halointegrator_splashtop_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorSplashtopLastError { get; set; } 

        [JsonProperty("gocardless_userfieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? GoCardlessUserFieldMappings { get; set; } 

        [JsonProperty("gocardless_defaultsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? GoCardlessDefaultSiteName { get; set; } 

        [JsonProperty("halointegrator_gocardless", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorGoCardless { get; set; } 

        [JsonProperty("halointegrator_gocardless_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorGoCardlessLastSync { get; set; } 

        [JsonProperty("halointegrator_gocardless_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorGoCardlessLastError { get; set; } 

        [JsonProperty("reset_halointegrator_gocardless_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ResetHaloIntegratorGoCardlessLastSync { get; set; } 

        [JsonProperty("prometheus_api_url_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? PrometheusApiUrlList { get; set; } 

        [JsonProperty("aidetection_enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AiDetectionEnabled { get; set; } 

        [JsonProperty("itglue_sync_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? ItGlueSyncEntitiesList { get; set; } 

        [JsonProperty("slack_command_workspaces", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? SlackCommandWorkspaces { get; set; } 

        [JsonProperty("meraki_top_level_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? MerakiTopLevelName { get; set; } 

        [JsonProperty("meraki_client_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLink>? MerakiClientMappings { get; set; } 

        [JsonProperty("meraki_device_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? MerakiDeviceFieldMappings { get; set; } 

        [JsonProperty("merakidefaultassettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? MerakiDefaultAssetTypeName { get; set; } 

        [JsonProperty("meraki_xtype_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AssetTypeMapping>? MerakiXTypeMappings { get; set; } 

        [JsonProperty("halointegrator_meraki", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorMeraki { get; set; } 

        [JsonProperty("halointegrator_meraki_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorMerakiLastSync { get; set; } 

        [JsonProperty("halointegrator_meraki_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorMerakiLastError { get; set; } 

        [JsonProperty("meraki_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? MerakiUrl { get; set; } 

        [JsonProperty("saml_certififcate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SamlCertificate { get; set; } 

        [JsonProperty("whatsapp_defaultclientsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? WhatsappDefaultClientSiteName { get; set; } 

        [JsonProperty("xsoar_default_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? XsoarDefaultUsername { get; set; } 

        [JsonProperty("halointegrator_adobecommerce", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorAdobeCommerce { get; set; } 

        [JsonProperty("halointegrator_adobecommerce_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorAdobeCommerceLastSync { get; set; } 

        [JsonProperty("halointegrator_adobecommerce_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorAdobeCommerceLastError { get; set; } 

        [JsonProperty("adobecommercedefaultsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AdobeCommerceDefaultSiteName { get; set; } 

        [JsonProperty("adobecommerce_import_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? AdobeCommerceImportEntitiesList { get; set; } 

        [JsonProperty("openai_enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? OpenAiEnabled { get; set; } 

        [JsonProperty("azureopenai_enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AzureOpenAiEnabled { get; set; } 

        [JsonProperty("azureopenai_embedding_enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AzureOpenaiEmbeddingEnabled { get; set; } 

        [JsonProperty("azureaisearch_demo_enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AzureAiSearchDemoEnabled { get; set; } 

        [JsonProperty("freshdesk_statusfilter_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? FreshdeskStatusFilterList { get; set; } 

        [JsonProperty("distributionlists_defaultsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DistributionListsDefaultSiteName { get; set; } 

        [JsonProperty("workspace_mobilemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? WorkspaceMobileMappings { get; set; } 

        [JsonProperty("workspace_mappings_xtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AssetTypeMapping>? WorkspaceMappingsXType { get; set; } 

        [JsonProperty("_index_kbs_now", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IndexKbsNow { get; set; } 

        [JsonProperty("_index_services_now", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IndexServicesNow { get; set; } 

        [JsonProperty("home_html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HomeHtml { get; set; } 

        [JsonProperty("home_html_top", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HomeHtmlTop { get; set; } 

        [JsonProperty("agent_presence_rules", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AgentPresenceRule>? AgentPresenceRules { get; set; } 

        [JsonProperty("halointegrator_mailchimp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorMailchimp { get; set; } 

        [JsonProperty("halointegrator_mailchimp_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorMailchimpLastSync { get; set; } 

        [JsonProperty("halointegrator_mailchimp_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorMailchimpLastError { get; set; } 

        [JsonProperty("mailchimp_import_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? MailchimpImportEntitiesList { get; set; } 

        [JsonProperty("reset_halointegrator_mailchimp_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ResetHaloIntegratorMailchimpLastSync { get; set; } 

        [JsonProperty("quoteapprovalfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<TicketTypeField>? QuoteApprovalFields { get; set; } 

        [JsonProperty("recordonlinepresence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? RecordOnlinePresence { get; set; } 

        [JsonProperty("exchange_agent_subscriptions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AgentEventSubscription>? ExchangeAgentSubscriptions { get; set; } 

        [JsonProperty("_do_convert_to_prospects", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DoConvertToProspects { get; set; } 

        [JsonProperty("dynamicscrm_customtable_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Dynamics365CrmFieldMapping>? DynamicsCrmCustomTableMappings { get; set; } 

        [JsonProperty("webdashboardtitle_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? WebDashboardTitleOverride { get; set; } 

        [JsonProperty("contractapprovalfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<TicketTypeField>? ContractApprovalFields { get; set; } 

        [JsonProperty("sccm_dontupdatetype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SccmDontUpdateType { get; set; } 

        [JsonProperty("lansweeper_dontupdatetype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? LansweeperDontUpdateType { get; set; } 

        [JsonProperty("portal_requestor_display_attribute1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PortalRequestorDisplayAttribute1 { get; set; } 

        [JsonProperty("portal_requestor_display_attribute2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PortalRequestorDisplayAttribute2 { get; set; } 

        [JsonProperty("converted_currency_rounding_behaviour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ConvertedCurrencyRoundingBehaviour { get; set; } 

        [JsonProperty("agent_status_reassign_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AgentStatusReassignMapping>? AgentStatusReassignMappings { get; set; } 

        [JsonProperty("new_integration_key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewIntegrationKey { get; set; } 

        [JsonProperty("new_integration_key2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewIntegrationKey2 { get; set; } 

        [JsonProperty("new_integration_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? NewIntegrationMethod { get; set; } 

        [JsonProperty("new_integration_webhook_key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewIntegrationWebhookKey { get; set; } 

        [JsonProperty("integration_webhook_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? IntegrationWebhookUsername { get; set; } 

        [JsonProperty("new_integration_webhook_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? NewIntegrationWebhookMethod { get; set; } 

        [JsonProperty("atera_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AteraUrl { get; set; } 

        [JsonProperty("businesscentral_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? BusinessCentralUrl { get; set; } 

        [JsonProperty("businesscentral_appid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? BusinessCentralAppid { get; set; } 

        [JsonProperty("businesscentral_domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? BusinessCentralDomain { get; set; } 

        [JsonProperty("businesscentral_tokenexpiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? BusinessCentralTokenExpiry { get; set; } 

        [JsonProperty("businesscentral_redirect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? BusinessCentralRedirect { get; set; } 

        [JsonProperty("businesscentral_authorised", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? BusinessCentralAuthorised { get; set; } 

        [JsonProperty("dynamicscrm_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DynamicsCrmUrl { get; set; } 

        [JsonProperty("dynamicscrm_appid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DynamicsCrmAppid { get; set; } 

        [JsonProperty("dynamicscrm_domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DynamicsCrmDomain { get; set; } 

        [JsonProperty("dynamicscrm_tokenexpiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? DynamicsCrmTokenExpiry { get; set; } 

        [JsonProperty("dynamicscrm_redirect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DynamicsCrmRedirect { get; set; } 

        [JsonProperty("dynamicscrm_authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DynamicsCrmAuthorized { get; set; } 

        [JsonProperty("exchange_application_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ExchangeApplicationId { get; set; } 

        [JsonProperty("exchange_tenant_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ExchangeTenantId { get; set; } 

        [JsonProperty("exchange_token_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? ExchangeTokenExpiry { get; set; } 

        [JsonProperty("exchange_redirect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ExchangeRedirect { get; set; } 

        [JsonProperty("exchange_authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ExchangeAuthorized { get; set; } 

        [JsonProperty("device42_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Device42Url { get; set; } 

        [JsonProperty("device42_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Device42Username { get; set; } 

        [JsonProperty("prtg_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PrtgUrl { get; set; } 

        [JsonProperty("prtg_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PrtgUsername { get; set; } 

        [JsonProperty("prtg_password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PrtgPassword { get; set; } 

        [JsonProperty("gfi_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? GfiUrl { get; set; } 

        [JsonProperty("soc_api_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SocApiId { get; set; } 

        [JsonProperty("qbo_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? QboClientId { get; set; } 

        [JsonProperty("qbo_token_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? QboTokenExpiry { get; set; } 

        [JsonProperty("qbo_authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? QboAuthorized { get; set; } 

        [JsonProperty("qbo_redirect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? QboRedirect { get; set; } 

        [JsonProperty("qbo_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? QboUrl { get; set; } 

        [JsonProperty("sage50password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sage50Password { get; set; } 

        [JsonProperty("servicenow_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ServiceNowUrl { get; set; } 

        [JsonProperty("servicenow_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ServiceNowUsername { get; set; } 

        [JsonProperty("autotask_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AutoTaskUsername { get; set; } 

        [JsonProperty("connectwise_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ConnectWiseUrl { get; set; } 

        [JsonProperty("connectwise_public_key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ConnectWisePublicKey { get; set; } 

        [JsonProperty("connectwise_private_key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ConnectWisePrivateKey { get; set; } 

        [JsonProperty("ninja_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NinjaUrl { get; set; } 

        [JsonProperty("ninja_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NinjaClientId { get; set; } 

        [JsonProperty("ninja_authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? NinjaAuthorized { get; set; } 

        [JsonProperty("ninja_token_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? NinjaTokenExpiry { get; set; } 

        [JsonProperty("ninja_redirect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NinjaRedirect { get; set; } 

        [JsonProperty("itglue_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ItGlueUrl { get; set; } 

        [JsonProperty("snelstart_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SnelStartUrl { get; set; } 

        [JsonProperty("snelstart_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SnelStartClientId { get; set; } 

        [JsonProperty("snelstart_authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SnelStartAuthorized { get; set; } 

        [JsonProperty("snelstart_token_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? SnelStartTokenExpiry { get; set; } 

        [JsonProperty("jamf_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? JamfUrl { get; set; } 

        [JsonProperty("jamf_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? JamfUsername { get; set; } 

        [JsonProperty("interact_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? InteractUrl { get; set; } 

        [JsonProperty("interact_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? InteractUsername { get; set; } 

        [JsonProperty("interact_tenant", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? InteractTenant { get; set; } 

        [JsonProperty("interact_token_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? InteractTokenExpiry { get; set; } 

        [JsonProperty("gw_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? GwUrl { get; set; } 

        [JsonProperty("gw_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? GwClientId { get; set; } 

        [JsonProperty("gw_token_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? GwTokenExpiry { get; set; } 

        [JsonProperty("gw_redirect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? GwRedirect { get; set; } 

        [JsonProperty("gw_authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? GwAuthorized { get; set; } 

        [JsonProperty("scomservername", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ScomServerName { get; set; } 

        [JsonProperty("scomdomain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ScomDomain { get; set; } 

        [JsonProperty("scomusername", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ScomUsername { get; set; } 

        [JsonProperty("scompassword", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ScomPassword { get; set; } 

        [JsonProperty("scom_access", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ScomAccess { get; set; } 

        [JsonProperty("orion_server_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OrionServerName { get; set; } 

        [JsonProperty("orion_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OrionUsername { get; set; } 

        [JsonProperty("orion_password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OrionPassword { get; set; } 

        [JsonProperty("orion_access", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? OrionAccess { get; set; } 

        [JsonProperty("beyondtrust_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? BeyondTrustUrl { get; set; } 

        [JsonProperty("beyondtrust_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? BeyondTrustUsername { get; set; } 

        [JsonProperty("beyondtrust_token_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? BeyondTrustTokenExpiry { get; set; } 

        [JsonProperty("beyondtrust_authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? BeyondTrustAuthorized { get; set; } 

        [JsonProperty("sentinel_token_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? SentinelTokenExpiry { get; set; } 

        [JsonProperty("sentinel_redirect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SentinelRedirect { get; set; } 

        [JsonProperty("sentinel_authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SentinelAuthorized { get; set; } 

        [JsonProperty("syncro_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SyncroUrl { get; set; } 

        [JsonProperty("domotz_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DomotzUrl { get; set; } 

        [JsonProperty("g2aremote_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? G2ARemoteClientId { get; set; } 

        [JsonProperty("automate_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AutomateUrl { get; set; } 

        [JsonProperty("automate_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AutomateUsername { get; set; } 

        [JsonProperty("g2aremote_authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? G2ARemoteAuthorized { get; set; } 

        [JsonProperty("automate_token_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? AutomateTokenExpiry { get; set; } 

        [JsonProperty("g2aremote_refresh_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? G2ARemoteRefreshToken { get; set; } 

        [JsonProperty("g2aremote_token_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? G2ARemoteTokenExpiry { get; set; } 

        [JsonProperty("g2aremote_redirect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? G2ARemoteRedirect { get; set; } 

        [JsonProperty("snow_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SnowUsername { get; set; } 

        [JsonProperty("snow_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SnowUrl { get; set; } 

        [JsonProperty("auvik_tenant", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AuvikTenant { get; set; } 

        [JsonProperty("auvik_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AuvikUsername { get; set; } 

        [JsonProperty("hubspot_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HubspotUrl { get; set; } 

        [JsonProperty("hubspot_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HubspotClientId { get; set; } 

        [JsonProperty("hubspot_authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HubspotAuthorized { get; set; } 

        [JsonProperty("hubspot_token_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HubspotTokenExpiry { get; set; } 

        [JsonProperty("hubspot_redirect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HubspotRedirect { get; set; } 

        [JsonProperty("qualys_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? QualysUrl { get; set; } 

        [JsonProperty("qualys_domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? QualysDomain { get; set; } 

        [JsonProperty("qualys_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? QualysUsername { get; set; } 

        [JsonProperty("azuretranslate_region", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AzureTranslateRegion { get; set; } 

        [JsonProperty("azuretranslate_currentusage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? AzureTranslateCurrentUsage { get; set; } 

        [JsonProperty("passportal_apikey", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PassportalApikey { get; set; } 

        [JsonProperty("passportal_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PassportalUrl { get; set; } 

        [JsonProperty("passportal_refresh_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PassportalRefreshToken { get; set; } 

        [JsonProperty("passportal_token_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? PassportalTokenExpiry { get; set; } 

        [JsonProperty("hudu_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HuduUrl { get; set; } 

        [JsonProperty("cipp_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CippUrl { get; set; } 

        [JsonProperty("intacct_sender_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? IntacctSenderId { get; set; } 

        [JsonProperty("intacct_company_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? IntacctCompanyId { get; set; } 

        [JsonProperty("intacct_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? IntacctUsername { get; set; } 

        [JsonProperty("backupradar_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? BackupRadarUrl { get; set; } 

        [JsonProperty("addigy_clientid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AddigyClientId { get; set; } 

        [JsonProperty("ingram_micro_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? IngramMicroUrl { get; set; } 

        [JsonProperty("ingram_micro_marketplace", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? IngramMicroMarketplace { get; set; } 

        [JsonProperty("ingram_micro_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? IngramMicroUsername { get; set; } 

        [JsonProperty("ingram_micro_token_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? IngramMicroTokenExpiry { get; set; } 

        [JsonProperty("freshdesk_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? FreshdeskUrl { get; set; } 

        [JsonProperty("liongard_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? LiongardUrl { get; set; } 

        [JsonProperty("liongard_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? LiongardClientId { get; set; } 

        [JsonProperty("salesforce_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SalesforceClientId { get; set; } 

        [JsonProperty("pax8_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Pax8ClientId { get; set; } 

        [JsonProperty("salesforce_authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SalesforceAuthorized { get; set; } 

        [JsonProperty("pax8_token_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Pax8TokenExpiry { get; set; } 

        [JsonProperty("salesforce_refresh_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SalesforceRefreshToken { get; set; } 

        [JsonProperty("salesforce_token_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? SalesforceTokenExpiry { get; set; } 

        [JsonProperty("salesforce_redirect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SalesforceRedirect { get; set; } 

        [JsonProperty("salesforce_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SalesforceUrl { get; set; } 

        [JsonProperty("client_secret_newrelic", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ClientSecretNewrelic { get; set; } 

        [JsonProperty("newrelicuser_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewRelicUserName { get; set; } 

        [JsonProperty("newrelic_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewrelicUrl { get; set; } 

        [JsonProperty("new_glclientsecret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewGlClientSecret { get; set; } 

        [JsonProperty("kaseya_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? KaseyaClientId { get; set; } 

        [JsonProperty("kaseya_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? KaseyaUrl { get; set; } 

        [JsonProperty("kaseya_authorised", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? KaseyaAuthorised { get; set; } 

        [JsonProperty("kaseya_alert_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? KaseyaAlertUserName { get; set; } 

        [JsonProperty("kaseya_servicedesks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? KaseyaServiceDesks { get; set; } 

        [JsonProperty("chat_service_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ChatServiceUrl { get; set; } 

        [JsonProperty("report_service_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ReportServiceUrl { get; set; } 

        [JsonProperty("zabbix_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ZabbixUrl { get; set; } 

        [JsonProperty("zabbix_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ZabbixUsername { get; set; } 

        [JsonProperty("rhipe_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? RhipeClientId { get; set; } 

        [JsonProperty("techdata_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TechDataClientId { get; set; } 

        [JsonProperty("inty_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? IntyUrl { get; set; } 

        [JsonProperty("inty_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? IntyUsername { get; set; } 

        [JsonProperty("westcoastcloud_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? WestCoastCloudUrl { get; set; } 

        [JsonProperty("westcoastcloud_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? WestCoastCloudUsername { get; set; } 

        [JsonProperty("sherweb_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SherwebClientId { get; set; } 

        [JsonProperty("sherweb_tenant", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SherwebTenant { get; set; } 

        [JsonProperty("also_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AlsoUrl { get; set; } 

        [JsonProperty("also_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AlsoUsername { get; set; } 

        [JsonProperty("dickerdata_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DickerDataUrl { get; set; } 

        [JsonProperty("quoter_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? QuoterUrl { get; set; } 

        [JsonProperty("quoter_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? QuoterClientId { get; set; } 

        [JsonProperty("halolink_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloLinkUrl { get; set; } 

        [JsonProperty("halolink_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloLinkClientId { get; set; } 

        [JsonProperty("includechatsettings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeChatSettings { get; set; } 

        [JsonProperty("includeprsettings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludePrSettings { get; set; } 

        [JsonProperty("includeintegrationsettings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeIntegrationSettings { get; set; } 

        [JsonProperty("includebillingsettings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeBillingSettings { get; set; } 

        [JsonProperty("includeemailsettings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeEmailSettings { get; set; } 

        [JsonProperty("includechangefreezesettings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeChangeFreezeSettings { get; set; } 

        [JsonProperty("includeportalsettings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludePortalSettings { get; set; } 

        [JsonProperty("includerecurringinvoicesettings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeRecurringInvoiceSettings { get; set; } 

        [JsonProperty("includequotesettings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeQuoteSettings { get; set; } 

        [JsonProperty("includecontractsettings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeContractSettings { get; set; } 

        [JsonProperty("integrationmoduleid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? IntegrationModuleId { get; set; } 

        [JsonProperty("includeresourcebookingsettings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeResourceBookingSettings { get; set; } 

        [JsonProperty("includecalendarsettings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeCalendarSettings { get; set; } 

        [JsonProperty("includeadvancedsettings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IncludeAdvancedSettings { get; set; } 

        [JsonProperty("gw_scopes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<string>? GwScopes { get; set; } 

        [JsonProperty("gw_asset_scopes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? GwAssetScopes { get; set; } 

        [JsonProperty("pagerduty_services", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<PagerDutyMapping>? PagerdutyServices { get; set; } 

        [JsonProperty("integration_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? IntegrationClientId { get; set; } 

        [JsonProperty("whatsapp_authorised", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? WhatsappAuthorised { get; set; } 

        [JsonProperty("logicmonitor_access_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? LogicMonitorAccessId { get; set; } 

        [JsonProperty("openai_default_model", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OpenAiDefaultModel { get; set; } 

        [JsonProperty("azure_openai_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AzureOpenAiUrl { get; set; } 

        [JsonProperty("azure_openai_version", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AzureOpenAiVersion { get; set; } 

        [JsonProperty("azure_ai_search_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AzureAiSearchUrl { get; set; } 

        [JsonProperty("azure_ai_search_version", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AzureAiSearchVersion { get; set; } 

        [JsonProperty("integration_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? IntegrationUrl { get; set; } 

        [JsonProperty("integration_tenant", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? IntegrationTenant { get; set; } 

        [JsonProperty("openai_embeddings_tickettypes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<TicketTypeList>? OpenAiEmbeddingsTicketTypes { get; set; } 

        [JsonProperty("azureopenai_embeddings_tickettypes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<TicketTypeList>? AzureOpenaiEmbeddingsTicketTypes { get; set; } 

        [JsonProperty("aiembedding_enabled_tickettypes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<LongIdNameKeyPair>? AiEmbeddingEnabledTicketTypes { get; set; } 

        [JsonProperty("vectorise_tickettypes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<TicketTypeList>? VectoriseTicketTypes { get; set; } 

        [JsonProperty("vectorise_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? VectoriseDate { get; set; } 

        [JsonProperty("opsgenie_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OpsgenieUrl { get; set; } 

        [JsonProperty("opsgenie_instance_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OpsgenieInstanceUrl { get; set; } 

        [JsonProperty("teams_tenant_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TeamsTenantId { get; set; } 

        [JsonProperty("teams_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TeamsClientId { get; set; } 

        [JsonProperty("teams_authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? TeamsAuthorized { get; set; } 

        [JsonProperty("freshdesk_status_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? FreshdeskStatusMappings { get; set; } 

        [JsonProperty("freshdesk_priority_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? FreshdeskPriorityMappings { get; set; } 

        [JsonProperty("freshdesk_team_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? FreshdeskTeamMappings { get; set; } 

        [JsonProperty("freshdesk_field_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? FreshdeskFieldMappings { get; set; } 

        [JsonProperty("coralogix_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CoralogixUrl { get; set; } 

        [JsonProperty("coralogix_uuid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CoralogixUuid { get; set; } 

        [JsonProperty("gw_mobile_scopes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? GwMobileScopes { get; set; } 

        [JsonProperty("mailchimp_authorised", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? MailchimpAuthorised { get; set; } 

        [JsonProperty("zendesk_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ZendeskUrl { get; set; } 

        [JsonProperty("zendesk_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ZendeskEmail { get; set; } 

        [JsonProperty("teamsshifts_tenant_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TeamsShiftsTenantId { get; set; } 

        [JsonProperty("teamsshifts_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TeamsShiftsClientId { get; set; } 

        [JsonProperty("teamsshifts_authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? TeamsShiftsAuthorized { get; set; } 

        [JsonProperty("teamsshifts_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<MicrosoftTeamsMapping>? TeamsShiftsMappings { get; set; } 

        [JsonProperty("halointegrator_microsoftteams", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorMicrosoftTeams { get; set; } 

        [JsonProperty("halointegrator_microsoftteams_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorMicrosoftTeamsLastSync { get; set; } 

        [JsonProperty("halointegrator_microsoftteams_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorMicrosoftTeamsLastError { get; set; } 

        [JsonProperty("reset_halointegrator_microsoftteams_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ResetHaloIntegratorMicrosoftTeamsLastSync { get; set; } 

        [JsonProperty("hopewiser_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HopewiserUser { get; set; } 

        [JsonProperty("hopewiser_maf", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HopewiserMaf { get; set; } 

        [JsonProperty("teamsshifts_shifttype_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLink>? TeamsShiftsShiftTypeMappings { get; set; } 

        [JsonProperty("webhook_iterations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? WebhookIterations { get; set; } 

    }