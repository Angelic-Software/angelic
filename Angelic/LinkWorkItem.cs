using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class LinkWorkItem
{
    [JsonProperty("ticketId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TicketId { get; set; } 

    [JsonProperty("workItemId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? WorkItemId { get; set; } 

    [JsonProperty("externalLinkId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ExternalLinkId { get; set; } 

    [JsonProperty("product", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ReleaseProduct? Product { get; set; } 

    [JsonProperty("rev", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Rev { get; set; } 

}