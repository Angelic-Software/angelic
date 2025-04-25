using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Configuration.Tickets.Templates;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class TemplateRule
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("parent_template_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ParentTemplateId { get; set; } 

    [JsonProperty("child_template_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ChildTemplateId { get; set; } 

    [JsonProperty("usage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Usage { get; set; } 

    [JsonProperty("rule_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RuleType { get; set; } 

    [JsonProperty("createonchildclose_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CreateonchildcloseId { get; set; } 

    [JsonProperty("createonchildclose_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CreateonchildcloseName { get; set; } 

    [JsonProperty("working_days", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? WorkingDays { get; set; } 

    [JsonProperty("outcome_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OutcomeId { get; set; } 

    [JsonProperty("outcome_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OutcomeName { get; set; } 

    [JsonProperty("field_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? FieldId { get; set; } 

    [JsonProperty("field_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? FieldValue { get; set; } 

    [JsonProperty("field_value_string", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? FieldValueString { get; set; } 

    [JsonProperty("field_contains", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? FieldContains { get; set; } 

    [JsonProperty("field_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? FieldName { get; set; } 

    [JsonProperty("approvalstatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Approvalstatus { get; set; } 

    [JsonProperty("group_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? GroupId { get; set; } 

    [JsonProperty("optionalservice_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OptionalserviceId { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}