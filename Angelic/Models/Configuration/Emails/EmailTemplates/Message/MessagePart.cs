using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Emails.EmailTemplates.Message;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record MessagePart
{
    [JsonProperty("body", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public MessagePartBody? Body { get; set; } 

    [JsonProperty("filename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Filename { get; set; } 

    [JsonProperty("headers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<MessagePartHeader>? Headers { get; set; } 

    [JsonProperty("mimeType", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MimeType { get; set; } 

    [JsonProperty("partId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PartId { get; set; } 

    [JsonProperty("parts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<MessagePart>? Parts { get; set; } 

    [JsonProperty("eTag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ETag { get; set; } 

}