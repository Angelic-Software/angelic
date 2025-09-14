using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record IntegrationConfiguration
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("application_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ApplicationUrl { get; set; } 

    [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ClientId { get; set; } 

    [JsonProperty("new_client_secret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewClientSecret { get; set; } 

    [JsonProperty("new_access_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewAccessToken { get; set; } 

    [JsonProperty("new_refresh_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewRefreshToken { get; set; } 

    [JsonProperty("token_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? TokenExpiry { get; set; } 

    [JsonProperty("redirect_uri", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RedirectUri { get; set; } 

    [JsonProperty("_isauthorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsAuthorized { get; set; } 

    [JsonProperty("tenant", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Tenant { get; set; } 

    [JsonProperty("resource", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Resource { get; set; } 

    [JsonProperty("new_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? NewMethod { get; set; } 

    [JsonProperty("alternate_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AlternateClientId { get; set; } 

    [JsonProperty("new_alternate_client_secret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewAlternateClientSecret { get; set; } 

    [JsonProperty("client_credentials", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ClientCredentials { get; set; } 

    [JsonProperty("password_credentials", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? PasswordCredentials { get; set; } 

    [JsonProperty("webhook_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? WebhookUsername { get; set; } 

    [JsonProperty("new_webhook_password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewWebhookPassword { get; set; } 

    [JsonProperty("webhook_iterations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? WebhookIterations { get; set; } 

    [JsonProperty("new_webhook_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? NewWebhookMethod { get; set; } 

    [JsonProperty("last_update", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? LastUpdate { get; set; } 

    [JsonProperty("token_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TokenUrl { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}