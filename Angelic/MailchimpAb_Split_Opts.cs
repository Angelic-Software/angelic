using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class MailchimpAb_Split_Opts
{
    [JsonProperty("split_test", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Split_test { get; set; } 

    [JsonProperty("pick_winner", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Pick_winner { get; set; } 

    [JsonProperty("wait_units", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Wait_units { get; set; } 

    [JsonProperty("wait_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Wait_time { get; set; } 

    [JsonProperty("split_size", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Split_size { get; set; } 

    [JsonProperty("from_name_a", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? From_name_a { get; set; } 

    [JsonProperty("from_name_b", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? From_name_b { get; set; } 

    [JsonProperty("reply_email_a", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Reply_email_a { get; set; } 

    [JsonProperty("reply_email_b", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Reply_email_b { get; set; } 

    [JsonProperty("subject_a", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Subject_a { get; set; } 

    [JsonProperty("subject_b", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Subject_b { get; set; } 

    [JsonProperty("send_time_a", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Send_time_a { get; set; } 

    [JsonProperty("send_time_b", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Send_time_b { get; set; } 

    [JsonProperty("send_time_winner", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Send_time_winner { get; set; } 

}