using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class MailchimpVariate_Settings
{
    [JsonProperty("winning_combination_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Winning_combination_id { get; set; } 

    [JsonProperty("winning_campaign_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Winning_campaign_id { get; set; } 

    [JsonProperty("winner_criteria", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Winner_criteria { get; set; } 

    [JsonProperty("wait_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Wait_time { get; set; } 

    [JsonProperty("test_size", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Test_size { get; set; } 

    [JsonProperty("subject_lines", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<string>? Subject_lines { get; set; } 

    [JsonProperty("send_times", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<DateTimeOffset>? Send_times { get; set; } 

    [JsonProperty("from_names", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<string>? From_names { get; set; } 

    [JsonProperty("reply_to_addresses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<string>? Reply_to_addresses { get; set; } 

    [JsonProperty("contents", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<string>? Contents { get; set; } 

    [JsonProperty("combinations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<MailchimpCombination>? Combinations { get; set; } 

}