using System.CodeDom.Compiler;
using Angelic.Configuration.CustomField;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Tabname
{
    [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Intent { get; set; } 

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Guid { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("tableid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Tableid { get; set; } 

    [JsonProperty("columns", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Columns { get; set; } 

    [JsonProperty("sequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sequence { get; set; } 

    [JsonProperty("fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<FieldInfo>? Fields { get; set; } 

    [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Url { get; set; } 

    [JsonProperty("linked_dashboard_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? LinkedDashboardId { get; set; } 

    [JsonProperty("icon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Icon { get; set; } 

    [JsonProperty("send_secure_url_parameter", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? SendSecureUrlParameter { get; set; } 

    [JsonProperty("new_iframe_secret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewIframeSecret { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("module_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ModuleId { get; set; } 

}