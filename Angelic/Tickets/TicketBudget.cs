using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Tickets;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class TicketBudget
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TicketId { get; set; } 

    [JsonProperty("budgettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? BudgetTypeId { get; set; } 

    [JsonProperty("budgettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? BudgetTypeName { get; set; } 

    [JsonProperty("hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Hours { get; set; } 

    [JsonProperty("days", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Days { get; set; } 

    [JsonProperty("rate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Rate { get; set; } 

    [JsonProperty("rate_days", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? RateDays { get; set; } 

    [JsonProperty("money", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Money { get; set; } 

    [JsonProperty("estimated_hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? EstimatedHours { get; set; } 

    [JsonProperty("estimated_days", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? EstimatedDays { get; set; } 

    [JsonProperty("estimated_money", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? EstimatedMoney { get; set; } 

    [JsonProperty("actual_hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? ActualHours { get; set; } 

    [JsonProperty("actual_days", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? ActualDays { get; set; } 

    [JsonProperty("actual_money", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? ActualMoney { get; set; } 

    [JsonProperty("scheduled_hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? ScheduledHours { get; set; } 

    [JsonProperty("scheduled_days", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? ScheduledDays { get; set; } 

    [JsonProperty("scheduled_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? ScheduledValue { get; set; } 

    [JsonProperty("toschedule_hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? ToscheduleHours { get; set; } 

    [JsonProperty("toschedule_days", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? ToscheduleDays { get; set; } 

    [JsonProperty("toschedule_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? ToscheduleValue { get; set; } 

    [JsonProperty("remaining_hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? RemainingHours { get; set; } 

    [JsonProperty("remaining_days", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? RemainingDays { get; set; } 

    [JsonProperty("remaining_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? RemainingValue { get; set; } 

    [JsonProperty("quoteline_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? QuotelineId { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}