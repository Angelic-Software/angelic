using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.SoftwareReleases;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class LicenceInfo
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Id { get; set; } 

    [JsonProperty("site_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SiteId { get; set; } 

    [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ClientId { get; set; } 

    [JsonProperty("client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ClientName { get; set; } 

    [JsonProperty("version", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Version { get; set; } 

    [JsonProperty("apiurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ApiUrl { get; set; } 

    [JsonProperty("organisationname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OrganisationName { get; set; } 

    [JsonProperty("is_trial", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsTrial { get; set; } 

    [JsonProperty("support_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SupportType { get; set; } 

    [JsonProperty("trialexpiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? TrialExpiry { get; set; } 

    [JsonProperty("registrationdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? RegistrationDate { get; set; } 

}