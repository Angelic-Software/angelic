using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Configuration.SelfServicePortal;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ServiceRestriction
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("service_category_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ServiceCategoryId { get; set; } 

    [JsonProperty("service_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ServiceId { get; set; } 

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Type { get; set; } 

    [JsonProperty("data_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DataId { get; set; } 

    [JsonProperty("svrdata_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? SvrdataGuid { get; set; } 

    [JsonProperty("data_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DataName { get; set; } 

    [JsonProperty("service_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ServiceName { get; set; } 

    [JsonProperty("allow_access", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowAccess { get; set; } 

    [JsonProperty("data_string", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DataString { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}