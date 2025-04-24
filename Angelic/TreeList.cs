using System.CodeDom.Compiler;
using Angelic.Agent;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class TreeList
{
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
    public ICollection<SectionDetailList>? Teams { get; set; } 

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