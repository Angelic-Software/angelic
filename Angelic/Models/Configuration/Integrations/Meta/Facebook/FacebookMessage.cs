using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.Meta.Facebook;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record FacebookMessage
{
    [JsonProperty("sender", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public FacebookKeyPair? Sender { get; set; } 

    [JsonProperty("recipient", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public FacebookKeyPair? Recipient { get; set; } 

    [JsonProperty("timestamp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public long? Timestamp { get; set; } 

    [JsonProperty("message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public FacebookMessageContent? Message { get; set; } 

}