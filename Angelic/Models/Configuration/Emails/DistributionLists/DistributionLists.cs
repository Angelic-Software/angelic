using System.CodeDom.Compiler;
using Angelic.Models.Configuration.Campaigns;
using Angelic.Models.ExternalLinks;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.Emails.DistributionLists;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class DistributionLists
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("desc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Desc { get; set; } 

    [JsonProperty("mailbox_from", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MailboxFrom { get; set; } 

    [JsonProperty("mailbox_replyto", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MailboxReplyTo { get; set; } 

    [JsonProperty("dynamic_members", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? DynamicMembers { get; set; } 

    [JsonProperty("users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Models.Users.User>? Users { get; set; } 

    [JsonProperty("members", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<DistributionListsUser>? Members { get; set; } 

    [JsonProperty("addtheseusers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Models.Users.User>? AddTheseUsers { get; set; } 

    [JsonProperty("removetheseusers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Models.Users.User>? RemoveTheseUsers { get; set; } 

    [JsonProperty("users_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? UsersCount { get; set; } 

    [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsImport { get; set; } 

    [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ImportType { get; set; } 

    [JsonProperty("mailbox_from_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MailboxFromAddress { get; set; } 

    [JsonProperty("new_external_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ExternalLink? NewExternalLink { get; set; } 

    [JsonProperty("_match_thirdparty_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MatchThirdPartyId { get; set; } 

    [JsonProperty("_match_integration_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MatchIntegrationId { get; set; } 

    [JsonProperty("_match_integration_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MatchIntegrationName { get; set; } 

    [JsonProperty("third_party_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ThirdPartyUrl { get; set; } 

    [JsonProperty("filters", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<DlFilterDetails>? Filters { get; set; } 

    [JsonProperty("linked_campaigns", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<MailCampaign>? LinkedCampaigns { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}