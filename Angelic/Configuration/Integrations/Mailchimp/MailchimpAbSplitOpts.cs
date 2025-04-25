using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Configuration.Integrations.Mailchimp;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class MailchimpAbSplitOpts
{
    [JsonProperty("split_test", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SplitTest { get; set; } 

    [JsonProperty("pick_winner", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PickWinner { get; set; } 

    [JsonProperty("wait_units", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? WaitUnits { get; set; } 

    [JsonProperty("wait_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? WaitTime { get; set; } 

    [JsonProperty("split_size", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SplitSize { get; set; } 

    [JsonProperty("from_name_a", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? FromNameA { get; set; } 

    [JsonProperty("from_name_b", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? FromNameB { get; set; } 

    [JsonProperty("reply_email_a", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ReplyEmailA { get; set; } 

    [JsonProperty("reply_email_b", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ReplyEmailB { get; set; } 

    [JsonProperty("subject_a", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SubjectA { get; set; } 

    [JsonProperty("subject_b", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SubjectB { get; set; } 

    [JsonProperty("send_time_a", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? SendTimeA { get; set; } 

    [JsonProperty("send_time_b", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? SendTimeB { get; set; } 

    [JsonProperty("send_time_winner", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SendTimeWinner { get; set; } 

}