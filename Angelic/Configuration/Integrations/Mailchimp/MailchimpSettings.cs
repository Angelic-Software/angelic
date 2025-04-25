using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Configuration.Integrations.Mailchimp;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class MailchimpSettings
{
    [JsonProperty("subject_line", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SubjectLine { get; set; } 

    [JsonProperty("preview_text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PreviewText { get; set; } 

    [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Title { get; set; } 

    [JsonProperty("from_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? FromName { get; set; } 

    [JsonProperty("reply_to", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ReplyTo { get; set; } 

    [JsonProperty("use_conversation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? UseConversation { get; set; } 

    [JsonProperty("to_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ToName { get; set; } 

    [JsonProperty("folder_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? FolderId { get; set; } 

    [JsonProperty("authenticate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Authenticate { get; set; } 

    [JsonProperty("auto_footer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AutoFooter { get; set; } 

    [JsonProperty("inline_css", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? InlineCss { get; set; } 

    [JsonProperty("auto_tweet", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AutoTweet { get; set; } 

    [JsonProperty("auto_fb_post", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<string>? AutoFbPost { get; set; } 

    [JsonProperty("fb_comments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? FbComments { get; set; } 

    [JsonProperty("timewarp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Timewarp { get; set; } 

    [JsonProperty("template_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TemplateId { get; set; } 

    [JsonProperty("drag_and_drop", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DragAndDrop { get; set; } 

}