using System.CodeDom.Compiler;
using Angelic.Models.Configuration.Custom.CustomFields;
using Angelic.Models.Configuration.Tickets.TicketTypes;
using Newtonsoft.Json;

namespace Angelic.Models;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Feedback
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TicketId { get; set; } 

    [JsonProperty("key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Key { get; set; } 

    [JsonProperty("score", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Score { get; set; } 

    [JsonProperty("date", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Date { get; set; } 

    [JsonProperty("comment", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Comment { get; set; } 

    [JsonProperty("score_band", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ScoreBand { get; set; } 

    [JsonProperty("user_message", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? UserMessage { get; set; } 

    [JsonProperty("customsurveyfields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CustomField>? Customsurveyfields { get; set; } 

    [JsonProperty("recaptcha_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? RecaptchaToken { get; set; } 

    [JsonProperty("feedback_faultid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? FeedbackFaultid { get; set; } 

    [JsonProperty("fields", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<TicketTypeField>? Fields { get; set; } 

    [JsonProperty("automation_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AutomationId { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("ip_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? IpAddress { get; set; } 

}