using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

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
    public int? Mailbox_from { get; set; } 

    [JsonProperty("mailbox_replyto", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Mailbox_replyto { get; set; } 

    [JsonProperty("dynamic_members", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Dynamic_members { get; set; } 

    [JsonProperty("users", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Users>? Users { get; set; } 

    [JsonProperty("members", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<DistributionListsUser>? Members { get; set; } 

    [JsonProperty("addtheseusers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Users>? Addtheseusers { get; set; } 

    [JsonProperty("removetheseusers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<Users>? Removetheseusers { get; set; } 

    [JsonProperty("users_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Users_count { get; set; } 

    [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? _isimport { get; set; } 

    [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _importtype { get; set; } 

    [JsonProperty("mailbox_from_address", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Mailbox_from_address { get; set; } 

    [JsonProperty("new_external_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ExternalLink_List? New_external_link { get; set; } 

    [JsonProperty("_match_thirdparty_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _match_thirdparty_id { get; set; } 

    [JsonProperty("_match_integration_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? _match_integration_id { get; set; } 

    [JsonProperty("_match_integration_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _match_integration_name { get; set; } 

    [JsonProperty("third_party_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Third_party_url { get; set; } 

    [JsonProperty("filters", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<DlFilterDetails>? Filters { get; set; } 

    [JsonProperty("linked_campaigns", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<MailCampaign>? Linked_campaigns { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

}