using System.CodeDom.Compiler;
using Angelic.KeyPairs;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class TaxRuleConditions
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("tax_rule_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Tax_rule_id { get; set; } 

    [JsonProperty("value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Value { get; set; } 

    [JsonProperty("value_lookup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<StringIdNameKeyPair>? Value_lookup { get; set; } 

    [JsonProperty("value_bool", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Value_bool { get; set; } 

    [JsonProperty("value_display", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Value_display { get; set; } 

    [JsonProperty("value_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Value_type { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

}