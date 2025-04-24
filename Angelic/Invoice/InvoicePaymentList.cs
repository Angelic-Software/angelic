using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class InvoicePaymentList
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("invoice_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? InvoiceId { get; set; } 

    [JsonProperty("date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Date { get; set; } 

    [JsonProperty("amount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Amount { get; set; } 

    [JsonProperty("method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Method { get; set; } 

    [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Status { get; set; } 

    [JsonProperty("module_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ModuleId { get; set; } 

    [JsonProperty("intent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? IntentId { get; set; } 

    [JsonProperty("intent_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? IntentDate { get; set; } 

    [JsonProperty("intent_response", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? IntentResponse { get; set; } 

    [JsonProperty("webhook_payload", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? WebhookPayload { get; set; } 

    [JsonProperty("webhook_received_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? WebhookReceivedDate { get; set; } 

    [JsonProperty("sage50_reference", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Sage50Reference { get; set; } 

    [JsonProperty("thirdpartyid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Thirdpartyid { get; set; } 

    [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ClientId { get; set; } 

    [JsonProperty("client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ClientName { get; set; } 

    [JsonProperty("_statuswarning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Statuswarning { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("qbo_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? QboId { get; set; } 

    [JsonProperty("xero_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? XeroId { get; set; } 

    [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Isimport { get; set; } 

    [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Importtype { get; set; } 

    [JsonProperty("sqlimport_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SqlimportId { get; set; } 

    [JsonProperty("invoice_match_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? InvoiceMatchId { get; set; } 

    [JsonProperty("invoice_invoicenumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? InvoiceInvoicenumber { get; set; } 

}