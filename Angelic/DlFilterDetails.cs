using System.CodeDom.Compiler;
using Angelic.KeyPairs;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class DlFilterDetails
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("list_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ListId { get; set; } 

    [JsonProperty("filter_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? FilterName { get; set; } 

    [JsonProperty("filter_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? FilterType { get; set; } 

    [JsonProperty("filter_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? FilterValue { get; set; } 

    [JsonProperty("filter_values", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<StringIdNameKeyPair>? FilterValues { get; set; } 

    [JsonProperty("filter_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? FilterGuid { get; set; } 

}