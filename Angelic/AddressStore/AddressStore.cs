using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.AddressStore;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class AddressStore
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; }

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Type { get; set; }

    [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Description { get; set; }

    [JsonProperty("note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Note { get; set; }

    [JsonProperty("line1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Line1 { get; set; }

    [JsonProperty("line2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Line2 { get; set; }

    [JsonProperty("line3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Line3 { get; set; }

    [JsonProperty("line4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Line4 { get; set; }

    [JsonProperty("postcode", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Postcode { get; set; }

    [JsonProperty("primary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Primary { get; set; }

    [JsonProperty("inactive", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Inactive { get; set; }

    [JsonProperty("date_active", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? DateActive { get; set; }

    [JsonProperty("date_inactive", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? DateInactive { get; set; }

    [JsonProperty("lat", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Lat { get; set; }

    [JsonProperty("long", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Long { get; set; }

    [JsonProperty("client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ClientName { get; set; }

    [JsonProperty("site_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SiteId { get; set; }

    [JsonProperty("site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SiteName { get; set; }

    [JsonProperty("user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? UserId { get; set; }

    [JsonProperty("user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? UserName { get; set; }

    [JsonProperty("user_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? UserEmail { get; set; }

    [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsImport { get; set; }

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; }
}
