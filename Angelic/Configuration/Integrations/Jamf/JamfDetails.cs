using System.CodeDom.Compiler;
using Angelic.KeyPairs;
using Newtonsoft.Json;

namespace Angelic.Configuration.Integrations.Jamf;

    [GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
    public class JamfDetails
    {
        [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? Id { get; set; } 

        [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Url { get; set; } 

        [JsonProperty("username", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Username { get; set; } 

        [JsonProperty("new_password", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? NewPassword { get; set; } 
    
        [JsonProperty("new_integration_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? NewIntegrationMethod { get; set; } 
    
        [JsonProperty("instancetype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? InstanceType { get; set; } 
    
        [JsonProperty("devicetypes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DeviceTypes { get; set; } 
    
        [JsonProperty("device_types", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ValueLabelIsNewKeyPair>? DeviceTypesList { get; set; } 
    
        [JsonProperty("defaultsite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? DefaultSite { get; set; } 
    
        [JsonProperty("defaultsite_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? DefaultSiteName { get; set; } 
    
        [JsonProperty("site_links", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<ExternalLinkList>? SiteLinks { get; set; } 
    
        [JsonProperty("fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public ICollection<IntegrationFieldMapping>? FieldMappings { get; set; } 
    
        [JsonProperty("sitematchtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? SiteMatchType { get; set; } 
    
        [JsonProperty("computerassettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? ComputerAssetType { get; set; } 
    
        [JsonProperty("computerassettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? ComputerAssetTypeName { get; set; } 
    
        [JsonProperty("mobileassettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? MobileAssetType { get; set; } 
    
        [JsonProperty("mobileassettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? MobileAssetTypeName { get; set; } 
    
        [JsonProperty("assetimportidentifier", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public int? AssetImportIdentifier { get; set; } 
    
        [JsonProperty("assetmatchingfield_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? AssetMatchingFieldName { get; set; } 
    
        [JsonProperty("halointegrator", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? HaloIntegrator { get; set; } 
    
        [JsonProperty("halointegratorerror", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? HaloIntegratorError { get; set; } 
    
        [JsonProperty("halointegratorlastsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? HaloIntegratorLastSync { get; set; } 
    
        [JsonProperty("dontupdateassettype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DontUpdateAssetType { get; set; } 
    
        [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string? Warning { get; set; } 
    
        [JsonProperty("dont_create_new_devices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public bool? DontCreateNewDevices { get; set; } 

    }