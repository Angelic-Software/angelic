using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.TeamsAndAgents;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ImpersonationRequest
{
    [JsonProperty("irid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Irid { get; set; } 

    [JsonProperty("requestor", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Requestor { get; set; } 

    [JsonProperty("agent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Agent { get; set; } 

    [JsonProperty("user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? User { get; set; } 

    [JsonProperty("timestamp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Timestamp { get; set; } 

    [JsonProperty("enc_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? EncId { get; set; } 

    [JsonProperty("token_used", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? TokenUsed { get; set; } 

    [JsonProperty("used_timestamp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? UsedTimestamp { get; set; } 

    [JsonProperty("jwt", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Jwt { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}