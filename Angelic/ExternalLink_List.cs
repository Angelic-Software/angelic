using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ExternalLink_List
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("table_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Table_id { get; set; } 

    [JsonProperty("module_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Module_id { get; set; } 

    [JsonProperty("integration_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Integration_name { get; set; } 

    [JsonProperty("halo_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Halo_id { get; set; } 

    [JsonProperty("third_party_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Third_party_id { get; set; } 

    [JsonProperty("third_party_desc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Third_party_desc { get; set; } 

    [JsonProperty("third_party_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Third_party_type { get; set; } 

    [JsonProperty("third_party_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Third_party_url { get; set; } 

    [JsonProperty("third_party_assigned_to", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Third_party_assigned_to { get; set; } 

    [JsonProperty("third_party_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public long? Third_party_count { get; set; } 

    [JsonProperty("primary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Primary { get; set; } 

    [JsonProperty("halo_desc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Halo_desc { get; set; } 

    [JsonProperty("halo_second_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Halo_second_id { get; set; } 

    [JsonProperty("halo_second_desc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Halo_second_desc { get; set; } 

    [JsonProperty("extra_match_field", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Extra_match_field { get; set; } 

    [JsonProperty("details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Details_id { get; set; } 

    [JsonProperty("third_party_secondary_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Third_party_secondary_id { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

    [JsonProperty("third_party_status", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Third_party_status { get; set; } 

    [JsonProperty("third_party_priority", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Third_party_priority { get; set; } 

    [JsonProperty("_match", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _match { get; set; } 

    [JsonProperty("populate_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Populate_url { get; set; } 

    [JsonProperty("date_created", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Date_created { get; set; } 

    [JsonProperty("date_updated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Date_updated { get; set; } 

    [JsonProperty("subscription_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Subscription_id { get; set; } 

    [JsonProperty("new_subscription_key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? New_subscription_key { get; set; } 

    [JsonProperty("subscription_expiry", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Subscription_expiry { get; set; } 

    [JsonProperty("_webhookaction", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public WebhookSubscriptionAction? _webhookaction { get; set; } 

    [JsonProperty("revisions", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Revisions { get; set; } 

    [JsonProperty("dont_move_existing_assets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Dont_move_existing_assets { get; set; } 

    [JsonProperty("chat_message_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Chat_message_count { get; set; } 

    [JsonProperty("third_party_additional_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Third_party_additional_id { get; set; } 

}