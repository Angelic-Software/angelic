using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.Mailchimp;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class MailchimpDeliveryStatus
{
    [JsonProperty("enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Enabled { get; set; } 

    [JsonProperty("can_cancel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CanCancel { get; set; } 

    [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Status { get; set; } 

    [JsonProperty("emails_sent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? EmailsSent { get; set; } 

    [JsonProperty("emails_canceled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? EmailsCanceled { get; set; } 

}