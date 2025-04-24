using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class XTypeStatus
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("xtype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? XtypeId { get; set; } 

    [JsonProperty("xtype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? XtypeName { get; set; } 

    [JsonProperty("status_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? StatusId { get; set; } 

    [JsonProperty("status_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? StatusName { get; set; } 

    [JsonProperty("allowafterallstatuses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Allowafterallstatuses { get; set; } 

    [JsonProperty("allowedafterstatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<XTypeStatusRestrictions>? Allowedafterstatus { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}