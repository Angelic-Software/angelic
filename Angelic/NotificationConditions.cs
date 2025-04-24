using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class NotificationConditions
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("rule_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Rule_id { get; set; } 

    [JsonProperty("notification_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Notification_guid { get; set; } 

    [JsonProperty("fieldname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Fieldname { get; set; } 

    [JsonProperty("fieldid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Fieldid { get; set; } 

    [JsonProperty("change_context", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Change_context { get; set; } 

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Type { get; set; } 

    [JsonProperty("value_int", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Value_int { get; set; } 

    [JsonProperty("valueint_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Valueint_guid { get; set; } 

    [JsonProperty("value_string", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Value_string { get; set; } 

    [JsonProperty("value_display", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Value_display { get; set; } 

    [JsonProperty("value_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Value_type { get; set; } 

    [JsonProperty("timezonestring", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Timezonestring { get; set; } 

    [JsonProperty("tablename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Tablename { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

    [JsonProperty("fieldtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Fieldtype { get; set; } 

}