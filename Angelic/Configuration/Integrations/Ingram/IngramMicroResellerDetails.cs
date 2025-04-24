using System.CodeDom.Compiler;
using Angelic.KeyPairs;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class IngramMicroResellerDetails
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("new_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? NewMethod { get; set; } 

    [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ClientId { get; set; } 

    [JsonProperty("customer_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CustomerNumber { get; set; } 

    [JsonProperty("country_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CountryCode { get; set; } 

    [JsonProperty("correlation_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CorrelationId { get; set; } 

    [JsonProperty("company_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CompanyId { get; set; } 

    [JsonProperty("receive_order_status_updated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ReceiveOrderStatusUpdated { get; set; } 

    [JsonProperty("receive_quote_to_order", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ReceiveQuoteToOrder { get; set; } 

    [JsonProperty("auto_create_purchase_order", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AutoCreatePurchaseOrder { get; set; } 

    [JsonProperty("sync_entities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SyncEntities { get; set; } 

    [JsonProperty("sync_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ValueLabelIsNewKeyPair>? SyncEntitiesList { get; set; } 

    [JsonProperty("api_app_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ApiAppType { get; set; } 

    [JsonProperty("reseller_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ResellerSite { get; set; } 

    [JsonProperty("delivery_address_auto_po", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DeliveryAddressAutoPo { get; set; } 

    [JsonProperty("order_status_canceled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OrderStatusCanceled { get; set; } 

    [JsonProperty("order_status_backordered", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OrderStatusBackordered { get; set; } 

    [JsonProperty("order_status_processing", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OrderStatusProcessing { get; set; } 

    [JsonProperty("order_status_hold", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OrderStatusHold { get; set; } 

    [JsonProperty("order_status_delivered", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OrderStatusDelivered { get; set; } 

    [JsonProperty("new_client_secret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewClientSecret { get; set; } 

    [JsonProperty("new_access_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewAccessToken { get; set; } 

    [JsonProperty("new_webhook_signature", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewWebhookSignature { get; set; } 

    [JsonProperty("company_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CompanyName { get; set; } 

    [JsonProperty("ordered_status_canceled_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OrderedStatusCanceledName { get; set; } 

    [JsonProperty("order_status_backordered_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OrderStatusBackorderedName { get; set; } 

    [JsonProperty("order_status_processing_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OrderStatusProcessingName { get; set; } 

    [JsonProperty("order_status_hold_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OrderStatusHoldName { get; set; } 

    [JsonProperty("order_status_delivered_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OrderStatusDeliveredName { get; set; } 

    [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Guid { get; set; } 

    [JsonProperty("default_assetgroup_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DefaultAssetgroupId { get; set; } 

    [JsonProperty("default_assetgroup_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultAssetgroupName { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}