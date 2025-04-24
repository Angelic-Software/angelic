using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class StdRequestRule
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; } 

    [JsonProperty("parent_template_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Parent_template_id { get; set; } 

    [JsonProperty("child_template_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Child_template_id { get; set; } 

    [JsonProperty("usage", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Usage { get; set; } 

    [JsonProperty("rule_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Rule_type { get; set; } 

    [JsonProperty("createonchildclose_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Createonchildclose_id { get; set; } 

    [JsonProperty("createonchildclose_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Createonchildclose_name { get; set; } 

    [JsonProperty("working_days", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Working_days { get; set; } 

    [JsonProperty("outcome_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Outcome_id { get; set; } 

    [JsonProperty("outcome_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Outcome_name { get; set; } 

    [JsonProperty("field_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Field_id { get; set; } 

    [JsonProperty("field_value", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Field_value { get; set; } 

    [JsonProperty("field_value_string", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Field_value_string { get; set; } 

    [JsonProperty("field_contains", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Field_contains { get; set; } 

    [JsonProperty("field_name", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Field_name { get; set; } 

    [JsonProperty("approvalstatus", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Approvalstatus { get; set; } 

    [JsonProperty("group_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Group_id { get; set; } 

    [JsonProperty("optionalservice_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Optionalservice_id { get; set; } 

    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? _warning { get; set; } 

}