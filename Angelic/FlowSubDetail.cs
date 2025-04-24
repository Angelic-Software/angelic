using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class FlowSubDetail
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("flow_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Flow_id { get; set; } 

    [JsonProperty("chatprofile_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Chatprofile_id { get; set; } 

    [JsonProperty("start_step", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Start_step { get; set; } 

    [JsonProperty("end_step", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? End_step { get; set; } 

    [JsonProperty("old_diagram_startpos", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Old_diagram_startpos { get; set; } 

    [JsonProperty("old_diagram_endpos", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Old_diagram_endpos { get; set; } 

    [JsonProperty("action_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Action_type { get; set; } 

    [JsonProperty("action_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Action_id { get; set; } 

    [JsonProperty("action_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Action_guid { get; set; } 

    [JsonProperty("action_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Action_name { get; set; } 

    [JsonProperty("action_colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Action_colour { get; set; } 

    [JsonProperty("action_outcome", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Action_outcome { get; set; } 

    [JsonProperty("time_limit_mins", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Time_limit_mins { get; set; } 

    [JsonProperty("use_work_hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Use_work_hours { get; set; } 

    [JsonProperty("time_limit_action_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Time_limit_action_id { get; set; } 

    [JsonProperty("time_limit_action_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Time_limit_action_guid { get; set; } 

    [JsonProperty("time_limit_action_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Time_limit_action_name { get; set; } 

    [JsonProperty("automation_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Automation_type { get; set; } 

    [JsonProperty("automation_action_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Automation_action_id { get; set; } 

    [JsonProperty("automation_action_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Automation_action_guid { get; set; } 

    [JsonProperty("automation_action_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Automation_action_name { get; set; } 

    [JsonProperty("automation_runbook_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Automation_runbook_id { get; set; } 

    [JsonProperty("automation_runbook_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Automation_runbook_name { get; set; } 

    [JsonProperty("automation_execution_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Automation_execution_type { get; set; } 

    [JsonProperty("seq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Seq { get; set; } 

    [JsonProperty("approval_result", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Approval_result { get; set; } 

    [JsonProperty("restricted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Restricted { get; set; } 

    [JsonProperty("conditions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AutoassignCriteria>? Conditions { get; set; } 

    [JsonProperty("conditions_exec", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AutoassignCriteria>? Conditions_exec { get; set; } 

    [JsonProperty("restrictions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<FlowSubDetailRestriction>? Restrictions { get; set; } 

    [JsonProperty("todo_group_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Todo_group_id { get; set; } 

    [JsonProperty("todo_group_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Todo_group_name { get; set; } 

    [JsonProperty("translations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<LanguagePackTranslationsCustom>? Translations { get; set; } 

    [JsonProperty("chat_selection_order", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Chat_selection_order { get; set; } 

    [JsonProperty("number_of_days", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Number_of_days { get; set; } 

    [JsonProperty("date_field_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Date_field_id { get; set; } 

}