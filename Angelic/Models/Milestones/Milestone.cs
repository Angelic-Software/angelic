using System.CodeDom.Compiler;
using Angelic.Models.Tickets;
using Newtonsoft.Json;

namespace Angelic.Models.Milestones;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record Milestone
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TicketId { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("sequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sequence { get; set; } 

    [JsonProperty("start_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? StartDate { get; set; } 

    [JsonProperty("target_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? TargetDate { get; set; } 

    [JsonProperty("milestone_dependencies", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Milestone>? MilestoneDependencies { get; set; } 

    [JsonProperty("dependencies", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<MilestoneDependency>? Dependencies { get; set; } 

    [JsonProperty("tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<TicketMilestone>? Tickets { get; set; } 

    [JsonProperty("_complete", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Complete { get; set; } 

    [JsonProperty("_dateschanged", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DatesChanged { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("start_days", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? StartDays { get; set; } 

    [JsonProperty("target_days", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TargetDays { get; set; } 

    [JsonProperty("_fromtemplate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? FromTemplate { get; set; } 

    [JsonProperty("milestone_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? MilestoneValue { get; set; } 

    [JsonProperty("processed_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? ProcessedDate { get; set; } 

    [JsonProperty("invoicenumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? InvoiceNumber { get; set; } 

    [JsonProperty("from_template_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? FromTemplateId { get; set; } 

}