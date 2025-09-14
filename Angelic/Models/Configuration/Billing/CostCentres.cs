using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Billing;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record CostCentres
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("chargeable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Chargeable { get; set; } 

    [JsonProperty("addr1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Addr1 { get; set; } 

    [JsonProperty("addr2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Addr2 { get; set; } 

    [JsonProperty("addr3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Addr3 { get; set; } 

    [JsonProperty("addr4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Addr4 { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}