using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Emails.EmailTemplates.ContentTypes;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Parameter
{
    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("encoding", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Encoding.Encoding? Encoding { get; set; } 

    [Range(0, 2)]
    [JsonProperty("encodingMethod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? EncodingMethod { get; set; } 

    [JsonProperty("alwaysQuote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AlwaysQuote { get; set; } 

    [JsonProperty("value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Value { get; set; } 

}