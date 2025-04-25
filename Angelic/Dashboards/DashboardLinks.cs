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
    public bool? InApp { get; set; } 

    [JsonProperty("admin_only", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AdminOnly { get; set; } 

    [JsonProperty("org_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OrgId { get; set; } 

    [JsonProperty("department_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DepartmentId { get; set; } 

    [JsonProperty("team_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TeamId { get; set; } 

    [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AgentId { get; set; } 

    [JsonProperty("org_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OrgName { get; set; } 

    [JsonProperty("department_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DepartmentName { get; set; } 

    [JsonProperty("team_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TeamName { get; set; } 

    [JsonProperty("display_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DisplayType { get; set; } 

    [JsonProperty("restriction_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RestrictionType { get; set; } 

    [JsonProperty("layouts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Layouts { get; set; } 

    [JsonProperty("widgets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Widget>? Widgets { get; set; } 

    [JsonProperty("access_control", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AccessControl>? AccessControl { get; set; } 

    [JsonProperty("access_control_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AccessControlLevel { get; set; } 

    [JsonProperty("report_access_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ReportAccessToken { get; set; } 

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
    public ICollection<DashboardRestriction>? UserAccess { get; set; } 

    [JsonProperty("is_published", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsPublished { get; set; } 

    [JsonProperty("published_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PublishedId { get; set; } 

    [JsonProperty("allow_anonymous", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowAnonymous { get; set; } 

    [JsonProperty("rowheight", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Rowheight { get; set; } 

    [JsonProperty("manually_load_dashboards", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ManuallyLoadDashboards { get; set; } 

    [JsonProperty("dashboard_theme_override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DashboardThemeOverride { get; set; } 

    [JsonProperty("list_item_height", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ListItemHeight { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}