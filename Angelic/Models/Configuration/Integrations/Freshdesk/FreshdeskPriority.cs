using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.Freshdesk;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record FreshdeskPriority
{
    [JsonProperty("respond_within", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RespondWithin { get; set; } 

    [JsonProperty("resolve_within", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ResolveWithin { get; set; } 

    [JsonProperty("next_respond_within", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? NextRespondWithin { get; set; } 

    [JsonProperty("business_hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? BusinessHours { get; set; } 

    [JsonProperty("escalation_enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? EscalationEnabled { get; set; } 

}