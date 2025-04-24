using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class FreshdeskStats
{
    [JsonProperty("agent_responded_at", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AgentRespondedAt { get; set; } 

    [JsonProperty("responder_responded_at", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ResponderRespondedAt { get; set; } 

    [JsonProperty("first_responded_at", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? FirstRespondedAt { get; set; } 

    [JsonProperty("status_updated_at", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? StatusUpdatedAt { get; set; } 

    [JsonProperty("reopened_at", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ReopenedAt { get; set; } 

    [JsonProperty("resolved_at", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ResolvedAt { get; set; } 

    [JsonProperty("closed_at", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ClosedAt { get; set; } 

    [JsonProperty("pending_since", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PendingSince { get; set; } 

}