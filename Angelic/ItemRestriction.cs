using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ItemRestriction
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("item_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Item_id { get; set; } 

    [JsonProperty("servicerequest_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Servicerequest_id { get; set; } 

    [JsonProperty("item_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Item_name { get; set; } 

}