using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class IntegrationConfiguration
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("application_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Application_url { get; set; } 

    [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Client_id { get; set; } 

    [JsonProperty("new_client_secret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? New_client_secret { get; set; } 

    [JsonProperty("new_access_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? New_access_token { get; set; } 

    [JsonProperty("new_refresh_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? New_refresh_token { get; set; } 

    [JsonProperty("token_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Token_expiry { get; set; } 

    [JsonProperty("redirect_uri", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Redirect_uri { get; set; } 

    [JsonProperty("_isauthorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _isauthorized { get; set; } 

    [JsonProperty("tenant", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Tenant { get; set; } 

    [JsonProperty("resource", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Resource { get; set; } 

    [JsonProperty("new_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? New_method { get; set; } 

    [JsonProperty("alternate_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Alternate_client_id { get; set; } 

    [JsonProperty("new_alternate_client_secret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? New_alternate_client_secret { get; set; } 

    [JsonProperty("client_credentials", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Client_credentials { get; set; } 

    [JsonProperty("password_credentials", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Password_credentials { get; set; } 

    [JsonProperty("webhook_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Webhook_username { get; set; } 

    [JsonProperty("new_webhook_password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? New_webhook_password { get; set; } 

    [JsonProperty("webhook_iterations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Webhook_iterations { get; set; } 

    [JsonProperty("new_webhook_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? New_webhook_method { get; set; } 

    [JsonProperty("last_update", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Last_update { get; set; } 

    [JsonProperty("token_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Token_url { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

}