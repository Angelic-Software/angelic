using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Billing.Prepay;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class PrePayThreshold
{
    [JsonProperty("asAmount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AsAmount { get; set; } 

    [JsonProperty("newHours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? NewHours { get; set; } 

    [JsonProperty("newAmount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? NewAmount { get; set; } 

    [JsonProperty("currentUsed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? CurrentUsed { get; set; } 

    [JsonProperty("total", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Total { get; set; } 

}