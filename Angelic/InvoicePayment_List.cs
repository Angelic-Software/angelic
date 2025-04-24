using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class InvoicePayment_List
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("invoice_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Invoice_id { get; set; } 

    [JsonProperty("date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Date { get; set; } 

    [JsonProperty("amount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Amount { get; set; } 

    [JsonProperty("method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Method { get; set; } 

    [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Status { get; set; } 

    [JsonProperty("module_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Module_id { get; set; } 

    [JsonProperty("intent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Intent_id { get; set; } 

    [JsonProperty("intent_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Intent_date { get; set; } 

    [JsonProperty("intent_response", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Intent_response { get; set; } 

    [JsonProperty("webhook_payload", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Webhook_payload { get; set; } 

    [JsonProperty("webhook_received_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Webhook_received_date { get; set; } 

    [JsonProperty("sage50_reference", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Sage50_reference { get; set; } 

    [JsonProperty("thirdpartyid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Thirdpartyid { get; set; } 

    [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Client_id { get; set; } 

    [JsonProperty("client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Client_name { get; set; } 

    [JsonProperty("_statuswarning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _statuswarning { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

    [JsonProperty("qbo_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Qbo_id { get; set; } 

    [JsonProperty("xero_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Xero_id { get; set; } 

    [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _isimport { get; set; } 

    [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _importtype { get; set; } 

    [JsonProperty("sqlimport_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sqlimport_id { get; set; } 

    [JsonProperty("invoice_match_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Invoice_match_id { get; set; } 

    [JsonProperty("invoice_invoicenumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Invoice_invoicenumber { get; set; } 

}