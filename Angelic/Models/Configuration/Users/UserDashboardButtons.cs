using System.CodeDom.Compiler;
using Angelic.Models.Configuration.Language;
using Angelic.Models.Configuration.Tickets.TicketTypes;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Users;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record UserDashboardButtons
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("sequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sequence { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("hint_header", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? HintHeader { get; set; } 

    [JsonProperty("hint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Hint { get; set; } 

    [JsonProperty("systemuse", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SystemUse { get; set; } 

    [JsonProperty("use_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? UseId { get; set; } 

    [JsonProperty("use_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? UseGuid { get; set; } 

    [JsonProperty("colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Colour { get; set; } 

    [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Url { get; set; } 

    [JsonProperty("hover", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Hover { get; set; } 

    [JsonProperty("icon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Icon { get; set; } 

    [JsonProperty("usedefault", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? UseDefault { get; set; } 

    [JsonProperty("showonhomescreen", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowOnHomeScreen { get; set; } 

    [JsonProperty("showonnavbar", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowOnNavbar { get; set; } 

    [JsonProperty("iconcolour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? IconColour { get; set; } 

    [JsonProperty("iconcolour_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? IconColourType { get; set; } 

    [JsonProperty("anyonymousanduseraccessprivelages", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AnonymousAndUserAccessPrivileges { get; set; } 

    [JsonProperty("udbtickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? UdbTicketType { get; set; } 

    [JsonProperty("tickettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? TicketTypeGuid { get; set; } 

    [JsonProperty("displaytype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DisplayType { get; set; } 

    [JsonProperty("displaytype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? DisplayTypeGuid { get; set; } 

    [JsonProperty("useroadmapcolumnsratherthanstatuses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Useroadmapcolumnsratherthanstatuses { get; set; } 

    [JsonProperty("restrictions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<UserDashboardRestrictions>? Restrictions { get; set; } 

    [JsonProperty("translations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<LanguagePackTranslationsCustom>? Translations { get; set; } 

    [JsonProperty("customhtml", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CustomHtml { get; set; } 

    [JsonProperty("page_title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PageTitle { get; set; } 

    [JsonProperty("page_desc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PageDesc { get; set; } 

    [JsonProperty("topkb_title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TopKbTitle { get; set; } 

    [JsonProperty("new_icon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewIcon { get; set; } 

    [JsonProperty("usecustomicon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? UseCustomIcon { get; set; } 

    [JsonProperty("custom_icon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CustomIcon { get; set; } 

    [JsonProperty("default_view", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultView { get; set; } 

    [JsonProperty("portal_ticket_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<TicketTypeList>? PortalTicketList { get; set; } 

    [JsonProperty("ticket_column_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TicketColumnOverride { get; set; } 

    [JsonProperty("tickettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TicketType { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}