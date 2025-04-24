using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class FaultBudget
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Ticket_id { get; set; } 

    [JsonProperty("budgettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Budgettype_id { get; set; } 

    [JsonProperty("budgettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Budgettype_name { get; set; } 

    [JsonProperty("hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Hours { get; set; } 

    [JsonProperty("days", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Days { get; set; } 

    [JsonProperty("rate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Rate { get; set; } 

    [JsonProperty("rate_days", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Rate_days { get; set; } 

    [JsonProperty("money", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Money { get; set; } 

    [JsonProperty("estimated_hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Estimated_hours { get; set; } 

    [JsonProperty("estimated_days", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Estimated_days { get; set; } 

    [JsonProperty("estimated_money", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Estimated_money { get; set; } 

    [JsonProperty("actual_hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Actual_hours { get; set; } 

    [JsonProperty("actual_days", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Actual_days { get; set; } 

    [JsonProperty("actual_money", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Actual_money { get; set; } 

    [JsonProperty("scheduled_hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Scheduled_hours { get; set; } 

    [JsonProperty("scheduled_days", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Scheduled_days { get; set; } 

    [JsonProperty("scheduled_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Scheduled_value { get; set; } 

    [JsonProperty("toschedule_hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Toschedule_hours { get; set; } 

    [JsonProperty("toschedule_days", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Toschedule_days { get; set; } 

    [JsonProperty("toschedule_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Toschedule_value { get; set; } 

    [JsonProperty("remaining_hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Remaining_hours { get; set; } 

    [JsonProperty("remaining_days", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Remaining_days { get; set; } 

    [JsonProperty("remaining_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Remaining_value { get; set; } 

    [JsonProperty("quoteline_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Quoteline_id { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

}