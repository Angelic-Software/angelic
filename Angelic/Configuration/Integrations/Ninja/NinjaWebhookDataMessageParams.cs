using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Configuration.Integrations.Ninja;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class NinjaWebhookDataMessageParams
{
    [JsonProperty("threshold", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Threshold { get; set; } 

    [JsonProperty("unit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Unit { get; set; } 

    [JsonProperty("start_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? StartDate { get; set; } 

    [JsonProperty("end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? EndDate { get; set; } 

    [JsonProperty("top_processes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TopProcesses { get; set; } 

}