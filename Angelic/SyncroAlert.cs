using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class SyncroAlert
{
    [JsonProperty("text", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Text { get; set; } 

    [JsonProperty("html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Html { get; set; } 

    [JsonProperty("link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Link { get; set; } 

    [JsonProperty("attributes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public SyncroAlertAttributes? Attributes { get; set; } 

    [JsonProperty("device_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Device_name { get; set; } 

    [JsonProperty("customer_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Customer_name { get; set; } 

    [JsonProperty("created_at", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Created_at { get; set; } 

    [JsonProperty("updated_at", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Updated_at { get; set; } 

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("customer_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Customer_id { get; set; } 

}