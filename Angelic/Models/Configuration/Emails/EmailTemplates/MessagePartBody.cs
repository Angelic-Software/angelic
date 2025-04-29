using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Emails.EmailTemplates;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class MessagePartBody
{
    [JsonProperty("attachmentId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AttachmentId { get; set; } 

    [JsonProperty("data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Data { get; set; } 

    [JsonProperty("size", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Size { get; set; } 

    [JsonProperty("eTag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ETag { get; set; } 

}