using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.TeamsAndAgents;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class OnlineStatus
{
    [JsonProperty("techID", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TechId { get; set; } 

    [JsonProperty("lastOnlineDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? LastOnlineDate { get; set; } 

    [JsonProperty("isOnline", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsOnline { get; set; } 

    [JsonProperty("lastOnline", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? LastOnline { get; set; } 

    [JsonProperty("agent_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AgentStatus { get; set; } 

    [JsonProperty("status_overidden", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? StatusOveridden { get; set; } 

    [JsonProperty("fetch_all", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? FetchAll { get; set; } 

    [JsonProperty("is_logout", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsLogout { get; set; } 

    [JsonProperty("command", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Command { get; set; } 

    [JsonProperty("last_active", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? LastActive { get; set; } 

    [JsonProperty("is_idle", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsIdle { get; set; } 

}