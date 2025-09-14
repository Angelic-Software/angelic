using System.CodeDom.Compiler;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record Trace
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public long? Id { get; set; } 

    [Range(0, 11)]
    [JsonProperty("tracetype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TraceType { get; set; } 

    [JsonProperty("relatedid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RelatedId { get; set; } 

    [JsonProperty("systemeventid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SystemEventId { get; set; } 

    [JsonProperty("timestamp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Timestamp { get; set; } 

    [JsonProperty("log", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Log { get; set; } 

}