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
    public int? Servicedetail_servsiteid { get; set; } 

    [JsonProperty("servicedetail_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Servicedetail_type { get; set; } 

    [JsonProperty("servicedetail_requesttypeid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Servicedetail_requesttypeid { get; set; } 

    [JsonProperty("servicedetail_requesttypeguid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Servicedetail_requesttypeguid { get; set; } 

    [JsonProperty("servicedetail_requesttypename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Servicedetail_requesttypename { get; set; } 

    [JsonProperty("servicedetail_templateid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Servicedetail_templateid { get; set; } 

    [JsonProperty("servicedetail_templateguid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? Servicedetail_templateguid { get; set; } 

    [JsonProperty("servicedetail_templatename", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Servicedetail_templatename { get; set; } 

    [JsonProperty("servicedetail_url", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Servicedetail_url { get; set; } 

    [JsonProperty("servicedetail_label", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Servicedetail_label { get; set; } 

    [JsonProperty("servicedetail_hint", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Servicedetail_hint { get; set; } 

    [JsonProperty("servicedetail_shownewreqscreen", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Servicedetail_shownewreqscreen { get; set; } 

    [JsonProperty("optional_services", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ServiceOption>? Optional_services { get; set; } 

    [JsonProperty("sequenceid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Sequenceid { get; set; } 

    [JsonProperty("servicedetail_longname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Servicedetail_longname { get; set; } 

    [JsonProperty("allow_all_items", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Allow_all_items { get; set; } 

    [JsonProperty("allowed_items", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ItemRestriction>? Allowed_items { get; set; } 

    [JsonProperty("translations", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<LanguagePackTranslationsCustom>? Translations { get; set; } 

    [JsonProperty("show_submission_summary", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Show_submission_summary { get; set; } 

}