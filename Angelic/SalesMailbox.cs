using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class SalesMailbox
{
    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Type { get; set; } 

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("tenantid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Tenantid { get; set; } 

    [JsonProperty("applicationid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Applicationid { get; set; } 

    [JsonProperty("new_client_secret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? New_client_secret { get; set; } 

    [JsonProperty("new_access_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? New_access_token { get; set; } 

    [JsonProperty("new_refresh_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? New_refresh_token { get; set; } 

    [JsonProperty("token_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Token_expiry { get; set; } 

    [JsonProperty("halointegrator_enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Halointegrator_enabled { get; set; } 

    [JsonProperty("halointegrator_lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Halointegrator_lastsync { get; set; } 

    [JsonProperty("halointegrator_lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Halointegrator_lasterror { get; set; } 

    [JsonProperty("redirect_uri", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Redirect_uri { get; set; } 

    [JsonProperty("_authcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _authcode { get; set; } 

    [JsonProperty("_exchangecodefortoken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _exchangecodefortoken { get; set; } 

    [JsonProperty("mailboxes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<SalesMailboxDetail>? Mailboxes { get; set; } 

    [JsonProperty("authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Authorized { get; set; } 

    [JsonProperty("new_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? New_method { get; set; } 

    [JsonProperty("google_authorized", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Google_authorized { get; set; } 

    [JsonProperty("new_google_access_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? New_google_access_token { get; set; } 

    [JsonProperty("new_google_refresh_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? New_google_refresh_token { get; set; } 

    [JsonProperty("google_token_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Google_token_expiry { get; set; } 

    [JsonProperty("google_redirect", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Google_redirect { get; set; } 

    [JsonProperty("google_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Google_email { get; set; } 

    [JsonProperty("_getgoogletoken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _getgoogletoken { get; set; } 

    [JsonProperty("google_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Google_code { get; set; } 

    [JsonProperty("google_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Google_type { get; set; } 

    [JsonProperty("graph_host", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Graph_host { get; set; } 

    [JsonProperty("import_sent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Import_sent { get; set; } 

    [JsonProperty("match_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Match_method { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

}