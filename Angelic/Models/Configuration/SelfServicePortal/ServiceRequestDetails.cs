using System.CodeDom.Compiler;
using Angelic.Models.Configuration.Language;
using Angelic.Models.Items;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.SelfServicePortal;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public record ServiceRequestDetails
{
    [JsonProperty("icon", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Icon { get; set; } 

    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Guid { get; set; } 

    [JsonProperty("servicedetail_servsiteid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ServiceDetailServSiteId { get; set; } 

    [JsonProperty("servicedetail_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ServiceDetailType { get; set; } 

    [JsonProperty("servicedetail_requesttypeid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ServiceDetailRequestTypeId { get; set; } 

    [JsonProperty("servicedetail_requesttypeguid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? ServiceDetailRequestTypeGuid { get; set; } 

    [JsonProperty("servicedetail_requesttypename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ServiceDetailRequestTypename { get; set; } 

    [JsonProperty("servicedetail_templateid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ServiceDetailTemplateId { get; set; } 

    [JsonProperty("servicedetail_templateguid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? ServiceDetailTemplateGuid { get; set; } 

    [JsonProperty("servicedetail_templatename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ServiceDetailTemplateName { get; set; } 

    [JsonProperty("servicedetail_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ServiceDetailUrl { get; set; } 

    [JsonProperty("servicedetail_label", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ServiceDetailLabel { get; set; } 

    [JsonProperty("servicedetail_hint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ServiceDetailHint { get; set; } 

    [JsonProperty("servicedetail_shownewreqscreen", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ServiceDetailShowNewReqScreen { get; set; } 

    [JsonProperty("optional_services", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ServiceOption>? OptionalServices { get; set; } 

    [JsonProperty("sequenceid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SequenceId { get; set; } 

    [JsonProperty("servicedetail_longname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? ServiceDetailLongName { get; set; } 

    [JsonProperty("allow_all_items", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? AllowAllItems { get; set; } 

    [JsonProperty("allowed_items", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ItemRestriction>? AllowedItems { get; set; } 

    [JsonProperty("translations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<LanguagePackTranslationsCustom>? Translations { get; set; } 

    [JsonProperty("show_submission_summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowSubmissionSummary { get; set; } 

}