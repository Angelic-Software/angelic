using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class FacebookMessageContent
{
    [JsonProperty("mid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Mid { get; set; } 

    [JsonProperty("text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Text { get; set; } 

    [JsonProperty("attachments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<FacebookMessageAttachment>? Attachments { get; set; } 

    [JsonProperty("is_deleted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Is_deleted { get; set; } 

    [JsonProperty("is_echo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Is_echo { get; set; } 

    [JsonProperty("is_unsupported", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Is_unsupported { get; set; } 

}