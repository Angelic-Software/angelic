using System.CodeDom.Compiler;
using Angelic.Models.Configuration.Language;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Tickets.Workflows;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record FlowStages
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("flow_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? FlowId { get; set; } 

    [JsonProperty("sequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sequence { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("edit_outcome", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? EditOutcome { get; set; } 

    [JsonProperty("outcome_step", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OutcomeStep { get; set; } 

    [JsonProperty("translations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<LanguagePackTranslationsCustom>? Translations { get; set; } 

}