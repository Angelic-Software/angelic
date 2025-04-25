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

    [JsonProperty("sequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sequence { get; set; } 

    [JsonProperty("showcounts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowCounts { get; set; } 

    [JsonProperty("column_profile_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ColumnProfileId { get; set; } 

    [JsonProperty("column_profile_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? ColumnProfileGuid { get; set; } 

    [JsonProperty("filter_profile_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? FilterProfileId { get; set; } 

    [JsonProperty("filter_profile_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? FilterProfileGuid { get; set; } 

    [JsonProperty("lock_view_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? LockViewType { get; set; } 

    [JsonProperty("connectedinstance_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ConnectedinstanceId { get; set; } 

    [JsonProperty("connectedinstance_list_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ConnectedinstanceListId { get; set; } 

    [JsonProperty("show_in_team_tree", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowInTeamTree { get; set; } 

    [JsonProperty("show_in_team_tree_team_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ShowInTeamTreeTeamId { get; set; } 

    [JsonProperty("show_in_team_tree_team_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ShowInTeamTreeTeamName { get; set; } 

    [JsonProperty("ticket_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TicketCount { get; set; } 

    [JsonProperty("connectedinstance_error", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ConnectedinstanceError { get; set; } 

    [JsonProperty("column_profile_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ColumnProfileName { get; set; } 

    [JsonProperty("filter_profile_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? FilterProfileName { get; set; } 

    [JsonProperty("connectedinstance_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ConnectedinstanceName { get; set; } 

    [JsonProperty("filters", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ViewFilterDetails>? Filters { get; set; } 

    [JsonProperty("group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Group { get; set; } 

    [JsonProperty("group_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? GroupName { get; set; } 

    [JsonProperty("group_seq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? GroupSeq { get; set; } 

    [JsonProperty("group_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? GroupType { get; set; } 

    [JsonProperty("group_collapsed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? GroupCollapsed { get; set; } 

    [JsonProperty("translations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<LanguagePackTranslationsCustom>? Translations { get; set; } 

}