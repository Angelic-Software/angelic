using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Agent;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class AgentRequestType
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AgentId { get; set; } 

    [JsonProperty("agent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AgentName { get; set; } 

    [JsonProperty("tickettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TickettypeId { get; set; } 

    [JsonProperty("tickettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TickettypeName { get; set; } 

    [JsonProperty("role_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RoleId { get; set; } 

    [JsonProperty("role_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RoleName { get; set; } 

    [JsonProperty("cancreate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Cancreate { get; set; } 

    [JsonProperty("canview", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Canview { get; set; } 

    [JsonProperty("canedit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Canedit { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}