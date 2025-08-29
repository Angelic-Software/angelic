using System.CodeDom.Compiler;
using Angelic.Models.Configuration.Tickets.Templates;
using Newtonsoft.Json;

namespace Angelic.Models.Configuration.SelfServicePortal;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ServiceOption
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("service_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ServiceId { get; set; } 

    [JsonProperty("optional_service_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OptionalServiceId { get; set; } 

    [JsonProperty("optional_service_guid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public Guid? OptionalServiceGuid { get; set; } 

    [JsonProperty("optional_service_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OptionalServiceName { get; set; } 

    [JsonProperty("sequenceid", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? SequenceId { get; set; } 

    [JsonProperty("show_new_req_screen", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ShowNewReqScreen { get; set; } 

    [JsonProperty("mandatory", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Mandatory { get; set; } 

    [JsonProperty("default", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Default { get; set; } 

    [JsonProperty("expandeddefault", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? ExpandedDefault { get; set; } 

    [JsonProperty("include", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public bool? Include { get; set; } 

    [JsonProperty("servicerequestdetails_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ServiceRequestDetailsId { get; set; } 

    [JsonProperty("optional_parent_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? OptionalParentId { get; set; } 

    [JsonProperty("rule_count", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? RuleCount { get; set; } 

    [JsonProperty("creation_rules", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<TemplateRule>? CreationRules { get; set; } 

    [JsonProperty("optional_service_name_short", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? OptionalServiceNameShort { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; } 

}