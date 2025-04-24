using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class KandjiDetails
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Url { get; set; } 

    [JsonProperty("apiurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Apiurl { get; set; } 

    [JsonProperty("new_integration_key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? New_integration_key { get; set; } 

    [JsonProperty("new_integration_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? New_integration_method { get; set; } 

    [JsonProperty("default_devicesite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Default_devicesite { get; set; } 

    [JsonProperty("default_devicesite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Default_devicesite_name { get; set; } 

    [JsonProperty("default_devicetype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Default_devicetype { get; set; } 

    [JsonProperty("default_devicetypename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Default_devicetypename { get; set; } 

    [JsonProperty("assetimportidentifier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Assetimportidentifier { get; set; } 

    [JsonProperty("assetimportidentifier_fieldname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Assetimportidentifier_fieldname { get; set; } 

    [JsonProperty("fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IntegrationFieldMapping>? Fieldmappings { get; set; } 

    [JsonProperty("sitemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IntegrationSiteMapping>? Sitemappings { get; set; } 

    [JsonProperty("enableintegrator", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Enableintegrator { get; set; } 

    [JsonProperty("lastsyncdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Lastsyncdate { get; set; } 

    [JsonProperty("lastsyncerror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Lastsyncerror { get; set; } 

    [JsonProperty("delete_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Delete_devices { get; set; } 

    [JsonProperty("dont_create_new_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Dont_create_new_devices { get; set; } 

    [JsonProperty("dont_update_device_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Dont_update_device_type { get; set; } 

    [JsonProperty("dont_move_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Dont_move_site { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

    [JsonProperty("mappings_xtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<XTypeMapping>? Mappings_xtype { get; set; } 

    [JsonProperty("default_assetgroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Default_assetgroup { get; set; } 

    [JsonProperty("default_assetgroupname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Default_assetgroupname { get; set; } 

    [JsonProperty("assettype_choice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Assettype_choice { get; set; } 

    [JsonProperty("assettype_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Assettype_field { get; set; } 

}