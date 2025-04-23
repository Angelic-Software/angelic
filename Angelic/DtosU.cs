using System.CodeDom.Compiler;
using Angelic.Dtos;
using Angelic.KeyPairs;
using Newtonsoft.Json;

namespace Angelic;


    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class Uname
    {
        [JsonProperty("sites", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<UnameSite>? Sites { get; set; } 

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("onlinestatus_actual", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Onlinestatus_actual { get; set; } 

        [JsonProperty("onlinestatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Onlinestatus { get; set; } 

        [JsonProperty("is_online", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_online { get; set; } 

        [JsonProperty("lastonline", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Lastonline { get; set; } 

        [JsonProperty("team", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Team { get; set; } 

        [JsonProperty("isdisabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isdisabled { get; set; } 

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
        public string? Firstname { get; set; } 

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
        public int? Ticket_count { get; set; } 

        [JsonProperty("is_agent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_agent { get; set; } 

        [JsonProperty("one_client", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? One_client { get; set; } 

        [JsonProperty("teams", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<UnameSection>? Teams { get; set; } 

        [JsonProperty("departments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<UnameDepartment>? Departments { get; set; } 

        [JsonProperty("clients", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<UnameAreaRestriction>? Clients { get; set; } 

        [JsonProperty("tickettypes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<UnameRequestType>? Tickettypes { get; set; } 

        [JsonProperty("qualifications", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<UnameQualification>? Qualifications { get; set; } 

        [JsonProperty("qualification_weighting", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Qualification_weighting { get; set; } 

        [JsonProperty("qualified", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Qualified { get; set; } 

        [JsonProperty("role_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Role_list { get; set; } 

        [JsonProperty("current_action_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Current_action_type { get; set; } 

        [JsonProperty("current_action_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Current_action_name { get; set; } 

        [JsonProperty("assettypes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<UnameXtype>? Assettypes { get; set; } 

        [JsonProperty("googleemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Googleemail { get; set; } 

        [JsonProperty("linemanager", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Linemanager { get; set; } 

        [JsonProperty("linemanager_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Linemanager_name { get; set; } 

        [JsonProperty("inboxes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Inboxes { get; set; } 

        [JsonProperty("exchange_authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Exchange_authorized { get; set; } 

        [JsonProperty("exchange_account", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Exchange_account { get; set; } 

        [JsonProperty("sentinel_authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sentinel_authorized { get; set; } 

        [JsonProperty("licence_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Licence_type { get; set; } 

        [JsonProperty("named_licences_in_use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Named_licences_in_use { get; set; } 

        [JsonProperty("concurrent_licences_in_use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Concurrent_licences_in_use { get; set; } 

        [JsonProperty("concurrent_agent_total", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Concurrent_agent_total { get; set; } 

        [JsonProperty("google_mail_authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Google_mail_authorized { get; set; } 

        [JsonProperty("inbox_clientid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Inbox_clientid { get; set; } 

        [JsonProperty("isapiagent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isapiagent { get; set; } 

        [JsonProperty("splashtop_authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Splashtop_authorized { get; set; } 

        [JsonProperty("gotoresolve_authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Gotoresolve_authorized { get; set; } 

        [JsonProperty("datecreated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Datecreated { get; set; } 

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
        public int? Default_filter_id_tickets { get; set; } 

        [JsonProperty("default_filter_name_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_filter_name_tickets { get; set; } 

        [JsonProperty("default_columns_id_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_columns_id_tickets { get; set; } 

        [JsonProperty("default_columns_name_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_columns_name_tickets { get; set; } 

        [JsonProperty("default_view_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_view_tickets { get; set; } 

        [JsonProperty("default_view_tickets_selectedid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_view_tickets_selectedid { get; set; } 

        [JsonProperty("default_view_tickets_selectedname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_view_tickets_selectedname { get; set; } 

        [JsonProperty("default_filter_id_opps", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_filter_id_opps { get; set; } 

        [JsonProperty("default_filter_name_opps", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_filter_name_opps { get; set; } 

        [JsonProperty("default_columns_id_opps", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_columns_id_opps { get; set; } 

        [JsonProperty("default_columns_name_opps", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_columns_name_opps { get; set; } 

        [JsonProperty("default_view_opps", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_view_opps { get; set; } 

        [JsonProperty("default_view_opps_selectedid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_view_opps_selectedid { get; set; } 

        [JsonProperty("default_view_opps_selectedname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_view_opps_selectedname { get; set; } 

        [JsonProperty("default_action_view", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_action_view { get; set; } 

        [JsonProperty("default_action_display", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_action_display { get; set; } 

        [JsonProperty("default_feed_view", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_feed_view { get; set; } 

        [JsonProperty("ticket_preview_mode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ticket_preview_mode { get; set; } 

        [JsonProperty("default_ticket_preview_size", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_ticket_preview_size { get; set; } 

        [JsonProperty("list_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? List_type { get; set; } 

        [JsonProperty("navmenu_mode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Navmenu_mode { get; set; } 

        [JsonProperty("default_calendar_view", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_calendar_view { get; set; } 

        [JsonProperty("calendar_options", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Calendar_options { get; set; } 

        [JsonProperty("search_options", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Search_options { get; set; } 

        [JsonProperty("newtabpref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Newtabpref { get; set; } 

        [JsonProperty("theme", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Theme { get; set; } 

        [JsonProperty("theme_revert", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Theme_revert { get; set; } 

        [JsonProperty("language_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Language_id { get; set; } 

        [JsonProperty("language_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Language_name { get; set; } 

        [JsonProperty("app_colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? App_colour { get; set; } 

        [JsonProperty("app_colour_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? App_colour_type { get; set; } 

        [JsonProperty("nav_display_mode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Nav_display_mode { get; set; } 

        [JsonProperty("enablehighcontrast", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enablehighcontrast { get; set; } 

        [JsonProperty("actionscreen_display_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Actionscreen_display_type { get; set; } 

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
        public int? Clientdetails_layout_id { get; set; } 

        [JsonProperty("clientdetails_layout_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Clientdetails_layout_name { get; set; } 

        [JsonProperty("nav_layout_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Nav_layout_id { get; set; } 

        [JsonProperty("nav_layout_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Nav_layout_name { get; set; } 

        [JsonProperty("sendowneremails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sendowneremails { get; set; } 

        [JsonProperty("warnifnoscan", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Warnifnoscan { get; set; } 

        [JsonProperty("dontemailmeifiloggedit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dontemailmeifiloggedit { get; set; } 

        [JsonProperty("workhour_start", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Workhour_start { get; set; } 

        [JsonProperty("workhour_end", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Workhour_end { get; set; } 

        [JsonProperty("activedirectory_dn", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Activedirectory_dn { get; set; } 

        [JsonProperty("third_party_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Third_party_guid { get; set; } 

        [JsonProperty("roles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<NHD_Roles>? Roles { get; set; } 

        [JsonProperty("add_roles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<NHD_Roles>? Add_roles { get; set; } 

        [JsonProperty("claims", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<NHD_Claim>? Claims { get; set; } 

        [JsonProperty("department", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Department { get; set; } 

        [JsonProperty("_is_a_departmentmanager", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _is_a_departmentmanager { get; set; } 

        [JsonProperty("_is_a_teammanager", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _is_a_teammanager { get; set; } 

        [JsonProperty("access_control", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? Access_control { get; set; } 

        [JsonProperty("twofactor_enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Twofactor_enabled { get; set; } 

        [JsonProperty("_isnew", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _isnew { get; set; } 

        [JsonProperty("adconnection", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Adconnection { get; set; } 

        [JsonProperty("useadlogin", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Useadlogin { get; set; } 

        [JsonProperty("container_dn", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Container_dn { get; set; } 

        [JsonProperty("notifications", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<UnameNotification>? Notifications { get; set; } 

        [JsonProperty("notifications_personal", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<UnameNotification>? Notifications_personal { get; set; } 

        [JsonProperty("emailconfirmed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Emailconfirmed { get; set; } 

        [JsonProperty("accountconfirmed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Accountconfirmed { get; set; } 

        [JsonProperty("isinvite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isinvite { get; set; } 

        [JsonProperty("is_sales", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_sales { get; set; } 

        [JsonProperty("_getlogmeinid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _getlogmeinid { get; set; } 

        [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _isimport { get; set; } 

        [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _importtype { get; set; } 

        [JsonProperty("_importtoken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _importtoken { get; set; } 

        [JsonProperty("beyondtrust_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Beyondtrust_name { get; set; } 

        [JsonProperty("azure_roleid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Azure_roleid { get; set; } 

        [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CustomField>? Customfields { get; set; } 

        [JsonProperty("chargerates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Restriction>? Chargerates { get; set; } 

        [JsonProperty("warnifnoscan_integrator", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Warnifnoscan_integrator { get; set; } 

        [JsonProperty("warnifnoscan_integrator_hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Warnifnoscan_integrator_hours { get; set; } 

        [JsonProperty("orion_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Orion_username { get; set; } 

        [JsonProperty("orion_password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Orion_password { get; set; } 

        [JsonProperty("ncentral_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Ncentral_username { get; set; } 

        [JsonProperty("soc_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Soc_username { get; set; } 

        [JsonProperty("autotaskid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Autotaskid { get; set; } 

        [JsonProperty("oktaid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Oktaid { get; set; } 

        [JsonProperty("okta_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Okta_status { get; set; } 

        [JsonProperty("new_ncentral_key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_ncentral_key { get; set; } 

        [JsonProperty("pomincostforapprovaltype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Pomincostforapprovaltype { get; set; } 

        [JsonProperty("pomincostforapproval", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Pomincostforapproval { get; set; } 

        [JsonProperty("quotemarginforapprovaltype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Quotemarginforapprovaltype { get; set; } 

        [JsonProperty("quotemarginforapproval", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Quotemarginforapproval { get; set; } 

        [JsonProperty("new_orion_password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_orion_password { get; set; } 

        [JsonProperty("orion_access", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Orion_access { get; set; } 

        [JsonProperty("new_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? New_method { get; set; } 

        [JsonProperty("exchange_token_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Exchange_token_expiry { get; set; } 

        [JsonProperty("exchange_redirect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Exchange_redirect { get; set; } 

        [JsonProperty("_getoauthtoken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _getoauthtoken { get; set; } 

        [JsonProperty("oauth_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Oauth_code { get; set; } 

        [JsonProperty("oauth_redirect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Oauth_redirect { get; set; } 

        [JsonProperty("oauth_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Oauth_type { get; set; } 

        [JsonProperty("new_access_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_access_token { get; set; } 

        [JsonProperty("new_token_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_token_type { get; set; } 

        [JsonProperty("new_refresh_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_refresh_token { get; set; } 

        [JsonProperty("_disconnectintegration", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _disconnectintegration { get; set; } 

        [JsonProperty("sentinel_token_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Sentinel_token_expiry { get; set; } 

        [JsonProperty("sentinel_redirect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sentinel_redirect { get; set; } 

        [JsonProperty("default_columns_id_assets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_columns_id_assets { get; set; } 

        [JsonProperty("Oo_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Oo_name { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("isagentdetails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isagentdetails { get; set; } 

        [JsonProperty("excludefromresourcebooking", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Excludefromresourcebooking { get; set; } 

        [JsonProperty("delegation_activated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Delegation_activated { get; set; } 

        [JsonProperty("delegation_timebased", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Delegation_timebased { get; set; } 

        [JsonProperty("delegation_start", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Delegation_start { get; set; } 

        [JsonProperty("delegation_end", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Delegation_end { get; set; } 

        [JsonProperty("delegation_user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Delegation_user_id { get; set; } 

        [JsonProperty("delegation_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Delegation_user_name { get; set; } 

        [JsonProperty("_reassign_all_accounts_to_agent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? _reassign_all_accounts_to_agent { get; set; } 

        [JsonProperty("_kick", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _kick { get; set; } 

        [JsonProperty("_revoke_tokens", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _revoke_tokens { get; set; } 

        [JsonProperty("authenticatorapp_configured", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Authenticatorapp_configured { get; set; } 

        [JsonProperty("_revoke_authenticatorapp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _revoke_authenticatorapp { get; set; } 

        [JsonProperty("ispasswordreset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ispasswordreset { get; set; } 

        [JsonProperty("graph_host", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Graph_host { get; set; } 

        [JsonProperty("linked_halo_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Linked_halo_url { get; set; } 

        [JsonProperty("holiday_allowance", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Holiday_allowance { get; set; } 

        [JsonProperty("remaining_holiday_allowance", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Remaining_holiday_allowance { get; set; } 

        [JsonProperty("_isbatch", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _isbatch { get; set; } 

        [JsonProperty("import_photo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Import_photo { get; set; } 

        [JsonProperty("travelrate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Travelrate { get; set; } 

        [JsonProperty("github_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Github_username { get; set; } 

        [JsonProperty("_signature_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _signature_id { get; set; } 

        [JsonProperty("_signature", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _signature { get; set; } 

        [JsonProperty("is_admin", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_admin { get; set; } 

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

        [JsonProperty("default_columns_id_clients", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_columns_id_clients { get; set; } 

        [JsonProperty("default_view_clients_selectedname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_view_clients_selectedname { get; set; } 

        [JsonProperty("default_view_assets_selectedname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_view_assets_selectedname { get; set; } 

        [JsonProperty("_do_reassign01", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _do_reassign01 { get; set; } 

        [JsonProperty("check_reassign01", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Check_reassign01 { get; set; } 

        [JsonProperty("_force", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _force { get; set; } 

        [JsonProperty("default_view_customers_selectedid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_view_customers_selectedid { get; set; } 

        [JsonProperty("default_view_customers_selectedname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_view_customers_selectedname { get; set; } 

        [JsonProperty("default_view_users_selectedid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_view_users_selectedid { get; set; } 

        [JsonProperty("default_view_users_selectedname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_view_users_selectedname { get; set; } 

        [JsonProperty("default_columns_id_contracts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_columns_id_contracts { get; set; } 

        [JsonProperty("default_view_contracts_selectedname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_view_contracts_selectedname { get; set; } 

        [JsonProperty("default_columns_id_sites", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_columns_id_sites { get; set; } 

        [JsonProperty("default_columns_sites_selectedname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_columns_sites_selectedname { get; set; } 

        [JsonProperty("default_columns_id_users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_columns_id_users { get; set; } 

        [JsonProperty("default_columns_users_selectedname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_columns_users_selectedname { get; set; } 

        [JsonProperty("pagerduty_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Pagerduty_email { get; set; } 

        [JsonProperty("ac_assettypes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? Ac_assettypes { get; set; } 

        [JsonProperty("ac_assetgroups", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? Ac_assetgroups { get; set; } 

        [JsonProperty("ac_servicecategories", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? Ac_servicecategories { get; set; } 

        [JsonProperty("ac_services", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? Ac_services { get; set; } 

        [JsonProperty("ac_suppliers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? Ac_suppliers { get; set; } 

        [JsonProperty("ac_suppliercontracts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? Ac_suppliercontracts { get; set; } 

        [JsonProperty("last_modified", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Last_modified { get; set; } 

        [JsonProperty("jira_instance", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Jira_instance { get; set; } 

        [JsonProperty("jira_instance_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Jira_instance_name { get; set; } 

        [JsonProperty("pref_notification_sound", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Pref_notification_sound { get; set; } 

        [JsonProperty("pref_chat_sound", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Pref_chat_sound { get; set; } 

        [JsonProperty("default_columns_id_supplier_contracts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_columns_id_supplier_contracts { get; set; } 

        [JsonProperty("default_view_supplier_contracts_selectedname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_view_supplier_contracts_selectedname { get; set; } 

        [JsonProperty("default_view_assets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_view_assets { get; set; } 

        [JsonProperty("default_view_assets_selectedid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_view_assets_selectedid { get; set; } 

        [JsonProperty("default_view_assets_selectedid_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_view_assets_selectedid_name { get; set; } 

        [JsonProperty("matching_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Matching_value { get; set; } 

        [JsonProperty("sqlimport_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sqlimport_id { get; set; } 

        [JsonProperty("splashtop_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Splashtop_url { get; set; } 

        [JsonProperty("splashtop_token_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Splashtop_token_expiry { get; set; } 

        [JsonProperty("default_splashtop_channelname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_splashtop_channelname { get; set; } 

        [JsonProperty("splashtop_channel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ValueLabelIsNewKeyPair? Splashtop_channel { get; set; } 

        [JsonProperty("ac_chatprofiles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? Ac_chatprofiles { get; set; } 

        [JsonProperty("ac_faqlists", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? Ac_faqlists { get; set; } 

        [JsonProperty("allow_automatic_call_scripts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allow_automatic_call_scripts { get; set; } 

        [JsonProperty("gotoresolve_token_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Gotoresolve_token_expiry { get; set; } 

        [JsonProperty("ac_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? Ac_devices { get; set; } 

        [JsonProperty("azure_connectionid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Azure_connectionid { get; set; } 

        [JsonProperty("allow_presence_notifications", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allow_presence_notifications { get; set; } 

        [JsonProperty("azure_tenant_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Azure_tenant_id { get; set; } 

        [JsonProperty("azure_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Azure_client_id { get; set; } 

        [JsonProperty("presence_subscription", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public UnamePresenceSubscription? Presence_subscription { get; set; } 

        [JsonProperty("default_columns_id_supplier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_columns_id_supplier { get; set; } 

        [JsonProperty("default_columns_supplier_selectedname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_columns_supplier_selectedname { get; set; } 

        [JsonProperty("default_view_suppliers_selectedid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_view_suppliers_selectedid { get; set; } 

        [JsonProperty("default_view_suppliers_selectedname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_view_suppliers_selectedname { get; set; } 

        [JsonProperty("linked_user_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Linked_user_client_id { get; set; } 

        [JsonProperty("contractdetails_layout_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Contractdetails_layout_id { get; set; } 

        [JsonProperty("contractdetails_layout_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Contractdetails_layout_name { get; set; } 

        [JsonProperty("default_action_date_display", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_action_date_display { get; set; } 

        [JsonProperty("signature_image", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Signature_image { get; set; } 

        [JsonProperty("exclude_from_automatic_assigning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Exclude_from_automatic_assigning { get; set; } 

        [JsonProperty("userdetails_layout_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Userdetails_layout_id { get; set; } 

        [JsonProperty("userdetails_layout_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Userdetails_layout_name { get; set; } 

        [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Guid { get; set; } 

        [JsonProperty("calendar_options_multi", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? Calendar_options_multi { get; set; } 

        [JsonProperty("ac_databaselookups", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AccessControl>? Ac_databaselookups { get; set; } 

        [JsonProperty("default_columns_id_pos", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_columns_id_pos { get; set; } 

        [JsonProperty("default_view_pos_selectedname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Default_view_pos_selectedname { get; set; } 

        [JsonProperty("sitedetails_layout_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sitedetails_layout_id { get; set; } 

        [JsonProperty("sitedetails_layout_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sitedetails_layout_name { get; set; } 

        [JsonProperty("enable_teams_shifts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enable_teams_shifts { get; set; } 

        [JsonProperty("warnif_incomplete_ts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Warnif_incomplete_ts { get; set; } 

        [JsonProperty("warnif_incomplete_ts_manager", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Warnif_incomplete_ts_manager { get; set; } 

        [JsonProperty("incomplete_ts_threshold", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Incomplete_ts_threshold { get; set; } 

        [JsonProperty("incomplete_ts_sendtime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Incomplete_ts_sendtime { get; set; } 

        [JsonProperty("incomplete_ts_lastcreated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Incomplete_ts_lastcreated { get; set; } 

        [JsonProperty("use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Use { get; set; } 

        [JsonProperty("assetfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<UnameField>? Assetfields { get; set; } 

        [JsonProperty("unamecustomfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<UnameCustom>? Unamecustomfields { get; set; } 

        [JsonProperty("unameappointmenttypes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<UnameAppointment>? Unameappointmenttypes { get; set; } 

        [JsonProperty("_canupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _canupdate { get; set; } 

        [JsonProperty("_canupdate_moreinfo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _canupdate_moreinfo { get; set; } 

        [JsonProperty("logmeinid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Logmeinid { get; set; } 

        [JsonProperty("allowbeyondtrustinvites", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allowbeyondtrustinvites { get; set; } 

        [JsonProperty("jira_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Jira_id { get; set; } 

        [JsonProperty("custombuttons", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<UnameButton>? Custombuttons { get; set; } 

        [JsonProperty("namewithinactive", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Namewithinactive { get; set; } 

        [JsonProperty("apptsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Apptsync { get; set; } 

        [JsonProperty("okta_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Okta_id { get; set; } 

        [JsonProperty("enableshifts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enableshifts { get; set; } 

        [JsonProperty("sendemailerrors", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sendemailerrors { get; set; } 

        [JsonProperty("uname_usercustomfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<UnameCustom>? Uname_usercustomfields { get; set; } 

        [JsonProperty("can_approve_purchaseorder", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Can_approve_purchaseorder { get; set; } 

        [JsonProperty("can_approve_quote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Can_approve_quote { get; set; } 

        [JsonProperty("can_approve_invoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Can_approve_invoice { get; set; } 

        [JsonProperty("default_splashtop_channel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_splashtop_channel { get; set; } 

        [JsonProperty("workday_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Workday_id { get; set; } 

        [JsonProperty("workday_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Workday_name { get; set; } 

        [JsonProperty("workday_timezone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Workday_timezone { get; set; } 

        [JsonProperty("costprice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Costprice { get; set; } 

        [JsonProperty("chargerate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Chargerate { get; set; } 

        [JsonProperty("first_role_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? First_role_id { get; set; } 

        [JsonProperty("in_queried_team", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? In_queried_team { get; set; } 

        [JsonProperty("guid_string", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Guid_string { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class UnameAnalyzer
    {
        [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Agent_id { get; set; } 

        [JsonProperty("agent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Agent_name { get; set; } 

        [JsonProperty("report_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Report_id { get; set; } 

        [JsonProperty("readonly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Readonly { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class UnameAppointment
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Agent_id { get; set; } 

        [JsonProperty("agent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Agent_name { get; set; } 

        [JsonProperty("field_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Field_id { get; set; } 

        [JsonProperty("field_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Field_name { get; set; } 

        [JsonProperty("role_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Role_id { get; set; } 

        [JsonProperty("role_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Role_name { get; set; } 

        [JsonProperty("field_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Field_type { get; set; } 

        [JsonProperty("level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Level { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class UnameAreaRestriction
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Agent_id { get; set; } 

        [JsonProperty("agent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Agent_name { get; set; } 

        [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Client_id { get; set; } 

        [JsonProperty("client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Client_name { get; set; } 

        [JsonProperty("role_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Role_id { get; set; } 

        [JsonProperty("role_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Role_name { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class UnameButton
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Agent_id { get; set; } 

        [JsonProperty("agent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Agent_name { get; set; } 

        [JsonProperty("roleid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Roleid { get; set; } 

        [JsonProperty("role_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Role_name { get; set; } 

        [JsonProperty("button_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Button_id { get; set; } 

        [JsonProperty("button_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Button_name { get; set; } 

        [JsonProperty("can_access", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Can_access { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class UnameCustom
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Agent_id { get; set; } 

        [JsonProperty("agent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Agent_name { get; set; } 

        [JsonProperty("field_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Field_id { get; set; } 

        [JsonProperty("field_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Field_name { get; set; } 

        [JsonProperty("role_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Role_id { get; set; } 

        [JsonProperty("role_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Role_name { get; set; } 

        [JsonProperty("field_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Field_type { get; set; } 

        [JsonProperty("level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Level { get; set; } 

        [JsonProperty("canadd", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Canadd { get; set; } 

        [JsonProperty("candelete", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Candelete { get; set; } 

        [JsonProperty("canedit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Canedit { get; set; } 

        [JsonProperty("customfield_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Customfield_type { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class UnameDepartment
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Agent_id { get; set; } 

        [JsonProperty("agent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Agent_name { get; set; } 

        [JsonProperty("department_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Department_id { get; set; } 

        [JsonProperty("department_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Department_guid { get; set; } 

        [JsonProperty("department_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Department_name { get; set; } 

        [JsonProperty("role_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Role_id { get; set; } 

        [JsonProperty("role_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Role_name { get; set; } 

        [JsonProperty("membershiplevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Membershiplevel { get; set; } 

        [JsonProperty("includeteamsintree", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Includeteamsintree { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class UnameEventSubscription
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Agent_id { get; set; } 

        [JsonProperty("azure_identifier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Azure_identifier { get; set; } 

        [JsonProperty("_subscriptionaction", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public WebhookSubscriptionAction? _subscriptionaction { get; set; } 

        [JsonProperty("subscription_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Subscription_id { get; set; } 

        [JsonProperty("subscription_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Subscription_expiry { get; set; } 

        [JsonProperty("subscribed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Subscribed { get; set; } 

        [JsonProperty("new_subscription_key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_subscription_key { get; set; } 

        [JsonProperty("_dosave", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _dosave { get; set; } 

        [JsonProperty("agent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Agent_name { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class UnameField
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Agent_id { get; set; } 

        [JsonProperty("agent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Agent_name { get; set; } 

        [JsonProperty("field_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Field_id { get; set; } 

        [JsonProperty("field_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Field_name { get; set; } 

        [JsonProperty("role_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Role_id { get; set; } 

        [JsonProperty("role_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Role_name { get; set; } 

        [JsonProperty("field_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Field_type { get; set; } 

        [JsonProperty("level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Level { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class UnameNotification
    {
        [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Guid { get; set; } 

        [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intent { get; set; } 

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Agent_id { get; set; } 

        [JsonProperty("agent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Agent_name { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Type { get; set; } 

        [JsonProperty("delivery_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Delivery_method { get; set; } 

        [JsonProperty("sendpushnotification", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sendpushnotification { get; set; } 

        [JsonProperty("sendpushnotificationbrowser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sendpushnotificationbrowser { get; set; } 

        [JsonProperty("popupinnotificationpane", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Popupinnotificationpane { get; set; } 

        [JsonProperty("eventno", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Eventno { get; set; } 

        [JsonProperty("emailtemplate_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Emailtemplate_id { get; set; } 

        [JsonProperty("emailtemplate_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Emailtemplate_guid { get; set; } 

        [JsonProperty("emailtemplate_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Emailtemplate_name { get; set; } 

        [JsonProperty("user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? User_id { get; set; } 

        [JsonProperty("user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? User_name { get; set; } 

        [JsonProperty("email_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Email_list { get; set; } 

        [JsonProperty("slack_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Slack_id { get; set; } 

        [JsonProperty("interval", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Interval { get; set; } 

        [JsonProperty("useworkinghours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Useworkinghours { get; set; } 

        [JsonProperty("restriction_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Restriction_type { get; set; } 

        [JsonProperty("restriction_department_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Restriction_department_id { get; set; } 

        [JsonProperty("restriction_department_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Restriction_department_guid { get; set; } 

        [JsonProperty("restriction_department_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Restriction_department_name { get; set; } 

        [JsonProperty("restriction_team_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Restriction_team_id { get; set; } 

        [JsonProperty("restriction_team_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Restriction_team_guid { get; set; } 

        [JsonProperty("restriction_team_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Restriction_team_name { get; set; } 

        [JsonProperty("webhook_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Webhook_id { get; set; } 

        [JsonProperty("agents", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<UnameNotificationLink>? Agents { get; set; } 

        [JsonProperty("condition_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Condition_count { get; set; } 

        [JsonProperty("subscriber_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Subscriber_count { get; set; } 

        [JsonProperty("role_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Role_id { get; set; } 

        [JsonProperty("role_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Role_name { get; set; } 

        [JsonProperty("conditions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<NotificationConditions>? Conditions { get; set; } 

        [JsonProperty("_canupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _canupdate { get; set; } 

        [JsonProperty("slack_channel_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Slack_channel_name { get; set; } 

        [JsonProperty("teams_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Teams_id { get; set; } 

        [JsonProperty("teams_channel_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Teams_channel_name { get; set; } 

        [JsonProperty("value1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Value1 { get; set; } 

        [JsonProperty("value1_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Value1_name { get; set; } 

        [JsonProperty("_iszapier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _iszapier { get; set; } 

        [JsonProperty("filter_sitecontact", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Filter_sitecontact { get; set; } 

        [JsonProperty("sitecontact_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sitecontact_type { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("roles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<UnameNotificationLink>? Roles { get; set; } 

        [JsonProperty("mattermost_channelid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Mattermost_channelid { get; set; } 

        [JsonProperty("mattermost_channel_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Mattermost_channel_name { get; set; } 

        [JsonProperty("rule_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Rule_id { get; set; } 

        [JsonProperty("rule_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Rule_name { get; set; } 

        [JsonProperty("user_roles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<UnameNotificationLink>? User_roles { get; set; } 

        [JsonProperty("filter_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Filter_type { get; set; } 

        [JsonProperty("customisecolour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Customisecolour { get; set; } 

        [JsonProperty("colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Colour { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class UnameNotificationLink
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Agent_id { get; set; } 

        [JsonProperty("agent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Agent_name { get; set; } 

        [JsonProperty("notification_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Notification_id { get; set; } 

        [JsonProperty("notification_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Notification_guid { get; set; } 

        [JsonProperty("notification_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Notification_name { get; set; } 

        [JsonProperty("role_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Role_id { get; set; } 

        [JsonProperty("role_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Role_name { get; set; } 

        [JsonProperty("user_role_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? User_role_id { get; set; } 

        [JsonProperty("user_role_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? User_role_name { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class UnamePresenceRule
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("seq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Seq { get; set; } 

        [JsonProperty("activity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Activity { get; set; } 

        [JsonProperty("availability", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Availability { get; set; } 

        [JsonProperty("outcome", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Outcome { get; set; } 

        [JsonProperty("must_be_online", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Must_be_online { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class UnamePresenceSubscription
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Agent_id { get; set; } 

        [JsonProperty("azure_connection_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Azure_connection_id { get; set; } 

        [JsonProperty("azure_oid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Azure_oid { get; set; } 

        [JsonProperty("azure_upn", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Azure_upn { get; set; } 

        [JsonProperty("new_access_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_access_token { get; set; } 

        [JsonProperty("new_refresh_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_refresh_token { get; set; } 

        [JsonProperty("token_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Token_expiry { get; set; } 

        [JsonProperty("redirect_uri", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Redirect_uri { get; set; } 

        [JsonProperty("_subscriptionaction", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public WebhookSubscriptionAction? _subscriptionaction { get; set; } 

        [JsonProperty("subscription_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Subscription_id { get; set; } 

        [JsonProperty("subscription_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Subscription_expiry { get; set; } 

        [JsonProperty("subscribed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Subscribed { get; set; } 

        [JsonProperty("new_subscription_key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_subscription_key { get; set; } 

        [JsonProperty("oauth_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Oauth_code { get; set; } 

        [JsonProperty("graph_host", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Graph_host { get; set; } 

        [JsonProperty("azure_connection", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AzureADConnection? Azure_connection { get; set; } 

        [JsonProperty("_dosave", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _dosave { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class UnameQualification
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Agent_id { get; set; } 

        [JsonProperty("agent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Agent_name { get; set; } 

        [JsonProperty("qualification_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Qualification_id { get; set; } 

        [JsonProperty("qualification_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Qualification_name { get; set; } 

        [JsonProperty("role_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Role_id { get; set; } 

        [JsonProperty("role_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Role_name { get; set; } 

        [JsonProperty("date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Date { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("enddate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Enddate { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class UnameRequestType
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Agent_id { get; set; } 

        [JsonProperty("agent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Agent_name { get; set; } 

        [JsonProperty("tickettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Tickettype_id { get; set; } 

        [JsonProperty("tickettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Tickettype_name { get; set; } 

        [JsonProperty("role_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Role_id { get; set; } 

        [JsonProperty("role_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Role_name { get; set; } 

        [JsonProperty("cancreate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Cancreate { get; set; } 

        [JsonProperty("canview", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Canview { get; set; } 

        [JsonProperty("canedit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Canedit { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class UnameSection
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Agent_id { get; set; } 

        [JsonProperty("agent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Agent_name { get; set; } 

        [JsonProperty("team_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Team_id { get; set; } 

        [JsonProperty("team_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Team_guid { get; set; } 

        [JsonProperty("team_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Team_name { get; set; } 

        [JsonProperty("department_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Department_id { get; set; } 

        [JsonProperty("org_department_team_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Org_department_team_name { get; set; } 

        [JsonProperty("role_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Role_id { get; set; } 

        [JsonProperty("role_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Role_name { get; set; } 

        [JsonProperty("is_manager", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_manager { get; set; } 

        [JsonProperty("no_config_access", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? No_config_access { get; set; } 

        [JsonProperty("unassigned_access", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Unassigned_access { get; set; } 

        [JsonProperty("otheragent_access", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Otheragent_access { get; set; } 

        [JsonProperty("fortickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Fortickets { get; set; } 

        [JsonProperty("foropps", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Foropps { get; set; } 

        [JsonProperty("forprojects", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Forprojects { get; set; } 

        [JsonProperty("in_section", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? In_section { get; set; } 

        [JsonProperty("namewithinactive", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Namewithinactive { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class UnameSite
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Agent_id { get; set; } 

        [JsonProperty("agent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Agent_name { get; set; } 

        [JsonProperty("role_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Role_id { get; set; } 

        [JsonProperty("role_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Role_name { get; set; } 

        [JsonProperty("site_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Site_id { get; set; } 

        [JsonProperty("site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Site_name { get; set; } 

        [JsonProperty("level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Level { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class UnameXtype
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Agent_id { get; set; } 

        [JsonProperty("agent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Agent_name { get; set; } 

        [JsonProperty("assettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Assettype_id { get; set; } 

        [JsonProperty("assettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Assettype_name { get; set; } 

        [JsonProperty("role_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Role_id { get; set; } 

        [JsonProperty("role_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Role_name { get; set; } 

        [JsonProperty("cancreate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Cancreate { get; set; } 

        [JsonProperty("canview", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Canview { get; set; } 

        [JsonProperty("canedit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Canedit { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class Uname_List
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("onlinestatus_actual", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Onlinestatus_actual { get; set; } 

        [JsonProperty("onlinestatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Onlinestatus { get; set; } 

        [JsonProperty("is_online", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_online { get; set; } 

        [JsonProperty("lastonline", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Lastonline { get; set; } 

        [JsonProperty("team", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Team { get; set; } 

        [JsonProperty("isdisabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isdisabled { get; set; } 

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
        public string? Firstname { get; set; } 

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
        public int? Ticket_count { get; set; } 

        [JsonProperty("is_agent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_agent { get; set; } 

        [JsonProperty("one_client", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? One_client { get; set; } 

        [JsonProperty("teams", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<UnameSection>? Teams { get; set; } 

        [JsonProperty("departments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<UnameDepartment>? Departments { get; set; } 

        [JsonProperty("clients", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<UnameAreaRestriction>? Clients { get; set; } 

        [JsonProperty("tickettypes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<UnameRequestType>? Tickettypes { get; set; } 

        [JsonProperty("qualifications", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<UnameQualification>? Qualifications { get; set; } 

        [JsonProperty("qualification_weighting", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Qualification_weighting { get; set; } 

        [JsonProperty("qualified", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Qualified { get; set; } 

        [JsonProperty("role_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Role_list { get; set; } 

        [JsonProperty("current_action_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Current_action_type { get; set; } 

        [JsonProperty("current_action_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Current_action_name { get; set; } 

        [JsonProperty("assettypes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<UnameXtype>? Assettypes { get; set; } 

        [JsonProperty("googleemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Googleemail { get; set; } 

        [JsonProperty("linemanager", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Linemanager { get; set; } 

        [JsonProperty("linemanager_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Linemanager_name { get; set; } 

        [JsonProperty("inboxes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Inboxes { get; set; } 

        [JsonProperty("exchange_authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Exchange_authorized { get; set; } 

        [JsonProperty("exchange_account", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Exchange_account { get; set; } 

        [JsonProperty("sentinel_authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sentinel_authorized { get; set; } 

        [JsonProperty("licence_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Licence_type { get; set; } 

        [JsonProperty("named_licences_in_use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Named_licences_in_use { get; set; } 

        [JsonProperty("concurrent_licences_in_use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Concurrent_licences_in_use { get; set; } 

        [JsonProperty("concurrent_agent_total", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Concurrent_agent_total { get; set; } 

        [JsonProperty("google_mail_authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Google_mail_authorized { get; set; } 

        [JsonProperty("inbox_clientid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Inbox_clientid { get; set; } 

        [JsonProperty("isapiagent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isapiagent { get; set; } 

        [JsonProperty("splashtop_authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Splashtop_authorized { get; set; } 

        [JsonProperty("gotoresolve_authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Gotoresolve_authorized { get; set; } 

        [JsonProperty("use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Use { get; set; } 

        [JsonProperty("assetfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<UnameField>? Assetfields { get; set; } 

        [JsonProperty("unamecustomfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<UnameCustom>? Unamecustomfields { get; set; } 

        [JsonProperty("unameappointmenttypes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<UnameAppointment>? Unameappointmenttypes { get; set; } 

        [JsonProperty("_canupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _canupdate { get; set; } 

        [JsonProperty("_canupdate_moreinfo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _canupdate_moreinfo { get; set; } 

        [JsonProperty("logmeinid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Logmeinid { get; set; } 

        [JsonProperty("allowbeyondtrustinvites", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allowbeyondtrustinvites { get; set; } 

        [JsonProperty("jira_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Jira_id { get; set; } 

        [JsonProperty("custombuttons", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<UnameButton>? Custombuttons { get; set; } 

        [JsonProperty("namewithinactive", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Namewithinactive { get; set; } 

        [JsonProperty("apptsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Apptsync { get; set; } 

        [JsonProperty("okta_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Okta_id { get; set; } 

        [JsonProperty("enableshifts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Enableshifts { get; set; } 

        [JsonProperty("sendemailerrors", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sendemailerrors { get; set; } 

        [JsonProperty("uname_usercustomfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<UnameCustom>? Uname_usercustomfields { get; set; } 

        [JsonProperty("can_approve_purchaseorder", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Can_approve_purchaseorder { get; set; } 

        [JsonProperty("can_approve_quote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Can_approve_quote { get; set; } 

        [JsonProperty("can_approve_invoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Can_approve_invoice { get; set; } 

        [JsonProperty("default_splashtop_channel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_splashtop_channel { get; set; } 

        [JsonProperty("workday_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Workday_id { get; set; } 

        [JsonProperty("workday_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Workday_name { get; set; } 

        [JsonProperty("workday_timezone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Workday_timezone { get; set; } 

        [JsonProperty("costprice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Costprice { get; set; } 

        [JsonProperty("chargerate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Chargerate { get; set; } 

        [JsonProperty("first_role_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? First_role_id { get; set; } 

        [JsonProperty("in_queried_team", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? In_queried_team { get; set; } 

        [JsonProperty("guid_string", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Guid_string { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class UnsubEmailServiceUsers
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("stid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Stid { get; set; } 

        [JsonProperty("uid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Uid { get; set; } 

        [JsonProperty("key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Key { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class UnsubscribeService
    {
        [JsonProperty("serviceid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Serviceid { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class UserAnalyzer
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? User_id { get; set; } 

        [JsonProperty("user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? User_name { get; set; } 

        [JsonProperty("report_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Report_id { get; set; } 

        [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Client_id { get; set; } 

        [JsonProperty("client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Client_name { get; set; } 

        [JsonProperty("site_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Site_id { get; set; } 

        [JsonProperty("site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Site_name { get; set; } 

        [JsonProperty("role_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Role_id { get; set; } 

        [JsonProperty("role_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Role_name { get; set; } 

        [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Type { get; set; } 

        [JsonProperty("allow_everyone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allow_everyone { get; set; } 

        [JsonProperty("department_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Department_id { get; set; } 

        [JsonProperty("department_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Department_name { get; set; } 

        [JsonProperty("organisation_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Organisation_id { get; set; } 

        [JsonProperty("organisation_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Organisation_name { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class UserCompany
    {
        [JsonProperty("company_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Company_id { get; set; } 

        [JsonProperty("user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? User_id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class UserDashboardButtons
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("sequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sequence { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("hint_header", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Hint_header { get; set; } 

        [JsonProperty("hint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Hint { get; set; } 

        [JsonProperty("systemuse", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Systemuse { get; set; } 

        [JsonProperty("use_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Use_id { get; set; } 

        [JsonProperty("use_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Use_guid { get; set; } 

        [JsonProperty("colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Colour { get; set; } 

        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Url { get; set; } 

        [JsonProperty("hover", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hover { get; set; } 

        [JsonProperty("icon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Icon { get; set; } 

        [JsonProperty("usedefault", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Usedefault { get; set; } 

        [JsonProperty("showonhomescreen", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showonhomescreen { get; set; } 

        [JsonProperty("showonnavbar", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showonnavbar { get; set; } 

        [JsonProperty("iconcolour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Iconcolour { get; set; } 

        [JsonProperty("iconcolour_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Iconcolour_type { get; set; } 

        [JsonProperty("anyonymousanduseraccessprivelages", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Anyonymousanduseraccessprivelages { get; set; } 

        [JsonProperty("udbtickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Udbtickettype { get; set; } 

        [JsonProperty("tickettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Tickettype_guid { get; set; } 

        [JsonProperty("displaytype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Displaytype { get; set; } 

        [JsonProperty("displaytype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Displaytype_guid { get; set; } 

        [JsonProperty("useroadmapcolumnsratherthanstatuses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Useroadmapcolumnsratherthanstatuses { get; set; } 

        [JsonProperty("restrictions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<UserDashboardRestrictions>? Restrictions { get; set; } 

        [JsonProperty("translations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<LanguagePackTranslationsCustom>? Translations { get; set; } 

        [JsonProperty("customhtml", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Customhtml { get; set; } 

        [JsonProperty("page_title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Page_title { get; set; } 

        [JsonProperty("page_desc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Page_desc { get; set; } 

        [JsonProperty("topkb_title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Topkb_title { get; set; } 

        [JsonProperty("new_icon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_icon { get; set; } 

        [JsonProperty("usecustomicon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Usecustomicon { get; set; } 

        [JsonProperty("custom_icon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Custom_icon { get; set; } 

        [JsonProperty("default_view", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_view { get; set; } 

        [JsonProperty("portal_ticket_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<RequestType_List>? Portal_ticket_list { get; set; } 

        [JsonProperty("ticket_column_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Ticket_column_override { get; set; } 

        [JsonProperty("tickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Tickettype { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class UserDashboardRestrictions
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("button_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Button_id { get; set; } 

        [JsonProperty("restriction_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Restriction_type { get; set; } 

        [JsonProperty("entity_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Entity_id { get; set; } 

        [JsonProperty("entity_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Entity_guid { get; set; } 

        [JsonProperty("entity_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Entity_name { get; set; } 

        [JsonProperty("allow_access", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allow_access { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class UserDepartment
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? User_id { get; set; } 

        [JsonProperty("user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? User_name { get; set; } 

        [JsonProperty("department_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Department_id { get; set; } 

        [JsonProperty("department_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Department_name { get; set; } 

        [JsonProperty("is_manager", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_manager { get; set; } 

        [JsonProperty("is_azure_department", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_azure_department { get; set; } 

        [JsonProperty("role_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Role_id { get; set; } 

        [JsonProperty("role_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Role_name { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class UserPrefs
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("lang", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Lang { get; set; } 

        [JsonProperty("theme", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Theme { get; set; } 

        [JsonProperty("userdetails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Users? Userdetails { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class UserRoles
    {
        [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Guid? Guid { get; set; } 

        [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Intent { get; set; } 

        [JsonProperty("isimportantcontact2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isimportantcontact2 { get; set; } 

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("showmeonly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Showmeonly { get; set; } 

        [JsonProperty("ischangeapprover2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ischangeapprover2 { get; set; } 

        [JsonProperty("ispoapprover", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ispoapprover { get; set; } 

        [JsonProperty("web_access_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Web_access_level { get; set; } 

        [JsonProperty("canadd", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Canadd { get; set; } 

        [JsonProperty("canviewopps", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Canviewopps { get; set; } 

        [JsonProperty("allowviewsitedocs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allowviewsitedocs { get; set; } 

        [JsonProperty("allowviewclientdocs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allowviewclientdocs { get; set; } 

        [JsonProperty("canviewcontracts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Canviewcontracts { get; set; } 

        [JsonProperty("canaccesscatalog", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Canaccesscatalog { get; set; } 

        [JsonProperty("cataloglevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Cataloglevel { get; set; } 

        [JsonProperty("canaccessinvoices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Canaccessinvoices { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("notes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Notes { get; set; } 

        [JsonProperty("device_access_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Device_access_level { get; set; } 

        [JsonProperty("is_integration", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_integration { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("dontackemails2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dontackemails2 { get; set; } 

        [JsonProperty("departments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<UserDepartment>? Departments { get; set; } 

        [JsonProperty("notifications", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<UnameNotification>? Notifications { get; set; } 

        [JsonProperty("canuploaddocuments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Canuploaddocuments { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class UserThirdPartyGroup
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("userid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Userid { get; set; } 

        [JsonProperty("thirdpartyid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Thirdpartyid { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class Users
    {
        [JsonProperty("is_comms_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_comms_user { get; set; } 

        [JsonProperty("ischangeapprover2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ischangeapprover2 { get; set; } 

        [JsonProperty("sitephonenumberint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Sitephonenumberint { get; set; } 

        [JsonProperty("phonenumberint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Phonenumberint { get; set; } 

        [JsonProperty("homenumberint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Homenumberint { get; set; } 

        [JsonProperty("mobileint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Mobileint { get; set; } 

        [JsonProperty("mobilenumber2int", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Mobilenumber2int { get; set; } 

        [JsonProperty("faxint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Faxint { get; set; } 

        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("site_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Site_id { get; set; } 

        [JsonProperty("site_id_int", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Site_id_int { get; set; } 

        [JsonProperty("site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Site_name { get; set; } 

        [JsonProperty("client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Client_name { get; set; } 

        [JsonProperty("firstname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Firstname { get; set; } 

        [JsonProperty("surname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Surname { get; set; } 

        [JsonProperty("initials", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Initials { get; set; } 

        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Title { get; set; } 

        [JsonProperty("emailaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Emailaddress { get; set; } 

        [JsonProperty("phonenumber_preferred", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Phonenumber_preferred { get; set; } 

        [JsonProperty("sitephonenumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sitephonenumber { get; set; } 

        [JsonProperty("phonenumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Phonenumber { get; set; } 

        [JsonProperty("homenumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Homenumber { get; set; } 

        [JsonProperty("mobilenumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Mobilenumber { get; set; } 

        [JsonProperty("mobilenumber2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Mobilenumber2 { get; set; } 

        [JsonProperty("fax", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Fax { get; set; } 

        [JsonProperty("telpref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Telpref { get; set; } 

        [JsonProperty("activedirectory_dn", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Activedirectory_dn { get; set; } 

        [JsonProperty("onpremise_activedirectory_dn", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Onpremise_activedirectory_dn { get; set; } 

        [JsonProperty("container_dn", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Container_dn { get; set; } 

        [JsonProperty("login", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Login { get; set; } 

        [JsonProperty("inactive", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Inactive { get; set; } 

        [JsonProperty("colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Colour { get; set; } 

        [JsonProperty("isimportantcontact", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isimportantcontact { get; set; } 

        [JsonProperty("other1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Other1 { get; set; } 

        [JsonProperty("other2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Other2 { get; set; } 

        [JsonProperty("other3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Other3 { get; set; } 

        [JsonProperty("other4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Other4 { get; set; } 

        [JsonProperty("other5", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Other5 { get; set; } 

        [JsonProperty("notes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Notes { get; set; } 

        [JsonProperty("neversendemails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Neversendemails { get; set; } 

        [JsonProperty("default_currency_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_currency_code { get; set; } 

        [JsonProperty("site_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Site_guid { get; set; } 

        [JsonProperty("area_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Area_guid { get; set; } 

        [JsonProperty("site_cautomate_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Site_cautomate_guid { get; set; } 

        [JsonProperty("priority_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Priority_id { get; set; } 

        [JsonProperty("linked_agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Linked_agent_id { get; set; } 

        [JsonProperty("covered_by_contract", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Covered_by_contract { get; set; } 

        [JsonProperty("contract_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Contract_value { get; set; } 

        [JsonProperty("software_role_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Software_role_name { get; set; } 

        [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CustomField>? Customfields { get; set; } 

        [JsonProperty("attachments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Attachment>? Attachments { get; set; } 

        [JsonProperty("custombuttons", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CustomButton>? Custombuttons { get; set; } 

        [JsonProperty("relationship_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Relationship_id { get; set; } 

        [JsonProperty("user_relationships", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<XTypeRole>? User_relationships { get; set; } 

        [JsonProperty("uddevsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Uddevsite { get; set; } 

        [JsonProperty("uddevnum", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Uddevnum { get; set; } 

        [JsonProperty("uduserid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Uduserid { get; set; } 

        [JsonProperty("userdevicerolecount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Userdevicerolecount { get; set; } 

        [JsonProperty("site_hubspot_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Site_hubspot_guid { get; set; } 

        [JsonProperty("isserviceaccount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isserviceaccount { get; set; } 

        [JsonProperty("ignoreautomatedbilling", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ignoreautomatedbilling { get; set; } 

        [JsonProperty("isimportantcontact2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isimportantcontact2 { get; set; } 

        [JsonProperty("connectwiseid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Connectwiseid { get; set; } 

        [JsonProperty("autotaskid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Autotaskid { get; set; } 

        [JsonProperty("messagegroup_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Messagegroup_id { get; set; } 

        [JsonProperty("role_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Role_list { get; set; } 

        [JsonProperty("sitetimezone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sitetimezone { get; set; } 

        [JsonProperty("client_account_manager_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Client_account_manager_id { get; set; } 

        [JsonProperty("datecreated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Datecreated { get; set; } 

        [JsonProperty("inv1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Inv1 { get; set; } 

        [JsonProperty("inv2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Inv2 { get; set; } 

        [JsonProperty("inv3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Inv3 { get; set; } 

        [JsonProperty("inv4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Inv4 { get; set; } 

        [JsonProperty("slaid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Slaid { get; set; } 

        [JsonProperty("new_password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_password { get; set; } 

        [JsonProperty("dontackemails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dontackemails { get; set; } 

        [JsonProperty("web_access_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Web_access_level { get; set; } 

        [JsonProperty("showmeonly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Showmeonly { get; set; } 

        [JsonProperty("showrecentonly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Showrecentonly { get; set; } 

        [JsonProperty("inform", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Inform { get; set; } 

        [JsonProperty("inv1site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Inv1site { get; set; } 

        [JsonProperty("inv2site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Inv2site { get; set; } 

        [JsonProperty("inv3site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Inv3site { get; set; } 

        [JsonProperty("inv4site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Inv4site { get; set; } 

        [JsonProperty("inv5", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Inv5 { get; set; } 

        [JsonProperty("inv6", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Inv6 { get; set; } 

        [JsonProperty("inv7", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Inv7 { get; set; } 

        [JsonProperty("inv8", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Inv8 { get; set; } 

        [JsonProperty("inv9", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Inv9 { get; set; } 

        [JsonProperty("inv10", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Inv10 { get; set; } 

        [JsonProperty("inv5site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Inv5site { get; set; } 

        [JsonProperty("inv6site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Inv6site { get; set; } 

        [JsonProperty("inv7site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Inv7site { get; set; } 

        [JsonProperty("inv8site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Inv8site { get; set; } 

        [JsonProperty("inv9site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Inv9site { get; set; } 

        [JsonProperty("inv10site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Inv10site { get; set; } 

        [JsonProperty("informaction", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Informaction { get; set; } 

        [JsonProperty("informclearance", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Informclearance { get; set; } 

        [JsonProperty("inv11", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Inv11 { get; set; } 

        [JsonProperty("inv12", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Inv12 { get; set; } 

        [JsonProperty("inv13", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Inv13 { get; set; } 

        [JsonProperty("inv14", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Inv14 { get; set; } 

        [JsonProperty("inv15", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Inv15 { get; set; } 

        [JsonProperty("inv16", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Inv16 { get; set; } 

        [JsonProperty("inv17", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Inv17 { get; set; } 

        [JsonProperty("inv18", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Inv18 { get; set; } 

        [JsonProperty("inv19", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Inv19 { get; set; } 

        [JsonProperty("inv20", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Inv20 { get; set; } 

        [JsonProperty("inv21", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Inv21 { get; set; } 

        [JsonProperty("inv22", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Inv22 { get; set; } 

        [JsonProperty("inv23", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Inv23 { get; set; } 

        [JsonProperty("inv24", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Inv24 { get; set; } 

        [JsonProperty("inv25", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Inv25 { get; set; } 

        [JsonProperty("inv11site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Inv11site { get; set; } 

        [JsonProperty("inv12site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Inv12site { get; set; } 

        [JsonProperty("inv13site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Inv13site { get; set; } 

        [JsonProperty("inv14site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Inv14site { get; set; } 

        [JsonProperty("inv15site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Inv15site { get; set; } 

        [JsonProperty("inv16site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Inv16site { get; set; } 

        [JsonProperty("inv17site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Inv17site { get; set; } 

        [JsonProperty("inv18site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Inv18site { get; set; } 

        [JsonProperty("inv19site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Inv19site { get; set; } 

        [JsonProperty("inv20site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Inv20site { get; set; } 

        [JsonProperty("inv21site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Inv21site { get; set; } 

        [JsonProperty("inv22site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Inv22site { get; set; } 

        [JsonProperty("inv23site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Inv23site { get; set; } 

        [JsonProperty("inv24site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Inv24site { get; set; } 

        [JsonProperty("inv25site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Inv25site { get; set; } 

        [JsonProperty("showslatimes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Showslatimes { get; set; } 

        [JsonProperty("canadd", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Canadd { get; set; } 

        [JsonProperty("allowviewsitedocs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allowviewsitedocs { get; set; } 

        [JsonProperty("third_party_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Third_party_guid { get; set; } 

        [JsonProperty("third_party_sql", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Third_party_sql { get; set; } 

        [JsonProperty("ischangeapprover", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ischangeapprover { get; set; } 

        [JsonProperty("cancreateuser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Cancreateuser { get; set; } 

        [JsonProperty("department", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Department { get; set; } 

        [JsonProperty("isheadofdept", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isheadofdept { get; set; } 

        [JsonProperty("deputysite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Deputysite { get; set; } 

        [JsonProperty("deputyusername", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Deputyusername { get; set; } 

        [JsonProperty("cat2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Cat2 { get; set; } 

        [JsonProperty("lastlogindate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Lastlogindate { get; set; } 

        [JsonProperty("email2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Email2 { get; set; } 

        [JsonProperty("email3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Email3 { get; set; } 

        [JsonProperty("iscontractcontact", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Iscontractcontact { get; set; } 

        [JsonProperty("informnewarea", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Informnewarea { get; set; } 

        [JsonProperty("informactionarea", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Informactionarea { get; set; } 

        [JsonProperty("informclearancearea", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Informclearancearea { get; set; } 

        [JsonProperty("disclaimermatchstring", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Disclaimermatchstring { get; set; } 

        [JsonProperty("viewallcleared", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Viewallcleared { get; set; } 

        [JsonProperty("isexternal", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isexternal { get; set; } 

        [JsonProperty("question1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Question1 { get; set; } 

        [JsonProperty("question2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Question2 { get; set; } 

        [JsonProperty("question3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Question3 { get; set; } 

        [JsonProperty("question4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Question4 { get; set; } 

        [JsonProperty("question5", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Question5 { get; set; } 

        [JsonProperty("dontaddtomailinglist", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dontaddtomailinglist { get; set; } 

        [JsonProperty("caneditwebdetails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Caneditwebdetails { get; set; } 

        [JsonProperty("cataloglevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Cataloglevel { get; set; } 

        [JsonProperty("canaccesscatalog", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Canaccesscatalog { get; set; } 

        [JsonProperty("hasbeentrained", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hasbeentrained { get; set; } 

        [JsonProperty("admanager", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Admanager { get; set; } 

        [JsonProperty("canviewcontracts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Canviewcontracts { get; set; } 

        [JsonProperty("ispoapprover", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ispoapprover { get; set; } 

        [JsonProperty("encmethod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Encmethod { get; set; } 

        [JsonProperty("adconnection", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Adconnection { get; set; } 

        [JsonProperty("useadlogin", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Useadlogin { get; set; } 

        [JsonProperty("sendwelcomeemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sendwelcomeemail { get; set; } 

        [JsonProperty("welcomeemail_template_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Welcomeemail_template_id { get; set; } 

        [JsonProperty("resetpassword", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Resetpassword { get; set; } 

        [JsonProperty("_anonymise", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _anonymise { get; set; } 

        [JsonProperty("_reassign_all_to_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? _reassign_all_to_user { get; set; } 

        [JsonProperty("ismaincontact", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ismaincontact { get; set; } 

        [JsonProperty("primary_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public AddressStore? Primary_address { get; set; } 

        [JsonProperty("addresses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AddressStore>? Addresses { get; set; } 

        [JsonProperty("departments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<UserDepartment>? Departments { get; set; } 

        [JsonProperty("organisation_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Organisation_id { get; set; } 

        [JsonProperty("popup_notes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<AreaPopup>? Popup_notes { get; set; } 

        [JsonProperty("open_ticket_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Open_ticket_count { get; set; } 

        [JsonProperty("onhold_ticket_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Onhold_ticket_count { get; set; } 

        [JsonProperty("total_ticket_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Total_ticket_count { get; set; } 

        [JsonProperty("opened_thismonth_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Opened_thismonth_count { get; set; } 

        [JsonProperty("_isnew", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _isnew { get; set; } 

        [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _isimport { get; set; } 

        [JsonProperty("memberof", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Memberof { get; set; } 

        [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _importtype { get; set; } 

        [JsonProperty("usercompany", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<UserCompany>? Usercompany { get; set; } 

        [JsonProperty("supplier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public Supplier? Supplier { get; set; } 

        [JsonProperty("supplier_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Supplier_name { get; set; } 

        [JsonProperty("claims", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<NHD_Claim>? Claims { get; set; } 

        [JsonProperty("app_colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? App_colour { get; set; } 

        [JsonProperty("emailconfirmed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Emailconfirmed { get; set; } 

        [JsonProperty("agent_app_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Agent_app_url { get; set; } 

        [JsonProperty("imagedata", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Imagedata { get; set; } 

        [JsonProperty("webannouncement", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Webannouncement { get; set; } 

        [JsonProperty("cautomateid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Cautomateid { get; set; } 

        [JsonProperty("azure_connectionid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Azure_connectionid { get; set; } 

        [JsonProperty("_importtoken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _importtoken { get; set; } 

        [JsonProperty("jira_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Jira_id { get; set; } 

        [JsonProperty("zapier_client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Zapier_client_name { get; set; } 

        [JsonProperty("delegation_activated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Delegation_activated { get; set; } 

        [JsonProperty("delegation_timebased", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Delegation_timebased { get; set; } 

        [JsonProperty("delegation_start", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Delegation_start { get; set; } 

        [JsonProperty("delegation_end", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Delegation_end { get; set; } 

        [JsonProperty("delegation_user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Delegation_user_id { get; set; } 

        [JsonProperty("delegation_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Delegation_user_name { get; set; } 

        [JsonProperty("googleworkplace_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Googleworkplace_id { get; set; } 

        [JsonProperty("isnhserveremaildefault", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isnhserveremaildefault { get; set; } 

        [JsonProperty("matchprimaryemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Matchprimaryemail { get; set; } 

        [JsonProperty("servicenow_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Servicenow_id { get; set; } 

        [JsonProperty("servicenow_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Servicenow_username { get; set; } 

        [JsonProperty("site_servicenow_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Site_servicenow_id { get; set; } 

        [JsonProperty("sgatewayid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sgatewayid { get; set; } 

        [JsonProperty("software", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<DeviceApplications>? Software { get; set; } 

        [JsonProperty("canaccessinvoices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Canaccessinvoices { get; set; } 

        [JsonProperty("samaccountname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Samaccountname { get; set; } 

        [JsonProperty("oktaid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Oktaid { get; set; } 

        [JsonProperty("okta_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Okta_status { get; set; } 

        [JsonProperty("authenticatorapp_configured", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Authenticatorapp_configured { get; set; } 

        [JsonProperty("_revoke_authenticatorapp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _revoke_authenticatorapp { get; set; } 

        [JsonProperty("ulastupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Ulastupdate { get; set; } 

        [JsonProperty("_isopp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _isopp { get; set; } 

        [JsonProperty("oppcompanyname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Oppcompanyname { get; set; } 

        [JsonProperty("oppcontactname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Oppcontactname { get; set; } 

        [JsonProperty("oppemailaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Oppemailaddress { get; set; } 

        [JsonProperty("assets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Device_List>? Assets { get; set; } 

        [JsonProperty("locked", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Locked { get; set; } 

        [JsonProperty("site_guid2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Site_guid2 { get; set; } 

        [JsonProperty("allowviewclientdocs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Allowviewclientdocs { get; set; } 

        [JsonProperty("azure_tenant_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Azure_tenant_id { get; set; } 

        [JsonProperty("azure_last_login_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Azure_last_login_date { get; set; } 

        [JsonProperty("linked_user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Linked_user_id { get; set; } 

        [JsonProperty("linked_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Linked_user_name { get; set; } 

        [JsonProperty("hubspot_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Hubspot_id { get; set; } 

        [JsonProperty("hubspot_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Hubspot_url { get; set; } 

        [JsonProperty("hubspot_dont_sync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hubspot_dont_sync { get; set; } 

        [JsonProperty("hubspot_archived", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Hubspot_archived { get; set; } 

        [JsonProperty("passportal_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Passportal_id { get; set; } 

        [JsonProperty("passportal_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Passportal_client_id { get; set; } 

        [JsonProperty("opportunity_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Opportunity_id { get; set; } 

        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _warning { get; set; } 

        [JsonProperty("isuserdetails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isuserdetails { get; set; } 

        [JsonProperty("hudu_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Hudu_url { get; set; } 

        [JsonProperty("sqlimport_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Sqlimport_id { get; set; } 

        [JsonProperty("sqlimport_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sqlimport_user { get; set; } 

        [JsonProperty("unsubscribed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Unsubscribed { get; set; } 

        [JsonProperty("canviewopps", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Canviewopps { get; set; } 

        [JsonProperty("azure_tenant_domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Azure_tenant_domain { get; set; } 

        [JsonProperty("servicenow_companyid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Servicenow_companyid { get; set; } 

        [JsonProperty("external_links", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLink_List>? External_links { get; set; } 

        [JsonProperty("new_external_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ExternalLink_List? New_external_link { get; set; } 

        [JsonProperty("_match_thirdparty_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _match_thirdparty_id { get; set; } 

        [JsonProperty("_match_integration_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? _match_integration_id { get; set; } 

        [JsonProperty("_match_integration_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _match_integration_name { get; set; } 

        [JsonProperty("salesforce_dontsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Salesforce_dontsync { get; set; } 

        [JsonProperty("_hascontactsenabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _hascontactsenabled { get; set; } 

        [JsonProperty("new_site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_site_name { get; set; } 

        [JsonProperty("_isbatch", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _isbatch { get; set; } 

        [JsonProperty("roles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<UserRoles>? Roles { get; set; } 

        [JsonProperty("azure_roleid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Azure_roleid { get; set; } 

        [JsonProperty("add_roles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<UserRoles>? Add_roles { get; set; } 

        [JsonProperty("facebook_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Facebook_id { get; set; } 

        [JsonProperty("facebook_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Facebook_username { get; set; } 

        [JsonProperty("twitter_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Twitter_id { get; set; } 

        [JsonProperty("twitter_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Twitter_username { get; set; } 

        [JsonProperty("_merge_user_into", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? _merge_user_into { get; set; } 

        [JsonProperty("_email_collision", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? _email_collision { get; set; } 

        [JsonProperty("_dont_fire_automations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _dont_fire_automations { get; set; } 

        [JsonProperty("device_access_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Device_access_level { get; set; } 

        [JsonProperty("ticket_customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CustomField>? Ticket_customfields { get; set; } 

        [JsonProperty("manager_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Manager_email { get; set; } 

        [JsonProperty("_remove_licenses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _remove_licenses { get; set; } 

        [JsonProperty("_new_usersite_only", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _new_usersite_only { get; set; } 

        [JsonProperty("thirdpartygroups", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<UserThirdPartyGroup>? Thirdpartygroups { get; set; } 

        [JsonProperty("linked_sites", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLink_List>? Linked_sites { get; set; } 

        [JsonProperty("dontackemails2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Dontackemails2 { get; set; } 

        [JsonProperty("instagram_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public long? Instagram_id { get; set; } 

        [JsonProperty("instagram_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Instagram_username { get; set; } 

        [JsonProperty("jira_instance", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Jira_instance { get; set; } 

        [JsonProperty("jira_instance_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Jira_instance_name { get; set; } 

        [JsonProperty("third_party_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Third_party_id { get; set; } 

        [JsonProperty("no_manager_roleid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? No_manager_roleid { get; set; } 

        [JsonProperty("matching_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Matching_value { get; set; } 

        [JsonProperty("theme", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Theme { get; set; } 

        [JsonProperty("lang", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Lang { get; set; } 

        [JsonProperty("gocardless_customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public IDictionary<string, string?>? Gocardless_customfields { get; set; } 

        [JsonProperty("service_account_overridden", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Service_account_overridden { get; set; } 

        [JsonProperty("sendaccountsemails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Sendaccountsemails { get; set; } 

        [JsonProperty("extratabs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Tabname>? Extratabs { get; set; } 

        [JsonProperty("informifack", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Informifack { get; set; } 

        [JsonProperty("informnewareaifack", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Informnewareaifack { get; set; } 

        [JsonProperty("marketing_unsubscribes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<MarketingUnsubscribe>? Marketing_unsubscribes { get; set; } 

        [JsonProperty("new_account_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? New_account_name { get; set; } 

        [JsonProperty("prospect_account_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Prospect_account_id { get; set; } 

        [JsonProperty("open_opportunity_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Open_opportunity_count { get; set; } 

        [JsonProperty("_convert_phonenumbers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? _convert_phonenumbers { get; set; } 

        [JsonProperty("update_user_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Update_user_tickets { get; set; } 

        [JsonProperty("check_update_user_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Check_update_user_tickets { get; set; } 

        [JsonProperty("canuploaddocuments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Canuploaddocuments { get; set; } 

        [JsonProperty("runbook_button_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Runbook_button_id { get; set; } 

        [JsonProperty("use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Use { get; set; } 

        [JsonProperty("key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Key { get; set; } 

        [JsonProperty("table", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public TableEnum? Table { get; set; } 

        [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Client_id { get; set; } 

        [JsonProperty("item_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Item_tax_code { get; set; } 

        [JsonProperty("automatic_sales_tax", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Automatic_sales_tax { get; set; } 

        [JsonProperty("client_taxable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Client_taxable { get; set; } 

        [JsonProperty("overridepdftemplatequote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Overridepdftemplatequote { get; set; } 

        [JsonProperty("overridepdftemplatequote_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Overridepdftemplatequote_name { get; set; } 

        [JsonProperty("contract_end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Contract_end_date { get; set; } 

        [JsonProperty("okta_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Okta_id { get; set; } 

        [JsonProperty("azure_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Azure_id { get; set; } 

        [JsonProperty("user_with_clientsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? User_with_clientsite { get; set; } 

        [JsonProperty("client_automatic_callscript_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Client_automatic_callscript_id { get; set; } 

        [JsonProperty("neversendmarketingemails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Neversendmarketingemails { get; set; } 

        [JsonProperty("is_prospect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_prospect { get; set; } 

        [JsonProperty("whatsapp_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Whatsapp_number { get; set; } 

        [JsonProperty("azureoid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Azureoid { get; set; } 

        [JsonProperty("date_of_birth", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Date_of_birth { get; set; } 

        [JsonProperty("_importtypeid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? _importtypeid { get; set; } 

        [JsonProperty("_importthirdpartyid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _importthirdpartyid { get; set; } 

    }

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class Users_List
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Name { get; set; } 

        [JsonProperty("site_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Site_id { get; set; } 

        [JsonProperty("site_id_int", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Site_id_int { get; set; } 

        [JsonProperty("site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Site_name { get; set; } 

        [JsonProperty("client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Client_name { get; set; } 

        [JsonProperty("firstname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Firstname { get; set; } 

        [JsonProperty("surname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Surname { get; set; } 

        [JsonProperty("initials", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Initials { get; set; } 

        [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Title { get; set; } 

        [JsonProperty("emailaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Emailaddress { get; set; } 

        [JsonProperty("phonenumber_preferred", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Phonenumber_preferred { get; set; } 

        [JsonProperty("sitephonenumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sitephonenumber { get; set; } 

        [JsonProperty("phonenumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Phonenumber { get; set; } 

        [JsonProperty("homenumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Homenumber { get; set; } 

        [JsonProperty("mobilenumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Mobilenumber { get; set; } 

        [JsonProperty("mobilenumber2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Mobilenumber2 { get; set; } 

        [JsonProperty("fax", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Fax { get; set; } 

        [JsonProperty("telpref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Telpref { get; set; } 

        [JsonProperty("activedirectory_dn", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Activedirectory_dn { get; set; } 

        [JsonProperty("onpremise_activedirectory_dn", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Onpremise_activedirectory_dn { get; set; } 

        [JsonProperty("container_dn", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Container_dn { get; set; } 

        [JsonProperty("login", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Login { get; set; } 

        [JsonProperty("inactive", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Inactive { get; set; } 

        [JsonProperty("colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Colour { get; set; } 

        [JsonProperty("isimportantcontact", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isimportantcontact { get; set; } 

        [JsonProperty("other1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Other1 { get; set; } 

        [JsonProperty("other2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Other2 { get; set; } 

        [JsonProperty("other3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Other3 { get; set; } 

        [JsonProperty("other4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Other4 { get; set; } 

        [JsonProperty("other5", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Other5 { get; set; } 

        [JsonProperty("notes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Notes { get; set; } 

        [JsonProperty("neversendemails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Neversendemails { get; set; } 

        [JsonProperty("default_currency_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Default_currency_code { get; set; } 

        [JsonProperty("site_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Site_guid { get; set; } 

        [JsonProperty("area_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Area_guid { get; set; } 

        [JsonProperty("site_cautomate_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Site_cautomate_guid { get; set; } 

        [JsonProperty("priority_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Priority_id { get; set; } 

        [JsonProperty("linked_agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Linked_agent_id { get; set; } 

        [JsonProperty("covered_by_contract", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Covered_by_contract { get; set; } 

        [JsonProperty("contract_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public double? Contract_value { get; set; } 

        [JsonProperty("software_role_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Software_role_name { get; set; } 

        [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CustomField>? Customfields { get; set; } 

        [JsonProperty("attachments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<Attachment>? Attachments { get; set; } 

        [JsonProperty("custombuttons", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<CustomButton>? Custombuttons { get; set; } 

        [JsonProperty("relationship_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Relationship_id { get; set; } 

        [JsonProperty("user_relationships", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<XTypeRole>? User_relationships { get; set; } 

        [JsonProperty("uddevsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Uddevsite { get; set; } 

        [JsonProperty("uddevnum", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Uddevnum { get; set; } 

        [JsonProperty("uduserid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Uduserid { get; set; } 

        [JsonProperty("userdevicerolecount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Userdevicerolecount { get; set; } 

        [JsonProperty("site_hubspot_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Site_hubspot_guid { get; set; } 

        [JsonProperty("isserviceaccount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isserviceaccount { get; set; } 

        [JsonProperty("ignoreautomatedbilling", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Ignoreautomatedbilling { get; set; } 

        [JsonProperty("isimportantcontact2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Isimportantcontact2 { get; set; } 

        [JsonProperty("connectwiseid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Connectwiseid { get; set; } 

        [JsonProperty("autotaskid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Autotaskid { get; set; } 

        [JsonProperty("messagegroup_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Messagegroup_id { get; set; } 

        [JsonProperty("role_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Role_list { get; set; } 

        [JsonProperty("sitetimezone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Sitetimezone { get; set; } 

        [JsonProperty("client_account_manager_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Client_account_manager_id { get; set; } 

        [JsonProperty("use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Use { get; set; } 

        [JsonProperty("key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Key { get; set; } 

        [JsonProperty("table", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public TableEnum? Table { get; set; } 

        [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Client_id { get; set; } 

        [JsonProperty("item_tax_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Item_tax_code { get; set; } 

        [JsonProperty("automatic_sales_tax", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Automatic_sales_tax { get; set; } 

        [JsonProperty("client_taxable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Client_taxable { get; set; } 

        [JsonProperty("overridepdftemplatequote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Overridepdftemplatequote { get; set; } 

        [JsonProperty("overridepdftemplatequote_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Overridepdftemplatequote_name { get; set; } 

        [JsonProperty("contract_end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Contract_end_date { get; set; } 

        [JsonProperty("okta_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Okta_id { get; set; } 

        [JsonProperty("azure_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Azure_id { get; set; } 

        [JsonProperty("user_with_clientsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? User_with_clientsite { get; set; } 

        [JsonProperty("client_automatic_callscript_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Client_automatic_callscript_id { get; set; } 

        [JsonProperty("neversendmarketingemails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Neversendmarketingemails { get; set; } 

        [JsonProperty("is_prospect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? Is_prospect { get; set; } 

        [JsonProperty("whatsapp_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Whatsapp_number { get; set; } 

        [JsonProperty("azureoid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Azureoid { get; set; } 

        [JsonProperty("date_of_birth", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? Date_of_birth { get; set; } 

        [JsonProperty("_importtypeid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? _importtypeid { get; set; } 

        [JsonProperty("_importthirdpartyid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _importthirdpartyid { get; set; } 

        [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? _importtype { get; set; } 

        [JsonProperty("new_external_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ExternalLink_List? New_external_link { get; set; } 

    }