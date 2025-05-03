using System.CodeDom.Compiler;
using Angelic.Models.Assets;
using Angelic.Models.Configuration.Custom.CustomFields;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Tickets.Templates;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class TemplateList
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
    public int? GroupId { get; set; } 

    [JsonProperty("restriction_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RestrictionType { get; set; } 

    [JsonProperty("restrictto_department_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RestricttoDepartmentId { get; set; } 

    [JsonProperty("restrictto_department_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RestricttoDepartmentName { get; set; } 

    [JsonProperty("restrictto_team_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RestricttoTeamId { get; set; } 

    [JsonProperty("restrictto_team_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RestricttoTeamName { get; set; } 

    [JsonProperty("restrictto_agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RestricttoAgentId { get; set; } 

    [JsonProperty("restrictto_agent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RestricttoAgentName { get; set; } 

    [JsonProperty("summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Summary { get; set; } 

    [JsonProperty("tickettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TicketTypeId { get; set; } 

    [JsonProperty("rule_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RuleCount { get; set; } 

    [JsonProperty("creation_rules", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<TemplateRule>? CreationRules { get; set; } 

    [JsonProperty("todo_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<TemplateToDo>? TodoList { get; set; } 

    [JsonProperty("emailto", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EmailTo { get; set; } 

    [JsonProperty("emailcc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EmailCc { get; set; } 

    [JsonProperty("emailbcc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EmailBcc { get; set; } 

    [JsonProperty("emailsubject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Emailsubject { get; set; } 

    [JsonProperty("time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Time { get; set; } 

    [JsonProperty("disabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Disabled { get; set; } 

    [JsonProperty("lastcreated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Lastcreated { get; set; } 

    [JsonProperty("nextcreationdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? NextCreationdate { get; set; } 

    [JsonProperty("nextcreationdate_after_end", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? NextCreationdateAfterEnd { get; set; } 

    [JsonProperty("execution_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ExecutionType { get; set; } 

    [JsonProperty("startdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? StartDate { get; set; } 

    [JsonProperty("end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? EndDate { get; set; } 

    [JsonProperty("period", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Period { get; set; } 

    [JsonProperty("create_locked", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CreateLocked { get; set; } 

    [JsonProperty("one_ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OneTicketId { get; set; } 

    [JsonProperty("created_ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CreatedTicketId { get; set; } 

    [JsonProperty("approval_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ApprovalId { get; set; } 

    [JsonProperty("reportarea", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Reportarea { get; set; } 

    [JsonProperty("reportarea_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ReportareaName { get; set; } 

    [JsonProperty("restrictto_department_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? RestricttoDepartmentGuid { get; set; } 

    [JsonProperty("restrictto_team_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? RestricttoTeamGuid { get; set; } 

    [JsonProperty("clients", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Clients { get; set; } 

    [JsonProperty("tickettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? TicketTypeGuid { get; set; } 

    [JsonProperty("automationtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Automationtype { get; set; } 

    [JsonProperty("optionalservice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Optionalservice { get; set; } 

    [JsonProperty("optional_agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OptionalAgentId { get; set; } 

    [JsonProperty("optional_team", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OptionalTeam { get; set; } 

    [JsonProperty("optional_status_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OptionalStatusId { get; set; } 

    [JsonProperty("optional_tickettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OptionalTicketTypeId { get; set; } 

    [JsonProperty("optional_create_locked", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? OptionalCreateLocked { get; set; } 

    [JsonProperty("optional_defaultresourcetype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OptionalDefaultResourcetype { get; set; } 

    [JsonProperty("optional_excludefromsla", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OptionalExcludeFromSla { get; set; } 

    [JsonProperty("optional_customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomField>? OptionalCustomFields { get; set; } 

    [JsonProperty("optional_assets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AssetList>? OptionalAssets { get; set; } 

    [JsonProperty("optional_forwardinboundupdates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OptionalForwardinboundupdates { get; set; } 

    [JsonProperty("optional_showforusers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OptionalShowForUsers { get; set; } 

    [JsonProperty("optional_urgency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OptionalUrgency { get; set; } 

    [JsonProperty("optional_impact", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OptionalImpact { get; set; } 

    [JsonProperty("optional_workflow_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OptionalWorkflowId { get; set; } 

    [JsonProperty("optional_estimate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? OptionalEstimate { get; set; } 

    [JsonProperty("optional_category_1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OptionalCategory1 { get; set; } 

    [JsonProperty("optional_category_2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OptionalCategory2 { get; set; } 

    [JsonProperty("optional_category_3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OptionalCategory3 { get; set; } 

    [JsonProperty("optional_category_4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OptionalCategory4 { get; set; } 

    [JsonProperty("optional_priority_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OptionalPriorityId { get; set; } 

    [JsonProperty("optional_budgettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OptionalBudgetTypeId { get; set; } 

    [JsonProperty("optional_kb_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OptionalKbId { get; set; } 

    [JsonProperty("optional_service", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OptionalService { get; set; } 

    [JsonProperty("optional_service_details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OptionalServiceDetailsId { get; set; } 

    [JsonProperty("service", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Service { get; set; } 

    [JsonProperty("optional_sla_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OptionalSlaId { get; set; } 

}