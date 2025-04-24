using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class MarketingUnsubscribe
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("mailcampaign_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Mailcampaign_id { get; set; } 

    [JsonProperty("user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? User_id { get; set; } 

    [JsonProperty("email_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Email_address { get; set; } 

    [JsonProperty("email_unsubscribed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Email_unsubscribed { get; set; } 

    [JsonProperty("date_unsubscribed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Date_unsubscribed { get; set; } 

    [JsonProperty("user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? User_name { get; set; } 

    [JsonProperty("mailcampaign_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Mailcampaign_name { get; set; } 

    [JsonProperty("email_unsubscribed_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Email_unsubscribed_name { get; set; } 

    [JsonProperty("token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Token { get; set; } 

    [JsonProperty("validate_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Validate_token { get; set; } 

    [JsonProperty("unsub_all", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Unsub_all { get; set; } 

}