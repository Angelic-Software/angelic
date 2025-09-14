using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Emails.EmailTemplates.Message;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record Header
{
    [JsonProperty("offset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public long? Offset { get; set; } 

    [JsonProperty("field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Field { get; set; } 

    [Range(-1, 130)]
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("rawField", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public byte[]? RawField { get; set; } 

    [JsonProperty("rawValue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public byte[]? RawValue { get; set; } 

    [JsonProperty("value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Value { get; set; } 

}