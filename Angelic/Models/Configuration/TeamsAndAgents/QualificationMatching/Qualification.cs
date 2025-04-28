using System.CodeDom.Compiler;
using Angelic.Models.Configuration.TeamsAndAgents.Agents;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.TeamsAndAgents;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Qualification
{
    [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Guid { get; set; } 

    [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Intent { get; set; } 

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("weight", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Weight { get; set; } 

    [JsonProperty("mustmatch", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Mustmatch { get; set; } 

    [JsonProperty("criteria", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<QualificationCategory>? Criteria { get; set; } 

    [JsonProperty("agents", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AgentQualification>? Agents { get; set; } 

    [JsonProperty("agent_matched", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AgentMatched { get; set; } 

    [JsonProperty("_domatch", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Domatch { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}