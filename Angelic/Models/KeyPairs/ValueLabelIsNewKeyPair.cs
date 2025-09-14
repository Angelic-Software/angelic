using Newtonsoft.Json;

namespace Angelic.Models.KeyPairs;

// Previously known as KeyPair2
public record ValueLabelIsNewKeyPair
{
    [JsonProperty("value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Value { get; set; }

    [JsonProperty("label", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Label { get; set; }

    [JsonProperty("isnew", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsNew { get; set; }
}