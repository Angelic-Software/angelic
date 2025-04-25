using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Configuration.Integrations.Mailchimp;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class MailchimpReportSummary
{
    [JsonProperty("opens", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Opens { get; set; } 

    [JsonProperty("unique_opens", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? UniqueOpens { get; set; } 

    [JsonProperty("open_rate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public float? OpenRate { get; set; } 

    [JsonProperty("clicks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Clicks { get; set; } 

    [JsonProperty("subscriber_clicks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SubscriberClicks { get; set; } 

    [JsonProperty("click_rate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public float? ClickRate { get; set; } 

    [JsonProperty("ecommerce", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public MailchimpEcommerce? Ecommerce { get; set; } 

}