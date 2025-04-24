using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ServSite
{
    [JsonProperty("sendemailtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sendemailtype { get; set; } 

    [JsonProperty("email_subscriber_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Email_subscriber_count { get; set; } 

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

    [JsonProperty("override_site_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Override_site_name { get; set; } 

    [JsonProperty("override", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Override { get; set; } 

    [JsonProperty("checkmon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Checkmon { get; set; } 

    [JsonProperty("checktue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Checktue { get; set; } 

    [JsonProperty("checkwed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Checkwed { get; set; } 

    [JsonProperty("checkthu", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Checkthu { get; set; } 

    [JsonProperty("checkfri", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Checkfri { get; set; } 

    [JsonProperty("checksat", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Checksat { get; set; } 

    [JsonProperty("checksun", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Checksun { get; set; } 

    [JsonProperty("servicekind", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Servicekind { get; set; } 

    [JsonProperty("url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Url { get; set; } 

    [JsonProperty("param1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Param1 { get; set; } 

    [JsonProperty("param2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Param2 { get; set; } 

    [JsonProperty("param3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Param3 { get; set; } 

    [JsonProperty("min", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Min { get; set; } 

    [JsonProperty("max", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Max { get; set; } 

    [JsonProperty("note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Note { get; set; } 

    [JsonProperty("pop3serverid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Pop3serverid { get; set; } 

    [JsonProperty("pop3serverid_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Pop3serverid_name { get; set; } 

    [JsonProperty("subject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Subject { get; set; } 

    [JsonProperty("body", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Body { get; set; } 

    [JsonProperty("fromaddr", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Fromaddr { get; set; } 

    [JsonProperty("toaddr", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Toaddr { get; set; } 

    [JsonProperty("enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Enabled { get; set; } 

    [JsonProperty("oksubject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Oksubject { get; set; } 

    [JsonProperty("okbody", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Okbody { get; set; } 

    [JsonProperty("okfromaddr", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Okfromaddr { get; set; } 

    [JsonProperty("oktoaddr", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Oktoaddr { get; set; } 

    [JsonProperty("okany", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Okany { get; set; } 

    [JsonProperty("failsubject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Failsubject { get; set; } 

    [JsonProperty("failbody", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Failbody { get; set; } 

    [JsonProperty("failfromaddr", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Failfromaddr { get; set; } 

    [JsonProperty("failtoaddr", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Failtoaddr { get; set; } 

    [JsonProperty("failany", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Failany { get; set; } 

    [JsonProperty("wdid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Wdid { get; set; } 

    [JsonProperty("cat2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Cat2 { get; set; } 

    [JsonProperty("workdays_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Workdays_name { get; set; } 

    [JsonProperty("photopath", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Photopath { get; set; } 

    [JsonProperty("allowincidients", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Allowincidients { get; set; } 

    [JsonProperty("allowoptin", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Allowoptin { get; set; } 

    [JsonProperty("service_tickettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Service_tickettype_name { get; set; } 

    [JsonProperty("service_template_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Service_template_name { get; set; } 

    [JsonProperty("incident_tickettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Incident_tickettype_name { get; set; } 

    [JsonProperty("incident_template_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Incident_template_name { get; set; } 

    [JsonProperty("autoemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Autoemail { get; set; } 

    [JsonProperty("servicedetailshtml", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Servicedetailshtml { get; set; } 

    [JsonProperty("alsosubscribe", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Alsosubscribe { get; set; } 

    [JsonProperty("allowunsubscribe", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Allowunsubscribe { get; set; } 

    [JsonProperty("allowservicerequests", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Allowservicerequests { get; set; } 

    [JsonProperty("userlevel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Userlevel { get; set; } 

    [JsonProperty("showonmyservicespage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Showonmyservicespage { get; set; } 

    [JsonProperty("assettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Assettype_name { get; set; } 

    [JsonProperty("smsmessage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Smsmessage { get; set; } 

    [JsonProperty("servicerequestlbl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Servicerequestlbl { get; set; } 

    [JsonProperty("servicerequesthint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(4000)]
    public string? Servicerequesthint { get; set; } 

    [JsonProperty("incidentlbl", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Incidentlbl { get; set; } 

    [JsonProperty("incidenthint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    [System.ComponentModel.DataAnnotations.StringLength(4000)]
    public string? Incidenthint { get; set; } 

    [JsonProperty("allowall_category1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Allowall_category1 { get; set; } 

    [JsonProperty("allowed_category1", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CategoryRestriction>? Allowed_category1 { get; set; } 

    [JsonProperty("allowall_category2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Allowall_category2 { get; set; } 

    [JsonProperty("allowed_category2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CategoryRestriction>? Allowed_category2 { get; set; } 

    [JsonProperty("allowall_category3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Allowall_category3 { get; set; } 

    [JsonProperty("allowed_category3", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CategoryRestriction>? Allowed_category3 { get; set; } 

    [JsonProperty("allowall_category4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Allowall_category4 { get; set; } 

    [JsonProperty("allowed_category4", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CategoryRestriction>? Allowed_category4 { get; set; } 

    [JsonProperty("seq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Seq { get; set; } 

    [JsonProperty("unsubscribe_ticketortemplate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Unsubscribe_ticketortemplate { get; set; } 

    [JsonProperty("unsubscribe_tickettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Unsubscribe_tickettype_id { get; set; } 

    [JsonProperty("unsubscribe_template_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Unsubscribe_template_id { get; set; } 

    [JsonProperty("create_on_unsubscribe", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Create_on_unsubscribe { get; set; } 

    [JsonProperty("unsubscribe_all", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Unsubscribe_all { get; set; } 

    [JsonProperty("field_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Field_id { get; set; } 

    [JsonProperty("field_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Field_name { get; set; } 

    [JsonProperty("tickettype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Tickettype_name { get; set; } 

    [JsonProperty("template_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Template_name { get; set; } 

    [JsonProperty("recent_servicerequest_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Recent_servicerequest_count { get; set; } 

    [JsonProperty("recent_incident_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Recent_incident_count { get; set; } 

    [JsonProperty("open_incident_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Open_incident_count { get; set; } 

    [JsonProperty("open_servicerequest_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Open_servicerequest_count { get; set; } 

    [JsonProperty("user_access", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ServiceRestriction>? User_access { get; set; } 

    [JsonProperty("subscribers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ServiceUser>? Subscribers { get; set; } 

    [JsonProperty("linked_services", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ServiceLinks>? Linked_services { get; set; } 

    [JsonProperty("assets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Device_List>? Assets { get; set; } 

    [JsonProperty("update_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Update_status { get; set; } 

    [JsonProperty("user_subscribed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? User_subscribed { get; set; } 

    [JsonProperty("user", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Users? User { get; set; } 

    [JsonProperty("emailtemplate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Emailtemplate { get; set; } 

    [JsonProperty("send_service_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Send_service_email { get; set; } 

    [JsonProperty("preview_service_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Preview_service_email { get; set; } 

    [JsonProperty("service_email_from", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Service_email_from { get; set; } 

    [JsonProperty("service_email_subject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Service_email_subject { get; set; } 

    [JsonProperty("service_email_html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Service_email_html { get; set; } 

    [JsonProperty("allowfollowfault", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Allowfollowfault { get; set; } 

    [JsonProperty("status_subscribedtoupdates", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Status_subscribedtoupdates { get; set; } 

    [JsonProperty("unsubcount", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Unsubcount { get; set; } 

    [JsonProperty("new_icon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? New_icon { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

    [JsonProperty("showinrelatedservices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Showinrelatedservices { get; set; } 

    [JsonProperty("user_canunsubscribe", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? User_canunsubscribe { get; set; } 

    [JsonProperty("customfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomField>? Customfields { get; set; } 

    [JsonProperty("translations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<LanguagePackTranslationsCustom>? Translations { get; set; } 

    [JsonProperty("optional_services", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ServiceOption>? Optional_services { get; set; } 

    [JsonProperty("isservicedetails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Isservicedetails { get; set; } 

    [JsonProperty("statushistoryportal", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Statushistoryportal { get; set; } 

    [JsonProperty("status_history", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ServStatus>? Status_history { get; set; } 

    [JsonProperty("service_request_details", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ServiceRequestDetails>? Service_request_details { get; set; } 

    [JsonProperty("device_child_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Device_child_id { get; set; } 

    [JsonProperty("device_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Device_count { get; set; } 

    [JsonProperty("incidentonly", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Incidentonly { get; set; } 

    [JsonProperty("cat_phonenumber", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Cat_phonenumber { get; set; } 

    [JsonProperty("kbs", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<KBEntry_List>? Kbs { get; set; } 

    [JsonProperty("search_index_sync_timestamp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Search_index_sync_timestamp { get; set; } 

    [JsonProperty("search_index_sync_batches", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Search_index_sync_batches { get; set; } 

    [JsonProperty("preview_when_logging", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Preview_when_logging { get; set; } 

    [JsonProperty("tags", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Tag>? Tags { get; set; } 

    [JsonProperty("track_availability", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Track_availability { get; set; } 

    [JsonProperty("tracking_period", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Tracking_period { get; set; } 

    [JsonProperty("tracking_target", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Tracking_target { get; set; } 

    [JsonProperty("delay_avilability_calc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Delay_avilability_calc { get; set; } 

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