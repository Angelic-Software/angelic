using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.KeyPairs;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class StringStringValuesKeyValuePair
{
    [JsonProperty("key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Key { get; set; } 

    [JsonProperty("value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<string>? Value { get; set; } 

}