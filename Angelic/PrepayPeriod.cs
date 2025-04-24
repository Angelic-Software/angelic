using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class PrepayPeriod
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("contract_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Contract_id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("start_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Start_date { get; set; } 

    [JsonProperty("end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? End_date { get; set; } 

    [JsonProperty("start_date_display", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Start_date_display { get; set; } 

    [JsonProperty("end_date_display", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? End_date_display { get; set; } 

    [JsonProperty("current", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Current { get; set; } 

    [JsonProperty("hours_added", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Hours_added { get; set; } 

    [JsonProperty("hours_expired", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Hours_expired { get; set; } 

    [JsonProperty("hours_remaining", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Hours_remaining { get; set; } 

    [JsonProperty("hours_used_this_period", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Hours_used_this_period { get; set; } 

    [JsonProperty("amount_added", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Amount_added { get; set; } 

    [JsonProperty("amount_expired", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Amount_expired { get; set; } 

    [JsonProperty("amount_remaining", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Amount_remaining { get; set; } 

    [JsonProperty("amount_used_this_period", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Amount_used_this_period { get; set; } 

}