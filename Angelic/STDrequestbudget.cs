using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class STDrequestbudget
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("template_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Template_id { get; set; } 

    [JsonProperty("hours", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Hours { get; set; } 

    [JsonProperty("days", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Days { get; set; } 

    [JsonProperty("rate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Rate { get; set; } 

    [JsonProperty("rate_days", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Rate_days { get; set; } 

    [JsonProperty("budgettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Budgettype_id { get; set; } 

    [JsonProperty("budgettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Budgettype_name { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

}