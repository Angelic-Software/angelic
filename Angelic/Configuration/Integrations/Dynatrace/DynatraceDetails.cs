using System.CodeDom.Compiler;
using Angelic.KeyPairs;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class DynatraceDetails
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Url { get; set; } 

    [JsonProperty("new_integration_key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewIntegrationKey { get; set; } 

    [JsonProperty("new_integration_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? NewIntegrationMethod { get; set; } 

    [JsonProperty("default_devicesite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultDevicesite { get; set; } 

    [JsonProperty("default_devicesite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultDevicesiteName { get; set; } 

    [JsonProperty("default_devicetype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultDevicetype { get; set; } 

    [JsonProperty("default_devicetypename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultDevicetypename { get; set; } 

    [JsonProperty("assetimportidentifier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Assetimportidentifier { get; set; } 

    [JsonProperty("assetimportidentifier_fieldname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AssetimportidentifierFieldname { get; set; } 

    [JsonProperty("host_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IntegrationFieldMapping>? HostFieldmappings { get; set; } 

    [JsonProperty("service_fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IntegrationFieldMapping>? ServiceFieldmappings { get; set; } 

    [JsonProperty("sitemappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<IntegrationSiteMapping>? Sitemappings { get; set; } 

    [JsonProperty("enableintegrator", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Enableintegrator { get; set; } 

    [JsonProperty("lastsyncdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Lastsyncdate { get; set; } 

    [JsonProperty("lastsyncerror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Lastsyncerror { get; set; } 

    [JsonProperty("halo_integrator_import_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? HaloIntegratorImportList { get; set; } 

    [JsonProperty("halo_integrator_import_types", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ValueLabelIsNewKeyPair>? HaloIntegratorImportTypes { get; set; } 

    [JsonProperty("delete_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DeleteDevices { get; set; } 

    [JsonProperty("dont_create_new_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DontCreateNewDevices { get; set; } 

    [JsonProperty("dont_update_device_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DontUpdateDeviceType { get; set; } 

    [JsonProperty("dont_move_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DontMoveSite { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Guid { get; set; } 

    [JsonProperty("mappings_xtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<XTypeMapping>? MappingsXtype { get; set; } 

    [JsonProperty("default_assetgroup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultAssetgroup { get; set; } 

    [JsonProperty("default_assetgroupname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultAssetgroupname { get; set; } 

    [JsonProperty("assettype_choice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AssettypeChoice { get; set; } 

    [JsonProperty("assettype_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AssettypeField { get; set; } 

    [JsonProperty("webhook_username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? WebhookUsername { get; set; } 

    [JsonProperty("new_webhook_password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewWebhookPassword { get; set; } 

    [JsonProperty("webhook_salt", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? WebhookSalt { get; set; } 

    [JsonProperty("webhook_iterations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? WebhookIterations { get; set; } 

    [JsonProperty("enable_alerts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? EnableAlerts { get; set; } 

    [JsonProperty("ticket_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TicketType { get; set; } 

    [JsonProperty("ticket_type_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TicketTypeName { get; set; } 

    [JsonProperty("ticket_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TicketUser { get; set; } 

    [JsonProperty("ticket_user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TicketUserName { get; set; } 

    [JsonProperty("new_webhook_password_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? NewWebhookPasswordMethod { get; set; } 

}