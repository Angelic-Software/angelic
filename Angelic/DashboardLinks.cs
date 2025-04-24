using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class DashboardLinks
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Use { get; set; } 

    [JsonProperty("link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Link { get; set; } 

    [JsonProperty("iframe", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Iframe { get; set; } 

    [JsonProperty("newtab", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Newtab { get; set; } 

    [JsonProperty("in_app", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? In_app { get; set; } 

    [JsonProperty("admin_only", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Admin_only { get; set; } 

    [JsonProperty("org_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Org_id { get; set; } 

    [JsonProperty("department_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Department_id { get; set; } 

    [JsonProperty("team_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Team_id { get; set; } 

    [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Agent_id { get; set; } 

    [JsonProperty("org_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Org_name { get; set; } 

    [JsonProperty("department_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Department_name { get; set; } 

    [JsonProperty("team_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Team_name { get; set; } 

    [JsonProperty("display_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Display_type { get; set; } 

    [JsonProperty("restriction_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Restriction_type { get; set; } 

    [JsonProperty("layouts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Layouts { get; set; } 

    [JsonProperty("widgets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Widget>? Widgets { get; set; } 

    [JsonProperty("access_control", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AccessControl>? Access_control { get; set; } 

    [JsonProperty("access_control_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Access_control_level { get; set; } 

    [JsonProperty("report_access_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Report_access_token { get; set; } 

    [JsonProperty("reportingperiod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Reportingperiod { get; set; } 

    [JsonProperty("reportingperiodstartdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Reportingperiodstartdate { get; set; } 

    [JsonProperty("reportingperiodenddate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Reportingperiodenddate { get; set; } 

    [JsonProperty("reportingperiodvisibility", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Reportingperiodvisibility { get; set; } 

    [JsonProperty("filters", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<DashboardFilter>? Filters { get; set; } 

    [JsonProperty("user_access", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<DashboardRestriction>? User_access { get; set; } 

    [JsonProperty("is_published", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Is_published { get; set; } 

    [JsonProperty("published_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Published_id { get; set; } 

    [JsonProperty("allow_anonymous", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Allow_anonymous { get; set; } 

    [JsonProperty("rowheight", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Rowheight { get; set; } 

    [JsonProperty("manually_load_dashboards", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Manually_load_dashboards { get; set; } 

    [JsonProperty("dashboard_theme_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Dashboard_theme_override { get; set; } 

    [JsonProperty("list_item_height", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? List_item_height { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

}