using System.CodeDom.Compiler;
using Angelic.Attributes;
using Angelic.Models.Configuration.Integrations;
using Newtonsoft.Json;

namespace Angelic.Models.ExternalLinks;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
[HasEndpoint("ExternalLink")]
public record ExternalLink
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("table_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TableId { get; set; } 

    [JsonProperty("module_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ModuleId { get; set; } 

    [JsonProperty("integration_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? IntegrationName { get; set; } 

    [JsonProperty("halo_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? HaloId { get; set; } 

    [JsonProperty("third_party_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ThirdPartyId { get; set; } 

    [JsonProperty("third_party_desc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ThirdPartyDesc { get; set; } 

    [JsonProperty("third_party_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ThirdPartyType { get; set; } 

    [JsonProperty("third_party_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ThirdPartyUrl { get; set; } 

    [JsonProperty("third_party_assigned_to", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ThirdPartyAssignedTo { get; set; } 

    [JsonProperty("third_party_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public long? ThirdPartyCount { get; set; } 

    [JsonProperty("primary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Primary { get; set; } 

    [JsonProperty("halo_desc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? HaloDesc { get; set; } 

    [JsonProperty("halo_second_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? HaloSecondId { get; set; } 

    [JsonProperty("halo_second_desc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? HaloSecondDesc { get; set; } 

    [JsonProperty("extra_match_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ExtraMatchField { get; set; } 

    [JsonProperty("details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? DetailsId { get; set; } 

    [JsonProperty("third_party_secondary_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ThirdPartySecondaryId { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("third_party_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ThirdPartyStatus { get; set; } 

    [JsonProperty("third_party_priority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ThirdPartyPriority { get; set; } 

    [JsonProperty("_match", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Match { get; set; } 

    [JsonProperty("populate_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? PopulateUrl { get; set; } 

    [JsonProperty("date_created", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? DateCreated { get; set; } 

    [JsonProperty("date_updated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? DateUpdated { get; set; } 

    [JsonProperty("subscription_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SubscriptionId { get; set; } 

    [JsonProperty("new_subscription_key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NewSubscriptionKey { get; set; } 

    [JsonProperty("subscription_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? SubscriptionExpiry { get; set; } 

    [JsonProperty("_webhookaction", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public WebhookSubscriptionAction? WebhookAction { get; set; } 

    [JsonProperty("revisions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Revisions { get; set; } 

    [JsonProperty("dont_move_existing_assets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DontMoveExistingAssets { get; set; } 

    [JsonProperty("chat_message_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ChatMessageCount { get; set; } 

    [JsonProperty("third_party_additional_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ThirdPartyAdditionalId { get; set; } 

}