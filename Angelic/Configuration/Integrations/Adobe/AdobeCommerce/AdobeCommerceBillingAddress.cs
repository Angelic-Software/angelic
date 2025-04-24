using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.AdobeCommerceBilling_Address;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class AdobeCommerceBillingAddress
{
    [JsonProperty("address_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AddressType { get; set; }

    [JsonProperty("city", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? City { get; set; }

    [JsonProperty("country_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CountryId { get; set; }

    [JsonProperty("email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Email { get; set; }

    [JsonProperty("entity_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? EntityId { get; set; }

    [JsonProperty("firstname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Firstname { get; set; }

    [JsonProperty("lastname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Lastname { get; set; }

    [JsonProperty("parent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ParentId { get; set; }

    [JsonProperty("postcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Postcode { get; set; }

    [JsonProperty("region", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Region { get; set; }

    [JsonProperty("region_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RegionCode { get; set; }

    [JsonProperty("region_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RegionId { get; set; }

    [JsonProperty("street", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<string>? Street { get; set; }

    [JsonProperty("telephone", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Telephone { get; set; }
}
