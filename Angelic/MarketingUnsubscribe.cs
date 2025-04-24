using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class MarketingUnsubscribe
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("mailcampaign_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MailcampaignId { get; set; } 

    [JsonProperty("user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? UserId { get; set; } 

    [JsonProperty("email_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EmailAddress { get; set; } 

    [JsonProperty("email_unsubscribed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? EmailUnsubscribed { get; set; } 

    [JsonProperty("date_unsubscribed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? DateUnsubscribed { get; set; } 

    [JsonProperty("user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? UserName { get; set; } 

    [JsonProperty("mailcampaign_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MailcampaignName { get; set; } 

    [JsonProperty("email_unsubscribed_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EmailUnsubscribedName { get; set; } 

    [JsonProperty("token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Token { get; set; } 

    [JsonProperty("validate_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ValidateToken { get; set; } 

    [JsonProperty("unsub_all", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? UnsubAll { get; set; } 

}