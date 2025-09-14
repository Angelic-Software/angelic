using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Deprecated;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record NhServerConfig
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("acceptattachments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AcceptAttachments { get; set; } 

    [JsonProperty("acceptautoreplycheckbox", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AcceptAutoReplyCheckbox { get; set; } 

    [JsonProperty("actionemails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ActionEmails { get; set; } 

    [JsonProperty("actionsendlimit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ActionSendLimit { get; set; } 

    [JsonProperty("approvalscan", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ApprovalScan { get; set; } 

    [JsonProperty("assetattachmentmaintenance", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AssetAttachmentMaintenance { get; set; } 

    [JsonProperty("autocreatedevice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AutoCreateDevice { get; set; } 

    [JsonProperty("autodevicesite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AutoDeviceSite { get; set; } 

    [JsonProperty("autodevicetype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AutoDeviceType { get; set; } 

    [JsonProperty("autolinkdevices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AutoLinkDevices { get; set; } 

    [JsonProperty("automatchlocation2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AutoMatchLocation2 { get; set; } 

    [JsonProperty("autoondiagram", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AutoOnDiagram { get; set; } 

    [JsonProperty("autorequests", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AutoRequests { get; set; } 

    [JsonProperty("calendarsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CalendarSync { get; set; } 

    [JsonProperty("clearlogboxes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ClearLogBoxes { get; set; } 

    [JsonProperty("confforemails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ConfForEmails { get; set; } 

    [JsonProperty("datefilter", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? DateFilter { get; set; } 

    [JsonProperty("deleteerrors", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DeleteErrors { get; set; } 

    [JsonProperty("emailcreatenewuser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? EmailCreateNewUser { get; set; } 

    [JsonProperty("emaillogfolder", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EmailLogFolder { get; set; } 

    [JsonProperty("emailnoack", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? EmailNoAck { get; set; } 

    [JsonProperty("emailrequesttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EmailRequestType { get; set; } 

    [JsonProperty("emailsiteint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? EmailSiteInt { get; set; } 

    [JsonProperty("emailtechieint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? EmailTechIeInt { get; set; } 

    [JsonProperty("emailusefullname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? EmailUseFullName { get; set; } 

    [JsonProperty("emailuserdefault", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EmailUserDefault { get; set; } 

    [JsonProperty("emailuserint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? EmailUserInt { get; set; } 

    [JsonProperty("emailusesitedomain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? EmailUseSiteDomain { get; set; } 

    [JsonProperty("errorreportemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ErrorReportEmail { get; set; } 

    [JsonProperty("errorreportemailaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ErrorReportEmailAddress { get; set; } 

    [JsonProperty("errorreportrequest", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ErrorReportRequest { get; set; } 

    [JsonProperty("ewslastapptsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? EwsLastApptSync { get; set; } 

    [JsonProperty("forcehtml", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ForceHtml { get; set; } 

    [JsonProperty("highlevellogging", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? HighLevelLogging { get; set; } 

    [JsonProperty("ignorecc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IgnoreCc { get; set; } 

    [JsonProperty("ignoreduplicateemails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IgnoreDuplicateEmails { get; set; } 

    [JsonProperty("ignoreifsitenotmatched", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IgnoreIfSiteNotMatched { get; set; } 

    [JsonProperty("intervalseconds", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? IntervalSeconds { get; set; } 

    [JsonProperty("maintenancerequests", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? MaintenanceRequests { get; set; } 

    [JsonProperty("mainttime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MaintTime { get; set; } 

    [JsonProperty("nhdsuppliersync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? NhdSupplierSync { get; set; } 

    [JsonProperty("nooverduescan", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? NoOverdueScan { get; set; } 

    [JsonProperty("pop3interface", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Pop3Interface { get; set; } 

    [JsonProperty("popuptimeoutseconds", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PopupTimeoutSeconds { get; set; } 

    [JsonProperty("prepayautotopup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? PrepayAutoTopUp { get; set; } 

    [JsonProperty("processxmlfiles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ProcessXmlFiles { get; set; } 

    [JsonProperty("recurringcalendarsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? RecurringCalendarSync { get; set; } 

    [JsonProperty("refreshautoinv", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? RefreshAutoInv { get; set; } 

    [JsonProperty("requestscan", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? RequestScan { get; set; } 

    [JsonProperty("saverawemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? SaveRawEmail { get; set; } 

    [JsonProperty("sendsmtp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? SendSmtp { get; set; } 

    [JsonProperty("sendtray", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? SendTray { get; set; } 

    [JsonProperty("sendwelcomeemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? SendWelcomeEmail { get; set; } 

    [JsonProperty("servicestatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ServiceStatus { get; set; } 

    [JsonProperty("statussendlimit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? StatusSendLimit { get; set; } 

    [JsonProperty("storeemailsindb", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? StoreEmailsInDb { get; set; } 

    [JsonProperty("timeoutseconds", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TimeoutSeconds { get; set; } 

    [JsonProperty("emailsitename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EmailSiteName { get; set; } 

    [JsonProperty("emailusername", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EmailUsername { get; set; } 

    [JsonProperty("autodevicesitename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AutoDeviceSiteName { get; set; } 

    [JsonProperty("autodevicetypename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AutoDeviceTypeName { get; set; } 

    [JsonProperty("reporttimeout", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ReportTimeout { get; set; } 

    [JsonProperty("deletecustomdata", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DeleteCustomData { get; set; } 

    [JsonProperty("bulkemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? BulkEmail { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}