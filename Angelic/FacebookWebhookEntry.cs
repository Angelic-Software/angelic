using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class FacebookWebhookEntry
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Id { get; set; } 

    [JsonProperty("time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public long? Time { get; set; } 

    [JsonProperty("messaging", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<FacebookMessage>? Messaging { get; set; } 

    [JsonProperty("changes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<FacebookWebhookChange>? Changes { get; set; } 

}