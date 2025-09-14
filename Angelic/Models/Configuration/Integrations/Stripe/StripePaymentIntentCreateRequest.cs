using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.Stripe;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record StripePaymentIntentCreateRequest
{
    [JsonProperty("items", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<StripeItem>? Items { get; set; } 

    [JsonProperty("cardid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CardId { get; set; } 

}