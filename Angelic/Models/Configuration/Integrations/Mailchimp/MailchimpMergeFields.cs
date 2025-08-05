using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.Mailchimp;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class MailchimpMergeFields
{
    [JsonProperty("property1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public object? Property1 { get; set; } 

    [JsonProperty("property2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public object? Property2 { get; set; } 

    [JsonProperty("fname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? FName { get; set; } 

    [JsonProperty("lname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? LName { get; set; } 

}