using Newtonsoft.Json;

namespace Angelic.KeyPairs;

public class ValueLabelIsNewKeyPair
{
    [JsonProperty("value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Value { get; set; }

    [JsonProperty("label", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Label { get; set; }

    [JsonProperty("isnew", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsNew { get; set; }
}