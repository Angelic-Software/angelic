using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class DeviceApplications
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("licence_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Licence_id { get; set; } 

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
    public DateTimeOffset? Install_date { get; set; } 

    [JsonProperty("snowid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Snowid { get; set; } 

    [JsonProperty("licence_required", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Licence_required { get; set; } 

    [JsonProperty("version", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Version { get; set; } 

    [JsonProperty("licence_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Licence_name { get; set; } 

    [JsonProperty("user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? User_id { get; set; } 

    [JsonProperty("role_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Role_id { get; set; } 

    [JsonProperty("role_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Role_name { get; set; } 

    [JsonProperty("moduleid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Moduleid { get; set; } 

    [JsonProperty("new_users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Users>? New_users { get; set; } 

    [JsonProperty("new_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Device>? New_devices { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

}