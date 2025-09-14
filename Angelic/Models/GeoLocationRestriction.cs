using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record GeoLocationRestriction
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("table_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TableId { get; set; } 

    [JsonProperty("entity_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? EntityId { get; set; } 

    [JsonProperty("country_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CountryCode { get; set; } 

    [JsonProperty("continent_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ContinentCode { get; set; } 

    [JsonProperty("exclude", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Exclude { get; set; } 

}