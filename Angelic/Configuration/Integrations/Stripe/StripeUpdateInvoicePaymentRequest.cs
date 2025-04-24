using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class StripeUpdateInvoicePaymentRequest
{
    [JsonProperty("payment_intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PaymentIntent { get; set; } 

    [JsonProperty("payment_intent_client_secret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PaymentIntentClientSecret { get; set; } 

}