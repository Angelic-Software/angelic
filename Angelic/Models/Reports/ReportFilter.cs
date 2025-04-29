using System.CodeDom.Compiler;
using Newtonsoft.Json;

namespace Angelic.Models.Reports;

[GeneratedCode("NJsonSchema", "14.3.0.0 (NJsonSchema v11.2.0.0 (Newtonsoft.Json v13.0.0.0))")]
public class ReportFilter
{
    [JsonProperty("id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? Id { get; set; }
    
    [JsonProperty("report_id", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? ReportId { get; set; }
    
    [JsonProperty("fieldname", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? FieldName { get; set; }
    
    [JsonProperty("data_type", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DataType { get; set; }
    
    [JsonProperty("data_type_group", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? DataTypeGroup { get; set; }
    
    [JsonProperty("query", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Query { get; set; }
    
    [JsonProperty("numericruletype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? NumericRuleType { get; set; }
    
    [JsonProperty("numericvalue", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public double? NumericValue { get; set; }
    
    [JsonProperty("stringrulevalues", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public ICollection<ValueLabelIsNewKeyPair>? StringRuleValues { get; set; }
    
    [JsonProperty("stringruletext", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? StringRuleText { get; set; }
    
    [JsonProperty("stringruletype", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public int? StringRuleType { get; set; }
    
    [JsonProperty("_warning", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
    public string? Warning { get; set; }
}
