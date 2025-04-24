using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class KBEntry_List
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Description { get; set; } 

    [JsonProperty("view_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? View_count { get; set; } 

    [JsonProperty("useful_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Useful_count { get; set; } 

    [JsonProperty("notuseful_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Notuseful_count { get; set; } 

    [JsonProperty("date_created", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Date_created { get; set; } 

    [JsonProperty("date_edited", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Date_edited { get; set; } 

    [JsonProperty("tag_string", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Tag_string { get; set; } 

    [JsonProperty("inactive", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Inactive { get; set; } 

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Type { get; set; } 

    [JsonProperty("next_review_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Next_review_date { get; set; } 

    [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomField>? Customfields { get; set; } 

    [JsonProperty("limit_start_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Limit_start_date { get; set; } 

    [JsonProperty("limit_end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Limit_end_date { get; set; } 

    [JsonProperty("editor_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Editor_type { get; set; } 

    [JsonProperty("kb_tags", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Kb_tags { get; set; } 

    [JsonProperty("confluence_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Confluence_url { get; set; } 

    [JsonProperty("search_score", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Search_score { get; set; } 

    [JsonProperty("resolution_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Resolution_list { get; set; } 

    [JsonProperty("link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Link { get; set; } 

    [JsonProperty("geo_restrictions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<GeoLocationRestriction>? Geo_restrictions { get; set; } 

    [JsonProperty("use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Use { get; set; } 

    [JsonProperty("key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Key { get; set; } 

    [JsonProperty("table", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public TableEnum? Table { get; set; } 

    [JsonProperty("ticket_template_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Ticket_template_id { get; set; } 

    [JsonProperty("_importtypeid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? _importtypeid { get; set; } 

    [JsonProperty("_importthirdpartyid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _importthirdpartyid { get; set; } 

    [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _importtype { get; set; } 

    [JsonProperty("new_external_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ExternalLink_List? New_external_link { get; set; } 

}