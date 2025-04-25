using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Journey
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("unum", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Unum { get; set; } 

    [JsonProperty("faultid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Faultid { get; set; } 

    [JsonProperty("actionnumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Actionnumber { get; set; } 

    [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Description { get; set; } 

    [JsonProperty("startdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? StartDate { get; set; } 

    [JsonProperty("enddate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? EndDate { get; set; } 

    [JsonProperty("startodometer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Startodometer { get; set; } 

    [JsonProperty("endodometer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Endodometer { get; set; } 

    [JsonProperty("vehicle", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Vehicle { get; set; } 

    [JsonProperty("startgps", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Startgps { get; set; } 

    [JsonProperty("endgps", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Endgps { get; set; } 

    [JsonProperty("datereimbursed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Datereimbursed { get; set; } 

    [JsonProperty("dateinvoicedmileage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Dateinvoicedmileage { get; set; } 

    [JsonProperty("dateinvoicedtraveltime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Dateinvoicedtraveltime { get; set; } 

    [JsonProperty("ihidmileage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Ihidmileage { get; set; } 

    [JsonProperty("ihidtraveltime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Ihidtraveltime { get; set; } 

    [JsonProperty("invoiceable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Invoiceable { get; set; } 

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Type { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}