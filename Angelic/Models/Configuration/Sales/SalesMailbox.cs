using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Sales;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record SalesMailbox
{
    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Type { get; set; } 

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("tenantid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TenantId { get; set; } 

    [JsonProperty("applicationid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ApplicationId { get; set; } 

    [JsonProperty("new_client_secret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewClientSecret { get; set; } 

    [JsonProperty("new_access_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewAccessToken { get; set; } 

    [JsonProperty("new_refresh_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewRefreshToken { get; set; } 

    [JsonProperty("token_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? TokenExpiry { get; set; } 

    [JsonProperty("halointegrator_enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? HaloIntegratorEnabled { get; set; } 

    [JsonProperty("halointegrator_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? HaloIntegratorLastSync { get; set; } 

    [JsonProperty("halointegrator_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? HaloIntegratorLastError { get; set; } 

    [JsonProperty("redirect_uri", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RedirectUri { get; set; } 

    [JsonProperty("_authcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Authcode { get; set; } 

    [JsonProperty("_exchangecodefortoken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ExchangeCodeForToken { get; set; } 

    [JsonProperty("mailboxes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<SalesMailboxDetail>? Mailboxes { get; set; } 

    [JsonProperty("authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Authorized { get; set; } 

    [JsonProperty("new_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? NewMethod { get; set; } 

    [JsonProperty("google_authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? GoogleAuthorized { get; set; } 

    [JsonProperty("new_google_access_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewGoogleAccessToken { get; set; } 

    [JsonProperty("new_google_refresh_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewGoogleRefreshToken { get; set; } 

    [JsonProperty("google_token_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? GoogleTokenExpiry { get; set; } 

    [JsonProperty("google_redirect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? GoogleRedirect { get; set; } 

    [JsonProperty("google_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? GoogleEmail { get; set; } 

    [JsonProperty("_getgoogletoken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? GetGoogleToken { get; set; } 

    [JsonProperty("google_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? GoogleCode { get; set; } 

    [JsonProperty("google_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? GoogleType { get; set; } 

    [JsonProperty("graph_host", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? GraphHost { get; set; } 

    [JsonProperty("import_sent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ImportSent { get; set; } 

    [JsonProperty("match_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MatchMethod { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}