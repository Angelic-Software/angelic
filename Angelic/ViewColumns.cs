using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ViewColumns
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Guid { get; set; } 

    [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Intent { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("tile_html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Tile_html { get; set; } 

    [JsonProperty("columns", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ViewColumnsDetails>? Columns { get; set; } 

    [JsonProperty("_temp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _temp { get; set; } 

    [JsonProperty("card_html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Card_html { get; set; } 

    [JsonProperty("linked_dashboard_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Linked_dashboard_id { get; set; } 

    [JsonProperty("use_dashboard", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Use_dashboard { get; set; } 

    [JsonProperty("include_children", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Include_children { get; set; } 

    [JsonProperty("restriction_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Restriction_type { get; set; } 

    [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Agent_id { get; set; } 

    [JsonProperty("agent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Agent_name { get; set; } 

    [JsonProperty("team_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Team_id { get; set; } 

    [JsonProperty("team_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Team_guid { get; set; } 

    [JsonProperty("team_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Team_name { get; set; } 

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Type { get; set; } 

    [JsonProperty("type_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Type_name { get; set; } 

}