using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class NhServerConfig
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("acceptattachments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Acceptattachments { get; set; } 

    [JsonProperty("acceptautoreplycheckbox", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Acceptautoreplycheckbox { get; set; } 

    [JsonProperty("actionemails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Actionemails { get; set; } 

    [JsonProperty("actionsendlimit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Actionsendlimit { get; set; } 

    [JsonProperty("approvalscan", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Approvalscan { get; set; } 

    [JsonProperty("assetattachmentmaintenance", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Assetattachmentmaintenance { get; set; } 

    [JsonProperty("autocreatedevice", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Autocreatedevice { get; set; } 

    [JsonProperty("autodevicesite", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Autodevicesite { get; set; } 

    [JsonProperty("autodevicetype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Autodevicetype { get; set; } 

    [JsonProperty("autolinkdevices", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Autolinkdevices { get; set; } 

    [JsonProperty("automatchlocation2", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Automatchlocation2 { get; set; } 

    [JsonProperty("autoondiagram", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Autoondiagram { get; set; } 

    [JsonProperty("autorequests", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Autorequests { get; set; } 

    [JsonProperty("calendarsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Calendarsync { get; set; } 

    [JsonProperty("clearlogboxes", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Clearlogboxes { get; set; } 

    [JsonProperty("confforemails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Confforemails { get; set; } 

    [JsonProperty("datefilter", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Datefilter { get; set; } 

    [JsonProperty("deleteerrors", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Deleteerrors { get; set; } 

    [JsonProperty("emailcreatenewuser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Emailcreatenewuser { get; set; } 

    [JsonProperty("emaillogfolder", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Emaillogfolder { get; set; } 

    [JsonProperty("emailnoack", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Emailnoack { get; set; } 

    [JsonProperty("emailrequesttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Emailrequesttype { get; set; } 

    [JsonProperty("emailsiteint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Emailsiteint { get; set; } 

    [JsonProperty("emailtechieint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Emailtechieint { get; set; } 

    [JsonProperty("emailusefullname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Emailusefullname { get; set; } 

    [JsonProperty("emailuserdefault", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Emailuserdefault { get; set; } 

    [JsonProperty("emailuserint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Emailuserint { get; set; } 

    [JsonProperty("emailusesitedomain", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Emailusesitedomain { get; set; } 

    [JsonProperty("errorreportemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Errorreportemail { get; set; } 

    [JsonProperty("errorreportemailaddress", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Errorreportemailaddress { get; set; } 

    [JsonProperty("errorreportrequest", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Errorreportrequest { get; set; } 

    [JsonProperty("ewslastapptsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Ewslastapptsync { get; set; } 

    [JsonProperty("forcehtml", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Forcehtml { get; set; } 

    [JsonProperty("highlevellogging", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Highlevellogging { get; set; } 

    [JsonProperty("ignorecc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Ignorecc { get; set; } 

    [JsonProperty("ignoreduplicateemails", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Ignoreduplicateemails { get; set; } 

    [JsonProperty("ignoreifsitenotmatched", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Ignoreifsitenotmatched { get; set; } 

    [JsonProperty("intervalseconds", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Intervalseconds { get; set; } 

    [JsonProperty("maintenancerequests", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Maintenancerequests { get; set; } 

    [JsonProperty("mainttime", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Mainttime { get; set; } 

    [JsonProperty("nhdsuppliersync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Nhdsuppliersync { get; set; } 

    [JsonProperty("nooverduescan", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Nooverduescan { get; set; } 

    [JsonProperty("pop3interface", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Pop3Interface { get; set; } 

    [JsonProperty("popuptimeoutseconds", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Popuptimeoutseconds { get; set; } 

    [JsonProperty("prepayautotopup", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Prepayautotopup { get; set; } 

    [JsonProperty("processxmlfiles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Processxmlfiles { get; set; } 

    [JsonProperty("recurringcalendarsync", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Recurringcalendarsync { get; set; } 

    [JsonProperty("refreshautoinv", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Refreshautoinv { get; set; } 

    [JsonProperty("requestscan", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Requestscan { get; set; } 

    [JsonProperty("saverawemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Saverawemail { get; set; } 

    [JsonProperty("sendsmtp", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Sendsmtp { get; set; } 

    [JsonProperty("sendtray", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Sendtray { get; set; } 

    [JsonProperty("sendwelcomeemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Sendwelcomeemail { get; set; } 

    [JsonProperty("servicestatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Servicestatus { get; set; } 

    [JsonProperty("statussendlimit", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Statussendlimit { get; set; } 

    [JsonProperty("storeemailsindb", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Storeemailsindb { get; set; } 

    [JsonProperty("timeoutseconds", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Timeoutseconds { get; set; } 

    [JsonProperty("emailsitename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Emailsitename { get; set; } 

    [JsonProperty("emailusername", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Emailusername { get; set; } 

    [JsonProperty("autodevicesitename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Autodevicesitename { get; set; } 

    [JsonProperty("autodevicetypename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Autodevicetypename { get; set; } 

    [JsonProperty("reporttimeout", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Reporttimeout { get; set; } 

    [JsonProperty("deletecustomdata", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Deletecustomdata { get; set; } 

    [JsonProperty("bulkemail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Bulkemail { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}