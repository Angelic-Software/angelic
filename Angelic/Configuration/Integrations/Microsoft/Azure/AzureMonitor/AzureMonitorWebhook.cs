using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Configuration.Integrations.Microsoft.Azure.AzureMonitor;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class AzureMonitorWebhook
{
    [JsonProperty("schemaId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SchemaId { get; set; } 

    [JsonProperty("data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public AzureMonitorData? Data { get; set; } 

}