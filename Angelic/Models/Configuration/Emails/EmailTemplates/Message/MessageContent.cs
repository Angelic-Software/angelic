using System.CodeDom.Compiler;
using Angelic.Models.HtmlDesigns;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Emails.EmailTemplates;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class MessageContent
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Guid { get; set; } 

    [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Intent { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Description { get; set; } 

    [JsonProperty("body_text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? BodyText { get; set; } 

    [JsonProperty("body_sms", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? BodySms { get; set; } 

    [JsonProperty("body_html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? BodyHtml { get; set; } 

    [JsonProperty("design", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public HtmlDesign? Design { get; set; } 

    [JsonProperty("announcement_end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? AnnouncementEndDate { get; set; } 

    [JsonProperty("_isclone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsClone { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("sectionid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SectionId { get; set; } 

    [JsonProperty("header_text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? HeaderText { get; set; } 

    [JsonProperty("access_control", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AccessControl>? AccessControl { get; set; } 

    [JsonProperty("access_control_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AccessControlLevel { get; set; } 

    [JsonProperty("is_single_obj", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsSingleObj { get; set; } 

    [JsonProperty("messagegroup_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MessageGroupId { get; set; } 

}