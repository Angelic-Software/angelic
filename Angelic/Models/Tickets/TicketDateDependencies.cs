using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Tickets;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class TicketDateDependencies
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("parentfaultid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ParentFaultId { get; set; } 

    [JsonProperty("faultid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? FaultId { get; set; } 

    [JsonProperty("dependentfaultid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Dependentfaultid { get; set; } 

    [JsonProperty("applied_from_template", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AppliedFromTemplate { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}