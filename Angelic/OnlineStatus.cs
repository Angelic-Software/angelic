using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class OnlineStatus
{
    [JsonProperty("techID", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TechID { get; set; } 

    [JsonProperty("lastOnlineDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? LastOnlineDate { get; set; } 

    [JsonProperty("isOnline", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsOnline { get; set; } 

    [JsonProperty("lastOnline", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? LastOnline { get; set; } 

    [JsonProperty("agent_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Agent_status { get; set; } 

    [JsonProperty("status_overidden", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Status_overidden { get; set; } 

    [JsonProperty("fetch_all", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Fetch_all { get; set; } 

    [JsonProperty("is_logout", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Is_logout { get; set; } 

    [JsonProperty("command", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Command { get; set; } 

    [JsonProperty("last_active", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Last_active { get; set; } 

    [JsonProperty("is_idle", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Is_idle { get; set; } 

}