using System.CodeDom.Compiler;
using Angelic.KeyPairs;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class SnowDetails
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Url { get; set; } 

    [JsonProperty("username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Username { get; set; } 

    [JsonProperty("sdpassword", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Sdpassword { get; set; } 

    [JsonProperty("new_integration_key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? New_integration_key { get; set; } 

    [JsonProperty("new_integration_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? New_integration_method { get; set; } 

    [JsonProperty("toplevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Toplevel { get; set; } 

    [JsonProperty("toplevel_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Toplevel_name { get; set; } 

    [JsonProperty("default_devicesite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Default_devicesite { get; set; } 

    [JsonProperty("default_devicesite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Default_devicesite_name { get; set; } 

    [JsonProperty("default_devicetype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Default_devicetype { get; set; } 

    [JsonProperty("default_devicetypename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Default_devicetypename { get; set; } 

    [JsonProperty("user_matching_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? User_matching_type { get; set; } 

    [JsonProperty("assetimportidentifier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Assetimportidentifier { get; set; } 

    [JsonProperty("assetimportidentifier_fieldname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Assetimportidentifier_fieldname { get; set; } 

    [JsonProperty("snow_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IntegrationFieldMapping>? Snow_fieldmappings { get; set; } 

    [JsonProperty("enableintegrator", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Enableintegrator { get; set; } 

    [JsonProperty("lastsyncdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Lastsyncdate { get; set; } 

    [JsonProperty("lastsyncerror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Lastsyncerror { get; set; } 

    [JsonProperty("halo_integrator_import_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Halo_integrator_import_list { get; set; } 

    [JsonProperty("halo_integrator_import_types", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ValueLabelIsNewKeyPair>? Halo_integrator_import_types { get; set; } 

    [JsonProperty("delete_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Delete_devices { get; set; } 

    [JsonProperty("dont_create_new_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Dont_create_new_devices { get; set; } 

    [JsonProperty("dont_update_device_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Dont_update_device_type { get; set; } 

    [JsonProperty("dont_move_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Dont_move_site { get; set; } 

    [JsonProperty("dont_update_site_addresses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Dont_update_site_addresses { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

    [JsonProperty("client_links", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ExternalLink_List>? Client_links { get; set; } 

    [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Guid { get; set; } 

}