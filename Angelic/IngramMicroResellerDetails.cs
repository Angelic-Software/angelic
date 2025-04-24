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
    public bool? New_method { get; set; } 

    [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Client_id { get; set; } 

    [JsonProperty("customer_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Customer_number { get; set; } 

    [JsonProperty("country_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Country_code { get; set; } 

    [JsonProperty("correlation_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Correlation_id { get; set; } 

    [JsonProperty("company_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Company_id { get; set; } 

    [JsonProperty("receive_order_status_updated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Receive_order_status_updated { get; set; } 

    [JsonProperty("receive_quote_to_order", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Receive_quote_to_order { get; set; } 

    [JsonProperty("auto_create_purchase_order", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Auto_create_purchase_order { get; set; } 

    [JsonProperty("sync_entities", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Sync_entities { get; set; } 

    [JsonProperty("sync_entities_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ValueLabelIsNewKeyPair>? Sync_entities_list { get; set; } 

    [JsonProperty("api_app_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Api_app_type { get; set; } 

    [JsonProperty("reseller_site", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Reseller_site { get; set; } 

    [JsonProperty("delivery_address_auto_po", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Delivery_address_auto_po { get; set; } 

    [JsonProperty("order_status_canceled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Order_status_canceled { get; set; } 

    [JsonProperty("order_status_backordered", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Order_status_backordered { get; set; } 

    [JsonProperty("order_status_processing", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Order_status_processing { get; set; } 

    [JsonProperty("order_status_hold", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Order_status_hold { get; set; } 

    [JsonProperty("order_status_delivered", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Order_status_delivered { get; set; } 

    [JsonProperty("new_client_secret", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? New_client_secret { get; set; } 

    [JsonProperty("new_access_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? New_access_token { get; set; } 

    [JsonProperty("new_webhook_signature", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? New_webhook_signature { get; set; } 

    [JsonProperty("company_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Company_name { get; set; } 

    [JsonProperty("ordered_status_canceled_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Ordered_status_canceled_name { get; set; } 

    [JsonProperty("order_status_backordered_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Order_status_backordered_name { get; set; } 

    [JsonProperty("order_status_processing_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Order_status_processing_name { get; set; } 

    [JsonProperty("order_status_hold_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Order_status_hold_name { get; set; } 

    [JsonProperty("order_status_delivered_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Order_status_delivered_name { get; set; } 

    [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Guid { get; set; } 

    [JsonProperty("default_assetgroup_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Default_assetgroup_id { get; set; } 

    [JsonProperty("default_assetgroup_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Default_assetgroup_name { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

}