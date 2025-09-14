using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.Mailchimp;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record MailchimpLinks
{
    [JsonProperty("rel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Rel { get; set; } 

    [JsonProperty("href", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Href { get; set; } 

    [JsonProperty("method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Method { get; set; } 

    [JsonProperty("targetSchema", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TargetSchema { get; set; } 

    [JsonProperty("schema", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Schema { get; set; } 

}