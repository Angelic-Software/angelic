using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Attachments;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record PresignedUrlRequest
{
    [JsonProperty("filename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Filename { get; set; } 

    [JsonProperty("filesize", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public long? Filesize { get; set; } 

    [JsonProperty("_tempid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? TempId { get; set; } 

    [JsonProperty("originalfilename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OriginalFileName { get; set; } 

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Type { get; set; } 

    [JsonProperty("unique_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? UniqueId { get; set; } 

    [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TicketId { get; set; } 

    [JsonProperty("atfilename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AtFileName { get; set; } 

    [JsonProperty("atdesc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AtDesc { get; set; } 

    [JsonProperty("atparentid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AtParentId { get; set; } 

    [JsonProperty("atlinkedversionid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AtLinkedVersionId { get; set; } 

    [JsonProperty("atnote", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AtNote { get; set; } 

    [JsonProperty("allow_anon_upload", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowAnonUpload { get; set; } 

    [JsonProperty("tickettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TicketTypeId { get; set; } 

    [JsonProperty("tickettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TicketTypeGuid { get; set; } 

}