using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ChargeRate
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("area", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Area { get; set; } 

    [JsonProperty("contract_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ContractId { get; set; } 

    [JsonProperty("charge_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ChargeId { get; set; } 

    [JsonProperty("startdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Startdate { get; set; } 

    [JsonProperty("expirydate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Expirydate { get; set; } 

    [JsonProperty("rate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Rate { get; set; } 

    [JsonProperty("org", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Org { get; set; } 

    [JsonProperty("minimum", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Minimum { get; set; } 

    [JsonProperty("increment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Increment { get; set; } 

    [JsonProperty("oohmultiplier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Oohmultiplier { get; set; } 

    [JsonProperty("holidaymultiplier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Holidaymultiplier { get; set; } 

    [JsonProperty("weekendmultiplier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Weekendmultiplier { get; set; } 

    [JsonProperty("surcharge", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Surcharge { get; set; } 

    [JsonProperty("round", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Round { get; set; } 

    [JsonProperty("useagentworkinghours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Useagentworkinghours { get; set; } 

    [JsonProperty("use_budget_rate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? UseBudgetRate { get; set; } 

    [JsonProperty("current", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Current { get; set; } 

    [JsonProperty("current_rate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? CurrentRate { get; set; } 

    [JsonProperty("use_for_travel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? UseForTravel { get; set; } 

    [JsonProperty("use_for_mileage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? UseForMileage { get; set; } 

    [JsonProperty("travel_surchargeid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TravelSurchargeid { get; set; } 

    [JsonProperty("contractmultiplier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Contractmultiplier { get; set; } 

    [JsonProperty("rateoverride", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Rateoverride { get; set; } 

    [JsonProperty("override_surcharge", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? OverrideSurcharge { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}