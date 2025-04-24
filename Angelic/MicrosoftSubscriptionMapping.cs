using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class MicrosoftSubscriptionMapping
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("halo_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Halo_id { get; set; } 

    [JsonProperty("halo_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Halo_name { get; set; } 

    [JsonProperty("microsoft_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Microsoft_id { get; set; } 

    [JsonProperty("microsoft_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Microsoft_name { get; set; } 

    [JsonProperty("site_path", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Site_path { get; set; } 

    [JsonProperty("site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Site_name { get; set; } 

    [JsonProperty("azure_connection_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Azure_connection_id { get; set; } 

    [JsonProperty("_subscriptionaction", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public WebhookSubscriptionAction? _subscriptionaction { get; set; } 

    [JsonProperty("subscription_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Subscription_id { get; set; } 

    [JsonProperty("subscription_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Subscription_expiry { get; set; } 

    [JsonProperty("subscribed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Subscribed { get; set; } 

    [JsonProperty("new_subscription_key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? New_subscription_key { get; set; } 

    [JsonProperty("azure_connection", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public AzureAdConnection? Azure_connection { get; set; } 

    [JsonProperty("_dosave", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _dosave { get; set; } 

    [JsonProperty("mappings_folder", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IntegrationFieldMapping>? Mappings_folder { get; set; } 

    [JsonProperty("sharepoint_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public SharePointList? Sharepoint_list { get; set; } 

    [JsonProperty("sharepoint_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public SharePointSite? Sharepoint_site { get; set; } 

    [JsonProperty("change_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Change_token { get; set; } 

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Type { get; set; } 

    [JsonProperty("fullname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Fullname { get; set; } 

}