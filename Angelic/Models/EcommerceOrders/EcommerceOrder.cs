using System.CodeDom.Compiler;
using Angelic.Models.Configuration.Integrations.Adobe.AdobeCommerce;
using Angelic.Models.Configuration.Integrations.Amazon;
using Newtonsoft.Json;

namespace Angelic.Models.EcommerceOrders;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record EcommerceOrder
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("moduleid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ModuleId { get; set; } 

    [JsonProperty("thirdpartyid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ThirdPartyId { get; set; } 

    [JsonProperty("thirdpartyurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ThirdPartyUrl { get; set; } 

    [JsonProperty("thirdpartyordernumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ThirdPartyOrderNumber { get; set; } 

    [JsonProperty("thirdpartycustomerid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ThirdPartyCustomerId { get; set; } 

    [JsonProperty("thirdpartystatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ThirdPartyStatus { get; set; } 

    [JsonProperty("thirdpartystatus2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ThirdPartyStatus2 { get; set; } 

    [JsonProperty("thirdpartycreateddate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? ThirdPartyCreatedDate { get; set; } 

    [JsonProperty("integration_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? IntegrationName { get; set; } 

    [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TicketId { get; set; } 

    [JsonProperty("details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DetailsId { get; set; } 

    [JsonProperty("shop_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ShopName { get; set; } 

    [JsonProperty("_unlink_from_ticket", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? UnlinkFromTicket { get; set; } 

    [JsonProperty("jsonobj", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? JsonObj { get; set; } 

    [JsonProperty("_amazon_buyer_info", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public AmazonSellerBuyerInfo? AmazonBuyerInfo { get; set; } 

    [JsonProperty("_adobecommerce_billing_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public AdobeCommerceBillingAddress? AdobeCommerceBillingAddress { get; set; } 

    [JsonProperty("linked_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<EcommerceOrderTicket>? LinkedTickets { get; set; } 

}