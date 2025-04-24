using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class StringObjectDbTypeTuple
{
    [JsonProperty("item1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Item1 { get; set; } 

    [JsonProperty("item2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public object? Item2 { get; set; } 

    [JsonProperty("item3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DbType? Item3 { get; set; } 

}