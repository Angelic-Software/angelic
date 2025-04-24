using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class OrderHead
{
    [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomField>? Customfields { get; set; } 

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Use { get; set; } 

    [JsonProperty("title", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Title { get; set; } 

    [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Ticket_id { get; set; } 

    [JsonProperty("user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? User_id { get; set; } 

    [JsonProperty("user_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? User_name { get; set; } 

    [JsonProperty("site_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Site_id { get; set; } 

    [JsonProperty("site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Site_name { get; set; } 

    [JsonProperty("client_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Client_id { get; set; } 

    [JsonProperty("client_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Client_name { get; set; } 

    [JsonProperty("client_to_invoice_to_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Client_to_invoice_to_id { get; set; } 

    [JsonProperty("assigned_agent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Assigned_agent { get; set; } 

    [JsonProperty("assigned_agent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Assigned_agent_name { get; set; } 

    [JsonProperty("open_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Open_status { get; set; } 

    [JsonProperty("date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Date { get; set; } 

    [JsonProperty("ship_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Ship_date { get; set; } 

    [JsonProperty("total", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Total { get; set; } 

    [JsonProperty("cost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Cost { get; set; } 

    [JsonProperty("profit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Profit { get; set; } 

    [JsonProperty("note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Note { get; set; } 

    [JsonProperty("po_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Po_number { get; set; } 

    [JsonProperty("createdby_agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Createdby_agent_id { get; set; } 

    [JsonProperty("deliverby", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Deliverby { get; set; } 

    [JsonProperty("summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Summary { get; set; } 

    [JsonProperty("datereceived", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Datereceived { get; set; } 

    [JsonProperty("numberbottles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Numberbottles { get; set; } 

    [JsonProperty("ship_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Ship_status { get; set; } 

    [JsonProperty("soldby", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Soldby { get; set; } 

    [JsonProperty("accountsref", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Accountsref { get; set; } 

    [JsonProperty("status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Status { get; set; } 

    [JsonProperty("leadsource", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Leadsource { get; set; } 

    [JsonProperty("canvasser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Canvasser { get; set; } 

    [JsonProperty("invoice_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Invoice_date { get; set; } 

    [JsonProperty("invoicenumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Invoicenumber { get; set; } 

    [JsonProperty("includegroupeditemprice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Includegroupeditemprice { get; set; } 

    [JsonProperty("includegroupeditemqty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Includegroupeditemqty { get; set; } 

    [JsonProperty("currency", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Currency { get; set; } 

    [JsonProperty("currency_code", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Currency_code { get; set; } 

    [JsonProperty("currency_code_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Currency_code_name { get; set; } 

    [JsonProperty("currency_conversion_rate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Currency_conversion_rate { get; set; } 

    [JsonProperty("quotation_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Quotation_id { get; set; } 

    [JsonProperty("consignment_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Consignment_id { get; set; } 

    [JsonProperty("do_not_invoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Do_not_invoice { get; set; } 

    [JsonProperty("closeandconsignwhenpoprocessed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Closeandconsignwhenpoprocessed { get; set; } 

    [JsonProperty("lines", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<OrderLine>? Lines { get; set; } 

    [JsonProperty("add_lines", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<OrderLine>? Add_lines { get; set; } 

    [JsonProperty("_cancel_reserve", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _cancel_reserve { get; set; } 

    [JsonProperty("_validateonly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _validateonly { get; set; } 

    [JsonProperty("_print_preview", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _print_preview { get; set; } 

    [JsonProperty("_print_generate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _print_generate { get; set; } 

    [JsonProperty("printhtml", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Printhtml { get; set; } 

    [JsonProperty("pdf_attachment_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Pdf_attachment_id { get; set; } 

    [JsonProperty("pdftemplate_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Pdftemplate_id { get; set; } 

    [JsonProperty("pdftemplate_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Pdftemplate_name { get; set; } 

    [JsonProperty("purchaseorder_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Purchaseorder_count { get; set; } 

    [JsonProperty("invoice_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Invoice_count { get; set; } 

    [JsonProperty("percentage_invoiced", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Percentage_invoiced { get; set; } 

    [JsonProperty("outstanding_total", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Outstanding_total { get; set; } 

    [JsonProperty("_create_po", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _create_po { get; set; } 

    [JsonProperty("_create_invoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _create_invoice { get; set; } 

    [JsonProperty("_create_invoice_method", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? _create_invoice_method { get; set; } 

    [JsonProperty("_create_invoice_percentage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? _create_invoice_percentage { get; set; } 

    [JsonProperty("_create_invoice_amount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? _create_invoice_amount { get; set; } 

    [JsonProperty("_create_invoice_qty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? _create_invoice_qty { get; set; } 

    [JsonProperty("_create_invoice_lines", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<OrderLine>? _create_invoice_lines { get; set; } 

    [JsonProperty("_create_invoice_line_description", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _create_invoice_line_description { get; set; } 

    [JsonProperty("_create_invoice_invoice_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? _create_invoice_invoice_date { get; set; } 

    [JsonProperty("_return_invoice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _return_invoice { get; set; } 

    [JsonProperty("createdbyagentname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Createdbyagentname { get; set; } 

    [JsonProperty("last_update_time", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Last_update_time { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

    [JsonProperty("_distributorMessage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _distributorMessage { get; set; } 

    [JsonProperty("project_faultid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Project_faultid { get; set; } 

    [JsonProperty("order_project_template_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Order_project_template_id { get; set; } 

    [JsonProperty("order_project_template_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Order_project_template_name { get; set; } 

    [JsonProperty("_iscopy", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _iscopy { get; set; } 

    [JsonProperty("includegrouppriceandqty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Includegrouppriceandqty { get; set; } 

    [JsonProperty("costperweight", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Costperweight { get; set; } 

    [JsonProperty("showpercentageinvoiced", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Showpercentageinvoiced { get; set; } 

    [JsonProperty("linked_to_opportunity", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Linked_to_opportunity { get; set; } 

    [JsonProperty("linked_to_ticket", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Linked_to_ticket { get; set; } 

    [JsonProperty("linked_to_project", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Linked_to_project { get; set; } 

    [JsonProperty("intacct_class", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Intacct_class { get; set; } 

    [JsonProperty("intacct_class_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Intacct_class_name { get; set; } 

    [JsonProperty("intacct_save_location", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Intacct_save_location { get; set; } 

    [JsonProperty("override_delivery_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Override_delivery_address { get; set; } 

    [JsonProperty("deladdress1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Deladdress1 { get; set; } 

    [JsonProperty("deladdress2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Deladdress2 { get; set; } 

    [JsonProperty("deladdress3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Deladdress3 { get; set; } 

    [JsonProperty("deladdress4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Deladdress4 { get; set; } 

    [JsonProperty("deladdress5", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Deladdress5 { get; set; } 

    [JsonProperty("delivery_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public AddressStore? Delivery_address { get; set; } 

    [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _isimport { get; set; } 

    [JsonProperty("_match_thirdparty_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _match_thirdparty_id { get; set; } 

    [JsonProperty("_match_integration_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? _match_integration_id { get; set; } 

    [JsonProperty("_match_integration_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _match_integration_name { get; set; } 

    [JsonProperty("dattocommerce_clientid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Dattocommerce_clientid { get; set; } 

    [JsonProperty("dattocommerce_contactname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Dattocommerce_contactname { get; set; } 

    [JsonProperty("dattocommerce_contactemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Dattocommerce_contactemail { get; set; } 

    [JsonProperty("deliveryamount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Deliveryamount { get; set; } 

    [JsonProperty("deliverytax", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Deliverytax { get; set; } 

    [JsonProperty("is_so_screen", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Is_so_screen { get; set; } 

    [JsonProperty("_novalidate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _novalidate { get; set; } 

    [JsonProperty("avalara_details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Avalara_details_id { get; set; } 

    [JsonProperty("avalara_details_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Avalara_details_name { get; set; } 

    [JsonProperty("originaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public AddressStore? Originaddress { get; set; } 

    [JsonProperty("originaddress1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Originaddress1 { get; set; } 

    [JsonProperty("originaddress2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Originaddress2 { get; set; } 

    [JsonProperty("originaddress3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Originaddress3 { get; set; } 

    [JsonProperty("originaddress4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Originaddress4 { get; set; } 

    [JsonProperty("originaddress5", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Originaddress5 { get; set; } 

    [JsonProperty("custombuttons", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomButton>? Custombuttons { get; set; } 

    [JsonProperty("extratabs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Tabname>? Extratabs { get; set; } 

    [JsonProperty("_dotaxsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _dotaxsync { get; set; } 

    [JsonProperty("tax_total", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Tax_total { get; set; } 

    [JsonProperty("revenue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Revenue { get; set; } 

    [JsonProperty("external_links", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ExternalLink_List>? External_links { get; set; } 

    [JsonProperty("_importtypeid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? _importtypeid { get; set; } 

    [JsonProperty("_importthirdpartyid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _importthirdpartyid { get; set; } 

    [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _importtype { get; set; } 

    [JsonProperty("new_external_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ExternalLink_List? New_external_link { get; set; } 

}