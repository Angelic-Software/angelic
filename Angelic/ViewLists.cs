using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ViewLists
{
    [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Guid { get; set; } 

    [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Intent { get; set; } 

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Use { get; set; } 

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

    [JsonProperty("sequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sequence { get; set; } 

    [JsonProperty("showcounts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Showcounts { get; set; } 

    [JsonProperty("column_profile_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Column_profile_id { get; set; } 

    [JsonProperty("column_profile_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Column_profile_guid { get; set; } 

    [JsonProperty("filter_profile_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Filter_profile_id { get; set; } 

    [JsonProperty("filter_profile_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Filter_profile_guid { get; set; } 

    [JsonProperty("lock_view_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Lock_view_type { get; set; } 

    [JsonProperty("connectedinstance_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Connectedinstance_id { get; set; } 

    [JsonProperty("connectedinstance_list_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Connectedinstance_list_id { get; set; } 

    [JsonProperty("show_in_team_tree", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Show_in_team_tree { get; set; } 

    [JsonProperty("show_in_team_tree_team_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Show_in_team_tree_team_id { get; set; } 

    [JsonProperty("show_in_team_tree_team_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Show_in_team_tree_team_name { get; set; } 

    [JsonProperty("ticket_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Ticket_count { get; set; } 

    [JsonProperty("connectedinstance_error", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Connectedinstance_error { get; set; } 

    [JsonProperty("column_profile_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Column_profile_name { get; set; } 

    [JsonProperty("filter_profile_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Filter_profile_name { get; set; } 

    [JsonProperty("connectedinstance_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Connectedinstance_name { get; set; } 

    [JsonProperty("filters", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ViewFilterDetails>? Filters { get; set; } 

    [JsonProperty("group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Group { get; set; } 

    [JsonProperty("group_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Group_name { get; set; } 

    [JsonProperty("group_seq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Group_seq { get; set; } 

    [JsonProperty("group_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Group_type { get; set; } 

    [JsonProperty("group_collapsed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Group_collapsed { get; set; } 

    [JsonProperty("translations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<LanguagePackTranslationsCustom>? Translations { get; set; } 

}