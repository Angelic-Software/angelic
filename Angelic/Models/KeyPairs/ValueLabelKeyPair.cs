using Newtonsoft.Json;

namespace Angelic.Models.KeyPairs;

public class ValueLabelKeyPair
{
    [JsonProperty("value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Value { get; set; }

    [JsonProperty("label", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Label { get; set; }
}