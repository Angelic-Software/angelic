using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ServSite_List
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Guid { get; set; } 

    [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Intent { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Summary { get; set; } 

    [JsonProperty("sequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sequence { get; set; } 

    [JsonProperty("showinusercatalog", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Showinusercatalog { get; set; } 

    [JsonProperty("showintechcatalog", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Showintechcatalog { get; set; } 

    [JsonProperty("trackstatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Trackstatus { get; set; } 

    [JsonProperty("service_category_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Service_category_id { get; set; } 

    [JsonProperty("service_category_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Service_category_guid { get; set; } 

    [JsonProperty("service_category_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Service_category_name { get; set; } 

    [JsonProperty("business_owner_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Business_owner_id { get; set; } 

    [JsonProperty("business_owner_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Business_owner_name { get; set; } 

    [JsonProperty("business_owner_cab_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Business_owner_cab_id { get; set; } 

    [JsonProperty("business_owner_cab_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Business_owner_cab_name { get; set; } 

    [JsonProperty("technical_owner_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Technical_owner_id { get; set; } 

    [JsonProperty("technical_owner_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Technical_owner_name { get; set; } 

    [JsonProperty("technical_owner_cab_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Technical_owner_cab_id { get; set; } 

    [JsonProperty("technical_owner_cab_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Technical_owner_cab_name { get; set; } 

    [JsonProperty("compliance_owner_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Compliance_owner_id { get; set; } 

    [JsonProperty("compliance_owner_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Compliance_owner_name { get; set; } 

    [JsonProperty("compliance_owner_cab_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Compliance_owner_cab_id { get; set; } 

    [JsonProperty("compliance_owner_cab_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Compliance_owner_cab_name { get; set; } 

    [JsonProperty("cost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Cost { get; set; } 

    [JsonProperty("estimated_delivery", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Estimated_delivery { get; set; } 

    [JsonProperty("estimated_delivery_days", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Estimated_delivery_days { get; set; } 

    [JsonProperty("subscribable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Subscribable { get; set; } 

    [JsonProperty("subscriber_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Subscriber_count { get; set; } 

    [JsonProperty("asset_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Asset_count { get; set; } 

    [JsonProperty("assettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Assettype_id { get; set; } 

    [JsonProperty("assettype_ids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Assettype_ids { get; set; } 

    [JsonProperty("current_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Current_status { get; set; } 

    [JsonProperty("status_message_update_internal", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Status_message_update_internal { get; set; } 

    [JsonProperty("status_message_update_public", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Status_message_update_public { get; set; } 

    [JsonProperty("using_default_public_message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Using_default_public_message { get; set; } 

    [JsonProperty("status_ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Status_ticket_id { get; set; } 

    [JsonProperty("status_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Status_date { get; set; } 

    [JsonProperty("service_tickettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Service_tickettype_id { get; set; } 

    [JsonProperty("serviceshownewreqscreen", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Serviceshownewreqscreen { get; set; } 

    [JsonProperty("service_template_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Service_template_id { get; set; } 

    [JsonProperty("newservicereqtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Newservicereqtype { get; set; } 

    [JsonProperty("incident_tickettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Incident_tickettype_id { get; set; } 

    [JsonProperty("incident_template_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Incident_template_id { get; set; } 

    [JsonProperty("newincidenttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Newincidenttype { get; set; } 

    [JsonProperty("relatedworkdayid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Relatedworkdayid { get; set; } 

    [JsonProperty("status_end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Status_end_date { get; set; } 

    [JsonProperty("status_ticket_start_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Status_ticket_start_date { get; set; } 

    [JsonProperty("status_ticket_end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Status_ticket_end_date { get; set; } 

    [JsonProperty("requestdetails_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Requestdetails_count { get; set; } 

    [JsonProperty("requestdetails_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Requestdetails_id { get; set; } 

    [JsonProperty("requestdetail_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Requestdetail_url { get; set; } 

    [JsonProperty("requestdetail_shownewreqscreen", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Requestdetail_shownewreqscreen { get; set; } 

    [JsonProperty("requestdetail_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Requestdetail_type { get; set; } 

    [JsonProperty("screenafterlogging", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Screenafterlogging { get; set; } 

    [JsonProperty("pricingrange", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Pricingrange { get; set; } 

    [JsonProperty("override_site_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Override_site_id { get; set; } 

    [JsonProperty("failcreaterequest", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Failcreaterequest { get; set; } 

    [JsonProperty("workdays", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Workdays { get; set; } 

    [JsonProperty("checkminutes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Checkminutes { get; set; } 

    [JsonProperty("failalwaysnewrequest", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Failalwaysnewrequest { get; set; } 

    [JsonProperty("criticality", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Criticality { get; set; } 

    [JsonProperty("search_score", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Search_score { get; set; } 

    [JsonProperty("device_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Device_id { get; set; } 

    [JsonProperty("use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Use { get; set; } 

    [JsonProperty("icon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Icon { get; set; } 

    [JsonProperty("relatedworkdayid_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Relatedworkdayid_name { get; set; } 

    [JsonProperty("relatedworkdayid_content", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Relatedworkdayid_content { get; set; } 

    [JsonProperty("status_message_update_internal_html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Status_message_update_internal_html { get; set; } 

    [JsonProperty("status_message_update_public_html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Status_message_update_public_html { get; set; } 

    [JsonProperty("future_statuses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Int32NullableStringDateTimeNullableInt32NullableTuple>? Future_statuses { get; set; } 

    [JsonProperty("current_statuses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Int32NullableStringDateTimeNullableInt32NullableDateTimeNullableTuple>? Current_statuses { get; set; } 

    [JsonProperty("service_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Service_url { get; set; } 

    [JsonProperty("incident_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Incident_url { get; set; } 

    [JsonProperty("access_control", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AccessControl>? Access_control { get; set; } 

    [JsonProperty("access_control_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Access_control_level { get; set; } 

    [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _isimport { get; set; } 

    [JsonProperty("link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Link { get; set; } 

    [JsonProperty("tag_string", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Tag_string { get; set; } 

    [JsonProperty("device_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Device_guid { get; set; } 

    [JsonProperty("device_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Device_name { get; set; } 

}