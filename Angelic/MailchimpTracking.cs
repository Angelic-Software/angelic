using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class MailchimpTracking
{
    [JsonProperty("opens", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Opens { get; set; } 

    [JsonProperty("html_clicks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Html_clicks { get; set; } 

    [JsonProperty("text_clicks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Text_clicks { get; set; } 

    [JsonProperty("goal_tracking", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Goal_tracking { get; set; } 

    [JsonProperty("ecomm360", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Ecomm360 { get; set; } 

    [JsonProperty("google_analytics", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Google_analytics { get; set; } 

    [JsonProperty("clicktale", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Clicktale { get; set; } 

    [JsonProperty("salesforce", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public MailchimpSalesforce? Salesforce { get; set; } 

    [JsonProperty("capsule", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public MailchimpCapsule? Capsule { get; set; } 

}