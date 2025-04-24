using System.CodeDom.Compiler;
using Angelic.KeyPairs;
using Newtonsoft.Json;

namespace Angelic;

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
    public string? Entity_singular { get; set; } 

    [JsonProperty("entity_plural", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Entity_plural { get; set; } 

    [JsonProperty("icon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Icon { get; set; } 

    [JsonProperty("default_filter_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Default_filter_id { get; set; } 

    [JsonProperty("default_filter_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Default_filter_name { get; set; } 

    [JsonProperty("default_view", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Default_view { get; set; } 

    [JsonProperty("default_view_selectedid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Default_view_selectedid { get; set; } 

    [JsonProperty("default_view_selectedname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Default_view_selectedname { get; set; } 

    [JsonProperty("default_columns_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Default_columns_id { get; set; } 

    [JsonProperty("default_ticket_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Default_ticket_type { get; set; } 

    [JsonProperty("default_itil_ticket_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Default_itil_ticket_type { get; set; } 

    [JsonProperty("default_template_group_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Default_template_group_id { get; set; } 

    [JsonProperty("default_columns_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Default_columns_name { get; set; } 

    [JsonProperty("selectservice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Selectservice { get; set; } 

    [JsonProperty("enableprojecttreeview", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Enableprojecttreeview { get; set; } 

    [JsonProperty("showtabondetailsscreens", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Showtabondetailsscreens { get; set; } 

    [JsonProperty("filters", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ViewFilterDetails>? Filters { get; set; } 

    [JsonProperty("team_restrictions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AreaSectionDetail>? Team_restrictions { get; set; } 

    [JsonProperty("area_use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Area_use { get; set; } 

    [JsonProperty("area_use_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Area_use_name { get; set; } 

    [JsonProperty("shownewticketbutton", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Shownewticketbutton { get; set; } 

    [JsonProperty("allow_ticket_type_selection", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Allow_ticket_type_selection { get; set; } 

    [JsonProperty("kanbanstatuschoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<StringIdNameKeyPair>? Kanbanstatuschoice { get; set; } 

    [JsonProperty("kanbanstatuschoice_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Kanbanstatuschoice_list { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

}