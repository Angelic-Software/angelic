using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Tickets.Views;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record ViewColumns
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
    public string? TileHtml { get; set; } 

    [JsonProperty("columns", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ViewColumnsDetails>? Columns { get; set; } 

    [JsonProperty("_temp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Temp { get; set; } 

    [JsonProperty("card_html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CardHtml { get; set; } 

    [JsonProperty("linked_dashboard_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? LinkedDashboardId { get; set; } 

    [JsonProperty("use_dashboard", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? UseDashboard { get; set; } 

    [JsonProperty("include_children", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IncludeChildren { get; set; } 

    [JsonProperty("restriction_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RestrictionType { get; set; } 

    [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AgentId { get; set; } 

    [JsonProperty("agent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AgentName { get; set; } 

    [JsonProperty("team_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TeamId { get; set; } 

    [JsonProperty("team_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? TeamGuid { get; set; } 

    [JsonProperty("team_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TeamName { get; set; } 

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Type { get; set; } 

    [JsonProperty("type_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TypeName { get; set; } 

}