using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.Meta.Facebook;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class FacebookWebhook
{
    [JsonProperty("object", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Object { get; set; } 

    [JsonProperty("entry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<FacebookWebhookEntry>? Entry { get; set; } 

}