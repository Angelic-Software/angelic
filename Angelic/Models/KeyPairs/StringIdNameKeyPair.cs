using Newtonsoft.Json;

namespace Angelic.Models.KeyPairs;

/// <summary>
/// Originally named KeyPair.
/// </summary>
public class StringIdNameKeyPair
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 
}