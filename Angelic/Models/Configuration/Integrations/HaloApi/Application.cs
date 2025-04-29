using System.CodeDom.Compiler;
using Angelic.Models.Configuration.Integrations.OpenIddict;
using Angelic.Models.KeyPairs;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.HaloApi;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Application
{
    [JsonProperty("grant_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? GrantType { get; set; } 

    [JsonProperty("loginas_agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? LoginasAgentId { get; set; } 

    [JsonProperty("loginas_agent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? LoginasAgentName { get; set; } 

    [JsonProperty("inactive", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Inactive { get; set; } 

    [JsonProperty("system_use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SystemUse { get; set; } 

    [JsonProperty("redirecturi", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Redirecturi { get; set; } 

    [JsonProperty("logoutredirecturi", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Logoutredirecturi { get; set; } 

    [JsonProperty("cors_whitelist", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CorsWhitelist { get; set; } 

    [JsonProperty("redirecturi_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ValueLabelIsNewKeyPair>? RedirecturiList { get; set; } 

    [JsonProperty("postlogoutredirecturi_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ValueLabelIsNewKeyPair>? PostlogoutredirecturiList { get; set; } 

    [JsonProperty("cors_whitelist_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ValueLabelIsNewKeyPair>? CorsWhitelistList { get; set; } 

    [JsonProperty("scopes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ApplicationScope>? Scopes { get; set; } 

    [JsonProperty("allowagents", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Allowagents { get; set; } 

    [JsonProperty("allowusers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowUsers { get; set; } 

    [JsonProperty("organisation_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OrganisationId { get; set; } 

    [JsonProperty("organisation_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OrganisationName { get; set; } 

    [JsonProperty("loginas_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? LoginasClientId { get; set; } 

    [JsonProperty("loginas_client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? LoginasClientName { get; set; } 

    [JsonProperty("loginas_supplier_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? LoginasSupplierId { get; set; } 

    [JsonProperty("loginas_supplier_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? LoginasSupplierName { get; set; } 

    [JsonProperty("loginentity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Loginentity { get; set; } 

    [JsonProperty("language_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? LanguageId { get; set; } 

    [JsonProperty("language_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? LanguageName { get; set; } 

    [JsonProperty("disable_windowsauth", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DisableWindowsauth { get; set; } 

    [JsonProperty("disable_azure", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DisableAzure { get; set; } 

    [JsonProperty("disable_adfs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DisableAdfs { get; set; } 

    [JsonProperty("disable_okta", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DisableOkta { get; set; } 

    [JsonProperty("disable_centrify", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DisableCentrify { get; set; } 

    [JsonProperty("disable_google", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DisableGoogle { get; set; } 

    [JsonProperty("button_config", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<LoginScreenConfig>? ButtonConfig { get; set; } 

    [JsonProperty("assertion_consumer_service_index", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AssertionConsumerServiceIndex { get; set; } 

    [JsonProperty("disable_anon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DisableAnon { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("_issystem", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Issystem { get; set; } 

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