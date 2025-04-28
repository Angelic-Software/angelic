using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class SubscriptionQuantityChange
{
    [JsonProperty("licence_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? LicenceId { get; set; } 

    [JsonProperty("current_quantity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CurrentQuantity { get; set; } 

    [JsonProperty("new_quantity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? NewQuantity { get; set; } 

}