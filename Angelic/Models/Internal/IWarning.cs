using Newtonsoft.Json;

namespace Angelic.Models.Internal;

internal interface IWarning
{
    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 
}