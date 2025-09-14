using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.Device42;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record Device42Webhook
{
    [JsonProperty("category", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Category { get; set; } 

    [JsonProperty("user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? User { get; set; } 

    [JsonProperty("action", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Action { get; set; } 

    [JsonProperty("data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Device42WebhookData? Data { get; set; } 

    [JsonProperty("resourceObject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public object? ResourceObject { get; set; } 

}