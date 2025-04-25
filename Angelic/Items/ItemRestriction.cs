using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Items;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ItemRestriction
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("item_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ItemId { get; set; } 

    [JsonProperty("servicerequest_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ServiceRequestId { get; set; } 

    [JsonProperty("item_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ItemName { get; set; } 

}