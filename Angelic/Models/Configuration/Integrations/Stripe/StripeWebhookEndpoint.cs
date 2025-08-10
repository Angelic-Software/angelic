using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.Stripe;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class StripeWebhookEndpoint
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Id { get; set; } 

    [JsonProperty("_object", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Object { get; set; } 

    [JsonProperty("created", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Created { get; set; } 

    [JsonProperty("enabled_events", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<string>? EnabledEvents { get; set; } 

    [JsonProperty("livemode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? LiveMode { get; set; } 

    [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Status { get; set; } 

    [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Url { get; set; } 

}