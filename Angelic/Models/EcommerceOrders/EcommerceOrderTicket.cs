using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.EcommerceOrders;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class EcommerceOrderTicket
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("eo_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? EoId { get; set; } 

    [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TicketId { get; set; } 

    [JsonProperty("third_party_order_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ThirdPartyOrderId { get; set; } 

    [JsonProperty("third_party_order_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ThirdPartyOrderUrl { get; set; } 

}