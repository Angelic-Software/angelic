using System.CodeDom.Compiler;
using Angelic.Models.Configuration.Custom.CustomFields;
using Angelic.Models.ExternalLinks;
using Newtonsoft.Json;

namespace Angelic.Models.KnowledgeBase;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record KbArticleList
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Description { get; set; } 

    [JsonProperty("view_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ViewCount { get; set; } 

    [JsonProperty("useful_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? UsefulCount { get; set; } 

    [JsonProperty("notuseful_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? NotUsefulCount { get; set; } 

    [JsonProperty("date_created", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? DateCreated { get; set; } 

    [JsonProperty("date_edited", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? DateEdited { get; set; } 

    [JsonProperty("tag_string", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TagString { get; set; } 

    [JsonProperty("inactive", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Inactive { get; set; } 

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Type { get; set; } 

    [JsonProperty("next_review_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? NextReviewDate { get; set; } 

    [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomField>? CustomFields { get; set; } 

    [JsonProperty("limit_start_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? LimitStartDate { get; set; } 

    [JsonProperty("limit_end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? LimitEndDate { get; set; } 

    [JsonProperty("editor_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? EditorType { get; set; } 

    [JsonProperty("kb_tags", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? KbTags { get; set; } 

    [JsonProperty("confluence_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ConfluenceUrl { get; set; } 

    [JsonProperty("search_score", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? SearchScore { get; set; } 

    [JsonProperty("resolution_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ResolutionList { get; set; } 

    [JsonProperty("link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Link { get; set; } 

    [JsonProperty("geo_restrictions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<GeoLocationRestriction>? GeoRestrictions { get; set; } 

    [JsonProperty("use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Use { get; set; } 

    [JsonProperty("key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Key { get; set; } 

    [JsonProperty("table", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Table { get; set; } 

    [JsonProperty("ticket_template_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TicketTemplateId { get; set; } 

    [JsonProperty("_importtypeid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ImportTypeId { get; set; } 

    [JsonProperty("_importthirdpartyid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ImportThirdPartyId { get; set; } 

    [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ImportType { get; set; } 

    [JsonProperty("new_external_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ExternalLink? NewExternalLink { get; set; } 

}