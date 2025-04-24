using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class StdRequest_List
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Guid { get; set; } 

    [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Intent { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Type { get; set; } 

    [JsonProperty("domain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Domain { get; set; } 

    [JsonProperty("group_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Group_id { get; set; } 

    [JsonProperty("restriction_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Restriction_type { get; set; } 

    [JsonProperty("restrictto_department_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Restrictto_department_id { get; set; } 

    [JsonProperty("restrictto_department_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Restrictto_department_name { get; set; } 

    [JsonProperty("restrictto_team_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Restrictto_team_id { get; set; } 

    [JsonProperty("restrictto_team_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Restrictto_team_name { get; set; } 

    [JsonProperty("restrictto_agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Restrictto_agent_id { get; set; } 

    [JsonProperty("restrictto_agent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Restrictto_agent_name { get; set; } 

    [JsonProperty("summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Summary { get; set; } 

    [JsonProperty("tickettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Tickettype_id { get; set; } 

    [JsonProperty("rule_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Rule_count { get; set; } 

    [JsonProperty("creation_rules", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<StdRequestRule>? Creation_rules { get; set; } 

    [JsonProperty("todo_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<STDToDo>? Todo_list { get; set; } 

    [JsonProperty("emailto", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Emailto { get; set; } 

    [JsonProperty("emailcc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Emailcc { get; set; } 

    [JsonProperty("emailbcc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Emailbcc { get; set; } 

    [JsonProperty("emailsubject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Emailsubject { get; set; } 

    [JsonProperty("time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Time { get; set; } 

    [JsonProperty("disabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Disabled { get; set; } 

    [JsonProperty("lastcreated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Lastcreated { get; set; } 

    [JsonProperty("nextcreationdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Nextcreationdate { get; set; } 

    [JsonProperty("nextcreationdate_after_end", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Nextcreationdate_after_end { get; set; } 

    [JsonProperty("execution_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Execution_type { get; set; } 

    [JsonProperty("startdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Startdate { get; set; } 

    [JsonProperty("end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? End_date { get; set; } 

    [JsonProperty("period", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Period { get; set; } 

    [JsonProperty("create_locked", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Create_locked { get; set; } 

    [JsonProperty("one_ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? One_ticket_id { get; set; } 

    [JsonProperty("created_ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Created_ticket_id { get; set; } 

    [JsonProperty("approval_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Approval_id { get; set; } 

    [JsonProperty("reportarea", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Reportarea { get; set; } 

    [JsonProperty("reportarea_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Reportarea_name { get; set; } 

    [JsonProperty("restrictto_department_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Restrictto_department_guid { get; set; } 

    [JsonProperty("restrictto_team_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Restrictto_team_guid { get; set; } 

    [JsonProperty("clients", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Clients { get; set; } 

    [JsonProperty("tickettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Tickettype_guid { get; set; } 

    [JsonProperty("automationtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Automationtype { get; set; } 

    [JsonProperty("optionalservice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Optionalservice { get; set; } 

    [JsonProperty("optional_agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Optional_agent_id { get; set; } 

    [JsonProperty("optional_team", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Optional_team { get; set; } 

    [JsonProperty("optional_status_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Optional_status_id { get; set; } 

    [JsonProperty("optional_tickettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Optional_tickettype_id { get; set; } 

    [JsonProperty("optional_create_locked", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Optional_create_locked { get; set; } 

    [JsonProperty("optional_defaultresourcetype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Optional_defaultresourcetype { get; set; } 

    [JsonProperty("optional_excludefromsla", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Optional_excludefromsla { get; set; } 

    [JsonProperty("optional_customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomField>? Optional_customfields { get; set; } 

    [JsonProperty("optional_assets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Device_List>? Optional_assets { get; set; } 

    [JsonProperty("optional_forwardinboundupdates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Optional_forwardinboundupdates { get; set; } 

    [JsonProperty("optional_showforusers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Optional_showforusers { get; set; } 

    [JsonProperty("optional_urgency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Optional_urgency { get; set; } 

    [JsonProperty("optional_impact", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Optional_impact { get; set; } 

    [JsonProperty("optional_workflow_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Optional_workflow_id { get; set; } 

    [JsonProperty("optional_estimate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Optional_estimate { get; set; } 

    [JsonProperty("optional_category_1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Optional_category_1 { get; set; } 

    [JsonProperty("optional_category_2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Optional_category_2 { get; set; } 

    [JsonProperty("optional_category_3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Optional_category_3 { get; set; } 

    [JsonProperty("optional_category_4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Optional_category_4 { get; set; } 

    [JsonProperty("optional_priority_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Optional_priority_id { get; set; } 

    [JsonProperty("optional_budgettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Optional_budgettype_id { get; set; } 

    [JsonProperty("optional_kb_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Optional_kb_id { get; set; } 

    [JsonProperty("optional_service", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Optional_service { get; set; } 

    [JsonProperty("optional_service_details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Optional_service_details_id { get; set; } 

    [JsonProperty("service", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Service { get; set; } 

    [JsonProperty("optional_sla_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Optional_sla_id { get; set; } 

}