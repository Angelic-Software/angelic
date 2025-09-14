using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Tickets.TicketRule;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record TicketRulesOutcome
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("rule_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RuleId { get; set; } 

    [JsonProperty("autoassign_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? AutoAssignGuid { get; set; } 

    [JsonProperty("fieldid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? FieldId { get; set; } 

    [JsonProperty("fieldname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? FieldName { get; set; } 

    [JsonProperty("value_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ValueType { get; set; } 

    [JsonProperty("value_int", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ValueInt { get; set; } 

    [JsonProperty("value_string", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ValueString { get; set; } 

    [JsonProperty("value_datetime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? ValueDateTime { get; set; } 

    [JsonProperty("value_float", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? ValueFloat { get; set; } 

    [JsonProperty("value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public object? Value { get; set; } 

    [JsonProperty("value_display", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ValueDisplay { get; set; } 

    [JsonProperty("value_type_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ValueTypeId { get; set; } 

    [JsonProperty("is_dummy", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsDummy { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}