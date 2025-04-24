using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class MailchimpCombination
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Id { get; set; } 

    [JsonProperty("subject_line", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Subject_line { get; set; } 

    [JsonProperty("send_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Send_time { get; set; } 

    [JsonProperty("from_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? From_name { get; set; } 

    [JsonProperty("reply_to", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Reply_to { get; set; } 

    [JsonProperty("content_description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Content_description { get; set; } 

    [JsonProperty("recipients", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Recipients { get; set; } 

}