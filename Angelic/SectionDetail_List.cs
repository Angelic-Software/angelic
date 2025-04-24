using System.CodeDom.Compiler;
using Angelic.Agent;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class SectionDetail_List
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
    public bool? Forrequests { get; set; } 

    [JsonProperty("foropps", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Foropps { get; set; } 

    [JsonProperty("forprojects", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Forprojects { get; set; } 

    [JsonProperty("ticket_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Ticket_count { get; set; } 

    [JsonProperty("department_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Department_id { get; set; } 

    [JsonProperty("department_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Department_name { get; set; } 

    [JsonProperty("org_team_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Org_team_name { get; set; } 

    [JsonProperty("inactive", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Inactive { get; set; } 

    [JsonProperty("override_column_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Override_column_id { get; set; } 

    [JsonProperty("agents", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AgentList>? Agents { get; set; } 

    [JsonProperty("managers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Manager>? Managers { get; set; } 

    [JsonProperty("teamphotopath", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Teamphotopath { get; set; } 

    [JsonProperty("last_modified", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Last_modified { get; set; } 

    [JsonProperty("hide_agents_in_tree_if_no_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Hide_agents_in_tree_if_no_tickets { get; set; } 

    [JsonProperty("timesheet_approver", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Timesheet_approver { get; set; } 

    [JsonProperty("timesheet_approver_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Timesheet_approver_name { get; set; } 

    [JsonProperty("concurrent_lic_limit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Concurrent_lic_limit { get; set; } 

    [JsonProperty("use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Use { get; set; } 

    [JsonProperty("department_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Department_guid { get; set; } 

    [JsonProperty("homescreendashboardid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Homescreendashboardid { get; set; } 

    [JsonProperty("homescreendashboardname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Homescreendashboardname { get; set; } 

}