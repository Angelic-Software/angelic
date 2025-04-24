using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class IMRWebhook
{
    [JsonProperty("topic", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Topic { get; set; } 

    [JsonProperty("event", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Event { get; set; } 

    [JsonProperty("eventTimeStamp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? EventTimeStamp { get; set; } 

    [JsonProperty("eventId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EventId { get; set; } 

    [JsonProperty("resource", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public object? Resource { get; set; } 

}