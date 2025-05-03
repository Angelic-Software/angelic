using System.CodeDom.Compiler;
using Angelic.Models.Clients;
using Angelic.Models.Configuration.Assets;
using Angelic.Models.Configuration.Integrations.Microsoft.Azure.AzureDelta;
using Angelic.Models.KeyPairs;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.Microsoft.Azure.AzureAd;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class AzureAdConnection
{
    [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Guid { get; set; } 

    [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Intent { get; set; } 

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Domain { get; set; } 

    [JsonProperty("directoryid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Directoryid { get; set; } 

    [JsonProperty("applicationid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ApplicationId { get; set; } 

    [JsonProperty("new_client_secret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewClientSecret { get; set; } 

    [JsonProperty("new_access_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewAccessToken { get; set; } 

    [JsonProperty("new_refresh_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewRefreshToken { get; set; } 

    [JsonProperty("token_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? TokenExpiry { get; set; } 

    [JsonProperty("_authcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Authcode { get; set; } 

    [JsonProperty("_exchangecodefortoken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Exchangecodefortoken { get; set; } 

    [JsonProperty("mappings_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IntegrationFieldMapping>? MappingsUser { get; set; } 

    [JsonProperty("mappings_agent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IntegrationFieldMapping>? MappingsAgent { get; set; } 

    [JsonProperty("mappings_agent_roles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IntegrationFieldMapping>? MappingsAgentRoles { get; set; } 

    [JsonProperty("mappings_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AzureAdMapping>? MappingsSite { get; set; } 

    [JsonProperty("user_matching_fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? UserMatchingFields { get; set; } 

    [JsonProperty("agent_matching_fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AgentMatchingFields { get; set; } 

    [JsonProperty("user_matching_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ValueLabelIsNewKeyPair>? UserMatchingList { get; set; } 

    [JsonProperty("agent_matching_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ValueLabelIsNewKeyPair>? AgentMatchingList { get; set; } 

    [JsonProperty("halointegratorenabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? HaloIntegratorenabled { get; set; } 

    [JsonProperty("halointegrator_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? HaloIntegratorLastSync { get; set; } 

    [JsonProperty("halointegrator_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? HaloIntegratorLastError { get; set; } 

    [JsonProperty("redirect_uri", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RedirectUri { get; set; } 

    [JsonProperty("mappings_cab", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IntegrationFieldMapping>? MappingsCab { get; set; } 

    [JsonProperty("manage_licenses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ManageLicenses { get; set; } 

    [JsonProperty("licensed_roles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? LicensedRoles { get; set; } 

    [JsonProperty("licensed_roles_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<StringIdNameKeyPair>? LicensedRolesList { get; set; } 

    [JsonProperty("tenant_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TenantType { get; set; } 

    [JsonProperty("mappings_device", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IntegrationFieldMapping>? MappingsDevice { get; set; } 

    [JsonProperty("defaultsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultSite { get; set; } 

    [JsonProperty("defaultsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultSiteName { get; set; } 

    [JsonProperty("assettype_choice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AssetTypeChoice { get; set; } 

    [JsonProperty("default_assetgroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultAssetGroup { get; set; } 

    [JsonProperty("default_assetgroup_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? DefaultAssetGroupGuid { get; set; } 

    [JsonProperty("default_assetgroup_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultAssetGroupName { get; set; } 

    [JsonProperty("default_assettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultAssetType { get; set; } 

    [JsonProperty("default_assettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? DefaultAssetTypeGuid { get; set; } 

    [JsonProperty("default_assettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultAssetTypeName { get; set; } 

    [JsonProperty("assettype_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AssetTypeField { get; set; } 

    [JsonProperty("assettype_fieldname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AssetTypeFieldName { get; set; } 

    [JsonProperty("import_identifier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ImportIdentifier { get; set; } 

    [JsonProperty("import_identifier_fieldname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ImportIdentifierFieldName { get; set; } 

    [JsonProperty("accountenabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Accountenabled { get; set; } 

    [JsonProperty("authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Authorized { get; set; } 

    [JsonProperty("new_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? NewMethod { get; set; } 

    [JsonProperty("createunmatchedusers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Createunmatchedusers { get; set; } 

    [JsonProperty("unmatchedusersite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Unmatchedusersite { get; set; } 

    [JsonProperty("unmatchedusersite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? UnmatchedusersiteName { get; set; } 

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Type { get; set; } 

    [JsonProperty("top_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TopLevel { get; set; } 

    [JsonProperty("auto_create_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AutoCreateMappings { get; set; } 

    [JsonProperty("auto_allow_sso", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AutoAllowSso { get; set; } 

    [JsonProperty("top_level_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TopLevelName { get; set; } 

    [JsonProperty("mappings_client", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ClientAzureTenant>? MappingsClient { get; set; } 

    [JsonProperty("default_ticket_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultTicketType { get; set; } 

    [JsonProperty("default_ticket_type_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultTicketTypeName { get; set; } 

    [JsonProperty("default_classification", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultClassification { get; set; } 

    [JsonProperty("default_classification_reason", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultClassificationReason { get; set; } 

    [JsonProperty("default_priority_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultPriorityName { get; set; } 

    [JsonProperty("mappings_ticket", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IntegrationFieldMapping>? MappingsTicket { get; set; } 

    [JsonProperty("intune_dont_update_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IntuneDontUpdateType { get; set; } 

    [JsonProperty("halo_integrator_import_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? HaloIntegratorImportList { get; set; } 

    [JsonProperty("halo_integrator_import_types", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ValueLabelIsNewKeyPair>? HaloIntegratorImportTypes { get; set; } 

    [JsonProperty("intune_enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IntuneEnabled { get; set; } 

    [JsonProperty("licence_import_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? LicenceImportType { get; set; } 

    [JsonProperty("graphendpoint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Graphendpoint { get; set; } 

    [JsonProperty("intuneusermatchingfield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Intuneusermatchingfield { get; set; } 

    [JsonProperty("current_scopes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<string>? CurrentScopes { get; set; } 

    [JsonProperty("_dosave", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DoSave { get; set; } 

    [JsonProperty("dont_sync_new_tenants", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DontSyncNewTenants { get; set; } 

    [JsonProperty("importunmatchedgroupasserviceaccount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Importunmatchedgroupasserviceaccount { get; set; } 

    [JsonProperty("deactivate_users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DeactivateUsers { get; set; } 

    [JsonProperty("mappings_priority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IntegrationFieldMapping>? MappingsPriority { get; set; } 

    [JsonProperty("allow_subscription_management", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowSubscriptionManagement { get; set; } 

    [JsonProperty("receive_subscription_updated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ReceiveSubscriptionUpdated { get; set; } 

    [JsonProperty("graph_host", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? GraphHost { get; set; } 

    [JsonProperty("mappings_user_roles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IntegrationFieldMapping>? MappingsUserRoles { get; set; } 

    [JsonProperty("alternate_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AlternateClientId { get; set; } 

    [JsonProperty("new_alternate_client_secret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewAlternateClientSecret { get; set; } 

    [JsonProperty("default_relationship_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultRelationshipType { get; set; } 

    [JsonProperty("mappings_xtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AssetTypeMapping>? MappingsXType { get; set; } 

    [JsonProperty("intune_delete_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? IntuneDeleteStatus { get; set; } 

    [JsonProperty("intune_delete_status_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? IntuneDeleteStatusName { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("sentinel_default_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SentinelDefaultUser { get; set; } 

    [JsonProperty("sentinel_default_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SentinelDefaultUserName { get; set; } 

    [JsonProperty("named_roles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NamedRoles { get; set; } 

    [JsonProperty("named_roles_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<StringIdNameKeyPair>? NamedRolesList { get; set; } 

    [JsonProperty("new_user_template", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? NewUserTemplate { get; set; } 

    [JsonProperty("new_user_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? NewUserType { get; set; } 

    [JsonProperty("mappings_new_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IntegrationFieldMapping>? MappingsNewUser { get; set; } 

    [JsonProperty("new_user_template_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewUserTemplateName { get; set; } 

    [JsonProperty("software_import_licence_matching", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? SoftwareImportLicenceMatching { get; set; } 

    [JsonProperty("default_intune_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultIntuneStatus { get; set; } 

    [JsonProperty("default_intune_status_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultIntuneStatusName { get; set; } 

    [JsonProperty("no_manager_role", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? NoManagerRole { get; set; } 

    [JsonProperty("no_manager_role_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NoManagerRoleName { get; set; } 

    [JsonProperty("track_sign_in_activity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? TrackSignInActivity { get; set; } 

    [JsonProperty("halointegrator_allowedclientidslist", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ValueLabelKeyPair>? HaloIntegratorAllowedclientidslist { get; set; } 

    [JsonProperty("halointegrator_allowedclientids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? HaloIntegratorAllowedclientids { get; set; } 

    [JsonProperty("user_licence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ValueLabelIsNewKeyPair>? UserLicence { get; set; } 

    [JsonProperty("user_licence_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? UserLicenceList { get; set; } 

    [JsonProperty("check_licence_list_for_service_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CheckLicenceListForServiceUser { get; set; } 

    [JsonProperty("exclude_mssense_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ExcludeMssenseDevices { get; set; } 

    [JsonProperty("authentication_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AuthenticationType { get; set; } 

    [JsonProperty("_confirmmanagedidentitysetup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Confirmmanagedidentitysetup { get; set; } 

    [JsonProperty("_confirmclientcredentialssetup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ConfirmClientCredentialsSetup { get; set; } 

    [JsonProperty("allow_presence_notifications", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowPresenceNotifications { get; set; } 

    [JsonProperty("licence_import_client", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? LicenceImportClient { get; set; } 

    [JsonProperty("licence_import_client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? LicenceImportClientName { get; set; } 

    [JsonProperty("assign_licences", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AssignLicences { get; set; } 

    [JsonProperty("resource", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Resource { get; set; } 

    [JsonProperty("only_import_sentinel_comments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? OnlyImportSentinelComments { get; set; } 

    [JsonProperty("use_delta_queries", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? UseDeltaQueries { get; set; } 

    [JsonProperty("_deltareset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public AzureDeltaReset? Deltareset { get; set; } 

    [JsonProperty("intune_user_matching_integration", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? IntuneUserMatchingIntegration { get; set; } 

    [JsonProperty("intune_recovered_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? IntuneRecoveredStatus { get; set; } 

    [JsonProperty("intune_recovered_status_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? IntuneRecoveredStatusName { get; set; } 

}