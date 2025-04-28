using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.Syncro;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class SyncroAlertAttributes
{
    [JsonProperty("properties", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public SyncroAlertProperties? Properties { get; set; } 

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("customer_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CustomerId { get; set; } 

    [JsonProperty("created_at", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? CreatedAt { get; set; } 

    [JsonProperty("updated_at", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? UpdatedAt { get; set; } 

    [JsonProperty("customer", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public SyncroCustomer? Customer { get; set; } 

    [JsonProperty("asset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public SyncroAlertAsset? Asset { get; set; } 

    [JsonProperty("resolved", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Resolved { get; set; } 

    [JsonProperty("computer_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ComputerName { get; set; } 

}