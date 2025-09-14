using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.Microsoft.Azure.AzureDevOps;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record DevOpsWebhookMessage
{
    [JsonProperty("text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Text { get; set; } 

    [JsonProperty("markdown", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Markdown { get; set; } 

}