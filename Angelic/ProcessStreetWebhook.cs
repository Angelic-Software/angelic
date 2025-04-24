using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ProcessStreetWebhook
{
    [JsonProperty("createdDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? CreatedDate { get; set; } 

    [JsonProperty("data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ProcessStreetData? Data { get; set; } 

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Id { get; set; } 

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Type { get; set; } 

}