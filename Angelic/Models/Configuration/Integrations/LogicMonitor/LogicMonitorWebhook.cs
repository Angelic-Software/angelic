using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.LogicMonitor;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class LogicMonitorWebhook
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Id { get; set; } 

    [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Status { get; set; } 

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Type { get; set; } 

    [JsonProperty("message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Message { get; set; } 

    [JsonProperty("level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Level { get; set; } 

    [JsonProperty("host", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Host { get; set; } 

    [JsonProperty("datasource", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Datasource { get; set; } 

    [JsonProperty("admin", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Admin { get; set; } 

    [JsonProperty("ticketid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Ticketid { get; set; } 

    [JsonProperty("halo_customer_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? HaloCustomerId { get; set; } 

    [JsonProperty("halo_customer_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? HaloCustomerName { get; set; } 

}