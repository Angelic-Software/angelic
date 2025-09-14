using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Automation;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record AutomateTicket
{
    [JsonProperty("ticketId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TicketId { get; set; } 

    [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public AutomateReference? Status { get; set; } 

    [JsonProperty("subject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Subject { get; set; } 

    [JsonProperty("body", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Body { get; set; } 

    [JsonProperty("category", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public AutomateReference? Category { get; set; } 

    [JsonProperty("priority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public AutomateReference? Priority { get; set; } 

    [JsonProperty("client", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public AutomateReference? Client { get; set; } 

    [JsonProperty("location", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public AutomateReference? Location { get; set; } 

    [JsonProperty("computer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public AutomateReference? Computer { get; set; } 

    [JsonProperty("dueDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? DueDate { get; set; } 

    [JsonProperty("startDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? StartDate { get; set; } 

    [JsonProperty("contactDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? ContactDate { get; set; } 

    [JsonProperty("updateDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? UpdateDate { get; set; } 

    [JsonProperty("from", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? From { get; set; } 

    [JsonProperty("cc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Cc { get; set; } 

    [JsonProperty("supportLevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SupportLevel { get; set; } 

    [JsonProperty("externalId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ExternalId { get; set; } 

    [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Guid { get; set; } 

    [JsonProperty("comments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AutomateComment>? Comments { get; set; } 

}