using System.CodeDom.Compiler;
using Angelic.KeyPairs;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class AttachmentView
{
    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Type { get; set; } 

    [JsonProperty("unique_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? UniqueId { get; set; } 

    [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TicketId { get; set; } 

    [JsonProperty("action_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ActionId { get; set; } 

    [JsonProperty("record_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RecordCount { get; set; } 

    [JsonProperty("attachments", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<AttachmentList>? Attachments { get; set; } 

    [JsonProperty("page_no", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PageNo { get; set; } 

    [JsonProperty("page_size", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PageSize { get; set; } 

    [JsonProperty("folders", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<LongIdNameKeyPair>? Folders { get; set; } 

}