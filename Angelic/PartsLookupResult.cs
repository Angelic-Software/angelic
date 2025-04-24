using System.CodeDom.Compiler;
using Angelic.KeyPairs;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class PartsLookupResult
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("field_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Field_id { get; set; } 

    [JsonProperty("lookup_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Lookup_value { get; set; } 

    [JsonProperty("success", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Success { get; set; } 

    [JsonProperty("error", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Error { get; set; } 

    [JsonProperty("data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public IDictionary<string, object?>? Data { get; set; } 

    [JsonProperty("field_values", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<StringIdNameKeyPair>? Field_values { get; set; } 

    [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomField>? Customfields { get; set; } 

    [JsonProperty("lookup_values", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Lookup_values { get; set; } 

    [JsonProperty("message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Message { get; set; } 

    [JsonProperty("popup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Popup { get; set; } 

    [JsonProperty("confirm_popup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Confirm_popup { get; set; } 

    [JsonProperty("data_multiple", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IDictionary<string, object>>? Data_multiple { get; set; } 

    [JsonProperty("message_multiple", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Message_multiple { get; set; } 

    [JsonProperty("customfields_multiple", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ICollection<CustomField>>? Customfields_multiple { get; set; } 

    [JsonProperty("mapped_outcome_field_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Mapped_outcome_field_id { get; set; } 

    [JsonProperty("mapped_outcome_inverted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Mapped_outcome_inverted { get; set; } 

}