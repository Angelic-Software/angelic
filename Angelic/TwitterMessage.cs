using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class TwitterMessage
{
    [JsonProperty("target", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public TwitterMessageTarget? Target { get; set; } 

    [JsonProperty("sender_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Sender_id { get; set; } 

    [JsonProperty("source_app_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Source_app_id { get; set; } 

    [JsonProperty("message_data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public TwitterMessageData? Message_data { get; set; } 

}