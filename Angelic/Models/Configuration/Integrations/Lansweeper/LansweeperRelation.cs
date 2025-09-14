using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.Lansweeper;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record LansweeperRelation
{
    [JsonProperty("childAssetKey", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ChildAssetKey { get; set; } 

    [JsonProperty("lastChanged", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? LastChanged { get; set; } 

    [JsonProperty("parentAssetKey", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ParentAssetKey { get; set; } 

    [JsonProperty("startDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? StartDate { get; set; } 

    [JsonProperty("endDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EndDate { get; set; } 

    [JsonProperty("comment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Comment { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

}