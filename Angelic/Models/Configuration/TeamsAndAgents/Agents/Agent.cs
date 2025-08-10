using System.CodeDom.Compiler;
using Angelic.Models.Configuration.Custom.CustomFields;
using Angelic.Models.Configuration.TeamsAndAgents.Agents.AgentNotifications;
using Angelic.Models.KeyPairs;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.TeamsAndAgents.Agents;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class Agent
    {
        [JsonProperty("sites", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AgentSite>? Sites { get; set; } 

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("onlinestatus_actual", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? OnlineStatusActual { get; set; } 

        [JsonProperty("onlinestatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? OnlineStatus { get; set; } 

        [JsonProperty("is_online", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsOnline { get; set; } 

        [JsonProperty("lastonline", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? LastOnline { get; set; } 

        [JsonProperty("team", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Team { get; set; } 

        [JsonProperty("isdisabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDisabled { get; set; } 

        [JsonProperty("email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Email { get; set; } 

        [JsonProperty("ad", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ad { get; set; } 

        [JsonProperty("lastlogindate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Lastlogindate { get; set; } 

        [JsonProperty("agentphotopath", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Agentphotopath { get; set; } 

        [JsonProperty("initials", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Initials { get; set; } 

        [JsonProperty("firstname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? FirstName { get; set; } 

        [JsonProperty("surname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Surname { get; set; } 

        [JsonProperty("colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Colour { get; set; } 

        [JsonProperty("jobtitle", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Jobtitle { get; set; } 

        [JsonProperty("sms", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sms { get; set; } 

        [JsonProperty("extensionnumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Extensionnumber { get; set; } 

        [JsonProperty("ticket_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TicketCount { get; set; } 

        [JsonProperty("is_agent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAgent { get; set; } 

        [JsonProperty("one_client", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? OneClient { get; set; } 

        [JsonProperty("teams", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AgentSection>? Teams { get; set; } 

        [JsonProperty("departments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AgentDepartment>? Departments { get; set; } 

        [JsonProperty("clients", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AgentAreaRestriction>? Clients { get; set; } 

        [JsonProperty("tickettypes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AgentTicketType>? TicketTypes { get; set; } 

        [JsonProperty("qualifications", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AgentQualification>? Qualifications { get; set; } 

        [JsonProperty("qualification_weighting", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? QualificationWeighting { get; set; } 

        [JsonProperty("qualified", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Qualified { get; set; } 

        [JsonProperty("role_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? RoleList { get; set; } 

        [JsonProperty("current_action_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CurrentActionType { get; set; } 

        [JsonProperty("current_action_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CurrentActionName { get; set; } 

        [JsonProperty("assettypes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AgentAssetType>? AssetTypes { get; set; } 

        [JsonProperty("googleemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Googleemail { get; set; } 

        [JsonProperty("linemanager", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Linemanager { get; set; } 

        [JsonProperty("linemanager_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? LinemanagerName { get; set; } 

        [JsonProperty("inboxes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Inboxes { get; set; } 

        [JsonProperty("exchange_authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ExchangeAuthorized { get; set; } 

        [JsonProperty("exchange_account", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ExchangeAccount { get; set; } 

        [JsonProperty("sentinel_authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SentinelAuthorized { get; set; } 

        [JsonProperty("licence_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LicenceType { get; set; } 

        [JsonProperty("named_licences_in_use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NamedLicencesInUse { get; set; } 

        [JsonProperty("concurrent_licences_in_use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ConcurrentLicencesInUse { get; set; } 

        [JsonProperty("concurrent_agent_total", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ConcurrentAgentTotal { get; set; } 

        [JsonProperty("google_mail_authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? GoogleMailAuthorized { get; set; } 

        [JsonProperty("inbox_clientid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? InboxClientId { get; set; } 

        [JsonProperty("isapiagent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsApiagent { get; set; } 

        [JsonProperty("splashtop_authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SplashtopAuthorized { get; set; } 

        [JsonProperty("gotoresolve_authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? GotoresolveAuthorized { get; set; } 

        [JsonProperty("datecreated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? DateCreated { get; set; } 

        [JsonProperty("password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Password { get; set; } 

        [JsonProperty("lunchbreak", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Lunchbreak { get; set; } 

        [JsonProperty("agentphotodata", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Agentphotodata { get; set; } 

        [JsonProperty("pagesize", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Pagesize { get; set; } 

        [JsonProperty("signature", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Signature { get; set; } 

        [JsonProperty("default_filter_id_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultFilterIdTickets { get; set; } 

        [JsonProperty("default_filter_name_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultFilterNameTickets { get; set; } 

        [JsonProperty("default_columns_id_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultColumnsIdTickets { get; set; } 

        [JsonProperty("default_columns_name_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultColumnsNameTickets { get; set; } 

        [JsonProperty("default_view_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultViewTickets { get; set; } 

        [JsonProperty("default_view_tickets_selectedid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultViewTicketsSelectedId { get; set; } 

        [JsonProperty("default_view_tickets_selectedname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultViewTicketsSelectedName { get; set; } 

        [JsonProperty("default_filter_id_opps", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultFilterIdOpps { get; set; } 

        [JsonProperty("default_filter_name_opps", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultFilterNameOpps { get; set; } 

        [JsonProperty("default_columns_id_opps", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultColumnsIdOpps { get; set; } 

        [JsonProperty("default_columns_name_opps", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultColumnsNameOpps { get; set; } 

        [JsonProperty("default_view_opps", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultViewOpps { get; set; } 

        [JsonProperty("default_view_opps_selectedid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultViewOppsSelectedId { get; set; } 

        [JsonProperty("default_view_opps_selectedname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultViewOppsSelectedName { get; set; } 

        [JsonProperty("default_action_view", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultActionView { get; set; } 

        [JsonProperty("default_action_display", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultActionDisplay { get; set; } 

        [JsonProperty("default_feed_view", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultFeedView { get; set; } 

        [JsonProperty("ticket_preview_mode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? TicketPreviewMode { get; set; } 

        [JsonProperty("default_ticket_preview_size", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultTicketPreviewSize { get; set; } 

        [JsonProperty("list_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ListType { get; set; } 

        [JsonProperty("navmenu_mode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NavmenuMode { get; set; } 

        [JsonProperty("default_calendar_view", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultCalendarView { get; set; } 

        [JsonProperty("calendar_options", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? CalendarOptions { get; set; } 

        [JsonProperty("search_options", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SearchOptions { get; set; } 

        [JsonProperty("newtabpref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Newtabpref { get; set; } 

        [JsonProperty("theme", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Theme { get; set; } 

        [JsonProperty("theme_revert", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ThemeRevert { get; set; } 

        [JsonProperty("language_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LanguageId { get; set; } 

        [JsonProperty("language_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? LanguageName { get; set; } 

        [JsonProperty("app_colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AppColour { get; set; } 

        [JsonProperty("app_colour_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AppColourType { get; set; } 

        [JsonProperty("nav_display_mode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NavDisplayMode { get; set; } 

        [JsonProperty("enablehighcontrast", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enablehighcontrast { get; set; } 

        [JsonProperty("actionscreen_display_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ActionscreenDisplayType { get; set; } 

        [JsonProperty("homescreenchartid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Homescreenchartid { get; set; } 

        [JsonProperty("homescreenchartname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Homescreenchartname { get; set; } 

        [JsonProperty("homescreenchartpublishedid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Homescreenchartpublishedid { get; set; } 

        [JsonProperty("homescreendashboardid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Homescreendashboardid { get; set; } 

        [JsonProperty("homescreendashboardname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Homescreendashboardname { get; set; } 

        [JsonProperty("sidemenudashboardid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sidemenudashboardid { get; set; } 

        [JsonProperty("sidemenudashboardname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sidemenudashboardname { get; set; } 

        [JsonProperty("clientdetails_layout_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ClientDetailsLayoutId { get; set; } 

        [JsonProperty("clientdetails_layout_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ClientDetailsLayoutName { get; set; } 

        [JsonProperty("nav_layout_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? NavLayoutId { get; set; } 

        [JsonProperty("nav_layout_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NavLayoutName { get; set; } 

        [JsonProperty("sendowneremails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sendowneremails { get; set; } 

        [JsonProperty("warnifnoscan", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Warnifnoscan { get; set; } 

        [JsonProperty("dontemailmeifiloggedit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DontEmailMeifiloggedit { get; set; } 

        [JsonProperty("workhour_start", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? WorkhourStart { get; set; } 

        [JsonProperty("workhour_end", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? WorkhourEnd { get; set; } 

        [JsonProperty("activedirectory_dn", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ActiveDirectoryDn { get; set; } 

        [JsonProperty("third_party_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ThirdPartyGuid { get; set; } 

        [JsonProperty("roles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Roles>? Roles { get; set; } 

        [JsonProperty("add_roles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Roles>? AddRoles { get; set; } 

        [JsonProperty("claims", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<NhdClaim>? Claims { get; set; } 

        [JsonProperty("department", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Department { get; set; } 

        [JsonProperty("_is_a_departmentmanager", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsADepartmentmanager { get; set; } 

        [JsonProperty("_is_a_teammanager", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsATeammanager { get; set; } 

        [JsonProperty("access_control", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? AccessControl { get; set; } 

        [JsonProperty("twofactor_enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? TwofactorEnabled { get; set; } 

        [JsonProperty("_isnew", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsNew { get; set; } 

        [JsonProperty("adconnection", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Adconnection { get; set; } 

        [JsonProperty("useadlogin", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Useadlogin { get; set; } 

        [JsonProperty("container_dn", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ContainerDn { get; set; } 

        [JsonProperty("notifications", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AgentNotification>? Notifications { get; set; } 

        [JsonProperty("notifications_personal", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AgentNotification>? NotificationsPersonal { get; set; } 

        [JsonProperty("emailconfirmed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EmailConfirmed { get; set; } 

        [JsonProperty("accountconfirmed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Accountconfirmed { get; set; } 

        [JsonProperty("isinvite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsInvite { get; set; } 

        [JsonProperty("is_sales", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsSales { get; set; } 

        [JsonProperty("_getlogmeinid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Getlogmeinid { get; set; } 

        [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsImport { get; set; } 

        [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ImportType { get; set; } 

        [JsonProperty("_importtoken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ImportToken { get; set; } 

        [JsonProperty("beyondtrust_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? BeyondtrustName { get; set; } 

        [JsonProperty("azure_roleid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AzureRoleId { get; set; } 

        [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CustomField>? CustomFields { get; set; } 

        [JsonProperty("chargerates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Restriction>? ChargeRates { get; set; } 

        [JsonProperty("warnifnoscan_integrator", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? WarnifnoscanIntegrator { get; set; } 

        [JsonProperty("warnifnoscan_integrator_hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? WarnifnoscanIntegratorHours { get; set; } 

        [JsonProperty("orion_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OrionUsername { get; set; } 

        [JsonProperty("orion_password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OrionPassword { get; set; } 

        [JsonProperty("ncentral_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NCentralUsername { get; set; } 

        [JsonProperty("soc_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SocUsername { get; set; } 

        [JsonProperty("autotaskid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AutoTaskId { get; set; } 

        [JsonProperty("oktaid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Oktaid { get; set; } 

        [JsonProperty("okta_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OktaStatus { get; set; } 

        [JsonProperty("new_ncentral_key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewNCentralKey { get; set; } 

        [JsonProperty("pomincostforapprovaltype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Pomincostforapprovaltype { get; set; } 

        [JsonProperty("pomincostforapproval", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Pomincostforapproval { get; set; } 

        [JsonProperty("quotemarginforapprovaltype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Quotemarginforapprovaltype { get; set; } 

        [JsonProperty("quotemarginforapproval", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Quotemarginforapproval { get; set; } 

        [JsonProperty("new_orion_password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewOrionPassword { get; set; } 

        [JsonProperty("orion_access", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? OrionAccess { get; set; } 

        [JsonProperty("new_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? NewMethod { get; set; } 

        [JsonProperty("exchange_token_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? ExchangeTokenExpiry { get; set; } 

        [JsonProperty("exchange_redirect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ExchangeRedirect { get; set; } 

        [JsonProperty("_getoauthtoken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Getoauthtoken { get; set; } 

        [JsonProperty("oauth_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OauthCode { get; set; } 

        [JsonProperty("oauth_redirect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OauthRedirect { get; set; } 

        [JsonProperty("oauth_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OauthType { get; set; } 

        [JsonProperty("new_access_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewAccessToken { get; set; } 

        [JsonProperty("new_token_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewTokenType { get; set; } 

        [JsonProperty("new_refresh_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewRefreshToken { get; set; } 

        [JsonProperty("_disconnectintegration", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Disconnectintegration { get; set; } 

        [JsonProperty("sentinel_token_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? SentinelTokenExpiry { get; set; } 

        [JsonProperty("sentinel_redirect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SentinelRedirect { get; set; } 

        [JsonProperty("default_columns_id_assets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultColumnsIdAssets { get; set; } 

        [JsonProperty("Oo_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OoName { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warning { get; set; } 

        [JsonProperty("isagentdetails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAgentdetails { get; set; } 

        [JsonProperty("excludefromresourcebooking", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ExcludeFromresourcebooking { get; set; } 

        [JsonProperty("delegation_activated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DelegationActivated { get; set; } 

        [JsonProperty("delegation_timebased", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DelegationTimebased { get; set; } 

        [JsonProperty("delegation_start", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? DelegationStart { get; set; } 

        [JsonProperty("delegation_end", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? DelegationEnd { get; set; } 

        [JsonProperty("delegation_user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DelegationUserId { get; set; } 

        [JsonProperty("delegation_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DelegationUsername { get; set; } 

        [JsonProperty("_reassign_all_accounts_to_agent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ReassignAllAccountsToAgent { get; set; } 

        [JsonProperty("_kick", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Kick { get; set; } 

        [JsonProperty("_revoke_tokens", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? RevokeTokens { get; set; } 

        [JsonProperty("authenticatorapp_configured", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AuthenticatorappConfigured { get; set; } 

        [JsonProperty("_revoke_authenticatorapp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? RevokeAuthenticatorapp { get; set; } 

        [JsonProperty("ispasswordreset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsPasswordreset { get; set; } 

        [JsonProperty("graph_host", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? GraphHost { get; set; } 

        [JsonProperty("linked_halo_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? LinkedHaloUrl { get; set; } 

        [JsonProperty("holiday_allowance", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? HolidayAllowance { get; set; } 

        [JsonProperty("remaining_holiday_allowance", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? RemainingHolidayAllowance { get; set; } 

        [JsonProperty("_isbatch", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsBatch { get; set; } 

        [JsonProperty("import_photo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ImportPhoto { get; set; } 

        [JsonProperty("travelrate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Travelrate { get; set; } 

        [JsonProperty("github_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? GithubUsername { get; set; } 

        [JsonProperty("_signature_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SignatureId { get; set; } 

        [JsonProperty("_signature", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PrefixedUnderscoreSignature { get; set; } 

        [JsonProperty("is_admin", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAdmin { get; set; } 

        [JsonProperty("ac_tickettypes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? AcTicketTypes { get; set; } 

        [JsonProperty("ac_approvals", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? AcApprovals { get; set; } 

        [JsonProperty("ac_rules", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? AcRules { get; set; } 

        [JsonProperty("ac_cannedtext", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? AcCannedText { get; set; } 

        [JsonProperty("ac_customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? AcCustomFields { get; set; } 

        [JsonProperty("ac_customtables", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? AcCustomTables { get; set; } 

        [JsonProperty("ac_dashboards", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? AcDashboards { get; set; } 

        [JsonProperty("ac_workflows", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? AcWorkflows { get; set; } 

        [JsonProperty("ac_roles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? AcRoles { get; set; } 

        [JsonProperty("ac_slas", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? AcSlas { get; set; } 

        [JsonProperty("ac_templates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? AcTemplates { get; set; } 

        [JsonProperty("ac_outcomes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? AcOutcomes { get; set; } 

        [JsonProperty("ac_workdays", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? AcWorkdays { get; set; } 

        [JsonProperty("ac_emailtemplates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? AcEmailTemplates { get; set; } 

        [JsonProperty("ac_messagegroups", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? AcMessageGroups { get; set; } 

        [JsonProperty("ac_reportgroups", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? AcReportgroups { get; set; } 

        [JsonProperty("ac_fieldgroups", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? AcFieldgroups { get; set; } 

        [JsonProperty("ac_languagepacks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? AcLanguagepacks { get; set; } 

        [JsonProperty("ac_itemgroups", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? AcItemGroups { get; set; } 

        [JsonProperty("default_columns_id_clients", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultColumnsIdClients { get; set; } 

        [JsonProperty("default_view_clients_selectedname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultViewClientsSelectedName { get; set; } 

        [JsonProperty("default_view_assets_selectedname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultViewAssetsSelectedName { get; set; } 

        [JsonProperty("_do_reassign01", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DoReassign01 { get; set; } 

        [JsonProperty("check_reassign01", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? CheckReassign01 { get; set; } 

        [JsonProperty("_force", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Force { get; set; } 

        [JsonProperty("default_view_customers_selectedid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultViewCustomersSelectedId { get; set; } 

        [JsonProperty("default_view_customers_selectedname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultViewCustomersSelectedName { get; set; } 

        [JsonProperty("default_view_users_selectedid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultViewUsersSelectedId { get; set; } 

        [JsonProperty("default_view_users_selectedname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultViewUsersSelectedName { get; set; } 

        [JsonProperty("default_columns_id_contracts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultColumnsIdContracts { get; set; } 

        [JsonProperty("default_view_contracts_selectedname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultViewContractsSelectedName { get; set; } 

        [JsonProperty("default_columns_id_sites", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultColumnsIdSites { get; set; } 

        [JsonProperty("default_columns_sites_selectedname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultColumnsSitesSelectedName { get; set; } 

        [JsonProperty("default_columns_id_users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultColumnsIdUsers { get; set; } 

        [JsonProperty("default_columns_users_selectedname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultColumnsUsersSelectedName { get; set; } 

        [JsonProperty("pagerduty_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? PagerdutyEmail { get; set; } 

        [JsonProperty("ac_assettypes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? AcAssetTypes { get; set; } 

        [JsonProperty("ac_assetgroups", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? AcAssetGroups { get; set; } 

        [JsonProperty("ac_servicecategories", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? AcServicecategories { get; set; } 

        [JsonProperty("ac_services", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? AcServices { get; set; } 

        [JsonProperty("ac_suppliers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? AcSuppliers { get; set; } 

        [JsonProperty("ac_suppliercontracts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? AcSuppliercontracts { get; set; } 

        [JsonProperty("last_modified", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? LastModified { get; set; } 

        [JsonProperty("jira_instance", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? JiraInstance { get; set; } 

        [JsonProperty("jira_instance_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? JiraInstanceName { get; set; } 

        [JsonProperty("pref_notification_sound", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PrefNotificationSound { get; set; } 

        [JsonProperty("pref_chat_sound", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? PrefChatSound { get; set; } 

        [JsonProperty("default_columns_id_supplier_contracts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultColumnsIdSupplierContracts { get; set; } 

        [JsonProperty("default_view_supplier_contracts_selectedname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultViewSupplierContractsSelectedName { get; set; } 

        [JsonProperty("default_view_assets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultViewAssets { get; set; } 

        [JsonProperty("default_view_assets_selectedid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultViewAssetsSelectedId { get; set; } 

        [JsonProperty("default_view_assets_selectedid_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultViewAssetsSelectedIdName { get; set; } 

        [JsonProperty("matching_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? MatchingValue { get; set; } 

        [JsonProperty("sqlimport_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SqlImportId { get; set; } 

        [JsonProperty("splashtop_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SplashtopUrl { get; set; } 

        [JsonProperty("splashtop_token_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? SplashtopTokenExpiry { get; set; } 

        [JsonProperty("default_splashtop_channelname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultSplashtopChannelname { get; set; } 

        [JsonProperty("splashtop_channel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ValueLabelIsNewKeyPair? SplashtopChannel { get; set; } 

        [JsonProperty("ac_chatprofiles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? AcChatProfiles { get; set; } 

        [JsonProperty("ac_faqlists", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? AcFaqLists { get; set; } 

        [JsonProperty("allow_automatic_call_scripts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowAutomaticCallScripts { get; set; } 

        [JsonProperty("gotoresolve_token_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? GotoresolveTokenExpiry { get; set; } 

        [JsonProperty("ac_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? AcDevices { get; set; } 

        [JsonProperty("azure_connectionid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AzureConnectionId { get; set; } 

        [JsonProperty("allow_presence_notifications", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? AllowPresenceNotifications { get; set; } 

        [JsonProperty("azure_tenant_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AzureTenantId { get; set; } 

        [JsonProperty("azure_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AzureClientId { get; set; } 

        [JsonProperty("presence_subscription", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AgentPresenceSubscription? PresenceSubscription { get; set; } 

        [JsonProperty("default_columns_id_supplier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultColumnsIdSupplier { get; set; } 

        [JsonProperty("default_columns_supplier_selectedname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultColumnsSupplierSelectedName { get; set; } 

        [JsonProperty("default_view_suppliers_selectedid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultViewSuppliersSelectedId { get; set; } 

        [JsonProperty("default_view_suppliers_selectedname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultViewSuppliersSelectedName { get; set; } 

        [JsonProperty("linked_user_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? LinkedUserClientId { get; set; } 

        [JsonProperty("contractdetails_layout_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ContractdetailsLayoutId { get; set; } 

        [JsonProperty("contractdetails_layout_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ContractdetailsLayoutName { get; set; } 

        [JsonProperty("default_action_date_display", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultActionDateDisplay { get; set; } 

        [JsonProperty("signature_image", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SignatureImage { get; set; } 

        [JsonProperty("exclude_from_automatic_assigning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? ExcludeFromAutomaticAssigning { get; set; } 

        [JsonProperty("userdetails_layout_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? UserDetailsLayoutId { get; set; } 

        [JsonProperty("userdetails_layout_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? UserDetailsLayoutName { get; set; } 

        [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Guid { get; set; } 

        [JsonProperty("calendar_options_multi", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? CalendarOptionsMulti { get; set; } 

        [JsonProperty("ac_databaselookups", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? AcDatabaselookups { get; set; } 

        [JsonProperty("default_columns_id_pos", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultColumnsIdPos { get; set; } 

        [JsonProperty("default_view_pos_selectedname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultViewPosSelectedName { get; set; } 

        [JsonProperty("sitedetails_layout_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SitedetailsLayoutId { get; set; } 

        [JsonProperty("sitedetails_layout_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? SitedetailsLayoutName { get; set; } 

        [JsonProperty("enable_teams_shifts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableTeamsShifts { get; set; } 

        [JsonProperty("warnif_incomplete_ts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? WarnifIncompleteTs { get; set; } 

        [JsonProperty("warnif_incomplete_ts_manager", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? WarnifIncompleteTsManager { get; set; } 

        [JsonProperty("incomplete_ts_threshold", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? IncompleteTsThreshold { get; set; } 

        [JsonProperty("incomplete_ts_sendtime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? IncompleteTsSendtime { get; set; } 

        [JsonProperty("incomplete_ts_lastcreated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? IncompleteTsLastcreated { get; set; } 

        [JsonProperty("use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Use { get; set; } 

        [JsonProperty("assetfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AgentField>? AssetFields { get; set; } 

        [JsonProperty("unamecustomfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AgentCustom>? UnameCustomFields { get; set; } 

        [JsonProperty("unameappointmenttypes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AgentAppointment>? Unameappointmenttypes { get; set; } 

        [JsonProperty("_canupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanUpdate { get; set; } 

        [JsonProperty("_canupdate_moreinfo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanUpdateMoreinfo { get; set; } 

        [JsonProperty("logmeinid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Logmeinid { get; set; } 

        [JsonProperty("allowbeyondtrustinvites", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allowbeyondtrustinvites { get; set; } 

        [JsonProperty("jira_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? JiraId { get; set; } 

        [JsonProperty("custombuttons", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AgentButton>? CustomButtons { get; set; } 

        [JsonProperty("namewithinactive", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Namewithinactive { get; set; } 

        [JsonProperty("apptsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Apptsync { get; set; } 

        [JsonProperty("okta_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? OktaId { get; set; } 

        [JsonProperty("enableshifts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enableshifts { get; set; } 

        [JsonProperty("sendemailerrors", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? SendEmailerrors { get; set; } 

        [JsonProperty("uname_usercustomfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AgentCustom>? UnameUserCustomfields { get; set; } 

        [JsonProperty("can_approve_purchaseorder", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanApprovePurchaseOrder { get; set; } 

        [JsonProperty("can_approve_quote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanApproveQuote { get; set; } 

        [JsonProperty("can_approve_invoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? CanApproveInvoice { get; set; } 

        [JsonProperty("default_splashtop_channel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultSplashtopChannel { get; set; } 

        [JsonProperty("workday_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? WorkdayId { get; set; } 

        [JsonProperty("workday_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? WorkdayName { get; set; } 

        [JsonProperty("workday_timezone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? WorkdayTimeZone { get; set; } 

        [JsonProperty("costprice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? CostPrice { get; set; } 

        [JsonProperty("chargerate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ChargeRate { get; set; } 

        [JsonProperty("first_role_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? FirstRoleId { get; set; } 

        [JsonProperty("in_queried_team", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? InQueriedTeam { get; set; } 

        [JsonProperty("guid_string", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? GuidString { get; set; } 

    }