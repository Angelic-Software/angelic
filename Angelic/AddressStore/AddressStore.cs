using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.AddressStore;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public partial class AddressStore
{
    [JsonProperty("id", Required = JsonRequired.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } = default!;

    [JsonProperty("type", Required = JsonRequired.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Type { get; set; } = default!;

    [JsonProperty("description", Required = JsonRequired.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Description { get; set; } = default!;

    [JsonProperty("note", Required = JsonRequired.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Note { get; set; } = default!;

    [JsonProperty("line1", Required = JsonRequired.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Line1 { get; set; } = default!;

    [JsonProperty("line2", Required = JsonRequired.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Line2 { get; set; } = default!;

    [JsonProperty("line3", Required = JsonRequired.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Line3 { get; set; } = default!;

    [JsonProperty("line4", Required = JsonRequired.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Line4 { get; set; } = default!;

    [JsonProperty("postcode", Required = JsonRequired.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Postcode { get; set; } = default!;

    [JsonProperty("primary", Required = JsonRequired.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Primary { get; set; } = default!;

    [JsonProperty("inactive", Required = JsonRequired.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Inactive { get; set; } = default!;

    [JsonProperty("date_active", Required = JsonRequired.Default, NullValueHandling = NullValueHandling.Ignore)]
    public System.DateTimeOffset? DateActive { get; set; } = default!;

    [JsonProperty("date_inactive", Required = JsonRequired.Default, NullValueHandling = NullValueHandling.Ignore)]
    public System.DateTimeOffset? DateInactive { get; set; } = default!;

    [JsonProperty("lat", Required = JsonRequired.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Lat { get; set; } = default!;

    [JsonProperty("long", Required = JsonRequired.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Long { get; set; } = default!;

    [JsonProperty("client_name", Required = JsonRequired.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ClientName { get; set; } = default!;

    [JsonProperty("site_id", Required = JsonRequired.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SiteId { get; set; } = default!;

    [JsonProperty("site_name", Required = JsonRequired.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SiteName { get; set; } = default!;

    [JsonProperty("user_id", Required = JsonRequired.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? UserId { get; set; } = default!;

    [JsonProperty("user_name", Required = JsonRequired.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? UserName { get; set; } = default!;

    [JsonProperty("user_email", Required = JsonRequired.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? UserEmail { get; set; } = default!;

    [JsonProperty("_isimport", Required = JsonRequired.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsImport { get; set; } = default!;

    [JsonProperty("_warning", Required = JsonRequired.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } = default!;
}
