using System.CodeDom.Compiler;
using Angelic.Chat;
using Angelic.Configuration.Integrations;
using Angelic.Configuration.TicketRules;
using Newtonsoft.Json;

namespace Angelic.Configuration.Workflow;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class FlowDetail
{
    [JsonProperty("fdid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Fdid { get; set; } 

    [JsonProperty("step_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? StepId { get; set; } 

    [JsonProperty("flow_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? FlowId { get; set; } 

    [JsonProperty("chatprofile_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ChatprofileId { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("isstart", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Isstart { get; set; } 

    [JsonProperty("isend", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Isend { get; set; } 

    [JsonProperty("islaststep", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Islaststep { get; set; } 

    [JsonProperty("old_diagram_x", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OldDiagramX { get; set; } 

    [JsonProperty("old_diagram_y", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OldDiagramY { get; set; } 

    [JsonProperty("new_flow_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? NewFlowId { get; set; } 

    [JsonProperty("stage_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? StageNumber { get; set; } 

    [JsonProperty("pipeline_stage_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PipelineStageId { get; set; } 

    [JsonProperty("pipeline_stage_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PipelineStageName { get; set; } 

    [JsonProperty("actions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<FlowSubDetail>? Actions { get; set; } 

    [JsonProperty("overrideprobabiliywhenatthisstep", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Overrideprobabiliywhenatthisstep { get; set; } 

    [JsonProperty("probabilityoverridevalue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Probabilityoverridevalue { get; set; } 

    [JsonProperty("steptype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Steptype { get; set; } 

    [JsonProperty("message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(4000)]
    public string? Message { get; set; } 

    [JsonProperty("message2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(4000)]
    public string? Message2 { get; set; } 

    [JsonProperty("message3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(4000)]
    public string? Message3 { get; set; } 

    [JsonProperty("auto_action", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AutoAction { get; set; } 

    [JsonProperty("auto_action_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AutoActionType { get; set; } 

    [JsonProperty("auto_action_type_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? AutoActionTypeGuid { get; set; } 

    [JsonProperty("input_field_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? InputFieldId { get; set; } 

    [JsonProperty("newticket_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? NewticketType { get; set; } 

    [JsonProperty("newticket_tickettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? NewticketTickettypeId { get; set; } 

    [JsonProperty("newticket_template_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? NewticketTemplateId { get; set; } 

    [JsonProperty("step_conditions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<TicketRulesCriteria>? StepConditions { get; set; } 

    [JsonProperty("chat_teams", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<TeamList>? ChatTeams { get; set; } 

    [JsonProperty("rules", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<TicketRules.TicketRules>? Rules { get; set; } 

    [JsonProperty("chat_image_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ChatImageType { get; set; } 

    [JsonProperty("note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(500)]
    public string? Note { get; set; } 

    [JsonProperty("newticket_service_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? NewticketServiceId { get; set; } 

    [JsonProperty("content", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(4000)]
    public string? Content { get; set; } 

    [JsonProperty("ai_model", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(50)]
    public string? AiModel { get; set; } 

    [JsonProperty("virtual_agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(50)]
    public string? VirtualAgentId { get; set; } 

    [JsonProperty("start_new_chat_flow_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? StartNewChatFlowId { get; set; } 

    [JsonProperty("iteration_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? IterationType { get; set; } 

    [JsonProperty("iteration_batch_size", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? IterationBatchSize { get; set; } 

    [JsonProperty("use_batch_response", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? UseBatchResponse { get; set; } 

    [JsonProperty("newticket_sendlink", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? NewticketSendlink { get; set; } 

    [JsonProperty("output_variables", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomIntegrationMethodValue>? OutputVariables { get; set; } 

    [JsonProperty("runbook_variable_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomIntegrationMethodValue>? RunbookVariableMappings { get; set; } 

    [JsonProperty("chat_input_suggestions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ChatInputSuggestion>? ChatInputSuggestions { get; set; } 

    [JsonProperty("chat_step_questions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ChatStepQuestion>? ChatStepQuestions { get; set; } 

    [JsonProperty("translations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<LanguagePackTranslationsCustom>? Translations { get; set; } 

}