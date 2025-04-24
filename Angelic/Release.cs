using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class Release
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name { get; set; } 

    [JsonProperty("name_expanded", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Name_expanded { get; set; } 

    [JsonProperty("releasetype_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Releasetype_id { get; set; } 

    [JsonProperty("releasetype_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Releasetype_name { get; set; } 

    [JsonProperty("branch_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Branch_id { get; set; } 

    [JsonProperty("branch_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Branch_name { get; set; } 

    [JsonProperty("whoreleased_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Whoreleased_id { get; set; } 

    [JsonProperty("builddate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Builddate { get; set; } 

    [JsonProperty("releasedate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Releasedate { get; set; } 

    [JsonProperty("note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Note { get; set; } 

    [JsonProperty("public_note", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Public_note { get; set; } 

    [JsonProperty("product_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Product_id { get; set; } 

    [JsonProperty("product_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Product_name { get; set; } 

    [JsonProperty("product_icon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Product_icon { get; set; } 

    [JsonProperty("sequence", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sequence { get; set; } 

    [JsonProperty("major_version_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Major_version_number { get; set; } 

    [JsonProperty("minor_version_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Minor_version_number { get; set; } 

    [JsonProperty("patch_version_number", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Patch_version_number { get; set; } 

    [JsonProperty("releasenote_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Releasenote_count { get; set; } 

    [JsonProperty("release1_emaildate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Release1_emaildate { get; set; } 

    [JsonProperty("release2_emaildate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Release2_emaildate { get; set; } 

    [JsonProperty("release3_emaildate", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public DateTimeOffset? Release3_emaildate { get; set; } 

    [JsonProperty("send_release1_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Send_release1_email { get; set; } 

    [JsonProperty("send_release2_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Send_release2_email { get; set; } 

    [JsonProperty("send_release3_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Send_release3_email { get; set; } 

    [JsonProperty("preview_release_email", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Preview_release_email { get; set; } 

    [JsonProperty("release_email_subject", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Release_email_subject { get; set; } 

    [JsonProperty("release_email_html", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Release_email_html { get; set; } 

    [JsonProperty("release_email_tickets", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<int>? Release_email_tickets { get; set; } 

    [JsonProperty("releasetype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ReleaseType? Releasetype { get; set; } 

    [JsonProperty("instance_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Instance_count { get; set; } 

    [JsonProperty("total_instance_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Total_instance_count { get; set; } 

    [JsonProperty("adoption", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? Adoption { get; set; } 

    [JsonProperty("issues_logged", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Issues_logged { get; set; } 

    [JsonProperty("open_issues", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Open_issues { get; set; } 

    [JsonProperty("licences", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<LicenceInfo>? Licences { get; set; } 

    [JsonProperty("jira_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Jira_name { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

}