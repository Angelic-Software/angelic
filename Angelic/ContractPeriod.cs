using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ContractPeriod
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("contract_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ContractId { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("start_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? StartDate { get; set; } 

    [JsonProperty("end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? EndDate { get; set; } 

    [JsonProperty("start_date_display", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? StartDateDisplay { get; set; } 

    [JsonProperty("end_date_display", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? EndDateDisplay { get; set; } 

    [JsonProperty("current", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Current { get; set; } 

    [JsonProperty("hours_in_period", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? HoursInPeriod { get; set; } 

    [JsonProperty("hours_used", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? HoursUsed { get; set; } 

    [JsonProperty("hours_remaining", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? HoursRemaining { get; set; } 

    [JsonProperty("hours_charged", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? HoursCharged { get; set; } 

}