using System.CodeDom.Compiler;
using Angelic.Dtos;
using Angelic.KeyPairs;
using Newtonsoft.Json;

namespace Angelic;


    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class NCentralAlert
    {
        [JsonProperty("action", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Action { get; set; } 

        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Title { get; set; } 

        [JsonProperty("details", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Details { get; set; } 

        [JsonProperty("ncentralTicketId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NcentralTicketId { get; set; } 

        [JsonProperty("psaTicketNumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PsaTicketNumber { get; set; } 

        [JsonProperty("customTags", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public NCentralCustomTags? CustomTags { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class NCentralCustomTags
    {
        [JsonProperty("requestType", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? RequestType { get; set; } 

        [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Status { get; set; } 

        [JsonProperty("priority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Priority { get; set; } 

        [JsonProperty("category", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Category { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class NCentralDetails
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Url { get; set; } 

        [JsonProperty("username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Username { get; set; } 

        [JsonProperty("toplevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Toplevel { get; set; } 

        [JsonProperty("dontsyncaddr", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dontsyncaddr { get; set; } 

        [JsonProperty("defassettypegroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Defassettypegroup { get; set; } 

        [JsonProperty("defassettypegroup_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Defassettypegroup_name { get; set; } 

        [JsonProperty("newmethod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Newmethod { get; set; } 

        [JsonProperty("alerttickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Alerttickettype { get; set; } 

        [JsonProperty("tickettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Tickettype_name { get; set; } 

        [JsonProperty("alertticketuser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Alertticketuser { get; set; } 

        [JsonProperty("user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? User_name { get; set; } 

        [JsonProperty("alertusername", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Alertusername { get; set; } 

        [JsonProperty("alertclientid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Alertclientid { get; set; } 

        [JsonProperty("syncentities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Syncentities { get; set; } 

        [JsonProperty("enableintegrator", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enableintegrator { get; set; } 

        [JsonProperty("lastsyncdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Lastsyncdate { get; set; } 

        [JsonProperty("lastsyncerror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Lastsyncerror { get; set; } 

        [JsonProperty("reqcredsremote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Reqcredsremote { get; set; } 

        [JsonProperty("deactivateclients", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Deactivateclients { get; set; } 

        [JsonProperty("deactivateassets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Deactivateassets { get; set; } 

        [JsonProperty("asset_type_choice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Asset_type_choice { get; set; } 

        [JsonProperty("default_assettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_assettype { get; set; } 

        [JsonProperty("assettype_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Assettype_field { get; set; } 

        [JsonProperty("mappings_xtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<XTypeMapping>? Mappings_xtype { get; set; } 

        [JsonProperty("default_assettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_assettype_name { get; set; } 

        [JsonProperty("client_links", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLink_List>? Client_links { get; set; } 

        [JsonProperty("site_links", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLink_List>? Site_links { get; set; } 

        [JsonProperty("asset_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? Asset_fieldmappings { get; set; } 

        [JsonProperty("new_password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_password { get; set; } 

        [JsonProperty("new_alert_password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_alert_password { get; set; } 

        [JsonProperty("new_client_secret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_client_secret { get; set; } 

        [JsonProperty("automaticclientsitelink", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Automaticclientsitelink { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("login_port", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Login_port { get; set; } 

        [JsonProperty("match_user_device", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Match_user_device { get; set; } 

        [JsonProperty("ignore_probes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ignore_probes { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class NHD_Claim
    {
        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Type { get; set; } 

        [JsonProperty("value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Value { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class NHD_DeviceInfo
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(255)]
        public string? Id { get; set; } 

        [JsonProperty("user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(255)]
        public string? User_id { get; set; } 

        [JsonProperty("device_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(255)]
        public string? Device_name { get; set; } 

        [JsonProperty("manufacturer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(255)]
        public string? Manufacturer { get; set; } 

        [JsonProperty("model", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(255)]
        public string? Model { get; set; } 

        [JsonProperty("os", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(255)]
        public string? Os { get; set; } 

        [JsonProperty("app_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(255)]
        public string? App_name { get; set; } 

        [JsonProperty("app_version", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(255)]
        public string? App_version { get; set; } 

        [JsonProperty("apns_device_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(255)]
        public string? Apns_device_token { get; set; } 

        [JsonProperty("firebase_device_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(255)]
        public string? Firebase_device_token { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        [System.ComponentModel.DataAnnotations.StringLength(4000)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class NHD_Identity_Application
    {
        [JsonProperty("grant_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Grant_type { get; set; } 

        [JsonProperty("loginas_agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Loginas_agent_id { get; set; } 

        [JsonProperty("loginas_agent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Loginas_agent_name { get; set; } 

        [JsonProperty("inactive", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Inactive { get; set; } 

        [JsonProperty("system_use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? System_use { get; set; } 

        [JsonProperty("redirecturi", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Redirecturi { get; set; } 

        [JsonProperty("logoutredirecturi", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Logoutredirecturi { get; set; } 

        [JsonProperty("cors_whitelist", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Cors_whitelist { get; set; } 

        [JsonProperty("redirecturi_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? Redirecturi_list { get; set; } 

        [JsonProperty("postlogoutredirecturi_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? Postlogoutredirecturi_list { get; set; } 

        [JsonProperty("cors_whitelist_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? Cors_whitelist_list { get; set; } 

        [JsonProperty("scopes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<NHD_Identity_ApplicationScope>? Scopes { get; set; } 

        [JsonProperty("allowagents", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allowagents { get; set; } 

        [JsonProperty("allowusers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allowusers { get; set; } 

        [JsonProperty("organisation_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Organisation_id { get; set; } 

        [JsonProperty("organisation_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Organisation_name { get; set; } 

        [JsonProperty("loginas_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Loginas_client_id { get; set; } 

        [JsonProperty("loginas_client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Loginas_client_name { get; set; } 

        [JsonProperty("loginas_supplier_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Loginas_supplier_id { get; set; } 

        [JsonProperty("loginas_supplier_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Loginas_supplier_name { get; set; } 

        [JsonProperty("loginentity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Loginentity { get; set; } 

        [JsonProperty("language_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Language_id { get; set; } 

        [JsonProperty("language_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Language_name { get; set; } 

        [JsonProperty("disable_windowsauth", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Disable_windowsauth { get; set; } 

        [JsonProperty("disable_azure", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Disable_azure { get; set; } 

        [JsonProperty("disable_adfs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Disable_adfs { get; set; } 

        [JsonProperty("disable_okta", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Disable_okta { get; set; } 

        [JsonProperty("disable_centrify", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Disable_centrify { get; set; } 

        [JsonProperty("disable_google", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Disable_google { get; set; } 

        [JsonProperty("button_config", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<LoginScreenConfig>? Button_config { get; set; } 

        [JsonProperty("assertion_consumer_service_index", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Assertion_consumer_service_index { get; set; } 

        [JsonProperty("disable_anon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Disable_anon { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("_issystem", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _issystem { get; set; } 

        [JsonProperty("authorizations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<OpenIddictAuthorization>? Authorizations { get; set; } 

        [JsonProperty("clientId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ClientId { get; set; } 

        [JsonProperty("clientSecret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ClientSecret { get; set; } 

        [JsonProperty("concurrencyToken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ConcurrencyToken { get; set; } 

        [JsonProperty("consentType", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ConsentType { get; set; } 

        [JsonProperty("displayName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DisplayName { get; set; } 

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Id { get; set; } 

        [JsonProperty("permissions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Permissions { get; set; } 

        [JsonProperty("postLogoutRedirectUris", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PostLogoutRedirectUris { get; set; } 

        [JsonProperty("properties", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Properties { get; set; } 

        [JsonProperty("redirectUris", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? RedirectUris { get; set; } 

        [JsonProperty("tokens", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<OpenIddictToken>? Tokens { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Type { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class NHD_Identity_ApplicationScope
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("application_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Application_id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class NHD_Roles
    {
        [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intent { get; set; } 

        [JsonProperty("chargerates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Restriction>? Chargerates { get; set; } 

        [JsonProperty("id_int", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id_int { get; set; } 

        [JsonProperty("notes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Notes { get; set; } 

        [JsonProperty("teams", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<UnameSection>? Teams { get; set; } 

        [JsonProperty("departments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<UnameDepartment>? Departments { get; set; } 

        [JsonProperty("clients", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<UnameAreaRestriction>? Clients { get; set; } 

        [JsonProperty("tickettypes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<UnameRequestType>? Tickettypes { get; set; } 

        [JsonProperty("assetfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<UnameField>? Assetfields { get; set; } 

        [JsonProperty("unamecustomfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<UnameCustom>? Unamecustomfields { get; set; } 

        [JsonProperty("unameappointmenttypes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<UnameAppointment>? Unameappointmenttypes { get; set; } 

        [JsonProperty("notifications", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<UnameNotification>? Notifications { get; set; } 

        [JsonProperty("claims", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<NHD_Claim>? Claims { get; set; } 

        [JsonProperty("custombuttons", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<UnameButton>? Custombuttons { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("assettypes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<UnameXtype>? Assettypes { get; set; } 

        [JsonProperty("Oo_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Oo_name { get; set; } 

        [JsonProperty("uname_usercustomfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<UnameCustom>? Uname_usercustomfields { get; set; } 

        [JsonProperty("access_control", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? Access_control { get; set; } 

        [JsonProperty("access_control_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Access_control_level { get; set; } 

        [JsonProperty("ac_tickettypes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? Ac_tickettypes { get; set; } 

        [JsonProperty("ac_approvals", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? Ac_approvals { get; set; } 

        [JsonProperty("ac_rules", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? Ac_rules { get; set; } 

        [JsonProperty("ac_cannedtext", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? Ac_cannedtext { get; set; } 

        [JsonProperty("ac_customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? Ac_customfields { get; set; } 

        [JsonProperty("ac_customtables", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? Ac_customtables { get; set; } 

        [JsonProperty("ac_dashboards", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? Ac_dashboards { get; set; } 

        [JsonProperty("ac_workflows", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? Ac_workflows { get; set; } 

        [JsonProperty("ac_roles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? Ac_roles { get; set; } 

        [JsonProperty("ac_slas", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? Ac_slas { get; set; } 

        [JsonProperty("ac_templates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? Ac_templates { get; set; } 

        [JsonProperty("ac_outcomes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? Ac_outcomes { get; set; } 

        [JsonProperty("ac_workdays", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? Ac_workdays { get; set; } 

        [JsonProperty("ac_emailtemplates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? Ac_emailtemplates { get; set; } 

        [JsonProperty("ac_messagegroups", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? Ac_messagegroups { get; set; } 

        [JsonProperty("ac_reportgroups", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? Ac_reportgroups { get; set; } 

        [JsonProperty("ac_fieldgroups", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? Ac_fieldgroups { get; set; } 

        [JsonProperty("ac_languagepacks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? Ac_languagepacks { get; set; } 

        [JsonProperty("ac_itemgroups", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? Ac_itemgroups { get; set; } 

        [JsonProperty("ac_suppliers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? Ac_suppliers { get; set; } 

        [JsonProperty("ac_suppliercontracts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? Ac_suppliercontracts { get; set; } 

        [JsonProperty("is_integration", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_integration { get; set; } 

        [JsonProperty("ac_assettypes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? Ac_assettypes { get; set; } 

        [JsonProperty("ac_assetgroups", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? Ac_assetgroups { get; set; } 

        [JsonProperty("ac_servicecategories", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? Ac_servicecategories { get; set; } 

        [JsonProperty("ac_services", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? Ac_services { get; set; } 

        [JsonProperty("ac_chatprofiles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? Ac_chatprofiles { get; set; } 

        [JsonProperty("ac_faqlists", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? Ac_faqlists { get; set; } 

        [JsonProperty("ac_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? Ac_devices { get; set; } 

        [JsonProperty("sites", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<UnameSite>? Sites { get; set; } 

        [JsonProperty("ac_databaselookups", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? Ac_databaselookups { get; set; } 

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("normalizedName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NormalizedName { get; set; } 

        [JsonProperty("concurrencyStamp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ConcurrencyStamp { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class NHServerConfig
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("acceptattachments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Acceptattachments { get; set; } 

        [JsonProperty("acceptautoreplycheckbox", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Acceptautoreplycheckbox { get; set; } 

        [JsonProperty("actionemails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Actionemails { get; set; } 

        [JsonProperty("actionsendlimit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Actionsendlimit { get; set; } 

        [JsonProperty("approvalscan", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Approvalscan { get; set; } 

        [JsonProperty("assetattachmentmaintenance", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Assetattachmentmaintenance { get; set; } 

        [JsonProperty("autocreatedevice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Autocreatedevice { get; set; } 

        [JsonProperty("autodevicesite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Autodevicesite { get; set; } 

        [JsonProperty("autodevicetype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Autodevicetype { get; set; } 

        [JsonProperty("autolinkdevices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Autolinkdevices { get; set; } 

        [JsonProperty("automatchlocation2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Automatchlocation2 { get; set; } 

        [JsonProperty("autoondiagram", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Autoondiagram { get; set; } 

        [JsonProperty("autorequests", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Autorequests { get; set; } 

        [JsonProperty("calendarsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Calendarsync { get; set; } 

        [JsonProperty("clearlogboxes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Clearlogboxes { get; set; } 

        [JsonProperty("confforemails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Confforemails { get; set; } 

        [JsonProperty("datefilter", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Datefilter { get; set; } 

        [JsonProperty("deleteerrors", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Deleteerrors { get; set; } 

        [JsonProperty("emailcreatenewuser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Emailcreatenewuser { get; set; } 

        [JsonProperty("emaillogfolder", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Emaillogfolder { get; set; } 

        [JsonProperty("emailnoack", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Emailnoack { get; set; } 

        [JsonProperty("emailrequesttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Emailrequesttype { get; set; } 

        [JsonProperty("emailsiteint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Emailsiteint { get; set; } 

        [JsonProperty("emailtechieint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Emailtechieint { get; set; } 

        [JsonProperty("emailusefullname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Emailusefullname { get; set; } 

        [JsonProperty("emailuserdefault", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Emailuserdefault { get; set; } 

        [JsonProperty("emailuserint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Emailuserint { get; set; } 

        [JsonProperty("emailusesitedomain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Emailusesitedomain { get; set; } 

        [JsonProperty("errorreportemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Errorreportemail { get; set; } 

        [JsonProperty("errorreportemailaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Errorreportemailaddress { get; set; } 

        [JsonProperty("errorreportrequest", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Errorreportrequest { get; set; } 

        [JsonProperty("ewslastapptsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Ewslastapptsync { get; set; } 

        [JsonProperty("forcehtml", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Forcehtml { get; set; } 

        [JsonProperty("highlevellogging", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Highlevellogging { get; set; } 

        [JsonProperty("ignorecc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ignorecc { get; set; } 

        [JsonProperty("ignoreduplicateemails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ignoreduplicateemails { get; set; } 

        [JsonProperty("ignoreifsitenotmatched", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ignoreifsitenotmatched { get; set; } 

        [JsonProperty("intervalseconds", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Intervalseconds { get; set; } 

        [JsonProperty("maintenancerequests", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Maintenancerequests { get; set; } 

        [JsonProperty("mainttime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Mainttime { get; set; } 

        [JsonProperty("nhdsuppliersync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Nhdsuppliersync { get; set; } 

        [JsonProperty("nooverduescan", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Nooverduescan { get; set; } 

        [JsonProperty("pop3interface", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Pop3interface { get; set; } 

        [JsonProperty("popuptimeoutseconds", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Popuptimeoutseconds { get; set; } 

        [JsonProperty("prepayautotopup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Prepayautotopup { get; set; } 

        [JsonProperty("processxmlfiles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Processxmlfiles { get; set; } 

        [JsonProperty("recurringcalendarsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Recurringcalendarsync { get; set; } 

        [JsonProperty("refreshautoinv", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Refreshautoinv { get; set; } 

        [JsonProperty("requestscan", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Requestscan { get; set; } 

        [JsonProperty("saverawemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Saverawemail { get; set; } 

        [JsonProperty("sendsmtp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sendsmtp { get; set; } 

        [JsonProperty("sendtray", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sendtray { get; set; } 

        [JsonProperty("sendwelcomeemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sendwelcomeemail { get; set; } 

        [JsonProperty("servicestatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Servicestatus { get; set; } 

        [JsonProperty("statussendlimit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Statussendlimit { get; set; } 

        [JsonProperty("storeemailsindb", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Storeemailsindb { get; set; } 

        [JsonProperty("timeoutseconds", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Timeoutseconds { get; set; } 

        [JsonProperty("emailsitename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Emailsitename { get; set; } 

        [JsonProperty("emailusername", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Emailusername { get; set; } 

        [JsonProperty("autodevicesitename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Autodevicesitename { get; set; } 

        [JsonProperty("autodevicetypename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Autodevicetypename { get; set; } 

        [JsonProperty("reporttimeout", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Reporttimeout { get; set; } 

        [JsonProperty("deletecustomdata", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Deletecustomdata { get; set; } 

        [JsonProperty("bulkemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Bulkemail { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class NPR_Result
    {
        [JsonProperty("windows_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Windows_user { get; set; } 

        [JsonProperty("email_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Email_address { get; set; } 

        [JsonProperty("activedirectory_dn", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Activedirectory_dn { get; set; } 

        [JsonProperty("onpremise_activedirectory_dn", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Onpremise_activedirectory_dn { get; set; } 

        [JsonProperty("enrolled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enrolled { get; set; } 

        [JsonProperty("questions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<SecurityQuestion>? Questions { get; set; } 

        [JsonProperty("hide_answers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hide_answers { get; set; } 

        [JsonProperty("validated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Validated { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class NinjaAlert
    {
        [JsonProperty("uid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Uid { get; set; } 

        [JsonProperty("deviceId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DeviceId { get; set; } 

        [JsonProperty("message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Message { get; set; } 

        [JsonProperty("createTime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? CreateTime { get; set; } 

        [JsonProperty("updateTime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? UpdateTime { get; set; } 

        [JsonProperty("sourceType", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SourceType { get; set; } 

        [JsonProperty("sourceConfigUid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SourceConfigUid { get; set; } 

        [JsonProperty("sourceName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SourceName { get; set; } 

        [JsonProperty("subject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Subject { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class NinjaWebhook
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("activityTime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? ActivityTime { get; set; } 

        [JsonProperty("deviceId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DeviceId { get; set; } 

        [JsonProperty("seriesUid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SeriesUid { get; set; } 

        [JsonProperty("activityType", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ActivityType { get; set; } 

        [JsonProperty("statusCode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? StatusCode { get; set; } 

        [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Status { get; set; } 

        [JsonProperty("activityResult", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ActivityResult { get; set; } 

        [JsonProperty("sourceConfigUid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SourceConfigUid { get; set; } 

        [JsonProperty("sourceName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SourceName { get; set; } 

        [JsonProperty("subject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Subject { get; set; } 

        [JsonProperty("message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Message { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Type { get; set; } 

        [JsonProperty("severity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Severity { get; set; } 

        [JsonProperty("priority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Priority { get; set; } 

        [JsonProperty("data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public NinjaWebhookData? Data { get; set; } 

        [JsonProperty("resourceObject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public object? ResourceObject { get; set; } 

        [JsonProperty("activityTypeEnum", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public NinjaWebhookActivityType? ActivityTypeEnum { get; set; } 

        [JsonProperty("statusCodeEnum", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public NinjaWebhookStatus? StatusCodeEnum { get; set; } 

        [JsonProperty("activityResultEnum", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public NinjaWebhookActivityResult? ActivityResultEnum { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum NinjaWebhookActivityResult
    {

        _0 = 0,

        _1 = 1,

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum NinjaWebhookActivityType
    {

        _0 = 0,

        _1 = 1,

        _2 = 2,

        _3 = 3,

        _4 = 4,

        _5 = 5,

        _6 = 6,

        _7 = 7,

        _8 = 8,

        _9 = 9,

        _10 = 10,

        _11 = 11,

        _12 = 12,

        _13 = 13,

        _14 = 14,

        _15 = 15,

        _16 = 16,

        _17 = 17,

        _18 = 18,

        _19 = 19,

        _20 = 20,

        _21 = 21,

        _22 = 22,

        _23 = 23,

        _24 = 24,

        _25 = 25,

        _26 = 26,

        _27 = 27,

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class NinjaWebhookData
    {
        [JsonProperty("message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public NinjaWebhookDataMessage? Message { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class NinjaWebhookDataMessage
    {
        [JsonProperty("code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Code { get; set; } 

        [JsonProperty("_params", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public NinjaWebhookDataMessageParams? _params { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class NinjaWebhookDataMessageParams
    {
        [JsonProperty("threshold", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Threshold { get; set; } 

        [JsonProperty("unit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Unit { get; set; } 

        [JsonProperty("start_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Start_date { get; set; } 

        [JsonProperty("end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? End_date { get; set; } 

        [JsonProperty("top_processes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Top_processes { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public enum NinjaWebhookStatus
    {

        _0 = 0,

        _1 = 1,

        _2 = 2,

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class NotificationConditions
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("rule_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Rule_id { get; set; } 

        [JsonProperty("notification_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Notification_guid { get; set; } 

        [JsonProperty("fieldname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Fieldname { get; set; } 

        [JsonProperty("fieldid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Fieldid { get; set; } 

        [JsonProperty("change_context", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Change_context { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; } 

        [JsonProperty("value_int", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Value_int { get; set; } 

        [JsonProperty("valueint_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Valueint_guid { get; set; } 

        [JsonProperty("value_string", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Value_string { get; set; } 

        [JsonProperty("value_display", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Value_display { get; set; } 

        [JsonProperty("value_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Value_type { get; set; } 

        [JsonProperty("timezonestring", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Timezonestring { get; set; } 

        [JsonProperty("tablename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Tablename { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("fieldtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Fieldtype { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class NotificationContent
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Guid { get; set; } 

        [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intent { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Message { get; set; } 

        [JsonProperty("body_text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Body_text { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }