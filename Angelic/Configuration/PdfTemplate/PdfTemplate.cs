using System.CodeDom.Compiler;
using Angelic.Contract;
using Angelic.Invoice;
using Angelic.Reports;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class PdfTemplate
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Type { get; set; } 

    [JsonProperty("description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Description { get; set; } 

    [JsonProperty("orientation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Orientation { get; set; } 

    [JsonProperty("margin", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Margin { get; set; } 

    [JsonProperty("default_mainhtml", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultMainhtml { get; set; } 

    [JsonProperty("default_subhtml", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultSubhtml { get; set; } 

    [JsonProperty("default_subhtml2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultSubhtml2 { get; set; } 

    [JsonProperty("default_subhtml3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultSubhtml3 { get; set; } 

    [JsonProperty("includeheader", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Includeheader { get; set; } 

    [JsonProperty("headerl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Headerl { get; set; } 

    [JsonProperty("headerc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Headerc { get; set; } 

    [JsonProperty("headerr", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Headerr { get; set; } 

    [JsonProperty("headerishtml", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Headerishtml { get; set; } 

    [JsonProperty("headerheight", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Headerheight { get; set; } 

    [JsonProperty("headerhtml", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Headerhtml { get; set; } 

    [JsonProperty("includefooter", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Includefooter { get; set; } 

    [JsonProperty("footerl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Footerl { get; set; } 

    [JsonProperty("footerc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Footerc { get; set; } 

    [JsonProperty("footerr", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Footerr { get; set; } 

    [JsonProperty("footerishtml", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Footerishtml { get; set; } 

    [JsonProperty("footerheight", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Footerheight { get; set; } 

    [JsonProperty("footerhtml", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Footerhtml { get; set; } 

    [JsonProperty("colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Colour { get; set; } 

    [JsonProperty("colour_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ColourType { get; set; } 

    [JsonProperty("backgroundimageurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(1000)]
    public string? Backgroundimageurl { get; set; } 

    [JsonProperty("width", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Width { get; set; } 

    [JsonProperty("config_source_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ConfigSourceType { get; set; } 

    [JsonProperty("config_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(1000)]
    public string? ConfigUrl { get; set; } 

    [JsonProperty("reportingperiod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Reportingperiod { get; set; } 

    [JsonProperty("system_use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(50)]
    public string? SystemUse { get; set; } 

    [JsonProperty("detailcolumns", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<PdfTemplateDetail>? Detailcolumns { get; set; } 

    [JsonProperty("pages", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<PdfTemplatePage>? Pages { get; set; } 

    [JsonProperty("is_preview", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsPreview { get; set; } 

    [JsonProperty("is_generate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsGenerate { get; set; } 

    [JsonProperty("printhtml", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Printhtml { get; set; } 

    [JsonProperty("pdf_attachment_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PdfAttachmentId { get; set; } 

    [JsonProperty("pdf_attachment_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PdfAttachmentLink { get; set; } 

    [JsonProperty("quotation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public QuotationHeader? Quotation { get; set; } 

    [JsonProperty("salesorder", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public SalesOrder? Salesorder { get; set; } 

    [JsonProperty("purchaseorder", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public PurchaseOrderHeader? Purchaseorder { get; set; } 

    [JsonProperty("invoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public InvoiceHeader? Invoice { get; set; } 

    [JsonProperty("contract", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ContractHeader? Contract { get; set; } 

    [JsonProperty("report", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Report? Report { get; set; } 

    [JsonProperty("consignment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ConsignmentHeader? Consignment { get; set; } 

    [JsonProperty("reports", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<PdfTemplateReport>? Reports { get; set; } 

    [JsonProperty("composite_report_apid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CompositeReportApid { get; set; } 

    [JsonProperty("canbeaccessedbyallusers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Canbeaccessedbyallusers { get; set; } 

    [JsonProperty("permissions_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<UserReport>? PermissionsUser { get; set; } 

    [JsonProperty("schedule", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<StdRequestList>? Schedule { get; set; } 

    [JsonProperty("clientid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Clientid { get; set; } 

    [JsonProperty("licencename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Licencename { get; set; } 

    [JsonProperty("library_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? LibraryId { get; set; } 

    [JsonProperty("image_attachment_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ImageAttachmentId { get; set; } 

    [JsonProperty("pagewidthinches", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Pagewidthinches { get; set; } 

    [JsonProperty("pageheightinches", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Pageheightinches { get; set; } 

    [JsonProperty("icon_base64", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? IconBase64 { get; set; } 

    [JsonProperty("icon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Icon { get; set; } 

    [JsonProperty("kbentry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public KbEntry? Kbentry { get; set; } 

    [JsonProperty("showinlineimage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Showinlineimage { get; set; } 

    [JsonProperty("pdf_media_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PdfMediaType { get; set; } 

    [JsonProperty("asset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Asset.Asset? Asset { get; set; } 

    [JsonProperty("prefix_pdf_attachment_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PrefixPdfAttachmentId { get; set; } 

    [JsonProperty("prefixpdfappend", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Prefixpdfappend { get; set; } 

    [JsonProperty("iscustomised", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Iscustomised { get; set; } 

    [JsonProperty("show_bundled_lines", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ShowBundledLines { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("_xmlwarning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Xmlwarning { get; set; } 

    [JsonProperty("override_attachment_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OverrideAttachmentName { get; set; } 

    [JsonProperty("portal_display_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PortalDisplayType { get; set; } 

    [JsonProperty("bulkprint_asset_id_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<int>? BulkprintAssetIdList { get; set; } 

    [JsonProperty("invoicexmltemplate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Invoicexmltemplate { get; set; } 

    [JsonProperty("pdftinvoicexmltemplate_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PdftinvoicexmltemplateName { get; set; } 

}