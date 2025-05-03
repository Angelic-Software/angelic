using System.CodeDom.Compiler;
using Angelic.Models.Configuration.Tickets.Views;
using Angelic.Models.KeyPairs;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Tickets.TicketAreas;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class TicketArea
{
    [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Guid { get; set; } 

    [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Intent { get; set; } 

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("sequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sequence { get; set; } 

    [JsonProperty("entity_singular", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EntitySingular { get; set; } 

    [JsonProperty("entity_plural", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EntityPlural { get; set; } 

    [JsonProperty("icon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Icon { get; set; } 

    [JsonProperty("default_filter_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultFilterId { get; set; } 

    [JsonProperty("default_filter_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultFilterName { get; set; } 

    [JsonProperty("default_view", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultView { get; set; } 

    [JsonProperty("default_view_selectedid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultViewSelectedId { get; set; } 

    [JsonProperty("default_view_selectedname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultViewSelectedName { get; set; } 

    [JsonProperty("default_columns_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultColumnsId { get; set; } 

    [JsonProperty("default_ticket_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultTicketType { get; set; } 

    [JsonProperty("default_itil_ticket_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultItilTicketType { get; set; } 

    [JsonProperty("default_template_group_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultTemplateGroupId { get; set; } 

    [JsonProperty("default_columns_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultColumnsName { get; set; } 

    [JsonProperty("selectservice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SelectService { get; set; } 

    [JsonProperty("enableprojecttreeview", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? EnableProjectTreeView { get; set; } 

    [JsonProperty("showtabondetailsscreens", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowTabOnDetailsScreens { get; set; } 

    [JsonProperty("filters", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ViewFilterDetails>? Filters { get; set; } 

    [JsonProperty("team_restrictions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<TicketAreaTeamRestrictions>? TeamRestrictions { get; set; } 

    [JsonProperty("area_use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AreaUse { get; set; } 

    [JsonProperty("area_use_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AreaUseName { get; set; } 

    [JsonProperty("shownewticketbutton", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowNewTicketButton { get; set; } 

    [JsonProperty("allow_ticket_type_selection", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AllowTicketTypeSelection { get; set; } 

    [JsonProperty("kanbanstatuschoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<StringIdNameKeyPair>? KanbanStatusChoice { get; set; } 

    [JsonProperty("kanbanstatuschoice_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? KanbanStatusChoiceList { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}