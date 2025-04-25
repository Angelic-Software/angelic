using System.CodeDom.Compiler;
using Angelic.Configuration.Custom.CustomFields;
using Angelic.KeyPairs;
using Newtonsoft.Json;

namespace Angelic.Configuration.Integrations.Lookups;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class DatabaseLookupResult
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("field_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? FieldId { get; set; } 

    [JsonProperty("lookup_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? LookupValue { get; set; } 

    [JsonProperty("success", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Success { get; set; } 

    [JsonProperty("error", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Error { get; set; } 

    [JsonProperty("data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public IDictionary<string, object?>? Data { get; set; } 

    [JsonProperty("field_values", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<StringIdNameKeyPair>? FieldValues { get; set; } 

    [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomField>? CustomFields { get; set; } 

    [JsonProperty("lookup_values", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? LookupValues { get; set; } 

    [JsonProperty("message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Message { get; set; } 

    [JsonProperty("popup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Popup { get; set; } 

    [JsonProperty("confirm_popup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ConfirmPopup { get; set; } 

    [JsonProperty("data_multiple", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IDictionary<string, object>>? DataMultiple { get; set; } 

    [JsonProperty("message_multiple", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MessageMultiple { get; set; } 

    [JsonProperty("customfields_multiple", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ICollection<CustomField>>? CustomFieldsMultiple { get; set; } 

    [JsonProperty("mapped_outcome_field_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MappedOutcomeFieldId { get; set; } 

    [JsonProperty("mapped_outcome_inverted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? MappedOutcomeInverted { get; set; } 

}