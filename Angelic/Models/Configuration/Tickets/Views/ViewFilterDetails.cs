using System.CodeDom.Compiler;
using Angelic.Models.KeyPairs;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Tickets.Views;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record ViewFilterDetails
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("filter_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? FilterId { get; set; } 

    [JsonProperty("list_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ListId { get; set; } 

    [JsonProperty("itemsupplier_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ItemSupplierId { get; set; } 

    [JsonProperty("area_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AreaId { get; set; } 

    [JsonProperty("filter_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? FilterName { get; set; } 

    [JsonProperty("filter_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? FilterType { get; set; } 

    [JsonProperty("filter_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? FilterValue { get; set; } 

    [JsonProperty("filter_values", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<StringIdNameKeyPair>? FilterValues { get; set; } 

    [JsonProperty("multiselect_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<MultiselectFilter>? MultiselectValue { get; set; } 

    [JsonProperty("filter_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? FilterGuid { get; set; } 

    [JsonProperty("list_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? ListGuid { get; set; } 

    [JsonProperty("itemsupplier_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? ItemSupplierGuid { get; set; } 

    [JsonProperty("filter_value_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? FilterValueGuid { get; set; } 

}