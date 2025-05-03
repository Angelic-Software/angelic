using System.CodeDom.Compiler;
using Angelic.Models.Clients;
using Angelic.Models.Configuration.Integrations.Lookups;
using Angelic.Models.Configuration.TeamsAndAgents.Agents;
using Angelic.Models.Configuration.TeamsAndAgents.Agents.AgentNotifications;
using Angelic.Models.Configuration.Tickets.Workflows;
using Angelic.Models.Users;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Tickets.TicketRule;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class TicketRules
{
    [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Guid { get; set; } 

    [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Intent { get; set; } 

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("precedence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Precedence { get; set; } 

    [JsonProperty("use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Use { get; set; } 

    [JsonProperty("stopmatching", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Stopmatching { get; set; } 

    [JsonProperty("new_agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? NewAgentId { get; set; } 

    [JsonProperty("new_agent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewAgentName { get; set; } 

    [JsonProperty("new_team", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewTeam { get; set; } 

    [JsonProperty("new_priority_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? NewPriorityId { get; set; } 

    [JsonProperty("new_status_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? NewStatusId { get; set; } 

    [JsonProperty("newstatus_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? NewStatusGuid { get; set; } 

    [JsonProperty("new_sla_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? NewSlaId { get; set; } 

    [JsonProperty("new_sla_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? NewSlaGuid { get; set; } 

    [JsonProperty("new_category_1_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? NewCategory1Id { get; set; } 

    [JsonProperty("new_category_1_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? NewCategory1Guid { get; set; } 

    [JsonProperty("new_category_1_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewCategory1Name { get; set; } 

    [JsonProperty("new_product_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? NewProductId { get; set; } 

    [JsonProperty("new_product_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewProductName { get; set; } 

    [JsonProperty("new_workflow_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? NewWorkflowId { get; set; } 

    [JsonProperty("newworkflow_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? NewworkflowGuid { get; set; } 

    [JsonProperty("new_workflow_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewWorkflowName { get; set; } 

    [JsonProperty("dontshownotification", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DontShownotification { get; set; } 

    [JsonProperty("criteria", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<TicketRulesCriteria>? Criteria { get; set; } 

    [JsonProperty("outcomes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<TicketRulesOutcome>? Outcomes { get; set; } 

    [JsonProperty("_domatch", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DoMatch { get; set; } 

    [JsonProperty("user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public User? User { get; set; } 

    [JsonProperty("matched_rule_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MatchedRuleCount { get; set; } 

    [JsonProperty("matched_ids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MatchedIds { get; set; } 

    [JsonProperty("outcome_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OutcomeId { get; set; } 

    [JsonProperty("outcome_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OutcomeName { get; set; } 

    [JsonProperty("new_category_2_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? NewCategory2Id { get; set; } 

    [JsonProperty("new_category_2_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? NewCategory2Guid { get; set; } 

    [JsonProperty("new_category_2_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewCategory2Name { get; set; } 

    [JsonProperty("new_category_3_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? NewCategory3Id { get; set; } 

    [JsonProperty("new_category_3_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? NewCategory3Guid { get; set; } 

    [JsonProperty("new_category_3_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewCategory3Name { get; set; } 

    [JsonProperty("new_category_4_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? NewCategory4Id { get; set; } 

    [JsonProperty("new_category_4_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? NewCategory4Guid { get; set; } 

    [JsonProperty("new_category_4_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewCategory4Name { get; set; } 

    [JsonProperty("script_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ScriptId { get; set; } 

    [JsonProperty("script_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ScriptName { get; set; } 

    [JsonProperty("rule_ids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<int>? RuleIds { get; set; } 

    [JsonProperty("new_template_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? NewTemplateId { get; set; } 

    [JsonProperty("newtemplate_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? NewtemplateGuid { get; set; } 

    [JsonProperty("new_template_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewTemplateName { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("popupmsg", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Popupmsg { get; set; } 

    [JsonProperty("popup_notes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<PopupNote>? PopupNotes { get; set; } 

    [JsonProperty("flowdetail_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? FlowdetailId { get; set; } 

    [JsonProperty("batch_size", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? BatchSize { get; set; } 

    [JsonProperty("batch_sleep", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? BatchSleep { get; set; } 

    [JsonProperty("access_control", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AccessControl>? AccessControl { get; set; } 

    [JsonProperty("access_control_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AccessControlLevel { get; set; } 

    [JsonProperty("events", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AgentNotification>? Events { get; set; } 

    [JsonProperty("new_colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewColour { get; set; } 

    [JsonProperty("set_colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? SetColour { get; set; } 

    [JsonProperty("active", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Active { get; set; } 

    [JsonProperty("olas", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<WorkflowTarget>? Olas { get; set; } 

    [JsonProperty("database_lookups", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<DatabaseLookup>? DatabaseLookups { get; set; } 

}