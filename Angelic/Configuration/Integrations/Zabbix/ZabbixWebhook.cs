using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Configuration.Integrations.Zabbix;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ZabbixWebhook
{
    [JsonProperty("alert_message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Alert_message { get; set; } 

    [JsonProperty("alert_subject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Alert_subject { get; set; } 

    [JsonProperty("event_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Event_id { get; set; } 

    [JsonProperty("event_nseverity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Event_nseverity { get; set; } 

    [JsonProperty("event_source", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Event_source { get; set; } 

    [JsonProperty("event_tags", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Event_tags { get; set; } 

    [JsonProperty("event_update_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Event_update_status { get; set; } 

    [JsonProperty("event_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Event_value { get; set; } 

    [JsonProperty("trigger_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Trigger_id { get; set; } 

    [JsonProperty("host", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Host { get; set; } 

    [JsonProperty("params", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public IDictionary<string, string?>? Params { get; set; } 

}