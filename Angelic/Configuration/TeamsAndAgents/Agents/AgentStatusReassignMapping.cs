using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Configuration.TeamsAndAgents.Agents;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class AgentStatusReassignMapping
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; }

    [JsonProperty("status_from", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? StatusFrom { get; set; }

    [JsonProperty("status_to", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? StatusTo { get; set; }

    [JsonProperty("reassign_to", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ReassignTo { get; set; }
}
