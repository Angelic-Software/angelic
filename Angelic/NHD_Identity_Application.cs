using System.CodeDom.Compiler;
using Angelic.KeyPairs;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class NHD_Identity_Application
{
    [JsonProperty("grant_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Grant_type { get; set; } 

    [JsonProperty("loginas_agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Loginas_agent_id { get; set; } 

    [JsonProperty("loginas_agent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Loginas_agent_name { get; set; } 

    [JsonProperty("inactive", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Inactive { get; set; } 

    [JsonProperty("system_use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? System_use { get; set; } 

    [JsonProperty("redirecturi", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Redirecturi { get; set; } 

    [JsonProperty("logoutredirecturi", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Logoutredirecturi { get; set; } 

    [JsonProperty("cors_whitelist", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Cors_whitelist { get; set; } 

    [JsonProperty("redirecturi_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ValueLabelIsNewKeyPair>? Redirecturi_list { get; set; } 

    [JsonProperty("postlogoutredirecturi_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ValueLabelIsNewKeyPair>? Postlogoutredirecturi_list { get; set; } 

    [JsonProperty("cors_whitelist_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ValueLabelIsNewKeyPair>? Cors_whitelist_list { get; set; } 

    [JsonProperty("scopes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<NHD_Identity_ApplicationScope>? Scopes { get; set; } 

    [JsonProperty("allowagents", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Allowagents { get; set; } 

    [JsonProperty("allowusers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Allowusers { get; set; } 

    [JsonProperty("organisation_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Organisation_id { get; set; } 

    [JsonProperty("organisation_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Organisation_name { get; set; } 

    [JsonProperty("loginas_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Loginas_client_id { get; set; } 

    [JsonProperty("loginas_client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Loginas_client_name { get; set; } 

    [JsonProperty("loginas_supplier_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Loginas_supplier_id { get; set; } 

    [JsonProperty("loginas_supplier_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Loginas_supplier_name { get; set; } 

    [JsonProperty("loginentity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Loginentity { get; set; } 

    [JsonProperty("language_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Language_id { get; set; } 

    [JsonProperty("language_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Language_name { get; set; } 

    [JsonProperty("disable_windowsauth", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Disable_windowsauth { get; set; } 

    [JsonProperty("disable_azure", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Disable_azure { get; set; } 

    [JsonProperty("disable_adfs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Disable_adfs { get; set; } 

    [JsonProperty("disable_okta", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Disable_okta { get; set; } 

    [JsonProperty("disable_centrify", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Disable_centrify { get; set; } 

    [JsonProperty("disable_google", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Disable_google { get; set; } 

    [JsonProperty("button_config", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<LoginScreenConfig>? Button_config { get; set; } 

    [JsonProperty("assertion_consumer_service_index", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Assertion_consumer_service_index { get; set; } 

    [JsonProperty("disable_anon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Disable_anon { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

    [JsonProperty("_issystem", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _issystem { get; set; } 

    [JsonProperty("authorizations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<OpenIddictAuthorization>? Authorizations { get; set; } 

    [JsonProperty("clientId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ClientId { get; set; } 

    [JsonProperty("clientSecret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ClientSecret { get; set; } 

    [JsonProperty("concurrencyToken", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ConcurrencyToken { get; set; } 

    [JsonProperty("consentType", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ConsentType { get; set; } 

    [JsonProperty("displayName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DisplayName { get; set; } 

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Id { get; set; } 

    [JsonProperty("permissions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Permissions { get; set; } 

    [JsonProperty("postLogoutRedirectUris", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PostLogoutRedirectUris { get; set; } 

    [JsonProperty("properties", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Properties { get; set; } 

    [JsonProperty("redirectUris", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RedirectUris { get; set; } 

    [JsonProperty("tokens", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<OpenIddictToken>? Tokens { get; set; } 

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Type { get; set; } 

}