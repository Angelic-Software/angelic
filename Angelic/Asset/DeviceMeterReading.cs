using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Asset;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class DeviceMeterReading
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("recurringinvoice_line_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RecurringinvoiceLineId { get; set; } 

    [JsonProperty("asset_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AssetId { get; set; } 

    [JsonProperty("meter_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MeterName { get; set; } 

    [JsonProperty("timestamp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Timestamp { get; set; } 

    [JsonProperty("who", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Who { get; set; } 

    [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TicketId { get; set; } 

    [JsonProperty("invoice_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? InvoiceId { get; set; } 

    [JsonProperty("reading_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ReadingType { get; set; } 

    [JsonProperty("pack_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PackId { get; set; } 

    [JsonProperty("reading", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Reading { get; set; } 

    [JsonProperty("previous_reading", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PreviousReading { get; set; } 

    [JsonProperty("reason", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Reason { get; set; } 

    [JsonProperty("reviewed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Reviewed { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}