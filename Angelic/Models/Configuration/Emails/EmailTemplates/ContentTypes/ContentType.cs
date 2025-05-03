using System.CodeDom.Compiler;
using Angelic.Models.Configuration.Emails.EmailTemplates.ContentTypes;
using Angelic.Models.Configuration.Emails.EmailTemplates.Encoder;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Emails.EmailTemplates;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ContentType
{
    [JsonProperty("mediaType", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MediaType { get; set; } 

    [JsonProperty("mediaSubtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MediaSubtype { get; set; } 

    [JsonProperty("parameters", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Parameter>? Parameters { get; set; } 

    [JsonProperty("boundary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Boundary { get; set; } 

    [JsonProperty("charset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Charset { get; set; } 

    [JsonProperty("charsetEncoding", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Encoding? CharsetEncoding { get; set; } 

    [JsonProperty("format", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Format { get; set; } 

    [JsonProperty("mimeType", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MimeType { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

}