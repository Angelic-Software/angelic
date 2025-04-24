using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

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
    public string? Body_text { get; set; } 

    [JsonProperty("body_sms", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Body_sms { get; set; } 

    [JsonProperty("body_html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Body_html { get; set; } 

    [JsonProperty("design", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public HtmlDesign? Design { get; set; } 

    [JsonProperty("announcement_end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Announcement_end_date { get; set; } 

    [JsonProperty("_isclone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _isclone { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

    [JsonProperty("sectionid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sectionid { get; set; } 

    [JsonProperty("header_text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Header_text { get; set; } 

    [JsonProperty("access_control", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AccessControl>? Access_control { get; set; } 

    [JsonProperty("access_control_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Access_control_level { get; set; } 

    [JsonProperty("is_single_obj", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Is_single_obj { get; set; } 

    [JsonProperty("messagegroup_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Messagegroup_id { get; set; } 

}