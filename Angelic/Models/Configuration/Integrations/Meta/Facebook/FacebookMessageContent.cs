using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.Meta.Facebook;

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
    public bool? IsDeleted { get; set; } 

    [JsonProperty("is_echo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsEcho { get; set; } 

    [JsonProperty("is_unsupported", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsUnsupported { get; set; } 

}