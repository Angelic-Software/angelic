using System.CodeDom.Compiler;
using Angelic.Models.Configuration.TeamsAndAgents;
using Angelic.Models.Configuration.TeamsAndAgents.Agents;
using Angelic.Models.Configuration.Tickets;
using Angelic.Models.Configuration.Tickets.Templates;
using Angelic.Models.Configuration.Users;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class TopLevel
{
    [JsonProperty("toplevel_mailbox_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TopLevelMailboxOverride { get; set; } 

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Guid { get; set; } 

    [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Intent { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("accounts_override_mailbox", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AccountsOverrideMailbox { get; set; } 

    [JsonProperty("concurrent_lic_limit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ConcurrentLicLimit { get; set; } 

    [JsonProperty("parentid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Parentid { get; set; } 

    [JsonProperty("notes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Notes { get; set; } 

    [JsonProperty("kashflowurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Kashflowurl { get; set; } 

    [JsonProperty("kashflowusername", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Kashflowusername { get; set; } 

    [JsonProperty("kashflowpassword", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Kashflowpassword { get; set; } 

    [JsonProperty("mailbox_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MailboxOverride { get; set; } 

    [JsonProperty("agent_department", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AgentDepartment { get; set; } 

    [JsonProperty("messagegroup_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MessageGroupId { get; set; } 

    [JsonProperty("agents", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AgentDepartment>? Agents { get; set; } 

    [JsonProperty("users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<UserDepartment>? Users { get; set; } 

    [JsonProperty("cannedtext", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CannedText>? CannedText { get; set; } 

    [JsonProperty("templates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<TemplateList>? Templates { get; set; } 

    [JsonProperty("announcement", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Announcement { get; set; } 

    [JsonProperty("invoice_class", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? InvoiceClass { get; set; } 

    [JsonProperty("quote_profit_currency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? QuoteProfitCurrency { get; set; } 

    [JsonProperty("quote_profit_currency_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? QuoteProfitCurrencyName { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("_canupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CanUpdate { get; set; } 

    [JsonProperty("use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Use { get; set; } 

    [JsonProperty("organisation_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OrganisationId { get; set; } 

    [JsonProperty("organisation_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? OrganisationGuid { get; set; } 

    [JsonProperty("organisation_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OrganisationName { get; set; } 

    [JsonProperty("org_department_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OrgDepartmentName { get; set; } 

    [JsonProperty("long_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? LongName { get; set; } 

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Type { get; set; } 

    [JsonProperty("teams", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<TeamList>? Teams { get; set; } 

    [JsonProperty("agent_members", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AgentList>? AgentMembers { get; set; } 

    [JsonProperty("managers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Manager>? Managers { get; set; } 

    [JsonProperty("user_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? UserCount { get; set; } 

    [JsonProperty("open_ticket_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OpenTicketCount { get; set; } 

    [JsonProperty("onhold_ticket_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OnholdTicketCount { get; set; } 

    [JsonProperty("total_ticket_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TotalTicketCount { get; set; } 

    [JsonProperty("opened_thismonth_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OpenedThismonthCount { get; set; } 

}