using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.TeamsAndAgents.Agents;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class AgentSection
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AgentId { get; set; } 

    [JsonProperty("agent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AgentName { get; set; } 

    [JsonProperty("team_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TeamId { get; set; } 

    [JsonProperty("team_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? TeamGuid { get; set; } 

    [JsonProperty("team_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TeamName { get; set; } 

    [JsonProperty("department_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DepartmentId { get; set; } 

    [JsonProperty("org_department_team_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OrgDepartmentTeamName { get; set; } 

    [JsonProperty("role_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RoleId { get; set; } 

    [JsonProperty("role_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RoleName { get; set; } 

    [JsonProperty("is_manager", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsManager { get; set; } 

    [JsonProperty("no_config_access", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? NoConfigAccess { get; set; } 

    [JsonProperty("unassigned_access", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? UnassignedAccess { get; set; } 

    [JsonProperty("otheragent_access", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? OtheragentAccess { get; set; } 

    [JsonProperty("fortickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ForTickets { get; set; } 

    [JsonProperty("foropps", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ForOpps { get; set; } 

    [JsonProperty("forprojects", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ForProjects { get; set; } 

    [JsonProperty("in_section", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? InSection { get; set; } 

    [JsonProperty("namewithinactive", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Namewithinactive { get; set; } 

}