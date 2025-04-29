using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Tickets;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class TicketTimeEntry
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("faultid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? FaultId { get; set; } 

    [JsonProperty("actioncode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Actioncode { get; set; } 

    [JsonProperty("time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Time { get; set; } 

    [JsonProperty("actionbillingplanid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Actionbillingplanid { get; set; } 

    [JsonProperty("value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Value { get; set; } 

    [JsonProperty("overridden", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Overridden { get; set; } 

    [JsonProperty("actualtime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Actualtime { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}