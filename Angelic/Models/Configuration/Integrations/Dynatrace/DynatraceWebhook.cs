using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.Dynatrace;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record DynatraceWebhook
{
    [JsonProperty("state", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? State { get; set; } 

    [JsonProperty("problemID", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ProblemId { get; set; } 

    [JsonProperty("problemTitle", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ProblemTitle { get; set; } 

    [JsonProperty("problemSeverity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ProblemSeverity { get; set; } 

    [JsonProperty("problemImpact", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ProblemImpact { get; set; } 

    [JsonProperty("problemURL", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ProblemUrl { get; set; } 

    [JsonProperty("impactedEntities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<DynatraceEntity>? ImpactedEntities { get; set; } 

    [JsonProperty("impactedEntityNames", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ImpactedEntityNames { get; set; } 

    [JsonProperty("problemDetailsHTML", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ProblemDetailsHtml { get; set; } 

    [JsonProperty("problemDetailsText", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ProblemDetailsText { get; set; } 

    [JsonProperty("detailsId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DetailsId { get; set; } 

}