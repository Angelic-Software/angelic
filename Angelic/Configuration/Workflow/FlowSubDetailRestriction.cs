using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class FlowSubDetailRestriction
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("flowsubdetail_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? FlowsubdetailId { get; set; } 

    [JsonProperty("field_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? FieldId { get; set; } 

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Type { get; set; } 

    [JsonProperty("value_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ValueId { get; set; } 

    [JsonProperty("value_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ValueName { get; set; } 

}