using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Assets;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class AssetApplications
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("licence_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? LicenceId { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Count { get; set; } 

    [JsonProperty("did", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Did { get; set; } 

    [JsonProperty("bundledesc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Bundledesc { get; set; } 

    [JsonProperty("cost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Cost { get; set; } 

    [JsonProperty("lastused", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Lastused { get; set; } 

    [JsonProperty("install_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? InstallDate { get; set; } 

    [JsonProperty("snowid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Snowid { get; set; } 

    [JsonProperty("licence_required", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? LicenceRequired { get; set; } 

    [JsonProperty("version", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Version { get; set; } 

    [JsonProperty("licence_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? LicenceName { get; set; } 

    [JsonProperty("user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? UserId { get; set; } 

    [JsonProperty("role_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RoleId { get; set; } 

    [JsonProperty("role_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RoleName { get; set; } 

    [JsonProperty("moduleid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Moduleid { get; set; } 

    [JsonProperty("new_users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Users.User>? NewUsers { get; set; } 

    [JsonProperty("new_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Asset>? NewDevices { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}