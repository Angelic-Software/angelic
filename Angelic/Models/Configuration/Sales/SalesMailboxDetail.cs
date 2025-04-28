using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Sales;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class SalesMailboxDetail
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("smid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Smid { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("enableautomatching", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Enableautomatching { get; set; } 

    [JsonProperty("lastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Lastsync { get; set; } 

    [JsonProperty("sentlastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Sentlastsync { get; set; } 

    [JsonProperty("lasterror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Lasterror { get; set; } 

    [JsonProperty("_hasAccess", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? HasAccess { get; set; } 

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

    [JsonProperty("_getgoogletoken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Getgoogletoken { get; set; } 

    [JsonProperty("agent_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AgentEmail { get; set; } 

    [JsonProperty("_authcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Authcode { get; set; } 

    [JsonProperty("new_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? NewMethod { get; set; } 

    [JsonProperty("applicationid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ApplicationId { get; set; } 

    [JsonProperty("linked_agent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? LinkedAgent { get; set; } 

    [JsonProperty("linked_agent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? LinkedAgentName { get; set; } 

    [JsonProperty("linked_agent_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? LinkedAgentEmail { get; set; } 

    [JsonProperty("match_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MatchType { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}