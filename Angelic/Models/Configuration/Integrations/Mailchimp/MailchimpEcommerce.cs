using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.Mailchimp;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class MailchimpEcommerce
{
    [JsonProperty("total_orders", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TotalOrders { get; set; } 

    [JsonProperty("total_spent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TotalSpent { get; set; } 

    [JsonProperty("total_revenue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TotalRevenue { get; set; } 

}