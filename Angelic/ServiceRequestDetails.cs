using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ServiceRequestDetails
{
    [JsonProperty("icon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Icon { get; set; } 

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Guid { get; set; } 

    [JsonProperty("servicedetail_servsiteid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ServicedetailServsiteid { get; set; } 

    [JsonProperty("servicedetail_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ServicedetailType { get; set; } 

    [JsonProperty("servicedetail_requesttypeid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ServicedetailRequesttypeid { get; set; } 

    [JsonProperty("servicedetail_requesttypeguid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? ServicedetailRequesttypeguid { get; set; } 

    [JsonProperty("servicedetail_requesttypename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ServicedetailRequesttypename { get; set; } 

    [JsonProperty("servicedetail_templateid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ServicedetailTemplateid { get; set; } 

    [JsonProperty("servicedetail_templateguid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? ServicedetailTemplateguid { get; set; } 

    [JsonProperty("servicedetail_templatename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ServicedetailTemplatename { get; set; } 

    [JsonProperty("servicedetail_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ServicedetailUrl { get; set; } 

    [JsonProperty("servicedetail_label", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ServicedetailLabel { get; set; } 

    [JsonProperty("servicedetail_hint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ServicedetailHint { get; set; } 

    [JsonProperty("servicedetail_shownewreqscreen", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ServicedetailShownewreqscreen { get; set; } 

    [JsonProperty("optional_services", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ServiceOption>? OptionalServices { get; set; } 

    [JsonProperty("sequenceid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sequenceid { get; set; } 

    [JsonProperty("servicedetail_longname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ServicedetailLongname { get; set; } 

    [JsonProperty("allow_all_items", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowAllItems { get; set; } 

    [JsonProperty("allowed_items", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ItemRestriction>? AllowedItems { get; set; } 

    [JsonProperty("translations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<LanguagePackTranslationsCustom>? Translations { get; set; } 

    [JsonProperty("show_submission_summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowSubmissionSummary { get; set; } 

}