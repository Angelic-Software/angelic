using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Configuration.Integrations.Mailchimp;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class MailchimpTracking
{
    [JsonProperty("opens", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Opens { get; set; } 

    [JsonProperty("html_clicks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? HtmlClicks { get; set; } 

    [JsonProperty("text_clicks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? TextClicks { get; set; } 

    [JsonProperty("goal_tracking", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? GoalTracking { get; set; } 

    [JsonProperty("ecomm360", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Ecomm360 { get; set; } 

    [JsonProperty("google_analytics", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? GoogleAnalytics { get; set; } 

    [JsonProperty("clicktale", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Clicktale { get; set; } 

    [JsonProperty("salesforce", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public MailchimpSalesforce? Salesforce { get; set; } 

    [JsonProperty("capsule", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public MailchimpCapsule? Capsule { get; set; } 

}