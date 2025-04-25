using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Area;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class AreaPopup
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ClientId { get; set; } 

    [JsonProperty("site_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SiteId { get; set; } 

    [JsonProperty("user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? UserId { get; set; } 

    [JsonProperty("date_created", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? DateCreated { get; set; } 

    [JsonProperty("note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Note { get; set; } 

    [JsonProperty("dismissable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Dismissable { get; set; } 

    [JsonProperty("read_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ReadStatus { get; set; } 

    [JsonProperty("displaymodal", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Displaymodal { get; set; } 

    [JsonProperty("displayhtml", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Displayhtml { get; set; } 

    [JsonProperty("limitdaterange", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Limitdaterange { get; set; } 

    [JsonProperty("startdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Startdate { get; set; } 

    [JsonProperty("enddate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Enddate { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}