using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.KeyPairs;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Int32NullableStringDateTimeNullableInt32NullableDateTimeNullableTuple
{
    [JsonProperty("item1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Item1 { get; set; } 

    [JsonProperty("item2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Item2 { get; set; } 

    [JsonProperty("item3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Item3 { get; set; } 

    [JsonProperty("item4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Item4 { get; set; } 

    [JsonProperty("item5", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Item5 { get; set; } 

}