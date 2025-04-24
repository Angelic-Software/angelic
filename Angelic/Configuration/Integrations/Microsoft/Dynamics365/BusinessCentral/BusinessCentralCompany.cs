using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class BusinessCentralCompany
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Id { get; set; } 

    [JsonProperty("systemVersion", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SystemVersion { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("displayName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DisplayName { get; set; } 

    [JsonProperty("businessProfileId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? BusinessProfileId { get; set; } 

    [JsonProperty("systemCreatedAt", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? SystemCreatedAt { get; set; } 

    [JsonProperty("systemCreatedBy", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SystemCreatedBy { get; set; } 

    [JsonProperty("systemModifiedAt", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? SystemModifiedAt { get; set; } 

    [JsonProperty("systemModifiedBy", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SystemModifiedBy { get; set; } 

}