using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.SoftwareReleases;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Release
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("name_expanded", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? NameExpanded { get; set; } 

    [JsonProperty("releasetype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ReleaseTypeId { get; set; } 

    [JsonProperty("releasetype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ReleaseTypeName { get; set; } 

    [JsonProperty("branch_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? BranchId { get; set; } 

    [JsonProperty("branch_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? BranchName { get; set; } 

    [JsonProperty("whoreleased_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? WhoReleasedId { get; set; } 

    [JsonProperty("builddate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? BuildDate { get; set; } 

    [JsonProperty("releasedate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? ReleaseDate { get; set; } 

    [JsonProperty("note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Note { get; set; } 

    [JsonProperty("public_note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? PublicNote { get; set; } 

    [JsonProperty("product_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ProductId { get; set; } 

    [JsonProperty("product_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ProductName { get; set; } 

    [JsonProperty("product_icon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ProductIcon { get; set; } 

    [JsonProperty("sequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sequence { get; set; } 

    [JsonProperty("major_version_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MajorVersionNumber { get; set; } 

    [JsonProperty("minor_version_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? MinorVersionNumber { get; set; } 

    [JsonProperty("patch_version_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? PatchVersionNumber { get; set; } 

    [JsonProperty("releasenote_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ReleaseNoteCount { get; set; } 

    [JsonProperty("release1_emaildate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Release1EmailDate { get; set; } 

    [JsonProperty("release2_emaildate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Release2EmailDate { get; set; } 

    [JsonProperty("release3_emaildate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Release3EmailDate { get; set; } 

    [JsonProperty("send_release1_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? SendRelease1Email { get; set; } 

    [JsonProperty("send_release2_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? SendRelease2Email { get; set; } 

    [JsonProperty("send_release3_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? SendRelease3Email { get; set; } 

    [JsonProperty("preview_release_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? PreviewReleaseEmail { get; set; } 

    [JsonProperty("release_email_subject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ReleaseEmailSubject { get; set; } 

    [JsonProperty("release_email_html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ReleaseEmailHtml { get; set; } 

    [JsonProperty("release_email_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<int>? ReleaseEmailTickets { get; set; } 

    [JsonProperty("releasetype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ReleaseType? ReleaseType { get; set; } 

    [JsonProperty("instance_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? InstanceCount { get; set; } 

    [JsonProperty("total_instance_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? TotalInstanceCount { get; set; } 

    [JsonProperty("adoption", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Adoption { get; set; } 

    [JsonProperty("issues_logged", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? IssuesLogged { get; set; } 

    [JsonProperty("open_issues", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OpenIssues { get; set; } 

    [JsonProperty("licences", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<LicenceInfo>? Licences { get; set; } 

    [JsonProperty("jira_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? JiraName { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}