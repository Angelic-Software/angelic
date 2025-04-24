using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class SOCWebhook
{
    [JsonProperty("phase", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Phase { get; set; } 

    [JsonProperty("entity_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Entity_id { get; set; } 

    [JsonProperty("subject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Subject { get; set; } 

    [JsonProperty("details", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Details { get; set; } 

    [JsonProperty("incident", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Incident { get; set; } 

    [JsonProperty("last_timestamp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public long? Last_timestamp { get; set; } 

    [JsonProperty("ack_at", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public long? Ack_at { get; set; } 

    [JsonProperty("ack_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Ack_by { get; set; } 

    [JsonProperty("ack_message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Ack_message { get; set; } 

    [JsonProperty("resolved_at", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public long? Resolved_at { get; set; } 

    [JsonProperty("resolved_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Resolved_by { get; set; } 

    [JsonProperty("text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Text { get; set; } 

    [JsonProperty("username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Username { get; set; } 

    [JsonProperty("resourceObject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public object? ResourceObject { get; set; } 

}