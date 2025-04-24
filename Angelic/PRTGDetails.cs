using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class PRTGDetails
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Url { get; set; } 

    [JsonProperty("username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Username { get; set; } 

    [JsonProperty("new_password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? New_password { get; set; } 

    [JsonProperty("new_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? New_method { get; set; } 

    [JsonProperty("defsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Defsite { get; set; } 

    [JsonProperty("site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Site_name { get; set; } 

    [JsonProperty("defassettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Defassettype { get; set; } 

    [JsonProperty("assettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Assettype_name { get; set; } 

    [JsonProperty("assetmatchingfield_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Assetmatchingfield_name { get; set; } 

    [JsonProperty("assetmatchingfield", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Assetmatchingfield { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

    [JsonProperty("halointegratorenabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Halointegratorenabled { get; set; } 

    [JsonProperty("halointegratorlasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Halointegratorlasterror { get; set; } 

    [JsonProperty("halointegratorlastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Halointegratorlastsync { get; set; } 

    [JsonProperty("asset_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IntegrationFieldMapping>? Asset_fieldmappings { get; set; } 

    [JsonProperty("enable_webhooks", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Enable_webhooks { get; set; } 

    [JsonProperty("new_webhook_secret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? New_webhook_secret { get; set; } 

    [JsonProperty("webhook_ticket_type_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Webhook_ticket_type_id { get; set; } 

    [JsonProperty("webhook_ticket_user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Webhook_ticket_user_id { get; set; } 

    [JsonProperty("webhook_ticket_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Webhook_ticket_user_name { get; set; } 

    [JsonProperty("webhook_ticket_summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Webhook_ticket_summary { get; set; } 

    [JsonProperty("webhook_ticket_details", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Webhook_ticket_details { get; set; } 

    [JsonProperty("webhook_autoclosure_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Webhook_autoclosure_status { get; set; } 

}