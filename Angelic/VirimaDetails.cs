using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class VirimaDetails
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Url { get; set; } 

    [JsonProperty("tenantid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Tenantid { get; set; } 

    [JsonProperty("new_integration_key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? New_integration_key { get; set; } 

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

    [JsonProperty("use_user_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Use_user_site { get; set; } 

    [JsonProperty("override_site_rules", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Override_site_rules { get; set; } 

    [JsonProperty("dont_remove_users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Dont_remove_users { get; set; } 

    [JsonProperty("relation_sync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Relation_sync { get; set; } 

    [JsonProperty("software_import_licence_matching", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Software_import_licence_matching { get; set; } 

    [JsonProperty("default_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Default_status { get; set; } 

    [JsonProperty("default_status_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Default_status_name { get; set; } 

    [JsonProperty("delete_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Delete_status { get; set; } 

    [JsonProperty("delete_status_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Delete_status_name { get; set; } 

    [JsonProperty("user_matching_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? User_matching_field { get; set; } 

    [JsonProperty("_clearlastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _clearlastsync { get; set; } 

}