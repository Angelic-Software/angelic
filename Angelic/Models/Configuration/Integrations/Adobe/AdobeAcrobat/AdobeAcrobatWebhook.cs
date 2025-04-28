using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Integrations.Adobe.AdobeAcrobat;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class AdobeAcrobatWebhook
{
    [JsonProperty("webhookId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? WebhookId { get; set; }

    [JsonProperty("webhookName", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? WebhookName { get; set; }

    [JsonProperty("webhookNotificationId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? WebhookNotificationId { get; set; }

    [JsonProperty("webhookUrlInfo", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public AdobeAcrobatWebhookUrlInfo? WebhookUrlInfo { get; set; }

    [JsonProperty("webhookScope", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? WebhookScope { get; set; }

    [JsonProperty("webhookNotificationApplicableUsers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AdobeAcrobatWebhookNotificationApplicableUser>? WebhookNotificationApplicableUsers { get; set; }

    [JsonProperty("event", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Event { get; set; }

    [JsonProperty("eventDate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? EventDate { get; set; }

    [JsonProperty("eventResourceType", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? EventResourceType { get; set; }

    [JsonProperty("participantRole", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ParticipantRole { get; set; }

    [JsonProperty("actionType", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ActionType { get; set; }

    [JsonProperty("participantUserId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ParticipantUserId { get; set; }

    [JsonProperty("participantUserEmail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ParticipantUserEmail { get; set; }

    [JsonProperty("actingUserId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ActingUserId { get; set; }

    [JsonProperty("actingUserEmail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ActingUserEmail { get; set; }

    [JsonProperty("initiatingUserId", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? InitiatingUserId { get; set; }

    [JsonProperty("initiatingUserEmail", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? InitiatingUserEmail { get; set; }

    [JsonProperty("agreement", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public AdobeAcrobatWebhookAgreement? Agreement { get; set; }
}
