using System.CodeDom.Compiler;
using Angelic.Models.Appointments;
using Angelic.Models.Contracts;
using Angelic.Models.KeyPairs;
using Newtonsoft.Json;

namespace Angelic.Models;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Schedule
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("startdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? StartDate { get; set; } 

    [JsonProperty("enddate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? EndDate { get; set; } 

    [JsonProperty("subject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Subject { get; set; } 

    [JsonProperty("hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Hours { get; set; } 

    [JsonProperty("dailyrecurrencepattern", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Dailyrecurrencepattern { get; set; } 

    [JsonProperty("dailyrecurrencedays", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Dailyrecurrencedays { get; set; } 

    [JsonProperty("weeklyrecurrenceweeks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Weeklyrecurrenceweeks { get; set; } 

    [JsonProperty("endafteramount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Endafteramount { get; set; } 

    [JsonProperty("rangeofrecurrence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Rangeofrecurrence { get; set; } 

    [JsonProperty("requesttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RequestType { get; set; } 

    [JsonProperty("recurrencepattern", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Recurrencepattern { get; set; } 

    [JsonProperty("agentid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AgentId { get; set; } 

    [JsonProperty("monthlyrecurrencepattern", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Monthlyrecurrencepattern { get; set; } 

    [JsonProperty("yearlyrecurrencepattern", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? YearlyRecurrencepattern { get; set; } 

    [JsonProperty("monthlyrecurrencespecificdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Monthlyrecurrencespecificdate { get; set; } 

    [JsonProperty("monthlyrecurrencespecificdateinterval", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Monthlyrecurrencespecificdateinterval { get; set; } 

    [JsonProperty("monthlyrecurrencespecificday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Monthlyrecurrencespecificday { get; set; } 

    [JsonProperty("monthlyrecurrencespecificdayofweek", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Monthlyrecurrencespecificdayofweek { get; set; } 

    [JsonProperty("monthlyrecurrencespecificdayinterval", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Monthlyrecurrencespecificdayinterval { get; set; } 

    [JsonProperty("yearlyrecurrencespecificdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? YearlyRecurrencespecificdate { get; set; } 

    [JsonProperty("yearlyrecurrencespecificdatemonth", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? YearlyRecurrencespecificdatemonth { get; set; } 

    [JsonProperty("yearlyrecurrencespecificdateinterval", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? YearlyRecurrencespecificdateinterval { get; set; } 

    [JsonProperty("yearlyrecurrencespecificday", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? YearlyRecurrencespecificday { get; set; } 

    [JsonProperty("yearlyrecurrencespecificdayofweek", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? YearlyRecurrencespecificdayofweek { get; set; } 

    [JsonProperty("yearlyrecurrencespecificdaymonth", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? YearlyRecurrencespecificdaymonth { get; set; } 

    [JsonProperty("yearlyrecurrencespecificdayinterval", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? YearlyRecurrenceSpecificDayInterval { get; set; } 

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Type { get; set; } 

    [JsonProperty("uniqueid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Uniqueid { get; set; } 

    [JsonProperty("weeklyrecurrencestring", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Weeklyrecurrencestring { get; set; } 

    [JsonProperty("nextcreationdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? NextCreationdate { get; set; } 

    [JsonProperty("nextrundate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? NextRundate { get; set; } 

    [JsonProperty("contract_schedule_plan", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ContractSchedulePlan>? ContractSchedulePlan { get; set; } 

    [JsonProperty("weeklyrecurrenceamount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<StringIdNameKeyPair>? Weeklyrecurrenceamount { get; set; } 

    [JsonProperty("_validateonly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ValidateOnly { get; set; } 

    [JsonProperty("events", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Appointment>? Events { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}