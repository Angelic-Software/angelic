using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class EcommerceOrderFault
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("eo_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Eo_id { get; set; } 

    [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Ticket_id { get; set; } 

    [JsonProperty("third_party_order_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Third_party_order_id { get; set; } 

    [JsonProperty("third_party_order_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Third_party_order_url { get; set; } 

}