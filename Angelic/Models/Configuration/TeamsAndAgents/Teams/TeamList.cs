using System.CodeDom.Compiler;
using Angelic.Models.Configuration.TeamsAndAgents.Agents;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.TeamsAndAgents.Teams;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class TeamList
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Guid { get; set; } 

    [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Intent { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("sequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sequence { get; set; } 

    [JsonProperty("forrequests", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ForRequests { get; set; } 

    [JsonProperty("foropps", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ForOpps { get; set; } 

    [JsonProperty("forprojects", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ForProjects { get; set; } 

    [JsonProperty("ticket_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TicketCount { get; set; } 

    [JsonProperty("department_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DepartmentId { get; set; } 

    [JsonProperty("department_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DepartmentName { get; set; } 

    [JsonProperty("org_team_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OrgTeamName { get; set; } 

    [JsonProperty("inactive", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Inactive { get; set; } 

    [JsonProperty("override_column_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OverrideColumnId { get; set; } 

    [JsonProperty("agents", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AgentList>? Agents { get; set; } 

    [JsonProperty("managers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Manager>? Managers { get; set; } 

    [JsonProperty("teamphotopath", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TeamPhotoPath { get; set; } 

    [JsonProperty("last_modified", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? LastModified { get; set; } 

    [JsonProperty("hide_agents_in_tree_if_no_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? HideAgentsInTreeIfNoTickets { get; set; } 

    [JsonProperty("timesheet_approver", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TimesheetApprover { get; set; } 

    [JsonProperty("timesheet_approver_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TimesheetApproverName { get; set; } 

    [JsonProperty("concurrent_lic_limit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ConcurrentLicLimit { get; set; } 

    [JsonProperty("use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Use { get; set; } 

    [JsonProperty("department_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? DepartmentGuid { get; set; } 

    [JsonProperty("homescreendashboardid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? HomeScreenDashboardId { get; set; } 

    [JsonProperty("homescreendashboardname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? HomeScreenDashboardName { get; set; } 

}