using Angelic.Models.Configuration.Assets.SoftwareLicensing;
using Angelic.Models.Configuration.Integrations;
using Angelic.Models.Configuration.Integrations.Auvik;
using Angelic.Models.Configuration.Integrations.Okta;
using Angelic.Models.Configuration.Tickets;
using Angelic.Models.KeyPairs;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Advanced.Controls;

public partial class Control
{
  [JsonProperty("licence_guids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<string>? LicenceGuids { get; set; } 

        [JsonProperty("atera_alert_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AteraAlertUserName { get; set; } 

        [JsonProperty("teams_default_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TeamsDefaultUserName { get; set; } 

        [JsonProperty("_exchangeaction", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Exchangeaction { get; set; } 

        [JsonProperty("halointegrator_exchange", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorExchange { get; set; } 

        [JsonProperty("halointegrator_exchange_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorExchangeLastSync { get; set; } 

        [JsonProperty("halointegrator_exchange_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorExchangeLastError { get; set; } 

        [JsonProperty("okta_sitemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<OktaMapping>? OktaSitemappings { get; set; } 

        [JsonProperty("okta_usermappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? OktaUsermappings { get; set; } 

        [JsonProperty("okta_agentmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? OktaAgentmappings { get; set; } 

        [JsonProperty("okta_rolemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? OktaRolemappings { get; set; } 

        [JsonProperty("okta_cabmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? OktaCabmappings { get; set; } 

        [JsonProperty("okta_user_matching_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? OktaUserMatchingList { get; set; } 

        [JsonProperty("okta_agent_matching_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? OktaAgentMatchingList { get; set; } 

        [JsonProperty("okta_active_statuses_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? OktaActiveStatusesList { get; set; } 

        [JsonProperty("halointegrator_okta", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorOkta { get; set; } 

        [JsonProperty("halointegrator_okta_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorOktaLastSync { get; set; } 

        [JsonProperty("halointegrator_okta_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorOktaLastError { get; set; } 

        [JsonProperty("reset_okta_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ResetOktaLastSync { get; set; } 

        [JsonProperty("quote_cannedtext", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CannedText>? QuoteCannedText { get; set; } 

        [JsonProperty("merakiapplicationsecret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Merakiapplicationsecret { get; set; } 

        [JsonProperty("merakiusername", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Merakiusername { get; set; } 

        [JsonProperty("merakitickettypename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Merakitickettypename { get; set; } 

        [JsonProperty("lansweeper_authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? LansweeperAuthorized { get; set; } 

        [JsonProperty("_getoauthtoken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Getoauthtoken { get; set; } 

        [JsonProperty("oauth_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OauthCode { get; set; } 

        [JsonProperty("oauth_redirect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OauthRedirect { get; set; } 

        [JsonProperty("oauth_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OauthType { get; set; } 

        [JsonProperty("graph_host", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? GraphHost { get; set; } 

        [JsonProperty("_disconnectintegration", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Disconnectintegration { get; set; } 

        [JsonProperty("lansweeper_sitemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationSiteMapping>? LansweeperSitemappings { get; set; } 

        [JsonProperty("lansweeper_site_rules", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationSiteMapping>? LansweeperSiteRules { get; set; } 

        [JsonProperty("lansweeper_fieldmappings_api", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? LansweeperFieldMappingsApi { get; set; } 

        [JsonProperty("alarmminutes_bool", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AlarmminutesBool { get; set; } 

        [JsonProperty("_integrationid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Integrationid { get; set; } 

        [JsonProperty("ninja_sitemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationSiteMapping>? NinjaSitemappings { get; set; } 

        [JsonProperty("ninja_alert_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NinjaAlertUserName { get; set; } 

        [JsonProperty("dattormm_alert_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DattormmAlertUserName { get; set; } 

        [JsonProperty("_closealerts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Closealerts { get; set; } 

        [JsonProperty("_closealerts_integration", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ClosealertsIntegration { get; set; } 

        [JsonProperty("alert_guids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<string>? AlertGuids { get; set; } 

        [JsonProperty("hashostedintegrator", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hashostedintegrator { get; set; } 

        [JsonProperty("halointegrator_xlsimports", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorXlsimports { get; set; } 

        [JsonProperty("halointegrator_xlsimports_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorXlsimportsLastSync { get; set; } 

        [JsonProperty("halointegrator_xlsimports_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorXlsimportsLastError { get; set; } 

        [JsonProperty("snelstart_old_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SnelStartOldClientId { get; set; } 

        [JsonProperty("_getsnelstartlink", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Getsnelstartlink { get; set; } 

        [JsonProperty("itglue_clientmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLinkList>? ItGlueClientmappings { get; set; } 

        [JsonProperty("itglue_sitemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLinkList>? ItGlueSitemappings { get; set; } 

        [JsonProperty("itglue_active_statuses_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? ItGlueActiveStatusesList { get; set; } 

        [JsonProperty("itglue_typemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AssetTypeMapping>? ItGlueTypemappings { get; set; } 

        [JsonProperty("itglue_configtypemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AssetTypeMapping>? ItGlueConfigtypemappings { get; set; } 

        [JsonProperty("itglue_statusmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? ItGlueStatusmappings { get; set; } 

        [JsonProperty("itglue_default_site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ItGlueDefaultSiteName { get; set; } 

        [JsonProperty("halointegrator_itglue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorItGlue { get; set; } 

        [JsonProperty("halointegrator_itglue_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorItGlueLastSync { get; set; } 

        [JsonProperty("halointegrator_itglue_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorItGlueLastError { get; set; } 

        [JsonProperty("bookingtypes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<BookingType>? BookingTypes { get; set; } 

        [JsonProperty("appsettings_encthumbprint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AppsettingsEncthumbprint { get; set; } 

        [JsonProperty("old_pwd_enc_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? OldPwdEncCount { get; set; } 

        [JsonProperty("scom_allowed_clientids_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? ScomAllowedClientIdsList { get; set; } 

        [JsonProperty("orion_allowed_clientids_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? OrionAllowedClientIdsList { get; set; } 

        [JsonProperty("teamsbot_disabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? TeamsbotDisabled { get; set; } 

        [JsonProperty("datto_sitemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationSiteMapping>? DattoSitemappings { get; set; } 

        [JsonProperty("halointegrator_dynamics365crm", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorDynamics365Crm { get; set; } 

        [JsonProperty("halointegrator_dynamics365crm_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorDynamics365CrmLastSync { get; set; } 

        [JsonProperty("halointegrator_dynamics365crm_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorDynamics365CrmLastError { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warning { get; set; } 

        [JsonProperty("jamf_defaultsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? JamfDefaultSiteName { get; set; } 

        [JsonProperty("jamf_defaultdtypecomputer_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? JamfDefaultdtypecomputerName { get; set; } 

        [JsonProperty("jamf_defaultdtypemobile_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? JamfDefaultdtypemobileName { get; set; } 

        [JsonProperty("jamf_device_types", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? JamfDeviceTypes { get; set; } 

        [JsonProperty("jamf_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? JamfFieldMappings { get; set; } 

        [JsonProperty("halointegrator_jamf", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorJamf { get; set; } 

        [JsonProperty("halointegrator_jamf_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorJamfLastSync { get; set; } 

        [JsonProperty("halointegrator_jamf_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorJamfLastError { get; set; } 

        [JsonProperty("sentinel_ticketmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? SentinelTicketmappings { get; set; } 

        [JsonProperty("halointegrator_sentinel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorSentinel { get; set; } 

        [JsonProperty("halointegrator_sentinel_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorSentinelLastSync { get; set; } 

        [JsonProperty("halointegrator_sentinel_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorSentinelLastError { get; set; } 

        [JsonProperty("server_time_zone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ServerTimeZone { get; set; } 

        [JsonProperty("use_project_datetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? UseProjectDateTime { get; set; } 

        [JsonProperty("allow_cf_values_not_on_tickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowCfValuesNotOnTicketType { get; set; } 

        [JsonProperty("azuremonitor_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? AzuremonitorFieldMappings { get; set; } 

        [JsonProperty("azuremonitoruser_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AzuremonitoruserName { get; set; } 

        [JsonProperty("syncro_defaultsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SyncroDefaultSiteName { get; set; } 

        [JsonProperty("syncro_device_types", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? SyncroDeviceTypes { get; set; } 

        [JsonProperty("syncro_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? SyncroFieldMappings { get; set; } 

        [JsonProperty("halointegrator_syncro", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorSyncro { get; set; } 

        [JsonProperty("halointegrator_syncro_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorSyncroLastSync { get; set; } 

        [JsonProperty("halointegrator_syncro_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorSyncroLastError { get; set; } 

        [JsonProperty("syncro_alert_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SyncroAlertUserName { get; set; } 

        [JsonProperty("domotz_agentfieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? DomotzAgentfieldmappings { get; set; } 

        [JsonProperty("domotz_devicefieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? DomotzDevicefieldmappings { get; set; } 

        [JsonProperty("domotz_default_agentsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DomotzDefaultAgentsiteName { get; set; } 

        [JsonProperty("domotz_default_devicesite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DomotzDefaultDevicesiteName { get; set; } 

        [JsonProperty("domotz_devicetypemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AssetTypeMapping>? DomotzDevicetypemappings { get; set; } 

        [JsonProperty("halointegrator_domotz", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorDomotz { get; set; } 

        [JsonProperty("halointegrator_domotz_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorDomotzLastSync { get; set; } 

        [JsonProperty("halointegrator_domotz_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorDomotzLastError { get; set; } 

        [JsonProperty("_deactivateusers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Deactivateusers { get; set; } 

        [JsonProperty("_deactivateusers_integration", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DeactivateusersIntegration { get; set; } 

        [JsonProperty("user_guids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<string>? UserGuids { get; set; } 

        [JsonProperty("user_tenantids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<string>? UserTenantIds { get; set; } 

        [JsonProperty("_deactivateagents", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Deactivateagents { get; set; } 

        [JsonProperty("_deactivateagents_integration", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DeactivateagentsIntegration { get; set; } 

        [JsonProperty("agent_guids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<string>? AgentGuids { get; set; } 

        [JsonProperty("halointegrator_haloassetdiscovery", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorHaloassetdiscovery { get; set; } 

        [JsonProperty("halointegrator_haloassetdiscovery_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorHaloassetdiscoveryLastSync { get; set; } 

        [JsonProperty("halointegrator_haloassetdiscovery_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorHaloassetdiscoveryLastError { get; set; } 

        [JsonProperty("automate_sitemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationSiteMapping>? AutomateSitemappings { get; set; } 

        [JsonProperty("halointegrator_automate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorAutomate { get; set; } 

        [JsonProperty("halointegrator_automate_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorAutomateLastSync { get; set; } 

        [JsonProperty("halointegrator_automate_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorAutomateLastError { get; set; } 

        [JsonProperty("automate_import_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? AutomateImportEntitiesList { get; set; } 

        [JsonProperty("atera_import_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? AteraImportEntitiesList { get; set; } 

        [JsonProperty("addigy_import_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? AddigyImportEntitiesList { get; set; } 

        [JsonProperty("meraki_import_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? MerakiImportEntitiesList { get; set; } 

        [JsonProperty("automate_alert_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AutomateAlertUserName { get; set; } 

        [JsonProperty("lansweeper_exports", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationExport>? LansweeperExports { get; set; } 

        [JsonProperty("_checkexportprogress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Checkexportprogress { get; set; } 

        [JsonProperty("export_module", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ExportModule { get; set; } 

        [JsonProperty("atera_sitemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationSiteMapping>? AteraSitemappings { get; set; } 

        [JsonProperty("device42_sitemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationSiteMapping>? Device42Sitemappings { get; set; } 

        [JsonProperty("ncentral_sitemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationSiteMapping>? NCentralSitemappings { get; set; } 

        [JsonProperty("syncro_sitemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationSiteMapping>? SyncroSitemappings { get; set; } 

        [JsonProperty("halointegrator_g2aremote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorG2Aremote { get; set; } 

        [JsonProperty("halointegrator_g2aremote_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorG2AremoteLastSync { get; set; } 

        [JsonProperty("halointegrator_g2aremote_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorG2AremoteLastError { get; set; } 

        [JsonProperty("snow_default_devicesite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SnowDefaultDevicesiteName { get; set; } 

        [JsonProperty("snow_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? SnowFieldMappings { get; set; } 

        [JsonProperty("halointegrator_snow", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorSnow { get; set; } 

        [JsonProperty("halointegrator_snow_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorSnowLastSync { get; set; } 

        [JsonProperty("halointegrator_snow_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorSnowLastError { get; set; } 

        [JsonProperty("auvik_sitemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationSiteMapping>? AuvikSitemappings { get; set; } 

        [JsonProperty("auvik_network_typemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AssetTypeMapping>? AuvikNetworkTypemappings { get; set; } 

        [JsonProperty("auvik_device_typemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AssetTypeMapping>? AuvikDeviceTypemappings { get; set; } 

        [JsonProperty("auvik_network_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? AuvikNetworkFieldMappings { get; set; } 

        [JsonProperty("auvik_device_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? AuvikDeviceFieldMappings { get; set; } 

        [JsonProperty("auvik_default_site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AuvikDefaultSiteName { get; set; } 

        [JsonProperty("halointegrator_auvik", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorAuvik { get; set; } 

        [JsonProperty("halointegrator_auvik_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorAuvikLastSync { get; set; } 

        [JsonProperty("halointegrator_auvik_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorAuvikLastError { get; set; } 

        [JsonProperty("auvik_alert_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AuvikAlertUserName { get; set; } 

        [JsonProperty("teamsbot_allowed_tenants_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? TeamsbotAllowedTenantsList { get; set; } 

        [JsonProperty("hubspot_sitemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationSiteMapping>? HubspotSitemappings { get; set; } 

        [JsonProperty("hubspot_company_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? HubspotCompanyFieldMappings { get; set; } 

        [JsonProperty("hubspot_contact_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? HubspotContactFieldMappings { get; set; } 

        [JsonProperty("hubspot_deals_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? HubspotDealsFieldMappings { get; set; } 

        [JsonProperty("hubspot_items_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? HubspotItemsFieldMappings { get; set; } 

        [JsonProperty("hubspot_quotes_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? HubspotQuotesFieldMappings { get; set; } 

        [JsonProperty("hubspot_top_level_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HubspotTopLevelName { get; set; } 

        [JsonProperty("hubspot_default_site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HubspotDefaultSiteName { get; set; } 

        [JsonProperty("hubspot_included_lifecycles_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<KeyPair>? HubspotIncludedLifecyclesList { get; set; } 

        [JsonProperty("halointegrator_hubspot", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorHubspot { get; set; } 

        [JsonProperty("halointegrator_hubspot_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorHubspotLastSync { get; set; } 

        [JsonProperty("halointegrator_hubspot_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorHubspotLastError { get; set; } 

        [JsonProperty("qualys_typemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AssetTypeMapping>? QualysTypemappings { get; set; } 

        [JsonProperty("qualys_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? QualysFieldMappings { get; set; } 

        [JsonProperty("qualys_default_site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? QualysDefaultSiteName { get; set; } 

        [JsonProperty("halointegrator_qualys", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorQualys { get; set; } 

        [JsonProperty("halointegrator_qualys_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorQualysLastSync { get; set; } 

        [JsonProperty("halointegrator_qualys_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorQualysLastError { get; set; } 

        [JsonProperty("passportal_defaultclientsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PassportalDefaultClientsiteName { get; set; } 

        [JsonProperty("passportal_defaultusersite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PassportalDefaultUsersiteName { get; set; } 

        [JsonProperty("passportal_clientmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationSiteMapping>? PassportalClientmappings { get; set; } 

        [JsonProperty("halointegrator_passportal", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorPassportal { get; set; } 

        [JsonProperty("halointegrator_passportal_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorPassportalLastSync { get; set; } 

        [JsonProperty("halointegrator_passportal_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorPassportalLastError { get; set; } 

        [JsonProperty("passportal_assetfieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? PassportalAssetFieldMappings { get; set; } 

        [JsonProperty("passportal_defaultassetsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PassportalDefaultAssetsiteName { get; set; } 

        [JsonProperty("passportal_import_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? PassportalImportEntitiesList { get; set; } 

        [JsonProperty("auvik_top_level_domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AuvikTenantMod? AuvikTopLevelDomain { get; set; } 

        [JsonProperty("lansweeper_include_linux", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? LansweeperIncludeLinux { get; set; } 

        [JsonProperty("intacct_sync_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? IntacctSyncEntitiesList { get; set; } 

        [JsonProperty("license_model", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public LicenseModel? LicenseModel { get; set; } 

        [JsonProperty("addigy_clientmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationSiteMapping>? AddigyClientmappings { get; set; } 

        [JsonProperty("addigy_defaultassetsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AddigyDefaultAssetsiteName { get; set; } 

        [JsonProperty("addigy_assetfieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? AddigyAssetFieldMappings { get; set; } 

        [JsonProperty("halointegrator_addigy", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorAddigy { get; set; } 

        [JsonProperty("halointegrator_addigy_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorAddigyLastSync { get; set; } 

        [JsonProperty("halointegrator_addigy_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorAddigyLastError { get; set; } 

        [JsonProperty("addigy_alert_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AddigyAlertUserName { get; set; } 

        [JsonProperty("domotz_sitemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationSiteMapping>? DomotzSitemappings { get; set; } 

        [JsonProperty("halointegrator_liongard", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorLiongard { get; set; } 

        [JsonProperty("halointegrator_liongard_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorLiongardLastSync { get; set; } 

        [JsonProperty("halointegrator_liongard_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorLiongardLastError { get; set; } 

        [JsonProperty("liongard_sitemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationSiteMapping>? LiongardSitemappings { get; set; } 

        [JsonProperty("liongard_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? LiongardFieldMappings { get; set; } 

        [JsonProperty("liongard_defaultsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? LiongardDefaultSiteName { get; set; } 

        [JsonProperty("liongard_mappings_xtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AssetTypeMapping>? LiongardMappingsXType { get; set; } 

        [JsonProperty("halointegrator_stripe", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorStripe { get; set; } 

        [JsonProperty("halointegrator_stripe_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorStripeLastSync { get; set; } 

        [JsonProperty("halointegrator_stripe_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorStripeLastError { get; set; } 

        [JsonProperty("ingram_micro_client_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLinkList>? IngramMicroClientMappings { get; set; } 

        [JsonProperty("ingram_micro_top_level_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? IngramMicroTopLevelName { get; set; } 

        [JsonProperty("halointegrator_ingram_micro", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorIngramMicro { get; set; } 

        [JsonProperty("halointegrator_ingram_micro_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorIngramMicroLastSync { get; set; } 

        [JsonProperty("halointegrator_ingram_micro_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorIngramMicroLastError { get; set; } 

        [JsonProperty("ingram_micro_import_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? IngramMicroImportEntitiesList { get; set; } 

        [JsonProperty("pax8_client_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLinkList>? Pax8ClientMappings { get; set; } 

        [JsonProperty("quoter_item_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLinkList>? QuoterItemMappings { get; set; } 

        [JsonProperty("etilize_item_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLinkList>? EtilizeItemMappings { get; set; } 

        [JsonProperty("pax8_top_level_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Pax8TopLevelName { get; set; } 

        [JsonProperty("halointegrator_pax8", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorPax8 { get; set; } 

        [JsonProperty("halointegrator_pax8_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorPax8LastSync { get; set; } 

        [JsonProperty("halointegrator_pax8_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorPax8LastError { get; set; } 

        [JsonProperty("pax8_import_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? Pax8ImportEntitiesList { get; set; } 

        [JsonProperty("halointegrator_giacom", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorGiacom { get; set; } 

        [JsonProperty("halointegrator_giacom_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorGiacomLastSync { get; set; } 

        [JsonProperty("halointegrator_giacom_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorGiacomLastError { get; set; } 

        [JsonProperty("giacom_import_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? GiacomImportEntitiesList { get; set; } 

        [JsonProperty("salesforce_contactfieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? SalesforceContactfieldmappings { get; set; } 

        [JsonProperty("salesforce_accountfieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? SalesforceAccountfieldmappings { get; set; } 

        [JsonProperty("salesforce_opportunityfieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? SalesforceOpportunityfieldmappings { get; set; } 

        [JsonProperty("salesforce_casefieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? SalesforceCasefieldmappings { get; set; } 

        [JsonProperty("halointegrator_salesforce", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorSalesforce { get; set; } 

        [JsonProperty("halointegrator_salesforce_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorSalesforceLastSync { get; set; } 

        [JsonProperty("halointegrator_salesforce_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorSalesforceLastError { get; set; } 

        [JsonProperty("salesforce_import_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? SalesforceImportEntitiesList { get; set; } 

        [JsonProperty("salesforce_import_attachments_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? SalesforceImportAttachmentsList { get; set; } 

        [JsonProperty("salesforce_clientmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLinkList>? SalesforceClientmappings { get; set; } 

        [JsonProperty("azure_allowed_tenants", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AzureAllowedTenants { get; set; } 

        [JsonProperty("azure_allowed_tenants_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? AzureAllowedTenantsList { get; set; } 

        [JsonProperty("azure_auto_creation_site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AzureAutoCreationSiteName { get; set; } 

        [JsonProperty("b2cazure_auto_creation_site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? B2CazureAutoCreationSiteName { get; set; } 

        [JsonProperty("halointegrator_newrelic", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorNewrelic { get; set; } 

        [JsonProperty("halointegrator_newrelic_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorNewrelicLastSync { get; set; } 

        [JsonProperty("halointegrator_newrelic_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorNewrelicLastError { get; set; } 

        [JsonProperty("halointegrator_backupradar", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorBackupradar { get; set; } 

        [JsonProperty("halointegrator_backupradar_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorBackupradarLastSync { get; set; } 

        [JsonProperty("halointegrator_backupradar_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorBackupradarLastError { get; set; } 

        [JsonProperty("_deactivateclients", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Deactivateclients { get; set; } 

        [JsonProperty("kaseya_defaultsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? KaseyaDefaultSiteName { get; set; } 

        [JsonProperty("halointegrator_kaseya", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorKaseya { get; set; } 

        [JsonProperty("halointegrator_kaseya_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorKaseyaLastSync { get; set; } 

        [JsonProperty("halointegrator_kaseya_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorKaseyaLastError { get; set; } 

        [JsonProperty("kaseya_agentfieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? KaseyaAgentfieldmappings { get; set; } 

        [JsonProperty("kaseya_sitemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationSiteMapping>? KaseyaSitemappings { get; set; } 

        [JsonProperty("kaseya_typemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AssetTypeMapping>? KaseyaTypemappings { get; set; } 

        [JsonProperty("stripe_client_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLinkList>? StripeClientMappings { get; set; } 

        [JsonProperty("stripe_paymentmethod_options_keypair", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? StripePaymentMethodOptionsKeypair { get; set; } 

        [JsonProperty("stripe_manual_paymentmethod_options_keypair", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? StripeManualPaymentMethodOptionsKeypair { get; set; } 

        [JsonProperty("zabbix_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? ZabbixFieldMappings { get; set; } 

        [JsonProperty("zabbix_typemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AssetTypeMapping>? ZabbixTypemappings { get; set; } 

        [JsonProperty("zabbix_default_type_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ZabbixDefaultTypeName { get; set; } 

        [JsonProperty("zabbix_default_site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ZabbixDefaultSiteName { get; set; } 

        [JsonProperty("halointegrator_zabbix", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorZabbix { get; set; } 

        [JsonProperty("halointegrator_zabbix_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorZabbixLastSync { get; set; } 

        [JsonProperty("halointegrator_zabbix_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorZabbixLastError { get; set; } 

        [JsonProperty("giacom_client_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLinkList>? GiacomClientMappings { get; set; } 

        [JsonProperty("giacom_top_level_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? GiacomTopLevelName { get; set; } 

        [JsonProperty("rhipe_client_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLinkList>? RhipeClientMappings { get; set; } 

        [JsonProperty("rhipe_top_level_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? RhipeTopLevelName { get; set; } 

        [JsonProperty("halointegrator_rhipe", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorRhipe { get; set; } 

        [JsonProperty("halointegrator_rhipe_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorRhipeLastSync { get; set; } 

        [JsonProperty("halointegrator_rhipe_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorRhipeLastError { get; set; } 

        [JsonProperty("rhipe_import_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? RhipeImportEntitiesList { get; set; } 

        [JsonProperty("techdata_client_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLinkList>? TechdataClientMappings { get; set; } 

        [JsonProperty("techdata_top_level_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? TechdataTopLevelName { get; set; } 

        [JsonProperty("halointegrator_techdata", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorTechdata { get; set; } 

        [JsonProperty("halointegrator_techdata_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorTechdataLastSync { get; set; } 

        [JsonProperty("halointegrator_techdata_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorTechdataLastError { get; set; } 

        [JsonProperty("techdata_import_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? TechdataImportEntitiesList { get; set; } 

        [JsonProperty("inty_client_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLinkList>? IntyClientMappings { get; set; } 

        [JsonProperty("inty_top_level_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? IntyTopLevelName { get; set; } 

        [JsonProperty("halointegrator_inty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorInty { get; set; } 

        [JsonProperty("halointegrator_inty_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorIntyLastSync { get; set; } 

        [JsonProperty("halointegrator_inty_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorIntyLastError { get; set; } 

        [JsonProperty("inty_import_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? IntyImportEntitiesList { get; set; } 

        [JsonProperty("westcoastcloud_client_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLinkList>? WestcoastcloudClientMappings { get; set; } 

        [JsonProperty("westcoastcloud_top_level_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? WestcoastcloudTopLevelName { get; set; } 

        [JsonProperty("halointegrator_westcoastcloud", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorWestcoastcloud { get; set; } 

        [JsonProperty("halointegrator_westcoastcloud_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorWestcoastcloudLastSync { get; set; } 

        [JsonProperty("halointegrator_westcoastcloud_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorWestcoastcloudLastError { get; set; } 

        [JsonProperty("westcoastcloud_import_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? WestcoastcloudImportEntitiesList { get; set; } 

        [JsonProperty("sherweb_client_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLinkList>? SherwebClientMappings { get; set; } 

        [JsonProperty("sherweb_top_level_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SherwebTopLevelName { get; set; } 

        [JsonProperty("halointegrator_sherweb", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorSherweb { get; set; } 

        [JsonProperty("halointegrator_sherweb_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorSherwebLastSync { get; set; } 

        [JsonProperty("halointegrator_sherweb_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorSherwebLastError { get; set; } 

        [JsonProperty("sherweb_import_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? SherwebImportEntitiesList { get; set; } 

        [JsonProperty("also_client_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLinkList>? AlsoClientMappings { get; set; } 

        [JsonProperty("also_top_level_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AlsoTopLevelName { get; set; } 

        [JsonProperty("halointegrator_also", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorAlso { get; set; } 

        [JsonProperty("halointegrator_also_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorAlsoLastSync { get; set; } 

        [JsonProperty("halointegrator_also_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorAlsoLastError { get; set; } 

        [JsonProperty("also_import_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? AlsoImportEntitiesList { get; set; } 

        [JsonProperty("arrowsphere_client_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLinkList>? ArrowsphereClientMappings { get; set; } 

        [JsonProperty("arrowsphere_top_level_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ArrowsphereTopLevelName { get; set; } 

        [JsonProperty("halointegrator_arrowsphere", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorArrowsphere { get; set; } 

        [JsonProperty("halointegrator_arrowsphere_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorArrowsphereLastSync { get; set; } 

        [JsonProperty("halointegrator_arrowsphere_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorArrowsphereLastError { get; set; } 

        [JsonProperty("arrowsphere_import_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? ArrowsphereImportEntitiesList { get; set; } 

        [JsonProperty("dickerdata_client_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLinkList>? DickerdataClientMappings { get; set; } 

        [JsonProperty("dickerdata_top_level_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DickerdataTopLevelName { get; set; } 

        [JsonProperty("halointegrator_dickerdata", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorDickerdata { get; set; } 

        [JsonProperty("halointegrator_dickerdata_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorDickerdataLastSync { get; set; } 

        [JsonProperty("halointegrator_dickerdata_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorDickerdataLastError { get; set; } 

        [JsonProperty("dickerdata_import_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? DickerdataImportEntitiesList { get; set; } 

        [JsonProperty("halointegrator_oracle", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorOracle { get; set; } 

        [JsonProperty("halointegrator_oracle_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorOracleLastSync { get; set; } 

        [JsonProperty("halointegrator_oracle_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorOracleLastError { get; set; } 

        [JsonProperty("halointegrator_servicenow", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorServiceNow { get; set; } 

        [JsonProperty("halointegrator_servicenow_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorServiceNowLastSync { get; set; } 

        [JsonProperty("halointegrator_servicenow_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorServiceNowLastError { get; set; } 

        [JsonProperty("xerodefaulttenantname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Xerodefaulttenantname { get; set; } 

        [JsonProperty("qbdefaultcompanyname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Qbdefaultcompanyname { get; set; } 

        [JsonProperty("kashflowdefaultconnectionname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Kashflowdefaultconnectionname { get; set; } 

        [JsonProperty("dbcdefaulttenantname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Dbcdefaulttenantname { get; set; } 

        [JsonProperty("datadog_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DatadogUrl { get; set; } 

        [JsonProperty("clear_billing_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ClearBillingMappings { get; set; } 

        [JsonProperty("clearunsentactions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Clearunsentactions { get; set; } 

        [JsonProperty("clearunsentemailstore", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Clearunsentemailstore { get; set; } 

        [JsonProperty("clearunsentescmsg", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Clearunsentescmsg { get; set; } 

        [JsonProperty("clearunsentactions_attempted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ClearunsentactionsAttempted { get; set; } 

        [JsonProperty("clearunsentemailstore_attempted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ClearunsentemailstoreAttempted { get; set; } 

        [JsonProperty("clearunsentescmsg_attempted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ClearunsentescmsgAttempted { get; set; } 

        [JsonProperty("slack_ticket_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SlackTicketUserName { get; set; } 

        [JsonProperty("slack_command_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SlackCommandUserName { get; set; } 

        [JsonProperty("_checkexport_returnerrors", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? CheckexportReturnerrors { get; set; } 

        [JsonProperty("device_tenantids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<int>? DeviceTenantIds { get; set; } 

        [JsonProperty("client_tenantids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<int>? ClientTenantIds { get; set; } 

        [JsonProperty("connectwisecontrol_sitemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLinkList>? ConnectwisecontrolSitemappings { get; set; } 

        [JsonProperty("connectwisecontrol_typemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AssetTypeMapping>? ConnectwisecontrolTypemappings { get; set; } 

        [JsonProperty("halointegrator_connectwisecontrol", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegratorConnectwisecontrol { get; set; } 

        [JsonProperty("connectwisecontrol_import_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? ConnectwisecontrolImportEntitiesList { get; set; } 

        [JsonProperty("halointegrator_connectwisecontrol_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorConnectwisecontrolLastSync { get; set; } 

        [JsonProperty("halointegrator_connectwisecontrol_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorConnectwisecontrolLastError { get; set; } 

        [JsonProperty("connectwisecontrolassetdefaultsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ConnectwisecontrolassetdefaultsiteName { get; set; } 

        [JsonProperty("salesforce_priority_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? SalesforcePriorityMappings { get; set; } 

        [JsonProperty("cors_whitelist_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? CorsWhitelistList { get; set; } 

        [JsonProperty("okta_userrolemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? OktaUserrolemappings { get; set; } 

        [JsonProperty("workspace_devicemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? WorkspaceDevicemappings { get; set; }   
}