using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class FreshdeskStats
{
    [JsonProperty("agent_responded_at", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Agent_responded_at { get; set; } 

    [JsonProperty("responder_responded_at", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Responder_responded_at { get; set; } 

    [JsonProperty("first_responded_at", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? First_responded_at { get; set; } 

    [JsonProperty("status_updated_at", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Status_updated_at { get; set; } 

    [JsonProperty("reopened_at", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Reopened_at { get; set; } 

    [JsonProperty("resolved_at", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Resolved_at { get; set; } 

    [JsonProperty("closed_at", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Closed_at { get; set; } 

    [JsonProperty("pending_since", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Pending_since { get; set; } 

}