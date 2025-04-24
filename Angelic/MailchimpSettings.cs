using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class MailchimpSettings
{
    [JsonProperty("subject_line", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Subject_line { get; set; } 

    [JsonProperty("preview_text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Preview_text { get; set; } 

    [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Title { get; set; } 

    [JsonProperty("from_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? From_name { get; set; } 

    [JsonProperty("reply_to", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Reply_to { get; set; } 

    [JsonProperty("use_conversation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Use_conversation { get; set; } 

    [JsonProperty("to_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? To_name { get; set; } 

    [JsonProperty("folder_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Folder_id { get; set; } 

    [JsonProperty("authenticate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Authenticate { get; set; } 

    [JsonProperty("auto_footer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Auto_footer { get; set; } 

    [JsonProperty("inline_css", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Inline_css { get; set; } 

    [JsonProperty("auto_tweet", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Auto_tweet { get; set; } 

    [JsonProperty("auto_fb_post", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<string>? Auto_fb_post { get; set; } 

    [JsonProperty("fb_comments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Fb_comments { get; set; } 

    [JsonProperty("timewarp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Timewarp { get; set; } 

    [JsonProperty("template_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Template_id { get; set; } 

    [JsonProperty("drag_and_drop", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Drag_and_drop { get; set; } 

}