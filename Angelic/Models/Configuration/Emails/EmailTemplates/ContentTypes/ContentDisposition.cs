using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Emails.EmailTemplates.ContentTypes;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ContentDisposition
{
    [JsonProperty("disposition", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Disposition { get; set; } 

    [JsonProperty("isAttachment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsAttachment { get; set; } 

    [JsonProperty("parameters", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Parameter>? Parameters { get; set; } 

    [JsonProperty("fileName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? FileName { get; set; } 

    [JsonProperty("creationDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? CreationDate { get; set; } 

    [JsonProperty("modificationDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? ModificationDate { get; set; } 

    [JsonProperty("readDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? ReadDate { get; set; } 

    [JsonProperty("size", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public long? Size { get; set; } 

}