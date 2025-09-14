using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record LoginToken
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Type { get; set; } 

    [JsonProperty("timestamp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Timestamp { get; set; } 

    [JsonProperty("verifier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Verifier { get; set; } 

    [JsonProperty("token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Token { get; set; } 

    [JsonProperty("enc_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? EncId { get; set; } 

    [JsonProperty("token_used", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? TokenUsed { get; set; } 

    [JsonProperty("used_timestamp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? UsedTimestamp { get; set; } 

    [JsonProperty("used_userid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? UsedUserid { get; set; } 

    [JsonProperty("jwt", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Jwt { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}