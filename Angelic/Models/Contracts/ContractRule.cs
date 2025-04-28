using System.CodeDom.Compiler;
using Angelic.Models.Configuration.Tickets.TicketRule;
using Newtonsoft.Json;

namespace Angelic.Models.Contracts;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ContractRule
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("sequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sequence { get; set; } 

    [JsonProperty("enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Enabled { get; set; } 

    [JsonProperty("user_under_client", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? UserUnderClient { get; set; } 

    [JsonProperty("outcome_contract_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OutcomeContractType { get; set; } 

    [JsonProperty("outcome_contract_subtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OutcomeContractSubtype { get; set; } 

    [JsonProperty("outcome_covered", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? OutcomeCovered { get; set; } 

    [JsonProperty("outcome_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OutcomeValue { get; set; } 

    [JsonProperty("outcome_end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? OutcomeEndDate { get; set; } 

    [JsonProperty("rule_criteria", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<TicketRulesCriteria>? RuleCriteria { get; set; } 

    [JsonProperty("is_matched", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsMatched { get; set; } 

    [JsonProperty("outcome_contract_type_display", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OutcomeContractTypeDisplay { get; set; } 

    [JsonProperty("outcome_contract_subtype_display", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OutcomeContractSubtypeDisplay { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}