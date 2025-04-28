using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Emails.EmailRules;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class EmailRule
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Type { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("pop3serverid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Pop3Serverid { get; set; } 

    [JsonProperty("mailbox_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MailboxName { get; set; } 

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

    [JsonProperty("starttag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Starttag { get; set; } 

    [JsonProperty("endtag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Endtag { get; set; } 

    [JsonProperty("fieldname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? FieldName { get; set; } 

    [JsonProperty("length", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Length { get; set; } 

    [JsonProperty("useendofline", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Useendofline { get; set; } 

    [JsonProperty("2starttag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _2starttag { get; set; } 

    [JsonProperty("2endtag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _2endtag { get; set; } 

    [JsonProperty("2fieldname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _2fieldname { get; set; } 

    [JsonProperty("2length", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? _2length { get; set; } 

    [JsonProperty("2useendofline", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _2useendofline { get; set; } 

    [JsonProperty("3starttag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _3starttag { get; set; } 

    [JsonProperty("3endtag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _3endtag { get; set; } 

    [JsonProperty("3fieldname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _3fieldname { get; set; } 

    [JsonProperty("3length", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? _3length { get; set; } 

    [JsonProperty("3useendofline", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _3useendofline { get; set; } 

    [JsonProperty("closestring", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Closestring { get; set; } 

    [JsonProperty("requesttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RequestType { get; set; } 

    [JsonProperty("4starttag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _4starttag { get; set; } 

    [JsonProperty("4endtag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _4endtag { get; set; } 

    [JsonProperty("4fieldname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _4fieldname { get; set; } 

    [JsonProperty("4length", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? _4length { get; set; } 

    [JsonProperty("4useendofline", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _4useendofline { get; set; } 

    [JsonProperty("seq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Seq { get; set; } 

    [JsonProperty("pagerduty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Pagerduty { get; set; } 

    [JsonProperty("fromaddrexact", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Fromaddrexact { get; set; } 

    [JsonProperty("toaddrexact", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Toaddrexact { get; set; } 

    [JsonProperty("privateactions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Privateactions { get; set; } 

    [JsonProperty("3useticketuser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _3useticketuser { get; set; } 

    [JsonProperty("fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<EmailRuleFieldMapping>? FieldMappings { get; set; } 

    [JsonProperty("endtagmatchtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Endtagmatchtype { get; set; } 

    [JsonProperty("3matchtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? _3matchtype { get; set; } 

    [JsonProperty("3endtagmatchtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? _3endtagmatchtype { get; set; } 

    [JsonProperty("pagerdutyagent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Pagerdutyagent { get; set; } 

    [JsonProperty("pagerduty_service", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PagerdutyService { get; set; } 

    [JsonProperty("pagerduty_service_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PagerdutyServiceName { get; set; } 

    [JsonProperty("5starttag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _5starttag { get; set; } 

    [JsonProperty("5endtag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _5endtag { get; set; } 

    [JsonProperty("5fieldname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _5fieldname { get; set; } 

    [JsonProperty("5length", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? _5length { get; set; } 

    [JsonProperty("5useendofline", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _5useendofline { get; set; } 

    [JsonProperty("5endtagmatchtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? _5endtagmatchtype { get; set; } 

    [JsonProperty("splunkoncall", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Splunkoncall { get; set; } 

    [JsonProperty("attachmentname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Attachmentname { get; set; } 

    [JsonProperty("attachmentmatchtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Attachmentmatchtype { get; set; } 

    [JsonProperty("matchonattachment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Matchonattachment { get; set; } 

    [JsonProperty("matchccandbcc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Matchccandbcc { get; set; } 

    [JsonProperty("6starttag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _6starttag { get; set; } 

    [JsonProperty("6endtag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _6endtag { get; set; } 

    [JsonProperty("6length", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? _6length { get; set; } 

    [JsonProperty("6useendofline", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _6useendofline { get; set; } 

    [JsonProperty("6endtagmatchtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? _6endtagmatchtype { get; set; } 

    [JsonProperty("always_close_alerts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AlwaysCloseAlerts { get; set; } 

    [JsonProperty("closed_alerts_read_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ClosedAlertsReadStatus { get; set; } 

    [JsonProperty("dontsendacknowledgement", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Dontsendacknowledgement { get; set; } 

    [JsonProperty("scan_full_body", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ScanFullBody { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("response_template_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ResponseTemplateId { get; set; } 

    [JsonProperty("response_template_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ResponseTemplateName { get; set; } 

    [JsonProperty("dont_update_from_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DontUpdateFromAddress { get; set; } 

}