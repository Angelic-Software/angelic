using System.CodeDom.Compiler;
using Angelic.Models.Configuration.Language;
using Angelic.Models.Configuration.Tickets.TicketRule;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Tickets.Workflows;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class FlowSubDetail
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("flow_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? FlowId { get; set; } 

    [JsonProperty("chatprofile_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ChatprofileId { get; set; } 

    [JsonProperty("start_step", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? StartStep { get; set; } 

    [JsonProperty("end_step", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? EndStep { get; set; } 

    [JsonProperty("old_diagram_startpos", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OldDiagramStartpos { get; set; } 

    [JsonProperty("old_diagram_endpos", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OldDiagramEndpos { get; set; } 

    [JsonProperty("action_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ActionType { get; set; } 

    [JsonProperty("action_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ActionId { get; set; } 

    [JsonProperty("action_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? ActionGuid { get; set; } 

    [JsonProperty("action_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ActionName { get; set; } 

    [JsonProperty("action_colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ActionColour { get; set; } 

    [JsonProperty("action_outcome", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ActionOutcome { get; set; } 

    [JsonProperty("time_limit_mins", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? TimeLimitMins { get; set; } 

    [JsonProperty("use_work_hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? UseWorkHours { get; set; } 

    [JsonProperty("time_limit_action_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TimeLimitActionId { get; set; } 

    [JsonProperty("time_limit_action_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? TimeLimitActionGuid { get; set; } 

    [JsonProperty("time_limit_action_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TimeLimitActionName { get; set; } 

    [JsonProperty("automation_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AutomationType { get; set; } 

    [JsonProperty("automation_action_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AutomationActionId { get; set; } 

    [JsonProperty("automation_action_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? AutomationActionGuid { get; set; } 

    [JsonProperty("automation_action_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AutomationActionName { get; set; } 

    [JsonProperty("automation_runbook_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AutomationRunbookId { get; set; } 

    [JsonProperty("automation_runbook_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AutomationRunbookName { get; set; } 

    [JsonProperty("automation_execution_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AutomationExecutionType { get; set; } 

    [JsonProperty("seq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Seq { get; set; } 

    [JsonProperty("approval_result", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ApprovalResult { get; set; } 

    [JsonProperty("restricted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Restricted { get; set; } 

    [JsonProperty("conditions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<TicketRulesCriteria>? Conditions { get; set; } 

    [JsonProperty("conditions_exec", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<TicketRulesCriteria>? ConditionsExec { get; set; } 

    [JsonProperty("restrictions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<FlowSubDetailRestriction>? Restrictions { get; set; } 

    [JsonProperty("todo_group_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TodoGroupId { get; set; } 

    [JsonProperty("todo_group_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TodoGroupName { get; set; } 

    [JsonProperty("translations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<LanguagePackTranslationsCustom>? Translations { get; set; } 

    [JsonProperty("chat_selection_order", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ChatSelectionOrder { get; set; } 

    [JsonProperty("number_of_days", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? NumberOfDays { get; set; } 

    [JsonProperty("date_field_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DateFieldId { get; set; } 

}