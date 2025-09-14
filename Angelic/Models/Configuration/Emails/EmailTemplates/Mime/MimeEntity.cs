using System.CodeDom.Compiler;
using Angelic.Models.Configuration.Emails.EmailTemplates.ContentTypes;
using Angelic.Models.Configuration.Emails.EmailTemplates.Message;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Emails.EmailTemplates.Mime;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record MimeEntity
{
    [JsonProperty("headers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Header>? Headers { get; set; } 

    [JsonProperty("contentDisposition", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ContentDisposition? ContentDisposition { get; set; } 

    [JsonProperty("contentType", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ContentType? ContentType { get; set; } 

    [JsonProperty("contentBase", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Uri? ContentBase { get; set; } 

    [JsonProperty("contentLocation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Uri? ContentLocation { get; set; } 

    [JsonProperty("contentId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ContentId { get; set; } 

    [JsonProperty("isAttachment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsAttachment { get; set; } 

}