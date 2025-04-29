using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.TeamsAndAgents.Agents;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class AgentList
{
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
    public DateTimeOffset? LastLoginDate { get; set; } 

    [JsonProperty("agentphotopath", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AgentPhotoPath { get; set; } 

    [JsonProperty("initials", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Initials { get; set; } 

    [JsonProperty("firstname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? FirstName { get; set; } 

    [JsonProperty("surname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Surname { get; set; } 

    [JsonProperty("colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Colour { get; set; } 

    [JsonProperty("jobtitle", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? JobTitle { get; set; } 

    [JsonProperty("sms", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Sms { get; set; } 

    [JsonProperty("extensionnumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ExtensionNumber { get; set; } 

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
    public string? GoogleEmail { get; set; } 

    [JsonProperty("linemanager", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? LineManager { get; set; } 

    [JsonProperty("linemanager_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? LineManagerName { get; set; } 

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
    public bool? IsApiAgent { get; set; } 

    [JsonProperty("splashtop_authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? SplashtopAuthorized { get; set; } 

    [JsonProperty("gotoresolve_authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? GotoresolveAuthorized { get; set; } 

    [JsonProperty("use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Use { get; set; } 

    [JsonProperty("assetfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AgentField>? AssetFields { get; set; } 

    [JsonProperty("unamecustomfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AgentCustom>? UnameCustomFields { get; set; } 

    [JsonProperty("unameappointmenttypes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AgentAppointment>? UnameAppointmentTypes { get; set; } 

    [JsonProperty("_canupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CanUpdate { get; set; } 

    [JsonProperty("_canupdate_moreinfo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CanUpdateMoreInfo { get; set; } 

    [JsonProperty("logmeinid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? LogMeInId { get; set; } 

    [JsonProperty("allowbeyondtrustinvites", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowBeyondTrustInvites { get; set; } 

    [JsonProperty("jira_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? JiraId { get; set; } 

    [JsonProperty("custombuttons", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AgentButton>? CustomButtons { get; set; } 

    [JsonProperty("namewithinactive", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Namewithinactive { get; set; } 

    [JsonProperty("apptsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ApptSync { get; set; } 

    [JsonProperty("okta_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OktaId { get; set; } 

    [JsonProperty("enableshifts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? EnableShifts { get; set; } 

    [JsonProperty("sendemailerrors", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? SendEmailErrors { get; set; } 

    [JsonProperty("uname_usercustomfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AgentCustom>? UnameUserCustomFields { get; set; } 

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