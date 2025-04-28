using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.TeamsAndAgents.Agents;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class AgentPresenceRule
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("seq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Seq { get; set; } 

    [JsonProperty("activity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Activity { get; set; } 

    [JsonProperty("availability", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Availability { get; set; } 

    [JsonProperty("outcome", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Outcome { get; set; } 

    [JsonProperty("must_be_online", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? MustBeOnline { get; set; } 

}