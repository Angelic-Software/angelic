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
    public int? TaxRuleId { get; set; } 

    [JsonProperty("value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Value { get; set; } 

    [JsonProperty("value_lookup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<StringIdNameKeyPair>? ValueLookup { get; set; } 

    [JsonProperty("value_bool", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ValueBool { get; set; } 

    [JsonProperty("value_display", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ValueDisplay { get; set; } 

    [JsonProperty("value_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ValueType { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}