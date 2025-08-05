using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Attachments;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class AttachmentList
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("filename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Filename { get; set; } 

    [JsonProperty("datecreated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? DateCreated { get; set; } 

    [JsonProperty("note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Note { get; set; } 

    [JsonProperty("filesize", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Filesize { get; set; } 

    [JsonProperty("type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Type { get; set; } 

    [JsonProperty("unique_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? UniqueId { get; set; } 

    [JsonProperty("desc", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Desc { get; set; } 

    [JsonProperty("isimage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsImage { get; set; } 

    [JsonProperty("showforusers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowForUsers { get; set; } 

    [JsonProperty("showonchild", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowOnChild { get; set; } 

    [JsonProperty("showonrelated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowOnRelated { get; set; } 

    [JsonProperty("data_base64", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DataBase64 { get; set; } 

    [JsonProperty("download_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DownloadUrl { get; set; } 

    [JsonProperty("third_party_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ThirdPartyToken { get; set; } 

    [JsonProperty("third_party_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ThirdPartyId { get; set; } 

    [JsonProperty("already_posted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AlreadyPosted { get; set; } 

    [JsonProperty("faultid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? FaultId { get; set; } 

    [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsImport { get; set; } 

    [JsonProperty("_importtype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ImportType { get; set; } 

    [JsonProperty("s3url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? S3Url { get; set; } 

    [JsonProperty("att_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? AttLink { get; set; } 

    [JsonProperty("child_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ChildCount { get; set; } 

    [JsonProperty("parent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ParentId { get; set; } 

    [JsonProperty("linked_version_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? LinkedVersionId { get; set; } 

    [JsonProperty("allow_anon_upload", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowAnonUpload { get; set; } 

    [JsonProperty("tickettype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TicketTypeId { get; set; } 

    [JsonProperty("tickettype_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? TicketTypeGuid { get; set; } 

    [JsonProperty("validate_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ValidateGuid { get; set; } 

}