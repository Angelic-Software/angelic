using System.CodeDom.Compiler;
using Angelic.Models.Configuration.Approval;
using Angelic.Models.Configuration.Approval.Cab;
using Newtonsoft.Json;

namespace Angelic.Models;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class CabHeader
{
    [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Guid { get; set; } 

    [JsonProperty("intent", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Intent { get; set; } 

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("all_must_approve", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllMustApprove { get; set; } 

    [JsonProperty("approvals_needed", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ApprovalsNeeded { get; set; } 

    [JsonProperty("rejection_threshold", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RejectionThreshold { get; set; } 

    [JsonProperty("members", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CabMember>? Members { get; set; } 

    [JsonProperty("ldapstring", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Ldapstring { get; set; } 

    [JsonProperty("roles", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<CabRole>? Roles { get; set; } 

    [JsonProperty("teams_webhook_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TeamsWebhookUrl { get; set; } 

    [JsonProperty("slack_channel", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SlackChannel { get; set; } 

    [JsonProperty("slack_channel_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? SlackChannelName { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}