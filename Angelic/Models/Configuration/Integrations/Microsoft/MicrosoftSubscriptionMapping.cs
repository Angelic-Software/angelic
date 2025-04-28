using System.CodeDom.Compiler;
using Angelic.Models.Configuration.Integrations.Microsoft.Azure.AzureAd;
using Angelic.Models.Configuration.Integrations.Microsoft.SharePoint;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.Microsoft;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class MicrosoftSubscriptionMapping
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("halo_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? HaloId { get; set; } 

    [JsonProperty("halo_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? HaloName { get; set; } 

    [JsonProperty("microsoft_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MicrosoftId { get; set; } 

    [JsonProperty("microsoft_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MicrosoftName { get; set; } 

    [JsonProperty("site_path", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SitePath { get; set; } 

    [JsonProperty("site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SiteName { get; set; } 

    [JsonProperty("azure_connection_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AzureConnectionId { get; set; } 

    [JsonProperty("_subscriptionaction", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public WebhookSubscriptionAction? Subscriptionaction { get; set; } 

    [JsonProperty("subscription_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SubscriptionId { get; set; } 

    [JsonProperty("subscription_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? SubscriptionExpiry { get; set; } 

    [JsonProperty("subscribed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Subscribed { get; set; } 

    [JsonProperty("new_subscription_key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewSubscriptionKey { get; set; } 

    [JsonProperty("azure_connection", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public AzureAdConnection? AzureConnection { get; set; } 

    [JsonProperty("_dosave", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Dosave { get; set; } 

    [JsonProperty("mappings_folder", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IntegrationFieldMapping>? MappingsFolder { get; set; } 

    [JsonProperty("sharepoint_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public SharePointList? SharepointList { get; set; } 

    [JsonProperty("sharepoint_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public SharePointSite? SharepointSite { get; set; } 

    [JsonProperty("change_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ChangeToken { get; set; } 

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Type { get; set; } 

    [JsonProperty("fullname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Fullname { get; set; } 

}