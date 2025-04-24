using System.CodeDom.Compiler;
using Angelic.KeyPairs;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class BookingTypeTimeslot
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Id { get; set; } 

    [JsonProperty("startdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Startdate { get; set; } 

    [JsonProperty("enddate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Enddate { get; set; } 

    [JsonProperty("resources", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<LongIdNameKeyPair>? Resources { get; set; } 

    [JsonProperty("bookedResourceId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? BookedResourceId { get; set; } 

}