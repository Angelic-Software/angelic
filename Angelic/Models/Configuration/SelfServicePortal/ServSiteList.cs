using System.CodeDom.Compiler;
using Angelic.Attributes;
using Angelic.Models.KeyPairs;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.SelfServicePortal;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
[ListVariantOf(typeof(ServSite))]
public record ServSiteList
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
    public bool? ShowInUserCatalog { get; set; } 

    [JsonProperty("showintechcatalog", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowInTechCatalog { get; set; } 

    [JsonProperty("trackstatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? TrackStatus { get; set; } 

    [JsonProperty("service_category_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ServiceCategoryId { get; set; } 

    [JsonProperty("service_category_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? ServiceCategoryGuid { get; set; } 

    [JsonProperty("service_category_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ServiceCategoryName { get; set; } 

    [JsonProperty("business_owner_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? BusinessOwnerId { get; set; } 

    [JsonProperty("business_owner_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? BusinessOwnerName { get; set; } 

    [JsonProperty("business_owner_cab_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? BusinessOwnerCabId { get; set; } 

    [JsonProperty("business_owner_cab_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? BusinessOwnerCabName { get; set; } 

    [JsonProperty("technical_owner_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TechnicalOwnerId { get; set; } 

    [JsonProperty("technical_owner_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TechnicalOwnerName { get; set; } 

    [JsonProperty("technical_owner_cab_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TechnicalOwnerCabId { get; set; } 

    [JsonProperty("technical_owner_cab_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TechnicalOwnerCabName { get; set; } 

    [JsonProperty("compliance_owner_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ComplianceOwnerId { get; set; } 

    [JsonProperty("compliance_owner_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ComplianceOwnerName { get; set; } 

    [JsonProperty("compliance_owner_cab_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ComplianceOwnerCabId { get; set; } 

    [JsonProperty("compliance_owner_cab_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ComplianceOwnerCabName { get; set; } 

    [JsonProperty("cost", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Cost { get; set; } 

    [JsonProperty("estimated_delivery", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? EstimatedDelivery { get; set; } 

    [JsonProperty("estimated_delivery_days", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? EstimatedDeliveryDays { get; set; } 

    [JsonProperty("subscribable", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Subscribable { get; set; } 

    [JsonProperty("subscriber_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SubscriberCount { get; set; } 

    [JsonProperty("asset_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AssetCount { get; set; } 

    [JsonProperty("assettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AssetTypeId { get; set; } 

    [JsonProperty("assettype_ids", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AssetTypeIds { get; set; } 

    [JsonProperty("current_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CurrentStatus { get; set; } 

    [JsonProperty("status_message_update_internal", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? StatusMessageUpdateInternal { get; set; } 

    [JsonProperty("status_message_update_public", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? StatusMessageUpdatePublic { get; set; } 

    [JsonProperty("using_default_public_message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? UsingDefaultPublicMessage { get; set; } 

    [JsonProperty("status_ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? StatusTicketId { get; set; } 

    [JsonProperty("status_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? StatusDate { get; set; } 

    [JsonProperty("service_tickettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ServiceTicketTypeId { get; set; } 

    [JsonProperty("serviceshownewreqscreen", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ServiceShowNewReqScreen { get; set; } 

    [JsonProperty("service_template_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ServiceTemplateId { get; set; } 

    [JsonProperty("newservicereqtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? NewServiceReqType { get; set; } 

    [JsonProperty("incident_tickettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? IncidentTicketTypeId { get; set; } 

    [JsonProperty("incident_template_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? IncidentTemplateId { get; set; } 

    [JsonProperty("newincidenttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? NewIncidentType { get; set; } 

    [JsonProperty("relatedworkdayid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RelatedWorkdayId { get; set; } 

    [JsonProperty("status_end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? StatusEndDate { get; set; } 

    [JsonProperty("status_ticket_start_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? StatusTicketStartDate { get; set; } 

    [JsonProperty("status_ticket_end_date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? StatusTicketEndDate { get; set; } 

    [JsonProperty("requestdetails_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RequestDetailsCount { get; set; } 

    [JsonProperty("requestdetails_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RequestDetailsId { get; set; } 

    [JsonProperty("requestdetail_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RequestDetailUrl { get; set; } 

    [JsonProperty("requestdetail_shownewreqscreen", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? RequestDetailShowNewReqScreen { get; set; } 

    [JsonProperty("requestdetail_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RequestDetailType { get; set; } 

    [JsonProperty("screenafterlogging", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ScreenAfterLogging { get; set; } 

    [JsonProperty("pricingrange", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? PricingRange { get; set; } 

    [JsonProperty("override_site_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OverrideSiteId { get; set; } 

    [JsonProperty("failcreaterequest", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? FailCreateRequest { get; set; } 

    [JsonProperty("workdays", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Workdays { get; set; } 

    [JsonProperty("checkminutes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CheckMinutes { get; set; } 

    [JsonProperty("failalwaysnewrequest", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? FailAlwaysNewRequest { get; set; } 

    [JsonProperty("criticality", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Criticality { get; set; } 

    [JsonProperty("search_score", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? SearchScore { get; set; } 

    [JsonProperty("device_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DeviceId { get; set; } 

    [JsonProperty("use", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Use { get; set; } 

    [JsonProperty("icon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Icon { get; set; } 

    [JsonProperty("relatedworkdayid_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RelatedWorkdayIdName { get; set; } 

    [JsonProperty("relatedworkdayid_content", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RelatedWorkdayIdContent { get; set; } 

    [JsonProperty("status_message_update_internal_html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? StatusMessageUpdateInternalHtml { get; set; } 

    [JsonProperty("status_message_update_public_html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? StatusMessageUpdatePublicHtml { get; set; } 

    [JsonProperty("future_statuses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Int32NullableStringDateTimeNullableInt32NullableTuple>? FutureStatuses { get; set; } 

    [JsonProperty("current_statuses", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Int32NullableStringDateTimeNullableInt32NullableDateTimeNullableTuple>? CurrentStatuses { get; set; } 

    [JsonProperty("service_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ServiceUrl { get; set; } 

    [JsonProperty("incident_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? IncidentUrl { get; set; } 

    [JsonProperty("access_control", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AccessControl>? AccessControl { get; set; } 

    [JsonProperty("access_control_level", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AccessControlLevel { get; set; } 

    [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsImport { get; set; } 

    [JsonProperty("link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Link { get; set; } 

    [JsonProperty("tag_string", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TagString { get; set; } 

    [JsonProperty("device_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? DeviceGuid { get; set; } 

    [JsonProperty("device_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DeviceName { get; set; } 

}