using System.CodeDom.Compiler;
using Angelic.Attributes;
using Angelic.Models.KeyPairs;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Ai;

[HasEndpoint("AISuggestion")]
[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record AiSuggestion
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; }

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; }

    [JsonProperty("precedence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Precedence { get; set; }
    
    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Type { get; set; }
    
    [JsonProperty("ticket_types", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<LongIdNameKeyPair>? TicketTypes { get; set; }
    
    [JsonProperty("auto_apply", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AutoApply { get; set; }
    
    [JsonProperty("min_score", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? MinScore { get; set; }
    
    [JsonProperty("min_matches", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MinMatches { get; set; }
    
    [JsonProperty("condition_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ConditionNumber { get; set; }
    
    [JsonProperty("condition_percentage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? ConditionPercentage { get; set; }
    
    [JsonProperty("outcome_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OutcomeId { get; set; }
    
    [JsonProperty("outcome_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OutcomeName { get; set; }
    
    [JsonProperty("template_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TemplateId { get; set; }
    
    [JsonProperty("template_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TemplateName { get; set; }
    
    [JsonProperty("summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Summary { get; set; }
    
    [JsonProperty("ticket_open_closed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TicketOpenClosed { get; set; }
    
    [JsonProperty("last_x_days", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? LastXDays { get; set; }
    
    [JsonProperty("condition_entities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<LongIdNameKeyPair>? ConditionEntities { get; set; }
    
    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; }
}
