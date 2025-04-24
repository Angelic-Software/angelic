using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class NinjaWebhookDataMessage
{
    [JsonProperty("code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Code { get; set; } 

    [JsonProperty("_params", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public NinjaWebhookDataMessageParams? Params { get; set; } 

}