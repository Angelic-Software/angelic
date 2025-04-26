using System.CodeDom.Compiler;
using Angelic.Invoice;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CsvTemplate
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Type { get; set; } 

    [JsonProperty("groupingtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Groupingtype { get; set; } 

    [JsonProperty("detailcolumns", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CsvTemplateDetail>? Detailcolumns { get; set; } 

    [JsonProperty("is_preview", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsPreview { get; set; } 

    [JsonProperty("is_generate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsGenerate { get; set; } 

    [JsonProperty("printcsv", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Printcsv { get; set; } 

    [JsonProperty("invoices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<InvoiceHeader>? Invoices { get; set; } 

    [JsonProperty("csv_attachment_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CsvAttachmentId { get; set; } 

    [JsonProperty("csv_attachment_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CsvAttachmentName { get; set; } 

    [JsonProperty("update_posted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? UpdatePosted { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("background_task", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? BackgroundTask { get; set; } 

}