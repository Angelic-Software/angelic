using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.Mailchimp;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class MailchimpVariateSettings
{
    [JsonProperty("winning_combination_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? WinningCombinationId { get; set; } 

    [JsonProperty("winning_campaign_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? WinningCampaignId { get; set; } 

    [JsonProperty("winner_criteria", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? WinnerCriteria { get; set; } 

    [JsonProperty("wait_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? WaitTime { get; set; } 

    [JsonProperty("test_size", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TestSize { get; set; } 

    [JsonProperty("subject_lines", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<string>? SubjectLines { get; set; } 

    [JsonProperty("send_times", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<DateTimeOffset>? SendTimes { get; set; } 

    [JsonProperty("from_names", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<string>? FromNames { get; set; } 

    [JsonProperty("reply_to_addresses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<string>? ReplyToAddresses { get; set; } 

    [JsonProperty("contents", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<string>? Contents { get; set; } 

    [JsonProperty("combinations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<MailchimpCombination>? Combinations { get; set; } 

}