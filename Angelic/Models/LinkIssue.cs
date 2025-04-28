using System.CodeDom.Compiler;
using Angelic.Models.Configuration.SoftwareReleases;
using Newtonsoft.Json;

namespace Angelic.Models;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class LinkIssue
{
    [JsonProperty("ticketId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TicketId { get; set; } 

    [JsonProperty("issueId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? IssueId { get; set; } 

    [JsonProperty("externalLinkId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ExternalLinkId { get; set; } 

    [JsonProperty("ticket", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Faults? Ticket { get; set; } 

    [JsonProperty("product", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ReleaseProduct? Product { get; set; } 

}