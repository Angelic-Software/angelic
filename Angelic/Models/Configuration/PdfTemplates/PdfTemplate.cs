using System.CodeDom.Compiler;
using Angelic.Models.Assets;
using Angelic.Models.Configuration.Tickets.Templates;
using Angelic.Models.Configuration.Users;
using Angelic.Models.Contracts;
using Angelic.Models.Invoice;
using Angelic.Models.KnowledgeBase;
using Angelic.Models.PurchaseOrders;
using Angelic.Models.Quotation;
using Angelic.Models.Reports;
using Angelic.Models.SalesOrders;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.PdfTemplates;

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
    public string? DefaultMainHtml { get; set; } 

    [JsonProperty("default_subhtml", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultSubHtml { get; set; } 

    [JsonProperty("default_subhtml2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultSubHtml2 { get; set; } 

    [JsonProperty("default_subhtml3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DefaultSubHtml3 { get; set; } 

    [JsonProperty("includeheader", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IncludeHeader { get; set; } 

    [JsonProperty("headerl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? HeaderL { get; set; } 

    [JsonProperty("headerc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? HeaderC { get; set; } 

    [JsonProperty("headerr", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? HeaderR { get; set; } 

    [JsonProperty("headerishtml", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? HeaderIsHtml { get; set; } 

    [JsonProperty("headerheight", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? HeaderHeight { get; set; } 

    [JsonProperty("headerhtml", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? HeaderHtml { get; set; } 

    [JsonProperty("includefooter", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IncludeFooter { get; set; } 

    [JsonProperty("footerl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? FooterL { get; set; } 

    [JsonProperty("footerc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? FooterC { get; set; } 

    [JsonProperty("footerr", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? FooterR { get; set; } 

    [JsonProperty("footerishtml", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? FooterIsHtml { get; set; } 

    [JsonProperty("footerheight", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? FooterHeight { get; set; } 

    [JsonProperty("footerhtml", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? FooterHtml { get; set; } 

    [JsonProperty("colour", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Colour { get; set; } 

    [JsonProperty("colour_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ColourType { get; set; } 

    [JsonProperty("backgroundimageurl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(1000)]
    public string? BackgroundImageUrl { get; set; } 

    [JsonProperty("width", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Width { get; set; } 

    [JsonProperty("config_source_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ConfigSourceType { get; set; } 

    [JsonProperty("config_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(1000)]
    public string? ConfigUrl { get; set; } 

    [JsonProperty("reportingperiod", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ReportingPeriod { get; set; } 

    [JsonProperty("system_use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(50)]
    public string? SystemUse { get; set; } 

    [JsonProperty("detailcolumns", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<PdfTemplateDetail>? DetailColumns { get; set; } 

    [JsonProperty("pages", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<PdfTemplatePage>? Pages { get; set; } 

    [JsonProperty("is_preview", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsPreview { get; set; } 

    [JsonProperty("is_generate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsGenerate { get; set; } 

    [JsonProperty("printhtml", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PrintHtml { get; set; } 

    [JsonProperty("pdf_attachment_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PdfAttachmentId { get; set; } 

    [JsonProperty("pdf_attachment_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PdfAttachmentLink { get; set; } 

    [JsonProperty("quotation", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public QuotationHeader? Quotation { get; set; } 

    [JsonProperty("salesorder", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public SalesOrder? SalesOrder { get; set; } 

    [JsonProperty("purchaseorder", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public PurchaseOrder? PurchaseOrder { get; set; } 

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
    public bool? CanBeAccessedByAllUsers { get; set; } 

    [JsonProperty("permissions_user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<UserReport>? PermissionsUser { get; set; } 

    [JsonProperty("schedule", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<TemplateList>? Schedule { get; set; } 

    [JsonProperty("clientid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ClientId { get; set; } 

    [JsonProperty("licencename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? LicenceName { get; set; } 

    [JsonProperty("library_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? LibraryId { get; set; } 

    [JsonProperty("image_attachment_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ImageAttachmentId { get; set; } 

    [JsonProperty("pagewidthinches", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? PageWidthInches { get; set; } 

    [JsonProperty("pageheightinches", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? PageHeightInches { get; set; } 

    [JsonProperty("icon_base64", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? IconBase64 { get; set; } 

    [JsonProperty("icon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Icon { get; set; } 

    [JsonProperty("kbentry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public KbArticle? KbEntry { get; set; } 

    [JsonProperty("showinlineimage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowInlineImage { get; set; } 

    [JsonProperty("pdf_media_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PdfMediaType { get; set; } 

    [JsonProperty("asset", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Asset? Asset { get; set; } 

    [JsonProperty("prefix_pdf_attachment_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PrefixPdfAttachmentId { get; set; } 

    [JsonProperty("prefixpdfappend", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? PrefixPdfAppend { get; set; } 

    [JsonProperty("iscustomised", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsCustomised { get; set; } 

    [JsonProperty("show_bundled_lines", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ShowBundledLines { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("_xmlwarning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? XmlWarning { get; set; } 

    [JsonProperty("override_attachment_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OverrideAttachmentName { get; set; } 

    [JsonProperty("portal_display_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PortalDisplayType { get; set; } 

    [JsonProperty("bulkprint_asset_id_list", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<int>? BulkPrintAssetIdList { get; set; } 

    [JsonProperty("invoicexmltemplate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? InvoiceXmlTemplate { get; set; } 

    [JsonProperty("pdftinvoicexmltemplate_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PdfTInvoiceXmlTemplateName { get; set; } 

}