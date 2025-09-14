using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Tickets.TicketRule;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record TicketRulesCriteria
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("rule_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RuleId { get; set; } 

    [JsonProperty("autoassign_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? AutoAssignGuid { get; set; } 

    [JsonProperty("qualification_criteria_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? QualificationCriteriaId { get; set; } 

    [JsonProperty("fieldname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? FieldName { get; set; } 

    [JsonProperty("value_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ValueType { get; set; } 

    [JsonProperty("value_type_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ValueTypeId { get; set; } 

    [JsonProperty("value_int", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ValueInt { get; set; } 

    [JsonProperty("valueint_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? ValueIntGuid { get; set; } 

    [JsonProperty("value_string", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ValueString { get; set; } 

    [JsonProperty("value_datetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? ValueDateTime { get; set; } 

    [JsonProperty("partialmatch", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? PartialMatch { get; set; } 

    [JsonProperty("value_float", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? ValueFloat { get; set; } 

    [JsonProperty("matchseparatedvalues", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? MatchSeparatedValues { get; set; } 

    [JsonProperty("value_display", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ValueDisplay { get; set; } 

    [JsonProperty("alt_value_display", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AltValueDisplay { get; set; } 

    [JsonProperty("tablename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TableName { get; set; } 

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Type { get; set; } 

    [JsonProperty("flowsubdetails_criteria_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? FlowSubDetailsCriteriaId { get; set; } 

    [JsonProperty("use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Use { get; set; } 

    [JsonProperty("chatprofile_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ChatProfileId { get; set; } 

    [JsonProperty("chatprofile_flow_seq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ChatProfileFlowSeq { get; set; } 

    [JsonProperty("timezonestring", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TimeZoneString { get; set; } 

    [JsonProperty("match_after_start", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? MatchAfterStart { get; set; } 

    [JsonProperty("match_after_target", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? MatchAfterTarget { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("stdid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? StdId { get; set; } 

    [JsonProperty("contract_rule_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ContractRuleId { get; set; } 

    [JsonProperty("utcoffset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? UtcOffset { get; set; } 

    [JsonProperty("eventrule_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? EventRuleId { get; set; } 

    [JsonProperty("eventrule_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? EventRuleGuid { get; set; } 

}