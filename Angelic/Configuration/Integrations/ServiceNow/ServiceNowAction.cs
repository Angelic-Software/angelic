using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Configuration.Integrations.ServiceNow;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ServiceNowAction
{
    [JsonProperty("sys_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SysId { get; set; } 

    [JsonProperty("sys_created_on", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SysCreatedOn { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("element_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ElementId { get; set; } 

    [JsonProperty("sys_tags", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SysTags { get; set; } 

    [JsonProperty("value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Value { get; set; } 

    [JsonProperty("sys_created_by", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SysCreatedBy { get; set; } 

    [JsonProperty("element", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Element { get; set; } 

    [JsonProperty("halo_key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? HaloKey { get; set; } 

    [JsonProperty("halo_client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? HaloClientId { get; set; } 

}