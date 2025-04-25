using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Attachments;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Attachment
{
    [JsonProperty("third_party_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ThirdPartyId { get; set; } 

    [JsonProperty("link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Link { get; set; } 

    [JsonProperty("content_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ContentType { get; set; } 

    [JsonProperty("last_updated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? LastUpdated { get; set; } 

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("filename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Filename { get; set; } 

    [JsonProperty("datecreated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Datecreated { get; set; } 

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
    public bool? Isimage { get; set; } 

    [JsonProperty("data", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public byte[]? Data { get; set; } 

    [JsonProperty("ticket_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TicketId { get; set; } 

    [JsonProperty("action_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ActionId { get; set; } 

    [JsonProperty("user_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? UserId { get; set; } 

    [JsonProperty("agent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AgentId { get; set; } 

    [JsonProperty("attachmentaction_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AttachmentactionId { get; set; } 

    [JsonProperty("_canupdate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? CanUpdate { get; set; } 

    [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Guid { get; set; } 

    [JsonProperty("image_upload_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ImageUploadId { get; set; } 

    [JsonProperty("image_upload_key", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ImageUploadKey { get; set; } 

    [JsonProperty("file", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public byte[]? File { get; set; } 

    [JsonProperty("_enduserportalpdfprint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Enduserportalpdfprint { get; set; } 

    [JsonProperty("anon_outcomeid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? AnonOutcomeid { get; set; } 

    [JsonProperty("has_scanned", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? HasScanned { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

    [JsonProperty("_is_new_version", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? IsNewVersion { get; set; } 

    [JsonProperty("parent_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ParentName { get; set; } 

    [JsonProperty("version_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? VersionCount { get; set; } 

    [JsonProperty("_alreadyuploaded", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Alreadyuploaded { get; set; } 

    [JsonProperty("copy_from_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? CopyFromId { get; set; } 

    [JsonProperty("new_external_link", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ExternalLinkList? NewExternalLink { get; set; } 

    [JsonProperty("_match_thirdparty_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MatchThirdpartyId { get; set; } 

    [JsonProperty("_match_integration_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MatchIntegrationId { get; set; } 

    [JsonProperty("_match_integration_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? MatchIntegrationName { get; set; } 

    [JsonProperty("import_details_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ImportDetailsId { get; set; } 

    [JsonProperty("external_links", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ExternalLinkList>? ExternalLinks { get; set; } 

    [JsonProperty("showforusers", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowForusers { get; set; } 

    [JsonProperty("showonchild", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowOnchild { get; set; } 

    [JsonProperty("showonrelated", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowOnrelated { get; set; } 

    [JsonProperty("data_base64", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DataBase64 { get; set; } 

    [JsonProperty("download_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DownloadUrl { get; set; } 

    [JsonProperty("third_party_token", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ThirdPartyToken { get; set; } 

    [JsonProperty("already_posted", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AlreadyPosted { get; set; } 

    [JsonProperty("faultid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Faultid { get; set; } 

    [JsonProperty("_isimport", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Isimport { get; set; } 

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