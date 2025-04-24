using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class FlowDetail
{
    [JsonProperty("fdid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Fdid { get; set; } 

    [JsonProperty("step_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Step_id { get; set; } 

    [JsonProperty("flow_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Flow_id { get; set; } 

    [JsonProperty("chatprofile_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Chatprofile_id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("isstart", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Isstart { get; set; } 

    [JsonProperty("isend", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Isend { get; set; } 

    [JsonProperty("islaststep", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Islaststep { get; set; } 

    [JsonProperty("old_diagram_x", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Old_diagram_x { get; set; } 

    [JsonProperty("old_diagram_y", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Old_diagram_y { get; set; } 

    [JsonProperty("new_flow_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? New_flow_id { get; set; } 

    [JsonProperty("stage_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Stage_number { get; set; } 

    [JsonProperty("pipeline_stage_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Pipeline_stage_id { get; set; } 

    [JsonProperty("pipeline_stage_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Pipeline_stage_name { get; set; } 

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
    public int? Auto_action { get; set; } 

    [JsonProperty("auto_action_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Auto_action_type { get; set; } 

    [JsonProperty("auto_action_type_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Auto_action_type_guid { get; set; } 

    [JsonProperty("input_field_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Input_field_id { get; set; } 

    [JsonProperty("newticket_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Newticket_type { get; set; } 

    [JsonProperty("newticket_tickettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Newticket_tickettype_id { get; set; } 

    [JsonProperty("newticket_template_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Newticket_template_id { get; set; } 

    [JsonProperty("step_conditions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AutoassignCriteria>? Step_conditions { get; set; } 

    [JsonProperty("chat_teams", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<SectionDetail_List>? Chat_teams { get; set; } 

    [JsonProperty("rules", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Autoassign>? Rules { get; set; } 

    [JsonProperty("chat_image_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Chat_image_type { get; set; } 

    [JsonProperty("note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(500)]
    public string? Note { get; set; } 

    [JsonProperty("newticket_service_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Newticket_service_id { get; set; } 

    [JsonProperty("content", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(4000)]
    public string? Content { get; set; } 

    [JsonProperty("ai_model", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(50)]
    public string? Ai_model { get; set; } 

    [JsonProperty("virtual_agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(50)]
    public string? Virtual_agent_id { get; set; } 

    [JsonProperty("start_new_chat_flow_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Start_new_chat_flow_id { get; set; } 

    [JsonProperty("iteration_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Iteration_type { get; set; } 

    [JsonProperty("iteration_batch_size", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Iteration_batch_size { get; set; } 

    [JsonProperty("use_batch_response", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Use_batch_response { get; set; } 

    [JsonProperty("newticket_sendlink", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Newticket_sendlink { get; set; } 

    [JsonProperty("output_variables", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<OutboundIntegrationMethodValue>? Output_variables { get; set; } 

    [JsonProperty("runbook_variable_mappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<OutboundIntegrationMethodValue>? Runbook_variable_mappings { get; set; } 

    [JsonProperty("chat_input_suggestions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ChatInputSuggestion>? Chat_input_suggestions { get; set; } 

    [JsonProperty("chat_step_questions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ChatStepQuestion>? Chat_step_questions { get; set; } 

    [JsonProperty("translations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<LanguagePackTranslationsCustom>? Translations { get; set; } 

}