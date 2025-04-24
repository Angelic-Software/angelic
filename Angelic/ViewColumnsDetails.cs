using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ViewColumnsDetails
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("columns_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Columns_id { get; set; } 

    [JsonProperty("column_seq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Column_seq { get; set; } 

    [JsonProperty("column_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Column_name { get; set; } 

    [JsonProperty("width", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Width { get; set; } 

    [JsonProperty("order_seq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Order_seq { get; set; } 

    [JsonProperty("order_desc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Order_desc { get; set; } 

    [JsonProperty("column_title_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Column_title_override { get; set; } 

    [JsonProperty("groupbystatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Groupbystatus { get; set; } 

    [JsonProperty("columns_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Columns_guid { get; set; } 

}