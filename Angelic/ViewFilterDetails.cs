using System.CodeDom.Compiler;
using Angelic.KeyPairs;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ViewFilterDetails
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("filter_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Filter_id { get; set; } 

    [JsonProperty("list_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? List_id { get; set; } 

    [JsonProperty("itemsupplier_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Itemsupplier_id { get; set; } 

    [JsonProperty("area_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Area_id { get; set; } 

    [JsonProperty("filter_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Filter_name { get; set; } 

    [JsonProperty("filter_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Filter_type { get; set; } 

    [JsonProperty("filter_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Filter_value { get; set; } 

    [JsonProperty("filter_values", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<StringIdNameKeyPair>? Filter_values { get; set; } 

    [JsonProperty("multiselect_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<MultiselectFilter>? Multiselect_value { get; set; } 

    [JsonProperty("filter_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Filter_guid { get; set; } 

    [JsonProperty("list_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? List_guid { get; set; } 

    [JsonProperty("itemsupplier_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Itemsupplier_guid { get; set; } 

    [JsonProperty("filter_value_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Filter_value_guid { get; set; } 

}