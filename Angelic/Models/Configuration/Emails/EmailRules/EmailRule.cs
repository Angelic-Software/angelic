using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Emails.EmailRules;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record EmailRule
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Type { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("pop3serverid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Pop3ServerId { get; set; } 

    [JsonProperty("mailbox_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MailboxName { get; set; } 

    [JsonProperty("subject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Subject { get; set; } 

    [JsonProperty("body", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Body { get; set; } 

    [JsonProperty("fromaddr", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? FromAddr { get; set; } 

    [JsonProperty("toaddr", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ToAddr { get; set; } 

    [JsonProperty("enabled", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Enabled { get; set; } 

    [JsonProperty("starttag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? StartTag { get; set; } 

    [JsonProperty("endtag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EndTag { get; set; } 

    [JsonProperty("fieldname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? FieldName { get; set; } 

    [JsonProperty("length", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Length { get; set; } 

    [JsonProperty("useendofline", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? UseEndOfLine { get; set; } 

    [JsonProperty("2starttag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TwoStartTag { get; set; } 

    [JsonProperty("2endtag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TwoEndTag { get; set; } 

    [JsonProperty("2fieldname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TwoFieldName { get; set; } 

    [JsonProperty("2length", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TwoLength { get; set; } 

    [JsonProperty("2useendofline", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? TwoUseEndOfLine { get; set; } 

    [JsonProperty("3starttag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ThreeStartTag { get; set; } 

    [JsonProperty("3endtag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ThreeEndTag { get; set; } 

    [JsonProperty("3fieldname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ThreeFieldName { get; set; } 

    [JsonProperty("3length", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ThreeLength { get; set; } 

    [JsonProperty("3useendofline", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ThreeUseEndOfLine { get; set; } 

    [JsonProperty("closestring", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? CloseString { get; set; } 

    [JsonProperty("requesttype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RequestType { get; set; } 

    [JsonProperty("4starttag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? FourStartTag { get; set; } 

    [JsonProperty("4endtag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? FourEndTag { get; set; } 

    [JsonProperty("4fieldname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? FourFieldName { get; set; } 

    [JsonProperty("4length", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? FourLength { get; set; } 

    [JsonProperty("4useendofline", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? FourUseEndOfLine { get; set; } 

    [JsonProperty("seq", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Seq { get; set; } 

    [JsonProperty("pagerduty", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? PagerDuty { get; set; } 

    [JsonProperty("fromaddrexact", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? FromAddrExact { get; set; } 

    [JsonProperty("toaddrexact", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ToAddrExact { get; set; } 

    [JsonProperty("privateactions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? PrivateActions { get; set; } 

    [JsonProperty("3useticketuser", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ThreeUseTicketUser { get; set; } 

    [JsonProperty("fieldmappings", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<EmailRuleFieldMapping>? FieldMappings { get; set; } 

    [JsonProperty("endtagmatchtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? EndTagMatchType { get; set; } 

    [JsonProperty("3matchtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ThreeMatchType { get; set; } 

    [JsonProperty("3endtagmatchtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ThreeEndTagMatchType { get; set; } 

    [JsonProperty("pagerdutyagent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PagerDutyAgent { get; set; } 

    [JsonProperty("pagerduty_service", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PagerDutyService { get; set; } 

    [JsonProperty("pagerduty_service_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PagerDutyServiceName { get; set; } 

    [JsonProperty("5starttag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? FiveStartTag { get; set; } 

    [JsonProperty("5endtag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? FiveEndTag { get; set; } 

    [JsonProperty("5fieldname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? FiveFieldName { get; set; } 

    [JsonProperty("5length", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? FiveLength { get; set; } 

    [JsonProperty("5useendofline", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? FiveUseEndOfLine { get; set; } 

    [JsonProperty("5endtagmatchtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? FiveEndTagMatchType { get; set; } 

    [JsonProperty("splunkoncall", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? SplunkOnCall { get; set; } 

    [JsonProperty("attachmentname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AttachmentName { get; set; } 

    [JsonProperty("attachmentmatchtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AttachmentMatchType { get; set; } 

    [JsonProperty("matchonattachment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? MatchOnAttachment { get; set; } 

    [JsonProperty("matchccandbcc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? MatchCcAndBcc { get; set; } 

    [JsonProperty("6starttag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SixStartTag { get; set; } 

    [JsonProperty("6endtag", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SixEndTag { get; set; } 

    [JsonProperty("6length", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SixLength { get; set; } 

    [JsonProperty("6useendofline", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? SixUseEndOfLine { get; set; } 

    [JsonProperty("6endtagmatchtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SixEndTagMatchType { get; set; } 

    [JsonProperty("always_close_alerts", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AlwaysCloseAlerts { get; set; } 

    [JsonProperty("closed_alerts_read_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ClosedAlertsReadStatus { get; set; } 

    [JsonProperty("dontsendacknowledgement", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DontSendAcknowledgement { get; set; } 

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