using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class MailchimpCombination
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Id { get; set; } 

    [JsonProperty("subject_line", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SubjectLine { get; set; } 

    [JsonProperty("send_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SendTime { get; set; } 

    [JsonProperty("from_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? FromName { get; set; } 

    [JsonProperty("reply_to", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ReplyTo { get; set; } 

    [JsonProperty("content_description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ContentDescription { get; set; } 

    [JsonProperty("recipients", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Recipients { get; set; } 

}