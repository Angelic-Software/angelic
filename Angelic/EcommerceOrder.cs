using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class EcommerceOrder
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("moduleid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Moduleid { get; set; } 

    [JsonProperty("thirdpartyid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Thirdpartyid { get; set; } 

    [JsonProperty("thirdpartyurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Thirdpartyurl { get; set; } 

    [JsonProperty("thirdpartyordernumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Thirdpartyordernumber { get; set; } 

    [JsonProperty("thirdpartycustomerid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Thirdpartycustomerid { get; set; } 

    [JsonProperty("thirdpartystatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Thirdpartystatus { get; set; } 

    [JsonProperty("thirdpartystatus2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Thirdpartystatus2 { get; set; } 

    [JsonProperty("thirdpartycreateddate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Thirdpartycreateddate { get; set; } 

    [JsonProperty("integration_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Integration_name { get; set; } 

    [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Ticket_id { get; set; } 

    [JsonProperty("details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Details_id { get; set; } 

    [JsonProperty("shop_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Shop_name { get; set; } 

    [JsonProperty("_unlink_from_ticket", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _unlink_from_ticket { get; set; } 

    [JsonProperty("jsonobj", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Jsonobj { get; set; } 

    [JsonProperty("_amazon_buyer_info", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public AmazonSellerBuyerInfo? _amazon_buyer_info { get; set; } 

    [JsonProperty("_adobecommerce_billing_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public AdobeCommerceBilling_Address? _adobecommerce_billing_address { get; set; } 

    [JsonProperty("linked_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<EcommerceOrderFault>? Linked_tickets { get; set; } 

}